
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

// Namespace: PRISM.Exchange
public class ExchangeGoodsGridView : PRISM.Interactions.GridView<PRISM.Exchange.ExchangeGoodsGridViewCell, PRISM.Adapters.ExchangeProductGridListCellData, PRISM.Exchange.ExchangeGoodsGridViewContext>, PRISM.Adapters.IExchangeGoodsGridView, PRISM.Adapters.IExchangeGridView
{
    private UnityEngine.CanvasGroup canvasGroup;
    private UnityEngine.UI.LayoutGroup layoutGroup;
    private UnityEngine.GameObject purchaseProductAmountPanel;
    private ENTERPRISE.UI.UITextMeshProUGUI purchaseProductAmountText;
    private ENTERPRISE.OutGame.RewardItem purchaseProductIcon;
    private PRISM.Interactions.FilterOnlyView filterView;
    private ENTERPRISE.UI.UITextMeshProUGUI emptyResultText;
    private FancyScrollView.Scroller scroller;
    private PRISM.Interactions.ToggleGroupView horizontalTabGroup;
    private System.Collections.Generic.IList<PRISM.Adapters.ExchangeProductGridListCellData> appliedFilterItems;
    private UniRx.Subject<System.ValueTuple<PRISM.Adapters.ExchangeProductListItemViewModel, PRISM.Module.Networking.IPurchaseExchangeProductReply>> onExchangeCompletedSubject;
    private UniRx.Subject<System.ValueTuple<ButtonGoToType, PRISM.Adapters.ExchangeProductListItemViewModel, PRISM.Module.Networking.IPurchaseExchangeProductReply>> onGoToOtherViewSubject;
    public System.IObservable<System.ValueTuple<PRISM.Adapters.ExchangeProductListItemViewModel, PRISM.Module.Networking.IPurchaseExchangeProductReply>> OnExchangeCompletedObservable { get; set; }
    public System.IObservable<System.ValueTuple<ButtonGoToType, PRISM.Adapters.ExchangeProductListItemViewModel, PRISM.Module.Networking.IPurchaseExchangeProductReply>> OnGoToOtherViewObservable { get; set; }
    public System.IObservable<int> OnSelectGoods { get; set; }
    public PRISM.Adapters.ISortFilterView FilterOnlyView { get; set; }
    public float ScrollPosition { get; set; }
    public System.IObservable<int> OnAchievementDetail { get; set; }
    public void SetPurchaseExchangeProductUIActive(bool isActive);
    public void SetUITabActive(bool isActive);
    public void ShowGridView();
    public void HideGridView();
    public void UpdateContents(PRISM.Module.Networking.IProductStatus purchaseProduct, System.Collections.Generic.IList<PRISM.Adapters.ExchangeProductListItemViewModel> items, int tabGroupID);
    public void UpdateContents(System.Collections.Generic.IList<PRISM.Adapters.ExchangeProductGridListCellData> items);
    public void UpdateViewOnly();
    protected void SetupCellTemplate();
    private void Awake();
    public void SetUp(UniRx.IReactiveProperty<int> horizontalTabIndex);
    private Cysharp.Threading.Tasks.UniTask _updateUseExchangeUIAsync(PRISM.Module.Networking.IProductStatus purchaseProduct);
    private void _updatePurchaseProductUI(PRISM.Module.Networking.IHavingProductStatus havingPurchaseProduct, PRISM.Module.Networking.IProductStatus purchaseProduct);
    private void PRISM.Adapters.IExchangeGridView.SetResourceLoader(PRISM.ResourceManagement.IResourceLoader resourceLoader);

    private class CellGroup : DefaultCellGroup<PRISM.Adapters.ExchangeProductGridListCellData, PRISM.Exchange.ExchangeGoodsGridViewContext>
    {
    }

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Adapters.ExchangeProductListItemViewModel, PRISM.Adapters.ExchangeProductGridListCellData> <>9__30_0;
        private PRISM.Adapters.ExchangeProductGridListCellData <UpdateContents>b__30_0(PRISM.Adapters.ExchangeProductListItemViewModel item);
    }

    private struct <_updateUseExchangeUIAsync>d__36 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Module.Networking.IProductStatus purchaseProduct;
        public PRISM.Exchange.ExchangeGoodsGridView <>4__this;
        private Awaiter<PRISM.Module.Networking.IHavingProductStatus> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Exchange
public class ExchangeGoodsGridViewCell : PRISM.Interactions.GridViewCell<PRISM.Adapters.ExchangeProductGridListCellData, PRISM.Exchange.ExchangeGoodsGridViewContext>
{
    private UnityEngine.GameObject newBtgObj;
    private PRISM.Interactions.RewardItemIcon itemIcon;
    private PRISM.Interactions.SimpleAchievementIcon achievementIcon;
    private PRISM.Interactions.ViewStateChanger iconStateChanger;
    private ENTERPRISE.UI.UITextMeshProUGUI descriptionText;
    private ENTERPRISE.UI.UITextMeshProUGUI periodText;
    private ENTERPRISE.UI.UITextMeshProUGUI countText;
    private PRISM.Interactions.ButtonView button;
    private ENTERPRISE.OutGame.RewardItem purchaseProductIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI priceText;
    private UnityEngine.GameObject cellInActiveObj;
    private UnityEngine.GameObject labelAreaObj;
    private UnityEngine.GameObject alreadyAcquiredLabelObj;
    private ENTERPRISE.UI.UITextMeshProUGUI alreadyAcquiredText;
    private UnityEngine.CanvasGroup canvasGroup;
    private System.IDisposable showPeriodTextDisposable;
    private System.Threading.CancellationTokenSource cts;
    private PRISM.Adapters.ExchangeProductGridListCellData goodsData;
    public void Initialize();
    public void UpdateContent(PRISM.Adapters.ExchangeProductGridListCellData goodsModel);
    private void OnDestroy();
    private void _updatePeriodText();
    private string _getPeriodText();
    private string _getCountText();
    private void <Initialize>b__18_0(UniRx.Unit _);
    private void <UpdateContent>b__19_0(long _);
}

// Namespace: PRISM.Exchange
public class ExchangeGoodsGridViewContext : PRISM.Interactions.GridViewContextWithClick<int>
{
    private int <MstExchangeGroupGroupId>k__BackingField;
    private int <SelectedIndex>k__BackingField;
    private UniRx.Subject<int> <OnAchievementDetail>k__BackingField;
    public int MstExchangeGroupGroupId { get; set; }
    public int SelectedIndex { get; set; }
    public UniRx.Subject<int> OnAchievementDetail { get; set; }
    public void Dispose();
}

// Namespace: PRISM.Interactions
public class ExchangeTopOverlayView : PRISM.Interactions.OverlayViewWithCloseButton, PRISM.Adapters.IExchangeTopOverlayView, PRISM.Adapters.IClosableOverlayView<UniRx.Unit>, PRISM.Adapters.IOverlayView, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private UnityEngine.CanvasGroup canvasGroup;
    private ENTERPRISE.UI.UIButton historyButton;
    private PRISM.Interactions.Exchange.ExchangeTabItemView tabPrefab;
    private ENTERPRISE.UI.UITabGroup tabGroup;
    private UnityEngine.GameObject purchaseProductObj;
    private PRISM.Exchange.ExchangeGoodsGridView goodsGridView;
    private PRISM.Interactions.Exchange.ExchangeLargeSpaceGridView largeGridView;
    private PRISM.Interactions.Exchange.ExchangeEventGridView eventGridView;
    private UnityEngine.UI.ScrollRect scrollRect;
    private PRISM.Adapters.ExchangeTopViewModel viewModel;
    private UniRx.Subject<UniRx.Unit> onExchangeCompleted;
    private UniRx.Subject<PRISM.Adapters.ExchangeProductListItemViewModel> onGoodsSelect;
    private System.Collections.Generic.IList<PRISM.Adapters.ExchangeProductListItemViewModel> showItemViewModels;
    public ENTERPRISE.UI.UITabGroup OvelayUITabGroup { get; set; }
    public System.IObservable<UniRx.Unit> OnHistory { get; set; }
    public System.IObservable<PRISM.Adapters.IExchangeGoodsListItemViewModel> OnGoodsSelect { get; set; }
    public PRISM.Adapters.IExchangeGoodsGridView GoodsGridView { get; set; }
    public PRISM.Adapters.IExchangeListView LargeSpaceGridView { get; set; }
    public System.IObservable<PRISM.Adapters.ExchangeLargeSpaceGoodsGridViewModel> OnSelectionTicket { get; set; }
    public System.IObservable<PRISM.Adapters.ExchangeEventGridViewModel> OnTapEventGoods { get; set; }
    public System.IObservable<UniRx.Unit> OnExchangeCompletedObservable { get; set; }
    public void Inject(PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void SetViewModel(PRISM.Adapters.ExchangeTopViewModel vm);
    public Cysharp.Threading.Tasks.UniTask SetUpTabDataAsync(System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IExchangeGroupStatus> exchangeGroupList, System.Threading.CancellationToken ct);
    public void JumpToLeftTab(int index);
    public Cysharp.Threading.Tasks.UniTask LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public void ShowGridView();
    public void HideGridView();
    public void ShowLargeGridView();
    public void HideLargeGridView();
    public void ShowEventGridView();
    public void HideEventGridView();
    public void SetUITabActive(bool isActive);
    public void SetPurchaseExchangeProductUIActive(bool isActive);
    public void GridViewUpdate();
    public void SetLargeGridViewEmptyText(string str);
    public void LargeGridViewUpdate();
    public void EventGridViewUpdate();
    private void Awake();
    private void <LoadAsync>b__33_0(System.ValueTuple<ButtonGoToType, PRISM.Adapters.ExchangeProductListItemViewModel, PRISM.Module.Networking.IPurchaseExchangeProductReply> _);
    private void <LoadAsync>b__33_1(System.ValueTuple<PRISM.Adapters.ExchangeProductListItemViewModel, PRISM.Module.Networking.IPurchaseExchangeProductReply> _);
    private void <LoadAsync>b__33_2(int index);
    private bool <GridViewUpdate>b__43_2(System.ValueTuple<PRISM.Adapters.ExchangeProductListItemViewModel, int> tmp);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Module.Networking.IExchangeGroupStatus, int> <>9__31_0;
        public static System.Func<PRISM.Adapters.ExchangeProductListItemViewModel, bool> <>9__43_0;
        public static System.Func<PRISM.Adapters.ExchangeProductListItemViewModel, int, System.ValueTuple<PRISM.Adapters.ExchangeProductListItemViewModel, int>> <>9__43_1;
        private int <SetUpTabDataAsync>b__31_0(PRISM.Module.Networking.IExchangeGroupStatus x);
        private bool <GridViewUpdate>b__43_0(PRISM.Adapters.ExchangeProductListItemViewModel item);
        private System.ValueTuple<PRISM.Adapters.ExchangeProductListItemViewModel, int> <GridViewUpdate>b__43_1(PRISM.Adapters.ExchangeProductListItemViewModel item, int index);
    }

    private struct <SetUpTabDataAsync>d__31 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IExchangeGroupStatus> exchangeGroupList;
        public PRISM.Interactions.ExchangeTopOverlayView <>4__this;
        public System.Threading.CancellationToken ct;
        private PRISM.Interactions.Exchange.ExchangeTabItemView <prefab>5__2;
        private System.Collections.Generic.List<ENTERPRISE.UI.UITabButton> <tabs>5__3;
        private Enumerator<PRISM.Module.Networking.IExchangeGroupStatus> <>7__wrap3;
        private PRISM.Module.Networking.IExchangeGroupStatus <group>5__5;
        private Awaiter<System.ValueTuple<TabData, bool>> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class ExchangeConfirmationPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IExchangeConfirmationPopupView, PRISM.Adapters.IClosablePopupFrame<int>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<int>
{
    protected ENTERPRISE.UI.UITextMeshProUGUI headerText;
    private ENTERPRISE.OutGame.RewardItem priceViewProductIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI priceText;
    private PRISM.Interactions.ButtonView rateViewButton;
    private PRISM.Interactions.NumberFluctuateButtonView[] numberFluctuateButtons;
    protected ENTERPRISE.OutGame.RewardItem goodsIcon;
    protected ENTERPRISE.UI.UITextMeshProUGUI descriptionText;
    protected ENTERPRISE.UI.UITextMeshProUGUI exchangeCountText;
    protected ENTERPRISE.OutGame.RewardItem purchaseProductIcon;
    protected PRISM.Common.ValueFluctionTextPair purchaseProductCountTextPair;
    protected PRISM.Common.ValueFluctionTextPair goodsCountTextPair;
    protected PRISM.Common.ValueFluctionTextPair exchangeLimitTextPair;
    protected ENTERPRISE.UI.UITextMeshProUGUI cautionText;
    protected PRISM.CommonInputFieldTMP exchangeCountInput;
    private PRISM.Adapters.ExchangeConfirmationPopupViewModel viewModel;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<int> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<int> OnCloseRequested { get; set; }
    public System.IObservable<UniRx.Unit> OnRate { get; set; }
    public System.IObservable<int> OnFluctuate { get; set; }
    public System.IObservable<string> OnEditEnd { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void Setup(PRISM.Adapters.ExchangeConfirmationPopupViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    public void UpdateUIState();
    private void <CreateFrameParameter>b__24_0();
    private void <CreateFrameParameter>b__24_1();
    private void <CreateFrameParameter>b__24_2();
}

// Namespace: PRISM.Interactions
public class ExchangeCostumeListPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IExchangeCostumeListPopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private UnityEngine.GameObject cellPrefab;
    private UnityEngine.Transform content;
    private PRISM.Adapters.ExchangeSelectionListPopupViewModel viewModel;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClose;
    private UniRx.Subject<UniRx.Unit> onExchange;
    private UniRx.Subject<PRISM.Adapters.ExchangeProductTicketListViewModel> onDetail;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public System.IObservable<PRISM.Adapters.ExchangeProductTicketListViewModel> OnDetail { get; set; }
    public System.IObservable<UniRx.Unit> OnExchange { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void Setup(PRISM.Adapters.ExchangeSelectionListPopupViewModel viewModel, PRISM.ResourceManagement.IResourceLoader loader);
    public void Close(bool exchange);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__12_0();
    private void <CreateFrameParameter>b__12_1();

    private class <>c__DisplayClass13_0
    {
        public PRISM.Adapters.ExchangeSelectionListPopupViewModel viewModel;
        public PRISM.Interactions.ExchangeCostumeListPopupView <>4__this;
        public System.Action<int> <>9__0;
        public System.Action<PRISM.Adapters.ExchangeProductTicketListViewModel> <>9__1;
        private void <Setup>b__0(int index);
        private void <Setup>b__1(PRISM.Adapters.ExchangeProductTicketListViewModel model);
    }
}

// Namespace: PRISM.Interactions
public class ExchangeHistoryDetailPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IExchangeHistoryDetailPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.Exchange.ExchangeHistoryItemView exchangeItemView;
    private PRISM.Interactions.Exchange.ExchangeHistoryDetailItemContainerView exchangeHistoryDetailItemContainerView;
    private static int HistoryDetalTitleKey;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClick;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public System.IObservable<PRISM.Domain.ProductKey> OnGoodsInformation { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    public void Setup(PRISM.Adapters.ExchangeHistoryItemViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private void <CreateFrameParameter>b__8_0();
    private void <CreateFrameParameter>b__8_1();
}

// Namespace: PRISM.Interactions
public class ExchangeItemTicketListPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IExchangeItemTicketListPopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private PRISM.Adapters.ExchangeSelectionListPopupViewModel viewModel;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClosed;
    private UnityEngine.GameObject exchangeProductObj;
    private ENTERPRISE.OutGame.RewardItem exchangeProductIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI exchangeProductAmountText;
    private PRISM.Interactions.Exchange.ExchangeProductListGridView listGridView;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public System.IObservable<int> OnClickGoodsIndex { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void Inject(PRISM.Adapters.ExchangeSelectionListPopupViewModel vm, PRISM.ResourceManagement.IResourceLoader loader);
    public void Close(bool exchange);
    private void _setup();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__11_0();
    private void <CreateFrameParameter>b__11_1();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Adapters.ExchangeProductTicketListViewModel, PRISM.Adapters.ExchangeProductGridListCellData> <>9__14_0;
        private PRISM.Adapters.ExchangeProductGridListCellData <_setup>b__14_0(PRISM.Adapters.ExchangeProductTicketListViewModel item);
    }

    private struct <LoadAsync>d__21 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
        public PRISM.Interactions.ExchangeItemTicketListPopupView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter<bool> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class ExchangePieceRatePopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IExchangePieceRatePopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private ENTERPRISE.UI.UITextMeshProUGUI currentExchangeCountText;
    private ENTERPRISE.OutGame.RewardItem exchangeTargetRewardIcon;
    private PRISM.Interactions.PieceExchangeRateCell pieceRatePrefab;
    private UnityEngine.GameObject rateViewArea;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Setup(PRISM.Module.Networking.IProductStatus purchaseProduct, System.Collections.Generic.IReadOnlyList<PRISM.Exchange.ExchangePriceRateClientModel> priceRateList, int totalPurchaseCount, PRISM.ResourceManagement.IResourceLoader loader);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__8_0();
    private void <CreateFrameParameter>b__8_1();
}

// Namespace: PRISM.Interactions
public class ExchangeProductDetailPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IExchangeProductDetailPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.Shop.ShopPurchaseHistoryDetailItemContainerView mainItemContainerView;
    private PRISM.Adapters.ExchangeProductTicketListViewModel viewModel;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClick;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    public void Setup(PRISM.Adapters.ExchangeProductTicketListViewModel vm);
    private void <CreateFrameParameter>b__5_0();
    private void <CreateFrameParameter>b__5_1();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Domain.ProductKeyWithAmount, System.Collections.Generic.IEnumerable<PRISM.Domain.ProductKeyWithAmount>> <>9__14_0;
        private System.Collections.Generic.IEnumerable<PRISM.Domain.ProductKeyWithAmount> <Setup>b__14_0(PRISM.Domain.ProductKeyWithAmount product);
    }
}

// Namespace: PRISM.Interactions
public class ExchangeProductListPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IExchangeProductListPopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private PRISM.Adapters.ExchangeProductListPopupViewModel viewModel;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClosed;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    private UnityEngine.GameObject exchangeProductObj;
    private ENTERPRISE.OutGame.RewardItem exchangeProductIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI exchangeProductAmountText;
    private PRISM.Interactions.Exchange.ExchangeProductListGridView listView;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public System.IObservable<int> OnClickGoodsIndex { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void Inject(PRISM.Adapters.ExchangeProductListPopupViewModel vm, PRISM.ResourceManagement.IResourceLoader loader);
    public void Setup();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__11_0();
    private void <CreateFrameParameter>b__11_1();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Adapters.ExchangeEventProductListViewModel, PRISM.Adapters.ExchangeProductGridListCellData> <>9__13_0;
        private PRISM.Adapters.ExchangeProductGridListCellData <Setup>b__13_0(PRISM.Adapters.ExchangeEventProductListViewModel item);
    }

    private struct <LoadAsync>d__20 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
        public PRISM.Interactions.ExchangeProductListPopupView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter<PRISM.Module.Networking.IHavingProductStatus> <>u__1;
        private Awaiter<bool> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class ExchangeResultPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IExchangeResultPopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private ENTERPRISE.UI.UITextMeshProUGUI headerText;
    private PRISM.Interactions.RewardItemIcon itemIcon;
    private PRISM.Interactions.Achievement.AchievementIcon achievementIcon;
    private PRISM.Interactions.ViewStateChanger iconStateChanger;
    private ENTERPRISE.UI.UITextMeshProUGUI descriptionText;
    private ENTERPRISE.UI.UITextMeshProUGUI exchangeCountText;
    private ENTERPRISE.OutGame.RewardItem purchaseProductIcon;
    private PRISM.Common.ValueFluctionTextPair purchaseProductCountTextPair;
    private PRISM.Common.ValueFluctionTextPair goodsCountTextPair;
    private ENTERPRISE.OutGame.RewardItem convertProductIcon;
    private PRISM.Common.ValueFluctionTextPair convertCountTextPair;
    private PRISM.Common.ValueFluctionTextPair exchangeLimitTextPair;
    private ButtonGoToType goToType;
    private PRISM.Adapters.ExchangeResultPopupViewModel viewModel;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public System.IObservable<int> OnAchievementIconClick { get; set; }
    public System.IObservable<int> OnAchievementIconLongPress { get; set; }
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void Setup(PRISM.Adapters.ExchangeResultPopupViewModel resultViewModel, PRISM.ResourceManagement.IResourceLoader loader);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__21_0();
    private void <CreateFrameParameter>b__21_1();
    private void <CreateFrameParameter>b__21_2();
    private void <CreateFrameParameter>b__21_3();
}

// Namespace: PRISM.Interactions
public class ExchangeSelectionCompletePopupView : PRISM.Interactions.Exchange.ExchangeSelectionPopupViewBase, PRISM.Interactions.IPopupContent, PRISM.Adapters.IExchangeSelectionCompletePopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClick;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void Inject(PRISM.Adapters.ExchangeProductTicketListViewModel viewModel, int exchangeCount, PRISM.ResourceManagement.IResourceLoader loader);
    private void _setTicketRequirePairViewText(PRISM.Module.Networking.IProductStatus ticketProduct, int baseAmount);
    protected void _setStarCountTextPair(int baseAmount, int addAmount);
    protected void _setPieceCountTextPair(int baseAmount, int addAmount);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    protected void _setTicketRequirePairViewText();
    protected void _setAmountText(long havingAmount, int exchnageAmount);
    private void <CreateFrameParameter>b__3_0();
    private void <CreateFrameParameter>b__3_1();
    private void <CreateFrameParameter>b__3_2();
    private void <CreateFrameParameter>b__3_3();

    private struct <LoadAsync>d__14 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
        public PRISM.Interactions.ExchangeSelectionCompletePopupView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private Awaiter<bool> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class ExchangeSelectionConfirmPopupView : PRISM.Interactions.Exchange.ExchangeSelectionPopupViewBase, PRISM.Interactions.IPopupContent, PRISM.Adapters.IExchangeSelectionConfirmPopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private ENTERPRISE.OutGame.RewardItem exchangeCountProductIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI exchangeCountText;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClick;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void Inject(PRISM.Adapters.ExchangeProductTicketListViewModel viewModel, PRISM.ResourceManagement.IResourceLoader loader);
    private void _setTicketRequirePairViewText(PRISM.Module.Networking.IProductStatus ticketProduct, string ticketName, int requireAmount, int baseAmount);
    private void _setPurchaseTextActive(bool isHaving);
    protected void _setStarCountTextPair(int baseAmount, int addAmount);
    protected void _setPieceCountTextPair(int baseAmount, int addAmount);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    protected void _setTicketRequirePairViewText();
    protected void _setAmountText(long havingAmount, int exchnageAmount);
    private void <CreateFrameParameter>b__5_0();
    private void <CreateFrameParameter>b__5_1();
    private void <CreateFrameParameter>b__5_2();

    private struct <LoadAsync>d__17 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
        public PRISM.Interactions.ExchangeSelectionConfirmPopupView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private Awaiter<bool> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class ExchangeSelectionListPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IExchangeSelectionListPopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private UnityEngine.GameObject itemPrefab;
    private UnityEngine.Transform itemListContent;
    private ENTERPRISE.UI.UITextMeshProUGUI expireDateText;
    private ENTERPRISE.OutGame.RewardItem ticketIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI ticketCountText;
    private ENTERPRISE.UI.UITextMeshProUGUI cautionText;
    private UniRx.Subject<UniRx.Unit> onSelectItemSubject;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClose;
    private PRISM.Adapters.ExchangeSelectionListPopupViewModel viewModel;
    private System.Collections.Generic.List<PRISM.Interactions.Exchange.ExchangeSelectionItemView> itemViews;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public System.IObservable<UniRx.Unit> OnSelectItem { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    private void Awake();
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void Setup(PRISM.Adapters.ExchangeSelectionListPopupViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void Close(bool exchange);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__15_0();
    private void <CreateFrameParameter>b__15_1();

    private class <>c__DisplayClass16_0
    {
        public PRISM.Adapters.ExchangeSelectionListPopupViewModel viewModel;
        public PRISM.Interactions.ExchangeSelectionListPopupView <>4__this;
        public System.Action<int> <>9__0;
        private void <Setup>b__0(int index);
    }
}

// Namespace: PRISM.Interactions
public class ExchangeSimpleConfirmPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IExchangeSimpleConfirmPopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private ENTERPRISE.UI.UITextMeshProUGUI headerText;
    private PRISM.Interactions.RewardItemIcon exchangeProductRewardIcon;
    private PRISM.Interactions.Achievement.AchievementIcon exchangeProductAchievementIcon;
    private PRISM.Interactions.ViewStateChanger exchangeProductIconStateChanger;
    private ENTERPRISE.UI.UITextMeshProUGUI exchangeProductNameText;
    private ENTERPRISE.OutGame.RewardItem exchangeCountProductIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI exchangeCountText;
    private ENTERPRISE.OutGame.RewardItem purchaseProductIcon;
    private PRISM.Common.ValueFluctionTextPair purchaseProductCountTextPair;
    private UnityEngine.GameObject exchangeCountFluctionObject;
    private ENTERPRISE.UI.UITextMeshProUGUI exchangeCountBeforeText;
    private ENTERPRISE.UI.UITextMeshProUGUI exchangeCountAfterText;
    private ENTERPRISE.UI.UITextMeshProUGUI exchangeCountNoneText;
    private ENTERPRISE.UI.UITextMeshProUGUI cautionText;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public System.IObservable<int> OnAchievementIconClick { get; set; }
    public System.IObservable<int> OnAchievementIconLongPress { get; set; }
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    public void Setup(PRISM.Adapters.ExchangeSimpleConfirmPopupViewModel viewModel, PRISM.ResourceManagement.IResourceLoader loader);
    private void _setRequireProductPairViewText(PRISM.Module.Networking.IProductWithAmountStatus product, int requireAmount, int baseAmount, PRISM.ResourceManagement.IResourceLoader loader);
    private void _setExchangeCountText(int limitCount, int remainCount);
    private void <CreateFrameParameter>b__21_0();
    private void <CreateFrameParameter>b__21_1();
    private void <CreateFrameParameter>b__21_2();
}

// Namespace: PRISM.Interactions
public class ExchangeHistoryPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IExchangeHistoryPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private ENTERPRISE.UI.UITextMeshProUGUI cautionText;
    private UnityEngine.Transform itemListContent;
    private UnityEngine.UI.Scrollbar listScrollBar;
    private UnityEngine.GameObject itemViewPrefab;
    private UnityEngine.GameObject emptyViewTextObj;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClick;
    private UniRx.Subject<int> onClickHistoryItem;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public System.IObservable<int> OnClickedHistoryItem { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void SetUp(PRISM.Adapters.ExchangeHistoryViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__11_0();
    private void <CreateFrameParameter>b__11_1();
    private void <SetUp>b__12_0(int index);
}

// Namespace: PRISM.Interactions
public class PieceExchangeRateCell : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI countText;
    private ENTERPRISE.OutGame.RewardItem pieceIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI pieceText;
    private UnityEngine.GameObject selectBG;
    public ENTERPRISE.OutGame.RewardItem PieceIcon { get; set; }
    public void SetUp(PRISM.Exchange.ExchangePriceRateClientModel priceRate, bool isSelect);
}

// Namespace: PRISM.Interactions.Exchange
public class ExchangeSelectionPopupViewBase : UnityEngine.MonoBehaviour
{
    protected ENTERPRISE.UI.UITextMeshProUGUI headerText;
    protected PRISM.Interactions.RewardItemIcon exchangeProductRewardIcon;
    protected PRISM.Interactions.ButtonView detailButton;
    protected ENTERPRISE.UI.UITextMeshProUGUI exchangeProductNameText;
    protected UnityEngine.GameObject pieceProductRootObject;
    protected ENTERPRISE.UI.UITextMeshProUGUI pieceLabelText;
    protected ENTERPRISE.OutGame.RewardItem pieceProductIcon;
    protected ENTERPRISE.UI.UITextMeshProUGUI pieceProductNameText;
    protected ENTERPRISE.OutGame.RewardItem purchaseProductIcon;
    protected PRISM.Common.ValueFluctionTextPair purchaseProductCountTextPair;
    protected UnityEngine.GameObject starCountRootObject;
    protected ENTERPRISE.OutGame.RewardItem starCountProductIcon;
    protected PRISM.Common.ValueFluctionTextPair starCountTextPair;
    protected UnityEngine.GameObject pieceCountRootObject;
    protected ENTERPRISE.OutGame.RewardItem pieceCountProductIcon;
    protected PRISM.Common.ValueFluctionTextPair pieceCountTextPair;
    protected UnityEngine.GameObject exchangeCountRootObject;
    protected UnityEngine.GameObject exchangeCountFluctionObject;
    protected ENTERPRISE.UI.UITextMeshProUGUI exchangeCountBeforeText;
    protected ENTERPRISE.UI.UITextMeshProUGUI exchangeCountAfterText;
    protected ENTERPRISE.UI.UITextMeshProUGUI exchangeCountNoneText;
    protected PRISM.Common.ValueFluctionTextPair amountTextPair;
    protected PRISM.Adapters.ExchangeProductTicketListViewModel viewModel;
    protected PRISM.ResourceManagement.IResourceLoader resourceLoader;
    protected int exchangeCount;
    public System.IObservable<UniRx.Unit> OnDetail { get; set; }
    protected void _setPieceUI(bool isShowPiece);
    protected void _setExchangeProduct(PRISM.Module.Networking.IProductWithAmountStatus exchangeProduct, int rainbowCrystalAmount, string exchangeProductName, PRISM.Module.Networking.IProductStatus pieceProduct, int pieceAmount, string pieceLabelTextStr, PRISM.Module.Networking.IHavingProductStatus havingProduct, bool isShowPieceIcon);
    protected Cysharp.Threading.Tasks.UniTask _setPieceTextPairViewTextAsync(PRISM.Module.Networking.IProductStatus pieceProduct, int pieceAmount, System.Threading.CancellationToken ct);
    protected Cysharp.Threading.Tasks.UniTask _setStarPairViewTextAsync(PRISM.Module.Networking.IProductStatus starProduct, int addAmount, System.Threading.CancellationToken ct);
    protected void _setPieceCountTextPair(int baseAmount, int addAmount);
    protected void _setStarCountTextPair(int baseAmount, int addAmount);
    private void _setExchangeCountText(int limitCount, int remainCount);
    protected Cysharp.Threading.Tasks.UniTask _setupViewAsync(System.Threading.CancellationToken ct);
    protected void _setAmountText(long havingAmount, int exchnageAmount);
    protected void _setTicketRequirePairViewText();
    private void _setPurchaseTextActive(bool isHaving);
    private bool _isShowAmountProduct(ProductType productType);

    private struct <_setPieceTextPairViewTextAsync>d__29 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Module.Networking.IProductStatus pieceProduct;
        public System.Threading.CancellationToken ct;
        public PRISM.Interactions.Exchange.ExchangeSelectionPopupViewBase <>4__this;
        public int pieceAmount;
        private int <baseAmount>5__2;
        private Awaiter<PRISM.Module.Networking.IHavingProductStatus> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_setStarPairViewTextAsync>d__30 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Module.Networking.IProductStatus starProduct;
        public System.Threading.CancellationToken ct;
        public PRISM.Interactions.Exchange.ExchangeSelectionPopupViewBase <>4__this;
        public int addAmount;
        private int <baseAmount>5__2;
        private Awaiter<PRISM.Module.Networking.IHavingProductStatus> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_setupViewAsync>d__34 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Exchange.ExchangeSelectionPopupViewBase <>4__this;
        public System.Threading.CancellationToken ct;
        private bool <isShowPiece>5__2;
        private Awaiter <>u__1;
        private Awaiter<PRISM.Module.Networking.IHavingProductStatus> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Exchange
public class ExchangeCostumeListItemView : UnityEngine.MonoBehaviour
{
    private static string CostumeTicketThumbnailImageNameBase;
    private UnityEngine.GameObject newIcon;
    private UnityEngine.UI.RawImage iconImage;
    private UnityEngine.GameObject grayoutImage;
    private UnityEngine.UI.RawImage buttonTicketImage;
    private PRISM.Interactions.ButtonView exchangeButton;
    private PRISM.Interactions.ButtonView detailButton;
    private ENTERPRISE.UI.UITextMeshProUGUI priceText;
    private ENTERPRISE.UI.UITextMeshProUGUI expireDateText;
    private ENTERPRISE.UI.UITextMeshProUGUI exchangeCountLimitText;
    private UnityEngine.GameObject labelAreaObj;
    private UnityEngine.GameObject alreadyAcquiredLabelObj;
    private ENTERPRISE.UI.UITextMeshProUGUI alreadyAcquiredText;
    private System.IDisposable limitTimeDisposable;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    private UniRx.Subject<int> onTargetProductIndex;
    private UniRx.Subject<PRISM.Adapters.ExchangeProductTicketListViewModel> onDetail;
    public System.IObservable<int> OnExchange { get; set; }
    public System.IObservable<PRISM.Adapters.ExchangeProductTicketListViewModel> OnDetail { get; set; }
    public void Setup(PRISM.Adapters.ExchangeProductTicketListViewModel param, int index, bool exchangeable, PRISM.ResourceManagement.IResourceLoader loader);
    public void SetNewIcon(bool isActive);
    private void Awake();
    private void _setupIcon(PRISM.Adapters.ExchangeProductTicketListViewModel viewModel);
    private void _updateLimitTime(PRISM.Adapters.ExchangeProductTicketListViewModel viewModel);
    private void _onDetail(PRISM.Adapters.ExchangeProductTicketListViewModel param);
    private string _createExipreDateString(PRISM.Adapters.ExchangeProductTicketListViewModel param);
    private string _createCountLimitString(PurchaseCountResetTimingType limitType, int purchaseCount, int purchaseLimit);
    private Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> _loadThumnailImageAsync(int mstId);
    private string _getCostumeTicketThumbnailName(int mstId);

    private class <>c__DisplayClass21_0
    {
        public PRISM.Interactions.Exchange.ExchangeCostumeListItemView <>4__this;
        public int index;
        public PRISM.Adapters.ExchangeProductTicketListViewModel param;
        private void <Setup>b__0(UniRx.Unit _);
        private void <Setup>b__1(UniRx.Unit _);
        private void <Setup>b__2(long _);
    }
}

// Namespace: PRISM.Interactions.Exchange
public class ExchangeEventGridView : FancyScrollView.FancyGridView<PRISM.Adapters.ExchangeEventGridViewModel, PRISM.Interactions.Exchange.ExchangeEventViewContext>, System.IDisposable
{
    private UnityEngine.CanvasGroup canvasGroup;
    private PRISM.Interactions.Exchange.ExchangeEventViewCell cellPrefab;
    protected ENTERPRISE.UI.UITextMeshProUGUI emptyViewText;
    public PRISM.Interactions.Exchange.ExchangeEventViewContext ViewContext { get; set; }
    public void SetResourceLoader(PRISM.ResourceManagement.IResourceLoader loader);
    public void SetEmptyText(string str);
    public void ShowGridView();
    public void HideGridView();
    public void UpdateContents(System.Collections.Generic.IList<PRISM.Adapters.ExchangeEventGridViewModel> items);
    public void Dispose();
    protected void SetupCellTemplate();

    private class CellGroup : DefaultCellGroup<PRISM.Adapters.ExchangeEventGridViewModel, PRISM.Interactions.Exchange.ExchangeEventViewContext>
    {
    }
}

// Namespace: PRISM.Interactions.Exchange
public class ExchangeEventViewCell : FancyScrollView.FancyGridViewCell<PRISM.Adapters.ExchangeEventGridViewModel, PRISM.Interactions.Exchange.ExchangeEventViewContext>
{
    private static string ExchangeEventImageNameBase;
    private UnityEngine.GameObject newBtgObj;
    private UnityEngine.UI.RawImage itemIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI eventName;
    private ENTERPRISE.UI.UITextMeshProUGUI playablePeriodText;
    private ENTERPRISE.UI.UITextMeshProUGUI exchangePeriodText;
    private UnityEngine.GameObject cellInActiveObj;
    private UnityEngine.GameObject buttonInActiveObj;
    private ENTERPRISE.UI.UIButton exchangeBtn;
    private PRISM.Adapters.ExchangeEventGridViewModel <GoodsData>k__BackingField;
    public PRISM.Adapters.ExchangeEventGridViewModel GoodsData { get; set; }
    public PRISM.Interactions.Exchange.ExchangeEventViewContext ViewContext { get; set; }
    public void UpdateContent(PRISM.Adapters.ExchangeEventGridViewModel eventModel);
    private void _setExchangeButtonActive(bool isActive);
    private Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> _loadImageAsync(int mstId);

    private class <>c__DisplayClass15_0
    {
        public PRISM.Interactions.Exchange.ExchangeEventViewCell <>4__this;
        public PRISM.Adapters.ExchangeEventGridViewModel eventModel;
        private void <UpdateContent>b__0();
    }
}

// Namespace: PRISM.Interactions.Exchange
public class ExchangeEventViewContext : PRISM.Interactions.GridViewContext
{
    private UniRx.Subject<PRISM.Adapters.ExchangeEventGridViewModel> onClickEvent;
    public System.IObservable<PRISM.Adapters.ExchangeEventGridViewModel> OnClickEvent { get; set; }
    public void ClickPurchaseOnNext(PRISM.Adapters.ExchangeEventGridViewModel value);
    public void Dispose();
}

// Namespace: PRISM.Interactions.Exchange
public class ExchangeGoodsSetItem : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.RewardItemIcon rewardItem;
    private ENTERPRISE.UI.UITextMeshProUGUI itemNameText;
    private ENTERPRISE.UI.UITextMeshProUGUI amountText;
    private UnityEngine.GameObject spaceLine;
    private PRISM.Interactions.Shop.GoodsInformationButton goodsInformationButton;
    public System.IObservable<PRISM.Domain.ProductKey> OnGoodsInformation { get; set; }
    public void Setup(PRISM.Domain.ProductKeyWithAmount product, int amount, PRISM.ResourceManagement.IResourceLoader resourceLoader, bool displaySpaceLine, bool isShowDetail);
}

// Namespace: PRISM.Interactions.Exchange
public class ExchangeHistoryDetailItemContainerView : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI titleText;
    private PRISM.Interactions.Exchange.ExchangeGoodsSetItem itemPrefab;
    private UnityEngine.Transform itemParent;
    private UnityEngine.GameObject noItemLabel;
    private UniRx.Subject<PRISM.Domain.ProductKey> onGoodsInformationSubject;
    public System.IObservable<PRISM.Domain.ProductKey> OnGoodsInformation { get; set; }
    private void Awake();
    public void Setup(string title, System.Collections.Generic.IReadOnlyList<PRISM.Domain.ProductKeyWithAmount> itemList, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private void <Setup>b__8_0(PRISM.Domain.ProductKey product);
}

// Namespace: PRISM.Interactions.Exchange
public class ExchangeHistoryItemView : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI purchasedDateText;
    private ENTERPRISE.UI.UITextMeshProUGUI itemTitleText;
    private ENTERPRISE.UI.UITextMeshProUGUI useProductCountText;
    private ENTERPRISE.UI.UITextMeshProUGUI exchangeProductCountText;
    private PRISM.Interactions.RewardItemIcon rewardItem;
    private UnityEngine.GameObject rightIcon;
    private ENTERPRISE.UI.UIButton cellButton;
    private ENTERPRISE.OutGame.RewardItem useProductIconRewardItem;
    private UniRx.Subject<int> onClick;
    public System.IObservable<int> OnClickHistoryItem { get; set; }
    private void Awake();
    public void SetIcon(PRISM.Module.Networking.IProductWithAmountStatus product, PRISM.ResourceManagement.IResourceLoader resourceLoader, bool isShowDetail);
    public void SetItemText(string itemName, string dateStr);
    public void SetExchangeText(PRISM.Module.Networking.IProductWithAmountStatus useProduct, int exItemCount, bool isShowDetail, PRISM.ResourceManagement.IResourceLoader loader);
    public void SetCellButton(bool isEnable, int index);

    private class <>c__DisplayClass15_0
    {
        public PRISM.Interactions.Exchange.ExchangeHistoryItemView <>4__this;
        public int index;
        private void <SetCellButton>b__0();
    }
}

// Namespace: PRISM.Interactions.Exchange
public class ExchangeLargeSpaceGoodsViewCell : FancyScrollView.FancyGridViewCell<PRISM.Adapters.ExchangeLargeSpaceGoodsGridViewModel, PRISM.Interactions.Exchange.ExchangeLargeSpaceGoodsViewContext>
{
    private PRISM.Adapters.ExchangeLargeSpaceGoodsGridViewModel <GoodsData>k__BackingField;
    private UnityEngine.GameObject newBtgObj;
    private ENTERPRISE.OutGame.RewardItem itemIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI descriptionText;
    private ENTERPRISE.UI.UITextMeshProUGUI periodText;
    private ENTERPRISE.UI.UITextMeshProUGUI countText;
    private UnityEngine.GameObject buttonInActiveObj;
    private ENTERPRISE.OutGame.RewardItem purchaseProductIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI priceText;
    private UnityEngine.GameObject cellInActiveObj;
    private ENTERPRISE.UI.UIButton exchangeBtn;
    private System.IDisposable showPeriodTextDisposable;
    public PRISM.Adapters.ExchangeLargeSpaceGoodsGridViewModel GoodsData { get; set; }
    public void UpdateContent(PRISM.Adapters.ExchangeLargeSpaceGoodsGridViewModel goodsModel);
    private void _setExchangeButtonActive(bool isActive);
    private void OnDestroy();
    private string _getPeriodText();

    private class <>c__DisplayClass15_0
    {
        public PRISM.Interactions.Exchange.ExchangeLargeSpaceGoodsViewCell <>4__this;
        public PRISM.Adapters.ExchangeLargeSpaceGoodsGridViewModel goodsModel;
        private void <UpdateContent>b__0();
        private void <UpdateContent>b__1(long _);
    }
}

// Namespace: PRISM.Interactions.Exchange
public class ExchangeLargeSpaceGoodsViewContext : PRISM.Interactions.GridViewContext
{
    private UniRx.Subject<PRISM.Adapters.ExchangeLargeSpaceGoodsGridViewModel> onClickPurchase;
    public System.IObservable<PRISM.Adapters.ExchangeLargeSpaceGoodsGridViewModel> OnClickPurchase { get; set; }
    public void ClickPurchaseOnNext(PRISM.Adapters.ExchangeLargeSpaceGoodsGridViewModel value);
    public void Dispose();
}

// Namespace: PRISM.Interactions.Exchange
public class ExchangeLargeSpaceGridView : FancyScrollView.FancyGridView<PRISM.Adapters.ExchangeLargeSpaceGoodsGridViewModel, PRISM.Interactions.Exchange.ExchangeLargeSpaceGoodsViewContext>, PRISM.Adapters.IExchangeListView, System.IDisposable
{
    private UnityEngine.CanvasGroup canvasGroup;
    private PRISM.Interactions.Exchange.ExchangeLargeSpaceGoodsViewCell cellPrefab;
    protected ENTERPRISE.UI.UITextMeshProUGUI emptyViewText;
    public PRISM.Interactions.Exchange.ExchangeLargeSpaceGoodsViewContext ViewContext { get; set; }
    public System.IObservable<PRISM.Adapters.ExchangeLargeSpaceGoodsGridViewModel> OnSelectionTicket { get; set; }
    public void SetResourceLoader(PRISM.ResourceManagement.IResourceLoader loader);
    public void SetEmptyText(string str);
    public void ShowGridView();
    public void HideGridView();
    public void UpdateContents(System.Collections.Generic.IList<PRISM.Adapters.ExchangeLargeSpaceGoodsGridViewModel> items);
    public void Dispose();
    protected void SetupCellTemplate();

    private class CellGroup : DefaultCellGroup<PRISM.Adapters.ExchangeLargeSpaceGoodsGridViewModel, PRISM.Interactions.Exchange.ExchangeLargeSpaceGoodsViewContext>
    {
    }
}

// Namespace: PRISM.Interactions.Exchange
public class ExchangeProductListGridView : PRISM.Interactions.GridView<PRISM.Exchange.ExchangeGoodsGridViewCell, PRISM.Adapters.ExchangeProductGridListCellData, PRISM.Exchange.ExchangeGoodsGridViewContext>, PRISM.Adapters.IExchangeGridView
{
    private UnityEngine.GameObject purchaseProductAmountPanel;
    private ENTERPRISE.UI.UITextMeshProUGUI purchaseProductAmountText;
    private ENTERPRISE.OutGame.RewardItem purchaseProductIcon;
    public System.IObservable<int> OnClickGoodsIndex { get; set; }
    public void SetPurchaseExchangeProductUIActive(bool isActive);
    public void UpdateContents(System.Collections.Generic.IList<PRISM.Adapters.ExchangeProductGridListCellData> items, int groupId);
    public void UpdateContents(System.Collections.Generic.IList<PRISM.Adapters.ExchangeProductGridListCellData> items);
    public void UpdateViewOnly();
    protected void SetupCellTemplate();
    private void PRISM.Adapters.IExchangeGridView.SetResourceLoader(PRISM.ResourceManagement.IResourceLoader resourceLoader);

    private class CellGroup : DefaultCellGroup<PRISM.Adapters.ExchangeProductGridListCellData, PRISM.Exchange.ExchangeGoodsGridViewContext>
    {
    }
}

// Namespace: PRISM.Interactions.Exchange
public class ExchangeSelectionItemView : UnityEngine.MonoBehaviour
{
    private PRISM.Legacy.GashaProductItemPresenter productItem;
    private ENTERPRISE.UI.UITextMeshProUGUI itemNameText;
    private ENTERPRISE.OutGame.RewardItem exchangeItemIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI amountText;
    private ENTERPRISE.UI.UITextMeshProUGUI exchangeLimitText;
    private ENTERPRISE.OutGame.RewardItem rewardPieceItem;
    private ENTERPRISE.UI.UITextMeshProUGUI pieceLabelText;
    private ENTERPRISE.OutGame.RewardItem exchangeButtonItemIcon;
    private ENTERPRISE.UI.UIButton exchangeButton;
    private UnityEngine.UI.Image grayoutImage;
    private PRISM.Interactions.ViewStateChanger viewStateChanger;
    private UniRx.Subject<int> onClick;
    public System.IObservable<int> OnClickItemIndex { get; set; }
    public string ProductName { get; set; }
    public void SetUp(PRISM.Module.Networking.IProductWithAmountStatus productWithAmount, PRISM.Adapters.ExchangeProductTicketListViewModel vm, int index, PRISM.ResourceManagement.IResourceLoader resourceLoader, bool exchangeable);
    private PRISM.Module.Networking.IProductStatus _createPieceProduct(PRISM.Module.Networking.IProductStatus itemProduct);
    private void _setItemName(PRISM.Module.Networking.IProductStatus itemProduct);

    private class <>c__DisplayClass16_0
    {
        public PRISM.Interactions.Exchange.ExchangeSelectionItemView <>4__this;
        public int index;
        private void <SetUp>b__0();
    }
}

// Namespace: PRISM.Interactions.Exchange
public class ExchangeTabItemView : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITabButton tabButton;
    private UnityEngine.GameObject newBadge;
    public ENTERPRISE.UI.UITabButton TabButton { get; set; }
    public UnityEngine.GameObject NewBadge { get; set; }
    public void SetVisibleNewBadge(bool isVisible);
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=1995 402E2962053DC5C6E530A8DADC9D919078BCDAB2518A07902F947C43C7D9E9AA;
    private static __StaticArrayInitTypeSize=2767 B44523E43C773454651AD9DE16F814EF832B7D6E6408683D7396B5CBD91E1287;

    private struct __StaticArrayInitTypeSize=1995 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=2767 : System.ValueType
    {
    }
}
