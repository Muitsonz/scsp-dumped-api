
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
public class ShareScreenshotOverlayView : UnityEngine.MonoBehaviour, PRISM.Adapters.IShareScreenshotOverlayView, PRISM.Adapters.IClosableOverlayView<UniRx.Unit>, PRISM.Adapters.IOverlayView, PRISM.Adapters.IClosable<UniRx.Unit>, PRISM.Interactions.IDisableBackgroundBlur
{
    private string <Text>k__BackingField;
    private System.Nullable<float> <AspectRatio>k__BackingField;
    private bool <IsTransparent>k__BackingField;
    private string Text { get; set; }
    private System.Nullable<float> AspectRatio { get; set; }
    private bool IsTransparent { get; set; }
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    private Cysharp.Threading.Tasks.UniTask PRISM.Adapters.IOverlayView.ShowAsync(System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask<UniRx.Unit> _shareAsync();
    public Cysharp.Threading.Tasks.UniTask HideAsync();

    private struct <_shareAsync>d__15 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<UniRx.Unit> <>t__builder;
        public PRISM.Interactions.ShareScreenshotOverlayView <>4__this;
        private System.IDisposable <_>5__2;
        private System.IDisposable <__>5__3;
        private NativeShare <share>5__4;
        private Awaiter <>u__1;
        private Awaiter<System.ValueTuple<ShareResult, string>> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=50 B408619B7A7DE5651E4745D43AFB72FCC0F6A2DC3AB621DDE86358EFBC7C6D25;
    private static __StaticArrayInitTypeSize=95 CA1E9AEAFD01A9220F8E0FD1ADD686FEA24CB230582D92F864A8B0E6FDA31557;

    private struct __StaticArrayInitTypeSize=50 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=95 : System.ValueType
    {
    }
}
