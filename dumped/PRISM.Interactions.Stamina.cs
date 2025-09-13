
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

// Namespace: PRISM.Stamina
public class StaminaRecoveryGaugeView : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.Image staminaGaugeImage;
    private UnityEngine.UI.Image staminaGaugeAfterImage;
    private UnityEngine.UI.Image staminaFullGaugeImage;
    private UnityEngine.UI.Image increaseColorImage;
    private UnityEngine.UI.Image decreaseColorImage;
    public void Setup(int currentValue, int afterValue, int maxValue, bool isMax);
}

// Namespace: PRISM.Interactions.Stamina
public class StaminaRecoveryCompletePopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IStaminaRecoveryCompletePopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.Stamina.StaminaRecoveryTypeItemPanelView typeItemPanelView;
    private ENTERPRISE.UI.UITextMeshProUGUI infoMessageText;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Adapters.StaminaRecoveryCompleteViewModel viewModel;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Inject(PRISM.Adapters.StaminaRecoveryCompleteViewModel viewModel);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    private void <CreateFrameParameter>b__7_0();
    private void <CreateFrameParameter>b__7_1();
}

// Namespace: PRISM.Interactions.Stamina
public class StaminaRecoverySelectItemConfirmListView : PRISM.Interactions.ListView<PRISM.Interactions.Stamina.StaminaRecoverySelectItemConfirmListViewCell, PRISM.Adapters.StaminaRecoveryUseItemViewModel>
{
}

// Namespace: PRISM.Interactions.Stamina
public class StaminaRecoverySelectItemConfirmListViewCell : PRISM.Interactions.ListViewCell<PRISM.Adapters.StaminaRecoveryUseItemViewModel>
{
    private PRISM.Interactions.RewardItemIcon itemIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI itemNameText;
    private ENTERPRISE.UI.UITextMeshProUGUI recoveryTypeText;
    private ENTERPRISE.UI.UITextMeshProUGUI recoveryAmountText;
    private UnityEngine.GameObject expireDateObject;
    private ENTERPRISE.UI.UITextMeshProUGUI expireDateText;
    private ENTERPRISE.UI.UITextMeshProUGUI itemAmountText;
    private ENTERPRISE.UI.UITextMeshProUGUI itemAmountAfterText;
    private ENTERPRISE.UI.UITextMeshProUGUI useAmountText;
    private UnityEngine.GameObject expireRemineTimeObject;
    private ENTERPRISE.UI.UITextMeshProUGUI expireRemineTimeText;
    private ENTERPRISE.UI.UITextMeshProUGUI[] replaceMeshTexts;
    public void UpdateContent(PRISM.Adapters.StaminaRecoveryUseItemViewModel viewModel);
}

// Namespace: PRISM.Interactions.Stamina
public class StaminaRecoverySelectItemConfirmPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IStaminaRecoverySelectItemConfirmPopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private PRISM.Interactions.Stamina.StaminaRecoverySelectItemConfirmListView listView;
    private PRISM.Interactions.Stamina.StaminaRecoveryTypeItemPanelView typeItemPanelView;
    private ENTERPRISE.UI.UITextMeshProUGUI infoMessageText;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClosed;
    private PRISM.Adapters.StaminaRecoveryPopupViewModel viewModel;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Inject(PRISM.Adapters.StaminaRecoveryPopupViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    private void <CreateFrameParameter>b__8_0();
    private void <CreateFrameParameter>b__8_1();
    private void <CreateFrameParameter>b__8_2();

    private struct <LoadAsync>d__9 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
        public PRISM.Interactions.Stamina.StaminaRecoverySelectItemConfirmPopupView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter<bool> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Stamina
public class StaminaRecoverySelectItemLiveView : PRISM.Interactions.ListView<PRISM.Interactions.Stamina.StaminaRecoverySelectItemListViewCell, PRISM.Adapters.StaminaRecoveryUseItemViewModel, PRISM.Interactions.ListViewContextWithClick<System.ValueTuple<int, int>>>
{
    public System.IObservable<System.ValueTuple<int, int>> OnClickedUseAmount { get; set; }
}

// Namespace: PRISM.Interactions.Stamina
public class StaminaRecoverySelectItemListViewCell : PRISM.Interactions.ListViewCell<PRISM.Adapters.StaminaRecoveryUseItemViewModel, PRISM.Interactions.ListViewContextWithClick<System.ValueTuple<int, int>>>
{
    private PRISM.Interactions.RewardItemIcon itemIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI itemNameText;
    private ENTERPRISE.UI.UITextMeshProUGUI recoveryTypeText;
    private ENTERPRISE.UI.UITextMeshProUGUI recoveryAmountText;
    private UnityEngine.GameObject expireDateObject;
    private ENTERPRISE.UI.UITextMeshProUGUI expireDateText;
    private ENTERPRISE.UI.UITextMeshProUGUI itemAmountText;
    private ENTERPRISE.UI.UITextMeshProUGUI itemAmountAfterText;
    private ENTERPRISE.UI.UITextMeshProUGUI useAmountText;
    private UnityEngine.GameObject expireRemineTimeObject;
    private ENTERPRISE.UI.UITextMeshProUGUI expireRemineTimeText;
    private ENTERPRISE.UI.UITextMeshProUGUI[] replaceMeshTexts;
    private PRISM.Interactions.ButtonView useMinusButton;
    private PRISM.Interactions.ButtonView usePlusButton;
    private PRISM.Interactions.ButtonView useMinusJumpButton;
    private PRISM.Interactions.ButtonView usePlusJumpButton;
    private ENTERPRISE.UI.UITextMeshProUGUI minusJumpText;
    private ENTERPRISE.UI.UITextMeshProUGUI plusJumpText;
    private System.IDisposable useAmountDisposable;
    private System.IDisposable expireDisposable;
    private System.IDisposable timeRecoveryMaxDisposable;
    private System.IDisposable plusButtonEnableDisposable;
    public void Initialize();
    public void UpdateContent(PRISM.Adapters.StaminaRecoveryUseItemViewModel viewModel);
    private void _setupUseAmountButton(PRISM.Interactions.ButtonView buttonView, int amount);

    private class <>c__DisplayClass23_0
    {
        public PRISM.Adapters.StaminaRecoveryUseItemViewModel viewModel;
        public PRISM.Interactions.Stamina.StaminaRecoverySelectItemListViewCell <>4__this;
        private void <UpdateContent>b__0(long amount);
        private void <UpdateContent>b__1(int _);
        private void <UpdateContent>b__2(int _);
        private void <UpdateContent>b__3(long _);
        private void <UpdateContent>g___checkPlusButtonEnable|4();
    }

    private class <>c__DisplayClass24_0
    {
        public PRISM.Interactions.Stamina.StaminaRecoverySelectItemListViewCell <>4__this;
        public int amount;
        private void <_setupUseAmountButton>b__0(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.Stamina
public class StaminaRecoverySelectItemPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IStaminaRecoverySelectItemPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.Stamina.StaminaRecoverySelectItemLiveView listView;
    private ENTERPRISE.UI.UITextMeshProUGUI noItemText;
    private PRISM.Interactions.ButtonView resetButton;
    private PRISM.Interactions.ButtonView entrustButton;
    private PRISM.Interactions.Stamina.StaminaRecoveryTypeItemPanelView typeItemPanelView;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Adapters.StaminaRecoveryPopupViewModel viewModel;
    private System.Func<Cysharp.Threading.Tasks.UniTask> onDecideFunc;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public System.IObservable<UniRx.Unit> OnResetObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnEntrustObservable { get; set; }
    public System.IObservable<System.ValueTuple<int, int>> OnCellUseAmountObservable { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Inject(PRISM.Adapters.StaminaRecoveryPopupViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Func<Cysharp.Threading.Tasks.UniTask> onDecideFunc);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    public void UpdateListView();
    private void _updateView();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    private void <CreateFrameParameter>b__17_0();
    private void <CreateFrameParameter>b__17_1();
    private bool <CreateFrameParameter>b__17_2();
    private void <CreateFrameParameter>b__17_3();
    private void <_updateView>b__21_0(long _);
    private void <_updateView>b__21_1(int _);

    private struct <LoadAsync>d__18 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
        public PRISM.Interactions.Stamina.StaminaRecoverySelectItemPopupView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter<bool> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Stamina
public class StaminaRecoverySelectJewelConfirmPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IStaminaRecoverySelectJewelConfirmPopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private PRISM.Interactions.Stamina.StaminaRecoveryTypeItemPanelView typeItemPanelView;
    private ENTERPRISE.UI.UITextMeshProUGUI infoMessageText;
    private PRISM.Interactions.ButtonView specifiedCommercialButton;
    private ENTERPRISE.UI.UITextMeshProUGUI costJewelAmountText;
    private ENTERPRISE.UI.UITextMeshProUGUI haveJewelAmountText;
    private ENTERPRISE.UI.UITextMeshProUGUI haveJewelAfterAmountText;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClosed;
    private PRISM.Adapters.StaminaRecoveryPopupViewModel viewModel;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public System.IObservable<UniRx.Unit> OnSpecifiedCommercialObservable { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Inject(PRISM.Adapters.StaminaRecoveryPopupViewModel viewModel);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void _setupView();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    private void <CreateFrameParameter>b__13_0();
    private void <CreateFrameParameter>b__13_1();
    private void <CreateFrameParameter>b__13_2();
}

// Namespace: PRISM.Interactions.Stamina
public class StaminaRecoverySelectJewelPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IStaminaRecoverySelectJewelPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.Stamina.StaminaRecoveryTypeItemPanelView typeItemPanelView;
    private ENTERPRISE.UI.UITextMeshProUGUI infoMessageText;
    private PRISM.Interactions.ButtonView specifiedCommercialButton;
    private ENTERPRISE.UI.UITextMeshProUGUI costJewelAmountText;
    private ENTERPRISE.UI.UITextMeshProUGUI haveJewelAmountText;
    private ENTERPRISE.UI.UITextMeshProUGUI haveJewelAfterAmountText;
    private PRISM.Interactions.ButtonView useMinusButton;
    private PRISM.Interactions.ButtonView useMinusJumpButton;
    private ENTERPRISE.UI.UITextMeshProUGUI useMinusJumpText;
    private PRISM.Interactions.ButtonView usePlusButton;
    private PRISM.Interactions.ButtonView usePlusJumpButton;
    private ENTERPRISE.UI.UITextMeshProUGUI usePlusJumpText;
    private ENTERPRISE.UI.UITextMeshProUGUI useAmountText;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private System.Func<Cysharp.Threading.Tasks.UniTask> onDecideFunc;
    private PRISM.Adapters.StaminaRecoveryPopupViewModel viewModel;
    private FooterInfoParameter footerParameter;
    private System.IDisposable everyValueChangedDisposable;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public System.IObservable<UniRx.Unit> OnUseMinObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnUseMinusObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnUsePlusObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnUseMinusJumpObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnUsePlusJumpObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnUseMaxObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnSpecifiedCommercialObservable { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Inject(PRISM.Adapters.StaminaRecoveryPopupViewModel viewModel, System.Func<Cysharp.Threading.Tasks.UniTask> onDecideFunc);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public void ApplyFooterParameter();
    public void UpdateView();
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void _initializeButtonParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    private void <CreateFrameParameter>b__35_0();
    private void <UpdateView>b__38_0(int amount);
    private void <_initializeButtonParameter>b__40_0();
    private void <_initializeButtonParameter>b__40_1();
    private bool <_initializeButtonParameter>b__40_2();
    private void <_initializeButtonParameter>b__40_3();
    private bool <_initializeButtonParameter>b__40_4();
}

// Namespace: PRISM.Interactions.Stamina
public class StaminaRecoveryTypeSelectPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IStaminaRecoveryTypeSelectPopupView, PRISM.Adapters.IClosablePopupFrame<System.Nullable<PRISM.Adapters.StaminaRecoveryType>>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<System.Nullable<PRISM.Adapters.StaminaRecoveryType>>
{
    private ENTERPRISE.UI.UITextMeshProUGUI recoveryTimeText;
    private PRISM.Interactions.ButtonView jewelButton;
    private PRISM.Interactions.ButtonView itemButton;
    private PRISM.Interactions.ViewStateChanger staminaTypeStateChanger;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<System.Nullable<PRISM.Adapters.StaminaRecoveryType>> onClosed;
    private PRISM.Adapters.StaminaRecoveryPopupViewModel viewModel;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<System.Nullable<PRISM.Adapters.StaminaRecoveryType>> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Inject(PRISM.Adapters.StaminaRecoveryPopupViewModel viewModel);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__9_0();
    private void <CreateFrameParameter>b__9_1();
    private void <LoadAsync>b__10_0(long _);
    private void <LoadAsync>b__10_1(UniRx.Unit _);
    private void <LoadAsync>b__10_2(UniRx.Unit _);
}

// Namespace: PRISM.Interactions.Stamina
public class StaminaRecoveryTypeItemPanelView : UnityEngine.MonoBehaviour, System.IDisposable
{
    private UnityEngine.UI.Image staminaLogImage;
    private ENTERPRISE.UI.UITextMeshProUGUI recoveryTimeText;
    private ENTERPRISE.UI.UITextMeshProUGUI staminaText;
    private ENTERPRISE.UI.UITextMeshProUGUI staminaAfterText;
    private UnityEngine.GameObject arrowObject;
    private PRISM.Stamina.StaminaRecoveryGaugeView staminaGaugeView;
    private PRISM.Stamina.StaminaRecoveryGaugeView liveBoostGaugeView;
    private PRISM.Interactions.ButtonView useMinButton;
    private PRISM.Interactions.ButtonView useMinusButton;
    private PRISM.Interactions.ButtonView usePlusButton;
    private PRISM.Interactions.ButtonView useMaxButton;
    private ENTERPRISE.UI.UITextMeshProUGUI staminaInfoText;
    private UnityEngine.Sprite[] staminaLogoSprites;
    private System.IDisposable timerDisposable;
    private UniRx.CompositeDisposable staminaValueDisposable;
    public System.IObservable<UniRx.Unit> OnUseMinObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnUseMinusObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnUsePlusObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnUseMaxObservable { get; set; }
    public void SetupTypeItem(PRISM.Adapters.StaminaRecoveryPopupViewModel viewModel);
    public void SetupTypeJewel(PRISM.Adapters.StaminaRecoveryPopupViewModel viewModel);
    public void Setup(StaminaType type, int currentValue, int afterValue, int maxValue, bool isMax);
    public void Setup(StaminaType type, PRISM.Stamina.StaminaModel model, int afterValue, bool isMax);
    public void UpdateStamina(StaminaType type, PRISM.Stamina.StaminaModel model, int afterValue, bool isMax);
    public void SetupStaminaTypeItem(PRISM.Adapters.StaminaRecoveryPopupViewModel viewModel);
    public void SetUseButtonEnable(PRISM.Adapters.StaminaRecoveryPopupViewModel viewModel);
    public void Dispose();
    private void _initialize(StaminaType type, string infoText, bool isInfoText, bool isHavingItem);
    private void _setupStamina(StaminaType type, int currentValue, int afterValue, int maxValue, bool isMax);
    private void _setupTimer(PRISM.Stamina.StaminaModel model);

    private class <>c__DisplayClass23_0
    {
        public PRISM.Interactions.Stamina.StaminaRecoveryTypeItemPanelView <>4__this;
        public PRISM.Adapters.StaminaRecoveryPopupViewModel viewModel;
        private void <SetupTypeItem>b__0(int _);
        private void <SetupTypeItem>b__1(int _);
    }

    private class <>c__DisplayClass24_0
    {
        public PRISM.Interactions.Stamina.StaminaRecoveryTypeItemPanelView <>4__this;
        public PRISM.Adapters.StaminaRecoveryPopupViewModel viewModel;
        private void <SetupTypeJewel>b__0(int _);
        private void <SetupTypeJewel>b__1(int _);
    }

    private class <>c__DisplayClass26_0
    {
        public PRISM.Interactions.Stamina.StaminaRecoveryTypeItemPanelView <>4__this;
        public PRISM.Stamina.StaminaModel model;
        public int afterValue;
        public bool isMax;
        private void <Setup>b__0(int _);
    }

    private class <>c__DisplayClass33_0
    {
        public PRISM.Stamina.StaminaModel model;
        public PRISM.Interactions.Stamina.StaminaRecoveryTypeItemPanelView <>4__this;
        private void <_setupTimer>b__0(long _);
    }
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=1124 0959B181FD8154FC015D5FAADB7D5E04579444358BF8966F66503500BCD216F8;
    private static __StaticArrayInitTypeSize=799 BFC95D5078C18F80DD89003F0003E3B591FCEDBB7EF04CBBE507F49F449E75CD;

    private struct __StaticArrayInitTypeSize=799 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=1124 : System.ValueType
    {
    }
}
