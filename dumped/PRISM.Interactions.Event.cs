
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
public class AllSongLiveEventConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.LiveEventArgument>, PRISM.IAllSongLiveEventConnector
{
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
    protected PRISM.Adapters.LiveEventArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
}

// Namespace: PRISM.Interactions
public class EventDetailPanelView : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI eventDateText;
    private ENTERPRISE.UI.UITextMeshProUGUI remainTimeText;
    private PRISM.Interactions.ButtonView rewardButton;
    private PRISM.Interactions.ButtonView rankingButton;
    private PRISM.Interactions.ButtonView missionButton;
    private PRISM.Interactions.ButtonView shopButton;
    private UnityEngine.GameObject missionButtonBadge;
    private ENTERPRISE.UI.UITextMeshProUGUI eventPointText;
    private ENTERPRISE.UI.UITextMeshProUGUI eventRankingText;
    private ENTERPRISE.UI.UITextMeshProUGUI highScoreRankingText;
    private ENTERPRISE.UI.UITextMeshProUGUI eventStoryText;
    private ENTERPRISE.UI.UITextMeshProUGUI eventStoryRemainPointText;
    private ENTERPRISE.UI.UITextMeshProUGUI eventBonusRateText;
    private UnityEngine.GameObject nextStoryObject;
    private UnityEngine.GameObject storyCompleteObject;
    private PRISM.Interactions.ButtonView helpButton;
    private UnityEngine.GameObject userRankingPanel;
    private UnityEngine.GameObject aggregationPanel;
    private ENTERPRISE.UI.UITextMeshProUGUI aggregationDateText;
    public System.IObservable<UniRx.Unit> OnClickRankingButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickHelpButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickRewardButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickMissionButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickShopButton { get; set; }
    public void Setup(PRISM.Adapters.IEventDetailPanelViewModel model);
    private string _getExpiredTimeText(System.DateTime endDate, ENTERPRISE.Localization.LocalizationManager localizer);
    public void Terminate();
    private string _getDateText(System.Nullable<System.DateTime> date, ENTERPRISE.Localization.LocalizationManager localizer);
}

// Namespace: PRISM.Interactions
public class EventRankingRewardTabView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.RankingRewardListView rewardListView;
    private UnityEngine.CanvasGroup rewardListCanvas;
    public void Show(PRISM.Adapters.EventRankingRewardTabViewModel model, RankingMode rankingMode, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Interactions
public class LiveEventConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.LiveEventArgument>, PRISM.ILiveEventConnector
{
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
    protected PRISM.Adapters.LiveEventArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
}

// Namespace: PRISM.Interactions
public class AllSongIdolRewardListCell : PRISM.Interactions.ListViewCell<PRISM.Adapters.AllSongIdolRewardListCellViewModel>
{
    private ENTERPRISE.UI.UITextMeshProUGUI titleText;
    private UnityEngine.Transform rewardIconContainer;
    private ENTERPRISE.OutGame.RewardItem rewardIconBase;
    private PRISM.Interactions.SimpleAchievementIcon achievementIconBase;
    private PRISM.AutoCancellationTokenSource canceller;
    public void UpdateContent(PRISM.Adapters.AllSongIdolRewardListCellViewModel viewModel);

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
public class AllSongIdolRewardListView : PRISM.Interactions.ListView<PRISM.Interactions.AllSongIdolRewardListCell, PRISM.Adapters.AllSongIdolRewardListCellViewModel>
{
}

// Namespace: PRISM.Interactions
public class LiveEventAllSongBorderListCell : PRISM.EnhancedListViewCell<System.ValueTuple<EventRankGrade, long>>
{
    private PRISM.Interactions.LiveEventRankingGradeIcon gradeIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI detailText;
    private ENTERPRISE.UI.UITextMeshProUGUI pointText;
    public void UpdateContent(System.ValueTuple<EventRankGrade, long> data);
}

// Namespace: PRISM.Interactions
public class LiveEventAllSongBorderListView : PRISM.EnhancedListView<System.ValueTuple<EventRankGrade, long>>
{
}

// Namespace: PRISM.Interactions
public class LiveEventAllSongIdolRankingTabView : UnityEngine.MonoBehaviour, System.IDisposable
{
    private PRISM.Interactions.LiveEventRankingIdolSelfRankListView listView;
    private PRISM.Interactions.LiveEventRankingListView pointRankingView;
    private PRISM.Interactions.LiveEventAllSongBorderListView borderListView;
    private UnityEngine.GameObject borderView;
    private PRISM.Interactions.LiveEventAllSongSelfRankingView selfView;
    private PRISM.Interactions.ToggleGroupView tabGroup;
    private PRISM.Interactions.LiveEventRankingIdolSelectListView idolSelectListView;
    private PRISM.Interactions.LiveEventRankingAggregationView aggregationView;
    private PRISM.CommonInputFieldTMP commentInput;
    private PRISM.Interactions.ButtonView switchDisplayButton;
    private PRISM.Adapters.LiveEventAllSongRankingTabViewModel viewModel;
    private bool isInitialized;
    private PRISM.Data.LoginUserData loginUserData;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    private UniRx.Subject<int> onTabChanged;
    public System.IObservable<int> OnIdolTabSelectionChanged { get; set; }
    public System.IObservable<int> OnTabChanged { get; set; }
    public System.IObservable<string> OnEditComment { get; set; }
    public void Show(PRISM.Adapters.LiveEventAllSongRankingTabViewModel model, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken cancellationToken);
    private void _updateList();
    public void Dispose();

    private class <>c__DisplayClass21_0
    {
        public PRISM.Interactions.LiveEventAllSongIdolRankingTabView <>4__this;
        public System.Threading.CancellationToken cancellationToken;
        private void <Show>b__0(int index);
        private void <Show>b__1(PRISM.Adapters.LiveEventRankingCellViewModel model);
        private void <Show>b__2(UniRx.Unit _);
        private void <Show>b__3(string newComment);
    }
}

// Namespace: PRISM.Interactions
public class LiveEventAllSongIdolRewardTabView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.AllSongIdolRewardListView rewardListView;
    private PRISM.Interactions.LiveEventRankingIdolSelectListView idolSelectListView;
    private UnityEngine.CanvasGroup rewardListCanvas;
    private bool isInitialized;
    public void Show(PRISM.Adapters.AllSongIdolRankingRewardTabViewModel model, PRISM.ResourceManagement.IResourceLoader resourceLoader);

    private class <>c__DisplayClass4_0
    {
        public PRISM.Interactions.LiveEventAllSongIdolRewardTabView <>4__this;
        public PRISM.Adapters.AllSongIdolRankingRewardTabViewModel model;
        private void <Show>g__OnCellClicked|0(int index);
        private void <Show>g__OnSelectionChanged|1(int index);
        private void <Show>g__UpdateList|2();
    }
}

// Namespace: PRISM.Interactions
public class LiveEventAllSongRankingTabView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.LiveEventAllSongSelfRankingView selfRankingView;
    private PRISM.Interactions.LiveEventRankingListView pointRankingView;
    private PRISM.Interactions.ToggleGroupView tabGroup;
    private PRISM.Interactions.MusicDifficultyIcon[] difficultyIcons;
    private PRISM.Interactions.MusicBasicInfoView musicInfoView;
    private PRISM.Interactions.LiveEventRankingAggregationView aggregationView;
    private PRISM.CommonInputFieldTMP commentInput;
    private PRISM.Interactions.LiveEventAllSongSelfRankingView userRankForBorderView;
    private PRISM.Adapters.LiveEventAllSongRankingTabViewModel viewModel;
    private bool isInitialized;
    private PRISM.Data.LoginUserData loginUserData;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    private UniRx.Subject<int> onTabChanged;
    public System.IObservable<int> OnTabChanged { get; set; }
    public System.IObservable<string> OnEditComment { get; set; }
    public Cysharp.Threading.Tasks.UniTask ShowAsync(PRISM.Adapters.LiveEventAllSongRankingTabViewModel model, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken cancellationToken);
    private Cysharp.Threading.Tasks.UniTask _getListAsync(System.Threading.CancellationToken cancellationToken);
    private void <_getListAsync>g__GetSelfRankAsync|18_0(PRISM.Interactions.LiveEventAllSongSelfRankingView view);

    private class <>c__DisplayClass17_0
    {
        public System.Threading.CancellationToken cancellationToken;
        public PRISM.Interactions.LiveEventAllSongRankingTabView <>4__this;
        private void <ShowAsync>b__0(PRISM.Adapters.LiveEventRankingCellViewModel model);
        private void <ShowAsync>b__1(string newComment);
    }

    private struct <ShowAsync>d__17 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public System.Threading.CancellationToken cancellationToken;
        public PRISM.Interactions.LiveEventAllSongRankingTabView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public PRISM.Adapters.LiveEventAllSongRankingTabViewModel model;
        private <>c__DisplayClass17_0 <>8__1;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_getListAsync>d__18 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.LiveEventAllSongRankingTabView <>4__this;
        public System.Threading.CancellationToken cancellationToken;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class LiveEventAllSongRewardTabView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.RankingRewardListView rewardListView;
    private UnityEngine.CanvasGroup rewardListCanvas;
    public void Show(PRISM.Adapters.EventRankingRewardTabViewModel model, RankingMode rankingMode, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Interactions
public class LiveEventAllSongSelfRankingView : UnityEngine.MonoBehaviour
{
    private PRISM.Live.UserRankingView selfRankingView;
    private PRISM.Interactions.SimpleAchievementIconGroup achievementIconGroup;
    private PRISM.UI.PFIdolIconView idolIcon;
    private PRISM.Interactions.LiveEventRankingGradeIcon gradeIcon;
    private UnityEngine.GameObject rankDText;
    public void Show(PRISM.Module.Networking.IRankedUserStatus ranking, PRISM.ResourceManagement.IResourceLoader resourceLoader, bool isAggregation);
}

// Namespace: PRISM.Interactions
public class LiveEventCategoryTabButtonView : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI tabText;
    private PRISM.Interactions.ButtonView button;
    public PRISM.Interactions.ButtonView Button { get; set; }
    public void SetText(string text);
}

// Namespace: PRISM.Interactions
public class LiveEventCategoryToggleGroupView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.LiveEventCategoryTabButtonView tabButton;
    private UnityEngine.Transform tabParent;
    public void Initialize(System.Collections.Generic.IEnumerable<string> tabNames, UniRx.IReactiveProperty<int> selectedTabIndex);
    private PRISM.Interactions.ButtonView <Initialize>b__2_0(string tabName);
}

// Namespace: PRISM.Interactions
public class LiveEventMedalExchangeRewardGridCell : PRISM.Interactions.GridViewCell<PRISM.Adapters.LiveEventMedalExchangeRewardGridViewModel>
{
    private PRISM.Interactions.MedalGashaRewardIcon rewardIcon;
    public void UpdateContent(PRISM.Adapters.LiveEventMedalExchangeRewardGridViewModel data);
}

// Namespace: PRISM.Interactions
public class LiveEventMedalExchangeRewardGridView : PRISM.Interactions.GridView<PRISM.Interactions.LiveEventMedalExchangeRewardGridCell, PRISM.Adapters.LiveEventMedalExchangeRewardGridViewModel>
{
    protected void SetupCellTemplate();

    private class CellGroup : DefaultCellGroup<PRISM.Adapters.LiveEventMedalExchangeRewardGridViewModel, PRISM.Interactions.GridViewContext>
    {
    }
}

// Namespace: PRISM.Interactions
public class LiveEventMedalExchangeRewardTabView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.LiveEventMedalExchangeRewardGridView rewardGridView;
    private UnityEngine.CanvasGroup rewardListCanvas;
    public void Show(PRISM.Adapters.AllSongMedalExchangeRewardTabViewModel model, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Interactions
public class LiveEventRankingAggregationView : UnityEngine.MonoBehaviour
{
    private UnityEngine.GameObject aggregationPanel;
    private ENTERPRISE.UI.UITextMeshProUGUI aggregationDateText;
    public void Show(System.Nullable<System.DateTime> resultBeginDate);
}

// Namespace: PRISM.Interactions
public class LiveEventRankingCell : PRISM.EnhancedListViewCell<PRISM.Adapters.LiveEventRankingCellViewModel, PRISM.Interactions.LiveEventRankingContext>
{
    private PRISM.Interactions.RankingHeaderView headerView;
    private PRISM.UI.PFIdolIconView idolIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI userName;
    private PRISM.Interactions.SimpleAchievementIconGroup achievementIconGroup;
    private UnityEngine.GameObject myselfCellBase;
    private PRISM.Interactions.ViewStateChanger myselfCellStateChanger;
    private PRISM.Interactions.ViewStateChanger rankingTypeStateChanger;
    private ENTERPRISE.UI.UITextMeshProUGUI point;
    private ENTERPRISE.UI.UITextMeshProUGUI score;
    private ENTERPRISE.UI.UITextMeshProUGUI idolPoint;
    private PRISM.Interactions.MusicDifficultyIcon difficultyIcon;
    private UnityEngine.UI.RawImage pointIcon;
    private UnityEngine.UI.RawImage idolPointIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI commentText;
    private PRISM.AutoCancellationTokenSource canceller;
    protected void _initialize();
    public void UpdateContent(PRISM.Adapters.LiveEventRankingCellViewModel data);
    private void <_initialize>b__15_0(System.ValueTuple<int, UnityEngine.GameObject> _);
}

// Namespace: PRISM.Interactions
public class LiveEventRankingIdolSelectListCell : PRISM.CommonListViewCell<int, PRISM.CommonListViewContext>
{
    private PRISM.UI.PFIdolIconView icon;
    private System.Threading.CancellationTokenSource cancellationTokenSource;
    public void Initialize();
    public void UpdateContent(int itemData);
    private void OnDestroy();
    private void <Initialize>b__2_0(System.ValueTuple<int, UnityEngine.GameObject> _);
}

// Namespace: PRISM.Interactions
public class LiveEventRankingIdolSelectListView : PRISM.CommonListView<PRISM.Interactions.LiveEventRankingIdolSelectListCell, int, PRISM.CommonListViewContext>
{
}

// Namespace: PRISM.Interactions
public class LiveEventRankingIdolSelfRankCell : FancyScrollView.FancyGridViewCell<PRISM.Adapters.LiveEventRankingIdolSelfRankCellViewModel, PRISM.Interactions.LiveEventRankingIdolSelfRankListContext>
{
    private PRISM.UI.PFIdolIconView icon;
    private ENTERPRISE.UI.UITextMeshProUGUI pointText;
    private PRISM.Interactions.LiveEventRankingGradeIcon gradePyramid;
    private PRISM.Interactions.LiveEventRankingGradeIcon gradeIcon;
    private UnityEngine.GameObject[] gradeDetailTexts;
    private PRISM.Interactions.LiveEventRankingGradeIcon baseImage;
    private UnityEngine.GameObject rankArea;
    private UnityEngine.GameObject borderArea;
    private UnityEngine.GameObject upperBorderArea;
    private UnityEngine.GameObject lowerBorderArea;
    private ENTERPRISE.UI.UITextMeshProUGUI pointTextBorder;
    private ENTERPRISE.UI.UITextMeshProUGUI upperBorderText;
    private ENTERPRISE.UI.UITextMeshProUGUI lowerBorderText;
    private UnityEngine.GameObject rankDText;
    private PRISM.Interactions.LiveEventRankingGradeIcon gradeIconBorder;
    private System.Threading.CancellationTokenSource cancellationTokenSource;
    public void Initialize();
    public void UpdateContent(PRISM.Adapters.LiveEventRankingIdolSelfRankCellViewModel itemData);
    private void OnDestroy();
    private void <Initialize>b__16_0(bool isShowBorder);
}

// Namespace: PRISM.Interactions
public class LiveEventRankingIdolSelfRankListView : FancyScrollView.FancyGridView<PRISM.Adapters.LiveEventRankingIdolSelfRankCellViewModel, PRISM.Interactions.LiveEventRankingIdolSelfRankListContext>
{
    private PRISM.Interactions.LiveEventRankingIdolSelfRankCell cellPrefab;
    protected UnityEngine.GameObject emptyView;
    public bool IsShowBorder { get; set; }
    protected void SetupCellTemplate();
    public void SetResourceLoader(PRISM.ResourceManagement.IResourceLoader resourceLoader);

    private class CellGroup : DefaultCellGroup<PRISM.Adapters.LiveEventRankingIdolSelfRankCellViewModel, PRISM.Interactions.LiveEventRankingIdolSelfRankListContext>
    {
    }
}

// Namespace: PRISM.Interactions
public class LiveEventRankingIdolSelfRankListContext : PRISM.Interactions.GridViewContext
{
    private UniRx.ReactiveProperty<bool> <IsShowBorder>k__BackingField;
    public UniRx.ReactiveProperty<bool> IsShowBorder { get; set; }
    public void Dispose();
}

// Namespace: PRISM.Interactions
public class LiveEventRankingListView : PRISM.EnhancedListView<PRISM.Adapters.LiveEventRankingCellViewModel, PRISM.Interactions.LiveEventRankingContext>
{
    public System.IObservable<PRISM.Adapters.LiveEventRankingCellViewModel> OnIdolIconLongPressed { get; set; }
    private void <get_OnIdolIconLongPressed>b__1_0(System.Action<PRISM.Adapters.LiveEventRankingCellViewModel> h);
    private void <get_OnIdolIconLongPressed>b__1_1(System.Action<PRISM.Adapters.LiveEventRankingCellViewModel> h);
}

// Namespace: PRISM.Interactions
public class LiveEventRankingContext : PRISM.EnhancedListViewContext
{
    private System.Action<PRISM.Adapters.LiveEventRankingCellViewModel> <OnIdolIconLongPressed>k__BackingField;
    public System.Action<PRISM.Adapters.LiveEventRankingCellViewModel> OnIdolIconLongPressed { get; set; }
}

// Namespace: PRISM.Interactions
public class LiveEventRankingOverlayView : PRISM.Interactions.OverlayViewWithCloseButton, PRISM.Adapters.ILiveEventRankingOverlayView, PRISM.Adapters.IClosableOverlayView<UniRx.Unit>, PRISM.Adapters.IOverlayView, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.ToggleGroupView functionTabGroup;
    private PRISM.Interactions.LiveEventCategoryToggleGroupView rewardCategoryTabGroup;
    private UnityEngine.GameObject[] rewardCategoryViews;
    private PRISM.Interactions.LiveEventCategoryToggleGroupView rankingCategoryTabGroup;
    private UnityEngine.GameObject[] rankingCategoryViews;
    private PRISM.Interactions.MedalGashaRewardTabView medalGashaRewardTabView;
    private PRISM.Interactions.LiveEventMedalExchangeRewardTabView medalExchangeRewardTabView;
    private PRISM.Interactions.EventRankingRewardTabView eventRankingRewardTabView;
    private PRISM.Interactions.LiveEventAllSongRewardTabView allSongRewardTabView;
    private PRISM.Interactions.LiveEventAllSongIdolRewardTabView allSongIdolRewardTabView;
    private PRISM.Interactions.LiveEventRankingTabView eventRankingView;
    private PRISM.Interactions.LiveEventRankingTabView highScoreRankingView;
    private PRISM.Interactions.LiveEventAllSongIdolRankingTabView allSongIdolRankingTabView;
    private PRISM.Interactions.LiveEventAllSongRankingTabView allSongPointRankingTabView;
    private PRISM.Interactions.LiveEventAllSongRankingTabView allSongHighScoreRankingTabView;
    private PRISM.Interactions.TechnicalChallengeRewardTabView technicalChallengeRewardTabView;
    private PRISM.Interactions.LiveEventRankingTabView technicalChallengeMasterRankingView;
    private PRISM.Interactions.LiveEventRankingTabView technicalChallengeExpertRankingView;
    private PRISM.HowToPlayPopupOpener howToPlayEventPopupOpener;
    private PRISM.HowToPlayPopupOpener howToPlayAllSongPopupOpener;
    private PRISM.HowToPlayPopupOpener howToPlayTechnicalChallengePopupOpener;
    private UniRx.Subject<System.ValueTuple<PRISM.Adapters.RankingFunction, int>> onTabSelected;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    private PRISM.Adapters.LiveEventRankingViewModel model;
    public System.IObservable<System.ValueTuple<PRISM.Adapters.RankingFunction, int>> OnTabSelected { get; set; }
    public System.IObservable<System.ValueTuple<int, EventRankingType>> OnChangedEventRankingTab { get; set; }
    public System.IObservable<System.ValueTuple<string, EventRankingType>> OnUpdateComment { get; set; }
    public System.IObservable<int> OnChangeIdolTab { get; set; }
    public void ShowMedalGashaRewardTab(PRISM.Adapters.MedalGashaRewardTabViewModel model);
    public void ShowEventRankingRewardTab(PRISM.Adapters.EventRankingRewardTabViewModel model, RankingMode rankingMode);
    public void ShowAllSongIdolRankingRewardTab(PRISM.Adapters.AllSongIdolRankingRewardTabViewModel model);
    public void ShowAllSongMedalExchangeRewardTab(PRISM.Adapters.AllSongMedalExchangeRewardTabViewModel model);
    public void ShowAllSongEventRankingRewardTab(PRISM.Adapters.EventRankingRewardTabViewModel model, RankingMode rankingMode);
    public void ShowEventRankingTab(PRISM.Adapters.LiveEventRankingTabViewModel model, System.Threading.CancellationToken cancellationToken);
    public void ShowAllSongIdolRankingTab(PRISM.Adapters.LiveEventAllSongRankingTabViewModel model, System.Threading.CancellationToken cancellationToken);
    public void ShowAllSongEventRankingTab(PRISM.Adapters.LiveEventAllSongRankingTabViewModel model, System.Threading.CancellationToken cancellationToken);
    public void ShowTechnicalChallengeRewardTab(PRISM.Adapters.TechnicalChallengeRewardTabViewModel model);
    public void ShowTechnicalChallengeRankingTab(PRISM.Adapters.LiveEventRankingTabViewModel model, System.Threading.CancellationToken cancellationToken);
    public void Initialize(int eventId, bool isOpenRanking, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken cancellationToken);
    public void ChangeTab(PRISM.Adapters.RankingFunction selectedFunction);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    private Cysharp.Threading.Tasks.UniTask <>n__0(System.Threading.CancellationToken ct);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<int, System.ValueTuple<int, EventRankingType>> <>9__24_0;
        public static System.Func<int, System.ValueTuple<int, EventRankingType>> <>9__24_1;
        public static System.Func<int, System.ValueTuple<int, EventRankingType>> <>9__24_2;
        public static System.Func<int, System.ValueTuple<int, EventRankingType>> <>9__24_3;
        public static System.Func<int, System.ValueTuple<int, EventRankingType>> <>9__24_4;
        public static System.Func<string, System.ValueTuple<string, EventRankingType>> <>9__26_0;
        public static System.Func<string, System.ValueTuple<string, EventRankingType>> <>9__26_1;
        public static System.Func<string, System.ValueTuple<string, EventRankingType>> <>9__26_2;
        public static System.Func<string, System.ValueTuple<string, EventRankingType>> <>9__26_3;
        public static System.Func<string, System.ValueTuple<string, EventRankingType>> <>9__26_4;
        public static System.Func<string, System.ValueTuple<string, EventRankingType>> <>9__26_5;
        public static System.Func<string, System.ValueTuple<string, EventRankingType>> <>9__26_6;
        private System.ValueTuple<int, EventRankingType> <get_OnChangedEventRankingTab>b__24_0(int p);
        private System.ValueTuple<int, EventRankingType> <get_OnChangedEventRankingTab>b__24_1(int p);
        private System.ValueTuple<int, EventRankingType> <get_OnChangedEventRankingTab>b__24_2(int p);
        private System.ValueTuple<int, EventRankingType> <get_OnChangedEventRankingTab>b__24_3(int p);
        private System.ValueTuple<int, EventRankingType> <get_OnChangedEventRankingTab>b__24_4(int p);
        private System.ValueTuple<string, EventRankingType> <get_OnUpdateComment>b__26_0(string c);
        private System.ValueTuple<string, EventRankingType> <get_OnUpdateComment>b__26_1(string c);
        private System.ValueTuple<string, EventRankingType> <get_OnUpdateComment>b__26_2(string c);
        private System.ValueTuple<string, EventRankingType> <get_OnUpdateComment>b__26_3(string p);
        private System.ValueTuple<string, EventRankingType> <get_OnUpdateComment>b__26_4(string p);
        private System.ValueTuple<string, EventRankingType> <get_OnUpdateComment>b__26_5(string c);
        private System.ValueTuple<string, EventRankingType> <get_OnUpdateComment>b__26_6(string c);
    }

    private class <>c__DisplayClass43_0
    {
        public ENTERPRISE.Localization.LocalizationManager localizer;
        public PRISM.Interactions.LiveEventRankingOverlayView <>4__this;
        private string <ShowAsync>b__0(PRISM.Adapters.LiveEventRewardCategory i);
        private string <ShowAsync>b__1(PRISM.Adapters.LiveEventRankingCategory i);
        private void <ShowAsync>b__2(int _);
        private void <ShowAsync>g__SwitchTab|3();
    }

    private struct <ShowAsync>d__43 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.LiveEventRankingOverlayView <>4__this;
        public System.Threading.CancellationToken cancellationToken;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class LiveEventRankingTabView : UnityEngine.MonoBehaviour, System.IDisposable
{
    private PRISM.Interactions.ToggleGroupView tabGroup;
    private PRISM.Live.UserRankingView userRankingView;
    private PRISM.Interactions.LiveEventRankingListView liveEventRankingListView;
    private PRISM.Interactions.MusicDifficultyIcon difficultyIcon;
    private PRISM.Interactions.MusicBasicInfoView musicInfoView;
    private UnityEngine.UI.RawImage pointIcon;
    private PRISM.Interactions.LiveEventRankingAggregationView aggregationView;
    private PRISM.CommonInputFieldTMP commentInput;
    private PRISM.Adapters.LiveEventRankingTabViewModel viewModel;
    private bool isInitialized;
    private UniRx.Subject<int> onTabChanged;
    public System.IObservable<int> OnTabChanged { get; set; }
    public System.IObservable<string> OnEditComment { get; set; }
    public Cysharp.Threading.Tasks.UniTask ShowAsync(PRISM.Adapters.LiveEventRankingTabViewModel model, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken cancellationToken);
    private Cysharp.Threading.Tasks.UniTask _getListAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken cancellationToken);
    public void Dispose();

    private class <>c__DisplayClass15_0
    {
        public System.Threading.CancellationToken cancellationToken;
        public PRISM.Interactions.LiveEventRankingTabView <>4__this;
        private void <ShowAsync>b__0(PRISM.Adapters.LiveEventRankingCellViewModel model);
        private void <ShowAsync>b__1(string newComment);
    }

    private struct <ShowAsync>d__15 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public System.Threading.CancellationToken cancellationToken;
        public PRISM.Interactions.LiveEventRankingTabView <>4__this;
        public PRISM.Adapters.LiveEventRankingTabViewModel model;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private <>c__DisplayClass15_0 <>8__1;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_getListAsync>d__16 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.LiveEventRankingTabView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken cancellationToken;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class MusicDifficultyIcon : UnityEngine.MonoBehaviour
{
    private UnityEngine.GameObject[] musicDifficulties;
    public void Show(SongDifficultyLevel difficultyLevel);
}

// Namespace: PRISM.Interactions
public class LiveEventResultPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.ILiveEventResultPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private UnityEngine.UI.RawImage image;
    private ENTERPRISE.UI.UITextMeshProUGUI eventRankingText;
    private ENTERPRISE.UI.UITextMeshProUGUI highScoreRankingText;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClick;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void Inject(int eventRank, int scoreRank);
    public Cysharp.Threading.Tasks.UniTask LoadImageAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Definitions.MstEvent master, System.Threading.CancellationToken ct);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__6_0();
    private void <CreateFrameParameter>b__6_1();
}

// Namespace: PRISM.Interactions
public class LiveEventView : UnityEngine.MonoBehaviour, PRISM.Adapters.ILiveEventView
{
    private UnityEngine.UI.Image backgroundImage;
    private UnityEngine.Transform characterArea;
    private UnityEngine.UI.Image eventLogo;
    private UnityEngine.UI.Image eventLogoEffect;
    private PRISM.Interactions.EventDetailPanelView detailView;
    private PRISM.Interactions.ButtonWithBadgeView eventStoryButton;
    private PRISM.Interactions.ButtonWithBadgeView gashaButton;
    private PRISM.Interactions.ButtonView liveButton;
    private PRISM.Interactions.StaminaView liveBoostView;
    private PRISM.MoviePlayer moviePlayer;
    private PRISM.Interactions.Event.EventBonusRateView eventBonusView;
    private PRISM.HowToPlayPopupOpener howToPlayPopupOpener;
    private PRISM.Interactions.ButtonView resultButton;
    private PRISM.Interactions.ViewStateChanger resultButtonChanger;
    private PRISM.Interactions.ButtonView technicalChallengeButton;
    private PRISM.Interactions.ViewStateChanger technicalChallengeButtonStateChanger;
    private PRISM.Interactions.ButtonView albumButton;
    private UnityEngine.GameObject albumButtonBadge;
    private PRISM.Interactions.ButtonWithBadgeView medalExchangeButton;
    private PRISM.Interactions.Event.EventBreakTimeView liveEventBreakTimeView;
    private UnityEngine.UI.Image[] randomCharacterAreas;
    private PRISM.Adapters.LiveEventViewModel liveEventViewModel;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    public PRISM.Adapters.IStaminaView LiveBoostView { get; set; }
    public System.IObservable<UniRx.Unit> OnClickRankingButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickRewardButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickMissionButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickShopButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickEventBonusRateDetailButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickEventStoryButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickMedalGashaButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickLiveButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickTechnicalChallengeButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickAlbumButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickMedalExchangeButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickBreakTimeSettingButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickResultButton { get; set; }
    public void Inject(PRISM.Adapters.LiveEventViewModel liveEventViewModel);
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken cancellationToken);
    private Cysharp.Threading.Tasks.UniTask _updateViewAsync(System.Threading.CancellationToken cancellationToken);
    public void UpdateDetailAndButtons();
    public void UpdateBreakTime();
    public void UpdateAlbumBadge();
    private Cysharp.Threading.Tasks.UniTask _loadCharacterImageAsync(PRISM.Definitions.MstEvent eventMaster, System.Threading.CancellationToken cancellationToken);
    private Cysharp.Threading.Tasks.UniTask _loadRandomCharacterAsync(PRISM.Definitions.MstEvent eventMaster, System.Threading.CancellationToken cancellationToken);
    private Cysharp.Threading.Tasks.UniTask _loadBackgroundImageAsync(PRISM.Definitions.MstEvent eventMaster, System.Threading.CancellationToken cancellationToken);
    private Cysharp.Threading.Tasks.UniTask _loadLogoImageAsync(PRISM.Definitions.MstEvent eventMaster, System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <InitializeAsync>b__52_0(UniRx.Unit _);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Definitions.MstCharacterInfo, bool> <>9__58_0;
        public static System.Func<PRISM.Definitions.MstCharacterInfo, float> <>9__58_1;
        private bool <_loadRandomCharacterAsync>b__58_0(PRISM.Definitions.MstCharacterInfo m);
        private float <_loadRandomCharacterAsync>b__58_1(PRISM.Definitions.MstCharacterInfo _);
    }

    private class <>c__DisplayClass58_0
    {
        public PRISM.Interactions.LiveEventView <>4__this;
        public PRISM.Definitions.MstEvent eventMaster;
        public System.Threading.CancellationToken cancellationToken;
        private Cysharp.Threading.Tasks.UniTask <_loadRandomCharacterAsync>b__2(PRISM.Definitions.MstCharacterInfo chara, int index);
    }

    private struct <InitializeAsync>d__52 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.LiveEventView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken cancellationToken;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <TerminateAsync>d__61 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.LiveEventView <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_loadBackgroundImageAsync>d__59 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.LiveEventView <>4__this;
        public PRISM.Definitions.MstEvent eventMaster;
        public System.Threading.CancellationToken cancellationToken;
        private UnityEngine.UI.Image <>7__wrap1;
        private Awaiter<UnityEngine.Sprite> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_loadCharacterImageAsync>d__57 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.LiveEventView <>4__this;
        public PRISM.Definitions.MstEvent eventMaster;
        public System.Threading.CancellationToken cancellationToken;
        private Awaiter<UnityEngine.GameObject> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_loadLogoImageAsync>d__60 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.LiveEventView <>4__this;
        public PRISM.Definitions.MstEvent eventMaster;
        public System.Threading.CancellationToken cancellationToken;
        private UnityEngine.UI.Image <>7__wrap1;
        private Awaiter<UnityEngine.Sprite> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_loadRandomCharacterAsync>d__58 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.LiveEventView <>4__this;
        public PRISM.Definitions.MstEvent eventMaster;
        public System.Threading.CancellationToken cancellationToken;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_updateViewAsync>d__53 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.LiveEventView <>4__this;
        public System.Threading.CancellationToken cancellationToken;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class MedalGashaAllConfirmPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IMedalGashaAllConfirmPopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private ENTERPRISE.UI.UITextMeshProUGUI priceMedalAmountText;
    private ENTERPRISE.UI.UITextMeshProUGUI beforeMedalAmountText;
    private ENTERPRISE.UI.UITextMeshProUGUI afterMedalAmountText;
    private ENTERPRISE.UI.UITextMeshProUGUI messageText;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Assign(int price, long currentMedal, int count);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__8_0();
    private void <CreateFrameParameter>b__8_1();
    private void <CreateFrameParameter>b__8_2();
}

// Namespace: PRISM.Interactions
public class MedalGashaConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.MedalGashaArgument>, PRISM.IMedalGashaConnector
{
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
    protected PRISM.Adapters.MedalGashaArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
}

// Namespace: PRISM.Interactions
public class MedalGashaCountSettingPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IMedalGashaCountSettingPopupView, PRISM.Adapters.IClosablePopupFrame<System.ValueTuple<int, bool>>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<System.ValueTuple<int, bool>>
{
    private ENTERPRISE.UI.UITextMeshProUGUI priceMedalAmountText;
    private ENTERPRISE.UI.UITextMeshProUGUI beforeMedalAmountText;
    private ENTERPRISE.UI.UITextMeshProUGUI afterMedalAmountText;
    private ENTERPRISE.UI.UITextMeshProUGUI gashaAmountText;
    private PRISM.Interactions.ButtonView minusButton;
    private PRISM.Interactions.ButtonView plusButton;
    private UnityEngine.UI.Slider amountSlider;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<System.ValueTuple<int, bool>> onClosed;
    private int price;
    private long currentMedal;
    private bool isChangeValue;
    private bool isInitialized;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<System.ValueTuple<int, bool>> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Assign(int price, long currentMedal, int maxAmount, int lastAmount);
    private void _updateView();
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <Assign>b__14_0(float _);
    private void <Assign>b__14_1(UniRx.Unit _);
    private void <Assign>b__14_2(UniRx.Unit _);
    private void <CreateFrameParameter>b__16_0();
    private void <CreateFrameParameter>b__16_1();
    private void <CreateFrameParameter>b__16_2();
}

// Namespace: PRISM.Interactions
public class MedalGashaResultView : UnityEngine.MonoBehaviour, PRISM.Adapters.IMedalGashaResultView, PRISM.Adapters.IClosableOverlayView<UniRx.Unit>, PRISM.Adapters.IOverlayView, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private UnityEngine.UI.ScrollRect scrollView;
    private UnityEngine.Transform traItemRoot;
    private UnityEngine.GameObject goTemplateIco;
    private ENTERPRISE.UI.UIButton okButton;
    private UnityEngine.UI.Button skipAnimationButton;
    private UnityEngine.Animator medalGashaSequenceAnimator;
    private UnityEngine.Animator medalGashaRibbonAnimator;
    private UnityEngine.CanvasGroup uiCanvas;
    private UnityEngine.UI.ScrollRect scrollViewMini;
    private UnityEngine.Transform traItemRootMini;
    private UnityEngine.GameObject goTemplateIcoMini;
    private int miniGridDelayFrame;
    private EasingCore.Ease miniGridScrollEasing;
    private System.Collections.Generic.List<PRISM.Interactions.MedalGashaResultViewCell> cellList;
    private System.Threading.CancellationToken skipToken;
    private bool isUseMiniGrid;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public System.IObservable<UniRx.Unit> OnClickSkipButton { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.MedalGashaResultModel model, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken skipToken, System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken cancellationToken);
    private void _skipAll();
    private void _startBlinking();
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    private void <ShowAsync>b__21_0(UniRx.Unit _);
    private void <ShowAsync>b__21_1(UniRx.Unit _);

    private class <>c__DisplayClass20_0
    {
        public PRISM.Adapters.MedalGashaResultModel model;
        private PRISM.Interactions.MedalGashaResultViewCellModel <InitializeAsync>b__0(PRISM.Module.Networking.IRewardProductStatus r);
    }

    private class <>c__DisplayClass20_1
    {
        public PRISM.Module.Networking.IRewardProductStatus r;
        private bool <InitializeAsync>b__1(PRISM.Module.Networking.IMedalGashaRewardStatus f);
    }

    private struct <ShowAsync>d__21 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.MedalGashaResultView <>4__this;
        public System.Threading.CancellationToken cancellationToken;
        private System.Threading.CancellationTokenSource <linkedTokenSource>5__2;
        private System.Threading.CancellationToken <ct>5__3;
        private System.IDisposable <_>5__4;
        private Awaiter <>u__1;
        private int <count>5__5;
        private EasingCore.EasingFunction <easingFunction>5__6;
        private Enumerator<PRISM.Interactions.MedalGashaResultViewCell> <>7__wrap6;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class MedalGashaResultViewCellModel
{
    private PRISM.Module.Networking.IRewardProductStatus <Reward>k__BackingField;
    private bool <IsFeatured>k__BackingField;
    public PRISM.Module.Networking.IRewardProductStatus Reward { get; set; }
    public bool IsFeatured { get; set; }
}

// Namespace: PRISM.Interactions
public class MedalGashaResultViewCell : UnityEngine.MonoBehaviour
{
    private UnityEngine.Animator anim;
    private PRISM.Interactions.RewardItemIcon rewardItemIcon;
    private UnityEngine.GameObject objectNew;
    private UnityEngine.UI.RawImage imageConvertItem;
    private ENTERPRISE.UI.UITextMeshProUGUI textConvertAmount;
    private UnityEngine.CanvasGroup canvasGroupReward;
    private UnityEngine.CanvasGroup canvasGroupConvert;
    private bool isConvertProduct;
    private static float ChangeTime;
    private PRISM.Interactions.MedalGashaResultViewCellModel model;
    public void Initialize(PRISM.Interactions.MedalGashaResultViewCellModel cellModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public Cysharp.Threading.Tasks.UniTask PlayAsync(System.Threading.CancellationToken ct);
    public void Skip();
    public void StartBlinking();
    private void <StartBlinking>b__13_1(float val);
    private void <StartBlinking>b__13_3(float val);
    private void <StartBlinking>b__13_5(float val);
    private void <StartBlinking>b__13_7(float val);

    private class <>c
    {
        public static <>c <>9;
        public static DG.Tweening.Core.DOGetter<float> <>9__13_0;
        public static DG.Tweening.Core.DOGetter<float> <>9__13_2;
        public static DG.Tweening.Core.DOGetter<float> <>9__13_4;
        public static DG.Tweening.Core.DOGetter<float> <>9__13_6;
        private float <StartBlinking>b__13_0();
        private float <StartBlinking>b__13_2();
        private float <StartBlinking>b__13_4();
        private float <StartBlinking>b__13_6();
    }

    private struct <PlayAsync>d__11 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.MedalGashaResultViewCell <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class MedalGashaRewardAllListCell : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.RewardItemIcon icon;
    private ENTERPRISE.UI.UITextMeshProUGUI rewardCountText;
    private UnityEngine.GameObject countBase;
    private UnityEngine.GameObject completeObject;
    public void Show(int currentCount, int limitCount, bool isFeatured, PRISM.Module.Networking.IProductWithAmountStatus product, PRISM.ResourceManagement.IResourceLoader resourceLoader, bool isShowDetail, bool isShowAmount);
}

// Namespace: PRISM.Interactions
public class MedalGashaRewardAllListHeader : PRISM.EnhancedListViewCell<PRISM.Adapters.IMedalGashaRewardListData>
{
    private UnityEngine.GameObject featuredObject;
    public void SetData(PRISM.Adapters.IMedalGashaRewardListData data);
}

// Namespace: PRISM.Interactions
public class MedalGashaRewardAllListRow : PRISM.EnhancedListViewCell<PRISM.Adapters.IMedalGashaRewardListData>
{
    private UnityEngine.GameObject featuredObject;
    private PRISM.Interactions.MedalGashaRewardAllListCell cellPrefab;
    private UnityEngine.Transform iconArea;
    public void SetData(PRISM.Adapters.MedalGashaRewardBodyData data);
}

// Namespace: PRISM.Interactions
public class MedalGashaRewardAllListView : PRISM.EnhancedListView<PRISM.Adapters.IMedalGashaRewardListData>
{
    protected PRISM.Interactions.MedalGashaRewardAllListRow bodyRowPrefab;
    private int bodyRowSize;
    private int featuredBodyRowSize;
    protected PRISM.Interactions.MedalGashaRewardAllListHeader headerRowViewPrefab;
    private int headerSize;
    private int featuredHeaderSize;
    protected PRISM.Interactions.MedalGashaRewardAllListHeader footerRowViewPrefab;
    private int footerSize;
    private int nextStartingIndex;
    private PRISM.Adapters.MedalGashaRewardAllListViewModel model;
    public void Initialize(PRISM.Adapters.MedalGashaRewardAllListViewModel model);
    public void UpdateContents(float scrollPositionFactor);
    public int GetNumberOfCells(EnhancedUI.EnhancedScroller.EnhancedScroller scroller);
    public float GetCellViewSize(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex);
    public EnhancedUI.EnhancedScroller.EnhancedScrollerCellView GetCellView(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex, int cellIndex);
}

// Namespace: PRISM.Interactions
public class MedalGashaRewardIcon : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.RewardItemIcon icon;
    private ENTERPRISE.UI.UITextMeshProUGUI rewardCountText;
    public void Show(int rewardCount, PRISM.Module.Networking.IProductWithAmountStatus product, PRISM.ResourceManagement.IResourceLoader resourceLoader, bool isShowDetail, bool isShowAmount);
}

// Namespace: PRISM.Interactions
public class MedalGashaRewardListCell : PRISM.EnhancedListViewCell<PRISM.Adapters.MedalGashaRewardListViewModel>
{
    private ENTERPRISE.UI.UITextMeshProUGUI boxNumberText;
    private PRISM.Interactions.MedalGashaRewardIcon iconBase;
    private UnityEngine.Transform iconArea;
    public void UpdateContent(PRISM.Adapters.MedalGashaRewardListViewModel data);
}

// Namespace: PRISM.Interactions
public class MedalGashaRewardListView : PRISM.EnhancedListView<PRISM.Adapters.MedalGashaRewardListViewModel>
{
}

// Namespace: PRISM.Interactions
public class MedalGashaRewardTabView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.MedalGashaRewardListView rewardListView;
    private UnityEngine.CanvasGroup rewardListCanvas;
    public void Show(PRISM.Adapters.MedalGashaRewardTabViewModel model, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Interactions
public class MedalGashaView : UnityEngine.MonoBehaviour, PRISM.Adapters.IMedalGashaView
{
    private UnityEngine.UI.Image backgroundImage;
    private UnityEngine.UI.Image eventLogo;
    private UnityEngine.UI.Image eventLogoEffect;
    private ENTERPRISE.UI.UITextMeshProUGUI boxNumberText;
    private ENTERPRISE.UI.UITextMeshProUGUI endDateText;
    private PRISM.Interactions.MedalGashaRewardAllListView rewardListView;
    private UnityEngine.GameObject warnText;
    private UnityEngine.GameObject okText;
    private PRISM.Interactions.GashaTokenArea gashaTokenArea;
    private PRISM.Interactions.GashaButton gashaButtonSingle;
    private PRISM.Interactions.GashaButton gashaButtonMultiple;
    private PRISM.UIGrayOutController grayOutSingle;
    private PRISM.UIGrayOutController grayOutMultiple;
    private ENTERPRISE.UI.UIButton helpButton;
    private ENTERPRISE.UI.UIButton proceedNextButton;
    private ENTERPRISE.UI.UIButton featuredRewardButton;
    private PRISM.HowToPlayPopupOpener howToPlayPopupOpener;
    private UnityEngine.GameObject[] proceedNextObjects;
    private UnityEngine.Animator[] proceedNextAnimations;
    private UnityEngine.UI.Toggle lockCheckBox;
    private UnityEngine.GameObject lockCheckBoxObject;
    private ENTERPRISE.UI.UIButton lockedButton;
    private UnityEngine.GameObject unlockWarningBalloonObject;
    private int maxGashaCount;
    private UniRx.Subject<System.ValueTuple<PRISM.Adapters.MedalGashaStatusModel, string, string, int>> onClickGasha;
    private PRISM.Adapters.MedalGashaRewardAllListViewModel gashaModel;
    private PRISM.Adapters.MedalGashaStatusModel statusModel;
    public System.IObservable<System.ValueTuple<PRISM.Adapters.MedalGashaStatusModel, string, string, int>> OnClickGasha { get; set; }
    public System.IObservable<UniRx.Unit> OnClickProceedNext { get; set; }
    public System.IObservable<UniRx.Unit> OnClickFeaturedReward { get; set; }
    public System.IObservable<bool> OnClickLockCheckBox { get; set; }
    public System.IObservable<UniRx.Unit> OnClickLockedButton { get; set; }
    public void Inject(PRISM.Adapters.MedalGashaRewardAllListViewModel gashaModel, PRISM.Adapters.MedalGashaStatusModel statusModel);
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken cancellationToken);
    public void UpdateView();
    public Cysharp.Threading.Tasks.UniTask PlayProceedNextAnimationAsync(System.Threading.CancellationToken ct);
    public void UpdateLockStatus(bool isOn);
    public void PlayCheckboxAnimation();
    private void _updateView();
    private Cysharp.Threading.Tasks.UniTask _loadBackgroundAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Definitions.MstEvent eventMaster, System.Threading.CancellationToken cancellationToken);
    private Cysharp.Threading.Tasks.UniTask _loadLogoImageAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Definitions.MstEvent eventMaster, System.Threading.CancellationToken cancellationToken);
    public void Terminate();
    private void <InitializeAsync>b__38_0();
    private UnityEngine.Vector3 <PlayCheckboxAnimation>b__42_0();
    private void <PlayCheckboxAnimation>b__42_1(UnityEngine.Vector3 x);
    private void <_updateView>b__43_0(PRISM.Module.Networking.IGashaPriceStatus price, System.ValueTuple<PRISM.Interactions.GashaButton, PRISM.UIGrayOutController> buttons);
    private void <_updateView>g__OnClickGashaDelegate|43_1(string gashaId, string priceId);

    private class <>c__DisplayClass40_0
    {
        public System.Threading.CancellationToken ct;
        private Cysharp.Threading.Tasks.UniTask <PlayProceedNextAnimationAsync>b__0(UnityEngine.Animator a);
    }

    private struct <InitializeAsync>d__38 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.MedalGashaView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken cancellationToken;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <PlayProceedNextAnimationAsync>d__40 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public System.Threading.CancellationToken ct;
        public PRISM.Interactions.MedalGashaView <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_loadBackgroundAsync>d__44 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.MedalGashaView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public PRISM.Definitions.MstEvent eventMaster;
        public System.Threading.CancellationToken cancellationToken;
        private UnityEngine.UI.Image <>7__wrap1;
        private Awaiter<UnityEngine.Sprite> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_loadLogoImageAsync>d__45 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.MedalGashaView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public PRISM.Definitions.MstEvent eventMaster;
        public System.Threading.CancellationToken cancellationToken;
        private UnityEngine.UI.Image <>7__wrap1;
        private Awaiter<UnityEngine.Sprite> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class LiveAllSongEventResultIdolCell : UnityEngine.MonoBehaviour
{
    private PRISM.UI.PFIdolIconView icon;
    private PRISM.Interactions.LiveEventRankingGradeIcon gradeIcon;
    private UnityEngine.GameObject noneObject;
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(int idolId, EventRankGrade grade, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken cancellationToken);
}

// Namespace: PRISM.Interactions
public class LiveAllSongEventResultOverlayView : UnityEngine.MonoBehaviour, PRISM.Adapters.ILiveAllSongEventResultOverlayView, PRISM.Adapters.IClosableOverlayView<UniRx.Unit>, PRISM.Adapters.IOverlayView, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private TMPro.TextMeshProUGUI pointRankingText;
    private TMPro.TextMeshProUGUI highScoreRankingText;
    private PRISM.Interactions.LiveAllSongEventResultIdolCell idolCellBase;
    private UnityEngine.GameObject presentText;
    private ENTERPRISE.UI.UIButton closeButton;
    private UnityEngine.UI.Image resultImage;
    private System.IDisposable backKeyDisposable;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.LiveAllSongEventResultViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken cancellationToken);
    private Cysharp.Threading.Tasks.UniTask PRISM.Adapters.IOverlayView.ShowAsync(System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask PRISM.Adapters.IOverlayView.HideAsync();

    private class <>c__DisplayClass9_0
    {
        public PRISM.Interactions.LiveAllSongEventResultOverlayView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken cancellationToken;
        private Cysharp.Threading.Tasks.UniTask <InitializeAsync>b__0(System.ValueTuple<int, EventRankGrade> x);
    }
}

// Namespace: PRISM.Interactions
public class LiveEventAlbumCell : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UIButton button;
    private UnityEngine.GameObject unlockedObject;
    private UnityEngine.GameObject lockedObject;
    private TMPro.TextMeshProUGUI lockedText;
    public System.IObservable<UniRx.Unit> OnClick { get; set; }
    public void Setup(PRISM.Module.Networking.IEventAlbumStatus data);
}

// Namespace: PRISM.Interactions
public class LiveEventAlbumOverlayView : PRISM.Interactions.OverlayViewWithCloseButton, PRISM.Adapters.ILiveEventAlbumOverlayView, PRISM.Adapters.IClosableOverlayView<UniRx.Unit>, PRISM.Adapters.IOverlayView, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.LiveEventAlbumCell[] cells;
    private UnityEngine.UI.Image expandImage;
    private UnityEngine.UI.Button expandFinishButton;
    public System.IObservable<int> OnSelect { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(int eventId, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IEventAlbumStatus> albumList, System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask ExpandAsync(PRISM.Module.Networking.IEventAlbumStatus album, PRISM.ResourceManagement.IResourceLoader loader);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Interactions.LiveEventAlbumCell, int, System.IObservable<int>> <>9__4_0;
        public static System.Action<PRISM.Interactions.LiveEventAlbumCell, PRISM.Module.Networking.IEventAlbumStatus> <>9__5_0;
        private System.IObservable<int> <get_OnSelect>b__4_0(PRISM.Interactions.LiveEventAlbumCell cell, int index);
        private void <InitializeAsync>b__5_0(PRISM.Interactions.LiveEventAlbumCell cell, PRISM.Module.Networking.IEventAlbumStatus data);
    }

    private class <>c__DisplayClass4_0
    {
        public int index;
        private int <get_OnSelect>b__1(UniRx.Unit _);
    }

    private struct <ExpandAsync>d__6 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Module.Networking.IEventAlbumStatus album;
        public PRISM.Interactions.LiveEventAlbumOverlayView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader loader;
        private System.Threading.CancellationTokenSource <cts>5__2;
        private UnityEngine.UI.Image <>7__wrap2;
        private Awaiter<UnityEngine.Sprite> <>u__1;
        private Awaiter<int> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class LiveEventBonusOverlayView : PRISM.Interactions.OverlayViewWithCloseButton, PRISM.Adapters.ILiveEventBonusOverlayView, PRISM.Adapters.IClosableOverlayView<UniRx.Unit>, PRISM.Adapters.IOverlayView, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private ENTERPRISE.UI.UITextMeshProUGUI descriptionText;
    private PRISM.Interactions.Event.LiveEventBonusListView listView;
    private PRISM.Interactions.Event.EventBonusRateView rateView;
    private ENTERPRISE.UI.UIButton changeModeButton;
    private ENTERPRISE.UI.UIButton idolUpgradingButton;
    public System.IObservable<UniRx.Unit> OnClickIdolUpgradingButton { get; set; }
    public void Initialize(PRISM.Definitions.MstEvent eventMaster, int bonusRate, System.Collections.Generic.IList<PRISM.Adapters.LiveEventBonusListCellViewModel> models, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private void <Initialize>b__7_0();
}

// Namespace: PRISM.Interactions
public class LiveEventBreakTimeSettingCell : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UIButton button;
    private PRISM.UIGrayOutController grayOutController;
    private UnityEngine.GameObject selectedObject;
    private UnityEngine.GameObject unselectedObject;
    private ENTERPRISE.UI.UITextMeshProUGUI[] texts;
    public System.IObservable<UniRx.Unit> OnClick { get; set; }
    public void Render(PRISM.Module.Networking.IEventBreakTimeOptionStatus status);
}

// Namespace: PRISM.Interactions
public class LiveEventBreakTimeSettingOverlayView : PRISM.Interactions.OverlayViewWithCloseButton, PRISM.Adapters.ILiveEventBreakTimeSettingOverlayView, PRISM.Adapters.IClosableOverlayView<UniRx.Unit>, PRISM.Adapters.IOverlayView, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private ENTERPRISE.UI.UITextMeshProUGUI descriptionText;
    private PRISM.Interactions.LiveEventBreakTimeSettingCell cellBase;
    private UniRx.Subject<int> onSelect;
    private System.Collections.Generic.List<PRISM.Interactions.LiveEventBreakTimeSettingCell> cellList;
    private UniRx.CompositeDisposable disposables;
    public System.IObservable<int> OnSelect { get; set; }
    public void Initialize(int eventId);
    public void Render(PRISM.Module.Networking.IEventBreakTimeStatus status);
    private Cysharp.Threading.Tasks.UniTask PRISM.Adapters.IOverlayView.HideAsync();

    private class <>c__DisplayClass8_0
    {
        public int index;
        public PRISM.Interactions.LiveEventBreakTimeSettingOverlayView <>4__this;
        private void <Render>b__0(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions
public class TechnicalChallengeResultOverlayView : UnityEngine.MonoBehaviour, PRISM.Adapters.ITechnicalChallengeResultOverlayView, PRISM.Adapters.IClosableOverlayView<UniRx.Unit>, PRISM.Adapters.IOverlayView, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.ButtonView closeButton;
    private UnityEngine.UI.Image resultImage;
    private PRISM.Interactions.TechnicalChallengeUserInfoView userInfoView;
    private UnityEngine.UI.RawImage jacketImage;
    private PRISM.Interactions.TechnicalRankIcon rankIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI masterLevelText;
    private ENTERPRISE.UI.UITextMeshProUGUI masterScoreText;
    private ENTERPRISE.UI.UITextMeshProUGUI masterRankText;
    private ENTERPRISE.UI.UITextMeshProUGUI expertLevelText;
    private ENTERPRISE.UI.UITextMeshProUGUI expertScoreText;
    private ENTERPRISE.UI.UITextMeshProUGUI expertRankText;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.TechnicalChallengeResultOverlayViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask PRISM.Adapters.IOverlayView.ShowAsync(System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask PRISM.Adapters.IOverlayView.HideAsync();
    private string _getScoreText(int score);
    private string _getRankText(int rank);

    private struct <InitializeAsync>d__13 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.TechnicalChallengeResultOverlayView <>4__this;
        public PRISM.Adapters.TechnicalChallengeResultOverlayViewModel viewModel;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class TechnicalChallengeRewardListCell : PRISM.Interactions.ListViewCell<PRISM.Definitions.MstTechnicalRankReward>
{
    private ENTERPRISE.UI.UITextMeshProUGUI titleText;
    private ENTERPRISE.UI.UITextMeshProUGUI targetScoreText;
    private UnityEngine.Transform rewardIconContainer;
    private ENTERPRISE.OutGame.RewardItem rewardIconBase;
    private PRISM.Interactions.SimpleAchievementIcon achievementIconBase;
    private PRISM.Interactions.TechnicalRankIcon rankIcon;
    private PRISM.Interactions.ViewStateChanger rankFrameChanger;
    private PRISM.AutoCancellationTokenSource canceller;
    public void UpdateContent(PRISM.Definitions.MstTechnicalRankReward rankReward);
    private void OnDestroy();

    private class <>O
    {
        public static System.Func<string, PRISM.Domain.ProductKeyWithAmount> <0>__ParseProductIdWithAmount;
    }

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Domain.ProductKeyWithAmount, bool> <>9__8_0;
        public static System.Func<PRISM.Domain.ProductKeyWithAmount, bool> <>9__8_1;
        private bool <UpdateContent>b__8_0(PRISM.Domain.ProductKeyWithAmount r);
        private bool <UpdateContent>b__8_1(PRISM.Domain.ProductKeyWithAmount r);
    }
}

// Namespace: PRISM.Interactions
public class TechnicalChallengeRewardListView : PRISM.Interactions.ListView<PRISM.Interactions.TechnicalChallengeRewardListCell, PRISM.Definitions.MstTechnicalRankReward>
{
}

// Namespace: PRISM.Interactions
public class TechnicalChallengeRewardTabView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.TechnicalChallengeRewardListView rewardListView;
    public void Show(PRISM.Adapters.TechnicalChallengeRewardTabViewModel model, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Interactions
public class TechnicalChallengeTopChallengeSongView : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.RawImage jacketImage;
    private PRISM.Interactions.TechnicalRankIcon rankIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI songNameText;
    private ENTERPRISE.UI.UITextMeshProUGUI masterLvText;
    private ENTERPRISE.UI.UITextMeshProUGUI masterHighScoreText;
    private ENTERPRISE.UI.UITextMeshProUGUI masterRankText;
    private ENTERPRISE.UI.UITextMeshProUGUI expertLvText;
    private ENTERPRISE.UI.UITextMeshProUGUI expertHighScoreText;
    private ENTERPRISE.UI.UITextMeshProUGUI expertRankText;
    private ENTERPRISE.UI.UITextMeshProUGUI resultDateText;
    private PRISM.Interactions.ViewStateChanger aggregationStateChanger;
    public void Setup(PRISM.Adapters.TechnicalChallengeTopViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    private string _getScoreText(int score);
    private string _getRankText(int rank);
}

// Namespace: PRISM.Interactions
public class TechnicalChallengeTopConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.TechnicalChallengeTopArgument>, PRISM.ITechnicalChallengeTopConnector
{
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
    protected PRISM.Adapters.TechnicalChallengeTopArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
}

// Namespace: PRISM.Interactions
public class TechnicalChallengeTopView : UnityEngine.MonoBehaviour, PRISM.Adapters.ITechnicalChallengeTopView
{
    private UnityEngine.UI.Image backgroundImage;
    private PRISM.Interactions.ButtonView liveButton;
    private PRISM.Interactions.ButtonView howToPlayButton;
    private PRISM.Interactions.ButtonView rewardButton;
    private PRISM.Interactions.ButtonView rankingButton;
    private PRISM.Interactions.ButtonWithBadgeView missionButton;
    private PRISM.Interactions.ButtonView liveSettingButton;
    private PRISM.HowToPlayPopupOpener howToPlayPopupOpener;
    private PRISM.Interactions.ButtonView rankingResultButton;
    private PRISM.Interactions.TechnicalChallengeTopChallengeSongView challengeSongView;
    private PRISM.Interactions.ToggleGroupView difficultyToggleGroup;
    private PRISM.RhythmGame.NumberSpriteView eventNumberView;
    private ENTERPRISE.UI.UITextMeshProUGUI ticketCountText;
    private ENTERPRISE.UI.UITextMeshProUGUI dateText;
    private ENTERPRISE.UI.UITextMeshProUGUI remainTimeText;
    private UnityEngine.UI.RawImage ticketIcon;
    private UnityEngine.UI.RawImage buttonTicketIcon;
    private PRISM.Interactions.ViewStateChanger liveButtonChanger;
    private PRISM.Interactions.ViewStateChanger displayTicketChanger;
    private PRISM.Interactions.ViewStateChanger remainTextChanger;
    private PRISM.Interactions.ViewStateChanger rankingResultActiveChanger;
    private PRISM.Interactions.ViewStateChanger rankingResultButtonChanger;
    private PRISM.Interactions.ViewStateChanger liveOpenedChanger;
    private PRISM.Interactions.ViewStateChanger displayDMMChanger;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    private System.IDisposable checkRefreshDisposable;
    private UniRx.Subject<UniRx.Unit> onRefresh;
    public System.IObservable<UniRx.Unit> OnClickLiveButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickHowToPlayButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickRewardButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickRankingButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickMissionButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickLiveSettingButton { get; set; }
    public PRISM.HowToPlayPopupOpener HowToPlayPopupOpener { get; set; }
    public System.IObservable<UniRx.Unit> OnClickRankingResultButton { get; set; }
    public System.IObservable<UniRx.Unit> OnRefresh { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.TechnicalChallengeTopViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    public void UpdateView(PRISM.Adapters.TechnicalChallengeTopViewModel viewModel, System.Threading.CancellationToken ct);
    private void _checkRefreshDateTime(PRISM.Adapters.TechnicalChallengeTopViewModel viewModel);

    private class <>c__DisplayClass47_0
    {
        public PRISM.Interactions.TechnicalChallengeTopView <>4__this;
        public PRISM.Adapters.TechnicalChallengeTopViewModel viewModel;
        private void <UpdateView>b__0(long amount);
        private void <UpdateView>b__1(long _);
    }
}

// Namespace: PRISM.Interactions.Event
public class EventBonusRateView : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI bonusText;
    private PRISM.Interactions.ButtonView showDetailButton;
    public System.IObservable<UniRx.Unit> OnClickShowDetail { get; set; }
    public void Show(int bonusRate);
}

// Namespace: PRISM.Interactions.Event
public class EventBreakTimeView : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI beginText;
    private ENTERPRISE.UI.UITextMeshProUGUI endText;
    private PRISM.Interactions.ButtonView settingButton;
    public System.IObservable<UniRx.Unit> OnClickSetting { get; set; }
    public void Show(PRISM.Module.Networking.IEventBreakTimeStatus status);
}

// Namespace: PRISM.Interactions.Event
public class LiveEventBonusListCell : PRISM.Interactions.GridViewCell<PRISM.Adapters.LiveEventBonusListCellViewModel, PRISM.Interactions.Event.LiveEventBonusListContext>
{
    private UnityEngine.GameObject totalObject;
    private UnityEngine.GameObject detailObject;
    private ENTERPRISE.UI.UITextMeshProUGUI idolName;
    private PRISM.UI.PFIdolIconView idolIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI bonusRateText;
    private ENTERPRISE.UI.UITextMeshProUGUI maxRateText;
    private ENTERPRISE.UI.UITextMeshProUGUI baseEffectText;
    private ENTERPRISE.UI.UITextMeshProUGUI baseMaxText;
    private ENTERPRISE.UI.UITextMeshProUGUI starEffectText;
    private ENTERPRISE.UI.UITextMeshProUGUI starMaxText;
    private ENTERPRISE.UI.UITextMeshProUGUI lvEffectText;
    private ENTERPRISE.UI.UITextMeshProUGUI lvMaxText;
    private UnityEngine.Color deniedColor;
    private UnityEngine.Color availableColor;
    private UnityEngine.Color maxColor;
    private UnityEngine.GameObject grayOutObject;
    private UniRx.CompositeDisposable disposables;
    private PRISM.AutoCancellationTokenSource canceller;
    public void UpdateContent(PRISM.Adapters.LiveEventBonusListCellViewModel viewModel);
    private void OnDestroy();
    private static void <UpdateContent>g__SetDetailText|18_2(ENTERPRISE.UI.UITextMeshProUGUI current, ENTERPRISE.UI.UITextMeshProUGUI limit, PRISM.Module.Networking.ILimitedValueStatus model, UnityEngine.Color textColor);

    private class <>c__DisplayClass18_0
    {
        public bool hasBonus;
        public PRISM.Adapters.LiveEventBonusListCellViewModel viewModel;
        public System.Threading.CancellationToken token;
        public PRISM.Interactions.Event.LiveEventBonusListCell <>4__this;
        private Cysharp.Threading.Tasks.UniTaskVoid <UpdateContent>b__0(System.ValueTuple<int, UnityEngine.GameObject> _);
        private void <UpdateContent>b__1(bool isShowDetail);

        private struct <<UpdateContent>b__0>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
        {
            public int <>1__state;
            public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
            public <>c__DisplayClass18_0 <>4__this;
            private Awaiter<bool> <>u__1;
            private void MoveNext();
            private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }
}

// Namespace: PRISM.Interactions.Event
public class LiveEventBonusListContext : PRISM.Interactions.GridViewContext
{
    public UniRx.ReactiveProperty<bool> IsShowDetail;
    public void Dispose();
}

// Namespace: PRISM.Interactions.Event
public class LiveEventBonusListView : PRISM.Interactions.GridView<PRISM.Interactions.Event.LiveEventBonusListCell, PRISM.Adapters.LiveEventBonusListCellViewModel, PRISM.Interactions.Event.LiveEventBonusListContext>
{
    protected void SetupCellTemplate();
    public void ToggleDetail();

    private class CellGroup : DefaultCellGroup<PRISM.Adapters.LiveEventBonusListCellViewModel, PRISM.Interactions.Event.LiveEventBonusListContext>
    {
    }
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=3609 2CC2035E637CC72BAA8A06D5DE29F0AB721C2962AF7769B825461FA024AFAECF;
    private static __StaticArrayInitTypeSize=5792 700A00D5AEABF1854E66B215F5DC392E63EA04F5637E7612E35A20486EBAE7A3;

    private struct __StaticArrayInitTypeSize=3609 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=5792 : System.ValueType
    {
    }
}
