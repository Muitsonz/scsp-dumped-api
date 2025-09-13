
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

// Namespace: PRISM.Module.PRISMLogger
public interface ILoggerAnalysis
{
    public void Log(string message);
    public void LogException(System.Exception exception);
}

// Namespace: PRISM.Module.PRISMLogger
public class LoggerDevelop : PRISM.Definitions.Logger.PRISMLoggerBase, UnityEngine.ILogHandler
{
    private PRISM.Module.PRISMLogger.Formatter.IMessageFormatter formatter;
    private bool editorMode;
    private System.Collections.Generic.HashSet<Category> categoryFilter;
    private System.Collections.Generic.HashSet<Level> levelFilter;
    private PRISM.Module.PRISMLogger.ILoggerAnalysis analysis;
    private PRISM.Module.PRISMLogger.Logger.UnityLogHandlerWrapper <UnityLogger>k__BackingField;
    public PRISM.Module.PRISMLogger.Logger.UnityLogHandlerWrapper UnityLogger { get; set; }
    public System.Collections.Generic.IReadOnlyCollection<Category> FilteredCategories { get; set; }
    public System.Collections.Generic.IReadOnlyCollection<Level> FilteredLevels { get; set; }
    public void Message(Category category, Level level, string format, object[] args);
    public void ExceptionMessage(Category category, System.Exception exception, string format, object[] args);
    public void FilterWithCategories(System.Collections.Generic.IEnumerable<Category> categories);
    public void AssignLevelFilter(System.Collections.Generic.IEnumerable<Level> filteredLevels);
    private void UnityEngine.ILogHandler.LogFormat(UnityEngine.LogType logType, UnityEngine.Object context, string format, object[] args);
    private void UnityEngine.ILogHandler.LogException(System.Exception exception, UnityEngine.Object context);
    private bool _checkVisible(Category category, Level level);
    private void _output(Level level, string message, UnityEngine.Object context);
    private void _outputException(System.Exception exception, string message, UnityEngine.Object context);
}

// Namespace: PRISM.Module.PRISMLogger
public class LoggerInstaller
{
    private PRISM.Definitions.Logger.PRISMLoggerBase logger;
    private PRISM.Module.PRISMLogger.ILoggerAnalysis loggerAnalysis;
    public void Install(PRISM.Module.PRISMLogger.ILoggerAnalysis loggerAnalysis);
    public void Setup();
}

// Namespace: PRISM.Module.PRISMLogger
public class LoggerProduction : PRISM.Definitions.Logger.PRISMLoggerBase, UnityEngine.ILogHandler
{
    private PRISM.Module.PRISMLogger.Formatter.IMessageFormatter formatter;
    private PRISM.Module.PRISMLogger.ILoggerAnalysis loggerAnalysis;
    public void Message(Category category, Level level, string format, object[] args);
    public void ExceptionMessage(Category category, System.Exception exception, string format, object[] args);
    private void UnityEngine.ILogHandler.LogFormat(UnityEngine.LogType logType, UnityEngine.Object context, string format, object[] args);
    private void UnityEngine.ILogHandler.LogException(System.Exception exception, UnityEngine.Object context);
    private void _output(string message);
    private void _outputException(System.Exception exception);
}

// Namespace: PRISM.Module.PRISMLogger
private class LoggerSilent : PRISM.Definitions.Logger.PRISMLoggerBase, UnityEngine.ILogHandler
{
    public void Message(Category category, Level level, string format, object[] args);
    public void ExceptionMessage(Category category, System.Exception exception, string format, object[] args);
    public void LogFormat(UnityEngine.LogType logType, UnityEngine.Object context, string format, object[] args);
    public void LogException(System.Exception exception, UnityEngine.Object context);
}

// Namespace: PRISM.Module.PRISMLogger
public class LogLevelExtension
{
    public static UnityEngine.LogType ToUnity(Level value);
    public static Level ToPRISMLogger(UnityEngine.LogType value);
}

// Namespace: PRISM.Module.PRISMLogger.Logger
public class GleipnirLogger : Gleipnir.Logger.LoggerBase
{
    private PRISM.Definitions.Logger.CategorizedLogger logger;
    public void LogMessage(LogType logType, UnityEngine.Object context, string format, object[] values);
    public void Exception(System.Exception exception, UnityEngine.Object context);
    public void AnalysisMessage(string message);
}

// Namespace: PRISM.Module.PRISMLogger.Logger
public class LimelightLogger : Limelight.Logger.LoggerBase
{
    private PRISM.Definitions.Logger.CategorizedLogger logger;
    public void LogMessage(LogType logType, UnityEngine.Object context, string format, object[] values);
    public void Exception(System.Exception exception, UnityEngine.Object context);
    public void AnalysisMessage(string message);
}

// Namespace: PRISM.Module.PRISMLogger.Logger
public class UnityLogHandlerWrapper
{
    private static PRISM.Module.PRISMLogger.Logger.UnityLogHandlerWrapper instance;
    private UnityEngine.ILogHandler <BaseLogger>k__BackingField;
    public PRISM.Module.PRISMLogger.Logger.UnityLogHandlerWrapper Instance { get; set; }
    public UnityEngine.ILogHandler BaseLogger { get; set; }
    public void ExceptionMessage(System.Exception exception, string text, UnityEngine.Object context);
    public void Message(UnityEngine.LogType level, string text, UnityEngine.Object context);
}

// Namespace: PRISM.Module.PRISMLogger.Formatter
public class CategoryColorMapping : PRISM.Module.PRISMLogger.Formatter.ICategoryMapping, System.IDisposable
{
    private System.Security.Cryptography.MD5 md5;
    private System.Collections.Generic.Dictionary<Category, string> categoryMap;
    public string Get(Category category);
    public void Dispose();
    private UnityEngine.Color _calculateStringColor(string text);
}

// Namespace: PRISM.Module.PRISMLogger.Formatter
public class CategoryTextMapping : PRISM.Module.PRISMLogger.Formatter.ICategoryMapping, System.IDisposable
{
    private Cysharp.Text.Utf8PreparedFormat<Category> format;
    public void Dispose();
    public string Get(Category category);
}

// Namespace: PRISM.Module.PRISMLogger.Formatter
public interface ICategoryMapping : System.IDisposable
{
    public string Get(Category category);
}

// Namespace: PRISM.Module.PRISMLogger.Formatter
public interface IMessageFormatter
{
    public string ConvertMessage(Category category, Level level, string format, object[] args);
}

// Namespace: PRISM.Module.PRISMLogger.Formatter
public class MessageFormatter : PRISM.Module.PRISMLogger.Formatter.IMessageFormatter, System.IDisposable
{
    private PRISM.Module.PRISMLogger.Formatter.ICategoryMapping mapping;
    private Cysharp.Text.Utf8PreparedFormat<int, string, string> messageFormatter;
    private Cysharp.Text.Utf8PreparedFormat<string, string> threadPoolMessageFormatter;
    public string ConvertMessage(Category category, Level level, string format, object[] args);
    public void Dispose();
    private string _formatBaseText(string format, object[] args);
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=1138 DE5C044F02BF4F34CD430184CC23A6532D7E3E996FF84E89EB31A61B2520CDF9;
    private static __StaticArrayInitTypeSize=718 F362478BAFBC42FEEA8CA366E9F324B111BE1704CDE9744153668C846FD437A4;

    private struct __StaticArrayInitTypeSize=718 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=1138 : System.ValueType
    {
    }
}
