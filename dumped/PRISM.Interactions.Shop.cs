
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
public class ShopLoginBonusPassRewardPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IShopLoginBonusPassRewardPopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private ENTERPRISE.UI.UITextMeshProUGUI messageText;
    private ENTERPRISE.OutGame.RewardItem rewardItem;
    private ENTERPRISE.UI.UITextMeshProUGUI validPeriodLabel;
    private ENTERPRISE.UI.UITextMeshProUGUI validPeriodText;
    private ENTERPRISE.UI.ToggleButton popupCheckToggleButton;
    private ENTERPRISE.UI.UITextMeshProUGUI popupOpenCheckLabel;
    private bool isOn;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClick;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    public void Initialize(int mstProductId);
    public void SetValidPeriodText(System.Nullable<System.DateTime> beginDate, System.Nullable<System.DateTime> endDate);
    public void SetUpItem(PRISM.Module.Networking.IProductStatus itemProduct, int amount, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private void <CreateFrameParameter>b__10_0();
    private void <CreateFrameParameter>b__10_1();
    private void <Initialize>b__19_0();
}

// Namespace: PRISM.Interactions
public class ShopPassDetailPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IShopPassDetailPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private ENTERPRISE.UI.UITextMeshProUGUI descriptionText;
    private UnityEngine.GameObject cautionView;
    private ENTERPRISE.UI.UITextMeshProUGUI cautionText;
    private string cautionStr;
    private int mstId;
    private string titleName;
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
    public void SetParameter(int itemMstId, string cautionStr);
    private void _updateParameter();
    private string GetDescriptiontext(int mstId);
    private void <CreateFrameParameter>b__0_0();
    private void <CreateFrameParameter>b__0_1();
}

// Namespace: PRISM.Interactions
public class ShopPassMultiRewardPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IShopPassMultiRewardPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private ENTERPRISE.UI.UITextMeshProUGUI messageText;
    private ENTERPRISE.UI.UITextMeshProUGUI validPeriodLabel;
    private ENTERPRISE.UI.UITextMeshProUGUI validPeriodText;
    private ENTERPRISE.UI.ToggleButton popupCheckToggleButton;
    private ENTERPRISE.UI.UITextMeshProUGUI popupOpenCheckLabel;
    private PRISM.Interactions.Exchange.ShopPassMultiRewardView passMultiReward;
    private bool isOn;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Initialize(int mstProductId, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProductWithAmountStatus> items, PRISM.ResourceManagement.IResourceLoader loader);
    public void SetValidPeriodText(System.Nullable<System.DateTime> beginDate, System.Nullable<System.DateTime> endDate);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <Initialize>b__10_0();
    private void <CreateFrameParameter>b__12_0();
    private void <CreateFrameParameter>b__12_1();
}

// Namespace: PRISM.Interactions
public class ShopPassPurchaseCompletePopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IShopPassPurchaseCompletePopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private static int purchasedMessageTextId;
    private ENTERPRISE.UI.UITextMeshProUGUI messageText;
    private UnityEngine.UI.RawImage itemIconImage;
    private ENTERPRISE.UI.UITextMeshProUGUI itemNameText;
    private PRISM.Interactions.ButtonView productDetailButton;
    private PRISM.Adapters.ShopPassPurchaseCompletePopupViewModel viewModel;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClick;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public System.IObservable<UniRx.Unit> OnProductDetailClicked { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void Assign(PRISM.Adapters.ShopPassPurchaseCompletePopupViewModel vm, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private Cysharp.Threading.Tasks.UniTask _setupParameterAsync();
    private void <CreateFrameParameter>b__12_0();
    private void <CreateFrameParameter>b__12_1();

    private struct <ShowAsync>d__18 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ShopPassPurchaseCompletePopupView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class ShopPurchaseHistoryDetailPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IShopPurchaseHistoryDetailPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.Shop.ShopPurchaseHistoryItemView shopItemView;
    private PRISM.Interactions.Shop.ShopPurchaseHistoryDetailItemContainerView mainItemContainerView;
    private PRISM.Interactions.Shop.ShopPurchaseHistoryDetailItemContainerView bonusItemContainerView;
    private PRISM.Adapters.ShopPurchaseHistoryListItemViewModel viewModel;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClick;
    private UniRx.Subject<UniRx.Unit> onPassDetail;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public System.IObservable<UniRx.Unit> OnPassDetail { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Adapters.ShopPurchaseHistoryListItemViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    private void Awake();
    private void <CreateFrameParameter>b__10_0();
    private void <CreateFrameParameter>b__10_1();

    private class <>c__DisplayClass19_0
    {
        public PRISM.Definitions.MasterData masterData;
        public PRISM.Interactions.ShopPurchaseHistoryDetailPopupView <>4__this;
        private System.Collections.Generic.IEnumerable<PRISM.Domain.ProductKeyWithAmount> <SetupAsync>b__0(PRISM.Module.Networking.IProductWithAmountStatus x);
        private System.Collections.Generic.IEnumerable<PRISM.Domain.ProductKeyWithAmount> <SetupAsync>b__1(PRISM.Module.Networking.IProductWithAmountStatus x);
        private void <SetupAsync>b__2(UniRx.Unit _);
        private void <SetupAsync>b__3(UniRx.Unit _);
    }

    private struct <SetupAsync>d__19 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ShopPurchaseHistoryDetailPopupView <>4__this;
        public PRISM.Adapters.ShopPurchaseHistoryListItemViewModel viewModel;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        private <>c__DisplayClass19_0 <>8__1;
        private PRISM.Domain.ProductKeyWithAmount[] <detailContentList>5__2;
        private PRISM.Domain.ProductKeyWithAmount[] <detailBonusList>5__3;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class ShopPurchaseHistoryPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IShopPurchaseHistoryPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private ENTERPRISE.UI.UITextMeshProUGUI cautionText;
    private UnityEngine.Transform itemListContent;
    private UnityEngine.GameObject itemViewPrefab;
    private UnityEngine.GameObject emptyViewTextObj;
    private System.Collections.Generic.List<PRISM.Interactions.Shop.ShopPurchaseHistoryItemView> itemList;
    private PRISM.Adapters.ShopPurchaseHistoryViewModel viewModel;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClick;
    private UniRx.Subject<int> onClickHistoryItem;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public System.IObservable<int> OnClickedHistoryItem { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void Awake();
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Adapters.ShopPurchaseHistoryViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public void UpdateView();
    private void <CreateFrameParameter>b__12_0();
    private void <CreateFrameParameter>b__12_1();
    private void <SetupAsync>b__22_0(int index);

    private struct <SetupAsync>d__22 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ShopPurchaseHistoryPopupView <>4__this;
        public PRISM.Adapters.ShopPurchaseHistoryViewModel viewModel;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        private int <i>5__2;
        private PRISM.Adapters.ShopPurchaseHistoryListItemViewModel <itemModel>5__3;
        private UnityEngine.GameObject <instanceGameObject>5__4;
        private PRISM.Interactions.Shop.ShopPurchaseHistoryItemView <historyView>5__5;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class ShopCostumeSellingView : UnityEngine.MonoBehaviour, PRISM.Adapters.Shop.IShopCostumeSellingView
{
    private PRISM.Interactions.Shop.ShopCostumeGroupCellGridScrollerView scroller;
    private UnityEngine.CanvasGroup canvasGroup;
    public System.IObservable<PRISM.Adapters.Shop.ShopCostumeGroupCellData> OnClickShowCostumeListButton { get; set; }
    public void Initialize(PRISM.Adapters.Shop.ShopCostumeSellingViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void Show(bool isShow);
    public void SetEmptyViewText(string text);
    private void <Initialize>b__4_0(System.Collections.Generic.IList<PRISM.Adapters.Shop.ShopCostumeGroupCellData> cellDataList);
}

// Namespace: PRISM.Interactions
public class ShopLimitedTimeLoginBonusPassSellingView : UnityEngine.MonoBehaviour, PRISM.Adapters.Shop.IShopLimitedTimeLoginBonusPassSellingView
{
    private UnityEngine.UI.RawImage backGroundImage;
    private ENTERPRISE.UI.UITextMeshProUGUI seasonPeriodText;
    private UnityEngine.UI.RawImage loginPassIconImage;
    private ENTERPRISE.UI.UITextMeshProUGUI passNameText;
    private ENTERPRISE.UI.UITextMeshProUGUI passPossesionText;
    private PRISM.Interactions.ButtonView passDetailButton;
    private ENTERPRISE.UI.UIButton purchaseButton;
    private ENTERPRISE.UI.UITextMeshProUGUI priceText;
    private UnityEngine.CanvasGroup canvasGroup;
    private PRISM.Adapters.Shop.ShopLimitedTimeLoginBonusPassProductModel currentProductModel;
    public System.IObservable<PRISM.Adapters.Shop.ShopLimitedTimeLoginBonusPassProductModel> OnClickPurchase { get; set; }
    public System.IObservable<System.ValueTuple<int, string>> OnClickDetail { get; set; }
    public void Show(bool isShow);
    public Cysharp.Threading.Tasks.UniTask UpdateAsync(PRISM.Adapters.Shop.ShopLimitedTimeLoginBonusPassSellingViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    private PRISM.Adapters.Shop.ShopLimitedTimeLoginBonusPassProductModel <get_OnClickPurchase>b__11_0(UniRx.Unit _);
    private System.ValueTuple<int, string> <get_OnClickDetail>b__13_0(UniRx.Unit _);
}

// Namespace: PRISM.Interactions.Exchange
public class ShopPassMultiRewardView : PRISM.EnhancedListView<PRISM.Module.Networking.IProductWithAmountStatus>
{
}

// Namespace: PRISM.Interactions.Exchange
public class ShopPassRewardViewCell : PRISM.EnhancedListViewCell<PRISM.Module.Networking.IProductWithAmountStatus>
{
    private PRISM.Interactions.RewardItemIcon rewardItem;
    private ENTERPRISE.UI.UITextMeshProUGUI itemNameText;
    private UnityEngine.GameObject spaceLine;
    private System.Threading.CancellationTokenSource cts;
    public void UpdateContent(PRISM.Module.Networking.IProductWithAmountStatus productAmount);
}

// Namespace: PRISM.Interactions.Shop
public class GoodsInformationButton : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView informationButtonView;
    private ENTERPRISE.UI.UITextMeshProUGUI buttonText;
    private PRISM.Domain.ProductKey productKey;
    public System.IObservable<PRISM.Domain.ProductKey> OnClickInformation { get; set; }
    public void Setup(PRISM.Domain.ProductKey product);
    private bool _isShowInformationButtonProduct(ProductType type);
    private string _setButtonLabel(ProductType type);
    private PRISM.Domain.ProductKey <get_OnClickInformation>b__4_0(UniRx.Unit _);
}

// Namespace: PRISM.Interactions.Shop
public class ShopChargeAlertPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.Shop.IShopChargeAlertPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private ENTERPRISE.UI.UITextMeshProUGUI alertDescriptionText;
    private ENTERPRISE.UI.UITextMeshProUGUI productPriceText;
    private ENTERPRISE.UI.UITextMeshProUGUI remainingChargeDescriptionText;
    private ENTERPRISE.UI.UITextMeshProUGUI remainingChargePriceText;
    private ENTERPRISE.UI.UITextMeshProUGUI chargeLimitDescriptionText;
    private ENTERPRISE.UI.UITextMeshProUGUI chargeLimitPriceText;
    private ENTERPRISE.UI.UITextMeshProUGUI cautionText;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void Initialize(PRISM.Adapters.Shop.ShopChargeAlertPopupViewModel viewModel);
    private static void _setPriceValueText(ENTERPRISE.UI.UITextMeshProUGUI textMeshPro, int price, PRISM.Definitions.LocalizationKey localizationKey);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__10_0();
    private void <CreateFrameParameter>b__10_1();
}

// Namespace: PRISM.Interactions.Shop
public class ShopConsentConfirmPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.Shop.IShopConsentConfirmPopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private ENTERPRISE.UI.UIButton termButton;
    private ENTERPRISE.UI.UITextMeshProUGUI termButtonLabel;
    private ENTERPRISE.UI.UITextMeshProUGUI descriptionText;
    private ENTERPRISE.UI.UITextMeshProUGUI cautionText;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public System.IObservable<UniRx.Unit> OnClickTermButton { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void Initialize();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__9_0();
    private void <CreateFrameParameter>b__9_1();
    private void <CreateFrameParameter>b__9_2();
}

// Namespace: PRISM.Interactions.Shop
public class ShopCostumeListPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.Shop.IShopCostumeListPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.Shop.ShopCostumeCellScrollerView scroller;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Interactions.PopupFrameParameter frameParameter;
    private System.Func<PRISM.Adapters.Shop.IShopProductModel, Cysharp.Threading.Tasks.UniTask<bool>> <OnClickPurchaseButtonFunc>k__BackingField;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public System.IObservable<PRISM.Adapters.Shop.IShopProductModel> OnClickDetailButton { get; set; }
    public System.IObservable<PRISM.Adapters.Shop.IShopProductModel> OnClickTryOnButton { get; set; }
    public System.Func<PRISM.Adapters.Shop.IShopProductModel, Cysharp.Threading.Tasks.UniTask<bool>> OnClickPurchaseButtonFunc { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void Initialize(PRISM.Adapters.Shop.ShopCostumeListPopupViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private Cysharp.Threading.Tasks.UniTaskVoid <Initialize>b__14_0(PRISM.Adapters.Shop.IShopProductModel productModel);
    private void <Initialize>b__14_1();
    private void <Initialize>b__14_2();

    private struct <<Initialize>b__14_0>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
        public PRISM.Interactions.Shop.ShopCostumeListPopupView <>4__this;
        public PRISM.Adapters.Shop.IShopProductModel productModel;
        private Awaiter<bool> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Shop
public class ShopGoodsDetailPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.Shop.IShopGoodsDetailPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.Shop.ShopGoodsSetItemContainer itemSetContainer;
    private PRISM.Interactions.Shop.ShopGoodsSetItemContainer bonusSetContainer;
    private UnityEngine.GameObject tabPanel;
    private ENTERPRISE.UI.UITabGroup tabGroup;
    private UnityEngine.GameObject cautionPanel;
    private ENTERPRISE.UI.UITextMeshProUGUI cautionText;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Interactions.PopupFrameParameter frameParameter;
    private bool isShowBonusContent;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public System.IObservable<PRISM.Domain.ProductKey> OnGoodsInformation { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void Initialize(PRISM.Adapters.Shop.ShopProductModelCore productModel, System.Collections.Generic.IReadOnlyList<PRISM.Domain.ProductKeyWithAmount> detailMainProducts, System.Collections.Generic.IReadOnlyList<PRISM.Domain.ProductKeyWithAmount> detailBonusProducts, PRISM.ResourceManagement.IResourceLoader loader);
    private void _switchView(int selectIndex);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <Initialize>b__14_0(int index, ENTERPRISE.UI.UITabGroup _);
    private void <Initialize>b__14_1();
    private void <Initialize>b__14_2();
}

// Namespace: PRISM.Interactions.Shop
public class ShopPassReceivePurchaseBenefitsPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IShopPassReceivePurchaseBenefitsPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.Shop.ShopGoodsSetItem itemPrefab;
    private UnityEngine.Transform itemParent;
    private PRISM.Adapters.ShopReceivePurchaseBenefitsPopupViewModel viewModel;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClick;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<int> terminateTask;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void Initialize(PRISM.Adapters.ShopReceivePurchaseBenefitsPopupViewModel viewModel);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void _updateViewAsync();
    private void <CreateFrameParameter>b__7_0();
    private void <CreateFrameParameter>b__7_1();
}

// Namespace: PRISM.Interactions.Shop
public class ShopPurchaseCompletePopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.Shop.IShopPurchaseCompletePopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private ENTERPRISE.UI.UITextMeshProUGUI messageText;
    private PRISM.Interactions.Shop.ShopPurchasePopupProductItem item;
    private UnityEngine.GameObject panelParent;
    private UnityEngine.GameObject purchaseAmountTextPanel;
    private ENTERPRISE.UI.UITextMeshProUGUI purchaseAmountText;
    private PRISM.Interactions.JewelPurchasePanelView jewelPurchasePanel;
    private PRISM.Interactions.Shop.ShopItemAmountPanelView itemAmountPanel;
    private PRISM.Interactions.Shop.ShopPurchaseLimitPanelView purchaseLimitPanel;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Interactions.PopupFrameParameter frameParameter;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public System.IObservable<UniRx.Unit> OnClickProductDetailButton { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.Shop.ShopPurchaseCompletePopupViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    private void _setOrderAmountPanel(PRISM.Adapters.Shop.ShopPurchaseCompletePopupViewModel viewModel);
    private void _setPurchaseLimitPanel(PRISM.Adapters.Shop.ShopPurchaseCompletePopupViewModel viewModel);
    private void _setJewelAmountPanel(PRISM.Adapters.Shop.ShopPurchaseCompletePopupViewModel viewModel);
    private void _setItemAmountPanel(PRISM.Adapters.Shop.ShopPurchaseCompletePopupViewModel viewModel);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <InitializeAsync>b__15_0();
    private void <InitializeAsync>b__15_1();
}

// Namespace: PRISM.Interactions.Shop
public class ShopPassPurchaseConfirmPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.Shop.IShopPassPurchaseConfirmPopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private ENTERPRISE.UI.UITextMeshProUGUI messageText;
    private PRISM.Interactions.Shop.ShopPurchasePopupProductItem item;
    private UnityEngine.GameObject validityPanelRoot;
    private UnityEngine.GameObject validityAutoLivePanelRoot;
    private ENTERPRISE.UI.UITextMeshProUGUI validityLabelText;
    private ENTERPRISE.UI.UITextMeshProUGUI validDayText;
    private ENTERPRISE.UI.UITextMeshProUGUI validityText;
    private ENTERPRISE.UI.UITextMeshProUGUI validityDayPeriodText;
    private ENTERPRISE.UI.UITextMeshProUGUI validityAutoLivePeriodText;
    private ENTERPRISE.UI.UITextMeshProUGUI priceText;
    private ENTERPRISE.UI.UIButton specifiedCommercialTransactionActButton;
    private ENTERPRISE.UI.UIButton actOnSettlementButton;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public System.IObservable<UniRx.Unit> OnClickProductDetailButton { get; set; }
    public System.IObservable<UniRx.Unit> OnActOnSettlementClicked { get; set; }
    public System.IObservable<UniRx.Unit> OnClickSpecifiedCommercialTransactionButton { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.Shop.ShopPassPurchaseConfirmContentViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    private void _setPricePanel(PRISM.Adapters.Shop.ShopPassPurchaseConfirmContentViewModel viewModel);
    private void _setValidPeriodPanel(PRISM.Adapters.Shop.ShopPassPurchaseConfirmContentViewModel viewModel);
    private void _setValidAutoLivePeriodPanel(PRISM.Adapters.Shop.ShopPassPurchaseConfirmContentViewModel viewModel);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__21_0();
    private void <CreateFrameParameter>b__21_1();
    private void <CreateFrameParameter>b__21_2();
}

// Namespace: PRISM.Interactions.Shop
public class ShopItemAmountPanelView : UnityEngine.MonoBehaviour
{
    private UnityEngine.GameObject panel;
    private PRISM.Common.ValueFluctionTextPair itemFluctuationTextPair;
    public void UpdateView(System.ValueTuple<long, long> itemAmount, bool needShowItemAmountPanel);
}

// Namespace: PRISM.Interactions.Shop
public class ShopOrderCountSelectorPanelView : UnityEngine.MonoBehaviour
{
    private UnityEngine.GameObject purchaseAmountPanel;
    private ENTERPRISE.UI.UITextMeshProUGUI purchaseAmountText;
    private PRISM.Interactions.ButtonView minimumButton;
    private PRISM.Interactions.ButtonView minusButton;
    private PRISM.Interactions.ButtonView plusButton;
    private PRISM.Interactions.ButtonView maximumButton;
    public System.IObservable<UniRx.Unit> OnClickMinimumButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickOrRepeatPressMinusButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickOrRepeatPressPlusButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickMaximumButton { get; set; }
    public void UpdateView(int orderCount, bool isMinimumButtonEnable, bool isMinusButtonEnable, bool isPlusButtonEnable, bool isMaximumButtonEnable);
}

// Namespace: PRISM.Interactions.Shop
public class ShopPurchaseLimitPanelView : UnityEngine.MonoBehaviour
{
    private UnityEngine.GameObject purchaseLimitPanel;
    private ENTERPRISE.UI.UITextMeshProUGUI currentPurchaseLimitText;
    private ENTERPRISE.UI.UITextMeshProUGUI afterPurchaseLimitText;
    public void UpdateView(bool hasPurchaseLimit, System.ValueTuple<int, int> purchaseLimitCount);
    public void UpdateView(bool hasPurchaseLimit, string beforeLimitCount, string afterLimitCount);
}

// Namespace: PRISM.Interactions.Shop
public class ShopPurchaseWithCashConfirmPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IShopPurchaseWithCashConfirmPopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private ENTERPRISE.UI.UITextMeshProUGUI messageText;
    private PRISM.Interactions.Shop.ShopPurchasePopupProductItem item;
    private ENTERPRISE.UI.UITextMeshProUGUI cashPriceText;
    private PRISM.Interactions.Shop.ShopPurchaseLimitPanelView purchaseLimitPanel;
    private PRISM.Interactions.ButtonView specifiedCommercialTransactionActButton;
    private PRISM.Interactions.ButtonView actOnSettlementButton;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public System.IObservable<UniRx.Unit> OnClickProductDetailButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickSpecifiedCommercialTransactionActButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickActOnSettlementButton { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.Shop.ShopPurchaseWithCashConfirmPopupViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__7_0();
    private void <CreateFrameParameter>b__7_1();
    private void <CreateFrameParameter>b__7_2();
}

// Namespace: PRISM.Interactions.Shop
public class ShopPurchaseWithJewelConfirmPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.Shop.IShopPurchaseWithJewelConfirmPopupView, PRISM.Adapters.IClosablePopupFrame<PRISM.Adapters.Shop.ShopPurchaseWithJewelConfirmPopupResult>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<PRISM.Adapters.Shop.ShopPurchaseWithJewelConfirmPopupResult>
{
    private UnityEngine.GameObject messageTextPanel;
    private ENTERPRISE.UI.UITextMeshProUGUI messageText;
    private PRISM.Interactions.Shop.ShopPurchasePopupProductItem item;
    private PRISM.Interactions.Shop.ShopOrderCountSelectorPanelView orderCountSelectorPanel;
    private PRISM.Interactions.JewelPurchasePanelView jewelPurchasePanel;
    private PRISM.Interactions.Shop.ShopItemAmountPanelView itemAmountPanel;
    private PRISM.Interactions.Shop.ShopPurchaseLimitPanelView limitPanel;
    private PRISM.Interactions.ButtonView specifiedCommercialTransactionActButton;
    private UnityEngine.GameObject cautionPanel;
    private ENTERPRISE.UI.UITextMeshProUGUI cautionText;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<PRISM.Adapters.Shop.ShopPurchaseWithJewelConfirmPopupResult> onClosed;
    private PRISM.Interactions.PopupFrameParameter frameParameter;
    private PRISM.Interactions.IPopupFrameView parent;
    public System.IObservable<UniRx.Unit> OnClickProductDetailButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickSpecifiedCommercialTransactionActButton { get; set; }
    public Cysharp.Threading.Tasks.UniTask<PRISM.Adapters.Shop.ShopPurchaseWithJewelConfirmPopupResult> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.Shop.ShopPurchaseWithJewelOrderCountModel orderCountModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    private void _updateOrderCountSelectorPanel(PRISM.Adapters.Shop.ShopOrderCountSelectorPanelViewModel orderCountSelectorPanelViewModel);
    private void _updateJewelPurchasePanelView(PRISM.Adapters.Shop.ShopJewelPurchasePanelViewModel jewelPurchasePanelViewModel);
    private void _updateItemAmountPanelView(PRISM.Adapters.Shop.ShopPurchaseWithJewelOrderCountModel orderCountModel);
    private void _updateLimitPanelView(PRISM.Adapters.Shop.ShopPurchaseWithJewelOrderCountModel orderCountModel);
    private void _setUpCautionText(InGameCurrencyType jewelPurchaseType, bool isJewelShortage);
    private ButtonInfoParameter[] _createButtonParameters(PRISM.Adapters.Shop.ShopPurchaseWithJewelOrderCountModel orderCountModel, bool isJewelShortage, System.Nullable<PRISM.Definitions.LocalizationKey> purchaseButtonTextKey);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();

    private class <>c__DisplayClass19_0
    {
        public PRISM.Interactions.Shop.ShopPurchaseWithJewelConfirmPopupView <>4__this;
        public PRISM.Adapters.Shop.ShopOrderCountSelectorPanelViewModel orderCountSelectorPanelViewModel;
        public PRISM.Adapters.Shop.ShopJewelPurchasePanelViewModel jewelPurchasePanelViewModel;
        public PRISM.Adapters.Shop.ShopPurchaseWithJewelOrderCountModel orderCountModel;
        private void <InitializeAsync>b__5();
        private void <InitializeAsync>b__0(UniRx.Unit _);
        private void <InitializeAsync>b__1(UniRx.Unit _);
        private void <InitializeAsync>b__2(UniRx.Unit _);
        private void <InitializeAsync>b__3(UniRx.Unit _);
        private void <InitializeAsync>b__4(int _);
    }

    private class <>c__DisplayClass25_0
    {
        public PRISM.Interactions.Shop.ShopPurchaseWithJewelConfirmPopupView <>4__this;
        public PRISM.Adapters.Shop.ShopPurchaseWithJewelOrderCountModel orderCountModel;
        private void <_createButtonParameters>b__0();
        private void <_createButtonParameters>b__1();
        private void <_createButtonParameters>b__2();
    }
}

// Namespace: PRISM.Interactions.Shop
public class ShopPurchaseHistoryDetailItemContainerView : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI titleText;
    private PRISM.Interactions.Shop.ShopGoodsSetItem itemPrefab;
    private UnityEngine.Transform itemParent;
    private UnityEngine.GameObject noItemLabel;
    private UniRx.Subject<UniRx.Unit> onPassDetailSubject;
    public System.IObservable<UniRx.Unit> OnPassDetail { get; set; }
    public void Setup(string title, System.Collections.Generic.IReadOnlyList<PRISM.Domain.ProductKeyWithAmount> itemArray);
    private void Awake();
    private void <Setup>b__7_0(UniRx.Unit _);
}

// Namespace: PRISM.Interactions.Shop
public class ShopPurchaseHistoryItemView : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI purchasedDateText;
    private ENTERPRISE.UI.UITextMeshProUGUI itemTitleText;
    private ENTERPRISE.UI.UITextMeshProUGUI jewelText;
    private ENTERPRISE.UI.UITextMeshProUGUI freeJewelText;
    private ENTERPRISE.UI.UITextMeshProUGUI purchaseCountText;
    private ENTERPRISE.UI.UITextMeshProUGUI cashText;
    private ENTERPRISE.UI.UIButton detailButton;
    private UnityEngine.UI.RawImage itemIcon;
    private UniRx.Subject<int> onClick;
    public System.IObservable<int> OnClickHistoryItem { get; set; }
    private void Awake();
    public Cysharp.Threading.Tasks.UniTask Setup(PRISM.Adapters.ShopPurchaseHistoryListItemViewModel itemViewModel, int index, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public void SetItemText(string itemName, string dateStr);
    public void SetPayText(int paidjewel, int freeJewel, int cash);
    public void SetPurchaseCountText(int purchaseCount);

    private class <>c__DisplayClass12_0
    {
        public PRISM.Interactions.Shop.ShopPurchaseHistoryItemView <>4__this;
        public int index;
        private void <Setup>b__0();
    }

    private struct <Setup>d__12 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Shop.ShopPurchaseHistoryItemView <>4__this;
        public int index;
        public PRISM.Adapters.ShopPurchaseHistoryListItemViewModel itemViewModel;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Shop
public class ShopPurchasePopupProductItem : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.RawImage itemIconImage;
    private ENTERPRISE.UI.UITextMeshProUGUI productNameText;
    private PRISM.Interactions.ButtonView productDetailButton;
    public System.IObservable<UniRx.Unit> OnClickProductDetailButton { get; set; }
    public void SetProductName(string productName);
    public Cysharp.Threading.Tasks.UniTask SetProductIconAsync(PRISM.Domain.ProductKey productKey, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask SetProductIconAsGeneralImageAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
}

// Namespace: PRISM.Interactions.Shop
public class ShopReceiveBonusPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.Shop.IShopReceiveBonusPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.Shop.ShopGoodsSetItem itemPrefab;
    private UnityEngine.Transform itemParent;
    private ENTERPRISE.UI.UITextMeshProUGUI descriptionText;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private UniRx.Subject<PRISM.Domain.ProductKey> onGoodsInformationSubject;
    private PRISM.Interactions.IPopupFrameView parent;
    public System.IObservable<PRISM.Domain.ProductKey> OnGoodsInformation { get; set; }
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    private void Awake();
    public void Initialize(System.Collections.Generic.IReadOnlyCollection<PRISM.Domain.ProductKeyWithAmount> bonusProducts, int purchaseCount);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__9_0();
    private void <CreateFrameParameter>b__9_1();
    private void <Initialize>b__11_0(PRISM.Domain.ProductKey product);
}

// Namespace: PRISM.Interactions.Shop
public class ShopRegisterBirthdayCompletePopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IShopRegisterBirthdayCompletePopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private ENTERPRISE.UI.UITextMeshProUGUI birthdayText;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Initialize(int year, int month, int day);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__5_0();
    private void <CreateFrameParameter>b__5_1();
}

// Namespace: PRISM.Interactions.Shop
public class ShopRegisterBirthdayConfirmPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IShopRegisterBirthdayConfirmPopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private ENTERPRISE.UI.UITextMeshProUGUI birthdayText;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Initialize(int year, int month, int day);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__5_0();
    private void <CreateFrameParameter>b__5_1();
    private void <CreateFrameParameter>b__5_2();
}

// Namespace: PRISM.Interactions.Shop
public class ShopRegisterBirthdayPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.Shop.IShopRegisterBirthdayPopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private PRISM.CommonInputFieldTMP inputField;
    private ENTERPRISE.UI.UITextMeshProUGUI inputLengthText;
    private ENTERPRISE.UI.UIButton termsButton;
    private ENTERPRISE.UI.UITextMeshProUGUI termsButtonLabel;
    private ENTERPRISE.UI.UITextMeshProUGUI descriptionUnder16;
    private ENTERPRISE.UI.UITextMeshProUGUI description16To18;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClosed;
    private PRISM.Adapters.Shop.ShopRegisterBirthdayModel model;
    private PRISM.Adapters.Shop.OnDecideRegisterBirthdayPopup <OnDecideRegisterBirthdayPopup>k__BackingField;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public System.IObservable<UniRx.Unit> OnTermsButtonClicked { get; set; }
    public PRISM.Adapters.Shop.OnDecideRegisterBirthdayPopup OnDecideRegisterBirthdayPopup { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Initialize(PRISM.Adapters.Shop.ShopRegisterBirthdayModel model);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    private Cysharp.Threading.Tasks.UniTask _executeAfterDecideSequenceAsync(System.Threading.CancellationToken ct);
    private void _setActiveRegisterButton(bool isActive);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__17_0();
    private void <CreateFrameParameter>b__17_1();
    private void <CreateFrameParameter>b__17_2();

    private class <>c__DisplayClass16_0
    {
        public PRISM.Interactions.Shop.ShopRegisterBirthdayPopupView <>4__this;
        public PRISM.Adapters.Shop.ShopRegisterBirthdayModel model;
        private void <Initialize>b__0(string inputValue);
    }

    private struct <_executeAfterDecideSequenceAsync>d__18 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Shop.ShopRegisterBirthdayPopupView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter<bool> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Shop
public class ResourceLoaderExtensions
{
    public static Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadShopProductIconAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, ShopItemType shopItemType, int mstItemId, ImageType type, bool isStore, System.Threading.CancellationToken ct);
    public static Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadShopMultiProductSmallIconAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
}

// Namespace: PRISM.Interactions.Shop
public class ShopCostumeGroupCellGridScrollerView : PRISM.Interactions.GridView<PRISM.Interactions.Shop.ShopCostumeGroupCellView, PRISM.Adapters.Shop.ShopCostumeGroupCellData, PRISM.Interactions.GridViewContextWithClick<PRISM.Adapters.Shop.ShopCostumeGroupCellData>>
{
    private ENTERPRISE.UI.UITextMeshProUGUI emptyViewText;
    public System.IObservable<PRISM.Adapters.Shop.ShopCostumeGroupCellData> OnClickShowCostumeListButton { get; set; }
    public void SetEmptyViewText(string str);
    protected void Initialize();
    protected void SetupCellTemplate();

    private class CellGroup : DefaultCellGroup<PRISM.Adapters.Shop.ShopCostumeGroupCellData, PRISM.Interactions.GridViewContextWithClick<PRISM.Adapters.Shop.ShopCostumeGroupCellData>>
    {
    }
}

// Namespace: PRISM.Interactions.Shop
public class ShopCostumeGroupCellView : PRISM.Interactions.GridViewCell<PRISM.Adapters.Shop.ShopCostumeGroupCellData, PRISM.Interactions.GridViewContextWithClick<PRISM.Adapters.Shop.ShopCostumeGroupCellData>>
{
    private UnityEngine.GameObject newBadge;
    private UnityEngine.UI.RawImage iconImage;
    private ENTERPRISE.UI.ButtonBase showCostumeListButton;
    private System.IDisposable buttonDisposable;
    private System.Threading.CancellationTokenSource cts;
    public void UpdateContent(PRISM.Adapters.Shop.ShopCostumeGroupCellData data);

    private class <>c__DisplayClass5_0
    {
        public PRISM.Interactions.Shop.ShopCostumeGroupCellView <>4__this;
        public PRISM.Adapters.Shop.ShopCostumeGroupCellData data;
        private void <UpdateContent>b__0(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.Shop
public class ShopCostumeCellScrollerView : PRISM.EnhancedListView<PRISM.Adapters.Shop.ShopSellingCellBaseViewModel, PRISM.Interactions.Shop.ShopCostumeCellScrollerViewContext>
{
    public System.IObservable<PRISM.Adapters.Shop.IShopProductModel> OnClickDetailButton { get; set; }
    public System.IObservable<PRISM.Adapters.Shop.IShopProductModel> OnClickPurchaseButton { get; set; }
    public System.IObservable<PRISM.Adapters.Shop.IShopProductModel> OnClickTryOnButton { get; set; }
}

// Namespace: PRISM.Interactions.Shop
public class ShopCostumeCellScrollerViewContext : PRISM.EnhancedListViewContext, System.IDisposable
{
    public UniRx.Subject<PRISM.Adapters.Shop.IShopProductModel> OnClickDetailButton;
    public UniRx.Subject<PRISM.Adapters.Shop.IShopProductModel> OnClickPurchaseButton;
    public UniRx.Subject<PRISM.Adapters.Shop.IShopProductModel> OnClickTryOnButton;
    public void Dispose();
}

// Namespace: PRISM.Interactions.Shop
public class ShopCostumeCellView : PRISM.EnhancedListViewCell<PRISM.Adapters.Shop.ShopSellingCellBaseViewModel, PRISM.Interactions.Shop.ShopCostumeCellScrollerViewContext>
{
    private PRISM.Interactions.Shop.ShopSellingCellBaseView cellBase;
    private UnityEngine.UI.Button tryOnButton;
    private UniRx.CompositeDisposable disposables;
    private System.Threading.CancellationTokenSource cts;
    public void UpdateContent(PRISM.Adapters.Shop.ShopSellingCellBaseViewModel viewModel);

    private class <>c__DisplayClass4_0
    {
        public PRISM.Interactions.Shop.ShopCostumeCellView <>4__this;
        public PRISM.Adapters.Shop.ShopSellingCellBaseViewModel viewModel;
        private void <UpdateContent>b__0(UniRx.Unit _);
        private void <UpdateContent>b__1(UniRx.Unit _);
        private void <UpdateContent>b__2(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.Shop
public class ShopDmmStoreProductIconInjector : PRISM.Adapters.Shop.IShopDmmStoreProductIconInjector
{
    private ENTERPRISE.Purchase.PurchaseUnityDmmGames purchaseUnityDmmGames;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    private System.Collections.Generic.Dictionary<string, string> dmmIconKeys;
    public Cysharp.Threading.Tasks.UniTask InjectIfNeededAsync(string productId, string dmmStoreIconKey, System.Threading.CancellationToken ct);

    private struct <InjectIfNeededAsync>d__4 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public string dmmStoreIconKey;
        public PRISM.Interactions.Shop.ShopDmmStoreProductIconInjector <>4__this;
        public string productId;
        public System.Threading.CancellationToken ct;
        private Awaiter<UnityEngine.Texture2D> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Shop
public class ShopDmmStoreProductIconInjectorSilent : PRISM.Adapters.Shop.IShopDmmStoreProductIconInjector
{
    public Cysharp.Threading.Tasks.UniTask InjectIfNeededAsync(string productId, string dmmStoreIconKey, System.Threading.CancellationToken ct);
}

// Namespace: PRISM.Interactions.Shop
public class ShopGoodsCellGridScrollerView : PRISM.Interactions.GridView<PRISM.Interactions.Shop.ShopGoodsCellView, PRISM.Adapters.Shop.ShopSellingCellBaseViewModel, PRISM.Interactions.Shop.ShopGoodsCellGridScrollerViewContext>
{
    private ENTERPRISE.UI.UITextMeshProUGUI emptyViewText;
    public System.IObservable<PRISM.Adapters.Shop.IShopProductModel> OnClickPurchaseButton { get; set; }
    public System.IObservable<PRISM.Adapters.Shop.IShopProductModel> OnClickDetailButton { get; set; }
    public void SetEmptyViewText(string str);
    protected void Initialize();
    protected void SetupCellTemplate();

    private class CellGroup : DefaultCellGroup<PRISM.Adapters.Shop.ShopSellingCellBaseViewModel, PRISM.Interactions.Shop.ShopGoodsCellGridScrollerViewContext>
    {
    }
}

// Namespace: PRISM.Interactions.Shop
public class ShopGoodsCellGridScrollerViewContext : PRISM.Interactions.GridViewContext
{
    private UniRx.Subject<PRISM.Adapters.Shop.IShopProductModel> <OnClickPurchaseButton>k__BackingField;
    private UniRx.Subject<PRISM.Adapters.Shop.IShopProductModel> <OnClickDetailButton>k__BackingField;
    public UniRx.Subject<PRISM.Adapters.Shop.IShopProductModel> OnClickPurchaseButton { get; set; }
    public UniRx.Subject<PRISM.Adapters.Shop.IShopProductModel> OnClickDetailButton { get; set; }
    public void Dispose();
}

// Namespace: PRISM.Interactions.Shop
public class ShopGoodsCellView : PRISM.Interactions.GridViewCell<PRISM.Adapters.Shop.ShopSellingCellBaseViewModel, PRISM.Interactions.Shop.ShopGoodsCellGridScrollerViewContext>
{
    private PRISM.Interactions.Shop.ShopSellingCellBaseView cellBase;
    private UniRx.CompositeDisposable disposables;
    private System.Threading.CancellationTokenSource cts;
    public void UpdateContent(PRISM.Adapters.Shop.ShopSellingCellBaseViewModel viewModel);
    private void Awake();

    private class <>c__DisplayClass3_0
    {
        public PRISM.Interactions.Shop.ShopGoodsCellView <>4__this;
        public PRISM.Adapters.Shop.ShopSellingCellBaseViewModel viewModel;
        private void <UpdateContent>b__0(UniRx.Unit _);
        private void <UpdateContent>b__1(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.Shop
public class ShopGoodsSetItem : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.OutGame.RewardItem rewardItem;
    private ENTERPRISE.UI.UITextMeshProUGUI itemNameText;
    private ENTERPRISE.UI.UITextMeshProUGUI amountText;
    private UnityEngine.GameObject spaceLine;
    private PRISM.Interactions.Shop.GoodsInformationButton goodsInformationButton;
    private UniRx.Subject<UniRx.Unit> onPassDetailSubject;
    public System.IObservable<UniRx.Unit> OnOpenPassDetail { get; set; }
    public System.IObservable<PRISM.Domain.ProductKey> OnGoodsInformation { get; set; }
    public void Setup(PRISM.Domain.ProductKey product, int amount, bool displaySpaceLine, bool enableInfoButton);
    private void Awake();
    private void <Setup>b__10_0();
}

// Namespace: PRISM.Interactions.Shop
public class ShopGoodsSetItemContainer : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI titleText;
    private PRISM.Interactions.Shop.ShopGoodsSetItem itemPrefab;
    private UnityEngine.Transform itemParent;
    private UnityEngine.GameObject noItemLabel;
    private UniRx.Subject<PRISM.Domain.ProductKey> onGoodsInformationSubject;
    public System.IObservable<PRISM.Domain.ProductKey> OnGoodsInformation { get; set; }
    private void Awake();
    public void Setup(string title, System.Collections.Generic.IReadOnlyList<PRISM.Domain.ProductKeyWithAmount> products);
    private void <Setup>b__8_0(PRISM.Domain.ProductKey product);
}

// Namespace: PRISM.Interactions.Shop
public class ShopOverlayView : PRISM.Interactions.OverlayViewWithCloseButton, PRISM.Adapters.Shop.IShopOverlayView, PRISM.Adapters.IClosableOverlayView<UniRx.Unit>, PRISM.Adapters.IOverlayView, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private ENTERPRISE.UI.UITextMeshProUGUI titleLabelText;
    private PRISM.Interactions.Shop.ShopTabGroupView tabGroupView;
    private PRISM.Interactions.Shop.ShopGoodsSellingView jewelSellingView;
    private PRISM.Interactions.Shop.ShopGoodsSellingView itemSellingView;
    private PRISM.Interactions.ShopCostumeSellingView costumeSellingView;
    private PRISM.Interactions.Shop.ShopSeasonPassSellingView seasonPassSellingView;
    private PRISM.Interactions.Shop.ShopLoginBonusPassSellingView loginPassSellingView;
    private PRISM.Interactions.ShopLimitedTimeLoginBonusPassSellingView limitedLoginPassView;
    private ENTERPRISE.UI.UIButton actOnSettlementButton;
    private ENTERPRISE.UI.UIButton specifiedCommercialTransactionActButton;
    private ENTERPRISE.UI.UIButton purchaseHistoryButton;
    private ENTERPRISE.UI.UITextMeshProUGUI paidJewelText;
    private ENTERPRISE.UI.UITextMeshProUGUI freeJewelText;
    private UnityEngine.CanvasGroup canvasGroup;
    private System.IDisposable backKeyDisposable;
    public PRISM.Adapters.Shop.IShopTabGroupView TabGroupView { get; set; }
    public PRISM.Adapters.Shop.IShopGoodsSellingView JewelSellingView { get; set; }
    public PRISM.Adapters.Shop.IShopGoodsSellingView ItemSellingView { get; set; }
    public PRISM.Adapters.Shop.IShopCostumeSellingView CostumeSellingView { get; set; }
    public PRISM.Adapters.Shop.IShopSeasonPassSellingView SeasonPassSellingView { get; set; }
    public PRISM.Adapters.Shop.IShopLoginBonusPassSellingView LoginBonusPassView { get; set; }
    public PRISM.Adapters.Shop.IShopLimitedTimeLoginBonusPassSellingView LimitedLoginBonusPassSellingView { get; set; }
    public System.IObservable<UniRx.Unit> OnActOnSettlementClicked { get; set; }
    public System.IObservable<UniRx.Unit> OnSpecifiedCommercialTransactionClick { get; set; }
    public System.IObservable<UniRx.Unit> OnPurchaseHistoryClick { get; set; }
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public PRISM.Adapters.Shop.IShopDmmStoreProductIconInjector CreateDmmStoreProductIconInjector(ENTERPRISE.Purchase.IPurchase purchase, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void UpdateJewelAmount(PRISM.Domain.Jewel jewel);
    private void Awake();
}

// Namespace: PRISM.Interactions.Shop
public class ShopGoodsSellingView : UnityEngine.MonoBehaviour, PRISM.Adapters.Shop.IShopGoodsSellingView
{
    private PRISM.Interactions.Shop.ShopGoodsCellGridScrollerView scroller;
    private UnityEngine.CanvasGroup canvasGroup;
    public System.IObservable<PRISM.Adapters.Shop.IShopProductModel> OnClickPurchaseButton { get; set; }
    public System.IObservable<PRISM.Adapters.Shop.IShopProductModel> OnClickDetailButton { get; set; }
    public void Initialize(PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void Show(bool isShow);
    public void SetEmptyViewText(string text);
    public void UpdateView(System.Collections.Generic.IList<PRISM.Adapters.Shop.ShopSellingCellBaseViewModel> viewModels);
}

// Namespace: PRISM.Interactions.Shop
public class ShopLoginBonusPassSellingView : UnityEngine.MonoBehaviour, PRISM.Adapters.Shop.IShopLoginBonusPassSellingView
{
    private UnityEngine.UI.RawImage backGroundImage;
    private ENTERPRISE.UI.UITextMeshProUGUI seasonPeriodText;
    private UnityEngine.UI.RawImage loginPassIconImage;
    private ENTERPRISE.UI.UITextMeshProUGUI passNameText;
    private ENTERPRISE.UI.UITextMeshProUGUI passPossesionText;
    private PRISM.Interactions.ButtonView passDetailButton;
    private ENTERPRISE.UI.UIButton purchaseButton;
    private ENTERPRISE.UI.UITextMeshProUGUI priceText;
    private UnityEngine.CanvasGroup canvasGroup;
    private PRISM.Adapters.Shop.ShopLoginBonusPassProductModel currentProductModel;
    public System.IObservable<PRISM.Adapters.Shop.ShopLoginBonusPassProductModel> OnClickPurchase { get; set; }
    public System.IObservable<System.ValueTuple<int, string>> OnClickDetail { get; set; }
    public void Show(bool isShow);
    public Cysharp.Threading.Tasks.UniTask UpdateAsync(PRISM.Adapters.Shop.ShopLoginBonusPassSellingViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    private PRISM.Adapters.Shop.ShopLoginBonusPassProductModel <get_OnClickPurchase>b__11_0(UniRx.Unit _);
    private System.ValueTuple<int, string> <get_OnClickDetail>b__13_0(UniRx.Unit _);
}

// Namespace: PRISM.Interactions.Shop
public class ShopSeasonPassSellingView : UnityEngine.MonoBehaviour, PRISM.Adapters.Shop.IShopSeasonPassSellingView
{
    private UnityEngine.UI.RawImage backGroundImage;
    private UnityEngine.UI.Image seasonLogoImage;
    private ENTERPRISE.UI.UITextMeshProUGUI seasonPeriodLabel;
    private ENTERPRISE.UI.UITextMeshProUGUI seasonPeriodText;
    private ENTERPRISE.UI.UIButton seasonMissionButton;
    private UnityEngine.UI.RawImage seasonPassIconImage;
    private ENTERPRISE.UI.UITextMeshProUGUI passNameText;
    private ENTERPRISE.UI.UITextMeshProUGUI passPossesionText;
    private PRISM.Interactions.ButtonView passDetailButton;
    private ENTERPRISE.UI.UIButton purchaseButton;
    private ENTERPRISE.UI.UITextMeshProUGUI priceText;
    private UnityEngine.CanvasGroup canvasGroup;
    private PRISM.Adapters.Shop.ShopSeasonPassProductModel currentProductModel;
    public System.IObservable<PRISM.Adapters.Shop.ShopSeasonPassProductModel> OnClickPurchase { get; set; }
    public System.IObservable<System.ValueTuple<int, string>> OnClickDetail { get; set; }
    public System.IObservable<UniRx.Unit> OnClickSeasonMission { get; set; }
    public void Show(bool isShow);
    public Cysharp.Threading.Tasks.UniTask UpdateAsync(PRISM.Adapters.Shop.ShopSeasonPassSellingViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    private PRISM.Adapters.Shop.ShopSeasonPassProductModel <get_OnClickPurchase>b__14_0(UniRx.Unit _);
    private System.ValueTuple<int, string> <get_OnClickDetail>b__16_0(UniRx.Unit _);
}

// Namespace: PRISM.Interactions.Shop
public class ShopSellingCellBaseView : UnityEngine.MonoBehaviour
{
    private UnityEngine.GameObject newIcon;
    private UnityEngine.UI.RawImage iconImage;
    private UnityEngine.UI.Button purchaseButton;
    private PRISM.Interactions.ButtonView detailButton;
    private ENTERPRISE.UI.UITextMeshProUGUI priceText;
    private UnityEngine.GameObject limitPanel;
    private ENTERPRISE.UI.UITextMeshProUGUI expireDateText;
    private ENTERPRISE.UI.UITextMeshProUGUI purchaseCountLimitText;
    private UnityEngine.GameObject alreadyAcquiredLabelPanel;
    private ENTERPRISE.UI.UITextMeshProUGUI alreadyAcquiredText;
    private UnityEngine.GameObject grayOutImage;
    private System.IDisposable timerDisposable;
    public System.IObservable<UniRx.Unit> OnClickPurchaseButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickDetailButton { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.Shop.ShopSellingCellBaseViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);

    private class <>c__DisplayClass16_0
    {
        public PRISM.Interactions.Shop.ShopSellingCellBaseView <>4__this;
        public PRISM.Adapters.Shop.ShopSellingCellBaseViewModel viewModel;
        private void <InitializeAsync>b__0(long _);
    }
}

// Namespace: PRISM.Interactions.Shop
public class ShopTabGroupView : UnityEngine.MonoBehaviour, PRISM.Adapters.Shop.IShopTabGroupView
{
    private UnityEngine.Transform tabParent;
    private PRISM.Interactions.Shop.ShopTabView tabPrefab;
    public void Initialize(System.Collections.Generic.IEnumerable<PRISM.Adapters.Shop.ShopTabViewModel> tabViewModels, UniRx.ReactiveProperty<int> selectedTabIndex);
    private PRISM.Interactions.ButtonView <Initialize>b__2_0(PRISM.Adapters.Shop.ShopTabViewModel tabViewModel);
}

// Namespace: PRISM.Interactions.Shop
public class ShopTabView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView tabButton;
    private ENTERPRISE.UI.UITextMeshProUGUI tabText;
    private UnityEngine.GameObject newBadge;
    public PRISM.Interactions.ButtonView TabButton { get; set; }
    public void Initialize(PRISM.Adapters.Shop.ShopTabViewModel viewModel);
    private void <Initialize>b__5_0(bool isNew);
    private void <Initialize>b__5_1(bool isVisible);
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=4705 8375FE89D0285A54D7F649A8F0734FD0166A9D7F8FE9975CC53D60FCB7C74416;
    private static __StaticArrayInitTypeSize=2940 E22DB68D54F254D947EF91FA942259ADB5AEA10D77C770239FD2BCC5D9181C1A;

    private struct __StaticArrayInitTypeSize=2940 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=4705 : System.ValueType
    {
    }
}
