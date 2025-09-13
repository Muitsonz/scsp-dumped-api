
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

// Namespace: PRISM.ResourceManagement
public enum DownloadCategory : System.Enum
{
    public int value__;
    public static PRISM.ResourceManagement.DownloadCategory Foreground;
    public static PRISM.ResourceManagement.DownloadCategory Background;
    public static PRISM.ResourceManagement.DownloadCategory Custom;
}

// Namespace: PRISM.ResourceManagement
public interface IDownloadEventHandler
{
    public void OnDownloadStart(PRISM.ResourceManagement.DownloadCategory category);
    public void OnDownloadProgress(PRISM.ResourceManagement.DownloadCategory category, long downloadedBytes, long totalDownloadBytes, long globalDownloadedBytes, long globalTotalDownloadBytes);
    public void OnDownloadFinish(PRISM.ResourceManagement.DownloadCategory category);
    public Cysharp.Threading.Tasks.UniTask OnDownloadError(Limelight.AssetDownloadError error);
}

// Namespace: PRISM.ResourceManagement
public interface IRawPathResolver
{
    public Cysharp.Threading.Tasks.UniTask<string> ResolveAsync(string key, bool lowercaseEnsured);
    public string Resolve(string key, bool lowercaseEnsured);
}

// Namespace: PRISM.ResourceManagement
public interface IRawResourceLoader
{
    public Cysharp.Threading.Tasks.UniTask<byte[]> LoadAsync(string key, System.Threading.CancellationToken cancellationToken);
    public byte[] UnsafeLoad(string key, bool lowercaseEnsured);
}

// Namespace: PRISM.ResourceManagement
public interface IResourceDownloader
{
    public System.IDisposable AddDownloadEventHandler(PRISM.ResourceManagement.IDownloadEventHandler handler);
    public Limelight.Downloader.IDownloadJobProvider GetDownloadContext(Limelight.IAssetRequest request);
    public string GetResourceVersionRequest();
    public Cysharp.Threading.Tasks.UniTask DownloadByGroupAsync(string group, bool isBackground, bool isPrepend);
    public Cysharp.Threading.Tasks.UniTask DownloadByContextAsync(PRISM.ResourceManagement.DownloadCategory category, Limelight.Downloader.IDownloadJobProvider context, bool isPrepend);
    public Cysharp.Threading.Tasks.UniTask DownloadByKeysAsync(System.Collections.Generic.IEnumerable<string> keys, bool isBackground, bool isPrepend);
    public System.IDisposable SuppressBackgroundDownloadWithUsing();
    public bool BrokenCatalogDatabaseDetected();
    public Cysharp.Threading.Tasks.UniTask RecoverCatalogDBAsync(System.Action<float, float> progressCallback);
    public bool IsDownloading(PRISM.ResourceManagement.DownloadCategory category);
}

// Namespace: PRISM.ResourceManagement
public interface IResourceLoader : System.IDisposable
{
    public Cysharp.Threading.Tasks.UniTask<T> LoadAsync<T>(string key, System.Threading.CancellationToken cancellationToken);
    public T UnsafeLoad<T>(string key);
}

// Namespace: PRISM.ResourceManagement
public interface IResourceLoaderContainer
{
    public PRISM.ResourceManagement.IResourceLoader NeverUnloadLoader { get; set; }
    public PRISM.ResourceManagement.IRawResourceLoader RawLoader { get; set; }
    public PRISM.ResourceManagement.IRawPathResolver RawPathResolver { get; set; }
    public PRISM.ResourceManagement.ISceneLoader SceneLoader { get; set; }
    public PRISM.ResourceManagement.IResourceLoader CreateScopedLoader(string name);
    public bool IsKeyExists(string key, bool lowercaseEnsured);
    public bool IsKeyExists(ulong crc);
    public Cysharp.Threading.Tasks.UniTask WipeoutLocalAssetCacheAsync();
}

// Namespace: PRISM.ResourceManagement
public interface ISceneLoader
{
    public Cysharp.Threading.Tasks.UniTask<UnityEngine.AsyncOperation> LoadAsync(string key, UnityEngine.SceneManagement.LoadSceneMode mode, bool lowercaseEnsured);
    public void Release(string key);
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=559 2B0715101DF6955564358F74FFB6E5073B423C1A386CA407DA03C721D8030252;
    private static __StaticArrayInitTypeSize=335 BFD6FBE7BDE2A5A901F56BC16C5ACD581DCE4BC49D04A97BAD367F80F80E10CD;

    private struct __StaticArrayInitTypeSize=335 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=559 : System.ValueType
    {
    }
}
