
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
public class AgePurchaseLimitPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IAgePurchaseLimitPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private ENTERPRISE.UI.UITextMeshProUGUI popupLabel;
    private ENTERPRISE.UI.UITextMeshProUGUI[] tableValues;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onCloseButtonClicked;
    private PRISM.Interactions.IPopupFrameView parent;
    public UnityEngine.RectTransform Rect { get; set; }
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void UpdateViewText();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__3_0();
    private void <CreateFrameParameter>b__3_1();
}

// Namespace: PRISM.Interactions
public class CheckJewelPopupView : UnityEngine.MonoBehaviour, PRISM.Adapters.ICheckJewelPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>, PRISM.Interactions.IPopupContent
{
    private ENTERPRISE.UI.UITextMeshProUGUI popupLabel;
    private ENTERPRISE.UI.UITextMeshProUGUI popupDescription;
    private ENTERPRISE.UI.UITextMeshProUGUI[] tableLabels;
    private ENTERPRISE.UI.UITextMeshProUGUI[] tableValues;
    private ENTERPRISE.UI.UITextMeshProUGUI currentPlatformPaidJewelValue;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onCloseButtonClicked;
    private PRISM.Interactions.IPopupFrameView popupFrame;
    public UnityEngine.RectTransform Rect { get; set; }
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView popupFrame);
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void UpdateJewelAmount(long paid, long free, long currentPaid);
    private void <CreateFrameParameter>b__16_0();
    private void <CreateFrameParameter>b__16_1();

    private struct <HideAsync>d__15 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.CheckJewelPopupView <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <LoadAsync>d__12 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
        public PRISM.Interactions.CheckJewelPopupView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter<bool> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <ShowAsync>d__14 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.CheckJewelPopupView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <TerminateAsync>d__13 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.CheckJewelPopupView <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class CopyrightPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.ICopyrightPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private UnityEngine.TextAsset textAsset;
    private ENTERPRISE.UI.UITextMeshProUGUI text;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClick;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__6_0();
    private void <CreateFrameParameter>b__6_1();
}

// Namespace: PRISM.Interactions.Support
public class SupportPopupView : UnityEngine.MonoBehaviour, PRISM.Adapters.ISupportPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>, PRISM.Interactions.IPopupContent
{
    private static string AccountDeleteLinkKey;
    private PRISM.Interactions.ButtonView[] buttons;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onCloseButtonClicked;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public System.IObservable<PRISM.Adapters.Support.SupportContentType> OnClick { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void SetButtonEnabled(PRISM.Adapters.Support.SupportContentType type, bool isEnabled);
    public string GetAccountDeleteUrlQuery(string userId);
    private PRISM.Interactions.PopupFrameParameter PRISM.Interactions.IPopupContent.CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <PRISM.Interactions.IPopupContent.CreateFrameParameter>b__9_0();
    private void <PRISM.Interactions.IPopupContent.CreateFrameParameter>b__9_1();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Interactions.ButtonView, int, System.IObservable<PRISM.Adapters.Support.SupportContentType>> <>9__6_0;
        private System.IObservable<PRISM.Adapters.Support.SupportContentType> <get_OnClick>b__6_0(PRISM.Interactions.ButtonView x, int index);
    }

    private class <>c__DisplayClass6_0
    {
        public int index;
        private PRISM.Adapters.Support.SupportContentType <get_OnClick>b__1(UniRx.Unit _);
    }
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=290 24FD55E151C60CD8120DF8BAE92E62D0AB4D9D7A17227A58A137D191B5A13212;
    private static __StaticArrayInitTypeSize=182 F4C27D5EFD625F0BBE6B614E4C82F67EEBB3AB4FD2D9171E1FE78ED2E4EE8E52;

    private struct __StaticArrayInitTypeSize=182 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=290 : System.ValueType
    {
    }
}
