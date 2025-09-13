
private class <Module>
{
}

private class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    private static MonoScriptData Get();

    private struct MonoScriptData : System.ValueType
    {
        public byte[] FilePathsData;
        public byte[] TypesData;
        public int TotalTypes;
        public int TotalFiles;
        public bool IsEditorOnly;
    }
}

// Namespace: PRISM.Module.AppTrackingTransparency
public class AppTrackingTransparencyFactory
{
    public static PRISM.Module.AppTrackingTransparency.IAppTrackingTransparency Create();
}

// Namespace: PRISM.Module.AppTrackingTransparency
public interface IAppTrackingTransparency
{
    public int GetAttStatus();
    public Cysharp.Threading.Tasks.UniTask<int> RequestTrackingAsync();
}

// Namespace: PRISM.Module.AppTrackingTransparency
public class NoAppTrackingTransparency : PRISM.Module.AppTrackingTransparency.IAppTrackingTransparency
{
    public int GetAttStatus();
    public Cysharp.Threading.Tasks.UniTask<int> RequestTrackingAsync();
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=295 032E873161F8C6FB45881B3161D7A7B4EA159174DCA885B8F830673AAF06D52D;
    private static __StaticArrayInitTypeSize=205 9DACD21F8E71AD3C03B6580B90650F14F4B635C492F1B3DDF6A23DB744E34E41;

    private struct __StaticArrayInitTypeSize=205 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=295 : System.ValueType
    {
    }
}
