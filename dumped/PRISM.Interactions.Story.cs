
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

// Namespace: PRISM.Interactions.Story
public class EpisodeZeroStorySelectConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.Story.EpisodeZeroStorySelectArgument>, PRISM.Adapters.Story.IEpisodeZeroStorySelectConnector
{
    protected PRISM.Adapters.Story.EpisodeZeroStorySelectArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
}

// Namespace: PRISM.Interactions.Story
public class EpisodeZeroStorySelectIdolColorData : UnityEngine.ScriptableObject
{
    private IdColorPair[] idColorPairs;
    public System.Collections.Generic.IReadOnlyDictionary<int, UnityEngine.Color> ToDictionary();

    private class IdColorPair
    {
        public int Id;
        public UnityEngine.Color Color;
    }

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<IdColorPair, int> <>9__2_0;
        public static System.Func<IdColorPair, UnityEngine.Color> <>9__2_1;
        private int <ToDictionary>b__2_0(IdColorPair x);
        private UnityEngine.Color <ToDictionary>b__2_1(IdColorPair x);
    }
}

// Namespace: PRISM.Interactions.Story
public class EpisodeZeroStorySelectIdolTabView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.MinimalUIButtonView button;
    private UnityEngine.UI.Image selectedImage;
    private UnityEngine.UI.Image unselectedImage;
    private PRISM.Interactions.ViewStateChanger isSelectedChanger;
    private PRISM.Interactions.ViewStateChanger isUnreadChanger;
    private PRISM.Interactions.ViewStateChanger isNewChanger;
    public PRISM.Interactions.MinimalUIButtonView Button { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(int mstIdolId, PRISM.ResourceManagement.IResourceLoader resourceLoader, UniRx.IReadOnlyReactiveProperty<int> selectedIdolId, bool isUnread, bool isNew, System.Threading.CancellationToken ct);

    private class <>c__DisplayClass8_0
    {
        public PRISM.Interactions.Story.EpisodeZeroStorySelectIdolTabView <>4__this;
        public int mstIdolId;
        private void <InitializeAsync>b__0(int value);
    }
}

// Namespace: PRISM.Interactions.Story
public class EpisodeZeroStorySelectCellScrollerContext : PRISM.EnhancedListViewContext, System.IDisposable
{
    private UniRx.Subject<PRISM.Adapters.Story.EpisodeZeroStorySelectCellViewModel> onClickCell;
    private UniRx.Subject<PRISM.Adapters.Story.EpisodeZeroStorySelectCellViewModel> onClickFavoriteButton;
    public UniRx.ISubject<PRISM.Adapters.Story.EpisodeZeroStorySelectCellViewModel> OnClickCell { get; set; }
    public UniRx.ISubject<PRISM.Adapters.Story.EpisodeZeroStorySelectCellViewModel> OnClickFavoriteButton { get; set; }
    public void Dispose();
}

// Namespace: PRISM.Interactions.Story
public class EpisodeZeroStorySelectCellScrollerView : PRISM.EnhancedListView<PRISM.Adapters.Story.EpisodeZeroStorySelectCellViewModel, PRISM.Interactions.Story.EpisodeZeroStorySelectCellScrollerContext>
{
    public System.IObservable<PRISM.Adapters.Story.EpisodeZeroStorySelectCellViewModel> OnClickCell { get; set; }
    public System.IObservable<PRISM.Adapters.Story.EpisodeZeroStorySelectCellViewModel> OnClickFavoriteButton { get; set; }
    private void OnDestroy();
}

// Namespace: PRISM.Interactions.Story
public class EpisodeZeroStorySelectCellView : PRISM.EnhancedListViewCell<PRISM.Adapters.Story.EpisodeZeroStorySelectCellViewModel, PRISM.Interactions.Story.EpisodeZeroStorySelectCellScrollerContext>
{
    private PRISM.Interactions.ButtonView button;
    private UnityEngine.UI.Image thumbnailImage;
    private UnityEngine.UI.Image colorTapeImage;
    private ENTERPRISE.UI.UITextMeshProUGUI titleText;
    private ENTERPRISE.UI.UITextMeshProUGUI storyNumberText;
    private PRISM.Interactions.ViewStateChanger isUnreadChanger;
    private PRISM.Interactions.ViewStateChanger isNewChanger;
    private PRISM.Interactions.Story.StoryRewardItemIcon originalRewardItemIcon;
    private UnityEngine.Transform rewardItemIconParent;
    private PRISM.Interactions.ButtonView favoriteButton;
    private PRISM.Interactions.ViewStateChanger isFavoriteChanger;
    private PRISM.Interactions.ViewStateChanger isLockedChanger;
    private ENTERPRISE.UI.UITextMeshProUGUI lockText;
    private PRISM.Interactions.ResettableComponentPool<PRISM.Interactions.Story.StoryRewardItemIcon> rewardItemIconPool;
    private PRISM.AutoCancellationTokenSource canceller;
    public void UpdateContent(PRISM.Adapters.Story.EpisodeZeroStorySelectCellViewModel viewModel);
    private void OnDestroy();

    private class <>c__DisplayClass15_0
    {
        public PRISM.Interactions.Story.EpisodeZeroStorySelectCellView <>4__this;
        public PRISM.Adapters.Story.EpisodeZeroStorySelectCellViewModel viewModel;
        private void <UpdateContent>b__0(UniRx.Unit _);
        private void <UpdateContent>b__1(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.Story
public class EpisodeZeroStorySelectView : UnityEngine.MonoBehaviour, PRISM.Adapters.Story.IEpisodeZeroStorySelectView
{
    private PRISM.Interactions.MinimalUIButtonToggleGroupView unitTabGroupView;
    private PRISM.Interactions.Story.EpisodeZeroStorySelectIdolTabView originalIdolTabView;
    private UnityEngine.Transform idolTabParent;
    private UnityEngine.UI.Image idolImage;
    private PRISM.Interactions.Story.EpisodeZeroStorySelectIdolColorData idolColorData;
    private ENTERPRISE.UI.UITextMeshProUGUI idolNameText;
    private ENTERPRISE.UI.UITextMeshProUGUI idolNameEnText;
    private ENTERPRISE.UI.UITextMeshProUGUI idolDescriptionText;
    private ENTERPRISE.UI.UITextMeshProUGUI idolDescriptionTextFront;
    private UnityEngine.UI.Image idolNameDecoLineImage;
    private UnityEngine.UI.Image unitLogoImage;
    private PRISM.Interactions.Story.EpisodeZeroStorySelectCellScrollerView cellScroller;
    private PRISM.UIAnimation onChangeIdolAnimation;
    private PRISM.UIAnimation onChangeUnitAnimation;
    private PRISM.AutoCancellationTokenSource selectedIdolCanceller;
    private PRISM.AutoCancellationTokenSource selectedUnitCanceller;
    private bool isInitialized;
    public System.IObservable<PRISM.Adapters.Story.EpisodeZeroStorySelectCellViewModel> OnPlayAdv { get; set; }
    public System.IObservable<PRISM.Adapters.Story.EpisodeZeroStorySelectCellViewModel> OnChangeFavorite { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(System.Collections.Generic.IReadOnlyDictionary<int, System.Collections.Generic.IReadOnlyList<PRISM.Adapters.Story.EpisodeZeroStorySelectCellViewModel>> thumbnailCellViewModels, UniRx.IReactiveProperty<int> selectedUnitId, UniRx.IReactiveProperty<int> selectedIdolId, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    private void OnDestroy();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Definitions.MstCharacterInfo, bool> <>9__21_3;
        public static System.Func<PRISM.Adapters.Story.EpisodeZeroStorySelectCellViewModel, bool> <>9__21_5;
        public static System.Func<PRISM.Adapters.Story.EpisodeZeroStorySelectCellViewModel, bool> <>9__21_6;
        public static System.Func<PRISM.Interactions.Story.EpisodeZeroStorySelectIdolTabView, PRISM.Interactions.MinimalUIButtonView> <>9__21_0;
        public static System.Func<PRISM.Definitions.MstCharacterInfo, int> <>9__21_8;
        private bool <InitializeAsync>b__21_3(PRISM.Definitions.MstCharacterInfo x);
        private bool <InitializeAsync>b__21_5(PRISM.Adapters.Story.EpisodeZeroStorySelectCellViewModel x);
        private bool <InitializeAsync>b__21_6(PRISM.Adapters.Story.EpisodeZeroStorySelectCellViewModel x);
        private PRISM.Interactions.MinimalUIButtonView <InitializeAsync>b__21_0(PRISM.Interactions.Story.EpisodeZeroStorySelectIdolTabView x);
        private int <InitializeAsync>b__21_8(PRISM.Definitions.MstCharacterInfo x);
    }

    private class <>c__DisplayClass21_0
    {
        public System.Collections.Generic.IReadOnlyDictionary<int, System.Collections.Generic.IReadOnlyList<PRISM.Adapters.Story.EpisodeZeroStorySelectCellViewModel>> thumbnailCellViewModels;
        public PRISM.Interactions.Story.EpisodeZeroStorySelectView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public UniRx.IReactiveProperty<int> selectedIdolId;
        public System.Threading.CancellationToken ct;
        public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstUnit> mstUnits;
        public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstCharacterInfo> mstCharacterInfos;
        public PRISM.Interactions.Story.EpisodeZeroStorySelectIdolTabView[] idolTabs;
        public System.Collections.Generic.IReadOnlyDictionary<int, UnityEngine.Color> idolColorDataDictionary;
        private Cysharp.Threading.Tasks.UniTask<PRISM.Interactions.Story.EpisodeZeroStorySelectIdolTabView> <InitializeAsync>b__4(PRISM.Definitions.MstCharacterInfo mstCharacterInfo);
        private void <InitializeAsync>b__1(int unitId);
        private void <InitializeAsync>b__2(int idolId);

        private struct <<InitializeAsync>b__4>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
        {
            public int <>1__state;
            public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<PRISM.Interactions.Story.EpisodeZeroStorySelectIdolTabView> <>t__builder;
            public <>c__DisplayClass21_0 <>4__this;
            public PRISM.Definitions.MstCharacterInfo mstCharacterInfo;
            private PRISM.Interactions.Story.EpisodeZeroStorySelectIdolTabView <idolTabView>5__2;
            private Awaiter <>u__1;
            private void MoveNext();
            private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }

    private class <>c__DisplayClass21_1
    {
        public int unitId;
        private bool <InitializeAsync>b__7(PRISM.Definitions.MstCharacterInfo x);
    }

    private struct <InitializeAsync>d__21 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public System.Collections.Generic.IReadOnlyDictionary<int, System.Collections.Generic.IReadOnlyList<PRISM.Adapters.Story.EpisodeZeroStorySelectCellViewModel>> thumbnailCellViewModels;
        public PRISM.Interactions.Story.EpisodeZeroStorySelectView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public UniRx.IReactiveProperty<int> selectedIdolId;
        public System.Threading.CancellationToken ct;
        public UniRx.IReactiveProperty<int> selectedUnitId;
        private <>c__DisplayClass21_0 <>8__1;
        private Awaiter<PRISM.Interactions.Story.EpisodeZeroStorySelectIdolTabView[]> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Story
public class EpisodeZeroUnitSelectCellView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.MinimalUIButtonView button;
    private PRISM.Interactions.ViewStateChanger isUnreadChanger;
    private PRISM.Interactions.ViewStateChanger isNewChanger;
    public PRISM.Interactions.MinimalUIButtonView Button { get; set; }
    public PRISM.Interactions.ViewStateChanger IsUnreadChanger { get; set; }
    public PRISM.Interactions.ViewStateChanger IsNewChanger { get; set; }
}

// Namespace: PRISM.Interactions.Story
public class EpisodeZeroUnitSelectContentView : UnityEngine.MonoBehaviour, PRISM.Adapters.Story.IEpisodeZeroUnitSelectContentView
{
    private ENTERPRISE.UI.UITextMeshProUGUI readStoryCountText;
    private PRISM.Interactions.ButtonView showRewardListButton;
    private PRISM.Interactions.Story.EpisodeZeroUnitSelectCellView[] cells;
    private PRISM.UIAnimation cellAnimation;
    private PRISM.Interactions.ButtonView showHowToPlayButton;
    private PRISM.HowToPlayPopupOpener howToPlayPopupOpener;
    public System.IObservable<UniRx.Unit> OnShowHowToPlay { get; set; }
    public System.IObservable<UniRx.Unit> OnShowRewardList { get; set; }
    public System.IObservable<int> OnJumpToIdolPage { get; set; }
    public void Initialize(System.ValueTuple<int, int> readStoryCount, System.Collections.Generic.IReadOnlyDictionary<int, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IEpisodeZeroStoryStatus>> statusDictionary);
    public Cysharp.Threading.Tasks.UniTask OpenHowToPlayPopupAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TryFirstTimeOpenHowToPlayPopupAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask PlayAnimationAsync(System.Threading.CancellationToken ct);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Interactions.Story.EpisodeZeroUnitSelectCellView, System.IObservable<int>> <>9__11_0;
        public static System.Func<PRISM.Module.Networking.IEpisodeZeroStoryStatus, bool> <>9__12_0;
        public static System.Func<PRISM.Module.Networking.IEpisodeZeroStoryStatus, bool> <>9__12_1;
        private System.IObservable<int> <get_OnJumpToIdolPage>b__11_0(PRISM.Interactions.Story.EpisodeZeroUnitSelectCellView x);
        private bool <Initialize>b__12_0(PRISM.Module.Networking.IEpisodeZeroStoryStatus x);
        private bool <Initialize>b__12_1(PRISM.Module.Networking.IEpisodeZeroStoryStatus x);
    }
}

// Namespace: PRISM.Interactions.Story
public class EventStorySelectConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.Story.EventStorySelectArgument>, PRISM.Story.IEventStorySelectConnector
{
    protected PRISM.Adapters.Story.EventStorySelectArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
}

// Namespace: PRISM.Interactions.Story
public class EventStorySelectView : UnityEngine.MonoBehaviour, PRISM.Adapters.Story.IEventStorySelectView
{
    private UnityEngine.UI.Image bgImage;
    private ENTERPRISE.UI.UITextMeshProUGUI eventPeriodText;
    private UnityEngine.GameObject eventPointObject;
    private ENTERPRISE.UI.UITextMeshProUGUI eventPointText;
    private PRISM.Interactions.CommonTitleView viewTitle;
    private PRISM.Interactions.Story.StoryPlayableStoryCellScroller cellScroller;
    public PRISM.Adapters.Story.IStoryPlayableStoryCellScroller CellScroller { get; set; }
    public void SetViewTitle(int eventId);
    public void SetEventPeriodText(System.DateTime beginDate, System.DateTime endDate);
    public void ShowCurrentEventPoint(bool isActive, System.Nullable<long> currentEventPoint);
    public Cysharp.Threading.Tasks.UniTask InitializeBackgroundAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, int eventId, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask PlayEventBgmAsync(PRISM.Definitions.MstEvent eventMaster, System.Threading.CancellationToken ct);
}

// Namespace: PRISM.Interactions.Story
public class ExtraStorySelectConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.Story.ExtraStorySelectArgument>, PRISM.Story.IExtraStorySelectConnector
{
    protected PRISM.Adapters.Story.ExtraStorySelectArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
}

// Namespace: PRISM.Interactions.Story
public class ExtraStorySelectView : UnityEngine.MonoBehaviour, PRISM.Adapters.Story.IExtraStorySelectView
{
    private UnityEngine.UI.Image bgImage;
    private PRISM.Interactions.CommonTitleView viewTitle;
    private PRISM.Interactions.Story.StoryPlayableStoryCellScroller cellScroller;
    public PRISM.Adapters.Story.IStoryPlayableStoryCellScroller CellScroller { get; set; }
    public void SetViewTitle(string title);
    public Cysharp.Threading.Tasks.UniTask SetBackgroundImageAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, int subCategoryId, System.Threading.CancellationToken ct);
}

// Namespace: PRISM.Interactions.Story
public class ExtraStorySubcategorySelectConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.Story.ExtraStorySubcategorySelectArgument>, PRISM.Story.IExtraStorySubcategorySelectConnector
{
    protected PRISM.Adapters.Story.ExtraStorySubcategorySelectArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
}

// Namespace: PRISM.Interactions.Story
public class ExtraStorySubcategorySelectView : UnityEngine.MonoBehaviour, PRISM.Adapters.Story.IExtraStorySubcategorySelectView
{
    private PRISM.UI.UICharacterViewer uiCharacterViewer;
    private PRISM.UI.CenteringObjectsOutsideSafeArea characterPositionAdjuster;
    private PRISM.Interactions.CommonTitleView titleView;
    private PRISM.Interactions.Story.StoryCellScroller cellScroller;
    public System.IObservable<PRISM.Adapters.Story.IStoryCellViewModel> OnClickCell { get; set; }
    public float ScrollPosition { get; set; }
    public void InitializeCellScroller(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.Story.ExtraStorySubcategorySelectCellViewModel> cellViewModels, PRISM.ResourceManagement.IResourceLoader resourceLoader, float scrollPosition, UniRx.IReactiveProperty<bool> isUnreadFilterActive);
    public void SetViewTitle(string title);
    public Cysharp.Threading.Tasks.UniTask Initialize3dHazukiAsync(PRISM.UnitIdol unitIdol, PRISM.UI.UICharacterVoicePattern voicePattern, ScreenType screenType, string requiredMotionCueSheetName, System.Threading.CancellationToken ct);
    public void OnNextViewPreparation();
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();

    private struct <Initialize3dHazukiAsync>d__10 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Story.ExtraStorySubcategorySelectView <>4__this;
        public PRISM.UnitIdol unitIdol;
        public PRISM.UI.UICharacterVoicePattern voicePattern;
        public ScreenType screenType;
        public string requiredMotionCueSheetName;
        public System.Threading.CancellationToken ct;
        private Awaiter<bool> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Story
public class IdolSubStoryIdolSelectCell : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView button;
    private PRISM.Interactions.CharacterBaseIconView characterBaseIcon;
    protected UnityEngine.GameObject newBadge;
    protected UnityEngine.GameObject unreadBadge;
    private PRISM.UIGrayOutController uiGrayOutController;
    private UnityEngine.GameObject lockIcon;
    public System.IObservable<UniRx.Unit> OnClickCell { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.Story.IdolSubStoryIdolSelectCellViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
}

// Namespace: PRISM.Interactions.Story
public class IdolSubStoryIdolSelectCellGroup : PRISM.EnhancedListViewCell<PRISM.Adapters.Story.IStoryCellViewModel, PRISM.Interactions.Story.IdolSubStoryIdolSelectCellListViewContext>
{
    private PRISM.Interactions.Story.IdolSubStoryIdolSelectCell[] cells;
    private UnityEngine.UI.Image unitIconImage;
    private UniRx.CompositeDisposable disposables;
    private System.Threading.CancellationTokenSource cts;
    public void UpdateContent(PRISM.Adapters.Story.IStoryCellViewModel data);
    private void Awake();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Adapters.Story.IdolSubStoryIdolSelectCellViewModel, bool> <>9__4_0;
        private bool <UpdateContent>b__4_0(PRISM.Adapters.Story.IdolSubStoryIdolSelectCellViewModel x);
    }

    private class <>c__DisplayClass4_0
    {
        public PRISM.Adapters.Story.IdolSubStoryIdolSelectCellViewModel cellData;
        public PRISM.Interactions.Story.IdolSubStoryIdolSelectCellGroup <>4__this;
        private void <UpdateContent>b__1(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.Story
public class IdolSubStoryIdolSelectCellGroupScroller : PRISM.EnhancedListView<PRISM.Adapters.Story.IStoryCellViewModel, PRISM.Interactions.Story.IdolSubStoryIdolSelectCellListViewContext>, PRISM.Interactions.Story.IStoryCellScroller
{
    private ENTERPRISE.UI.UITextMeshProUGUI emptyViewText;
    private PRISM.Interactions.ToggleButtonView unreadFilterToggle;
    private UniRx.IReactiveProperty<bool> isUnreadFilterActive;
    private System.Collections.Generic.IReadOnlyList<PRISM.Adapters.Story.IStoryCellViewModel> currentAllCellViewModels;
    public float ScrollPosition { get; set; }
    public System.IObservable<PRISM.Adapters.Story.IdolSubStoryIdolSelectCellViewModel> OnClickCell { get; set; }
    public void Setup(PRISM.ResourceManagement.IResourceLoader resourceLoader, UniRx.IReactiveProperty<bool> isUnreadFilterActive, System.Action updateScrollerAction);
    public void UpdateScroller(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.Story.IStoryCellViewModel> cellViewModels, System.Nullable<float> scrollPosition);
    public void SetUnreadFilterActive(bool isActive);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Adapters.Story.IStoryCellViewModel, bool> <>9__9_0;
        private bool <UpdateScroller>b__9_0(PRISM.Adapters.Story.IStoryCellViewModel x);
    }

    private class <>c__DisplayClass8_0
    {
        public System.Action updateScrollerAction;
        private void <Setup>b__0(bool _);
    }
}

// Namespace: PRISM.Interactions.Story
public class IdolSubStoryIdolSelectCellListViewContext : PRISM.EnhancedListViewContext, System.IDisposable
{
    private UniRx.Subject<PRISM.Adapters.Story.IdolSubStoryIdolSelectCellViewModel> <OnClickCell>k__BackingField;
    private bool <IsUnreadFilterActive>k__BackingField;
    public UniRx.Subject<PRISM.Adapters.Story.IdolSubStoryIdolSelectCellViewModel> OnClickCell { get; set; }
    public bool IsUnreadFilterActive { get; set; }
    public void Dispose();
}

// Namespace: PRISM.Interactions.Story
public class IdolSubStoryIdolSelectConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.Story.IdolSubStoryIdolSelectArgument>, PRISM.Legacy.Story.IIdolSubStoryIdolSelectConnector
{
    protected PRISM.Adapters.Story.IdolSubStoryIdolSelectArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
}

// Namespace: PRISM.Interactions.Story
public class IdolSubStoryIdolSelectView : UnityEngine.MonoBehaviour, PRISM.Adapters.Story.IIdolSubStoryIdolSelectView
{
    private PRISM.UI.UICharacterViewer uiCharacterViewer;
    private PRISM.UI.CenteringObjectsOutsideSafeArea characterPositionAdjuster;
    private PRISM.Interactions.CommonTitleView titleView;
    private PRISM.Interactions.Story.IdolSubStoryIdolSelectCellGroupScroller scroller;
    public System.IObservable<PRISM.Adapters.Story.IdolSubStoryIdolSelectCellViewModel> OnClickCell { get; set; }
    public float ScrollPosition { get; set; }
    public void InitializeScroller(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.IdolSubStoryIdolSelectCellGroupViewModel> cellGroupViewModels, PRISM.ResourceManagement.IResourceLoader resourceLoader, float scrollPosition, UniRx.IReactiveProperty<bool> isUnreadFilterActive);
    public void SetViewTitle(string titleText);
    public Cysharp.Threading.Tasks.UniTask Initialize3dHazukiAsync(PRISM.UnitIdol unitIdol, PRISM.UI.UICharacterVoicePattern voicePattern, ScreenType screenType, string requiredMotionCueSheetName, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask ShowIdolStoryUnlockConditionPopupAsync(int idolId, int unlockDearness, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public void OnNextViewPreparation();
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();

    private class <>c__DisplayClass8_0
    {
        public System.Collections.Generic.IReadOnlyList<PRISM.Adapters.IdolSubStoryIdolSelectCellGroupViewModel> cellGroupViewModels;
        public PRISM.Interactions.Story.IdolSubStoryIdolSelectView <>4__this;
        public UniRx.IReactiveProperty<bool> isUnreadFilterActive;
        private void <InitializeScroller>b__0();
        private void <InitializeScroller>g___updateScroller|1(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.Story.IStoryCellViewModel> cellViewModels, System.Nullable<float> scrollPosition);
    }
}

// Namespace: PRISM.Interactions.Story
public class IdolSubStorySelectConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.Story.IdolSubStorySelectArgument>, PRISM.Story.IIdolSubStorySelectConnector
{
    protected PRISM.Adapters.Story.IdolSubStorySelectArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
}

// Namespace: PRISM.Interactions.Story
public class IdolSubStorySelectView : UnityEngine.MonoBehaviour, PRISM.Adapters.Story.IIdolSubStorySelectView
{
    private UnityEngine.UI.Image charaColorBg;
    private PRISM.UI.UICharacterViewer uiCharacterViewer;
    private PRISM.UI.CenteringObjectsOutsideSafeArea characterPositionAdjuster;
    private ENTERPRISE.UI.UITextMeshProUGUI dearnessText;
    private PRISM.Interactions.CommonTitleView titleView;
    private PRISM.Interactions.Story.StoryPlayableStoryCellScroller cellScroller;
    public PRISM.Adapters.Story.IStoryPlayableStoryCellScroller CellScroller { get; set; }
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    public void SetIdolDearnessText(int idolDearness);
    public void SetBackgroundColor(int idolId);
    public void SetViewTitle(int idolId);
    public Cysharp.Threading.Tasks.UniTask Initialize3dCharacterFromVoiceInfoAsync(PRISM.UI.UICharacterVoiceInfo voiceInfo, ScreenType screenType, System.Threading.CancellationToken ct);
    public void OnNextViewPreparation();

    private struct <Initialize3dCharacterFromVoiceInfoAsync>d__12 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Story.IdolSubStorySelectView <>4__this;
        public PRISM.UI.UICharacterVoiceInfo voiceInfo;
        public ScreenType screenType;
        public System.Threading.CancellationToken ct;
        private Awaiter<bool> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Story
public class StoryReadCountRewardCellGridView : PRISM.Interactions.GridView<PRISM.Interactions.Story.StoryReadCountRewardCellView, PRISM.Adapters.Story.StoryReadCountRewardCellViewModel>
{
    protected void SetupCellTemplate();

    private class CellGroup : DefaultCellGroup<PRISM.Adapters.Story.StoryReadCountRewardCellViewModel, PRISM.Interactions.GridViewContext>
    {
    }
}

// Namespace: PRISM.Interactions.Story
public class StoryReadCountRewardCellView : PRISM.Interactions.GridViewCell<PRISM.Adapters.Story.StoryReadCountRewardCellViewModel>
{
    private TMPro.TextMeshProUGUI episodeNumberText;
    private PRISM.Interactions.RewardItemIcon rewardItemIcon;
    private PRISM.Interactions.ViewStateChanger isAlreadyAcquiredChanger;
    private PRISM.AutoCancellationTokenSource canceller;
    public void UpdateContent(PRISM.Adapters.Story.StoryReadCountRewardCellViewModel itemData);
    private void OnDestroy();
}

// Namespace: PRISM.Interactions.Story
public class StoryReadCountRewardListPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.Story.IStoryReadCountRewardListPopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private ENTERPRISE.UI.UITextMeshProUGUI readCountText;
    private ENTERPRISE.UI.UITextMeshProUGUI descriptionText;
    private PRISM.Interactions.Story.StoryReadCountRewardCellGridView gridView;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Initialize(System.ValueTuple<int, int> storyReadCount, StoryType storyType, System.Collections.Generic.IReadOnlyList<PRISM.Adapters.Story.StoryReadCountRewardCellViewModel> cellViewModels, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__7_0();
    private void <CreateFrameParameter>b__7_1();
    private void <CreateFrameParameter>b__7_2();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Adapters.Story.StoryReadCountRewardCellViewModel, int, System.ValueTuple<PRISM.Adapters.Story.StoryReadCountRewardCellViewModel, int>> <>9__4_0;
        public static System.Func<System.ValueTuple<PRISM.Adapters.Story.StoryReadCountRewardCellViewModel, int>, bool> <>9__4_1;
        private System.ValueTuple<PRISM.Adapters.Story.StoryReadCountRewardCellViewModel, int> <Initialize>b__4_0(PRISM.Adapters.Story.StoryReadCountRewardCellViewModel x, int i);
        private bool <Initialize>b__4_1(System.ValueTuple<PRISM.Adapters.Story.StoryReadCountRewardCellViewModel, int> x);
    }
}

// Namespace: PRISM.Interactions.Story
public class StoryReceiveRewardPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IStoryReceiveRewardPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private ENTERPRISE.UI.UITextMeshProUGUI headerText;
    private ENTERPRISE.UI.UITextMeshProUGUI normalRewardItemAreaTitleText;
    private ENTERPRISE.UI.UITextMeshProUGUI storyReadCountRewardItemAreaTitleText;
    private UnityEngine.UI.ScrollRect scrollRect;
    private PRISM.Interactions.ReceiveRewardItem rewardItemPrefab;
    private UnityEngine.Transform normalRewardItemParent;
    private UnityEngine.Transform storyReadCountRewardItemParent;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Interactions.PopupFrameParameter popupFrameParameter;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Initialize(PRISM.Adapters.Story.StoryReceiveRewardPopupViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__12_0();
    private void <CreateFrameParameter>b__12_1();
}

// Namespace: PRISM.Interactions.Story
public class StorySearchPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.Story.IStorySearchPopupView, PRISM.Adapters.IClosablePopupFrame<PRISM.Definitions.SortFilterSettings>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<PRISM.Definitions.SortFilterSettings>
{
    private UnityEngine.Transform filterContentParent;
    private PRISM.Interactions.ButtonView resetFilterButton;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<PRISM.Definitions.SortFilterSettings> onClosed;
    private System.Collections.Generic.List<PRISM.Definitions.ReactiveHashSet<int>> reactiveFilterOnIds;
    private PRISM.Interactions.PopupFrameParameter frameParameter;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<PRISM.Definitions.SortFilterSettings> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(System.Collections.Generic.IEnumerable<PRISM.Definitions.FilterType> filterTypes, PRISM.Definitions.SortFilterSettings currentSettings, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <LoadAsync>b__9_2(int _);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Definitions.ReactiveHashSet<int>, bool> <>9__9_0;
        public static System.Func<PRISM.Definitions.ReactiveHashSet<int>, System.IObservable<int>> <>9__9_1;
        public static System.Func<PRISM.Definitions.ReactiveHashSet<int>, bool> <>9__9_3;
        private bool <LoadAsync>b__9_0(PRISM.Definitions.ReactiveHashSet<int> x);
        private System.IObservable<int> <LoadAsync>b__9_1(PRISM.Definitions.ReactiveHashSet<int> x);
        private bool <LoadAsync>b__9_3(PRISM.Definitions.ReactiveHashSet<int> x);
    }

    private class <>c__DisplayClass8_0
    {
        public PRISM.Interactions.Story.StorySearchPopupView <>4__this;
        public PRISM.Definitions.SortType initialSortType;
        public PRISM.Definitions.SortDirection initialSortDirection;
        public System.Collections.Generic.Dictionary<PRISM.Definitions.FilterType, System.Collections.Generic.ISet<int>> filterOnIds;
        private void <InitializeAsync>b__0(UniRx.Unit _);
        private void <InitializeAsync>b__1();
        private void <InitializeAsync>b__2();
        private void <InitializeAsync>b__3();
    }

    private struct <InitializeAsync>d__8 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Story.StorySearchPopupView <>4__this;
        public PRISM.Definitions.SortFilterSettings currentSettings;
        public System.Collections.Generic.IEnumerable<PRISM.Definitions.FilterType> filterTypes;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        private <>c__DisplayClass8_0 <>8__1;
        private System.Collections.Generic.IEnumerator<PRISM.Definitions.FilterType> <>7__wrap1;
        private PRISM.Definitions.FilterType <filterType>5__3;
        private Awaiter<PRISM.Interactions.FilterToggleGroupViewFactory> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <LoadAsync>d__9 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
        public PRISM.Interactions.Story.StorySearchPopupView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter<bool> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Story
public class ProduceIdolScenarioSelectConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.Story.ProduceIdolScenarioSelectArgument>, PRISM.Story.IProduceIdolScenarioSelectConnector
{
    protected PRISM.Adapters.Story.ProduceIdolScenarioSelectArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
}

// Namespace: PRISM.Interactions.Story
public class ProduceIdolScenarioSelectView : UnityEngine.MonoBehaviour, PRISM.Adapters.Story.IProduceIdolScenarioSelectView
{
    private PRISM.Interactions.CommonTitleView viewTitle;
    private UnityEngine.Transform idolPos;
    private PRISM.Interactions.Story.StoryPlayableStoryCellScroller cellScroller;
    private PRISM.Interactions.ButtonView upgradingButton;
    public PRISM.Adapters.Story.IStoryPlayableStoryCellScroller CellScroller { get; set; }
    public System.IObservable<UniRx.Unit> OnClickUpgradingButton { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(int mstProduceIdolId, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);

    private struct <InitializeAsync>d__8 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public int mstProduceIdolId;
        public PRISM.Interactions.Story.ProduceIdolScenarioSelectView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        private Awaiter<UnityEngine.GameObject> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Story
public class ProduceIdolScenarioIdolSelectCell : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ProduceIdolIconView produceIdolIconView;
    private PRISM.Interactions.ButtonView cellButton;
    protected UnityEngine.GameObject newBadge;
    protected UnityEngine.GameObject unreadBadge;
    public System.IObservable<UniRx.Unit> OnClick { get; set; }
    public System.IObservable<UniRx.Unit> OnLongPress { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.Story.ProduceIdolScenarioIdolSelectCellViewModel cellViewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
}

// Namespace: PRISM.Interactions.Story
public class ProduceIdolScenarioIdolSelectCellGroup : PRISM.EnhancedListViewCell<PRISM.Adapters.Story.IStoryCellViewModel[], PRISM.Interactions.Story.ProduceIdolScenarioIdolSelectCellScrollerContext>
{
    private PRISM.Interactions.Story.ProduceIdolScenarioIdolSelectCell[] cells;
    private UniRx.CompositeDisposable disposables;
    private PRISM.AutoCancellationTokenSource canceller;
    public void UpdateContent(PRISM.Adapters.Story.IStoryCellViewModel[] cellViewModels);
    private void OnDestroy();

    private class <>c__DisplayClass3_0
    {
        public PRISM.Adapters.Story.ProduceIdolScenarioIdolSelectCellViewModel cellViewModel;
        public PRISM.Interactions.Story.ProduceIdolScenarioIdolSelectCellGroup <>4__this;
        private void <UpdateContent>b__0(UniRx.Unit _);
        private void <UpdateContent>b__1(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.Story
public class ProduceIdolScenarioIdolSelectCellScroller : PRISM.EnhancedListView<PRISM.Adapters.Story.IStoryCellViewModel[], PRISM.Interactions.Story.ProduceIdolScenarioIdolSelectCellScrollerContext>
{
    private int cellGroupElementCount;
    private PRISM.Interactions.ToggleButtonView unreadFilterToggle;
    private ENTERPRISE.UI.UITextMeshProUGUI emptyViewText;
    private UniRx.IReactiveProperty<bool> isUnreadFilterActive;
    private System.Collections.Generic.IReadOnlyList<PRISM.Adapters.Story.IStoryCellViewModel> currentAllCellViewModels;
    public System.IObservable<PRISM.Adapters.Story.ProduceIdolScenarioIdolSelectCellViewModel> OnClickCell { get; set; }
    public System.IObservable<PRISM.Adapters.Story.ProduceIdolScenarioIdolSelectCellViewModel> OnLongPressCell { get; set; }
    public float ScrollPosition { get; set; }
    public void Setup(PRISM.ResourceManagement.IResourceLoader resourceLoader, UniRx.IReactiveProperty<bool> isUnreadFilterActive);
    public void UpdateScroller(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.Story.IStoryCellViewModel> cellViewModels, System.Nullable<float> scrollPosition);
    private System.Collections.Generic.IEnumerable<PRISM.Adapters.Story.IStoryCellViewModel[]> _chunkCellViewModels(System.Collections.Generic.IEnumerable<PRISM.Adapters.Story.IStoryCellViewModel> cellViewModels);
    private void <Setup>b__11_0(bool _);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Adapters.Story.IStoryCellViewModel, bool> <>9__12_0;
        public static System.Func<System.Collections.Generic.IEnumerable<PRISM.Adapters.Story.IStoryCellViewModel>, PRISM.Adapters.Story.IStoryCellViewModel[]> <>9__13_0;
        private bool <UpdateScroller>b__12_0(PRISM.Adapters.Story.IStoryCellViewModel x);
        private PRISM.Adapters.Story.IStoryCellViewModel[] <_chunkCellViewModels>b__13_0(System.Collections.Generic.IEnumerable<PRISM.Adapters.Story.IStoryCellViewModel> x);
    }
}

// Namespace: PRISM.Interactions.Story
public class ProduceIdolScenarioIdolSelectCellScrollerContext : PRISM.EnhancedListViewContext, System.IDisposable
{
    private UniRx.Subject<PRISM.Adapters.Story.ProduceIdolScenarioIdolSelectCellViewModel> <OnClickCell>k__BackingField;
    private UniRx.Subject<PRISM.Adapters.Story.ProduceIdolScenarioIdolSelectCellViewModel> <OnLongPressCell>k__BackingField;
    public UniRx.Subject<PRISM.Adapters.Story.ProduceIdolScenarioIdolSelectCellViewModel> OnClickCell { get; set; }
    public UniRx.Subject<PRISM.Adapters.Story.ProduceIdolScenarioIdolSelectCellViewModel> OnLongPressCell { get; set; }
    public void Dispose();
}

// Namespace: PRISM.Interactions.Story
public class ProduceIdolScenarioIdolSelectConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.Story.ProduceIdolScenarioIdolSelectArgument>, PRISM.Story.IProduceIdolScenarioIdolSelectConnector
{
    protected PRISM.Adapters.Story.ProduceIdolScenarioIdolSelectArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
}

// Namespace: PRISM.Interactions.Story
public class ProduceScenarioIdolSelectView : UnityEngine.MonoBehaviour, PRISM.Adapters.Story.IProduceIdolScenarioIdolSelectView
{
    private PRISM.Interactions.CommonTitleView titleView;
    private PRISM.Interactions.Story.ProduceIdolScenarioIdolSelectCellScroller scroller;
    private PRISM.Interactions.FilterOnlyView filterOnlyView;
    private PRISM.UI.UICharacterViewer uiCharacterViewer;
    private PRISM.UI.CenteringObjectsOutsideSafeArea characterPositionAdjuster;
    public float ScrollPosition { get; set; }
    public PRISM.Adapters.ISortFilterView SortFilterView { get; set; }
    public System.IObservable<PRISM.Adapters.Story.ProduceIdolScenarioIdolSelectCellViewModel> OnClickCell { get; set; }
    public System.IObservable<PRISM.Adapters.Story.ProduceIdolScenarioIdolSelectCellViewModel> OnLongPressCell { get; set; }
    public void Initialize(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.Story.ProduceIdolScenarioIdolSelectCellViewModel> cellViewModels, PRISM.ResourceManagement.IResourceLoader resourceLoader, float scrollPosition, UniRx.IReactiveProperty<bool> isUnreadFilterActive);
    public Cysharp.Threading.Tasks.UniTask Initialize3dHazukiAsync(PRISM.UnitIdol unitIdol, PRISM.UI.UICharacterVoicePattern voicePattern, ScreenType screenType, string requiredMotionCueSheetName, System.Threading.CancellationToken ct);
    public void UpdateScroller(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.Story.ProduceIdolScenarioIdolSelectCellViewModel> cellViewModels);
    public void OnNextViewPreparation();
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();

    private struct <Initialize3dHazukiAsync>d__14 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Story.ProduceScenarioIdolSelectView <>4__this;
        public PRISM.UnitIdol unitIdol;
        public PRISM.UI.UICharacterVoicePattern voicePattern;
        public ScreenType screenType;
        public string requiredMotionCueSheetName;
        public System.Threading.CancellationToken ct;
        private Awaiter<bool> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Story
public class ProduceMainScenarioEpisodeSelectConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.Story.ProduceMainScenarioEpisodeSelectArgument>, PRISM.Legacy.Story.IProduceMainScenarioEpisodeSelectConnector
{
    protected PRISM.Adapters.Story.ProduceMainScenarioEpisodeSelectArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
}

// Namespace: PRISM.Interactions.Story
public class ProduceMainScenarioEpisodeSelectView : UnityEngine.MonoBehaviour, PRISM.Adapters.Story.IProduceMainScenarioEpisodeSelectView
{
    private PRISM.UI.UICharacterViewer uiCharacterViewer;
    private PRISM.UI.CenteringObjectsOutsideSafeArea characterPositionAdjuster;
    private PRISM.Interactions.CommonTitleView titleView;
    private PRISM.Interactions.Story.StoryCellScroller cellScroller;
    public System.IObservable<PRISM.Adapters.Story.IStoryCellViewModel> OnClickCell { get; set; }
    public float ScrollPosition { get; set; }
    public void InitializeCellScroller(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.Story.ProduceMainScenarioEpisodeSelectCellViewModel> cellViewModels, PRISM.ResourceManagement.IResourceLoader resourceLoader, float scrollPosition, UniRx.IReactiveProperty<bool> isUnreadFilterActive);
    public void SetViewTitle(string title);
    public Cysharp.Threading.Tasks.UniTask Initialize3dHazukiAsync(PRISM.UnitIdol unitIdol, PRISM.UI.UICharacterVoicePattern voicePattern, ScreenType screenType, string requiredMotionCueSheetName, System.Threading.CancellationToken ct);
    public void OnNextViewPreparation();
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
}

// Namespace: PRISM.Interactions.Story
public class ProduceMainScenarioSelectConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.Story.ProduceMainScenarioSelectArgument>, PRISM.Legacy.Story.IProduceMainScenarioSelectConnector
{
    protected PRISM.Adapters.Story.ProduceMainScenarioSelectArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
}

// Namespace: PRISM.Interactions.Story
public class ProduceMainScenarioSelectView : UnityEngine.MonoBehaviour, PRISM.Adapters.Story.IProduceMainScenarioSelectView
{
    private PRISM.Interactions.Story.StoryPlayableStoryCellScroller cellScroller;
    private UnityEngine.UI.Image backgroundImage;
    public PRISM.Adapters.Story.IStoryPlayableStoryCellScroller CellScroller { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeBackgroundAsync(string backgroundImageKey, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
}

// Namespace: PRISM.Interactions.Story
public class EnhancedStoryCellView : PRISM.EnhancedListViewCell<PRISM.Adapters.Story.IStoryCellViewModel, PRISM.Interactions.Story.StoryCellScrollerContext>
{
    private PRISM.Interactions.Story.StoryCellView cellView;
    private UniRx.CompositeDisposable disposables;
    private System.Threading.CancellationTokenSource cts;
    public void UpdateContent(PRISM.Adapters.Story.IStoryCellViewModel viewModel);
    private void Awake();

    private class <>c__DisplayClass3_0
    {
        public PRISM.Interactions.Story.EnhancedStoryCellView <>4__this;
        public PRISM.Adapters.Story.IStoryCellViewModel viewModel;
        private void <UpdateContent>b__0(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.Story
public interface IStoryCellScroller
{
    public void UpdateScroller(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.Story.IStoryCellViewModel> cellViewModels, System.Nullable<float> scrollPosition);
}

// Namespace: PRISM.Interactions.Story
public class StoryCellScroller : PRISM.EnhancedListView<PRISM.Adapters.Story.IStoryCellViewModel, PRISM.Interactions.Story.StoryCellScrollerContext>, PRISM.Interactions.Story.IStoryCellScroller
{
    private ENTERPRISE.UI.UITextMeshProUGUI emptyViewText;
    private PRISM.Interactions.Story.EnhancedStoryCellView storyCell;
    private PRISM.Interactions.ToggleButtonView unreadFilterToggle;
    private UniRx.IReactiveProperty<bool> isUnreadFilterActive;
    private System.Collections.Generic.IReadOnlyList<PRISM.Adapters.Story.IStoryCellViewModel> currentAllCellViewModels;
    public System.IObservable<PRISM.Adapters.Story.IStoryCellViewModel> OnClickCell { get; set; }
    public float ScrollPosition { get; set; }
    public void Setup(PRISM.ResourceManagement.IResourceLoader resourceLoader, UniRx.IReactiveProperty<bool> isUnreadFilterActive);
    public void UpdateScroller(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.Story.IStoryCellViewModel> cellViewModels, System.Nullable<float> scrollPosition);
    public void SetEmptyViewText(string value);
    public float GetCellViewSize(EnhancedUI.EnhancedScroller.EnhancedScroller _, int dataIndex);
    public EnhancedUI.EnhancedScroller.EnhancedScrollerCellView GetCellView(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex, int cellIndex);
    private void <Setup>b__9_0(bool _);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Adapters.Story.IStoryCellViewModel, bool> <>9__10_0;
        private bool <UpdateScroller>b__10_0(PRISM.Adapters.Story.IStoryCellViewModel x);
    }
}

// Namespace: PRISM.Interactions.Story
public class StoryCellScrollerContext : PRISM.EnhancedListViewContext, System.IDisposable
{
    private UniRx.Subject<PRISM.Adapters.Story.IStoryCellViewModel> <OnClickCell>k__BackingField;
    public UniRx.Subject<PRISM.Adapters.Story.IStoryCellViewModel> OnClickCell { get; set; }
    public void Dispose();
}

// Namespace: PRISM.Interactions.Story
public class StoryCellView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.Story.StoryCellBaseView baseView;
    private UnityEngine.UI.Image thumbnailImage;
    private UnityEngine.UI.Image logoImage;
    public System.IObservable<UniRx.Unit> OnClick { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.Story.IStoryCellViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
}

// Namespace: PRISM.Interactions.Story
public class StoryCellBaseView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView button;
    private ENTERPRISE.UI.UITextMeshProUGUI mainTitle;
    private ENTERPRISE.UI.UITextMeshProUGUI mainTitleFront;
    private ENTERPRISE.UI.UITextMeshProUGUI subTitle;
    private PRISM.Interactions.ViewStateChanger newBadgeChanger;
    private PRISM.Interactions.ViewStateChanger unreadBadgeChanger;
    private PRISM.Interactions.ViewStateChanger lockChanger;
    private ENTERPRISE.UI.UITextMeshProUGUI lockText;
    public System.IObservable<UniRx.Unit> OnClick { get; set; }
    public void Initialize(PRISM.Adapters.Story.StoryCellBaseViewModel viewModel);
}

// Namespace: PRISM.Interactions.Story
public class EnhancedEveryStoryReadNotionCellView : PRISM.EnhancedListViewCell<PRISM.Adapters.Story.IStoryPlayableStoryCellViewModel, PRISM.Interactions.Story.StoryPlayableStoryCellScrollerContext>
{
}

// Namespace: PRISM.Interactions.Story
public class EnhancedStoryPlayableStoryCellView : PRISM.EnhancedListViewCell<PRISM.Adapters.Story.IStoryPlayableStoryCellViewModel, PRISM.Interactions.Story.StoryPlayableStoryCellScrollerContext>
{
    private PRISM.Interactions.Story.StoryPlayableStoryCellView cellView;
    private UniRx.CompositeDisposable disposables;
    private System.Threading.CancellationTokenSource cts;
    public void UpdateContent(PRISM.Adapters.Story.IStoryPlayableStoryCellViewModel viewModel);
    private void Awake();

    private class <>c__DisplayClass3_0
    {
        public PRISM.Interactions.Story.EnhancedStoryPlayableStoryCellView <>4__this;
        public PRISM.Adapters.Story.IStoryPlayableStoryCellViewModel viewModel;
        private void <UpdateContent>b__0(UniRx.Unit _);
        private void <UpdateContent>b__1(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.Story
public class StoryPlayableStoryCellScroller : PRISM.EnhancedListView<PRISM.Adapters.Story.IStoryPlayableStoryCellViewModel, PRISM.Interactions.Story.StoryPlayableStoryCellScrollerContext>, PRISM.Adapters.Story.IStoryPlayableStoryCellScroller
{
    private ENTERPRISE.UI.UITextMeshProUGUI emptyViewText;
    private PRISM.Interactions.Story.EnhancedEveryStoryReadNotionCellView everyStoryReadNotionCell;
    private PRISM.Interactions.Story.EnhancedStoryPlayableStoryCellView storyCell;
    private PRISM.Interactions.ToggleButtonView unreadFilterToggleView;
    private UniRx.IReactiveProperty<bool> isUnreadFilterActive;
    private System.Collections.Generic.IReadOnlyList<PRISM.Adapters.Story.IStoryPlayableStoryCellViewModel> currentAllCellViewModels;
    private bool showAllStoryReadNotion;
    public System.IObservable<PRISM.Adapters.Story.IStoryPlayableStoryCellViewModel> OnClickCell { get; set; }
    public UniRx.Subject<PRISM.Adapters.Story.IStoryPlayableStoryCellViewModel> OnClickFavoriteButton { get; set; }
    public float ScrollPosition { get; set; }
    public void Setup(PRISM.ResourceManagement.IResourceLoader resourceLoader, UniRx.IReactiveProperty<bool> isUnreadFilterActive, bool showEveryStoryReadNotion, System.Action updateScrollerAction);
    public void UpdateScroller(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.Story.IStoryPlayableStoryCellViewModel> cellViewModels, System.Nullable<float> scrollPosition);
    public void ReloadScroller();
    public void SetEmptyViewText(string value);
    public float GetCellViewSize(EnhancedUI.EnhancedScroller.EnhancedScroller _, int dataIndex);
    public EnhancedUI.EnhancedScroller.EnhancedScrollerCellView GetCellView(EnhancedUI.EnhancedScroller.EnhancedScroller _, int dataIndex, int cellIndex);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Adapters.Story.IStoryPlayableStoryCellViewModel, bool> <>9__14_0;
        private bool <UpdateScroller>b__14_0(PRISM.Adapters.Story.IStoryPlayableStoryCellViewModel x);
    }

    private class <>c__DisplayClass13_0
    {
        public PRISM.Interactions.Story.StoryPlayableStoryCellScroller <>4__this;
        public System.Action updateScrollerAction;
        private void <Setup>b__0();
        private void <Setup>b__1(bool _);
    }
}

// Namespace: PRISM.Interactions.Story
public class StoryPlayableStoryCellScrollerContext : PRISM.EnhancedListViewContext, System.IDisposable
{
    private UniRx.Subject<PRISM.Adapters.Story.IStoryPlayableStoryCellViewModel> <OnClickCell>k__BackingField;
    private UniRx.Subject<PRISM.Adapters.Story.IStoryPlayableStoryCellViewModel> <OnClickFavoriteButton>k__BackingField;
    public UniRx.Subject<PRISM.Adapters.Story.IStoryPlayableStoryCellViewModel> OnClickCell { get; set; }
    public UniRx.Subject<PRISM.Adapters.Story.IStoryPlayableStoryCellViewModel> OnClickFavoriteButton { get; set; }
    public void Dispose();
}

// Namespace: PRISM.Interactions.Story
public class StoryPlayableStoryCellView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.Story.StoryCellBaseView baseView;
    private PRISM.Interactions.StoryThumbnailView thumbnailView;
    private PRISM.Interactions.Story.StoryCategoryTypeLabelView categoryTypeLabelView;
    private PRISM.Interactions.ViewStateChanger showCategoryLabelChanger;
    private PRISM.Interactions.ButtonView favoriteButton;
    private PRISM.Interactions.ViewStateChanger favoriteButtonChanger;
    private PRISM.Interactions.Story.StoryRewardItemIcon storyRewardItemIconPrefab;
    private UnityEngine.Transform rewardItemIconPos;
    private UnityEngine.Pool.ObjectPool<PRISM.Interactions.Story.StoryRewardItemIcon> rewardIconPool;
    private System.Collections.Generic.List<PRISM.Interactions.Story.StoryRewardItemIcon> activeRewardIcons;
    public System.IObservable<UniRx.Unit> OnClick { get; set; }
    public System.IObservable<UniRx.Unit> OnClickFavoriteButton { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.Story.IStoryPlayableStoryCellViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    private void Awake();
    private PRISM.Interactions.Story.StoryRewardItemIcon <Awake>b__15_0();
    private void <Awake>b__15_1(PRISM.Interactions.Story.StoryRewardItemIcon target);

    private class <>c
    {
        public static <>c <>9;
        public static System.Action<PRISM.Interactions.Story.StoryRewardItemIcon> <>9__15_2;
        public static System.Action<PRISM.Interactions.Story.StoryRewardItemIcon> <>9__15_3;
        private void <Awake>b__15_2(PRISM.Interactions.Story.StoryRewardItemIcon target);
        private void <Awake>b__15_3(PRISM.Interactions.Story.StoryRewardItemIcon target);
    }
}

// Namespace: PRISM.Interactions.Story
public class StoryCharacterFilterToggleButtonView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.FilterToggleButtonView toggle;
    private PRISM.Interactions.ButtonView button;
    private PRISM.Interactions.CharacterBaseIconView characterBaseIcon;
    public PRISM.Interactions.FilterToggleButtonView FilterToggleButton { get; set; }
    public void Initialize(PRISM.ResourceManagement.IResourceLoader resourceLoader, int mstCharacterInfoId, System.Threading.CancellationToken ct);
    public void SetInteractable(bool value);
}

// Namespace: PRISM.Interactions.Story
public class StoryCharacterFilterToggleButtonViewContainer : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.Image unitIconImage;
    private PRISM.Interactions.Story.StoryCharacterFilterToggleButtonView togglePrefab;
    private System.Collections.Generic.IReadOnlyList<PRISM.Interactions.Story.StoryCharacterFilterToggleButtonView> <FilterToggleButtons>k__BackingField;
    public System.Collections.Generic.IReadOnlyList<PRISM.Interactions.Story.StoryCharacterFilterToggleButtonView> FilterToggleButtons { get; set; }
    public void Initialize(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Definitions.MstUnit mstUnit, System.Collections.Generic.IEnumerable<int> mstCharacterInfoIds, System.Threading.CancellationToken ct);

    private class <>c__DisplayClass6_0
    {
        public PRISM.Interactions.Story.StoryCharacterFilterToggleButtonViewContainer <>4__this;
        public UnityEngine.Transform toggleParent;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        private PRISM.Interactions.Story.StoryCharacterFilterToggleButtonView <Initialize>b__0(int id);
    }
}

// Namespace: PRISM.Interactions.Story
public class StoryCharacterFilterToggleGroupView : PRISM.Interactions.FilterToggleGroupView
{
    private int maxSelectCount;
    private PRISM.Interactions.Story.StoryCharacterFilterToggleButtonViewContainer storyCharacterFilterToggleContainerPrefab;
    private PRISM.Interactions.ButtonView resetSelectButton;
    public void Initialize(PRISM.Definitions.IReactiveHashSet<int> onIds, PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Adapters.IFilterToggleGroupViewOption option, System.Threading.CancellationToken cancellationToken);
    private System.Collections.Generic.IEnumerable<PRISM.Interactions.Story.StoryCharacterFilterToggleButtonViewContainer> _createContainers(PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    private void _switchInteractableStatus(PRISM.Definitions.IReactiveHashSet<int> onIds, System.Collections.Generic.IReadOnlyList<PRISM.Interactions.Story.StoryCharacterFilterToggleButtonView> storyCharacterFilterToggles, int selectedCount);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Interactions.Story.StoryCharacterFilterToggleButtonViewContainer, System.Collections.Generic.IEnumerable<PRISM.Interactions.Story.StoryCharacterFilterToggleButtonView>> <>9__3_0;
        public static System.Func<PRISM.Interactions.Story.StoryCharacterFilterToggleButtonView, PRISM.Interactions.FilterToggleButtonView> <>9__3_1;
        public static System.Func<PRISM.Definitions.MstCharacterInfo, PRISM.Definitions.MstUnit> <>9__4_0;
        public static System.Func<System.Linq.IGrouping<PRISM.Definitions.MstUnit, PRISM.Definitions.MstCharacterInfo>, bool> <>9__4_1;
        public static System.Func<PRISM.Definitions.MstCharacterInfo, int> <>9__4_2;
        private System.Collections.Generic.IEnumerable<PRISM.Interactions.Story.StoryCharacterFilterToggleButtonView> <Initialize>b__3_0(PRISM.Interactions.Story.StoryCharacterFilterToggleButtonViewContainer x);
        private PRISM.Interactions.FilterToggleButtonView <Initialize>b__3_1(PRISM.Interactions.Story.StoryCharacterFilterToggleButtonView x);
        private PRISM.Definitions.MstUnit <_createContainers>b__4_0(PRISM.Definitions.MstCharacterInfo x);
        private bool <_createContainers>b__4_1(System.Linq.IGrouping<PRISM.Definitions.MstUnit, PRISM.Definitions.MstCharacterInfo> x);
        private int <_createContainers>b__4_2(PRISM.Definitions.MstCharacterInfo x);
    }

    private class <>c__DisplayClass3_0
    {
        public PRISM.Definitions.IReactiveHashSet<int> onIds;
        public PRISM.Interactions.Story.StoryCharacterFilterToggleGroupView <>4__this;
        public PRISM.Interactions.Story.StoryCharacterFilterToggleButtonView[] storyCharacterFilterToggles;
        private void <Initialize>b__2(UniRx.Unit _);
        private void <Initialize>b__3(int count);
    }

    private class <>c__DisplayClass5_0
    {
        public PRISM.Definitions.IReactiveHashSet<int> onIds;
        public System.Func<PRISM.Interactions.Story.StoryCharacterFilterToggleButtonView, bool> <>9__0;
        private bool <_switchInteractableStatus>b__0(PRISM.Interactions.Story.StoryCharacterFilterToggleButtonView x);
    }

    private class <_createContainers>d__4 : System.Collections.Generic.IEnumerable<PRISM.Interactions.Story.StoryCharacterFilterToggleButtonViewContainer>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<PRISM.Interactions.Story.StoryCharacterFilterToggleButtonViewContainer>, System.Collections.IEnumerator, System.IDisposable
    {
        private int <>1__state;
        private PRISM.Interactions.Story.StoryCharacterFilterToggleButtonViewContainer <>2__current;
        private int <>l__initialThreadId;
        public PRISM.Interactions.Story.StoryCharacterFilterToggleGroupView <>4__this;
        private PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public PRISM.ResourceManagement.IResourceLoader <>3__resourceLoader;
        private System.Threading.CancellationToken ct;
        public System.Threading.CancellationToken <>3__ct;
        private UnityEngine.Transform <containerParent>5__2;
        private System.Collections.Generic.IEnumerator<System.Linq.IGrouping<PRISM.Definitions.MstUnit, PRISM.Definitions.MstCharacterInfo>> <>7__wrap2;
        private PRISM.Interactions.Story.StoryCharacterFilterToggleButtonViewContainer System.Collections.Generic.IEnumerator<PRISM.Interactions.Story.StoryCharacterFilterToggleButtonViewContainer>.Current { get; set; }
        private object System.Collections.IEnumerator.Current { get; set; }
        private void System.IDisposable.Dispose();
        private bool MoveNext();
        private void <>m__Finally1();
        private void System.Collections.IEnumerator.Reset();
        private System.Collections.Generic.IEnumerator<PRISM.Interactions.Story.StoryCharacterFilterToggleButtonViewContainer> System.Collections.Generic.IEnumerable<PRISM.Interactions.Story.StoryCharacterFilterToggleButtonViewContainer>.GetEnumerator();
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
    }
}

// Namespace: PRISM.Interactions.Story
public class StoryContinuousPlayConfirmationPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.Story.IStoryContinuousPlayConfirmationPopupView, PRISM.Adapters.IClosablePopupFrame<PRISM.Adapters.Story.StoryContinuousPlayConfirmationPopupResult>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<PRISM.Adapters.Story.StoryContinuousPlayConfirmationPopupResult>
{
    private PRISM.Interactions.NewStoryCellView cell;
    private ENTERPRISE.UI.UITextMeshProUGUI mainText;
    private PRISM.Interactions.ViewStateChanger needDownloadChanger;
    private ENTERPRISE.UI.UITextMeshProUGUI downloadSizeText;
    private ENTERPRISE.UI.UITextMeshProUGUI downloadRecommendationText;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<PRISM.Adapters.Story.StoryContinuousPlayConfirmationPopupResult> onCloseRequested;
    private PRISM.Interactions.PopupFrameParameter popupFrameParameter;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<PRISM.Adapters.Story.StoryContinuousPlayConfirmationPopupResult> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.NewStoryCellViewModel storyCellViewModel, bool isVoicePlayActive, PRISM.Adapters.Story.IStorySize storySize, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    private PRISM.Interactions.PopupFrameParameter _createPopupFrameParameter(bool isVoicePlayActive);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();

    private class <>c__DisplayClass11_0
    {
        public PRISM.Interactions.Story.StoryContinuousPlayConfirmationPopupView <>4__this;
        public bool isVoicePlayActive;
        private void <_createPopupFrameParameter>b__0();
        private void <_createPopupFrameParameter>b__1();
        private void <_createPopupFrameParameter>b__2();
    }
}

// Namespace: PRISM.Interactions.Story
public class StoryPlayConfirmationPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.Story.IStoryPlayConfirmationPopupView, PRISM.Adapters.IClosablePopupFrame<PRISM.Adapters.Story.StoryPlayConfirmationPopupResult>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<PRISM.Adapters.Story.StoryPlayConfirmationPopupResult>
{
    private PRISM.Interactions.ToggleGroupView playTypeToggleGroup;
    private ENTERPRISE.UI.UITextMeshProUGUI withVoiceText;
    private ENTERPRISE.UI.UITextMeshProUGUI noVoiceText;
    private UnityEngine.GameObject downloadRecommendation;
    private PRISM.Interactions.ToggleButtonView needSkipConfirmationFromNextTimeToggle;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<PRISM.Adapters.Story.StoryPlayConfirmationPopupResult> onCloseRequested;
    private UniRx.ReactiveProperty<int> playTypeIndex;
    private UniRx.ReactiveProperty<bool> needSkipConfirmationFromNextTime;
    private PRISM.Adapters.Story.IStorySize storySize;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<PRISM.Adapters.Story.StoryPlayConfirmationPopupResult> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Inject(PRISM.Adapters.Story.IStorySize storySize);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    private void _initialize();
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    private void <CreateFrameParameter>b__12_0();
    private void <CreateFrameParameter>b__12_1();
    private void <CreateFrameParameter>b__12_2();
}

// Namespace: PRISM.Interactions.Story
public class StoryTopEpisodeZeroContentView : UnityEngine.MonoBehaviour, PRISM.Adapters.Story.IStoryTopEpisodeZeroContentView, PRISM.Adapters.Story.IStoryTopContentView
{
    private PRISM.Interactions.Story.EpisodeZeroUnitSelectContentView unitSelectContentView;
    private PRISM.AutoCancellationTokenSource canceller;
    public PRISM.Adapters.Story.IEpisodeZeroUnitSelectContentView UnitSelectContentView { get; set; }
    public float ScrollPosition { get; set; }
    public void SetActive(bool isActive);
    private void OnDestroy();
}

// Namespace: PRISM.Interactions.Story
public class EventStoryEventSelectCell : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UIButton cellButton;
    private UnityEngine.UI.Image thumbnailImage;
    private UnityEngine.GameObject newBadge;
    private UnityEngine.GameObject unreadBadge;
    private ENTERPRISE.UI.UITextMeshProUGUI periodText;
    public System.IObservable<UniRx.Unit> OnClick { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.Story.EventStoryEventSelectCellViewModel cellViewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);

    private struct <InitializeAsync>d__7 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public PRISM.Adapters.Story.EventStoryEventSelectCellViewModel cellViewModel;
        public System.Threading.CancellationToken ct;
        public PRISM.Interactions.Story.EventStoryEventSelectCell <>4__this;
        private ENTERPRISE.Localization.LocalizationManager <localizationManager>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Story
public class EventStoryEventSelectCellGridScroller : PRISM.EnhancedListView<PRISM.Adapters.Story.IStoryCellViewModel[], PRISM.Interactions.Story.StoryTopCellListViewContext<PRISM.Adapters.Story.EventStoryEventSelectCellViewModel>>, PRISM.Interactions.Story.IStoryCellScroller
{
    private int cellCount;
    private ENTERPRISE.UI.UITextMeshProUGUI emptyViewText;
    private PRISM.Interactions.ToggleButtonView unreadFilterToggle;
    private UniRx.IReactiveProperty<bool> isUnreadFilterActive;
    private UniRx.IReactiveProperty<int> selectedUnitId;
    private System.Collections.Generic.IReadOnlyList<PRISM.Adapters.Story.EventStoryEventSelectCellViewModel> currentAllCellViewModels;
    public float ScrollPosition { get; set; }
    public System.IObservable<PRISM.Adapters.Story.EventStoryEventSelectCellViewModel> OnClickCell { get; set; }
    public void Setup(PRISM.ResourceManagement.IResourceLoader resourceLoader, UniRx.IReactiveProperty<bool> isUnreadFilterActive, UniRx.IReactiveProperty<int> selectedUnitTabFilterId, float firstScrollPosition);
    public void UpdateScroller(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.Story.IStoryCellViewModel> cellViewModels, System.Nullable<float> scrollPosition);
    private System.Collections.Generic.IReadOnlyList<PRISM.Adapters.Story.IStoryCellViewModel[]> _chunkCellViewModels(System.Collections.Generic.IEnumerable<PRISM.Adapters.Story.IStoryCellViewModel> cellViewModels);
    private bool <UpdateScroller>b__11_0(PRISM.Adapters.Story.EventStoryEventSelectCellViewModel x);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Adapters.Story.EventStoryEventSelectCellViewModel, bool> <>9__11_1;
        public static System.Func<System.Collections.Generic.IEnumerable<PRISM.Adapters.Story.IStoryCellViewModel>, PRISM.Adapters.Story.IStoryCellViewModel[]> <>9__12_0;
        private bool <UpdateScroller>b__11_1(PRISM.Adapters.Story.EventStoryEventSelectCellViewModel x);
        private PRISM.Adapters.Story.IStoryCellViewModel[] <_chunkCellViewModels>b__12_0(System.Collections.Generic.IEnumerable<PRISM.Adapters.Story.IStoryCellViewModel> x);
    }

    private class <>c__DisplayClass10_0
    {
        public System.Collections.Generic.Dictionary<int, float> currentScrollPositions;
        public PRISM.Interactions.Story.EventStoryEventSelectCellGridScroller <>4__this;
        private void <Setup>b__0(UniRx.Pair<int> unitId);
        private void <Setup>b__1(bool _);
    }
}

// Namespace: PRISM.Interactions.Story
public class EventStoryEventSelectCellGroup : PRISM.EnhancedListViewCell<PRISM.Adapters.Story.IStoryCellViewModel[], PRISM.Interactions.Story.StoryTopCellListViewContext<PRISM.Adapters.Story.EventStoryEventSelectCellViewModel>>
{
    private PRISM.Interactions.Story.EventStoryEventSelectCell[] cells;
    private UniRx.CompositeDisposable disposables;
    private System.Threading.CancellationTokenSource cts;
    public void UpdateContent(PRISM.Adapters.Story.IStoryCellViewModel[] cellViewModels);
    protected void _initialize();

    private class <>c__DisplayClass3_0
    {
        public PRISM.Adapters.Story.EventStoryEventSelectCellViewModel cellData;
        public PRISM.Interactions.Story.EventStoryEventSelectCellGroup <>4__this;
        private void <UpdateContent>b__0(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.Story
public class StoryTopEventContentView : UnityEngine.MonoBehaviour, PRISM.Adapters.Story.IStoryTopEventContentView, PRISM.Adapters.Story.IStoryTopContentView
{
    private PRISM.Interactions.MinimalUIButtonToggleGroupView unitTabGroup;
    private PRISM.Interactions.Story.EventStoryEventSelectCellGridScroller scroller;
    public float ScrollPosition { get; set; }
    public System.IObservable<PRISM.Adapters.Story.EventStoryEventSelectCellViewModel> OnClickCell { get; set; }
    public void Initialize(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.Story.EventStoryEventSelectCellViewModel> cellViewModels, PRISM.ResourceManagement.IResourceLoader resourceLoader, float scrollPosition, UniRx.IReactiveProperty<bool> isUnreadFilterActive, UniRx.IReactiveProperty<int> unitTabFilterId);
    public void SetActive(bool isActive);
}

// Namespace: PRISM.Interactions.Story
public class StoryTopExtraContentView : UnityEngine.MonoBehaviour, PRISM.Adapters.Story.IStoryTopExtraContentView, PRISM.Adapters.Story.IStoryTopContentView
{
    private PRISM.Interactions.Story.StoryCellScroller cellScroller;
    public float ScrollPosition { get; set; }
    public System.IObservable<PRISM.Adapters.Story.IStoryCellViewModel> OnClickCell { get; set; }
    public void Initialize(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.Story.ExtraStoryCategorySelectCellViewModel> cellViewModels, PRISM.ResourceManagement.IResourceLoader resourceLoader, float scrollPosition, UniRx.IReactiveProperty<bool> isUnreadFilterActive);
    public void SetActive(bool isActive);
}

// Namespace: PRISM.Interactions.Story
public class StoryTopFavoriteContentView : UnityEngine.MonoBehaviour, PRISM.Adapters.Story.IStoryTopFavoriteContentView, PRISM.Adapters.Story.IStoryTopContentView
{
    private PRISM.Interactions.Story.StoryPlayableStoryCellScroller cellScroller;
    private PRISM.Interactions.SortFilterView sortFilterView;
    public float ScrollPosition { get; set; }
    public PRISM.Adapters.Story.IStoryPlayableStoryCellScroller CellScroller { get; set; }
    public PRISM.Adapters.ISortFilterView SortFilterView { get; set; }
    public void SetActive(bool isActive);
}

// Namespace: PRISM.Interactions.Story
public class StoryTopIdolContentView : UnityEngine.MonoBehaviour, PRISM.Adapters.Story.IStoryTopIdolContentView, PRISM.Adapters.Story.IStoryTopContentView
{
    private PRISM.Interactions.Story.StoryCellScroller cellScroller;
    public float ScrollPosition { get; set; }
    public System.IObservable<PRISM.Adapters.Story.IStoryCellViewModel> OnClickCell { get; set; }
    public void Initialize(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.Story.IdolScenarioCategorySelectCellViewModel> cellViewModels, PRISM.ResourceManagement.IResourceLoader resourceLoader, float scrollPosition, UniRx.IReactiveProperty<bool> isUnreadFilterActive);
    public void SetActive(bool isActive);
}

// Namespace: PRISM.Interactions.Story
public class StoryTopProduceScenarioContentView : UnityEngine.MonoBehaviour, PRISM.Adapters.Story.IStoryTopProduceScenarioContentView, PRISM.Adapters.Story.IStoryTopContentView
{
    private PRISM.Interactions.Story.StoryCellScroller cellScroller;
    public float ScrollPosition { get; set; }
    public System.IObservable<PRISM.Adapters.Story.IStoryCellViewModel> OnClickCell { get; set; }
    public void Initialize(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.Story.ProduceScenarioUnitSelectCellViewModel> cellViewModels, PRISM.ResourceManagement.IResourceLoader resourceLoader, float scrollPosition, UniRx.IReactiveProperty<bool> isUnreadFilterActive);
    public void SetActive(bool isActive);
}

// Namespace: PRISM.Interactions.Story
public class StorySearchButtonView : UnityEngine.MonoBehaviour, PRISM.Adapters.Story.IStorySearchButtonView
{
    private PRISM.Interactions.ButtonView searchButton;
    private PRISM.Interactions.ViewStateChanger resultLabelChanger;
    private ENTERPRISE.UI.UITextMeshProUGUI resultText;
    private PRISM.Interactions.ViewStateChanger sortDirectionStateChanger;
    private PRISM.Interactions.ButtonView toggleSortDirectionButton;
    public System.IObservable<UniRx.Unit> OnClickSearchButton { get; set; }
    public System.IObservable<UniRx.Unit> OnToggleSortDirection { get; set; }
    public void UpdateView(bool isFiltered, int resultCount, PRISM.Definitions.SortDirection sortDirection);
}

// Namespace: PRISM.Interactions.Story
public class StoryTopSearchContentView : UnityEngine.MonoBehaviour, PRISM.Adapters.Story.IStoryTopSearchContentView, PRISM.Adapters.Story.IStoryTopContentView
{
    private PRISM.Interactions.Story.StoryPlayableStoryCellScroller cellScroller;
    private PRISM.Interactions.Story.StorySearchButtonView storySearchButton;
    public float ScrollPosition { get; set; }
    public PRISM.Adapters.Story.IStoryPlayableStoryCellScroller CellScroller { get; set; }
    public PRISM.Adapters.Story.IStorySearchButtonView StorySearchButton { get; set; }
    public void SetActive(bool isActive);
}

// Namespace: PRISM.Interactions.Story
public class StoryTopCellListViewContext`1<TData> : PRISM.EnhancedListViewContext, System.IDisposable
{
    private UniRx.Subject<TData> <OnClickCell>k__BackingField;
    public UniRx.Subject<TData> OnClickCell { get; set; }
    public void Dispose();
}

// Namespace: PRISM.Interactions.Story
public class StoryTopConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.Story.StoryTopArgument>, PRISM.Legacy.Story.IStoryTopConnector
{
    protected PRISM.Adapters.Story.StoryTopArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
}

// Namespace: PRISM.Interactions.Story
public class StoryTopTabGroup : UnityEngine.MonoBehaviour, PRISM.Adapters.Story.IStoryTopTabGroup
{
    private PRISM.Interactions.Story.StoryTopTabView tabPrefab;
    private UnityEngine.Transform tabParent;
    public void Initialize(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.Story.StoryTopTabViewModel> tabViewModelList, UniRx.IReactiveProperty<StoryTopContentType> selectedTabType);

    private class <>c__DisplayClass2_0
    {
        public PRISM.Interactions.Story.StoryTopTabGroup <>4__this;
        public System.Collections.Generic.IReadOnlyList<PRISM.Adapters.Story.StoryTopTabViewModel> tabViewModelList;
        private PRISM.Interactions.ButtonView <Initialize>b__0(PRISM.Adapters.Story.StoryTopTabViewModel tabViewModel);
        private int <Initialize>b__1(int index);
    }
}

// Namespace: PRISM.Interactions.Story
public class StoryTopTabView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView tabButton;
    private ENTERPRISE.UI.UITextMeshProUGUI tabLabel;
    private UnityEngine.UI.Image newBadge;
    private UnityEngine.UI.Image unreadBadge;
    public PRISM.Interactions.ButtonView TabButton { get; set; }
    public void Initialize(PRISM.Adapters.Story.StoryTopTabViewModel viewModel);
}

// Namespace: PRISM.Interactions.Story
public class StoryTopView : UnityEngine.MonoBehaviour, PRISM.Adapters.Story.IStoryTopView
{
    private PRISM.Interactions.Story.StoryTopTabGroup storyTopTabGroup;
    private PRISM.Interactions.ViewStateChanger backgroundChanger;
    private PRISM.Interactions.Story.StoryTopEpisodeZeroContentView episodeZeroContentView;
    private PRISM.Interactions.Story.StoryTopIdolContentView idolContentView;
    private PRISM.Interactions.Story.StoryTopProduceScenarioContentView produceScenarioContentView;
    private PRISM.Interactions.Story.StoryTopEventContentView eventContentView;
    private PRISM.Interactions.Story.StoryTopExtraContentView extraContentView;
    private PRISM.Interactions.Story.StoryTopSubStoryContentView subStoryContentView;
    private PRISM.Interactions.Story.StoryTopFavoriteContentView favoriteContentView;
    private PRISM.Interactions.Story.StoryTopSearchContentView searchContentView;
    private System.Collections.Generic.Dictionary<StoryTopContentType, PRISM.Adapters.Story.IStoryTopContentView> contentViewDic;
    public PRISM.Adapters.Story.IStoryTopTabGroup StoryTopTabGroup { get; set; }
    public PRISM.Adapters.Story.IStoryTopEpisodeZeroContentView EpisodeZeroContentView { get; set; }
    public PRISM.Adapters.Story.IStoryTopIdolContentView IdolContentView { get; set; }
    public PRISM.Adapters.Story.IStoryTopProduceScenarioContentView ProduceScenarioContentView { get; set; }
    public PRISM.Adapters.Story.IStoryTopEventContentView EventContentView { get; set; }
    public PRISM.Adapters.Story.IStoryTopExtraContentView ExtraContentView { get; set; }
    public PRISM.Adapters.Story.IStoryTopSubStoryContentView SubStoryContentView { get; set; }
    public PRISM.Adapters.Story.IStoryTopFavoriteContentView FavoriteContentView { get; set; }
    public PRISM.Adapters.Story.IStoryTopSearchContentView SearchContentView { get; set; }
    public void Initialize();
    public void ShowContent(StoryTopContentType storyTopContentType);
    public float GetScrollPosition(StoryTopContentType storyTopContentType);
}

// Namespace: PRISM.Interactions.Story
public class StoryTopSubStoryContentView : UnityEngine.MonoBehaviour, PRISM.Adapters.Story.IStoryTopSubStoryContentView, PRISM.Adapters.Story.IStoryTopContentView
{
    private PRISM.Interactions.Story.StoryCellScroller cellScroller;
    public float ScrollPosition { get; set; }
    public System.IObservable<PRISM.Adapters.Story.IStoryCellViewModel> OnClickCell { get; set; }
    public void Initialize(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.Story.SubStorySelectCellViewModel> cellViewModels, PRISM.ResourceManagement.IResourceLoader resourceLoader, float scrollPosition, UniRx.IReactiveProperty<bool> isUnreadFilterActive);
    public void SetActive(bool isActive);
}

// Namespace: PRISM.Interactions.Story
public class SupportCharacterScenarioCharacterSelectCell : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.SupportCharacterIconView supportCharacterIconView;
    private PRISM.Interactions.ButtonView cellButton;
    protected UnityEngine.GameObject newBadge;
    protected UnityEngine.GameObject unreadBadge;
    public System.IObservable<UniRx.Unit> OnClick { get; set; }
    public System.IObservable<UniRx.Unit> OnLongPress { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.Story.SupportCharacterScenarioCharacterSelectCellViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
}

// Namespace: PRISM.Interactions.Story
public class SupportCharacterScenarioCharacterSelectCellGroup : PRISM.EnhancedListViewCell<PRISM.Adapters.Story.IStoryCellViewModel[], PRISM.Interactions.Story.SupportCharacterScenarioCharacterSelectCellScrollerContext>
{
    private PRISM.Interactions.Story.SupportCharacterScenarioCharacterSelectCell[] cells;
    private UniRx.CompositeDisposable disposables;
    private PRISM.AutoCancellationTokenSource canceller;
    public void UpdateContent(PRISM.Adapters.Story.IStoryCellViewModel[] cellViewModels);
    private void OnDestroy();

    private class <>c__DisplayClass3_0
    {
        public PRISM.Adapters.Story.SupportCharacterScenarioCharacterSelectCellViewModel cellViewModel;
        public PRISM.Interactions.Story.SupportCharacterScenarioCharacterSelectCellGroup <>4__this;
        private void <UpdateContent>b__0(UniRx.Unit _);
        private void <UpdateContent>b__1(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.Story
public class SupportCharacterScenarioCharacterSelectCellScroller : PRISM.EnhancedListView<PRISM.Adapters.Story.IStoryCellViewModel[], PRISM.Interactions.Story.SupportCharacterScenarioCharacterSelectCellScrollerContext>
{
    private int cellGroupElementCount;
    private PRISM.Interactions.ToggleButtonView unreadFilterToggle;
    private ENTERPRISE.UI.UITextMeshProUGUI emptyViewText;
    private UniRx.IReactiveProperty<bool> isUnreadFilterActive;
    private System.Collections.Generic.IReadOnlyList<PRISM.Adapters.Story.IStoryCellViewModel> currentAllCellViewModels;
    public System.IObservable<PRISM.Adapters.Story.SupportCharacterScenarioCharacterSelectCellViewModel> OnClickCell { get; set; }
    public System.IObservable<PRISM.Adapters.Story.SupportCharacterScenarioCharacterSelectCellViewModel> OnLongPressCell { get; set; }
    public float ScrollPosition { get; set; }
    public void Setup(PRISM.ResourceManagement.IResourceLoader resourceLoader, UniRx.IReactiveProperty<bool> isUnreadFilterActive);
    public void UpdateScroller(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.Story.IStoryCellViewModel> cellViewModels, System.Nullable<float> scrollPosition);
    private System.Collections.Generic.IEnumerable<PRISM.Adapters.Story.IStoryCellViewModel[]> _chunkCellViewModels(System.Collections.Generic.IEnumerable<PRISM.Adapters.Story.IStoryCellViewModel> cellViewModels);
    private void <Setup>b__11_0(bool _);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Adapters.Story.IStoryCellViewModel, bool> <>9__12_0;
        public static System.Func<System.Collections.Generic.IEnumerable<PRISM.Adapters.Story.IStoryCellViewModel>, PRISM.Adapters.Story.IStoryCellViewModel[]> <>9__13_0;
        private bool <UpdateScroller>b__12_0(PRISM.Adapters.Story.IStoryCellViewModel x);
        private PRISM.Adapters.Story.IStoryCellViewModel[] <_chunkCellViewModels>b__13_0(System.Collections.Generic.IEnumerable<PRISM.Adapters.Story.IStoryCellViewModel> x);
    }
}

// Namespace: PRISM.Interactions.Story
public class SupportCharacterScenarioCharacterSelectCellScrollerContext : PRISM.EnhancedListViewContext, System.IDisposable
{
    private UniRx.Subject<PRISM.Adapters.Story.SupportCharacterScenarioCharacterSelectCellViewModel> <OnClickCell>k__BackingField;
    private UniRx.Subject<PRISM.Adapters.Story.SupportCharacterScenarioCharacterSelectCellViewModel> <OnLongPressCell>k__BackingField;
    public UniRx.Subject<PRISM.Adapters.Story.SupportCharacterScenarioCharacterSelectCellViewModel> OnClickCell { get; set; }
    public UniRx.Subject<PRISM.Adapters.Story.SupportCharacterScenarioCharacterSelectCellViewModel> OnLongPressCell { get; set; }
    public void Dispose();
}

// Namespace: PRISM.Interactions.Story
public class SupportCharacterScenarioCharacterSelectConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.Story.SupportCharacterScenarioCharacterSelectArgument>, PRISM.Story.ISupportCharacterScenarioCharacterSelectConnector
{
    protected PRISM.Adapters.Story.SupportCharacterScenarioCharacterSelectArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
}

// Namespace: PRISM.Interactions.Story
public class SupportCharacterScenarioCharacterSelectView : UnityEngine.MonoBehaviour, PRISM.Adapters.Story.ISupportCharacterScenarioCharacterSelectView
{
    private PRISM.Interactions.CommonTitleView titleView;
    private PRISM.Interactions.Story.SupportCharacterScenarioCharacterSelectCellScroller scroller;
    private PRISM.Interactions.FilterOnlyView filterOnlyView;
    private PRISM.UI.UICharacterViewer uiCharacterViewer;
    private PRISM.UI.CenteringObjectsOutsideSafeArea characterPositionAdjuster;
    public float ScrollPosition { get; set; }
    public PRISM.Adapters.ISortFilterView SortFilterView { get; set; }
    public System.IObservable<PRISM.Adapters.Story.SupportCharacterScenarioCharacterSelectCellViewModel> OnClickCell { get; set; }
    public System.IObservable<PRISM.Adapters.Story.SupportCharacterScenarioCharacterSelectCellViewModel> OnLongPressCell { get; set; }
    public void Initialize(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.Story.SupportCharacterScenarioCharacterSelectCellViewModel> cellViewModels, PRISM.ResourceManagement.IResourceLoader resourceLoader, float scrollPosition, UniRx.IReactiveProperty<bool> isUnreadFilterActive);
    public Cysharp.Threading.Tasks.UniTask Initialize3dHazukiAsync(PRISM.UnitIdol unitIdol, PRISM.UI.UICharacterVoicePattern voicePattern, ScreenType screenType, string requiredMotionCueSheetName, System.Threading.CancellationToken ct);
    public void UpdateScroller(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.Story.SupportCharacterScenarioCharacterSelectCellViewModel> cellViewModels);
    public void OnNextViewPreparation();
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();

    private struct <Initialize3dHazukiAsync>d__14 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Story.SupportCharacterScenarioCharacterSelectView <>4__this;
        public PRISM.UnitIdol unitIdol;
        public PRISM.UI.UICharacterVoicePattern voicePattern;
        public ScreenType screenType;
        public string requiredMotionCueSheetName;
        public System.Threading.CancellationToken ct;
        private Awaiter<bool> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Story
public class SupportCharacterScenarioSelectConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.Story.SupportCharacterScenarioSelectArgument>, PRISM.Story.ISupportCharacterScenarioSelectConnector
{
    protected PRISM.Adapters.Story.SupportCharacterScenarioSelectArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
}

// Namespace: PRISM.Interactions.Story
public class SupportCharacterScenarioSelectView : UnityEngine.MonoBehaviour, PRISM.Adapters.Story.ISupportCharacterScenarioSelectView
{
    private PRISM.Interactions.CommonTitleView viewTitle;
    private UnityEngine.UI.RawImage characterImage;
    private PRISM.Interactions.Story.StoryPlayableStoryCellScroller cellScroller;
    private PRISM.Interactions.ButtonView upgradingButton;
    public PRISM.Adapters.Story.IStoryPlayableStoryCellScroller CellScroller { get; set; }
    public System.IObservable<UniRx.Unit> OnClickUpgradingButton { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(int mstSupportCharacterId, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
}

// Namespace: PRISM.Interactions.Story
public class UnitSubStorySelectConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.Story.UnitSubStorySelectArgument>, PRISM.Story.IUnitSubStorySelectConnector
{
    protected PRISM.Adapters.Story.UnitSubStorySelectArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
}

// Namespace: PRISM.Interactions.Story
public class UnitSubStorySelectView : UnityEngine.MonoBehaviour, PRISM.Adapters.Story.IUnitSubStorySelectView
{
    private UnityEngine.UI.Image bgImage;
    private PRISM.Interactions.Story.StoryPlayableStoryCellScroller cellScroller;
    public PRISM.Adapters.Story.IStoryPlayableStoryCellScroller CellScroller { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeBackgroundAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, int mstMainStoryChapterId, System.Threading.CancellationToken ct);
}

// Namespace: PRISM.Interactions.Story
public class UnitSubStoryUnitSelectConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.Story.UnitSubStoryUnitSelectArgument>, PRISM.Legacy.Story.IUnitSubStoryUnitSelectConnector
{
    protected PRISM.Adapters.Story.UnitSubStoryUnitSelectArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
}

// Namespace: PRISM.Interactions.Story
public class UnitSubStoryUnitSelectView : UnityEngine.MonoBehaviour, PRISM.Adapters.Story.IUnitSubStoryUnitSelectView
{
    private PRISM.UI.UICharacterViewer uiCharacterViewer;
    private PRISM.UI.CenteringObjectsOutsideSafeArea characterPositionAdjuster;
    private PRISM.Interactions.CommonTitleView titleView;
    private PRISM.Interactions.Story.StoryCellScroller cellScroller;
    public System.IObservable<PRISM.Adapters.Story.IStoryCellViewModel> OnClickCell { get; set; }
    public float ScrollPosition { get; set; }
    public void InitializeCellScroller(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.Story.UnitSubStoryUnitSelectCellViewModel> cellViewModels, PRISM.ResourceManagement.IResourceLoader resourceLoader, float scrollPosition, UniRx.IReactiveProperty<bool> isUnreadFilterActive);
    public void SetViewTitle(string titleText);
    public Cysharp.Threading.Tasks.UniTask Initialize3dHazukiAsync(PRISM.UnitIdol unitIdol, PRISM.UI.UICharacterVoicePattern voicePattern, ScreenType screenType, string requiredMotionCueSheetName, System.Threading.CancellationToken ct);
    public void OnNextViewPreparation();
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=9205 6B7019FD8F931A0628918BE0A7FF38CE0E7CA20A326A46C34FA1461DF4196B85;
    private static __StaticArrayInitTypeSize=5307 BAC10B6AE983AB63B1A1724AD257F60442BF805318A306930C583CF9EF36B71E;

    private struct __StaticArrayInitTypeSize=5307 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=9205 : System.ValueType
    {
    }
}
