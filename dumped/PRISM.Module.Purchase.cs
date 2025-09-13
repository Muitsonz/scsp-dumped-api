
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

// Namespace: ENTERPRISE.Purchase
public interface IPurchase : System.IDisposable
{
    public System.IObservable<ENTERPRISE.Purchase.VerifyReceiptData> OnUnprocessedReceiptData { get; set; }
    public System.Collections.Generic.List<ENTERPRISE.Purchase.VerifyReceiptData> VerifyReceiptDataList { get; set; }
    public InitializeState InitializeState { get; set; }
    public BillingState BillingState { get; set; }
    public Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ENTERPRISE.Purchase.ErrorCode, string>> PrepareAsync(System.Collections.Generic.IReadOnlyList<string> productList, System.Threading.CancellationToken ct);
    public bool IsAvailable(string storeProductId);
    public UnityEngine.Purchasing.Product GetProduct(string storeProductId);
    public Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ENTERPRISE.Purchase.VerifyReceiptData, ENTERPRISE.Purchase.ErrorCode>> PurchaseAsync(string productId);
    public void PurchaseEnd(ENTERPRISE.Purchase.VerifyReceiptData verifyReceiptData);
    public bool IsPurchasedDeferred(string storeProductId);
    public void SetOrderId(string orderId);
}

// Namespace: ENTERPRISE.Purchase
public class PurchaseConstants
{

    public enum InitializeState : System.Enum
    {
        public int value__;
        public static InitializeState None;
        public static InitializeState Successed;
        public static InitializeState Failed;
    }

    public enum BillingState : System.Enum
    {
        public int value__;
        public static BillingState None;
        public static BillingState RefreshReceipt;
        public static BillingState Purchasing;
        public static BillingState RequestVerifyReceipt;
        public static BillingState Error;
        public static BillingState Deferred;
    }
}

// Namespace: ENTERPRISE.Purchase
public enum ErrorCode : System.Enum
{
    public int value__;
    public static ENTERPRISE.Purchase.ErrorCode None;
    public static ENTERPRISE.Purchase.ErrorCode PurchasingUnavailable;
    public static ENTERPRISE.Purchase.ErrorCode NoProductsAvailable;
    public static ENTERPRISE.Purchase.ErrorCode AppNotKnown;
    public static ENTERPRISE.Purchase.ErrorCode InitializeConnectionOff;
    public static ENTERPRISE.Purchase.ErrorCode InitializeTimeout;
    public static ENTERPRISE.Purchase.ErrorCode InitializeUnknown;
    public static ENTERPRISE.Purchase.ErrorCode PurchasingUnavailable2;
    public static ENTERPRISE.Purchase.ErrorCode ExistingPurchasePending;
    public static ENTERPRISE.Purchase.ErrorCode ProductUnavailable;
    public static ENTERPRISE.Purchase.ErrorCode SignatureInvalid;
    public static ENTERPRISE.Purchase.ErrorCode UserCancelled;
    public static ENTERPRISE.Purchase.ErrorCode PaymentDeclined;
    public static ENTERPRISE.Purchase.ErrorCode DuplicateTransaction;
    public static ENTERPRISE.Purchase.ErrorCode PurchaseUnknown;
    public static ENTERPRISE.Purchase.ErrorCode FailedRefreshReceipt;
    public static ENTERPRISE.Purchase.ErrorCode UnavailablePurchase;
    public static ENTERPRISE.Purchase.ErrorCode NotRegisterBirthday;
    public static ENTERPRISE.Purchase.ErrorCode ReserveStoreItemFailed;
    public static ENTERPRISE.Purchase.ErrorCode ConnectionFailed;
    public static ENTERPRISE.Purchase.ErrorCode PurchaseInitializeFaild;
    public static ENTERPRISE.Purchase.ErrorCode PurchaseUnknownOther;
    public static ENTERPRISE.Purchase.ErrorCode VerifyReceiptOffset;
    public static ENTERPRISE.Purchase.ErrorCode VerifyReceiptDuplicated;
    public static ENTERPRISE.Purchase.ErrorCode VerifyReceiptSkip;
    public static ENTERPRISE.Purchase.ErrorCode VerifyReceiptUnknown;
    public static ENTERPRISE.Purchase.ErrorCode Timeout;
    public static ENTERPRISE.Purchase.ErrorCode TitleJump;
    public static ENTERPRISE.Purchase.ErrorCode RefreshReceiptErrorOffset;
}

// Namespace: ENTERPRISE.Purchase
public class PurchaseInstanceCreator
{
    public ENTERPRISE.Purchase.IPurchase CreateInstanse(string dmmGamesApiToken);
}

// Namespace: ENTERPRISE.Purchase
public class PurchaseUnityEditor : ENTERPRISE.Purchase.IPurchase, System.IDisposable
{
    private UniRx.Subject<ENTERPRISE.Purchase.VerifyReceiptData> verifyReceiptSubject;
    private InitializeState <InitializeState>k__BackingField;
    private BillingState <BillingState>k__BackingField;
    public System.IObservable<ENTERPRISE.Purchase.VerifyReceiptData> OnUnprocessedReceiptData { get; set; }
    public System.Collections.Generic.List<ENTERPRISE.Purchase.VerifyReceiptData> VerifyReceiptDataList { get; set; }
    public InitializeState InitializeState { get; set; }
    public BillingState BillingState { get; set; }
    public Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ENTERPRISE.Purchase.ErrorCode, string>> PrepareAsync(System.Collections.Generic.IReadOnlyList<string> productList, System.Threading.CancellationToken ct);
    public bool IsAvailable(string storeProductId);
    public UnityEngine.Purchasing.Product GetProduct(string storeProductId);
    public Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ENTERPRISE.Purchase.VerifyReceiptData, ENTERPRISE.Purchase.ErrorCode>> PurchaseAsync(string productId);
    public void PurchaseEnd(ENTERPRISE.Purchase.VerifyReceiptData verifyReceiptData);
    public bool IsPurchasedDeferred(string storeProductId);
    public void SetOrderId(string orderId);
    public void Dispose();
}

// Namespace: ENTERPRISE.Purchase
public class DmmGamesInitializeArgsModel
{
    private static string defaultPrefix;
    private static string keyViewerId;
    private static string keyOnetimeToken;
    private static string keyOpenId;
    private static string keyAccessToken;
    private string <ViewerId>k__BackingField;
    private string <AccessToken>k__BackingField;
    private string <OpenId>k__BackingField;
    private string <OnetimeToken>k__BackingField;
    public string ViewerId { get; set; }
    public string AccessToken { get; set; }
    public string OpenId { get; set; }
    public string OnetimeToken { get; set; }
    public static ENTERPRISE.Purchase.DmmGamesInitializeArgsModel Load();
    public static ENTERPRISE.Purchase.DmmGamesInitializeArgsModel Load(string prefix);
    private static ENTERPRISE.Purchase.DmmGamesInitializeArgsModel _parse(string[] args, string prefix);
}

// Namespace: ENTERPRISE.Purchase
public class PurchaseUnityAndroid : ENTERPRISE.Purchase.PurchaseUnityIAPBase
{
    private UnityEngine.Purchasing.IGooglePlayStoreExtensions googlePlayStoreExtensions;
    private UnityEngine.Purchasing.IGooglePlayConfiguration googlePlayConfiguration;
    public void OnInitialized(UnityEngine.Purchasing.IStoreController controller, UnityEngine.Purchasing.IExtensionProvider extensions);
    public void SetOrderId(string orderId);
    protected ENTERPRISE.Purchase.VerifyReceiptData _getVerifyReceiptData(UnityEngine.Purchasing.Product product);
    private void OnDeferredPurchaseListener(UnityEngine.Purchasing.Product product);
    protected void _setConfiguration(UnityEngine.Purchasing.ConfigurationBuilder cb);
    protected bool _isPurchasedDeferred(UnityEngine.Purchasing.Product product);

    private class Payload
    {
        public string json;
        public string signature;

        public class Json
        {
            public int purchaseState;
        }
    }

    private class <>c__DisplayClass8_0
    {
        public UnityEngine.Purchasing.Product product;
        private bool <_isPurchasedDeferred>b__0(ENTERPRISE.Purchase.VerifyReceiptData data);
    }
}

// Namespace: ENTERPRISE.Purchase
public class PurchaseUnityDmmGames : ENTERPRISE.Purchase.PurchaseUnityIAPBase
{
    private Dmm.Games.Unity.Purchasing.DmmGamesIapStoreExtension dmmGamesIapStoreExtension;
    private bool isSandbox;
    private string apiToken;
    public string ViewerId { get; set; }
    public string ViewerIdSignature { get; set; }
    public void OnInitialized(UnityEngine.Purchasing.IStoreController controller, UnityEngine.Purchasing.IExtensionProvider extensions);
    public System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Product> GetEnableProductList();
    public void SetProductIcon(string productId, UnityEngine.Texture2D iconTexture);
    public Cysharp.Threading.Tasks.UniTask<ENTERPRISE.Purchase.ErrorCode> PrepareBeforeLoginAsync(System.Threading.CancellationToken cancellationToken);
    public System.ValueTuple<long, string> GetViewerIdsBeforeLogin();
    protected UnityEngine.Purchasing.ConfigurationBuilder _getConfigurationBuilder();
    protected ENTERPRISE.Purchase.VerifyReceiptData _getVerifyReceiptData(UnityEngine.Purchasing.Product product);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<UnityEngine.Purchasing.Product, bool> <>9__9_0;
        private bool <GetEnableProductList>b__9_0(UnityEngine.Purchasing.Product x);
    }

    private struct <PrepareBeforeLoginAsync>d__11 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<ENTERPRISE.Purchase.ErrorCode> <>t__builder;
        public ENTERPRISE.Purchase.PurchaseUnityDmmGames <>4__this;
        public System.Threading.CancellationToken cancellationToken;
        private Awaiter<System.ValueTuple<ENTERPRISE.Purchase.ErrorCode, string>> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: ENTERPRISE.Purchase
public class PurchaseUnityIAPBase : ENTERPRISE.Purchase.IPurchase, System.IDisposable, UnityEngine.Purchasing.IDetailedStoreListener, UnityEngine.Purchasing.IStoreListener
{
    protected static string receiptIdHashKey;
    protected UnityEngine.Purchasing.IStoreController storeController;
    protected UnityEngine.Purchasing.IExtensionProvider extensionProvider;
    protected System.Collections.Generic.List<ENTERPRISE.Purchase.VerifyReceiptData> verifyReceiptDataList;
    protected RefreshReceiptState refreshReceiptState;
    private ENTERPRISE.Purchase.ErrorCode prepareErrorCode;
    private ENTERPRISE.Purchase.ErrorCode purchaseErrorCode;
    private string purchaseErrorMessage;
    private UniRx.Subject<ENTERPRISE.Purchase.VerifyReceiptData> verifyReceiptDataSubject;
    private System.Action <NotifyPrepareSuccess>k__BackingField;
    private System.Action<int> <NotifyPrepareError>k__BackingField;
    private InitializeState <InitializeState>k__BackingField;
    private BillingState <BillingState>k__BackingField;
    public System.Action NotifyPrepareSuccess { get; set; }
    public System.Action<int> NotifyPrepareError { get; set; }
    public System.Collections.Generic.List<ENTERPRISE.Purchase.VerifyReceiptData> VerifyReceiptDataList { get; set; }
    public InitializeState InitializeState { get; set; }
    public BillingState BillingState { get; set; }
    public System.IObservable<ENTERPRISE.Purchase.VerifyReceiptData> OnUnprocessedReceiptData { get; set; }
    public Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ENTERPRISE.Purchase.ErrorCode, string>> PrepareAsync(System.Collections.Generic.IReadOnlyList<string> productList, System.Threading.CancellationToken ct);
    public bool IsAvailable(string storeProductId);
    public UnityEngine.Purchasing.Product GetProduct(string storeProductId);
    public Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ENTERPRISE.Purchase.VerifyReceiptData, ENTERPRISE.Purchase.ErrorCode>> PurchaseAsync(string _productId);
    public void PurchaseEnd(ENTERPRISE.Purchase.VerifyReceiptData verifyReceiptData);
    public void OnInitialized(UnityEngine.Purchasing.IStoreController controller, UnityEngine.Purchasing.IExtensionProvider extensions);
    public void OnInitializeFailed(UnityEngine.Purchasing.InitializationFailureReason error);
    public void OnInitializeFailed(UnityEngine.Purchasing.InitializationFailureReason error, string message);
    public void OnPurchaseFailed(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.PurchaseFailureReason failureReason);
    public void OnPurchaseFailed(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.Extension.PurchaseFailureDescription failureDescription);
    public UnityEngine.Purchasing.PurchaseProcessingResult ProcessPurchase(UnityEngine.Purchasing.PurchaseEventArgs purchaseEvent);
    public bool IsPurchasedDeferred(string storeProductId);
    public void SetOrderId(string orderId);
    protected Cysharp.Threading.Tasks.UniTask _initialize(System.Collections.Generic.IEnumerable<string> productIds, System.Threading.CancellationToken ct);
    protected UnityEngine.Purchasing.ConfigurationBuilder _getConfigurationBuilder();
    protected void _refreshAppReceipt();
    public void Dispose();
    protected ENTERPRISE.Purchase.VerifyReceiptData _getVerifyReceiptData(UnityEngine.Purchasing.Product product);
    protected ENTERPRISE.Purchase.ErrorCode _canPurchase(string productId);
    protected void _setConfiguration(UnityEngine.Purchasing.ConfigurationBuilder cb);
    protected bool _isPurchasedDeferred(UnityEngine.Purchasing.Product product);
    private bool <_initialize>b__43_0();

    protected enum RefreshReceiptState : System.Enum
    {
        public int value__;
        public static RefreshReceiptState None;
        public static RefreshReceiptState Success;
        public static RefreshReceiptState Failed;
    }

    private class <>c__DisplayClass33_0
    {
        public ENTERPRISE.Purchase.PurchaseUnityIAPBase <>4__this;
        public string _productId;
        private bool <PurchaseAsync>b__0();
        private bool <PurchaseAsync>b__1();
        private bool <PurchaseAsync>b__2(ENTERPRISE.Purchase.VerifyReceiptData x);
    }

    private class <>c__DisplayClass41_0
    {
        public string storeProductId;
        private bool <IsPurchasedDeferred>b__0(UnityEngine.Purchasing.Product product);
    }

    private struct <PrepareAsync>d__30 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<System.ValueTuple<ENTERPRISE.Purchase.ErrorCode, string>> <>t__builder;
        public ENTERPRISE.Purchase.PurchaseUnityIAPBase <>4__this;
        public System.Collections.Generic.IReadOnlyList<string> productList;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <PurchaseAsync>d__33 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<System.ValueTuple<ENTERPRISE.Purchase.VerifyReceiptData, ENTERPRISE.Purchase.ErrorCode>> <>t__builder;
        public ENTERPRISE.Purchase.PurchaseUnityIAPBase <>4__this;
        public string _productId;
        private <>c__DisplayClass33_0 <>8__1;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_initialize>d__43 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public ENTERPRISE.Purchase.PurchaseUnityIAPBase <>4__this;
        public System.Collections.Generic.IEnumerable<string> productIds;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: ENTERPRISE.Purchase
public class PurchaseUnityIOS : ENTERPRISE.Purchase.PurchaseUnityIAPBase
{
    private UnityEngine.Purchasing.IAppleExtensions appleExtensions;
    public void OnInitialized(UnityEngine.Purchasing.IStoreController controller, UnityEngine.Purchasing.IExtensionProvider extensions);
    public void SetOrderId(string orderId);
    protected ENTERPRISE.Purchase.VerifyReceiptData _getVerifyReceiptData(UnityEngine.Purchasing.Product product);
    protected void _refreshAppReceipt();
    private void <_refreshAppReceipt>b__4_0(string receipt);
    private void <_refreshAppReceipt>b__4_1(string errorMsg);

    private class <>c
    {
        public static <>c <>9;
        public static System.Action<UnityEngine.Purchasing.Product> <>9__1_0;
        private void <OnInitialized>b__1_0(UnityEngine.Purchasing.Product product);
    }
}

// Namespace: ENTERPRISE.Purchase
public class NullPurchase : ENTERPRISE.Purchase.IPurchase, System.IDisposable
{
    private System.IObservable<ENTERPRISE.Purchase.VerifyReceiptData> <OnUnprocessedReceiptData>k__BackingField;
    private InitializeState <InitializeState>k__BackingField;
    private BillingState <BillingState>k__BackingField;
    public System.IObservable<ENTERPRISE.Purchase.VerifyReceiptData> OnUnprocessedReceiptData { get; set; }
    public System.Collections.Generic.List<ENTERPRISE.Purchase.VerifyReceiptData> VerifyReceiptDataList { get; set; }
    public InitializeState InitializeState { get; set; }
    public BillingState BillingState { get; set; }
    public bool IsAvailable(string storeProductId);
    public UnityEngine.Purchasing.Product GetProduct(string storeProductId);
    public Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ENTERPRISE.Purchase.ErrorCode, string>> PrepareAsync(System.Collections.Generic.IReadOnlyList<string> productList, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ENTERPRISE.Purchase.VerifyReceiptData, ENTERPRISE.Purchase.ErrorCode>> PurchaseAsync(string productId);
    public void PurchaseEnd(ENTERPRISE.Purchase.VerifyReceiptData verifyReceiptData);
    public bool IsPurchasedDeferred(string storeProductId);
    public void SetOrderId(string orderId);
    public void Dispose();
}

// Namespace: ENTERPRISE.Purchase
public class VerifyReceiptData
{
    public string orderId;
    public string receiptData;
    public string transactionId;
    public string dataSignature;
    public int purchaseState;
    public string currency;
    public float unitPrice;
    public string productId;
    public UnityEngine.Purchasing.Product product;
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=587 C9EDC530C925E56EBB32302737A945154AE7350228C62B569BE1548DEB2E93A7;
    private static __StaticArrayInitTypeSize=728 FBB8180605E3562DCC915AACFF30D8F33B4FB1D25FE8BB95562BBEA747BBAF83;

    private struct __StaticArrayInitTypeSize=587 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=728 : System.ValueType
    {
    }
}
