
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
public class ConnectOrTransferConfirmPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IConnectOrTransferConfirmPopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private ENTERPRISE.UI.UITextMeshProUGUI topText;
    private ENTERPRISE.UI.UITextMeshProUGUI userIdText;
    private ENTERPRISE.UI.UITextMeshProUGUI userNameText;
    private ENTERPRISE.UI.UITextMeshProUGUI firstTimeDateText;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClosed;
    private PRISM.Interactions.PopupFrameParameter frameParameter;
    private PRISM.Interactions.IPopupFrameView parent;
    private UnityEngine.GameObject releaseConnectAnnotation;
    private ENTERPRISE.UI.UITextMeshProUGUI releaseConnectLabelText;
    private ENTERPRISE.UI.UITextMeshProUGUI releaseConnectTimeLeftText;
    private System.Nullable<System.DateTime> releasableDate;
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    private void _initializeCommon(PRISM.Definitions.LocalizationKey topKey, string userId, string userName, System.Nullable<System.DateTime> firstTimeDate);
    public void InitializeAsConnectAccount(PRISM.Adapters.IConnectAccountUser user);
    public void InitializeAsTransferAccount(PRISM.Module.Networking.IConfirmTransferReply user);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    public void InitializeAsReleaseConnectAccount(PRISM.Adapters.IConnectAccountUser user);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    private void _startReleaseConnectTextUpdater();
    private void <InitializeAsConnectAccount>b__9_0();
    private void <InitializeAsConnectAccount>b__9_1();
    private void <InitializeAsConnectAccount>b__9_2();
    private void <InitializeAsTransferAccount>b__10_0();
    private void <InitializeAsTransferAccount>b__10_1();
    private void <InitializeAsTransferAccount>b__10_2();
    private void <InitializeAsReleaseConnectAccount>b__23_1();
    private void <InitializeAsReleaseConnectAccount>b__23_3();
    private void <InitializeAsReleaseConnectAccount>b__23_4();
    private Cysharp.Threading.Tasks.UniTask <InitializeAsReleaseConnectAccount>g__ConfirmAsync|23_0();

    private struct <<InitializeAsReleaseConnectAccount>g__ConfirmAsync|23_0>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ConnectOrTransferConfirmPopupView <>4__this;
        private Awaiter<bool> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private class <>c
    {
        public static <>c <>9;
        public static System.Action <>9__23_2;
        private void <InitializeAsReleaseConnectAccount>b__23_2();
    }

    private class <>c__DisplayClass25_0
    {
        public PRISM.Interactions.ConnectOrTransferConfirmPopupView <>4__this;
        public System.IDisposable disposable;
        private void <_startReleaseConnectTextUpdater>b__0(long x);
    }
}

// Namespace: PRISM.Interactions
public class ConnectOrTransferTokenInputPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IConnectOrTransferTokenInputPopupView, PRISM.Adapters.IClosablePopupFrame<string>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<string>
{
    private PRISM.CommonInputFieldTMP codeInput;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<string> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<string> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    private Cysharp.Threading.Tasks.UniTask _onCancelAsync();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <ShowAsync>b__4_0(string text);
    private void <CreateFrameParameter>b__5_0();
    private void <CreateFrameParameter>b__5_1();
    private void <CreateFrameParameter>b__5_2();

    private struct <_onCancelAsync>d__6 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ConnectOrTransferTokenInputPopupView <>4__this;
        private Awaiter<bool> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class TransferStopPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.ITransferStopPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private static string TransferStopCategory;
    private static int TitleId;
    private static int MessageId;
    private static string ContactCategory;
    private static int PlayerIdLabel;
    private static int PlayerIdNotExist;
    private static int CopyIdText;
    private static int ContactButtonText;
    private static int CopyFinishPopupTitle;
    private static int CopyFinishPopupMessage;
    private ENTERPRISE.UI.UITextMeshProUGUI message;
    private ENTERPRISE.UI.UITextMeshProUGUI playerIdLabel;
    private ENTERPRISE.UI.UITextMeshProUGUI playerIdValueText;
    private ENTERPRISE.UI.UITextMeshProUGUI copyIdText;
    private ENTERPRISE.UI.UIButton copyIdButton;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private UniRx.Subject<UniRx.Unit> onClickFaq;
    private string urlQuery;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public System.IObservable<UniRx.Unit> OnClickFaq { get; set; }
    public System.IObservable<UniRx.Unit> OnClickIdCopyButton { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Initialize(string userId);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void OpenURL(string url);
    public Cysharp.Threading.Tasks.UniTask ShowFinishCopyIdAsync(string userId, System.Threading.CancellationToken cancellationToken);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__25_0();
    private void <CreateFrameParameter>b__25_1();
    private void <CreateFrameParameter>b__25_2();
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=389 035B18D74B486EA30E9F77CDF1C5EA9104F0044103353FF5DE5AFC90D5B64E36;
    private static __StaticArrayInitTypeSize=219 AC1BAD4ECDA77354E6E80019A5E68DC0BD5D4901378B29C108DFE7D8DD4E0E86;

    private struct __StaticArrayInitTypeSize=219 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=389 : System.ValueType
    {
    }
}
