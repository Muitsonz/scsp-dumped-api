using System.Text;
using Mono.Cecil;
using static System.Console;

namespace ScspLocalifyTools;

public static class AssemblyToSymbols
{
    static readonly Dictionary<string, string> KeywordMap = new()
    {
        ["System.Void"] = "void",
        ["System.Boolean"] = "bool",
        ["System.Byte"] = "byte",
        ["System.SByte"] = "sbyte",
        ["System.Char"] = "char",
        ["System.Decimal"] = "decimal",
        ["System.Double"] = "double",
        ["System.Single"] = "float",
        ["System.Int32"] = "int",
        ["System.UInt32"] = "uint",
        ["System.Int64"] = "long",
        ["System.UInt64"] = "ulong",
        ["System.Int16"] = "short",
        ["System.UInt16"] = "ushort",
        ["System.Object"] = "object",
        ["System.String"] = "string"
    };

    public static void DumpType(StringBuilder sb, TypeDefinition type, string indent)
    {
        using var writer = new StringWriter(sb);

        if (!string.IsNullOrEmpty(type.Namespace))
            writer.WriteLine($"// Namespace: {type.Namespace}");

        writer.Write($"{indent}{GetTypeModifiers(type)}{GetKind(type)} {type.Name}{RenderGenericParameters(type.GenericParameters)}");
        var heritage = new[] { type.BaseType }.Where(t => t != null && t.FullName != "System.Object")
                      .Concat(type.Interfaces.Select(i => i.InterfaceType))
                      .Select(RenderType)
                      .ToArray();
        if (heritage.Length > 0)
            writer.Write($" : {string.Join(", ", heritage)}");

        writer.WriteLine();
        writer.WriteLine($"{indent}{{");

        foreach (var f in type.Fields)
            writer.WriteLine($"{indent}    {GetVisibility((MethodAttributes)f.Attributes)}{(f.IsStatic ? "static " : "")}{RenderType(f.FieldType)} {f.Name};");

        foreach (var p in type.Properties)
            writer.WriteLine($"{indent}    {GetVisibility(p.GetMethod?.Attributes ?? p.SetMethod.Attributes)}{RenderType(p.PropertyType)} {p.Name} {{ get; set; }}");

        foreach (var e in type.Events)
            writer.WriteLine($"{indent}    {GetVisibility(e.AddMethod.Attributes)}event {RenderType(e.EventType)} {e.Name};");

        foreach (var m in type.Methods.Where(m => !m.IsGetter && !m.IsSetter && !m.IsConstructor))
        {
            var vis = GetVisibility(m.Attributes);
            var stat = m.IsStatic ? "static " : "";
            var ret = RenderType(m.ReturnType);
            var gens = RenderGenericParameters(m.GenericParameters);
            var parms = string.Join(", ", m.Parameters.Select(p => $"{RenderType(p.ParameterType)} {p.Name}"));

            writer.WriteLine($"{indent}    {vis}{stat}{ret} {m.Name}{gens}({parms});");
        }

        foreach (var nested in type.NestedTypes)
        {
            writer.WriteLine();
            DumpType(sb, nested, indent + "    ");
        }

        writer.WriteLine($"{indent}}}");
    }

    static string GetKind(TypeDefinition t)
        => t.IsInterface ? "interface"
         : t.IsEnum ? "enum"
         : t.IsValueType ? "struct"
         : "class";

    static string GetTypeModifiers(TypeDefinition t)
    {
        if (t.IsPublic || t.IsNestedPublic) return "public ";
        if (t.IsNestedFamily) return "protected ";
        if (t.IsNotPublic || t.IsNestedPrivate) return "private ";
        return "";
    }

    static string GetVisibility(MethodAttributes attrs)
        => attrs.HasFlag(MethodAttributes.Public) ? "public "
         : attrs.HasFlag(MethodAttributes.Family) ? "protected "
         : attrs.HasFlag(MethodAttributes.Private) ? "private "
         : "";

    static string RenderGenericParameters(Mono.Collections.Generic.Collection<GenericParameter> genParams)
    {
        return genParams.Count == 0
            ? ""
            : "<" + string.Join(", ", genParams.Select(g => g.Name)) + ">";
    }

    static string RenderType(TypeReference tr)
    {
        switch (tr)
        {
        case GenericInstanceType git:
            var name = RenderType(git.ElementType);
            var args = string.Join(", ", git.GenericArguments.Select(RenderType));
            return $"{name}<{args}>";

        case ArrayType at:
            return $"{RenderType(at.ElementType)}[{new string(',', at.Rank - 1)}]";

        case ByReferenceType br:
            return $"{RenderType(br.ElementType)}&";

        case GenericParameter gp:
            return gp.Name;

        default:
            var full = tr.Namespace.Length > 0
                     ? $"{tr.Namespace}.{StripGenericArity(tr.Name)}"
                     : StripGenericArity(tr.Name);
            return KeywordMap.TryGetValue(tr.FullName, out var kw) ? kw : full;
        }
    }

    static string StripGenericArity(string name)
    {
        var idx = name.IndexOf('`');
        return idx >= 0 ? name.Substring(0, idx) : name;
    }



    public static void Run(string inputDirectory, string outputDirectory)
    {
        foreach (var file in Directory.GetFiles(inputDirectory))
        {
            if (!Path.GetExtension(file).Equals(".dll", StringComparison.CurrentCultureIgnoreCase))
                continue;
            if (!Path.GetFileName(file).StartsWith("PRISM"))
                continue;

            WriteLine(file);
            var assembly = AssemblyDefinition.ReadAssembly(file);
            var sb = new StringBuilder();
            foreach (var module in assembly.Modules)
            {
                foreach (var type in module.Types)
                {
                    sb.AppendLine();
                    DumpType(sb, type, "");
                }

            }
            File.WriteAllText(
                Path.Combine(outputDirectory, Path.GetFileNameWithoutExtension(file) + ".cs"),
                sb.ToString()
            );
        }
    }
}