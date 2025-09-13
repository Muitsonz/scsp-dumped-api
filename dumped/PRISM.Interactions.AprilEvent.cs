
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
public class AprilPhotoCostumeChangeConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.AprilEvent.AprilPhotoArgument>, PRISM.Adapters.IAprilPhotoCostumeChangeConnector
{
    protected PRISM.Adapters.AprilEvent.AprilPhotoArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
}

// Namespace: PRISM.Interactions
public class AprilPhotoCostumeChangeView : UnityEngine.MonoBehaviour, PRISM.Adapters.IAprilPhotoCostumeChangeView
{
    private PRISM.Interactions.CostumeChange.CostumeChangeView costumeChangeView;
    public PRISM.Adapters.CostumeChange.ICostumeChangeView CostumeChangeView { get; set; }
}

// Namespace: PRISM.Interactions.AprilEvent
public class AprilEventSE
{
    public static string SheetName;
    public static PRISM.Definitions.SoundKey EventAprilMain;
    public static PRISM.Definitions.SoundKey EventAprilShutter;
}

// Namespace: PRISM.Interactions.AprilEvent
public class AprilEventTopConnector : PRISM.Interactions.ViewConnector, PRISM.Adapters.AprilEvent.IAprilEventTopConnector
{
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
}

// Namespace: PRISM.Interactions.AprilEvent
public class AprilEventTopView : UnityEngine.MonoBehaviour, PRISM.Adapters.AprilEvent.IAprilEventTopView
{
    private PRISM.Interactions.ButtonView photoButton;
    private PRISM.Interactions.ButtonView dressUpRoomButton;
    private PRISM.Interactions.ButtonView mvButton;
    private PRISM.Interactions.ButtonView shopButton;
    private PRISM.Interactions.ButtonView gashaButton;
    public System.IObservable<UniRx.Unit> OnJumpToPhoto { get; set; }
    public System.IObservable<UniRx.Unit> OnJumpToDressUpRoom { get; set; }
    public System.IObservable<UniRx.Unit> OnJumpToMV { get; set; }
    public System.IObservable<UniRx.Unit> OnJumpToShop { get; set; }
    public System.IObservable<UniRx.Unit> OnJumpToGasha { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(System.Threading.CancellationToken ct);
    public void Terminate();

    private struct <InitializeAsync>d__15 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.AprilEvent
public class AprilPhotoButtonMenuAnimation : PRISM.UIAnimation
{
    private EasingCore.Ease easeType;
    private float duration;
    private UnityEngine.Vector2 positionOffset;
    private UnityEngine.Vector2 sizeOffset;
    private UnityEngine.CanvasGroup canvasGroup;
    private float alphaOffset;
    private UnityEngine.RectTransform rectTransform;
    private UnityEngine.Vector2 fromPosition;
    private UnityEngine.Vector2 toPosition;
    private UnityEngine.Vector2 fromSize;
    private UnityEngine.Vector2 toSize;
    private float fromAlpha;
    private float toAlpha;
    private bool isReady;
    private bool isOpen;
    public float Duration { get; set; }
    private void Awake();
    public Cysharp.Threading.Tasks.UniTask PlayAsync(float delay, System.Threading.CancellationToken ct);
    private void _update(float r);
    public void Skip();

    private struct <PlayAsync>d__18 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.AprilEvent.AprilPhotoButtonMenuAnimation <>4__this;
        public float delay;
        public System.Threading.CancellationToken ct;
        private float <time>5__2;
        private EasingCore.EasingFunction <ease>5__3;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.AprilEvent
public class AprilPhotoConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.AprilEvent.AprilPhotoArgument>, PRISM.Adapters.AprilEvent.IAprilPhotoConnector
{
    protected PRISM.Adapters.AprilEvent.AprilPhotoArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
}

// Namespace: PRISM.Interactions.AprilEvent
public class AprilPhotoData : UnityEngine.ScriptableObject
{
    public float cameraZoomNear;
    public float cameraZoomFar;
    public float cameraScreenMinYNear;
    public float cameraScreenMinYFar;
    public float cameraScreenMaxYNear;
    public float cameraScreenMaxYFar;
    public float cameraScreenMinXNear;
    public float cameraScreenMinXFar;
    public float cameraScreenMaxXNear;
    public float cameraScreenMaxXFar;
    public float cameraRotateSpeedScaleY;
    public float cameraRotateSpeedScaleX;
    public float cameraSlideSpeedScale;
    public float cameraPinchSpeedScale;
}

// Namespace: PRISM.Interactions.AprilEvent
public class AprilPhotoScene : UnityEngine.MonoBehaviour
{
    private static float DefaultCameraDistance;
    private int characterId;
    private int clothId;
    private PRISM.CameraController mainCamera;
    private Cinemachine.CinemachineVirtualCamera cinemachineVirtualCamera;
    private PRISM.Scenario.ScenarioManager scenarioManager;
    private PRISM.Scenario.ScenarioManager scenarioManagerInstance;
    private UnityEngine.Material captureMaterial;
    private PRISM.HumanoidIKTarget humanoidIKTarget;
    private UnityEngine.UI.RawImage webCamRawImage;
    private UnityEngine.UI.RawImage characterFadeRawImage;
    private PRISM.Interactions.AprilEvent.TouchInputPanel touchInputPanel;
    private PRISM.Interactions.AprilEvent.AprilPhotoData data;
    private PRISM.Interactions.AprilEvent.CameraScreenCapture cameraScreenCapture;
    private UnityEngine.Vector2 shotPhotoPreviewRectTransformDefaultAnchoredPosition;
    private UnityEngine.RenderTexture characterFadeRenderTexture;
    private int inputLockCount;
    private bool <IsEnd>k__BackingField;
    private PRISM.Rendering.CameraRenderData <CameraRenderData>k__BackingField;
    private UnityEngine.WebCamTexture webCamTexture;
    private float _time;
    private PRISM.Character character;
    private EyeController[] eyes;
    private bool onClickFlag;
    private UniRx.Subject<UniRx.Unit> showUI;
    private int cameraIndex;
    private UnityEngine.WebCamDevice currentCameraDevice;
    private Cinemachine.CinemachineFramingTransposer cinemachineFramingTransposer;
    private Cinemachine.CinemachinePOV cinemachinePov;
    private float screenMinX;
    private float screenMaxX;
    private float screenMinY;
    private float screenMaxY;
    private UnityEngine.Canvas fadeCanvas;
    private bool <IsSetupCompleted>k__BackingField;
    private PRISM.Adapters.AprilEvent.AprilEventSessionData sessionData;
    private float pinchDistanceOld;
    private UnityEngine.Vector2 doubleTouchCenterPositionOld;
    public int CharacterId { get; set; }
    public int ClothId { get; set; }
    public PRISM.Interactions.AprilEvent.AprilPhotoData Data { get; set; }
    public bool IsEnd { get; set; }
    public PRISM.Rendering.CameraRenderData CameraRenderData { get; set; }
    public PRISM.Scenario.ScenarioManager ScenarioManagerInstance { get; set; }
    public bool IsSetupCompleted { get; set; }
    public System.IObservable<UniRx.Unit> ShowUI();
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.UnitIdol unitIdol, PRISM.Adapters.AprilEvent.AprilEventSessionData sessionData);
    public void ChangeCamera();
    private Cysharp.Threading.Tasks.UniTask _createWebCamTextureAsync(int targetCameraIndex);
    private Cysharp.Threading.Tasks.UniTask _downloadAsync(PRISM.UnitIdol idol);
    private Cysharp.Threading.Tasks.UniTask _popCharacterAsync(int characterId, int clothId);
    private Cysharp.Threading.Tasks.UniTask _popCharacterAsync(PRISM.UnitIdol idol);
    private static void _setupMagica(PRISM.Character character);
    private Cysharp.Threading.Tasks.UniTask _setupCharacterAsync(PRISM.UnitIdol idol);
    public Cysharp.Threading.Tasks.UniTask ChangeCharacterAsync(PRISM.UnitIdol unitIdol);
    private Cysharp.Threading.Tasks.UniTask _fadeOutCharacterAsync();
    private Cysharp.Threading.Tasks.UniTask _fadeInCharacterAsync();
    private void _updateScreenMinMaxY();
    private void _setCameraScreenClamped(float screenX, float screenY);
    private void Update();
    private void _updateWebCameraImageAspect();
    private void _updateIk();
    private void _updatePhotoImageReverse();
    public void ResetCameraPosture();
    private void _applyCameraHeightFromCharacterScale();
    public void SetMotion(string cueName);
    private void _onPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
    private void _onPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
    private void _onDrag(UnityEngine.EventSystems.PointerEventData eventData);
    private void _onDragRotateCamera(UnityEngine.Vector2 delta);
    private void _setCameraRotation(UnityEngine.Vector2 delta);
    private void _onDragSlideMoveCamera(UnityEngine.Vector2 doubleTouchCenterPosition);
    private UnityEngine.Vector2 _getDoubleTouchCenterPosition(UnityEngine.EventSystems.PointerEventData eventData);
    private void _onDragZoomCamera(float delta);
    private float _getPinchDistance();
    private bool _isSingleTap();
    private bool _isDoubleTap();
    public void Cleanup();
    private void _cleanupWebCamTexture();
    private bool <SetupAsync>b__56_1();
    private bool <SetupAsync>b__56_2();
    private bool <_createWebCamTextureAsync>b__58_0();
    private void <ResetCameraPosture>b__73_0(float f);
    private void <ResetCameraPosture>b__73_1(float f);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<bool> <>9__56_0;
        private bool <SetupAsync>b__56_0();
    }

    private struct <ChangeCharacterAsync>d__64 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.AprilEvent.AprilPhotoScene <>4__this;
        public PRISM.UnitIdol unitIdol;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <SetupAsync>d__56 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.AprilEvent.AprilPhotoScene <>4__this;
        public PRISM.Adapters.AprilEvent.AprilEventSessionData sessionData;
        public PRISM.UnitIdol unitIdol;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_createWebCamTextureAsync>d__58 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.AprilEvent.AprilPhotoScene <>4__this;
        public int targetCameraIndex;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_downloadAsync>d__59 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.UnitIdol idol;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_fadeInCharacterAsync>d__66 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.AprilEvent.AprilPhotoScene <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_fadeOutCharacterAsync>d__65 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.AprilEvent.AprilPhotoScene <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_popCharacterAsync>d__60 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public int characterId;
        public int clothId;
        public PRISM.Interactions.AprilEvent.AprilPhotoScene <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_popCharacterAsync>d__61 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.AprilEvent.AprilPhotoScene <>4__this;
        public PRISM.UnitIdol idol;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_setupCharacterAsync>d__63 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.AprilEvent.AprilPhotoScene <>4__this;
        public PRISM.UnitIdol idol;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.AprilEvent
public class AprilPhotoView : UnityEngine.MonoBehaviour, PRISM.Adapters.AprilEvent.IAprilPhotoView
{
    private PRISM.Interactions.ButtonView backButton;
    private PRISM.Interactions.ButtonView howToPlayButton;
    private PRISM.Interactions.ButtonView cameraResetButton;
    private PRISM.Interactions.ButtonView uiDisplayButton;
    private PRISM.Interactions.ButtonView changeCharacterButton;
    private PRISM.Interactions.ButtonView changeCostumeButton;
    private PRISM.Interactions.ButtonView changeCameraButton;
    private PRISM.Interactions.ButtonView poseButton;
    private PRISM.UIAnimation poseButtonAnimation;
    private float poseAnimationTimeout;
    private PRISM.Interactions.ButtonView[] poseTypeButtons;
    private PRISM.Interactions.ViewStateChanger selectedPoseTypeViewStateChanger;
    private PRISM.Interactions.ButtonView footerMenuButton;
    private PRISM.Interactions.ViewStateChanger footerMenuOpenCloseStateChanger;
    private PRISM.UIAnimation footerAnimation;
    private PRISM.Interactions.ButtonView shotButton;
    private UnityEngine.GameObject uiRoot;
    private UnityEngine.GameObject copyRightText;
    private UnityEngine.CanvasGroup cgBlackFade;
    private PRISM.HowToPlayPopupOpener howtoPlayPopupOpener;
    private PRISM.Interactions.AprilEvent.AprilPhotoScene aprilPhotoScene;
    private PRISM.SceneLoader sceneLoader;
    private UniRx.Subject<PRISM.Adapters.AprilEvent.PhotoPoseType> onPhotoPoseTypeSubject;
    private UniRx.Subject<UnityEngine.Texture2D> onShotSubject;
    private UniRx.Subject<UniRx.Unit> onBackSubject;
    private bool poseIsOpen;
    private UniRx.ReactiveProperty<bool> footerIsOpen;
    private PRISM.UnitIdol unitIdol;
    private bool isPlayingMotion;
    private Cysharp.Threading.Tasks.TimeoutController timeoutController;
    private System.Threading.CancellationTokenSource linkedCts;
    public System.IObservable<UniRx.Unit> OnChangeCharacterButton { get; set; }
    public System.IObservable<UniRx.Unit> OnChangeCostumeButton { get; set; }
    public System.IObservable<PRISM.Adapters.AprilEvent.PhotoPoseType> OnPhotoPoseType { get; set; }
    public System.IObservable<UnityEngine.Texture2D> OnShot { get; set; }
    public System.IObservable<UniRx.Unit> OnBack { get; set; }
    private void Awake();
    public Cysharp.Threading.Tasks.UniTask SetupAsync(UniRx.IReactiveProperty<PRISM.Adapters.AprilEvent.ChangeIdolData> idolData, PRISM.Adapters.AprilEvent.AprilEventSessionData sessionData);
    private void _onlyPauseUIEnable();
    public Cysharp.Threading.Tasks.UniTask PlayMotionAsync(string cueSheetName, string cueName);
    public Cysharp.Threading.Tasks.UniTask ReleaseAsync();
    private Cysharp.Threading.Tasks.UniTask _shotAsync();
    private bool <SetupAsync>b__42_0(UniRx.Unit _);
    private void <SetupAsync>b__42_1(UniRx.Unit _);
    private void <SetupAsync>b__42_2(UniRx.Unit _);
    private void <SetupAsync>b__42_3(UniRx.Unit _);
    private void <SetupAsync>b__42_4(UniRx.Unit _);
    private void <SetupAsync>b__42_5(UniRx.Unit _);
    private Cysharp.Threading.Tasks.UniTaskVoid <SetupAsync>b__42_6(PRISM.Adapters.AprilEvent.ChangeIdolData data);
    private Cysharp.Threading.Tasks.UniTaskVoid <SetupAsync>b__42_7(UniRx.Unit _);
    private void <SetupAsync>b__42_9(int index);
    private Cysharp.Threading.Tasks.UniTaskVoid <SetupAsync>b__42_10(UniRx.Unit _);
    private void <SetupAsync>b__42_11(bool b);
    private void <SetupAsync>b__42_12(UniRx.Unit _);
    private void <SetupAsync>b__42_13(UniRx.Unit _);

    private struct <<SetupAsync>b__42_10>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
        public PRISM.Interactions.AprilEvent.AprilPhotoView <>4__this;
        private System.IDisposable <__>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <<SetupAsync>b__42_6>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
        public PRISM.Interactions.AprilEvent.AprilPhotoView <>4__this;
        public PRISM.Adapters.AprilEvent.ChangeIdolData data;
        private System.IDisposable <_>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <<SetupAsync>b__42_7>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
        public PRISM.Interactions.AprilEvent.AprilPhotoView <>4__this;
        private System.IDisposable <__>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Interactions.ButtonView, int, System.IObservable<int>> <>9__42_8;
        public static System.Func<PRISM.Interactions.AprilEvent.AprilPhotoView, Status> <>9__44_0;
        public static System.Func<Status, bool> <>9__44_1;
        public static System.Func<Status, bool> <>9__44_2;
        private System.IObservable<int> <SetupAsync>b__42_8(PRISM.Interactions.ButtonView button, int i);
        private Status <PlayMotionAsync>b__44_0(PRISM.Interactions.AprilEvent.AprilPhotoView _);
        private bool <PlayMotionAsync>b__44_1(Status s);
        private bool <PlayMotionAsync>b__44_2(Status s);
    }

    private class <>c__DisplayClass42_0
    {
        public int i;
        private int <SetupAsync>b__14(UniRx.Unit _);
    }

    private struct <PlayMotionAsync>d__44 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.AprilEvent.AprilPhotoView <>4__this;
        public string cueSheetName;
        public string cueName;
        private Awaiter <>u__1;
        private Awaiter<Status> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <ReleaseAsync>d__45 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.AprilEvent.AprilPhotoView <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <SetupAsync>d__42 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.AprilEvent.AprilPhotoView <>4__this;
        public UniRx.IReactiveProperty<PRISM.Adapters.AprilEvent.ChangeIdolData> idolData;
        public PRISM.Adapters.AprilEvent.AprilEventSessionData sessionData;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_shotAsync>d__46 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.AprilEvent.AprilPhotoView <>4__this;
        private System.IDisposable <_>5__2;
        private System.IDisposable <__>5__3;
        private Awaiter <>u__1;
        private Awaiter <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.AprilEvent
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

// Namespace: PRISM.Interactions.AprilEvent
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
        public PRISM.Interactions.AprilEvent.DebugArTestAlbumPanel <>4__this;
        private System.IO.FileInfo[] <>7__wrap1;
        private int <>7__wrap2;
        private Awaiter<UnityEngine.Texture2D> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.AprilEvent
public class PhotoSaveConfirmationOverlayView : UnityEngine.MonoBehaviour, PRISM.Adapters.IPhotoSaveConfirmationOverlayView, PRISM.Adapters.IClosableOverlayView<UniRx.Unit>, PRISM.Adapters.IOverlayView, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private UnityEngine.UI.RawImage photoImage;
    private UnityEngine.UI.AspectRatioFitter aspectRatioFitter;
    private PRISM.Interactions.ButtonView disposeButton;
    private PRISM.Interactions.ButtonView shareButton;
    private PRISM.Interactions.ButtonView saveButton;
    private UniRx.Subject<UniRx.Unit> onCloseRequested;
    private UnityEngine.Texture2D photoTexture;
    private NativeShare share;
    private ENTERPRISE.Localization.LocalizationManager localizer;
    private string folderName;
    private string fileName;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    private Cysharp.Threading.Tasks.UniTask PRISM.Adapters.IOverlayView.ShowAsync(System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask PRISM.Adapters.IOverlayView.HideAsync();
    public void Assign(UnityEngine.Texture2D tex);
    private void _closeRequest();
    private Cysharp.Threading.Tasks.UniTask _shareAsync();
    private Cysharp.Threading.Tasks.UniTask _saveAsync();
    private void <Assign>b__15_0(UniRx.Unit _);
    private void <Assign>b__15_1(UniRx.Unit _);
    private void <Assign>b__15_2(UniRx.Unit _);

    private class <>c__DisplayClass18_0
    {
        public System.Nullable<bool> success;
        private void <_saveAsync>b__0(bool isSuccess, string _);
        private bool <_saveAsync>b__1();
    }

    private struct <PRISM-Adapters-IOverlayView-ShowAsync>d__13 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_saveAsync>d__18 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.AprilEvent.PhotoSaveConfirmationOverlayView <>4__this;
        private <>c__DisplayClass18_0 <>8__1;
        private Cysharp.Threading.Tasks.TimeoutController <timeoutController>5__2;
        private System.Threading.CancellationTokenSource <linkedTokenSource>5__3;
        private int <>7__wrap3;
        private Permission <permission>5__5;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_shareAsync>d__17 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.AprilEvent.PhotoSaveConfirmationOverlayView <>4__this;
        private Awaiter<System.ValueTuple<ShareResult, string>> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.AprilEvent
public class TouchInputPanel : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerUpHandler, UnityEngine.EventSystems.IDragHandler
{
    public System.Action<UnityEngine.EventSystems.PointerEventData> onPointerDown;
    public System.Action<UnityEngine.EventSystems.PointerEventData> onPointerUp;
    public System.Action<UnityEngine.EventSystems.PointerEventData> onDrag;
    public void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
    public void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
    public void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=727 0E5CA15EB67119766478FBD8FDE8564025664B89D4DB4DBDFDEC534FB858C403;
    private static __StaticArrayInitTypeSize=1108 2A1F2D57E5307A3C1A3443026B4861021B802369B9ECF3789565B3F56B603B38;

    private struct __StaticArrayInitTypeSize=727 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=1108 : System.ValueType
    {
    }
}
