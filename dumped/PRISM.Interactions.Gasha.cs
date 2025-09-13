
private class <Module>
{
}

private class <>f__AnonymousType0`2<<price>j__TPar, <tokenArea>j__TPar>
{
    private <price>j__TPar <price>i__Field;
    private <tokenArea>j__TPar <tokenArea>i__Field;
    public <price>j__TPar price { get; set; }
    public <tokenArea>j__TPar tokenArea { get; set; }
    public bool Equals(object value);
    public int GetHashCode();
    public string ToString();
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
public class GashaEffectConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.GashaEffectArgument>, PRISM.Adapters.IGashaEffectConnector
{
    protected PRISM.Adapters.GashaEffectArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
}

// Namespace: PRISM.Interactions
public class GashaBonusAcquisitionPopupView : UnityEngine.MonoBehaviour, PRISM.Adapters.IGashaBonusAcquisitionPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>, PRISM.Interactions.IPopupContent
{
    private ENTERPRISE.OutGame.RewardItem rewardItemPrefab;
    private UnityEngine.Transform itemParent;
    private UnityEngine.UI.GridLayoutGroup gridLayoutGroup;
    private ENTERPRISE.UI.UITextMeshProUGUI iconTapInfoText;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Setup(PRISM.Gasha.GashaResultData gashaResultData, PRISM.ResourceManagement.IResourceLoader resourceLoader);
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
public class GashaBonusPopupView : UnityEngine.MonoBehaviour, PRISM.Adapters.IGashaBonusPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>, PRISM.Interactions.IPopupContent
{
    private ENTERPRISE.UI.UITabGroup uITabGroup;
    private ENTERPRISE.UI.UITabGroup uITabStepGroup;
    private UnityEngine.GameObject goStep;
    private UnityEngine.GameObject goItem;
    private UnityEngine.GameObject goXml;
    private UnityEngine.GameObject goEmpty;
    private PRISM.Interactions.GashaBonusRateView gashaBonusRateView;
    private Growing.XMLPanel xMLPanel;
    private bool isStep;
    private int tabIndex;
    private int stepTabIndex;
    private System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IGashaBonusRateStatus> rateList;
    private Growing.XMLPanel xMLPanelInstance;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public Cysharp.Threading.Tasks.UniTask SetupAsync(System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IGashaBonusRateStatus> rateList, int stepNum, int stepNo);
    public void _SetupTab();
    public void _SetupStep(int stepNum);
    private PRISM.Module.Networking.IGashaBonusRateStatus _getRate();
    private void _refresh(PRISM.Module.Networking.IGashaBonusRateStatus target);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <_SetupTab>b__17_0(int tabIndex, ENTERPRISE.UI.UITabGroup _);
    private void <_SetupStep>b__18_0(int stepTabIndex, ENTERPRISE.UI.UITabGroup _);
    private void <CreateFrameParameter>b__21_0();
    private void <CreateFrameParameter>b__21_1();

    private class <>c__DisplayClass19_0
    {
        public int stepNo;
        private bool <_getRate>b__0(PRISM.Module.Networking.IGashaBonusRateStatus x);
    }

    private struct <_refresh>d__20 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
        public PRISM.Interactions.GashaBonusPopupView <>4__this;
        public PRISM.Module.Networking.IGashaBonusRateStatus target;
        private Awaiter<bool> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class GashaBonusRateView : UnityEngine.MonoBehaviour
{
    private PRISM.CmnTable cmnTable;
    private Growing.XMLPanel xmlPanel;
    public void Setup(PRISM.Module.Networking.IGashaBonusRateStatus gashaBonusRates);
    private void _setupList(System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IGashaBonusProductRateStatus> gashaBonusProductRates);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Module.Networking.IGashaBonusProductRateStatus, float> <>9__3_0;
        private float <_setupList>b__3_0(PRISM.Module.Networking.IGashaBonusProductRateStatus x);
    }
}

// Namespace: PRISM.Interactions
public class GashaConfirmationPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IGashaConfirmationPopupView, PRISM.Adapters.IClosablePopupFrame<System.ValueTuple<int, bool>>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<System.ValueTuple<int, bool>>
{
    private ENTERPRISE.UI.UITextMeshProUGUI txtMsgTop;
    private ENTERPRISE.UI.UITextMeshProUGUI txtCaution;
    private ENTERPRISE.UI.UITextMeshProUGUI txtPaidBefore;
    private ENTERPRISE.UI.UITextMeshProUGUI txtPaidAfter;
    private ENTERPRISE.UI.UITextMeshProUGUI txtFreeBefore;
    private ENTERPRISE.UI.UITextMeshProUGUI txtFreeAfter;
    private ENTERPRISE.UI.UITextMeshProUGUI txtTokenBefore;
    private ENTERPRISE.UI.UITextMeshProUGUI txtTokenAfter;
    private ENTERPRISE.UI.UITextMeshProUGUI txtExChangePointBefore;
    private ENTERPRISE.UI.UITextMeshProUGUI txtExChangePointAfter;
    private UnityEngine.GameObject goPaid;
    private UnityEngine.GameObject goFree;
    private UnityEngine.GameObject goExChangePoint;
    private UnityEngine.GameObject goToken;
    private UnityEngine.UI.RawImage imgToken;
    private ENTERPRISE.UI.UITextMeshProUGUI txtTokutei;
    private PRISM.Interactions.ButtonView btnTokutei;
    private string gashaName;
    private PRISM.Domain.ProductService ps;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<CloseType> closeTask;
    private bool isRetry;
    private bool isShortageJewel;
    private PRISM.Module.Networking.IGashaPriceStatus gashaPrice;
    private PRISM.Domain.Gasha gasha;
    private bool isShopOpened;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<System.ValueTuple<int, bool>> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<System.ValueTuple<int, bool>> OnCloseRequested { get; set; }
    public System.IObservable<UniRx.Unit> OnClickTokuteiButton { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Domain.Gasha gasha, PRISM.Module.Networking.IGashaPriceStatus gashaPrice, PRISM.ResourceManagement.IResourceLoader resourceLoader, bool isRetry);
    private void _refreshContents(PRISM.Domain.Gasha gasha, PRISM.Module.Networking.IGashaPriceStatus gashaPrice);
    private bool _showInGameCurrency(PRISM.Domain.Gasha gasha, PRISM.Module.Networking.IGashaPriceStatus gashaPrice);
    private void _showToken(PRISM.Domain.ProductService ps, PRISM.Module.Networking.IGashaPriceStatus gashaPrice);
    private void _setupExChange(PRISM.Domain.Gasha gasha, PRISM.Module.Networking.IGashaPriceStatus gashaPrice);
    private void _updateJewelModeUI(PRISM.Domain.Gasha gasha, PRISM.Module.Networking.IGashaPriceStatus gashaPrice, bool isShortageJewel);
    private void _onDecideButtonClicked();
    private bool _isDecideButtonEnabled();
    private System.ValueTuple<string, int> _getDecideButtonTextData();
    private Cysharp.Threading.Tasks.UniTask _showShopOverlayAsync(System.Threading.CancellationToken ct);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private bool <_isDecideButtonEnabled>b__39_0(PRISM.Module.Networking.IHavingProductStatus x);
    private void <CreateFrameParameter>b__42_0();
    private void <CreateFrameParameter>b__42_1();
    private void <CreateFrameParameter>b__42_2();

    public enum CloseType : System.Enum
    {
        public int value__;
        public static CloseType Cancel;
        public static CloseType BuyJewel;
        public static CloseType ExecGasha;
    }

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Module.Networking.IHavingProductStatus, bool> <>9__34_0;
        public static System.Func<PRISM.Module.Networking.IHavingProductStatus, bool> <>9__34_1;
        private bool <_showInGameCurrency>b__34_0(PRISM.Module.Networking.IHavingProductStatus x);
        private bool <_showInGameCurrency>b__34_1(PRISM.Module.Networking.IHavingProductStatus x);
    }

    private class <>c__DisplayClass35_0
    {
        public PRISM.Module.Networking.IGashaPriceStatus gashaPrice;
        private bool <_showToken>b__0(PRISM.Module.Networking.IHavingProductStatus x);
    }

    private struct <_showShopOverlayAsync>d__41 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public System.Threading.CancellationToken ct;
        public PRISM.Interactions.GashaConfirmationPopupView <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class GashaDetailPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IGashaDetailPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private Growing.XMLPanel xMLPanelDescription;
    private Growing.XMLPanel xMLPanelAttention;
    private UnityEngine.GameObject goDescription;
    private UnityEngine.GameObject goAttention;
    private PRISM.Interactions.ButtonView[] toggleButtons;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(GashaTabType tabType, string xml, UniRx.IReactiveProperty<int> selectedTab);
    public Cysharp.Threading.Tasks.UniTask SetupContentsAsync(GashaTabType tabType, string xml);
    public void ChangeContents(GashaTabType tabType);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__11_0();
    private void <CreateFrameParameter>b__11_1();

    private struct <InitializeAsync>d__5 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.GashaDetailPopupView <>4__this;
        public UniRx.IReactiveProperty<int> selectedTab;
        public GashaTabType tabType;
        public string xml;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <SetupContentsAsync>d__6 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public GashaTabType tabType;
        public PRISM.Interactions.GashaDetailPopupView <>4__this;
        public string xml;
        private Awaiter<bool> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class GashaExchangeConfirmationPoint : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI txtLabel;
    private UnityEngine.GameObject imgPoint;
    private PRISM.Legacy.GashaProductItemPresenter gashaProductItem;
    private ENTERPRISE.UI.UITextMeshProUGUI txtLeft;
    private ENTERPRISE.UI.UITextMeshProUGUI txtRight;
    private UnityEngine.GameObject goArrow;
    public PRISM.Interactions.GashaExchangeConfirmationPoint SetLabel(string str);
    public PRISM.Interactions.GashaExchangeConfirmationPoint SetIcon(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Module.Networking.IProductStatus product);
    public PRISM.Interactions.GashaExchangeConfirmationPoint SetEnableLeftNumber(bool b);
    public PRISM.Interactions.GashaExchangeConfirmationPoint SetLeftNumber(string nm);
    public PRISM.Interactions.GashaExchangeConfirmationPoint SetRightNumber(string nm);
}

// Namespace: PRISM.Interactions
public class GashaExchangeConfirmationPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IGashaExchangeConfirmationPopupView, PRISM.Adapters.IClosablePopupFrame<string>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<string>
{
    private PRISM.Interactions.PopupFrameParameter popupFrameParameter;
    private PRISM.Adapters.GashaStartType parameterType;
    private string gashaExchangeRewardId;
    private ENTERPRISE.UI.UITextMeshProUGUI txtMessage;
    private PRISM.Interactions.GashaRewardScrollerView rewardScrollerView;
    private PRISM.Interactions.GashaExchangeConfirmationPoint[] points;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<string> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<string> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public Cysharp.Threading.Tasks.UniTask SetupConfirmationAsync(PRISM.Adapters.GashaExchangeConfirmationPopupViewModel model, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private void _addProductList(PRISM.Gasha.GashaExchangeListCellProductModel cellProductModel, PRISM.Interactions.GashaExchangeConfirmationPoint confirmationPoint, System.Collections.Generic.List<PRISM.Adapters.GashaRewardScrollCellViewModel> modelList, int index, bool isResult, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public Cysharp.Threading.Tasks.UniTask SetupResultAsync(PRISM.Adapters.GashaExchangeConfirmationPopupViewModel model, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private long _getProductAmount(PRISM.Module.Networking.IProductStatus product, bool isHaving);
    public void SetParameter(PRISM.Adapters.GashaStartType parameterType, bool isBigWindow);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <SetParameter>b__13_0();
    private void <SetParameter>b__13_1();
    private void <SetParameter>b__13_2();
    private void <SetParameter>b__13_3();
    private void <SetParameter>b__13_4();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Adapters.GashaRewardScrollCellViewModel, int> <>9__9_0;
        public static System.Func<PRISM.Module.Networking.IGashaExtraRewardProductStatus, int> <>9__10_0;
        public static System.Func<PRISM.Module.Networking.IGashaExtraRewardProductStatus, bool> <>9__10_2;
        public static System.Func<PRISM.Module.Networking.IGashaExtraRewardProductStatus, bool> <>9__10_3;
        public static System.Func<PRISM.Adapters.GashaRewardScrollCellViewModel, int> <>9__11_0;
        public static System.Func<PRISM.Adapters.GashaRewardScrollCellViewModel, bool> <>9__11_1;
        private int <SetupConfirmationAsync>b__9_0(PRISM.Adapters.GashaRewardScrollCellViewModel x);
        private int <_addProductList>b__10_0(PRISM.Module.Networking.IGashaExtraRewardProductStatus status);
        private bool <_addProductList>b__10_2(PRISM.Module.Networking.IGashaExtraRewardProductStatus status);
        private bool <_addProductList>b__10_3(PRISM.Module.Networking.IGashaExtraRewardProductStatus status);
        private int <SetupResultAsync>b__11_0(PRISM.Adapters.GashaRewardScrollCellViewModel x);
        private bool <SetupResultAsync>b__11_1(PRISM.Adapters.GashaRewardScrollCellViewModel x);
    }

    private class <>c__DisplayClass10_0
    {
        public PRISM.Domain.ProductKey convertedProductKey;
        private bool <_addProductList>b__1(PRISM.Adapters.GashaRewardScrollCellViewModel x);
    }
}

// Namespace: PRISM.Interactions
public class GashaExchangeExpiryDateConversionItemCell : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.Image imgBanner;
    private ENTERPRISE.UI.UITextMeshProUGUI txtBefor;
    private ENTERPRISE.UI.UITextMeshProUGUI txtAfter;
    public void Setup(PRISM.Module.Networking.IGashaConvertExchangePointStatus gashaConvertExchangePoint, PRISM.ResourceManagement.IResourceLoader loader, System.Threading.CancellationToken ct);
}

// Namespace: PRISM.Interactions
public class GashaExchangeExpiryDateConversionPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IGashaExchangeExpiryDateConversionPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.GashaExchangeExpiryDateConversionItemCell goTemplate;
    private ENTERPRISE.UI.UITextMeshProUGUI txtNow;
    private ENTERPRISE.UI.UITextMeshProUGUI txtOld;
    private ENTERPRISE.UI.UITextMeshProUGUI txtPuls;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Module.Networking.IConvertGashaExchangePointReply convertGashaExchangePointReply, long oldp, long newp, PRISM.ResourceManagement.IResourceLoader loader, System.Threading.CancellationToken ct);
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
public class GashaExchangeExpiryDateInfoItemCell : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.Image imgBanner;
    private ENTERPRISE.UI.UITextMeshProUGUI txtNm;
    private ENTERPRISE.UI.UITextMeshProUGUI txtLimit;
    private ENTERPRISE.UI.ButtonBase btnGotoGasha;
    private ENTERPRISE.UI.UITextMeshProUGUI txtHavePoint;
    private ENTERPRISE.UI.UITextMeshProUGUI txtExpiryDate;
    public void Setup(PRISM.Module.Networking.IGashaExchangePointStatus gashaExchangePoint, Cysharp.Threading.Tasks.IResolvePromise<PRISM.Module.Networking.IGashaExchangePointStatus> onJumpGasha, PRISM.ResourceManagement.IResourceLoader loader, System.Threading.CancellationToken ct);

    private class <>c__DisplayClass6_0
    {
        public PRISM.Interactions.GashaExchangeExpiryDateInfoItemCell <>4__this;
        public PRISM.Module.Networking.IGashaExchangePointStatus gashaExchangePoint;
        public Cysharp.Threading.Tasks.IResolvePromise<PRISM.Module.Networking.IGashaExchangePointStatus> onJumpGasha;
        private void <Setup>b__0(long x);
        private void <Setup>b__1();
    }
}

// Namespace: PRISM.Interactions
public class GashaExchangeExpiryDateInfoPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IGashaExchangeExpiryDateInfoPopupView, PRISM.Adapters.IClosablePopupFrame<PRISM.Module.Networking.IGashaExchangePointStatus>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<PRISM.Module.Networking.IGashaExchangePointStatus>
{
    private PRISM.Interactions.GashaExchangeExpiryDateInfoItemCell template;
    private ENTERPRISE.UI.UITextMeshProUGUI txtDivMessage;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<PRISM.Module.Networking.IGashaExchangePointStatus> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<PRISM.Module.Networking.IGashaExchangePointStatus> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public Cysharp.Threading.Tasks.UniTask SetupAsync(System.Collections.Generic.IEnumerable<PRISM.Module.Networking.IGashaExchangePointStatus> gashaExchangePoints, PRISM.ResourceManagement.IResourceLoader loader, System.Threading.CancellationToken ct);
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
public class GashaExchangeItemCellView : UnityEngine.MonoBehaviour
{
    private PRISM.Legacy.GashaProductItemPresenter gashaProductItem;
    private ENTERPRISE.OutGame.RewardItem rewardPieceItem;
    private ENTERPRISE.UI.UITextMeshProUGUI txtPieceDetail;
    private UnityEngine.GameObject rewardPieceItemFrame;
    private ENTERPRISE.UI.UITextMeshProUGUI txtItemName;
    private UnityEngine.GameObject goKakutoku;
    private UnityEngine.GameObject goMiKakutoku;
    private ENTERPRISE.UI.UITextMeshProUGUI txtPoint;
    private PRISM.Interactions.ButtonView btnExChange;
    private UnityEngine.UI.RawImage duplicatedBonusImage;
    private ENTERPRISE.UI.UITextMeshProUGUI txtLimit;
    private string <ExchangeRewardId>k__BackingField;
    public string ExchangeRewardId { get; set; }
    public System.IObservable<string> OnClickItem { get; set; }
    public void Setup(PRISM.Gasha.GashaExchangeListCellModel cellModel, int currentPoint, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void SetupProduct(PRISM.Gasha.GashaExchangeListCellProductModel productModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private string <get_OnClickItem>b__16_0(UniRx.Unit _);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Module.Networking.IGashaExtraRewardProductStatus, int> <>9__18_0;
        public static System.Func<PRISM.Module.Networking.IGashaExtraRewardProductStatus, bool> <>9__18_1;
        public static System.Func<PRISM.Module.Networking.IGashaExtraRewardProductStatus, bool> <>9__18_2;
        private int <SetupProduct>b__18_0(PRISM.Module.Networking.IGashaExtraRewardProductStatus status);
        private bool <SetupProduct>b__18_1(PRISM.Module.Networking.IGashaExtraRewardProductStatus status);
        private bool <SetupProduct>b__18_2(PRISM.Module.Networking.IGashaExtraRewardProductStatus status);
    }
}

// Namespace: PRISM.Interactions
public class GashaExchangeItemDoubleCellView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.GashaExchangeItemCellView mainCell;
    private PRISM.Interactions.GashaExchangeItemCellView addCell;
    public System.IObservable<string> OnClickItem { get; set; }
    public string ExchangeRewardId { get; set; }
    public void Setup(PRISM.Gasha.GashaExchangeListCellModel cellModel, int currentPoint, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Interactions
public class GashaExchangeListPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IGashaExchangeListPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.ToggleGroupView tabGroup;
    private PRISM.Interactions.ButtonView btnHelp;
    private UnityEngine.GameObject goItem1;
    private UnityEngine.GameObject goItem2;
    private UnityEngine.GameObject goHeadLine;
    private UnityEngine.GameObject goXml;
    private Growing.XMLPanel xmlPanel;
    private PRISM.Interactions.GashaExchangeItemCellView templateCell;
    private PRISM.Interactions.GashaExchangeItemDoubleCellView templateDoubleCell;
    private UnityEngine.Transform cellParent;
    private ENTERPRISE.UI.UITextMeshProUGUI txtLimit;
    private ENTERPRISE.UI.UITextMeshProUGUI txtPrismPoint;
    private ENTERPRISE.UI.UITextMeshProUGUI txtCaution;
    private string xmldata;
    private System.Collections.Generic.List<PRISM.Interactions.GashaExchangeItemCellView> itemCells;
    private System.Collections.Generic.List<PRISM.Interactions.GashaExchangeItemDoubleCellView> doubleItemCells;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private System.Collections.Generic.IReadOnlyList<PRISM.Gasha.GashaExchangeListCellModel> rewardList;
    private PRISM.Interactions.IPopupFrameView parent;
    public System.IObservable<UniRx.Unit> OnClickShowHelpButton { get; set; }
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Gasha.GashaExchangeListPopupViewModel exchange, System.Nullable<System.DateTime> endDate, string xmlData, System.Action<string, System.Action<PRISM.Gasha.GashaExchangeListPopupViewModel, PRISM.ResourceManagement.IResourceLoader>, PRISM.ResourceManagement.IResourceLoader> OnSelectTarget, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private void _onRefresh(PRISM.Gasha.GashaExchangeListPopupViewModel exchange, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private Cysharp.Threading.Tasks.UniTask _setupItemAsync(int idx, PRISM.Gasha.GashaExchangeListPopupViewModel exchange, System.Action<string, System.Action<PRISM.Gasha.GashaExchangeListPopupViewModel, PRISM.ResourceManagement.IResourceLoader>, PRISM.ResourceManagement.IResourceLoader> OnSelectTarget, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__25_0();
    private void <CreateFrameParameter>b__25_1();

    private class <>c__DisplayClass22_0
    {
        public PRISM.Interactions.GashaExchangeListPopupView <>4__this;
        public PRISM.Gasha.GashaExchangeListPopupViewModel exchange;
        public System.Action<string, System.Action<PRISM.Gasha.GashaExchangeListPopupViewModel, PRISM.ResourceManagement.IResourceLoader>, PRISM.ResourceManagement.IResourceLoader> OnSelectTarget;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private Cysharp.Threading.Tasks.UniTaskVoid <SetupAsync>b__0(int index);

        private struct <<SetupAsync>b__0>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
        {
            public int <>1__state;
            public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
            public <>c__DisplayClass22_0 <>4__this;
            public int index;
            private Awaiter <>u__1;
            private void MoveNext();
            private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }

    private class <>c__DisplayClass23_0
    {
        public PRISM.Interactions.GashaExchangeItemCellView cell;
        private bool <_onRefresh>b__0(PRISM.Gasha.GashaExchangeListCellModel x);
    }

    private class <>c__DisplayClass23_1
    {
        public PRISM.Interactions.GashaExchangeItemDoubleCellView cell;
        private bool <_onRefresh>b__1(PRISM.Gasha.GashaExchangeListCellModel x);
    }

    private class <>c__DisplayClass24_0
    {
        public System.Action<string, System.Action<PRISM.Gasha.GashaExchangeListPopupViewModel, PRISM.ResourceManagement.IResourceLoader>, PRISM.ResourceManagement.IResourceLoader> OnSelectTarget;
        public PRISM.Interactions.GashaExchangeListPopupView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Action<string> <>9__1;
        public System.Action<string> <>9__0;
        private void <_setupItemAsync>b__1(string gasha_exchange_reward_id);
        private void <_setupItemAsync>b__0(string gasha_exchange_reward_id);
    }

    private struct <SetupAsync>d__22 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.GashaExchangeListPopupView <>4__this;
        public PRISM.Gasha.GashaExchangeListPopupViewModel exchange;
        public System.Action<string, System.Action<PRISM.Gasha.GashaExchangeListPopupViewModel, PRISM.ResourceManagement.IResourceLoader>, PRISM.ResourceManagement.IResourceLoader> OnSelectTarget;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public string xmlData;
        private <>c__DisplayClass22_0 <>8__1;
        public System.Nullable<System.DateTime> endDate;
        private UniRx.ReactiveProperty<int> <selectedTab>5__2;
        private System.Threading.CancellationTokenSource <cts>5__3;
        private Awaiter<PRISM.Module.Networking.IGetProduceIdolListReply> <>u__1;
        private Awaiter<PRISM.Module.Networking.IGetSupportCharacterListReply> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_setupItemAsync>d__24 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public System.Action<string, System.Action<PRISM.Gasha.GashaExchangeListPopupViewModel, PRISM.ResourceManagement.IResourceLoader>, PRISM.ResourceManagement.IResourceLoader> OnSelectTarget;
        public PRISM.Interactions.GashaExchangeListPopupView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public int idx;
        public PRISM.Gasha.GashaExchangeListPopupViewModel exchange;
        private Awaiter<bool> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class GashaRewardScrollerView : PRISM.EnhancedListView<PRISM.Adapters.GashaRewardScrollCellViewModel, PRISM.EnhancedListViewContext>
{
}

// Namespace: PRISM.Interactions
public class GashaHistoryDetailPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IGashaHistoryDetailPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.Gasha.GashaHistoryDetailScrollView gashaHistoryDetailScroll;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void InitializeView(PRISM.Module.Networking.IGashaHistoryStatus gashaHistory, PRISM.ResourceManagement.IResourceLoader loader, System.Threading.CancellationToken ct);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__5_0();
    private void <CreateFrameParameter>b__5_1();
}

// Namespace: PRISM.Interactions
public class GashaHistoryPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IGashaHistoryPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private ENTERPRISE.UI.UITextMeshProUGUI nothingHistoryText;
    private PRISM.Interactions.Gasha.GashaHistoryCellView gashaHistoryCell;
    private UnityEngine.RectTransform contentRoot;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Setup(PRISM.Module.Networking.IGetGashaHistoryListReply getGashaHistoryListReply, System.Action<PRISM.Module.Networking.IGashaHistoryStatus> onClick, PRISM.ResourceManagement.IResourceLoader loader, System.Threading.CancellationToken ct);
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
        public static System.Func<PRISM.Module.Networking.IGashaHistoryStatus, System.Nullable<System.DateTime>> <>9__6_0;
        private System.Nullable<System.DateTime> <Setup>b__6_0(PRISM.Module.Networking.IGashaHistoryStatus y);
    }
}

// Namespace: PRISM.Interactions
public class GashaGaugeItemCell : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.OutGame.RewardItem itemIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI txtPrismPoint;
    private ENTERPRISE.UI.UITextMeshProUGUI txtItemName;
    private UnityEngine.GameObject goDone;
    public void Setup(PRISM.Module.Networking.IGashaPrismGaugeRewardStatus gashaPrismGauge, int currentPoint, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Interactions
public class GashaPrismGaugePopupView : UnityEngine.MonoBehaviour, PRISM.Adapters.IGashaPrismGaugePopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>, PRISM.Interactions.IPopupContent
{
    private PRISM.Interactions.ToggleGroupView tabGroup;
    private UnityEngine.GameObject goItem;
    private UnityEngine.GameObject goXml;
    private UnityEngine.GameObject goHeadLine;
    private Growing.XMLPanel xmlPanel;
    private PRISM.Interactions.GashaGaugeItemCell gashaGaugeItemCell;
    private ENTERPRISE.UI.UITextMeshProUGUI txtLimit;
    private ENTERPRISE.UI.UITextMeshProUGUI txtPrismPoint;
    private string xmldata;
    private System.Collections.Generic.List<UnityEngine.GameObject> gashaGaugeItemCells;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Setup(PRISM.Domain.GashaPrismGauge gashaPrismGauge, string xmlData, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private Cysharp.Threading.Tasks.UniTask _setupItemAsync(int idx, PRISM.Domain.GashaPrismGauge gashaPrismGauge, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__15_0();
    private void <CreateFrameParameter>b__15_1();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Module.Networking.IGashaPrismGaugeRewardStatus, int> <>9__14_0;
        private int <_setupItemAsync>b__14_0(PRISM.Module.Networking.IGashaPrismGaugeRewardStatus x);
    }

    private class <>c__DisplayClass13_0
    {
        public PRISM.Interactions.GashaPrismGaugePopupView <>4__this;
        public PRISM.Domain.GashaPrismGauge gashaPrismGauge;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private Cysharp.Threading.Tasks.UniTaskVoid <Setup>b__0(int index);

        private struct <<Setup>b__0>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
        {
            public int <>1__state;
            public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
            public <>c__DisplayClass13_0 <>4__this;
            public int index;
            private Awaiter <>u__1;
            private void MoveNext();
            private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }

    private struct <_setupItemAsync>d__14 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public int idx;
        public PRISM.Interactions.GashaPrismGaugePopupView <>4__this;
        public PRISM.Domain.GashaPrismGauge gashaPrismGauge;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private Awaiter<bool> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class GashaPrismGaugeProgressPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IGashaPrismGaugeProgressPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.PrismGauge prismGauge;
    private ENTERPRISE.UI.UITextMeshProUGUI txtOld;
    private ENTERPRISE.UI.UITextMeshProUGUI txtNew;
    private PRISM.Interactions.ButtonView btnFront;
    private System.Threading.CancellationTokenSource cts;
    private bool isGaugeAnimation;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClose;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Setup(PRISM.Module.Networking.IGashaPrismGaugeStatus gashaPrismGauge, int oldPoint);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <Setup>b__9_1();
    private void <Setup>b__9_2(UniRx.Unit _);
    private void <CreateFrameParameter>b__10_0();
    private void <CreateFrameParameter>b__10_1();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Module.Networking.IGashaPrismGaugeRewardStatus, int> <>9__9_0;
        private int <Setup>b__9_0(PRISM.Module.Networking.IGashaPrismGaugeRewardStatus x);
    }
}

// Namespace: PRISM.Interactions
public class PrismGauge : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.PrismGaugeItem prismGaugeItem;
    private UnityEngine.UI.Image gauge;
    private UnityEngine.RectTransform rectItem;
    private PRISM.Module.Networking.IGashaPrismGaugeStatus gashaPrismGauge;
    private int currentPoint;
    private int startPoint;
    private int endPoint;
    private CriWare.CriAtomExPlayback playback;
    private System.Action endcallback;
    private float after;
    public void SetUp(PRISM.Module.Networking.IGashaPrismGaugeStatus gashaPrismGauge, System.Nullable<int> overridePoint);
    public Cysharp.Threading.Tasks.UniTask GaugeAnimeAsync(System.Action endcallback, System.Threading.CancellationToken ct);
    private void _execDone();
    private bool <SetUp>b__10_0(PRISM.Module.Networking.IGashaPrismGaugeRewardStatus x);
    private bool <SetUp>b__10_2(PRISM.Module.Networking.IGashaPrismGaugeRewardStatus x);
    private void <GaugeAnimeAsync>b__11_0();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Module.Networking.IGashaPrismGaugeRewardStatus, int> <>9__10_1;
        public static System.Func<PRISM.Module.Networking.IGashaPrismGaugeRewardStatus, int> <>9__10_3;
        private int <SetUp>b__10_1(PRISM.Module.Networking.IGashaPrismGaugeRewardStatus x);
        private int <SetUp>b__10_3(PRISM.Module.Networking.IGashaPrismGaugeRewardStatus x);
    }

    private struct <GaugeAnimeAsync>d__11 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.PrismGauge <>4__this;
        public System.Action endcallback;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class PrismGaugeItem : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.OutGame.RewardItem rewardItem;
    private UnityEngine.GameObject glowEffect;
    private ENTERPRISE.UI.UITextMeshProUGUI txtPrismPoint;
    private UnityEngine.GameObject goDone;
    public void Setup(PRISM.Module.Networking.IGashaPrismGaugeRewardStatus gashaPrismGaugeReward, int point);
    public void EnableGlow();
}

// Namespace: PRISM.Interactions
public class AbstractGashaRateCellView : EnhancedUI.EnhancedScroller.EnhancedScrollerCellView
{
    public void Reset();
}

// Namespace: PRISM.Interactions
public class GashaRatesNotesCellView : PRISM.Interactions.AbstractGashaRateCellView
{
    private static float BottomHeight;
    private UnityEngine.RectTransform rect;
    private float baseHeight;
    private ENTERPRISE.UI.UITextMeshProUGUI txtNotes;
    public float GetHeight(bool bottom);
    public void Setup(string notes, bool bottom);
    public void Reset();
}

// Namespace: PRISM.Interactions
public class GashaRatesRarityRateTableCellView : PRISM.Interactions.AbstractGashaRateCellView
{
    private static int ObjectPoolDefaultCapacity;
    private static int ObjectPoolMaxSize;
    private UnityEngine.RectTransform rect;
    private float baseHeight;
    private ENTERPRISE.UI.UITextMeshProUGUI txtLabelRarity;
    private ENTERPRISE.UI.UITextMeshProUGUI txtLabelNormal;
    private ENTERPRISE.UI.UITextMeshProUGUI txtLabelPromised;
    private PRISM.Interactions.RarityRateTableRowView rowViewPrefab;
    private UnityEngine.Transform trRowViewParent;
    private float bottomMargin;
    private UnityEngine.GameObject[] promisedRateColmObjects;
    private UnityEngine.Pool.ObjectPool<PRISM.Interactions.RarityRateTableRowView> rowViewPool;
    private System.Collections.Generic.List<PRISM.Interactions.RarityRateTableRowView> activeRowViews;
    public float GetHeight(int rowViewNum);
    public void Setup(System.Collections.Generic.List<PRISM.Adapters.GashaRatesRarityRateModel> rarityRateList, string promisedRateName);
    public void Reset();
    private UnityEngine.Pool.ObjectPool<PRISM.Interactions.RarityRateTableRowView> _createRowViewPool();
    private PRISM.Interactions.RarityRateTableRowView <_createRowViewPool>b__16_0();
    private void <_createRowViewPool>b__16_1(PRISM.Interactions.RarityRateTableRowView target);

    private class <>c
    {
        public static <>c <>9;
        public static System.Action<PRISM.Interactions.RarityRateTableRowView> <>9__16_2;
        public static System.Action<PRISM.Interactions.RarityRateTableRowView> <>9__16_3;
        private void <_createRowViewPool>b__16_2(PRISM.Interactions.RarityRateTableRowView target);
        private void <_createRowViewPool>b__16_3(PRISM.Interactions.RarityRateTableRowView target);
    }
}

// Namespace: PRISM.Interactions
public class GashaRatesRateDoubleProductCellView : PRISM.Interactions.GashaRatesRateProductCellView
{
    private PRISM.Interactions.ProduceIdolIconView pIdolSecondIconView;
    private PRISM.Interactions.ButtonView pIdolSecondIconButton;
    private PRISM.Interactions.SupportCharacterIconView sCharaSecondIconView;
    private PRISM.Interactions.ButtonView sCharaSecondIconButton;
    private ENTERPRISE.OutGame.RewardItem itemSecondIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI secondProductNameAliasText;
    private ENTERPRISE.UI.UITextMeshProUGUI secondProductNameText;
    private System.IDisposable disposable;
    private PRISM.AutoCancellationTokenSource canceller;
    public void Setup(PRISM.Adapters.GashaRatesRateDoubleProductCellViewModel model, PRISM.ResourceManagement.IResourceLoader resourceLoader, bool isPromisedRate);
    public void Reset();
    public void OnDestroy();

    private class <>c__DisplayClass9_0
    {
        public int mstId;
        private void <Setup>b__0(UniRx.Unit _);
    }

    private class <>c__DisplayClass9_1
    {
        public int mstId;
        private void <Setup>b__1(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions
public class GashaRatesRateHeaderCellView : PRISM.Interactions.AbstractGashaRateCellView
{
    private static float CellMargin;
    private UnityEngine.RectTransform rect;
    private float baseHeight;
    private ENTERPRISE.UI.UITextMeshProUGUI txtRarityGroup;
    private ENTERPRISE.UI.UITextMeshProUGUI txtLabelProductType;
    private ENTERPRISE.UI.UITextMeshProUGUI txtLabelNormal;
    private ENTERPRISE.UI.UITextMeshProUGUI txtLabelPromised;
    private UnityEngine.GameObject[] promisedRateColmObjects;
    public float GetHeight(bool isTop);
    public void Setup(PRISM.Adapters.GashaRatesRateHeaderCellViewModel model, string promisedRateName);
    public void Reset();
}

// Namespace: PRISM.Interactions
public class GashaRatesRateProductCellView : PRISM.Interactions.AbstractGashaRateCellView
{
    private UnityEngine.RectTransform rect;
    private PRISM.Interactions.ProduceIdolIconView pfIdolIconView;
    private PRISM.Interactions.ButtonView pfIdolIconButton;
    private PRISM.Interactions.SupportCharacterIconView sCharaIconView;
    private PRISM.Interactions.ButtonView sCharaIconButton;
    private ENTERPRISE.OutGame.RewardItem producItem;
    private ENTERPRISE.UI.UITextMeshProUGUI txtCharaNameAlias;
    private ENTERPRISE.UI.UITextMeshProUGUI txtCharaName;
    private ENTERPRISE.UI.UITextMeshProUGUI txtNormalRate;
    private ENTERPRISE.UI.UITextMeshProUGUI txtPromisedRate;
    private UnityEngine.GameObject bgBlue;
    private UnityEngine.GameObject bgWhite;
    private UnityEngine.GameObject[] promisedRateColmObjects;
    private System.IDisposable disposable;
    private PRISM.AutoCancellationTokenSource canceller;
    public float GetHeight();
    public void Setup(PRISM.Adapters.GashaRatesRateProductCellViewModel model, PRISM.ResourceManagement.IResourceLoader resourceLoader, bool isPromisedRate);
    public void Reset();
    public void OnDestroy();
    protected System.ValueTuple<string, string> _splitCostumeName(string costumeName);

    private class <>c__DisplayClass16_0
    {
        public int mstId;
        private void <Setup>b__0(UniRx.Unit _);
    }

    private class <>c__DisplayClass16_1
    {
        public int mstId;
        private void <Setup>b__1(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions
public class GashaRatesTitleCellView : PRISM.Interactions.AbstractGashaRateCellView
{
    private float baseHeight;
    private ENTERPRISE.UI.UITextMeshProUGUI txtTitle;
    public float GetHeight();
    public void Setup(string title);
    public void Reset();
}

// Namespace: PRISM.Interactions
public class GashaRateView : UnityEngine.MonoBehaviour, EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate
{
    private EnhancedUI.EnhancedScroller.EnhancedScroller scroller;
    private EnhancedUI.EnhancedScroller.EnhancedScrollerCellView[] cellViewPrefabs;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    private PRISM.Adapters.GashaRatesPopupViewModel vm;
    public void Setup(PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void DataSwitching(PRISM.Adapters.GashaRatesPopupViewModel viewModel);
    private void _activateCell(PRISM.Interactions.AbstractGashaRateCellView cellView);
    private void _deactivateCell(PRISM.Interactions.AbstractGashaRateCellView cellView);
    private int EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate.GetNumberOfCells(EnhancedUI.EnhancedScroller.EnhancedScroller scroller);
    private float EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate.GetCellViewSize(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex);
    private EnhancedUI.EnhancedScroller.EnhancedScrollerCellView EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate.GetCellView(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex, int cellIndex);
    private EnhancedUI.EnhancedScroller.EnhancedScrollerCellView _selectCellView(int dataIndex);
    private float _getCellViewHeight(int dataIndex);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Interactions.AbstractGashaRateCellView, bool> <>9__4_0;
        public static System.Func<EnhancedUI.EnhancedScroller.EnhancedScrollerCellView, bool> <>9__12_0;
        public static System.Func<EnhancedUI.EnhancedScroller.EnhancedScrollerCellView, bool> <>9__12_1;
        public static System.Func<EnhancedUI.EnhancedScroller.EnhancedScrollerCellView, bool> <>9__12_2;
        public static System.Func<EnhancedUI.EnhancedScroller.EnhancedScrollerCellView, bool> <>9__12_3;
        public static System.Func<EnhancedUI.EnhancedScroller.EnhancedScrollerCellView, bool> <>9__12_4;
        public static System.Func<EnhancedUI.EnhancedScroller.EnhancedScrollerCellView, bool> <>9__12_5;
        private bool <Setup>b__4_0(PRISM.Interactions.AbstractGashaRateCellView cellView);
        private bool <_getCellViewHeight>b__12_0(EnhancedUI.EnhancedScroller.EnhancedScrollerCellView x);
        private bool <_getCellViewHeight>b__12_1(EnhancedUI.EnhancedScroller.EnhancedScrollerCellView x);
        private bool <_getCellViewHeight>b__12_2(EnhancedUI.EnhancedScroller.EnhancedScrollerCellView x);
        private bool <_getCellViewHeight>b__12_3(EnhancedUI.EnhancedScroller.EnhancedScrollerCellView x);
        private bool <_getCellViewHeight>b__12_4(EnhancedUI.EnhancedScroller.EnhancedScrollerCellView x);
        private bool <_getCellViewHeight>b__12_5(EnhancedUI.EnhancedScroller.EnhancedScrollerCellView x);
    }

    private class <>c__DisplayClass11_0
    {
        public string cellIdentifier;
        private bool <_selectCellView>b__0(EnhancedUI.EnhancedScroller.EnhancedScrollerCellView x);
    }
}

// Namespace: PRISM.Interactions
public class RarityRateTableRowView : UnityEngine.MonoBehaviour
{
    private UnityEngine.RectTransform rect;
    private ENTERPRISE.UI.UITextMeshProUGUI txtRarity;
    private ENTERPRISE.UI.UITextMeshProUGUI txtNormalRate;
    private ENTERPRISE.UI.UITextMeshProUGUI txtPromisedRate;
    private UnityEngine.GameObject bgBlue;
    private UnityEngine.GameObject bgWhite;
    private UnityEngine.GameObject[] promisedRateColmObjects;
    public float Height { get; set; }
    public void Setup(PRISM.Adapters.GashaRatesInListType ratesInType, int rarity, float normalRate, float promisedRate, bool isPromisedRate, int rowIndex);
}

// Namespace: PRISM.Interactions
public class GashaRatesPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IGashaRatesPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private UnityEngine.GameObject stepTabView;
    private PRISM.Interactions.ButtonView[] stepToggleButtons;
    private PRISM.Interactions.GashaRateView rateView;
    private ENTERPRISE.UI.UITextMeshProUGUI iconTapInfoText;
    private System.Collections.Generic.List<PRISM.Adapters.GashaRatesPopupViewModel> vmList;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public Cysharp.Threading.Tasks.UniTask SetupAsync(System.Collections.Generic.IEnumerable<PRISM.Adapters.GashaRatesPopupViewModel> modelList, UniRx.IReactiveProperty<int> selectedIndex, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <SetupAsync>b__8_1(int index);
    private void <CreateFrameParameter>b__9_0();
    private void <CreateFrameParameter>b__9_1();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Adapters.GashaRatesPopupViewModel, int> <>9__8_0;
        private int <SetupAsync>b__8_0(PRISM.Adapters.GashaRatesPopupViewModel rate);
    }
}

// Namespace: PRISM.Interactions
public class GashaRatesSelectPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IGashaRatesSelectPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.Gasha.GashaRatesSelectCellView gashaRatesSelectCell;
    private UnityEngine.RectTransform contentRoot;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private UniRx.CompositeDisposable disposables;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Setup(PRISM.Module.Networking.IGetProductDetailReply getProductDetailReply, System.Action<PRISM.Module.Networking.IGashaTicketTargetGashaStatus> onClick, PRISM.ResourceManagement.IResourceLoader loader, System.Threading.CancellationToken ct);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__7_0();
    private void <CreateFrameParameter>b__7_1();

    private class <>c__DisplayClass6_0
    {
        public System.Action<PRISM.Module.Networking.IGashaTicketTargetGashaStatus> onClick;
    }

    private class <>c__DisplayClass6_1
    {
        public PRISM.Module.Networking.IGashaTicketTargetGashaStatus targetGasha;
        public <>c__DisplayClass6_0 CS$<>8__locals1;
        private void <Setup>b__0(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions
public class GashaTicketConfirmationPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IGashaTicketConfirmationPopupView, PRISM.Adapters.IClosablePopupFrame<int>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<int>
{
    private ENTERPRISE.UI.UITextMeshProUGUI txtTopMsg;
    private UnityEngine.UI.RawImage imgItem;
    private ENTERPRISE.UI.UITextMeshProUGUI txtItem;
    private PRISM.Interactions.NumberFluctuateButtonView[] numberFluctuateButtons;
    private ENTERPRISE.UI.UITextMeshProUGUI txtVolue;
    private ENTERPRISE.UI.UITextMeshProUGUI txtBefor;
    private ENTERPRISE.UI.UITextMeshProUGUI txtAfter;
    private ENTERPRISE.UI.UITextMeshProUGUI txtExChangePointBefore;
    private ENTERPRISE.UI.UITextMeshProUGUI txtExChangePointAfter;
    private UnityEngine.GameObject goExChangePoint;
    private PRISM.Interactions.ButtonView btnItem;
    private UnityEngine.UI.RawImage imgMiniItem;
    private ENTERPRISE.UI.UITextMeshProUGUI txtTokutei;
    private PRISM.Interactions.ButtonView btnTokutei;
    private UniRx.ReactiveProperty<int> currentTicketCount;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<int> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<int> OnCloseRequested { get; set; }
    public System.IObservable<UniRx.Unit> OnClickPriceItemButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickTokuteiButton { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Domain.Gasha gasha, PRISM.Module.Networking.IGashaPriceStatus gashaPrice, long haveAmount, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private void _refreshUI(PRISM.Domain.Gasha gasha, PRISM.Module.Networking.IGashaPriceStatus gashaPrice, long haveAmount);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__24_0();
    private void <CreateFrameParameter>b__24_1();
    private void <CreateFrameParameter>b__24_2();

    private class <>c__DisplayClass22_0
    {
        public PRISM.Interactions.GashaTicketConfirmationPopupView <>4__this;
        public int min;
        public int max;
        public PRISM.Domain.Gasha gasha;
        public PRISM.Module.Networking.IGashaPriceStatus gashaPrice;
        public long haveAmount;
        private void <SetupAsync>b__0(int diff);
        private void <SetupAsync>b__1(int value);
    }
}

// Namespace: PRISM.Interactions
public class GashaResultConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.GashaResultArgument>, PRISM.Adapters.IGashaResultConnector
{
    protected PRISM.Adapters.GashaResultArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
}

// Namespace: PRISM.Interactions
public class GashaTopConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.GashaTopArgument>, PRISM.Adapters.IGashaTopConnector
{
    protected PRISM.Adapters.GashaTopArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
    public void ChangeBannerView(string resourceID);
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
}

// Namespace: PRISM.Interactions.Gasha
public class GashaEffectMonitor : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.Gasha.GashaEffectMonitorCard[] cards;
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Adapters.GashaEffectViewModel viewModel, PRISM.ResourceManagement.IResourceLoader loader, System.Threading.CancellationToken ct);

    private class <>c__DisplayClass1_0
    {
        public PRISM.Adapters.GashaEffectViewModel viewModel;
        public PRISM.ResourceManagement.IResourceLoader loader;
        public System.Threading.CancellationToken ct;
        private Cysharp.Threading.Tasks.UniTask <SetupAsync>b__0(PRISM.Interactions.Gasha.GashaEffectMonitorCard card, int i);
    }

    private struct <SetupAsync>d__1 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Adapters.GashaEffectViewModel viewModel;
        public PRISM.ResourceManagement.IResourceLoader loader;
        public System.Threading.CancellationToken ct;
        public PRISM.Interactions.Gasha.GashaEffectMonitor <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Gasha
public class GashaEffectMonitorCard : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ViewStateChanger isProduceIdolStateChanger;
    private PRISM.Interactions.ViewStateChanger rarityStateChanger;
    private bool useSilhouette;
    private UnityEngine.Transform silhouettePrefabParent;
    private UnityEngine.Material silhouetteMaterial;
    private UnityEngine.Material defaultMaterial;
    private UnityEngine.GameObject currentObject;
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Adapters.CharacterAcquisitionModel model, int rarity, PRISM.ResourceManagement.IResourceLoader loader, System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask _setupProduceIdolAsync(PRISM.Definitions.MstProduceIdol master, PRISM.ResourceManagement.IResourceLoader loader, System.Threading.CancellationToken ct);

    private struct <_setupProduceIdolAsync>d__8 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Gasha.GashaEffectMonitorCard <>4__this;
        public PRISM.Definitions.MstProduceIdol master;
        public PRISM.ResourceManagement.IResourceLoader loader;
        public System.Threading.CancellationToken ct;
        private Awaiter<UnityEngine.GameObject> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Gasha
public class GashaEffectMovieView : UnityEngine.MonoBehaviour, PRISM.Adapters.ITimelineSceneDependencyDefine
{
    private string movieKey;
    private CriWare.CriManaMovieControllerForUI controller;
    private string PRISM.Adapters.ITimelineSceneDependencyDefine.AssetKey { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask DisposeAsync(UnityEngine.Transform disposeParent);
    private bool <DisposeAsync>g__IsStopped|5_0();

    private struct <InitializeAsync>d__4 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Gasha.GashaEffectMovieView <>4__this;
        public System.Threading.CancellationToken ct;
        private CriWare.CriManaMovieControllerForUI <>7__wrap1;
        private Awaiter<string> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Gasha
public class GashaEffectScene : UnityEngine.MonoBehaviour
{
    public static string Name;
    private PRISM.Interactions.Gasha.GashaEffectFirstSceneControlView firstView;
    private PRISM.Interactions.Gasha.GashaEffectSpotLightSceneControlView spotLightView;
    private PRISM.Interactions.Gasha.GashaEffectLowRarityProduceIdolSceneControlView lowRarityProduceIdolView;
    private PRISM.Interactions.CharacterAcquisitionPlayer characterAcquisitionPlayer;
    private PRISM.Interactions.ButtonView skipButton;
    private PRISM.Interactions.ButtonView allSkipButton;
    private UnityEngine.GameObject finishedCover;
    private float tapDelaySeconds;
    private UnityEngine.Color ambientSkyColor;
    private UnityEngine.Color keepAmbientSkyColor;
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.TimelineSceneDependency dependency, PRISM.Adapters.GashaEffectViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask PlayAsync(PRISM.Adapters.GashaEffectViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken externalCt);
    private System.IObservable<UniRx.Unit> _onSkipWithDelay();
    private static bool _isSkipOnAllSkipped(PRISM.Adapters.CharacterAcquisitionModel model);
    private Cysharp.Threading.Tasks.UniTask _playWithSkipAsync(PRISM.Adapters.CharacterAcquisitionModel model, System.Func<System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask> taskFactory, CancellationTokenPair ct);
    private Cysharp.Threading.Tasks.UniTask _playCharacterAcquisitionAsync(PRISM.Adapters.CharacterAcquisitionModel model, PRISM.ResourceManagement.IResourceLoader resourceLoader, bool hasNext, CancellationTokenPair ct);
    public Cysharp.Threading.Tasks.UniTask DisposeAsync();

    private struct CancellationTokenPair : System.ValueType, System.IEquatable<CancellationTokenPair>
    {
        private System.Threading.CancellationToken <AllSkip>k__BackingField;
        private System.Threading.CancellationToken <External>k__BackingField;
        public System.Threading.CancellationToken AllSkip { get; set; }
        public System.Threading.CancellationToken External { get; set; }
        public bool IsAllSkipped { get; set; }
        public System.Threading.CancellationToken Alive { get; set; }
        public string ToString();
        private bool PrintMembers(System.Text.StringBuilder builder);
        public static bool op_Inequality(CancellationTokenPair left, CancellationTokenPair right);
        public static bool op_Equality(CancellationTokenPair left, CancellationTokenPair right);
        public int GetHashCode();
        public bool Equals(object obj);
        public bool Equals(CancellationTokenPair other);
        public void Deconstruct(System.Threading.CancellationToken& AllSkip, System.Threading.CancellationToken& External);
    }

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Adapters.GashaEffectDrawViewModel, System.Collections.Generic.IEnumerable<PRISM.Adapters.CharacterAcquisitionModel>> <>9__12_0;
        public static System.Func<PRISM.Adapters.CharacterAcquisitionModel, System.Collections.Generic.IEnumerable<string>> <>9__12_1;
        private System.Collections.Generic.IEnumerable<PRISM.Adapters.CharacterAcquisitionModel> <InitializeAsync>b__12_0(PRISM.Adapters.GashaEffectDrawViewModel x);
        private System.Collections.Generic.IEnumerable<string> <InitializeAsync>b__12_1(PRISM.Adapters.CharacterAcquisitionModel x);
    }

    private class <>c__DisplayClass12_0
    {
        public string[] loadedCueSheets;
        private void <InitializeAsync>b__2();
    }

    private class <>c__DisplayClass13_0
    {
        public System.Threading.CancellationTokenSource allSkipCts;
        public PRISM.Interactions.Gasha.GashaEffectScene <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private void <PlayAsync>b__0(UniRx.Unit _);
    }

    private class <>c__DisplayClass13_1
    {
        public int initialRarity;
        public PRISM.Adapters.GashaEffectDrawViewModel draw;
        public <>c__DisplayClass13_0 CS$<>8__locals1;
        private Cysharp.Threading.Tasks.UniTask <PlayAsync>b__1(System.Threading.CancellationToken skipCt);
    }

    private class <>c__DisplayClass13_2
    {
        public PRISM.Adapters.GashaLowRarityProduceIdolAcquisitionModel lowRarityProduceIdol;
        public <>c__DisplayClass13_1 CS$<>8__locals2;
        private Cysharp.Threading.Tasks.UniTask <PlayAsync>b__2(System.Threading.CancellationToken skipCt);
    }

    private class <>c__DisplayClass16_0
    {
        public System.Threading.CancellationTokenSource cts;
        private void <_playWithSkipAsync>b__0(UniRx.Unit _);
    }

    private struct <InitializeAsync>d__12 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Gasha.GashaEffectScene <>4__this;
        public PRISM.Adapters.GashaEffectViewModel viewModel;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        public PRISM.Adapters.TimelineSceneDependency dependency;
        private <>c__DisplayClass12_0 <>8__1;
        private Awaiter <>u__1;
        private Awaiter<string[]> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <PlayAsync>d__13 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Gasha.GashaEffectScene <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken externalCt;
        private <>c__DisplayClass13_0 <>8__1;
        public PRISM.Adapters.GashaEffectViewModel viewModel;
        private <>c__DisplayClass13_1 <>8__2;
        private CancellationTokenPair <ct>5__2;
        private System.IDisposable <_>5__3;
        private Awaiter<bool> <>u__1;
        private int <i>5__4;
        private Awaiter <>u__2;
        private int <index>5__5;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_playCharacterAcquisitionAsync>d__17 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public CancellationTokenPair ct;
        public PRISM.Adapters.CharacterAcquisitionModel model;
        public PRISM.Interactions.Gasha.GashaEffectScene <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public bool hasNext;
        private System.Threading.CancellationTokenSource <cts>5__2;
        private Awaiter<System.ValueTuple<bool, UniRx.Unit>> <>u__1;
        private Awaiter <>u__2;
        private Awaiter<UniRx.Unit> <>u__3;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_playWithSkipAsync>d__16 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public CancellationTokenPair ct;
        public PRISM.Adapters.CharacterAcquisitionModel model;
        public PRISM.Interactions.Gasha.GashaEffectScene <>4__this;
        public System.Func<System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask> taskFactory;
        private <>c__DisplayClass16_0 <>8__1;
        private System.IDisposable <_>5__2;
        private Awaiter<bool> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Gasha
public class GashaEffectView : UnityEngine.MonoBehaviour, PRISM.Adapters.IGashaEffectView
{
    private PRISM.SceneLoader sceneLoader;
    private PRISM.Interactions.Gasha.GashaEffectScene effectScene;
    public void Start();
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.GashaEffectViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask PlayAsync(PRISM.Adapters.GashaEffectViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask ReleaseAsync();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Interactions.Drama.DramaSceneCharacter, PRISM.UnitIdol> <>9__3_0;
        private PRISM.UnitIdol <InitializeAsync>b__3_0(PRISM.Interactions.Drama.DramaSceneCharacter x);
    }

    private struct <InitializeAsync>d__3 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public System.Threading.CancellationToken ct;
        public PRISM.Adapters.GashaEffectViewModel viewModel;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public PRISM.Interactions.Gasha.GashaEffectView <>4__this;
        private PRISM.Adapters.TimelineSceneDependency <dependency>5__2;
        private PRISM.DownloadKeyContainer <downloadKeyContainer>5__3;
        private Awaiter<PRISM.Adapters.TimelineSceneDependency> <>u__1;
        private Awaiter<UnityEngine.GameObject> <>u__2;
        private Awaiter <>u__3;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <ReleaseAsync>d__5 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Gasha.GashaEffectView <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Gasha
public class GashaNotificationReceiver : UnityEngine.MonoBehaviour, UnityEngine.Playables.INotificationReceiver
{
    private PRISM.Interactions.Gasha.GashaEffectFirstSceneControlView scene;
    private void UnityEngine.Playables.INotificationReceiver.OnNotify(UnityEngine.Playables.Playable origin, UnityEngine.Playables.INotification notification, object context);
    public void Inject(PRISM.Interactions.Gasha.GashaEffectFirstSceneControlView scene);

    private class <>c__DisplayClass1_0
    {
        public PRISM.Interactions.Gasha.GashaJumpMarker <jumpMarker>5__2;
        private bool <UnityEngine.Playables.INotificationReceiver.OnNotify>b__0(PRISM.Interactions.Gasha.GashaLabelMarker x);
    }
}

// Namespace: PRISM.Interactions.Gasha
public class GashaCriAtomSelectorLabelMarker : UnityEngine.Timeline.Marker, UnityEngine.Playables.INotification
{
    private UnityEngine.PropertyName <id>k__BackingField;
    private string selector;
    private string label;
    public UnityEngine.PropertyName id { get; set; }
    public string Selector { get; set; }
    public string Label { get; set; }
}

// Namespace: PRISM.Interactions.Gasha
public class GashaJumpMarker : UnityEngine.Timeline.Marker, UnityEngine.Playables.INotification
{
    private UnityEngine.PropertyName <id>k__BackingField;
    private string targetName;
    public UnityEngine.PropertyName id { get; set; }
    public string TargetName { get; set; }
}

// Namespace: PRISM.Interactions.Gasha
public class GashaLabelMarker : UnityEngine.Timeline.Marker, UnityEngine.Playables.INotification
{
    private UnityEngine.PropertyName <id>k__BackingField;
    private bool isSkipTarget;
    public UnityEngine.PropertyName id { get; set; }
    public bool IsSkipTarget { get; set; }
}

// Namespace: PRISM.Interactions.Gasha
public class GashaEffectFirstSceneControlView : PRISM.Interactions.Gasha.GashaEffectSceneControlView
{
    private PRISM.Interactions.Gasha.GashaEffectMonitor monitor;
    private CriWare.CriAtomSource bgmSource;
    private PRISM.Interactions.Gasha.GashaEffectMovieView[] movieViews;
    private UnityEngine.Transform disposeMovieParent;
    private double lastJumpTime;
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.GashaEffectViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask _overrideCutScenePrefabAsync(string cutSceneName, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    private void _applyTrackData(PRISM.Adapters.GashaEffectViewModel viewModel);
    private void _setChildMuted(UnityEngine.Timeline.GroupTrack track, System.Func<int, bool> isMute);
    public void Jump(System.Func<PRISM.Interactions.Gasha.GashaLabelMarker, bool> predicate);
    public Cysharp.Threading.Tasks.UniTask PlayAsync(System.IObservable<UniRx.Unit> skipObservable, System.Threading.CancellationToken ct);
    public void SetSelectorLabel(string selector, string label);
    public void StopBgm();
    public Cysharp.Threading.Tasks.UniTask DisposeAsync();
    private Cysharp.Threading.Tasks.UniTask <DisposeAsync>b__13_0(PRISM.Interactions.Gasha.GashaEffectMovieView x);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<UnityEngine.Timeline.TrackAsset, System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TimelineClip>> <>9__6_0;
        public static System.Func<UnityEngine.Timeline.TimelineClip, bool> <>9__6_1;
        public static System.Func<PRISM.Interactions.TimelineScene, UnityEngine.Playables.PlayableAsset> <>9__7_0;
        public static System.Func<UnityEngine.Timeline.TimelineAsset, System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset>> <>9__7_1;
        private System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TimelineClip> <_overrideCutScenePrefabAsync>b__6_0(UnityEngine.Timeline.TrackAsset x);
        private bool <_overrideCutScenePrefabAsync>b__6_1(UnityEngine.Timeline.TimelineClip x);
        private UnityEngine.Playables.PlayableAsset <_applyTrackData>b__7_0(PRISM.Interactions.TimelineScene x);
        private System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> <_applyTrackData>b__7_1(UnityEngine.Timeline.TimelineAsset x);
    }

    private class <>c__DisplayClass10_0
    {
        public PRISM.Interactions.Gasha.GashaEffectFirstSceneControlView <>4__this;
        public UnityEngine.Playables.PlayableDirector director;
        public System.Func<PRISM.Interactions.Gasha.GashaLabelMarker, bool> <>9__1;
        private void <PlayAsync>b__0(UniRx.Unit _);
        private bool <PlayAsync>b__1(PRISM.Interactions.Gasha.GashaLabelMarker x);
    }

    private class <>c__DisplayClass5_0
    {
        public System.Threading.CancellationToken ct;
        private Cysharp.Threading.Tasks.UniTask <InitializeAsync>b__0(PRISM.Interactions.Gasha.GashaEffectMovieView x);
    }

    private class <>c__DisplayClass7_0
    {
        public PRISM.Adapters.GashaEffectViewModel viewModel;
        public System.Func<int, bool> <>9__4;
        private bool <_applyTrackData>b__4(int i);
    }

    private class <>c__DisplayClass7_1
    {
        public string trackName;
        public PRISM.Module.Networking.IGashaEffectChanceUpStatus trackData;
        private bool <_applyTrackData>b__2(PRISM.Module.Networking.IGashaEffectChanceUpStatus x);
        private bool <_applyTrackData>b__3(int i);
    }

    private struct <InitializeAsync>d__5 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public System.Threading.CancellationToken ct;
        public PRISM.Adapters.GashaEffectViewModel viewModel;
        public PRISM.Interactions.Gasha.GashaEffectFirstSceneControlView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private <>c__DisplayClass5_0 <>8__1;
        private bool <hasCutScene>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <PlayAsync>d__10 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Gasha.GashaEffectFirstSceneControlView <>4__this;
        public System.IObservable<UniRx.Unit> skipObservable;
        public System.Threading.CancellationToken ct;
        private <>c__DisplayClass10_0 <>8__1;
        private System.IDisposable <_>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_overrideCutScenePrefabAsync>d__6 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public string cutSceneName;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        public PRISM.Interactions.Gasha.GashaEffectFirstSceneControlView <>4__this;
        private Awaiter<UnityEngine.GameObject> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Gasha
public class GashaEffectLowRarityProduceIdolSceneControlView : PRISM.Interactions.Gasha.GashaEffectSceneControlView, UnityEngine.Playables.INotificationReceiver
{
    private PRISM.Interactions.Drama.DramaSceneCharacter character;
    private PRISM.Interactions.ProduceIdolAcquisitionNameView nameView;
    private PRISM.Interactions.Gasha.GashaEffectMonitorCard monitorCard;
    private UniRx.Subject<UniRx.Unit> onNotify;
    public Cysharp.Threading.Tasks.UniTask PlayAsync(PRISM.Adapters.GashaLowRarityProduceIdolAcquisitionModel model, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    private void UnityEngine.Playables.INotificationReceiver.OnNotify(UnityEngine.Playables.Playable origin, UnityEngine.Playables.INotification notification, object context);
    private void OnDestroy();

    private struct <PlayAsync>d__4 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Adapters.GashaLowRarityProduceIdolAcquisitionModel model;
        public PRISM.Interactions.Gasha.GashaEffectLowRarityProduceIdolSceneControlView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        private Awaiter<UniRx.Unit> <>u__1;
        private Awaiter <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Gasha
public class GashaEffectSceneControlView : UnityEngine.MonoBehaviour
{
    protected PRISM.Interactions.TimelineScene timelineScene;
    public PRISM.Interactions.TimelineScene TimelineScene { get; set; }
}

// Namespace: PRISM.Interactions.Gasha
public class IdleAnimationPair
{
    public int characterId;
    public UnityEngine.AnimationClip clip;
}

// Namespace: PRISM.Interactions.Gasha
public class GashaEffectSpotLightSceneControlView : PRISM.Interactions.Gasha.GashaEffectSceneControlView
{
    private PRISM.Interactions.Drama.DramaSceneCharacter character;
    private PRISM.Interactions.Gasha.GashaEffectMonitorCard monitorCard;
    private UnityEngine.GameObject[] rarityUpObjects;
    private PRISM.Interactions.Gasha.IdleAnimationPair[] idleAnimationPairs;
    private UnityEngine.AnimationClip defaultAnimationClip;
    public Cysharp.Threading.Tasks.UniTask PlayAsync(int initialRarity, PRISM.Adapters.GashaEffectDrawViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    private void _changeIdleAnimation(int targetCharacterId, PRISM.Adapters.CharacterAcquisitionModel model, int rarity);
    private void _changeAnimationClip(string trackPath, UnityEngine.AnimationClip clip);

    private class <>c__DisplayClass5_0
    {
        public UnityEngine.Playables.PlayableDirector director;
        public double duration;
        private bool <PlayAsync>b__0();
    }

    private class <>c__DisplayClass6_0
    {
        public int targetCharacterId;
        private bool <_changeIdleAnimation>b__0(PRISM.Interactions.Gasha.IdleAnimationPair pair);
    }

    private struct <PlayAsync>d__5 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Adapters.GashaEffectDrawViewModel viewModel;
        public PRISM.Interactions.Gasha.GashaEffectSpotLightSceneControlView <>4__this;
        public int initialRarity;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        private <>c__DisplayClass5_0 <>8__1;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Gasha
public class GashaEffectTimelineSwitcher
{
    public static void Switch(PRISM.Interactions.TimelineScene timelineScene, PRISM.UnitIdol unitIdol, PRISM.Adapters.CharacterAcquisitionModel model, int initialRarity);
    public static string GetRarityTrackName(PRISM.Adapters.CharacterAcquisitionModel model, int initialRarity);
    private static void <Switch>g__SwitchProduceIdolOrSupportCharacter|1_0(UnityEngine.Timeline.TrackAsset track, bool muted, <>c__DisplayClass1_0& );
    private static void <Switch>g__SwitchEffect|1_1(UnityEngine.Timeline.TrackAsset effectGroupTrack, <>c__DisplayClass1_0& );
    private static void <Switch>g__SwitchCharacter|1_2(UnityEngine.Timeline.TrackAsset characterGroupTrack, <>c__DisplayClass1_0& );

    private class TrackNames
    {
        public static string ProduceIdol;
        public static string SupportCharacter;
        public static string Effect;
        public static string RarityPrefix;
    }

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<UnityEngine.Timeline.TrackAsset, bool> <>9__1_3;
        private bool <Switch>b__1_3(UnityEngine.Timeline.TrackAsset x);
    }

    private struct <>c__DisplayClass1_0 : System.ValueType
    {
        public PRISM.Adapters.CharacterAcquisitionModel model;
        public int initialRarity;
        public PRISM.UnitIdol unitIdol;
    }
}

// Namespace: PRISM.Interactions.Gasha
public class GashaRewardScrollCellView : PRISM.EnhancedListViewCell<PRISM.Adapters.GashaRewardScrollCellViewModel, PRISM.EnhancedListViewContext>
{
    private PRISM.Legacy.GashaProductItemPresenter productItem;
    private ENTERPRISE.UI.UITextMeshProUGUI productNameText;
    private ENTERPRISE.UI.UITextMeshProUGUI pieceDetailText;
    public void UpdateContent(PRISM.Adapters.GashaRewardScrollCellViewModel viewModel);
}

// Namespace: PRISM.Interactions.Gasha
public class GashaHistoryCellView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView btn;
    private UnityEngine.UI.Image imgLogo;
    private ENTERPRISE.UI.UITextMeshProUGUI txtMsg1;
    private ENTERPRISE.UI.UITextMeshProUGUI txtMsg2;
    private PRISM.Interactions.Gasha.GashaHistoryProductLabelView productLabelBase;
    private System.IDisposable disposable;
    public void Setup(PRISM.Module.Networking.IGashaHistoryStatus gashaHistory, PRISM.ResourceManagement.IResourceLoader loader, System.Threading.CancellationToken ct, System.Action<PRISM.Module.Networking.IGashaHistoryStatus> onClick);
    private void OnDestroy();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Module.Networking.IProductWithAmountStatus, int, System.ValueTuple<PRISM.Module.Networking.IProductWithAmountStatus, int>> <>9__6_1;
        private System.ValueTuple<PRISM.Module.Networking.IProductWithAmountStatus, int> <Setup>b__6_1(PRISM.Module.Networking.IProductWithAmountStatus x, int i);
    }

    private class <>c__DisplayClass6_0
    {
        public System.Action<PRISM.Module.Networking.IGashaHistoryStatus> onClick;
        public PRISM.Module.Networking.IGashaHistoryStatus gashaHistory;
        private void <Setup>b__0(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.Gasha
public class GashaHistoryDetailCellView : UnityEngine.MonoBehaviour
{
    private PRISM.Legacy.GashaProductItemPresenter gashaProductItem;
    private ENTERPRISE.UI.UITextMeshProUGUI txtName;
    private UnityEngine.GameObject[] stars;
    private UnityEngine.GameObject[] raritys;
    private ENTERPRISE.UI.UITextMeshProUGUI txtVolue;
    private PRISM.Legacy.GashaProductItemPresenter[] extraProductItems;
    private ENTERPRISE.UI.UITextMeshProUGUI[] extraProductItemAmount;
    private ENTERPRISE.UI.UITextMeshProUGUI txtPieceDetail;
    public void Setup(PRISM.Module.Networking.IGashaRewardProductStatus gashaRewardProduct, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void Setup(PRISM.Module.Networking.IRewardProductStatus rewardProduct, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IGashaExtraRewardProductStatus> extraProductList);
    private void _init();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Module.Networking.IGashaExtraRewardProductStatus, bool> <>9__9_0;
        public static System.Func<PRISM.Module.Networking.IGashaExtraRewardProductStatus, bool> <>9__9_1;
        public static System.Func<PRISM.Module.Networking.IGashaExtraRewardProductStatus, int> <>9__9_2;
        private bool <Setup>b__9_0(PRISM.Module.Networking.IGashaExtraRewardProductStatus status);
        private bool <Setup>b__9_1(PRISM.Module.Networking.IGashaExtraRewardProductStatus status);
        private int <Setup>b__9_2(PRISM.Module.Networking.IGashaExtraRewardProductStatus status);
    }
}

// Namespace: PRISM.Interactions.Gasha
public class GashaHistoryDetailDoubleCellView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.Gasha.GashaHistoryDetailCellView mainCell;
    private PRISM.Interactions.Gasha.GashaHistoryDetailCellView addCell;
    public void Setup(PRISM.Module.Networking.IGashaRewardProductStatus mainProduct, PRISM.Module.Networking.IGashaRewardProductStatus addProduct, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Interactions.Gasha
public class GashaHistoryDetailScrollView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.Gasha.GashaHistoryCellView gashaHistoryCell;
    private PRISM.Interactions.Gasha.GashaHistoryDetailCellView templateCell;
    private PRISM.Interactions.Gasha.GashaHistoryDetailDoubleCellView templateDoubleCell;
    private UnityEngine.Transform traGasha;
    private UnityEngine.Transform traGashaTitle;
    private UnityEngine.Transform traOmake;
    private UnityEngine.Transform traOmakeTitle;
    private UnityEngine.Transform traPrismGauge;
    private UnityEngine.Transform traPrismGaugeTitle;
    public void Setup(PRISM.Module.Networking.IGashaHistoryStatus gashaHistory, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Module.Networking.IGashaRewardProductStatus, int, System.ValueTuple<int, PRISM.Module.Networking.IGashaRewardProductStatus>> <>9__9_0;
        public static System.Func<System.ValueTuple<int, PRISM.Module.Networking.IGashaRewardProductStatus>, int> <>9__9_1;
        public static System.Func<System.Linq.IGrouping<int, System.ValueTuple<int, PRISM.Module.Networking.IGashaRewardProductStatus>>, int> <>9__9_2;
        public static System.Func<System.ValueTuple<int, PRISM.Module.Networking.IGashaRewardProductStatus>, bool> <>9__9_3;
        private System.ValueTuple<int, PRISM.Module.Networking.IGashaRewardProductStatus> <Setup>b__9_0(PRISM.Module.Networking.IGashaRewardProductStatus rewardProduct, int index);
        private int <Setup>b__9_1(System.ValueTuple<int, PRISM.Module.Networking.IGashaRewardProductStatus> x);
        private int <Setup>b__9_2(System.Linq.IGrouping<int, System.ValueTuple<int, PRISM.Module.Networking.IGashaRewardProductStatus>> x);
        private bool <Setup>b__9_3(System.ValueTuple<int, PRISM.Module.Networking.IGashaRewardProductStatus> x);
    }

    private class <>c__DisplayClass9_0
    {
        public System.ValueTuple<int, PRISM.Module.Networking.IGashaRewardProductStatus> mainProduct;
        private bool <Setup>b__4(System.ValueTuple<int, PRISM.Module.Networking.IGashaRewardProductStatus> x);
    }
}

// Namespace: PRISM.Interactions.Gasha
public class GashaHistoryProductLabelView : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.RawImage icon;
    private SpecialIcon[] specialIcons;
    private ENTERPRISE.UI.UITextMeshProUGUI amountText;
    public void Setup(PRISM.Module.Networking.IProductWithAmountStatus product, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken token);

    private struct SpecialIcon : System.ValueType
    {
        public ProductType ProductType;
        public int ProductMstId;
        public UnityEngine.GameObject Object;
    }
}

// Namespace: PRISM.Interactions.Gasha
public class GashaRatesSelectCellView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView btn;
    private UnityEngine.UI.Image imgLogo;
    private ENTERPRISE.UI.UITextMeshProUGUI txtGashaName;
    public System.IObservable<UniRx.Unit> OnClickCell { get; set; }
    public void Setup(PRISM.Module.Networking.IGashaTicketTargetGashaStatus gashaTicketTargetGasha, PRISM.ResourceManagement.IResourceLoader loader, System.Threading.CancellationToken ct);
}

// Namespace: PRISM.Interactions.Gasha
public class ResourceLoaderExtensions
{
    public static Cysharp.Threading.Tasks.UniTask<UnityEngine.Sprite> LoadGashaLogoAsync(PRISM.ResourceManagement.IResourceLoader loader, string resourceId, System.Threading.CancellationToken ct);
}

// Namespace: PRISM.Interactions.Gasha
public class GashaResultCardAreaView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.Gasha.GashaResultCardView[] cardViews;
    private ENTERPRISE.UI.UITextMeshProUGUI txtAnnotation;
    private UnityEngine.Animator animator;
    public System.IObservable<System.ValueTuple<PRISM.Module.Networking.IProductWithAmountStatus, int>> OnCardClick { get; set; }
    public System.IObservable<System.ValueTuple<PRISM.Module.Networking.IProductWithAmountStatus, int>> OnCardLongPress { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(System.Collections.Generic.List<System.Linq.IGrouping<int, PRISM.Module.Networking.IGashaRewardProductStatus>> drawProductList, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken skipCt);
    public void StartBlinking();
    private Cysharp.Threading.Tasks.UniTask _waitAnimatorAsync(System.Threading.CancellationToken ct);
    public void Select(int index);
    public void UnSelect(int index);
    public void AllUnSelect();
    public System.ValueTuple<PRISM.Module.Networking.IProductStatus, PRISM.Module.Networking.IProductStatus> GetProductStatus(int index);
    public void SetUiActive(bool value);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Interactions.Gasha.GashaResultCardView, int, System.IObservable<System.ValueTuple<PRISM.Module.Networking.IProductWithAmountStatus, int>>> <>9__4_0;
        public static System.Func<PRISM.Interactions.Gasha.GashaResultCardView, int, System.IObservable<System.ValueTuple<PRISM.Module.Networking.IProductWithAmountStatus, int>>> <>9__6_0;
        public static System.Func<PRISM.Module.Networking.IGashaRewardProductStatus, bool> <>9__7_2;
        public static System.Func<System.Linq.IGrouping<int, PRISM.Module.Networking.IGashaRewardProductStatus>, bool> <>9__7_0;
        public static System.Func<PRISM.Module.Networking.IGashaRewardProductStatus, bool> <>9__7_3;
        public static System.Func<System.Linq.IGrouping<int, PRISM.Module.Networking.IGashaRewardProductStatus>, bool> <>9__7_1;
        public static System.Func<PRISM.Interactions.Gasha.GashaResultCardView, bool> <>9__8_0;
        private System.IObservable<System.ValueTuple<PRISM.Module.Networking.IProductWithAmountStatus, int>> <get_OnCardClick>b__4_0(PRISM.Interactions.Gasha.GashaResultCardView cardView, int index);
        private System.IObservable<System.ValueTuple<PRISM.Module.Networking.IProductWithAmountStatus, int>> <get_OnCardLongPress>b__6_0(PRISM.Interactions.Gasha.GashaResultCardView cardView, int index);
        private bool <InitializeAsync>b__7_0(System.Linq.IGrouping<int, PRISM.Module.Networking.IGashaRewardProductStatus> list);
        private bool <InitializeAsync>b__7_2(PRISM.Module.Networking.IGashaRewardProductStatus x);
        private bool <InitializeAsync>b__7_1(System.Linq.IGrouping<int, PRISM.Module.Networking.IGashaRewardProductStatus> list);
        private bool <InitializeAsync>b__7_3(PRISM.Module.Networking.IGashaRewardProductStatus x);
        private bool <ShowAsync>b__8_0(PRISM.Interactions.Gasha.GashaResultCardView view);
    }

    private class <>c__DisplayClass4_0
    {
        public int index;
        private System.ValueTuple<PRISM.Module.Networking.IProductWithAmountStatus, int> <get_OnCardClick>b__1(PRISM.Module.Networking.IProductWithAmountStatus p);
    }

    private class <>c__DisplayClass6_0
    {
        public int index;
        private System.ValueTuple<PRISM.Module.Networking.IProductWithAmountStatus, int> <get_OnCardLongPress>b__1(PRISM.Module.Networking.IProductWithAmountStatus p);
    }

    private struct <InitializeAsync>d__7 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Gasha.GashaResultCardAreaView <>4__this;
        public System.Collections.Generic.List<System.Linq.IGrouping<int, PRISM.Module.Networking.IGashaRewardProductStatus>> drawProductList;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <ShowAsync>d__8 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Gasha.GashaResultCardAreaView <>4__this;
        public System.Threading.CancellationToken skipCt;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_waitAnimatorAsync>d__10 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Gasha.GashaResultCardAreaView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Gasha
public class GashaResultCardView : UnityEngine.MonoBehaviour
{
    private UnityEngine.Transform pIdolParent;
    private UnityEngine.Transform pIdolBackdropParent;
    private UnityEngine.Material pIdolBackdropMaterial;
    private UnityEngine.Color pIdolBackdropColor;
    private ENTERPRISE.OutGame.RewardItem pIdolPieceIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI pIdolPieceDetail;
    private UnityEngine.UI.RawImage sCharaImage;
    private UnityEngine.UI.RawImage sCharaBackdropImage;
    private ENTERPRISE.OutGame.RewardItem sCharaPieceIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI sCharaPieceDetail;
    private UnityEngine.GameObject newIcon;
    private PRISM.Interactions.SupportCharacterIconView addSCharaIconView;
    private UnityEngine.GameObject addSCharaNewIcon;
    private ENTERPRISE.OutGame.RewardItem addSCharaPieceIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI addSCharaPieceDetail;
    private PRISM.Interactions.ViewStateChanger productTypeChanger;
    private PRISM.Interactions.ViewStateChanger rarityChanger;
    private UnityEngine.UI.RawImage imgConvertItem;
    private ENTERPRISE.UI.UITextMeshProUGUI convertAmountText;
    private UnityEngine.CanvasGroup canvasGroupReward;
    private UnityEngine.CanvasGroup canvasGroupAddReward;
    private UnityEngine.CanvasGroup canvasGroupConvert;
    private UnityEngine.Animator cardAnimator;
    private PRISM.Interactions.ButtonView mainCharaButton;
    private PRISM.Interactions.ButtonView addCharaButton;
    private UnityEngine.GameObject selectFrame;
    private UnityEngine.Animator animator;
    private ENTERPRISE.UI.AnimatorWithEvent animatorEvent;
    private PRISM.Module.Networking.IGashaRewardProductStatus mainReward;
    private PRISM.Module.Networking.IGashaRewardProductStatus addReward;
    private static float ChangeTime;
    private static int ConvertChangeLoopMilliSeconds;
    private bool isConvertBlink;
    public System.IObservable<PRISM.Module.Networking.IProductWithAmountStatus> OnClick { get; set; }
    public System.IObservable<PRISM.Module.Networking.IProductWithAmountStatus> OnLongPress { get; set; }
    public void Select();
    public void UnSelect();
    public System.ValueTuple<PRISM.Module.Networking.IProductStatus, PRISM.Module.Networking.IProductStatus> GetProductStatus();
    public Cysharp.Threading.Tasks.UniTask SetupAsync(System.Linq.IGrouping<int, PRISM.Module.Networking.IGashaRewardProductStatus> drawProductList, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    private void _setupPiece(System.Collections.Generic.List<PRISM.Module.Networking.IGashaExtraRewardProductStatus> pieceProducts, ENTERPRISE.OutGame.RewardItem pieceIcon, ENTERPRISE.UI.UITextMeshProUGUI pieceDetailText, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public Cysharp.Threading.Tasks.UniTask StartBlinkAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask WaitAnimatorAsync(System.Threading.CancellationToken skipCt);
    private PRISM.Module.Networking.IProductWithAmountStatus <get_OnClick>b__29_0(UniRx.Unit _);
    private PRISM.Module.Networking.IProductWithAmountStatus <get_OnClick>b__29_1(UniRx.Unit _);
    private PRISM.Module.Networking.IProductWithAmountStatus <get_OnLongPress>b__31_0(UniRx.Unit _);
    private PRISM.Module.Networking.IProductWithAmountStatus <get_OnLongPress>b__31_1(UniRx.Unit _);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Module.Networking.IGashaRewardProductStatus, bool> <>9__40_0;
        public static System.Func<PRISM.Module.Networking.IGashaRewardProductStatus, bool> <>9__40_1;
        public static System.Func<PRISM.Module.Networking.IGashaExtraRewardProductStatus, bool> <>9__41_0;
        public static System.Func<PRISM.Module.Networking.IGashaExtraRewardProductStatus, bool> <>9__41_1;
        public static System.Func<PRISM.Module.Networking.IGashaExtraRewardProductStatus, int> <>9__41_2;
        public static System.Action<string> <>9__43_0;
        private bool <SetupAsync>b__40_0(PRISM.Module.Networking.IGashaRewardProductStatus x);
        private bool <SetupAsync>b__40_1(PRISM.Module.Networking.IGashaRewardProductStatus x);
        private bool <_setupPiece>b__41_0(PRISM.Module.Networking.IGashaExtraRewardProductStatus status);
        private bool <_setupPiece>b__41_1(PRISM.Module.Networking.IGashaExtraRewardProductStatus status);
        private int <_setupPiece>b__41_2(PRISM.Module.Networking.IGashaExtraRewardProductStatus status);
        private void <WaitAnimatorAsync>b__43_0(string _);
    }

    private struct <SetupAsync>d__40 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Gasha.GashaResultCardView <>4__this;
        public System.Linq.IGrouping<int, PRISM.Module.Networking.IGashaRewardProductStatus> drawProductList;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        private System.Collections.Generic.List<PRISM.Module.Networking.IGashaExtraRewardProductStatus> <pieceProducts>5__2;
        private Awaiter<UnityEngine.GameObject> <>u__1;
        private Awaiter <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <StartBlinkAsync>d__42 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Gasha.GashaResultCardView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <WaitAnimatorAsync>d__43 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Gasha.GashaResultCardView <>4__this;
        public System.Threading.CancellationToken skipCt;
        private int <>7__wrap1;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Gasha
public class GashaResultItem : UnityEngine.MonoBehaviour
{
    private PRISM.UI.PFIdolIconView pFIdolIconView;
    private PRISM.UI.SCharaIconView sCharaIconView;
    private ENTERPRISE.OutGame.RewardItem cmnItem;
    private ENTERPRISE.OutGame.RewardItem cmnItemPieceIconP;
    private ENTERPRISE.OutGame.RewardItem cmnItemPieceIconS;
    private ENTERPRISE.UI.UITextMeshProUGUI txtPieceDetailP;
    private ENTERPRISE.UI.UITextMeshProUGUI txtPieceDetailS;
    private UnityEngine.UI.RawImage imgConvertItem;
    private ENTERPRISE.UI.UITextMeshProUGUI txtAmount;
    private ENTERPRISE.UI.ButtonBase btnPIdol;
    private ENTERPRISE.UI.ButtonBase btnSChara;
    private UnityEngine.GameObject goNew;
    private UnityEngine.Animator pIdolBackgroundAnimator;
    private UnityEngine.Animator sCharaBackgroundAnimator;
    private UnityEngine.Animator itemEffectAnimator;
    private UnityEngine.CanvasGroup canvasGroupReward;
    private UnityEngine.CanvasGroup canvasGroupConvert;
    private UnityEngine.GameObject goSelectFrame;
    private PRISM.Module.Networking.IProductStatus <SelectedProduct>k__BackingField;
    private int <GashaResultIndex>k__BackingField;
    private bool isShowReward;
    private PRISM.Module.Networking.IRewardProductStatus rewardProduct;
    private PRISM.Module.Networking.IProductWithAmountStatus pickupProduc;
    private int rewardRarity;
    private static float ChangeTime;
    private static int ConvertChangeLoopMilliSeconds;
    private System.Threading.CancellationTokenSource ctc;
    public PRISM.Module.Networking.IProductStatus SelectedProduct { get; set; }
    public int GashaResultIndex { get; set; }
    public void SetupIdol(PRISM.Module.Networking.IRewardProductStatus rewardProduct, System.Collections.Generic.List<PRISM.Module.Networking.IGashaExtraRewardProductStatus> pieceProducts, PRISM.Module.Networking.IGashaPriceStatus gashaPrice, int gashaResultIndex, PRISM.ResourceManagement.IResourceLoader resourceLoader, bool isSelect, UniRx.Subject<System.ValueTuple<bool, PRISM.Interactions.Gasha.GashaResultItem>> OnItemClick);
    public void Select();
    public void UnSelect();
    public Cysharp.Threading.Tasks.UniTask ShowAsync(bool isAnimation, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask StartBlinkAsync();
    public void SetupItem(PRISM.Module.Networking.IRewardProductStatus rewardProduct, int rewardRarity, int gashaResultIndex, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void OnDestroy();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Module.Networking.IGashaExtraRewardProductStatus, bool> <>9__33_4;
        public static System.Func<PRISM.Module.Networking.IGashaExtraRewardProductStatus, bool> <>9__33_5;
        public static System.Func<PRISM.Module.Networking.IGashaExtraRewardProductStatus, int> <>9__33_6;
        private bool <SetupIdol>b__33_4(PRISM.Module.Networking.IGashaExtraRewardProductStatus status);
        private bool <SetupIdol>b__33_5(PRISM.Module.Networking.IGashaExtraRewardProductStatus status);
        private int <SetupIdol>b__33_6(PRISM.Module.Networking.IGashaExtraRewardProductStatus status);
    }

    private class <>c__DisplayClass33_0
    {
        public PRISM.Module.Networking.IRewardProductStatus rewardProduct;
        public UnityEngine.Animator itemBackgroundAnimator;
        public int rarity;
        public UniRx.Subject<System.ValueTuple<bool, PRISM.Interactions.Gasha.GashaResultItem>> OnItemClick;
        public PRISM.Interactions.Gasha.GashaResultItem <>4__this;
        public bool isProduceIdol;
        public PRISM.Module.Networking.IGashaPriceStatus gashaPrice;
        public System.Threading.CancellationToken ct;
        private bool <SetupIdol>b__0(PRISM.Module.Networking.IGashaExtraRewardProductStatus x);
        private void <SetupIdol>b__1(long _);
        private void <SetupIdol>b__2();
        private void <SetupIdol>b__3();

        private struct <<SetupIdol>b__3>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
        {
            public int <>1__state;
            public System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
            public <>c__DisplayClass33_0 <>4__this;
            private Awaiter<bool> <>u__1;
            private Awaiter <>u__2;
            private void MoveNext();
            private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }

    private struct <ShowAsync>d__36 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Gasha.GashaResultItem <>4__this;
        public bool isAnimation;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <StartBlinkAsync>d__37 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Gasha.GashaResultItem <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Gasha
public class GashaResultShare : UnityEngine.MonoBehaviour
{
    private UnityEngine.GameObject goBtnRoot;
    private PRISM.Interactions.ButtonView cancelButton;
    private PRISM.Interactions.ButtonView shareButton;
    private UnityEngine.GameObject goEnableShare;
    private UnityEngine.GameObject goItems;
    private UnityEngine.CanvasGroup canvasGroupItems;
    private ENTERPRISE.UI.UITextMeshProUGUI iconSelectInfoText;
    private ENTERPRISE.UI.UITextMeshProUGUI copyrightText;
    private UnityEngine.GameObject goLogo;
    private PRISM.Interactions.Gasha.GashaResultCardAreaView cardAreaView;
    private ENTERPRISE.UI.UITextMeshProUGUI cardAreaInfoText;
    private UnityEngine.GameObject goSelect;
    private PRISM.Interactions.ButtonView btnClose;
    private ENTERPRISE.UI.UITextMeshProUGUI guideText;
    private ENTERPRISE.UI.UITextMeshProUGUI cautionaryText;
    private PRISM.Interactions.ButtonView idolButton;
    private PRISM.Interactions.ButtonView idolAndResultButton;
    private PRISM.Interactions.ButtonView resultButton;
    private ENTERPRISE.UI.UITextMeshProUGUI idolText;
    private ENTERPRISE.UI.UITextMeshProUGUI idolAndResultText;
    private ENTERPRISE.UI.UITextMeshProUGUI resultText;
    private System.Collections.Generic.Dictionary<System.ValueTuple<int, int>, PRISM.Module.Networking.IProductStatus> selectedResultCard;
    private System.Collections.Generic.List<PRISM.Interactions.Gasha.GashaResultItem> selectedResultItem;
    private ShareType shareType;
    private bool isProduceIdol;
    private bool isSupportCharacter;
    private int shareLimit;
    private System.Collections.Generic.List<PRISM.Interactions.Gasha.GashaResultItem> gashaResultItems;
    private UniRx.Subject<System.ValueTuple<bool, PRISM.Interactions.Gasha.GashaResultItem>> onItemClick;
    private UniRx.CompositeDisposable btnDisposable;
    private System.Action onClose;
    private System.IDisposable backDisposable;
    public void Start();
    public void Setup(System.Collections.Generic.List<System.Linq.IGrouping<int, PRISM.Module.Networking.IGashaRewardProductStatus>> drawProductList, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public void Setup(UnityEngine.GameObject goTemp, PRISM.Module.Networking.IGashaPriceStatus gashaPrice, System.Collections.Generic.List<PRISM.Module.Networking.IGashaRewardProductStatus> gashaRewardProducts, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    private void _setupUi(System.Threading.CancellationToken ct);
    public void Show(bool isCharaGasha, System.Action OnClose, System.Threading.CancellationToken ct);
    private void _hide();
    private void _allUnSelect();
    private Cysharp.Threading.Tasks.UniTask _onClickShareButtonAsync(System.Threading.CancellationToken ct);
    private string _getProductName(PRISM.Module.Networking.IProductStatus selectedProduct);
    private string _getShareText();
    public void OnDestroy();
    private void <Setup>b__34_2(System.ValueTuple<PRISM.Module.Networking.IProductWithAmountStatus, int> obj);
    private void <Setup>b__35_0(System.ValueTuple<bool, PRISM.Interactions.Gasha.GashaResultItem> obj);
    private void <Show>b__37_0(UniRx.Unit _);

    private enum ShareType : System.Enum
    {
        public int value__;
        public static ShareType IdolOnly;
        public static ShareType IdolAndResult;
        public static ShareType ResultOnly;
    }

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Module.Networking.IGashaRewardProductStatus, bool> <>9__34_3;
        public static System.Func<System.Linq.IGrouping<int, PRISM.Module.Networking.IGashaRewardProductStatus>, bool> <>9__34_0;
        public static System.Func<PRISM.Module.Networking.IGashaRewardProductStatus, bool> <>9__34_4;
        public static System.Func<System.Linq.IGrouping<int, PRISM.Module.Networking.IGashaRewardProductStatus>, bool> <>9__34_1;
        public static System.Func<PRISM.Interactions.Gasha.GashaResultItem, int> <>9__40_0;
        public static System.Func<PRISM.Interactions.Gasha.GashaResultItem, PRISM.Module.Networking.IProductStatus> <>9__40_1;
        public static System.Func<System.Collections.Generic.KeyValuePair<System.ValueTuple<int, int>, PRISM.Module.Networking.IProductStatus>, int> <>9__40_2;
        public static System.Func<System.Collections.Generic.KeyValuePair<System.ValueTuple<int, int>, PRISM.Module.Networking.IProductStatus>, PRISM.Module.Networking.IProductStatus> <>9__40_3;
        private bool <Setup>b__34_0(System.Linq.IGrouping<int, PRISM.Module.Networking.IGashaRewardProductStatus> list);
        private bool <Setup>b__34_3(PRISM.Module.Networking.IGashaRewardProductStatus x);
        private bool <Setup>b__34_1(System.Linq.IGrouping<int, PRISM.Module.Networking.IGashaRewardProductStatus> list);
        private bool <Setup>b__34_4(PRISM.Module.Networking.IGashaRewardProductStatus x);
        private int <_onClickShareButtonAsync>b__40_0(PRISM.Interactions.Gasha.GashaResultItem item);
        private PRISM.Module.Networking.IProductStatus <_onClickShareButtonAsync>b__40_1(PRISM.Interactions.Gasha.GashaResultItem item);
        private int <_onClickShareButtonAsync>b__40_2(System.Collections.Generic.KeyValuePair<System.ValueTuple<int, int>, PRISM.Module.Networking.IProductStatus> item);
        private PRISM.Module.Networking.IProductStatus <_onClickShareButtonAsync>b__40_3(System.Collections.Generic.KeyValuePair<System.ValueTuple<int, int>, PRISM.Module.Networking.IProductStatus> item);
    }

    private class <>c__DisplayClass35_0
    {
        public PRISM.Interactions.Gasha.GashaResultItem gashaResultItem;
        private bool <Setup>b__1(PRISM.Interactions.Gasha.GashaResultItem x);
    }

    private class <>c__DisplayClass36_0
    {
        public PRISM.Interactions.Gasha.GashaResultShare <>4__this;
        public string msg;
        public System.Threading.CancellationToken ct;
        private void <_setupUi>b__0(UniRx.Unit _);
        private void <_setupUi>b__1(UniRx.Unit _);
        private void <_setupUi>b__2(UniRx.Unit _);
        private void <_setupUi>b__3(UniRx.Unit _);
        private Cysharp.Threading.Tasks.UniTaskVoid <_setupUi>b__4(UniRx.Unit _);
        private void <_setupUi>b__5(UniRx.Unit _);

        private struct <<_setupUi>b__4>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
        {
            public int <>1__state;
            public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
            public <>c__DisplayClass36_0 <>4__this;
            private Awaiter <>u__1;
            private void MoveNext();
            private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }

    private struct <_onClickShareButtonAsync>d__40 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Gasha.GashaResultShare <>4__this;
        public System.Threading.CancellationToken ct;
        private System.IDisposable <_>5__2;
        private PRISM.ResourceManagement.IRawResourceLoader <loader>5__3;
        private Cysharp.Text.Utf16ValueStringBuilder <sb>5__4;
        private NativeShare <payload>5__5;
        private int <count>5__6;
        private System.Collections.Generic.List<PRISM.Module.Networking.IProductStatus> <selectedProductList>5__7;
        private Enumerator<PRISM.Module.Networking.IProductStatus> <>7__wrap7;
        private PRISM.Module.Networking.IProductStatus <selectedProduct>5__9;
        private string <fileName>5__10;
        private NativeShare <>7__wrap10;
        private Awaiter<byte[]> <>u__1;
        private Awaiter <>u__2;
        private Awaiter<System.ValueTuple<ShareResult, string>> <>u__3;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Gasha
public class GashaResultView : UnityEngine.MonoBehaviour, PRISM.Adapters.IGashaResultView, System.IDisposable
{
    private PRISM.Interactions.ButtonView btnOK;
    private PRISM.Interactions.ButtonView btnOmake;
    private PRISM.Interactions.ButtonView btnSkip;
    private PRISM.Interactions.ButtonView btnUiHide;
    private PRISM.Interactions.ButtonView btnUiShow;
    private PRISM.Interactions.GashaButton btnRetryGasha;
    private PRISM.Interactions.ButtonView btnEndlessRetryGasha;
    private PRISM.Interactions.JewelAmountPanelView jewelAmountPanelView;
    private PRISM.Interactions.JewelLimitedSalePanelView jewelLimitedSalePanelView;
    private UnityEngine.GameObject goTopArea;
    private UnityEngine.GameObject goBottomArea;
    private UnityEngine.UI.RawImage imgBackground;
    private UnityEngine.UI.Image imgDisable;
    private UnityEngine.Animator resultAnimator;
    private UnityEngine.Animator backgroundAnimator;
    private UnityEngine.GameObject middleArea;
    private PRISM.Interactions.ViewStateChanger resultTypeChanger;
    private PRISM.Interactions.Gasha.GashaResultCardAreaView cardAreaView;
    private UnityEngine.CanvasGroup canvasGroupCardArea;
    private UnityEngine.GameObject goTemplateIco;
    private UnityEngine.GameObject goTemplateItemIco;
    private UnityEngine.Transform traItemRoot;
    private UnityEngine.GameObject goMiddleArea;
    private UnityEngine.CanvasGroup canvasGroupMiddleArea;
    private ENTERPRISE.UI.UITextMeshProUGUI txtBottomMsg;
    private UnityEngine.GameObject goExChangePointRoot;
    private PRISM.Interactions.ButtonView btnExChangePoint;
    private ENTERPRISE.UI.UITextMeshProUGUI txtExChangePointBefor;
    private ENTERPRISE.UI.UITextMeshProUGUI txtExChangePointAfter;
    private UnityEngine.GameObject goPrismGaugePointRoot;
    private PRISM.Interactions.ButtonView btnPrismGaugePointPoint;
    private ENTERPRISE.UI.UITextMeshProUGUI txtPrismGaugePointBefor;
    private ENTERPRISE.UI.UITextMeshProUGUI txtPrismGaugePointAfter;
    private PRISM.Interactions.GashaTokenArea gashaTokenArea;
    private ENTERPRISE.UI.UITextMeshProUGUI txtOKBtn;
    private PRISM.Interactions.ButtonView btnInterruption;
    private PRISM.Interactions.ButtonView btnShare;
    private PRISM.Interactions.Gasha.GashaResultShare gashaResultShare;
    private System.Collections.Generic.List<System.ValueTuple<PRISM.Interactions.Gasha.GashaResultItem, int>> goIcons;
    private UniRx.Subject<UniRx.Unit> onClickRetryButton;
    private System.Func<Cysharp.Threading.Tasks.UniTask<PRISM.Domain.Jewel>> <OnNeedJewel>k__BackingField;
    private bool isCharaGasha;
    private bool isAnyPickup;
    public System.IObservable<UniRx.Unit> OnClickRetryButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickInterruptionButton { get; set; }
    public System.Func<Cysharp.Threading.Tasks.UniTask<PRISM.Domain.Jewel>> OnNeedJewel { get; set; }
    public System.IObservable<UniRx.Unit> OnClickOKButton { get; set; }
    public PRISM.Adapters.IBackKeyObservable OnBackKey { get; set; }
    public System.IObservable<UniRx.Unit> OnBonusAcquisitionOnClick { get; set; }
    public System.IObservable<UniRx.Unit> OnClickUiHide { get; set; }
    public System.IObservable<UniRx.Unit> OnClickUiShow { get; set; }
    public System.IObservable<UniRx.Unit> OnSkipClick { get; set; }
    public System.IObservable<UniRx.Unit> OnClickShowExchangeHelpButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickShowPrismGaugeHelpButton { get; set; }
    public System.IObservable<System.ValueTuple<PRISM.Module.Networking.IProductWithAmountStatus, int>> OnCardClick { get; set; }
    public PRISM.Adapters.IJewelAmountPanelView JewelAmountPanelView { get; set; }
    public PRISM.Adapters.IJewelLimitedSalePanelView JewelLimitedSalePanelView { get; set; }
    public bool IsActive { get; set; }
    public bool IsUiActive { get; set; }
    public void Start();
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(string gashaId, string gashaPriceId, PRISM.Gasha.GashaResultData gashaResultData, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken resultCt);
    public Cysharp.Threading.Tasks.UniTask OnBeginIdleAsync(System.Threading.CancellationToken skipCt, System.Threading.CancellationToken viewCt);
    public Cysharp.Threading.Tasks.UniTask UpdateCurrentGashaTokenAsync(string gashaId, string gashaPriceId, PRISM.Gasha.GashaResultData gashaResultData, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken resultCt);
    public void UpdateCurrentGashaTokenAmount(PRISM.Module.Networking.IGashaPriceStatus gashaPrice, long amount, bool isShowRetryBtn);
    public void Dispose();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Module.Networking.IGashaPrismGaugeRewardStatus, int> <>9__73_4;
        public static System.Func<PRISM.Module.Networking.IGashaRewardProductStatus, int> <>9__73_1;
        public static System.Func<System.Linq.IGrouping<int, PRISM.Module.Networking.IGashaRewardProductStatus>, int> <>9__73_2;
        public static System.Func<PRISM.Module.Networking.IGashaRewardProductStatus, bool> <>9__73_5;
        public static System.Func<System.Linq.IGrouping<int, PRISM.Module.Networking.IGashaRewardProductStatus>, bool> <>9__73_3;
        public static System.Func<PRISM.Module.Networking.IGashaRewardProductStatus, bool> <>9__73_6;
        public static System.Func<PRISM.Module.Networking.IGashaRewardProductStatus, bool> <>9__73_7;
        public static System.Func<PRISM.Module.Networking.IGashaRewardProductStatus, bool> <>9__73_8;
        private int <InitializeAsync>b__73_4(PRISM.Module.Networking.IGashaPrismGaugeRewardStatus x);
        private int <InitializeAsync>b__73_1(PRISM.Module.Networking.IGashaRewardProductStatus x);
        private int <InitializeAsync>b__73_2(System.Linq.IGrouping<int, PRISM.Module.Networking.IGashaRewardProductStatus> x);
        private bool <InitializeAsync>b__73_3(System.Linq.IGrouping<int, PRISM.Module.Networking.IGashaRewardProductStatus> list);
        private bool <InitializeAsync>b__73_5(PRISM.Module.Networking.IGashaRewardProductStatus x);
        private bool <InitializeAsync>b__73_6(PRISM.Module.Networking.IGashaRewardProductStatus x);
        private bool <InitializeAsync>b__73_7(PRISM.Module.Networking.IGashaRewardProductStatus x);
        private bool <InitializeAsync>b__73_8(PRISM.Module.Networking.IGashaRewardProductStatus x);
    }

    private class <>c__DisplayClass73_0
    {
        public string gashaPriceId;
        private bool <InitializeAsync>b__0(PRISM.Module.Networking.IGashaPriceStatus x);
    }

    private class <>c__DisplayClass75_0
    {
        public string gashaPriceId;
        public PRISM.Interactions.Gasha.GashaResultView <>4__this;
        private bool <UpdateCurrentGashaTokenAsync>b__0(PRISM.Module.Networking.IGashaPriceStatus x);
        private void <UpdateCurrentGashaTokenAsync>b__1(string gashaId, string gashaPriceId);
    }

    private struct <InitializeAsync>d__73 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public string gashaPriceId;
        public PRISM.Interactions.Gasha.GashaResultView <>4__this;
        public PRISM.Gasha.GashaResultData gashaResultData;
        public string gashaId;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken resultCt;
        private PRISM.Module.Networking.IGashaPriceStatus <gashaPrice>5__2;
        private System.Collections.Generic.List<System.Linq.IGrouping<int, PRISM.Module.Networking.IGashaRewardProductStatus>> <drawProductList>5__3;
        private Awaiter <>u__1;
        private Awaiter<CriWare.CriAtomExPlayback> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <OnBeginIdleAsync>d__74 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Gasha.GashaResultView <>4__this;
        public System.Threading.CancellationToken skipCt;
        public System.Threading.CancellationToken viewCt;
        private Awaiter <>u__1;
        private Enumerator<System.ValueTuple<PRISM.Interactions.Gasha.GashaResultItem, int>> <>7__wrap1;
        private Awaiter<bool> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <UpdateCurrentGashaTokenAsync>d__75 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public string gashaPriceId;
        public PRISM.Interactions.Gasha.GashaResultView <>4__this;
        public PRISM.Gasha.GashaResultData gashaResultData;
        public System.Threading.CancellationToken resultCt;
        public string gashaId;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private <>c__DisplayClass75_0 <>8__1;
        private PRISM.Module.Networking.IGashaPriceStatus <gashaPrice>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Gasha
public class GashaBannerCarouselContext : PRISM.DefaultCarouselContext, System.IDisposable
{
    private System.Collections.Generic.List<string> <NewData>k__BackingField;
    private UniRx.Subject<string> <OnChangeCenter>k__BackingField;
    public string CenterGashaId;
    private System.Action<string> <OnSaveNewData>k__BackingField;
    public PRISM.Legacy.WebTextureLoader WebTextureLoader;
    public System.Collections.Generic.List<string> NewData { get; set; }
    public UniRx.Subject<string> OnChangeCenter { get; set; }
    public System.Action<string> OnSaveNewData { get; set; }
    public void Setup(System.Collections.Generic.List<string> data, System.Action<string> onSaveNewData);
    public void Dispose();
}

// Namespace: PRISM.Interactions.Gasha
public class GashaBannerCarousel : PRISM.Carousel<PRISM.Domain.Gasha, PRISM.Interactions.Gasha.GashaBannerCarouselContext>
{
    private UnityEngine.CanvasGroup canvasGroup;
    private UnityEngine.UI.ToggleGroup toggleGroup;
    private float throughTime;
    private float lastPosition;
    private bool isCarouselEvent;
    private System.Collections.Generic.List<PRISM.Domain.Gasha> gashas;
    private UniRx.ReactiveProperty<bool> <IsFixedTagert>k__BackingField;
    private UniRx.Subject<int> <OnMoveEnd>k__BackingField;
    public UniRx.ReactiveProperty<bool> IsFixedTagert { get; set; }
    public UniRx.Subject<int> OnMoveEnd { get; set; }
    public bool IsLoop { get; set; }
    public bool IsTouch { get; set; }
    protected void _playSelectionChangedSE();
    public void SetupContext(System.Collections.Generic.List<string> newdata, System.Action<string> onSaveNewData);
    public void SetupListData(System.Collections.Generic.List<PRISM.Domain.Gasha> gashas, bool isIndicatorSetup);
    protected void UpdatePosition(float position);
    public void Jump(int index);
    public void Update();
    public void StartCarouselEvent();
    public void Dispose();

    private class <>c__DisplayClass23_0
    {
        public string gashaId;
        private bool <Update>b__0(string x);
    }
}

// Namespace: PRISM.Interactions.Gasha
public class GashaBannerCell : PRISM.CarouselCell<PRISM.Domain.Gasha, PRISM.Interactions.Gasha.GashaBannerCarouselContext>
{
    private ENTERPRISE.UI.UITextMeshProUGUI txt;
    private UnityEngine.UI.RawImage img;
    private UnityEngine.GameObject goNew;
    private UnityEngine.GameObject goBadge;
    private UnityEngine.GameObject goDisable;
    private ENTERPRISE.UI.UITextMeshProUGUI txtLimit;
    private System.Threading.CancellationTokenSource cancellationTokenSource;
    public void Initialize();
    public void UpdateContent(PRISM.Domain.Gasha gasha);
    private void _badgeSetting(PRISM.Domain.Gasha gasha);
    public void OnDestroy();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Module.Networking.IGashaPriceStatus, bool> <>9__8_0;
        private bool <UpdateContent>b__8_0(PRISM.Module.Networking.IGashaPriceStatus x);
    }

    private class <>c__DisplayClass8_0
    {
        public PRISM.Interactions.Gasha.GashaBannerCell <>4__this;
        public PRISM.Domain.Gasha gasha;
        private void <UpdateContent>b__1(long x);
        private void <UpdateContent>b__2(bool _);
        private bool <UpdateContent>b__3(string x);
    }

    private class <>c__DisplayClass9_0
    {
        public PRISM.Domain.Gasha gasha;
        private bool <_badgeSetting>b__0(string x);
    }
}

// Namespace: PRISM.Interactions.Gasha
public class GashaStepListView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.Gasha.GashaStepView[] stepViews;
    public void Setup(System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IGashaStepStatus> stepDataList, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Interactions.Gasha
public class GashaStepView : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI txtNumberOfTime;
    private UnityEngine.GameObject goPaidJewel;
    private UnityEngine.GameObject goFreeJewel;
    private UnityEngine.UI.RawImage imgToken;
    private ENTERPRISE.UI.UITextMeshProUGUI txtPrice;
    private UnityEngine.GameObject goSelector;
    private UnityEngine.GameObject goStamp;
    private UnityEngine.UI.RawImage imgCatchphrase;
    public void Setup(PRISM.Module.Networking.IGashaStepStatus stepData, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private void <Setup>b__8_0();
}

// Namespace: PRISM.Interactions.Gasha
public class GashaTopView : UnityEngine.MonoBehaviour, PRISM.Adapters.IGashaTopView
{
    private PRISM.Interactions.Gasha.GashaBannerCarousel gashaBannerCarousel;
    private PRISM.MoviePlayer moviePlayer;
    private PRISM.Interactions.Gasha.SwipeButton backgroundSwipeButton;
    private PRISM.Interactions.CharacterAcquisitionNameView gashaNamePlate;
    private ENTERPRISE.UI.UITextMeshProUGUI txtTokutei;
    private UnityEngine.GameObject goGashaButton;
    private PRISM.Interactions.ButtonView btnTokutei;
    private UnityEngine.UI.Image imgLogo;
    private ENTERPRISE.UI.UITextMeshProUGUI txtLimit;
    private PRISM.Interactions.ButtonView btnDetails;
    private PRISM.Interactions.ButtonView btnGashaRates;
    private PRISM.Interactions.ButtonView btnMembers;
    private PRISM.Interactions.ButtonView btnCostumes;
    private PRISM.Interactions.ButtonView btnOmake;
    private PRISM.Interactions.ButtonView btnHistory;
    private PRISM.Interactions.ButtonView globalMenuButton;
    private ENTERPRISE.UI.UITextMeshProUGUI txtMsg;
    private UnityEngine.UI.Image imgBackground;
    private UnityEngine.UI.AspectRatioFitter aspectRatioFitterBackground;
    private UnityEngine.UI.Image imgBackgroundNext;
    private UnityEngine.UI.AspectRatioFitter aspectRatioFitterBackgroundNext;
    private UnityEngine.UI.Image imgCarouselTouch;
    private UnityEngine.CanvasGroup canvasGroupMiddle;
    private UnityEngine.GameObject goPrismGauge;
    private ENTERPRISE.UI.UITextMeshProUGUI txtPrismGaugePoint;
    private ENTERPRISE.OutGame.RewardItem gaugeItemIcon;
    private PRISM.Interactions.ButtonView btnPrismGauge;
    private UnityEngine.GameObject goPrismGaugeDone;
    private UnityEngine.GameObject goExchangeRoot;
    private PRISM.Interactions.ButtonView btnExchange;
    private ENTERPRISE.UI.UITextMeshProUGUI txtExchange;
    private UnityEngine.GameObject goExchangebadge;
    private PRISM.Interactions.GashaTokenArea[] gashaTokenAreas;
    private PRISM.Interactions.JewelAmountPanelView jewelAmountPanelView;
    private PRISM.Interactions.JewelLimitedSalePanelView jewelLimitedSalePanelView;
    private PRISM.Interactions.Gasha.GashaStepListView gashaStepListView;
    private System.Collections.Generic.List<UnityEngine.GameObject> goBtns;
    private PRISM.Domain.Gasha currentGasha;
    private System.IDisposable backBtnDisposable;
    private System.Threading.CancellationTokenSource changeBackgroundCts;
    private System.Threading.CancellationTokenSource changeBannerCts;
    private System.Threading.CancellationTokenSource changeGashaCts;
    private System.Threading.CancellationTokenSource cts;
    private int lastSelectIndex;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    private bool isBackgroundReserve;
    private System.Collections.Generic.List<string> gashaNewDic;
    private string[] backgroundMovies;
    private System.Collections.Generic.IReadOnlyList<string> backgroundMovieValues;
    private string[] backgroundImages;
    private int playBackgroundIndex;
    private int updateTime;
    private UniRx.Subject<UniRx.Unit> onGotoTitlePopup;
    private System.Action<string, string> <OnClickGasha>k__BackingField;
    private System.Action<string, string> <OnChangeBanner>k__BackingField;
    private System.Func<System.Collections.Generic.List<string>> <OnRefreshNewData>k__BackingField;
    private System.Action<string> <OnSaveNewData>k__BackingField;
    public System.Action<string, string> OnClickGasha { get; set; }
    public System.Action<string, string> OnChangeBanner { get; set; }
    public System.Func<System.Collections.Generic.List<string>> OnRefreshNewData { get; set; }
    public System.Action<string> OnSaveNewData { get; set; }
    public System.IObservable<UniRx.Unit> OnTokuteiClickAsObservable { get; set; }
    public System.IObservable<string> OnDetailsClickAsObservable { get; set; }
    public System.IObservable<string> OnRatesClickAsObservable { get; set; }
    public System.IObservable<string> OnBounusClickAsObservable { get; set; }
    public System.IObservable<string> OnCostumesClickAsObservable { get; set; }
    public System.IObservable<PRISM.Domain.Gasha> OnPrismGaugeClickAsObservable { get; set; }
    public System.IObservable<string> OnExChangeClickAsObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnGashaHistoryClickAsObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnClickGlobalMenuObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnGotoTitlePopup { get; set; }
    public PRISM.Adapters.IJewelAmountPanelView JewelAmountPanelView { get; set; }
    public PRISM.Adapters.IJewelLimitedSalePanelView JewelLimitedSalePanelView { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(System.Collections.Generic.List<PRISM.Domain.Gasha> gashas, System.Collections.Generic.List<PRISM.Domain.GashaPrismGauge> gashaPrismGauges, PRISM.ResourceManagement.IResourceLoader resourceLoader, int selectGashaIndex);
    public Cysharp.Threading.Tasks.UniTask UpdateCurrentGashaTokenAsync();
    public Cysharp.Threading.Tasks.UniTask StopMoviePlayAsync();
    private Cysharp.Threading.Tasks.UniTask _backgroundReserveAsync(System.Threading.CancellationToken ct);
    public void ChangeBannerView(int index);
    private void _costumeBtnSetting(PRISM.Domain.Gasha gasha);
    private void _omakeBtnSetting(PRISM.Domain.Gasha gasha);
    private void _historyBtnSetting();
    private void _setupPrismGauge(PRISM.Domain.Gasha gasha, System.Collections.Generic.List<PRISM.Domain.GashaPrismGauge> gashaPrismGauges);
    private Cysharp.Threading.Tasks.UniTask _setupTokenAreaAsync(PRISM.Domain.Gasha gasha, System.Threading.CancellationToken ct);
    public void SetupExchange(PRISM.Domain.Gasha gasha);
    private Cysharp.Threading.Tasks.UniTask _setupGashaAsync(PRISM.Domain.Gasha gasha, System.Threading.CancellationToken ct);
    private void _changeBackground(PRISM.Domain.Gasha gasha, System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask _playBackgroundAsync(int startIndex, System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask _playMoviesAsync(string movie, string movieValue, System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask _playImageAsync(string image, string nextImage, System.Threading.CancellationToken ct);
    public void Dispose();
    private string <get_OnDetailsClickAsObservable>b__72_0(UniRx.Unit _);
    private string <get_OnRatesClickAsObservable>b__74_0(UniRx.Unit _);
    private string <get_OnBounusClickAsObservable>b__76_0(UniRx.Unit _);
    private string <get_OnCostumesClickAsObservable>b__78_0(UniRx.Unit _);
    private PRISM.Domain.Gasha <get_OnPrismGaugeClickAsObservable>b__80_0(UniRx.Unit _);
    private string <get_OnExChangeClickAsObservable>b__82_0(UniRx.Unit _);
    private bool <_backgroundReserveAsync>b__96_0();
    private void <_playMoviesAsync>b__107_0();

    private class <>c
    {
        public static <>c <>9;
        public static System.Action<UniRx.Unit> <>9__93_5;
        public static System.Func<PRISM.Module.Networking.IGashaPrismGaugeRewardStatus, int> <>9__101_1;
        public static System.Func<PRISM.Module.Networking.IGashaPrismGaugeRewardStatus, int> <>9__101_3;
        public static System.Func<PRISM.Module.Networking.IGashaPriceStatus, PRISM.Module.Networking.IProductWithAmountStatus> <>9__102_0;
        public static System.Func<PRISM.Module.Networking.IProductWithAmountStatus, bool> <>9__102_1;
        public static System.Func<PRISM.Module.Networking.IProductWithAmountStatus, PRISM.Interactions.GashaTokenArea, <>f__AnonymousType0<PRISM.Module.Networking.IProductWithAmountStatus, PRISM.Interactions.GashaTokenArea>> <>9__102_2;
        public static System.Func<PRISM.Module.Networking.IGashaPriceStatus, int> <>9__104_0;
        public static System.Func<string, string> <>9__105_0;
        public static System.Func<string, string> <>9__105_1;
        private void <InitializeAsync>b__93_5(UniRx.Unit _);
        private int <_setupPrismGauge>b__101_1(PRISM.Module.Networking.IGashaPrismGaugeRewardStatus x);
        private int <_setupPrismGauge>b__101_3(PRISM.Module.Networking.IGashaPrismGaugeRewardStatus x);
        private PRISM.Module.Networking.IProductWithAmountStatus <_setupTokenAreaAsync>b__102_0(PRISM.Module.Networking.IGashaPriceStatus x);
        private bool <_setupTokenAreaAsync>b__102_1(PRISM.Module.Networking.IProductWithAmountStatus y);
        private <>f__AnonymousType0<PRISM.Module.Networking.IProductWithAmountStatus, PRISM.Interactions.GashaTokenArea> <_setupTokenAreaAsync>b__102_2(PRISM.Module.Networking.IProductWithAmountStatus price, PRISM.Interactions.GashaTokenArea tokenArea);
        private int <_setupGashaAsync>b__104_0(PRISM.Module.Networking.IGashaPriceStatus x);
        private string <_changeBackground>b__105_0(string x);
        private string <_changeBackground>b__105_1(string x);
    }

    private class <>c__DisplayClass101_0
    {
        public PRISM.Domain.Gasha gasha;
        public PRISM.Domain.GashaPrismGauge data;
        private bool <_setupPrismGauge>b__0(PRISM.Domain.GashaPrismGauge x);
        private bool <_setupPrismGauge>b__2(PRISM.Module.Networking.IGashaPrismGaugeRewardStatus x);
    }

    private class <>c__DisplayClass93_0
    {
        public PRISM.Interactions.Gasha.GashaTopView <>4__this;
        public System.Collections.Generic.List<PRISM.Domain.Gasha> gashas;
        public System.Collections.Generic.List<PRISM.Domain.GashaPrismGauge> gashaPrismGauges;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private void <InitializeAsync>b__0(bool b);
        private void <InitializeAsync>b__1(int index);
        private void <InitializeAsync>b__2(int x);
        private void <InitializeAsync>b__3(UniRx.Unit _);
        private void <InitializeAsync>b__4(bool right);
    }

    private struct <InitializeAsync>d__93 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Gasha.GashaTopView <>4__this;
        public System.Collections.Generic.List<PRISM.Domain.Gasha> gashas;
        public System.Collections.Generic.List<PRISM.Domain.GashaPrismGauge> gashaPrismGauges;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private <>c__DisplayClass93_0 <>8__1;
        public int selectGashaIndex;
        private AsyncOperationAwaiter <>u__1;
        private Awaiter <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <StopMoviePlayAsync>d__95 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Gasha.GashaTopView <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_backgroundReserveAsync>d__96 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Gasha.GashaTopView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_playBackgroundAsync>d__106 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Gasha.GashaTopView <>4__this;
        public int startIndex;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_playImageAsync>d__108 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Gasha.GashaTopView <>4__this;
        public string image;
        public System.Threading.CancellationToken ct;
        public string nextImage;
        private UnityEngine.UI.Image <>7__wrap1;
        private Awaiter<UnityEngine.Sprite> <>u__1;
        private Awaiter <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_playMoviesAsync>d__107 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Gasha.GashaTopView <>4__this;
        public string movie;
        public System.Threading.CancellationToken ct;
        public string movieValue;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_setupGashaAsync>d__104 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Gasha.GashaTopView <>4__this;
        public PRISM.Domain.Gasha gasha;
        public System.Threading.CancellationToken ct;
        private UnityEngine.Transform <parent>5__2;
        private System.Collections.Generic.IEnumerator<PRISM.Module.Networking.IGashaPriceStatus> <>7__wrap2;
        private UnityEngine.GameObject <go>5__4;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_setupTokenAreaAsync>d__102 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Domain.Gasha gasha;
        public PRISM.Interactions.Gasha.GashaTopView <>4__this;
        public System.Threading.CancellationToken ct;
        private System.Collections.Generic.IEnumerator<<>f__AnonymousType0<PRISM.Module.Networking.IProductWithAmountStatus, PRISM.Interactions.GashaTokenArea>> <>7__wrap1;
        private <>f__AnonymousType0<PRISM.Module.Networking.IProductWithAmountStatus, PRISM.Interactions.GashaTokenArea> <item>5__3;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Gasha
public class SwipeButton : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IPointerUpHandler, System.IDisposable
{
    private bool isSwipeConsecutive;
    public SwipeDistanceValueType swipeDistanceValueType;
    private float minSwipeDistance;
    private float minSwipeDistanceScreenPercentage;
    private UnityEngine.Vector2 startTouchPosition;
    private UnityEngine.Vector2 dragTouchPosition;
    private UnityEngine.Vector2 endTouchPosition;
    private int dragLastStatusHorizontal;
    private int dragLastStatusVertical;
    private bool isSwiped;
    private UniRx.CompositeDisposable tapDisposables;
    private UniRx.Subject<UniRx.Unit> onTapSubject;
    private UniRx.Subject<int> onDragSwipeHorizontalSubject;
    private UniRx.Subject<int> onDragSwipeVerticalSubject;
    private UniRx.Subject<bool> onEndSwipeHorizontalSubject;
    private UniRx.Subject<bool> onEndSwipeVerticalSubject;
    public System.IObservable<UniRx.Unit> OnTap { get; set; }
    public System.IObservable<int> OnDragSwipeHorizontal { get; set; }
    public System.IObservable<int> OnDragSwipeVertical { get; set; }
    public System.IObservable<bool> OnEndSwipeHorizontal { get; set; }
    public System.IObservable<bool> OnEndSwipeVertical { get; set; }
    private float detectMinSwipeDistanceX { get; set; }
    private float detectMinSwipeDistanceY { get; set; }
    public void Awake();
    public void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
    public void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
    public void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
    private void _detectSwipe();
    private void _detectEndSwipe();
    public void Dispose();

    public enum SwipeDistanceValueType : System.Enum
    {
        public int value__;
        public static SwipeDistanceValueType FixedPixel;
        public static SwipeDistanceValueType ScreenPercentage;
    }
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=5930 5A77AFC7DAE371911FBC098F20D158B2C11558FF4AFB2FD311F087694F6513DE;
    private static __StaticArrayInitTypeSize=3745 D455B5FCF5EB0B8E4C1B024F12D51578C891FBB2B33455F3184E8B974A9F4FE0;

    private struct __StaticArrayInitTypeSize=3745 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=5930 : System.ValueType
    {
    }
}
