
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
public class RunwayColorSelectPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IRunwayColorSelectPopupView, PRISM.Adapters.IClosablePopupFrame<System.Nullable<UnityEngine.Color>>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<System.Nullable<UnityEngine.Color>>
{
    private PRISM.Interactions.ColorPickerView colorPickerView;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<System.Nullable<UnityEngine.Color>> onClosed;
    private UnityEngine.Color resetColor;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<System.Nullable<UnityEngine.Color>> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Initialize(UnityEngine.Color currentColor, UnityEngine.Color resetColor);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__6_0();
    private void <CreateFrameParameter>b__6_1();
    private void <CreateFrameParameter>b__6_2();
    private void <CreateFrameParameter>b__6_3();
}

// Namespace: PRISM.Interactions
public class RunwayUnitEasyCostumeChangePopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IRunwayUnitEasyCostumeChangePopupView, PRISM.Adapters.IClosablePopupFrame<System.Nullable<PRISM.Live.LiveUnitRecommendCostume>>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<System.Nullable<PRISM.Live.LiveUnitRecommendCostume>>
{
    private PRISM.Interactions.ToggleGroupView easyCostumeChangeToggleGroupView;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<System.Nullable<PRISM.Live.LiveUnitRecommendCostume>> onClosed;
    private UniRx.ReactiveProperty<PRISM.Live.LiveUnitRecommendCostume> costume;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<System.Nullable<PRISM.Live.LiveUnitRecommendCostume>> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Initialize(PRISM.Live.LiveUnitRecommendCostume easyCostumeChangeSelected);
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

// Namespace: PRISM.Interactions
public class RunwayUnitRecommendPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IRunwayUnitRecommendPopupView, PRISM.Adapters.IClosablePopupFrame<System.Nullable<PRISM.Adapters.RunwayUnitRecommendConfig>>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<System.Nullable<PRISM.Adapters.RunwayUnitRecommendConfig>>
{
    private PRISM.Interactions.ToggleGroupView easyCostumeChangeToggleGroupView;
    private PRISM.Interactions.ToggleGroupView priorityToggleGroupView;
    private PRISM.Interactions.ToggleGroupView unitToggleGroupView;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<System.Nullable<PRISM.Adapters.RunwayUnitRecommendConfig>> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<System.Nullable<PRISM.Adapters.RunwayUnitRecommendConfig>> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Definitions.MstUnit, bool> <>9__6_2;
        private bool <CreateFrameParameter>b__6_2(PRISM.Definitions.MstUnit x);
    }

    private class <>c__DisplayClass6_0
    {
        public PRISM.Interactions.RunwayUnitRecommendPopupView <>4__this;
        public UniRx.ReactiveProperty<int> unitId;
        public UniRx.ReactiveProperty<PRISM.Live.LiveUnitRecommendCostume> costume;
        public UniRx.ReactiveProperty<PRISM.Adapters.RunwayUnitRecommendPriority> priority;
        private void <CreateFrameParameter>b__0();
        private void <CreateFrameParameter>b__1();
        private void <CreateFrameParameter>b__3();
    }
}

// Namespace: PRISM.Interactions
public class RunwayCostumeChangeConnector : PRISM.Interactions.RunwayViewConnector<PRISM.Adapters.RunwayCostumeChangeArgument>, PRISM.Adapters.IRunwayCostumeChangeConnector
{
    protected PRISM.Adapters.RunwayCostumeChangeArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
}

// Namespace: PRISM.Interactions
public class RunwayCostumeChangeView : UnityEngine.MonoBehaviour, PRISM.Adapters.IRunwayCostumeChangeView
{
    private PRISM.Interactions.CostumeChange.CostumeChangeView costumeChangeView;
    public PRISM.Adapters.CostumeChange.ICostumeChangeView CostumeChangeView { get; set; }
    private void Awake();
    private void OnDestroy();
}

// Namespace: PRISM.Interactions
public class FirstTimeAnimationView : UnityEngine.MonoBehaviour
{
    private UnityEngine.Animator animator;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource animationCompletionSource;
    private void Awake();
    public Cysharp.Threading.Tasks.UniTask PlayAnimationAsync(bool hasPlayedAnimation);
    public void OnAnimationEnd();

    private struct <PlayAnimationAsync>d__3 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.FirstTimeAnimationView <>4__this;
        public bool hasPlayedAnimation;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class RunwayEventTopConnector : PRISM.Interactions.RunwayViewConnector<PRISM.Adapters.RunwayEventArgument>, PRISM.Adapters.IRunwayEventTopConnector
{
    protected PRISM.Adapters.RunwayEventArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
}

// Namespace: PRISM.Interactions
public class RunwayEventTopView : UnityEngine.MonoBehaviour, PRISM.Adapters.IRunwayEventTopView
{
    private PRISM.Interactions.ButtonView runwayButton;
    private PRISM.Interactions.ButtonView shopButton;
    private PRISM.Interactions.ButtonView gashaButton;
    private PRISM.Interactions.ButtonView xButton;
    private PRISM.Interactions.ButtonView howToPlayButton;
    private PRISM.HowToPlayPopupOpener howToPlay;
    private PRISM.Interactions.ButtonView missionButton;
    private PRISM.Interactions.ViewStateChanger missionBadge;
    private PRISM.MoviePlayer moviePlayer;
    private PRISM.Interactions.FirstTimeAnimationView firstTimeAnimationView;
    public System.IObservable<UniRx.Unit> OnJumpToRunway { get; set; }
    public System.IObservable<UniRx.Unit> OnJumpToShop { get; set; }
    public System.IObservable<UniRx.Unit> OnJumpToGasha { get; set; }
    public System.IObservable<UniRx.Unit> OnJumpToX { get; set; }
    public System.IObservable<UniRx.Unit> OnMission { get; set; }
    private void Start();
    public void Initialize(UniRx.IReadOnlyReactiveProperty<bool> isOnMissionBadge);
    public Cysharp.Threading.Tasks.UniTask PlayAnimationAsync(bool hasPlayedAnimation);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <Start>b__20_0(UniRx.Unit _);
    private void <Initialize>b__21_0(bool b);

    private struct <PlayAnimationAsync>d__22 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.RunwayEventTopView <>4__this;
        public bool hasPlayedAnimation;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class RunwayUnitConfirmationConnector : PRISM.Interactions.RunwayViewConnector<PRISM.Adapters.RunwayEventArgument>, PRISM.Adapters.IRunwayUnitConfirmationConnector
{
    protected PRISM.Adapters.RunwayEventArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
}

// Namespace: PRISM.Interactions
public class RunwayUnitConfirmationView : UnityEngine.MonoBehaviour, PRISM.Adapters.IRunwayUnitConfirmationView
{
    private UnityEngine.UI.RawImage backgroundImage;
    private PRISM.Interactions.ButtonView openUnitListButton;
    private ENTERPRISE.UI.UITextMeshProUGUI unitNumberText;
    private PRISM.CommonInputFieldTMP unitNameInputField;
    private PRISM.Interactions.ButtonView recommendButton;
    private PRISM.Interactions.ButtonView resetButton;
    private TNRD.SerializableInterface<PRISM.Adapters.ILiveMvUnitListWindow> unitListWindow;
    private PRISM.Interactions.RunwayUnitEditCarousel unitCarousel;
    private PRISM.Interactions.ToggleGroupView unitTab;
    private UnityEngine.GameObject unitAllMemberChangeEffect;
    private PRISM.Interactions.ButtonView easyCostumeChangeButton;
    private PRISM.Interactions.ButtonView startButton;
    private PRISM.Interactions.ViewStateChanger startButtonStateChanger;
    public System.IObservable<UniRx.Unit> OnOpenUnitList { get; set; }
    public System.IObservable<string> OnChangeUnitName { get; set; }
    public System.IObservable<UniRx.Unit> OnRecommend { get; set; }
    public System.IObservable<UniRx.Unit> OnReset { get; set; }
    public System.IObservable<UniRx.Unit> OnEasyCostumeChange { get; set; }
    public System.IObservable<UniRx.Unit> OnStart { get; set; }
    public PRISM.Adapters.IRunwayUnitEditCarousel UnitListView { get; set; }
    public PRISM.Adapters.ILiveMvUnitListWindow UnitListWindow { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.RunwayUnitConfirmationModel model, string backgroundImagePath, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public void PlayMemberChangeEffect();
    public void Terminate();
    private void <InitializeAsync>b__29_0(PRISM.Adapters.RunwayUnit unit);
    private void <InitializeAsync>b__29_1(PRISM.Adapters.RunwayUnitConfirmationUnitEditTabType type);
    private void <InitializeAsync>b__29_2(bool x);
}

// Namespace: PRISM.Interactions
public class RunwayUnitEditCarousel : PRISM.Carousel<PRISM.Adapters.RunwayUnit, PRISM.Interactions.RunwayUnitEditCarouselContext>, PRISM.Adapters.IRunwayUnitEditCarousel
{
    private PRISM.Interactions.SwipeAndArrowChangerView changerView;
    private UnityEngine.GameObject blocker;
    public void Initialize(PRISM.Adapters.RunwayUnitEditCarouselViewModel viewModel, System.Collections.Generic.IList<PRISM.Adapters.RunwayUnit> unitList, UniRx.IReadOnlyReactiveProperty<int> selectedIndex, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void Select(int index);
    private System.IObservable<int> PRISM.Adapters.IRunwayUnitEditCarousel.get_OnSelectionChanged();
    private void <Initialize>b__2_0(UniRx.Pair<int> pair);
    private void <Initialize>b__2_1(int i);
    private void <Initialize>b__2_3();
    private void <Initialize>b__2_2(bool draggable);
}

// Namespace: PRISM.Interactions
public class RunwayUnitEditCarouselCell : PRISM.CarouselCell<PRISM.Adapters.RunwayUnit, PRISM.Interactions.RunwayUnitEditCarouselContext>
{
    private PRISM.Interactions.RunwayUnitEditCarouselIcon[] idolIcons;
    private PRISM.Adapters.RunwayUnit unit;
    private PRISM.AutoCancellationTokenSource canceller;
    public void Initialize();
    public void UpdateContent(PRISM.Adapters.RunwayUnit unit);
    private bool <Initialize>b__3_0();
    private void <Initialize>b__3_1(bool draggable);
    private Cysharp.Threading.Tasks.UniTask <Initialize>b__3_2(int fromIndex, int toIndex);
    private void <Initialize>b__3_3(PRISM.Adapters.RunwayUnitConfirmationUnitEditTabType type);

    private class <>c__DisplayClass4_0
    {
        public PRISM.Interactions.RunwayUnitEditCarouselCell <>4__this;
        public PRISM.Adapters.RunwayUnit unit;
    }

    private class <>c__DisplayClass4_1
    {
        public int index;
        public <>c__DisplayClass4_0 CS$<>8__locals1;
        private void <UpdateContent>b__0(PRISM.Adapters.RunwayUnitEditCarouselClickEventType type);
    }
}

// Namespace: PRISM.Interactions
public class RunwayUnitEditCarouselContext : PRISM.DefaultCarouselContext
{
    private System.Action<bool> <SetCarouselDraggable>k__BackingField;
    private PRISM.Adapters.RunwayUnitEditCarouselViewModel <ViewModel>k__BackingField;
    public System.Action<bool> SetCarouselDraggable { get; set; }
    public PRISM.Adapters.RunwayUnitEditCarouselViewModel ViewModel { get; set; }
}

// Namespace: PRISM.Interactions
public class RunwayUnitEditCarouselIcon : UnityEngine.MonoBehaviour, PRISM.Live.IDraggable
{
    private PRISM.Interactions.CharacterBaseIconView iconView;
    private PRISM.Interactions.ButtonView emptyButton;
    private PRISM.Interactions.ButtonView button;
    private PRISM.Interactions.ViewStateChanger positionMarkState;
    private UnityEngine.GameObject dragMark;
    private PRISM.UIGrayOutController grayOutController;
    private PRISM.Interactions.ViewStateChanger subIconViewStateChanger;
    private PRISM.Interactions.CostumeSetIconView costumeSetIconView;
    private PRISM.Interactions.ButtonView lightingColorButton;
    private UnityEngine.UI.Image lightingColor;
    private UnityEngine.Animations.ScaleConstraint scaleConstraint;
    public System.IObservable<PRISM.Adapters.RunwayUnitEditCarouselClickEventType> OnClick { get; set; }
    public UnityEngine.GameObject DragTargetObject { get; set; }
    public void Setup(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Adapters.RunwayUnitIdol idol, int position, System.Threading.CancellationToken ct);
    public void SetSubIconActive(PRISM.Adapters.RunwayUnitConfirmationUnitEditTabType type);
    public UnityEngine.GameObject BeginDrag(UnityEngine.Transform parent);
    public void EndDrag();
    private void _setDragStatus(bool isInDrag);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<UniRx.Unit, PRISM.Adapters.RunwayUnitEditCarouselClickEventType> <>9__12_0;
        public static System.Func<UniRx.Unit, PRISM.Adapters.RunwayUnitEditCarouselClickEventType> <>9__12_1;
        public static System.Func<PRISM.Definitions.CostumePartType, PRISM.Adapters.RunwayUnitEditCarouselClickEventType> <>9__12_2;
        public static System.Func<UniRx.Unit, PRISM.Adapters.RunwayUnitEditCarouselClickEventType> <>9__12_3;
        private PRISM.Adapters.RunwayUnitEditCarouselClickEventType <get_OnClick>b__12_0(UniRx.Unit _);
        private PRISM.Adapters.RunwayUnitEditCarouselClickEventType <get_OnClick>b__12_1(UniRx.Unit _);
        private PRISM.Adapters.RunwayUnitEditCarouselClickEventType <get_OnClick>b__12_2(PRISM.Definitions.CostumePartType category);
        private PRISM.Adapters.RunwayUnitEditCarouselClickEventType <get_OnClick>b__12_3(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions
public class RunwayViewConnector`1<TArgument> : PRISM.Interactions.ViewConnector<TArgument>
{
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=725 06247E0ADA02B6ECF4E7C08BEBE1F888E11EA56402A2688DD8DC42E9572AD187;
    private static __StaticArrayInitTypeSize=1527 6B3EB05BD336B1D8A67021F930381C6734FA5750CA6DA97D923A756AFBFB8AFB;

    private struct __StaticArrayInitTypeSize=725 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=1527 : System.ValueType
    {
    }
}
