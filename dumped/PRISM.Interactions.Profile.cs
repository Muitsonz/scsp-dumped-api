
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
public class ProfileGuestCharaSelectOverlayView : PRISM.Interactions.OverlayViewWithOkCancelButton<int>, PRISM.Adapters.IProfileGuestCharaSelectOverlayView, PRISM.Adapters.IClosableOverlayView<int>, PRISM.Adapters.IOverlayView, PRISM.Adapters.IClosable<int>
{
    private PRISM.Interactions.ProduceIdolIconView selectionIdolIconView;
    private PRISM.Interactions.ButtonView selectionIdolIconButton;
    private UnityEngine.GameObject selectionIdolEmptyView;
    private UnityEngine.UI.RawImage selectionIdolFavoriteIconImage;
    private ENTERPRISE.UI.UITextMeshProUGUI skillLabel;
    private ENTERPRISE.UI.UITextMeshProUGUI skillName;
    private ENTERPRISE.UI.UITextMeshProUGUI skillDetail;
    private PRISM.Interactions.ProduceIdolIconListView piView;
    private ENTERPRISE.UI.UITextMeshProUGUI positiveButtonText;
    private UniRx.CompositeDisposable disposables;
    private PRISM.Adapters.ProfileGuestCharaSelectOverlayViewModel model;
    public PRISM.Adapters.IProduceIdolIconListView PIdolView { get; set; }
    public System.IObservable<UniRx.Unit> OnSelectionDetail { get; set; }
    public System.IObservable<int> OnSelectionChanged { get; set; }
    public System.IObservable<int> OnDetail { get; set; }
    public void Initialize(PRISM.Adapters.ProfileGuestCharaSelectOverlayViewModel model, PRISM.Adapters.ListProduceIdolIconViewModel selectionIconViewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public void SetProduceIdol(PRISM.Adapters.ListProduceIdolIconViewModel model, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    protected int _createReturnValue(bool isOk);

    private class <>c__DisplayClass20_0
    {
        public PRISM.Interactions.ProfileGuestCharaSelectOverlayView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        private void <SetProduceIdol>b__0(int id);
    }
}

// Namespace: PRISM.Interactions.Profile
public class GuestIdolIconViewWithSelector : PRISM.Interactions.ProduceIdolIconViewWithSelector
{
    private UnityEngine.UI.RawImage favoriteIconImage;
    private ENTERPRISE.UI.UITextMeshProUGUI liveCenterEffectText;
    private UniRx.CompositeDisposable disposables;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    public void Initialize(PRISM.Interactions.CharacterSelectClickObservableInt context);
    public Cysharp.Threading.Tasks.UniTask UpdateViewAsync(PRISM.Adapters.ListProduceIdolIconViewModel vm, int dataIndex, System.Threading.CancellationToken ct);

    private class <>c__DisplayClass5_0
    {
        public PRISM.Interactions.Profile.GuestIdolIconViewWithSelector <>4__this;
        public System.Threading.CancellationToken ct;
        private void <UpdateViewAsync>b__0(int id);
    }
}

// Namespace: PRISM.Interactions.Profile
public class ProfileEventArchiveListView : PRISM.CommonListView<PRISM.Interactions.Profile.ProfileEventArchiveListViewCell, PRISM.Adapters.ProfileEventArchiveViewModel, PRISM.CommonListViewContext>
{
}

// Namespace: PRISM.Interactions.Profile
public class ProfileEventArchiveListViewCell : PRISM.CommonListViewCell<PRISM.Adapters.ProfileEventArchiveViewModel, PRISM.CommonListViewContext>
{
    private ENTERPRISE.UI.UITextMeshProUGUI eventTitleText;
    private UnityEngine.UI.Image eventSpriteImage;
    private ENTERPRISE.UI.UITextMeshProUGUI expiryDate;
    public void UpdateContent(PRISM.Adapters.ProfileEventArchiveViewModel viewModel);
    private Cysharp.Threading.Tasks.UniTask _loadEventImageAsync(PRISM.Adapters.ProfileEventArchiveViewModel viewModel);

    private struct <_loadEventImageAsync>d__4 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Adapters.ProfileEventArchiveViewModel viewModel;
        public PRISM.Interactions.Profile.ProfileEventArchiveListViewCell <>4__this;
        private UnityEngine.UI.Image <>7__wrap1;
        private Awaiter<UnityEngine.Sprite> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Profile
public class ProfileHistoryPanelView : UnityEngine.MonoBehaviour, System.IDisposable
{
    private ENTERPRISE.UI.UITabGroup uiTabGroup;
    private UnityEngine.GameObject[] panelViewObjects;
    private ENTERPRISE.UI.UITextMeshProUGUI workingDaysText;
    private ENTERPRISE.UI.UITextMeshProUGUI firstWorkDayText;
    private ENTERPRISE.UI.UITextMeshProUGUI produceIdolText;
    private ENTERPRISE.UI.UITextMeshProUGUI evolveCountText;
    private ENTERPRISE.UI.UITextMeshProUGUI limitBreakCountText;
    private ENTERPRISE.UI.UITextMeshProUGUI costumeCountText;
    private ENTERPRISE.UI.UITextMeshProUGUI supportIdolText;
    private ENTERPRISE.UI.UITextMeshProUGUI masterTrainingCountText;
    private ENTERPRISE.UI.UITextMeshProUGUI totalFanText;
    private ENTERPRISE.UI.UITextMeshProUGUI exTotalFanText;
    private ENTERPRISE.UI.UITextMeshProUGUI storyReadTotalCountText;
    private ENTERPRISE.UI.UITextMeshProUGUI storyReadMainCountText;
    private ENTERPRISE.UI.UITextMeshProUGUI storyReadIdolCountText;
    private PRISM.Interactions.Profile.ProfileLiveCountView livePlayCountView;
    private PRISM.Interactions.Profile.ProfileLiveCountView fullComboCountView;
    private PRISM.Interactions.Profile.ProfileLiveCountView allGreatCountView;
    private PRISM.Interactions.Profile.ProfileLiveCountView allPerfectCountView;
    private PRISM.Interactions.Profile.ProfileLiveCountView allShinyCountView;
    private ENTERPRISE.UI.UITextMeshProUGUI produceFinishTotalCountText;
    private ENTERPRISE.UI.UITextMeshProUGUI[] produceFinishCountTexts;
    private ENTERPRISE.UI.UITextMeshProUGUI unitTotalRankCountText;
    private ENTERPRISE.UI.UIButton unitRankCountDetailButton;
    private ENTERPRISE.UI.UITextMeshProUGUI produceCardText;
    private ENTERPRISE.UI.UITextMeshProUGUI produceCardUnitText;
    private ENTERPRISE.UI.UIButton produceCardSummaryButton;
    private PRISM.Interactions.ViewStateChanger liveHighScoreArchiveViewChanger;
    private ENTERPRISE.UI.UITextMeshProUGUI liveHighScoreArchiveLabelText;
    private PRISM.Interactions.ButtonView liveHighScoreArchiveDetailButton;
    private PRISM.Interactions.Profile.ProfileEventArchiveListView eventListView;
    private PRISM.Interactions.Profile.ProfileSeasonArchiveListView seasonListView;
    private UniRx.Subject<int> onSeletedTab;
    private UniRx.Subject<int> onClickHistoryEventDetail;
    public System.IObservable<int> OnSelectedTabObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnUnitRankCountDetailObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnProduceCardSummaryObservable { get; set; }
    public System.IObservable<int> OnClickHistoryEventDetailObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnClickLiveHighScoreArchiveDetailButton { get; set; }
    public void Initialize(PRISM.Adapters.ProfileHistoryPanelViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void SetActivePanelViewObject(int index, bool isActive);
    public void Dispose();
    private void _setCountText(ENTERPRISE.UI.UITextMeshProUGUI[] texts, int[] values);
    private void <Initialize>b__44_0(int index, ENTERPRISE.UI.UITabGroup _);
    private void <Initialize>b__44_1(int index);
}

// Namespace: PRISM.Interactions.Profile
public class ProfileProduceCardSummaryListView : PRISM.Interactions.ListView<PRISM.Interactions.Profile.ProfileProduceCardSummaryListViewCell, PRISM.Adapters.ProfileProduceCardSummaryViewModel>
{
}

// Namespace: PRISM.Interactions.Profile
public class ProfileProduceCardSummaryListViewCell : PRISM.Interactions.ListViewCell<PRISM.Adapters.ProfileProduceCardSummaryViewModel>
{
    private ENTERPRISE.UI.UITextMeshProUGUI titleText;
    private ENTERPRISE.UI.UITextMeshProUGUI summaryText;
    public void UpdateContent(PRISM.Adapters.ProfileProduceCardSummaryViewModel viewModel);
}

// Namespace: PRISM.Interactions.Profile
public class ProfileSeasonArchiveListView : PRISM.Interactions.ListView<PRISM.Interactions.Profile.ProfileSeasonArchiveListViewCell, PRISM.Adapters.ProfileSeasonArchiveViewModel>
{
}

// Namespace: PRISM.Interactions.Profile
public class ProfileSeasonArchiveListViewCell : PRISM.Interactions.ListViewCell<PRISM.Adapters.ProfileSeasonArchiveViewModel>
{
    private UnityEngine.UI.Image seasonImage;
    private ENTERPRISE.UI.UITextMeshProUGUI expiryDate;
    private ENTERPRISE.UI.UITextMeshProUGUI achieveRank;
    private UnityEngine.GameObject passIconObject;
    private PRISM.AutoCancellationTokenSource canceller;
    public void UpdateContent(PRISM.Adapters.ProfileSeasonArchiveViewModel viewModel);
}

// Namespace: PRISM.Interactions.Profile
public class ProfileUserSelfOverlayView : PRISM.Interactions.OverlayViewWithCloseButton, PRISM.Adapters.IProfileUserSelfOverlayView, PRISM.Adapters.IClosableOverlayView<UniRx.Unit>, PRISM.Adapters.IOverlayView, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.Profile.ProfileCategoryTabListView tabListView;
    private UnityEngine.GameObject[] panelViewObjects;
    private PRISM.Interactions.Profile.ProfileUserSelfPanelView userSelfPanelView;
    private PRISM.Interactions.Profile.ProfileProgressPanelView progressPanelView;
    private PRISM.Interactions.Profile.ProfileHistoryPanelView historyPanelView;
    private PRISM.Adapters.ProfileUserSalfViewModel viewModel;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    public System.Action<int> OnTabCellClicked { get; set; }
    public System.IObservable<int> OnPIdolDetailObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnChangeFavoriteObservable { get; set; }
    public System.IObservable<System.ValueTuple<Attribute, int>> OnChangeGuestObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnChangeNameObservable { get; set; }
    public System.IObservable<System.ValueTuple<int, int>> OnClickAchievementObservalbe { get; set; }
    public System.IObservable<System.ValueTuple<int, int>> OnLongPressAchievementObservalbe { get; set; }
    public System.IObservable<UniRx.Unit> OnChangeBirthdayObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnChangeCommentObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnClickSCharaObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnSCharaDetailObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnFesUnitRankDetailObservable { get; set; }
    public System.IObservable<int> OnSelectedHistoryTabObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnUnitRankCountDetailObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnProduceCardSummaryObservable { get; set; }
    public System.IObservable<int> OnClickHistoryEventDetailObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnClickLiveHighScoreArchiveDetailButton { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.ProfileUserSalfViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public void SetCatetoryTabSelected(int selectIndex);
    public void SetActivePanelViewObject(int index, bool isActive);
    public Cysharp.Threading.Tasks.UniTask UserSalfPanelInitializeAsync(PRISM.Adapters.ProfileUserSalfViewModel viewModel, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask SetProduceIdolAsync(PRISM.Adapters.ProfileUserSalfViewModel viewModel, System.Threading.CancellationToken ct);
    public void SetProducerName(PRISM.Adapters.ProfileUserSalfViewModel viewModel);
    public Cysharp.Threading.Tasks.UniTask SetAchievementIconAsync(PRISM.Adapters.ProfileUserSalfViewModel viewModel);
    public void SetBirthday(PRISM.Adapters.ProfileUserSalfViewModel viewModel);
    public void SetComment(PRISM.Adapters.ProfileUserSalfViewModel viewModel);
    public Cysharp.Threading.Tasks.UniTask SetLiveGuestCharaAsync(PRISM.Adapters.ProfileUserSalfViewModel viewModel);
    public Cysharp.Threading.Tasks.UniTask SetSupportCharaAsync(PRISM.Adapters.ProfileUserSalfViewModel viewModel, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask ProgressPanelInitializeAsync(PRISM.Adapters.ProfileUserSalfViewModel viewModel, System.Threading.CancellationToken ct);
    public void SetHistoryActivePanelViewObject(int index, bool isActive);
    public void HistoryPanelInitialize(PRISM.Adapters.ProfileUserSalfViewModel viewModel);

    private struct <InitializeAsync>d__41 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Profile.ProfileUserSelfOverlayView <>4__this;
        public PRISM.Adapters.ProfileUserSalfViewModel viewModel;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Profile
public class ProfileEventArchiveInfoLivePopupView : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI pointText;
    private ENTERPRISE.UI.UITextMeshProUGUI rankingText;
    private ENTERPRISE.UI.UITextMeshProUGUI highScoreText;
    private UnityEngine.CanvasGroup canvasGroup;
    public void Show(PRISM.Adapters.ProfileEventArchiveInfoLivePopupViewModel viewModel);
}

// Namespace: PRISM.Interactions.Profile
public class ProfileEventArchiveInfoPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IProfileEventArchiveInfoPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private ENTERPRISE.UI.UITextMeshProUGUI eventTitleText;
    private UnityEngine.UI.Image eventSpriteImage;
    private ENTERPRISE.UI.UITextMeshProUGUI expiryDate;
    private UnityEngine.GameObject tourList;
    private PRISM.Interactions.Profile.ProfileEventArchiveInfoTourPopupView tourEventInfo;
    private FancyScrollView.Scroller tourScroller;
    private PRISM.Interactions.Profile.ProfileEventArchiveInfoLivePopupView liveEventInfo;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClick;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Adapters.ProfileEventArchiveInfoPopupViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__10_0();
    private void <CreateFrameParameter>b__10_1();

    private struct <SetupAsync>d__11 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Adapters.ProfileEventArchiveInfoPopupViewModel viewModel;
        public PRISM.Interactions.Profile.ProfileEventArchiveInfoPopupView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private string <eventTitleKey>5__2;
        private int <eventTextId>5__3;
        private UnityEngine.UI.Image <>7__wrap3;
        private Awaiter<UnityEngine.Sprite> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Profile
public class ProfileEventArchiveInfoTourPopupView : FancyScrollView.FancyGridView<PRISM.Adapters.ProfileEventArchiveInfoTourPopupViewCellModel, PRISM.ClickObservableContext<int>>
{
    private PRISM.Interactions.Profile.ProfileEventArchiveInfoTourPopupViewCell cellPrefab;
    protected UnityEngine.GameObject emptyView;
    public void UpdateContents(System.Collections.Generic.IList<PRISM.Adapters.ProfileEventArchiveInfoTourPopupViewCellModel> items);
    protected void SetupCellTemplate();

    private class CellGroup : DefaultCellGroup<PRISM.Adapters.ProfileEventArchiveInfoTourPopupViewCellModel, PRISM.ClickObservableContext<int>>
    {
    }
}

// Namespace: PRISM.Interactions.Profile
public class ProfileEventArchiveInfoTourPopupViewCell : FancyScrollView.FancyGridViewCell<PRISM.Adapters.ProfileEventArchiveInfoTourPopupViewCellModel, PRISM.ClickObservableContext<int>>
{
    private ENTERPRISE.UI.UITextMeshProUGUI unitText;
    private ENTERPRISE.UI.UITextMeshProUGUI stageText;
    private ENTERPRISE.UI.UITextMeshProUGUI starText;
    public void UpdateContent(PRISM.Adapters.ProfileEventArchiveInfoTourPopupViewCellModel cellModel);
}

// Namespace: PRISM.Interactions.Profile
public class ProfileAchievementSelectPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IProfileAchievementSelectPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.Profile.ProfileAchievementSlotPanelView[] slotPanelViews;
    private PRISM.Interactions.Profile.ProfileAchievementSelectGridView gridView;
    private PRISM.Interactions.FilterOnlyView filterView;
    private ENTERPRISE.UI.UITabGroup uiTabGroup;
    private UnityEngine.GameObject[] tabBadgeObjects;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private UniRx.Subject<UniRx.Unit> onDecide;
    private UniRx.Subject<int> onClickTab;
    private UniRx.Subject<int> onClickSlot;
    private PRISM.Adapters.ProfileAchievementSelectViewModel viewModel;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public System.IObservable<UniRx.Unit> OnDecideObservable { get; set; }
    public System.IObservable<int> OnClickTabObservable { get; set; }
    public System.IObservable<int> OnClickAchievementObservable { get; set; }
    public System.IObservable<int> OnLongPressAchievementObservable { get; set; }
    public System.IObservable<int> OnClickAchievementSlotObservable { get; set; }
    public PRISM.Adapters.ISortFilterView FilterOnlyView { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Inject(PRISM.Adapters.ProfileAchievementSelectViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    public void SetDecideButtonEnable(bool isEnable);
    public void UpdateAchievementList();
    public Cysharp.Threading.Tasks.UniTask UpdateAchievementSlotAsync();
    public void Close();
    private void _setTabBadge();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    private void <CreateFrameParameter>b__26_0();
    private void <CreateFrameParameter>b__26_1();
    private void <CreateFrameParameter>b__26_2();
    private void <LoadAsync>b__27_0(int index, ENTERPRISE.UI.UITabGroup group);
    private void <LoadAsync>b__27_1(int index);

    private struct <LoadAsync>d__27 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
        public PRISM.Interactions.Profile.ProfileAchievementSelectPopupView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter<bool> <>u__1;
        private Awaiter <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <UpdateAchievementSlotAsync>d__31 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Profile.ProfileAchievementSelectPopupView <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Profile
public class ProfileEditBirthdayPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IProfileEditBirthdayPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private TMPro.TMP_Dropdown monthDropdown;
    private TMPro.TMP_Dropdown dayDropdown;
    private ENTERPRISE.UI.ToggleButton birthdayPublicToggle;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private UniRx.Subject<UniRx.Unit> onDecide;
    private UniRx.Subject<int> onChangeMonth;
    private UniRx.Subject<int> onChangeDay;
    private UniRx.Subject<bool> onChangeBirthdayPublic;
    private PRISM.Adapters.ProfileEditBirthdayViewModel viewModel;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public System.IObservable<UniRx.Unit> OnDecideObservable { get; set; }
    public System.IObservable<int> OnChangeMonthObservable { get; set; }
    public System.IObservable<int> OnChangeDayObservable { get; set; }
    public System.IObservable<bool> OnChangeBirthdayPublicObservable { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Inject(PRISM.Adapters.ProfileEditBirthdayViewModel viewModel);
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public void SetDayList();
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    public void Close();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    private void <LoadAsync>b__20_1(int index);
    private void <LoadAsync>b__20_2(int index);
    private void <LoadAsync>b__20_3();
    private void <CreateFrameParameter>b__22_0();
    private void <CreateFrameParameter>b__22_1();
    private void <CreateFrameParameter>b__22_2();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<int, string> <>9__20_0;
        public static System.Func<int, string> <>9__21_0;
        private string <LoadAsync>b__20_0(int month);
        private string <SetDayList>b__21_0(int day);
    }

    private struct <LoadAsync>d__20 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
        public PRISM.Interactions.Profile.ProfileEditBirthdayPopupView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter<bool> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Profile
public class ProfileEditUserCommentPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IProfileEditUserCommentPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.CommonInputFieldTMP commentInputField;
    private ENTERPRISE.UI.UITextMeshProUGUI commentCount;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private UniRx.Subject<string> onDecide;
    private string commentText;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public System.IObservable<string> OnDecideObservable { get; set; }
    public System.IObservable<string> OnChangeCommentObservable { get; set; }
    public System.IObservable<string> OnEndEditCommentObservable { get; set; }
    public bool IsInputFieldReadOnly { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Inject(string commentText);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    public void SetCountText(string text);
    public void SetInputFieldText(string text);
    public void PlayOverLimitSE(string text);
    public void Close();
    private void _setPopupButtonEnable();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    private void <CreateFrameParameter>b__16_0();
    private void <CreateFrameParameter>b__16_1();
    private void <CreateFrameParameter>b__16_2();

    private struct <LoadAsync>d__17 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
        public PRISM.Interactions.Profile.ProfileEditUserCommentPopupView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter<bool> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Profile
public class ProfileFesUnitRankCountPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IProfileFesUnitRankCountPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.Profile.ProfileFesUnitRankCountGridView gridView;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Module.Networking.IUserProfileProduceTotalParameterRankStatus[] rankStatusList;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Inject(PRISM.Module.Networking.IUserProfileProduceTotalParameterRankStatus[] rankStatusList, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    private void <CreateFrameParameter>b__6_0();
    private void <CreateFrameParameter>b__6_1();

    private struct <LoadAsync>d__7 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
        public PRISM.Interactions.Profile.ProfileFesUnitRankCountPopupView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter<bool> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Profile
public class ProfileLiveHighScoreArchiveCellScrollerView : PRISM.EnhancedListView<PRISM.Adapters.Profile.ProfileLiveHighScoreArchiveCellViewModel>
{
}

// Namespace: PRISM.Interactions.Profile
public class ProfileLiveScoreArchiveCellView : PRISM.EnhancedListViewCell<PRISM.Adapters.Profile.ProfileLiveHighScoreArchiveCellViewModel>
{
    private UnityEngine.UI.RawImage songJacket;
    private ENTERPRISE.UI.UITextMeshProUGUI songNameText;
    private ENTERPRISE.UI.UITextMeshProUGUI highScoreText;
    private PRISM.AutoCancellationTokenSource canceller;
    public void UpdateContent(PRISM.Adapters.Profile.ProfileLiveHighScoreArchiveCellViewModel viewModel);
    private void OnDestroy();
}

// Namespace: PRISM.Interactions.Profile
public class ProfileLiveHighScoreArchivePopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.Profile.IProfileLiveHighScoreArchivePopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.Profile.ProfileLiveHighScoreArchiveCellScrollerView scroller;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void Initialize(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.Profile.ProfileLiveHighScoreArchiveCellViewModel> cellViewModels, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__4_0();
    private void <CreateFrameParameter>b__4_1();
}

// Namespace: PRISM.Interactions.Profile
public class ProfilePIdolSelectPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IProfilePIdolSelectPopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private PRISM.Interactions.ProduceIdolEnhancedGridView gridView;
    private PRISM.Interactions.SortFilterView sortFilterView;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClosed;
    private UniRx.Subject<int> onClickPIdolSubject;
    private UniRx.Subject<int> onLongPressPIdolSubject;
    private PRISM.Interactions.IPopupFrameView parent;
    public PRISM.Adapters.ISortFilterView SortFilterView { get; set; }
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public System.IObservable<int> OnClickPIdolObservable { get; set; }
    public System.IObservable<int> OnLongPressPIdolObservable { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Inject(PRISM.Definitions.SortFilterSettings initSettings, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    public void SetDecideButtonEnable(bool isEnable);
    public void UpdateContent(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.ListProduceIdolIconViewModel> idolIcons, PRISM.Definitions.SortType sortType);
    public void ResetSelected();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    private void <Inject>b__13_0(int index);
    private void <Inject>b__13_1(int index);
    private void <CreateFrameParameter>b__14_0();
    private void <CreateFrameParameter>b__14_1();
    private void <CreateFrameParameter>b__14_2();

    private struct <LoadAsync>d__15 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
        public PRISM.Interactions.Profile.ProfilePIdolSelectPopupView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter<bool> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Profile
public class ProfileProduceCardSummaryPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IProfileProduceCardSummaryPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.Profile.ProfileProduceCardSummaryListView listView;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Adapters.ProfileProduceCardSummaryViewModel[] viewModels;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Inject(PRISM.Adapters.ProfileProduceCardSummaryViewModel[] viewModels);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__6_0();
    private void <CreateFrameParameter>b__6_1();
}

// Namespace: PRISM.Interactions.Profile
public class ProfileProgressFesUnitRankDetailPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IProfileProgressFesUnitRankDetailPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.Profile.ProfileProgressFesUnitRankDetailListView listView;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Adapters.ProfileProgressPanelViewModel viewModel;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Inject(PRISM.Adapters.ProfileProgressPanelViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__6_0();
    private void <CreateFrameParameter>b__6_1();
}

// Namespace: PRISM.Interactions.Profile
public class ProfileSupportCharaSelectPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IProfileSupportCharaSelectPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.Profile.ProfileSupportCharaSelectGridView gridView;
    private PRISM.Interactions.SortFilterView sortFilterView;
    private UniRx.Subject<UniRx.Unit> onDecide;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Adapters.ProfileSupportCharaSelectViewModel viewModel;
    private PRISM.Interactions.IPopupFrameView parent;
    public PRISM.Adapters.ISortFilterView SortFilterView { get; set; }
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public System.IObservable<UniRx.Unit> OnDecideClick { get; set; }
    public System.IObservable<int> OnClickSCharaObservable { get; set; }
    public System.IObservable<int> OnLongPressSCharaObservable { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Inject(PRISM.Adapters.ProfileSupportCharaSelectViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    public void SetDecideButtonEnable(bool isEnable);
    public void UpdateSCharaList(PRISM.Adapters.ProfileSupportCharaIconViewModel[] dataList);
    public void Close();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    private void <CreateFrameParameter>b__16_0();
    private void <CreateFrameParameter>b__16_1();
    private void <CreateFrameParameter>b__16_2();

    private struct <LoadAsync>d__17 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
        public PRISM.Interactions.Profile.ProfileSupportCharaSelectPopupView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter<bool> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Profile
public class ProfileCategoryTabListView : PRISM.CommonListView<PRISM.Interactions.Profile.ProfileCategoryTabListViewCell, PRISM.Adapters.ProfileCategoryTabViewModel, PRISM.CommonListViewContext>
{
}

// Namespace: PRISM.Interactions.Profile
public class ProfileCategoryTabListViewCell : PRISM.CommonListViewCell<PRISM.Adapters.ProfileCategoryTabViewModel, PRISM.CommonListViewContext>
{
    private ENTERPRISE.UI.UITextMeshProUGUI normalText;
    private ENTERPRISE.UI.UITextMeshProUGUI selectedText;
    public void Initialize();
    public void UpdateContent(PRISM.Adapters.ProfileCategoryTabViewModel viewModel);
    private string _getText(PRISM.Adapters.ProfileCategoryTabViewModel viewModel);
}

// Namespace: PRISM.Interactions.Profile
public class ProfileFesUnitRankCountGridView : FancyScrollView.FancyGridView<PRISM.Module.Networking.IUserProfileProduceTotalParameterRankStatus, PRISM.ClickObservableContext<int>>
{
    private PRISM.Interactions.Profile.ProfileFesUnitRankCountGridViewCell cellPrefab;
    public PRISM.ClickObservableContext<int> ViewContext { get; set; }
    public void Dispose();
    protected void SetupCellTemplate();

    private class CellGroup : DefaultCellGroup<PRISM.Module.Networking.IUserProfileProduceTotalParameterRankStatus, PRISM.ClickObservableContext<int>>
    {
    }
}

// Namespace: PRISM.Interactions.Profile
public class ProfileFesUnitRankCountGridViewCell : FancyScrollView.FancyGridViewCell<PRISM.Module.Networking.IUserProfileProduceTotalParameterRankStatus, PRISM.ClickObservableContext<int>>
{
    private UnityEngine.UI.Image rankImage;
    private ENTERPRISE.UI.UITextMeshProUGUI countText;
    private System.Threading.CancellationTokenSource tokenSource;
    public void UpdateContent(PRISM.Module.Networking.IUserProfileProduceTotalParameterRankStatus rankStatus);
    private Cysharp.Threading.Tasks.UniTask _loadFesIdolRankSpriteAsync(PRISM.Module.Networking.IUserProfileProduceTotalParameterRankStatus rankStatus);
    private void OnDestroy();

    private struct <_loadFesIdolRankSpriteAsync>d__4 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Module.Networking.IUserProfileProduceTotalParameterRankStatus rankStatus;
        public PRISM.Interactions.Profile.ProfileFesUnitRankCountGridViewCell <>4__this;
        private UnityEngine.UI.Image <>7__wrap1;
        private Awaiter<UnityEngine.Sprite> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Profile
public class ProfileFriendUserFesUnitRankListView : PRISM.Interactions.ListView<PRISM.Interactions.Profile.ProfileFriendUserFesUnitRankListViewCell, PRISM.Adapters.ProfileFriendUserFesUnitRankViewModel>
{
}

// Namespace: PRISM.Interactions.Profile
public class ProfileFriendUserFesUnitRankListViewCell : PRISM.Interactions.ListViewCell<PRISM.Adapters.ProfileFriendUserFesUnitRankViewModel>
{
    private ENTERPRISE.UI.UITextMeshProUGUI unitNameText;
    private UnityEngine.UI.Image fesUnitRankingIconImage;
    private ENTERPRISE.UI.UITextMeshProUGUI fesUnitRankingTotalText;
    private PRISM.AutoCancellationTokenSource canceller;
    public void UpdateContent(PRISM.Adapters.ProfileFriendUserFesUnitRankViewModel viewModel);
    private Cysharp.Threading.Tasks.UniTask _loadFesIdolRankSpriteAsync(PRISM.Adapters.ProfileFriendUserFesUnitRankViewModel viewModel);

    private struct <_loadFesIdolRankSpriteAsync>d__5 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Adapters.ProfileFriendUserFesUnitRankViewModel viewModel;
        public PRISM.Interactions.Profile.ProfileFriendUserFesUnitRankListViewCell <>4__this;
        private UnityEngine.UI.Image <>7__wrap1;
        private Awaiter<UnityEngine.Sprite> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Profile
public class ProfileFriendUserFesUnitRankPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IProfileFriendUserFesUnitRankPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.Profile.ProfileFriendUserFesUnitRankListView listView;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClick;
    private PRISM.Adapters.ProfileFriendUserViewModel viewModel;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Inject(PRISM.Adapters.ProfileFriendUserViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__6_0();
    private void <CreateFrameParameter>b__6_1();
}

// Namespace: PRISM.Interactions.Profile
public class ProfileFriendUserProfileCarousel : PRISM.Carousel<UniRx.Unit, PRISM.DefaultCarouselContext>
{
    private UnityEngine.Transform[] panels;
    protected void Initialize();
    public void Initialize(UnityEngine.Transform[] panelTransforms);
    public void SetListData(System.Collections.Generic.IList<UniRx.Unit> _);
    public bool HasPrevious(int index);
    public bool HasNext(int index);
    public void EnableLoopWithScroller();
    protected void Relayout();
    protected void Refresh();
    protected void UpdatePosition(float _);
    private void _updatePosition();
    private void <Initialize>b__2_0(float value);
    private void <Initialize>b__2_1(int index);
}

// Namespace: PRISM.Interactions.Profile
public class ProfileFriendUserProfilePanelView : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI producerNameText;
    private UnityEngine.GameObject[] friendStateObjects;
    private PRISM.Interactions.Achievement.AchievementPanelView achievementPanelView;
    private ENTERPRISE.UI.UITextMeshProUGUI birthdayText;
    private ENTERPRISE.UI.UITextMeshProUGUI commentText;
    private PRISM.UI.SCharaIconRectView supportIdolIcon;
    private PRISM.Interactions.GuestEditCharacterIcon[] liveGuestIcons;
    private UniRx.Subject<Attribute> onGuestDetail;
    public System.IObservable<System.ValueTuple<int, UnityEngine.GameObject>> OnClickObservable { get; set; }
    public System.IObservable<System.ValueTuple<int, UnityEngine.GameObject>> OnLongPressObservable { get; set; }
    public System.IObservable<System.ValueTuple<int, int>> OnClickAchievementObservable { get; set; }
    public System.IObservable<System.ValueTuple<int, int>> OnLongPressAchievementObservable { get; set; }
    public System.IObservable<Attribute> OnGuestDetailObservable { get; set; }
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Adapters.ProfileFriendUserViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public void SetupFriendState(int index);

    private class <>c__DisplayClass18_0
    {
        public Attribute attribute;
        public PRISM.Interactions.Profile.ProfileFriendUserProfilePanelView <>4__this;
        private bool <SetupAsync>b__0(PRISM.Adapters.GuestEditCharacterIconModel x);
        private void <SetupAsync>b__1(int _);
    }

    private struct <SetupAsync>d__18 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Profile.ProfileFriendUserProfilePanelView <>4__this;
        public PRISM.Adapters.ProfileFriendUserViewModel viewModel;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Profile
public class ProfileFriendUserProfilePopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IProfileFriendUserProfilePopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private UnityEngine.UI.RawImage bgImage;
    private UnityEngine.Transform pIdolParent;
    private ENTERPRISE.UI.UIButton pIdolDetailButton;
    private UnityEngine.GameObject followButtonObject;
    private PRISM.Interactions.ButtonView followButton;
    private UnityEngine.GameObject releaseFollowButtonObject;
    private PRISM.Interactions.ButtonView releaseFollowButton;
    private PRISM.Interactions.ButtonView releaseFollowerButton;
    private PRISM.Interactions.Profile.ProfileFriendUserProfilePanelView profilePanelView;
    private PRISM.Interactions.Profile.ProfileFriendUserProgressListView progressListView;
    private PRISM.Interactions.Profile.ProfileFriendUserProfileCarousel profileCarousel;
    private PRISM.Interactions.ButtonView businessCardButton;
    private ENTERPRISE.UI.UIButton nextButton;
    private ENTERPRISE.UI.UIButton prevButton;
    private UniRx.CompositeDisposable disposables;
    private System.IDisposable friendStateDisposable;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClose;
    private UniRx.Subject<UniRx.Unit> onPIdolDetail;
    private UniRx.Subject<UniRx.Unit> onSCharaDetail;
    private UniRx.Subject<int> onAchievementDetail;
    private PRISM.Adapters.ProfileFriendUserViewModel viewModel;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public System.IObservable<UniRx.Unit> OnPIdolDetailObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnSCharaDetailObservable { get; set; }
    public System.IObservable<Attribute> OnGuestDetailObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnFollowObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnReleaseFollowObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnReleaseFollowerObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnUnitRankDetailOvservable { get; set; }
    public System.IObservable<int> OnAchievementDetailOvervable { get; set; }
    public System.IObservable<UniRx.Unit> OnBusinessCardObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnNextObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnPrevObservable { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Inject(PRISM.Adapters.ProfileFriendUserViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void ScrollToNext();
    public void ScrollToPrevious();
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    private void _setupFollowButtons(FriendState state);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    private Cysharp.Threading.Tasks.UniTask _loadPIdolAsync(System.Threading.CancellationToken ct);
    private void <CreateFrameParameter>b__49_0();
    private void <CreateFrameParameter>b__49_1();
    private void <LoadAsync>b__50_0(int index);
    private void <LoadAsync>b__50_1();
    private void <LoadAsync>b__50_2();
    private void <LoadAsync>b__50_3(System.ValueTuple<int, UnityEngine.GameObject> _);
    private void <LoadAsync>b__50_4(System.ValueTuple<int, UnityEngine.GameObject> _);
    private void <LoadAsync>b__50_5(System.ValueTuple<int, int> value);
    private void <LoadAsync>b__50_6(System.ValueTuple<int, int> value);
    private void <LoadAsync>b__50_7(FriendState state);

    private struct <LoadAsync>d__50 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
        public PRISM.Interactions.Profile.ProfileFriendUserProfilePopupView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private Awaiter<bool> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_loadPIdolAsync>d__59 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Profile.ProfileFriendUserProfilePopupView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter<UnityEngine.GameObject> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Profile
public class ProfileFriendUserProgressEpisordClearCountView : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI[] episordClearCountText;
    public void Setup(PRISM.Adapters.ProfileFriendUserViewModel viewModel);
}

// Namespace: PRISM.Interactions.Profile
public class ProfileFriendUserProgressFesUnitRankView : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.Image fesUnitRankingIconImage;
    private ENTERPRISE.UI.UITextMeshProUGUI fesUnitRankingText;
    private ENTERPRISE.UI.UIButton fesRankingDetailButton;
    public void Setup(PRISM.Adapters.ProfileFriendUserViewModel viewModel, UniRx.Subject<UniRx.Unit> onUnitRankDetail, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private Cysharp.Threading.Tasks.UniTask _loadfesUnitRankingIconIconImageAsync(ProduceParameterRank fesUnitRank, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);

    private class <>c__DisplayClass3_0
    {
        public UniRx.Subject<UniRx.Unit> onUnitRankDetail;
        private void <Setup>b__0();
    }

    private struct <_loadfesUnitRankingIconIconImageAsync>d__4 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public ProduceParameterRank fesUnitRank;
        public PRISM.Interactions.Profile.ProfileFriendUserProgressFesUnitRankView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        private UnityEngine.UI.Image <>7__wrap1;
        private Awaiter<UnityEngine.Sprite> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Profile
public class ProfileFriendUserProgressListView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.MusicRateView totalHighScoreRateView;
    private PRISM.Interactions.MusicRateView totalTechnicalRatingView;
    private PRISM.Interactions.Profile.ProfileLiveCountView liveClearCountView;
    private PRISM.Interactions.Profile.ProfileLiveCountView fullComboCountView;
    private PRISM.Interactions.Profile.ProfileLiveCountView allGrateCountView;
    private PRISM.Interactions.Profile.ProfileLiveCountView allPerfectCountView;
    private PRISM.Interactions.Profile.ProfileLiveCountView allShinyCountView;
    private PRISM.Interactions.Profile.ProfileFriendUserProgressFesUnitRankView fesUnitRankView;
    private PRISM.Interactions.Profile.ProfileFriendUserProgressEpisordClearCountView episordClearCountView;
    private UniRx.Subject<UniRx.Unit> onUnitRankDetail;
    public System.IObservable<UniRx.Unit> OnUnitRankDetailObservable { get; set; }
    public void Initialize(PRISM.Adapters.ProfileFriendUserViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Interactions.Profile
public class ProfileIdolIconViewWithSelector : PRISM.Interactions.ProduceIdolIconViewWithSelector
{
    private UnityEngine.UI.RawImage favoriteIconImage;
    private UniRx.CompositeDisposable disposables;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    public void Initialize(PRISM.Interactions.CharacterSelectClickObservableInt context);
    public Cysharp.Threading.Tasks.UniTask UpdateViewAsync(PRISM.Adapters.ListProduceIdolIconViewModel vm, int dataIndex, System.Threading.CancellationToken ct);

    private class <>c__DisplayClass4_0
    {
        public PRISM.Interactions.Profile.ProfileIdolIconViewWithSelector <>4__this;
        public System.Threading.CancellationToken ct;
        private void <UpdateViewAsync>b__0(int id);
    }
}

// Namespace: PRISM.Interactions.Profile
public class ProfileLiveCountView : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI[] countTexts;
    private string format;
    public void Setup(System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IUserProfileLiveStatus> list);
}

// Namespace: PRISM.Interactions.Profile
public class ProfileProgressFesUnitRankDetailListView : PRISM.Interactions.ListView<PRISM.Interactions.Profile.ProfileProgressFesUnitRankDetailListViewCell, PRISM.Adapters.ProfileProgressFesUnitRankDetailViewModel>
{
}

// Namespace: PRISM.Interactions.Profile
public class ProfileProgressFesUnitRankDetailListViewCell : PRISM.Interactions.ListViewCell<PRISM.Adapters.ProfileProgressFesUnitRankDetailViewModel>
{
    private ENTERPRISE.UI.UITextMeshProUGUI titleText;
    private UnityEngine.UI.Image fesUnitRankIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI fesUnitRankText;
    private PRISM.AutoCancellationTokenSource canceller;
    public void UpdateContent(PRISM.Adapters.ProfileProgressFesUnitRankDetailViewModel viewModel);
}

// Namespace: PRISM.Interactions.Profile
public class ProfileProgressPanelView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.MusicRateView totalHighScoreRateView;
    private PRISM.Interactions.MusicRateView totalTechnicalRateView;
    private PRISM.Interactions.Profile.ProfileLiveCountView liveClearCountView;
    private PRISM.Interactions.Profile.ProfileLiveCountView fullComboCountView;
    private PRISM.Interactions.Profile.ProfileLiveCountView allGreatCountView;
    private PRISM.Interactions.Profile.ProfileLiveCountView allPerfectCountView;
    private PRISM.Interactions.Profile.ProfileLiveCountView allShinyCountView;
    private UnityEngine.UI.Image fesUnitRankIconImage;
    private ENTERPRISE.UI.UITextMeshProUGUI fesUnitRankingText;
    private ENTERPRISE.UI.UIButton fesUnitRankDetailButton;
    private ENTERPRISE.UI.UITextMeshProUGUI[] episordClearCountText;
    public System.IObservable<UniRx.Unit> OnClickFesUnitRankDetailObservable { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.ProfileProgressPanelViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);

    private struct <InitializeAsync>d__13 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Profile.ProfileProgressPanelView <>4__this;
        public PRISM.Adapters.ProfileProgressPanelViewModel viewModel;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        private UnityEngine.UI.Image <>7__wrap1;
        private Awaiter<UnityEngine.Sprite> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Profile
public class ResourceLoaderExtensions
{
    public static Cysharp.Threading.Tasks.UniTask<UnityEngine.Sprite> LoadTourLogoAsync(PRISM.ResourceManagement.IResourceLoader loader, int eventId, System.Threading.CancellationToken ct);
}

// Namespace: PRISM.Interactions.Profile
public class ProfileAchievementSelectGridView : FancyScrollView.FancyGridView<PRISM.Adapters.AchievementIconViewModel, PRISM.ClickObservableContext<int>>
{
    private PRISM.Interactions.Profile.ProfileAchievementSelectGridViewCell cellPrefab;
    protected UnityEngine.GameObject emptyView;
    public PRISM.ClickObservableContext<int> ViewContext { get; set; }
    public void UpdateContents(System.Collections.Generic.IList<PRISM.Adapters.AchievementIconViewModel> items);
    public void JumpTo(int index);
    public void Dispose();
    protected void SetupCellTemplate();

    private class CellGroup : DefaultCellGroup<PRISM.Adapters.AchievementIconViewModel, PRISM.ClickObservableContext<int>>
    {
    }
}

// Namespace: PRISM.Interactions.Profile
public class ProfileAchievementSelectGridViewCell : FancyScrollView.FancyGridViewCell<PRISM.Adapters.AchievementIconViewModel, PRISM.ClickObservableContext<int>>
{
    private PRISM.Interactions.Achievement.AchievementIcon achievementIcon;
    private UnityEngine.GameObject settingsObject;
    private System.IDisposable selectedDisposable;
    private System.IDisposable settingsDisposable;
    public void Initialize();
    public void UpdateContent(PRISM.Adapters.AchievementIconViewModel viewModel);
    private void <Initialize>b__4_0(int achievementId);
    private void <Initialize>b__4_1(int achievementId);
    private void <UpdateContent>b__5_0(bool isSelected);
    private void <UpdateContent>b__5_1(bool isSettings);
}

// Namespace: PRISM.Interactions.Profile
public class ProfileAchievementSlotPanelView : UnityEngine.MonoBehaviour, System.IDisposable
{
    private PRISM.Interactions.Achievement.AchievementIcon achievementIcon;
    private UnityEngine.GameObject selectFrame;
    private ENTERPRISE.UI.UITextMeshProUGUI achievementName;
    private ENTERPRISE.UI.UITextMeshProUGUI getCondtionText;
    private UnityEngine.GameObject informationRoot;
    private UnityEngine.GameObject emptyText;
    private ENTERPRISE.UI.UIButton button;
    private System.IDisposable disposable;
    private UniRx.Subject<int> onClicked;
    public System.IObservable<int> OnClickedObservable { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.AchievementIconViewModel viewModel, int slotIndex, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void Dispose();

    private class <>c__DisplayClass11_0
    {
        public PRISM.Interactions.Profile.ProfileAchievementSlotPanelView <>4__this;
        public int slotIndex;
        private void <InitializeAsync>b__0();
        private void <InitializeAsync>b__1(bool isSelected);
    }

    private struct <InitializeAsync>d__11 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Profile.ProfileAchievementSlotPanelView <>4__this;
        public int slotIndex;
        public PRISM.Adapters.AchievementIconViewModel viewModel;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private <>c__DisplayClass11_0 <>8__1;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Profile
public class ProfileSupportCharaSelectGridView : FancyScrollView.FancyGridView<PRISM.Adapters.ProfileSupportCharaIconViewModel, PRISM.ClickObservableContext<int>>
{
    private PRISM.Interactions.Profile.ProfileSupportCharaSelectGridViewCell cellPrefab;
    protected UnityEngine.GameObject emptyView;
    public PRISM.ClickObservableContext<int> ViewContext { get; set; }
    public void UpdateContents(System.Collections.Generic.IList<PRISM.Adapters.ProfileSupportCharaIconViewModel> items);
    public void JumpTo(int index);
    public void Dispose();
    protected void SetupCellTemplate();

    private class CellGroup : DefaultCellGroup<PRISM.Adapters.ProfileSupportCharaIconViewModel, PRISM.ClickObservableContext<int>>
    {
    }
}

// Namespace: PRISM.Interactions.Profile
public class ProfileSupportCharaSelectGridViewCell : FancyScrollView.FancyGridViewCell<PRISM.Adapters.ProfileSupportCharaIconViewModel, PRISM.ClickObservableContext<int>>
{
    private PRISM.UI.SCharaIconRectView idolIconView;
    private UnityEngine.GameObject cursorObject;
    private UnityEngine.GameObject settingsObject;
    private System.IDisposable disposable;
    private System.Threading.CancellationTokenSource cts;
    public void UpdateContent(PRISM.Adapters.ProfileSupportCharaIconViewModel viewModel);
    private void <UpdateContent>b__5_0(bool isSelected);
}

// Namespace: PRISM.Interactions.Profile
public class ProfileUserSelfPanelView : UnityEngine.MonoBehaviour, System.IDisposable
{
    private static UnityEngine.Color CharID16Color;
    private UnityEngine.Transform prodeuceIdolImageTransform;
    private UnityEngine.UI.RawImage backgroundImage;
    private ENTERPRISE.UI.UIButton produceIdolDetailButton;
    private ENTERPRISE.UI.UIButton changeProduceIdolButton;
    private ENTERPRISE.UI.UITextMeshProUGUI producerNameText;
    private ENTERPRISE.UI.UIButton changeNameButton;
    private PRISM.Interactions.Achievement.AchievementPanelView achievementPanelView;
    private ENTERPRISE.UI.UITextMeshProUGUI birthdayText;
    private ENTERPRISE.UI.UIButton changeBirthdayButton;
    private ENTERPRISE.UI.UITextMeshProUGUI profileCommentText;
    private ENTERPRISE.UI.UIButton changeUserCommentButton;
    private PRISM.UI.SCharaIconRectView supportIdolIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI playerIdText;
    private ENTERPRISE.UI.UIButton playerIdCopyButton;
    private PRISM.Interactions.GuestEditCharacterIcon[] liveGuestIcons;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    private UniRx.Subject<int> onPIdolDetail;
    private UniRx.Subject<UniRx.Unit> onClickSChara;
    private UniRx.Subject<UniRx.Unit> onSCharaDetail;
    private UniRx.Subject<System.ValueTuple<Attribute, int>> onChangeGuest;
    public System.IObservable<int> OnPIdolDetailObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnChangeFavoriteObservable { get; set; }
    public System.IObservable<System.ValueTuple<Attribute, int>> OnChangeGuestObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnChangeNameObservable { get; set; }
    public System.IObservable<System.ValueTuple<int, int>> OnClickAchievementObservalbe { get; set; }
    public System.IObservable<System.ValueTuple<int, int>> OnLongPressAchievementObservalbe { get; set; }
    public System.IObservable<UniRx.Unit> OnChangeBirthdayObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnChangeCommentObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnClickSCharaObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnSCharaDetailObservable { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.ProfileUserSelfPanelViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask SetProduceIdolAsync(PRISM.Adapters.ProfileUserSelfPanelViewModel viewModel, System.Threading.CancellationToken ct);
    public void SetProducerName(PRISM.Adapters.ProfileUserSelfPanelViewModel viewModel);
    public Cysharp.Threading.Tasks.UniTask SetAchievementIconsAsync(PRISM.Adapters.ProfileUserSelfPanelViewModel viewModel);
    public void SetBirthday(PRISM.Adapters.ProfileUserSelfPanelViewModel viewModel);
    public void SetComment(PRISM.Adapters.ProfileUserSelfPanelViewModel viewModel);
    public Cysharp.Threading.Tasks.UniTask SetSupportCharaAsync(PRISM.Adapters.ProfileUserSelfPanelViewModel viewModel, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask SetLiveGuestCharaAsync(PRISM.Adapters.ProfileUserSelfPanelViewModel viewModel);
    public void Dispose();
    private Cysharp.Threading.Tasks.UniTask _onClickPlayerIdCopyAsync(PRISM.Adapters.ProfileUserSelfPanelViewModel viewModel);

    private class <>c__DisplayClass41_0
    {
        public PRISM.Interactions.Profile.ProfileUserSelfPanelView <>4__this;
        public PRISM.Adapters.ProfileUserSelfPanelViewModel viewModel;
        public System.Action<int> <>9__6;
        private void <InitializeAsync>b__0();
        private void <InitializeAsync>b__1();
        private void <InitializeAsync>b__2(System.ValueTuple<int, UnityEngine.GameObject> value);
        private void <InitializeAsync>b__3(System.ValueTuple<int, UnityEngine.GameObject> value);
        private void <InitializeAsync>b__6(int mstProduceIdolId);
        private void <InitializeAsync>b__4();
    }

    private class <>c__DisplayClass41_1
    {
        public Attribute attribute;
        public <>c__DisplayClass41_0 CS$<>8__locals1;
        private void <InitializeAsync>b__5(int mstProduceIdolId);
    }

    private class <>c__DisplayClass48_0
    {
        public Attribute attribute;
        private bool <SetLiveGuestCharaAsync>b__0(PRISM.Adapters.GuestEditCharacterIconModel x);
    }

    private struct <SetLiveGuestCharaAsync>d__48 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Profile.ProfileUserSelfPanelView <>4__this;
        public PRISM.Adapters.ProfileUserSelfPanelViewModel viewModel;
        private int <index>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <SetProduceIdolAsync>d__42 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Profile.ProfileUserSelfPanelView <>4__this;
        public PRISM.Adapters.ProfileUserSelfPanelViewModel viewModel;
        public System.Threading.CancellationToken ct;
        private Awaiter<UnityEngine.GameObject> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <SetSupportCharaAsync>d__47 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Adapters.ProfileUserSelfPanelViewModel viewModel;
        public PRISM.Interactions.Profile.ProfileUserSelfPanelView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=3534 3B9D7ABB96ABD6786203A1B6472277AC454190B3DA3F2273C8A898356E65B580;
    private static __StaticArrayInitTypeSize=4690 AE104D9F7BE7DB15EC28292390817519E9D3C20C81702EC6F88E4F6EEA8509AA;

    private struct __StaticArrayInitTypeSize=3534 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=4690 : System.ValueType
    {
    }
}
