
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
public class ConnectingView : UnityEngine.MonoBehaviour, PRISM.IConnectingView
{
    private UniRx.IntReactiveProperty counter;
    private System.IDisposable scopeCache;
    private UniRx.IReadOnlyReactiveProperty<int> Counter { get; set; }
    public void Toggle(bool isOn);
    public System.IDisposable CreateDisplayScope();
    private void <CreateDisplayScope>b__5_0();
}

// Namespace: PRISM.Interactions.Loading
public class CommonLoadingContentView : UnityEngine.MonoBehaviour, PRISM.Adapters.Loading.ICommonLoadingContentView
{
    private PRISM.Interactions.Loading.LoadingMiniCharaView miniCharaView;
    private PRISM.Interactions.Loading.LoadingTipsView tipsView;
    private UnityEngine.CanvasGroup canvasGroup;
    private float fadeInDurationSecond;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    public Cysharp.Threading.Tasks.UniTask LoadAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(bool needsShowTips, System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask HideAsync(System.Threading.CancellationToken cancellationToken);
    private void _terminate();
    private void Awake();
}

// Namespace: PRISM.Interactions.Loading
public class LoadingCanvas : UnityEngine.MonoBehaviour
{
    private UnityEngine.Canvas canvas;
    private PRISM.Interactions.Loading.LoadingView loadingView;
    private PRISM.Interactions.ConnectingView connectingView;
    public void Initialize(PRISM.Interactions.UICanvasManager canvasManager);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<int, int, System.ValueTuple<int, int>> <>9__3_0;
        private System.ValueTuple<int, int> <Initialize>b__3_0(int x, int y);
    }

    private class <>c__DisplayClass3_0
    {
        public PRISM.Interactions.UICanvasManager canvasManager;
        public PRISM.Interactions.Loading.LoadingCanvas <>4__this;
        private void <Initialize>b__1(UniRx.Pair<System.ValueTuple<int, int>> pair);
    }
}

// Namespace: PRISM.Interactions.Loading
public class LoadingMiniCharaView : UnityEngine.MonoBehaviour, PRISM.Adapters.Loading.ILoadingMiniCharaView, PRISM.Legacy.ILoadingMiniCharaViewForLegacy
{
    private int charaAnimationLength;
    private UnityEngine.UI.Image loadingCharaImage;
    private PRISM.Adapters.Loading.LoadingMiniCharaViewModel viewModel;
    private System.Threading.CancellationTokenSource cts;
    private int loadingCharaIndex;
    private UnityEngine.Sprite[] loadingCharaSprites;
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public void Show();
    public void Terminate();

    private class <>c__DisplayClass6_0
    {
        public int charaId;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        private Cysharp.Threading.Tasks.UniTask<UnityEngine.Sprite> <InitializeAsync>b__0(int index);
    }

    private class <>c__DisplayClass7_0
    {
        public PRISM.Interactions.Loading.LoadingMiniCharaView <>4__this;
        public System.Threading.CancellationToken ct;
        private Cysharp.Threading.Tasks.UniTask <Show>b__0();

        private struct <<Show>b__0>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
        {
            public int <>1__state;
            public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
            public <>c__DisplayClass7_0 <>4__this;
            private Awaiter <>u__1;
            private void MoveNext();
            private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }

    private struct <InitializeAsync>d__6 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        public PRISM.Interactions.Loading.LoadingMiniCharaView <>4__this;
        private Awaiter<UnityEngine.Sprite[]> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Loading
public class LoadingTipsView : UnityEngine.MonoBehaviour, PRISM.Adapters.Loading.ILoadingTipsView
{
    private ENTERPRISE.UI.UITextMeshProUGUI tipsTitleText;
    private ENTERPRISE.UI.UITextMeshProUGUI tipsDescriptionText;
    private ENTERPRISE.UI.UITextMeshProUGUI tipsCategoryTitleText;
    private UnityEngine.GameObject tipsCategoryObject;
    private UnityEngine.UI.Image tipsCategoryColorImage;
    private UnityEngine.UI.Image tipsCharaImage;
    private PRISM.Adapters.Loading.LoadingTipsViewModel viewModel;
    private bool isInitializationSuccess;
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void Show(bool isActive);

    private struct <InitializeAsync>d__8 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Loading.LoadingTipsView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private System.ValueTuple<int, PRISM.Definitions.MstTips> <pickedResult>5__2;
        private UnityEngine.UI.Image <>7__wrap2;
        private Awaiter<UnityEngine.Sprite> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Loading
public class LoadingView : UnityEngine.MonoBehaviour, PRISM.Adapters.Loading.ILoadingView
{
    private TNRD.SerializableInterface<PRISM.Adapters.Loading.ICommonLoadingContentBuilder> commonLoadingContentBuilder;
    private TNRD.SerializableInterface<PRISM.Adapters.Loading.ISimpleFadeLoadingContentBuilder> simpleFadeLoadingContentBuilder;
    private TNRD.SerializableInterface<PRISM.Adapters.Loading.ISpecialLoadingContentBuilder> specialAnimationLoadingContentBuilder;
    private UniRx.IntReactiveProperty counter;
    public UniRx.IReadOnlyReactiveProperty<int> Counter { get; set; }
    public PRISM.Adapters.Loading.ICommonLoadingContentBuilder CommonLoadingContentBuilder { get; set; }
    public PRISM.Adapters.Loading.ISimpleFadeLoadingContentBuilder SimpleFadeLoadingContentBuilder { get; set; }
    public PRISM.Adapters.Loading.ISpecialLoadingContentBuilder SpecialLoadingContentBuilder { get; set; }
    public void Initialize();
    public void Show();
    public void Hide();
}

// Namespace: PRISM.Interactions.Loading
public class SimpleFadeLoadingContentView : UnityEngine.MonoBehaviour, PRISM.Adapters.Loading.ISimpleFadeLoadingContentView
{
    private UnityEngine.UI.Image image;
    private float showDuration;
    private float hideDuration;
    public bool CanLoad(int simpleFadeType);
    public Cysharp.Threading.Tasks.UniTask LoadAsync(int simpleFadeType, System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask HideAsync(System.Threading.CancellationToken cancellationToken);

    private struct <HideAsync>d__6 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Loading.SimpleFadeLoadingContentView <>4__this;
        public System.Threading.CancellationToken cancellationToken;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Loading
public class SpecialLoadingContentView : UnityEngine.MonoBehaviour, PRISM.Adapters.Loading.ISpecialLoadingContentView
{
    private string transitionAnimationPlayerAssetKey;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    private PRISM.Interactions.Loading.TransitionAnimationPlayer transitionAnimationPlayer;
    public string AssetKey { get; set; }
    public Cysharp.Threading.Tasks.UniTask LoadAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(PRISM.Definitions.Loading.TransitionAnimationType transitionAnimationType, System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask HideAsync(System.Threading.CancellationToken cancellationToken);

    private struct <HideAsync>d__7 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Loading.SpecialLoadingContentView <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <LoadAsync>d__5 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Loading.SpecialLoadingContentView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken cancellationToken;
        private Awaiter<UnityEngine.GameObject> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Loading
public class TransitionAnimationPlayer : UnityEngine.MonoBehaviour
{
    private UnityEngine.Animator animator;
    private System.Collections.Generic.Dictionary<int, System.ValueTuple<int, int, int>> animatorHashDic;
    private PRISM.Definitions.Loading.TransitionAnimationType currentTransitionAnimationType;
    public Cysharp.Threading.Tasks.UniTask PlayAsync(PRISM.Definitions.Loading.TransitionAnimationType transitionAnimationType, System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask StopAsync();
    private System.ValueTuple<int, int, int> _getAnimatorHashes(PRISM.Definitions.Loading.TransitionAnimationType transitionAnimationType);

    private struct <PlayAsync>d__3 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Loading.TransitionAnimationPlayer <>4__this;
        public PRISM.Definitions.Loading.TransitionAnimationType transitionAnimationType;
        public System.Threading.CancellationToken cancellationToken;
        private System.ValueTuple<int, int, int> <hash>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=652 0CDC054E0AC7BAB2A164C3C54FA7EE9AF1F742342233C81A1AEBAE1A5D968563;
    private static __StaticArrayInitTypeSize=455 CD4CCE2A49B9D5A6A44CDD9C1694716486DAA7A6CBA790FD89B8DBBA6EABF680;

    private struct __StaticArrayInitTypeSize=455 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=652 : System.ValueType
    {
    }
}
