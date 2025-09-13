
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

// Namespace: PRISM.Interactions.ADV
public class ADVLogActionNode : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI actionContent;
    private PRISM.Adapters.ADV.ADVLogActionNodeViewModel viewModel;
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.ADV.ADVLogActionNodeViewModel _viewModel);
}

// Namespace: PRISM.Interactions.ADV
public class ADVLogTalkNode : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI speakerText;
    private ENTERPRISE.UI.UITextMeshProUGUI speakerProducerText;
    private UnityEngine.GameObject speakerCharaBackGround;
    private UnityEngine.GameObject speakerProducerBackGround;
    private ENTERPRISE.UI.UITextMeshProUGUI talkContent;
    private PRISM.Interactions.ButtonView voiceButton;
    private UnityEngine.UI.Image voiceButtonOn;
    private UnityEngine.UI.Image voiceButtonOff;
    private UnityEngine.GameObject iconRoot;
    private UnityEngine.UI.RawImage charaIcon;
    private UnityEngine.UI.Image charaBackGround;
    private UnityEngine.UI.RawImage otherIcon;
    private UnityEngine.GameObject choiceIcon;
    private PRISM.Adapters.ADV.ADVLogTalkNodeViewModel viewModel;
    private PRISM.Interactions.ADV.ADVLogTalkNodeVoicePlaybackContainer talkNodeVoicePlaybackContainer;
    private CriWare.CriAtomExPlayback currentPlayVoicePlayback;
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.ADV.ADVLogTalkNodeViewModel viewModel, PRISM.Interactions.ADV.ADVLogTalkNodeVoicePlaybackContainer talkNodeVoicePlaybackContainer, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void Terminate();
    private void _setSpeaker();
    private Cysharp.Threading.Tasks.UniTask _onClickVoiceButtonAsync();
    private Cysharp.Threading.Tasks.UniTask _loadCharaIconAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private void <InitializeAsync>b__16_0(UniRx.Unit _);

    private class <>c__DisplayClass19_0
    {
        public PRISM.Interactions.ADV.ADVLogTalkNode <>4__this;
        public CriWare.CriAtomExPlayback playback;
        private bool <_onClickVoiceButtonAsync>b__0(CueInfo x);
        private bool <_onClickVoiceButtonAsync>b__1();
        private bool <_onClickVoiceButtonAsync>b__2();
    }

    private struct <InitializeAsync>d__16 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ADV.ADVLogTalkNode <>4__this;
        public PRISM.Adapters.ADV.ADVLogTalkNodeViewModel viewModel;
        public PRISM.Interactions.ADV.ADVLogTalkNodeVoicePlaybackContainer talkNodeVoicePlaybackContainer;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_loadCharaIconAsync>d__20 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ADV.ADVLogTalkNode <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private Awaiter<UnityEngine.Sprite> <>u__1;
        private Awaiter <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_onClickVoiceButtonAsync>d__19 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ADV.ADVLogTalkNode <>4__this;
        private <>c__DisplayClass19_0 <>8__1;
        private System.Threading.CancellationToken <ct>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.ADV
public class ADVLogTalkNodeVoicePlaybackContainer
{
    private System.Collections.Generic.List<CriWare.CriAtomExPlayback> playbacks;
    public void RegisterPlayback(CriWare.CriAtomExPlayback playback);
    public void StopAllVoices();
}

// Namespace: PRISM.Interactions.Adv
public class AdvLauncherConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.Adv.AdvLauncherArgument>, PRISM.Adv.IAdvLauncherConnector
{
    protected PRISM.Adapters.Adv.AdvLauncherArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
}

// Namespace: PRISM.Interactions.Adv
public class AdvLauncherView : UnityEngine.MonoBehaviour, PRISM.Adapters.Adv.IAdvLauncherView
{
    private PRISM.Interactions.Adv.AdvScreenView advScreenView;
    private static string ScenarioScene;
    private PRISM.Adv.AdvParameter parameter;
    private PRISM.SceneLoader sceneLoader;
    private PRISM.Interactions.Adv.AdvScreenView view;
    public PRISM.Adapters.Adv.IAdvScreenView AdvScreenView { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adv.AdvParameter parameter, OnScenarioManagerInitializedFunc onScenarioManagerInitializedFunc, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();

    private struct <InitializeAsync>d__7 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public System.Threading.CancellationToken ct;
        public PRISM.Interactions.Adv.AdvLauncherView <>4__this;
        public PRISM.Adv.AdvParameter parameter;
        public OnScenarioManagerInitializedFunc onScenarioManagerInitializedFunc;
        private Awaiter <>u__1;
        private object <>7__wrap1;
        private int <>7__wrap2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Adv
public class AdvChoiceButton : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView button;
    private ENTERPRISE.UI.UITextMeshProUGUI uiText;
    private UnityEngine.GameObject voIcon;
    private UnityEngine.GameObject daIcon;
    private UnityEngine.GameObject viIcon;
    private UnityEngine.GameObject meIcon;
    private UnityEngine.GameObject sdCharaIcon;
    private UnityEngine.UI.Image sdCharaImage;
    public System.IObservable<UniRx.Unit> OnClick { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adv.AdvChoiceButtonViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public void SetText(string text);

    private struct <InitializeAsync>d__10 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Adv.AdvChoiceButton <>4__this;
        public PRISM.Adv.AdvChoiceButtonViewModel viewModel;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Adv
public class AdvChoiceButtonGroup : UnityEngine.MonoBehaviour, PRISM.Adapters.Adv.IAdvChoiceButtonGroupView
{
    private System.Collections.Generic.List<PRISM.Interactions.Adv.AdvChoiceButton> buttonList;
    private int[] fourChoiceButtonsIndices;
    private UniRx.CompositeDisposable disposables;
    private UniRx.CompositeDisposable buttonDisposables;
    private UniRx.Subject<UniRx.Unit> onChoiceStart;
    private UniRx.Subject<UniRx.Unit> onChoiceFinish;
    private System.Threading.CancellationTokenSource cts;
    private PRISM.Scenario.ScenarioManager scenarioManager;
    private bool isSelected;
    public System.IObservable<UniRx.Unit> OnChoiceStart { get; set; }
    public System.IObservable<UniRx.Unit> OnChoiceFinish { get; set; }
    public void Inject(PRISM.Scenario.ScenarioManager scenarioManager);
    public void Initialize(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Adv.AdvChoiceButtonGroupViewModel viewModel);
    private Cysharp.Threading.Tasks.UniTask _showChoicesIfExistsOnUpdateAsync(PRISM.Adv.AdvChoiceButtonGroupViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void Terminate();
    private void _startChoice(int choiceNum);
    private Cysharp.Threading.Tasks.UniTask _setUpChoicesAsync(PRISM.Adv.AdvChoiceButtonGroupViewModel viewModel, int choiceNum, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask _decideChoiceAsync(int choiceNumber, System.Func<int, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask> onDecideChoiceAsync);

    private class <>c
    {
        public static <>c <>9;
        public static System.Action<PRISM.Interactions.Adv.AdvChoiceButton> <>9__14_0;
        public static System.Action<PRISM.Interactions.Adv.AdvChoiceButton> <>9__19_0;
        private void <Initialize>b__14_0(PRISM.Interactions.Adv.AdvChoiceButton x);
        private void <_decideChoiceAsync>b__19_0(PRISM.Interactions.Adv.AdvChoiceButton button);
    }

    private class <>c__DisplayClass14_0
    {
        public PRISM.Interactions.Adv.AdvChoiceButtonGroup <>4__this;
        public PRISM.Adv.AdvChoiceButtonGroupViewModel viewModel;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private void <Initialize>b__1(UniRx.Unit _);
    }

    private class <>c__DisplayClass18_0
    {
        public PRISM.Interactions.Adv.AdvChoiceButtonGroup <>4__this;
        public PRISM.Adv.AdvChoiceButtonGroupViewModel viewModel;
    }

    private class <>c__DisplayClass18_1
    {
        public int selectNo;
        public <>c__DisplayClass18_0 CS$<>8__locals1;
        private void <_setUpChoicesAsync>b__0(UniRx.Unit _);
    }

    private struct <_decideChoiceAsync>d__19 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Adv.AdvChoiceButtonGroup <>4__this;
        public int choiceNumber;
        public System.Func<int, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask> onDecideChoiceAsync;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_showChoicesIfExistsOnUpdateAsync>d__15 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Adv.AdvChoiceButtonGroup <>4__this;
        public PRISM.Adv.AdvChoiceButtonGroupViewModel viewModel;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private int <choiceNum>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Adv
public class AdvForceSkipButton : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView button;
    private UnityEngine.UI.Image defaultTextImage;
    private UnityEngine.UI.Image skipBeforeChoiceTextImage;
    public System.IObservable<UniRx.Unit> OnClick { get; set; }
    public void ToggleTextImage(bool choiceExists);
}

// Namespace: PRISM.Interactions.Adv
public class AdvMenuFader : UnityEngine.MonoBehaviour, PRISM.Adapters.Adv.IAdvMenuFader
{
    private float delayBeforeFadeoutSecond;
    private float fadeoutEndSecond;
    private UnityEngine.CanvasGroup canvasGroup;
    private PRISM.AutoCancellationTokenSource autoCts;
    public void Show();
    public void Hide();
    public void StartFadeOut();
    public void CancelFadeOut();
    public void Terminate();
    private void _toggleActive(bool isActive);

    private class <>c__DisplayClass6_0
    {
        public PRISM.Interactions.Adv.AdvMenuFader <>4__this;
        public System.Threading.CancellationToken ct;
        public DG.Tweening.TweenCallback <>9__1;
        private Cysharp.Threading.Tasks.UniTask <StartFadeOut>b__0();
        private void <StartFadeOut>b__1();

        private struct <<StartFadeOut>b__0>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
        {
            public int <>1__state;
            public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
            public <>c__DisplayClass6_0 <>4__this;
            private Awaiter <>u__1;
            private void MoveNext();
            private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }
}

// Namespace: PRISM.Interactions.Adv
public class AdvMenuFavoriteOptionButton : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView button;
    private PRISM.Interactions.ViewStateChanger isFavoriteStateChanger;
    private ENTERPRISE.UI.UITextMeshProUGUI buttonText;
    private bool isFavorite;
    public System.IObservable<UniRx.Unit> OnClick { get; set; }
    public void SetButtonText(string text);
    public void InitializeToggle(bool isFavorite);
    private void <get_OnClick>b__5_0(UniRx.Unit _);
}

// Namespace: PRISM.Interactions.Adv
public class AdvMenuHideOptionButton : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView button;
    private ENTERPRISE.UI.UITextMeshProUGUI buttonText;
    public System.IObservable<UniRx.Unit> OnClick { get; set; }
    public void SetButtonText(string text);
}

// Namespace: PRISM.Interactions.Adv
public class AdvMenuOptionButtonContainer : UnityEngine.MonoBehaviour, PRISM.Adapters.Adv.IAdvMenuButtonContainer
{
    private int closeAnimationName;
    private int closeIdleAnimationName;
    private int openAnimationName;
    private int openIdleAnimationName;
    private PRISM.Interactions.ButtonView advMenuOptionButton;
    private PRISM.Interactions.Adv.AdvMenuHideOptionButton hideOptionButton;
    private PRISM.Interactions.Adv.AdvMenuShowLogOptionButton showLogOptionButton;
    private PRISM.Interactions.Adv.AdvMenuSkipOptionButton skipOptionButton;
    private PRISM.Interactions.Adv.AdvMenuFavoriteOptionButton favoriteOptionButton;
    private UnityEngine.Animator openMenuAnimator;
    private PRISM.Scenario.ScenarioManager scenarioManager;
    private bool <IsMenuOpen>k__BackingField;
    public bool IsMenuOpen { get; set; }
    public System.IObservable<UniRx.Unit> OnClickMenuOptionButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickHideButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickShowLogButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickSkipButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickFavoriteButton { get; set; }
    public void Inject(PRISM.Scenario.ScenarioManager scenarioManager);
    public void Initialize(PRISM.Adapters.Adv.AdvMenuOptionButtonContainerViewModel viewModel);
    public Cysharp.Threading.Tasks.UniTask ShowAdvLogAsync(PRISM.Adv.IAdvScenarioInfo advScenarioInfo, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask<bool> ShowAdvSkipConfirmationPopupAsync(PRISM.Adv.IAdvScenarioInfo advScenarioInfo, System.Threading.CancellationToken ct);
    public void UpdateSkipButtonText();
    public void PlayOpenAnimation(bool skipAnimation);
    public void PlayCloseAnimation(bool skipAnimation);
    public void ToggleAnimation(bool skipAnimation);
    private void _toggleOpen(bool isOpen, bool skipAnimation);

    private class <>c__DisplayClass27_0
    {
        public PRISM.Adv.IAdvScenarioInfo advScenarioInfo;
        private PRISM.Adv.AdvTextLogTalkCellViewModel <ShowAdvLogAsync>b__0(TextLogData x);
    }
}

// Namespace: PRISM.Interactions.Adv
public class AdvMenuShowLogOptionButton : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView button;
    private ENTERPRISE.UI.UITextMeshProUGUI buttonText;
    public System.IObservable<UniRx.Unit> OnClick { get; set; }
    public void SetButtonText(string text);
}

// Namespace: PRISM.Interactions.Adv
public class AdvMenuSkipOptionButton : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView button;
    private ENTERPRISE.UI.UITextMeshProUGUI buttonText;
    public System.IObservable<UniRx.Unit> OnClick { get; set; }
    public void SetButtonText(string value);
}

// Namespace: PRISM.Interactions.Adv
public class AdvMenuView : UnityEngine.MonoBehaviour, PRISM.Adapters.Adv.IAdvMenuView
{
    private PRISM.Interactions.Adv.AdvMenuOptionButtonContainer advMenuOptionButtonContainer;
    private PRISM.Interactions.Adv.AdvMenuFader advMenuFader;
    private PRISM.Interactions.Adv.AdvForceSkipButton advForceSkipButton;
    private UniRx.Subject<bool> onToggleAutoPlay;
    private PRISM.Scenario.ScenarioManager scenarioManager;
    private bool isApplicationQuitting;
    private bool <IsAutoPlayActive>k__BackingField;
    private bool <IsUIActive>k__BackingField;
    public PRISM.Adapters.Adv.IAdvMenuFader AdvMenuFader { get; set; }
    public PRISM.Adapters.Adv.IAdvMenuButtonContainer AdvMenuOptionButtonContainer { get; set; }
    public System.IObservable<UniRx.Unit> OnClickAdvSkipButton { get; set; }
    public bool IsAutoPlayActive { get; set; }
    public bool IsUIActive { get; set; }
    public System.IObservable<bool> OnToggleAutoPlay { get; set; }
    public void Inject(PRISM.Scenario.ScenarioManager scenarioManager);
    public void Initialize();
    public void Terminate();
    public void SetActive(bool isActive);
    public void ShowUI();
    public void HideUI();
    public void PauseAdv();
    public void ResumeAdv();
    public void SkipAdv();
    public void ToggleAdvAutoPlay();
    public void ActivateAdvAutoPlay(bool isAutoPlayActive);
    public void ToggleAdvForceButtonText(bool choiceExists);
    private void OnApplicationQuit();
    private void OnDestroy();
    private void <SkipAdv>b__30_0();
}

// Namespace: PRISM.Interactions.Adv
public class AdvScreenView : UnityEngine.MonoBehaviour, PRISM.Adapters.Adv.IAdvScreenView
{
    private PRISM.Interactions.AdvTitleView titleView;
    private PRISM.Interactions.Adv.AdvMenuView advMenu;
    private PRISM.Interactions.Adv.AdvSkipGaugeView advSkipGauge;
    private PRISM.Interactions.Adv.AdvChoiceButtonGroup advChoiceButtonGroup;
    private PRISM.Interactions.ButtonView tapRecognizer;
    private UnityEngine.GameObject[] hideOnAdvEndTargets;
    private PRISM.Scenario.ScenarioManager scenarioManager;
    private UniRx.CompositeDisposable disposables;
    private UniRx.Subject<UniRx.Unit> onTapped;
    private UniRx.Subject<UniRx.Unit> onTerminated;
    public System.IObservable<UniRx.Unit> OnScreenTapped { get; set; }
    public System.IObservable<UniRx.Unit> OnAdvTerminated { get; set; }
    public PRISM.Adapters.IAdvTitleView TitleView { get; set; }
    public PRISM.Adapters.Adv.IAdvMenuView AdvMenu { get; set; }
    public PRISM.Adapters.Adv.IAdvSkipGaugeView AdvSkipGauge { get; set; }
    public PRISM.Adapters.Adv.IAdvChoiceButtonGroupView AdvChoiceButtonGroup { get; set; }
    public void Inject(PRISM.Scenario.ScenarioManager scenarioManager);
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adv.AdvScreenViewModel viewModel, System.Func<bool> tapInvoker, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public void Terminate();
    public void SetActive(bool isActive);
    public void HideObjectsNeedHideOnAdvEnd();
    public void ActivateTapInput(bool isActive);
    public bool ChoiceExists();
    public void ResumeAdvSkip();
    private void <InitializeAsync>b__23_3();
    private void <InitializeAsync>b__23_0(UniRx.Unit _);
    private void <InitializeAsync>b__23_1(UnityEngine.EventSystems.PointerEventData _);
    private void <InitializeAsync>b__23_2(UnityEngine.EventSystems.PointerEventData _);
}

// Namespace: PRISM.Interactions.Adv
public class AdvSkipGaugeView : UnityEngine.MonoBehaviour, PRISM.Adapters.Adv.IAdvSkipGaugeView
{
    private UnityEngine.CanvasGroup canvasGroup;
    private ENTERPRISE.UI.AnimatorWithEvent animator;
    private UnityEngine.UI.Image skipTextImage;
    private UnityEngine.UI.Image choiceSkipTextImage;
    private float fadeDurationSeconds;
    private float fadeStartSeconds;
    private int animatorHashLongTapped;
    private UniRx.CompositeDisposable disposables;
    private FadeHandler fadeHandler;
    private UniRx.Subject<UniRx.Unit> onLongTap;
    private bool <IsLongTapEnabled>k__BackingField;
    public bool IsLongTapEnabled { get; set; }
    public System.IObservable<UniRx.Unit> OnLongTap { get; set; }
    public void Initialize(bool choiceExists);
    public void Terminate();
    public void ToggleSkipTexts(bool hasChoice);
    public void StartAnimation();
    public void ForceFinishAnimation();
    private void _onRunEvent(string eventTag);

    private class FadeHandler : System.IDisposable
    {
        private UnityEngine.CanvasGroup canvasGroup;
        private float fadeDurationSeconds;
        private System.Threading.CancellationTokenSource cts;
        public Cysharp.Threading.Tasks.UniTask FadeAsync(float targetAlpha, float fadeStartSeconds);
        public void Dispose();

        private struct <FadeAsync>d__4 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
        {
            public int <>1__state;
            public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
            public FadeHandler <>4__this;
            public float fadeStartSeconds;
            public float targetAlpha;
            private System.Threading.CancellationToken <token>5__2;
            private Awaiter <>u__1;
            private void MoveNext();
            private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }
}

// Namespace: PRISM.Interactions.Adv
public class AdvSkipConfirmationPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.Adv.IAdvSkipConfirmationPopupView, PRISM.Adapters.IClosablePopupFrame<System.ValueTuple<bool, bool>>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<System.ValueTuple<bool, bool>>
{
    private ENTERPRISE.UI.UITextMeshProUGUI topText;
    private ENTERPRISE.UI.UITextMeshProUGUI skipPopupFromNextTimeText;
    private ENTERPRISE.UI.UITextMeshProUGUI notionText;
    private PRISM.Interactions.ToggleButtonView toggle;
    private UnityEngine.GameObject advInformationField;
    private ENTERPRISE.UI.UITextMeshProUGUI mainHeadline;
    private ENTERPRISE.UI.UITextMeshProUGUI subHeadline;
    private ENTERPRISE.UI.UITextMeshProUGUI summary;
    private PopupSizeType sizeType;
    private UniRx.ReactiveProperty<bool> shouldSkipPopupFromNextTime;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<System.ValueTuple<bool, bool>> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<System.ValueTuple<bool, bool>> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Initialize(PRISM.Adapters.Adv.AdvSkipConfirmationPopupViewModel viewModel);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__14_0();
    private void <CreateFrameParameter>b__14_1();
    private void <CreateFrameParameter>b__14_2();
}

// Namespace: PRISM.Interactions.Adv
public class AdvTextLogOverlayView : PRISM.Interactions.OverlayViewWithCloseButton, PRISM.Adapters.Adv.IAdvTextLogOverlayView, PRISM.Adapters.IClosableOverlayView<UniRx.Unit>, PRISM.Adapters.IOverlayView, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private UnityEngine.UI.ScrollRect scrollRect;
    private ENTERPRISE.UI.UITextMeshProUGUI title;
    private UnityEngine.Transform cellParent;
    private PRISM.Interactions.Adv.AdvTextLogTalkCell talkCellPrefab;
    private PRISM.Interactions.ADV.ADVLogTalkNodeVoicePlaybackContainer voicePlaybackContainer;
    private Cysharp.Threading.Tasks.UniTask PRISM.Adapters.IOverlayView.HideAsync();
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.Adv.AdvTextLogOverlayViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);

    private struct <InitializeAsync>d__6 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Adv.AdvTextLogOverlayView <>4__this;
        public PRISM.Adapters.Adv.AdvTextLogOverlayViewModel viewModel;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Adv
public class AdvTextLogTalkCell : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI speakerText;
    private ENTERPRISE.UI.UITextMeshProUGUI speakerProducerText;
    private UnityEngine.GameObject speakerCharaBackGround;
    private UnityEngine.GameObject speakerProducerBackGround;
    private ENTERPRISE.UI.UITextMeshProUGUI talkContent;
    private PRISM.Interactions.ButtonView voiceButton;
    private UnityEngine.UI.Image voiceButtonOn;
    private UnityEngine.UI.Image voiceButtonOff;
    private UnityEngine.UI.RawImage charaIcon;
    private UnityEngine.UI.Image charaBackGround;
    private UnityEngine.UI.Image otherIcon;
    private UnityEngine.GameObject choiceIcon;
    private UniRx.CompositeDisposable disposables;
    private PRISM.AutoCancellationTokenSource voicePlayAutoCts;
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adv.AdvTextLogTalkCellViewModel viewModel, PRISM.Interactions.ADV.ADVLogTalkNodeVoicePlaybackContainer playbackContainer, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    private void _setSpeakerName(PRISM.Adv.AdvTextLogTalkCellViewModel viewModel);
    private Cysharp.Threading.Tasks.UniTask _initializeIconAsync(PRISM.Adv.AdvTextLogTalkCellViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask _playVoiceAsync(PRISM.Adv.AdvTextLogTalkCellViewModel viewModel, PRISM.Interactions.ADV.ADVLogTalkNodeVoicePlaybackContainer voicePlaybackContainer);

    private class <>c__DisplayClass14_0
    {
        public PRISM.Interactions.Adv.AdvTextLogTalkCell <>4__this;
        public PRISM.Adv.AdvTextLogTalkCellViewModel viewModel;
        public PRISM.Interactions.ADV.ADVLogTalkNodeVoicePlaybackContainer playbackContainer;
        private void <InitializeAsync>b__0(UniRx.Unit _);
    }

    private class <>c__DisplayClass17_0
    {
        public PRISM.Adv.AdvTextLogTalkCellViewModel viewModel;
        public CriWare.CriAtomExPlayback playback;
        private bool <_playVoiceAsync>b__0(CueInfo x);
        private bool <_playVoiceAsync>b__1();
        private bool <_playVoiceAsync>b__2();
    }

    private struct <_playVoiceAsync>d__17 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Adv.AdvTextLogTalkCellViewModel viewModel;
        public PRISM.Interactions.Adv.AdvTextLogTalkCell <>4__this;
        public PRISM.Interactions.ADV.ADVLogTalkNodeVoicePlaybackContainer voicePlaybackContainer;
        private <>c__DisplayClass17_0 <>8__1;
        private System.Threading.CancellationTokenSource <linkedTokenSource>5__2;
        private System.Threading.CancellationToken <ct>5__3;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=1016 651FA02F4B346AC05C8D92B1C21364887718AADE548E05B4E53066CEA2F4ADD7;
    private static __StaticArrayInitTypeSize=24 922DD13CBBA8C80BC5D3792B7FFBF5CB5EFA862DB979F5469C5403A58619AE84;
    private static __StaticArrayInitTypeSize=1702 B05512BC4556CF898900ACFA080B2178EDDC8C2FB2AD658AC73B9966DE172168;

    private struct __StaticArrayInitTypeSize=24 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=1016 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=1702 : System.ValueType
    {
    }
}
