
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
public class DirectMessageDetailPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IDirectMessageDetailPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private ENTERPRISE.UI.UITextMeshProUGUI titleText;
    private ENTERPRISE.UI.UITextMeshProUGUI dateText;
    private ENTERPRISE.UI.UITextMeshProUGUI bodyText;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    public void Setup(PRISM.Adapters.DirectMessageItemViewModel message1);
    private void <CreateFrameParameter>b__6_0();
    private void <CreateFrameParameter>b__6_1();
}

// Namespace: PRISM.Interactions
public class DirectMessageListCell : PRISM.EnhancedListViewCell<PRISM.Adapters.DirectMessageItemViewModel, PRISM.Interactions.DirectMessageViewContext>
{
    private ENTERPRISE.UI.UITextMeshProUGUI dateText;
    private ENTERPRISE.UI.UITextMeshProUGUI titleText;
    private UnityEngine.GameObject newMarkObject;
    private PRISM.Interactions.ButtonView openButton;
    private System.IDisposable disposable;
    public void UpdateContent(PRISM.Adapters.DirectMessageItemViewModel data);

    private class <>c__DisplayClass5_0
    {
        public PRISM.Interactions.DirectMessageListCell <>4__this;
        public PRISM.Adapters.DirectMessageItemViewModel data;
        private void <UpdateContent>b__0(bool isNew);
        private void <UpdateContent>b__1(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions
public class DirectMessageListView : PRISM.EnhancedListView<PRISM.Adapters.DirectMessageItemViewModel, PRISM.Interactions.DirectMessageViewContext>, System.IDisposable
{
    public System.IObservable<PRISM.Adapters.DirectMessageItemViewModel> OnDetailRequested { get; set; }
    public void Dispose();
}

// Namespace: PRISM.Interactions
public class DirectMessagePopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IDirectMessagePopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.DirectMessageListView listView;
    private PRISM.Adapters.IDirectMessageViewModel message;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public System.IObservable<PRISM.Adapters.DirectMessageItemViewModel> OnDetailRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Setup(PRISM.Adapters.IDirectMessageViewModel message, PRISM.ResourceManagement.IResourceLoader resourceLoader);
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
public class DirectMessageViewContext : PRISM.EnhancedListViewContext, System.IDisposable
{
    private UniRx.Subject<PRISM.Adapters.DirectMessageItemViewModel> onDetailRequested;
    public System.IObservable<PRISM.Adapters.DirectMessageItemViewModel> OnDetailRequested { get; set; }
    public void Dispose();
    public void PublishOpeningDetail(PRISM.Adapters.DirectMessageItemViewModel data);
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=236 15EB638C2E39766F8E4CC424F353E09B066C6E602481E16BD6BA4A2CB0CEACA0;
    private static __StaticArrayInitTypeSize=411 FEA2012B15785C122BA2601B4F3FD1947312DD4D35F7B7063AFFB78222D92F10;

    private struct __StaticArrayInitTypeSize=236 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=411 : System.ValueType
    {
    }
}
