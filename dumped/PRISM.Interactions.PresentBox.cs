
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

// Namespace: PRISM.Interactions.PresentBox
public class PresentBoxHistoryListView : PRISM.Interactions.ListView<PRISM.Interactions.PresentBox.PresentBoxHistoryListViewCell, PRISM.Adapters.PresentBoxListViewModel>
{
}

// Namespace: PRISM.Interactions.PresentBox
public class PresentBoxHistoryListViewCell : PRISM.Interactions.ListViewCell<PRISM.Adapters.PresentBoxListViewModel>
{
    private PRISM.Interactions.RewardItemIcon itemIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI nameText;
    private ENTERPRISE.UI.UITextMeshProUGUI messageText;
    private ENTERPRISE.UI.UITextMeshProUGUI limitText;
    private ENTERPRISE.UI.UITextMeshProUGUI receiveText;
    private ENTERPRISE.UI.UITextMeshProUGUI receiveLabelText;
    public void UpdateContent(PRISM.Adapters.PresentBoxListViewModel viewModel);
}

// Namespace: PRISM.Interactions.PresentBox
public class PresentBoxHistoryPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IPresentBoxHistoryPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.PresentBox.PresentBoxHistoryListView historyListView;
    private ENTERPRISE.UI.UITextMeshProUGUI[] replaceTexts;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClick;
    private PRISM.Adapters.PresentBoxViewModel viewModel;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Inject(PRISM.Adapters.PresentBoxViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__7_0();
    private void <CreateFrameParameter>b__7_1();
}

// Namespace: PRISM.Interactions.PresentBox
public class PresentBoxListView : PRISM.Interactions.ListView<PRISM.Interactions.PresentBox.PresentBoxListViewCell, PRISM.Adapters.PresentBoxListViewModel>
{
}

// Namespace: PRISM.Interactions.PresentBox
public class PresentBoxListViewCell : PRISM.Interactions.ListViewCell<PRISM.Adapters.PresentBoxListViewModel>
{
    private PRISM.Interactions.RewardItemIcon itemIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI nameText;
    private ENTERPRISE.UI.UITextMeshProUGUI messageText;
    private ENTERPRISE.UI.UITextMeshProUGUI limitText;
    private ENTERPRISE.UI.UITextMeshProUGUI receiveText;
    private ENTERPRISE.UI.UITextMeshProUGUI receiveLabelText;
    public void UpdateContent(PRISM.Adapters.PresentBoxListViewModel viewModel);
}

// Namespace: PRISM.Interactions.PresentBox
public class PresentBoxPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IPresentBoxPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.PresentBox.PresentBoxListView presentListView;
    private ENTERPRISE.UI.UITextMeshProUGUI[] replaceTexts;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClose;
    private UniRx.Subject<UniRx.Unit> onOpenHistory;
    private UniRx.Subject<UniRx.Unit> onReceive;
    private PRISM.Adapters.PresentBoxViewModel viewModel;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public System.IObservable<UniRx.Unit> OnOpenHistoryObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnReceiveObservable { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Inject(PRISM.Adapters.PresentBoxViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void SetReceiveButtonEnable(bool isEnable);
    public void UpdateListView();
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__15_0();
    private void <CreateFrameParameter>b__15_1();
    private void <CreateFrameParameter>b__15_2();
    private void <CreateFrameParameter>b__15_3();
    private void <ShowAsync>b__21_1(bool hasPresentList);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Adapters.PresentBoxViewModel, bool> <>9__21_0;
        private bool <ShowAsync>b__21_0(PRISM.Adapters.PresentBoxViewModel x);
    }

    private struct <LoadAsync>d__16 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
        public PRISM.Interactions.PresentBox.PresentBoxPopupView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter<bool> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.PresentBox
public class PresentBoxReceiveListView : PRISM.Interactions.ListView<PRISM.Interactions.PresentBox.PresentBoxReceiveListViewCell, PRISM.Adapters.PresentBoxListViewModel>
{
}

// Namespace: PRISM.Interactions.PresentBox
public class PresentBoxReceiveListViewCell : PRISM.Interactions.ListViewCell<PRISM.Adapters.PresentBoxListViewModel>
{
    private PRISM.Interactions.RewardItemIcon itemIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI nameText;
    public void UpdateContent(PRISM.Adapters.PresentBoxListViewModel viewModel);
}

// Namespace: PRISM.Interactions.PresentBox
public class PresentBoxReceivePopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IPresentBoxReceivePopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.PresentBox.PresentBoxReceiveListView receiveListView;
    private ENTERPRISE.UI.UITextMeshProUGUI messageText;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClick;
    private System.Collections.Generic.List<PRISM.Adapters.PresentBoxListViewModel> receiveModelList;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Inject(System.Collections.Generic.List<PRISM.Adapters.PresentBoxListViewModel> receiveModelList, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__7_0();
    private void <CreateFrameParameter>b__7_1();
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=534 3F09A6D2E71CE3CAA54B6BA08D7B4F8249994D3EE1F68AC468AB534357955547;
    private static __StaticArrayInitTypeSize=723 CADE5BFFF5FD77BB5633FB3D46C8ABCEF31F44A762484C50AF52718BFDD378D9;

    private struct __StaticArrayInitTypeSize=534 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=723 : System.ValueType
    {
    }
}
