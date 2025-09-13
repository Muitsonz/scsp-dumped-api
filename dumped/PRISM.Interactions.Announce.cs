
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
public class AnnounceConst
{
    public static float LINE_SPACING;
    public static System.Collections.Generic.Dictionary<AnnounceGenre, UnityEngine.Color> GenreColor;
}

// Namespace: PRISM.Interactions
public class AnnounceDetailPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IAnnounceDetailPopupView, PRISM.Adapters.IClosablePopupFrame<int>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<int>
{
    private UnityEngine.UI.Image imgCategory;
    private ENTERPRISE.UI.UITextMeshProUGUI txtCategory;
    private ENTERPRISE.UI.UITextMeshProUGUI txtTime;
    private UnityEngine.GameObject newBadge;
    private ENTERPRISE.UI.UITextMeshProUGUI txtUpdateTime;
    private ENTERPRISE.UI.UITextMeshProUGUI txtUpdateName;
    private ENTERPRISE.UI.UITextMeshProUGUI txtTitle;
    private Growing.XMLPanel xMLPanel;
    private UnityEngine.CanvasGroup canvasGroup;
    private PRISM.Interactions.PopupFrameParameter frameParameter;
    private PRISM.Adapters.AnnounceDetailPopupViewModel viewModel;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<int> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<int> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Initialize(PRISM.Adapters.AnnounceDetailPopupViewModel viewModel);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private ButtonInfoParameter <Initialize>b__11_0(PRISM.Module.Networking.IJumpStatus jump, int index);
    private void <Initialize>b__11_2();
    private void <Initialize>b__11_3();
    private float <ShowAsync>b__12_0();
    private void <ShowAsync>b__12_1(float x);

    private class <>c__DisplayClass11_0
    {
        public int index;
        public PRISM.Interactions.AnnounceDetailPopupView <>4__this;
        private void <Initialize>b__1();
    }

    private struct <ShowAsync>d__12 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.AnnounceDetailPopupView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private Awaiter<bool> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class AnnounceListView : PRISM.EnhancedListView<PRISM.Adapters.AnnounceListItemViewModel, PRISM.Interactions.AnnounceListViewContext>, System.IDisposable
{
    private float normalCellSize;
    private float moreButtonCellSize;
    public System.IObservable<string> OnArticleRequested { get; set; }
    public System.IObservable<UniRx.Unit> OnMoreRequested { get; set; }
    public float GetCellViewSize(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex);
    public void JumpToDataIndex(int index);
    public void Dispose();
}

// Namespace: PRISM.Interactions
public class AnnounceListViewCell : PRISM.EnhancedListViewCell<PRISM.Adapters.AnnounceListItemViewModel, PRISM.Interactions.AnnounceListViewContext>
{
    private UnityEngine.UI.Image imgCategory;
    private ENTERPRISE.UI.UITextMeshProUGUI txtCategory;
    private ENTERPRISE.UI.UITextMeshProUGUI txtTime;
    private UnityEngine.GameObject goIsNew;
    private ENTERPRISE.UI.UITextMeshProUGUI txtUpdateTime;
    private ENTERPRISE.UI.UITextMeshProUGUI txtUpdateName;
    private UnityEngine.UI.RawImage imgBanner;
    private ENTERPRISE.UI.UITextMeshProUGUI txtTitle;
    private PRISM.Interactions.ButtonView btnMain;
    private PRISM.Interactions.ButtonView btnMore;
    private UnityEngine.GameObject normalCellObject;
    private System.Threading.CancellationTokenSource tokenSource;
    private static System.Collections.Generic.IReadOnlyDictionary<AnnounceCategory, string> bannerKeyList;
    protected void _initialize();
    public void UpdateContent(PRISM.Adapters.AnnounceListItemViewModel data);
    private void OnDestroy();
    private string <_initialize>b__13_0(UniRx.Unit _);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<string, bool> <>9__13_1;
        private bool <_initialize>b__13_1(string t);
    }
}

// Namespace: PRISM.Interactions
public class AnnounceListViewContext : PRISM.EnhancedListViewContext, System.IDisposable
{
    public PRISM.Legacy.WebTextureLoader WebTextureLoader;
    private UniRx.Subject<string> <OnArticleClicked>k__BackingField;
    private UniRx.Subject<UniRx.Unit> <OnMoreClicked>k__BackingField;
    public UniRx.Subject<string> OnArticleClicked { get; set; }
    public UniRx.Subject<UniRx.Unit> OnMoreClicked { get; set; }
    public void Dispose();
}

// Namespace: PRISM.Interactions
public class AnnounceOverlayView : PRISM.Interactions.OverlayViewWithCloseButton, PRISM.Adapters.IAnnounceOverlayView, PRISM.Adapters.IClosableOverlayView<UniRx.Unit>, PRISM.Adapters.IOverlayView, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private ENTERPRISE.UI.UITabGroup tabGroup;
    private ENTERPRISE.UI.UITabButton categoryTabTemplate;
    private PRISM.Interactions.AnnounceListView listView;
    private ENTERPRISE.UI.UITextMeshProUGUI txtDataNothing;
    private BannerPair[] bannerIcons;
    private PictgramPair[] pictgramIcons;
    private System.Collections.Generic.Dictionary<AnnounceCategory, UnityEngine.Texture2D> bannerImages;
    private System.Collections.Generic.Dictionary<AnnounceCategory, UnityEngine.Sprite> pictogramImages;
    private PRISM.Adapters.AnnounceOverlayViewModel viewModel;
    private AnnounceCategory <LastSelectCategory>k__BackingField;
    public AnnounceCategory LastSelectCategory { get; set; }
    public System.IObservable<string> OnItemClicked { get; set; }
    public System.IObservable<AnnounceCategory> OnMoreRequested { get; set; }
    public void UpdateList(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.AnnounceListItemViewModel> viewModelList);
    public void JumpToDataIndex(int index);
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Adapters.AnnounceOverlayViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    private Cysharp.Threading.Tasks.UniTask _refreshListAsync(AnnounceCategory category, System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask _loadImageAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private AnnounceCategory <get_OnMoreRequested>b__18_0(UniRx.Unit _);

    public class BannerPair
    {
        public AnnounceCategory category;
        public string texture;
    }

    public class PictgramPair
    {
        public AnnounceCategory category;
        public string sprite;
    }

    private class <>c__DisplayClass21_0
    {
        public PRISM.Adapters.AnnounceOverlayViewModel viewModel;
        public PRISM.Interactions.AnnounceOverlayView <>4__this;
        private void <SetupAsync>b__0(int index, ENTERPRISE.UI.UITabGroup obj);
    }

    private class <>c__DisplayClass24_0
    {
        public AnnounceCategory item;
        private bool <_loadImageAsync>b__0(BannerPair pair);
        private bool <_loadImageAsync>b__1(PictgramPair pair);
    }

    private struct <SetupAsync>d__21 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Adapters.AnnounceOverlayViewModel viewModel;
        public PRISM.Interactions.AnnounceOverlayView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private <>c__DisplayClass21_0 <>8__1;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_loadImageAsync>d__24 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.AnnounceOverlayView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private <>c__DisplayClass24_0 <>8__1;
        private AnnounceCategory[] <>7__wrap1;
        private int <>7__wrap2;
        private System.Collections.Generic.Dictionary<AnnounceCategory, UnityEngine.Texture2D> <>7__wrap3;
        private AnnounceCategory <>7__wrap4;
        private Awaiter<UnityEngine.Texture2D> <>u__1;
        private System.Collections.Generic.Dictionary<AnnounceCategory, UnityEngine.Sprite> <>7__wrap5;
        private Awaiter<UnityEngine.Sprite> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_refreshListAsync>d__23 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.AnnounceOverlayView <>4__this;
        public AnnounceCategory category;
        public System.Threading.CancellationToken ct;
        private Awaiter<System.Collections.Generic.IReadOnlyList<PRISM.Adapters.AnnounceListItemViewModel>> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=368 70C9C42093F5E93F5CF9814606F16FC5F88A532982E26C5161ABC4FE4B4BA5D5;
    private static __StaticArrayInitTypeSize=438 9093A98C714EE8F879213345BD371A6CD0C0978A416F0CB5D22CA84D930FC78D;

    private struct __StaticArrayInitTypeSize=368 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=438 : System.ValueType
    {
    }
}
