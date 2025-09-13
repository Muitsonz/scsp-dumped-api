
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
public class FesDataPossessionLimitPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IFesDataPossessionLimitPopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private ENTERPRISE.UI.UITextMeshProUGUI txtMessage;
    private ENTERPRISE.UI.UITextMeshProUGUI txtFesUnitCount;
    private ENTERPRISE.UI.UITextMeshProUGUI txtFesUnitLimit;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClick;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Assign(int fesUnitCount);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__7_0();
    private void <CreateFrameParameter>b__7_1();
    private void <CreateFrameParameter>b__7_2();
}

// Namespace: PRISM.Interactions
public class Home3DSceneView : PRISM.Adapters.IHome3DSceneView, System.IDisposable
{
    private PRISM.Adapters.HomeViewModel viewModel;
    private UniRx.CompositeDisposable disposables;
    private PRISM.Scenario.ScenarioManager scenarioManager;
    private PRISM.Interactions.Home.Model3dLoaderForHome model3dLoader;
    public PRISM.Adapters.Home.IModel3dLoaderForHome Model3dLoader { get; set; }
    public Cysharp.Threading.Tasks.UniTask SetupAsync(int viewType, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    public void Dispose();
    private Cysharp.Threading.Tasks.UniTask _setupCharacterMotionAsync(int viewType);
    private bool <_setupCharacterMotionAsync>b__10_0();

    private class <>c__DisplayClass7_0
    {
        public PRISM.LiveCharacterController liveCharacterController;
        public PRISM.Interactions.Home3DSceneView <>4__this;
        private bool <SetupAsync>b__0();
        private bool <SetupAsync>b__1();
    }

    private struct <SetupAsync>d__7 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Home3DSceneView <>4__this;
        public int viewType;
        public System.Threading.CancellationToken ct;
        private <>c__DisplayClass7_0 <>8__1;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <TerminateAsync>d__8 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Home3DSceneView <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_setupCharacterMotionAsync>d__10 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Home3DSceneView <>4__this;
        public int viewType;
        private int <length>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class HomeBeginnerMissionBannerView : UnityEngine.MonoBehaviour, PRISM.Adapters.Home.IHomeBeginnerMissionBannerView
{
    private PRISM.Interactions.ButtonWithBadgeView button;
    public System.IObservable<UniRx.Unit> OnClick { get; set; }
    public void Initialize(UniRx.IReadOnlyReactiveProperty<PRISM.Adapters.IBadgeModel> homeBadgeModel);
    public void SetActive(bool isActive);
    private void <Initialize>b__3_0(PRISM.Adapters.IBadgeModel value);
}

// Namespace: PRISM.Interactions
public class HomeCharacterMessagePanelView : UnityEngine.MonoBehaviour, PRISM.Adapters.IHomeCharacterMessagePanelView, System.IDisposable
{
    private ENTERPRISE.UI.UITextMeshProUGUI nameText;
    private ENTERPRISE.UI.UITextMeshProUGUI messageText;
    private UnityEngine.CanvasGroup canvasGroup;
    private UnityEngine.CanvasGroup messageWindowCanvasGroup;
    private UnityEngine.Transform windowObject;
    private UnityEngine.UI.Image windowImage;
    private UnityEngine.AnimationCurve fadeCurve;
    private UnityEngine.Sprite[] windowSprites;
    private PRISM.Interactions.ScreenTouchDetector screenTouchDetector;
    private System.IDisposable panelViewFadeTimeDisposable;
    private System.IDisposable messageWindowFadeTimeDisposable;
    private string <CueSheetName>k__BackingField;
    public string CueSheetName { get; set; }
    public bool IsShow { get; set; }
    public System.IObservable<UniRx.Unit> OnTouchScreen { get; set; }
    public void Inject(PRISM.Interactions.ScreenTouchDetector screenTouchDetector);
    public void Initialize(string cueSheetName, Home3DViewType viewType);
    public void Show(float fadeTime);
    public void Hide(float fadeTime);
    public void ShowMessageWindow(string name, string text);
    public void ShowMessageWindow();
    public void HideMessageWindow();
    public void FadeOutMessageWindow(float fadeTime);
    public void Dispose();
    private UnityEngine.Vector3 _getPosition(Home3DViewType viewType);
    private UnityEngine.Sprite _getWindowSprite(Home3DViewType viewType);
    private void _fade(UnityEngine.CanvasGroup targetCanvasGroup, FadeType fadeType, System.Action onCompleted, float fadeTime);
    private void <Show>b__21_0();
    private void <Hide>b__22_0();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<float, bool> <>9__26_2;
        public static System.Func<float, bool> <>9__30_2;
        private bool <FadeOutMessageWindow>b__26_2(float rate);
        private bool <_fade>b__30_2(float rate);
    }

    private class <>c__DisplayClass26_0
    {
        public float time;
        public float fadeTime;
        public PRISM.Interactions.HomeCharacterMessagePanelView <>4__this;
        private void <FadeOutMessageWindow>b__0(long _);
        private float <FadeOutMessageWindow>b__1(long _);
        private float <FadeOutMessageWindow>b__3(float rate);
        private void <FadeOutMessageWindow>b__4(float rate);
        private void <FadeOutMessageWindow>b__5();
    }

    private class <>c__DisplayClass30_0
    {
        public float time;
        public float fadeTime;
        public PRISM.Interactions.HomeCharacterMessagePanelView <>4__this;
        public FadeType fadeType;
        public UnityEngine.CanvasGroup targetCanvasGroup;
        public System.Action onCompleted;
        private void <_fade>b__0(long _);
        private float <_fade>b__1(long _);
        private float <_fade>b__3(float rate);
        private void <_fade>b__4(float rate);
        private void <_fade>b__5();
    }
}

// Namespace: PRISM.Interactions
public class HomeConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.HomeArgument>, PRISM.IHomeConnector
{
    protected PRISM.Adapters.HomeArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
}

// Namespace: PRISM.Interactions
public class HomeSettingsIdolIconContent : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.CharacterBaseIconView idolIcon;
    private PRISM.Interactions.ButtonView idolIconButton;
    private PRISM.Interactions.ButtonView removeButton;
    private PRISM.Interactions.ButtonView selectClothesButton;
    private PRISM.AutoCancellationTokenSource canceller;
    public System.IObservable<UniRx.Unit> OnClickCharacterIconObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnClickRemoveObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnClickClothesObservable { get; set; }
    public void Setup(int characterId, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Interactions
public class HomeSettingsPopupView : UnityEngine.MonoBehaviour, PRISM.Adapters.IHomeSettingsPopupView, PRISM.Adapters.IClosablePopupFrame<System.ValueTuple<bool, System.Nullable<int>>>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<System.ValueTuple<bool, System.Nullable<int>>>, PRISM.Interactions.IPopupContent
{
    private PRISM.Interactions.ToggleGroupView idolCheckButtonGroup;
    private PRISM.Interactions.HomeSettingsIdolIconContent[] idolIconContents;
    private PRISM.Interactions.ButtonView buttonSave;
    private UnityEngine.GameObject saveWarningIcon;
    private PRISM.Interactions.ButtonView buttonClose;
    private PRISM.Adapters.HomeSettingsViewModel viewModel;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<System.ValueTuple<bool, System.Nullable<int>>> onClosed;
    private UniRx.Subject<UniRx.Unit> onSaveError;
    private UniRx.Subject<int> onRemoveCharacter;
    private UniRx.Subject<int> onSelectIdolButton;
    private bool <isWarning>k__BackingField;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<System.ValueTuple<bool, System.Nullable<int>>> OnCloseRequested { get; set; }
    public System.IObservable<UniRx.Unit> OnSaveErrorObservable { get; set; }
    public System.IObservable<int> OnRemoveCharacter { get; set; }
    public System.IObservable<int> OnSelectIdolSelectButtonObservable { get; set; }
    private bool isWarning { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Inject(PRISM.Adapters.HomeSettingsViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void SetSaveButtonWarning(bool isWarning);
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void ShowIdolIcon();
    private Cysharp.Threading.Tasks.UniTask<bool> _openSelectClothesConfirmPopupAsync();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <LoadAsync>b__25_0(UniRx.Unit _);
    private void <LoadAsync>b__25_1(UniRx.Unit _);
    private void <CreateFrameParameter>b__26_0();
    private void <ShowIdolIcon>b__27_0(PRISM.Interactions.HomeSettingsIdolIconContent icon, int vm);

    private class <>c__DisplayClass25_0
    {
        public int index;
        public PRISM.Interactions.HomeSettingsPopupView <>4__this;
        private void <LoadAsync>b__2(UniRx.Unit _);
        private void <LoadAsync>b__3(UniRx.Unit _);
        private Cysharp.Threading.Tasks.UniTaskVoid <LoadAsync>b__4(UniRx.Unit _);

        private struct <<LoadAsync>b__4>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
        {
            public int <>1__state;
            public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
            public <>c__DisplayClass25_0 <>4__this;
            private Awaiter<bool> <>u__1;
            private void MoveNext();
            private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }

    private struct <LoadAsync>d__25 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
        public PRISM.Interactions.HomeSettingsPopupView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter<bool> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class HomeSubFooterButtonGroupView : UnityEngine.MonoBehaviour, PRISM.Adapters.IHomeSubFooterButtonGroupView
{
    private PRISM.Interactions.ButtonWithBadgeView mobileButton;
    private PRISM.Interactions.ButtonWithBadgeView announceButton;
    private PRISM.Interactions.ButtonWithBadgeView missionButton;
    private PRISM.Interactions.ButtonWithBadgeView presentButton;
    private PRISM.Interactions.ButtonWithBadgeView exchangeButton;
    public System.IObservable<UniRx.Unit> OnClickMobileButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickAnnounceButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickMissionButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickPresentButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickExchangeButton { get; set; }
    public System.IDisposable Initialize(PRISM.Adapters.IHomeNotificationModelContainer notificationModelContainer);
    private void <Initialize>b__15_0(PRISM.Adapters.IBadgeModel value);
    private void <Initialize>b__15_1(PRISM.Adapters.IBadgeModel value);
    private void <Initialize>b__15_2(PRISM.Adapters.IBadgeModel value);
    private void <Initialize>b__15_3(PRISM.Adapters.IBadgeModel value);
    private void <Initialize>b__15_4(PRISM.Adapters.IBadgeModel value);
}

// Namespace: PRISM.Interactions
public class HomeTransitionView : UnityEngine.MonoBehaviour
{
    private UnityEngine.Animator transitonAnimator;
    public Cysharp.Threading.Tasks.UniTask TransitionInAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TransitionOutAsync(System.Threading.CancellationToken ct);
    public void Hide();

    private struct <TransitionInAsync>d__1 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public System.Threading.CancellationToken ct;
        public PRISM.Interactions.HomeTransitionView <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <TransitionOutAsync>d__2 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public System.Threading.CancellationToken ct;
        public PRISM.Interactions.HomeTransitionView <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class HomeView : UnityEngine.MonoBehaviour, PRISM.Adapters.IHomeView
{
    private PRISM.Interactions.HomeCharacterMessagePanelView characterMessagePanelView;
    private PRISM.Interactions.ScreenTouchDetector screenTouchDetector;
    private TNRD.SerializableInterface<PRISM.Adapters.Mobile.IMobileNotificationView> mobileNotificationView;
    private PRISM.ITutorialSequence tutorialSequence;
    private PRISM.Interactions.Home3DSceneView scene3DView;
    private PRISM.Adapters.HomeViewModel viewModel;
    public PRISM.Adapters.IHome3DSceneView Scene3DView { get; set; }
    public PRISM.Adapters.IHomeCharacterMessagePanelView CharacterMessagePanelView { get; set; }
    public System.IObservable<UniRx.Unit> OnClickUndoHideUIButtonObservable { get; set; }
    public PRISM.Adapters.Mobile.IMobileNotificationView MobileNotificationView { get; set; }
    public PRISM.ITutorialSequence TutorialSequence { get; set; }
    public void Inject(PRISM.Adapters.HomeViewModel viewModel);
    public Cysharp.Threading.Tasks.UniTask SetupAsync();
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    public Cysharp.Threading.Tasks.UniTask<PRISM.Adapters.IHome3DSceneView> Reload3DSceneAsync(PRISM.Adapters.HomeViewModel viewModel, System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask _playBgmAsync(PRISM.Adapters.HomeBackgroundViewModel backModel, System.Threading.CancellationToken ct);

    private struct <Reload3DSceneAsync>d__19 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<PRISM.Adapters.IHome3DSceneView> <>t__builder;
        public PRISM.Interactions.HomeView <>4__this;
        public PRISM.Adapters.HomeViewModel viewModel;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <SetupAsync>d__17 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.HomeView <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <TerminateAsync>d__18 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.HomeView <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_playBgmAsync>d__20 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Adapters.HomeBackgroundViewModel backModel;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Home
public class HomeEventBannerGroupView : UnityEngine.MonoBehaviour, PRISM.Adapters.Home.IHomeEventBannerGroupView
{
    private PRISM.Interactions.UIShifter shifter;
    private PRISM.Interactions.Home.BannerWithEndDateView[] shifterCells;
    private UniRx.Subject<PRISM.Adapters.Home.HomeEventBannerViewModel> onClickBanner;
    private System.IDisposable disposable;
    public System.IObservable<PRISM.Adapters.Home.HomeEventBannerViewModel> OnClickBanner { get; set; }
    public void Initialize(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.Home.HomeEventBannerViewModel> bannerViewModels, PRISM.ResourceManagement.IResourceLoader resourceLoader);

    private class <>c__DisplayClass6_0
    {
        public System.Collections.Generic.IReadOnlyList<PRISM.Adapters.Home.HomeEventBannerViewModel> bannerViewModels;
        public PRISM.Interactions.Home.HomeEventBannerGroupView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private void <Initialize>b__0(System.ValueTuple<UnityEngine.RectTransform, int> x);
    }

    private class <>c__DisplayClass6_1
    {
        public System.ValueTuple<UnityEngine.RectTransform, int> x;
        public PRISM.Adapters.Home.HomeEventBannerViewModel bannerViewModel;
        public <>c__DisplayClass6_0 CS$<>8__locals1;
        private bool <Initialize>b__1(PRISM.Interactions.Home.BannerWithEndDateView y);
        private void <Initialize>b__2(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.Home
public class HomeMainBannerGroupView : UnityEngine.MonoBehaviour, PRISM.Adapters.Home.IHomeMainBannerGroupView
{
    private PRISM.Interactions.UIShifter shifter;
    private PRISM.Interactions.Home.HomeMainBannerView[] shifterCells;
    private UniRx.Subject<PRISM.Adapters.Home.HomeMainBannerViewModel> onClickBanner;
    private PRISM.Legacy.IWebTextureLoader webTextureLoader;
    private System.IDisposable disposable;
    public System.IObservable<PRISM.Adapters.Home.HomeMainBannerViewModel> OnClickBanner { get; set; }
    public void Inject(PRISM.Legacy.IWebTextureLoader webTextureLoader);
    public void Initialize(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.Home.HomeMainBannerViewModel> bannerViewModels, PRISM.ResourceManagement.IResourceLoader resourceLoader);

    private class <>c__DisplayClass8_0
    {
        public System.Collections.Generic.IReadOnlyList<PRISM.Adapters.Home.HomeMainBannerViewModel> bannerViewModels;
        public PRISM.Interactions.Home.HomeMainBannerGroupView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private void <Initialize>b__0(System.ValueTuple<UnityEngine.RectTransform, int> x);
    }

    private class <>c__DisplayClass8_1
    {
        public System.ValueTuple<UnityEngine.RectTransform, int> x;
        public PRISM.Adapters.Home.HomeMainBannerViewModel bannerViewModel;
        public <>c__DisplayClass8_0 CS$<>8__locals1;
        private bool <Initialize>b__1(PRISM.Interactions.Home.HomeMainBannerView y);
        private void <Initialize>b__2(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.Home
public class HomeMainBannerView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView button;
    private UnityEngine.UI.Image genreImage;
    private UnityEngine.UI.RawImage bannerImage;
    private PRISM.AutoCancellationTokenSource canceller;
    public System.IObservable<UniRx.Unit> OnClick { get; set; }
    public Cysharp.Threading.Tasks.UniTask Initialize(PRISM.Adapters.Home.HomeMainBannerViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Legacy.IWebTextureLoader webTextureLoader);
    private void OnDestroy();
}

// Namespace: PRISM.Interactions.Home
public class HomeMainView : UnityEngine.MonoBehaviour, PRISM.Adapters.IHomeMainView
{
    private PRISM.Interactions.StaminaView liveBoostView;
    private PRISM.Interactions.JewelAmountPanelView jewelAmountPanelView;
    private PRISM.Interactions.JewelLimitedSalePanelView jewelLimitedSalePanelView;
    private PRISM.Interactions.MainFooterButtonGroupView mainFooterButtonGroupView;
    private PRISM.Interactions.HomeSubFooterButtonGroupView subFooterButtonGroupView;
    private PRISM.Interactions.Home.HomeMainBannerGroupView mainBannerGroupView;
    private PRISM.Interactions.Home.HomeEventBannerGroupView eventBannerGroupView;
    private PRISM.Interactions.Home.HomeSeasonMissionBannerView seasonMissionBannerView;
    private PRISM.Interactions.Home.HomeOurStreamBannerView ourStreamBannerView;
    private PRISM.Interactions.HomeBeginnerMissionBannerView beginnerMissionBannerView;
    private PRISM.Interactions.ButtonView dmButton;
    private PRISM.Interactions.ButtonView hideUIButton;
    private UnityEngine.GameObject hideAreaObject;
    private PRISM.Interactions.ButtonView settingsButton;
    private PRISM.Interactions.ButtonView globalMenuButton;
    private PRISM.Interactions.EventIconView globalMenuEventIconView;
    private PRISM.Interactions.ButtonView characterButton;
    private UnityEngine.CanvasGroup canvasGroup;
    private PRISM.Adapters.HomeViewModel viewModel;
    private PRISM.Legacy.WebTextureLoader webTextureLoader;
    public PRISM.Adapters.IStaminaView LiveBoostView { get; set; }
    public PRISM.Adapters.IJewelAmountPanelView JewelAmountPanelView { get; set; }
    public PRISM.Adapters.IJewelLimitedSalePanelView JewelLimitedSalePanelView { get; set; }
    public PRISM.Adapters.Home.IHomeMainBannerGroupView MainBannerGroupView { get; set; }
    public PRISM.Adapters.Home.IHomeEventBannerGroupView EventBannerGroupView { get; set; }
    public PRISM.Adapters.Home.IHomeSeasonMissionBannerView SeasonMissionBannerView { get; set; }
    public PRISM.Adapters.Home.IHomeBeginnerMissionBannerView BeginnerMissionBannerView { get; set; }
    public PRISM.Adapters.Home.IHomeOurStreamBannerView OurStreamBannerView { get; set; }
    public PRISM.Adapters.IMainFooterButtonGroupView MainFooterButtonGroupView { get; set; }
    public PRISM.Adapters.IHomeSubFooterButtonGroupView SubFooterButtonGroupView { get; set; }
    public System.IObservable<UniRx.Unit> OnClickHideUIButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickSettingsButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickDmButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickCharacterButton { get; set; }
    public PRISM.Adapters.IBackKeyObservable OnClickBackKeyObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnClickGlobalMenuObservable { get; set; }
    public void Inject(PRISM.Adapters.HomeViewModel viewModel);
    public System.IDisposable InitializeGlobalMenuEventIcon(UniRx.IReadOnlyReactiveProperty<PRISM.Adapters.IEventIconModel> globalMenuEventIconModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void Show();
    public void Hide();
    public void SetActiveUI(bool isActive);
    public Cysharp.Threading.Tasks.UniTask OpenPanelMissionAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask OpenGotoTitleConfirmPopupAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask OpenGashaExchangeExpiryDateInfoPopupAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask<bool> ShowLoginBonusPassEffectEndPUAsync(PRISM.Adapters.Shop.LoginBonusPassRewardModel passRewardModel, System.Threading.CancellationToken ct);
    public void SetDmButtonActive(bool isActive);
    private void Awake();
    private void _setActiveCharaButton(bool isActive);
    private Cysharp.Threading.Tasks.UniTask<bool> _showEnddedEffectNoAppealPU(string messageText, System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask<bool> _showEnddedEffectPU(string messageText, System.Threading.CancellationToken ct);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Module.Networking.IGashaExchangePointStatus, bool> <>9__59_0;
        private bool <OpenGashaExchangeExpiryDateInfoPopupAsync>b__59_0(PRISM.Module.Networking.IGashaExchangePointStatus x);
    }

    private class <>c__DisplayClass53_0
    {
        public PRISM.Interactions.Home.HomeMainView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private void <InitializeGlobalMenuEventIcon>b__0(PRISM.Adapters.IEventIconModel value);
    }

    private class <>c__DisplayClass59_0
    {
        public System.Collections.Generic.IEnumerable<PRISM.Module.Networking.IGashaExchangePointStatus> oneDayItems;
        private bool <OpenGashaExchangeExpiryDateInfoPopupAsync>b__1(PRISM.Module.Networking.IGashaExchangePointStatus x);
    }

    private struct <OpenGashaExchangeExpiryDateInfoPopupAsync>d__59 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public System.Threading.CancellationToken ct;
        private <>c__DisplayClass59_0 <>8__1;
        private Awaiter<System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IGashaExchangePointStatus>> <>u__1;
        private Awaiter <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <OpenGotoTitleConfirmPopupAsync>d__58 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public System.Threading.CancellationToken ct;
        private Awaiter<bool> <>u__1;
        private Awaiter <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <OpenPanelMissionAsync>d__57 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <ShowLoginBonusPassEffectEndPUAsync>d__60 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
        public PRISM.Adapters.Shop.LoginBonusPassRewardModel passRewardModel;
        public System.Threading.CancellationToken ct;
        public PRISM.Interactions.Home.HomeMainView <>4__this;
        private Awaiter<bool> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_showEnddedEffectNoAppealPU>d__64 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
        public string messageText;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Home
public class HomeOurStreamBannerView : UnityEngine.MonoBehaviour, PRISM.Adapters.Home.IHomeOurStreamBannerView
{
    private PRISM.Interactions.ButtonView button;
    private UnityEngine.UI.RawImage image;
    private PRISM.Legacy.IWebTextureLoader webTextureLoader;
    private PRISM.AutoCancellationTokenSource canceller;
    public System.IObservable<UniRx.Unit> OnClick { get; set; }
    public void Inject(PRISM.Legacy.IWebTextureLoader webTextureLoader);
    public void Initialize(PRISM.Adapters.Home.HomeOurStreamBannerViewModel viewModel);
    public void SetActive(bool isActive);
    private void OnDestroy();
}

// Namespace: PRISM.Interactions.Home
public class HomeRemindItemListView : PRISM.Interactions.ListView<PRISM.Interactions.Home.HomeRemindItemListViewCell, PRISM.Adapters.HomeRemindItemListViewModel, PRISM.Interactions.ListViewContextWithClick<int>>
{
    public System.IObservable<int> OnClick { get; set; }
}

// Namespace: PRISM.Interactions.Home
public class HomeRemindItemListViewCell : PRISM.Interactions.ListViewCell<PRISM.Adapters.HomeRemindItemListViewModel, PRISM.Interactions.ListViewContextWithClick<int>>
{
    private PRISM.Interactions.RewardItemIcon itemIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI nameText;
    private ENTERPRISE.UI.UITextMeshProUGUI limitText;
    private ENTERPRISE.UI.UITextMeshProUGUI buttonText;
    private PRISM.Interactions.ButtonView gotoButton;
    private System.IDisposable intervalDisposable;
    private System.IDisposable gotoButtonDisposable;
    public void UpdateContent(PRISM.Adapters.HomeRemindItemListViewModel viewModel);

    private class <>c__DisplayClass7_0
    {
        public PRISM.Adapters.HomeRemindItemListViewModel viewModel;
        public PRISM.Interactions.Home.HomeRemindItemListViewCell <>4__this;
        private void <UpdateContent>b__0(long _);
        private void <UpdateContent>b__1(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.Home
public class HomeRemindItemPopupView : UnityEngine.MonoBehaviour, PRISM.Adapters.IHomeRemindItemPopupView, PRISM.Adapters.IClosablePopupFrame<PRISM.Adapters.HomeRemindItemListViewModel>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<PRISM.Adapters.HomeRemindItemListViewModel>, PRISM.Interactions.IPopupContent
{
    private PRISM.Interactions.Home.HomeRemindItemListView remindItemListView;
    private ENTERPRISE.UI.UITextMeshProUGUI[] replaceMeshTexts;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<PRISM.Adapters.HomeRemindItemListViewModel> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<PRISM.Adapters.HomeRemindItemListViewModel> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Inject(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.HomeRemindItemListViewModel> viewModels, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__7_0();
    private void <CreateFrameParameter>b__7_1();

    private enum ReplaceText : System.Enum
    {
        public int value__;
        public static ReplaceText mlPublicText_Home_00011;
        public static ReplaceText mlPublicText_Home_00012;
    }

    private class <>c__DisplayClass6_0
    {
        public PRISM.Interactions.Home.HomeRemindItemPopupView <>4__this;
        public System.Collections.Generic.IReadOnlyList<PRISM.Adapters.HomeRemindItemListViewModel> viewModels;
        private void <Inject>b__0(int index);
    }
}

// Namespace: PRISM.Interactions.Home
public class HomeSeasonMissionBannerView : UnityEngine.MonoBehaviour, PRISM.Adapters.Home.IHomeSeasonMissionBannerView
{
    private PRISM.Interactions.Home.BannerWithEndDateView banner;
    public System.IObservable<UniRx.Unit> OnClick { get; set; }
    public void Initialize(PRISM.Adapters.Home.SeasonMissionBannerViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void Hide();
    private void <Initialize>b__3_0(bool hasSeasonPass);
}

// Namespace: PRISM.Interactions.Home
public class Model3dLoaderForHome : PRISM.Adapters.Home.IModel3dLoaderForHome
{
    private PRISM.Scenario.Model3dLoaderCore core;
    public PRISM.Scenario.ScenarioManager GetScenarioManager();
    public PRISM.LiveCharacterController GetLiveCharacterController();
    public PRISM.CameraController GetCameraController();
    public PRISM.BgObjectManager GetBgObjectManager();
    public PRISM.CutScene GetCutScene();
    public Cysharp.Threading.Tasks.UniTask SetUpAsync(string scenarioName, PRISM.UnitIdol[] unitIdols, int bgValue, int unitCount, System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask ReleaseAsync();
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=967 3113F0DC4EFB23D85B26F74339B223E0AF1A3577A74CF6C00DF3D143D3A80A76;
    private static __StaticArrayInitTypeSize=1563 CCB1EAB293CBCFF1455A48E4A6E9633B111C48E666F94BDB6412CC1866719632;

    private struct __StaticArrayInitTypeSize=967 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=1563 : System.ValueType
    {
    }
}
