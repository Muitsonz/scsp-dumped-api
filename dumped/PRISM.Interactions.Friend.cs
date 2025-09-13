
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
public class FriendIDSearchPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IFriendIDSearchPopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private ENTERPRISE.UI.UITextMeshProUGUI myID;
    private PRISM.Interactions.ButtonView myIDCopyButton;
    private PRISM.CommonInputFieldTMP stringField;
    private ENTERPRISE.UI.UITextMeshProUGUI yourIDText;
    private ENTERPRISE.UI.UITextMeshProUGUI searchIDText;
    private ENTERPRISE.UI.UITextMeshProUGUI inputCountText;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClose;
    private string userSearchId;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public System.IObservable<string> OnChangeSearchIDObservable { get; set; }
    public System.IObservable<string> OnEndEditSearchIDObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnCopyUserIdObservalbe { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Inject(string userSearchId);
    public void SetSearchButtonEnable(bool isEnable);
    public void SetFieldText(string text);
    public void SetInputCountText(string text);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__20_0();
    private void <CreateFrameParameter>b__20_1();
    private void <CreateFrameParameter>b__20_2();
}

// Namespace: PRISM.Interactions.Friend
public class FriendCategoryPanelView : UnityEngine.MonoBehaviour, PRISM.Adapters.Friend.IFriendCategoryPanelView
{
    private PRISM.Interactions.Friend.FriendCellScrollerView scroller;
    private ENTERPRISE.UI.UITextMeshProUGUI countText;
    private PRISM.Interactions.ButtonView toggleSortDirectionButton;
    private PRISM.Interactions.ViewStateChanger toggleSortDirectionButtonChanger;
    private PRISM.Interactions.ButtonView toggleDisplayButton;
    private ENTERPRISE.UI.UITextMeshProUGUI toggleDisplayButtonText;
    public PRISM.Adapters.Friend.IFriendCellScrollerView Scroller { get; set; }
    public System.IObservable<UniRx.Unit> OnClickToggleSortDirectionButton { get; set; }
    public void Initialize(UniRx.IReadOnlyReactiveProperty<System.ValueTuple<int, int>> count, UniRx.IReadOnlyReactiveProperty<SortOrderType> sortOrderType, UniRx.IReactiveProperty<SwitchDisplayType> switchDisplayType, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void SetActive(bool isActive);

    private class <>c__DisplayClass10_0
    {
        public PRISM.Interactions.Friend.FriendCategoryPanelView <>4__this;
        public UniRx.IReactiveProperty<SwitchDisplayType> switchDisplayType;
        public SwitchDisplayType[] displayTypes;
        private void <Initialize>b__0(System.ValueTuple<int, int> value);
        private void <Initialize>b__1(SortOrderType value);
        private void <Initialize>b__2(UniRx.Unit _);
        private void <Initialize>b__3(SwitchDisplayType value);
    }
}

// Namespace: PRISM.Interactions.Friend
public class FriendCategoryPanelViewForRecommend : UnityEngine.MonoBehaviour, PRISM.Adapters.Friend.IFriendCategoryPanelViewForRecommend
{
    private PRISM.Interactions.Friend.FriendCategoryPanelView panelView;
    private PRISM.Interactions.ButtonView idSearchButton;
    private PRISM.Interactions.ButtonView reloadButton;
    public PRISM.Adapters.Friend.IFriendCategoryPanelView PanelView { get; set; }
    public System.IObservable<UniRx.Unit> OnClickIdSearchButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickReloadButton { get; set; }
}

// Namespace: PRISM.Interactions.Friend
public class FriendCategoryTabGroupView : UnityEngine.MonoBehaviour, PRISM.Adapters.Friend.IFriendCategoryTabGroupView
{
    private UnityEngine.Transform tabParent;
    private PRISM.Interactions.Friend.FriendCategoryTabView tabPrefab;
    public void Initialize(System.Collections.Generic.IEnumerable<PRISM.Adapters.Friend.IFriendCategoryTabModel> tabModels, UniRx.IReactiveProperty<int> selectedTabIndex);
    private PRISM.Interactions.ButtonView <Initialize>b__2_0(PRISM.Adapters.Friend.IFriendCategoryTabModel tabViewModel);
}

// Namespace: PRISM.Interactions.Friend
public class FriendCategoryTabView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView tabButton;
    private ENTERPRISE.UI.UITextMeshProUGUI tabText;
    private UnityEngine.GameObject newBadge;
    public PRISM.Interactions.ButtonView TabButton { get; set; }
    public void Initialize(PRISM.Adapters.Friend.IFriendCategoryTabModel model);
    private void <Initialize>b__5_0(bool isNew);
}

// Namespace: PRISM.Interactions.Friend
public class FriendCellGuestIdolPanelView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.GuestEditCharacterIcon[] liveGuestIcons;
    private PRISM.UI.SCharaIconView supportIdolIcon;
    public void Setup(PRISM.Adapters.Friend.FriendCellViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);

    private class <>c__DisplayClass2_0
    {
        public Attribute attribute;
        private bool <Setup>b__0(PRISM.Adapters.GuestEditCharacterIconModel x);
    }
}

// Namespace: PRISM.Interactions.Friend
public class FriendCellScrollerView : PRISM.CommonListView<PRISM.Interactions.Friend.FriendCellView, PRISM.Adapters.Friend.FriendCellViewModel, PRISM.Interactions.Friend.FriendCellScrollerViewContext>, PRISM.Adapters.Friend.IFriendCellScrollerView
{
    public System.IObservable<int> OnClickCell { get; set; }
    public System.IObservable<PRISM.Module.Networking.IProduceIdolStatus> OnLongPressProduceIcon { get; set; }
    public void SetSwitchDisplayType(UniRx.IReactiveProperty<SwitchDisplayType> switchDisplayType);
    public void UpdateScroller(System.Collections.Generic.IList<PRISM.Adapters.Friend.FriendCellViewModel> cellViewModels);
    public void RefreshView();
    protected void Initialize();
    private void PRISM.Adapters.Friend.IFriendCellScrollerView.SetResourceLoader(PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private void <get_OnClickCell>b__1_0(System.Action<int> h);
    private void <get_OnClickCell>b__1_1(System.Action<int> h);
}

// Namespace: PRISM.Interactions.Friend
public class FriendCellScrollerViewContext : PRISM.CommonListViewContext, System.IDisposable
{
    private UniRx.Subject<PRISM.Module.Networking.IProduceIdolStatus> <OnLongPressProduceIcon>k__BackingField;
    private UniRx.IReactiveProperty<SwitchDisplayType> <SwitchDisplayType>k__BackingField;
    public UniRx.Subject<PRISM.Module.Networking.IProduceIdolStatus> OnLongPressProduceIcon { get; set; }
    public UniRx.IReactiveProperty<SwitchDisplayType> SwitchDisplayType { get; set; }
    public void SetSwitchDisplayType(UniRx.IReactiveProperty<SwitchDisplayType> switchDisplayType);
    public void Dispose();
}

// Namespace: PRISM.Interactions.Friend
public class FriendCellUserDataPanelView : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI playerName;
    private ENTERPRISE.UI.UITextMeshProUGUI playerNameSpace;
    private ENTERPRISE.UI.UITextMeshProUGUI latestLoginDate;
    private ENTERPRISE.UI.UITextMeshProUGUI comment;
    private PRISM.Interactions.ViewStateChanger friendStateChanger;
    private PRISM.Interactions.SimpleAchievementIconGroup achievementIconGroup;
    private PRISM.AutoCancellationTokenSource canceller;
    public void UpdateView(PRISM.Adapters.Friend.FriendCellUserDataPanelViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private void OnDestroy();
}

// Namespace: PRISM.Interactions.Friend
public class FriendCellView : PRISM.CommonListViewCell<PRISM.Adapters.Friend.FriendCellViewModel, PRISM.Interactions.Friend.FriendCellScrollerViewContext>
{
    private PRISM.UI.PFIdolIconView iconView;
    protected UnityEngine.CanvasGroup awakenLvCanvas;
    protected ENTERPRISE.UI.UITextMeshProUGUI awakenLvText;
    private UnityEngine.GameObject newImageObject;
    private PRISM.Interactions.ViewStateChanger panelStateChanger;
    private PRISM.Interactions.Friend.FriendCellUserDataPanelView userDataPanelView;
    private PRISM.Interactions.Friend.FriendCellGuestIdolPanelView guestIdolPanelView;
    private PRISM.Adapters.Friend.FriendCellViewModel viewModel;
    private System.IDisposable friendStateDisposable;
    public void Initialize();
    public void UpdateContent(PRISM.Adapters.Friend.FriendCellViewModel viewModel);
    public void SwitchDisplay();
    private void <Initialize>b__9_0(System.ValueTuple<int, UnityEngine.GameObject> _);
    private void <Initialize>b__9_1(SwitchDisplayType type);
}

// Namespace: PRISM.Interactions.Friend
public class FriendOverlayView : PRISM.Interactions.OverlayViewWithCloseButton, PRISM.Adapters.Friend.IFriendOverlayView, PRISM.Adapters.IClosableOverlayView<UniRx.Unit>, PRISM.Adapters.IOverlayView, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private UnityEngine.CanvasGroup canvasGroup;
    private PRISM.Interactions.Friend.FriendCategoryTabGroupView tabGroupView;
    private PRISM.Interactions.Friend.FriendCategoryPanelView panelViewForFollow;
    private PRISM.Interactions.Friend.FriendCategoryPanelView panelViewForFollower;
    private PRISM.Interactions.Friend.FriendCategoryPanelViewForRecommend panelViewForRecommend;
    public PRISM.Adapters.Friend.IFriendCategoryTabGroupView TabGroupView { get; set; }
    public PRISM.Adapters.Friend.IFriendCategoryPanelView PanelViewForFollow { get; set; }
    public PRISM.Adapters.Friend.IFriendCategoryPanelView PanelViewForFollower { get; set; }
    public PRISM.Adapters.Friend.IFriendCategoryPanelViewForRecommend PanelViewForRecommend { get; set; }
    public void Initialize();
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    private void _show(bool isShow);
}

// Namespace: PRISM.Interactions.Friend
public class FriendRemoveConfirmPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IFriendRemoveConfirmPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private TMPro.TextMeshProUGUI topMessageText;
    private ENTERPRISE.UI.UITextMeshProUGUI playerName;
    private ENTERPRISE.UI.UITextMeshProUGUI latestLoginDate;
    private PRISM.UI.PFIdolIconView iconView;
    private PRISM.Interactions.SimpleAchievementIconGroup achievementIconGroup;
    private UnityEngine.GameObject[] stateObjects;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClose;
    private PRISM.Adapters.FriendRemoveConfirmPopupViewModel viewModel;
    private System.Func<Cysharp.Threading.Tasks.UniTask> removeTaskFactory;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Initialize(PRISM.Adapters.FriendRemoveConfirmPopupViewModel viewModel, System.Func<Cysharp.Threading.Tasks.UniTask> removeTaskFactory, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void _setup(PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private void _setupFriendState(int index);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    private void <CreateFrameParameter>b__12_0();
    private void <CreateFrameParameter>b__12_1();
    private bool <CreateFrameParameter>b__12_2();
    private void <CreateFrameParameter>b__12_3();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<string, string> <>9__14_0;
        private string <_setup>b__14_0(string kw);
    }
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=1107 B56A678EDE5CA164CCD2649E9EA9C2C75E56AD128FB705FFCC9DB8BFE9DF50A5;
    private static __StaticArrayInitTypeSize=658 E2135BEE9213F4BFA90A0475B13B2C1DE0919482C2D09B7C1B269A8EA601D024;

    private struct __StaticArrayInitTypeSize=658 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=1107 : System.ValueType
    {
    }
}
