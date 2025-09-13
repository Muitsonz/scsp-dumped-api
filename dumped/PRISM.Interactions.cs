
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

// Namespace: PRISM.UI
public class OnDragSender : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IEndDragHandler
{
    private UnityEngine.Component target;
    public void SetTarget(UnityEngine.Component target);
    private void UnityEngine.EventSystems.IDragHandler.OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
    private void UnityEngine.EventSystems.IBeginDragHandler.OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
    private void UnityEngine.EventSystems.IEndDragHandler.OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
}

// Namespace: PRISM.Interactions
public class AnimationClipPlayer : UnityEngine.MonoBehaviour
{
    public UnityEngine.Animator animator;
    public UnityEngine.AnimationClip clip;
    public ClipPlayableInfo Prepare();

    public struct ClipPlayableInfo : System.ValueType, System.IDisposable, System.IEquatable<ClipPlayableInfo>
    {
        private UnityEngine.Playables.PlayableGraph <Graph>k__BackingField;
        private UnityEngine.Animations.AnimationPlayableOutput <Output>k__BackingField;
        private UnityEngine.Animations.AnimationClipPlayable <Playable>k__BackingField;
        private UnityEngine.AnimationClip <Clip>k__BackingField;
        public UnityEngine.Playables.PlayableGraph Graph { get; set; }
        public UnityEngine.Animations.AnimationPlayableOutput Output { get; set; }
        public UnityEngine.Animations.AnimationClipPlayable Playable { get; set; }
        public UnityEngine.AnimationClip Clip { get; set; }
        public void Dispose();
        public void Skip();
        public string ToString();
        private bool PrintMembers(System.Text.StringBuilder builder);
        public static bool op_Inequality(ClipPlayableInfo left, ClipPlayableInfo right);
        public static bool op_Equality(ClipPlayableInfo left, ClipPlayableInfo right);
        public int GetHashCode();
        public bool Equals(object obj);
        public bool Equals(ClipPlayableInfo other);
        public void Deconstruct(UnityEngine.Playables.PlayableGraph& Graph, UnityEngine.Animations.AnimationPlayableOutput& Output, UnityEngine.Animations.AnimationClipPlayable& Playable, UnityEngine.AnimationClip& Clip);
    }
}

// Namespace: PRISM.Interactions
public class GoToContentCellView : EnhancedUI.EnhancedScroller.EnhancedScrollerCellView
{
    private float cellSize;
    private ENTERPRISE.UI.UITextMeshProUGUI contentName;
    private PRISM.Interactions.ButtonView button;
    private ENTERPRISE.UI.UITextMeshProUGUI buttonText;
    private PRISM.AutoCancellationTokenSource autoCancellationToken;
    public float CellSize { get; set; }
    public void Setup(PRISM.Module.Networking.IJumpStatus jumpStatus, PRISM.Adapters.HowToReleaseCostumeListContext context);
    private void OnDestroy();

    private class <>c__DisplayClass7_0
    {
        public PRISM.Adapters.HowToReleaseCostumeListContext context;
        public PRISM.Module.Networking.IJumpStatus jumpStatus;
        private void <Setup>b__0(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions
public class GoToProduceIdolCellView : EnhancedUI.EnhancedScroller.EnhancedScrollerCellView
{
    private float cellSize;
    private PRISM.Interactions.ProduceIdolIconViewWithStar produceIdolIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI idolName;
    private PRISM.Interactions.ButtonView button;
    private ENTERPRISE.UI.UITextMeshProUGUI buttonText;
    private PRISM.AutoCancellationTokenSource autoCancellationToken;
    public float CellSize { get; set; }
    public void Setup(PRISM.Module.Networking.IJumpStatus jumpStatus, int mstProduceIdolId, int releaseStar, bool owned, PRISM.Adapters.HowToReleaseCostumeListContext context);
    private void OnDestroy();

    private class <>c__DisplayClass8_0
    {
        public PRISM.Adapters.HowToReleaseCostumeListContext context;
        public PRISM.Module.Networking.IJumpStatus jumpStatus;
        private void <Setup>b__0(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions
public class HowToReleaseCostumeList : UnityEngine.MonoBehaviour, EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate
{
    private EnhancedUI.EnhancedScroller.EnhancedScroller scroller;
    private PRISM.Interactions.GoToProduceIdolCellView goToProduceIdolCellPrefab;
    private PRISM.Interactions.GoToContentCellView gotoContentCellPrefab;
    private System.Collections.Generic.IReadOnlyList<PRISM.Adapters.UnlockLinkModel> unlockLinkList;
    public PRISM.Adapters.HowToReleaseCostumeListContext Context;
    public void Initialize(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.UnlockLinkModel> unlockLinkList, PRISM.Adapters.HowToReleaseCostumeListContext context);
    private void OnDestroy();
    private void _scrollerCellViewVisibilityChanged(EnhancedUI.EnhancedScroller.EnhancedScrollerCellView cellView);
    private int EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate.GetNumberOfCells(EnhancedUI.EnhancedScroller.EnhancedScroller scroller);
    private float EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate.GetCellViewSize(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex);
    private EnhancedUI.EnhancedScroller.EnhancedScrollerCellView EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate.GetCellView(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex, int cellIndex);
}

// Namespace: PRISM.Interactions
public class HowToReleaseCostumePopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IHowToReleaseCostumePopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.ViewStateChanger costumeSetOrSingleViewStateChanger;
    private PRISM.Interactions.HorizontalAutoScrollingText setName;
    private PRISM.Interactions.CostumeSetIconView costumeSetIconView;
    private PRISM.Interactions.CostumeIconView costumeIcon;
    private PRISM.Interactions.HorizontalAutoScrollingText costumeName;
    private PRISM.Interactions.HowToReleaseCostumeList list;
    private bool isCostumeSet;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Initialize(PRISM.Adapters.HowToReleaseCostumeModel model, PRISM.Adapters.HowToReleaseCostumeListContext context);
    private void _initializeCostumeSet(PRISM.Domain.ProductKey productKey, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private void _initializeCostume(PRISM.Domain.ProductKey productKey, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <Initialize>b__10_0(PRISM.Module.Networking.IJumpStatus _);
    private void <CreateFrameParameter>b__13_0();
    private void <CreateFrameParameter>b__13_1();
}

// Namespace: PRISM.Interactions
public class ButtonViewExtensions
{
    public static System.IObservable<UniRx.Unit> OnClickWithBackKey(PRISM.Interactions.ButtonView button);

    private class <>c__DisplayClass0_0
    {
        public PRISM.Interactions.ButtonView button;
        private void <OnClickWithBackKey>b__0(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions
public class NativeShareExtensions
{
    public static Cysharp.Threading.Tasks.UniTask AddScreenshotAsync(NativeShare self, UnityEngine.MonoBehaviour coroutineRunner, System.Threading.CancellationToken cancellationToken, System.Nullable<float> aspectRatio, bool isTransparent);
    public static NativeShare AddFile(NativeShare self, byte[] data, string fileName);
    public static Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ShareResult, string>> ShareAsync(NativeShare self);

    private class <>c__DisplayClass2_0
    {
        public Cysharp.Threading.Tasks.UniTaskCompletionSource<System.ValueTuple<ShareResult, string>> tcs;
        private void <ShareAsync>b__0(ShareResult result, string target);
    }

    private struct <AddScreenshotAsync>d__0 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public UnityEngine.MonoBehaviour coroutineRunner;
        public System.Threading.CancellationToken cancellationToken;
        public System.Nullable<float> aspectRatio;
        public bool isTransparent;
        public NativeShare self;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class ResourceLoaderExtensions
{
    public static Cysharp.Threading.Tasks.UniTask<UnityEngine.Sprite> LoadFesIdolRankSpriteAsync(PRISM.ResourceManagement.IResourceLoader loader, ProduceParameterRank rank, bool isSmall, System.Threading.CancellationToken ct);
    public static Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadBaseSkillCostAsync(PRISM.ResourceManagement.IResourceLoader loader, bool active, System.Threading.CancellationToken ct);
    public static Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadRewardListIdolStoryIconAsync(PRISM.ResourceManagement.IResourceLoader loader, System.Threading.CancellationToken ct);
}

// Namespace: PRISM.Interactions
public class UniRxExtension
{
    public static System.IObservable<TCellView> CellViewVisibilityChangedAsObservable<TCellView>(EnhancedUI.EnhancedScroller.EnhancedScroller scroller);
    public static System.IObservable<TCellView> CellViewWillRecycleAsObservable<TCellView>(EnhancedUI.EnhancedScroller.EnhancedScroller scroller);
    public static System.IObservable<System.ValueTuple<UnityEngine.Vector2, float>> ScrollerScrolledAsObservable(EnhancedUI.EnhancedScroller.EnhancedScroller scroller);
    public static System.IObservable<UniRx.Unit> ScrollerReachedUpperLimit(EnhancedUI.EnhancedScroller.EnhancedScroller scroller);
    public static System.IObservable<UniRx.Unit> ScrollerReachedLowerLimit(EnhancedUI.EnhancedScroller.EnhancedScroller scroller);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<System.Action<System.ValueTuple<UnityEngine.Vector2, float>>, EnhancedUI.EnhancedScroller.ScrollerScrolledDelegate> <>9__2_0;
        public static System.Func<System.ValueTuple<UnityEngine.Vector2, float>, bool> <>9__3_0;
        public static System.Func<System.ValueTuple<UnityEngine.Vector2, float>, UniRx.Unit> <>9__3_1;
        public static System.Func<System.ValueTuple<UnityEngine.Vector2, float>, bool> <>9__4_0;
        public static System.Func<System.ValueTuple<UnityEngine.Vector2, float>, UniRx.Unit> <>9__4_1;
        private EnhancedUI.EnhancedScroller.ScrollerScrolledDelegate <ScrollerScrolledAsObservable>b__2_0(System.Action<System.ValueTuple<UnityEngine.Vector2, float>> h);
        private bool <ScrollerReachedUpperLimit>b__3_0(System.ValueTuple<UnityEngine.Vector2, float> value);
        private UniRx.Unit <ScrollerReachedUpperLimit>b__3_1(System.ValueTuple<UnityEngine.Vector2, float> _);
        private bool <ScrollerReachedLowerLimit>b__4_0(System.ValueTuple<UnityEngine.Vector2, float> value);
        private UniRx.Unit <ScrollerReachedLowerLimit>b__4_1(System.ValueTuple<UnityEngine.Vector2, float> _);
    }

    private class <>c__0`1<TCellView>
    {
        public static <>c__0<TCellView> <>9;
        public static System.Func<System.Action<TCellView>, EnhancedUI.EnhancedScroller.CellViewVisibilityChangedDelegate> <>9__0_0;
        private EnhancedUI.EnhancedScroller.CellViewVisibilityChangedDelegate <CellViewVisibilityChangedAsObservable>b__0_0(System.Action<TCellView> h);
    }

    private class <>c__1`1<TCellView>
    {
        public static <>c__1<TCellView> <>9;
        public static System.Func<System.Action<TCellView>, EnhancedUI.EnhancedScroller.CellViewWillRecycleDelegate> <>9__1_0;
        private EnhancedUI.EnhancedScroller.CellViewWillRecycleDelegate <CellViewWillRecycleAsObservable>b__1_0(System.Action<TCellView> h);
    }

    private class <>c__DisplayClass0_0`1<TCellView>
    {
        public EnhancedUI.EnhancedScroller.EnhancedScroller scroller;
        private void <CellViewVisibilityChangedAsObservable>b__1(EnhancedUI.EnhancedScroller.CellViewVisibilityChangedDelegate h);
        private void <CellViewVisibilityChangedAsObservable>b__2(EnhancedUI.EnhancedScroller.CellViewVisibilityChangedDelegate h);
    }

    private class <>c__DisplayClass0_1`1<TCellView>
    {
        public System.Action<TCellView> h;
        private void <CellViewVisibilityChangedAsObservable>b__3(EnhancedUI.EnhancedScroller.EnhancedScrollerCellView cellView);
    }

    private class <>c__DisplayClass1_0`1<TCellView>
    {
        public EnhancedUI.EnhancedScroller.EnhancedScroller scroller;
        private void <CellViewWillRecycleAsObservable>b__1(EnhancedUI.EnhancedScroller.CellViewWillRecycleDelegate h);
        private void <CellViewWillRecycleAsObservable>b__2(EnhancedUI.EnhancedScroller.CellViewWillRecycleDelegate h);
    }

    private class <>c__DisplayClass1_1`1<TCellView>
    {
        public System.Action<TCellView> h;
        private void <CellViewWillRecycleAsObservable>b__3(EnhancedUI.EnhancedScroller.EnhancedScrollerCellView cellVIew);
    }

    private class <>c__DisplayClass2_0
    {
        public EnhancedUI.EnhancedScroller.EnhancedScroller scroller;
        private void <ScrollerScrolledAsObservable>b__1(EnhancedUI.EnhancedScroller.ScrollerScrolledDelegate h);
        private void <ScrollerScrolledAsObservable>b__2(EnhancedUI.EnhancedScroller.ScrollerScrolledDelegate h);
    }

    private class <>c__DisplayClass2_1
    {
        public System.Action<System.ValueTuple<UnityEngine.Vector2, float>> h;
        private void <ScrollerScrolledAsObservable>b__3(EnhancedUI.EnhancedScroller.EnhancedScroller enhancedScroller, UnityEngine.Vector2 value, float scrollPosition);
    }
}

// Namespace: PRISM.Interactions
public class FullScreenMovieView : UnityEngine.MonoBehaviour
{
    private PRISM.MoviePlayer player;
    private PRISM.Interactions.ButtonView skipButton;
    private UnityEngine.GameObject tapSkipObject;
    private System.Threading.CancellationTokenSource skipToken;
    private System.IDisposable skipDisposable;
    private System.Func<Cysharp.Threading.Tasks.UniTask> onMovieEndFunc;
    public void RegisterOnMovieEndCallback(System.Func<Cysharp.Threading.Tasks.UniTask> onMovieEndFunc);
    public Cysharp.Threading.Tasks.UniTask PlayAsync(string moviePath);
    private void _enableSkip();
    private static Cysharp.Threading.Tasks.UniTask<bool> _showConfirmSkipPopupAsync(System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTaskVoid <_enableSkip>b__8_0(UniRx.Unit _);

    private struct <<_enableSkip>b__8_0>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
        public PRISM.Interactions.FullScreenMovieView <>4__this;
        private Awaiter<bool> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <PlayAsync>d__7 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.FullScreenMovieView <>4__this;
        public string moviePath;
        private ENTERPRISE.NonSleepingScope <>7__wrap1;
        private Awaiter<bool> <>u__1;
        private Awaiter <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class GashaButton : UnityEngine.MonoBehaviour, System.IDisposable
{
    private UnityEngine.UI.Image imgBtn;
    private ENTERPRISE.UI.ColorToOutlineForTextMeshProUGUI outLine;
    private ENTERPRISE.UI.UITextMeshProUGUI txtTitle;
    private ENTERPRISE.UI.UITextMeshProUGUI txtCost;
    private UnityEngine.GameObject goBdgDot;
    private UnityEngine.GameObject goIcoPaid;
    private UnityEngine.UI.RawImage imgIco;
    private ENTERPRISE.UI.UITextMeshProUGUI txtFukidasiNormal;
    private ENTERPRISE.UI.UITextMeshProUGUI txtFukidasiEmphasis;
    private ENTERPRISE.UI.UITextMeshProUGUI txtDisable;
    private PRISM.Interactions.ButtonView btn;
    private PRISM.Module.Networking.IGashaPriceStatus gashaPrice;
    private string gashaId;
    private UniRx.CompositeDisposable disposables;
    public void Setup(string gashaId, PRISM.Module.Networking.IGashaPriceStatus gashaPrice, System.Action<string, string> OnClick, bool isResult);
    public Cysharp.Threading.Tasks.UniTask SetupAsync(string gashaId, PRISM.Module.Networking.IGashaPriceStatus gashaPrice, PRISM.ResourceManagement.IResourceLoader loader, System.Action<string, string> OnClick, bool isResult, System.Threading.CancellationToken ct);
    public void UpdateAmount(PRISM.Module.Networking.IGashaPriceStatus gashaPrice, long amount, bool isResult);
    public void Dispose();

    private class <>c__DisplayClass15_0
    {
        public System.Action<string, string> OnClick;
        public PRISM.Interactions.GashaButton <>4__this;
        private void <SetupAsync>b__0(UniRx.Unit _);
    }

    private struct <SetupAsync>d__15 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public System.Action<string, string> OnClick;
        public PRISM.Interactions.GashaButton <>4__this;
        public PRISM.Module.Networking.IGashaPriceStatus gashaPrice;
        public PRISM.ResourceManagement.IResourceLoader loader;
        public string gashaId;
        public System.Threading.CancellationToken ct;
        private <>c__DisplayClass15_0 <>8__1;
        public bool isResult;
        private bool <isJewel>5__2;
        private bool <isMedal>5__3;
        private Awaiter<PRISM.Module.Networking.IHavingProductStatus> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class GashaTokenArea : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.RawImage imgToken;
    private ENTERPRISE.UI.UITextMeshProUGUI txtNm;
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Module.Networking.IProductStatus product, System.Threading.CancellationToken ct, int maxSize);
    public void Setup(PRISM.Module.Networking.IHavingProductStatus token, int maxSize);
    public void UpdateAmount(long amount, int maxSize);

    private struct <SetupAsync>d__2 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Module.Networking.IProductStatus product;
        public System.Threading.CancellationToken ct;
        public PRISM.Interactions.GashaTokenArea <>4__this;
        public int maxSize;
        private Awaiter<PRISM.Module.Networking.IHavingProductStatus> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public interface IInteractionLocator
{
    private static PRISM.Interactions.IInteractionLocator <Instance>k__BackingField;
    public PRISM.Interactions.IInteractionLocator Instance { get; set; }
    public PRISM.Interactions.IOverlayInstantiator OverlayInstantiator { get; set; }
    public PRISM.Adapters.IBackKeyObservable BackKeyObservable { get; set; }
    public PRISM.Adapters.ICommonSequencerContainer CommonSequencerContainer { get; set; }
    public PRISM.Definitions.MasterData MasterData { get; set; }
    public ENTERPRISE.Localization.LocalizationManager LocalizationManager { get; set; }
    public PRISM.Adapters.Reporter.ICrashlytics Crashlytics { get; set; }
    public PRISM.Adapters.Reporter.IAnalytics Analytics { get; set; }
    public PRISM.ITutorialSequenceContext TutorialContext { get; set; }
    public ENTERPRISE.ViewManager ViewManager { get; set; }
    public PRISM.ErrorModalWindow ErrorModalWindow { get; set; }
}

// Namespace: PRISM.Interactions
public class ItemSetDetailCellContainerView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ItemSetDetailCellView cellPrefab;
    private UnityEngine.Transform cellParent;
    private ENTERPRISE.UI.UITextMeshProUGUI headLineText;
    private UnityEngine.GameObject emptyView;
    private UniRx.Subject<PRISM.Adapters.ItemSetDetailCellViewModel> onClickItemIcon;
    private UniRx.CompositeDisposable disposables;
    private PRISM.Interactions.ResettableComponentPool<PRISM.Interactions.ItemSetDetailCellView> cellPool;
    public System.IObservable<PRISM.Adapters.ItemSetDetailCellViewModel> OnClickItemIcon { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.ItemSetDetailCellViewModel> cellViewModels, PRISM.ResourceManagement.IResourceLoader resourceLoader, string headline, System.Threading.CancellationToken cancellationToken);
    private void OnDestroy();

    private class <>c__DisplayClass9_0
    {
        public PRISM.Interactions.ItemSetDetailCellContainerView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken cancellationToken;
        private Cysharp.Threading.Tasks.UniTask <InitializeAsync>b__0(PRISM.Adapters.ItemSetDetailCellViewModel x);
    }

    private class <>c__DisplayClass9_1
    {
        public PRISM.Adapters.ItemSetDetailCellViewModel x;
        public <>c__DisplayClass9_0 CS$<>8__locals1;
        private void <InitializeAsync>b__1(PRISM.Adapters.ItemSetDetailCellViewModel _);
    }

    private struct <InitializeAsync>d__9 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ItemSetDetailCellContainerView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken cancellationToken;
        public string headline;
        public System.Collections.Generic.IReadOnlyList<PRISM.Adapters.ItemSetDetailCellViewModel> cellViewModels;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class ItemSetDetailCellView : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.OutGame.ItemIconView itemIconView;
    private PRISM.Interactions.ButtonView itemIconButton;
    private ENTERPRISE.UI.UITextMeshProUGUI itemNameText;
    private ENTERPRISE.UI.UITextMeshProUGUI itemAmountText;
    private PRISM.Adapters.ItemSetDetailCellViewModel viewModel;
    public System.IObservable<PRISM.Adapters.ItemSetDetailCellViewModel> OnClickItemIcon { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.ItemSetDetailCellViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    private PRISM.Adapters.ItemSetDetailCellViewModel <get_OnClickItemIcon>b__6_0(UniRx.Unit _);
}

// Namespace: PRISM.Interactions
public class CountToggleButtonView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView button;
    private ENTERPRISE.UI.UITextMeshProUGUI countText;
    public void Initialize(UniRx.IReactiveProperty<int> currentIndex, int totalCount);

    private class <>c__DisplayClass2_0
    {
        public UniRx.IReactiveProperty<int> currentIndex;
        public int totalCount;
        public PRISM.Interactions.CountToggleButtonView <>4__this;
        private void <Initialize>b__0(UniRx.Unit _);
        private void <Initialize>b__1(int type);
    }
}

// Namespace: PRISM.Interactions
public class LiveEventRankingGradeIcon : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.Image icon;
    private UnityEngine.Sprite[] iconSprites;
    public void Show(EventRankGrade grade);
}

// Namespace: PRISM.Interactions
public class MusicBasicInfoView : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.RawImage typeIcon;
    private PRISM.Interactions.AttributeIconView attributeIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI nameText;
    private PRISM.Interactions.ViewStateChanger difficultyStateChanger;
    private PRISM.Interactions.ViewStateChanger unitStateChanger;
    private ENTERPRISE.UI.UITextMeshProUGUI levelText;
    public Cysharp.Threading.Tasks.UniTask SetUpAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Definitions.MstSong master, SongDifficultyLevel difficulty, System.Threading.CancellationToken ct);
}

// Namespace: PRISM.Interactions
public class MusicRateGradients : UnityEngine.ScriptableObject
{
    private UnityEngine.Gradient[] gradients;
    public UnityEngine.Gradient Get(int level);
}

// Namespace: PRISM.Interactions
public class MusicRateSprites : UnityEngine.ScriptableObject
{
    private UnityEngine.Sprite[] sprites;
    public UnityEngine.Sprite Get(int level);
}

// Namespace: PRISM.Interactions
public class MusicRateView : UnityEngine.MonoBehaviour
{
    private LevelImage[] levelImages;
    private UnityEngine.GameObject[] starObjects;
    private ENTERPRISE.UI.UITextMeshProUGUI rateText;
    private ENTERPRISE.UI.UITextMeshProUGUI gradeNameText;
    private PRISM.Legacy.ParamRememberableAnimator animator;
    public void SetUp(PRISM.Adapters.MusicRateViewModel viewModel);
    public void SetAnimatorNormalizedTime(float time);
    public void SetGradeNameMaterial(UnityEngine.Material material);

    private struct LevelImage : System.ValueType
    {
        private UnityEngine.UI.Image image;
        private PRISM.Interactions.MusicRateSprites sprites;
        public void SetLevel(int level);
    }
}

// Namespace: PRISM.Interactions
public class TechnicalChallengeUserInfoView : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.RawImage idolIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI userNameText;
    private PRISM.Interactions.SimpleAchievementIconGroup achievementIconGroup;
    private PRISM.Interactions.MusicRateView musicRateView;
    private PRISM.Interactions.MusicRateGradients gradients;
    private PRISM.UIGradient[] gradientTargets;
    public void Show(PRISM.Module.Networking.ITechnicalChallengeProfileStatus profile, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
}

// Namespace: PRISM.Interactions
public class TechnicalRankIcon : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ViewStateChanger rankIconChanger;
    public void Show(int rank);
}

// Namespace: PRISM.Interactions
public class LoginBonusOverlayView : UnityEngine.MonoBehaviour, PRISM.Adapters.ILoginBonusOverlayView, PRISM.Adapters.IClosableOverlayView<UniRx.Unit>, PRISM.Adapters.IOverlayView, PRISM.Adapters.IClosable<UniRx.Unit>, PRISM.Interactions.IDisableBackgroundBlur
{
    private PRISM.Interactions.LoginBonusPanelView panelView;
    private PRISM.Interactions.LoginBonusFullScreenPanelView fullScreenPanelView;
    private PRISM.Interactions.ScreenTouchDetector screenTouchDetector;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onCloseRequested;
    private UniRx.Subject<UniRx.Unit> onInput;
    private System.Collections.Generic.IReadOnlyList<PRISM.Adapters.ILoginBonusPanelViewModel> viewModels;
    private PRISM.Adapters.HomeLoginBonusCharacterMessagePresenter messagePresenter;
    private bool isLastSkip;
    private Cysharp.Threading.Tasks.UniTask<UniRx.Unit> PRISM.Adapters.IClosable<UniRx.Unit>.OnCloseRequested { get; set; }
    public void Initialize(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.ILoginBonusPanelViewModel> viewModels, PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Adapters.HomeLoginBonusCharacterMessagePresenter messagePresenter);
    private Cysharp.Threading.Tasks.UniTask PRISM.Adapters.IOverlayView.ShowAsync(System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask PRISM.Adapters.IOverlayView.HideAsync();
    private Cysharp.Threading.Tasks.UniTask _executeLoginBonusAsync(System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask _executeLastPhaseAsync(System.Threading.CancellationToken skipCt);
    private bool _scenarioTapKey();

    private class <>O
    {
        public static System.Func<bool> <0>__DefaultTapScreen;
    }

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<bool> <>9__13_0;
        private bool <_executeLoginBonusAsync>b__13_0();
    }

    private class <>c__DisplayClass8_0
    {
        public PRISM.Interactions.LoginBonusOverlayView <>4__this;
        public PRISM.Adapters.HomeLoginBonusCharacterMessagePresenter messagePresenter;
        private void <Initialize>b__0(UniRx.Unit _);
        private void <Initialize>b__1(UniRx.Unit _);
    }

    private struct <_executeLastPhaseAsync>d__14 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public System.Threading.CancellationToken skipCt;
        public PRISM.Interactions.LoginBonusOverlayView <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_executeLoginBonusAsync>d__13 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.LoginBonusOverlayView <>4__this;
        public System.Threading.CancellationToken ct;
        private System.Collections.Generic.IEnumerator<PRISM.Adapters.ILoginBonusPanelViewModel> <>7__wrap1;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class LoginBonusPanelFaderView : UnityEngine.MonoBehaviour
{
    private UnityEngine.CanvasGroup canvasGroup;
    private UnityEngine.Transform panelRoot;
    private static float PanelMoveSpeed;
    private UnityEngine.Vector3 rootPosition;
    public DG.Tweening.Tween CreateFadeInTween(float delayDuration);
    public DG.Tweening.Tween CreateFadeOutTween(float delayDuration);
    public void ResetPosition();
    private DG.Tweening.Tween _createFadeTween(System.ValueTuple<UnityEngine.Vector3, UnityEngine.Vector3> position, System.ValueTuple<float, float> alpha, float delayDuration);
    private void Awake();

    private class <>c__DisplayClass7_0
    {
        public PRISM.Interactions.LoginBonusPanelFaderView <>4__this;
        public System.ValueTuple<float, float> alpha;
        public System.ValueTuple<UnityEngine.Vector3, UnityEngine.Vector3> position;
        private void <_createFadeTween>b__0();
    }
}

// Namespace: PRISM.Interactions
public class LoginBonusPanelSheetView : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.Image graffitiImage;
    private UnityEngine.UI.Image titleImage;
    private UnityEngine.Animator titleAnimator;
    private PRISM.Interactions.LoginBonusRewardItemIconView[] loginBonusRewardItemIcons;
    private ENTERPRISE.UI.UITextMeshProUGUI endDateText;
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.LoginBonusPanelSheetViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public void PlayTitleAnimation();
    public Cysharp.Threading.Tasks.UniTask PlayStampAnimationAsync(int index, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask PlayNextRewardAnimationAsync(int index, System.Threading.CancellationToken ct);
    public void PlayStampAnimationImmediately(int index, bool playSe);
    public void PlayNextRewardAnimationImmediately(int index, bool playSe);
}

// Namespace: PRISM.Interactions
public class LoginBonusPanelView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.LoginBonusPanelSheetView currentSheetView;
    private PRISM.Interactions.LoginBonusPanelSheetView nextSheetView;
    private UnityEngine.Animator rotationAnimator;
    private UnityEngine.CanvasGroup canvasGroup;
    private PRISM.Interactions.LoginBonusPanelFaderView panelFader;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    private PRISM.Adapters.HomeLoginBonusCharacterMessagePresenter messagePresenter;
    private bool isStampAnimationFinished;
    private bool isNextRewardAnimationFinished;
    public void Inject(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Adapters.HomeLoginBonusCharacterMessagePresenter messagePresenter);
    public Cysharp.Threading.Tasks.UniTask ExecuteAsync(PRISM.Adapters.LoginBonusPanelViewModel viewModel, System.IObservable<UniRx.Unit> onInput, System.Threading.CancellationToken ct);
    public void Show();
    public void Hide();
    private Cysharp.Threading.Tasks.UniTask _executeReceiveRewardSequenceAsync(PRISM.Adapters.LoginBonusPanelViewModel viewModel, DG.Tweening.Tween fadeInTween, System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask _executeShowNextRewardSequenceAsync(PRISM.Adapters.LoginBonusPanelViewModel viewModel, System.Threading.CancellationToken skipCt);
    private static Cysharp.Threading.Tasks.UniTask _waitForVoiceStopAsync(System.Threading.CancellationToken ct);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<bool> <>9__15_0;
        private bool <_waitForVoiceStopAsync>b__15_0();
    }

    private class <>c__DisplayClass10_0
    {
        public PRISM.Interactions.LoginBonusPanelView <>4__this;
        public PRISM.Adapters.LoginBonusPanelViewModel viewModel;
        public DG.Tweening.Tween fadeInTween;
        public DG.Tweening.Tween fadeOutTween;
        public System.IObservable<UniRx.Unit> onInput;
        private Cysharp.Threading.Tasks.UniTask <ExecuteAsync>b__0(System.Threading.CancellationToken skipToken);
        private Cysharp.Threading.Tasks.UniTask <ExecuteAsync>b__1(System.Threading.CancellationToken skipToken);
        private Cysharp.Threading.Tasks.UniTask <ExecuteAsync>b__2(System.Threading.CancellationToken skipToken);
        private Cysharp.Threading.Tasks.UniTask <ExecuteAsync>g___waitInputAsync|3(System.Threading.CancellationToken token);
    }

    private struct <ExecuteAsync>d__10 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.LoginBonusPanelView <>4__this;
        public PRISM.Adapters.LoginBonusPanelViewModel viewModel;
        public System.IObservable<UniRx.Unit> onInput;
        public System.Threading.CancellationToken ct;
        private <>c__DisplayClass10_0 <>8__1;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_executeReceiveRewardSequenceAsync>d__13 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public DG.Tweening.Tween fadeInTween;
        public System.Threading.CancellationToken ct;
        public PRISM.Interactions.LoginBonusPanelView <>4__this;
        public PRISM.Adapters.LoginBonusPanelViewModel viewModel;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_executeShowNextRewardSequenceAsync>d__14 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Adapters.LoginBonusPanelViewModel viewModel;
        public PRISM.Interactions.LoginBonusPanelView <>4__this;
        public System.Threading.CancellationToken skipCt;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_waitForVoiceStopAsync>d__15 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class LoginBonusFullScreenPanelSheetView : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.Image backgroundImage;
    private PRISM.Interactions.LoginBonusRewardItemIconView[] loginBonusRewardItemIcons;
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.LoginBonusFullScreenPanelSheetViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask PlayStampAnimationAsync(System.Threading.CancellationToken ct);
    public void PlayStampAnimationImmediately(bool playSe);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Interactions.LoginBonusRewardItemIconView, bool> <>9__3_0;
        public static System.Func<PRISM.Interactions.LoginBonusRewardItemIconView, bool> <>9__4_0;
        private bool <PlayStampAnimationAsync>b__3_0(PRISM.Interactions.LoginBonusRewardItemIconView x);
        private bool <PlayStampAnimationImmediately>b__4_0(PRISM.Interactions.LoginBonusRewardItemIconView x);
    }

    private class <>c__DisplayClass3_0
    {
        public System.Threading.CancellationToken ct;
        private Cysharp.Threading.Tasks.UniTask <PlayStampAnimationAsync>b__1(PRISM.Interactions.LoginBonusRewardItemIconView x);
    }
}

// Namespace: PRISM.Interactions
public class LoginBonusFullScreenPanelView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.LoginBonusFullScreenPanelSheetView sheetView;
    private UnityEngine.CanvasGroup canvasGroup;
    private PRISM.Interactions.LoginBonusPanelFaderView panelFader;
    private PRISM.Interactions.LoginBonusTransitionAnimationPlayerView transitionAnimationPlayer;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    private bool isStampAnimationFinished;
    public void Inject(PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public Cysharp.Threading.Tasks.UniTask ExecuteAsync(PRISM.Adapters.LoginBonusFullScreenPanelViewModel viewModel, System.IObservable<UniRx.Unit> onInput, System.Threading.CancellationToken ct);
    public void Show();
    public void Hide();
    private Cysharp.Threading.Tasks.UniTask _executeReceiveRewardSequenceAsync(System.Threading.CancellationToken ct);

    private class <>c__DisplayClass7_0
    {
        public DG.Tweening.Tween fadeOutTween;
        public System.IObservable<UniRx.Unit> onInput;
        private Cysharp.Threading.Tasks.UniTask <ExecuteAsync>b__0(System.Threading.CancellationToken skipToken);
        private Cysharp.Threading.Tasks.UniTask <ExecuteAsync>g___waitInputAsync|1(System.Threading.CancellationToken token);
    }

    private struct <ExecuteAsync>d__7 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public System.IObservable<UniRx.Unit> onInput;
        public PRISM.Interactions.LoginBonusFullScreenPanelView <>4__this;
        public PRISM.Adapters.LoginBonusFullScreenPanelViewModel viewModel;
        public System.Threading.CancellationToken ct;
        private <>c__DisplayClass7_0 <>8__1;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_executeReceiveRewardSequenceAsync>d__10 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.LoginBonusFullScreenPanelView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class LoginBonusTransitionAnimationPlayerView : UnityEngine.MonoBehaviour
{
    private UnityEngine.Animator animator;
    public Cysharp.Threading.Tasks.UniTask FadeInAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask FadeOutAsync(System.Threading.CancellationToken ct);
    public void Hide();
}

// Namespace: PRISM.Interactions
public class LoginBonusRewardItemIconView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.RewardItemIcon rewardItemIcon;
    private UnityEngine.CanvasGroup canvasGroup;
    private UnityEngine.Animator iconAnimator;
    public void Show(PRISM.Adapters.LoginBonusRewardItemIconViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public Cysharp.Threading.Tasks.UniTask PlayStampAnimationAsync(System.Threading.CancellationToken ct);
    public void PlayStampAnimationImmediately();
    public Cysharp.Threading.Tasks.UniTask PlayNextRewardAnimationAsync(System.Threading.CancellationToken ct);
    public void PlayNextRewardAnimationImmediately();
    public void Hide();

    private struct <PlayNextRewardAnimationAsync>d__6 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.LoginBonusRewardItemIconView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <PlayStampAnimationAsync>d__4 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.LoginBonusRewardItemIconView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class LoginBonusUtility
{
    public static Cysharp.Threading.Tasks.UniTask ExecuteSkippableTaskAsync(System.Func<System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask> skippableTask, System.IObservable<UniRx.Unit> onInput);

    private struct <ExecuteSkippableTaskAsync>d__0 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public System.Func<System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask> skippableTask;
        public System.IObservable<UniRx.Unit> onInput;
        private System.Threading.CancellationTokenSource <skipCts>5__2;
        private Awaiter<int> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class AsChildInstantiator : PRISM.Interactions.IOverlayInstantiator, PRISM.IOverlayInstantiatorForLegacy
{
    private UnityEngine.Transform parent;
    public UnityEngine.GameObject Instantiate(UnityEngine.GameObject prefab, bool enableBackgroundBlur);
}

// Namespace: PRISM.Interactions
public class CharacterAcquisitionNameView : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI[] productNameTexts;
    private ENTERPRISE.UI.UITextMeshProUGUI[] characterNameTexts;
    private UnityEngine.GameObject newObject;
    private ENTERPRISE.OutGame.RewardItem convertProductIcon;
    private ENTERPRISE.OutGame.RewardItem extraIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI extraAmountText;
    private ENTERPRISE.UI.UITextMeshProUGUI extraDetailText;
    public void Play(PRISM.Adapters.CharacterAcquisitionModel model, PRISM.Definitions.LocalizationKey productNameKey, float seDelaySeconds, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public void RegisterPlaySe(float delaySeconds, PRISM.Definitions.SoundKey soundKey, System.Threading.CancellationToken ct);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Module.Networking.IGashaExtraRewardProductStatus, int> <>9__7_0;
        public static System.Func<PRISM.Module.Networking.IGashaExtraRewardProductStatus, bool> <>9__7_1;
        public static System.Func<PRISM.Module.Networking.IGashaExtraRewardProductStatus, bool> <>9__7_2;
        private int <Play>b__7_0(PRISM.Module.Networking.IGashaExtraRewardProductStatus status);
        private bool <Play>b__7_1(PRISM.Module.Networking.IGashaExtraRewardProductStatus status);
        private bool <Play>b__7_2(PRISM.Module.Networking.IGashaExtraRewardProductStatus status);
    }

    private class <>c__DisplayClass8_0
    {
        public PRISM.Definitions.SoundKey soundKey;
        public System.Threading.CancellationToken ct;
        private void <RegisterPlaySe>b__0();
    }
}

// Namespace: PRISM.Interactions
public class CharacterAcquisitionOverlayView : UnityEngine.MonoBehaviour, PRISM.Adapters.ICharacterAcquisitionOverlayView, PRISM.Adapters.IClosableOverlayView<UniRx.Unit>, PRISM.Adapters.IOverlayView, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.CharacterAcquisitionPlayer player;
    private PRISM.Interactions.ButtonView closeButton;
    private string[] sheetNames;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask PlayAsync(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.CharacterAcquisitionModel> models, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Adapters.CharacterAcquisitionModel, System.Collections.Generic.IEnumerable<string>> <>9__6_0;
        private System.Collections.Generic.IEnumerable<string> <PlayAsync>b__6_0(PRISM.Adapters.CharacterAcquisitionModel model);
    }

    private struct <HideAsync>d__7 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.CharacterAcquisitionOverlayView <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <PlayAsync>d__6 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.CharacterAcquisitionOverlayView <>4__this;
        public System.Collections.Generic.IReadOnlyList<PRISM.Adapters.CharacterAcquisitionModel> models;
        public System.Threading.CancellationToken ct;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private Awaiter<string[]> <>u__1;
        private int <index>5__2;
        private Awaiter <>u__2;
        private System.IDisposable <>7__wrap2;
        private Awaiter<UniRx.Unit> <>u__3;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class CharacterAcquisitionPlayer : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ProduceIdolAcquisitionPlayer produceIdolPlayer;
    private PRISM.Interactions.SupportCharacterAcquisitionPlayer supportCharacterPlayer;
    private UnityEngine.Animator betweenAnimator;
    public Cysharp.Threading.Tasks.UniTask PlayAsync(PRISM.Adapters.CharacterAcquisitionModel model, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask PlayBetweenAnimationAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask DisposeAsync();

    private struct <PlayBetweenAnimationAsync>d__4 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.CharacterAcquisitionPlayer <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class ProduceIdolAcquisitionNameView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.CharacterAcquisitionNameView commonView;
    private PRISM.Interactions.ViewStateChanger initialStarStateChanger;
    private PRISM.Gasha.GashaSign sign;
    public void Play(PRISM.Adapters.ProduceIdolAcquisitionModelBase model, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
}

// Namespace: PRISM.Interactions
public class ProduceIdolAcquisitionPlayer : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI voiceText;
    private UnityEngine.Animator voiceAnimator;
    private PRISM.MoviePlayer moviePlayer;
    private PRISM.Interactions.ProduceIdolAcquisitionNameView namePlate;
    public Cysharp.Threading.Tasks.UniTask PlayAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Adapters.ProduceIdolAcquisitionModel model, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask DisposeAsync();

    private class <>c__DisplayClass4_0
    {
        public PRISM.Interactions.ProduceIdolAcquisitionPlayer <>4__this;
        public PRISM.Adapters.ProduceIdolAcquisitionModel model;
        public System.Threading.CancellationToken ct;
        private bool <PlayAsync>b__0();
        private void <PlayAsync>b__1();
    }

    private struct <PlayAsync>d__4 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ProduceIdolAcquisitionPlayer <>4__this;
        public PRISM.Adapters.ProduceIdolAcquisitionModel model;
        public System.Threading.CancellationToken ct;
        private <>c__DisplayClass4_0 <>8__1;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class SupportCharacterAcquisitionNameView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.CharacterAcquisitionNameView commonView;
    private UnityEngine.Animator animator;
    private string[] animatorParameterNames;
    private PRISM.Gasha.GashaSign sign;
    public void Play(PRISM.Adapters.SupportCharacterAcquisitionModel model, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
}

// Namespace: PRISM.Interactions
public class SupportCharacterAcquisitionPlayer : UnityEngine.MonoBehaviour
{
    private UnityEngine.Animator animator;
    private UnityEngine.UI.RawImage[] images;
    private PRISM.Interactions.SupportCharacterAcquisitionNameView namePlate;
    public Cysharp.Threading.Tasks.UniTask PlayAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Adapters.SupportCharacterAcquisitionModel model, System.Threading.CancellationToken ct);

    private struct <PlayAsync>d__3 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.SupportCharacterAcquisitionPlayer <>4__this;
        public PRISM.Adapters.SupportCharacterAcquisitionModel model;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        private Awaiter<UnityEngine.Texture2D> <>u__1;
        private Awaiter <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class DividedCanvasInstantiator : PRISM.Interactions.IOverlayInstantiator, PRISM.IOverlayInstantiatorForLegacy
{
    private UnityEngine.Canvas canvasPrefab;
    private PRISM.Interactions.UICanvasManager canvasManager;
    public UnityEngine.GameObject Instantiate(UnityEngine.GameObject prefab, bool enableBackgroundBlur);

    private class <>c__DisplayClass3_0
    {
        public UnityEngine.Canvas canvas;
        public PRISM.Interactions.DividedCanvasInstantiator <>4__this;
        private void <Instantiate>b__0(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions
public interface IDisableBackgroundBlur
{
}

// Namespace: PRISM.Interactions
public class IdolLevelUpIdolView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.CharacterBaseIconView iconView;
    private PRISM.Interactions.IdolLevelUpParamView levelView;
    private PRISM.Interactions.IdolLevelUpParamView dearnessView;
    private PRISM.Interactions.IdolLevelUpParamView vocalView;
    private PRISM.Interactions.IdolLevelUpParamView danceView;
    private PRISM.Interactions.IdolLevelUpParamView visualView;
    private PRISM.Interactions.IdolLevelUpParamView mentalView;
    public Cysharp.Threading.Tasks.UniTask RenderAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Adapters.IdolLevelUpIdolViewModel& viewModel, System.Threading.CancellationToken cancellationToken);
}

// Namespace: PRISM.Interactions
public class IdolLevelUpOverlayView : UnityEngine.MonoBehaviour, PRISM.Adapters.IIdolLevelUpOverlayView, PRISM.Adapters.IClosableOverlayView<UniRx.Unit>, PRISM.Adapters.IOverlayView, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.IdolLevelUpIdolView[] idolViews;
    private PRISM.Interactions.ButtonView button;
    private PRISM.Legacy.ParamRememberableAnimator animator;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource animationCompletionSource;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(PRISM.Adapters.IdolLevelUpViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public void OnAnimationFinished();

    private class <>c__DisplayClass7_0
    {
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public PRISM.Adapters.IdolLevelUpViewModel viewModel;
        public System.Threading.CancellationToken ct;
        public System.Threading.CancellationTokenSource skipCts;
        private Cysharp.Threading.Tasks.UniTask <ShowAsync>b__0(PRISM.Interactions.IdolLevelUpIdolView view, int i);
        private void <ShowAsync>b__1(UniRx.Unit _);
    }

    private struct <ShowAsync>d__7 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public PRISM.Adapters.IdolLevelUpViewModel viewModel;
        public System.Threading.CancellationToken ct;
        public PRISM.Interactions.IdolLevelUpOverlayView <>4__this;
        private <>c__DisplayClass7_0 <>8__1;
        private Awaiter <>u__1;
        private Awaiter<UniRx.Unit> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class IdolLevelUpParamView : UnityEngine.MonoBehaviour
{
    private TMPro.TextMeshProUGUI valueText;
    private TMPro.TextMeshProUGUI addValueText;
    private string format;
    public void Render(PRISM.Adapters.IdolLevelUpParamViewModel& viewModel);
}

// Namespace: PRISM.Interactions
public interface IOverlayInstantiator : PRISM.IOverlayInstantiatorForLegacy
{
}

// Namespace: PRISM.Interactions
public class MovieOverlayView : UnityEngine.MonoBehaviour, PRISM.Adapters.IMovieOverlayView, PRISM.Adapters.IClosableOverlayView<UniRx.Unit>, PRISM.Adapters.IOverlayView, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private UnityEngine.UI.Image prepareImage;
    private PRISM.MoviePlayer moviePlayer;
    private UnityEngine.CanvasGroup grayout;
    private PRISM.Interactions.ViewStateChanger grayoutIconChanger;
    private PRISM.Interactions.ButtonView backgroundButton;
    private PRISM.Interactions.ButtonView movieButton;
    private float bgmFadeRatio;
    private float bgmFadeDuration;
    private DG.Tweening.Tweener grayoutTween;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(string movieKey, string prepareImageKey, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask PRISM.Adapters.IOverlayView.ShowAsync(System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask PRISM.Adapters.IOverlayView.HideAsync();
    private Cysharp.Threading.Tasks.UniTask _playMovieAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask _fadeOutBgmAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask _fadeInBgmAsync(System.Threading.CancellationToken ct);
    private void <InitializeAsync>b__12_0(UniRx.Unit _);
    private bool <_playMovieAsync>b__15_0();

    private enum GrayoutIconType : System.Enum
    {
        public int value__;
        public static GrayoutIconType Play;
        public static GrayoutIconType Pause;
        public static GrayoutIconType Replay;
    }

    private class <>c
    {
        public static <>c <>9;
        public static DG.Tweening.TweenCallback<float> <>9__16_0;
        public static DG.Tweening.TweenCallback<float> <>9__17_0;
        private void <_fadeOutBgmAsync>b__16_0(float value);
        private void <_fadeInBgmAsync>b__17_0(float value);
    }

    private struct <InitializeAsync>d__12 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.MovieOverlayView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public string prepareImageKey;
        public System.Threading.CancellationToken ct;
        public string movieKey;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <PRISM-Adapters-IOverlayView-HideAsync>d__14 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.MovieOverlayView <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_playMovieAsync>d__15 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.MovieOverlayView <>4__this;
        public System.Threading.CancellationToken ct;
        private object <>7__wrap1;
        private int <>7__wrap2;
        private Awaiter <>u__1;
        private ENTERPRISE.NonSleepingScope <>7__wrap3;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class OverlayViewBase : UnityEngine.MonoBehaviour
{
    protected PRISM.Interactions.CommonTitleView titleView;
    protected PRISM.HowToPlayPopupOpener howToPlayPopupOpener;
    private PRISM.UIAnimation inAnimation;
    private string <HowToPlayAdditionalKey>k__BackingField;
    private string HowToPlayAdditionalKey { get; set; }
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();

    private class <>c__DisplayClass7_0
    {
        public PRISM.Interactions.OverlayViewBase <>4__this;
        public System.Threading.CancellationToken ct;
        private void <ShowAsync>b__0(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions
public class OverlayViewFactory : PRISM.Adapters.IOverlayViewFactory
{
    public Cysharp.Threading.Tasks.UniTask<T> GenerateOverlayViewAsync<T>(PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);

    private struct <GenerateOverlayViewAsync>d__0`1<T> : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<T> <>t__builder;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        private System.IDisposable <__>5__2;
        private Awaiter<UnityEngine.GameObject> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class OverlayViewWithCloseButton : PRISM.Interactions.OverlayViewBase, PRISM.Adapters.IClosableOverlayView<UniRx.Unit>, PRISM.Adapters.IOverlayView, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.ButtonView closeButton;
    protected Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClose;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    protected PRISM.Definitions.SoundKey closeSoundKey { get; set; }
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    private void <ShowAsync>b__6_0(UniRx.Unit _);
}

// Namespace: PRISM.Interactions
public class OverlayViewWithOkCancelButtonAsync`1<T> : PRISM.Interactions.OverlayViewBase, PRISM.Adapters.IClosableOverlayView<T>, PRISM.Adapters.IOverlayView, PRISM.Adapters.IClosable<T>
{
    protected PRISM.Interactions.ButtonView okButton;
    protected PRISM.Interactions.ButtonView cancelButton;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<T> onClose;
    public Cysharp.Threading.Tasks.UniTask<T> OnCloseRequested { get; set; }
    protected Cysharp.Threading.Tasks.UniTask<T> _createReturnValueAsync(bool isOk);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTaskVoid <ShowAsync>b__6_0(UniRx.Unit _);
    private Cysharp.Threading.Tasks.UniTaskVoid <ShowAsync>b__6_1(UniRx.Unit _);

    private struct <<ShowAsync>b__6_0>d<T> : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
        public PRISM.Interactions.OverlayViewWithOkCancelButtonAsync<T> <>4__this;
        private Cysharp.Threading.Tasks.UniTaskCompletionSource<T> <>7__wrap1;
        private Awaiter<T> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <<ShowAsync>b__6_1>d<T> : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
        public PRISM.Interactions.OverlayViewWithOkCancelButtonAsync<T> <>4__this;
        private Cysharp.Threading.Tasks.UniTaskCompletionSource<T> <>7__wrap1;
        private Awaiter<T> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class OverlayViewWithOkCancelButton`1<T> : PRISM.Interactions.OverlayViewWithOkCancelButtonAsync<T>
{
    protected Cysharp.Threading.Tasks.UniTask<T> _createReturnValueAsync(bool isOk);
    protected T _createReturnValue(bool isOk);
}

// Namespace: PRISM.Interactions
public class OverlayViewWithOkCancelButton : PRISM.Interactions.OverlayViewWithOkCancelButtonAsync<bool>
{
    protected Cysharp.Threading.Tasks.UniTask<bool> _createReturnValueAsync(bool isOk);
}

// Namespace: PRISM.Interactions
public class UICanvasManager : System.IDisposable
{
    private System.Collections.Generic.List<System.ValueTuple<UnityEngine.Canvas, bool>> canvasList;
    private UnityEngine.Camera belowBlurCamera;
    private UnityEngine.Camera aboveBlurCamera;
    private UnityEngine.Camera uiCamera;
    public static bool IsAutoStacking;
    private static void _onBeginContextRendering(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras);
    public static void Stack(System.Collections.Generic.List<UnityEngine.Camera> cameras);
    private static void _setupBaseCamera(UnityEngine.Camera camera);
    public void Add(UnityEngine.Canvas canvas, bool enableBackgroundBlur);
    public void Remove(UnityEngine.Canvas canvas);
    public void RemoveAll();
    private void _adjustCanvasCameras();
    public void Dispose();

    private class <>O
    {
        public static System.Action<UnityEngine.Rendering.ScriptableRenderContext, System.Collections.Generic.List<UnityEngine.Camera>> <0>___onBeginContextRendering;
    }

    private class <>c
    {
        public static <>c <>9;
        public static System.Comparison<UnityEngine.Camera> <>9__7_0;
        public static System.Predicate<System.ValueTuple<UnityEngine.Canvas, bool>> <>9__12_0;
        private int <Stack>b__7_0(UnityEngine.Camera a, UnityEngine.Camera b);
        private bool <_adjustCanvasCameras>b__12_0(System.ValueTuple<UnityEngine.Canvas, bool> x);
    }

    private class <>c__DisplayClass10_0
    {
        public UnityEngine.Canvas canvas;
        private bool <Remove>b__0(System.ValueTuple<UnityEngine.Canvas, bool> x);
    }

    private class <>c__DisplayClass9_0
    {
        public UnityEngine.Canvas canvas;
        private bool <Add>b__0(System.ValueTuple<UnityEngine.Canvas, bool> x);
    }
}

// Namespace: PRISM.Interactions
public class CharacterSelectCharacterGridView : PRISM.Interactions.SelectableGridView<PRISM.Interactions.CharacterSelectCharacterGridViewCell, PRISM.Adapters.CharacterSelectPopupCharacterViewModel>
{
    protected void SetupCellTemplate();

    private class CellGroup : DefaultCellGroup<PRISM.Adapters.CharacterSelectPopupCharacterViewModel, PRISM.Interactions.SelectableGridViewContext<PRISM.Adapters.CharacterSelectPopupCharacterViewModel>>
    {
    }
}

// Namespace: PRISM.Interactions
public class CharacterSelectCharacterGridViewCell : PRISM.Interactions.SelectableGridViewCell<PRISM.Adapters.CharacterSelectPopupCharacterViewModel>
{
    private PRISM.Interactions.CharacterBaseIconView idolIcon;
    private UnityEngine.GameObject isSettingObject;
    private PRISM.Interactions.ViewStateChanger ownedStateChanger;
    private PRISM.AutoCancellationTokenSource canceller;
    public void UpdateContent(PRISM.Adapters.CharacterSelectPopupCharacterViewModel itemData);
    protected void OnDestroy();
}

// Namespace: PRISM.Interactions
public class CharacterSelectPopupView : UnityEngine.MonoBehaviour, PRISM.Adapters.ICharacterSelectPopupView, PRISM.Adapters.IClosablePopupFrame<int>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<int>, PRISM.Interactions.IPopupContent
{
    private PRISM.Interactions.CharacterSelectCharacterGridView gridView;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<int> onClosed;
    private UniRx.ReactiveProperty<PRISM.Adapters.CharacterSelectPopupCharacterViewModel> selectedCharacter;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<int> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Initialize(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.CharacterSelectPopupCharacterViewModel> characters, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <Initialize>b__5_0(UniRx.Pair<PRISM.Adapters.CharacterSelectPopupCharacterViewModel> x);
    private void <CreateFrameParameter>b__7_0();
    private void <CreateFrameParameter>b__7_1();
    private void <CreateFrameParameter>b__7_2();

    private class <>c__DisplayClass5_0
    {
        public UniRx.Pair<PRISM.Adapters.CharacterSelectPopupCharacterViewModel> x;
        public PRISM.Interactions.CharacterSelectPopupView <>4__this;
        private void <Initialize>b__1();
    }
}

// Namespace: PRISM.Interactions
public class CommonPopupFrame : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupFrameView, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IPopupFooter
{
    private static float NoHeaderHeight;
    private static float HeaderHeight;
    private static float NoFooterHeight;
    private static float FooterHeight;
    private static float SideSize;
    private UnityEngine.CanvasGroup canvasGroup;
    private UnityEngine.RectTransform windowTransform;
    private UnityEngine.RectTransform contentTransform;
    private ENTERPRISE.UI.UITextMeshProUGUI titleText;
    private PRISM.Interactions.ButtonView outOfRangeButton;
    private UnityEngine.GameObject headerObject;
    private PRISM.Interactions.ButtonView infoButton;
    private UnityEngine.GameObject footerObject;
    private PRISM.Interactions.PopupButton[] footerButtons;
    private EasingCore.Ease easeType;
    private float durationSecond;
    private UnityEngine.Vector3 startScale;
    private float headerHeight;
    private float footerHeight;
    private PRISM.Definitions.SoundKey openSE;
    private PRISM.Definitions.SoundKey closeSE;
    private string contentName;
    public UnityEngine.Transform ContentRoot { get; set; }
    public void Prepare();
    public void ApplyParameter(PRISM.Interactions.PopupFrameParameter parameter);
    public void ApplyContent(PRISM.Interactions.IPopupContent content);
    private void _applyExpandVertical(PRISM.Interactions.IPopupContent content);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    public void SetFooterButtonEnable(int index, bool isEnable);
    public void SnapOverlayUIToButton(int index, UnityEngine.RectTransform uiRect);
    public void SetClickableCover(int index, bool isActive);
    public void ApplyFooterParameter(FooterInfoParameter footerParameter);
    private void _applyFooterParameter(FooterInfoParameter footerParameter);
    private void _applyHeaderParameter(HeaderInfoParameter headerParameter);
    private void _applyOutOfRangeParameter(OutOfRangeInfoParameter parameter);
    private static UnityEngine.Vector2 _getSizeTypeInfo(PopupSizeType type);
    private void <ShowAsync>b__28_0(float t);

    private class <>c__DisplayClass37_0
    {
        public HeaderInfoParameter headerParameter;
        private void <_applyHeaderParameter>b__0(UniRx.Unit _);
    }

    private class <>c__DisplayClass38_0
    {
        public OutOfRangeInfoParameter parameter;
        private void <_applyOutOfRangeParameter>b__0(UniRx.Unit _);
    }

    private struct <ShowAsync>d__28 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public System.Threading.CancellationToken ct;
        public PRISM.Interactions.CommonPopupFrame <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class CompleteJewelPurchasePopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.ICompleteJewelPurchasePopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private ENTERPRISE.UI.UITextMeshProUGUI message;
    private PRISM.Interactions.JewelPurchasePanelView jewelPurchasePanel;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Interactions.PopupFrameParameter frameParameter;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void Initialize(PRISM.Domain.Jewel beforePurchaseJewel, PRISM.Domain.Jewel afterPurchaseJewel, string titleText, string messageText);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <Initialize>b__7_0();
    private void <Initialize>b__7_1();
}

// Namespace: PRISM.Interactions
public class ConfirmJewelPurchasePopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IConfirmJewelPurchasePopupView, PRISM.Adapters.IClosablePopupFrame<PRISM.Adapters.ConfirmJewelPurchasePopupResultType>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<PRISM.Adapters.ConfirmJewelPurchasePopupResultType>
{
    private PRISM.Interactions.JewelPurchasePanelView jewelPurchasePanel;
    private PRISM.Interactions.ButtonView specifiedCommercialTransactionActButton;
    private ENTERPRISE.UI.UITextMeshProUGUI cautionText;
    private PRISM.Interactions.PopupFrameParameter frameParameter;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<PRISM.Adapters.ConfirmJewelPurchasePopupResultType> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<PRISM.Adapters.ConfirmJewelPurchasePopupResultType> OnCloseRequested { get; set; }
    public System.IObservable<UniRx.Unit> OnClickSpecifiedCommercialTransactionActButton { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void Initialize(InGameCurrencyType jewelPurchaseType, int price, PRISM.Domain.Jewel havingJewel, string titleText, string decideButtonText);
    private ButtonInfoParameter[] _createButtonParameters(bool isJewelShortage, string decideButtonText);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <Initialize>b__10_0();
    private void <_createButtonParameters>b__11_0();
    private void <_createButtonParameters>b__11_1();
    private void <_createButtonParameters>b__11_2();
}

// Namespace: PRISM.Interactions
public class EditPlayerNameConfirmPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IEditPlayerNameConfirmPopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private ENTERPRISE.UI.UITextMeshProUGUI producerNameText;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClosed;
    private bool isFirst;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Inject(string producerName, bool isFirst);
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
public class EditPlayerNamePopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IEditPlayerNamePopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private static string NameInputTextKey;
    private PRISM.CommonInputFieldTMP producerNameInputField;
    private ENTERPRISE.UI.UITextMeshProUGUI producerNameCountText;
    private ENTERPRISE.UI.UITextMeshProUGUI producerNameLabelText;
    private ENTERPRISE.UI.UITextMeshProUGUI nameInputEmptyText;
    private ENTERPRISE.UI.UITextMeshProUGUI infoText;
    private ENTERPRISE.UI.UITextMeshProUGUI cautionText;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private bool isFirst;
    private System.Action decideAction;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public System.IObservable<string> OnChangeNameObservable { get; set; }
    public System.IObservable<string> OnEndEditNameObservable { get; set; }
    public bool IsInputFieldReadOnly { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Inject(string producerName, bool isFirst, System.Func<string, Cysharp.Threading.Tasks.UniTask> onClosingFunc);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void SetCountText(string text);
    public void SetInputFieldText(string text);
    public void PlayOverLimitSE(string text);
    private void _setPopupButtonEnable();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__19_0();
    private void <CreateFrameParameter>b__19_1();

    private class <>c__DisplayClass18_0
    {
        public System.Func<string, Cysharp.Threading.Tasks.UniTask> onClosingFunc;
        public PRISM.Interactions.EditPlayerNamePopupView <>4__this;
        public System.Func<bool> <>9__1;
        private void <Inject>b__0();
        private bool <Inject>b__1();
    }
}

// Namespace: PRISM.Interactions
public class EfficacyDetailListPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IEfficacyDetailListPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private UnityEngine.Transform efficacyDetailParent;
    private EfficacyDetailContent copyBaseEfficacyDetailObject;
    private System.Collections.Generic.List<UnityEngine.GameObject> efficacyDetailList;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClick;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Assign(System.Collections.Generic.IReadOnlyList<int> tmpLinkIdList);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__7_0();
    private void <CreateFrameParameter>b__7_1();
}

// Namespace: PRISM.Interactions
public class HowToPlayCarousel : PRISM.ArrowAttachedCarousel<UnityEngine.Texture, PRISM.DefaultCarouselContext>
{
}

// Namespace: PRISM.Interactions
public class HowToPlayCarouselCell : PRISM.CarouselCell<UnityEngine.Texture, PRISM.DefaultCarouselContext>
{
    private UnityEngine.UI.RawImage rawImage;
    public void UpdateContent(UnityEngine.Texture texture);
}

// Namespace: PRISM.Interactions
public class HowToPlayPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IHowToPlayPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.HowToPlayCarousel carousel;
    private ENTERPRISE.UI.UITextMeshProUGUI summary;
    private PRISM.Interactions.ButtonView previousButton;
    private PRISM.Interactions.ButtonView nextButton;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Interactions.PopupFrameParameter frameParameter;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Initialize(PRISM.HowToPlayPopupResourceConfig config);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<Item, UnityEngine.Texture> <>9__8_3;
        private UnityEngine.Texture <Initialize>b__8_3(Item x);
    }

    private class <>c__DisplayClass8_0
    {
        public PRISM.Interactions.HowToPlayPopupView <>4__this;
        public PRISM.HowToPlayPopupResourceConfig config;
        private void <Initialize>b__0(UniRx.Unit _);
        private void <Initialize>b__1(UniRx.Unit _);
        private void <Initialize>b__2(int i);
        private void <Initialize>b__4();
        private void <Initialize>b__5();
    }
}

// Namespace: PRISM.Interactions
public class IdolSkillDetailListPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IIdolSkillDetailListPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private UnityEngine.Transform contentParent;
    private PRISM.Interactions.IdolSkillDetailListElementView goElement;
    private UnityEngine.UI.RawImage imgSkillIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI txtSkillName;
    private ENTERPRISE.UI.UITextMeshProUGUI txtSkillLv;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClick;
    private System.IObservable<System.Collections.Generic.List<int>> <KeyWordTouchIdList>k__BackingField;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public System.IObservable<System.Collections.Generic.List<int>> KeyWordTouchIdList { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Assign(PRISM.Adapters.IdolSkillDetailListPopupViewModel vm, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__13_0();
    private void <CreateFrameParameter>b__13_1();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Module.Networking.IIdolSkillActionEffectStatus, System.ValueTuple<int, System.Collections.Generic.IReadOnlyList<int>>> <>9__12_1;
        public static System.Func<string, int> <>9__12_3;
        public static System.Func<System.Collections.Generic.List<string>, System.Collections.Generic.List<int>> <>9__12_2;
        public static System.Func<PRISM.Interactions.IdolSkillDetailListElementView, System.IObservable<System.Collections.Generic.List<int>>> <>9__12_0;
        private System.ValueTuple<int, System.Collections.Generic.IReadOnlyList<int>> <Assign>b__12_1(PRISM.Module.Networking.IIdolSkillActionEffectStatus x);
        private System.IObservable<System.Collections.Generic.List<int>> <Assign>b__12_0(PRISM.Interactions.IdolSkillDetailListElementView x);
        private System.Collections.Generic.List<int> <Assign>b__12_2(System.Collections.Generic.List<string> x);
        private int <Assign>b__12_3(string y);
    }
}

// Namespace: PRISM.Interactions
public class IdolSkillSingleDetailPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IIdolSkillSingleDetailPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private UnityEngine.UI.RawImage imgSkillIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI txtPp;
    private PRISM.VoDaViMeMultiView voDaViMeMultiView;
    private ENTERPRISE.UI.UITextMeshProUGUI txtSKillName;
    private ENTERPRISE.UI.UITextMeshProUGUI txtLv;
    private ENTERPRISE.UI.UITextMeshProUGUI txtDetail;
    private PRISM.Interactions.TMPKeyWordTouchDetector tmpKeyWordTouchDetector;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClick;
    private UniRx.Subject<System.Collections.Generic.List<int>> keyWordTouchIdList;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public System.IObservable<System.Collections.Generic.List<int>> KeyWordTouchIdList { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    private void Awake();
    public void Assign(PRISM.Adapters.IdolSkillSingleDetailPopupViewModel vm, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <Assign>b__14_0(System.ValueTuple<int, TMPro.TMP_TextInfo> info);
    private void <CreateFrameParameter>b__15_0();
    private void <CreateFrameParameter>b__15_1();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<string, int> <>9__14_1;
        private int <Assign>b__14_1(string x);
    }
}

// Namespace: PRISM.Interactions
public interface IPopupContent
{
    public UnityEngine.RectTransform Rect { get; set; }
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
}

// Namespace: PRISM.Interactions
public interface IPopupFrameView : PRISM.Adapters.IPopupFrame, PRISM.Adapters.IPopupFooter
{
    public void ApplyContent(PRISM.Interactions.IPopupContent content);
    public void SnapOverlayUIToButton(int index, UnityEngine.RectTransform uiRect);
    public void SetClickableCover(int index, bool isActive);
    public void ApplyFooterParameter(FooterInfoParameter footerParameter);
}

// Namespace: PRISM.Interactions
public class ItemSetDetailPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IItemSetDetailPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.ItemSetDetailCellContainerView cellContainerView;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public System.IObservable<PRISM.Adapters.ItemSetDetailCellViewModel> OnClickItemIcon { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(System.Collections.Generic.IEnumerable<PRISM.Domain.ProductKeyWithAmount> productKeys, PRISM.ResourceManagement.IResourceLoader resourceLoader, string headline, System.Threading.CancellationToken cancellationToken);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__7_0();
    private void <CreateFrameParameter>b__7_1();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Domain.ProductKeyWithAmount, PRISM.Adapters.ItemSetDetailCellViewModel> <>9__6_0;
        private PRISM.Adapters.ItemSetDetailCellViewModel <InitializeAsync>b__6_0(PRISM.Domain.ProductKeyWithAmount x);
    }
}

// Namespace: PRISM.Interactions
public class MessagePopupBuilder : PRISM.Adapters.IMessagePopupParameter, PRISM.Adapters.IMessagePopupBuilderButton3, PRISM.Adapters.IMessagePopupBuilderEmpty, PRISM.Adapters.IMessagePopupBuilderWithTitle, PRISM.Adapters.IMessagePopupBuilderButton0, PRISM.Adapters.IMessagePopupBuilderButton1, PRISM.Adapters.IMessagePopupBuilderButton2
{
    private string <Title>k__BackingField;
    private string <Message>k__BackingField;
    private PopupSizeType <SizeType>k__BackingField;
    private bool <IsEnableOutOfRange>k__BackingField;
    private System.Collections.Generic.List<System.ValueTuple<string, System.Nullable<PopupButtonType>>> buttons;
    private PRISM.Adapters.IClosableSequencer<int, PRISM.Adapters.IMessagePopupView> sequencer;
    public string Title { get; set; }
    public string Message { get; set; }
    public System.Collections.Generic.IEnumerable<System.ValueTuple<string, System.Nullable<PopupButtonType>>> Buttons { get; set; }
    public PopupSizeType SizeType { get; set; }
    public bool IsEnableOutOfRange { get; set; }
    private PRISM.Interactions.MessagePopupBuilder _addButton(string text, System.Nullable<PopupButtonType> type);
    private PRISM.Interactions.MessagePopupBuilder _addButton(PRISM.Definitions.LocalizationKey text, System.Nullable<PopupButtonType> type);
    public Cysharp.Threading.Tasks.UniTask<int> ShowAsync(System.Threading.CancellationToken cancellationToken);
    private PRISM.Adapters.IMessagePopupBuilderWithTitle PRISM.Adapters.IMessagePopupBuilderEmpty.SetTitle(string title);
    private PRISM.Adapters.IMessagePopupBuilderWithTitle PRISM.Adapters.IMessagePopupBuilderEmpty.SetTitle(PRISM.Definitions.LocalizationKey title);
    private PRISM.Adapters.IMessagePopupBuilderButton0 PRISM.Adapters.IMessagePopupBuilderWithTitle.SetMessage(string message);
    private PRISM.Adapters.IMessagePopupBuilderButton0 PRISM.Adapters.IMessagePopupBuilderWithTitle.SetMessage(PRISM.Definitions.LocalizationKey message);
    private PRISM.Adapters.IMessagePopupBuilderButton1 PRISM.Adapters.IMessagePopupBuilderButton0.AddButton(string text, System.Nullable<PopupButtonType> type);
    private PRISM.Adapters.IMessagePopupBuilderButton1 PRISM.Adapters.IMessagePopupBuilderButton0.AddButton(PRISM.Definitions.LocalizationKey text, System.Nullable<PopupButtonType> type);
    private PRISM.Adapters.IMessagePopupBuilderButton1 PRISM.Adapters.IMessagePopupBuilderButton0.AddCancelButton();
    private Cysharp.Threading.Tasks.UniTask PRISM.Adapters.IMessagePopupBuilderButton0.ShowClosePopupAsync(System.Threading.CancellationToken cancellationToken);
    private Cysharp.Threading.Tasks.UniTask PRISM.Adapters.IMessagePopupBuilderButton0.ShowOkPopupAsync(System.Threading.CancellationToken cancellationToken);
    private Cysharp.Threading.Tasks.UniTask<bool> PRISM.Adapters.IMessagePopupBuilderButton0.ShowYesNoPopupAsync(System.Threading.CancellationToken cancellationToken);
    private Cysharp.Threading.Tasks.UniTask<bool> PRISM.Adapters.IMessagePopupBuilderButton0.ShowOkCancelPopupAsync(System.Threading.CancellationToken cancellationToken);
    private PRISM.Adapters.IMessagePopupBuilderButton2 PRISM.Adapters.IMessagePopupBuilderButton1.AddButton(string text, System.Nullable<PopupButtonType> type);
    private PRISM.Adapters.IMessagePopupBuilderButton2 PRISM.Adapters.IMessagePopupBuilderButton1.AddButton(PRISM.Definitions.LocalizationKey text, System.Nullable<PopupButtonType> type);
    private PRISM.Adapters.IMessagePopupBuilderButton2 PRISM.Adapters.IMessagePopupBuilderButton1.AddDecideButton();
    private Cysharp.Threading.Tasks.UniTask PRISM.Adapters.IMessagePopupBuilderButton1.ShowAsync(System.Threading.CancellationToken cancellationToken);
    private PRISM.Adapters.IMessagePopupBuilderButton3 PRISM.Adapters.IMessagePopupBuilderButton2.AddButton(string text, System.Nullable<PopupButtonType> type);
    private PRISM.Adapters.IMessagePopupBuilderButton3 PRISM.Adapters.IMessagePopupBuilderButton2.AddButton(PRISM.Definitions.LocalizationKey text, System.Nullable<PopupButtonType> type);
    private Cysharp.Threading.Tasks.UniTask<bool> PRISM.Adapters.IMessagePopupBuilderButton2.ShowAsync(System.Threading.CancellationToken cancellationToken);
    private void <ShowAsync>b__21_0(PRISM.Adapters.IMessagePopupView view);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<int, bool> <>9__31_0;
        public static System.Func<int, bool> <>9__32_0;
        public static System.Func<int, bool> <>9__39_0;
        private bool <PRISM.Adapters.IMessagePopupBuilderButton0.ShowYesNoPopupAsync>b__31_0(int id);
        private bool <PRISM.Adapters.IMessagePopupBuilderButton0.ShowOkCancelPopupAsync>b__32_0(int id);
        private bool <PRISM.Adapters.IMessagePopupBuilderButton2.ShowAsync>b__39_0(int id);
    }
}

// Namespace: PRISM.Interactions
public class MessagePopupView : UnityEngine.MonoBehaviour, PRISM.Adapters.IMessageScrollPopupView, PRISM.Adapters.IMessagePopupView, PRISM.Adapters.IClosablePopupFrame<int>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<int>, PRISM.Interactions.IPopupContent
{
    private ENTERPRISE.UI.UITextMeshProUGUI uiTextMeshProUGUI;
    private PRISM.Interactions.PopupFrameParameter frameParameter;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<int> onClickSubject;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<int> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Initialize(PRISM.Adapters.IMessagePopupParameter messagePopupParameter);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    private bool _existsBaseCamera();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private ButtonInfoParameter <Initialize>b__5_0(System.ValueTuple<string, System.Nullable<PopupButtonType>> buttonInfo, int index);
    private void <Initialize>b__5_2();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<UnityEngine.Camera, UnityEngine.Rendering.Universal.UniversalAdditionalCameraData> <>9__7_0;
        public static System.Func<UnityEngine.Rendering.Universal.UniversalAdditionalCameraData, bool> <>9__7_1;
        private UnityEngine.Rendering.Universal.UniversalAdditionalCameraData <_existsBaseCamera>b__7_0(UnityEngine.Camera cam);
        private bool <_existsBaseCamera>b__7_1(UnityEngine.Rendering.Universal.UniversalAdditionalCameraData universalAdditionalCameraData);
    }

    private class <>c__DisplayClass5_0
    {
        public int index;
        public PRISM.Interactions.MessagePopupView <>4__this;
        private void <Initialize>b__1();
    }
}

// Namespace: PRISM.Interactions
public class PopupButton : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView button;
    private ENTERPRISE.UI.UITextMeshProUGUI text;
    private PRISM.Interactions.ViewStateChanger typeChanger;
    private UnityEngine.GameObject blackCover;
    private System.IDisposable disposable;
    private bool isEnable;
    public bool IsEnable { get; set; }
    public void SetInformation(ButtonInfoParameter info);
    public void SetClickableCover(bool isActive);

    private class <>c__DisplayClass9_0
    {
        public ButtonInfoParameter info;
        private void <SetInformation>b__0(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions
public class PopupFrameParameter
{
    private PopupSizeType <SizeType>k__BackingField;
    private HeaderInfoParameter <HeaderParameter>k__BackingField;
    private FooterInfoParameter <FooterParameter>k__BackingField;
    private OutOfRangeInfoParameter <OutOfRangeParameter>k__BackingField;
    private PRISM.Definitions.SoundKey <OpenSE>k__BackingField;
    private PRISM.Definitions.SoundKey <CloseSE>k__BackingField;
    public PopupSizeType SizeType { get; set; }
    public HeaderInfoParameter HeaderParameter { get; set; }
    public FooterInfoParameter FooterParameter { get; set; }
    public OutOfRangeInfoParameter OutOfRangeParameter { get; set; }
    public PRISM.Definitions.SoundKey OpenSE { get; set; }
    public PRISM.Definitions.SoundKey CloseSE { get; set; }

    public class HeaderInfoParameter
    {
        private string <Title>k__BackingField;
        private System.Action <OnInfoClick>k__BackingField;
        public string Title { get; set; }
        public System.Action OnInfoClick { get; set; }
    }

    public class FooterInfoParameter
    {
        private System.Collections.Generic.IReadOnlyList<ButtonInfoParameter> <ButtonParameters>k__BackingField;
        public System.Collections.Generic.IReadOnlyList<ButtonInfoParameter> ButtonParameters { get; set; }
    }

    public class OutOfRangeInfoParameter
    {
        private PRISM.Definitions.SoundKey <ClickSE>k__BackingField;
        private System.Action <OnClick>k__BackingField;
        public PRISM.Definitions.SoundKey ClickSE { get; set; }
        public System.Action OnClick { get; set; }
    }

    public class ButtonInfoParameter
    {
        private PopupButtonType <Type>k__BackingField;
        private bool <IsEnable>k__BackingField;
        private PRISM.Definitions.SoundKey <ClickSE>k__BackingField;
        private string <Text>k__BackingField;
        private System.Action <OnClick>k__BackingField;
        public PopupButtonType Type { get; set; }
        public bool IsEnable { get; set; }
        public PRISM.Definitions.SoundKey ClickSE { get; set; }
        public string Text { get; set; }
        public System.Action OnClick { get; set; }
    }
}

// Namespace: PRISM.Interactions
public class PopupFrameParameterTemplates
{
    public static FooterInfoParameter CreateCancelDecideFooter(System.Action cancelAction, System.Action decideAction);
    public static FooterInfoParameter CreateCloseFooter(System.Action closeAction);
}

// Namespace: PRISM.Interactions
public class PopupViewFactory : PRISM.Adapters.IPopupViewFactory
{
    private PRISM.Definitions.ScopedReactiveProperty<PRISM.Adapters.PopupFrameType> <FrameType>k__BackingField;
    public PRISM.Definitions.ScopedReactiveProperty<PRISM.Adapters.PopupFrameType> FrameType { get; set; }
    public Cysharp.Threading.Tasks.UniTask<T> GeneratePopupViewAsync<T>(PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);

    private struct <GeneratePopupViewAsync>d__3`1<T> : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<T> <>t__builder;
        public PRISM.Interactions.PopupViewFactory <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        private System.IDisposable <_>5__2;
        private Awaiter<System.ValueTuple<UnityEngine.GameObject, UnityEngine.GameObject>> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class RankingRewardListCell : PRISM.Interactions.ListViewCell<PRISM.Adapters.RankingRewardListCellViewModel>
{
    private ENTERPRISE.UI.UITextMeshProUGUI titleText;
    private UnityEngine.Transform rewardIconContainer;
    private ENTERPRISE.OutGame.RewardItem rewardIconBase;
    private PRISM.Interactions.SimpleAchievementIcon achievementIconBase;
    private PRISM.AutoCancellationTokenSource canceller;
    public void UpdateContent(PRISM.Adapters.RankingRewardListCellViewModel viewModel);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Module.Networking.IProductWithAmountStatus, bool> <>9__5_0;
        public static System.Func<PRISM.Module.Networking.IProductWithAmountStatus, bool> <>9__5_1;
        private bool <UpdateContent>b__5_0(PRISM.Module.Networking.IProductWithAmountStatus r);
        private bool <UpdateContent>b__5_1(PRISM.Module.Networking.IProductWithAmountStatus r);
    }
}

// Namespace: PRISM.Interactions
public class RankingRewardListView : PRISM.Interactions.ListView<PRISM.Interactions.RankingRewardListCell, PRISM.Adapters.RankingRewardListCellViewModel>
{
}

// Namespace: PRISM.Interactions
public class RankingRewardPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IRankingRewardPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClick;
    private ENTERPRISE.UI.UITabGroup tabGroup;
    private UnityEngine.GameObject[] tabViews;
    private PRISM.Interactions.RankingRewardListView highScoreRewardListView;
    private PRISM.Interactions.RankingRewardListView technicalRewardListView;
    private int seasonNumber;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Initialize(int seasonNumber, int tabIndex, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void Assign(System.Collections.Generic.IEnumerable<PRISM.Adapters.RankingRewardListCellViewModel> highScoreRateRewardDataList, System.Collections.Generic.IEnumerable<PRISM.Adapters.RankingRewardListCellViewModel> technicalRateRewardDataList);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <Initialize>b__8_0(int index, ENTERPRISE.UI.UITabGroup _);
    private static void <Assign>g__SetData|9_0(System.Collections.Generic.IEnumerable<PRISM.Adapters.RankingRewardListCellViewModel> viewData, PRISM.Interactions.RankingRewardListView view);
    private void <CreateFrameParameter>b__10_0();
    private void <CreateFrameParameter>b__10_1();
}

// Namespace: PRISM.Interactions
public class ReceiveRewardItem : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI itemText;
    private PRISM.Interactions.RewardItemIcon rewardItem;
    public void Setup(PRISM.Domain.ProductKey product, int amount, PRISM.ResourceManagement.IResourceLoader resourceLoader, bool isShowDetail, bool isShowAmount);
}

// Namespace: PRISM.Interactions
public class SDCharacterDisplayModelView : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.RawImage miniStageDisplay;
    private PRISM.Legacy.SimpleModel3dLoader model3dLoader;
    private bool isCompleteSetup;
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(string scenarioName, PRISM.UnitIdol[] unitIdols, System.Threading.CancellationToken ct);
    private void _setupReservedBuffer();
    private void Update();
    private void OnDestroy();
    private Cysharp.Threading.Tasks.UniTask <InitializeAsync>b__3_0();
}

// Namespace: PRISM.Interactions
public class FaqQueryGenerator
{
    private static string CommonKey;
    private static string LinkKey;
    private static string Format;
    private static int SaltLength;
    public static string Generate(string userId, string linkKey);
}

// Namespace: PRISM.Interactions
public class TransferContactPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.ITransferContactPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private ENTERPRISE.UI.UITextMeshProUGUI message;
    private ENTERPRISE.UI.UITextMeshProUGUI playerIdLabel;
    private ENTERPRISE.UI.UITextMeshProUGUI playerIdValueText;
    private ENTERPRISE.UI.UITextMeshProUGUI copyIdText;
    private ENTERPRISE.UI.UIButton copyIdButton;
    private UniRx.Subject<UniRx.Unit> onContactButtonClicked;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onCloseRequested;
    private PRISM.Interactions.IPopupFrameView parent;
    public System.IObservable<UniRx.Unit> OnClickCopyIdButton { get; set; }
    public System.IObservable<UniRx.Unit> OnOpeningContactURL { get; set; }
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Initialize(string userID);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    private void OnDestroy();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__14_0();
    private void <CreateFrameParameter>b__14_1();
    private void <CreateFrameParameter>b__14_2();

    private class MlKeyUtil
    {
        private static string Category;
        public PRISM.Definitions.LocalizationKey PopupTitle { get; set; }
        public PRISM.Definitions.LocalizationKey Message { get; set; }
        public PRISM.Definitions.LocalizationKey PlayerIdLabel { get; set; }
        public PRISM.Definitions.LocalizationKey PlayerIdNotExist { get; set; }
        public PRISM.Definitions.LocalizationKey CopyId { get; set; }
        public PRISM.Definitions.LocalizationKey Caution { get; set; }
        public PRISM.Definitions.LocalizationKey Cancel { get; set; }
        public PRISM.Definitions.LocalizationKey OpenContactUrl { get; set; }
    }
}

// Namespace: PRISM.Interactions
public class WebViewPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IWebViewPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private ENTERPRISE.Webview.NativeWebview nativeWebview;
    private ENTERPRISE.Webview.WebviewController webviewController;
    private PRISM.Interactions.PopupFrameParameter frameParameter;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClick;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Initialize(PRISM.Adapters.WebViewParameter webViewParameter);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();

    private class <>c__DisplayClass6_0
    {
        public PRISM.Interactions.WebViewPopupView <>4__this;
        public PRISM.Adapters.WebViewParameter webViewParameter;
        private void <Initialize>b__1();
        private void <Initialize>b__2();
        private void <Initialize>b__0(string scheme, string url);
    }

    private struct <ShowAsync>d__8 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.WebViewPopupView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class XmlDocumentPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IXmlDocumentPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private Growing.XMLPanel xmlPanel;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Interactions.PopupFrameParameter frameParameter;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void Initialize(string title, string body);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <Initialize>b__6_0();
    private void <Initialize>b__6_1();
}

// Namespace: PRISM.Interactions
public class ResettableComponentPool`1<T>
{
    private T prefab;
    private UnityEngine.Transform parent;
    private System.Collections.Generic.List<T> list;
    private int index;
    public T Get();
    public void Reset();
}

// Namespace: PRISM.Interactions
public class ScreenTapSkipAnimationPlayer : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UIButton skipButton;
    private bool isSkip;
    private System.Threading.CancellationTokenSource skipCancellationTokenSource;
    private bool isSetuped;
    public Cysharp.Threading.Tasks.UniTask PlayAnimationAsync(System.Func<System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask> animationTask, System.Action onSkip, System.Threading.CancellationToken cancellationToken);
    private void _setUp();
    private void <_setUp>b__5_0();

    private struct <PlayAnimationAsync>d__4 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ScreenTapSkipAnimationPlayer <>4__this;
        public System.Threading.CancellationToken cancellationToken;
        public System.Func<System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask> animationTask;
        public System.Action onSkip;
        private System.Threading.CancellationTokenSource <cancellationTokenSource>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public struct SerializeWithId`1<T> : System.ValueType
{
    private int id;
    private T content;
    public void Deconstruct(int& id, T& content);
}

// Namespace: PRISM.Interactions
public class SortFilterSettingsPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.ISortFilterSettingsPopupView, PRISM.Adapters.IClosablePopupFrame<PRISM.Definitions.SortFilterSettings>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<PRISM.Definitions.SortFilterSettings>
{
    private PRISM.Interactions.ViewStateChanger sortFilterStateChanger;
    private PRISM.Interactions.ToggleGroupView tabGroup;
    private UniqueSortToggleButton[] uniqueSortToggleButtons;
    private PRISM.Interactions.SortToggleButtonView defaultSortToggleButtonPrefab;
    private UnityEngine.Transform filterContentParent;
    private PRISM.Interactions.ButtonView resetFilterButton;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<PRISM.Definitions.SortFilterSettings> onClosed;
    private string popupTitle;
    private System.Collections.Generic.IReadOnlyList<PRISM.Definitions.SortType> sortTypes;
    private UniRx.ReactiveProperty<int> selectedSortIndex;
    private System.Collections.Generic.Dictionary<PRISM.Definitions.FilterType, System.Collections.Generic.ISet<int>> filterOnIds;
    private PRISM.Definitions.SortDirection initialSortDirection;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<PRISM.Definitions.SortFilterSettings> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(UniRx.IReactiveProperty<int> tabIndex, System.Collections.Generic.IReadOnlyList<PRISM.Definitions.SortType> sortTypes, System.Collections.Generic.IReadOnlyList<PRISM.Definitions.FilterType> filterTypes, PRISM.Definitions.SortFilterSettings currentSettings, PRISM.ResourceManagement.IResourceLoader resourceLoader, string popupTitle, System.Collections.Generic.IReadOnlyDictionary<PRISM.Definitions.FilterType, PRISM.Adapters.IFilterToggleGroupViewOption> filterToggleGroupViewOptions, System.Threading.CancellationToken cancellationToken);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__17_0();
    private void <CreateFrameParameter>b__17_1();
    private void <CreateFrameParameter>b__17_2();

    private enum SortFilterType : System.Enum
    {
        public int value__;
        public static SortFilterType SortOnly;
        public static SortFilterType FilterOnly;
        public static SortFilterType SortFilter;
    }

    private class UniqueSortToggleButton
    {
        public string Type;
        public PRISM.Interactions.ButtonView Button;
    }

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Definitions.SortType, PRISM.Definitions.SortType, bool> <>9__16_0;
        private bool <InitializeAsync>b__16_0(PRISM.Definitions.SortType x, PRISM.Definitions.SortType state);
    }

    private class <>c__DisplayClass16_0
    {
        public PRISM.Interactions.SortFilterSettingsPopupView <>4__this;
        public UnityEngine.Transform container;
        private PRISM.Interactions.ButtonView <InitializeAsync>b__1(PRISM.Definitions.SortType type);
    }

    private class <>c__DisplayClass16_1
    {
        public string typeString;
        private bool <InitializeAsync>b__2(UniqueSortToggleButton x);
    }

    private class <>c__DisplayClass16_2
    {
        public System.Collections.Generic.List<PRISM.Definitions.ReactiveHashSet<int>> reactiveFilterOnIds;
        private void <InitializeAsync>b__3(UniRx.Unit _);
    }

    private struct <InitializeAsync>d__16 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.SortFilterSettingsPopupView <>4__this;
        public System.Collections.Generic.IReadOnlyList<PRISM.Definitions.SortType> sortTypes;
        public System.Collections.Generic.IReadOnlyList<PRISM.Definitions.FilterType> filterTypes;
        public string popupTitle;
        public UniRx.IReactiveProperty<int> tabIndex;
        public PRISM.Definitions.SortFilterSettings currentSettings;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken cancellationToken;
        public System.Collections.Generic.IReadOnlyDictionary<PRISM.Definitions.FilterType, PRISM.Adapters.IFilterToggleGroupViewOption> filterToggleGroupViewOptions;
        private <>c__DisplayClass16_2 <>8__1;
        private System.Collections.Generic.IEnumerator<PRISM.Definitions.FilterType> <>7__wrap1;
        private PRISM.Definitions.FilterType <filterType>5__3;
        private Awaiter<PRISM.Interactions.FilterToggleGroupViewFactory> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class SortToggleButtonView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView buttonView;
    private ENTERPRISE.UI.UITextMeshProUGUI buttonText;
    public PRISM.Interactions.ButtonView ButtonView { get; set; }
    public void Initialize(PRISM.Definitions.SortType sortType);
}

// Namespace: PRISM.Interactions
public class AdvTitleView : UnityEngine.MonoBehaviour, PRISM.Adapters.IAdvTitleView
{
    private UnityEngine.Animator produceTitle;
    private UnityEngine.GameObject oneLineTitle;
    private ENTERPRISE.UI.UITextMeshProUGUI oneLineTitleText;
    private UnityEngine.GameObject twoLineTitle;
    private ENTERPRISE.UI.UITextMeshProUGUI chapterTitle;
    private ENTERPRISE.UI.UITextMeshProUGUI titleObject;
    private ENTERPRISE.UI.UITextMeshProUGUI titleFrontObject;
    private UnityEngine.GameObject storyTitle;
    private ENTERPRISE.UI.UITextMeshProUGUI storyChapterTitle;
    private ENTERPRISE.UI.UITextMeshProUGUI storyTitleObject;
    private UnityEngine.GameObject storyTitleBack;
    private UnityEngine.GameObject iconParent;
    private PRISM.Interactions.ProduceIdolIconView produceIdolIcon;
    private PRISM.Interactions.SupportCharacterIconView supportCharacterIcon;
    private PRISM.Interactions.CharacterBaseIconView characterBaseIcon;
    private UnityEngine.UI.Image unitIconImage;
    private int animatorHashAppearTitle;
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.IAdvTitleViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public void Show();
    private void _initializeTitle(PRISM.IAdvTitleViewModel viewModel);
    private Cysharp.Threading.Tasks.UniTask _initializeIconAsync(PRISM.IAdvTitleViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
}

// Namespace: PRISM.Interactions
public class NewStoryCellView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView button;
    private PRISM.Interactions.StoryThumbnailView thumbnailView;
    private ENTERPRISE.UI.UITextMeshProUGUI mainTitle;
    private ENTERPRISE.UI.UITextMeshProUGUI mainTitleFront;
    private ENTERPRISE.UI.UITextMeshProUGUI subTitle;
    private PRISM.Interactions.ViewStateChanger newBadgeChanger;
    private PRISM.Interactions.ViewStateChanger unreadBadgeChanger;
    private PRISM.Interactions.ViewStateChanger lockChanger;
    private ENTERPRISE.UI.UITextMeshProUGUI lockText;
    private UnityEngine.UI.Image logoImage;
    private PRISM.Interactions.Story.StoryCategoryTypeLabelView categoryTypeLabelView;
    private PRISM.Interactions.ViewStateChanger showCategoryTypeLabelChanger;
    private PRISM.Interactions.ButtonView favoriteButton;
    private PRISM.Interactions.ViewStateChanger favoriteButtonChanger;
    private PRISM.Interactions.Story.StoryRewardItemIcon storyRewardItemIconPrefab;
    private UnityEngine.Transform rewardItemIconPos;
    private PRISM.Interactions.ResettableComponentPool<PRISM.Interactions.Story.StoryRewardItemIcon> rewardItemIconPool;
    public System.IObservable<UniRx.Unit> OnClick { get; set; }
    public System.IObservable<UniRx.Unit> OnClickFavoriteButton { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.NewStoryCellViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
}

// Namespace: PRISM.Interactions
public class StoryThumbnailView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ViewStateChanger thumbnailChanger;
    private UnityEngine.UI.Image thumbnailImage;
    private PRISM.Interactions.ProduceIdolIconView produceIdolIconView;
    private UnityEngine.UI.RawImage supportCharacterIconImage;
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.IStoryThumbnailViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);

    private enum ThumbnailType : System.Enum
    {
        public int value__;
        public static ThumbnailType Default;
        public static ThumbnailType ProduceIdol;
        public static ThumbnailType SupportCharacter;
    }
}

// Namespace: PRISM.Interactions
public class ScreenInfo
{
    private static int DmmFullScreenWidth;
    private static int DmmFullScreenHeight;
    private static int DmmScreenWidth;
    private static int DmmScreenHeight;
    private static int NotFullScreenBorderWidthRatio;
    private static int NotFullScreenBorderHeightRatio;
    public static bool IsOverFullScreenBorder();
    public static UnityEngine.Vector2Int GetTargetScreenSize(bool isFullScreen);
}

// Namespace: PRISM.Interactions
public class SystemCall : PRISM.Adapters.ISystemCall, PRISM.Legacy.ISystemCallForLegacy
{
    public void OpenURL(string url);
    public string GenerateFaqQuery(string userID, string linkKey);
    public void CopyToScratch(string text);
    public System.IDisposable CreateIOSHomeBarAntiSwipableScope();
}

// Namespace: PRISM.Interactions
public class TimelineAnimationMaintainer : UnityEngine.MonoBehaviour
{
    private UnityEngine.Playables.PlayableDirector director;
    private PRISM.Interactions.Drama.DramaSceneCharacter character;
    private bool isPauseEndTiming;
    private UnityEngine.Playables.PlayableGraph playableGraph;
    private UnityEngine.Animations.AnimationPlayableOutput output;
    private UnityEngine.Animations.AnimationClipPlayable maintainLoopPlayable;
    private double time;
    private UnityEngine.Animator _getAnimator();
    private void _setupPlayableGraph();
    private void OnEnable();
    private void OnDisable();
    private void _createMaintainPlayable(UnityEngine.Playables.PlayableDirector director);
    private void _onPlayed(UnityEngine.Playables.PlayableDirector director);
    private void Update();

    private class <>c__DisplayClass11_0
    {
        public UnityEngine.Playables.PlayableDirector director;
        public UnityEngine.Animator animator;
        private bool <_createMaintainPlayable>b__0(UnityEngine.Timeline.TrackAsset t);
    }
}

// Namespace: PRISM.Interactions
public class TimelineScene : UnityEngine.MonoBehaviour
{
    public static string CharacterRootGroupTrackName;
    private UnityEngine.Playables.PlayableDirector director;
    private PRISM.CameraController mainCamera;
    private Render3DManager render3DManager;
    private UnityEngine.Transform characterRoot;
    private UnityEngine.Transform audioRoot;
    private UnityEngine.Transform cameraRoot;
    private UnityEngine.Transform propRoot;
    private UnityEngine.Transform bgModelRoot;
    private UnityEngine.Transform cutSceneRoot;
    private System.Nullable<double> cachedDuration;
    public UnityEngine.Playables.PlayableDirector Director { get; set; }
    public PRISM.CameraController MainCamera { get; set; }
    public Render3DManager Render3DManager { get; set; }
    public UnityEngine.Transform CharacterRoot { get; set; }
    public UnityEngine.Transform AudioRoot { get; set; }
    public UnityEngine.Transform CameraRoot { get; set; }
    public UnityEngine.Transform PropRoot { get; set; }
    public UnityEngine.Transform BgModelRoot { get; set; }
    public UnityEngine.Transform CutSceneRoot { get; set; }
    public bool IsParentScene();
    public double GetPlayableDirectorDuration();
    public Cysharp.Threading.Tasks.UniTask WaitPlayEndAsync(System.Threading.CancellationToken ct);

    private class <>c__DisplayClass31_0
    {
        public PRISM.Interactions.TimelineScene <>4__this;
        public double duration;
        private bool <WaitPlayEndAsync>b__0();
    }
}

// Namespace: PRISM.Interactions
public class TimelineSceneCharacterDropShadowOffset : UnityEngine.MonoBehaviour
{
    private float offsetY;
    private PRISM.Character targetCharacter;
    private void Update();
}

// Namespace: PRISM.Interactions
public class TimelineSceneInitializer
{
    public static bool Initialize(PRISM.Interactions.TimelineScene timelineScene, bool skipCharacterInitialize);
    public static void SetUpCharacters(PRISM.Interactions.TimelineScene scene, PRISM.Interactions.TimelineScene[] childScenes);
    private static void _setupCinemachineCamera(Cinemachine.CinemachineVirtualCamera cinemachineCamera, PRISM.Interactions.Drama.DramaSceneCharacter[] dramaCharacters);
    private static UnityEngine.Transform _getSwapTransform(UnityEngine.Transform baseTransform, PRISM.Interactions.Drama.DramaSceneCharacter[] dramaCharacters);
    private static UnityEngine.Transform _getSwapTransform(UnityEngine.Transform baseTransform, UnityEngine.Transform baseRootTransform, UnityEngine.Transform swapRootTransform);

    private class <>c__DisplayClass3_0
    {
        public UnityEngine.Transform baseTransform;
        private bool <_getSwapTransform>b__0(PRISM.Interactions.Drama.DramaSceneCharacter dramaCharacter);
    }
}

// Namespace: PRISM.Interactions
public class TMPKeyWordTouchDetector : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IEventSystemHandler
{
    private ENTERPRISE.UI.UITextMeshProUGUI uiTMP;
    private UnityEngine.Camera UIDisplayCamera;
    private UniRx.Subject<System.ValueTuple<int, TMPro.TMP_TextInfo>> onTouch;
    public System.IObservable<System.ValueTuple<int, TMPro.TMP_TextInfo>> OnKeyWordTouch { get; set; }
    private void Awake();
    public void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
}

// Namespace: PRISM.Interactions
public class AnimationClipUIAnimation : PRISM.UIAnimation
{
    private PRISM.Interactions.AnimationClipPlayer clipPlayer;
    private PRISM.Definitions.SkippableCancellationTokenSource skippableCancellationTokenSource;
    public float Duration { get; set; }
    public Cysharp.Threading.Tasks.UniTask PlayAsync(float delay, System.Threading.CancellationToken ct);
    public void Skip();
    public void Oestroy();

    private struct <PlayAsync>d__4 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.AnimationClipUIAnimation <>4__this;
        public System.Threading.CancellationToken ct;
        public float delay;
        private ClipPlayableInfo <playInfo>5__2;
        private System.Threading.CancellationToken <skippableToken>5__3;
        private System.Threading.CancellationTokenSource <linkedTokenSource>5__4;
        private System.Threading.CancellationToken <linkedToken>5__5;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class CompositeUIAnimation : PRISM.UIAnimation
{
    private System.Collections.Generic.List<Setting> settings;
    public float Duration { get; set; }
    public Cysharp.Threading.Tasks.UniTask PlayAsync(float delay, System.Threading.CancellationToken ct);
    public void Skip();
    public void AddAnimation(float delay, PRISM.UIAnimation animation);

    private struct Setting : System.ValueType
    {
        public float Delay;
        public PRISM.UIAnimation Animation;
    }

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<Setting, float> <>9__3_0;
        private float <get_Duration>b__3_0(Setting x);
    }

    private class <>c__DisplayClass4_0
    {
        public float delay;
        public System.Threading.CancellationToken ct;
        private Cysharp.Threading.Tasks.UniTask <PlayAsync>b__0(Setting x);
    }
}

// Namespace: PRISM.Interactions
public class CountUpUIAnimation : PRISM.UIAnimation
{
    private EasingCore.Ease easeType;
    private float duration;
    protected TMPro.TextMeshProUGUI text;
    private long startValue;
    private long targetValue;
    private bool isEraseUnderStartValue;
    private CountSEType seType;
    private static System.Collections.Generic.Dictionary<CountSEType, PRISM.Definitions.SoundKey> LoopSEKeys;
    private static System.Collections.Generic.Dictionary<CountSEType, PRISM.Definitions.SoundKey> EndSEKeys;
    public float Duration { get; set; }
    public Cysharp.Threading.Tasks.UniTask PlayAsync(float delay, System.Threading.CancellationToken ct);
    public void Skip();
    public void SetTargetValue(long value);
    private void _updateNumber(float r);
    protected void _setText(long displayValue);

    private enum CountSEType : System.Enum
    {
        public int value__;
        public static CountSEType None;
        public static CountSEType LiveSE;
    }

    private struct <PlayAsync>d__12 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public float delay;
        public PRISM.Interactions.CountUpUIAnimation <>4__this;
        public System.Threading.CancellationToken ct;
        private float <time>5__2;
        private EasingCore.EasingFunction <ease>5__3;
        private Awaiter <>u__1;
        private System.IDisposable <>7__wrap3;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class DefaultUIAnimation : PRISM.Interactions.UIAnimationBase
{
    private UnityEngine.CanvasGroup canvasGroup;
    private UnityEngine.Vector2 positionOffset;
    private UnityEngine.Vector2 sizeOffset;
    private float scaleOffset;
    private float alphaOffset;
    private UnityEngine.RectTransform rectTransform;
    private UnityEngine.Vector2 fromPosition;
    private UnityEngine.Vector2 toPosition;
    private UnityEngine.Vector2 fromSize;
    private UnityEngine.Vector2 toSize;
    private UnityEngine.Vector3 fromScale;
    private UnityEngine.Vector3 toScale;
    private float fromAlpha;
    private float toAlpha;
    protected void _prepare();
    protected void _update(float r);
}

// Namespace: PRISM.Interactions
public class DurationDeterminedUIAnimation : PRISM.UIAnimation
{
    private float duration;
    private PRISM.UIAnimation referredAnimation;
    public float Duration { get; set; }
    public Cysharp.Threading.Tasks.UniTask PlayAsync(float delay, System.Threading.CancellationToken ct);
    public void Skip();
}

// Namespace: PRISM.Interactions
public class DynamicCompositeUIAnimation : PRISM.UIAnimation
{
    private float delay;
    public float Duration { get; set; }
    public Cysharp.Threading.Tasks.UniTask PlayAsync(float delay, System.Threading.CancellationToken ct);
    public void Skip();
    private bool <get_Duration>b__2_0(PRISM.UIAnimation x);
    private float <get_Duration>b__2_1(PRISM.UIAnimation child, int index);

    private class <>c__DisplayClass3_0
    {
        public PRISM.Interactions.DynamicCompositeUIAnimation <>4__this;
        public float delay;
        public System.Threading.CancellationToken ct;
        private bool <PlayAsync>b__0(PRISM.UIAnimation x);
        private Cysharp.Threading.Tasks.UniTask <PlayAsync>b__1(PRISM.UIAnimation child, int index);
    }

    private struct <PlayAsync>d__3 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.DynamicCompositeUIAnimation <>4__this;
        public float delay;
        public System.Threading.CancellationToken ct;
        private <>c__DisplayClass3_0 <>8__1;
        private UnityEngine.Pool.PooledObject<System.Collections.Generic.List<PRISM.UIAnimation>> <_>5__2;
        private System.Collections.Generic.List<PRISM.UIAnimation> <list>5__3;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class ImageFillUIAnimation : PRISM.Interactions.UIAnimationBase
{
    private UnityEngine.UI.Image image;
    private float fromFill;
    private float toFill;
    public void SetTargetFillAmount(float toFill);
    protected void _prepare();
    protected void _update(float r);
}

// Namespace: PRISM.Interactions
public class PlaySEUIAnimation : PRISM.UIAnimation
{
    private string cuesheet;
    private string cueName;
    public float Duration { get; set; }
    public Cysharp.Threading.Tasks.UniTask PlayAsync(float delay, System.Threading.CancellationToken ct);
    public void Skip();

    private struct <PlayAsync>d__4 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.PlaySEUIAnimation <>4__this;
        public float delay;
        public System.Threading.CancellationToken ct;
        private PRISM.Definitions.SoundKey <soundKey>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class SequentialUIAnimation : PRISM.UIAnimation
{
    private System.Collections.Generic.List<Setting> settings;
    public float Duration { get; set; }
    public Cysharp.Threading.Tasks.UniTask PlayAsync(float delay, System.Threading.CancellationToken ct);
    public void Skip();
    public void AddAnimation(float delay, PRISM.UIAnimation animation);

    private struct Setting : System.ValueType
    {
        public float Delay;
        public PRISM.UIAnimation Animation;
    }

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<Setting, float> <>9__3_0;
        private float <get_Duration>b__3_0(Setting x);
    }
}

// Namespace: PRISM.Interactions
public class TextUIAnimation : PRISM.Interactions.UIAnimationBase
{
    private TMPro.TextMeshProUGUI text;
    private float characterSpacingOffset;
    private float fromCharacterSpacing;
    private float toCharacterSpacing;
    protected void _prepare();
    protected void _update(float r);
}

// Namespace: PRISM.Interactions
public class UIAnimationBase : PRISM.UIAnimation
{
    private EasingCore.Ease easeType;
    private float duration;
    private bool isReady;
    public float Duration { get; set; }
    protected void _prepare();
    protected void _update(float r);
    public Cysharp.Threading.Tasks.UniTask PlayAsync(float delay, System.Threading.CancellationToken ct);
    public void Skip();

    private struct <PlayAsync>d__7 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.UIAnimationBase <>4__this;
        public float delay;
        public System.Threading.CancellationToken ct;
        private float <time>5__2;
        private EasingCore.EasingFunction <ease>5__3;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class AttributeIconView : PRISM.AttributeIconViewForLegacy
{
    private PRISM.Interactions.ViewStateChanger stateChanger;
    public void Show(int attribute);
}

// Namespace: PRISM.Interactions
public class BadgeView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ViewStateChanger showChanger;
    private PRISM.Interactions.ViewStateChanger badgeChanger;
    private ENTERPRISE.UI.UITextMeshProUGUI amountText;
    public void Setup(PRISM.Adapters.IBadgeModel model);
}

// Namespace: PRISM.Interactions
public class BitToggleButtonView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView button;
    private PRISM.Interactions.ViewStateChanger isOnStateChanger;
    public void Initialize(UniRx.IReactiveProperty<int> onBits, int bit, System.Threading.CancellationToken cancellationToken);

    private class <>c__DisplayClass2_0
    {
        public UniRx.IReactiveProperty<int> onBits;
        public int bit;
        public PRISM.Interactions.BitToggleButtonView <>4__this;
        private void <Initialize>b__0(UniRx.Unit _);
        private void <Initialize>b__1(int x);
    }
}

// Namespace: PRISM.Interactions
public class ButtonView : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerUpHandler, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IPointerMoveHandler, System.IDisposable
{
    private bool interactable;
    private PRISM.Interactions.ViewStateChanger interactableStateChanger;
    private bool <EnableScaleAnimation>k__BackingField;
    private float pressScale;
    private float scaleSecond;
    private DG.Tweening.Ease scaleEase;
    private PRISM.Definitions.SoundKey <ClickSe>k__BackingField;
    private UniRx.Subject<UniRx.Unit> onClick;
    private bool canInvoke;
    private UniRx.Subject<UniRx.Unit> onLongPress;
    private System.Func<System.IObservable<long>> longPressObservableFactory;
    private System.IDisposable longPressObservableDisposable;
    private bool isRepeatActive;
    public bool EnableScaleAnimation { get; set; }
    public PRISM.Definitions.SoundKey ClickSe { get; set; }
    public System.IObservable<UniRx.Unit> OnClick { get; set; }
    public System.IObservable<UniRx.Unit> OnLongPress(float delay);
    public System.IObservable<UniRx.Unit> OnRepeatPress(float interval);
    public void SetInteractable(bool value);
    public void Dispose();
    private void OnDestroy();
    private void UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
    private void UnityEngine.EventSystems.IPointerMoveHandler.OnPointerMove(UnityEngine.EventSystems.PointerEventData eventData);
    private void UnityEngine.EventSystems.IPointerUpHandler.OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
    private void UnityEngine.EventSystems.IPointerClickHandler.OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);

    private class <>c
    {
        public static <>c <>9;
        public static System.Action<long> <>9__21_1;
        private void <OnLongPress>b__21_1(long _);
    }

    private class <>c__DisplayClass21_0
    {
        public System.TimeSpan delaySpan;
        private System.IObservable<long> <OnLongPress>b__0();
    }

    private class <>c__DisplayClass22_0
    {
        public System.TimeSpan intervalSpan;
        public PRISM.Interactions.ButtonView <>4__this;
        public System.Action<long> <>9__1;
        private System.IObservable<long> <OnRepeatPress>b__0();
        private void <OnRepeatPress>b__1(long _);
    }

    private class <>c__DisplayClass26_0
    {
        public PRISM.Interactions.ButtonView <>4__this;
        public UnityEngine.EventSystems.PointerEventData eventData;
        private void <UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown>b__0(long _);
    }
}

// Namespace: PRISM.Interactions
public class MinimalUIButtonToggleGroupView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.MinimalUIButtonView[] buttons;
    public void Initialize(UniRx.IReactiveProperty<int> selectedId, System.Threading.CancellationToken ct);
}

// Namespace: PRISM.Interactions
public class MinimalUIButtonView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView button;
    private UnityEngine.UI.Image image;
    private int id;
    public PRISM.Interactions.ButtonView Button { get; set; }
    public UnityEngine.UI.Image Image { get; set; }
    public int Id { get; set; }
    public System.IObservable<int> OnClick { get; set; }
    public void SetId(int id);
    private int <get_OnClick>b__10_0(UniRx.Unit _);
}

// Namespace: PRISM.Interactions
public class MinimalUIButtonViewExtensions
{
    public static void ToToggleGroup(System.Collections.Generic.IReadOnlyList<PRISM.Interactions.MinimalUIButtonView> buttons, UniRx.IReactiveProperty<int> selectedId, System.Threading.CancellationToken ct);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Interactions.MinimalUIButtonView, PRISM.Interactions.ButtonView> <>9__0_0;
        private PRISM.Interactions.ButtonView <ToToggleGroup>b__0_0(PRISM.Interactions.MinimalUIButtonView x);
    }

    private class <>c__DisplayClass0_0
    {
        public System.Collections.Generic.IReadOnlyList<PRISM.Interactions.MinimalUIButtonView> buttons;
        private int <ToToggleGroup>b__1(int index);
    }
}

// Namespace: PRISM.Interactions
public class NumberFluctuateButtonView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView button;
    private float repeatPressInterval;
    private int diff;
    public System.IObservable<int> OnClick { get; set; }
    public void UpdateView(int currentValue, int minValue, int maxValue);
    private int <get_OnClick>b__4_0(UniRx.Unit _);
    private int <get_OnClick>b__4_1(UniRx.Unit _);
}

// Namespace: PRISM.Interactions
public class NumberFluctuateButtonViewExtensions
{
    public static System.IObservable<int> OnClick(System.Collections.Generic.IEnumerable<PRISM.Interactions.NumberFluctuateButtonView> buttons);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Interactions.NumberFluctuateButtonView, System.IObservable<int>> <>9__0_0;
        private System.IObservable<int> <OnClick>b__0_0(PRISM.Interactions.NumberFluctuateButtonView x);
    }
}

// Namespace: PRISM.Interactions
public class ToggleButtonView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView button;
    private PRISM.Interactions.ViewStateChanger isOnStateChanger;
    public void Initialize(UniRx.IReactiveProperty<bool> isOn, System.Threading.CancellationToken cancellationToken);
    public void Initialize(bool isOn, System.Action<bool> onChange, System.Threading.CancellationToken cancellationToken);

    private class <>c__DisplayClass2_0
    {
        public UniRx.IReactiveProperty<bool> isOn;
        public PRISM.Interactions.ToggleButtonView <>4__this;
        private void <Initialize>b__0(UniRx.Unit _);
        private void <Initialize>b__1(bool x);
    }

    private class <>c__DisplayClass3_0
    {
        public bool isOn;
        public PRISM.Interactions.ToggleButtonView <>4__this;
        public System.Action<bool> onChange;
        private void <Initialize>b__0(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions
public class ToggleGroupView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView[] toggleButtons;
    private PRISM.Interactions.ViewStateChanger selectedIndexStateChanger;
    public void Initialize(UniRx.IReactiveProperty<int> selectedIndex, System.Threading.CancellationToken cancellationToken);
    public static System.IDisposable Create(System.Collections.Generic.IEnumerable<PRISM.Interactions.ButtonView> toggleButtons, UniRx.IReactiveProperty<int> selectedId, System.Func<int, int> indexToId);
    public void Initialize(int firstSelectedIndex, System.Action<int> onChange);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Interactions.ButtonView, int, System.ValueTuple<PRISM.Interactions.ButtonView, int>> <>9__3_0;
        private System.ValueTuple<PRISM.Interactions.ButtonView, int> <Create>b__3_0(PRISM.Interactions.ButtonView x, int i);
    }

    private class <>c__DisplayClass3_0
    {
        public UniRx.IReactiveProperty<int> selectedId;
    }

    private class <>c__DisplayClass3_1
    {
        public PRISM.Interactions.ButtonView button;
        public int id;
        public <>c__DisplayClass3_0 CS$<>8__locals1;
        private void <Create>b__1(UniRx.Unit _);
        private void <Create>b__2(int x);
    }

    private class <>c__DisplayClass4_0
    {
        public System.Action<int> onChange;
        public PRISM.Interactions.ToggleGroupView <>4__this;
        public System.Action<UniRx.Unit, int> <>9__1;
        private void <Initialize>b__1(UniRx.Unit _, int index);
        private void <Initialize>g__UpdateView|0(int index);
    }
}

// Namespace: PRISM.Interactions
public class ToggleGroupViewWithAllOff : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView[] toggleButtons;
    private PRISM.Interactions.ViewStateChanger selectedIndexStateChanger;
    public void Initialize(UniRx.IReactiveProperty<int> selectedIndex, System.Threading.CancellationToken cancellationToken);

    private class <>c__DisplayClass2_0
    {
        public UniRx.IReactiveProperty<int> selectedIndex;
        public System.Action<UniRx.Unit, int> <>9__0;
        private void <Initialize>b__0(UniRx.Unit _, int index);
    }
}

// Namespace: PRISM.Interactions
public class ButtonWithBadgeView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView button;
    private PRISM.Interactions.BadgeView badge;
    public System.IObservable<UniRx.Unit> OnClick { get; set; }
    public void Setup(PRISM.Adapters.IBadgeModel badgeModel);
}

// Namespace: PRISM.Interactions
public class ColorPickerPresetButtonView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView buttonView;
    private UnityEngine.UI.Image colorImage;
    public System.IObservable<UnityEngine.Color> OnClick { get; set; }
    private UnityEngine.Color <get_OnClick>b__3_0(UniRx.Unit _);
}

// Namespace: PRISM.Interactions
public class ColorPickerView : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.Image currentColorImage;
    private UnityEngine.UI.Slider hueSlider;
    private UnityEngine.UI.RawImage hueImage;
    private UnityEngine.UI.Slider saturationSlider;
    private UnityEngine.UI.RawImage saturationImage;
    private UnityEngine.UI.Slider valueSlider;
    private UnityEngine.UI.RawImage valueImage;
    private PRISM.Interactions.ColorPickerPresetButtonView[] presetButtons;
    public UnityEngine.Color CurrentColor { get; set; }
    public System.IDisposable Initialize();
    private void _createTexture(UnityEngine.UI.RawImage image, int width);
    private void _destroyTexture(UnityEngine.UI.RawImage image);
    private void _updateTexture(UnityEngine.UI.RawImage image, System.Func<float, float> h, System.Func<float, float> s, System.Func<float, float> v);
    public void SetColor(UnityEngine.Color color);
    private void _setColor(UnityEngine.Color color, bool updateSliderValues);
    private void <Initialize>b__10_3(float _);
    private void <Initialize>b__10_5();
    private float <_setColor>b__15_0(float _);
    private float <_setColor>b__15_2(float _);
    private float <_setColor>b__15_3(float _);
    private float <_setColor>b__15_4(float _);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<float, float> <>9__10_0;
        public static System.Func<float, float> <>9__10_1;
        public static System.Func<float, float> <>9__10_2;
        public static System.Func<PRISM.Interactions.ColorPickerPresetButtonView, System.IObservable<UnityEngine.Color>> <>9__10_4;
        public static System.Func<float, float> <>9__15_1;
        public static System.Func<float, float> <>9__15_5;
        private float <Initialize>b__10_0(float r);
        private float <Initialize>b__10_1(float _);
        private float <Initialize>b__10_2(float _);
        private System.IObservable<UnityEngine.Color> <Initialize>b__10_4(PRISM.Interactions.ColorPickerPresetButtonView x);
        private float <_setColor>b__15_1(float r);
        private float <_setColor>b__15_5(float r);
    }
}

// Namespace: PRISM.Interactions
public class CommonTitleView : UnityEngine.MonoBehaviour, PRISM.Adapters.ICommonTitleView
{
    private ENTERPRISE.UI.UITextMeshProUGUI titleText;
    private PRISM.Interactions.ButtonView infoButton;
    public System.IObservable<UniRx.Unit> OnClickInfo { get; set; }
    public void SetTitle(string title);
    public void SetActive(bool isActive);
    public void SetInfoButtonActive(bool isActive);
}

// Namespace: PRISM.Interactions
public class CostumeIconView : UnityEngine.MonoBehaviour
{
    private UnityEngine.GameObject emptyView;
    private UnityEngine.UI.RawImage image;
    private PRISM.Interactions.ButtonView button;
    public System.IObservable<UniRx.Unit> OnClick { get; set; }
    public Cysharp.Threading.Tasks.UniTask SetUpAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Domain.ProductKey productKey, bool setClickToDetail, System.Threading.CancellationToken ct);

    private class <>c__DisplayClass5_0
    {
        public PRISM.Domain.ProductKey productKey;
        public System.Threading.CancellationToken ct;
        private void <SetUpAsync>b__0(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions
public class CostumeSetIconView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.CostumeIconView[] costumeIconViews;
    public System.IObservable<PRISM.Definitions.CostumePartType> OnClick { get; set; }
    public Cysharp.Threading.Tasks.UniTask SetUpAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Domain.ICostumeSetData costumeSet, bool setClickToDetail, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask SetUpAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Domain.CostumeSetIds costumeSet, bool setClickToDetail, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask SetUpAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Module.Networking.ICostumePresetStatus preset, bool setClickToDetail, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask SetUpAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Func<PRISM.Definitions.CostumePartType, PRISM.Domain.ProductKey> productKeyGetter, bool setClickToDetail, System.Threading.CancellationToken ct);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Interactions.CostumeIconView, int, System.IObservable<PRISM.Definitions.CostumePartType>> <>9__2_0;
        private System.IObservable<PRISM.Definitions.CostumePartType> <get_OnClick>b__2_0(PRISM.Interactions.CostumeIconView icon, int index);
    }

    private class <>c__DisplayClass2_0
    {
        public int index;
        private PRISM.Definitions.CostumePartType <get_OnClick>b__1(UniRx.Unit _);
    }

    private class <>c__DisplayClass3_0
    {
        public PRISM.Domain.ICostumeSetData costumeSet;
        private PRISM.Domain.ProductKey <SetUpAsync>b__0(PRISM.Definitions.CostumePartType partType);
    }

    private class <>c__DisplayClass4_0
    {
        public PRISM.Domain.CostumeSetIds costumeSet;
        private PRISM.Domain.ProductKey <SetUpAsync>b__0(PRISM.Definitions.CostumePartType partType);
    }

    private class <>c__DisplayClass5_0
    {
        public PRISM.Module.Networking.ICostumePresetStatus preset;
        private PRISM.Domain.ProductKey <SetUpAsync>b__0(PRISM.Definitions.CostumePartType partType);
    }

    private class <>c__DisplayClass5_1
    {
        public PRISM.Definitions.CostumePartType partType;
        private bool <SetUpAsync>b__1(int id);
    }

    private class <>c__DisplayClass6_0
    {
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Func<PRISM.Definitions.CostumePartType, PRISM.Domain.ProductKey> productKeyGetter;
        public bool setClickToDetail;
        public System.Threading.CancellationToken ct;
        private Cysharp.Threading.Tasks.UniTask <SetUpAsync>b__0(PRISM.Interactions.CostumeIconView icon, int index);
    }
}

// Namespace: PRISM.Interactions
public class EventIconView : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI text;
    private UnityEngine.UI.Image iconImage;
    private PRISM.AutoCancellationTokenSource canceller;
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Adapters.IEventIconModel model, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private void OnDestroy();
}

// Namespace: PRISM.Interactions
public class CharacterFilterToggleGroupView : PRISM.Interactions.FilterToggleGroupView
{
    private ENTERPRISE.UI.UITextMeshProUGUI title;
    private PRISM.Interactions.SerializeWithId<PRISM.Interactions.SwitchAllToggleView>[] unitSwitchAllToggles;
    public void Initialize(PRISM.Definitions.IReactiveHashSet<int> onIds, PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Adapters.IFilterToggleGroupViewOption option, System.Threading.CancellationToken cancellationToken);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Definitions.MstCharacterInfo, int> <>9__2_1;
        private int <Initialize>b__2_1(PRISM.Definitions.MstCharacterInfo chara);
    }

    private class <>c__DisplayClass2_0
    {
        public int unitId;
        public PRISM.Interactions.CharacterFilterToggleGroupView <>4__this;
        private bool <Initialize>b__0(PRISM.Definitions.MstCharacterInfo chara);
    }

    private class <>c__DisplayClass2_1
    {
        public PRISM.Definitions.MstCharacterInfo chara;
        private bool <Initialize>b__2(PRISM.Interactions.FilterToggleButtonView toggle);
    }
}

// Namespace: PRISM.Interactions
public class DynamicFilterToggleGroupView : PRISM.Interactions.FilterToggleGroupView
{
    private ENTERPRISE.UI.UITextMeshProUGUI titleText;
    private UnityEngine.Transform toggleContainer;
    private PRISM.Interactions.FilterToggleButtonView toggleBase;
    public void Initialize(string title, bool hasSwitchAllToggle, System.Collections.Generic.IEnumerable<System.ValueTuple<int, string>> items);
    private PRISM.Interactions.FilterToggleButtonView <Initialize>b__3_0(System.ValueTuple<int, string> x);
}

// Namespace: PRISM.Interactions
public class DefaultFilterToggleGroupViewFactory : PRISM.Interactions.DynamicFilterToggleGroupViewFactory
{
    private Item[] items;
    protected System.Collections.Generic.IEnumerable<System.ValueTuple<int, string>> _enumerateItems();

    private struct Item : System.ValueType
    {
        private int id;
        private string text;
        public System.ValueTuple<int, string> ToTuple();
    }

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<Item, System.ValueTuple<int, string>> <>9__2_0;
        private System.ValueTuple<int, string> <_enumerateItems>b__2_0(Item x);
    }
}

// Namespace: PRISM.Interactions
public class DynamicFilterToggleGroupViewFactory : PRISM.Interactions.FilterToggleGroupViewFactory
{
    private PRISM.Interactions.DynamicFilterToggleGroupView prefab;
    private string title;
    private bool hasSwitchAllToggle;
    protected System.Collections.Generic.IEnumerable<System.ValueTuple<int, string>> _enumerateItems();
    public PRISM.Interactions.FilterToggleGroupView Create(UnityEngine.Transform parent);
}

// Namespace: PRISM.Interactions
public class FilterToggleGroupViewFactory : UnityEngine.ScriptableObject
{
    public PRISM.Interactions.FilterToggleGroupView Create(UnityEngine.Transform parent);
}

// Namespace: PRISM.Interactions
public class MstExchangeProductFilterToggleGroupViewFactory : PRISM.Interactions.DynamicFilterToggleGroupViewFactory
{
    protected System.Collections.Generic.IEnumerable<System.ValueTuple<int, string>> _enumerateItems();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Definitions.MstExchangeProductFilter, System.ValueTuple<int, string>> <>9__0_0;
        private System.ValueTuple<int, string> <_enumerateItems>b__0_0(PRISM.Definitions.MstExchangeProductFilter x);
    }
}

// Namespace: PRISM.Interactions
public class UniqueToggleGroupViewFactory : PRISM.Interactions.FilterToggleGroupViewFactory
{
    private PRISM.Interactions.FilterToggleGroupView prefab;
    public PRISM.Interactions.FilterToggleGroupView Create(UnityEngine.Transform parent);
}

// Namespace: PRISM.Interactions
public class FilterToggleButtonView : UnityEngine.MonoBehaviour
{
    private int id;
    private PRISM.Interactions.ButtonView button;
    private PRISM.Interactions.ViewStateChanger isOnStateChanger;
    public int Id { get; set; }
    public void Initialize(PRISM.Definitions.IReactiveHashSet<int> onIds, System.Threading.CancellationToken cancellationToken);

    private class <>c__DisplayClass6_0
    {
        public PRISM.Definitions.IReactiveHashSet<int> onIds;
        public PRISM.Interactions.FilterToggleButtonView <>4__this;
        private void <Initialize>b__0(UniRx.Unit _);
        private void <Initialize>b__1(int addId);
        private void <Initialize>b__2(int removeId);
    }
}

// Namespace: PRISM.Interactions
public class FilterToggleGroupView : UnityEngine.MonoBehaviour
{
    protected PRISM.Interactions.FilterToggleButtonView[] toggles;
    protected PRISM.Interactions.SwitchAllToggleView switchAllToggle;
    public void Initialize(PRISM.Definitions.IReactiveHashSet<int> onIds, PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Adapters.IFilterToggleGroupViewOption option, System.Threading.CancellationToken cancellationToken);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Interactions.FilterToggleButtonView, int> <>9__2_0;
        private int <Initialize>b__2_0(PRISM.Interactions.FilterToggleButtonView x);
    }
}

// Namespace: PRISM.Interactions
public class FilterOnlyView : UnityEngine.MonoBehaviour, PRISM.Adapters.ISortFilterView
{
    private PRISM.Interactions.ViewStateChanger isFilteredStateChanger;
    private PRISM.Interactions.ButtonView openSortFilterSettingPopupButton;
    public System.IObservable<UniRx.Unit> OnOpenSortFilterSettingPopup { get; set; }
    public System.IObservable<UniRx.Unit> OnToggleSortDirection { get; set; }
    public System.IDisposable Initialize(UniRx.IReadOnlyReactiveProperty<PRISM.Definitions.SortFilterSettings> currentSettings);
    private void <Initialize>b__6_0(PRISM.Definitions.SortFilterSettings settings);
}

// Namespace: PRISM.Interactions
public class GridView`3<TCell, TData, TContext> : FancyScrollView.FancyGridView<TData, TContext>
{
    protected TCell cellPrefab;
    private UnityEngine.GameObject emptyView;
    public void SetResourceLoader(PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void UpdateContents(System.Collections.Generic.IReadOnlyList<TData> items);
    public void UpdateContents(System.Collections.Generic.IList<TData> items);
    public void ScrollTo(int index, float duration, EasingCore.Ease easing, PRISM.ListViewAlignment alignment, System.Action onComplete);
    public void JumpTo(int index, PRISM.ListViewAlignment alignment);
    protected void OnDestroy();
}

// Namespace: PRISM.Interactions
public class GridView`2<TCell, TData> : PRISM.Interactions.GridView<TCell, TData, PRISM.Interactions.GridViewContext>
{
}

// Namespace: PRISM.Interactions
public class GridViewCell`2<TData, TContext> : FancyScrollView.FancyGridViewCell<TData, TContext>
{
}

// Namespace: PRISM.Interactions
public class GridViewCell`1<T> : PRISM.Interactions.GridViewCell<T, PRISM.Interactions.GridViewContext>
{
}

// Namespace: PRISM.Interactions
public class GuestEditCharacterIcon : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ProduceIdolIconView pfIdolIconView;
    private PRISM.Interactions.ButtonView iconButton;
    private UnityEngine.GameObject emptyObject;
    private Attribute attribute;
    private ENTERPRISE.UI.UITextMeshProUGUI liveCenterEffectText;
    private UniRx.Subject<int> onFIdolClick;
    private UniRx.Subject<int> onFIdolDetail;
    private int mstProduceIdolId;
    public System.IObservable<int> OnFIdolClick { get; set; }
    public System.IObservable<int> OnFIdolDetail { get; set; }
    public Attribute Attribute { get; set; }
    public void Initialize();
    public Cysharp.Threading.Tasks.UniTask SetUpAsync(PRISM.Adapters.GuestEditCharacterIconModel status, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void Dispose();
    private void <Initialize>b__14_0(UniRx.Unit _);
    private void <Initialize>b__14_1(UniRx.Unit _);

    private struct <SetUpAsync>d__15 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.GuestEditCharacterIcon <>4__this;
        public PRISM.Adapters.GuestEditCharacterIconModel status;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class HorizontalAutoScrollingText : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI text;
    private float scrollSpeed;
    private float interval;
    private int spaceCount;
    private float containerWidth;
    private string originalText;
    private DG.Tweening.Sequence sequence;
    public void SetText(string value);
    private void _stop();
    private void Awake();
    private void OnRectTransformDimensionsChange();
}

// Namespace: PRISM.Interactions
public class ProduceIdolIconViewWithStar : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ProduceIdolIconView iconView;
    private PRISM.Interactions.StarsStateView starsView;
    private PRISM.Interactions.ButtonView button;
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, int mstProduceIdolId, int currentStarLevel, System.Threading.CancellationToken ct);

    private class <>c__DisplayClass3_0
    {
        public int mstProduceIdolId;
        public System.Threading.CancellationToken ct;
        private void <SetupAsync>b__0(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions
public class RewardItemIcon : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.OutGame.RewardItem rewardItemIcon;
    private PRISM.Interactions.ProduceIdolIconView produceIdolIconView;
    private PRISM.Interactions.ButtonView produceIdolIconButton;
    private PRISM.Interactions.SupportCharacterIconView supportCharacterIconView;
    private PRISM.Interactions.ButtonView supportCharacterIconButton;
    private System.IDisposable disposable;
    public void Show(PRISM.Module.Networking.IProductWithAmountStatus productWithAmount, PRISM.ResourceManagement.IResourceLoader resourceLoader, bool isShowDetail, bool isShowAmount, System.Threading.CancellationToken token);
    public void Show(PRISM.Module.Networking.IHavingProductStatus product, PRISM.ResourceManagement.IResourceLoader resourceLoader, bool isShowDetail, bool isShowAmount, System.Threading.CancellationToken token);
    public void Show(PRISM.Domain.ProductKeyWithAmount productKeyWithAmount, PRISM.ResourceManagement.IResourceLoader resourceLoader, bool isShowDetail, bool isShowAmount, System.Threading.CancellationToken token);
    public void Show(PRISM.Domain.ProductKey product, int amount, PRISM.ResourceManagement.IResourceLoader resourceLoader, bool isShowDetail, bool isShowAmount, System.Threading.CancellationToken token);
    private void OnDestroy();

    private class <>c__DisplayClass9_0
    {
        public PRISM.Domain.ProductKey product;
        public System.Threading.CancellationToken ct;
        private void <Show>b__0(UniRx.Unit _);
        private void <Show>b__1(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions
public class IdolBaseRewardGaugeView : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.RectMaskGauge gauge;
    private TMPro.TextMeshProUGUI levelText;
    private UnityEngine.Color levelDefaultColor;
    private UnityEngine.Color levelUpColor;
    private UnityEngine.Color levelMaxColor;
    private UnityEngine.GameObject levelUpArrow;
    private UnityEngine.GameObject maxIcon;
    private UnityEngine.GameObject limitIcon;
    private TMPro.TextMeshProUGUI diffExpText;
    private PRISM.Adapters.IdolBaseRewardGaugeViewModel viewModel;
    private int currentLevel;
    public void Initialize(PRISM.Adapters.IdolBaseRewardGaugeViewModel viewModel);
    public Cysharp.Threading.Tasks.UniTask AnimateAsync(float baseDuration, System.Threading.CancellationToken cancellationToken);
    private void _renderLevel(int level, bool isLevelUp);

    private class <>c__DisplayClass12_0
    {
        public PRISM.Interactions.IdolBaseRewardGaugeView <>4__this;
        public float duration;
        private void <AnimateAsync>b__0(float t);
    }
}

// Namespace: PRISM.Interactions
public class IdolBaseRewardIdolView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.CharacterBaseIconView icon;
    private PRISM.Interactions.ViewStateChanger positionMarkStateChanger;
    private PRISM.Interactions.IdolBaseRewardGaugeView levelGauge;
    private PRISM.Interactions.IdolBaseRewardGaugeView dearnessGauge;
    private TMPro.TextMeshProUGUI fanText;
    private TMPro.TextMeshProUGUI diffFanText;
    public Cysharp.Threading.Tasks.UniTask PrepareAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, int characterId, PRISM.Live.LiveIdolPositionMark positionMark, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask AnimateAsync(PRISM.Adapters.IdolBaseRewardIdolViewModel viewModel, float duration, System.Threading.CancellationToken cancellationToken);

    private class <>c__DisplayClass7_0
    {
        public PRISM.Adapters.IdolBaseRewardIdolViewModel viewModel;
        public float duration;
        public System.Threading.CancellationToken cancellationToken;
        public System.Collections.Generic.List<Cysharp.Threading.Tasks.UniTask> tasks;
        public PRISM.Interactions.IdolBaseRewardIdolView <>4__this;
        private void <AnimateAsync>b__0(float t);
        private Cysharp.Threading.Tasks.UniTask <AnimateAsync>g__DelayAnimationFrame|1(int frameCount);
        private void <AnimateAsync>g__AddTask|2(Cysharp.Threading.Tasks.UniTask task, System.Nullable<PRISM.Definitions.SoundKey> loopKey);
        private void <AnimateAsync>g__RenderFan|3(long fan);
    }

    private struct <AnimateAsync>d__7 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Adapters.IdolBaseRewardIdolViewModel viewModel;
        public float duration;
        public System.Threading.CancellationToken cancellationToken;
        public PRISM.Interactions.IdolBaseRewardIdolView <>4__this;
        private <>c__DisplayClass7_0 <>8__1;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class IdolSkillDetailListElementView : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI txtLv;
    private UnityEngine.UI.RawImage imgPP;
    private ENTERPRISE.UI.UITextMeshProUGUI txtPP;
    private PRISM.VoDaViMeMultiView voDaViMeMultiView;
    private ENTERPRISE.UI.UITextMeshProUGUI txtDetail;
    private PRISM.Interactions.TMPKeyWordTouchDetector tmpKeyWordTouchDetector;
    public System.IObservable<System.Collections.Generic.List<string>> KeyWordTouchId;
    public void Setup(PRISM.ResourceManagement.IResourceLoader resourceLoader, int lv, int pp, System.Collections.Generic.IReadOnlyList<ProduceParameterType> typeList, System.Collections.Generic.IEnumerable<System.ValueTuple<int, System.Collections.Generic.IReadOnlyList<int>>> effectList, System.ValueTuple<int, int> condition, bool updated);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<System.ValueTuple<int, TMPro.TMP_TextInfo>, System.Collections.Generic.List<string>> <>9__7_0;
        private System.Collections.Generic.List<string> <Setup>b__7_0(System.ValueTuple<int, TMPro.TMP_TextInfo> x);
    }
}

// Namespace: PRISM.Interactions
public class JewelAmountPanelView : UnityEngine.MonoBehaviour, PRISM.Adapters.IJewelAmountPanelView
{
    private ENTERPRISE.UI.UITextMeshProUGUI totalJewelText;
    private ENTERPRISE.UI.UITextMeshProUGUI paidJewelText;
    private ENTERPRISE.UI.UITextMeshProUGUI freeJewelText;
    private PRISM.Interactions.ButtonView purchaseJewelButton;
    public System.IObservable<UniRx.Unit> OnClickJewelPurchaseButton { get; set; }
    public System.IDisposable Initialize(UniRx.IReadOnlyReactiveProperty<PRISM.Domain.Jewel> jewelModel);
    public void ShowPurchaseButton(bool show);
    private void <Initialize>b__6_0(PRISM.Domain.Jewel value);
}

// Namespace: PRISM.Interactions
public class JewelLimitedSalePanelView : UnityEngine.MonoBehaviour, PRISM.Adapters.IJewelLimitedSalePanelView
{
    private PRISM.Interactions.ViewStateChanger jewelPurchaseButtonImageChanger;
    private PRISM.Interactions.LimitedSaleBalloonContainerView limitedSaleBalloonContainerView;
    private PRISM.Interactions.SilentLimitedSaleBalloonContainerView silentLimitedSaleBalloonContainerView;
    private System.IDisposable periodDisposable;
    public System.IDisposable Initialize(UniRx.IReadOnlyReactiveProperty<PRISM.Adapters.LimitedSaleBalloonViewModel> limitedSaleBalloonViewModel, bool forceHideLimitedSaleBalloon);
    private void OnDestroy();

    private class <>c__DisplayClass4_0
    {
        public PRISM.Interactions.JewelLimitedSalePanelView <>4__this;
        public bool forceHideLimitedSaleBalloon;
        private void <Initialize>b__0(PRISM.Adapters.LimitedSaleBalloonViewModel value);
    }

    private class <>c__DisplayClass4_1
    {
        public PRISM.Adapters.LimitedSaleBalloonViewModel value;
        public PRISM.Interactions.ILimitedSaleBalloonView targetBalloonView;
        public <>c__DisplayClass4_0 CS$<>8__locals1;
        private void <Initialize>b__1(long _);
    }
}

// Namespace: PRISM.Interactions
public class DefaultLimitedSaleBalloonView : UnityEngine.MonoBehaviour, PRISM.Interactions.ILimitedSaleBalloonView
{
    private UnityEngine.GameObject panelObject;
    private UnityEngine.Animator animator;
    private System.Nullable<int> currentAnimatorHashId;
    public void Initialize(PRISM.Adapters.LimitedSaleBalloonViewModel viewModel);
    public void UpdateView(PRISM.Adapters.LimitedSaleBalloonViewModel viewModel);
    public void _playAnimation(bool isAnimation);
}

// Namespace: PRISM.Interactions
public interface ILimitedSaleBalloonView
{
    public void Initialize(PRISM.Adapters.LimitedSaleBalloonViewModel viewModel);
    public void UpdateView(PRISM.Adapters.LimitedSaleBalloonViewModel viewModel);
}

// Namespace: PRISM.Interactions
public class SilentLimitedSaleBalloonView : PRISM.Interactions.ILimitedSaleBalloonView
{
    public void Initialize(PRISM.Adapters.LimitedSaleBalloonViewModel viewModel);
    public void UpdateView(PRISM.Adapters.LimitedSaleBalloonViewModel viewModel);
}

// Namespace: PRISM.Interactions
public interface ILimitedSaleBalloonContainerView
{
    public PRISM.Interactions.ILimitedSaleBalloonView Initialize(PRISM.Adapters.LimitedSaleBalloonViewModel viewModel, bool forceHideBalloon);
}

// Namespace: PRISM.Interactions
public class SilentLimitedSaleBalloonContainerView : PRISM.Interactions.ILimitedSaleBalloonContainerView
{
    public PRISM.Interactions.ILimitedSaleBalloonView Initialize(PRISM.Adapters.LimitedSaleBalloonViewModel viewModel, bool forceHideBalloon);
}

// Namespace: PRISM.Interactions
public class LimitedSaleBalloonContainerView : UnityEngine.MonoBehaviour, PRISM.Interactions.ILimitedSaleBalloonContainerView
{
    private PRISM.Interactions.ViewStateChanger balloonChanger;
    private PRISM.Interactions.DefaultLimitedSaleBalloonView defaultLimitedSaleBalloonView;
    private PRISM.Interactions.PerUserLimitedSaleBalloonView perUserLimitedSaleBalloonView;
    public PRISM.Interactions.ILimitedSaleBalloonView Initialize(PRISM.Adapters.LimitedSaleBalloonViewModel viewModel, bool forceHideBalloon);

    private enum BalloonType : System.Enum
    {
        public int value__;
        public static BalloonType Silent;
        public static BalloonType Default;
        public static BalloonType PerUser;
    }
}

// Namespace: PRISM.Interactions
public class PerUserLimitedSaleBalloonView : UnityEngine.MonoBehaviour, PRISM.Interactions.ILimitedSaleBalloonView
{
    private UnityEngine.GameObject panelObject;
    private ENTERPRISE.UI.UITextMeshProUGUI limitedTimeText;
    private UnityEngine.Animator animator;
    private System.Nullable<int> currentAnimatorHashId;
    public void Initialize(PRISM.Adapters.LimitedSaleBalloonViewModel viewModel);
    public void UpdateView(PRISM.Adapters.LimitedSaleBalloonViewModel viewModel);
    public void _playAnimation(bool isAnimation);
}

// Namespace: PRISM.Interactions
public class JewelPurchasePanelView : UnityEngine.MonoBehaviour
{
    private UnityEngine.GameObject needPaidJewelPanel;
    private UnityEngine.GameObject needFreeJewelPanel;
    private ENTERPRISE.UI.UITextMeshProUGUI needPaidJewelAmountText;
    private ENTERPRISE.UI.UITextMeshProUGUI needFreeJewelAmountText;
    private PRISM.Common.ValueFluctionTextPair paidJewelFluctuationTextPair;
    private PRISM.Common.ValueFluctionTextPair freeJewelFluctuationTextPair;
    public void UpdateView(InGameCurrencyType priceType, PRISM.Domain.Jewel currentJewel, PRISM.Domain.Jewel jewelAfterPurchase, PRISM.Domain.Jewel needJewel);
    public void UpdateViewWithoutNeedJewelPanel(PRISM.Domain.Jewel currentJewel, PRISM.Domain.Jewel jewelAfterPurchase, bool showFreeJewelFluctuation);
    private void _updateJewelFluctuationPanel(PRISM.Domain.Jewel currentJewel, PRISM.Domain.Jewel jewelAfterPurchase, bool showFreeJewelFluctuation);
}

// Namespace: PRISM.Interactions
public class ListView`3<TCell, TData, TContext> : FancyScrollView.FancyScrollRect<TData, TContext>
{
    protected float cellSize;
    protected UnityEngine.GameObject cellPrefab;
    protected UnityEngine.GameObject emptyView;
    protected float CellSize { get; set; }
    protected UnityEngine.GameObject CellPrefab { get; set; }
    public void SetResourceLoader(PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void UpdateContents(System.Collections.Generic.IReadOnlyList<TData> items);
    public void ScrollTo(int index, float duration, EasingCore.Ease easing, PRISM.ListViewAlignment alignment, System.Action onComplete);
    public void JumpTo(int index, PRISM.ListViewAlignment alignment);
    protected void OnDestroy();
}

// Namespace: PRISM.Interactions
public class ListView`2<TCell, TData> : PRISM.Interactions.ListView<TCell, TData, PRISM.Interactions.ListViewContext>
{
}

// Namespace: PRISM.Interactions
public class ListViewCell`2<TData, TContext> : FancyScrollView.FancyScrollRectCell<TData, TContext>
{
}

// Namespace: PRISM.Interactions
public class ListViewCell`1<T> : PRISM.Interactions.ListViewCell<T, PRISM.Interactions.ListViewContext>
{
}

// Namespace: PRISM.Interactions
public class ListViewContext : FancyScrollView.FancyScrollRectContext, System.IDisposable
{
    private PRISM.ResourceManagement.IResourceLoader <ResourceLoader>k__BackingField;
    public PRISM.ResourceManagement.IResourceLoader ResourceLoader { get; set; }
    public void Dispose();
}

// Namespace: PRISM.Interactions
public class ListViewContextWithClick`1<T> : PRISM.Interactions.ListViewContext
{
    public UniRx.Subject<T> OnClick;
    public void Dispose();
}

// Namespace: PRISM.Interactions
public class LiveMusicTypeAndAttributeView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.AttributeIconView attributeIcon;
    private UnityEngine.UI.RawImage musicTypeIcon;
    public Cysharp.Threading.Tasks.UniTask ShowAsync(PRISM.Definitions.MstSong song, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken cancellationToken);
}

// Namespace: PRISM.Interactions
public class MainFooterButtonGroupView : UnityEngine.MonoBehaviour, PRISM.Adapters.IMainFooterButtonGroupView
{
    private PRISM.Interactions.MainFooterButtonView characterButton;
    private PRISM.Interactions.MainFooterButtonView dressOrderButton;
    private PRISM.Interactions.MainFooterButtonView storyButton;
    private PRISM.Interactions.MainFooterButtonView shopButton;
    private PRISM.Interactions.MainFooterButtonView gashaButton;
    private PRISM.Interactions.MainFooterButtonView liveButton;
    private PRISM.HowToPlayPopupOpener dressOrderHowToPlay;
    public System.IObservable<UniRx.Unit> OnClickCharacterButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickDressOrderButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickStoryButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickShopButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickGashaButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickLiveButton { get; set; }
    public void Initialize(PRISM.Adapters.IHomeNotificationModelContainer notificationModelContainer, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public Cysharp.Threading.Tasks.UniTask ShowHowToPlayDressOrderPopupIfNeededAsync();
    private static void <Initialize>g___initializeFooterButton|19_0(PRISM.Interactions.MainFooterButtonView button, NotificationPlace place, <>c__DisplayClass19_0& );

    private struct <>c__DisplayClass19_0 : System.ValueType
    {
        public PRISM.Adapters.IHomeNotificationModelContainer notificationModelContainer;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
    }
}

// Namespace: PRISM.Interactions
public class MainFooterButtonView : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerUpHandler
{
    private PRISM.Interactions.BadgeView badgeView;
    private PRISM.Interactions.EventIconView eventIconView;
    private UnityEngine.Animator animator;
    private UniRx.Subject<UniRx.Unit> onClick;
    private bool isSelectAnimationPlaying;
    public System.IObservable<UniRx.Unit> OnClick { get; set; }
    public void Initialize(UniRx.IReadOnlyReactiveProperty<PRISM.Adapters.IBadgeModel> badgeModel, UniRx.IReadOnlyReactiveProperty<PRISM.Adapters.IEventIconModel> eventIconModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private void UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
    private void UnityEngine.EventSystems.IPointerUpHandler.OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
    private void OnDestroy();
    private bool <UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown>b__8_0();
    private Cysharp.Threading.Tasks.UniTask <UnityEngine.EventSystems.IPointerUpHandler.OnPointerUp>b__9_0();
    private bool <UnityEngine.EventSystems.IPointerUpHandler.OnPointerUp>b__9_1();

    private struct <<UnityEngine-EventSystems-IPointerUpHandler-OnPointerUp>b__9_0>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.MainFooterButtonView <>4__this;
        private System.IDisposable <_>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private class <>c__DisplayClass7_0
    {
        public PRISM.Interactions.MainFooterButtonView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private void <Initialize>b__0(PRISM.Adapters.IBadgeModel value);
        private void <Initialize>b__1(PRISM.Adapters.IEventIconModel value);
    }
}

// Namespace: PRISM.Interactions
public class OnDragDetector : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IEndDragHandler
{
    private UniRx.ReactiveProperty<bool> isDragging;
    public UniRx.IReactiveProperty<bool> IsDragging { get; set; }
    private void UnityEngine.EventSystems.IBeginDragHandler.OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
    private void UnityEngine.EventSystems.IEndDragHandler.OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
    private void OnDestroy();
}

// Namespace: PRISM.Interactions
public class PotentialSupportSkillContentView : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.RawImage imgIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI txtSkillName;
    private ENTERPRISE.UI.UITextMeshProUGUI txtDetail;
    public void Setup(int mstPotentialSupportSkillId, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Interactions
public class RankingHeaderView : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.Image rankingBaseImage;
    private UnityEngine.Sprite[] rankingBaseSprites;
    private PRISM.Interactions.ViewStateChanger headerBaseObjects;
    private UnityEngine.GameObject[] rankingTextObjects;
    public void SetData(int rank, bool isShowCommonSprite);
}

// Namespace: PRISM.Interactions
public class RoundedRawImage : UnityEngine.UI.RawImage
{
    private float radius;
    private int division;
    protected void OnPopulateMesh(UnityEngine.UI.VertexHelper vh);
    private void <OnPopulateMesh>g__AddEdge|2_0(float x, float y, <>c__DisplayClass2_0& );
    private void <OnPopulateMesh>g__AddVert|2_1(float x, float y, <>c__DisplayClass2_0& );
    private void <OnPopulateMesh>g__AddQuad|2_2(int index0, int index1, int index2, int index3, <>c__DisplayClass2_0& );

    private struct <>c__DisplayClass2_0 : System.ValueType
    {
        public UnityEngine.UI.VertexHelper vh;
        public float degree;
        public float radiusX;
        public float radiusY;
        public PRISM.Interactions.RoundedRawImage <>4__this;
        public float degreeDelta;
        public UnityEngine.Rect rect;
        public UnityEngine.Color color32;
        public float scaleX;
        public float scaleY;
    }
}

// Namespace: PRISM.Interactions
public class ScreenTouchDetector : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView touchDetectorButton;
    public System.IObservable<UniRx.Unit> OnTouch { get; set; }
    private void Awake();
}

// Namespace: PRISM.Interactions
public class SelectableGridView`3<TCell, TData, TContext> : PRISM.Interactions.GridView<TCell, TData, TContext>
{
    public void Inject(PRISM.ResourceManagement.IResourceLoader resourceLoader, UniRx.IReactiveProperty<TData> selectedData);
}

// Namespace: PRISM.Interactions
public class SelectableGridView`2<TCell, TData> : PRISM.Interactions.SelectableGridView<TCell, TData, PRISM.Interactions.SelectableGridViewContext<TData>>
{
}

// Namespace: PRISM.Interactions
public class SelectableGridViewCell`2<TData, TContext> : PRISM.Interactions.GridViewCell<TData, TContext>
{
    protected PRISM.Interactions.ButtonView button;
    protected UnityEngine.GameObject selectedFrame;
    protected UniRx.CompositeDisposable disposables;
    public void UpdateContent(TData itemData);
    protected void OnDestroy();

    private class <>c__DisplayClass3_0<TData, TContext>
    {
        public PRISM.Interactions.SelectableGridViewCell<TData, TContext> <>4__this;
        public TData itemData;
        private void <UpdateContent>b__0(UniRx.Unit _);
        private void <UpdateContent>b__1(TData selectedData);
    }
}

// Namespace: PRISM.Interactions
public class SelectableGridViewCell`1<T> : PRISM.Interactions.SelectableGridViewCell<T, PRISM.Interactions.SelectableGridViewContext<T>>
{
}

// Namespace: PRISM.Interactions
public class SelectableGridViewContext`1<TData> : PRISM.Interactions.GridViewContext
{
    private UniRx.IReactiveProperty<TData> <SelectedData>k__BackingField;
    public UniRx.IReactiveProperty<TData> SelectedData { get; set; }
}

// Namespace: PRISM.Interactions
public class SimpleAchievementIcon : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UIButton button;
    private UnityEngine.UI.Image image;
    private UnityEngine.GameObject emptyObject;
    public Cysharp.Threading.Tasks.UniTask ShowAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, int mstAchievementId, System.Threading.CancellationToken cancellationToken);

    private class <>c__DisplayClass3_0
    {
        public int mstAchievementId;
        public PRISM.Interactions.SimpleAchievementIcon <>4__this;
        private void <ShowAsync>b__0();
    }
}

// Namespace: PRISM.Interactions
public class SimpleAchievementIconGroup : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.SimpleAchievementIcon[] icons;
    public Cysharp.Threading.Tasks.UniTask ShowAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Collections.Generic.IReadOnlyList<int> mstAchievementIds, System.Threading.CancellationToken ct);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<int, int, System.ValueTuple<int, int>> <>9__1_0;
        private System.ValueTuple<int, int> <ShowAsync>b__1_0(int x, int i);
    }

    private class <>c__DisplayClass1_0
    {
        public PRISM.Interactions.SimpleAchievementIconGroup <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        private Cysharp.Threading.Tasks.UniTask <ShowAsync>b__1(System.ValueTuple<int, int> x);
    }
}

// Namespace: PRISM.Interactions
public class SortFilterView : UnityEngine.MonoBehaviour, PRISM.Adapters.ISortFilterView
{
    private PRISM.Interactions.ViewStateChanger isFilteredStateChanger;
    private ENTERPRISE.UI.UITextMeshProUGUI sortTypeText;
    private PRISM.Interactions.ViewStateChanger sortDirectionStateChanger;
    private PRISM.Interactions.ButtonView openSortFilterSettingPopupButton;
    private PRISM.Interactions.ButtonView toggleSortDirectionButton;
    public System.IObservable<UniRx.Unit> OnOpenSortFilterSettingPopup { get; set; }
    public System.IObservable<UniRx.Unit> OnToggleSortDirection { get; set; }
    public System.IDisposable Initialize(UniRx.IReadOnlyReactiveProperty<PRISM.Definitions.SortFilterSettings> currentSettings);
    private void <Initialize>b__9_0(PRISM.Definitions.SortFilterSettings settings);
}

// Namespace: PRISM.Interactions
public class StaminaView : UnityEngine.MonoBehaviour, PRISM.Adapters.IStaminaView
{
    private ENTERPRISE.UI.UITextMeshProUGUI recoveryTimeText;
    private ENTERPRISE.UI.UITextMeshProUGUI staminaText;
    private UnityEngine.UI.Image staminaGauge;
    private PRISM.Interactions.ButtonView recoveryButton;
    private PRISM.Interactions.ViewStateChanger isTimeRecoveryMaxState;
    private PRISM.Interactions.ViewStateChanger isRecoveryMaxState;
    public System.IObservable<UniRx.Unit> OnClickRecovery { get; set; }
    public void UpdateView(int currentValue, int maxValue, bool isTimeRecoveryMax, bool isRecoveryMax, string recoveryText);
}

// Namespace: PRISM.Interactions
public class StarsStateView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ViewStateChanger viewStateChanger;
    public void SetStar(int trainingLv);
}

// Namespace: PRISM.Interactions
public class SCharaEditPotentialSupportSkillContentListView : UnityEngine.MonoBehaviour
{
    private UnityEngine.CanvasGroup canvasGroup;
    private PRISM.Interactions.SCharaEditPotentialSupportSkillContentView goContent;
    private UnityEngine.Transform contentParent;
    private System.Collections.Generic.List<PRISM.Interactions.SCharaEditPotentialSupportSkillContentView> contentList;
    public Cysharp.Threading.Tasks.UniTask SetupAsync(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.SCharaEditPotentialSupportSkillContentViewModel> viewModels, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public void Show(bool isShow);
    private void _deleteAllContent();
}

// Namespace: PRISM.Interactions
public class SCharaEditPotentialSupportSkillContentView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.PotentialSupportSkillContentView potentialSupportSkillContentView;
    private PRISM.Interactions.SCharaEditSDCharaIconListView sCharaEditSDCharaIconListView;
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Adapters.SCharaEditPotentialSupportSkillContentViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
}

// Namespace: PRISM.Interactions
public class SCharaEditSDCharaIconListView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.SCharaEditSDCharaIconView iconViewPrefab;
    private UnityEngine.Transform contentArea;
    private System.Collections.Generic.List<PRISM.Interactions.SCharaEditSDCharaIconView> iconViews;
    public Cysharp.Threading.Tasks.UniTask SetupAsync(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.SCharaEditSDCharaIconViewModel> viewModels, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
}

// Namespace: PRISM.Interactions
public class SCharaEditSDCharaIconView : UnityEngine.MonoBehaviour
{
    private UnityEngine.RectTransform rootRect;
    private SDCharaIconInfo selfCharaIcon;
    private SDCharaIconInfo friendCharaIcon;
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Adapters.SCharaEditSDCharaIconViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask _watchRedrawIconAsync(System.Threading.CancellationToken token);

    private class SDCharaIconInfo
    {
        private UnityEngine.RectTransform iconRect;
        private UnityEngine.UI.Image charaIcon;
        private UnityEngine.GameObject friendMark;
        public UnityEngine.RectTransform IconRect { get; set; }
        public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Adapters.SCharaEditSDCharaIconViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    }

    private class <>c__DisplayClass5_0
    {
        public int beforeW;
        public int beforeH;
        public bool beforeFS;
        private bool <_watchRedrawIconAsync>b__0();
    }

    private struct <_watchRedrawIconAsync>d__5 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        private <>c__DisplayClass5_0 <>8__1;
        public System.Threading.CancellationToken token;
        public PRISM.Interactions.SCharaEditSDCharaIconView <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class SCharaEditSupportEffectContentListView : UnityEngine.MonoBehaviour
{
    private UnityEngine.CanvasGroup canvasGroup;
    private PRISM.Interactions.SCharaEditSupportEffectContentView goContent;
    private UnityEngine.Transform contentParent;
    private System.Collections.Generic.List<PRISM.Interactions.SCharaEditSupportEffectContentView> contentList;
    public Cysharp.Threading.Tasks.UniTask SetupAsync(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.SCharaEditSupportEffectContentViewModel> viewModels, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public void Show(bool isShow);
    private void _deleteAllContent();
}

// Namespace: PRISM.Interactions
public class SCharaEditSupportEffectContentView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.SupportEffectContentView supportEffectContentView;
    private PRISM.Interactions.SCharaEditSDCharaIconListView sCharaEditSDCharaIconListView;
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Adapters.SCharaEditSupportEffectContentViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
}

// Namespace: PRISM.Interactions
public class SupportCharacterEditView : UnityEngine.MonoBehaviour
{
    private PRISM.UI.SCharaIconView[] selfSCharaIconViews;
    private ENTERPRISE.UI.UIButton[] selfSCharaIconBlankButtons;
    private PRISM.UI.SCharaIconView friendSCharaIconView;
    private ENTERPRISE.UI.UIButton friendSCharaIconBlankButton;
    private ENTERPRISE.UI.UITextMeshProUGUI skillSlotCountText;
    private ENTERPRISE.UI.UIButton recommendEditButton;
    private UnityEngine.UI.RawImage unitIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI unitNameText;
    private ENTERPRISE.UI.UITabGroup supportEffectAndPotentialSkillTabGroup;
    private PRISM.Interactions.SCharaEditSupportEffectContentListView supportEffectListView;
    private PRISM.Interactions.SCharaEditPotentialSupportSkillContentListView potentialSupportSkillListView;
    private UniRx.Subject<int> onClickSelfSCharaIcon;
    private UniRx.Subject<int> onLongPressSelfSCharaIcon;
    private UniRx.Subject<UniRx.Unit> onClickFriendSCharaIcon;
    private UniRx.Subject<UniRx.Unit> onLongPressFriendSCharaIcon;
    public System.IObservable<int> OnClickSelfSCharaIcon { get; set; }
    public System.IObservable<int> OnLongPressSelfSCharaIcon { get; set; }
    public System.IObservable<UniRx.Unit> OnClickFriendSCharaIcon { get; set; }
    public System.IObservable<UniRx.Unit> OnLongPressFriendSCharaIcon { get; set; }
    public System.IObservable<UniRx.Unit> OnClickRecommendEditButton { get; set; }
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Adapters.SupportCharacterEditViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask UpdateBothSupportCharactersAsync(System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.ISupportCharacterStatus> selfSupportCharacters, PRISM.Module.Networking.ISupportCharacterStatus friendSupportCharacter, System.Collections.Generic.IReadOnlyList<PRISM.Adapters.SCharaEditSupportEffectContentViewModel> supportEffectViewModels, System.Collections.Generic.IReadOnlyList<PRISM.Adapters.SCharaEditPotentialSupportSkillContentViewModel> potentialSupportSkillViewModels, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask _updateSelfSupportCharactersAsync(System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.ISupportCharacterStatus> selfSupportCharacters, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask _updateFriendSupportCharacterAsync(PRISM.Module.Networking.ISupportCharacterStatus friendSupportCharacter, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    private void OnDestroy();
    private void <SetupAsync>b__25_4(System.ValueTuple<int, UnityEngine.GameObject> tuple);
    private void <SetupAsync>b__25_5(System.ValueTuple<int, UnityEngine.GameObject> tuple);
    private void <SetupAsync>b__25_0(System.ValueTuple<int, UnityEngine.GameObject> _);
    private void <SetupAsync>b__25_1(System.ValueTuple<int, UnityEngine.GameObject> _);
    private void <SetupAsync>b__25_2();
    private void <SetupAsync>b__25_3(int index, ENTERPRISE.UI.UITabGroup _);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Module.Networking.ISupportCharacterStatus, int> <>9__26_0;
        private int <UpdateBothSupportCharactersAsync>b__26_0(PRISM.Module.Networking.ISupportCharacterStatus e);
    }

    private class <>c__DisplayClass25_0
    {
        public int index;
        public PRISM.Interactions.SupportCharacterEditView <>4__this;
        private void <SetupAsync>b__6();
    }

    private class <>c__DisplayClass27_0
    {
        public System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.ISupportCharacterStatus> selfSupportCharacters;
        public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstSupportCharacter> mstSupportCharacters;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
    }

    private class <>c__DisplayClass27_1
    {
        public int index;
        public PRISM.UI.SCharaIconView iconView;
        public <>c__DisplayClass27_0 CS$<>8__locals1;
        private Cysharp.Threading.Tasks.UniTask <_updateSelfSupportCharactersAsync>b__0();
    }
}

// Namespace: PRISM.Interactions
public class SupportEffectContentView : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI txtSkillName;
    private ENTERPRISE.UI.UITextMeshProUGUI txtDetail;
    private ENTERPRISE.UI.UITextMeshProUGUI txtReleaseLv;
    private PRISM.Interactions.ViewStateChanger bgStateChanger;
    private PRISM.Interactions.ViewStateChanger lockStateChanger;
    public void Setup(PRISM.Adapters.SupportEffectContentViewModel model);
    public void SetBgColor(bool on);
    private void _setLock(bool isLocked);
    private void <Setup>b__5_0(bool b);
    private void <Setup>b__5_2(bool _);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<bool, bool> <>9__5_1;
        private bool <Setup>b__5_1(bool b);
    }
}

// Namespace: PRISM.Interactions
public class SwipeAndArrowChangerView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView leftArrowButton;
    private PRISM.Interactions.ButtonView rightArrowButton;
    private UniRx.Triggers.ObservableDragTrigger dragTrigger;
    private float dragThreshold;
    private bool canChangeLeft;
    private bool canChangeRight;
    public System.IObservable<int> OnChange { get; set; }
    private void Start();
    public void SetCanChange(bool left, bool right);
    public void SetSe(PRISM.Definitions.SoundKey se);
    private bool <get_OnChange>b__8_1(System.ValueTuple<UnityEngine.EventSystems.PointerEventData, float> x);
    private bool <get_OnChange>b__8_2(System.ValueTuple<UnityEngine.EventSystems.PointerEventData, float> x);
    private int <get_OnChange>b__8_3(System.ValueTuple<UnityEngine.EventSystems.PointerEventData, float> x);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<UnityEngine.EventSystems.PointerEventData, System.ValueTuple<UnityEngine.EventSystems.PointerEventData, float>> <>9__8_0;
        public static System.Func<UniRx.Unit, int> <>9__8_4;
        public static System.Func<UniRx.Unit, int> <>9__8_5;
        private System.ValueTuple<UnityEngine.EventSystems.PointerEventData, float> <get_OnChange>b__8_0(UnityEngine.EventSystems.PointerEventData e);
        private int <get_OnChange>b__8_4(UniRx.Unit _);
        private int <get_OnChange>b__8_5(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions
public class SwitchAllToggleView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView button;
    private PRISM.Interactions.ViewStateChanger checkStateChanger;
    public void Initialize(PRISM.Definitions.IReactiveHashSet<int> onIds, System.Collections.Generic.IReadOnlyList<int> ids, System.Threading.CancellationToken cancellationToken);
    public void SetInteractable(bool value);

    private class <>c__DisplayClass2_0
    {
        public System.Collections.Generic.IReadOnlyList<int> ids;
        public PRISM.Definitions.IReactiveHashSet<int> onIds;
        public PRISM.Interactions.SwitchAllToggleView <>4__this;
        public System.Func<int, bool> <>9__3;
        private void <Initialize>b__0(UniRx.Unit _);
        private bool <Initialize>b__3(int id);
        private void <Initialize>b__1(System.Collections.Generic.IList<int> _);
        private void <Initialize>g__ApplyCheckState|2();
    }
}

// Namespace: PRISM.Interactions
public class SynchronizedAnimator : UnityEngine.MonoBehaviour
{
    private UnityEngine.Animator animator;
    private int layer;
    private float length;
    private void Awake();
    private void Update();
}

// Namespace: PRISM.Interactions
public class UIShifter : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IDragHandler
{
    private UnityEngine.RectTransform currentCell;
    private UnityEngine.RectTransform subCell;
    private PRISM.CarouselIndicator indicator;
    private float shiftSeconds;
    private float autoShiftSeconds;
    private UnityEngine.Vector2 moveSize;
    private int count;
    private int currentIndex;
    private float prevShiftTime;
    private UniRx.Subject<System.ValueTuple<UnityEngine.RectTransform, int>> onUpdateCell;
    public System.IObservable<System.ValueTuple<UnityEngine.RectTransform, int>> OnUpdateCell { get; set; }
    public void SetCount(int count, bool isInteractable);
    private void UnityEngine.EventSystems.IBeginDragHandler.OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
    private void UnityEngine.EventSystems.IDragHandler.OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
    private void Update();
    private void _shift(int direction);
}

// Namespace: PRISM.Interactions
public class ViewStateChanger : UnityEngine.MonoBehaviour
{
    public void ChangeState(int state);
    public void ChangeState(bool state);
}

// Namespace: PRISM.Interactions
public class ViewStateChangerAnchoredPosition : PRISM.Interactions.ViewStateChanger
{
    private UnityEngine.RectTransform target;
    private UnityEngine.Vector2[] anchoredPositions;
    public void ChangeState(int state);
}

// Namespace: PRISM.Interactions
public class ViewStateChangerCanvasGroup : PRISM.Interactions.ViewStateChanger
{
    private float fadeSeconds;
    private UnityEngine.CanvasGroup[] targets;
    private PRISM.AutoCancellationTokenSource cts;
    public void ChangeState(int state);

    private class <>c__DisplayClass3_0
    {
        public PRISM.Interactions.ViewStateChangerCanvasGroup <>4__this;
        public System.Threading.CancellationToken ct;
    }

    private class <>c__DisplayClass3_1
    {
        public UnityEngine.CanvasGroup target;
        public float currentAlpha;
        public int newAlpha;
        public <>c__DisplayClass3_0 CS$<>8__locals1;
        private Cysharp.Threading.Tasks.UniTask <ChangeState>b__0();

        private struct <<ChangeState>b__0>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
        {
            public int <>1__state;
            public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
            public <>c__DisplayClass3_1 <>4__this;
            private float <time>5__2;
            private Awaiter <>u__1;
            private void MoveNext();
            private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }
}

// Namespace: PRISM.Interactions
public class ViewStateChangerGameObject : PRISM.Interactions.ViewStateChanger
{
    private UnityEngine.GameObject[] targets;
    public void ChangeState(int state);
}

// Namespace: PRISM.Interactions
public class ViewStateChangerGrayOut : PRISM.Interactions.ViewStateChanger
{
    private PRISM.UIGrayOutController uiGrayOutController;
    private bool isGrayOutIfTrue;
    public void ChangeState(int state);
}

// Namespace: PRISM.Interactions
public class ViewStateChangerImage : PRISM.Interactions.ViewStateChanger
{
    private UnityEngine.UI.Image image;
    private UnityEngine.Sprite[] sprites;
    private UnityEngine.Color[] colors;
    public void ChangeState(int state);
}

// Namespace: PRISM.Interactions
public class ViewStateChangerMultiple : PRISM.Interactions.ViewStateChanger
{
    private PRISM.Interactions.ViewStateChanger[] stateChangers;
    public void ChangeState(int state);
}

// Namespace: PRISM.Interactions
public class ViewStateChangerNumberText : PRISM.Interactions.ViewStateChanger
{
    private UnityEngine.GameObject target;
    private ENTERPRISE.UI.UITextMeshProUGUI text;
    private int limit;
    public void ChangeState(int state);
}

// Namespace: PRISM.Interactions
public class ViewStateChangerRectTransformOffset : PRISM.Interactions.ViewStateChanger
{
    private UnityEngine.RectTransform target;
    private Offset[] offsetArray;
    public void ChangeState(int state);

    public struct Offset : System.ValueType
    {
        public float Left;
        public float Top;
        public float Right;
        public float Bottom;
    }
}

// Namespace: PRISM.Interactions
public class ViewStateChangerSizeDelta : PRISM.Interactions.ViewStateChanger
{
    private UnityEngine.RectTransform target;
    private UnityEngine.Vector2[] sizeArray;
    public void ChangeState(int state);
}

// Namespace: PRISM.Interactions
public class ViewStateChangerText : PRISM.Interactions.ViewStateChanger
{
    private ENTERPRISE.UI.UITextMeshProUGUI target;
    private UnityEngine.Color[] colors;
    private UnityEngine.Color[] outlineColors;
    public void ChangeState(int state);
}

// Namespace: PRISM.Interactions
public class VoDaViMeRankView : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI vo;
    private ENTERPRISE.UI.UITextMeshProUGUI da;
    private ENTERPRISE.UI.UITextMeshProUGUI vi;
    private ENTERPRISE.UI.UITextMeshProUGUI me;
    private UnityEngine.UI.RawImage[] rankArray;
    public void Set(PRISM.Module.Networking.IProduceParameterStatus param, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Interactions
public class VoDaViMeView : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI vo;
    private ENTERPRISE.UI.UITextMeshProUGUI da;
    private ENTERPRISE.UI.UITextMeshProUGUI vi;
    private ENTERPRISE.UI.UITextMeshProUGUI me;
    private ENTERPRISE.UI.UITextMeshProUGUI cost;
    public void Set(PRISM.Adapters.VoDaViMeViewModel voDaViMe);
    public void SetWithAdditionalParameter(PRISM.Adapters.VoDaViMeViewModel voDaViMe);
    public void SetOnlyAdditionalParameter(PRISM.Adapters.VoDaViMeViewModel voDaViMe);
    public void SetOnlyAdditionalParameter(PRISM.Module.Networking.IIdolParameterStatus voDaViMe);
    public void SetWithLineBreakAdditionalParameter(PRISM.Adapters.VoDaViMeViewModel voDaViMe);
    private string _getTextWithAdditional(int value, int additionalValue);
    private string _getTextWithLineBreakAdditional(int value, int additionalValue);
    private string _getTextOnlyAdditional(int additionalValue);
    private string _toCommaText(int value);
    private static string <SetOnlyAdditionalParameter>g__Format|8_0(int value);
}

// Namespace: PRISM.Interactions
public class IdolSkillTextUtility
{
    public static System.Collections.Generic.List<string> MakeKeyWordLinkList(int selectIndex, TMPro.TMP_TextInfo textInfo);
}

// Namespace: PRISM.Interactions
public class ViewConnector`1<TArgument> : ENTERPRISE.ViewBase
{
    protected string howToPlayPopupResourceConfigRef;
    private PRISM.Interactions.CommonTitleView titleView;
    private PRISM.Interactions.ButtonView globalMenuButton;
    private PRISM.Interactions.ButtonView backButton;
    private PRISM.ITutorialSequence tutorialSequence;
    private PRISM.UIAnimation inAnimation;
    private TNRD.SerializableInterface<PRISM.Adapters.IViewBuilder<TArgument>> builder;
    private UniRx.CompositeDisposable disposables;
    protected PRISM.IViewPresenter presenter;
    protected string GetHowToPlayPopupResourceConfigRef();
    protected TArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
    protected Cysharp.Threading.Tasks.UniTask _initializeAsync();
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
    protected Cysharp.Threading.Tasks.UniTask _beginViewAsync();
    protected Cysharp.Threading.Tasks.UniTask _terminateAsync();
    protected Cysharp.Threading.Tasks.UniTask _onBeginIdleAsync();
    private Cysharp.Threading.Tasks.UniTask _defaultOnBeginIdleAsync();
    public Cysharp.Threading.Tasks.UniTask OnBeforeNextViewLoadingAsync();
    private void <_initializeAsync>b__11_1(UniRx.Unit _);

    private class <>c<TArgument>
    {
        public static <>c<TArgument> <>9;
        public static System.Action<UniRx.Unit> <>9__11_0;
        private void <_initializeAsync>b__11_0(UniRx.Unit _);
    }

    private class <>c__DisplayClass11_0<TArgument>
    {
        public string configRef;
        private void <_initializeAsync>b__2(UniRx.Unit _);
    }

    private struct <_defaultOnBeginIdleAsync>d__16<TArgument> : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ViewConnector<TArgument> <>4__this;
        private Awaiter<bool> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_initializeAsync>d__11<TArgument> : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ViewConnector<TArgument> <>4__this;
        private Awaiter<PRISM.IViewPresenter> <>u__1;
        private Awaiter <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_terminateAsync>d__14<TArgument> : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ViewConnector<TArgument> <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class ViewConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.NullArgument>
{
    protected PRISM.Adapters.NullArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
}

// Namespace: PRISM.Interactions.Home
public class BannerWithEndDateView : UnityEngine.MonoBehaviour, PRISM.Adapters.Home.IBannerWithEndDateView
{
    private PRISM.Interactions.ButtonView button;
    private UnityEngine.UI.Image logoImage;
    private UnityEngine.GameObject periodObject;
    private TMPro.TextMeshProUGUI periodText;
    private PRISM.Interactions.ViewStateChanger periodImageChanger;
    private UniRx.Subject<UniRx.Unit> onClick;
    private System.IDisposable disposable;
    private PRISM.AutoCancellationTokenSource canceller;
    public System.IObservable<UniRx.Unit> OnClick { get; set; }
    public void Initialize(PRISM.Adapters.Home.BannerWithEndDateViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private static Cysharp.Threading.Tasks.UniTask _showConfirmEndPopupAsync(System.Threading.CancellationToken ct);
    private void OnDestroy();

    private class <>c__DisplayClass10_0
    {
        public PRISM.Adapters.Home.BannerWithEndDateViewModel viewModel;
        public PRISM.Interactions.Home.BannerWithEndDateView <>4__this;
        private Cysharp.Threading.Tasks.UniTaskVoid <Initialize>b__0(UniRx.Unit _);

        private struct <<Initialize>b__0>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
        {
            public int <>1__state;
            public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
            public <>c__DisplayClass10_0 <>4__this;
            private Awaiter <>u__1;
            private void MoveNext();
            private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }
}

// Namespace: PRISM.Interactions.Drama
public struct DramaBlinkCloseOpenTime : System.ValueType
{
    public static float DefaultCloseTime;
    public static float DefaultOpenTime;
    public static PRISM.Interactions.Drama.DramaBlinkCloseOpenTime Default;
    public float close;
    public float open;
    public float GetTotalTime();
}

// Namespace: PRISM.Interactions.Drama
public enum DramaEyeTargetType : System.Enum
{
    public int value__;
    public static PRISM.Interactions.Drama.DramaEyeTargetType Default;
    public static PRISM.Interactions.Drama.DramaEyeTargetType Facial;
}

// Namespace: PRISM.Interactions.Drama
public class DramaEyeController : UnityEngine.MonoBehaviour
{
    private UnityEngine.Transform closeL;
    private UnityEngine.Transform closeR;
    private UnityEngine.Transform smileL;
    private UnityEngine.Transform smileR;
    private UnityEngine.Transform eyeCloseL;
    private UnityEngine.Transform eyeCloseR;
    private UnityEngine.Transform eyeSmileL;
    private UnityEngine.Transform eyeSmileR;
    private PRISM.Interactions.Drama.DramaEyeTargetType eyeTargetType;
    private UnityEngine.Transform ikTarget;
    private PRISM.ParentConstraint facialConstraint;
    private UnityEngine.Transform facialAnimationIkTarget;
    private float blinkTimer;
    private PRISM.Interactions.Drama.DramaBlinkCloseOpenTime currentBlinkCloseOpenTime;
    private bool isBlinkOpen;
    private EyeController[] eyeControllers;
    private float blinkPower;
    public PRISM.Interactions.Drama.DramaEyeTargetType EyeTargetType { get; set; }
    public float BlinkPower { get; set; }
    public void Setup(PRISM.Character character);
    private void _setEyeTarget(UnityEngine.Transform target);
    private void Update();
    private void _updateBlink();
    private void _updateEyeTarget();
    private void _updateBlinkTimer();
    public void Blink(PRISM.Interactions.Drama.DramaBlinkCloseOpenTime closeOpenTime);
    private void _applyReceivedTransform(float value);
}

// Namespace: PRISM.Interactions.Drama
public class DramaSceneCameraAnimationData
{
    private bool enable;
    private UnityEngine.AnimationCurve easing;
    private float startTimingOffset;
    private float durationOffset;
    private bool enablePosition;
    private UnityEngine.Vector3 startPosition;
    private UnityEngine.Vector3 endPosition;
    private bool enableRotation;
    private UnityEngine.Vector3 startRotationEuler;
    private UnityEngine.Vector3 endRotationEuler;
    private bool enableFov;
    private float startFov;
    private float endFov;
    private bool enableLensShift;
    private UnityEngine.Vector2 startLensShift;
    private UnityEngine.Vector2 endLensShift;
    private bool enableDofFocalLength;
    public bool Enable { get; set; }
    public UnityEngine.AnimationCurve Easing { get; set; }
    public float StartTimingOffset { get; set; }
    public float DurationOffset { get; set; }
    public bool EnablePosition { get; set; }
    public UnityEngine.Vector3 StartPosition { get; set; }
    public UnityEngine.Vector3 EndPosition { get; set; }
    public bool EnableRotation { get; set; }
    public UnityEngine.Vector3 StartRotationEuler { get; set; }
    public UnityEngine.Vector3 EndRotationEuler { get; set; }
    public bool EnableFov { get; set; }
    public float StartFov { get; set; }
    public float EndFov { get; set; }
    public bool EnableLensShift { get; set; }
    public UnityEngine.Vector2 StartLensShift { get; set; }
    public UnityEngine.Vector2 EndLensShift { get; set; }
    public bool EnableDofFocalLength { get; set; }
    public void ApplyTo(float rate, Cinemachine.CinemachineVirtualCamera target);
    public void ApplyTo(double time, double start, double duration, Cinemachine.CinemachineVirtualCamera target);
}

// Namespace: PRISM.Interactions.Drama
public class DramaSceneCamera : UnityEngine.MonoBehaviour
{
    private Cinemachine.CinemachineVirtualCamera cinemachineCamera;
    private PRISM.Interactions.Drama.DramaSceneCameraAnimationData animation;
    private UnityEngine.Playables.PlayableDirector playBaseDirector;
    private UnityEngine.Playables.PlayableDirector clipParentDirector;
    private UnityEngine.Timeline.TimelineClip clip;
    public Cinemachine.CinemachineVirtualCamera CinemachineCamera { get; set; }
    public PRISM.Interactions.Drama.DramaSceneCameraAnimationData Animation { get; set; }
    public UnityEngine.Playables.PlayableDirector PlayBaseDirector { get; set; }
    public UnityEngine.Playables.PlayableDirector ClipParentDirector { get; set; }
    public UnityEngine.Timeline.TimelineClip Clip { get; set; }
    public void SetupForPlay();
    public void SetEnableAnimation(bool enable);
    public void Update();
    private void _updateAnimation();
    private void _updateReferenceTimeline();
    private bool _tryGetTimelineClip(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.TimelineClip& findClip, UnityEngine.Playables.PlayableDirector& clipParentDirector);
}

// Namespace: PRISM.Interactions.Drama
public class DramaSceneCharacter : UnityEngine.MonoBehaviour
{
    private static System.Collections.Generic.Dictionary<PRISM.Interactions.Drama.DramaSceneCharacterPositionType, string> positionTypeTransformPathPairs;
    private UnityEngine.Transform locator;
    private PRISM.Character character;
    private UnityEngine.RuntimeAnimatorController facialAnimationController;
    private PRISM.AnimatorLayerWeightReceiver receiver;
    private int charaId;
    private int hairId;
    private int clothId;
    private int[] accessoryIds;
    private PRISM.HumanoidIKTarget ikTarget;
    private System.Collections.Generic.Dictionary<PRISM.Interactions.Drama.DramaSceneCharacterPositionType, UnityEngine.Transform> cachedTransforms;
    private PRISM.Character playingCharacter;
    public UnityEngine.Transform Locator { get; set; }
    public PRISM.Character Character { get; set; }
    public UnityEngine.RuntimeAnimatorController FacialAnimationController { get; set; }
    public PRISM.AnimatorLayerWeightReceiver Receiver { get; set; }
    public PRISM.HumanoidIKTarget IkTarget { get; set; }
    public PRISM.Character PlayingCharacter { get; set; }
    public void Setup(PRISM.UnitIdol unitIdol, PRISM.Character character);
    private static void _setupAnimator(PRISM.Character target);
    public void Setup(int charaId, int hairId, int clothId, int[] accessoryIds);
    public PRISM.UnitIdol GetUnitIdol();
    public void SetupForPlay(PRISM.CameraController mainCamera);
    public void SwapBind(UnityEngine.Playables.PlayableDirector director);
    public static void SwapBind(UnityEngine.Playables.PlayableDirector director, UnityEngine.Transform src, UnityEngine.Transform dst);
    private void _setupDefaultActivation();
    private void _copyMagicaParameters();
    private static void _setupMagicaColliders(string editCharacterPath, System.Collections.Generic.IReadOnlyList<MagicaCloth2.ColliderComponent> edits, UnityEngine.Transform playingCharacterTransform, System.Collections.Generic.List<MagicaCloth2.ColliderComponent> playings);
    private static void _setupMagicaColliders(string editCharacterPath, MagicaCloth2.ColliderComponent edit, UnityEngine.Transform playingCharacterTransform, System.Collections.Generic.List<MagicaCloth2.ColliderComponent> playings);
    private static void _swapBindingObjectRecursively(UnityEngine.Playables.PlayableDirector director, UnityEngine.Transform sourceTransform, UnityEngine.Transform targetTransform);
    private static void _swapBindingObjectRecursively(UnityEngine.Playables.PlayableDirector director, System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> tracks, UnityEngine.Transform sourceTransform, UnityEngine.Transform targetTransform);
    private static void _swapBindingObject(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.TrackAsset track, UnityEngine.Transform sourceTransform, UnityEngine.Transform targetTransform);
    public UnityEngine.Transform GetTransform(PRISM.Interactions.Drama.DramaSceneCharacterPositionType positionType);
    public bool IsSameCombination(PRISM.UnitIdol unitIdol);
    public void ValidateMouthScale();
    public void CleanupPlayingCharacter(UnityEngine.Playables.PlayableDirector director);
    private static void <_setupDefaultActivation>g__CopyActiveRecursively|31_0(UnityEngine.Transform from, UnityEngine.Transform to);

    private class <>c__DisplayClass34_0
    {
        public string colliderPathFromRoot;
        public string playingCharacterPath;
        public string colliderPath;
        private bool <_setupMagicaColliders>b__0(MagicaCloth2.ColliderComponent collider);
        private bool <_setupMagicaColliders>b__1(MagicaCloth2.ColliderComponent collider);
    }
}

// Namespace: PRISM.Interactions.Drama
public enum DramaSceneCharacterPositionType : System.Enum
{
    public int value__;
    public static PRISM.Interactions.Drama.DramaSceneCharacterPositionType Origin;
    public static PRISM.Interactions.Drama.DramaSceneCharacterPositionType Head;
    public static PRISM.Interactions.Drama.DramaSceneCharacterPositionType EyeCenter;
    public static PRISM.Interactions.Drama.DramaSceneCharacterPositionType Nose;
    public static PRISM.Interactions.Drama.DramaSceneCharacterPositionType Mouth;
    public static PRISM.Interactions.Drama.DramaSceneCharacterPositionType Neck;
    public static PRISM.Interactions.Drama.DramaSceneCharacterPositionType LeftHand;
    public static PRISM.Interactions.Drama.DramaSceneCharacterPositionType RightHand;
    public static PRISM.Interactions.Drama.DramaSceneCharacterPositionType Bust;
    public static PRISM.Interactions.Drama.DramaSceneCharacterPositionType Hip;
    public static PRISM.Interactions.Drama.DramaSceneCharacterPositionType LeftFoot;
    public static PRISM.Interactions.Drama.DramaSceneCharacterPositionType RightFoot;
}

// Namespace: PRISM.Interactions.Drama
public class DramaSceneCharacterPositionTypeUtility
{
    public static System.Collections.Generic.Dictionary<string, PRISM.Interactions.Drama.DramaSceneCharacterPositionType> CharacterPositionTypeStringToEnumDic;
}

// Namespace: PRISM.Interactions.Drama
public class DramaSceneProps : UnityEngine.MonoBehaviour
{
    private PRISM.ParentConstraint parentConstraint;
    private UnityEngine.Transform prefabRoot;
    public PRISM.ParentConstraint ParentConstraint { get; set; }
    public UnityEngine.Transform PrefabRoot { get; set; }
    public void SetupForPlay();
}

// Namespace: PRISM.Interactions.Drama
public struct FingerTransformRotationOffset : System.ValueType
{
    public static PRISM.Interactions.Drama.FingerTransformRotationOffset zero;
    public UnityEngine.Vector3 proximal;
    public UnityEngine.Vector3 intermediate;
    public UnityEngine.Vector3 distal;
    public static PRISM.Interactions.Drama.FingerTransformRotationOffset op_Multiply(PRISM.Interactions.Drama.FingerTransformRotationOffset& a, float b);
    public static PRISM.Interactions.Drama.FingerTransformRotationOffset op_Addition(PRISM.Interactions.Drama.FingerTransformRotationOffset& a, PRISM.Interactions.Drama.FingerTransformRotationOffset b);
    public void Apply(UnityEngine.Animator animator, UnityEngine.HumanBodyBones humanBodyBone);
}

// Namespace: PRISM.Interactions.Drama
public struct FingersTransformRotationOffset : System.ValueType
{
    public static PRISM.Interactions.Drama.FingersTransformRotationOffset zero;
    public PRISM.Interactions.Drama.FingerTransformRotationOffset thumb;
    public PRISM.Interactions.Drama.FingerTransformRotationOffset index;
    public PRISM.Interactions.Drama.FingerTransformRotationOffset middle;
    public PRISM.Interactions.Drama.FingerTransformRotationOffset ring;
    public PRISM.Interactions.Drama.FingerTransformRotationOffset little;
    public static PRISM.Interactions.Drama.FingersTransformRotationOffset op_Multiply(PRISM.Interactions.Drama.FingersTransformRotationOffset& a, float b);
    public static PRISM.Interactions.Drama.FingersTransformRotationOffset op_Addition(PRISM.Interactions.Drama.FingersTransformRotationOffset& a, PRISM.Interactions.Drama.FingersTransformRotationOffset b);
    public void Apply(UnityEngine.Animator animator, UnityEngine.HumanBodyBones humanBodyBone);
}

// Namespace: PRISM.Interactions.Drama
public class HumanoidTransformOffset : UnityEngine.MonoBehaviour
{
    private UnityEngine.Animator animator;
    private UnityEngine.Vector3 <Hips>k__BackingField;
    private UnityEngine.Vector3 <Spine>k__BackingField;
    private UnityEngine.Vector3 <Chest>k__BackingField;
    private UnityEngine.Vector3 <UpperChest>k__BackingField;
    private UnityEngine.Vector3 <Neck>k__BackingField;
    private UnityEngine.Vector3 <Head>k__BackingField;
    private UnityEngine.Vector3 <LeftShoulder>k__BackingField;
    private UnityEngine.Vector3 <LeftUpperArm>k__BackingField;
    private UnityEngine.Vector3 <LeftLowerArm>k__BackingField;
    private UnityEngine.Vector3 <LeftHand>k__BackingField;
    private PRISM.Interactions.Drama.FingersTransformRotationOffset <LeftFingers>k__BackingField;
    private UnityEngine.Vector3 <RightShoulder>k__BackingField;
    private UnityEngine.Vector3 <RightUpperArm>k__BackingField;
    private UnityEngine.Vector3 <RightLowerArm>k__BackingField;
    private UnityEngine.Vector3 <RightHand>k__BackingField;
    private PRISM.Interactions.Drama.FingersTransformRotationOffset <RightFingers>k__BackingField;
    private UnityEngine.Playables.PlayableDirector playableDirector;
    private static bool isExecutedManualEvaluate;
    public UnityEngine.Animator Animator { get; set; }
    public UnityEngine.Vector3 Hips { get; set; }
    public UnityEngine.Vector3 Spine { get; set; }
    public UnityEngine.Vector3 Chest { get; set; }
    public UnityEngine.Vector3 UpperChest { get; set; }
    public UnityEngine.Vector3 Neck { get; set; }
    public UnityEngine.Vector3 Head { get; set; }
    public UnityEngine.Vector3 LeftShoulder { get; set; }
    public UnityEngine.Vector3 LeftUpperArm { get; set; }
    public UnityEngine.Vector3 LeftLowerArm { get; set; }
    public UnityEngine.Vector3 LeftHand { get; set; }
    public PRISM.Interactions.Drama.FingersTransformRotationOffset LeftFingers { get; set; }
    public UnityEngine.Vector3 RightShoulder { get; set; }
    public UnityEngine.Vector3 RightUpperArm { get; set; }
    public UnityEngine.Vector3 RightLowerArm { get; set; }
    public UnityEngine.Vector3 RightHand { get; set; }
    public PRISM.Interactions.Drama.FingersTransformRotationOffset RightFingers { get; set; }
    private void _clear();
    private void Update();
    private void LateUpdate();
    private void _apply(UnityEngine.HumanBodyBones bone, UnityEngine.Vector3 euler);
}

// Namespace: PRISM.Interactions.Drama.Timeline
public class CharacterZBiasMixerBehaviour : PRISM.MixerBehaviourBase<PRISM.Character>
{
    private UnityEngine.Transform targetTransform;
    private float keepZBias;
    protected void Apply(UnityEngine.Timeline.TimelineClip timelineClip, double time);
    protected void NoHitClip(UnityEngine.Timeline.TimelineClip beforeClip, UnityEngine.Timeline.TimelineClip nextClip);
    public void OnPlayableDestroy(UnityEngine.Playables.Playable playable);
    private void _rollbackZBias();
    private static UnityEngine.Material _getTargetMaterial(UnityEngine.Transform transform);
}

// Namespace: PRISM.Interactions.Drama.Timeline
public class CharacterZBiasPlayableAsset : UnityEngine.Playables.PlayableAsset, UnityEngine.Timeline.ITimelineClipAsset
{
    public PRISM.Interactions.Drama.Timeline.CharacterZBiasPlayableBehaviour behaviour;
    public UnityEngine.Timeline.ClipCaps clipCaps { get; set; }
    public UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go);
}

// Namespace: PRISM.Interactions.Drama.Timeline
public class CharacterZBiasPlayableBehaviour : UnityEngine.Playables.PlayableBehaviour
{
    public string targetPath;
    public float zBias;
}

// Namespace: PRISM.Interactions.Drama.Timeline
public class CharacterZBiasTrack : UnityEngine.Timeline.TrackAsset
{
    public UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner, int inputCount);
}

// Namespace: PRISM.Interactions.Drama.Timeline
public class DramaBlinkMixerBehaviour : PRISM.MixerBehaviourBase<PRISM.Interactions.Drama.DramaEyeController>
{
    public void Initialize(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.TimelineClip[] clips, PRISM.Interactions.Drama.DramaEyeController target);
}

// Namespace: PRISM.Interactions.Drama.Timeline
public class DramaBlinkTiming
{
    public float time;
    public PRISM.Interactions.Drama.DramaBlinkCloseOpenTime closeOpenTime;
}

// Namespace: PRISM.Interactions.Drama.Timeline
public class DramaBlinkPlayableAsset : UnityEngine.Playables.PlayableAsset, UnityEngine.Timeline.ITimelineClipAsset
{
    public float minSpaceTime;
    public float maxSpaceTime;
    public float loopDuration;
    public System.Collections.Generic.List<PRISM.Interactions.Drama.Timeline.DramaBlinkTiming> timings;
    private PRISM.Interactions.Drama.DramaEyeController <Target>k__BackingField;
    public PRISM.Interactions.Drama.DramaEyeController Target { get; set; }
    public UnityEngine.Timeline.ClipCaps clipCaps { get; set; }
    public void SimulateTiming(float closeTime, float openTime);
    public UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go);
}

// Namespace: PRISM.Interactions.Drama.Timeline
public class DramaBlinkPlayableBehaviour : UnityEngine.Playables.PlayableBehaviour
{
    public float LoopDuration;
    public System.Collections.Generic.List<PRISM.Interactions.Drama.Timeline.DramaBlinkTiming> Timings;
    private PRISM.Interactions.Drama.DramaEyeController <Target>k__BackingField;
    private double timeOld;
    public PRISM.Interactions.Drama.DramaEyeController Target { get; set; }
    public void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, object playerData);
}

// Namespace: PRISM.Interactions.Drama.Timeline
public class DramaBlinkTrack : PRISM.TrackAssetBase<PRISM.Interactions.Drama.DramaEyeController, PRISM.Interactions.Drama.Timeline.DramaBlinkMixerBehaviour>
{
}

// Namespace: PRISM.Interactions.Drama.Timeline
public class HumanoidTransformOffsetMixerBehaviour : PRISM.MixerBehaviourBase<PRISM.Interactions.Drama.HumanoidTransformOffset>
{
    protected void Apply(UnityEngine.Timeline.TimelineClip timelineClip, double time);
    private void _apply(PRISM.Interactions.Drama.Timeline.HumanoidTransformOffsetPlayableBehaviour behaviour, float weight);
    protected void Blend(UnityEngine.Timeline.TimelineClip prevClip, float prevOut, UnityEngine.Timeline.TimelineClip nextClip, float nextIn);
    protected void NoHitClip(UnityEngine.Timeline.TimelineClip beforeClip, UnityEngine.Timeline.TimelineClip nextClip);
}

// Namespace: PRISM.Interactions.Drama.Timeline
public class HumanoidTransformOffsetPlayableAsset : UnityEngine.Playables.PlayableAsset, UnityEngine.Timeline.ITimelineClipAsset
{
    public PRISM.Interactions.Drama.Timeline.HumanoidTransformOffsetPlayableBehaviour behaviour;
    public UnityEngine.Timeline.ClipCaps clipCaps { get; set; }
    public UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go);
}

// Namespace: PRISM.Interactions.Drama.Timeline
public class HumanoidTransformOffsetPlayableBehaviour : UnityEngine.Playables.PlayableBehaviour
{
    public bool enableHips;
    public UnityEngine.Vector3 hips;
    public bool enableSpine;
    public UnityEngine.Vector3 spine;
    public bool enableChest;
    public UnityEngine.Vector3 chest;
    public bool enableUpperChest;
    public UnityEngine.Vector3 upperChest;
    public bool enableNeck;
    public UnityEngine.Vector3 neck;
    public bool enableHead;
    public UnityEngine.Vector3 head;
    public bool enableLeftShoulder;
    public UnityEngine.Vector3 leftShoulder;
    public bool enableLeftUpperArm;
    public UnityEngine.Vector3 leftUpperArm;
    public bool enableLeftLowerArm;
    public UnityEngine.Vector3 leftLowerArm;
    public bool enableLeftHand;
    public UnityEngine.Vector3 leftHand;
    public bool enableLeftFingers;
    public PRISM.Interactions.Drama.FingersTransformRotationOffset leftFingers;
    public bool enableRightShoulder;
    public UnityEngine.Vector3 rightShoulder;
    public bool enableRightUpperArm;
    public UnityEngine.Vector3 rightUpperArm;
    public bool enableRightLowerArm;
    public UnityEngine.Vector3 rightLowerArm;
    public bool enableRightHand;
    public UnityEngine.Vector3 rightHand;
    public bool enableRightFingers;
    public PRISM.Interactions.Drama.FingersTransformRotationOffset rightFingers;
}

// Namespace: PRISM.Interactions.Drama.Timeline
public class HumanoidTransformOffsetTrack : UnityEngine.Timeline.TrackAsset
{
    public UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner, int inputCount);
}

// Namespace: PRISM.Interactions.Drama.Timeline
public class MagicaParameterMixerBehaviour : PRISM.MixerBehaviourBase<MagicaCloth2.MagicaCloth>
{
    protected void Apply(UnityEngine.Timeline.TimelineClip timelineClip, double time);
    private void _apply(PRISM.Interactions.Drama.Timeline.MagicaParameterPlayableBehaviour behaviour, float weight);
    protected void Blend(UnityEngine.Timeline.TimelineClip prevClip, float prevOut, UnityEngine.Timeline.TimelineClip nextClip, float nextIn);
    protected void NoHitClip(UnityEngine.Timeline.TimelineClip beforeClip, UnityEngine.Timeline.TimelineClip nextClip);
}

// Namespace: PRISM.Interactions.Drama.Timeline
public class MagicaParameterPlayableAsset : UnityEngine.Playables.PlayableAsset, UnityEngine.Timeline.ITimelineClipAsset
{
    public PRISM.Interactions.Drama.Timeline.MagicaParameterPlayableBehaviour behaviour;
    public UnityEngine.Timeline.ClipCaps clipCaps { get; set; }
    public UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go);
}

// Namespace: PRISM.Interactions.Drama.Timeline
public class MagicaParameterPlayableBehaviour : UnityEngine.Playables.PlayableBehaviour
{
    public bool enableBlendWeight;
    public float blendWeight;
    public bool enableStabilizationTime;
    public float stabilizationTime;
    public bool enableTeleportDistance;
    public float teleportDistance;
    public bool enableTeleportRotation;
    public float teleportRotation;
    public bool enableWorldInertia;
    public float worldInertia;
    public bool enableWorldMovementSpeedLimit;
    public float worldMovementSpeedLimit;
    public bool enableLocalInertia;
    public float localInertia;
    public bool enableRadius;
    public float radius;
    public bool enableFriction;
    public float friction;
}

// Namespace: PRISM.Interactions.Drama.Timeline
public class MagicaParameterTrack : UnityEngine.Timeline.TrackAsset
{
    public UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner, int inputCount);
}

// Namespace: PRISM.Interactions.Story
public class StoryCategoryTypeLabelView : UnityEngine.MonoBehaviour
{
    private ColorTextPair[] colorAndTexts;
    private UnityEngine.UI.Image image;
    private ENTERPRISE.UI.UITextMeshProUGUI label;
    public void Initialize(PRISM.Definitions.Story.StoryCategoryType categoryType);

    private class ColorTextPair
    {
        private UnityEngine.Color color;
        private string text;
        public UnityEngine.Color Color { get; set; }
        public string Text { get; set; }
    }
}

// Namespace: PRISM.Interactions.Story
public class StoryRewardItemIcon : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.RewardItemIcon rewardItemIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI itemAmountText;
    public void Initialize(PRISM.Module.Networking.IProductWithAmountStatus productWithAmount, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken cancellationToken);
}

// Namespace: PRISM.Interactions.Common
public class ReceiveRewardPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.Common.IReceiveRewardPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private ENTERPRISE.UI.UITextMeshProUGUI headerText;
    private UnityEngine.Transform rewardItemPos;
    private PRISM.Interactions.ReceiveRewardItem rewardItemPrefab;
    private UnityEngine.UI.ScrollRect scrollRect;
    private UnityEngine.GameObject footerArea;
    private ENTERPRISE.UI.UITextMeshProUGUI footerText;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Interactions.PopupFrameParameter popupFrameParameter;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void Initialize(PRISM.Adapters.Common.ReceiveRewardPopupViewModel viewModel, PRISM.Adapters.PopupFrameType frameType, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <Initialize>b__11_0();
    private void <Initialize>b__11_1();
}

// Namespace: PRISM.Interactions.Common
public class StoryUnlockPopupItemCell : UnityEngine.MonoBehaviour
{
    private TMPro.TextMeshProUGUI categoryText;
    private TMPro.TextMeshProUGUI titleText;
    private UnityEngine.UI.Image thumbnailImage;
    private UnityEngine.UI.RawImage thumbnailRawImage;
    private PRISM.Interactions.ProduceIdolIconView produceIdolIconView;
    private PRISM.Interactions.ViewStateChanger pIdolChanger;
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.Common.StoryUnlockPopupItemCellData cellData, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);

    private struct <InitializeAsync>d__6 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Common.StoryUnlockPopupItemCell <>4__this;
        public PRISM.Adapters.Common.StoryUnlockPopupItemCellData cellData;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Common
public class StoryUnlockPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.Common.IStoryUnlockPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private ENTERPRISE.UI.UITextMeshProUGUI popupHeaderText;
    private PRISM.Interactions.Common.StoryUnlockPopupItemCell itemCellPrefab;
    private UnityEngine.Transform itemCellPos;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onCloseRequested;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.Common.StoryUnlockPopupViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__7_0();
    private void <CreateFrameParameter>b__7_1();
}

// Namespace: PRISM.Interactions.PrivacyOption
public class PrivacyOptionPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.PrivacyOption.IPrivacyOptionPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private Growing.XMLPanel subMessageBody;
    private int subMessageFontSize;
    private ENTERPRISE.UI.UITextMeshProUGUI subMessageCaution;
    private ENTERPRISE.UI.UIButton analyticsButton;
    private ENTERPRISE.UI.UITextMeshProUGUI analyticsButtonText;
    private ENTERPRISE.UI.UIButton advertisementButton;
    private ENTERPRISE.UI.UITextMeshProUGUI advertisementButtonText;
    private ENTERPRISE.UI.ToggleButton analyticsToggle;
    private ENTERPRISE.UI.UITextMeshProUGUI analyticsToggleText;
    private ENTERPRISE.UI.ToggleButton advertisementToggle;
    private ENTERPRISE.UI.UITextMeshProUGUI advertisementToggleText;
    private UniRx.Subject<ConsentType> onClickDescriptionButton;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClose;
    private PRISM.Adapters.PrivacyOption.PrivacyOptionPopupViewModel viewModel;
    private System.Func<FooterButtonType, Cysharp.Threading.Tasks.UniTask> onClosingFunc;
    private PRISM.Interactions.IPopupFrameView parent;
    public System.IObservable<ConsentType> OnClickDescriptionButton { get; set; }
    public bool IsAnalyticsToggleActive { get; set; }
    public bool IsAdvertisementToggleActive { get; set; }
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Initialize(PRISM.Adapters.PrivacyOption.PrivacyOptionPopupViewModel viewModel, System.Func<FooterButtonType, Cysharp.Threading.Tasks.UniTask> onClosingFunc);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    private System.Collections.Generic.IReadOnlyList<ButtonInfoParameter> _createFooterButtonInfoParameters(ConfirmConsentStatus consentStatus);
    private void _onClickFooterButton(FooterButtonType type);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__24_0();
    private void <_createFooterButtonInfoParameters>b__26_0();
    private void <_createFooterButtonInfoParameters>b__26_1();
    private void <_createFooterButtonInfoParameters>b__26_2();
    private void <_createFooterButtonInfoParameters>b__26_3();
    private void <_createFooterButtonInfoParameters>b__26_4();
    private bool <_onClickFooterButton>b__27_0();

    private class <>c__DisplayClass23_0
    {
        public PRISM.Interactions.PrivacyOption.PrivacyOptionPopupView <>4__this;
        public PRISM.Adapters.PrivacyOption.PrivacyOptionPopupViewModel viewModel;
        private void <Initialize>b__0(UniRx.Unit _);
        private void <Initialize>b__1(UniRx.Unit _);
        private void <Initialize>b__2(bool x);
        private void <Initialize>b__3(bool x);
    }
}

// Namespace: PRISM.Interactions.GameHelpList
public class GameHelpListCategoryCellView : EnhancedUI.EnhancedScroller.EnhancedScrollerCellView
{
    private static float DescriptionUnderOffsetHeight;
    private UnityEngine.RectTransform largeCategoryRoot;
    private ENTERPRISE.UI.UITextMeshProUGUI largeCategoryText;
    private ENTERPRISE.UI.UIButton showCategoryButton;
    private UnityEngine.UI.Image largeCategoryImage;
    private UnityEngine.Sprite[] largeCategorySprites;
    private UnityEngine.RectTransform smallCategoryRoot;
    private ENTERPRISE.UI.UIButton showDescriptionButton;
    private UnityEngine.UI.Image expandSprite;
    private UnityEngine.Sprite expandOpenSprite;
    private UnityEngine.Sprite expandCloseSprite;
    private ENTERPRISE.UI.UITextMeshProUGUI smallCategoryText;
    private UnityEngine.RectTransform descriptionRoot;
    private ENTERPRISE.UI.UITextMeshProUGUI descriptionText;
    public float LargeCategoryCellHeight { get; set; }
    public float SmallCategoryCellHeight { get; set; }
    public System.IObservable<UniRx.Unit> OnClick { get; set; }
    public void SetCellInfo(PRISM.Adapters.Common.GameHelpList.GameHelpListCellViewModel viewModel);
}

// Namespace: PRISM.Interactions.GameHelpList
public class GameHelpListPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.Common.GameHelpList.IGameHelpListPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>, EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate
{
    private PRISM.Interactions.GameHelpList.GameHelpListCategoryCellView categoryCell;
    private PRISM.Interactions.GameHelpList.GetTextSizeView getTextSizeView;
    private EnhancedUI.EnhancedScroller.EnhancedScroller scroller;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClick;
    private PRISM.Adapters.Common.GameHelpList.GameHelpListViewModel viewModel;
    private PRISM.Interactions.IPopupFrameView parent;
    public float LargeCategoryCellHeight { get; set; }
    public float SmallCategoryCellHeight { get; set; }
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.Common.GameHelpList.GameHelpListViewModel cellViewModel, int focusCellIndex);
    public int GetNumberOfCells(EnhancedUI.EnhancedScroller.EnhancedScroller enhancedScroller);
    public float GetCellViewSize(EnhancedUI.EnhancedScroller.EnhancedScroller enhancedScroller, int dataIndex);
    public EnhancedUI.EnhancedScroller.EnhancedScrollerCellView GetCellView(EnhancedUI.EnhancedScroller.EnhancedScroller enhancedScroller, int dataIndex, int cellIndex);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <InitializeAsync>b__11_0(EnhancedUI.EnhancedScroller.EnhancedScrollerCellView view);
    private void <InitializeAsync>b__11_1(EnhancedUI.EnhancedScroller.EnhancedScroller _, EnhancedUI.EnhancedScroller.EnhancedScrollerCellView view);
    private void <CreateFrameParameter>b__15_0();
    private void <CreateFrameParameter>b__15_1();

    private class <>c__DisplayClass11_0
    {
        public EnhancedUI.EnhancedScroller.EnhancedScrollerCellView view;
        public PRISM.Interactions.GameHelpList.GameHelpListPopupView <>4__this;
        private void <InitializeAsync>b__2(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.GameHelpList
public class GetTextSizeView : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI calculatedText;
    public float GetPreferredHeight(string targetText);
}

// Namespace: PRISM.Interactions.CostumeChange
public class CostumeChangeIdolView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.CharacterBaseIconView characterIconView;
    private ENTERPRISE.UI.UITextMeshProUGUI characterName;
    private PRISM.Interactions.CostumeSetIconView costumeSetIconView;
    private PRISM.UI.UICharacterViewer uiCharacterViewer;
    private CameraConfig[] cameraConfigs;
    private UnityEngine.RectTransform closedState;
    private UnityEngine.RectTransform openState;
    private PRISM.Interactions.ButtonView closeButton;
    private PRISM.Interactions.ButtonView openButton;
    private PRISM.AutoCancellationTokenSource previewCanceller;
    private PRISM.AutoCancellationTokenSource costumeSetIconCanceller;
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Adapters.CostumeChange.CostumeChangeViewModel viewModel, System.Threading.CancellationToken ct);
    private void _initializeOpenClose(System.Threading.CancellationToken ct);
    public void Reload(PRISM.Adapters.CostumeChange.CostumeChangeViewModel viewModel);
    public void ReturnBackGroundFrom3D();
    public Cysharp.Threading.Tasks.UniTask ReleaseAsync();

    private class CameraConfig
    {
        private PRISM.Definitions.CostumeCategory[] targetCategories;
        private CameraTargetParameter parameter;
        public System.Collections.Generic.IReadOnlyList<PRISM.Definitions.CostumeCategory> TargetCategories { get; set; }
        public CameraTargetParameter Parameter { get; set; }
    }

    private class <>c__DisplayClass12_0
    {
        public PRISM.Adapters.CostumeChange.CostumeChangeViewModel viewModel;
        public PRISM.Interactions.CostumeChange.CostumeChangeIdolView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private void <InitializeAsync>b__0(CostumeType _);
        private void <InitializeAsync>b__1(PRISM.Definitions.CostumeCategory category);
    }

    private class <>c__DisplayClass12_1
    {
        public PRISM.Definitions.CostumeCategory category;
        private bool <InitializeAsync>b__2(CameraConfig x);
    }

    private class <>c__DisplayClass13_0
    {
        public PRISM.Interactions.CostumeChange.CostumeChangeIdolView <>4__this;
        public UnityEngine.Vector2 openStateSize;
        public UnityEngine.Vector2 closedStateSize;
        public DG.Tweening.TweenCallback <>9__2;
        private void <_initializeOpenClose>b__0(UniRx.Unit _);
        private void <_initializeOpenClose>b__1(UniRx.Unit _);
        private void <_initializeOpenClose>b__2();
    }

    private class <>c__DisplayClass14_0
    {
        public System.Threading.CancellationToken ct;
        public PRISM.Interactions.CostumeChange.CostumeChangeIdolView <>4__this;
        public PRISM.UnitIdol[] unitIdols;
        private void <Reload>b__0();
    }
}

// Namespace: PRISM.Interactions.CostumeChange
public class CostumeChangeTabInCategoryView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView button;
    private PRISM.Interactions.ViewStateChanger partTypeStateChanger;
    public PRISM.Interactions.ButtonView Initialize(PRISM.Definitions.CostumePartType partType);
}

// Namespace: PRISM.Interactions.CostumeChange
public class CostumeChangeToggleView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ToggleGroupViewWithAllOff displayModeToggleGroup;
    private PRISM.Interactions.ToggleGroupView costumeTypeToggleGroup;
    private PRISM.Interactions.ToggleGroupView costumeCategoryToggleGroup;
    private PRISM.Interactions.CostumeChange.CostumeChangeTabInCategoryView tabInCategoryViewBase;
    private PRISM.Interactions.ViewStateChanger tabInCategoryChanger;
    private System.IDisposable tabInCategoryDisposable;
    private PRISM.Interactions.ResettableComponentPool<PRISM.Interactions.CostumeChange.CostumeChangeTabInCategoryView> tabInCategoryViewPool;
    public void Initialize(PRISM.Adapters.CostumeChange.CostumeChangeViewModel viewModel);

    private class <>c__DisplayClass7_0
    {
        public PRISM.Adapters.CostumeChange.CostumeChangeViewModel viewModel;
        public PRISM.Interactions.CostumeChange.CostumeChangeToggleView <>4__this;
        public System.Func<PRISM.Definitions.CostumePartType, PRISM.Interactions.ButtonView> <>9__1;
        private void <Initialize>b__0(PRISM.Definitions.CostumeCategory category);
        private PRISM.Interactions.ButtonView <Initialize>b__1(PRISM.Definitions.CostumePartType partType);
    }
}

// Namespace: PRISM.Interactions.CostumeChange
public class CostumeChangeView : UnityEngine.MonoBehaviour, PRISM.Adapters.CostumeChange.ICostumeChangeView
{
    private PRISM.Interactions.CostumeChange.CostumePresetWindowView presetWindowView;
    private PRISM.Interactions.CostumeChange.CostumeChangeIdolView idolView;
    private PRISM.Interactions.CostumeChange.CostumeChangeToggleView toggleView;
    private PRISM.Interactions.CostumeChange.CostumeSetListView costumeSetView;
    private PRISM.Interactions.CostumeChange.CostumePartGridView costumePartView;
    private PRISM.Interactions.SortFilterView sortFilterView;
    private ENTERPRISE.UI.UITextMeshProUGUI costumePartTypeText;
    private PRISM.Interactions.HorizontalAutoScrollingText costumeNameText;
    private PRISM.Interactions.ButtonView decideButton;
    public PRISM.Adapters.CostumeChange.ICostumePresetWindowView PresetWindowView { get; set; }
    public PRISM.Adapters.ISortFilterView SortFilterView { get; set; }
    public System.IObservable<PRISM.Adapters.CostumeChange.CostumeSetViewModel> OnSelectCostumeSet { get; set; }
    public System.IObservable<PRISM.Adapters.CostumeChange.CostumePartViewModel> OnSelectCostumePart { get; set; }
    public System.IObservable<UniRx.Unit> OnDecide { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Adapters.CostumeChange.CostumeChangeViewModel viewModel, System.Threading.CancellationToken ct);
    public void UpdateList(PRISM.Adapters.CostumeChange.CostumeChangeViewModel viewModel, System.Collections.Generic.IReadOnlyList<PRISM.Adapters.CostumeChange.CostumeSetViewModel> costumeSets, System.Collections.Generic.IReadOnlyList<PRISM.Adapters.CostumeChange.CostumePartViewModel> costumeParts);
    public void Reload(PRISM.Adapters.CostumeChange.CostumeChangeViewModel viewModel);
    public void ReturnBackGroundFrom3D();
    public Cysharp.Threading.Tasks.UniTask ReleaseAsync();
    private void <InitializeAsync>b__19_0(PRISM.Adapters.CostumeChange.DisplayMode mode);
    private void <InitializeAsync>b__19_1(PRISM.Definitions.CostumeCategory category);
}

// Namespace: PRISM.Interactions.CostumeChange
public class CostumePartGridView : PRISM.Interactions.GridView<PRISM.Interactions.CostumeChange.CostumePartGridViewCell, PRISM.Adapters.CostumeChange.CostumePartViewModel, PRISM.Interactions.CostumeChange.CostumePartGridViewContext>
{
    public System.IObservable<PRISM.Adapters.CostumeChange.CostumePartViewModel> OnSelect { get; set; }
    protected void SetupCellTemplate();
    public void Inject(PRISM.ResourceManagement.IResourceLoader resourceLoader, UniRx.IReadOnlyReactiveProperty<PRISM.Adapters.CostumeChange.DisplayMode> displayMode);
    public void UpdateContents(PRISM.Adapters.CostumeChange.CostumeChangeViewModelByType viewModel, System.Collections.Generic.IReadOnlyList<PRISM.Adapters.CostumeChange.CostumePartViewModel> items);
    public void Reload();

    private class CellGroup : DefaultCellGroup<PRISM.Adapters.CostumeChange.CostumePartViewModel, PRISM.Interactions.CostumeChange.CostumePartGridViewContext>
    {
    }
}

// Namespace: PRISM.Interactions.CostumeChange
public class CostumePartGridViewContext : PRISM.Interactions.GridViewContextWithClick<PRISM.Adapters.CostumeChange.CostumePartViewModel>
{
    private PRISM.Domain.ICostumeSetData <SettingCostumeSet>k__BackingField;
    private PRISM.Domain.ICostumeSetData <PreviewCostumeSet>k__BackingField;
    private UniRx.IReadOnlyReactiveProperty<PRISM.Adapters.CostumeChange.DisplayMode> <DisplayMode>k__BackingField;
    public PRISM.Domain.ICostumeSetData SettingCostumeSet { get; set; }
    public PRISM.Domain.ICostumeSetData PreviewCostumeSet { get; set; }
    public UniRx.IReadOnlyReactiveProperty<PRISM.Adapters.CostumeChange.DisplayMode> DisplayMode { get; set; }
}

// Namespace: PRISM.Interactions.CostumeChange
public class CostumePartGridViewCell : PRISM.Interactions.GridViewCell<PRISM.Adapters.CostumeChange.CostumePartViewModel, PRISM.Interactions.CostumeChange.CostumePartGridViewContext>
{
    private PRISM.Interactions.CostumeIconView icon;
    private UnityEngine.GameObject defaultObject;
    private UnityEngine.GameObject settingObject;
    private UnityEngine.GameObject previewObject;
    private PRISM.Interactions.ViewStateChanger statusChanger;
    private PRISM.Interactions.ViewStateChanger displayModeStateChanger;
    private PRISM.AutoCancellationTokenSource canceller;
    public void UpdateContent(PRISM.Adapters.CostumeChange.CostumePartViewModel itemData);
    private void OnDestroy();

    private class <>c__DisplayClass7_0
    {
        public PRISM.Interactions.CostumeChange.CostumePartGridViewCell <>4__this;
        public PRISM.Adapters.CostumeChange.CostumePartViewModel itemData;
        private void <UpdateContent>b__0(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.CostumeChange
public class CostumeSetListView : PRISM.Interactions.ListView<PRISM.Interactions.CostumeChange.CostumeSetListViewCell, PRISM.Adapters.CostumeChange.CostumeSetViewModel, PRISM.Interactions.CostumeChange.CostumeSetListViewContext>
{
    public System.IObservable<PRISM.Adapters.CostumeChange.CostumeSetViewModel> OnSelect { get; set; }
    public void Inject(PRISM.ResourceManagement.IResourceLoader resourceLoader, UniRx.IReadOnlyReactiveProperty<PRISM.Adapters.CostumeChange.DisplayMode> displayMode);
    public void UpdateContents(PRISM.Adapters.CostumeChange.CostumeChangeViewModelByType viewModel, System.Collections.Generic.IReadOnlyList<PRISM.Adapters.CostumeChange.CostumeSetViewModel> items);
    public void Reload();
}

// Namespace: PRISM.Interactions.CostumeChange
public class CostumeSetListViewContext : PRISM.Interactions.ListViewContextWithClick<PRISM.Adapters.CostumeChange.CostumeSetViewModel>
{
    private PRISM.Domain.ICostumeSetData <SettingCostumeSet>k__BackingField;
    private PRISM.Domain.ICostumeSetData <PreviewCostumeSet>k__BackingField;
    private UniRx.IReadOnlyReactiveProperty<PRISM.Adapters.CostumeChange.DisplayMode> <DisplayMode>k__BackingField;
    public PRISM.Domain.ICostumeSetData SettingCostumeSet { get; set; }
    public PRISM.Domain.ICostumeSetData PreviewCostumeSet { get; set; }
    public UniRx.IReadOnlyReactiveProperty<PRISM.Adapters.CostumeChange.DisplayMode> DisplayMode { get; set; }
}

// Namespace: PRISM.Interactions.CostumeChange
public class CostumeSetListViewCell : PRISM.Interactions.ListViewCell<PRISM.Adapters.CostumeChange.CostumeSetViewModel, PRISM.Interactions.CostumeChange.CostumeSetListViewContext>
{
    private PRISM.Interactions.ButtonView button;
    private PRISM.Interactions.HorizontalAutoScrollingText nameText;
    private PRISM.Interactions.CostumeSetIconView iconView;
    private UnityEngine.GameObject[] settingObjects;
    private UnityEngine.GameObject previewObject;
    private UnityEngine.GameObject lockedObject;
    private PRISM.Interactions.ViewStateChanger displayModeStateChanger;
    private PRISM.AutoCancellationTokenSource canceller;
    public void UpdateContent(PRISM.Adapters.CostumeChange.CostumeSetViewModel itemData);
    private void OnDestroy();

    private class <>c__DisplayClass8_0
    {
        public PRISM.Interactions.CostumeChange.CostumeSetListViewCell <>4__this;
        public PRISM.Adapters.CostumeChange.CostumeSetViewModel itemData;
        private void <UpdateContent>b__0(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.CostumeChange
public class CostumePresetListCell : PRISM.Interactions.ListViewCell<PRISM.Module.Networking.ICostumePresetStatus, PRISM.Interactions.CostumeChange.CostumePresetListViewContext>
{
    private PRISM.Interactions.CostumeSetIconView costumeSetIconView;
    private ENTERPRISE.UI.UITextMeshProUGUI presetNumber;
    private PRISM.CommonInputFieldTMP presetNameInputField;
    private PRISM.Interactions.ButtonView renameButton;
    private PRISM.Interactions.ButtonView applyButton;
    private PRISM.Interactions.ButtonView saveButton;
    private PRISM.Interactions.ButtonView deleteButton;
    private PRISM.Interactions.ViewStateChanger saveButtonPresetChanger;
    private PRISM.AutoCancellationTokenSource canceller;
    private static int MaxTextCount;
    public void Initialize();
    public void UpdateContent(PRISM.Module.Networking.ICostumePresetStatus preset);
    private void OnDestroy();
    private void <Initialize>b__10_0(UniRx.Unit _);
    private void <Initialize>b__10_1(UniRx.Unit _);
    private void <Initialize>b__10_2(UniRx.Unit _);
    private void <Initialize>b__10_3(UniRx.Unit _);
    private void <Initialize>b__10_4(string newName);
}

// Namespace: PRISM.Interactions.CostumeChange
public class CostumePresetListView : PRISM.Interactions.ListView<PRISM.Interactions.CostumeChange.CostumePresetListCell, PRISM.Module.Networking.ICostumePresetStatus, PRISM.Interactions.CostumeChange.CostumePresetListViewContext>, PRISM.Adapters.CostumeChange.ICostumePresetListView
{
    public System.IObservable<int> OnClickSaveButton { get; set; }
    public System.IObservable<int> OnClickApplyButton { get; set; }
    public System.IObservable<int> OnClickDeleteButton { get; set; }
    public System.IObservable<System.ValueTuple<int, string>> OnEndEditPresetName { get; set; }
}

// Namespace: PRISM.Interactions.CostumeChange
public class CostumePresetListViewContext : PRISM.Interactions.ListViewContext
{
    public UniRx.Subject<int> OnClickSaveButton;
    public UniRx.Subject<int> OnClickApplyButton;
    public UniRx.Subject<int> OnClickDeleteButton;
    public UniRx.Subject<System.ValueTuple<int, string>> OnEndEditPresetName;
    public void Dispose();
}

// Namespace: PRISM.Interactions.CostumeChange
public class CostumePresetWindowView : ENTERPRISE.UI.SlideWindowBase, PRISM.Adapters.CostumeChange.ICostumePresetWindowView
{
    private PRISM.Interactions.CostumeChange.CostumePresetListView listView;
    private PRISM.Interactions.ButtonView openButton;
    private PRISM.Interactions.ButtonView closeButton;
    public PRISM.Adapters.CostumeChange.ICostumePresetListView ListView { get; set; }
    public System.IObservable<UniRx.Unit> OnOpen { get; set; }
    protected System.IObservable<UniRx.Unit> OnHideRequested { get; set; }
    public void Initialize(PRISM.ResourceManagement.IResourceLoader resourceLoader, UniRx.ReactiveProperty<PRISM.Adapters.CostumeChange.DisplayMode> displayMode);
    private void <Initialize>b__9_0(PRISM.Adapters.CostumeChange.DisplayMode mode);
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=14033 A991094F1BB8D3CBC22844F57F5867EC4361BCF43D1E01166A3E5CDD57849CEF;
    private static __StaticArrayInitTypeSize=21864 DD22EE512FE0B42E392D9DDD0BDDEBEF9E04C09A172A6022331BB8CAF1EB1801;

    private struct __StaticArrayInitTypeSize=14033 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=21864 : System.ValueType
    {
    }
}
