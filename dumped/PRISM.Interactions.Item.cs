
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
public class ItemDetailPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IItemDetailPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private ENTERPRISE.UI.UITextMeshProUGUI itemNameText;
    private ENTERPRISE.UI.UITextMeshProUGUI itemAmountText;
    private ENTERPRISE.UI.UITextMeshProUGUI itemInfoText;
    private ENTERPRISE.OutGame.RewardItem itemIcon;
    private PRISM.Interactions.Shop.GoodsInformationButton informationButton;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public System.IObservable<PRISM.Domain.ProductKey> OnGoodsInformation { get; set; }
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Initialize(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Domain.ProductKey productKey, long amount);
    public void SetAmountText(PRISM.Domain.ProductKey productKey, long amount);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__12_0();
    private void <CreateFrameParameter>b__12_1();
}

// Namespace: PRISM.Interactions.Item
public class ItemListExpireDetailListView : PRISM.Interactions.ListView<PRISM.Interactions.Item.ItemListExpireDetailListViewCell, PRISM.Adapters.ItemListExpireDetailListViewModel>
{
}

// Namespace: PRISM.Interactions.Item
public class ItemListExpireDetailListViewCell : PRISM.Interactions.ListViewCell<PRISM.Adapters.ItemListExpireDetailListViewModel>
{
    private PRISM.Interactions.RewardItemIcon itemIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI label;
    private ENTERPRISE.UI.UITextMeshProUGUI discription;
    public void UpdateContent(PRISM.Adapters.ItemListExpireDetailListViewModel viewModel);
}

// Namespace: PRISM.Interactions.Item
public class ItemListExpireDetailPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IItemListExpireDetailPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.Item.ItemListExpireDetailListView listView;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Adapters.ItemListOverlayContentListViewModel viewModel;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Inject(PRISM.Adapters.ItemListOverlayContentListViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__6_0();
    private void <CreateFrameParameter>b__6_1();

    private struct <LoadAsync>d__7 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
        public PRISM.Interactions.Item.ItemListExpireDetailPopupView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter<bool> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Item
public class ItemListOverlayContentListGridView : PRISM.Interactions.SelectableGridView<PRISM.Interactions.Item.ItemListOverlayContentListGridViewCell, PRISM.Adapters.ItemListOverlayContentListViewModel>
{
    public float ScrollbarValue { get; set; }
    public void SetScrollerValue(float value);
    protected void SetupCellTemplate();

    private class CellGroup : DefaultCellGroup<PRISM.Adapters.ItemListOverlayContentListViewModel, PRISM.Interactions.SelectableGridViewContext<PRISM.Adapters.ItemListOverlayContentListViewModel>>
    {
    }
}

// Namespace: PRISM.Interactions.Item
public class ItemListOverlayContentListGridViewCell : PRISM.Interactions.SelectableGridViewCell<PRISM.Adapters.ItemListOverlayContentListViewModel>
{
    private ENTERPRISE.OutGame.ItemIconView icon;
    private ENTERPRISE.UI.UITextMeshProUGUI text;
    private PRISM.Item.ItemExpireLabel expireLabel;
    private PRISM.AutoCancellationTokenSource canceller;
    public void UpdateContent(PRISM.Adapters.ItemListOverlayContentListViewModel viewModel);

    private class <>c__DisplayClass4_0
    {
        public PRISM.Adapters.ItemListOverlayContentListViewModel viewModel;
        public PRISM.Interactions.Item.ItemListOverlayContentListGridViewCell <>4__this;
        private void <UpdateContent>b__0(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.Item
public class ItemListOverlayContentPanelView : UnityEngine.MonoBehaviour
{
    private UnityEngine.GameObject rootObject;
    private PRISM.Interactions.RewardItemIcon itemIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI itemName;
    private ENTERPRISE.UI.UITextMeshProUGUI itemDescription;
    private ENTERPRISE.UI.UITextMeshProUGUI expireText;
    private ENTERPRISE.UI.UIButton expireButton;
    private ENTERPRISE.UI.UIButton useButton;
    private ENTERPRISE.UI.UITextMeshProUGUI useButtonText;
    public System.IObservable<UniRx.Unit> OnClickExprieOvservable { get; set; }
    public System.IObservable<UniRx.Unit> OnClickUseOvservable { get; set; }
    public void Show(PRISM.Adapters.ItemListOverlayContentListViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Interactions.Item
public class ItemListOverlayTabListView : PRISM.Interactions.ListView<PRISM.Interactions.Item.ItemListOverlayTabListViewCell, PRISM.Adapters.ItemListOverlayTabListViewModel, PRISM.Interactions.Item.ItemListOverlayTabListViewContext>
{
    public void Setup(UniRx.IReactiveProperty<EnumItemType> tabType);
    public void Reload();
}

// Namespace: PRISM.Interactions.Item
public class ItemListOverlayTabListViewCell : PRISM.Interactions.ListViewCell<PRISM.Adapters.ItemListOverlayTabListViewModel, PRISM.Interactions.Item.ItemListOverlayTabListViewContext>
{
    private PRISM.Interactions.ButtonView tabButton;
    private ENTERPRISE.UI.UITextMeshProUGUI tabText;
    private PRISM.Interactions.ViewStateChanger deselectStateChanger;
    private UnityEngine.GameObject dotBadge;
    private System.IDisposable buttonDisposable;
    public void Initialize();
    public void UpdateContent(PRISM.Adapters.ItemListOverlayTabListViewModel viewModel);

    private class <>c__DisplayClass6_0
    {
        public PRISM.Interactions.Item.ItemListOverlayTabListViewCell <>4__this;
        public PRISM.Adapters.ItemListOverlayTabListViewModel viewModel;
        private void <UpdateContent>b__0(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.Item
public class ItemListOverlayTabListViewContext : PRISM.Interactions.ListViewContext
{
    private UniRx.IReactiveProperty<EnumItemType> <SelectedTabType>k__BackingField;
    public UniRx.IReactiveProperty<EnumItemType> SelectedTabType { get; set; }
}

// Namespace: PRISM.Interactions.Item
public class ItemListOverlayView : PRISM.Interactions.OverlayViewWithCloseButton, PRISM.Adapters.IItemListOverlayView, PRISM.Adapters.IClosableOverlayView<UniRx.Unit>, PRISM.Adapters.IOverlayView, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.Item.ItemListOverlayTabListView categoryListView;
    private PRISM.Interactions.Item.ItemListOverlayContentListGridView contentListView;
    private PRISM.Interactions.Item.ItemListOverlayContentPanelView contentPanelView;
    private PRISM.Adapters.ItemListOverlayViewModel viewModel;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    private float startScrollbarValue;
    private System.IDisposable selectedItemDisposable;
    public System.IObservable<UniRx.Unit> OnClickExprieOvservable { get; set; }
    public System.IObservable<UniRx.Unit> OnClickUseOvservable { get; set; }
    public float ScrollbarValue { get; set; }
    public void Initialize(PRISM.Adapters.ItemListOverlayViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, float scrollbarValue, UniRx.IReactiveProperty<EnumItemType> tabType);
    public void UpdateContentList(float scrollbarValue);
    public void SetContentScrollbarValue(float value);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    private void <UpdateContentList>b__14_0(PRISM.Adapters.ItemListOverlayContentListViewModel item);
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=869 101FE18CAA34FBDC72684EA79BFFD376AA44070D00F67DD4DF86FDA482DB0AB1;
    private static __StaticArrayInitTypeSize=706 71A45A94B3502ECAD7F557A83BC0EFC728AE0FFE3750F76A3E9158C59409AFC7;

    private struct __StaticArrayInitTypeSize=706 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=869 : System.ValueType
    {
    }
}
