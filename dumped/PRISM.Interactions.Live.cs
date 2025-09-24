
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

// Namespace: PRISM.Live
public class MusicSelectionGridPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IMusicSelectionGridPopupView, PRISM.Adapters.IClosablePopupFrame<PRISM.Live.MusicData>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<PRISM.Live.MusicData>
{
    private PRISM.Interactions.Live.MusicSelectionGridView gridView;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<PRISM.Live.MusicData> onClosed;
    private UniRx.ReactiveProperty<PRISM.Live.MusicData> selectedMusic;
    private System.Collections.Generic.IList<PRISM.Live.MusicData> musicList;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<PRISM.Live.MusicData> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Initialize(System.Collections.Generic.IList<PRISM.Live.MusicData> musicList, PRISM.Live.MusicData selectedMusic, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__7_0();
    private void <CreateFrameParameter>b__7_1();
    private void <CreateFrameParameter>b__7_2();

    private class <>c__DisplayClass6_0
    {
        public PRISM.Live.MusicSelectionGridPopupView <>4__this;
        public System.Collections.Generic.IList<PRISM.Live.MusicData> musicList;
        private void <Initialize>b__0(PRISM.Live.MusicData music);
    }

    private struct <ShowAsync>d__8 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Live.MusicSelectionGridPopupView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class LiveCostumeChangeConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.LiveCostumeChangeArgument>, PRISM.Live.ILiveCostumeChangeConnector
{
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
    protected PRISM.Adapters.LiveCostumeChangeArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
}

// Namespace: PRISM.Interactions
public class LiveCostumeChangeView : UnityEngine.MonoBehaviour, PRISM.Adapters.ILiveCostumeChangeView
{
    private PRISM.Interactions.CommonTitleView titleView;
    private UnityEngine.GameObject characterBaseIcon;
    private PRISM.Interactions.ProduceIdolIconView produceIdolIconView;
    private ENTERPRISE.UI.UITextMeshProUGUI produceIdolNameText;
    private PRISM.Interactions.CostumeChange.CostumeChangeView costumeChangeView;
    public PRISM.Adapters.CostumeChange.ICostumeChangeView CostumeChangeView { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, CostumeType costumeType, PRISM.Live.LiveIdol liveIdol, System.Threading.CancellationToken ct);
}

// Namespace: PRISM.Interactions
public class LiveAutoLoopSettingOverlayView : PRISM.Interactions.OverlayViewWithOkCancelButton, PRISM.Adapters.ILiveAutoLoopSettingOverlayView, PRISM.Adapters.IClosableOverlayView<bool>, PRISM.Adapters.IOverlayView, PRISM.Adapters.IClosable<bool>
{
    private PRISM.Interactions.StaminaView liveBoostView;
    private PRISM.Interactions.ButtonView specifiedCommercialTransactionsLawButton;
    private PRISM.Interactions.ButtonView seasonPassButton;
    private PRISM.Interactions.ViewStateChanger seasonPassStateChanger;
    private ENTERPRISE.UI.UITextMeshProUGUI autoLiveCountText;
    private PRISM.Interactions.LiveAutoLoopSettingUsageView usageView;
    private PRISM.Interactions.LiveAutoLoopSettingRecoveryView recoveryView;
    private PRISM.Interactions.ToggleButtonView forceLightweightBackgroundToggle;
    private System.Func<Cysharp.Threading.Tasks.UniTask> onPreDecideFunc;
    public PRISM.Adapters.IStaminaView LiveBoostView { get; set; }
    public System.IObservable<UniRx.Unit> OnClickSpecifiedCommercialTransactionsLaw { get; set; }
    public System.IObservable<UniRx.Unit> OnClickSeasonPass { get; set; }
    public System.Threading.CancellationToken DestroyCancellationToken { get; set; }
    public void Initialize(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Adapters.LiveAutoLoopSettingViewModel viewModel, System.Func<Cysharp.Threading.Tasks.UniTask> onPreDecideFunc);
    public void UpdateSeasonPassStatus(PRISM.Adapters.LiveAutoLoopSettingViewModel viewModel);
    protected Cysharp.Threading.Tasks.UniTask<bool> _createReturnValueAsync(bool isOk);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<bool> <>9__19_0;
        private bool <_createReturnValueAsync>b__19_0();
    }
}

// Namespace: PRISM.Interactions
public class LiveAutoLoopSettingRecoveryItemView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.FilterToggleButtonView toggle;
    private ENTERPRISE.OutGame.RewardItem icon;
    public void Initialize(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Domain.ProductKey product, UniRx.IReadOnlyReactiveProperty<long> amount, PRISM.Definitions.ReactiveHashSet<int> onIds);

    private class <>c__DisplayClass2_0
    {
        public PRISM.Definitions.ReactiveHashSet<int> onIds;
        public PRISM.Domain.ProductKey product;
        public PRISM.Interactions.LiveAutoLoopSettingRecoveryItemView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private void <Initialize>b__0(UniRx.Unit _);
        private void <Initialize>b__1(long x);
    }
}

// Namespace: PRISM.Interactions
public class LiveAutoLoopSettingRecoveryView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ToggleButtonView enableAutoRecoveryToggle;
    private PRISM.Interactions.ToggleButtonView isConsumeJewelToggle;
    private ENTERPRISE.OutGame.RewardItem jewelIcon;
    private PRISM.Interactions.LiveAutoLoopSettingRecoveryItemView consumeItemBase;
    private UnityEngine.GameObject consumeItemEmptyView;
    public void Initialize(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Adapters.LiveAutoLoopSettingViewModel viewModel);

    private class <>c__DisplayClass5_0
    {
        public PRISM.Adapters.LiveAutoLoopSettingViewModel viewModel;
        public PRISM.Interactions.LiveAutoLoopSettingRecoveryView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public PRISM.Domain.ProductKey jewelProduct;
        private void <Initialize>b__0(UniRx.Unit _);
        private void <Initialize>b__1(PRISM.Domain.Jewel jewel);
    }
}

// Namespace: PRISM.Interactions
public class LiveAutoLoopSettingUsageView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.NumberFluctuateButtonView[] loopCountFluctuateButtons;
    private ENTERPRISE.UI.UITextMeshProUGUI loopCountText;
    private PRISM.UI.MarkingAttachedSlider liveBoostUsageCountSlider;
    private ENTERPRISE.UI.UITextMeshProUGUI liveBoostUsageCountText;
    private ENTERPRISE.UI.UITextMeshProUGUI totalUsageCountText;
    private PRISM.Interactions.ViewStateChanger isEnoughStateChanger;
    private UniRx.CompositeDisposable disposables;
    public void Initialize(PRISM.Adapters.ILiveAutoLoopSettingUsageViewModel viewModel);
    public void UpdateFluctuateButtons(UniRx.IReactiveProperty<int> loopCount, PRISM.Module.Networking.ILimitedValueStatus autoLiveCount);
    public void DisableFluctuateButtons();
    public void SetInteractableSlider(bool isActive);

    private class <>c__DisplayClass7_0
    {
        public PRISM.Adapters.ILiveAutoLoopSettingUsageViewModel viewModel;
        public PRISM.Interactions.LiveAutoLoopSettingUsageView <>4__this;
        private void <Initialize>b__0(int diff);
        private void <Initialize>b__1(int x);
        private void <Initialize>b__2(float x);
        private void <Initialize>b__3(int x);
    }
}

// Namespace: PRISM.Interactions
public class LimitedVoiceSeparatePurchaseIdolListCell : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.CharacterBaseIconView characterBaseIcon;
    private UnityEngine.GameObject centerIcon;
    public void UpdateContent(int characterId, bool isCenter, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Interactions
public class LimitedVoiceSeparatePurchaseOverlayView : UnityEngine.MonoBehaviour, PRISM.Adapters.ILimitedVoiceSeparatePurchaseOverlayView, PRISM.Adapters.IClosableOverlayView<System.ValueTuple<bool, PRISM.Module.Networking.ISongStatus>>, PRISM.Adapters.IOverlayView, PRISM.Adapters.IClosable<System.ValueTuple<bool, PRISM.Module.Networking.ISongStatus>>
{
    private PRISM.MoviePlayer moviePlayer;
    private UnityEngine.UI.RawImage jacketImage;
    private ENTERPRISE.UI.UITextMeshProUGUI musicName;
    private PRISM.Interactions.LimitedVoiceSeparatePurchaseIdolListCell[] idolCells;
    private PRISM.Interactions.ButtonView howToPlayButton;
    private PRISM.Interactions.ButtonView closeHowToPlayButton;
    private ENTERPRISE.UI.SlideWindowBase howToPlayView;
    private PRISM.Interactions.JewelAmountPanelView jewelAmountPanelView;
    private PRISM.Interactions.ButtonView purchaseButton;
    private ENTERPRISE.UI.UITextMeshProUGUI priceText;
    private PRISM.Interactions.ButtonView closeButton;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<System.ValueTuple<bool, PRISM.Module.Networking.ISongStatus>> onClosed;
    private System.IDisposable backKeyDisposable;
    private PRISM.Adapters.LimitedVoiceSeparatePurchaseOverlayViewModel viewModel;
    public Cysharp.Threading.Tasks.UniTask<System.ValueTuple<bool, PRISM.Module.Networking.ISongStatus>> OnCloseRequested { get; set; }
    public PRISM.Adapters.IJewelAmountPanelView JewelAmountPanelView { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Live.MusicData musicData, UniRx.IReadOnlyReactiveProperty<PRISM.Domain.Jewel> jewelModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken cancellationToken);
    private Cysharp.Threading.Tasks.UniTask _openPurchasePopupAsync(UniRx.IReadOnlyReactiveProperty<PRISM.Domain.Jewel> jewelModel, System.Threading.CancellationToken cancellationToken);
    private Cysharp.Threading.Tasks.UniTask PRISM.Adapters.IOverlayView.ShowAsync(System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask PRISM.Adapters.IOverlayView.HideAsync();

    private class <>c__DisplayClass18_0
    {
        public PRISM.Interactions.LimitedVoiceSeparatePurchaseOverlayView <>4__this;
        public UniRx.IReadOnlyReactiveProperty<PRISM.Domain.Jewel> jewelModel;
        public System.Threading.CancellationToken cancellationToken;
        private void <InitializeAsync>b__0(UniRx.Unit _);
        private void <InitializeAsync>b__1(UniRx.Unit _);
        private void <InitializeAsync>b__2(UniRx.Unit _);
        private void <InitializeAsync>b__3(UniRx.Unit _);
        private void <InitializeAsync>b__4(UniRx.Unit _);
    }

    private struct <PRISM-Adapters-IOverlayView-HideAsync>d__21 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.LimitedVoiceSeparatePurchaseOverlayView <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_openPurchasePopupAsync>d__19 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public UniRx.IReadOnlyReactiveProperty<PRISM.Domain.Jewel> jewelModel;
        public PRISM.Interactions.LimitedVoiceSeparatePurchaseOverlayView <>4__this;
        public System.Threading.CancellationToken cancellationToken;
        private PRISM.Domain.Jewel <beforeHavingJewel>5__2;
        private Awaiter<PRISM.Adapters.ConfirmJewelPurchasePopupResultType> <>u__1;
        private PRISM.Module.Networking.IUnlockLimitedSongPartsReply <result>5__3;
        private Awaiter<PRISM.Module.Networking.IUnlockLimitedSongPartsReply> <>u__2;
        private Awaiter <>u__3;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class LiveParameterBeforeAfterView : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI beforeText;
    private ENTERPRISE.UI.UITextMeshProUGUI afterText;
    private UnityEngine.GameObject upArrow;
    private UnityEngine.GameObject downArrow;
    public void SetValues(int before, int after);
}

// Namespace: PRISM.Interactions
public class LiveSkillSettingOverlayIdolView : UnityEngine.MonoBehaviour, PRISM.Live.IDraggable
{
    private PRISM.Interactions.ProduceIdolIconView iconView;
    private ENTERPRISE.UI.UITextMeshProUGUI liveSkillText;
    private UnityEngine.GameObject emptyView;
    private PRISM.Interactions.ViewStateChanger initialSkillOrderStateChanger;
    private PRISM.Interactions.ViewStateChanger skillOrderStateChanger;
    private PRISM.Interactions.ViewStateChanger isDefaultOrderStateChanger;
    private UnityEngine.CanvasGroup dragTargetObject;
    private UnityEngine.GameObject dragMark;
    public UnityEngine.GameObject DragTargetObject { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Live.LiveIdol idol, System.Threading.CancellationToken ct);
    public void RenderSkillOrder(int order, int defaultOrder, bool isFirst);
    public UnityEngine.GameObject BeginDrag(UnityEngine.Transform parent);
    public void EndDrag();
}

// Namespace: PRISM.Interactions
public class LiveSkillSettingOverlayView : PRISM.Interactions.OverlayViewWithOkCancelButton<System.Collections.Generic.IReadOnlyList<int>>, PRISM.Adapters.ILiveSkillSettingOverlayView, PRISM.Adapters.IClosableOverlayView<System.Collections.Generic.IReadOnlyList<int>>, PRISM.Adapters.IOverlayView, PRISM.Adapters.IClosable<System.Collections.Generic.IReadOnlyList<int>>
{
    private PRISM.Interactions.LiveSkillSettingOverlayIdolView[] idolViews;
    private PRISM.Interactions.ButtonView resetButton;
    private int[] orders;
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Live.LiveUnit unit, System.Threading.CancellationToken ct);
    protected System.Collections.Generic.IReadOnlyList<int> _createReturnValue(bool isOk);

    private class <>c__DisplayClass3_0
    {
        public PRISM.Interactions.LiveSkillSettingOverlayView <>4__this;
        public int[] defaultOrders;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        private void <InitializeAsync>b__0(UniRx.Unit _);
        private Cysharp.Threading.Tasks.UniTask <InitializeAsync>b__1(int i, int j);
        private Cysharp.Threading.Tasks.UniTask <InitializeAsync>b__2(PRISM.Interactions.LiveSkillSettingOverlayIdolView view, PRISM.Live.LiveIdol idol);
        private void <InitializeAsync>g__RenderOrders|3(bool isFirst);
    }
}

// Namespace: PRISM.Interactions
public class MusicInfoOverlayView : PRISM.Interactions.OverlayViewWithCloseButton, PRISM.Adapters.IMusicInfoOverlayView, PRISM.Adapters.IClosableOverlayView<UniRx.Unit>, PRISM.Adapters.IOverlayView, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private ENTERPRISE.UI.UITextMeshProUGUI musicName;
    private UnityEngine.UI.RawImage jacketImage;
    private UnityEngine.UI.RawImage[] jacketEffects;
    private PRISM.Interactions.ButtonView purchaseMusicButton;
    private PRISM.Live.MusicCreditsView musicCredits;
    private UnityEngine.UI.ScrollRect creditInfoScrollRect;
    public System.IObservable<UniRx.Unit> OnPurchase { get; set; }
    public void Initialize(PRISM.Live.MusicData musicData, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Module.Networking.IMvIdolStatus, int> <>9__8_1;
        private int <Initialize>b__8_1(PRISM.Module.Networking.IMvIdolStatus x);
    }

    private class <>c__DisplayClass8_0
    {
        public PRISM.Interactions.MusicInfoOverlayView <>4__this;
        public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstCharacterInfo> characters;
        private void <Initialize>b__0();
        private PRISM.Definitions.MstCharacterInfo <Initialize>b__2(PRISM.Module.Networking.IMvIdolStatus x);
    }

    private class <>c__DisplayClass8_1
    {
        public string format;
        private string <Initialize>b__3(PRISM.Definitions.MstCharacterInfo x);
    }
}

// Namespace: PRISM.Interactions
public class MusicRankingCategoryListCell : PRISM.CommonListViewCell<PRISM.Live.MusicRankingCategory, PRISM.CommonListViewContext>
{
    private UnityEngine.UI.Image cellImage;
    private UnityEngine.Sprite[] cellSprites;
    public void UpdateContent(PRISM.Live.MusicRankingCategory category);
}

// Namespace: PRISM.Interactions
public class MusicRankingCategoryView : PRISM.CommonListView<PRISM.Interactions.MusicRankingCategoryListCell, PRISM.Live.MusicRankingCategory, PRISM.CommonListViewContext>
{
}

// Namespace: PRISM.Interactions
public class MusicRankingOverlayView : PRISM.Interactions.OverlayViewWithCloseButton, PRISM.Adapters.IMusicRankingOverlayView, PRISM.Adapters.IClosableOverlayView<UniRx.Unit>, PRISM.Adapters.IOverlayView, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.MusicScoreRankingTabView scoreRankingTab;
    private PRISM.Interactions.UnitRankingTabView unitRankingTab;
    private PRISM.Interactions.MusicRankingCategoryView categoryView;
    private UniRx.Subject<PRISM.Live.MusicRankingCategory> onSelectedTab;
    public System.IObservable<PRISM.Live.MusicRankingCategory> OnSelectedTab { get; set; }
    public System.IObservable<UniRx.Unit> OnClickSwitchMusicButton { get; set; }
    public System.IObservable<int> OnChangeUnit { get; set; }
    public void Initialize(PRISM.Adapters.MusicRankingTabViewModel musicRankingTabViewModel, PRISM.Adapters.UnitRankingTabViewModel unitRankingTabViewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken cancellationToken);
    private void <Initialize>b__10_0(int index);
    private void <Initialize>b__10_1(PRISM.Live.MusicRankingCategory category);
}

// Namespace: PRISM.Interactions
public class MusicRankingPeriodView : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI dateText;
    private UnityEngine.GameObject dateTextArea;
    private ENTERPRISE.UI.UITextMeshProUGUI timeText;
    private System.DateTime endDate;
    private System.IDisposable intervalDisposable;
    private static float intervalSecond;
    public void SetData(System.DateTime endDate);
    private void UpdateText();
    private void <SetData>b__6_0(long _);
}

// Namespace: PRISM.Interactions
public class MusicScoreRankingCell : PRISM.EnhancedListViewCell<PRISM.Adapters.MusicScoreRankingViewModel, PRISM.Interactions.MusicScoreRankingContext>
{
    private PRISM.Interactions.ButtonView toggleDetailButton;
    private PRISM.Interactions.ViewStateChanger stateChanger;
    private PRISM.Interactions.RankingHeaderView headerView;
    private PRISM.Interactions.ProduceIdolIconView idolIcon;
    private PRISM.Interactions.ButtonView idolIconButton;
    private ENTERPRISE.UI.UITextMeshProUGUI userName;
    private ENTERPRISE.UI.UITextMeshProUGUI score;
    private UnityEngine.GameObject[] scoreDivisionLabels;
    private PRISM.Interactions.SimpleAchievementIconGroup achievementIcons;
    private UnityEngine.GameObject myselfCellBase;
    private PRISM.Interactions.ViewStateChanger myselfCellStateChanger;
    private UnityEngine.GameObject extendArea;
    private ENTERPRISE.UI.UITextMeshProUGUI totalPower;
    private PRISM.Interactions.MusicScoreRankingIdolView[] userIdolIcons;
    private PRISM.Interactions.Live.LiveSupportCharacterView[] supportCharacterViews;
    private PRISM.Interactions.MusicScoreRankingIdolView guestIdolIcon;
    private PRISM.AutoCancellationTokenSource canceller;
    protected void _initialize();
    public void UpdateContent(PRISM.Adapters.MusicScoreRankingViewModel data);
    public void OnDestroy();
    private void <_initialize>b__17_0(UniRx.Unit _);
    private void <_initialize>b__17_1(UniRx.Unit _);

    private class <>c__DisplayClass18_0
    {
        public int i;
        private bool <UpdateContent>b__0(PRISM.Module.Networking.ILiveRankingUnitIdolStatus ii);
    }

    private class <>c__DisplayClass18_1
    {
        public PRISM.Interactions.Live.LiveSupportCharacterView view;
        private void <UpdateContent>b__1(PRISM.Interactions.MusicScoreRankingStatusDisplayType type);
    }
}

// Namespace: PRISM.Interactions
public class MusicScoreRankingIdolView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ProduceIdolIconView iconView;
    private ENTERPRISE.UI.UITextMeshProUGUI totalParameterText;
    private ENTERPRISE.UI.UITextMeshProUGUI skillText;
    private PRISM.Interactions.ViewStateChanger statusDisplayState;
    public void Setup(PRISM.Module.Networking.ILiveRankingUnitIdolStatus idol, PRISM.Interactions.MusicScoreRankingContext context, System.Threading.CancellationToken ct);
    public void SetupGuest(PRISM.Module.Networking.ILiveRankingGuestStatus guest, PRISM.Interactions.MusicScoreRankingContext context, System.Threading.CancellationToken ct);
    private void _setup(int mstProduceIdolId, int star, PRISM.Interactions.MusicScoreRankingContext context, System.Threading.CancellationToken ct);
    private void <_setup>b__6_0(PRISM.Interactions.MusicScoreRankingStatusDisplayType type);
}

// Namespace: PRISM.Interactions
public class MusicScoreRankingTabView : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.ButtonBase switchMusicButton;
    private UnityEngine.UI.RawImage musicJacket;
    private PRISM.Interactions.MusicBasicInfoView musicBasicInfoView;
    private PRISM.Live.UserRankingView userRankingView;
    private PRISM.Interactions.MusicScoreRankingView musicScoreRankingView;
    private PRISM.Interactions.ToggleGroupView difficultiesToggleGroup;
    private PRISM.Adapters.MusicRankingTabViewModel viewModel;
    private bool isInitialized;
    public System.IObservable<UniRx.Unit> OnClickSwitchMusicButton { get; set; }
    public void Initialize(PRISM.Adapters.MusicRankingTabViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken cancellationToken);
    private Cysharp.Threading.Tasks.UniTask _refreshAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken cancellationToken);
    private void _updateList();

    private class <>c__DisplayClass10_0
    {
        public PRISM.Interactions.MusicScoreRankingTabView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken cancellationToken;
        private void <Initialize>b__0(UniRx.Unit _);
        private void <Initialize>b__1(PRISM.Adapters.MusicScoreRankingViewModel viewModel);
        private void <Initialize>b__2(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions
public class MusicScoreRankingView : PRISM.EnhancedListView<PRISM.Adapters.MusicScoreRankingViewModel, PRISM.Interactions.MusicScoreRankingContext>
{
    public System.IObservable<PRISM.Adapters.MusicScoreRankingViewModel> OnIdolIconLongPressed { get; set; }
    protected void Initialize();
    public float GetCellViewSize(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex);
    private void <get_OnIdolIconLongPressed>b__1_0(System.Action<PRISM.Adapters.MusicScoreRankingViewModel> h);
    private void <get_OnIdolIconLongPressed>b__1_1(System.Action<PRISM.Adapters.MusicScoreRankingViewModel> h);
    private void <Initialize>b__2_0(int dataIndex);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<long, PRISM.Interactions.MusicScoreRankingStatusDisplayType> <>9__2_1;
        private PRISM.Interactions.MusicScoreRankingStatusDisplayType <Initialize>b__2_1(long i);
    }
}

// Namespace: PRISM.Interactions
public class MusicScoreRankingContext : PRISM.EnhancedListViewContext
{
    private System.Action<int> <OnCellClicked>k__BackingField;
    private System.Action<PRISM.Adapters.MusicScoreRankingViewModel> <OnIdolIconLongPressed>k__BackingField;
    private System.IObservable<PRISM.Interactions.MusicScoreRankingStatusDisplayType> <StatusDisplayType>k__BackingField;
    public System.Action<int> OnCellClicked { get; set; }
    public System.Action<PRISM.Adapters.MusicScoreRankingViewModel> OnIdolIconLongPressed { get; set; }
    public System.IObservable<PRISM.Interactions.MusicScoreRankingStatusDisplayType> StatusDisplayType { get; set; }
}

// Namespace: PRISM.Interactions
public enum MusicScoreRankingStatusDisplayType : System.Enum
{
    public int value__;
    public static PRISM.Interactions.MusicScoreRankingStatusDisplayType TotalParameter;
    public static PRISM.Interactions.MusicScoreRankingStatusDisplayType Skill;
}

// Namespace: PRISM.Interactions
public class UnitRankingListCell : PRISM.EnhancedListViewCell<PRISM.Adapters.UnitRankingViewModel, PRISM.Interactions.UnitRankingListContext>
{
    private PRISM.Interactions.ButtonView toggleDetailButton;
    private PRISM.Interactions.ViewStateChanger stateChanger;
    private PRISM.Interactions.RankingHeaderView headerView;
    private PRISM.Interactions.ProduceIdolIconView idolIcon;
    private PRISM.Interactions.ButtonView idolIconButton;
    private ENTERPRISE.UI.UITextMeshProUGUI userName;
    private ENTERPRISE.UI.UITextMeshProUGUI score;
    private PRISM.Interactions.SimpleAchievementIconGroup achievementIcons;
    private UnityEngine.GameObject myselfCellBase;
    private PRISM.Interactions.ViewStateChanger myselfCellStateChanger;
    private UnityEngine.GameObject extendArea;
    private PRISM.Interactions.UnitRankingMusicScoreListView scoreListView;
    private PRISM.UI.OnDragSender dragSender;
    private PRISM.AutoCancellationTokenSource canceller;
    protected void _initialize();
    public void UpdateContent(PRISM.Adapters.UnitRankingViewModel data);
    private void <_initialize>b__14_0(UniRx.Unit _);
    private void <_initialize>b__14_1(UniRx.Unit _);
}

// Namespace: PRISM.Interactions
public class UnitRankingListView : PRISM.EnhancedListView<PRISM.Adapters.UnitRankingViewModel, PRISM.Interactions.UnitRankingListContext>
{
    public System.IObservable<PRISM.Adapters.UnitRankingViewModel> OnIdolIconLongPressed { get; set; }
    protected void Initialize();
    public float GetCellViewSize(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex);
    private void <get_OnIdolIconLongPressed>b__1_0(System.Action<PRISM.Adapters.UnitRankingViewModel> h);
    private void <get_OnIdolIconLongPressed>b__1_1(System.Action<PRISM.Adapters.UnitRankingViewModel> h);
    private void <Initialize>b__2_0(int dataIndex);
}

// Namespace: PRISM.Interactions
public class UnitRankingListContext : PRISM.EnhancedListViewContext
{
    private System.Action<int> <OnCellClicked>k__BackingField;
    private System.Action<PRISM.Adapters.UnitRankingViewModel> <OnIdolIconLongPressed>k__BackingField;
    public System.Action<int> OnCellClicked { get; set; }
    public System.Action<PRISM.Adapters.UnitRankingViewModel> OnIdolIconLongPressed { get; set; }
}

// Namespace: PRISM.Interactions
public class UnitRankingMusicScoreCell : PRISM.Interactions.ListViewCell<PRISM.Adapters.UnitRankingMusicScoreViewModel>
{
    private UnityEngine.UI.RawImage jacketIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI songName;
    private ENTERPRISE.UI.UITextMeshProUGUI score;
    private PRISM.AutoCancellationTokenSource canceller;
    public void UpdateContent(PRISM.Adapters.UnitRankingMusicScoreViewModel itemData);
}

// Namespace: PRISM.Interactions
public class UnitRankingMusicScoreListView : PRISM.Interactions.ListView<PRISM.Interactions.UnitRankingMusicScoreCell, PRISM.Adapters.UnitRankingMusicScoreViewModel>
{
}

// Namespace: PRISM.Interactions
public class UnitRankingTabView : UnityEngine.MonoBehaviour
{
    private PRISM.Live.UserRankingView userRankingView;
    private PRISM.Interactions.UnitRankingListView unitRankingListView;
    private PRISM.Interactions.UnitRankingCategorySelectListView categorySelectListView;
    private bool isInitialized;
    public System.IObservable<int> OnChangeUnitTab { get; set; }
    public void Initialize(PRISM.Adapters.UnitRankingTabViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken cancellationToken);

    private class <>c__DisplayClass6_0
    {
        public PRISM.Interactions.UnitRankingTabView <>4__this;
        public PRISM.Adapters.UnitRankingTabViewModel viewModel;
        public System.Threading.CancellationToken cancellationToken;
        private void <Initialize>b__0(int index);
        private void <Initialize>b__1(int category);
        private void <Initialize>b__2(PRISM.Adapters.UnitRankingViewModel viewModel);
        private void <Initialize>b__3(UniRx.Unit _);
        private void <Initialize>g__Refresh|4();
    }

    private class <>c__DisplayClass6_1
    {
        public int category;
        private bool <Initialize>b__5(int m);
    }
}

// Namespace: PRISM.Interactions
public class UnitRankingUnitSelectListCell : PRISM.CommonListViewCell<int, PRISM.CommonListViewContext>
{
    private PRISM.Interactions.ButtonView buttonView;
    private UnityEngine.UI.RawImage logoImage;
    private System.Threading.CancellationTokenSource cancellationTokenSource;
    private int category;
    public void Initialize();
    public void UpdateContent(int category);
    private void OnDestroy();
    private void <Initialize>b__4_0(UniRx.Unit _);
}

// Namespace: PRISM.Interactions
public class UnitRankingCategorySelectListView : PRISM.CommonListView<PRISM.Interactions.UnitRankingUnitSelectListCell, int, PRISM.CommonListViewContext>
{
}

// Namespace: PRISM.Interactions
public class MusicRateDetailView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.MusicRateOverlayUserInfoView userInfoView;
    private PRISM.Interactions.ToggleGroupView tabGroup;
    private PRISM.Interactions.MusicRateRewardListView rewardListView;
    private PRISM.Interactions.MusicRateTargetMusicListView targetMusicListView;
    private UniRx.Subject<System.ValueTuple<int, SongDifficultyLevel>> playMusicSubject;
    public System.IObservable<System.ValueTuple<int, SongDifficultyLevel>> OnPlayMusic { get; set; }
    public void Initialize(PRISM.Adapters.MusicRateDetailViewModel viewModel);
    private void _initializeRewardList(PRISM.Adapters.MusicRateDetailViewModel viewModel);
    private void _initializeMusicList(PRISM.Adapters.MusicRateDetailViewModel viewModel);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Adapters.MusicRateRewardListCellData, float> <>9__8_1;
        public static System.Func<PRISM.Adapters.MusicRateRewardListCellData, PRISM.Interactions.MusicRateRewardListCellType> <>9__8_2;
        private float <_initializeRewardList>b__8_1(PRISM.Adapters.MusicRateRewardListCellData x);
        private PRISM.Interactions.MusicRateRewardListCellType <_initializeRewardList>b__8_2(PRISM.Adapters.MusicRateRewardListCellData x);
    }

    private class <>c__DisplayClass8_0
    {
        public PRISM.Interactions.MusicRateDetailView <>4__this;
        public PRISM.Adapters.MusicRateDetailViewModel viewModel;
        private void <_initializeRewardList>b__0(UniRx.Unit _);
    }

    private class <>c__DisplayClass9_0
    {
        public System.Collections.Generic.List<PRISM.Adapters.MusicRateTargetMusicListCellData> dataList;
        public PRISM.Interactions.MusicRateDetailView <>4__this;
        private void <_initializeMusicList>b__0(int i);
    }
}

// Namespace: PRISM.Interactions
public class MusicRateOverlayUserInfoView : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.RawImage produceIdolIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI userNameText;
    private PRISM.Interactions.MusicRateView rateView;
    public void SetUp(PRISM.Adapters.MusicRateOverlayUserInfoViewModel model, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Interactions
public class MusicRateOverlayView : PRISM.Interactions.OverlayViewBase, PRISM.Adapters.IMusicRateOverlayView, PRISM.Adapters.IClosableOverlayView<System.ValueTuple<int, SongDifficultyLevel>>, PRISM.Adapters.IOverlayView, PRISM.Adapters.IClosable<System.ValueTuple<int, SongDifficultyLevel>>
{
    private PRISM.Interactions.ToggleGroupView rateToggleGroup;
    private PRISM.Interactions.MusicRateDetailView highScoreRateView;
    private PRISM.Interactions.MusicRateDetailView technicalRateView;
    private PRISM.Interactions.ButtonView backButton;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<System.ValueTuple<int, SongDifficultyLevel>> onClose;
    public Cysharp.Threading.Tasks.UniTask<System.ValueTuple<int, SongDifficultyLevel>> OnCloseRequested { get; set; }
    public void Assign(PRISM.Live.MusicRateType initialDisplayType, PRISM.Adapters.MusicRateDetailViewModel highScoreRateData, PRISM.Adapters.MusicRateDetailViewModel technicalRateData);
    private void <Assign>b__7_0(System.ValueTuple<int, SongDifficultyLevel> x);
    private void <Assign>b__7_1(UniRx.Unit _);
}

// Namespace: PRISM.Interactions
public class MusicRateRewardListCell : PRISM.EnhancedListViewCell<PRISM.Adapters.MusicRateRewardListCellData, PRISM.Interactions.MusicRateRewardListContext>
{
    private UnityEngine.Transform behindBackground;
    private UnityEngine.GameObject[] backgrounds;
    private UnityEngine.Transform beforeBackground;
    private PRISM.Interactions.MusicRateView rateView;
    private UnityEngine.Transform rewardIconContainer;
    private ENTERPRISE.OutGame.RewardItem rewardIconBase;
    private UnityEngine.GameObject postUnlockShinyBackground;
    private UnityEngine.Material gradeNameGradationMaterial;
    private PRISM.Interactions.MusicRateSprites gradeNameGradationTextures;
    private UnityEngine.Material currentMaterial;
    public void UpdateContent(PRISM.Adapters.MusicRateRewardListCellData data);
    private void Update();
    private void OnDestroy();
}

// Namespace: PRISM.Interactions
public class MusicRateRewardListContext : PRISM.EnhancedListViewContext
{
    private float <EffectNormalizedTime>k__BackingField;
    public float EffectNormalizedTime { get; set; }
}

// Namespace: PRISM.Interactions
public class MusicRateRewardListUnlockMasterCell : PRISM.EnhancedListViewCell<PRISM.Adapters.MusicRateRewardListCellData, PRISM.Interactions.MusicRateRewardListContext>
{
    private ENTERPRISE.UI.UITextMeshProUGUI gradeNameText;
    private ENTERPRISE.UI.UITextMeshProUGUI masterLevelText;
    public void UpdateContent(PRISM.Adapters.MusicRateRewardListCellData data);
}

// Namespace: PRISM.Interactions
public class MusicRateRewardListUnlockShinyCell : PRISM.EnhancedListViewCell<PRISM.Adapters.MusicRateRewardListCellData, PRISM.Interactions.MusicRateRewardListContext>
{
    private ENTERPRISE.UI.ButtonBase button;
    private UnityEngine.GameObject lockObject;
    private UnityEngine.GameObject unlockObject;
    private PRISM.Interactions.ButtonView howToPlayButton;
    private PRISM.HowToPlayPopupOpener howToPlayPopupOpener;
    protected void _initialize();
    public void UpdateContent(PRISM.Adapters.MusicRateRewardListCellData data);
    private void <_initialize>b__5_0(UniRx.Unit _);

    private class <>O
    {
        public static System.Action <0>__ShowShinyLockedModal;
    }
}

// Namespace: PRISM.Interactions
public class MusicRateRewardListView : PRISM.EnhancedListView<PRISM.Adapters.MusicRateRewardListCellData, PRISM.Interactions.MusicRateRewardListContext>
{
    private float effectDuration;
    private float unlockShinyCellSize;
    private PRISM.Interactions.MusicRateRewardListUnlockShinyCell unlockShinyCell;
    private float unlockMasterCellSize;
    private PRISM.Interactions.MusicRateRewardListUnlockMasterCell unlockMasterCell;
    private void Update();
    public float GetCellViewSize(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex);
    public EnhancedUI.EnhancedScroller.EnhancedScrollerCellView GetCellView(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex, int cellIndex);
}

// Namespace: PRISM.Interactions
public class MusicRateTargetMusicListCell : PRISM.CommonListViewCell<PRISM.Adapters.MusicRateTargetMusicListCellData, PRISM.Interactions.MusicRateTargetMusicListViewContext>
{
    private ENTERPRISE.UI.UITextMeshProUGUI listTitle;
    private UnityEngine.UI.RawImage musicJacketIcon;
    private PRISM.Interactions.MusicBasicInfoView musicBasicInfoView;
    private UnityEngine.GameObject highScoreParent;
    private ENTERPRISE.UI.UITextMeshProUGUI highScoreText;
    private ENTERPRISE.UI.UITextMeshProUGUI highScoreRateText;
    private UnityEngine.GameObject technicalScoreParent;
    private ENTERPRISE.UI.UITextMeshProUGUI technicalScoreText;
    private ENTERPRISE.UI.UITextMeshProUGUI technicalRateText;
    private PRISM.AutoCancellationTokenSource canceller;
    public void UpdateContent(PRISM.Adapters.MusicRateTargetMusicListCellData data);
}

// Namespace: PRISM.Interactions
public class MusicRateTargetMusicListView : PRISM.CommonListView<PRISM.Interactions.MusicRateTargetMusicListCell, PRISM.Adapters.MusicRateTargetMusicListCellData, PRISM.Interactions.MusicRateTargetMusicListViewContext>
{
    public void SetScrollPosition(float position);
    public void SetCanSelectMusic(bool canSelectMusic);
}

// Namespace: PRISM.Interactions
public class MusicRateTargetMusicListViewContext : PRISM.CommonListViewContext
{
    private bool <CanSelectMusic>k__BackingField;
    public bool CanSelectMusic { get; set; }
}

// Namespace: PRISM.Interactions
public class VocalSeparateIdolListCell : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.CharacterBaseIconView characterBaseIcon;
    private UnityEngine.GameObject centerIcon;
    private UnityEngine.GameObject onStageIcon;
    private UnityEngine.GameObject duplicatedIcon;
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Adapters.LimitedVoiceSeparateIdolListCellModel model, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
}

// Namespace: PRISM.Interactions
public class VocalSeparateIdolListView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.VocalSeparateIdolListCell cellPrefab;
    private UnityEngine.RectTransform cellArea;
    public Cysharp.Threading.Tasks.UniTask SetupAsync(System.Collections.Generic.IEnumerable<PRISM.Adapters.LimitedVoiceSeparateIdolListCellModel> models, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);

    private class <>c__DisplayClass2_0
    {
        public PRISM.Interactions.VocalSeparateIdolListView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        private Cysharp.Threading.Tasks.UniTask <SetupAsync>b__0(PRISM.Adapters.LimitedVoiceSeparateIdolListCellModel e);
    }
}

// Namespace: PRISM.Interactions
public class VocalSeparateSettingsPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IVocalSeparateSettingsPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.ViewStateChanger centerToggle;
    private PRISM.Interactions.ViewStateChanger onStageToggle;
    private PRISM.Interactions.ViewStateChanger duplicateToggle;
    private PRISM.Interactions.VocalSeparateIdolListView idolListView;
    private ENTERPRISE.UI.UITextMeshProUGUI songNameLabel;
    private PRISM.Interactions.ToggleGroupView soundEffectModeGroup;
    private UnityEngine.GameObject limitedOnlyView;
    private PRISM.Interactions.PopupFrameParameter frameParameter;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    private static System.Collections.Generic.IEnumerable<int> _getCenterAndOnStageCharacterIds(PRISM.Live.ILiveUnit unit, PRISM.Live.MusicData musicData);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void Assign(PRISM.Live.ILiveUnit unit, PRISM.Live.MusicData musicData, UniRx.IReactiveProperty<PRISM.Definitions.VocalSeparatedSoundEffectMode> soundEffectMode, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <Assign>b__13_4();
    private void <Assign>b__13_5();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Live.IIdol, int> <>9__11_0;
        public static System.Func<int, int> <>9__13_1;
        public static System.Func<System.Linq.IGrouping<int, int>, bool> <>9__13_2;
        private int <_getCenterAndOnStageCharacterIds>b__11_0(PRISM.Live.IIdol i);
        private int <Assign>b__13_1(int n);
        private bool <Assign>b__13_2(System.Linq.IGrouping<int, int> g);
    }

    private class <>c__DisplayClass13_0
    {
        public int centerCharacterId;
        public System.Collections.Generic.IEnumerable<int> onStageCharacterIds;
        public int[] targetCharacterIds;
        private PRISM.Adapters.LimitedVoiceSeparateIdolListCellModel <Assign>b__0(int id);
    }

    private class <>c__DisplayClass13_1
    {
        public int id;
        private bool <Assign>b__3(int id2);
    }
}

// Namespace: PRISM.Interactions
public class LiveBoostUsageSettingPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.ILiveBoostUsageSettingPopupView, PRISM.Adapters.IClosablePopupFrame<System.ValueTuple<bool, int, bool>>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<System.ValueTuple<bool, int, bool>>
{
    private PRISM.Live.LiveBoostUsageSliderView sliderView;
    private UnityEngine.GameObject zeroUsageAnnotation;
    private UnityEngine.GameObject zeroUnselectableAnnotation;
    private System.Action<int> onSliderValueChanged;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<System.ValueTuple<bool, int, bool>> onClick;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<System.ValueTuple<bool, int, bool>> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public void Assign(PRISM.Live.LiveBoostUsageSettingStatus liveBoostUsageSettingStatus, int eventId);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    private System.ValueTuple<bool, int, bool> _createReturnValue(bool isOk);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <ShowAsync>b__7_0(int value);
    private void <CreateFrameParameter>b__9_0();
    private void <CreateFrameParameter>b__9_1();
    private void <CreateFrameParameter>b__9_2();
}

// Namespace: PRISM.Interactions
public class LiveCameraModeSettingCharacterIcon : UnityEngine.MonoBehaviour
{
    private PRISM.UIGrayOutController grayOutController;
    private PRISM.UI.PFIdolIconRectView iconView;
    private UnityEngine.GameObject emptyView;
    private UnityEngine.GameObject[] emptyViewPositionMarks;
    private UnityEngine.GameObject focusMark;
    private UnityEngine.GameObject duplicatedMark;
    private UnityEngine.GameObject selectedMark;
    private PRISM.Interactions.ButtonView button;
    public System.IObservable<UniRx.Unit> OnClick { get; set; }
    public void SetUpLiveIdol(PRISM.Live.LiveIdol idol, PRISM.Live.LiveIdolPositionMark positionMark, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken cancellationToken);
    public void SetUpCharacter(PRISM.Live.IIdol idol, PRISM.Live.LiveIdolPositionMark positionMark, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken cancellationToken);
    public void SetGrayOutStatus(bool grayOut);
    public void SetButtonEnabled(bool isEnabled);
    public void SetFocusMarkActive(bool active);
    public void SetDuplicatedMarkActive(bool active);
    public void SetSelectedMarkActive(bool active);
    private bool _setUpCommon(PRISM.Live.IIdol idol, PRISM.Live.LiveIdolPositionMark positionMark);
}

// Namespace: PRISM.Interactions
public class LiveCameraModeSettingPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.ILiveCameraModeSettingPopupView, PRISM.Adapters.IClosablePopupFrame<System.ValueTuple<bool, PRISM.Live.LiveCameraMode, int>>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<System.ValueTuple<bool, PRISM.Live.LiveCameraMode, int>>
{
    private PRISM.Interactions.ToggleGroupView modeSelector;
    private PRISM.Interactions.LiveCameraModeSettingCharacterIcon[] characterIcons;
    private UnityEngine.GameObject summerIconGameObject;
    private PRISM.Interactions.ViewStateChanger grayOutObject;
    private PRISM.Interactions.ButtonView[] grayOutButtons;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<System.ValueTuple<bool, PRISM.Live.LiveCameraMode, int>> onSelect;
    private int selectedFocusPositionIndex;
    private UniRx.ReactiveProperty<int> currentCameraMode;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<System.ValueTuple<bool, PRISM.Live.LiveCameraMode, int>> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Initialize(PRISM.Live.LiveCameraModeSetting setting, PRISM.Live.MusicData musicData, PRISM.Live.ILiveUnit unit, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__12_1();
    private void <CreateFrameParameter>b__12_2();
    private void <CreateFrameParameter>b__12_3();
    private System.ValueTuple<bool, PRISM.Live.LiveCameraMode, int> <CreateFrameParameter>g__CreateReturnValue|12_0(bool isOk);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Interactions.ButtonView, System.IObservable<UniRx.Unit>> <>9__10_1;
        public static System.Action<UniRx.Unit> <>9__10_2;
        private System.IObservable<UniRx.Unit> <Initialize>b__10_1(PRISM.Interactions.ButtonView b);
        private void <Initialize>b__10_2(UniRx.Unit _);
    }

    private class <>c__DisplayClass10_0
    {
        public PRISM.Interactions.LiveCameraModeSettingPopupView <>4__this;
        public PRISM.Live.ILiveUnit unit;
        private void <Initialize>b__0(int mode);
    }

    private class <>c__DisplayClass10_1
    {
        public int reservedI;
        public <>c__DisplayClass10_0 CS$<>8__locals1;
        private void <Initialize>b__3(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions
public class LiveMusicRewardPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.ILiveMusicRewardPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private UnityEngine.UI.RawImage musicTypeIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI musicName;
    private PRISM.Interactions.ToggleGroupView musicDifficultyToggleGroup;
    private UnityEngine.GameObject maskRoot;
    private ENTERPRISE.UI.UITextMeshProUGUI maskLabel;
    private PRISM.Interactions.ButtonView skipButton;
    private PRISM.Interactions.MusicRewardInfoCell[] scoreRankRewardInfoCells;
    private PRISM.Interactions.MusicRewardInfoCell[] comboRankRewardInfoCells;
    private UniRx.ReactiveProperty<int> currentToggleIndex;
    private System.Threading.CancellationTokenSource animationCanceller;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    private PRISM.Live.MusicData musicData;
    private PRISM.Live.MusicData afterMusicData;
    private System.Action afterAnimationAction;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Initialize(PRISM.ResourceManagement.IResourceLoader resourceLoader, SongDifficultyLevel musicDifficulty, PRISM.Live.MusicData musicData, PRISM.Live.MusicData afterMusicData, System.Action afterAnimationAction);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    private void _updateView();
    private Cysharp.Threading.Tasks.UniTask _playNewAnimationAsync(System.Threading.CancellationToken ct);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <Initialize>b__17_0(UniRx.Unit _);
    private void <Initialize>b__17_1(int _);
    private void <CreateFrameParameter>b__21_0();
    private void <CreateFrameParameter>b__21_1();

    private class <>c
    {
        public static <>c <>9;
        public static System.Predicate<PRISM.Interactions.MusicRewardInfoCell> <>9__20_0;
        public static System.Func<CriWare.CriAtomExPlayback> <>9__20_1;
        private bool <_playNewAnimationAsync>b__20_0(PRISM.Interactions.MusicRewardInfoCell x);
        private CriWare.CriAtomExPlayback <_playNewAnimationAsync>b__20_1();
    }

    private struct <ShowAsync>d__18 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.LiveMusicRewardPopupView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_playNewAnimationAsync>d__20 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.LiveMusicRewardPopupView <>4__this;
        public System.Threading.CancellationToken ct;
        private System.Collections.Generic.List<PRISM.Interactions.MusicRewardInfoCell> <cells>5__2;
        private Awaiter <>u__1;
        private Enumerator<PRISM.Interactions.MusicRewardInfoCell> <>7__wrap2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class LiveMVUnitRecommendPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.ILiveMVUnitRecommendPopupView, PRISM.Adapters.IClosablePopupFrame<System.Nullable<PRISM.Live.LiveMvUnitRecommendConfig>>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<System.Nullable<PRISM.Live.LiveMvUnitRecommendConfig>>
{
    private PRISM.Interactions.ToggleGroupView easyCostumeChangeToggleGroupView;
    private PRISM.Interactions.ViewStateChanger mvOriginalCostumeExistsStateChanger;
    private PRISM.Interactions.ToggleGroupView priorityToggleGroupView;
    private PRISM.Interactions.ToggleGroupView unitToggleGroupView;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<System.Nullable<PRISM.Live.LiveMvUnitRecommendConfig>> onSelect;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<System.Nullable<PRISM.Live.LiveMvUnitRecommendConfig>> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void SetMvOriginalCostumeGrayOut(bool mvOriginalCostumeExists);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Definitions.MstUnit, bool> <>9__7_2;
        private bool <CreateFrameParameter>b__7_2(PRISM.Definitions.MstUnit x);
    }

    private class <>c__DisplayClass7_0
    {
        public PRISM.Interactions.LiveMVUnitRecommendPopupView <>4__this;
        public UniRx.ReactiveProperty<int> unitId;
        public UniRx.ReactiveProperty<PRISM.Live.LiveUnitRecommendCostume> costume;
        public UniRx.ReactiveProperty<PRISM.Live.LiveMvUnitRecommendPriority> priority;
        private void <CreateFrameParameter>b__0();
        private void <CreateFrameParameter>b__1();
        private void <CreateFrameParameter>b__3();
    }
}

// Namespace: PRISM.Interactions
public class LiveSettingTabBase`1<T> : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView resetButton;
    private UniRx.Subject<T> onOptionChangedSubject;
    protected bool IsCallFromRhythmGame;
    protected T Option;
    public System.IObservable<T> OnOptionChanged { get; set; }
    public void Initialize(T option, bool isCallFromRhythmGame, PRISM.RhythmGame.RhythmGameConfig config);
    public void SetValueWithoutNotify();
    protected void NotifyOptionChanged();
    private void <Initialize>b__6_0(UniRx.Unit _);
}

// Namespace: PRISM.Interactions
public class LiveStageDetailPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.ILiveStageDetailPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private UnityEngine.UI.RawImage musicTypeIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI unitBonusMessage;
    private UnityEngine.GameObject unitBonusDetail;
    private ENTERPRISE.UI.UITextMeshProUGUI unitBonusEachCharacterText;
    private ENTERPRISE.UI.UITextMeshProUGUI unitBonusTargetNumberText;
    private UnityEngine.GameObject unitBonusDetailSolo;
    private PRISM.Interactions.AttributeIconView attributeIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI attributeBonusMessage;
    private UnityEngine.UI.ScrollRect featuredRewardScrollRect;
    private UnityEngine.UI.ScrollRect rareRewardScrollRect;
    private ENTERPRISE.OutGame.RewardItem rewardItemBase;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClick;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void Assign(PRISM.Live.MusicData musicData, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.ILivePlayRewardStatus> rewardList, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__14_0();
    private void <CreateFrameParameter>b__14_1();
    private void <Assign>g__CreateRewardItems|15_0(UnityEngine.UI.ScrollRect scrollRect, LivePlayDisplayLotteryRewardType type, <>c__DisplayClass15_0& );
    private string <Assign>g__GetTargetName|15_1(<>c__DisplayClass15_0& );

    private struct <>c__DisplayClass15_0 : System.ValueType
    {
        public System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.ILivePlayRewardStatus> rewardList;
        public PRISM.Interactions.LiveStageDetailPopupView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public int memberCount;
        public ENTERPRISE.Localization.LocalizationManager localizer;
        public PRISM.Live.MusicData musicData;
    }

    private class <>c__DisplayClass15_1
    {
        public LivePlayDisplayLotteryRewardType type;
        public System.Func<PRISM.Module.Networking.ILivePlayRewardStatus, bool> <>9__2;
        private bool <Assign>b__2(PRISM.Module.Networking.ILivePlayRewardStatus r);
    }

    private class <>c__DisplayClass15_2
    {
        public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstCharacterInfo> characters;
        private string <Assign>b__3(PRISM.Module.Networking.IMvIdolStatus x);
    }

    private struct <ShowAsync>d__20 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.LiveStageDetailPopupView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class LiveUnitEasyCostumeChangePopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.ILiveUnitEasyCostumeChangePopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private PRISM.Interactions.ToggleGroupView easyCostumeChangeToggleGroupView;
    private PRISM.Interactions.ViewStateChanger liveMvStateChanger;
    private PRISM.Interactions.ViewStateChanger mvOriginalCostumeExistsStateChanger;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Initialize(PRISM.Adapters.LiveUnitEasyCostumeChangePopupViewModel viewModel);
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
public class LiveUnitEditCopyOrResetToggleView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ToggleButtonView mainUnitToggle;
    private PRISM.Interactions.ToggleButtonView supportMemberToggle;
    private PRISM.Interactions.ToggleButtonView guestToggle;
    private PRISM.Interactions.ToggleButtonView unitNameToggle;
    private PRISM.Interactions.ToggleButtonView skillOrderToggle;
    public void Initialize(PRISM.Adapters.LiveUnitEditCopyOrResetViewModel viewModel);
}

// Namespace: PRISM.Interactions
public class LiveUnitEditUseRecommendedPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.ILiveUnitEditUseRecommendedPopupView, PRISM.Adapters.IClosablePopupFrame<System.Nullable<PRISM.Live.LiveUnitRecommendConfig>>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<System.Nullable<PRISM.Live.LiveUnitRecommendConfig>>
{
    private PRISM.Interactions.ToggleGroupView recommendTargetToggleButtonGroup;
    private PRISM.Interactions.ToggleGroupView easyCostumeChangeToggleButtonGroup;
    private PRISM.Interactions.ViewStateChanger mvOriginalCostumeExistsStateChanger;
    private PRISM.Interactions.ToggleGroupView mainUnitSettingToggleButtonGroup;
    private PRISM.Interactions.ButtonView unitGrayOutButton;
    private PRISM.Interactions.ToggleGroupView targetUnitToggleButtonGroup;
    private PRISM.Interactions.ToggleGroupView supportSettingToggleButtonGroup;
    private PRISM.Interactions.ToggleGroupView guestSettingToggleButtonGroup;
    private PRISM.Interactions.ButtonView resetButton;
    private PRISM.Adapters.LiveUnitEditUseRecommendedPopupViewModel model;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<System.Nullable<PRISM.Live.LiveUnitRecommendConfig>> onClick;
    private PRISM.Interactions.IPopupFrameView parent;
    public System.IObservable<UniRx.Unit> OnClickGrayOutButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickResetButton { get; set; }
    public Cysharp.Threading.Tasks.UniTask<System.Nullable<PRISM.Live.LiveUnitRecommendConfig>> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    private void _notifyResult();
    public void Assign(PRISM.Adapters.LiveUnitEditUseRecommendedPopupViewModel model, bool mvOriginalCostumeExists);
    public void SetUnitGrayOut(bool value);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__17_0();
    private void <CreateFrameParameter>b__17_1();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Definitions.MstUnit, bool> <>9__18_0;
        private bool <_notifyResult>b__18_0(PRISM.Definitions.MstUnit x);
    }

    private struct <ShowAsync>d__25 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.LiveUnitEditUseRecommendedPopupView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class LiveUnitResetConfirmationPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.ILiveUnitResetConfirmationPopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private PRISM.Interactions.LiveUnitEditCopyOrResetToggleView toggleView;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Initialize(PRISM.Adapters.LiveUnitEditCopyOrResetViewModel viewModel);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <Initialize>b__4_0(bool condition);
    private void <CreateFrameParameter>b__5_0();
    private void <CreateFrameParameter>b__5_1();
    private void <CreateFrameParameter>b__5_2();
}

// Namespace: PRISM.Interactions
public class LiveUnitTotalParameterDetailPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.ILiveUnitTotalParameterDetailPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private ENTERPRISE.UI.UITextMeshProUGUI totalText;
    private ENTERPRISE.UI.UITextMeshProUGUI vocalText;
    private ENTERPRISE.UI.UITextMeshProUGUI danceText;
    private ENTERPRISE.UI.UITextMeshProUGUI visualText;
    private ENTERPRISE.UI.UITextMeshProUGUI mentalText;
    private ENTERPRISE.UI.UITextMeshProUGUI[] bonusTexts;
    private UnityEngine.RectTransform[] parameterGauges;
    private UnityEngine.GameObject[] parameterGaugesLabels;
    private UnityEngine.GameObject scoreOverflowMark;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClick;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void Assign(PRISM.Live.LiveUnit unit, PRISM.Live.MusicData musicData, SongDifficultyLevel musicDifficulty);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__13_0();
    private void <CreateFrameParameter>b__13_1();

    private enum BonusType : System.Enum
    {
        public int value__;
        public static BonusType BasicTotal;
        public static BonusType Support;
        public static BonusType Unit;
        public static BonusType Attribute;
        public static BonusType Center;
        public static BonusType Guest;
        public static BonusType Max;
    }

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Live.LiveIdol, int> <>9__14_0;
        public static System.Func<PRISM.Live.LiveIdol, int> <>9__14_1;
        public static System.Func<PRISM.Live.LiveIdol, int> <>9__14_2;
        public static System.Func<PRISM.Live.LiveIdol, int> <>9__14_3;
        public static System.Func<PRISM.Live.LiveIdol, int> <>9__14_4;
        public static System.Func<PRISM.Live.LiveIdol, int> <>9__14_5;
        public static System.Func<PRISM.Live.LiveIdol, int> <>9__14_6;
        public static System.Func<PRISM.Live.LiveIdol, int> <>9__14_7;
        public static System.Func<PRISM.Live.LiveIdol, int> <>9__14_8;
        private int <Assign>b__14_0(PRISM.Live.LiveIdol x);
        private int <Assign>b__14_1(PRISM.Live.LiveIdol x);
        private int <Assign>b__14_2(PRISM.Live.LiveIdol x);
        private int <Assign>b__14_3(PRISM.Live.LiveIdol x);
        private int <Assign>b__14_4(PRISM.Live.LiveIdol x);
        private int <Assign>b__14_5(PRISM.Live.LiveIdol x);
        private int <Assign>b__14_6(PRISM.Live.LiveIdol x);
        private int <Assign>b__14_7(PRISM.Live.LiveIdol x);
        private int <Assign>b__14_8(PRISM.Live.LiveIdol x);
    }

    private struct <ShowAsync>d__19 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.LiveUnitTotalParameterDetailPopupView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class MusicMasterDifficultyUnlockedPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IMusicMasterDifficultyUnlockedPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private UnityEngine.UI.RawImage musicJacketImage;
    private ENTERPRISE.UI.UITextMeshProUGUI message;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Definitions.MstSong musicMaster, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken cancellationToken);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__6_0();
    private void <CreateFrameParameter>b__6_1();
}

// Namespace: PRISM.Interactions
public class MusicRewardInfoCell : UnityEngine.MonoBehaviour
{
    protected UnityEngine.UI.Image rankImage;
    private UnityEngine.GameObject stampObject;
    private ENTERPRISE.OutGame.RewardItem rewardItem;
    private ENTERPRISE.UI.UITextMeshProUGUI conditionText;
    protected UnityEngine.Animator clearAnimator;
    private PRISM.Live.LiveUIResourceConfig resourceConfig;
    private static int NotClearedAnimationHash;
    private static int ClearedAnimationHash;
    private static int NewClearAnimationHash;
    private int clearStampAnimationHash;
    public void SetUp(PRISM.Definitions.MstLiveScoreRankReward reward, int conditionValue, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void SetUp(PRISM.Definitions.MstLiveComboRankReward reward, int conditionValue, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private void _setupItem(System.Collections.Generic.IReadOnlyList<string> productWithAmountList, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void PlayAnimation(PRISM.RewardClearStatusType clearStatusType);
    public void SkipAnimation(PRISM.RewardClearStatusType clearStatusType);
    private void _setAnimationHash(PRISM.RewardClearStatusType clearStatusType);
}

// Namespace: PRISM.Interactions
public class SkipLiveConfirmationPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.ISkipLiveConfirmationPopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private PRISM.Interactions.StaminaView liveBoostView;
    private ENTERPRISE.UI.UITextMeshProUGUI remainingSkipCount;
    private UnityEngine.RectTransform startButtonOverlayUI;
    protected PRISM.HowToPlayPopupOpener howToPlayPopupOpener;
    private PRISM.Interactions.LiveAutoLoopSettingUsageView loopSettingUsageView;
    private PRISM.Live.LiveBoostUsageRewardView rewardView;
    private PRISM.Interactions.ToggleButtonView alwaysMaxToggle;
    private static int SkipButtonIndex;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClick;
    private PRISM.Adapters.SkipLiveConfirmationPopupViewModel viewModel;
    private PRISM.Interactions.IPopupFrameView parent;
    public PRISM.Adapters.IStaminaView LiveBoostView { get; set; }
    public System.Threading.CancellationToken DestroyCancellationToken { get; set; }
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public void Assign(PRISM.Adapters.SkipLiveConfirmationPopupViewModel model);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__16_0();
    private void <CreateFrameParameter>b__16_1();
    private void <CreateFrameParameter>b__16_2();
    private void <CreateFrameParameter>b__16_3();
    private void <ShowAsync>b__17_0(int value);
    private void <ShowAsync>g__UpdateUsageViewInAlwaysStatus|17_1(bool isOn);

    private struct <ShowAsync>d__17 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.SkipLiveConfirmationPopupView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveCenterEffectConditionFilterToggleGroupViewFactory : PRISM.Interactions.DynamicFilterToggleGroupViewFactory
{
    protected System.Collections.Generic.IEnumerable<System.ValueTuple<int, string>> _enumerateItems();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Definitions.MstLiveCenterEffectDetail, int> <>9__0_0;
        public static System.Func<int, int> <>9__0_1;
        public static System.Func<int, System.ValueTuple<int, string>> <>9__0_2;
        private int <_enumerateItems>b__0_0(PRISM.Definitions.MstLiveCenterEffectDetail x);
        private int <_enumerateItems>b__0_1(int x);
        private System.ValueTuple<int, string> <_enumerateItems>b__0_2(int x);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveCenterEffectFilterToggleGroupViewFactory : PRISM.Interactions.DynamicFilterToggleGroupViewFactory
{
    protected System.Collections.Generic.IEnumerable<System.ValueTuple<int, string>> _enumerateItems();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Definitions.MstLiveCenterEffectDetail, int> <>9__0_0;
        public static System.Func<int, int> <>9__0_1;
        public static System.Func<int, System.ValueTuple<int, string>> <>9__0_2;
        private int <_enumerateItems>b__0_0(PRISM.Definitions.MstLiveCenterEffectDetail x);
        private int <_enumerateItems>b__0_1(int x);
        private System.ValueTuple<int, string> <_enumerateItems>b__0_2(int x);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveSkillFilterToggleGroupViewFactory : PRISM.Interactions.DynamicFilterToggleGroupViewFactory
{
    protected System.Collections.Generic.IEnumerable<System.ValueTuple<int, string>> _enumerateItems();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Definitions.MstLiveSkillLevel, int> <>9__0_0;
        public static System.Func<PRISM.Definitions.MstLiveSkillLevel, int> <>9__0_1;
        public static System.Func<PRISM.Definitions.MstLiveSkillLevel, System.ValueTuple<int, string>> <>9__0_2;
        private int <_enumerateItems>b__0_0(PRISM.Definitions.MstLiveSkillLevel x);
        private int <_enumerateItems>b__0_1(PRISM.Definitions.MstLiveSkillLevel x);
        private System.ValueTuple<int, string> <_enumerateItems>b__0_2(PRISM.Definitions.MstLiveSkillLevel x);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveSupportEffectConditionFilterToggleGroupViewFactory : PRISM.Interactions.DynamicFilterToggleGroupViewFactory
{
    protected System.Collections.Generic.IEnumerable<System.ValueTuple<int, string>> _enumerateItems();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Definitions.MstLiveSupportEffectDetail, int> <>9__0_0;
        public static System.Func<int, int> <>9__0_1;
        public static System.Func<int, System.ValueTuple<int, string>> <>9__0_2;
        private int <_enumerateItems>b__0_0(PRISM.Definitions.MstLiveSupportEffectDetail x);
        private int <_enumerateItems>b__0_1(int x);
        private System.ValueTuple<int, string> <_enumerateItems>b__0_2(int x);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveSupportEffectFilterToggleGroupViewFactory : PRISM.Interactions.DynamicFilterToggleGroupViewFactory
{
    protected System.Collections.Generic.IEnumerable<System.ValueTuple<int, string>> _enumerateItems();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Definitions.MstLiveSupportEffectType, System.ValueTuple<int, string>> <>9__0_0;
        private System.ValueTuple<int, string> <_enumerateItems>b__0_0(PRISM.Definitions.MstLiveSupportEffectType x);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveClearInfoFilterToggleGroupView : PRISM.Interactions.FilterToggleGroupView
{
    private PRISM.Interactions.ButtonView shinyLockedButton;
    public void Initialize(PRISM.Definitions.IReactiveHashSet<int> onIds, PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Adapters.IFilterToggleGroupViewOption option, System.Threading.CancellationToken cancellationToken);

    private class <>c
    {
        public static <>c <>9;
        public static System.Action<UniRx.Unit> <>9__1_0;
        private void <Initialize>b__1_0(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.Live
public class MusicFavoriteFilterToggleGroupView : PRISM.Interactions.FilterToggleGroupView
{
    private ENTERPRISE.UI.UITextMeshProUGUI[] slotNames;
    public void Initialize(PRISM.Definitions.IReactiveHashSet<int> onIds, PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Adapters.IFilterToggleGroupViewOption option, System.Threading.CancellationToken cancellationToken);
}

// Namespace: PRISM.Interactions.Live
public class LiveGuestProfileView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ProduceIdolIconView iconView;
    private PRISM.Interactions.ButtonView iconButton;
    private UnityEngine.GameObject emptyView;
    private ENTERPRISE.UI.UITextMeshProUGUI nameText;
    private PRISM.Interactions.ViewStateChanger friendStateChanger;
    private PRISM.Interactions.SimpleAchievementIconGroup achievementIconGroup;
    private PRISM.Interactions.ButtonView detailButton;
    private UniRx.Subject<PRISM.Module.Networking.ILiveGuestProfileStatus> updateGuestSubject;
    public System.IObservable<PRISM.Module.Networking.ILiveGuestProfileStatus> OnUpdateGuest { get; set; }
    public Cysharp.Threading.Tasks.UniTask RenderAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Module.Networking.ILiveGuestProfileStatus guest, System.Threading.CancellationToken ct, bool canClickEmptyView);
    private void OnDestroy();

    private class <>c__DisplayClass10_0
    {
        public PRISM.Module.Networking.ILiveGuestProfileStatus guest;
        public PRISM.Interactions.Live.LiveGuestProfileView <>4__this;
        public System.Threading.CancellationToken ct;
        private Cysharp.Threading.Tasks.UniTaskVoid <RenderAsync>b__0(UniRx.Unit _);
        private void <RenderAsync>b__1(UniRx.Unit _);

        private struct <<RenderAsync>b__0>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
        {
            public int <>1__state;
            public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
            public <>c__DisplayClass10_0 <>4__this;
            private Awaiter<FriendState> <>u__1;
            private void MoveNext();
            private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveProduceIdolBonusIconView : UnityEngine.MonoBehaviour
{
    private UnityEngine.GameObject unitBonusEffectObject;
    private PRISM.Interactions.ViewStateChanger attributeBonusEffectStateChanger;
    private PRISM.Interactions.ViewStateChanger unitIconOverlayTypeState;
    private UnityEngine.UI.Image unitIconOverlayImage;
    private UnityEngine.Animator[] iconAnimations;
    private DG.Tweening.Tweener tweener;
    public void Setup(PRISM.Live.LiveIdol idol, PRISM.Live.MusicData musicData);
    private static UnitIconOverlayType _getUnitIconOverlayType(PRISM.Live.LiveIdol idol, PRISM.Live.MusicData musicData);

    private enum UnitIconOverlayType : System.Enum
    {
        public int value__;
        public static UnitIconOverlayType None;
        public static UnitIconOverlayType Solo;
        public static UnitIconOverlayType Other;
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveTextUtility
{
    public string NullText { get; set; }
}

// Namespace: PRISM.Interactions.Live
public class LiveMusicSelectionButtonsView : UnityEngine.MonoBehaviour, PRISM.Adapters.ILiveMusicSelectionButtonsView
{
    private PRISM.Interactions.CountToggleButtonView switchDisplayToggleButton;
    private PRISM.Interactions.ButtonView searchButton;
    private PRISM.Interactions.ViewStateChanger searchButtonState;
    private PRISM.Interactions.ButtonView randomSelectButton;
    private PRISM.Interactions.ButtonView playMvButton;
    private PRISM.Interactions.ButtonView startButton;
    private UnityEngine.GameObject startButtonDisabled;
    private UnityEngine.GameObject startButtonLocked;
    private UnityEngine.UI.RawImage backgroundImage;
    private UnityEngine.UI.RawImage nextBackgroundImage;
    private PRISM.SimpleSlideAnimation slideAnimation;
    private PRISM.Interactions.Live.LiveMusicSelectionEventBannerView eventBannerView;
    private PRISM.AutoCancellationTokenSource canceller;
    public System.IObservable<UniRx.Unit> OnClickSearchButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickRandomSelectButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickPlayMvButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickStartButton { get; set; }
    public System.IObservable<PRISM.Definitions.MstEvent> OnClickEventBanner { get; set; }
    public void UpdateView(PRISM.Live.MusicData musicData, SongDifficultyLevel musicDifficulty, bool isMasterLocked, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void UpdateSearchButtonStatus(bool isFilterOn);
    public void InitializeEventBanner(System.Collections.Generic.IReadOnlyList<PRISM.Definitions.MstEvent> mstEvents, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public Cysharp.Threading.Tasks.UniTask SlideInAsync();
    public void Initialize(UniRx.IReactiveProperty<PRISM.Live.MusicListSwitchDisplayType> listDisplayType);
    private Cysharp.Threading.Tasks.UniTask _changeBackgroundImageAsync(PRISM.Live.MusicData musicData, bool isValidMusic, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private void <_changeBackgroundImageAsync>b__28_0();

    private struct <_changeBackgroundImageAsync>d__28 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Live.LiveMusicSelectionButtonsView <>4__this;
        public bool isValidMusic;
        public PRISM.Live.MusicData musicData;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private System.Threading.CancellationTokenSource <linkedToken>5__2;
        private Awaiter<UnityEngine.Texture2D> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveMusicSelectionCategoryListCell : PRISM.CommonListViewCell<PRISM.Definitions.MstSongType, PRISM.Interactions.Live.LiveMusicSelectionCategoryListContext>
{
    private UnityEngine.UI.RawImage tabIcon;
    private UnityEngine.GameObject spaceLine;
    private PRISM.AutoCancellationTokenSource canceller;
    public void UpdateContent(PRISM.Definitions.MstSongType master);
}

// Namespace: PRISM.Interactions.Live
public class LiveMusicSelectionCategoryListContext : PRISM.CommonListViewContext
{
    private int <ItemCount>k__BackingField;
    public int ItemCount { get; set; }
}

// Namespace: PRISM.Interactions.Live
public class LiveMusicSelectionCategoryListView : PRISM.CommonListView<PRISM.Interactions.Live.LiveMusicSelectionCategoryListCell, PRISM.Definitions.MstSongType, PRISM.Interactions.Live.LiveMusicSelectionCategoryListContext>, PRISM.Adapters.ILiveMusicSelectionCategoryListView
{
    private PRISM.SimpleSlideAnimation slideAnimation;
    public Cysharp.Threading.Tasks.UniTask SlideInAsync();
    public void UpdateContents(System.Collections.Generic.IList<PRISM.Definitions.MstSongType> items);
    public void JumpTo(int index, bool withoutNotify);
    protected void Initialize();
    private System.IObservable<int> PRISM.Adapters.ILiveMusicSelectionCategoryListView.get_OnSelectionChanged();
    private void <Initialize>b__4_0(int index);
}

// Namespace: PRISM.Interactions.Live
public class LiveMusicSelectionConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.LiveMusicSelectionArgument>, PRISM.Adapters.ILiveMusicSelectionConnector
{
    private string howToPlayPopupResourceConfigRefPc;
    protected string GetHowToPlayPopupResourceConfigRef();
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
    protected PRISM.Adapters.LiveMusicSelectionArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
}

// Namespace: PRISM.Interactions.Live
public class LiveMusicSelectionEventBannerView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.UIShifter shifter;
    private PRISM.Interactions.MinimalUIButtonView[] shifterCells;
    private UniRx.Subject<PRISM.Definitions.MstEvent> onClickEventBanner;
    private System.IDisposable disposable;
    public System.IObservable<PRISM.Definitions.MstEvent> OnClickEventBanner { get; set; }
    public void Initialize(System.Collections.Generic.IReadOnlyList<PRISM.Definitions.MstEvent> mstEvents, PRISM.ResourceManagement.IResourceLoader resourceLoader);

    private class <>c__DisplayClass6_0
    {
        public System.Collections.Generic.IReadOnlyList<PRISM.Definitions.MstEvent> mstEvents;
        public PRISM.Interactions.Live.LiveMusicSelectionEventBannerView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        private void <Initialize>b__0(System.ValueTuple<UnityEngine.RectTransform, int> x);
    }

    private class <>c__DisplayClass6_1
    {
        public System.ValueTuple<UnityEngine.RectTransform, int> x;
        public PRISM.Definitions.MstEvent mstEvent;
        public <>c__DisplayClass6_0 CS$<>8__locals1;
        private bool <Initialize>b__1(PRISM.Interactions.MinimalUIButtonView y);
        private void <Initialize>b__2(int _);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveMusicSelectionMusicDetailView : UnityEngine.MonoBehaviour, PRISM.Adapters.ILiveMusicSelectionDetailView
{
    private PRISM.Interactions.ButtonView rewardButton;
    private PRISM.Interactions.ButtonView rankingButton;
    private UnityEngine.GameObject rewardRankingButtonArea;
    private PRISM.Interactions.ButtonView favoriteToggleButton;
    private PRISM.Interactions.ViewStateChanger favoriteButtonState;
    private UnityEngine.GameObject jacketEmptyObject;
    private UnityEngine.UI.RawImage jacketImage;
    private PRISM.Interactions.ButtonView jacketInfoButton;
    private UnityEngine.GameObject _2DMVMark;
    private UnityEngine.GameObject voiceSeparatedMark;
    private UnityEngine.GameObject limitedVocalSeparatedMark;
    private UnityEngine.GameObject focusCameraMark;
    private UnityEngine.GameObject hasLiveCutSceneMark;
    private UnityEngine.GameObject limitedTimeNoticeObject;
    private PRISM.Interactions.Live.MusicDifficultySelector difficultySelector;
    private PRISM.SimpleSlideAnimation slideAnimation;
    private UnityEngine.UI.Image jacketBaseImage;
    private UnityEngine.Sprite musicTypeAllJacketBaseSprite;
    private UnityEngine.Sprite musicTypeExceptAllJacketBaseSprite;
    private PRISM.Live.LiveUIResourceConfig resourceConfig;
    private PRISM.AutoCancellationTokenSource canceller;
    public System.IObservable<UniRx.Unit> OnClickRewardButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickRankingButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickFavoriteButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickJacketInfoButton { get; set; }
    public PRISM.Interactions.Live.MusicDifficultySelector DifficultySelector { get; set; }
    public System.IObservable<SongDifficultyLevel> OnSelectDifficulty { get; set; }
    public void Initialize();
    public void UpdateView(PRISM.Live.MusicData musicData, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void UpdateFavoriteStatus(bool isOn);
    public Cysharp.Threading.Tasks.UniTask SlideInAsync();
    private void OnDestroy();

    private class <>c__DisplayClass34_0
    {
        public PRISM.Live.MusicData musicData;
        private bool <UpdateView>b__0(PRISM.Definitions.MstLiveCutScene x);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveMusicSelectionRateView : UnityEngine.MonoBehaviour, PRISM.Adapters.ILiveMusicSelectionRateView
{
    private PRISM.Interactions.MusicRateView highScoreRateView;
    private PRISM.Interactions.MusicRateView technicalScoreRateView;
    private PRISM.Interactions.ButtonView switchRateViewButton;
    private UnityEngine.UI.Image switchRateViewIcon;
    private UnityEngine.Sprite[] switchRateViewSprites;
    private PRISM.SimpleSlideAnimation slideAnimation;
    public System.IObservable<PRISM.Live.MusicRateType> OnClickRateView { get; set; }
    public System.IObservable<UniRx.Unit> OnSwitchRateView { get; set; }
    public void SetUp(PRISM.Module.Networking.ITotalHighScoreRatingStatus totalHighScoreRating, PRISM.Module.Networking.ITotalTechnicalRatingStatus totalTechnicalRating);
    public Cysharp.Threading.Tasks.UniTask SwitchViewAsync(PRISM.Live.MusicRateType rateType);
    public Cysharp.Threading.Tasks.UniTask SlideInAsync(PRISM.Live.MusicRateType rateType);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<UniRx.Unit, PRISM.Live.MusicRateType> <>9__7_0;
        public static System.Func<UniRx.Unit, PRISM.Live.MusicRateType> <>9__7_1;
        private PRISM.Live.MusicRateType <get_OnClickRateView>b__7_0(UniRx.Unit _);
        private PRISM.Live.MusicRateType <get_OnClickRateView>b__7_1(UniRx.Unit _);
    }

    private struct <SwitchViewAsync>d__11 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Live.LiveMusicSelectionRateView <>4__this;
        public PRISM.Live.MusicRateType rateType;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveMusicSelectionView : UnityEngine.MonoBehaviour, PRISM.Adapters.ILiveMusicSelectionView
{
    private PRISM.Interactions.StaminaView liveBoostView;
    private PRISM.Interactions.Live.LiveMusicSelectionCategoryListView categoryListView;
    private PRISM.Interactions.Live.MusicListCarousel musicListCarousel;
    private PRISM.Interactions.Live.LiveMusicSelectionMusicDetailView musicDetailView;
    private PRISM.Interactions.Live.LiveMusicSelectionButtonsView buttonsView;
    private PRISM.Interactions.Live.LiveMusicSelectionRateView musicRateView;
    private PRISM.Interactions.ViewStateChanger isMasterLockedStateChanger;
    private PRISM.HowToPlayPopupOpener shinyEnabledHowToPlayPopupOpener;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    public PRISM.Adapters.IStaminaView LiveBoostView { get; set; }
    public PRISM.Adapters.ILiveMusicSelectionCategoryListView CategoryList { get; set; }
    public PRISM.Adapters.ILiveMusicSelectionMusicListView MusicList { get; set; }
    public PRISM.Adapters.ILiveMusicSelectionDetailView Detail { get; set; }
    public PRISM.Adapters.ILiveMusicSelectionButtonsView Buttons { get; set; }
    public PRISM.Adapters.ILiveMusicSelectionRateView Rate { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Collections.Generic.IReadOnlyList<PRISM.Definitions.MstEvent> mstEvents, UniRx.IReactiveProperty<PRISM.Live.MusicListSwitchDisplayType> listDisplayType);
    public void SwitchDisplay(PRISM.Live.MusicListSwitchDisplayType type);
    public void SetDifficulty(SongDifficultyLevel difficulty);
    public void SetSelectedMusic(PRISM.Live.MusicData music, SongDifficultyLevel difficulty, bool isMasterLocked, System.Threading.CancellationToken cancellationToken);
    public void Hide();
    public Cysharp.Threading.Tasks.UniTask ShowAsync(PRISM.Live.MusicRateType rateViewType, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask ShowShinyEnabledHowToPlayPopupIfUnreadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <InitializeAsync>b__21_0(UniRx.Unit _);

    private struct <ShowAsync>d__26 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Live.LiveMusicSelectionView <>4__this;
        public System.Threading.CancellationToken ct;
        public PRISM.Live.MusicRateType rateViewType;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Live
public class MusicDifficultySelector : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView[] toggleButtons;
    private UniRx.Subject<SongDifficultyLevel> onSelectDifficulty;
    public System.IObservable<SongDifficultyLevel> OnSelectDifficulty { get; set; }
    public void Initialize();
    public void SelectDifficulty(SongDifficultyLevel difficulty);

    private class <>c__DisplayClass4_0
    {
        public SongDifficultyLevel difficulty;
        public PRISM.Interactions.Live.MusicDifficultySelector <>4__this;
        private void <Initialize>b__0(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.Live
public class MusicListCarousel : PRISM.Carousel<PRISM.Live.MusicData, PRISM.Interactions.Live.MusicListCarouselContext>, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IEndDragHandler, PRISM.Adapters.ILiveMusicSelectionMusicListView
{
    private PRISM.Interactions.Live.MusicListSelectedMusicView selectedMusicView;
    private PRISM.SimpleSlideAnimation slideAnimation;
    private float randomSelectDuration;
    private UnityEngine.GameObject randomSelectBeginEffect;
    private UnityEngine.GameObject[] randomSelectEndEffects;
    public float SlideInDuration { get; set; }
    public void SetListData(System.Collections.Generic.IList<PRISM.Live.MusicData> dataList);
    public Cysharp.Threading.Tasks.UniTask SlideInAsync();
    public void SwitchDisplay(PRISM.Live.MusicListSwitchDisplayType type);
    public void ScrollToRandom();
    public void SetDifficulty(SongDifficultyLevel difficulty);
    public void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
    public void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
    protected void Initialize();
    protected void _playSelectionChangedSE();
    private System.IObservable<int> PRISM.Adapters.ILiveMusicSelectionMusicListView.get_OnSelectionChanged();
    private void PRISM.Adapters.ILiveMusicSelectionMusicListView.JumpTo(int index, bool disableSE, bool forceNotifyChange);
    private void <Initialize>b__14_0(int index);

    private class <>c__DisplayClass10_0
    {
        public System.IDisposable disposable;
        public PRISM.Interactions.Live.MusicListCarousel <>4__this;
        private void <ScrollToRandom>b__0();
    }
}

// Namespace: PRISM.Interactions.Live
public class MusicListCarouselCell : PRISM.CarouselCell<PRISM.Live.MusicData, PRISM.Interactions.Live.MusicListCarouselContext>
{
    private static float BeforeCenter;
    private static float AfterCenter;
    private PRISM.Interactions.Live.MusicListCellCommonView commonView;
    private UnityEngine.CanvasGroup canvasGroup;
    private PRISM.Live.MusicData musicData;
    private UnityEngine.RectTransform cellRectTransform;
    private float halfCellHeight;
    private float halfContentHeight;
    private float awayFromCenterYOffset;
    public void Initialize();
    public void UpdateContent(PRISM.Live.MusicData itemData);
    public void UpdatePosition(float position);
    private void <Initialize>b__9_0(PRISM.Live.MusicListSwitchDisplayType type);
}

// Namespace: PRISM.Interactions.Live
public class MusicListCarouselContext : PRISM.DefaultCarouselContext
{
    private UniRx.ReactiveProperty<PRISM.Live.MusicListSwitchDisplayType> <DisplayType>k__BackingField;
    private SongDifficultyLevel <Difficulty>k__BackingField;
    private float <CellInterval>k__BackingField;
    private float <CenterCellXOffset>k__BackingField;
    private bool <IsListUnderDragging>k__BackingField;
    public UniRx.ReactiveProperty<PRISM.Live.MusicListSwitchDisplayType> DisplayType { get; set; }
    public SongDifficultyLevel Difficulty { get; set; }
    public float CellInterval { get; set; }
    public float CenterCellXOffset { get; set; }
    public bool IsListUnderDragging { get; set; }
}

// Namespace: PRISM.Interactions.Live
public class MusicListCellCommonView : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.RawImage jacketIcon;
    private UnityEngine.UI.RawImage musicTypeIcon;
    private PRISM.Interactions.AttributeIconView attributeIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI musicName;
    private UnityEngine.Color[] attributeColors;
    private ENTERPRISE.UI.UITextMeshProUGUI musicLevel;
    private UnityEngine.Color[] musicLevelColors;
    private UnityEngine.GameObject favoriteMark;
    private UnityEngine.GameObject newMark;
    private PRISM.Interactions.ViewStateChanger viewStateChanger;
    private ENTERPRISE.UI.UITextMeshProUGUI limitedTimeText;
    private UnityEngine.GameObject difficultyBasedInfoArea;
    private UnityEngine.GameObject mvOnlyNotice;
    private PRISM.Live.MusicClearStatusLampView clearStatusLampView;
    private UnityEngine.UI.Image scoreRankImage;
    private UnityEngine.GameObject noScoreRankObject;
    private UnityEngine.UI.Image comboRankImage;
    private UnityEngine.GameObject noComboRankObject;
    private PRISM.Live.LiveUIResourceConfig resourceConfig;
    private ENTERPRISE.UI.UITextMeshProUGUI combo;
    private ENTERPRISE.UI.UITextMeshProUGUI totalNotes;
    private ENTERPRISE.UI.UITextMeshProUGUI highScore;
    private ENTERPRISE.UI.UITextMeshProUGUI highScoreRate;
    private ENTERPRISE.UI.UITextMeshProUGUI technicalScore;
    private ENTERPRISE.UI.UITextMeshProUGUI technicalScoreRate;
    private UnityEngine.Color normalColor;
    private UnityEngine.Color maxColor;
    private UnityEngine.Color shinyColor;
    private ENTERPRISE.UI.UITextMeshProUGUI playCount;
    private PRISM.Live.MusicData cachedMusicData;
    private System.Threading.CancellationTokenSource cts;
    public void UpdateData(PRISM.Live.MusicData musicData, SongDifficultyLevel musicDifficulty, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void UpdateFavoriteStatus(bool isOn);
    public void SwitchDisplay(PRISM.Live.MusicListSwitchDisplayType type);
    public void SwitchDifficultyBasedInfo(SongDifficultyLevel difficulty);
    private void OnDestroy();
}

// Namespace: PRISM.Interactions.Live
public class MusicListSelectedMusicView : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI artistName;
    private PRISM.Interactions.Live.MusicListCellCommonView commonView;
    public PRISM.Interactions.Live.MusicListCellCommonView CommonView { get; set; }
    public void UpdateData(PRISM.Live.MusicData musicData, SongDifficultyLevel musicDifficulty, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Interactions.Live
public class MusicSpectrumVisualizer : UnityEngine.MonoBehaviour
{
    private static string SpectrumBusName;
    private static float LevelOffset;
    private UnityEngine.RectTransform[] bars;
    private CriWare.CriAtomExOutputAnalyzer analyzer;
    private float[] linearSpectrumLevels;
    private float[] logSpectrumLevels;
    private float maxLevel;
    private float maxBarSize;
    private void Start();
    private void Update();
    private void OnDestroy();
    private static bool _splitBandsOnLogScale(float[]& iLinearLvs, float[]& oLogLvs);
}

// Namespace: PRISM.Interactions.Live
public class LiveMvIdolListCell : PRISM.Interactions.ListViewCell<PRISM.Adapters.LiveMvIdolListViewModel, PRISM.Interactions.Live.LiveMvIdolListContext>
{
    private UnityEngine.UI.RawImage unitIcon;
    private PRISM.Interactions.Live.LiveMvIdolListIdolView[] idolViews;
    private UnityEngine.GameObject spaceLine;
    private PRISM.AutoCancellationTokenSource canceller;
    public void UpdateContent(PRISM.Adapters.LiveMvIdolListViewModel data);
    private void OnDestroy();
}

// Namespace: PRISM.Interactions.Live
public class LiveMvIdolListIdolView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.CharacterBaseIconView iconView;
    private PRISM.Interactions.ViewStateChanger isOwnedStateChanger;
    private PRISM.Interactions.ButtonView button;
    private UnityEngine.GameObject beingSetLabel;
    private UnityEngine.GameObject inSameUnitLabel;
    private UnityEngine.GameObject limitedVocalSeparateLabel;
    private UnityEngine.GameObject selectedFrame;
    private System.Collections.Generic.List<UnityEngine.GameObject> activeLabels;
    public void Setup(PRISM.Interactions.Live.LiveMvIdolListContext context, PRISM.Adapters.LiveMvIdolListIdolViewModel viewModel, System.Threading.CancellationToken ct);

    private class <>c__DisplayClass8_0
    {
        public PRISM.Adapters.LiveMvIdolListIdolViewModel viewModel;
        public PRISM.Interactions.Live.LiveMvIdolListContext context;
        public PRISM.Interactions.Live.LiveMvIdolListIdolView <>4__this;
        private void <Setup>b__0(UniRx.Unit _);
        private void <Setup>b__1(PRISM.Live.ILiveMVIdol idol);
        private void <Setup>b__3(long count);
        private void <Setup>g__ToggleLabel|2(UnityEngine.GameObject target);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveMvIdolListView : PRISM.Interactions.ListView<PRISM.Interactions.Live.LiveMvIdolListCell, PRISM.Adapters.LiveMvIdolListViewModel, PRISM.Interactions.Live.LiveMvIdolListContext>
{
    public void Initialize(PRISM.ResourceManagement.IResourceLoader resourceLoader, UniRx.IReactiveProperty<PRISM.Live.ILiveMVIdol> selectedIdol);
    public void UpdateContents(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.LiveMvIdolListViewModel> items);
}

// Namespace: PRISM.Interactions.Live
public class LiveMvIdolListContext : PRISM.Interactions.ListViewContext
{
    private UniRx.IReactiveProperty<PRISM.Live.ILiveMVIdol> <SelectedIdol>k__BackingField;
    private int <ItemCount>k__BackingField;
    public UniRx.IReactiveProperty<PRISM.Live.ILiveMVIdol> SelectedIdol { get; set; }
    public int ItemCount { get; set; }
}

// Namespace: PRISM.Interactions.Live
public class LiveMvUnitMemberChangeConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.LiveMvUnitMemberChangeArgument>, PRISM.Adapters.ILiveMvUnitMemberChangeConnector
{
    private PRISM.Live.MusicData musicData;
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
    protected PRISM.Adapters.LiveMvUnitMemberChangeArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
}

// Namespace: PRISM.Interactions.Live
public class LiveMvUnitMemberChangeView : UnityEngine.MonoBehaviour, PRISM.Adapters.ILiveMvUnitMemberChangeView
{
    private UnityEngine.UI.RawImage backgroundImage;
    private PRISM.Interactions.MusicBasicInfoView musicBasicInfoView;
    private PRISM.Interactions.ViewStateChanger positionMarkStateChanger;
    private PRISM.Interactions.CharacterBaseIconView beforeIconView;
    private PRISM.Interactions.CharacterBaseIconView afterIconView;
    private PRISM.Interactions.Live.LiveMvIdolListView idolListView;
    private PRISM.Interactions.ButtonView decideButton;
    private PRISM.AutoCancellationTokenSource canceller;
    public System.IObservable<UniRx.Unit> OnDecide { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Adapters.LiveMvUnitMemberChangeViewModel viewModel, System.Threading.CancellationToken ct);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Live.ILiveMVIdol, bool> <>9__10_0;
        private bool <InitializeAsync>b__10_0(PRISM.Live.ILiveMVIdol x);
    }

    private class <>c__DisplayClass10_0
    {
        public PRISM.Interactions.Live.LiveMvUnitMemberChangeView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private void <InitializeAsync>b__1(PRISM.Live.ILiveMVIdol idol);
    }

    private struct <InitializeAsync>d__10 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Live.LiveMvUnitMemberChangeView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public PRISM.Adapters.LiveMvUnitMemberChangeViewModel viewModel;
        public System.Threading.CancellationToken ct;
        private <>c__DisplayClass10_0 <>8__1;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveGuestSelectionGridView : PRISM.Interactions.SelectableGridView<PRISM.Interactions.Live.LiveGuestSelectionGridViewCell, PRISM.Adapters.LiveGuestSelectionGridCellViewModel>
{
    private PRISM.UIAnimation reloadAnimation;
    protected void SetupCellTemplate();
    public void PlayReloadAnimation();

    private class CellGroup : DefaultCellGroup<PRISM.Adapters.LiveGuestSelectionGridCellViewModel, PRISM.Interactions.SelectableGridViewContext<PRISM.Adapters.LiveGuestSelectionGridCellViewModel>>
    {
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveGuestSelectionGridViewCell : PRISM.Interactions.SelectableGridViewCell<PRISM.Adapters.LiveGuestSelectionGridCellViewModel>
{
    private PRISM.Interactions.Live.LiveGuestProfileView profileView;
    private ENTERPRISE.UI.UITextMeshProUGUI centerEffectNameText;
    private ENTERPRISE.UI.UITextMeshProUGUI centerEffectDetailText;
    private PRISM.AutoCancellationTokenSource canceller;
    public void UpdateContent(PRISM.Adapters.LiveGuestSelectionGridCellViewModel itemData);
}

// Namespace: PRISM.Interactions.Live
public class LiveGuestSelectionOverlayView : PRISM.Interactions.OverlayViewWithOkCancelButton<System.ValueTuple<string, int>>, PRISM.Adapters.ILiveGuestSelectionOverlayView, PRISM.Adapters.IClosableOverlayView<System.ValueTuple<string, int>>, PRISM.Adapters.IOverlayView, PRISM.Adapters.IClosable<System.ValueTuple<string, int>>
{
    private PRISM.Interactions.Live.LiveGuestSelectionGridView grid;
    private PRISM.Interactions.FilterOnlyView filterView;
    private UnityEngine.Animator reloadAnimator;
    private PRISM.Interactions.LiveParameterBeforeAfterView unitTotalParameterText;
    private PRISM.Interactions.LiveMusicTypeAndAttributeView attributeView;
    private PRISM.Interactions.ButtonView reloadButton;
    private PRISM.Adapters.LiveGuestSelectionOverlayViewModel model;
    public PRISM.Adapters.ISortFilterView SortFilterView { get; set; }
    public System.IObservable<UniRx.Unit> OnPushReload { get; set; }
    public void Initialize(PRISM.Adapters.LiveGuestSelectionOverlayViewModel model, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask PlayBeginReloadAnimationAsync();
    public Cysharp.Threading.Tasks.UniTask PlayFinishReloadAnimationAsync();
    protected System.ValueTuple<string, int> _createReturnValue(bool isOk);

    private class <>c__DisplayClass11_0
    {
        public PRISM.Interactions.Live.LiveGuestSelectionOverlayView <>4__this;
        public PRISM.Adapters.LiveGuestSelectionOverlayViewModel model;
        private void <Initialize>b__0(PRISM.Adapters.LiveGuestSelectionGridCellViewModel selectedGuest);
        private Cysharp.Threading.Tasks.UniTaskVoid <Initialize>b__1(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.LiveGuestSelectionGridCellViewModel> data);

        private struct <<Initialize>b__1>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
        {
            public int <>1__state;
            public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
            public <>c__DisplayClass11_0 <>4__this;
            public System.Collections.Generic.IReadOnlyList<PRISM.Adapters.LiveGuestSelectionGridCellViewModel> data;
            private Awaiter <>u__1;
            private void MoveNext();
            private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }

    private struct <PlayFinishReloadAnimationAsync>d__13 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Live.LiveGuestSelectionOverlayView <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveMVOverlayView : UnityEngine.MonoBehaviour, PRISM.Adapters.Live.ILiveMVOverlayView, PRISM.Adapters.IClosableOverlayView<UniRx.Unit>, PRISM.Adapters.IOverlayView, PRISM.Adapters.IClosable<UniRx.Unit>, PRISM.Interactions.IDisableBackgroundBlur
{
    private int setTimeDelayFrame;
    private Cysharp.Threading.Tasks.PlayerLoopTiming setTimeDelayTiming;
    private float backgroundBlockerFadeDuration;
    private int seekWaitMilliSeconds;
    private UnityEngine.UI.Image backgroundBlocker;
    private PRISM.Interactions.ButtonView pauseButton;
    private UnityEngine.UI.Image pauseIcon;
    private UnityEngine.GameObject pauseMenu;
    private PRISM.Interactions.ButtonView showPauseMenuButton;
    private PRISM.Interactions.ButtonView hidePauseMenuButton;
    private PRISM.Interactions.ButtonView resumeButton;
    private UnityEngine.UI.Image resumeIcon;
    private PRISM.Interactions.ButtonView forwardButton;
    private PRISM.Interactions.ButtonView backwardButton;
    private PRISM.Live.LiveMVSeekBar seekBar;
    private PRISM.Interactions.ButtonView skipButton;
    private PRISM.Interactions.ButtonView retryButton;
    private PRISM.Interactions.ToggleButtonView lyricsToggle;
    private ENTERPRISE.UI.UITextMeshProUGUI lyricsText;
    private PRISM.Interactions.ButtonView shareButton;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private DG.Tweening.Sequence sequence;
    private float keepRenderScale;
    private UnityEngine.Rendering.Universal.UpscalingFilterSelection keepUpscalingFilter;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public int SetTimeDelayFrame { get; set; }
    public Cysharp.Threading.Tasks.PlayerLoopTiming SetTimeDelayTiming { get; set; }
    public int SeekWaitMilliSeconds { get; set; }
    public System.IObservable<UniRx.Unit> OnClickPauseButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickResumeButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickForwardButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickBackwardButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickSkipButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickRetryButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickShareButton { get; set; }
    public System.IObservable<bool> OnApplicationFocus { get; set; }
    public System.IObservable<UniRx.Unit> OnClickBackKey { get; set; }
    public PRISM.Live.LiveMVSeekBar SeekBar { get; set; }
    private Cysharp.Threading.Tasks.UniTask PRISM.Adapters.IOverlayView.ShowAsync(System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask PRISM.Adapters.IOverlayView.HideAsync();
    public void Finish();
    public Cysharp.Threading.Tasks.UniTask Initialize3DMVAsync(bool isPortrait, bool hasLyric, UniRx.IReactiveProperty<bool> isLyricsOn);
    public Cysharp.Threading.Tasks.UniTask Initialize2DMVAsync(bool isPortrait);
    public Cysharp.Threading.Tasks.UniTask HideBackgroundBlockerAsync();
    public Cysharp.Threading.Tasks.UniTask PauseAsync(float time, PRISM.IPausable mvPauser);
    public void Resume();
    public System.IDisposable CreateHidePauseMenuScope();
    public void UpdateLyrics(string text);
    public void EndPauseMenu();
    private Cysharp.Threading.Tasks.UniTask _initializeCommonAsync(bool isPortrait);
    private void _togglePauseMenuActive(bool active);
    private void _playIconAnimation(UnityEngine.UI.Image icon);
    private void _saveRenderScaleSettings();
    public void ApplyKeepRenderScaleSettings();
    private void <CreateHidePauseMenuScope>b__60_0();
    private void <_initializeCommonAsync>b__63_0(UniRx.Unit _);
    private void <_initializeCommonAsync>b__63_1(UniRx.Unit _);

    private struct <HideBackgroundBlockerAsync>d__57 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Live.LiveMVOverlayView <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <PauseAsync>d__58 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Live.LiveMVOverlayView <>4__this;
        public float time;
        public PRISM.IPausable mvPauser;
        private Awaiter <>u__1;
        private Awaiter <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Live
public class RatingGradeUpOverlayView : UnityEngine.MonoBehaviour, PRISM.Adapters.IRatingGradeUpOverlayView, PRISM.Adapters.IClosableOverlayView<UniRx.Unit>, PRISM.Adapters.IOverlayView, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.SerializableNestedArray<UnityEngine.GameObject>[] rateTypeObjects;
    private PRISM.Interactions.MusicRateView[] beforeViews;
    private PRISM.Interactions.MusicRateView[] afterViews;
    private PRISM.Interactions.MusicRateGradients gradients;
    private PRISM.UIGradient beforeBackground;
    private PRISM.UIGradient afterBackground;
    private TMPro.TextMeshProUGUI rateText;
    private PRISM.Legacy.ParamRememberableAnimator animator;
    private PRISM.Legacy.ParamRememberableAnimator[] beforeStarAnimators;
    private PRISM.Legacy.ParamRememberableAnimator[] afterStarAnimators;
    private UnityEngine.GameObject[] afterStarEffects;
    private PRISM.Legacy.ParamRememberableAnimator[] rateTriggerAnimators;
    private PRISM.Interactions.ButtonView button;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(PRISM.Adapters.MusicRateViewModel before, PRISM.Adapters.MusicRateViewModel after, System.Action onFinishAnimation);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    private void _onSkip(PRISM.Adapters.MusicRateViewModel before, PRISM.Adapters.MusicRateViewModel after);
    private Cysharp.Threading.Tasks.UniTask _animateAsync(PRISM.Adapters.MusicRateViewModel before, PRISM.Adapters.MusicRateViewModel after, System.Threading.CancellationToken cancellationToken);
    private void _setStarOnCount(PRISM.Legacy.ParamRememberableAnimator[] stars, int length);

    private class <>c
    {
        public static <>c <>9;
        public static System.Action<string> <>9__19_0;
        private void <_animateAsync>b__19_0(string cueName);
    }

    private class <>c__DisplayClass16_0
    {
        public System.Threading.CancellationTokenSource skipCts;
        private void <ShowAsync>b__0(UniRx.Unit _);
    }

    private class <>c__DisplayClass19_0
    {
        public PRISM.Interactions.Live.RatingGradeUpOverlayView <>4__this;
        public PRISM.Adapters.MusicRateViewModel before;
        public PRISM.Adapters.MusicRateViewModel after;
        public string format;
        public System.Threading.CancellationToken cancellationToken;
        private void <_animateAsync>b__1(float t);
        private Cysharp.Threading.Tasks.UniTask <_animateAsync>g__StampStarsAsync|2(PRISM.Legacy.ParamRememberableAnimator[] stars, int start, int end);

        private struct <<_animateAsync>g__StampStarsAsync|2>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
        {
            public int <>1__state;
            public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
            public int start;
            public PRISM.Legacy.ParamRememberableAnimator[] stars;
            public <>c__DisplayClass19_0 <>4__this;
            public int end;
            private int <i>5__2;
            private Awaiter <>u__1;
            private void MoveNext();
            private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }

    private struct <ShowAsync>d__16 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Live.RatingGradeUpOverlayView <>4__this;
        public PRISM.Adapters.MusicRateViewModel before;
        public PRISM.Adapters.MusicRateViewModel after;
        public System.Action onFinishAnimation;
        private <>c__DisplayClass16_0 <>8__1;
        private Awaiter <>u__1;
        private Awaiter<UniRx.Unit> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_animateAsync>d__19 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Live.RatingGradeUpOverlayView <>4__this;
        public PRISM.Adapters.MusicRateViewModel before;
        public PRISM.Adapters.MusicRateViewModel after;
        public System.Threading.CancellationToken cancellationToken;
        private <>c__DisplayClass19_0 <>8__1;
        private bool <isGradeUp>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveIdolFavoriteMarkView : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.RawImage favoriteMarkImage;
    public void SetFavoriteMark(int mstFavoriteMarkId, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken cancellationToken);
}

// Namespace: PRISM.Interactions.Live
public class LiveSupportCharacterView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.SupportCharacterIconView idolIconView;
    private PRISM.Interactions.ButtonView iconButton;
    private PRISM.Interactions.ViewStateChanger displayModeStateChanger;
    private UnityEngine.GameObject baseParameterObject;
    private PRISM.UI.DiamondDisplay diamondDisplay;
    private ENTERPRISE.UI.UITextMeshProUGUI levelText;
    private PRISM.Interactions.Live.LiveSupportParameterContent supportParameterContent;
    private ENTERPRISE.UI.UITextMeshProUGUI totalText;
    private ENTERPRISE.UI.UITextMeshProUGUI supportEffectText;
    private PRISM.Interactions.Live.LiveIdolFavoriteMarkView favoriteMarkView;
    private PRISM.AutoCancellationTokenSource canceller;
    public void Show(PRISM.Live.LiveSupportCharacterViewModel itemData, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public void ChangeParameterTextColor(LiveUnitSupportMemberType parameterType, UnityEngine.Color color);
    public void ChangeDisplayMode(PRISM.Live.LiveSupportSelectionDisplayMode mode);

    private class <>c__DisplayClass11_0
    {
        public PRISM.Interactions.Live.LiveSupportCharacterView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        public PRISM.Live.LiveSupportCharacterViewModel itemData;
        private void <Show>b__0(int id);
        private void <Show>b__1(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveSupportParameterContent : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI vocalText;
    private ENTERPRISE.UI.UITextMeshProUGUI danceText;
    private ENTERPRISE.UI.UITextMeshProUGUI visualText;
    private ENTERPRISE.UI.UITextMeshProUGUI mentalText;
    public void Show(PRISM.Definitions.IdolParameter parameter);
    public void ShowNullText();
    public void SetTextColor(LiveUnitSupportMemberType parameterType, UnityEngine.Color color);
}

// Namespace: PRISM.Interactions.Live
public class LiveSupportParameterTypeBalloonView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ViewStateChanger parameterTypeBalloon;
    private ENTERPRISE.UI.UITextMeshProUGUI[] texts;
    public void Show(LiveUnitSupportMemberType parameterType);
}

// Namespace: PRISM.Interactions.Live
public class LiveSupportSelectionGridView : PRISM.Interactions.SelectableGridView<PRISM.Interactions.Live.LiveSupportSelectionGridViewCell, PRISM.Adapters.LiveSupportSelectionGridCellViewModel, PRISM.Interactions.Live.LiveSupportSelectionGridViewContext>
{
    public void SetDisplayMode(UniRx.ReactiveProperty<PRISM.Live.LiveSupportSelectionDisplayMode> displayMode);
    public void SetSupportMemberType(LiveUnitSupportMemberType memberType);
    protected void SetupCellTemplate();

    private class CellGroup : DefaultCellGroup<PRISM.Adapters.LiveSupportSelectionGridCellViewModel, PRISM.Interactions.Live.LiveSupportSelectionGridViewContext>
    {
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveSupportSelectionGridViewContext : PRISM.Interactions.SelectableGridViewContext<PRISM.Adapters.LiveSupportSelectionGridCellViewModel>
{
    private UniRx.IReadOnlyReactiveProperty<PRISM.Live.LiveSupportSelectionDisplayMode> <DisplayMode>k__BackingField;
    private LiveUnitSupportMemberType <CurrentSupportMemberType>k__BackingField;
    public UniRx.IReadOnlyReactiveProperty<PRISM.Live.LiveSupportSelectionDisplayMode> DisplayMode { get; set; }
    public LiveUnitSupportMemberType CurrentSupportMemberType { get; set; }
}

// Namespace: PRISM.Interactions.Live
public class LiveSupportSelectionGridViewCell : PRISM.Interactions.SelectableGridViewCell<PRISM.Adapters.LiveSupportSelectionGridCellViewModel, PRISM.Interactions.Live.LiveSupportSelectionGridViewContext>
{
    protected PRISM.Interactions.Live.LiveSupportCharacterView characterView;
    private PRISM.Interactions.ViewStateChanger usedBadge;
    private PRISM.AutoCancellationTokenSource canceller;
    public void Initialize();
    public void UpdateContent(PRISM.Adapters.LiveSupportSelectionGridCellViewModel itemData);
    private void <Initialize>b__3_0(PRISM.Live.LiveSupportSelectionDisplayMode mode);
}

// Namespace: PRISM.Interactions.Live
public class LiveSupportSelectionOverlayView : PRISM.Interactions.OverlayViewWithOkCancelButton<int>, PRISM.Adapters.ILiveSupportSelectionOverlayView, PRISM.Adapters.IClosableOverlayView<int>, PRISM.Adapters.IOverlayView, PRISM.Adapters.IClosable<int>
{
    private PRISM.Interactions.Live.LiveSupportSelectionGridView grid;
    private PRISM.Interactions.SortFilterView sortFilterView;
    private PRISM.Interactions.LiveMusicTypeAndAttributeView attributeView;
    private PRISM.Interactions.Live.LiveSupportParameterTypeBalloonView parameterTypeBalloon;
    private PRISM.Interactions.Live.LiveSupportCharacterView currentSelectedView;
    private PRISM.Interactions.Live.LiveSupportParameterContent currentSelectedParameterContent;
    private ENTERPRISE.UI.UITextMeshProUGUI supportLevelText;
    private ENTERPRISE.UI.UITextMeshProUGUI supportEffectNameText;
    private ENTERPRISE.UI.UITextMeshProUGUI supportEffectDescriptionText;
    private PRISM.Interactions.ButtonView goToUpgradeButton;
    private PRISM.Interactions.LiveParameterBeforeAfterView supportBonusView;
    private PRISM.Interactions.CountToggleButtonView switchDisplayModeButton;
    private PRISM.Adapters.LiveSupportSelectionOverlayViewModel model;
    private PRISM.AutoCancellationTokenSource canceller;
    public PRISM.Adapters.ISortFilterView SortFilterView { get; set; }
    public System.IObservable<UniRx.Unit> OnGoToUpgrade { get; set; }
    public void Initialize(PRISM.Adapters.LiveSupportSelectionOverlayViewModel model, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken cancellationToken);
    protected int _createReturnValue(bool isOk);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Adapters.LiveSupportSelectionGridCellViewModel, int, bool> <>9__18_2;
        private bool <Initialize>b__18_2(PRISM.Adapters.LiveSupportSelectionGridCellViewModel support, int id);
    }

    private class <>c__DisplayClass18_0
    {
        public System.Threading.CancellationToken cancellationToken;
        public PRISM.Interactions.Live.LiveSupportSelectionOverlayView <>4__this;
        public PRISM.Adapters.LiveSupportSelectionOverlayViewModel model;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private Cysharp.Threading.Tasks.UniTaskVoid <Initialize>b__0(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.LiveSupportSelectionGridCellViewModel> data);
        private void <Initialize>b__1(PRISM.Adapters.LiveSupportSelectionGridCellViewModel _);

        private struct <<Initialize>b__0>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
        {
            public int <>1__state;
            public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
            public <>c__DisplayClass18_0 <>4__this;
            public System.Collections.Generic.IReadOnlyList<PRISM.Adapters.LiveSupportSelectionGridCellViewModel> data;
            private Awaiter <>u__1;
            private void MoveNext();
            private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveUnitMemberChangeGridCell : PRISM.Interactions.SelectableGridViewCell<PRISM.Adapters.LiveUnitMemberChangeIdolViewModel, PRISM.Interactions.Live.LiveUnitMemberChangeGridViewContext>
{
    private PRISM.Interactions.Live.LiveUnitMemberChangeIdolView commonView;
    private PRISM.Interactions.ViewStateChanger statusDisplayTypeState;
    private ENTERPRISE.UI.UITextMeshProUGUI levelText;
    private PRISM.Interactions.ViewStateChanger levelMaxState;
    private PRISM.Interactions.ViewStateChanger levelLimitState;
    private ENTERPRISE.UI.UITextMeshProUGUI skillText;
    private ENTERPRISE.UI.UITextMeshProUGUI idolBaseLevelText;
    private UnityEngine.UI.Image idolBaseLevelGauge;
    private ENTERPRISE.UI.UITextMeshProUGUI dearnessText;
    private UnityEngine.UI.Image dearnessGauge;
    private ENTERPRISE.UI.UITextMeshProUGUI fanText;
    private PRISM.Interactions.ViewStateChanger positionTypeState;
    public void Initialize();
    public void UpdateContent(PRISM.Adapters.LiveUnitMemberChangeIdolViewModel itemData);
    private void <Initialize>b__12_0(PRISM.Adapters.LiveUnitMemberChangeStatusDisplayType type);
}

// Namespace: PRISM.Interactions.Live
public class LiveUnitMemberChangeGridView : PRISM.Interactions.SelectableGridView<PRISM.Interactions.Live.LiveUnitMemberChangeGridCell, PRISM.Adapters.LiveUnitMemberChangeIdolViewModel, PRISM.Interactions.Live.LiveUnitMemberChangeGridViewContext>
{
    protected void SetupCellTemplate();
    public void Initialize(UniRx.IReadOnlyReactiveProperty<PRISM.Adapters.LiveUnitMemberChangeStatusDisplayType> statusDisplayType, PRISM.Live.MusicData musicData);

    private class CellGroup : DefaultCellGroup<PRISM.Adapters.LiveUnitMemberChangeIdolViewModel, PRISM.Interactions.Live.LiveUnitMemberChangeGridViewContext>
    {
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveUnitMemberChangeGridViewContext : PRISM.Interactions.SelectableGridViewContext<PRISM.Adapters.LiveUnitMemberChangeIdolViewModel>
{
    private UniRx.IReadOnlyReactiveProperty<PRISM.Adapters.LiveUnitMemberChangeStatusDisplayType> <StatusDisplayType>k__BackingField;
    private PRISM.Live.MusicData <MusicData>k__BackingField;
    public UniRx.IReadOnlyReactiveProperty<PRISM.Adapters.LiveUnitMemberChangeStatusDisplayType> StatusDisplayType { get; set; }
    public PRISM.Live.MusicData MusicData { get; set; }
}

// Namespace: PRISM.Interactions.Live
public class LiveUnitMemberChangeIdolView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ProduceIdolIconView iconView;
    private PRISM.Interactions.Live.LiveProduceIdolBonusIconView bonusIconView;
    private PRISM.Interactions.ButtonView button;
    private PRISM.Interactions.Live.LiveIdolFavoriteMarkView favoriteMarkView;
    private ENTERPRISE.UI.UITextMeshProUGUI totalText;
    private ENTERPRISE.UI.UITextMeshProUGUI vocalText;
    private ENTERPRISE.UI.UITextMeshProUGUI danceText;
    private ENTERPRISE.UI.UITextMeshProUGUI visualText;
    private ENTERPRISE.UI.UITextMeshProUGUI mentalText;
    private ENTERPRISE.UI.UITextMeshProUGUI centerEffectText;
    private PRISM.AutoCancellationTokenSource canceller;
    public void UpdateView(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Live.LiveIdol idol, PRISM.Live.MusicData musicData, UniRx.IReactiveProperty<int> favoriteMarkId);
    private void OnDestroy();

    private class <>c__DisplayClass11_0
    {
        public PRISM.Live.LiveIdol idol;
        public UniRx.IReactiveProperty<int> favoriteMarkId;
        public System.Threading.CancellationToken ct;
        public PRISM.Interactions.Live.LiveUnitMemberChangeIdolView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Action<int> <>9__2;
        private Cysharp.Threading.Tasks.UniTaskVoid <UpdateView>b__0(UniRx.Unit _);
        private void <UpdateView>b__2(int id);
        private void <UpdateView>b__1(int id);

        private struct <<UpdateView>b__0>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
        {
            public int <>1__state;
            public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
            public <>c__DisplayClass11_0 <>4__this;
            private Awaiter <>u__1;
            private void MoveNext();
            private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveUnitMemberChangeOverlayView : PRISM.Interactions.OverlayViewWithOkCancelButton, PRISM.Adapters.ILiveUnitMemberChangeOverlayView, PRISM.Adapters.IClosableOverlayView<bool>, PRISM.Adapters.IOverlayView, PRISM.Adapters.IClosable<bool>
{
    private PRISM.Interactions.Live.LiveUnitMemberChangeGridView idolGridView;
    private PRISM.Interactions.SortFilterView sortFilterView;
    private PRISM.Interactions.Live.LiveUnitMemberChangeSelectedIdolView selectedIdolView;
    private PRISM.Interactions.LiveParameterBeforeAfterView unitTotalParameterView;
    private PRISM.Interactions.ButtonView goToUpgradeButton;
    private PRISM.Interactions.CountToggleButtonView changeDisplayTypeButton;
    private PRISM.Interactions.LiveMusicTypeAndAttributeView attributeView;
    public PRISM.Adapters.ISortFilterView SortFilterView { get; set; }
    public System.IObservable<UniRx.Unit> OnGoToUpgrade { get; set; }
    public void Initialize(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Adapters.LiveUnitMemberChangeViewModel viewModel);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Adapters.LiveUnitMemberChangeIdolViewModel, int, bool> <>9__11_2;
        private bool <Initialize>b__11_2(PRISM.Adapters.LiveUnitMemberChangeIdolViewModel idol, int id);
    }

    private class <>c__DisplayClass11_0
    {
        public PRISM.Interactions.Live.LiveUnitMemberChangeOverlayView <>4__this;
        public PRISM.Adapters.LiveUnitMemberChangeViewModel viewModel;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private Cysharp.Threading.Tasks.UniTaskVoid <Initialize>b__0(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.LiveUnitMemberChangeIdolViewModel> idols);
        private void <Initialize>b__1(PRISM.Adapters.LiveUnitMemberChangeIdolViewModel data);

        private struct <<Initialize>b__0>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
        {
            public int <>1__state;
            public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
            public <>c__DisplayClass11_0 <>4__this;
            public System.Collections.Generic.IReadOnlyList<PRISM.Adapters.LiveUnitMemberChangeIdolViewModel> idols;
            private Awaiter <>u__1;
            private void MoveNext();
            private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveUnitMemberChangeSelectedIdolView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.Live.LiveUnitMemberChangeIdolView commonView;
    private PRISM.Interactions.ViewStateChanger isCenterStateChanger;
    private ENTERPRISE.UI.UITextMeshProUGUI levelText;
    private PRISM.Interactions.ViewStateChanger levelMaxState;
    private PRISM.Interactions.ViewStateChanger levelLimitState;
    private ENTERPRISE.UI.UITextMeshProUGUI skillTitleText;
    private ENTERPRISE.UI.UITextMeshProUGUI skillLevelText;
    private ENTERPRISE.UI.UITextMeshProUGUI skillDescriptionText;
    private PRISM.Interactions.ToggleButtonView expandSkillToggle;
    private ENTERPRISE.UI.UITextMeshProUGUI centerEffectDescriptionText;
    private PRISM.Interactions.ToggleButtonView expandCenterEffectToggle;
    public void Initialize(bool isCenter);
    public void UpdateView(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Live.LiveIdol idol, PRISM.Live.MusicData musicData, UniRx.IReactiveProperty<int> favoriteMarkId);
}

// Namespace: PRISM.Interactions.Live
public class LiveMvUnitCopyConfirmationPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.ILiveMvUnitCopyConfirmationPopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private PRISM.Interactions.Live.LiveMvUnitCopyConfirmationUnitView unitOneView;
    private PRISM.Interactions.Live.LiveMvUnitCopyConfirmationUnitView unitTwoView;
    private ENTERPRISE.UI.UITextMeshProUGUI messageText;
    private PRISM.Interactions.ViewStateChanger copyFunctionArrow;
    private ENTERPRISE.UI.UITextMeshProUGUI copyFunctionText;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Initialize(PRISM.Live.ILiveUnit unitFrom, PRISM.Live.ILiveUnit unitTo, bool isReverse, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__9_0();
    private void <CreateFrameParameter>b__9_1();
    private void <CreateFrameParameter>b__9_2();
}

// Namespace: PRISM.Interactions.Live
public class LiveMvUnitCopyConfirmationUnitView : UnityEngine.MonoBehaviour
{
    protected ENTERPRISE.UI.UITextMeshProUGUI unitNumber;
    protected ENTERPRISE.UI.UITextMeshProUGUI unitName;
    protected PRISM.Interactions.Live.LiveMvUnitListCellView cellView;
    public void UpdateContent(PRISM.Live.ILiveUnit unit, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
}

// Namespace: PRISM.Interactions.Live
public class LiveSettingItemViewFloatSelector : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI text;
    private PRISM.Interactions.ButtonView[] addButtons;
    private PRISM.Interactions.ButtonView[] subButtons;
    private string format;
    private float[] steps;
    private float min;
    private float max;
    private float value;
    public void Initialize(System.Action<float> onChange);
    public void SetValueWithoutNotify(float value);

    private class <>c__DisplayClass8_0
    {
        public PRISM.Interactions.Live.LiveSettingItemViewFloatSelector <>4__this;
        public System.Action<float> onChange;
        private System.IObservable<float> <Initialize>b__0(PRISM.Interactions.ButtonView x, int i);
        private System.IObservable<float> <Initialize>b__1(PRISM.Interactions.ButtonView x, int i);
        private void <Initialize>b__2(float diff);
    }

    private class <>c__DisplayClass8_1
    {
        public int i;
        public <>c__DisplayClass8_0 CS$<>8__locals1;
        private float <Initialize>b__3(UniRx.Unit _);
    }

    private class <>c__DisplayClass8_2
    {
        public int i;
        public <>c__DisplayClass8_0 CS$<>8__locals2;
        private float <Initialize>b__4(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveSettingItemViewIndexSelector : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI text;
    private PRISM.Interactions.ButtonView addButton;
    private PRISM.Interactions.ButtonView subButton;
    private int count;
    private int value;
    public void Initialize(int count, System.Action<int> onChange);
    public void SetValueWithoutNotify(int value);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<UniRx.Unit, int> <>9__5_0;
        public static System.Func<UniRx.Unit, int> <>9__5_1;
        private int <Initialize>b__5_0(UniRx.Unit _);
        private int <Initialize>b__5_1(UniRx.Unit _);
    }

    private class <>c__DisplayClass5_0
    {
        public PRISM.Interactions.Live.LiveSettingItemViewIndexSelector <>4__this;
        public System.Action<int> onChange;
        private void <Initialize>b__2(int diff);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveSettingItemViewToggle : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView button;
    private PRISM.Interactions.ViewStateChanger isOnStateChanger;
    private bool isOn;
    public void Initialize(System.Action<bool> onChange);
    public void SetValueWithoutNotify(bool value);

    private class <>c__DisplayClass3_0
    {
        public PRISM.Interactions.Live.LiveSettingItemViewToggle <>4__this;
        public System.Action<bool> onChange;
        private void <Initialize>b__0(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveSettingItemViewToggleGroup : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView[] buttons;
    public void Initialize(System.Action<int> onChange);
    public void SetValueWithoutNotify(int value);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Interactions.ButtonView, int, System.IObservable<int>> <>9__1_0;
        private System.IObservable<int> <Initialize>b__1_0(PRISM.Interactions.ButtonView x, int i);
    }

    private class <>c__DisplayClass1_0
    {
        public PRISM.Interactions.Live.LiveSettingItemViewToggleGroup <>4__this;
        public System.Action<int> onChange;
        private void <Initialize>b__1(int index);
    }

    private class <>c__DisplayClass1_1
    {
        public int i;
        private int <Initialize>b__2(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveSettingItemViewVolumeSlider : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.Slider slider;
    private UniRx.Triggers.ObservablePointerUpTrigger pointerUpTrigger;
    private PRISM.Interactions.ButtonView muteButton;
    private PRISM.Interactions.ViewStateChanger muteStateChanger;
    private PRISM.Interactions.ViewStateChanger isPlusStateChanger;
    private bool isMute;
    public void Initialize(System.Action<PRISM.Legacy.SoundVolumeSettings> onChange);
    public void SetValueWithoutNotify(PRISM.Legacy.SoundVolumeSettings value);

    private class <>c__DisplayClass6_0
    {
        public PRISM.Interactions.Live.LiveSettingItemViewVolumeSlider <>4__this;
        public System.Action<PRISM.Legacy.SoundVolumeSettings> onChange;
        private void <Initialize>b__0(UniRx.Unit _);
        private void <Initialize>b__1(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveAudioOffsetSettingPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.ILiveAudioOffsetSettingPopupView, PRISM.Adapters.IClosablePopupFrame<System.ValueTuple<bool, float>>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<System.ValueTuple<bool, float>>
{
    private ENTERPRISE.UI.UITextMeshProUGUI[] lastOffsets;
    private PRISM.Interactions.Live.LiveSettingItemViewFloatSelector manualAdjustInput;
    private UniRx.Triggers.ObservablePointerDownTrigger tapButton;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<System.ValueTuple<bool, float>> onClick;
    private float offset;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<System.ValueTuple<bool, float>> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Assign(float offset);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__8_0();
    private void <CreateFrameParameter>b__8_1();
    private void <CreateFrameParameter>b__8_2();

    private class <>c
    {
        public static <>c <>9;
        public static System.Action<ENTERPRISE.UI.UITextMeshProUGUI, float> <>9__9_2;
        private void <ShowAsync>b__9_2(ENTERPRISE.UI.UITextMeshProUGUI text, float offset);
    }

    private class <>c__DisplayClass9_0
    {
        public PRISM.Interactions.Live.LiveAudioOffsetSettingPopupView <>4__this;
        public System.Collections.Generic.Queue<float> tapOffsets;
        public CriWare.CriAtomExPlayback playback;
        private void <ShowAsync>b__0(float x);
        private void <ShowAsync>b__1(UnityEngine.EventSystems.PointerEventData _);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveSettingDetailTabView : PRISM.Interactions.LiveSettingTabBase<PRISM.RhythmGame.RhythmGameOptionDetail>
{
    private PRISM.Interactions.Live.LiveSettingItemViewIndexSelector noteDesignInput;
    private PRISM.Interactions.Live.LiveSettingItemViewIndexSelector noteEffectDesignInput;
    private PRISM.Interactions.Live.LiveSettingItemViewToggle showNoteEffectToggle;
    private PRISM.Interactions.Live.LiveSettingItemViewToggle showLifeGaugeToggle;
    private PRISM.Interactions.Live.LiveSettingItemViewToggle showLifeWarningToggle;
    private PRISM.Interactions.Live.LiveSettingItemViewToggle showScoreGaugeToggle;
    private PRISM.Interactions.Live.LiveSettingItemViewToggle showShinyEffectToggle;
    private PRISM.Interactions.Live.LiveSettingItemViewToggleGroup comboShowTypeToggleGroup;
    private PRISM.Interactions.Live.LiveSettingItemViewToggle showGreatComboEffectToggle;
    private PRISM.Interactions.Live.LiveSettingItemViewToggle showPerfectComboEffectToggle;
    private PRISM.Interactions.Live.LiveSettingItemViewToggle showShinyComboEffectToggle;
    private PRISM.Interactions.Live.LiveSettingItemViewToggle showSpecialNumberComboEffectToggle;
    private PRISM.Interactions.Live.LiveSettingItemViewToggleGroup judgementShowTypeToggleGroup;
    private PRISM.Interactions.Live.LiveSettingItemViewToggleGroup judgementShowPositionTypeToggleGroup;
    private PRISM.Interactions.Live.LiveSettingItemViewToggleGroup showJudgementLagTypeToggle;
    private PRISM.Interactions.Live.LiveSettingItemViewToggle showPerfectJudgementLagToggle;
    private PRISM.Interactions.Live.LiveSettingItemViewToggleGroup technicalScoreShowTypeToggleGroup;
    private PRISM.Interactions.Live.LiveSettingItemViewToggleGroup technicalScoreShowPositionTypeToggleGroup;
    private PRISM.Interactions.Live.LiveSettingItemViewToggleGroup technicalScoreCalculationTypeToggleGroup;
    private PRISM.Interactions.Live.LiveSettingItemViewToggle showSkillCutinToggle;
    private PRISM.Interactions.Live.LiveSettingItemViewToggle showSkillEffectToggle;
    private PRISM.Interactions.Live.LiveSettingItemViewToggleGroup supportEffectTypeToggle;
    private PRISM.Interactions.Live.LiveSettingItemViewToggle showKeyBeamToggle;
    private PRISM.Interactions.Live.LiveSettingItemViewFloatSelector laneCutRateInput;
    private PRISM.Interactions.Live.LiveSettingItemViewToggle isMirrorToggle;
    private PRISM.Interactions.Live.LiveSettingItemViewToggleGroup frameRateTypeToggleGroup;
    public void Initialize(PRISM.RhythmGame.RhythmGameOptionDetail option, bool isCallFromRhythmGame, PRISM.RhythmGame.RhythmGameConfig config);
    public void SetValueWithoutNotify();
    private void <Initialize>b__26_0(int value);
    private void <Initialize>b__26_1(int value);
    private void <Initialize>b__26_2(bool value);
    private void <Initialize>b__26_3(bool value);
    private void <Initialize>b__26_4(bool value);
    private void <Initialize>b__26_5(bool value);
    private void <Initialize>b__26_6(bool value);
    private void <Initialize>b__26_7(int value);
    private void <Initialize>b__26_8(bool value);
    private void <Initialize>b__26_9(bool value);
    private void <Initialize>b__26_10(bool value);
    private void <Initialize>b__26_11(bool value);
    private void <Initialize>b__26_12(int value);
    private void <Initialize>b__26_13(int value);
    private void <Initialize>b__26_14(int value);
    private void <Initialize>b__26_15(bool value);
    private void <Initialize>b__26_16(int value);
    private void <Initialize>b__26_17(int value);
    private void <Initialize>b__26_18(int value);
    private void <Initialize>b__26_19(bool value);
    private void <Initialize>b__26_20(bool value);
    private void <Initialize>b__26_21(int value);
    private void <Initialize>b__26_22(bool value);
    private void <Initialize>b__26_23(float value);
    private void <Initialize>b__26_24(bool value);
    private void <Initialize>b__26_25(int value);

    private class <>c__DisplayClass26_0
    {
        public int value;
        public PRISM.Interactions.Live.LiveSettingDetailTabView <>4__this;
        private Cysharp.Threading.Tasks.UniTask <Initialize>b__26();

        private struct <<Initialize>b__26>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
        {
            public int <>1__state;
            public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
            public <>c__DisplayClass26_0 <>4__this;
            private PRISM.RhythmGame.RhythmGameOptionFrameRateType <type>5__2;
            private Awaiter<bool> <>u__1;
            private void MoveNext();
            private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveSettingLiveTabView : PRISM.Interactions.LiveSettingTabBase<PRISM.RhythmGame.RhythmGameOptionBasic>
{
    private PRISM.Interactions.Live.LiveSettingItemViewFloatSelector highSpeedInput;
    private PRISM.Interactions.Live.LiveSettingItemViewFloatSelector noteOffsetInput;
    private PRISM.Interactions.Live.LiveSettingItemViewFloatSelector noteDrawOffsetInput;
    private PRISM.Interactions.Live.LiveSettingItemViewFloatSelector backgroundBrightnessInput;
    private PRISM.Interactions.Live.LiveSettingItemViewFloatSelector laneAlphaInput;
    private PRISM.Interactions.Live.LiveSettingItemViewToggle showSimultaneousLineToggle;
    private PRISM.Interactions.Live.LiveSettingItemViewToggle useVibrationToggle;
    public void Initialize(PRISM.RhythmGame.RhythmGameOptionBasic option, bool isCallFromRhythmGame, PRISM.RhythmGame.RhythmGameConfig config);
    public void SetValueWithoutNotify();
    private void <Initialize>b__7_0(float value);
    private void <Initialize>b__7_1(float value);
    private void <Initialize>b__7_2(float value);
    private void <Initialize>b__7_3(float value);
    private void <Initialize>b__7_4(float value);
    private void <Initialize>b__7_5(bool value);
    private void <Initialize>b__7_6(bool value);
}

// Namespace: PRISM.Interactions.Live
public class LiveSettingPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.ILiveSettingPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.ToggleGroupView liveSettingTabGroup;
    private UnityEngine.GameObject[] tabViews;
    private PRISM.Live.LiveSettingPreviewPresenter preview;
    private PRISM.Interactions.Live.LiveSettingLiveTabView liveTab;
    private PRISM.Interactions.Live.LiveSettingDetailTabView detailTab;
    private PRISM.Interactions.Live.LiveSettingSoundTabView soundTab;
    private PRISM.Interactions.ButtonView noteOffsetSettingButton;
    private UnityEngine.GameObject[] disableOnRhythmGameObjects;
    private PRISM.Interactions.ButtonView[] shinyLockedButtons;
    private PRISM.RhythmGame.RhythmGameOption option;
    private PRISM.RhythmGame.RhythmGameLoader loader;
    private string bgmCueSheet;
    private string bgmCueName;
    private Status initialBgmStatus;
    private static string PreviewCueSheet;
    private static string PreviewCueName;
    private bool isCallFromRhythmGame;
    private string rhythmGameCueSheetName;
    private PopupSizeType sizeType;
    private bool isShinyEnabled;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClick;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void Assign(string rhythmGameCueSheetName, bool isShinyEnabled, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask _initializeAsync(System.Threading.CancellationToken cancellationToken);
    private void _onTabSelected(PRISM.Interactions.Live.LiveSettingTabType selectedTab);
    private void _switchBGM(bool isLiveBGM, System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask _showOffsetSettingPopupAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    private void <CreateFrameParameter>b__23_0();
    private void <CreateFrameParameter>b__23_1();

    private class <>c
    {
        public static <>c <>9;
        public static System.Action<UniRx.Unit> <>9__26_5;
        private void <_initializeAsync>b__26_5(UniRx.Unit _);
    }

    private class <>c__DisplayClass26_0
    {
        public PRISM.Interactions.Live.LiveSettingPopupView <>4__this;
        public System.Threading.CancellationToken cancellationToken;
        private void <_initializeAsync>b__0(PRISM.RhythmGame.RhythmGameOptionBasic _);
        private void <_initializeAsync>b__1(PRISM.RhythmGame.RhythmGameOptionDetail _);
        private void <_initializeAsync>b__2(PRISM.RhythmGame.RhythmGameOptionSound o);
        private void <_initializeAsync>b__3(bool value);
        private void <_initializeAsync>b__4(UniRx.Unit _);
    }

    private struct <LoadAsync>d__25 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
        public PRISM.Interactions.Live.LiveSettingPopupView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private Awaiter<bool> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_initializeAsync>d__26 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Live.LiveSettingPopupView <>4__this;
        public System.Threading.CancellationToken cancellationToken;
        private <>c__DisplayClass26_0 <>8__1;
        private Awaiter <>u__1;
        private Awaiter<PRISM.RhythmGame.RhythmGameConfig> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_showOffsetSettingPopupAsync>d__29 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Live.LiveSettingPopupView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter<System.ValueTuple<bool, float>> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Live
public enum LiveSettingTabType : System.Enum
{
    public int value__;
    public static PRISM.Interactions.Live.LiveSettingTabType Live;
    public static PRISM.Interactions.Live.LiveSettingTabType Detail;
    public static PRISM.Interactions.Live.LiveSettingTabType Sound;
}

// Namespace: PRISM.Interactions.Live
public class LiveSettingSoundPreviewPlayer : System.IDisposable
{
    public UniRx.ReactiveProperty<bool> IsPlaying;
    private System.Action playAction;
    private System.Action stopAction;
    private System.IDisposable disposable;
    private float prevPlayTime;
    public void Play();
    public void Dispose();

    private class <>c__DisplayClass5_0
    {
        public PRISM.Interactions.Live.LiveSettingSoundPreviewPlayer <>4__this;
        public System.Action stopAction;
        public float intervalSeconds;
        private void <.ctor>b__0(bool isPlay);
        private void <.ctor>b__1(long _);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveSettingSoundTabView : PRISM.Interactions.LiveSettingTabBase<PRISM.RhythmGame.RhythmGameOptionSound>, System.IDisposable
{
    private PRISM.Interactions.Live.LiveSettingItemViewVolumeSlider bgmVolumeNode;
    private PRISM.Interactions.ToggleButtonView bgmPreviewToggle;
    private PRISM.Interactions.Live.LiveSettingItemViewVolumeSlider seVolumeNode;
    private PRISM.Interactions.ToggleButtonView sePreviewToggle;
    private PRISM.Interactions.Live.LiveSettingItemViewVolumeSlider voiceVolumeNode;
    private PRISM.Interactions.ToggleButtonView voicePreviewToggle;
    private PRISM.Interactions.Live.LiveSettingItemViewToggleGroup startVoiceTypeToggleGroup;
    private PRISM.Interactions.Live.LiveSettingItemViewIndexSelector tapSETypeInput;
    private PRISM.Interactions.ToggleButtonView tapSEPreviewToggle;
    private PRISM.Interactions.Live.LiveSettingItemViewIndexSelector flickSETypeInput;
    private PRISM.Interactions.ToggleButtonView flickSEPreviewToggle;
    private UniRx.ReactiveProperty<bool> onSwitchBGMToggle;
    private static int VoicePreviewProduceIdolId;
    private PRISM.RhythmGame.RhythmGameSoundService soundService;
    private PRISM.Interactions.Live.LiveSettingSoundPreviewPlayer tapSEPlayer;
    private PRISM.Interactions.Live.LiveSettingSoundPreviewPlayer flickSEPlayer;
    private PRISM.Interactions.Live.LiveSettingSoundPreviewPlayer voicePlayer;
    public System.IObservable<bool> OnSwitchBGMToggle { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.RhythmGame.RhythmGameOptionSound option, bool isCallFromRhythmGame, PRISM.RhythmGame.RhythmGameConfig config);
    private Cysharp.Threading.Tasks.UniTask _createPreviewPlayersAsync();
    private void OnDisable();
    public void SetValueWithoutNotify();
    public void Dispose();
    private void <InitializeAsync>b__19_0(PRISM.Legacy.SoundVolumeSettings value);
    private void <InitializeAsync>b__19_1(PRISM.Legacy.SoundVolumeSettings value);
    private void <InitializeAsync>b__19_2(PRISM.Legacy.SoundVolumeSettings value);
    private void <InitializeAsync>b__19_3(int value);
    private void <InitializeAsync>b__19_4(int value);
    private void <InitializeAsync>b__19_5(int value);
    private void <>n__0(PRISM.RhythmGame.RhythmGameOptionSound option, bool isCallFromRhythmGame, PRISM.RhythmGame.RhythmGameConfig config);

    private class <>c__DisplayClass20_0
    {
        public CriWare.CriAtomExPlayback voicePlayback;
        public PRISM.Interactions.Live.LiveSettingSoundTabView <>4__this;
        public PRISM.Definitions.MstProduceIdol idol;
        private void <_createPreviewPlayersAsync>b__0();
        private void <_createPreviewPlayersAsync>b__1();
        private PRISM.Interactions.Live.LiveSettingSoundPreviewPlayer <_createPreviewPlayersAsync>g__CreateSEPlayer|2(PRISM.RhythmGame.NoteType noteType);
    }

    private class <>c__DisplayClass20_1
    {
        public PRISM.RhythmGame.NoteType noteType;
        public <>c__DisplayClass20_0 CS$<>8__locals1;
        private void <_createPreviewPlayersAsync>b__3();
    }

    private struct <InitializeAsync>d__19 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Live.LiveSettingSoundTabView <>4__this;
        public PRISM.RhythmGame.RhythmGameConfig config;
        public PRISM.RhythmGame.RhythmGameOptionSound option;
        public bool isCallFromRhythmGame;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_createPreviewPlayersAsync>d__20 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Live.LiveSettingSoundTabView <>4__this;
        private <>c__DisplayClass20_0 <>8__1;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveUnitCopyConfirmationPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.ILiveUnitCopyConfirmationPopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private PRISM.Interactions.Live.LiveUnitCopyConfirmationUnitView unitOneView;
    private PRISM.Interactions.Live.LiveUnitCopyConfirmationUnitView unitTwoView;
    private PRISM.Interactions.LiveUnitEditCopyOrResetToggleView toggleView;
    private ENTERPRISE.UI.UITextMeshProUGUI messageText;
    private PRISM.Interactions.ViewStateChanger copyFunctionArrow;
    private ENTERPRISE.UI.UITextMeshProUGUI copyFunctionText;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Initialize(PRISM.Adapters.LiveUnitEditCopyOrResetViewModel viewModel, PRISM.Live.ILiveUnit unitFrom, PRISM.Live.ILiveUnit unitTo, PRISM.Live.MusicData musicData, bool isReverse, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <Initialize>b__9_0(bool condition);
    private void <CreateFrameParameter>b__10_0();
    private void <CreateFrameParameter>b__10_1();
    private void <CreateFrameParameter>b__10_2();
}

// Namespace: PRISM.Interactions.Live
public class LiveUnitCopyConfirmationUnitView : UnityEngine.MonoBehaviour
{
    protected ENTERPRISE.UI.UITextMeshProUGUI unitNumber;
    protected ENTERPRISE.UI.UITextMeshProUGUI unitName;
    protected PRISM.Interactions.Live.LiveUnitListCellView cellView;
    protected PRISM.Interactions.ViewStateChanger isCopyMainStateChanger;
    protected PRISM.Interactions.ViewStateChanger isCopySupportStateChanger;
    protected PRISM.Interactions.ViewStateChanger isCopyGuestStateChanger;
    protected PRISM.Interactions.ViewStateChanger isCopyUnitNameStateChanger;
    protected PRISM.Interactions.ViewStateChanger isCopySkillOrderStateChanger;
    public void UpdateContent(PRISM.Adapters.LiveUnitEditCopyOrResetViewModel viewModel, PRISM.Live.ILiveUnit unit, PRISM.Live.MusicData musicData, bool isSource, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);

    private class <>c__DisplayClass8_0
    {
        public PRISM.Interactions.Live.LiveUnitCopyConfirmationUnitView <>4__this;
        public bool isSource;
        public PRISM.Live.ILiveUnit unit;
        private void <UpdateContent>b__0(bool isSet);
        private void <UpdateContent>b__1(bool isSet);
        private void <UpdateContent>b__2(bool isSet);
        private void <UpdateContent>b__3(bool isSet);
        private void <UpdateContent>b__4(bool isSet);
    }
}

// Namespace: PRISM.Interactions.Live
public class MusicAddToFavoritesPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IMusicAddToFavoritePopupView, PRISM.Adapters.IClosablePopupFrame<System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IFavoriteSongUpdateStatus>>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IFavoriteSongUpdateStatus>>
{
    private static int FavoriteNameMaxLength;
    private ENTERPRISE.UI.ToggleButton[] favoriteToggleButtons;
    private PRISM.CommonInputFieldTMP[] favoriteNameInputs;
    private ENTERPRISE.UI.UITextMeshProUGUI[] favoriteNameLengthCounters;
    private UnityEngine.GameObject invalidInputAnnotation;
    private System.Collections.Generic.Dictionary<FavoriteSongSlot, System.ValueTuple<bool, string>> initialStatuses;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IFavoriteSongUpdateStatus>> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IFavoriteSongUpdateStatus>> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Initialize(System.Collections.Generic.IEnumerable<PRISM.Live.FavoriteMusicGroup> favoriteMusicGroups, PRISM.Live.MusicData musicData);
    private System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IFavoriteSongUpdateStatus> _getFavoriteMusicGroupUpdates();
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private static bool <Initialize>g__IsValidInput|9_0(TMPro.TMP_InputField input);
    private void <_getFavoriteMusicGroupUpdates>g__TryAdd|10_0(FavoriteSongSlot slot, <>c__DisplayClass10_0& );
    private void <CreateFrameParameter>b__11_0();
    private void <CreateFrameParameter>b__11_1();
    private void <CreateFrameParameter>b__11_2();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.CommonInputFieldTMP, bool> <>9__9_2;
        private bool <Initialize>b__9_2(PRISM.CommonInputFieldTMP x);
    }

    private struct <>c__DisplayClass10_0 : System.ValueType
    {
        public PRISM.Interactions.Live.MusicAddToFavoritesPopupView <>4__this;
        public System.Collections.Generic.List<PRISM.Module.Networking.IFavoriteSongUpdateStatus> updates;
    }

    private class <>c__DisplayClass9_0
    {
        public PRISM.CommonInputFieldTMP input;
        public int reservedI;
        public PRISM.Interactions.Live.MusicAddToFavoritesPopupView <>4__this;
        private void <Initialize>b__1(string _);
    }
}

// Namespace: PRISM.Interactions.Live
public class MusicSelectionGridView : PRISM.Interactions.SelectableGridView<PRISM.Interactions.Live.MusicSelectionGridViewCell, PRISM.Live.MusicData>
{
    protected void SetupCellTemplate();

    private class CellGroup : DefaultCellGroup<PRISM.Live.MusicData, PRISM.Interactions.SelectableGridViewContext<PRISM.Live.MusicData>>
    {
    }
}

// Namespace: PRISM.Interactions.Live
public class MusicSelectionGridViewCell : PRISM.Interactions.SelectableGridViewCell<PRISM.Live.MusicData>
{
    private UnityEngine.UI.RawImage jacketIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI songName;
    private PRISM.AutoCancellationTokenSource canceller;
    public void UpdateContent(PRISM.Live.MusicData itemData);
    protected void OnDestroy();
}

// Namespace: PRISM.Interactions.Live
public class NotEnoughLiveBoostPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.INotEnoughLiveBoostPopupView, PRISM.Adapters.IClosablePopupFrame<PRISM.Adapters.NotEnoughLiveBoostPopupResult>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<PRISM.Adapters.NotEnoughLiveBoostPopupResult>
{
    private ENTERPRISE.UI.UITextMeshProUGUI lbUsageCountSettingText;
    private ENTERPRISE.UI.UITextMeshProUGUI currentLBValueText;
    private ENTERPRISE.UI.UITextMeshProUGUI confirmation;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<PRISM.Adapters.NotEnoughLiveBoostPopupResult> onClosed;
    private PRISM.Interactions.PopupFrameParameter frameParameter;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<PRISM.Adapters.NotEnoughLiveBoostPopupResult> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Initialize(LiveStartType startType, int lbUsageCountSetting, int currentLBValue);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <Initialize>b__7_0();
    private void <Initialize>b__7_1();
    private void <Initialize>b__7_2();
    private void <Initialize>b__7_3();
}

// Namespace: PRISM.Interactions.Live
public class SkipLiveResultPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.ISkipLiveResultPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.SDCharacterDisplayModelView modelView;
    private PRISM.Interactions.MusicBasicInfoView musicInfoView;
    private UnityEngine.GameObject clearAnimation;
    private UnityEngine.Animator scoreRankAnimator;
    private PRISM.Interactions.Live.LiveResultLiveBoostView liveBoostView;
    private ENTERPRISE.UI.UITextMeshProUGUI loopCount;
    private PRISM.Interactions.Live.LiveResultNumberRewardView moneyView;
    private PRISM.Interactions.Live.LiveResultNumberRewardView notebookView;
    private UnityEngine.UI.ScrollRect rewardScrollRect;
    private UnityEngine.RectTransform liveBonusRewardContainer;
    private UnityEngine.RectTransform clearRewardContainer;
    private UnityEngine.RectTransform scoreRankRewardContainer;
    private UnityEngine.RectTransform otherRewardContainer;
    private PRISM.Live.LiveResultRewardItem rewardItemPrefab;
    private PRISM.Interactions.Live.LiveResultUnitIdolView[] unitIdolViews;
    private UnityEngine.RectTransform unitIdolViewContainer;
    private PRISM.Interactions.Live.LiveGuestProfileView guestView;
    private UnityEngine.RectTransform idolViewContainer;
    private PRISM.Interactions.IdolBaseRewardIdolView idolViewPrefab;
    private UnityEngine.UI.Image eventLogoImage;
    private PRISM.Interactions.Live.LiveEventScoreDetailPanel eventScoreDetailPanel;
    private UnityEngine.RectTransform allSongEventIdolViewContainer;
    private PRISM.Interactions.Live.LiveResultAllSongEventIdolView allSongEventIdolViewPrefab;
    private PRISM.Interactions.ButtonView skipAnimationButton;
    private PRISM.Adapters.SkipLiveResultViewModel viewModel;
    private bool sePlayed;
    private System.Collections.Generic.Dictionary<UnityEngine.RectTransform, System.Collections.Generic.IReadOnlyList<PRISM.Live.LiveResultRewardItem>> rewardItemDic;
    private System.Collections.Generic.IReadOnlyList<PRISM.Interactions.IdolBaseRewardIdolView> idolViews;
    private System.Collections.Generic.IReadOnlyList<PRISM.Interactions.Live.LiveResultAllSongEventIdolView> allSongEventIdolViews;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Adapters.SkipLiveResultViewModel viewModel, System.Threading.CancellationToken ct);
    private void _createRewardItems(PRISM.ResourceManagement.IResourceLoader resourceLoader, UnityEngine.RectTransform container, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.ILivePlayRewardStatus> rewards);
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask _animateAsync(System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask _animateCoreAsync(System.Threading.CancellationToken ct);
    private void _skip();
    private Cysharp.Threading.Tasks.UniTaskVoid _showReceivePopupsAsync(System.Threading.CancellationToken ct);
    private bool _isScrollerContentExceedViewport();
    private Cysharp.Threading.Tasks.UniTask _scrollIfNeededAsync(UnityEngine.RectTransform container, System.Threading.CancellationToken ct);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__42_0();

    private class <>c
    {
        public static <>c <>9;
        public static System.Action<string> <>9__34_0;
        public static System.Action<PRISM.Interactions.Live.LiveResultUnitIdolView, System.ValueTuple<PRISM.Module.Networking.IProduceIdolStatus, PRISM.Adapters.IdolBaseRewardGaugeViewModel>> <>9__38_0;
        public static System.Action<PRISM.Interactions.IdolBaseRewardIdolView, PRISM.Module.Networking.IIdolBaseRewardStatus> <>9__38_1;
        public static System.Action<PRISM.Interactions.Live.LiveResultAllSongEventIdolView, PRISM.Module.Networking.ILiveEventIdolResultStatus> <>9__38_2;
        private void <LoadAsync>b__34_0(string cueName);
        private void <_skip>b__38_0(PRISM.Interactions.Live.LiveResultUnitIdolView view, System.ValueTuple<PRISM.Module.Networking.IProduceIdolStatus, PRISM.Adapters.IdolBaseRewardGaugeViewModel> idol);
        private void <_skip>b__38_1(PRISM.Interactions.IdolBaseRewardIdolView view, PRISM.Module.Networking.IIdolBaseRewardStatus data);
        private void <_skip>b__38_2(PRISM.Interactions.Live.LiveResultAllSongEventIdolView view, PRISM.Module.Networking.ILiveEventIdolResultStatus data);
    }

    private class <>c__DisplayClass32_0
    {
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        public PRISM.Interactions.Live.SkipLiveResultPopupView <>4__this;
        public System.Collections.Generic.List<Cysharp.Threading.Tasks.UniTask> tasks;
        private Cysharp.Threading.Tasks.UniTask <InitializeAsync>b__0(PRISM.Interactions.Live.LiveResultUnitIdolView view, System.ValueTuple<PRISM.Module.Networking.IProduceIdolStatus, PRISM.Adapters.IdolBaseRewardGaugeViewModel> idol);
        private PRISM.Interactions.IdolBaseRewardIdolView <InitializeAsync>b__1(PRISM.Module.Networking.IIdolBaseRewardStatus x);
        private void <InitializeAsync>b__2(UnityEngine.Sprite sprite);
        private PRISM.Interactions.Live.LiveResultAllSongEventIdolView <InitializeAsync>b__3(PRISM.Module.Networking.ILiveEventIdolResultStatus x);
    }

    private class <>c__DisplayClass33_0
    {
        public PRISM.Interactions.Live.SkipLiveResultPopupView <>4__this;
        public UnityEngine.RectTransform container;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private PRISM.Live.LiveResultRewardItem <_createRewardItems>b__0(PRISM.Module.Networking.ILivePlayRewardStatus reward);
    }

    private class <>c__DisplayClass36_0
    {
        public System.Threading.CancellationTokenSource animationCts;
        public PRISM.Interactions.Live.SkipLiveResultPopupView <>4__this;
        private void <_animateAsync>b__0(UniRx.Unit _);
        private void <_animateAsync>b__1(UniRx.Unit _);
    }

    private class <>c__DisplayClass37_0
    {
        public System.Threading.CancellationToken ct;
        private Cysharp.Threading.Tasks.UniTask <_animateCoreAsync>b__0(PRISM.Interactions.Live.LiveResultUnitIdolView view, System.ValueTuple<PRISM.Module.Networking.IProduceIdolStatus, PRISM.Adapters.IdolBaseRewardGaugeViewModel> idol);
        private Cysharp.Threading.Tasks.UniTask <_animateCoreAsync>b__1(PRISM.Interactions.IdolBaseRewardIdolView view, PRISM.Module.Networking.IIdolBaseRewardStatus data);
        private Cysharp.Threading.Tasks.UniTask <_animateCoreAsync>b__2(PRISM.Interactions.Live.LiveResultAllSongEventIdolView view, PRISM.Module.Networking.ILiveEventIdolResultStatus data);
    }

    private struct <ShowAsync>d__35 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Live.SkipLiveResultPopupView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_animateAsync>d__36 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Live.SkipLiveResultPopupView <>4__this;
        private <>c__DisplayClass36_0 <>8__1;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_animateCoreAsync>d__37 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public System.Threading.CancellationToken ct;
        public PRISM.Interactions.Live.SkipLiveResultPopupView <>4__this;
        private <>c__DisplayClass37_0 <>8__1;
        private Awaiter <>u__1;
        private Enumerator<UnityEngine.RectTransform, System.Collections.Generic.IReadOnlyList<PRISM.Live.LiveResultRewardItem>> <>7__wrap1;
        private UnityEngine.RectTransform <container>5__3;
        private System.Collections.Generic.IReadOnlyList<PRISM.Live.LiveResultRewardItem> <items>5__4;
        private System.Collections.Generic.IEnumerator<PRISM.Live.LiveResultRewardItem> <>7__wrap4;
        private PRISM.Live.LiveResultRewardItem <item>5__6;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_showReceivePopupsAsync>d__39 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
        public PRISM.Interactions.Live.SkipLiveResultPopupView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveResultAllSongEventIdolView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.CharacterBaseIconView icon;
    private PRISM.Interactions.ViewStateChanger positionMarksStateChanger;
    private TMPro.TextMeshProUGUI pointText;
    private TMPro.TextMeshProUGUI diffText;
    private PRISM.Interactions.LiveEventRankingGradeIcon[] gradeIcons;
    public Cysharp.Threading.Tasks.UniTask PrepareAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, int characterId, PRISM.Live.LiveIdolPositionMark positionMark, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask AnimateAsync(PRISM.Module.Networking.ILiveEventIdolResultStatus viewModel, float duration, System.Threading.CancellationToken cancellationToken);

    private class <>c__DisplayClass6_0
    {
        public PRISM.Module.Networking.ILiveEventIdolResultStatus viewModel;
        public PRISM.Interactions.Live.LiveResultAllSongEventIdolView <>4__this;
        private void <AnimateAsync>b__0(float t);
        private void <AnimateAsync>g__RenderPoint|1(long point);
    }

    private struct <AnimateAsync>d__6 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Module.Networking.ILiveEventIdolResultStatus viewModel;
        public PRISM.Interactions.Live.LiveResultAllSongEventIdolView <>4__this;
        public float duration;
        public System.Threading.CancellationToken cancellationToken;
        private <>c__DisplayClass6_0 <>8__1;
        private long <diffPoint>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveResultAllSongEventPhaseView : UnityEngine.MonoBehaviour, PRISM.Adapters.ILiveResultAllSongEventPhaseView
{
    private PRISM.Interactions.Live.LiveResultPhaseViewCore core;
    private UnityEngine.UI.Image backgroundImage;
    private PRISM.Interactions.Live.LiveResultAllSongEventIdolView[] idolViews;
    private PRISM.Interactions.ButtonView howToPlayButton;
    private PRISM.HowToPlayPopupOpener howToPlayPopupOpener;
    private PRISM.Interactions.ButtonView eventTopButton;
    public PRISM.Adapters.ILiveResultPhaseViewCore Core { get; set; }
    public System.IObservable<UniRx.Unit> OnClickEventTop { get; set; }
    public PRISM.HowToPlayPopupOpener HowToPlayPopupOpener { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Adapters.LiveResultAllSongEventPhaseViewModel viewModel, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(PRISM.Adapters.LiveResultAllSongEventPhaseViewModel viewModel, PRISM.Definitions.SkippableCancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask <ShowAsync>g__AnimateAsync|13_0(float duration, System.Threading.CancellationToken cancellationToken, <>c__DisplayClass13_0& );

    private class <>c__DisplayClass12_0
    {
        public PRISM.Interactions.Live.LiveResultAllSongEventPhaseView <>4__this;
        public PRISM.Adapters.LiveResultAllSongEventPhaseViewModel viewModel;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        private void <InitializeAsync>b__0(UniRx.Unit _);
        private Cysharp.Threading.Tasks.UniTask <InitializeAsync>b__1(PRISM.Interactions.Live.LiveResultAllSongEventIdolView view, int index);
    }

    private struct <>c__DisplayClass13_0 : System.ValueType
    {
        public PRISM.Interactions.Live.LiveResultAllSongEventPhaseView <>4__this;
        public PRISM.Adapters.LiveResultAllSongEventPhaseViewModel viewModel;
    }

    private class <>c__DisplayClass13_1
    {
        public float duration;
        public System.Threading.CancellationToken cancellationToken;
        private Cysharp.Threading.Tasks.UniTask <ShowAsync>b__1(PRISM.Interactions.Live.LiveResultAllSongEventIdolView view, System.ValueTuple<PRISM.Module.Networking.ILiveEventIdolResultStatus, PRISM.Live.LiveIdolPositionMark> idol);
    }

    private struct <ShowAsync>d__13 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Live.LiveResultAllSongEventPhaseView <>4__this;
        public PRISM.Adapters.LiveResultAllSongEventPhaseViewModel viewModel;
        public PRISM.Definitions.SkippableCancellationToken ct;
        private <>c__DisplayClass13_0 <>8__1;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveEventScoreDetailPanel : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.Live.ScoreRankIcon scoreRankIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI scoreText;
    private ENTERPRISE.UI.UITextMeshProUGUI eventPointBaseText;
    private ENTERPRISE.UI.UITextMeshProUGUI medalScoreText;
    private ENTERPRISE.UI.UITextMeshProUGUI eventBonusText;
    private ENTERPRISE.UI.UITextMeshProUGUI lbRateText;
    private ENTERPRISE.UI.UITextMeshProUGUI rewardEventPointText;
    private ENTERPRISE.UI.UITextMeshProUGUI totalEventPointText;
    private ENTERPRISE.UI.UITextMeshProUGUI rewardMedalText;
    private ENTERPRISE.UI.UITextMeshProUGUI totalMedalText;
    private UnityEngine.UI.Image pointIcon;
    private UnityEngine.UI.Image medalIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI pointNameBaseText;
    private ENTERPRISE.UI.UITextMeshProUGUI pointNameText;
    private ENTERPRISE.UI.UITextMeshProUGUI[] pointUnitTexts;
    private System.Collections.Generic.List<UnityEngine.Sprite> sprites;
    public Cysharp.Threading.Tasks.UniTask PrepareAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Adapters.LiveEventScoreDetailViewModel viewModel, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask AnimateScoresAsync(PRISM.Adapters.LiveEventScoreDetailViewModel viewModel, System.Func<bool> isSkip, System.Threading.CancellationToken ct);
    public void SetScoresImmediately(PRISM.Adapters.LiveEventScoreDetailViewModel viewModel);
    public void ResetScores();
    private void OnDestroy();
    private Cysharp.Threading.Tasks.UniTask _loadProductIconAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, UnityEngine.UI.Image image, PRISM.Domain.ProductKey product, System.Threading.CancellationToken ct);
    private static Cysharp.Threading.Tasks.UniTask _animateCommaNumberAsync(TMPro.TextMeshProUGUI tmp, int startValue, int endValue, System.Threading.CancellationToken cancellationToken);
    private static void _setCommaText(TMPro.TMP_Text tmp, long longNumber);

    private class <>c__DisplayClass22_0
    {
        public TMPro.TextMeshProUGUI tmp;
        private void <_animateCommaNumberAsync>b__0(float num);
    }

    private struct <AnimateScoresAsync>d__17 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Live.LiveEventScoreDetailPanel <>4__this;
        public PRISM.Adapters.LiveEventScoreDetailViewModel viewModel;
        public System.Threading.CancellationToken ct;
        public System.Func<bool> isSkip;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_loadProductIconAsync>d__21 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public PRISM.Domain.ProductKey product;
        public System.Threading.CancellationToken ct;
        public UnityEngine.UI.Image image;
        public PRISM.Interactions.Live.LiveEventScoreDetailPanel <>4__this;
        private Awaiter<UnityEngine.Texture2D> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveResultEventPhaseView : UnityEngine.MonoBehaviour, PRISM.Adapters.ILiveResultEventPhaseView
{
    private PRISM.Interactions.Live.LiveResultPhaseViewCore core;
    private UnityEngine.UI.Image backgroundImage;
    private UnityEngine.Transform characterArea;
    private UnityEngine.UI.Image characterImage;
    private UnityEngine.UI.Image logoImage;
    private UnityEngine.UI.Image logoEffectImage;
    private PRISM.Interactions.MusicBasicInfoView musicInfoView;
    private PRISM.Interactions.Live.LiveEventScoreDetailPanel scoreDetailPanel;
    private PRISM.Interactions.ButtonView eventTopButton;
    private PRISM.Interactions.ViewStateChanger nextStoryStateChanger;
    private ENTERPRISE.UI.UITextMeshProUGUI[] eventStoryTexts;
    private ENTERPRISE.UI.UITextMeshProUGUI[] eventStoryRemainPointTexts;
    private UnityEngine.Animator nextStoryAnimator;
    private UnityEngine.Animator completeStoryAnimator;
    public PRISM.Adapters.ILiveResultPhaseViewCore Core { get; set; }
    public System.IObservable<UniRx.Unit> OnClickEventTop { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Adapters.LiveResultEventPhaseViewModel viewModel, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(PRISM.Adapters.LiveResultEventPhaseViewModel viewModel, PRISM.Definitions.SkippableCancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync(PRISM.Adapters.LiveResultEventPhaseViewModel viewModel, bool isForward);

    private class <>c__DisplayClass18_0
    {
        public PRISM.Interactions.Live.LiveResultEventPhaseView <>4__this;
        public PRISM.Definitions.MstEvent master;
        public PRISM.Adapters.LiveResultEventPhaseViewModel viewModel;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        private void <InitializeAsync>b__0(UnityEngine.Sprite sprite);
        private Cysharp.Threading.Tasks.UniTask <InitializeAsync>g__LoadCharacterAsync|1();
        private UnityEngine.GameObject <InitializeAsync>b__2(UnityEngine.GameObject prefab);
    }

    private class <>c__DisplayClass19_0
    {
        public PRISM.Definitions.SkippableCancellationToken ct;
        private bool <ShowAsync>b__0();
    }

    private struct <ShowAsync>d__19 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Definitions.SkippableCancellationToken ct;
        public PRISM.Interactions.Live.LiveResultEventPhaseView <>4__this;
        public PRISM.Adapters.LiveResultEventPhaseViewModel viewModel;
        private <>c__DisplayClass19_0 <>8__1;
        private Awaiter<bool> <>u__1;
        private Awaiter <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveResultIdolPhaseView : UnityEngine.MonoBehaviour, PRISM.Adapters.ILiveResultIdolPhaseView
{
    private PRISM.Interactions.Live.LiveResultPhaseViewCore core;
    private PRISM.Interactions.IdolBaseRewardIdolView[] idolViews;
    public PRISM.Adapters.ILiveResultPhaseViewCore Core { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Collections.Generic.IReadOnlyList<PRISM.Adapters.LiveResultIdolPhaseIdolViewModel> idols, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.LiveResultIdolPhaseIdolViewModel> idols, PRISM.Definitions.SkippableCancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask <ShowAsync>g__AnimateAsync|5_0(float duration, System.Threading.CancellationToken cancellationToken, <>c__DisplayClass5_0& );

    private class <>c__DisplayClass4_0
    {
        public System.Collections.Generic.IReadOnlyList<PRISM.Adapters.LiveResultIdolPhaseIdolViewModel> idols;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        private Cysharp.Threading.Tasks.UniTask <InitializeAsync>b__0(PRISM.Interactions.IdolBaseRewardIdolView view, int index);
    }

    private struct <>c__DisplayClass5_0 : System.ValueType
    {
        public PRISM.Interactions.Live.LiveResultIdolPhaseView <>4__this;
        public System.Collections.Generic.IReadOnlyList<PRISM.Adapters.LiveResultIdolPhaseIdolViewModel> idols;
    }

    private class <>c__DisplayClass5_1
    {
        public float duration;
        public System.Threading.CancellationToken cancellationToken;
        private Cysharp.Threading.Tasks.UniTask <ShowAsync>b__1(PRISM.Interactions.IdolBaseRewardIdolView view, PRISM.Adapters.LiveResultIdolPhaseIdolViewModel idol);
    }

    private struct <ShowAsync>d__5 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Live.LiveResultIdolPhaseView <>4__this;
        public System.Collections.Generic.IReadOnlyList<PRISM.Adapters.LiveResultIdolPhaseIdolViewModel> idols;
        public PRISM.Definitions.SkippableCancellationToken ct;
        private <>c__DisplayClass5_0 <>8__1;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveResultAutoLabelView : UnityEngine.MonoBehaviour
{
    private TMPro.TextMeshProUGUI loopCountText;
    public void Initialize(PRISM.Adapters.LiveResultViewModel viewModel);
}

// Namespace: PRISM.Interactions.Live
public class LiveResultBackgroundView : PRISM.Adapters.ILiveResultBackgroundView, Cysharp.Threading.Tasks.IUniTaskAsyncDisposable
{
    private PRISM.Legacy.SimpleModel3dLoader model3dLoader;
    private string cueName;
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Live.LiveResultData inGameData, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask WaitReadyAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask PlayAsync(System.Threading.CancellationToken ct);
    public void SetEndFlag();
    public Cysharp.Threading.Tasks.UniTask DisposeAsync();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<bool> <>9__3_0;
        private bool <WaitReadyAsync>b__3_0();
    }

    private struct <InitializeAsync>d__2 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Live.LiveResultData inGameData;
        public PRISM.Interactions.Live.LiveResultBackgroundView <>4__this;
        public System.Threading.CancellationToken ct;
        private int <charaId>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <PlayAsync>d__4 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public System.Threading.CancellationToken ct;
        public PRISM.Interactions.Live.LiveResultBackgroundView <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <WaitReadyAsync>d__3 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveResultConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.LiveResultArgument>, PRISM.Live.ILiveResultConnector
{
    protected PRISM.Adapters.LiveResultArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
}

// Namespace: PRISM.Interactions.Live
public class LiveResultHeaderView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ViewStateChanger liveSuccessStateChanger;
    private PRISM.Interactions.MusicBasicInfoView musicInfoView;
    private PRISM.Live.MusicClearStatusLampView musicClearStatusLampView;
    private PRISM.Interactions.Live.LiveResultAutoLabelView[] autoLabelViews;
    private PRISM.Interactions.ButtonView shareButton;
    public System.IObservable<UniRx.Unit> OnShare { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Adapters.LiveResultViewModel viewModel, System.Threading.CancellationToken ct);
}

// Namespace: PRISM.Interactions.Live
public class LiveResultLiveBoostView : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.Image backgroundImage;
    private UnityEngine.Color defaultColor;
    private UnityEngine.Color maxColor;
    private ENTERPRISE.UI.UITextMeshProUGUI multiplierText;
    public void Setup(int count);
    public void AdjustLayout();
}

// Namespace: PRISM.Interactions.Live
public class LiveResultUtility
{
    public static Cysharp.Threading.Tasks.UniTask AnimateNumberAsync(ENTERPRISE.UI.UITextMeshProUGUI tmp, int value, int digit, System.Threading.CancellationToken cancellationToken);
    public static string GetLeadingGreyZeros(int number, int digits);

    private class <>c__DisplayClass0_0
    {
        public ENTERPRISE.UI.UITextMeshProUGUI tmp;
        public int digit;
        private void <AnimateNumberAsync>b__0(float num);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveResultView : UnityEngine.MonoBehaviour, PRISM.Adapters.ILiveResultView
{
    private UnityEngine.GameObject animationRoot;
    private PRISM.Interactions.Live.LiveResultHeaderView headerView;
    private PRISM.Interactions.Live.LiveResultPhaseControlView phaseControlView;
    private PRISM.Interactions.Live.LiveResultScorePhaseView scorePhaseView;
    private PRISM.Interactions.Live.LiveResultRewardPhaseView rewardPhaseView;
    private PRISM.Interactions.Live.LiveResultUnitPhaseView unitPhaseView;
    private PRISM.Interactions.Live.LiveResultIdolPhaseView idolPhaseView;
    private PRISM.Interactions.Live.LiveResultEventPhaseView eventPhaseView;
    private PRISM.Interactions.Live.LiveResultAllSongEventPhaseView allSongEventPhaseView;
    private PRISM.Adapters.ILiveResultBackgroundView <BackgroundView>k__BackingField;
    public PRISM.Adapters.ILiveResultBackgroundView BackgroundView { get; set; }
    public PRISM.Adapters.ILiveResultPhaseControlView PhaseControlView { get; set; }
    public PRISM.Adapters.ILiveResultScorePhaseView ScorePhaseView { get; set; }
    public PRISM.Adapters.ILiveResultRewardPhaseView RewardPhaseView { get; set; }
    public PRISM.Adapters.ILiveResultUnitPhaseView UnitPhaseView { get; set; }
    public PRISM.Adapters.ILiveResultIdolPhaseView IdolPhaseView { get; set; }
    public PRISM.Adapters.ILiveResultEventPhaseView EventPhaseView { get; set; }
    public PRISM.Adapters.ILiveResultAllSongEventPhaseView AllSongEventPhaseView { get; set; }
    public System.IObservable<UniRx.Unit> OnShare { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Adapters.LiveResultViewModel viewModel, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask AnimateAsync(System.Threading.CancellationToken ct);

    private class <>c
    {
        public static <>c <>9;
        public static System.Action<string> <>9__28_0;
        private void <InitializeAsync>b__28_0(string cueName);
    }

    private struct <InitializeAsync>d__28 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Live.LiveResultView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public PRISM.Adapters.LiveResultViewModel viewModel;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private Awaiter<CriWare.CriAtomExPlayback> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveResultPhaseControlButtonView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView button;
    private UnityEngine.CanvasGroup canvasGroup;
    public System.IObservable<UniRx.Unit> OnClick { get; set; }
    public UnityEngine.CanvasGroup CanvasGroup { get; set; }
    private void Awake();
}

// Namespace: PRISM.Interactions.Live
public class LiveResultPhaseControlView : UnityEngine.MonoBehaviour, PRISM.Adapters.ILiveResultPhaseControlView
{
    private PRISM.Interactions.Live.LiveResultPhaseControlButtonView[] buttons;
    public PRISM.Adapters.IBackKeyObservable BackKeyObservable { get; set; }
    public System.IObservable<PRISM.Adapters.LiveResultPhaseControlButtonType> OnClick { get; set; }
    public Cysharp.Threading.Tasks.UniTask FadeInAsync(System.Func<PRISM.Adapters.LiveResultPhaseControlButtonType, bool> showPredicate);
    public Cysharp.Threading.Tasks.UniTask FadeOutAsync(System.Func<PRISM.Adapters.LiveResultPhaseControlButtonType, bool> showPredicate);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Interactions.Live.LiveResultPhaseControlButtonView, int, System.IObservable<PRISM.Adapters.LiveResultPhaseControlButtonType>> <>9__4_0;
        private System.IObservable<PRISM.Adapters.LiveResultPhaseControlButtonType> <get_OnClick>b__4_0(PRISM.Interactions.Live.LiveResultPhaseControlButtonView button, int index);
    }

    private class <>c__DisplayClass4_0
    {
        public int index;
        private PRISM.Adapters.LiveResultPhaseControlButtonType <get_OnClick>b__1(UniRx.Unit _);
    }

    private class <>c__DisplayClass5_0
    {
        public System.Func<PRISM.Adapters.LiveResultPhaseControlButtonType, bool> showPredicate;
        private Cysharp.Threading.Tasks.UniTask <FadeInAsync>b__0(PRISM.Interactions.Live.LiveResultPhaseControlButtonView button, int index);

        private struct <<FadeInAsync>b__0>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
        {
            public int <>1__state;
            public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
            public <>c__DisplayClass5_0 <>4__this;
            public int index;
            public PRISM.Interactions.Live.LiveResultPhaseControlButtonView button;
            private TweenAwaiter <>u__1;
            private void MoveNext();
            private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }

    private class <>c__DisplayClass6_0
    {
        public System.Func<PRISM.Adapters.LiveResultPhaseControlButtonType, bool> showPredicate;
        private Cysharp.Threading.Tasks.UniTask <FadeOutAsync>b__0(PRISM.Interactions.Live.LiveResultPhaseControlButtonView button, int index);

        private struct <<FadeOutAsync>b__0>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
        {
            public int <>1__state;
            public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
            public PRISM.Interactions.Live.LiveResultPhaseControlButtonView button;
            public <>c__DisplayClass6_0 <>4__this;
            public int index;
            private TweenAwaiter <>u__1;
            private void MoveNext();
            private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveResultPhaseViewCore : UnityEngine.MonoBehaviour, PRISM.Adapters.ILiveResultPhaseViewCore
{
    private UnityEngine.Animator[] animators;
    private PRISM.Interactions.ButtonView skipButton;
    protected UnityEngine.CanvasGroup canvasGroup;
    public System.IObservable<UniRx.Unit> OnSkip { get; set; }
    public System.IDisposable CreateAnimationScope(PRISM.Definitions.SkippableCancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public void Hide();

    private class <>c
    {
        public static <>c <>9;
        public static System.Action<UnityEngine.GameObject> <>9__5_1;
        private void <CreateAnimationScope>b__5_1(UnityEngine.GameObject x);
    }

    private class <>c__DisplayClass5_0
    {
        public PRISM.Definitions.SkippableCancellationToken ct;
        public PRISM.Interactions.Live.LiveResultPhaseViewCore <>4__this;
        private void <CreateAnimationScope>b__0();
    }

    private struct <HideAsync>d__6 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Live.LiveResultPhaseViewCore <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveResultNumberRewardView : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI text;
    public void SetValue(long before, long after);
    public Cysharp.Threading.Tasks.UniTask AnimateAsync(long before, long after, System.Threading.CancellationToken cancellationToken);

    private class <>c__DisplayClass2_0
    {
        public PRISM.Interactions.Live.LiveResultNumberRewardView <>4__this;
        public long before;
        public long after;
        private void <AnimateAsync>b__0(float x);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveResultRewardInfoView : UnityEngine.MonoBehaviour
{
    private PRISM.Live.LiveResultRewardItem rewardItemPrefab;
    private UnityEngine.UI.ScrollRect[] rewardScrollRects;
    private UnityEngine.GameObject[] rewardEmptyObjects;
    private System.Collections.Generic.Dictionary<Category, System.Collections.Generic.IReadOnlyList<PRISM.Live.LiveResultRewardItem>> rewardItemDic;
    public void Initialize(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Module.Networking.ILivePlayRewardPackStatus rewardPack);
    public void HideRewardCategories();
    public Cysharp.Threading.Tasks.UniTask ShowRewardCategoriesAsync(System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask OpenRewardsAsync(System.Threading.CancellationToken cancellationToken);
    public void ShowRewardsImmediately();

    private enum Category : System.Enum
    {
        public int value__;
        public static Category LiveBonus;
        public static Category Clear;
        public static Category ScoreRank;
        public static Category Other;
    }

    private class <>c__DisplayClass5_0
    {
        public PRISM.Interactions.Live.LiveResultRewardInfoView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private void <Initialize>g__Create|0(Category category, System.Collections.Generic.IEnumerable<PRISM.Module.Networking.ILivePlayRewardStatus> rewards);
    }

    private class <>c__DisplayClass5_1
    {
        public UnityEngine.UI.ScrollRect scrollRect;
        public <>c__DisplayClass5_0 CS$<>8__locals1;
        private PRISM.Live.LiveResultRewardItem <Initialize>b__1(PRISM.Module.Networking.ILivePlayRewardStatus reward);
    }

    private class <>c__DisplayClass8_0
    {
        public System.Threading.CancellationToken cancellationToken;
    }

    private class <>c__DisplayClass8_1
    {
        public System.Collections.Generic.IReadOnlyList<PRISM.Live.LiveResultRewardItem> items;
        public float space;
        public float viewportSize;
        public UnityEngine.UI.ScrollRect scrollRect;
        public <>c__DisplayClass8_0 CS$<>8__locals1;
        private Cysharp.Threading.Tasks.UniTask<float> <OpenRewardsAsync>g__OpenAsync|0(PRISM.Live.LiveResultRewardItem item, int i, float currentSize);
        private Cysharp.Threading.Tasks.UniTask <OpenRewardsAsync>g__OpenRemainingAsync|1(float currentSize);

        private struct <<OpenRewardsAsync>g__OpenAsync|0>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
        {
            public int <>1__state;
            public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<float> <>t__builder;
            public PRISM.Live.LiveResultRewardItem item;
            public <>c__DisplayClass8_1 <>4__this;
            public int i;
            public float currentSize;
            private Awaiter <>u__1;
            private void MoveNext();
            private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }

        private struct <<OpenRewardsAsync>g__OpenRemainingAsync|1>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
        {
            public int <>1__state;
            public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
            public <>c__DisplayClass8_1 <>4__this;
            public float currentSize;
            private int <i>5__2;
            private Awaiter<float> <>u__1;
            private void MoveNext();
            private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }

    private struct <OpenRewardsAsync>d__8 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public System.Threading.CancellationToken cancellationToken;
        public PRISM.Interactions.Live.LiveResultRewardInfoView <>4__this;
        private <>c__DisplayClass8_0 <>8__1;
        private <>c__DisplayClass8_1 <>8__2;
        private Enumerator<Category, System.Collections.Generic.IReadOnlyList<PRISM.Live.LiveResultRewardItem>> <>7__wrap1;
        private Awaiter<float> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <ShowRewardCategoriesAsync>d__7 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Live.LiveResultRewardInfoView <>4__this;
        public System.Threading.CancellationToken cancellationToken;
        private Enumerator<Category, System.Collections.Generic.IReadOnlyList<PRISM.Live.LiveResultRewardItem>> <>7__wrap1;
        private Category <category>5__3;
        private System.Collections.Generic.IReadOnlyList<PRISM.Live.LiveResultRewardItem> <items>5__4;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveResultRewardPhaseView : UnityEngine.MonoBehaviour, PRISM.Adapters.ILiveResultRewardPhaseView
{
    private PRISM.Interactions.Live.LiveResultPhaseViewCore core;
    private PRISM.Interactions.Live.LiveResultLiveBoostView liveBoostView;
    private PRISM.Interactions.Live.LiveResultNumberRewardView moneyView;
    private PRISM.Interactions.Live.LiveResultNumberRewardView notebookView;
    private PRISM.Interactions.Live.LiveResultRewardInfoView rewardInfoView;
    public PRISM.Adapters.ILiveResultPhaseViewCore Core { get; set; }
    public void Initialize(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Module.Networking.ILivePlayRewardPackStatus rewardPack);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(PRISM.Adapters.LiveResultViewModel viewModel, PRISM.Definitions.SkippableCancellationToken ct);

    private class <>c__DisplayClass8_0
    {
        public PRISM.Interactions.Live.LiveResultRewardPhaseView <>4__this;
        public PRISM.Adapters.LiveResultViewModel viewModel;
        public PRISM.Definitions.SkippableCancellationToken ct;
        private Cysharp.Threading.Tasks.UniTask <ShowAsync>b__0();
        private Cysharp.Threading.Tasks.UniTask <ShowAsync>b__1();
        private Cysharp.Threading.Tasks.UniTask <ShowAsync>b__2();
        private Cysharp.Threading.Tasks.UniTask <ShowAsync>b__3();
    }

    private struct <ShowAsync>d__8 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Live.LiveResultRewardPhaseView <>4__this;
        public PRISM.Adapters.LiveResultViewModel viewModel;
        public PRISM.Definitions.SkippableCancellationToken ct;
        private <>c__DisplayClass8_0 <>8__1;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Live
public interface ILiveResultScorePhasePanel`1<T>
{
    public void SetData(T viewModel);
    public Cysharp.Threading.Tasks.UniTask AnimateAsync(T viewModel, System.Threading.CancellationToken ct);
    public void Clear();
}

// Namespace: PRISM.Interactions.Live
public class LiveResultJudgeCountCellView : UnityEngine.MonoBehaviour, PRISM.Interactions.Live.ILiveResultScorePhasePanel<PRISM.Adapters.LiveResultJudgeCountCellViewModel>
{
    private ENTERPRISE.UI.UITextMeshProUGUI totalText;
    private ENTERPRISE.UI.UITextMeshProUGUI detailText;
    public void ToggleDetail(bool showDetail);
    public void SetData(PRISM.Adapters.LiveResultJudgeCountCellViewModel viewModel);
    private void _setDetailText(int fast, int slow, int reverse);
    public Cysharp.Threading.Tasks.UniTask AnimateAsync(PRISM.Adapters.LiveResultJudgeCountCellViewModel viewModel, System.Threading.CancellationToken ct);
    public void Clear();

    private class <>c__DisplayClass5_0
    {
        public PRISM.Adapters.LiveResultJudgeCountCellViewModel viewModel;
        public PRISM.Interactions.Live.LiveResultJudgeCountCellView <>4__this;
        private void <AnimateAsync>b__0(float p);
    }

    private struct <AnimateAsync>d__5 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Adapters.LiveResultJudgeCountCellViewModel viewModel;
        public PRISM.Interactions.Live.LiveResultJudgeCountCellView <>4__this;
        public System.Threading.CancellationToken ct;
        private <>c__DisplayClass5_0 <>8__1;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveResultJudgeCountView : UnityEngine.MonoBehaviour, PRISM.Interactions.Live.ILiveResultScorePhasePanel<PRISM.Adapters.LiveResultJudgeCountViewModel>
{
    private PRISM.Interactions.Live.LiveResultJudgeCountCellView shinyCount;
    private PRISM.Interactions.Live.LiveResultJudgeCountCellView perfectCount;
    private PRISM.Interactions.Live.LiveResultJudgeCountCellView greatCount;
    private PRISM.Interactions.Live.LiveResultJudgeCountCellView goodCount;
    private PRISM.Interactions.Live.LiveResultJudgeCountCellView missCount;
    private UnityEngine.GameObject skillBoostedToPerfectBadge;
    private UnityEngine.GameObject skillBoostedToGreatBadge;
    private ENTERPRISE.UI.UITextMeshProUGUI detailAnnotation;
    private PRISM.Interactions.ButtonView switchDetailButton;
    private UniRx.IReadOnlyReactiveProperty<bool> showJudgeDetail;
    public void Initialize(bool showShiny, UniRx.IReactiveProperty<bool> showJudgeDetail);
    public void SetData(PRISM.Adapters.LiveResultJudgeCountViewModel viewModel);
    public Cysharp.Threading.Tasks.UniTask AnimateAsync(PRISM.Adapters.LiveResultJudgeCountViewModel viewModel, System.Threading.CancellationToken ct);
    public void Clear();

    private class <>c__DisplayClass10_0
    {
        public UniRx.IReactiveProperty<bool> showJudgeDetail;
        public PRISM.Interactions.Live.LiveResultJudgeCountView <>4__this;
        public bool showShiny;
        private void <Initialize>b__0(UniRx.Unit _);
        private void <Initialize>b__1(bool showDetail);
    }

    private struct <AnimateAsync>d__12 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Live.LiveResultJudgeCountView <>4__this;
        public PRISM.Adapters.LiveResultJudgeCountViewModel viewModel;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveResultRateInfoView : UnityEngine.MonoBehaviour, PRISM.Interactions.Live.ILiveResultScorePhasePanel<PRISM.Adapters.LiveResultRateInfoViewModel>
{
    private PRISM.Interactions.Live.LiveResultRateRecordView highScoreRateView;
    private PRISM.Interactions.Live.LiveResultRateRecordView totalHighScoreRateView;
    private PRISM.Interactions.Live.LiveResultRateRecordView technicalRateView;
    private PRISM.Interactions.Live.LiveResultRateRecordView totalTechnicalRateView;
    public void SetData(PRISM.Adapters.LiveResultRateInfoViewModel viewModel);
    public Cysharp.Threading.Tasks.UniTask AnimateAsync(PRISM.Adapters.LiveResultRateInfoViewModel viewModel, System.Threading.CancellationToken ct);
    public void Clear();

    private struct <AnimateAsync>d__5 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Live.LiveResultRateInfoView <>4__this;
        public PRISM.Adapters.LiveResultRateInfoViewModel viewModel;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveResultRateRecordView : UnityEngine.MonoBehaviour, PRISM.Interactions.Live.ILiveResultScorePhasePanel<PRISM.Adapters.LiveResultRateRecordViewModel>
{
    private int digits;
    private string numberFormat;
    private string increaseTextFormat;
    private ENTERPRISE.UI.UITextMeshProUGUI defaultText;
    private ENTERPRISE.UI.UITextMeshProUGUI newRecordText;
    private ENTERPRISE.UI.UITextMeshProUGUI defaultIncreaseText;
    private ENTERPRISE.UI.UITextMeshProUGUI newRecordIncreaseText;
    public void SetData(PRISM.Adapters.LiveResultRateRecordViewModel viewModel);
    private string _getText(float number);
    public Cysharp.Threading.Tasks.UniTask AnimateAsync(PRISM.Adapters.LiveResultRateRecordViewModel viewModel, System.Threading.CancellationToken ct);
    public void Clear();
    private void <AnimateAsync>b__9_0(float num);

    private struct <AnimateAsync>d__9 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Live.LiveResultRateRecordView <>4__this;
        public PRISM.Adapters.LiveResultRateRecordViewModel viewModel;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveResultRecordView : UnityEngine.MonoBehaviour, PRISM.Interactions.Live.ILiveResultScorePhasePanel<PRISM.Adapters.LiveResultRecordViewModel>
{
    private int digits;
    private UnityEngine.GameObject newRecordBadge;
    private ENTERPRISE.UI.UITextMeshProUGUI defaultText;
    private ENTERPRISE.UI.UITextMeshProUGUI defaultLeadingZeroText;
    private ENTERPRISE.UI.UITextMeshProUGUI newRecordText;
    private ENTERPRISE.UI.UITextMeshProUGUI newRecordLeadingZeroText;
    private ENTERPRISE.UI.UITextMeshProUGUI highRecordText;
    public void SetData(PRISM.Adapters.LiveResultRecordViewModel viewModel);
    public Cysharp.Threading.Tasks.UniTask AnimateAsync(PRISM.Adapters.LiveResultRecordViewModel viewModel, System.Threading.CancellationToken ct);
    public void Clear();

    private class <>c__DisplayClass8_0
    {
        public PRISM.Interactions.Live.LiveResultRecordView <>4__this;
        public PRISM.Adapters.LiveResultRecordViewModel viewModel;
        private void <AnimateAsync>b__0(float num);
        private void <AnimateAsync>b__1();
    }

    private struct <AnimateAsync>d__8 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Live.LiveResultRecordView <>4__this;
        public PRISM.Adapters.LiveResultRecordViewModel viewModel;
        public System.Threading.CancellationToken ct;
        private <>c__DisplayClass8_0 <>8__1;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveResultScorePhaseView : UnityEngine.MonoBehaviour, PRISM.Adapters.ILiveResultScorePhaseView
{
    private PRISM.Interactions.Live.LiveResultPhaseViewCore core;
    private PRISM.Live.MusicClearStatusLampView musicClearStatusLampView;
    private PRISM.Interactions.Live.LiveResultRecordView scoreRecordView;
    private PRISM.Interactions.Live.ScoreRankIcon scoreRankIcon;
    private PRISM.Interactions.Live.LiveResultRecordView comboRecordView;
    private PRISM.Interactions.ViewStateChanger clearTypeStateChanger;
    private UnityEngine.Animator comboRankAnimator;
    private PRISM.Interactions.Live.LiveResultRecordView technicalScoreRecordView;
    private PRISM.Interactions.Live.LiveResultJudgeCountView judgeCountView;
    private PRISM.Interactions.Live.LiveResultRateInfoView rateInfoView;
    private UnityEngine.GameObject autoLiveAnnotation;
    private PRISM.Interactions.ButtonView openRateOverlayButton;
    private PRISM.HowToPlayPopupOpener shinyEnabledHowToPlayPopupOpener;
    public PRISM.Adapters.ILiveResultPhaseViewCore Core { get; set; }
    public System.IObservable<UniRx.Unit> OnOpenRateOverlay { get; set; }
    public PRISM.HowToPlayPopupOpener ShinyEnabledHowToPlayPopupOpener { get; set; }
    public void Initialize(bool showShiny, UniRx.IReactiveProperty<bool> showJudgeDetail);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(PRISM.Adapters.LiveResultScorePhaseViewModel viewModel, PRISM.Definitions.SkippableCancellationToken ct);
    private void _showComboRank(ComboRank rank);

    private class <>c__DisplayClass20_0
    {
        public PRISM.Interactions.Live.LiveResultScorePhaseView <>4__this;
        public PRISM.Adapters.LiveResultScorePhaseViewModel viewModel;
        public PRISM.Definitions.SkippableCancellationToken ct;
        private Cysharp.Threading.Tasks.UniTask <ShowAsync>b__0();
    }

    private struct <ShowAsync>d__20 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Live.LiveResultScorePhaseView <>4__this;
        public PRISM.Adapters.LiveResultScorePhaseViewModel viewModel;
        public PRISM.Definitions.SkippableCancellationToken ct;
        private <>c__DisplayClass20_0 <>8__1;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Live
public class ScoreRankIcon : UnityEngine.MonoBehaviour
{
    private UnityEngine.Animator scoreRankAnimator;
    public void Show(ScoreRank rank);
    public void Hide();
}

// Namespace: PRISM.Interactions.Live
public class TechnicalChallengeLiveResultView : UnityEngine.MonoBehaviour, PRISM.Adapters.ITechnicalChallengeLiveResultView
{
    private PRISM.Interactions.ViewStateChanger difficultyStateChanger;
    private ENTERPRISE.UI.UITextMeshProUGUI levelText;
    private UnityEngine.UI.RawImage musicJacketIcon;
    private PRISM.Interactions.TechnicalChallengeUserInfoView userInfoView;
    private PRISM.Interactions.ButtonView shareButton;
    private PRISM.Interactions.ButtonView finishButton;
    private PRISM.Interactions.ButtonView skipButton;
    private PRISM.Interactions.Live.LiveResultRecordView comboRecordView;
    private PRISM.Interactions.ViewStateChanger clearTypeStateChanger;
    private PRISM.Interactions.TechnicalRankIcon tecRankIcon;
    private PRISM.Interactions.Live.LiveResultRecordView technicalScoreRecordView;
    private PRISM.Interactions.Live.LiveResultJudgeCountView judgeCountView;
    private UnityEngine.Animator[] animators;
    private PRISM.Adapters.TechnicalChallengeLiveResultViewModel viewModel;
    public System.IObservable<UniRx.Unit> OnShare { get; set; }
    public System.IObservable<UniRx.Unit> OnClose { get; set; }
    public System.IObservable<UniRx.Unit> OnSkip { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Adapters.TechnicalChallengeLiveResultViewModel viewModel, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask AnimateAsync(PRISM.Definitions.SkippableCancellationToken ct);

    private class <>c
    {
        public static <>c <>9;
        public static System.Action<string> <>9__20_0;
        private void <InitializeAsync>b__20_0(string cueName);
    }

    private struct <AnimateAsync>d__21 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Live.TechnicalChallengeLiveResultView <>4__this;
        public PRISM.Definitions.SkippableCancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <InitializeAsync>d__20 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Live.TechnicalChallengeLiveResultView <>4__this;
        public PRISM.Adapters.TechnicalChallengeLiveResultViewModel viewModel;
        public System.Threading.CancellationToken ct;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private Awaiter<CriWare.CriAtomExPlayback> <>u__1;
        private Awaiter <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Live
public class TechnicalChallengeLiveResultConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.TechnicalChallengeLiveResultArgument>, PRISM.Live.ITechnicalChallengeLiveResultConnector
{
    protected PRISM.Adapters.TechnicalChallengeLiveResultArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
}

// Namespace: PRISM.Interactions.Live
public class LiveResultUnitIdolView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ProduceIdolIconView iconView;
    private PRISM.Interactions.IdolBaseRewardGaugeView gaugeView;
    public Cysharp.Threading.Tasks.UniTask PrepareAsync(PRISM.Module.Networking.IProduceIdolStatus idol, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask AnimateAsync(PRISM.Adapters.IdolBaseRewardGaugeViewModel viewModel, float duration, System.Threading.CancellationToken cancellationToken);

    private struct <AnimateAsync>d__3 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Live.LiveResultUnitIdolView <>4__this;
        public PRISM.Adapters.IdolBaseRewardGaugeViewModel viewModel;
        public float duration;
        public System.Threading.CancellationToken cancellationToken;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveResultUnitPhaseView : UnityEngine.MonoBehaviour, PRISM.Adapters.ILiveResultUnitPhaseView
{
    private PRISM.Interactions.Live.LiveResultPhaseViewCore core;
    private PRISM.Interactions.Live.LiveResultLiveBoostView liveBoostView;
    private PRISM.Interactions.Live.LiveResultUnitIdolView[] idolViews;
    private PRISM.Interactions.Live.LiveGuestProfileView guestView;
    public PRISM.Adapters.ILiveResultPhaseViewCore Core { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Adapters.LiveResultUnitPhaseViewModel viewModel, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(PRISM.Adapters.LiveResultUnitPhaseViewModel viewModel, PRISM.Definitions.SkippableCancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask <ShowAsync>g__AnimateAsync|7_0(float duration, System.Threading.CancellationToken cancellationToken, <>c__DisplayClass7_0& );

    private class <>c__DisplayClass6_0
    {
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        private Cysharp.Threading.Tasks.UniTask <InitializeAsync>b__0(PRISM.Interactions.Live.LiveResultUnitIdolView view, System.ValueTuple<PRISM.Module.Networking.IProduceIdolStatus, PRISM.Adapters.IdolBaseRewardGaugeViewModel> idol);
    }

    private struct <>c__DisplayClass7_0 : System.ValueType
    {
        public PRISM.Interactions.Live.LiveResultUnitPhaseView <>4__this;
        public PRISM.Adapters.LiveResultUnitPhaseViewModel viewModel;
    }

    private class <>c__DisplayClass7_1
    {
        public float duration;
        public System.Threading.CancellationToken cancellationToken;
        private Cysharp.Threading.Tasks.UniTask <ShowAsync>b__1(PRISM.Interactions.Live.LiveResultUnitIdolView view, System.ValueTuple<PRISM.Module.Networking.IProduceIdolStatus, PRISM.Adapters.IdolBaseRewardGaugeViewModel> idol);
    }

    private struct <ShowAsync>d__7 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Live.LiveResultUnitPhaseView <>4__this;
        public PRISM.Adapters.LiveResultUnitPhaseViewModel viewModel;
        public PRISM.Definitions.SkippableCancellationToken ct;
        private <>c__DisplayClass7_0 <>8__1;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveAutoLoopView : UnityEngine.MonoBehaviour, PRISM.Adapters.ILiveAutoLoopView, PRISM.Adapters.IRhythmGameSpecialView
{
    private ENTERPRISE.UI.UITextMeshProUGUI loopCountText;
    private PRISM.Interactions.ToggleButtonView isFinishThisTimeToggle;
    public void Initialize(PRISM.Live.ILiveAutoLoopViewModel viewModel, int loopCount);

    private class <>c__DisplayClass2_0
    {
        public PRISM.Live.ILiveAutoLoopViewModel viewModel;
        private void <Initialize>b__0(bool x);
    }
}

// Namespace: PRISM.Interactions.Live
public class RhythmGameJudgeCountView : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI[] texts;
    private int[] counts;
    public void Initialize(bool isShinyEnabled);
    public void AddJudge(PRISM.RhythmGame.JudgmentResultType judgmentResultType);
}

// Namespace: PRISM.Interactions.Live
public class RhythmGameTechnicalChallengeView : UnityEngine.MonoBehaviour, PRISM.Adapters.IRhythmGameTechnicalChallengeView, PRISM.Adapters.IRhythmGameSpecialView
{
    private PRISM.Interactions.ViewStateChanger technicalChallengeStateChanger;
    private UnityEngine.UI.RawImage jacketImage;
    private PRISM.Interactions.ViewStateChanger difficultyStateChanger;
    private ENTERPRISE.UI.UITextMeshProUGUI[] retryCountTexts;
    private PRISM.Interactions.ButtonView[] howToPlayButtons;
    private PRISM.HowToPlayPopupOpener howToPlayPopupOpener;
    private PRISM.Interactions.ButtonView startButton;
    private ENTERPRISE.UI.AnimatorWithEvent animator;
    private PRISM.Interactions.Live.RhythmGameJudgeCountView judgeCountView;
    private ENTERPRISE.UI.UIButton retryButton;
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Definitions.MstSong song, SongDifficultyLevel difficulty, int remainRetryCount, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask StartAsync(System.Threading.CancellationToken ct);
    public void AddJudge(PRISM.RhythmGame.JudgmentResultType judgmentResultType);

    private class <>c
    {
        public static <>c <>9;
        public static System.Action<string> <>9__11_0;
        private void <StartAsync>b__11_0(string cueName);
    }

    private class <>c__DisplayClass10_0
    {
        public PRISM.Interactions.Live.RhythmGameTechnicalChallengeView <>4__this;
        public System.Threading.CancellationToken ct;
        public System.Action<UniRx.Unit> <>9__0;
        private void <InitializeAsync>b__0(UniRx.Unit _);
    }

    private struct <StartAsync>d__11 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Live.RhythmGameTechnicalChallengeView <>4__this;
        public System.Threading.CancellationToken ct;
        private System.IDisposable <_>5__2;
        private Awaiter<UniRx.Unit> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveUnitEditCarousel : PRISM.Carousel<PRISM.Live.LiveUnit, PRISM.Interactions.Live.LiveUnitEditCarouselContext>, PRISM.Adapters.ILiveUnitEditCarousel
{
    private PRISM.Interactions.SwipeAndArrowChangerView changerView;
    private UnityEngine.GameObject summerCellPrefab;
    private UnityEngine.GameObject blocker;
    protected UnityEngine.GameObject CellPrefab { get; set; }
    public void Initialize(PRISM.Adapters.LiveUnitEditCarouselViewModel viewModel, System.Collections.Generic.IList<PRISM.Live.LiveUnit> unitList, UniRx.IReadOnlyReactiveProperty<int> selectedIndex);
    public void Select(int index);
    private System.IObservable<int> PRISM.Adapters.ILiveUnitEditCarousel.get_OnSelectionChanged();
    private void <Initialize>b__5_0(UniRx.Pair<int> pair);
    private void <Initialize>b__5_1(int i);
    private void <Initialize>b__5_3();
    private void <Initialize>b__5_2(bool draggable);
}

// Namespace: PRISM.Interactions.Live
public class LiveUnitEditCarouselCell : PRISM.CarouselCell<PRISM.Live.LiveUnit, PRISM.Interactions.Live.LiveUnitEditCarouselContext>
{
    private PRISM.Interactions.Live.LiveUnitEditCarouselIdolView idolView;
    private PRISM.Interactions.Live.LiveUnitEditCarouselSupportMemberView supportMemberView;
    private PRISM.Interactions.Live.LiveUnitEditCarouselGuestView guestView;
    private PRISM.Live.LiveUnit liveUnit;
    public void Initialize();
    private void _initializeDragHandler(PRISM.Live.DragHandler dragHandler);
    public void UpdateContent(PRISM.Live.LiveUnit unit);
    private Cysharp.Threading.Tasks.UniTask <Initialize>b__4_0(int fromIndex, int toIndex);
    private Cysharp.Threading.Tasks.UniTask <Initialize>b__4_1(int fromIndex, int toIndex);
    private bool <_initializeDragHandler>b__5_0();
    private void <_initializeDragHandler>b__5_1(bool draggable);
}

// Namespace: PRISM.Interactions.Live
public class LiveUnitEditCarouselCharacterIcon : UnityEngine.MonoBehaviour, PRISM.Live.IDraggable
{
    private PRISM.Interactions.Live.LiveUnitEditCarouselIconCommon common;
    private PRISM.Interactions.ProduceIdolIconView iconView;
    private PRISM.Interactions.Live.LiveProduceIdolBonusIconView bonusIconView;
    private UnityEngine.GameObject dragTargetObject;
    private PRISM.Interactions.ViewStateChanger statusDisplayTypeState;
    private ENTERPRISE.UI.UITextMeshProUGUI totalParameterText;
    private ENTERPRISE.UI.UITextMeshProUGUI unitBonusText;
    private ENTERPRISE.UI.UITextMeshProUGUI attributeBonusText;
    private ENTERPRISE.UI.UITextMeshProUGUI liveSkillText;
    private ENTERPRISE.UI.UITextMeshProUGUI centerEffectText;
    private ENTERPRISE.UI.UITextMeshProUGUI produceIdolLevelText;
    private UnityEngine.UI.Image produceIdolLevelGauge;
    private PRISM.Interactions.ViewStateChanger produceIdolLevelMaxState;
    private PRISM.Interactions.ViewStateChanger produceIdolLevelLimitState;
    public PRISM.Interactions.Live.LiveUnitEditCarouselIconCommon Common { get; set; }
    public UnityEngine.GameObject DragTargetObject { get; set; }
    public void Setup(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Live.LiveIdol idol, PRISM.Live.MusicData musicData, UniRx.IReadOnlyReactiveProperty<PRISM.Live.LiveUnitConfirmationStatusDisplayType> idolStatusDisplayType, System.Threading.CancellationToken ct);
    public UnityEngine.GameObject BeginDrag(UnityEngine.Transform parent);
    public void EndDrag();
    private void <Setup>b__18_0(PRISM.Live.LiveUnitConfirmationStatusDisplayType type);
}

// Namespace: PRISM.Interactions.Live
public class LiveUnitEditCarouselContext : PRISM.DefaultCarouselContext
{
    private System.Action<bool> <SetCarouselDraggable>k__BackingField;
    private PRISM.Adapters.LiveUnitEditCarouselViewModel <ViewModel>k__BackingField;
    public System.Action<bool> SetCarouselDraggable { get; set; }
    public PRISM.Adapters.LiveUnitEditCarouselViewModel ViewModel { get; set; }
}

// Namespace: PRISM.Interactions.Live
public class LiveUnitEditCarouselGuestView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.Live.LiveGuestProfileView profileView;
    private PRISM.Interactions.ButtonView buttonView;
    private PRISM.Interactions.ButtonView iconButton;
    private ENTERPRISE.UI.UITextMeshProUGUI centerEffectNameText;
    private ENTERPRISE.UI.UITextMeshProUGUI centerEffectDescriptionText;
    private PRISM.Adapters.LiveUnitEditCarouselViewModel context;
    private PRISM.Live.LiveUnit unit;
    private PRISM.AutoCancellationTokenSource canceller;
    public void Initialize(PRISM.Adapters.LiveUnitEditCarouselViewModel context);
    public void UpdateContent(PRISM.Live.LiveUnit unit);
    private Cysharp.Threading.Tasks.UniTaskVoid _renderAsync();

    private class <>c__DisplayClass8_0
    {
        public PRISM.Interactions.Live.LiveUnitEditCarouselGuestView <>4__this;
        public PRISM.Adapters.LiveUnitEditCarouselViewModel context;
        private void <Initialize>b__0(PRISM.Live.LiveUnitConfirmationUnitEditTabType type);
        private void <Initialize>b__1(UniRx.Unit _);
    }

    private struct <_renderAsync>d__10 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
        public PRISM.Interactions.Live.LiveUnitEditCarouselGuestView <>4__this;
        private System.Threading.CancellationToken <ct>5__2;
        private Awaiter<PRISM.Module.Networking.ILiveGuestProfileStatus> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveUnitEditCarouselIdolView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.Live.LiveUnitEditCarouselCharacterIcon[] idolIcons;
    private PRISM.Interactions.ViewStateChanger[] skillOrderStateChangers;
    private PRISM.AutoCancellationTokenSource idolIconCanceller;
    private PRISM.Adapters.LiveUnitEditCarouselViewModel context;
    public void Initialize(PRISM.Adapters.LiveUnitEditCarouselViewModel context);
    public void UpdateContent(PRISM.Live.LiveUnit unit);
    public PRISM.Live.DragHandler CreateDragHandler();
    private void OnDestroy();
    private void <Initialize>b__4_0(PRISM.Live.LiveCameraModeSetting setting);
    private void <Initialize>b__4_1(PRISM.Live.LiveUnitConfirmationUnitEditTabType type);
    private void <Initialize>b__4_2(PRISM.Live.LiveUnitConfirmationStatusDisplayType type);

    private class <>c
    {
        public static <>c <>9;
        public static System.Action<PRISM.Interactions.ViewStateChanger, int> <>9__5_0;
        private void <UpdateContent>b__5_0(PRISM.Interactions.ViewStateChanger changer, int state);
    }

    private class <>c__DisplayClass5_0
    {
        public PRISM.Interactions.Live.LiveUnitEditCarouselIdolView <>4__this;
        public PRISM.Live.LiveUnit unit;
    }

    private class <>c__DisplayClass5_1
    {
        public PRISM.Interactions.Live.LiveUnitEditCarouselCharacterIcon icon;
        public PRISM.Live.LiveIdol idol;
        public int reservedI;
        public <>c__DisplayClass5_0 CS$<>8__locals1;
        private void <UpdateContent>b__1(bool isOn);
        private void <UpdateContent>b__2(PRISM.Adapters.LiveUnitEditCarouselClickEventType type);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveUnitEditCarouselSupportCell : UnityEngine.MonoBehaviour, PRISM.Live.IDraggable
{
    private PRISM.Interactions.Live.LiveSupportCharacterView characterView;
    private PRISM.Interactions.ButtonView buttonView;
    private UnityEngine.GameObject dragTargetObject;
    private UnityEngine.GameObject dragMark;
    private PRISM.UIGrayOutController grayOutController;
    public PRISM.Interactions.Live.LiveSupportCharacterView CharacterView { get; set; }
    public UnityEngine.GameObject DragTargetObject { get; set; }
    public System.IObservable<UniRx.Unit> OnClickSupportIcon { get; set; }
    public UnityEngine.GameObject BeginDrag(UnityEngine.Transform parent);
    public void EndDrag();
    private void _setDragStatus(bool isInDrag);
}

// Namespace: PRISM.Interactions.Live
public class LiveUnitEditCarouselSupportMemberView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.Live.LiveUnitEditCarouselSupportCell[] cells;
    private PRISM.AutoCancellationTokenSource idolIconCanceller;
    private PRISM.Adapters.LiveUnitEditCarouselViewModel context;
    public void Initialize(PRISM.Adapters.LiveUnitEditCarouselViewModel context);
    public void UpdateContent(PRISM.Live.LiveUnit unit);
    public PRISM.Live.DragHandler CreateDragHandler();
    private void OnDestroy();
    private void <Initialize>b__3_0(PRISM.Live.LiveUnitConfirmationUnitEditTabType type);
    private void <Initialize>b__3_1(PRISM.Live.LiveSupportSelectionDisplayMode type);

    private class <>c__DisplayClass4_0
    {
        public PRISM.Interactions.Live.LiveUnitEditCarouselSupportMemberView <>4__this;
        public PRISM.Live.LiveUnit unit;
    }

    private class <>c__DisplayClass4_1
    {
        public LiveUnitSupportMemberType supportType;
        public <>c__DisplayClass4_0 CS$<>8__locals1;
        private void <UpdateContent>b__0(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveBoostUsageButton : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView button;
    private ENTERPRISE.UI.UITextMeshProUGUI countText;
    private PRISM.Interactions.ViewStateChanger countTextState;
    private ENTERPRISE.UI.UITextMeshProUGUI overrideMaxUsageCountText;
    public System.IObservable<UniRx.Unit> OnClick { get; set; }
    public void UpdateView(PRISM.Live.NormalLiveLiveBoostUsageSettingStatus status);
}

// Namespace: PRISM.Interactions.Live
public class LiveStartButton : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView button;
    private PRISM.Interactions.ViewStateChanger enableStateChanger;
    private ENTERPRISE.UI.UITextMeshProUGUI labelText;
    private PRISM.UIGrayOutController grayOutController;
    public System.IObservable<UniRx.Unit> OnClick { get; set; }
    public void UpdateView(int remainingCount);
    public void SetGrayOut(bool isGrayOut);
}

// Namespace: PRISM.Interactions.Live
public class LiveUnitConfirmationButtonsView : UnityEngine.MonoBehaviour, PRISM.Adapters.ILiveUnitConfirmationButtonsView
{
    private PRISM.Interactions.Live.LiveBoostUsageButton liveBoostUsageButton;
    private PRISM.Interactions.Live.LiveStartButton autoLiveButton;
    private PRISM.Interactions.Live.LiveStartButton skipLiveButton;
    private PRISM.Interactions.Live.LiveStartButton startButton;
    private UnityEngine.GameObject seasonPassBalloon;
    public System.IObservable<UniRx.Unit> OnClickLiveBoost { get; set; }
    public System.IObservable<UniRx.Unit> OnClickAuto { get; set; }
    public System.IObservable<UniRx.Unit> OnClickSkip { get; set; }
    public System.IObservable<UniRx.Unit> OnClickStart { get; set; }
    public void Initialize();
    public void UpdateView(PRISM.Adapters.LiveUnitConfirmationButtonsViewModel viewModel);
    public void SetGrayOut(bool isGrayOut);
}

// Namespace: PRISM.Interactions.Live
public class LiveUnitConfirmationConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.LiveUnitConfirmationArgument>, PRISM.Adapters.ILiveUnitConfirmationConnector
{
    private PRISM.Live.MusicData musicData;
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
    protected PRISM.Adapters.LiveUnitConfirmationArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
}

// Namespace: PRISM.Interactions.Live
public class LiveUnitConfirmationStatusView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.CountToggleButtonView statusDisplayTypeToggleButton;
    private PRISM.Interactions.ViewStateChanger statusDisplayTypeState;
    private PRISM.Interactions.ButtonView skillSettingButton;
    private PRISM.Interactions.CountToggleButtonView supportStatusDisplayTypeToggleButton;
    private ENTERPRISE.UI.UITextMeshProUGUI centerEffectTitleText;
    private ENTERPRISE.UI.UITextMeshProUGUI centerEffectDescriptionText1;
    private ENTERPRISE.UI.UITextMeshProUGUI centerEffectDescriptionText2;
    private PRISM.Interactions.ButtonView showCenterEffectBalloonButton;
    private PRISM.Interactions.ButtonView hideCenterEffectBalloonButton;
    private PRISM.Interactions.ButtonView parameterDetailButton;
    private ENTERPRISE.UI.UITextMeshProUGUI parameterDetailText;
    private ENTERPRISE.UI.UITextMeshProUGUI supportBonusText;
    private PRISM.Interactions.ViewStateChanger supportTabBadge;
    private ENTERPRISE.UI.UITextMeshProUGUI guestBonusValueText;
    private PRISM.Interactions.ViewStateChanger guestTabBadge;
    public System.IObservable<UniRx.Unit> OnOpenParameterDetail { get; set; }
    public System.IObservable<UniRx.Unit> OnOpenSkillSetting { get; set; }
    public void Initialize(PRISM.Adapters.LiveUnitConfirmationViewModel viewModel);
    private void <Initialize>b__19_0(PRISM.Live.LiveUnitConfirmationStatusDisplayType type);
    private void <Initialize>b__19_1(UniRx.Unit _);
    private void <Initialize>b__19_2(UniRx.Unit _);
    private void <Initialize>b__19_3(PRISM.Live.ILiveUnit iUnit);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Live.LiveIdol, int> <>9__19_4;
        private int <Initialize>b__19_4(PRISM.Live.LiveIdol x);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveUnitConfirmationView : UnityEngine.MonoBehaviour, PRISM.Adapters.ILiveUnitConfirmationView
{
    private PRISM.Interactions.ButtonView globalMenuButton;
    private PRISM.Interactions.Live.LiveUnitConfirmationCommonView commonView;
    private PRISM.Interactions.ViewStateChanger summerState;
    private PRISM.Interactions.ButtonView eventButton;
    private PRISM.Interactions.ButtonView technicalChallengeButton;
    private PRISM.Interactions.StaminaView liveBoostView;
    private PRISM.Interactions.ButtonView liveStageDetailButton;
    private PRISM.Interactions.Live.LiveUnitEditCarousel unitCarousel;
    private PRISM.Interactions.ToggleGroupView unitTab;
    private PRISM.Interactions.Live.LiveUnitListWindow unitListWindow;
    private PRISM.Interactions.Live.LiveUnitConfirmationStatusView statusView;
    private PRISM.Interactions.ButtonView optionButton;
    private PRISM.Interactions.Live.LiveUnitConfirmationButtonsView buttonsView;
    public PRISM.Adapters.ILiveUnitConfirmationCommonView CommonView { get; set; }
    public PRISM.Adapters.IStaminaView LiveBoostView { get; set; }
    public PRISM.Adapters.ILiveUnitEditCarousel UnitListView { get; set; }
    public PRISM.Adapters.ILiveUnitListWindow UnitListWindow { get; set; }
    public PRISM.Adapters.ILiveUnitConfirmationButtonsView ButtonsView { get; set; }
    public System.IObservable<UniRx.Unit> OnJumpEvent { get; set; }
    public System.IObservable<UniRx.Unit> OnJumpTechnicalChallenge { get; set; }
    public System.IObservable<UniRx.Unit> OnOpenLiveStageDetail { get; set; }
    public System.IObservable<UniRx.Unit> OnOpenParameterDetail { get; set; }
    public System.IObservable<UniRx.Unit> OnOpenSkillSetting { get; set; }
    public System.IObservable<UniRx.Unit> OnOpenOption { get; set; }
    public System.IObservable<UniRx.Unit> OnOpenGlobalMenu { get; set; }
    public void Initialize(PRISM.Adapters.LiveUnitConfirmationViewModel viewModel);
}

// Namespace: PRISM.Interactions.Live
public class LiveUnitListCell : PRISM.CommonListViewCell<PRISM.Live.LiveUnit, PRISM.Interactions.Live.LiveUnitListCellContext>
{
    private PRISM.Interactions.Live.LiveUnitListCellView cellView;
    private PRISM.AutoCancellationTokenSource canceller;
    public void Initialize();
    public void UpdateContent(PRISM.Live.LiveUnit unit);
    private void OnDestroy();
    private void <Initialize>b__2_0(UniRx.Unit _);
    private void <Initialize>b__2_1(UniRx.Unit _);
    private void <Initialize>b__2_2(string unitName);
}

// Namespace: PRISM.Interactions.Live
public class LiveUnitListCellView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.Live.LiveUnitListCellCommonView commonView;
    private ENTERPRISE.UI.UITextMeshProUGUI totalParameterText;
    private PRISM.Interactions.Live.LiveUnitListCharacterIcon[] characterIcons;
    private PRISM.Interactions.Live.LiveUnitListSupportCharacterView[] supportCharacterViews;
    private PRISM.Interactions.ProduceIdolIconView guestIdolIcon;
    private PRISM.Interactions.ButtonView guestIdolButton;
    private System.IDisposable disposable;
    public PRISM.Interactions.Live.LiveUnitListCellCommonView CommonView { get; set; }
    public void Show(PRISM.Live.LiveUnit unit, PRISM.Live.MusicData musicData, bool isUseCopy, bool showCopyButton, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask _updateGuestAsync(PRISM.Live.LiveUnit unit, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken cancellationToken);

    private class <>c__DisplayClass10_0
    {
        public PRISM.Module.Networking.ILiveGuestProfileStatus guest;
        public System.Threading.CancellationToken cancellationToken;
        private void <_updateGuestAsync>b__0(UniRx.Unit _);
    }

    private struct <_updateGuestAsync>d__10 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public System.Threading.CancellationToken cancellationToken;
        public PRISM.Interactions.Live.LiveUnitListCellView <>4__this;
        public PRISM.Live.LiveUnit unit;
        private <>c__DisplayClass10_0 <>8__1;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private Awaiter<PRISM.Module.Networking.ILiveGuestProfileStatus> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveUnitListCharacterIcon : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ProduceIdolIconView iconView;
    private PRISM.Interactions.Live.LiveProduceIdolBonusIconView bonusIconView;
    private ENTERPRISE.UI.UITextMeshProUGUI statusText;
    private UnityEngine.GameObject statusObject;
    private PRISM.Interactions.ButtonView iconButton;
    private UnityEngine.GameObject skillOrderObject;
    private PRISM.Interactions.ViewStateChanger skillOrderView;
    private System.IDisposable disposable;
    public Cysharp.Threading.Tasks.UniTask SetUpAsync(PRISM.Live.LiveIdol idol, PRISM.Live.MusicData musicData, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);

    private class <>c__DisplayClass8_0
    {
        public PRISM.Live.LiveIdol idol;
        public System.Threading.CancellationToken ct;
        private void <SetUpAsync>b__0(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveUnitListSupportCharacterView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.SupportCharacterIconView idolIconView;
    private ENTERPRISE.UI.UITextMeshProUGUI totalText;
    private UnityEngine.GameObject statusObject;
    private PRISM.Interactions.ButtonView iconButton;
    private System.IDisposable disposable;
    public void Show(PRISM.Live.LiveSupportCharacterViewModel itemData, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);

    private class <>c__DisplayClass5_0
    {
        public PRISM.Live.LiveSupportCharacterViewModel itemData;
        public System.Threading.CancellationToken ct;
        private void <Show>b__0(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveUnitListView : PRISM.CommonListView<PRISM.Interactions.Live.LiveUnitListCell, PRISM.Live.LiveUnit, PRISM.Interactions.Live.LiveUnitListCellContext>
{
    public System.Action<int> OnMoveToClicked { get; set; }
    public System.Action<int> OnCopyToClicked { get; set; }
    public System.Action<int> OnCopyFromClicked { get; set; }
    public System.Action<System.ValueTuple<int, string>> OnChangeUnitName { get; set; }
    public bool IsSelectSpecialUnit { get; set; }
    public bool IsSelectEmptyUnit { get; set; }
    public void SetMusicData(PRISM.Live.MusicData musicData);
}

// Namespace: PRISM.Interactions.Live
public class LiveUnitListCellContext : PRISM.CommonListViewContext
{
    private PRISM.Live.MusicData <MusicData>k__BackingField;
    private System.Action<int> <OnMoveToClicked>k__BackingField;
    private System.Action<int> <OnCopyToClicked>k__BackingField;
    private System.Action<int> <OnCopyFromClicked>k__BackingField;
    private System.Action<System.ValueTuple<int, string>> <OnChangeUnitName>k__BackingField;
    private bool <IsSelectSpecialUnit>k__BackingField;
    private bool <IsSelectEmptyUnit>k__BackingField;
    public PRISM.Live.MusicData MusicData { get; set; }
    public System.Action<int> OnMoveToClicked { get; set; }
    public System.Action<int> OnCopyToClicked { get; set; }
    public System.Action<int> OnCopyFromClicked { get; set; }
    public System.Action<System.ValueTuple<int, string>> OnChangeUnitName { get; set; }
    public bool IsSelectSpecialUnit { get; set; }
    public bool IsSelectEmptyUnit { get; set; }
}

// Namespace: PRISM.Interactions.Live
public class LiveUnitListWindow : ENTERPRISE.UI.SlideWindowBase, PRISM.Adapters.ILiveUnitListWindow, System.IDisposable
{
    private PRISM.Interactions.ButtonView hideButton;
    private PRISM.Interactions.Live.LiveUnitListView listView;
    private PRISM.Interactions.Live.LiveUnitListCellView currentUnitCell;
    private UniRx.Subject<int> onMoveToClicked;
    private UniRx.Subject<System.ValueTuple<PRISM.Adapters.LiveUnitEditFunction, int>> onEditClicked;
    private UniRx.Subject<System.ValueTuple<int, string>> onChangeUnitName;
    private PRISM.Live.MusicData musicData;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    public System.IObservable<int> OnMoveToClicked { get; set; }
    public System.IObservable<System.ValueTuple<PRISM.Adapters.LiveUnitEditFunction, int>> OnEditClicked { get; set; }
    public System.IObservable<System.ValueTuple<int, string>> OnChangeUnitName { get; set; }
    public System.IObservable<string> OnChangeCurrentUnitName { get; set; }
    protected System.IObservable<UniRx.Unit> OnHideRequested { get; set; }
    public void Initialize(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Live.MusicData musicData);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Collections.Generic.IList<PRISM.Live.LiveUnit> units, int selectedIndex, System.Threading.CancellationToken cancellationToken);
    public void UpdateUnit(System.Collections.Generic.IList<PRISM.Live.LiveUnit> units, int selectedIndex, System.Threading.CancellationToken cancellationToken);
    public void Dispose();
    private void <Initialize>b__18_0(int index);
    private void <Initialize>b__18_1(int index);
    private void <Initialize>b__18_2(int index);
    private void <Initialize>b__18_3(System.ValueTuple<int, string> value);
}

// Namespace: PRISM.Interactions.Live
public class LiveUnitConfirmationCommonView : UnityEngine.MonoBehaviour, PRISM.Adapters.ILiveUnitConfirmationCommonView
{
    private UnityEngine.UI.RawImage backgroundImage;
    private PRISM.Interactions.MusicBasicInfoView musicBasicInfoView;
    private PRISM.Interactions.ButtonView cameraSettingButton;
    private PRISM.Interactions.ViewStateChanger cameraSettingEnabledState;
    private PRISM.Interactions.Live.VocalSeparateToggleView vocalSeparateToggleView;
    private PRISM.Interactions.Live.LiveUnitConfirmationUnitCommonView unitView;
    private UnityEngine.GameObject unitAllMemberChangeEffect;
    private PRISM.Interactions.ButtonView liveBackgroundModeToggle;
    private PRISM.Interactions.ViewStateChanger liveBackgroundModeButtonState;
    public PRISM.Adapters.IVocalSeparateToggleView VocalSeparateToggleView { get; set; }
    public PRISM.Adapters.ILiveUnitConfirmationUnitCommonView UnitView { get; set; }
    public System.IObservable<UniRx.Unit> OnClickCameraModeSetting { get; set; }
    public System.IObservable<UniRx.Unit> OnClickBackgroundToggle { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Live.MusicData musicData, SongDifficultyLevel difficulty, UniRx.IReadOnlyReactiveProperty<PRISM.Live.LiveCameraModeSetting> cameraModeSetting, UniRx.IReadOnlyReactiveProperty<PRISM.RhythmGame.LiveBackgroundMode> backgroundMode, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public void PlayMemberChangeEffect();
    private void <InitializeAsync>b__17_0(PRISM.Live.LiveCameraModeSetting setting);
    private void <InitializeAsync>b__17_1(PRISM.RhythmGame.LiveBackgroundMode mode);
}

// Namespace: PRISM.Interactions.Live
public class LiveUnitConfirmationUnitCommonView : UnityEngine.MonoBehaviour, PRISM.Adapters.ILiveUnitConfirmationUnitCommonView
{
    private PRISM.Interactions.ViewStateChanger unitBackgroundState;
    private PRISM.Interactions.ButtonView openUnitListButton;
    private ENTERPRISE.UI.UITextMeshProUGUI unitNumberText;
    private PRISM.CommonInputFieldTMP unitNameInputField;
    private PRISM.Interactions.ButtonView recommendButton;
    private PRISM.Interactions.ButtonView resetButton;
    private PRISM.Interactions.ButtonView easyCostumeChangeButton;
    public System.IObservable<UniRx.Unit> OnOpenUnitList { get; set; }
    public System.IObservable<string> OnChangeUnitName { get; set; }
    public System.IObservable<UniRx.Unit> OnRecommend { get; set; }
    public System.IObservable<UniRx.Unit> OnReset { get; set; }
    public System.IObservable<UniRx.Unit> OnEasyCostumeChange { get; set; }
    public void Initialize(UniRx.IReadOnlyReactiveProperty<PRISM.Live.ILiveUnit> currentUnit);
    public void UpdateUnitName(string text);
    private void <Initialize>b__17_0(PRISM.Live.ILiveUnit unit);
}

// Namespace: PRISM.Interactions.Live
public class LiveUnitEditCarouselIconCommon : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ViewStateChanger positionMarkState;
    private PRISM.Interactions.ButtonView emptyButton;
    private PRISM.Interactions.ButtonView button;
    private UnityEngine.GameObject dragMark;
    private PRISM.UIGrayOutController grayOutController;
    private UnityEngine.GameObject focusMark;
    private PRISM.Interactions.ViewStateChanger limitedVocalSeparateState;
    private PRISM.Interactions.CostumeSetIconView costumeSetIconView;
    private UnityEngine.Animations.ScaleConstraint scaleConstraint;
    public System.IObservable<PRISM.Adapters.LiveUnitEditCarouselClickEventType> OnClick { get; set; }
    public System.IObservable<PRISM.Adapters.LiveUnitEditCarouselClickEventType> OnClickMv { get; set; }
    public void Setup(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Live.IIdol idol, PRISM.Live.LiveIdolPositionMark positionMark, bool isEnableLimitedVocalSeparate, System.Threading.CancellationToken ct);
    public void SetFocusMarkActive(bool active);
    public void SetLimitedVocalSeparateActive(bool active);
    public void SetCostumeSetIconActive(bool active);
    public void SetDragStatus(bool isInDrag);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<UniRx.Unit, PRISM.Adapters.LiveUnitEditCarouselClickEventType> <>9__10_0;
        public static System.Func<UniRx.Unit, PRISM.Adapters.LiveUnitEditCarouselClickEventType> <>9__10_1;
        public static System.Func<UniRx.Unit, PRISM.Adapters.LiveUnitEditCarouselClickEventType> <>9__10_2;
        public static System.Func<PRISM.Definitions.CostumePartType, PRISM.Adapters.LiveUnitEditCarouselClickEventType> <>9__10_3;
        public static System.Func<UniRx.Unit, PRISM.Adapters.LiveUnitEditCarouselClickEventType> <>9__12_0;
        public static System.Func<UniRx.Unit, PRISM.Adapters.LiveUnitEditCarouselClickEventType> <>9__12_1;
        public static System.Func<PRISM.Definitions.CostumePartType, PRISM.Adapters.LiveUnitEditCarouselClickEventType> <>9__12_2;
        private PRISM.Adapters.LiveUnitEditCarouselClickEventType <get_OnClick>b__10_0(UniRx.Unit _);
        private PRISM.Adapters.LiveUnitEditCarouselClickEventType <get_OnClick>b__10_1(UniRx.Unit _);
        private PRISM.Adapters.LiveUnitEditCarouselClickEventType <get_OnClick>b__10_2(UniRx.Unit _);
        private PRISM.Adapters.LiveUnitEditCarouselClickEventType <get_OnClick>b__10_3(PRISM.Definitions.CostumePartType category);
        private PRISM.Adapters.LiveUnitEditCarouselClickEventType <get_OnClickMv>b__12_0(UniRx.Unit _);
        private PRISM.Adapters.LiveUnitEditCarouselClickEventType <get_OnClickMv>b__12_1(UniRx.Unit _);
        private PRISM.Adapters.LiveUnitEditCarouselClickEventType <get_OnClickMv>b__12_2(PRISM.Definitions.CostumePartType category);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveUnitListCellCommonView : UnityEngine.MonoBehaviour
{
    protected UnityEngine.GameObject defaultBackground;
    protected UnityEngine.GameObject specialBackground;
    protected ENTERPRISE.UI.UITextMeshProUGUI unitNumber;
    protected PRISM.CommonInputFieldTMP unitNameInputField;
    private PRISM.Interactions.ButtonView moveToButton;
    private PRISM.Interactions.ButtonView copyToButton;
    public System.IObservable<string> OnChangeUnitName { get; set; }
    public System.IObservable<UniRx.Unit> OnClickMoveToButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickCopyToButton { get; set; }
    public void UpdateContent(PRISM.Live.ILiveUnit unit, bool isUseCopy, bool showCopyButton);
}

// Namespace: PRISM.Interactions.Live
public class LiveMvUnitEditCarousel : PRISM.Carousel<PRISM.Live.LiveMVUnit, PRISM.Interactions.Live.LiveMvUnitEditCarouselContext>, PRISM.Adapters.ILiveMvUnitEditCarousel
{
    private PRISM.Interactions.SwipeAndArrowChangerView changerView;
    private UnityEngine.GameObject summerCellPrefab;
    private UnityEngine.GameObject blocker;
    protected UnityEngine.GameObject CellPrefab { get; set; }
    public void Initialize(PRISM.Adapters.LiveMvUnitEditCarouselViewModel viewModel, System.Collections.Generic.IList<PRISM.Live.LiveMVUnit> unitList, UniRx.IReadOnlyReactiveProperty<int> selectedIndex);
    public void Select(int index);
    private System.IObservable<int> PRISM.Adapters.ILiveMvUnitEditCarousel.get_OnSelectionChanged();
    private void <Initialize>b__5_0(UniRx.Pair<int> pair);
    private void <Initialize>b__5_1(int i);
    private void <Initialize>b__5_3();
    private void <Initialize>b__5_2(bool draggable);
}

// Namespace: PRISM.Interactions.Live
public class LiveMvUnitEditCarouselCell : PRISM.CarouselCell<PRISM.Live.LiveMVUnit, PRISM.Interactions.Live.LiveMvUnitEditCarouselContext>
{
    private PRISM.Interactions.Live.LiveMvUnitEditCarouselIdolView idolView;
    private PRISM.Live.LiveMVUnit unit;
    public void Initialize();
    public void UpdateContent(PRISM.Live.LiveMVUnit unit);
    private bool <Initialize>b__2_0();
    private void <Initialize>b__2_1(bool draggable);
    private Cysharp.Threading.Tasks.UniTask <Initialize>b__2_2(int fromIndex, int toIndex);
}

// Namespace: PRISM.Interactions.Live
public class LiveMvUnitEditCarouselCharacterIcon : UnityEngine.MonoBehaviour, PRISM.Live.IDraggable
{
    private PRISM.Interactions.Live.LiveUnitEditCarouselIconCommon common;
    private PRISM.Interactions.CharacterBaseIconView iconView;
    public PRISM.Interactions.Live.LiveUnitEditCarouselIconCommon Common { get; set; }
    public UnityEngine.GameObject DragTargetObject { get; set; }
    public void Setup(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Live.LiveMVIdol idol, System.Threading.CancellationToken ct);
    public UnityEngine.GameObject BeginDrag(UnityEngine.Transform parent);
    public void EndDrag();
}

// Namespace: PRISM.Interactions.Live
public class LiveMvUnitEditCarouselContext : PRISM.DefaultCarouselContext
{
    private System.Action<bool> <SetCarouselDraggable>k__BackingField;
    private PRISM.Adapters.LiveMvUnitEditCarouselViewModel <ViewModel>k__BackingField;
    public System.Action<bool> SetCarouselDraggable { get; set; }
    public PRISM.Adapters.LiveMvUnitEditCarouselViewModel ViewModel { get; set; }
}

// Namespace: PRISM.Interactions.Live
public class LiveMvUnitEditCarouselIdolView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.Live.LiveMvUnitEditCarouselCharacterIcon[] idolIcons;
    private PRISM.AutoCancellationTokenSource idolIconCanceller;
    private PRISM.Adapters.LiveMvUnitEditCarouselViewModel context;
    public void Initialize(PRISM.Adapters.LiveMvUnitEditCarouselViewModel context);
    public void UpdateContent(PRISM.Live.LiveMVUnit unit);
    public PRISM.Live.DragHandler CreateDragHandler();
    private void OnDestroy();
    private void <Initialize>b__3_0(PRISM.Live.LiveCameraModeSetting setting);

    private class <>c__DisplayClass4_0
    {
        public PRISM.Interactions.Live.LiveMvUnitEditCarouselIdolView <>4__this;
        public PRISM.Live.LiveMVUnit unit;
    }

    private class <>c__DisplayClass4_1
    {
        public PRISM.Interactions.Live.LiveMvUnitEditCarouselCharacterIcon icon;
        public PRISM.Live.LiveMVIdol idol;
        public int reservedI;
        public <>c__DisplayClass4_0 CS$<>8__locals1;
        private void <UpdateContent>b__0(bool isOn);
        private void <UpdateContent>b__1(PRISM.Adapters.LiveUnitEditCarouselClickEventType type);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveMvOriginalMemberView : UnityEngine.MonoBehaviour, PRISM.Adapters.ILiveMvOriginalMemberView
{
    private PRISM.Interactions.ButtonView editableUnitTabButton;
    private PRISM.Interactions.ButtonView mvOriginalTabButton;
    private PRISM.UIGrayOutController mvOriginalTabButtonGrayOutController;
    private UnityEngine.GameObject[] editableUnitObjects;
    private PRISM.Interactions.Live.LiveMvUnitEditCarouselIdolView mvOriginalMemberView;
    private PRISM.Interactions.Live.LiveMvUnitEditCarouselIdolView mvOriginalMemberViewSummer;
    public void Initialize(PRISM.Live.LiveMVUnit mvOriginalUnit, PRISM.Adapters.LiveMvUnitEditCarouselViewModel viewModel, UniRx.ReactiveProperty<PRISM.Live.LiveMVUnitConfirmationUnitEditTabType> tabType);
    public void UpdateContent(PRISM.Live.LiveMVUnit mvOriginalUnit);
    private void <Initialize>b__6_1(PRISM.Live.LiveMVUnitConfirmationUnitEditTabType type);

    private class <>c
    {
        public static <>c <>9;
        public static System.Action<UniRx.Unit> <>9__6_0;
        private void <Initialize>b__6_0(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.Live
public class LiveMvUnitConfirmationConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.LiveMvUnitConfirmationArgument>, PRISM.Adapters.ILiveMvUnitConfirmationConnector
{
    private PRISM.Live.MusicData musicData;
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
    protected PRISM.Adapters.LiveMvUnitConfirmationArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
}

// Namespace: PRISM.Interactions.Live
public class LiveMvUnitConfirmationView : UnityEngine.MonoBehaviour, PRISM.Adapters.ILiveMvUnitConfirmationView
{
    private PRISM.Interactions.Live.LiveUnitConfirmationCommonView commonView;
    private PRISM.Interactions.Live.LiveMvUnitEditCarousel unitCarousel;
    private PRISM.Interactions.Live.LiveMvUnitListWindow unitListWindow;
    private PRISM.Interactions.Live.LiveMvOriginalMemberView mvOriginalMemberView;
    private PRISM.Interactions.ButtonView toggleRenderingDynamicRangeButton;
    private PRISM.Interactions.ViewStateChanger renderingDynamicRangeState;
    private PRISM.Interactions.ButtonView startButton;
    private PRISM.UIGrayOutController startButtonGrayOutController;
    public PRISM.Adapters.ILiveUnitConfirmationCommonView CommonView { get; set; }
    public PRISM.Adapters.ILiveMvUnitEditCarousel UnitListView { get; set; }
    public PRISM.Adapters.ILiveMvUnitListWindow UnitListWindow { get; set; }
    public PRISM.Adapters.ILiveMvOriginalMemberView MvOriginalMemberView { get; set; }
    public System.IObservable<UniRx.Unit> OnClickToggleRenderingDynamicRange { get; set; }
    public System.IObservable<UniRx.Unit> OnClickStart { get; set; }
    public void Initialize(UniRx.IReadOnlyReactiveProperty<PRISM.RhythmGame.LiveBackgroundMode> backgroundMode, UniRx.IReadOnlyReactiveProperty<PRISM.Definitions.RenderingDynamicRange> renderingDynamicRange, UniRx.IReadOnlyReactiveProperty<bool> canPlay);
    private void <Initialize>b__20_0(PRISM.RhythmGame.LiveBackgroundMode mode);
    private void <Initialize>b__20_1(PRISM.Definitions.RenderingDynamicRange value);
    private void <Initialize>b__20_2(bool x);
}

// Namespace: PRISM.Interactions.Live
public class LiveMvUnitListCell : PRISM.CommonListViewCell<PRISM.Live.ILiveUnit, PRISM.Interactions.Live.LiveMvUnitListCellContext>
{
    private PRISM.Interactions.Live.LiveMvUnitListCellView cellView;
    private PRISM.AutoCancellationTokenSource canceller;
    public void Initialize();
    public void UpdateContent(PRISM.Live.ILiveUnit unit);
    private void OnDestroy();
    private void <Initialize>b__2_0(UniRx.Unit _);
    private void <Initialize>b__2_1(UniRx.Unit _);
    private void <Initialize>b__2_2(string unitName);
}

// Namespace: PRISM.Interactions.Live
public class LiveMvUnitListCellView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.Live.LiveUnitListCellCommonView commonView;
    private PRISM.Interactions.Live.LiveMvUnitListCharacterIcon[] characterIcons;
    public PRISM.Interactions.Live.LiveUnitListCellCommonView CommonView { get; set; }
    public void Show(PRISM.Live.ILiveUnit unit, bool isUseCopy, bool showCopyButton, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
}

// Namespace: PRISM.Interactions.Live
public class LiveMvUnitListCharacterIcon : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.CharacterBaseIconView iconView;
    private PRISM.Interactions.CostumeSetIconView costumeSetIconView;
    public Cysharp.Threading.Tasks.UniTask SetUpAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Live.IIdol idol, System.Threading.CancellationToken ct);
}

// Namespace: PRISM.Interactions.Live
public class LiveMvUnitListView : PRISM.CommonListView<PRISM.Interactions.Live.LiveMvUnitListCell, PRISM.Live.ILiveUnit, PRISM.Interactions.Live.LiveMvUnitListCellContext>
{
    public System.Action<int> OnMoveToClicked { get; set; }
    public System.Action<int> OnCopyToClicked { get; set; }
    public System.Action<int> OnCopyFromClicked { get; set; }
    public System.Action<System.ValueTuple<int, string>> OnChangeUnitName { get; set; }
    public bool IsSelectSpecialUnit { get; set; }
    public bool IsSelectEmptyUnit { get; set; }
}

// Namespace: PRISM.Interactions.Live
public class LiveMvUnitListCellContext : PRISM.CommonListViewContext
{
    private System.Action<int> <OnMoveToClicked>k__BackingField;
    private System.Action<int> <OnCopyToClicked>k__BackingField;
    private System.Action<int> <OnCopyFromClicked>k__BackingField;
    private System.Action<System.ValueTuple<int, string>> <OnChangeUnitName>k__BackingField;
    private bool <IsSelectSpecialUnit>k__BackingField;
    private bool <IsSelectEmptyUnit>k__BackingField;
    public System.Action<int> OnMoveToClicked { get; set; }
    public System.Action<int> OnCopyToClicked { get; set; }
    public System.Action<int> OnCopyFromClicked { get; set; }
    public System.Action<System.ValueTuple<int, string>> OnChangeUnitName { get; set; }
    public bool IsSelectSpecialUnit { get; set; }
    public bool IsSelectEmptyUnit { get; set; }
}

// Namespace: PRISM.Interactions.Live
public class LiveMvUnitListWindow : ENTERPRISE.UI.SlideWindowBase, PRISM.Adapters.ILiveMvUnitListWindow
{
    private PRISM.Interactions.ButtonView hideButton;
    private PRISM.Interactions.Live.LiveMvUnitListView listView;
    private PRISM.Interactions.Live.LiveMvUnitListCellView currentUnitCell;
    private UniRx.Subject<int> onMoveToClicked;
    private UniRx.Subject<System.ValueTuple<PRISM.Adapters.LiveUnitEditFunction, int>> onEditClicked;
    private UniRx.Subject<System.ValueTuple<int, string>> onChangeUnitName;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    private PRISM.AutoCancellationTokenSource currentUnitCts;
    public System.IObservable<int> OnMoveToClicked { get; set; }
    public System.IObservable<System.ValueTuple<PRISM.Adapters.LiveUnitEditFunction, int>> OnEditClicked { get; set; }
    public System.IObservable<System.ValueTuple<int, string>> OnChangeUnitName { get; set; }
    public System.IObservable<string> OnChangeCurrentUnitName { get; set; }
    protected System.IObservable<UniRx.Unit> OnHideRequested { get; set; }
    public void Initialize(PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Collections.Generic.IList<PRISM.Live.ILiveUnit> units, int selectedIndex);
    public void UpdateUnit(System.Collections.Generic.IList<PRISM.Live.ILiveUnit> units, int selectedIndex);
    private void OnDestroy();
    private void <Initialize>b__18_0(int index);
    private void <Initialize>b__18_1(int index);
    private void <Initialize>b__18_2(int index);
    private void <Initialize>b__18_3(System.ValueTuple<int, string> value);
}

// Namespace: PRISM.Interactions.Live
public class VocalSeparateToggleView : UnityEngine.MonoBehaviour, PRISM.Adapters.IVocalSeparateToggleView
{
    private PRISM.Interactions.ViewStateChanger isLimitedStateChanger;
    private PRISM.Interactions.ButtonView button;
    private PRISM.Interactions.ToggleButtonView toggle;
    private PRISM.Interactions.ButtonView settingButton;
    private UnityEngine.GameObject notSatisfyLabel;
    private UnityEngine.GameObject satisfyLabel;
    private PRISM.Interactions.ButtonView lockedButton;
    public System.IObservable<UniRx.Unit> OnClickSetting { get; set; }
    public System.IObservable<UniRx.Unit> OnClickLocked { get; set; }
    public void SetSupported(bool isSupported);
    public void Initialize(PRISM.Adapters.VocalSeparateViewModel viewModel);
    private UniRx.Unit <Initialize>b__12_0(bool isOn, bool isSatisfy);
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=11226 2946E751A24E7473008954207D564067FD5FE0C4C8AC8AAF6E329F6329A5905C;
    private static __StaticArrayInitTypeSize=18987 AFE5C79E154C074825A829A661CDD35AFEFB966CF3EDD3FADDB5FDDF275580E8;

    private struct __StaticArrayInitTypeSize=11226 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=18987 : System.ValueType
    {
    }
}
