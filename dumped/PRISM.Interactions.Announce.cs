
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
public class AnnounceListView : PRISM.EnhancedListView<PRISM.Adapters.AnnounceListItemViewModel, PRISM.Interactions.AnnounceListViewContext>
{
    private float normalCellSize;
    private float moreButtonCellSize;
    public System.IObservable<string> OnArticleRequested { get; set; }
    public System.IObservable<UniRx.Unit> OnMoreRequested { get; set; }
    public float GetCellViewSize(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex);
    public void JumpToDataIndex(int index);
    public void OnDestroy();
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
    private UnityEngine.Texture2D[] defaultBanners;
    private ENTERPRISE.UI.UITextMeshProUGUI txtTitle;
    private PRISM.Interactions.ButtonView btnMain;
    private PRISM.Interactions.ButtonView btnMore;
    private UnityEngine.GameObject normalCellObject;
    private System.Threading.CancellationTokenSource tokenSource;
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
    private PRISM.Interactions.ToggleGroupView categoryToggleGroup;
    private PRISM.Interactions.AnnounceListView listView;
    private UniRx.ReactiveProperty<AnnounceCategory> selectedCategory;
    public System.IObservable<string> OnItemClicked { get; set; }
    public System.IObservable<AnnounceCategory> OnMoreRequested { get; set; }
    public void UpdateList(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.AnnounceListItemViewModel> viewModelList);
    public void JumpToDataIndex(int index);
    public void Initialize(PRISM.Adapters.AnnounceOverlayViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    private AnnounceCategory <get_OnMoreRequested>b__6_0(UniRx.Unit _);

    private class <>c__DisplayClass9_0
    {
        public PRISM.Adapters.AnnounceOverlayViewModel viewModel;
        public System.Threading.CancellationToken ct;
        public PRISM.Interactions.AnnounceOverlayView <>4__this;
        private Cysharp.Threading.Tasks.UniTaskVoid <Initialize>b__0(AnnounceCategory category);

        private struct <<Initialize>b__0>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
        {
            public int <>1__state;
            public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
            public <>c__DisplayClass9_0 <>4__this;
            public AnnounceCategory category;
            private Awaiter<System.Collections.Generic.IReadOnlyList<PRISM.Adapters.AnnounceListItemViewModel>> <>u__1;
            private void MoveNext();
            private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=258 A16490E8A06E6B38F5E115457C786DCB886BE6262272622F7D9C98577F838905;
    private static __StaticArrayInitTypeSize=438 C8B6910C9299456B6A525FD58D5576FA7C45D03D767A66405C607A4D35CEFDA2;

    private struct __StaticArrayInitTypeSize=258 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=438 : System.ValueType
    {
    }
}
