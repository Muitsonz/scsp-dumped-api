
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

// Namespace: PRISM
private class GlobalSetting
{
    public static string LocalMetadataRootName;
    public static string LocalAssetsRootName;
    public static string LocalBackupRootName;
    public static string MetadataRoot;
    public static string DownloadDataRoot;
    public static string BackupRoot;
    public static string TemporaryDataRoot;
    private static string _getAppExclusiveName(string key);
}

// Namespace: PRISM
public class Global : System.IDisposable
{
    private static PRISM.Global instance;
    private bool initialized;
    private System.Threading.CancellationTokenSource cancelSource;
    private UniRx.CompositeDisposable subscribes;
    private Limelight.LimelightCore core;
    private bool <SaveDataWasBroken>k__BackingField;
    private bool <PermanentDataWasBroken>k__BackingField;
    private static bool <FirstTimeBoot>k__BackingField;
    private PRISM.ResourceManagement.ResourceLoaderContainer <Resources>k__BackingField;
    private PRISM.ResourceManagement.ResourceDownloader <Downloader>k__BackingField;
    private Gleipnir.Savedata.SavedataDB permanentData;
    private Gleipnir.Savedata.SavedataDB userSaveData;
    public PRISM.Global Instance { get; set; }
    public bool IsInitialized { get; set; }
    public System.Threading.CancellationToken CancellationToken { get; set; }
    public bool CatalogWasBroken { get; set; }
    public bool SaveDataWasBroken { get; set; }
    public bool PermanentDataWasBroken { get; set; }
    public bool FirstTimeBoot { get; set; }
    public PRISM.ResourceManagement.ResourceLoaderContainer Resources { get; set; }
    public PRISM.ResourceManagement.ResourceDownloader Downloader { get; set; }
    public string CurrentResourceVersion { get; set; }
    public string ServerResourceVersion { get; set; }
    public string ResourceVersionRequest { get; set; }
    private void OnApplicationPause(bool isPause);
    private void OnApplicationQuit();
    public static void SystemInit(string dmmGamesViewerId);
    private void _init(string dmmGamesViewerId);
    private void _initializePermanentData(string target);
    private Gleipnir.Savedata.SavedataDB _revertFromBackup(Limelight.StorageLocationProvider location, Gleipnir.Savedata.StorageBackup backup, string fileName);
    private void _systemReset();
    private void _teardown(bool quitting);
    public void Dispose();
    public static void SystemReset();
    public void ProcessServerResourceVersion(string version);
    public T CreateSaveData<T>(string scope, bool isPermanent);
    public void ClearUserSaveData(string dmmGamesViewerId);
    private void _initializeUserSaveData(string dmmGamesViewerId);
    private void <_init>b__38_0(UniRx.Unit _);

    private class MetadataLocationProvider : Limelight.IMetadataLocationProvider
    {
        private System.ValueTuple<string, byte[]> Limelight.IMetadataLocationProvider.GetLocation(string id);
    }
}

// Namespace: PRISM.ResourceManagement
public class ResourceDownloader : PRISM.ResourceManagement.IResourceDownloader, System.IDisposable
{
    private Limelight.LimelightCore core;
    private System.Collections.Generic.Dictionary<PRISM.ResourceManagement.DownloadCategory, long> progressForCategory;
    private System.Collections.Generic.Dictionary<PRISM.ResourceManagement.DownloadCategory, long> totalForCategory;
    private System.Collections.Generic.Dictionary<PRISM.ResourceManagement.DownloadCategory, System.Collections.Generic.HashSet<Limelight.Downloader.IDownloadJobProvider>> runningDownloads;
    private System.Collections.Generic.HashSet<PRISM.ResourceManagement.IDownloadEventHandler> handlers;
    public System.IDisposable AddDownloadEventHandler(PRISM.ResourceManagement.IDownloadEventHandler handler);
    public Limelight.Downloader.IDownloadJobProvider GetDownloadContext(Limelight.IAssetRequest request);
    public long GetDownloadSize(System.Collections.Generic.IEnumerable<string> keys);
    public string GetResourceVersionRequest();
    public Cysharp.Threading.Tasks.UniTask DownloadByGroupAsync(string group, bool isBackground, bool isPrepend);
    public Cysharp.Threading.Tasks.UniTask ResolvePendingDownloadErrors(System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask DownloadByContextAsync(PRISM.ResourceManagement.DownloadCategory category, Limelight.Downloader.IDownloadJobProvider context, bool isPrepend);
    private Cysharp.Threading.Tasks.UniTask _downloadByContextAsync(PRISM.ResourceManagement.DownloadCategory category, Limelight.Downloader.IDownloadJobProvider context, bool isPrepend);
    private Cysharp.Threading.Tasks.UniTask _watchMergedDownloadJobsAsync(PRISM.ResourceManagement.DownloadCategory category, System.Collections.Generic.HashSet<Limelight.Downloader.IDownloadJobProvider> contexts, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask DownloadByKeysAsync(System.Collections.Generic.IEnumerable<string> keys, bool isBackground, bool isPrepend);
    private Cysharp.Threading.Tasks.UniTask _downloadAsync(Limelight.IAssetRequest request, bool isBackground, bool isPrepend);
    private long _getDownloadSize(Limelight.IAssetRequest request);
    public System.IDisposable SuppressBackgroundDownloadWithUsing();
    public System.IDisposable TryPauseDownloadWithUsing();
    public Cysharp.Threading.Tasks.UniTask SynchronizeCatalog(System.Action<float, float> progressCallback);
    public bool BrokenCatalogDatabaseDetected();
    public Cysharp.Threading.Tasks.UniTask RecoverCatalogDBAsync(System.Action<float, float> progressCallback);
    public bool IsDownloading(PRISM.ResourceManagement.DownloadCategory category);
    private void _clearWorkItems();
    public void SoftReset();
    public void Dispose();
    private Cysharp.Threading.Tasks.UniTask <_downloadByContextAsync>b__13_0(Limelight.AssetDownloadError error);
    private bool <DownloadByKeysAsync>b__15_0(string key);
    private Cysharp.Threading.Tasks.UniTask <SynchronizeCatalog>b__20_0(Limelight.AssetDownloadError error);

    private struct <<SynchronizeCatalog>b__20_0>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.ResourceManagement.ResourceDownloader <>4__this;
        public Limelight.AssetDownloadError error;
        private Enumerator<PRISM.ResourceManagement.IDownloadEventHandler> <>7__wrap1;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <<_downloadByContextAsync>b__13_0>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.ResourceManagement.ResourceDownloader <>4__this;
        public Limelight.AssetDownloadError error;
        private Enumerator<PRISM.ResourceManagement.IDownloadEventHandler> <>7__wrap1;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private class <>c
    {
        public static <>c <>9;
        public static System.Predicate<Limelight.Downloader.IDownloadJobProvider> <>9__14_0;
        private bool <_watchMergedDownloadJobsAsync>b__14_0(Limelight.Downloader.IDownloadJobProvider runningContext);
    }

    private class <>c__DisplayClass6_0
    {
        public PRISM.ResourceManagement.ResourceDownloader <>4__this;
        public PRISM.ResourceManagement.IDownloadEventHandler handler;
        private void <AddDownloadEventHandler>b__0();
    }

    private struct <SynchronizeCatalog>d__20 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.ResourceManagement.ResourceDownloader <>4__this;
        public System.Action<float, float> progressCallback;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_downloadAsync>d__16 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.ResourceManagement.ResourceDownloader <>4__this;
        public Limelight.IAssetRequest request;
        public bool isBackground;
        public bool isPrepend;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_downloadByContextAsync>d__13 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public Limelight.Downloader.IDownloadJobProvider context;
        public PRISM.ResourceManagement.ResourceDownloader <>4__this;
        public PRISM.ResourceManagement.DownloadCategory category;
        public bool isPrepend;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_watchMergedDownloadJobsAsync>d__14 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public System.Collections.Generic.HashSet<Limelight.Downloader.IDownloadJobProvider> contexts;
        public PRISM.ResourceManagement.ResourceDownloader <>4__this;
        public PRISM.ResourceManagement.DownloadCategory category;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.ResourceManagement
public class ObjectResourceLoader : PRISM.ResourceManagement.IResourceLoader, System.IDisposable
{
    private System.Collections.Generic.HashSet<ulong> loadingKeys;
    private System.Collections.Generic.Dictionary<ulong, UnityEngine.Object> objectCache;
    private PRISM.ResourceManagement.ResourceLoaderContainer core;
    public Cysharp.Threading.Tasks.UniTask<T> LoadAsync<T>(string key, System.Threading.CancellationToken cancellationToken);
    public T UnsafeLoad<T>(string key);
    private bool _isLoading(ulong crc);
    private void _setCache(ulong cacheKey, UnityEngine.Object obj);
    public void Dispose();

    private class <>c__DisplayClass4_0`1<T>
    {
        public PRISM.ResourceManagement.ObjectResourceLoader <>4__this;
        public ulong crc;
        private bool <LoadAsync>b__0();
    }

    private struct <LoadAsync>d__4`1<T> : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<T> <>t__builder;
        public PRISM.ResourceManagement.ObjectResourceLoader <>4__this;
        public string key;
        public System.Threading.CancellationToken cancellationToken;
        private <>c__DisplayClass4_0<T> <>8__1;
        private Awaiter <>u__1;
        private Awaiter<T> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.ResourceManagement
public class RawPathResolver : PRISM.ResourceManagement.IRawPathResolver
{
    private PRISM.ResourceManagement.ResourceLoaderContainer core;
    public Cysharp.Threading.Tasks.UniTask<string> ResolveAsync(string key, bool lowercaseEnsured);
    public string Resolve(string key, bool lowercaseEnsured);
    private string _resolve(string key, ulong crc);

    private struct <ResolveAsync>d__2 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<string> <>t__builder;
        public string key;
        public bool lowercaseEnsured;
        public PRISM.ResourceManagement.RawPathResolver <>4__this;
        private ulong <crc>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.ResourceManagement
public class RawResourceLoader : PRISM.ResourceManagement.IRawResourceLoader
{
    private PRISM.ResourceManagement.ResourceLoaderContainer core;
    public Cysharp.Threading.Tasks.UniTask<byte[]> LoadAsync(string key, System.Threading.CancellationToken cancellationToken);
    public byte[] UnsafeLoad(string key, bool lowercaseEnsured);
    private byte[] _normalizeRawTextIfNecessary(ulong crc, byte[] bytes);

    private struct <LoadAsync>d__2 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<byte[]> <>t__builder;
        public string key;
        public PRISM.ResourceManagement.RawResourceLoader <>4__this;
        public System.Threading.CancellationToken cancellationToken;
        private ulong <crc>5__2;
        private Awaiter <>u__1;
        private Awaiter<byte[]> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.ResourceManagement
public class ResourceLoaderContainer : PRISM.ResourceManagement.IResourceLoaderContainer
{
    private Limelight.LimelightCore limelight;
    private PRISM.ResourceManagement.ResourceDownloader downloader;
    private System.Collections.Generic.Dictionary<PRISM.ResourceManagement.ObjectResourceLoader, string> objectResourceLoaders;
    private PRISM.ResourceManagement.IResourceLoader <NeverUnloadLoader>k__BackingField;
    private PRISM.ResourceManagement.IRawResourceLoader <RawLoader>k__BackingField;
    private PRISM.ResourceManagement.IRawPathResolver <RawPathResolver>k__BackingField;
    private PRISM.ResourceManagement.ISceneLoader <SceneLoader>k__BackingField;
    public PRISM.ResourceManagement.IResourceLoader NeverUnloadLoader { get; set; }
    public PRISM.ResourceManagement.IRawResourceLoader RawLoader { get; set; }
    public PRISM.ResourceManagement.IRawPathResolver RawPathResolver { get; set; }
    public PRISM.ResourceManagement.ISceneLoader SceneLoader { get; set; }
    private Limelight.LimelightCore Limelight { get; set; }
    private Limelight.AssetManager AssetManager { get; set; }
    public PRISM.ResourceManagement.IResourceLoader CreateScopedLoader(string name);
    public bool IsKeyExists(string key, bool lowercaseEnsured);
    public bool IsKeyExists(ulong crc);
    public Cysharp.Threading.Tasks.UniTask WipeoutLocalAssetCacheAsync();
    public void ReleaseAll();
    private Cysharp.Threading.Tasks.UniTask EnsureDownloadAsync(Limelight.IAssetRequest request);
    private T Validate<T>(T obj, string key);
    private void Untrack(PRISM.ResourceManagement.ObjectResourceLoader loader);

    private struct <EnsureDownloadAsync>d__25 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.ResourceManagement.ResourceLoaderContainer <>4__this;
        public Limelight.IAssetRequest request;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.ResourceManagement
public class SceneLoader : PRISM.ResourceManagement.ISceneLoader
{
    private PRISM.ResourceManagement.ResourceLoaderContainer core;
    private System.Collections.Generic.List<string> loadingKeys;
    public System.Collections.Generic.IEnumerable<string> LoadingKeys { get; set; }
    public Cysharp.Threading.Tasks.UniTask<UnityEngine.AsyncOperation> LoadAsync(string key, UnityEngine.SceneManagement.LoadSceneMode mode, bool lowercaseEnsured);
    public void Release(string key);

    private struct <LoadAsync>d__5 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<UnityEngine.AsyncOperation> <>t__builder;
        public bool lowercaseEnsured;
        public string key;
        public PRISM.ResourceManagement.SceneLoader <>4__this;
        public UnityEngine.SceneManagement.LoadSceneMode mode;
        private Awaiter <>u__1;
        private Awaiter<UnityEngine.AsyncOperation> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=555 9EDAFE6619CA1CBE9888D5A901171E90D851B7BDED2CAFD2EEBBF7D78477537F;
    private static __StaticArrayInitTypeSize=367 E44D5D97C45C67EB48A465B0A85F6C3BDBD3FB2426F3E076FE72839A7C39FB78;

    private struct __StaticArrayInitTypeSize=367 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=555 : System.ValueType
    {
    }
}
