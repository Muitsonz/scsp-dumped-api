
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

// Namespace: PRISM.Interactions
public class DownloadOverlayView : UnityEngine.MonoBehaviour, PRISM.Adapters.IDownloadOverlayView, PRISM.Adapters.IClosableOverlayView<Cysharp.Threading.Tasks.AsyncUnit>, PRISM.Adapters.IOverlayView, PRISM.Adapters.IClosable<Cysharp.Threading.Tasks.AsyncUnit>, PRISM.ResourceManagement.IDownloadEventHandler
{
    private UnityEngine.UI.Slider progressBar;
    private ENTERPRISE.UI.UITextMeshProUGUI percentageText;
    private Cysharp.Threading.Tasks.UniTask<Cysharp.Threading.Tasks.AsyncUnit> <OnCloseRequested>k__BackingField;
    public Cysharp.Threading.Tasks.UniTask<Cysharp.Threading.Tasks.AsyncUnit> OnCloseRequested { get; set; }
    private void PRISM.Adapters.IDownloadOverlayView.Inject(Cysharp.Threading.Tasks.UniTask downloadTask);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    private void PRISM.ResourceManagement.IDownloadEventHandler.OnDownloadStart(PRISM.ResourceManagement.DownloadCategory category);
    private void PRISM.ResourceManagement.IDownloadEventHandler.OnDownloadProgress(PRISM.ResourceManagement.DownloadCategory category, long downloadedBytes, long totalDownloadBytes, long globalDownloadedBytes, long globalTotalDownloadBytes);
    private void PRISM.ResourceManagement.IDownloadEventHandler.OnDownloadFinish(PRISM.ResourceManagement.DownloadCategory category);
    private Cysharp.Threading.Tasks.UniTask PRISM.ResourceManagement.IDownloadEventHandler.OnDownloadError(Limelight.AssetDownloadError error);
}

// Namespace: PRISM.Interactions
public class SystemCacheClearProgressView : UnityEngine.MonoBehaviour, PRISM.Adapters.ISystemCacheClearProgressView, PRISM.Adapters.IClosableOverlayView<Cysharp.Threading.Tasks.AsyncUnit>, PRISM.Adapters.IOverlayView, PRISM.Adapters.IClosable<Cysharp.Threading.Tasks.AsyncUnit>
{
    private UnityEngine.CanvasGroup canvasGroup;
    private float fadeDelay;
    private Cysharp.Threading.Tasks.UniTask<Cysharp.Threading.Tasks.AsyncUnit> <OnCloseRequested>k__BackingField;
    public Cysharp.Threading.Tasks.UniTask<Cysharp.Threading.Tasks.AsyncUnit> OnCloseRequested { get; set; }
    public void Inject(Cysharp.Threading.Tasks.UniTask cacheClearTask);
    private void Awake();
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
}

// Namespace: PRISM.Interactions
public class ConfirmDownloadPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.Title.IConfirmDownloadPopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private PRISM.Interactions.ToggleGroupView toggle;
    private ENTERPRISE.UI.UITextMeshProUGUI downloadSizeText;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Initialize(UniRx.IReactiveProperty<PRISM.Adapters.Title.DownloadType> downloadType, long downloadBytes);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__6_0();
    private void <CreateFrameParameter>b__6_1();
    private void <CreateFrameParameter>b__6_2();
}

// Namespace: PRISM.Interactions.Title
public class ConfirmCacheClearPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.Title.IConfirmCacheClearPopupView, PRISM.Adapters.IClosablePopupFrame<PRISM.Adapters.Title.CacheClearDecisionType>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<PRISM.Adapters.Title.CacheClearDecisionType>
{
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<PRISM.Adapters.Title.CacheClearDecisionType> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<PRISM.Adapters.Title.CacheClearDecisionType> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__3_0();
    private void <CreateFrameParameter>b__3_1();
    private void <CreateFrameParameter>b__3_2();
}

// Namespace: PRISM.Interactions.Title
public class ConfirmPlayerDataDeletePopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.Title.IConfirmPlayerDataDeletePopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__3_0();
    private void <CreateFrameParameter>b__3_1();
    private void <CreateFrameParameter>b__3_2();
}

// Namespace: PRISM.Interactions.Title
public class LicenseAgreementPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.Title.ILicenseAgreementPopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private ENTERPRISE.UI.UITextMeshProUGUI messageText;
    private PRISM.Interactions.ButtonView licenseButton;
    private PRISM.Interactions.ButtonView privacyPolicyButton;
    private PRISM.Interactions.ButtonView globalConsentButton;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClosed;
    private PRISM.Interactions.PopupFrameParameter frameParameter;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public System.IObservable<PRISM.Adapters.Title.LicensePopupButtonType> OnClick { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Initialize(bool isFirst);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <Initialize>b__10_0();
    private void <Initialize>b__10_1();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<UniRx.Unit, PRISM.Adapters.Title.LicensePopupButtonType> <>9__8_0;
        public static System.Func<UniRx.Unit, PRISM.Adapters.Title.LicensePopupButtonType> <>9__8_1;
        public static System.Func<UniRx.Unit, PRISM.Adapters.Title.LicensePopupButtonType> <>9__8_2;
        private PRISM.Adapters.Title.LicensePopupButtonType <get_OnClick>b__8_0(UniRx.Unit _);
        private PRISM.Adapters.Title.LicensePopupButtonType <get_OnClick>b__8_1(UniRx.Unit _);
        private PRISM.Adapters.Title.LicensePopupButtonType <get_OnClick>b__8_2(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.Title
public class PreAttPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.Title.IPreAttPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private UniRx.Subject<UniRx.Unit> onClickDetail;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public System.IObservable<UniRx.Unit> OnClickDetail { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__6_0();
    private void <CreateFrameParameter>b__6_1();
}

// Namespace: PRISM.Interactions.Title
public class SelectGameStartTypePopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.Title.ISelectGameStartTypePopupView, PRISM.Adapters.IClosablePopupFrame<PRISM.Adapters.Title.GameStartType>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<PRISM.Adapters.Title.GameStartType>
{
    private PRISM.Interactions.ButtonView transferAccountButton;
    private PRISM.Interactions.ButtonView newButton;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<PRISM.Adapters.Title.GameStartType> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<PRISM.Adapters.Title.GameStartType> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <LoadAsync>b__5_0(UniRx.Unit _);
    private void <LoadAsync>b__5_1(UniRx.Unit _);
    private void <CreateFrameParameter>b__6_0();
    private void <CreateFrameParameter>b__6_1();
}

// Namespace: PRISM.Interactions.Title
public class TitleMenuPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.Title.ITitleMenuPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.ButtonView[] buttons;
    private ENTERPRISE.UI.UITextMeshProUGUI transferText;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public System.IObservable<PRISM.Adapters.Title.TitleMenuButtonType> OnClick { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void SetConnectAccountButtonActive(bool isActive);
    public void SetConnectedStatus(bool isConnected);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__9_0();
    private void <CreateFrameParameter>b__9_1();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Interactions.ButtonView, int, System.IObservable<PRISM.Adapters.Title.TitleMenuButtonType>> <>9__6_0;
        private System.IObservable<PRISM.Adapters.Title.TitleMenuButtonType> <get_OnClick>b__6_0(PRISM.Interactions.ButtonView button, int index);
    }

    private class <>c__DisplayClass6_0
    {
        public int index;
        private PRISM.Adapters.Title.TitleMenuButtonType <get_OnClick>b__1(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.Title
public enum DefaultTitleCallType : System.Enum
{
    public int value__;
    public static PRISM.Interactions.Title.DefaultTitleCallType Long;
    public static PRISM.Interactions.Title.DefaultTitleCallType Short;
    public static PRISM.Interactions.Title.DefaultTitleCallType LongOrShort;
}

// Namespace: PRISM.Interactions.Title
public class DefaultTitleCallData : PRISM.Interactions.Title.ITitleCallData
{
    private PRISM.Definitions.SoundKey <SoundKey>k__BackingField;
    public PRISM.Definitions.SoundKey SoundKey { get; set; }
    private static string _getCueName(PRISM.Interactions.Title.DefaultTitleCallType defaultTitleCallType);
}

// Namespace: PRISM.Interactions.Title
public interface ITitleCallData
{
    public PRISM.Definitions.SoundKey SoundKey { get; set; }
}

// Namespace: PRISM.Interactions.Title
public class TitleCallData : PRISM.Interactions.Title.ITitleCallData
{
    private PRISM.Definitions.SoundKey <SoundKey>k__BackingField;
    public PRISM.Definitions.SoundKey SoundKey { get; set; }
}

// Namespace: PRISM.Interactions.Title
public class TitleCallPlayer
{
    private PRISM.Interactions.Title.ITitleCallData titleCallData;
    private bool isTitleCallEnabled;
    private bool isFirstPlay;
    public Cysharp.Threading.Tasks.UniTask LoadCueSheetAsync(System.Threading.CancellationToken cancellationToken);
    public void Play();
    public void UnloadCueSheet();

    private struct <LoadCueSheetAsync>d__5 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Title.TitleCallPlayer <>4__this;
        public System.Threading.CancellationToken cancellationToken;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Title
public class TitleConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.TitleArgument>, PRISM.Legacy.ITitleConnector
{
    protected PRISM.Adapters.TitleArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
}

// Namespace: PRISM.Interactions.Title
public class TitleLoadProgressBarView : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.Slider progressBar;
    private ENTERPRISE.UI.UITextMeshProUGUI startingGameText;
    private ENTERPRISE.UI.UITextMeshProUGUI percentageText;
    private UnityEngine.CanvasGroup fadeGroup;
    private bool <IsFinished>k__BackingField;
    private bool <IsLoading>k__BackingField;
    private float lastProgress;
    public bool IsFinished { get; set; }
    public bool IsLoading { get; set; }
    private void _startLoading();
    private void _updateProgress(float progress);
    private void _finishLoading();
    private void Reset();
    private void UpdateProgress(float progress);
    private void Initialize();
    private void <_finishLoading>b__15_0();
}

// Namespace: PRISM.Interactions.Title
public class TitleView : UnityEngine.MonoBehaviour, PRISM.Adapters.Title.ITitleView
{
    private ENTERPRISE.UI.UITextMeshProUGUI appVersionText;
    private PRISM.Interactions.ButtonView menuButton;
    private PRISM.Interactions.ButtonView wholeScreenButton;
    private PRISM.MoviePlayer moviePlayer;
    private UnityEngine.UI.RawImage backgroundImage;
    private PRISM.Interactions.Title.TitleLoadProgressBarView loadProgress;
    private UnityEngine.Animator touchToStart;
    private PRISM.Interactions.ToggleButtonView userIdButton;
    private ENTERPRISE.UI.UITextMeshProUGUI idText;
    private PRISM.Definitions.TitleBackgroundType backgroundType;
    private string backgroundKey;
    private string bgmCueSheetName;
    private string bgmCueName;
    private string titleCallCueSheetName;
    private string titleCallCueName;
    private PRISM.Definitions.MstTitleBackground mstTitleBackground;
    private bool isTitleCallEnabled;
    private System.IDisposable bgmDisposable;
    private float loadProgressValue;
    public System.IObservable<UniRx.Unit> OnClickMenuButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickWholeScreenButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickBackKey { get; set; }
    public void Initialize(PRISM.Adapters.Title.TitleViewModel viewModel, bool isTitleCallEnabled, PRISM.Definitions.MstTitleBackground mstTitleBackground);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask ResetLoadProgressAsync(System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync(System.Threading.CancellationToken token);
    public Cysharp.Threading.Tasks.UniTask StopSoundAsync(System.Threading.CancellationToken cancellationToken);
    public void UpdateLoadProgress(float progress);
    public void ShowRecoveryAlert();
    public void HideRecoveryAlert();
    public void UpdateRecoveryProgress(float progress);
    public void ShowTouchToStart();
    public void HideTouchToStart();
    private void Update();
    private Cysharp.Threading.Tasks.UniTask _playBackgroundWithImageAsync(string imageKey, PRISM.Definitions.SoundKey bgmSoundKey, PRISM.Interactions.Title.TitleCallPlayer titleCallPlayer, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken cancellationToken);
    private Cysharp.Threading.Tasks.UniTask _playBackgroundWithMovieAsync(string movieKey, PRISM.Interactions.Title.TitleCallPlayer titleCallPlayer, System.Threading.CancellationToken cancellationToken);
    private static string <Initialize>g__Format|26_0(string str);

    private enum BackgroundType : System.Enum
    {
        public int value__;
        public static BackgroundType Movie;
        public static BackgroundType Image;
    }

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<bool> <>9__30_0;
        private bool <StopSoundAsync>b__30_0();
    }

    private class <>c__DisplayClass39_0
    {
        public PRISM.Interactions.Title.TitleCallPlayer titleCallPlayer;
        public Cysharp.Threading.Tasks.UniTaskCompletionSource tcs;
        private void <_playBackgroundWithMovieAsync>b__0(CueEventMessage _);
        private void <_playBackgroundWithMovieAsync>b__1();
    }

    private struct <ShowAsync>d__27 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Title.TitleView <>4__this;
        public System.Threading.CancellationToken cancellationToken;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private PRISM.Definitions.TitleBackgroundType <titleBackgroundType>5__2;
        private string <titleBackgroundKey>5__3;
        private PRISM.Definitions.SoundKey <bgmSoundKey>5__4;
        private PRISM.Interactions.Title.TitleCallPlayer <titleCallPlayer>5__5;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <TerminateAsync>d__29 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Title.TitleView <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_playBackgroundWithImageAsync>d__38 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Definitions.SoundKey bgmSoundKey;
        public System.Threading.CancellationToken cancellationToken;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public string imageKey;
        public PRISM.Interactions.Title.TitleView <>4__this;
        public PRISM.Interactions.Title.TitleCallPlayer titleCallPlayer;
        private Awaiter <>u__1;
        private Awaiter<UnityEngine.Texture2D> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=786 5025DE42011A4373CCD78363C27846E7B1C1EC96BBE4225E98DF3CAEAC3E07BE;
    private static __StaticArrayInitTypeSize=1238 50B083DDEB144EC963F6DF366698638214F422FFEB8016233313BF7748016777;

    private struct __StaticArrayInitTypeSize=786 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=1238 : System.ValueType
    {
    }
}
