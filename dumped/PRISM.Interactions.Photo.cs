
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
public class CameraScreenCapture : UnityEngine.MonoBehaviour
{
    private UnityEngine.Camera myCamera;
    private UnityEngine.RenderTexture capturedTexture;
    private UnityEngine.Material <CaptureMaterial>k__BackingField;
    public UnityEngine.Material CaptureMaterial { get; set; }
    public UnityEngine.Texture CapturedTexture { get; set; }
    public void Setup();
    public void Capture();
    public void SaveImage();
    public static string GetSaveDirectoryPath();
}

// Namespace: PRISM.Interactions
public class DebugArTestAlbumPanel : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.Button backgroundButton;
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.GameObject photoItem;
    private System.Collections.Generic.List<UnityEngine.GameObject> photoItems;
    private UnityEngine.UI.Button allDeleteButton;
    private string saveDirectoryPath;
    public void Setup(string saveDirectoryPath);
    public Cysharp.Threading.Tasks.UniTask OpenAsync();
    private static Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadImageAsync(string saveDirectoryPath, System.IO.FileInfo fileInfo);
    private void OnClickAllDelete();
    public void Close();
    private void Cleanup();

    private struct <LoadImageAsync>d__8 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<UnityEngine.Texture2D> <>t__builder;
        public string saveDirectoryPath;
        public System.IO.FileInfo fileInfo;
        private System.IO.FileStream <fs>5__2;
        private byte[] <bs>5__3;
        private System.Runtime.CompilerServices.TaskAwaiter<int> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <OpenAsync>d__7 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.DebugArTestAlbumPanel <>4__this;
        private System.IO.FileInfo[] <>7__wrap1;
        private int <>7__wrap2;
        private Awaiter<UnityEngine.Texture2D> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class PhotoAlbumGridView : FancyScrollView.FancyGridView<PRISM.Adapters.PhotoCellData, PRISM.Interactions.PhotoAlbumGridViewContext>
{
    private PRISM.Interactions.PhotoAlbumGridViewCell cellPrefab;
    protected UnityEngine.GameObject emptyView;
    public PRISM.Interactions.PhotoAlbumGridViewContext ViewContext { get; set; }
    private void OnDestroy();
    public void UpdateContents(System.Collections.Generic.IList<PRISM.Adapters.PhotoCellData> items);
    protected void SetupCellTemplate();

    private class CellGroup : DefaultCellGroup<PRISM.Adapters.PhotoCellData, PRISM.Interactions.PhotoAlbumGridViewContext>
    {
    }
}

// Namespace: PRISM.Interactions
public class PhotoAlbumGridViewCell : FancyScrollView.FancyGridViewCell<PRISM.Adapters.PhotoCellData, PRISM.Interactions.PhotoAlbumGridViewContext>
{
    private PRISM.Interactions.ButtonView button;
    private UnityEngine.UI.RawImage photoImage;
    private UnityEngine.UI.RawImage favoriteImage;
    private UnityEngine.GameObject selectorObject;
    private UniRx.CompositeDisposable disposables;
    public void UpdateContent(PRISM.Adapters.PhotoCellData data);
    private void OnDestroy();
    private void _setFavoriteMark(int favoriteId);
    private void <UpdateContent>b__5_0(UniRx.Unit _);
    private void <UpdateContent>b__5_1(int id);
    private void <UpdateContent>b__5_2(UniRx.Unit _);
}

// Namespace: PRISM.Interactions
public class PhotoAlbumGridViewContext : PRISM.Interactions.GridViewContext
{
    private UniRx.Subject<System.ValueTuple<PRISM.Definitions.PhotoAlbumFooterType, int>> onSelectSubject;
    private UniRx.Subject<UniRx.Unit> disableAllSelectorsSubject;
    private UniRx.Subject<int> onPhotoDetailSubject;
    private PRISM.Adapters.IPhotoCache photoCache;
    private System.Collections.Generic.IList<PRISM.Service.Photo.PhotoInfo> photoInfoList;
    private PRISM.Definitions.PhotoAlbumFooterType <FooterType>k__BackingField;
    public PRISM.Definitions.PhotoAlbumFooterType FooterType { get; set; }
    public System.IObservable<int> OnPhotoDetail { get; set; }
    public System.IObservable<System.ValueTuple<PRISM.Definitions.PhotoAlbumFooterType, int>> OnSelectIndex { get; set; }
    public System.IObservable<UniRx.Unit> DisableSelector { get; set; }
    public void Initialize(PRISM.Adapters.IPhotoCache photoCache);
    public UnityEngine.Texture2D GetPhoto(PRISM.Service.Photo.PhotoInfo info);
    public void OnSelectCell(int index);
    public void DisableAllSelectors();
    public void Dispose();
}

// Namespace: PRISM.Interactions
public class PhotoAlbumView : UnityEngine.MonoBehaviour, PRISM.Adapters.IPhotoAlbumView
{
    private UnityEngine.GameObject viewGameObject;
    private PRISM.Interactions.ButtonView backButton;
    private PRISM.Interactions.PhotoAlbumGridView gridView;
    public System.IObservable<UniRx.Unit> OnBack { get; set; }
    public System.IObservable<int> OnPhotoDetail { get; set; }
    public System.IObservable<System.ValueTuple<PRISM.Definitions.PhotoAlbumFooterType, int>> OnSelectCell { get; set; }
    public void Initialize(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Adapters.IPhotoCache photoCache);
    public void Show(System.Collections.Generic.IList<PRISM.Adapters.PhotoCellData> cellDataList);
    public void Hide();
}

// Namespace: PRISM.Interactions
public class PhotoCache : PRISM.Adapters.IPhotoCache, System.IDisposable
{
    private System.Collections.Generic.Dictionary<string, UnityEngine.Texture2D> photoCache;
    public UnityEngine.Texture2D Get(PRISM.Service.Photo.PhotoInfo info);
    public void Dispose();
}

// Namespace: PRISM.Interactions
public class PhotoDetailFocusListView : FancyScrollView.FancyScrollRect<PRISM.Adapters.PhotoCellData, PRISM.Interactions.PhotoDetailFocusListViewContext>
{
    private PRISM.Interactions.PhotoDetailFocusListViewCell cellPrefab;
    private float cellSize;
    private PRISM.Interactions.ButtonView leftArrowButton;
    private PRISM.Interactions.ButtonView rightArrowButton;
    private UnityEngine.RectTransform rectTransform;
    public PRISM.Interactions.PhotoDetailFocusListViewContext ViewContext { get; set; }
    protected UnityEngine.GameObject CellPrefab { get; set; }
    protected float CellSize { get; set; }
    private void OnDestroy();
    public void Initialize(System.Collections.Generic.IList<PRISM.Adapters.PhotoCellData> cellDataList, int focusListIndex);
    public void RebuildContents(System.Collections.Generic.IList<PRISM.Adapters.PhotoCellData> dataList, int focusListIndex);
    private void _moveLeftPhoto();
    private void _moveRightPhoto();
    private void _movePhoto(int newFocusIndex);
    private void _setActiveArrowButton();
    private void <Initialize>b__8_0(UniRx.Unit _);
    private void <Initialize>b__8_1(UniRx.Unit _);
    private void <Initialize>b__8_2(bool toRight);
}

// Namespace: PRISM.Interactions
public class PhotoDetailFocusListViewCell : FancyScrollView.FancyScrollRectCell<PRISM.Adapters.PhotoCellData, PRISM.Interactions.PhotoDetailFocusListViewContext>
{
    private UnityEngine.UI.RawImage photoImage;
    private PRISM.Interactions.ButtonView photoButton;
    private UnityEngine.UI.RawImage favoriteImage;
    private PRISM.Interactions.ButtonView favoriteButton;
    private UniRx.CompositeDisposable disposables;
    private void OnDestroy();
    public void UpdateContent(PRISM.Adapters.PhotoCellData data);
    protected void UpdatePosition(float normalizedPosition, float localPosition);

    private class <>c__DisplayClass6_0
    {
        public PRISM.Interactions.PhotoDetailFocusListViewCell <>4__this;
        public PRISM.Adapters.PhotoCellData data;
        private void <UpdateContent>b__0(UniRx.Unit _);
        private void <UpdateContent>b__1(UniRx.Unit _);
        private void <UpdateContent>b__2(int favoriteId);
    }
}

// Namespace: PRISM.Interactions
public class PhotoDetailFocusListViewContext : PRISM.Interactions.GridViewContext
{
    private UniRx.Subject<string> onSelectSubject;
    private UniRx.Subject<bool> moveFocusSubject;
    private UniRx.Subject<int> onFavoriteSubject;
    private PRISM.Adapters.IPhotoCache photoCache;
    private int <ListFocusCellIndex>k__BackingField;
    private int <DataCount>k__BackingField;
    public System.IObservable<string> OnSelectIndex { get; set; }
    public System.IObservable<bool> MoveFocus { get; set; }
    public System.IObservable<int> OnFavoriteMark { get; set; }
    public int ListFocusCellIndex { get; set; }
    public int DataCount { get; set; }
    public void Initialize(PRISM.Adapters.IPhotoCache photoCache);
    public UnityEngine.Texture2D GetPhoto(PRISM.Service.Photo.PhotoInfo info);
    public void UpdateData(int dataCount);
    public void OnSelectCell(int listIndex, PRISM.Adapters.PhotoCellData photoCellData);
    public void OnFavorite(int listIndex);
    public void Dispose();
}

// Namespace: PRISM.Interactions
public class PhotoDetailOverlayView : UnityEngine.MonoBehaviour, PRISM.Adapters.IPhotoDetailOverlayView, PRISM.Adapters.IClosableOverlayView<UniRx.Unit>, PRISM.Adapters.IOverlayView, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.ButtonView deleteButton;
    private PRISM.Interactions.ButtonView closeButton;
    private PRISM.Interactions.ButtonView shareButton;
    private PRISM.Interactions.PhotoDetailFocusListView listView;
    private UniRx.Subject<UniRx.Unit> closeRequestSubject;
    private System.Collections.Generic.List<PRISM.Adapters.PhotoCellData> adjustCellDataList;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public System.IObservable<string> OnSelected { get; set; }
    public System.IObservable<int> OnFavoriteMark { get; set; }
    public System.IObservable<int> OnDelete { get; set; }
    public System.IObservable<int> OnShare { get; set; }
    public Cysharp.Threading.Tasks.UniTask AssignAsync(System.Collections.Generic.IList<PRISM.Adapters.PhotoCellData> cellDataList, int selectedDataIndex, PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Adapters.IPhotoCache photoCache, System.Threading.CancellationToken ct);
    public void RemoveCell(int dataListIndex);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    private int <get_OnDelete>b__13_0(UniRx.Unit _);
    private int <get_OnShare>b__15_0(UniRx.Unit _);
    private void <ShowAsync>b__18_0(UniRx.Unit _);
}

// Namespace: PRISM.Interactions
public class PhotoView : UnityEngine.MonoBehaviour, PRISM.Adapters.IPhotoView
{
    private UnityEngine.GameObject cmnUIGameObject;
    private UnityEngine.GameObject cmnUIBackBtnGameObject;
    private UnityEngine.GameObject viewGameObject;
    private PRISM.Interactions.ButtonView situationModeButton;
    private PRISM.Interactions.ButtonView photoAlbumButton;
    public System.IObservable<UniRx.Unit> OnSituationMode { get; set; }
    public System.IObservable<UniRx.Unit> OnPhotoAlbum { get; set; }
    public void Show();
    public void Hide();
    public void ShowCmnUI(bool isCustomBack);
    public void HideCmnUI();
}

// Namespace: PRISM.Interactions
public class PhotoViewConnector : PRISM.Interactions.ViewConnector, PRISM.IPhotoViewConnector
{
}

// Namespace: PRISM.Interactions
public class SituationModeView : UnityEngine.MonoBehaviour, PRISM.Adapters.ISituationModeView
{
    private UnityEngine.GameObject viewGameObject;
    private UnityEngine.GameObject uiAreaGameObject;
    private PRISM.Interactions.ButtonView backButton;
    private PRISM.Interactions.ButtonView shootingButton;
    private PRISM.Interactions.ButtonView[] footerButtons;
    private PRISM.Interactions.ButtonView uiInactiveButton;
    private PRISM.Interactions.ButtonView uiActiveButton;
    private UnityEngine.UI.RawImage previewImage;
    private PRISM.Interactions.ButtonView previewButton;
    private bool showingUI;
    public System.IObservable<UniRx.Unit> OnBack { get; set; }
    public System.IObservable<UniRx.Unit> OnShooting { get; set; }
    public System.IObservable<PRISM.Definitions.SituationModeFooterButtonType> OnFooterButton { get; set; }
    public System.IObservable<UniRx.Unit> OnPhotoPreview { get; set; }
    public void Initialize();
    public void ShowPhotoPreview();
    public void Show();
    public void Hide();
    private void <Initialize>b__18_0(UniRx.Unit _);
    private void <Initialize>b__18_1(UniRx.Unit _);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Interactions.ButtonView, int, System.IObservable<PRISM.Definitions.SituationModeFooterButtonType>> <>9__15_0;
        private System.IObservable<PRISM.Definitions.SituationModeFooterButtonType> <get_OnFooterButton>b__15_0(PRISM.Interactions.ButtonView button, int index);
    }

    private class <>c__DisplayClass15_0
    {
        public int index;
        private PRISM.Definitions.SituationModeFooterButtonType <get_OnFooterButton>b__1(UniRx.Unit _);
    }
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=666 0C5E9C3C747AA8472E4220DC34CAB4FA90090767EA3DB3BB42C42A9ED975A101;
    private static __StaticArrayInitTypeSize=1046 FFA0CF9319E1A050825357738DA204E1F20D75FC735B93CF60AB45FA69253DDF;

    private struct __StaticArrayInitTypeSize=666 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=1046 : System.ValueType
    {
    }
}
