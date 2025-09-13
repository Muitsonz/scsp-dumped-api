
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
public class DressUpRoom3DViewer : UnityEngine.MonoBehaviour, PRISM.Adapters.IDressUpRoom3DViewer, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IPointerUpHandler, UnityEngine.EventSystems.IScrollHandler
{
    private float cameraRotateSensitivity;
    private float cameraMoveSensitivity;
    private PRISM.Common.CharacterSpeechBalloonView speechBalloonView;
    private float cameraPinchZoomSensitivity;
    private float cameraMouseZoomSensitivity;
    private float maxCameraPositionY;
    private float minCameraPositionY;
    private float maxFov;
    private float minFov;
    private float maxLookDownAngle;
    private PRISM.Legacy.UISafeArea viewerSafeArea;
    private PRISM.Scenario.ScenarioManager scenarioManager;
    private PRISM.Legacy.SimpleModel3dLoader model3dLoader;
    private UniRx.Subject<UniRx.Unit> onEndPlayingVoice;
    private UniRx.Subject<UniRx.Unit> on3DModelClick;
    private UniRx.Subject<UniRx.Unit> onPinch;
    private UniRx.Subject<UniRx.Unit> onSwipe;
    private UniRx.Subject<UniRx.Unit> onScroll;
    private UniRx.Subject<bool> showUI;
    private string charaName;
    private System.IDisposable playingVoiceDisposable;
    private bool onClickFlag;
    private int clickCount;
    private float currentFov;
    private float currentCameraPositionY;
    private float currentCameraDollyEndpointY;
    private float baseDistanceOfCameraAndIdol;
    private float dollyOutMaxDistance;
    private float tapAreaMinX;
    private float tapAreaMaxX;
    private float tapAreaBaseMinX;
    private float tapAreaBaseMaxX;
    private float screenWidthInSafeArea;
    private float tapAreaCurrentMinX;
    private float tapAreaCurrentMaxX;
    private float tapAreaMinY;
    private float widthInSafeAreaOneTwelfth;
    private float screenWidthHalf;
    private float _fovPosYCoefficient;
    public bool PlayingVoice { get; set; }
    public System.IObservable<UniRx.Unit> OnEndPlayingVoice { get; set; }
    public System.IObservable<UniRx.Unit> On3DModelClick { get; set; }
    public System.IObservable<bool> ShowUI { get; set; }
    public System.IObservable<UniRx.Unit> OnPinch { get; set; }
    public System.IObservable<UniRx.Unit> OnSwipe { get; set; }
    public System.IObservable<UniRx.Unit> OnScrolled { get; set; }
    private void Awake();
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.UnitIdol unitIdol, string charaName);
    public Cysharp.Threading.Tasks.UniTask PlayVoiceMessageAsync(string cueName, int voiceResourceId, System.Threading.CancellationToken ct, float delay);
    private void _onSwipe(UnityEngine.Vector2 vector);
    private void _onPinch(float amount);
    private float _calcMinCameraPosition(float fov);
    private void _setCameraAngleX(float fov, float cameraPosY);
    public void ResetCamera();
    public void OnNextViewPreparation();
    public Cysharp.Threading.Tasks.UniTask ReleaseAsync();
    public void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
    public void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
    private bool _inVoicePlaybackArea(UnityEngine.EventSystems.PointerEventData eventData);
    public void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
    public void OnScroll(UnityEngine.EventSystems.PointerEventData eventData);
    private Cysharp.Threading.Tasks.UniTaskVoid <PlayVoiceMessageAsync>b__55_3(Status _);
    private Cysharp.Threading.Tasks.UniTask <OnPointerDown>b__63_0();
    private void <OnDrag>g__InvokeOnSwipe|66_0(UnityEngine.EventSystems.PointerEventData pointerEventData);

    private struct <<OnPointerDown>b__63_0>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.DressUpRoom3DViewer <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <<PlayVoiceMessageAsync>b__55_3>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
        public PRISM.Interactions.DressUpRoom3DViewer <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Interactions.DressUpRoom3DViewer, Status> <>9__55_0;
        public static System.Func<Status, bool> <>9__55_1;
        public static System.Func<Status, bool> <>9__55_2;
        private Status <PlayVoiceMessageAsync>b__55_0(PRISM.Interactions.DressUpRoom3DViewer _);
        private bool <PlayVoiceMessageAsync>b__55_1(Status s);
        private bool <PlayVoiceMessageAsync>b__55_2(Status s);
    }

    private class <>c__DisplayClass54_0
    {
        public PRISM.LiveCharacterController liveCharacterController;
        private bool <SetupAsync>b__0();
    }

    private struct <PlayVoiceMessageAsync>d__55 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.DressUpRoom3DViewer <>4__this;
        public float delay;
        public System.Threading.CancellationToken ct;
        public int voiceResourceId;
        public string cueName;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <SetupAsync>d__54 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.DressUpRoom3DViewer <>4__this;
        public string charaName;
        public PRISM.UnitIdol unitIdol;
        private <>c__DisplayClass54_0 <>8__1;
        private PRISM.UnitIdol[] <unitIdols>5__2;
        private Cysharp.Threading.Tasks.UniTask <charaTask>5__3;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class DressUpRoomCommonView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView globalMenuButton;
    private PRISM.Interactions.ButtonView backButton;
    private PRISM.Interactions.CommonTitleView titleView;
    private PRISM.HowToPlayPopupOpener howToPlayPopupOpener;
    public System.IObservable<UniRx.Unit> OnClickBack { get; set; }
    public void Show();

    private class <>c__DisplayClass6_0
    {
        public System.Threading.CancellationToken ct;
        public PRISM.Interactions.DressUpRoomCommonView <>4__this;
        private void <Show>b__0(UniRx.Unit _);
        private void <Show>b__1(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions
public class DressUpRoomConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.DressUpRoomArgument>, PRISM.IDressUpRoomConnector
{
    protected PRISM.Adapters.DressUpRoomArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
}

// Namespace: PRISM.Interactions
public class DressUpRoomCostumeChangeView : UnityEngine.MonoBehaviour, PRISM.Adapters.IDressUpRoomCostumeChangeView
{
    private PRISM.Interactions.DressUpRoomCommonView commonView;
    private PRISM.Interactions.CostumeChange.CostumeChangeView costumeChangeView;
    public PRISM.Adapters.CostumeChange.ICostumeChangeView CostumeChangeView { get; set; }
    public System.IObservable<UniRx.Unit> OnBack { get; set; }
    public void Show();
}

// Namespace: PRISM.Interactions
public class DressUpRoomTopView : UnityEngine.MonoBehaviour, PRISM.Adapters.IDressUpRoomTopView
{
    private PRISM.Interactions.DressUpRoomCommonView commonView;
    private PRISM.Interactions.DressUpRoom3DViewer characterView;
    private PRISM.Interactions.ButtonView cameraResetButton;
    private PRISM.Interactions.ButtonView switchUIDisplayButton;
    private PRISM.Interactions.ButtonView selectIdolButton;
    private PRISM.Interactions.ButtonView selectCostumeButton;
    private UnityEngine.CanvasGroup topViewUIArea;
    private bool isUIDisplayed;
    private UniRx.Subject<bool> onSwitchUIDisplay;
    public PRISM.Adapters.IDressUpRoom3DViewer CharacterView { get; set; }
    public System.IObservable<UniRx.Unit> OnCameraReset { get; set; }
    public System.IObservable<bool> OnSwitchUIDisplay { get; set; }
    public System.IObservable<UniRx.Unit> OnSelectIdol { get; set; }
    public System.IObservable<UniRx.Unit> OnSelectCostume { get; set; }
    private void Awake();
    public void Setup();
    public void HideUI();
    public void ShowUI();
    private Cysharp.Threading.Tasks.UniTask _fadeUIAsync(bool isFadeOut);
    private void <Setup>b__20_0(UniRx.Unit _);
    private void <Setup>b__20_1(UniRx.Unit _);

    private struct <_fadeUIAsync>d__23 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public bool isFadeOut;
        public PRISM.Interactions.DressUpRoomTopView <>4__this;
        private System.IDisposable <_>5__2;
        private TweenAwaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class DressUpRoomView : UnityEngine.MonoBehaviour, PRISM.Adapters.IDressUpRoomView, System.IDisposable
{
    private UnityEngine.Transform childViewParent;
    private PRISM.Interactions.DressUpRoomTopView topViewPrefab;
    private PRISM.Interactions.DressUpRoomCostumeChangeView costumeChangeViewPrefab;
    private PRISM.Interactions.ScreenTransitionCurtain curtain;
    private UnityEngine.CanvasGroup cgIdolChangeFader;
    private UnityEngine.GameObject childView;
    public void Awake();
    public Cysharp.Threading.Tasks.UniTask SetupAsync();
    public PRISM.Adapters.IDressUpRoomTopView InstantiateTopView();
    public PRISM.Adapters.IDressUpRoomCostumeChangeView InstantiateCostumeChangeView();
    public Cysharp.Threading.Tasks.UniTask CloseCurtainAsync();
    public Cysharp.Threading.Tasks.UniTask OpenCurtainAsync();
    public Cysharp.Threading.Tasks.UniTask FadeOutAsync();
    public Cysharp.Threading.Tasks.UniTask FadeInAsync();
    private void _destroyChildView();
    public void Dispose();

    private struct <FadeInAsync>d__13 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.DressUpRoomView <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class ScreenTransitionCurtain : UnityEngine.MonoBehaviour
{
    private UnityEngine.Animator anim;
    public Cysharp.Threading.Tasks.UniTask CloseAsync();
    public Cysharp.Threading.Tasks.UniTask OpenAsync();
}

// Namespace: PRISM.Interactions
public class DressUpRoomSE
{
    public static string SheetName;
    public static PRISM.Definitions.SoundKey CloseCurtain;
    public static PRISM.Definitions.SoundKey OpenCurtain;
}

// Namespace: PRISM.Interactions
public class FittingRoomConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.FittingRoomArgument>, PRISM.IFittingRoomConnector
{
    protected PRISM.Adapters.FittingRoomArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
}

// Namespace: PRISM.Interactions
public class FittingRoomView : UnityEngine.MonoBehaviour, PRISM.Adapters.IFittingRoomView
{
    private UnityEngine.CanvasGroup cgBlackFade;
    private PRISM.Legacy.SimpleModel3dLoader model3dLoader;
    private PRISM.Scenario.ScenarioManager scenarioManager;
    private System.Threading.CancellationTokenSource cts;
    private void Awake();
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.UnitIdol unitIdol);
    public Cysharp.Threading.Tasks.UniTask PerformanceAsync(string cueName);
    public Cysharp.Threading.Tasks.UniTask ReleaseAsync();
    private bool <PerformanceAsync>b__6_0();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<bool> <>9__6_1;
        private bool <PerformanceAsync>b__6_1();
    }

    private class <>c__DisplayClass5_0
    {
        public PRISM.LiveCharacterController liveCharacterController;
        private bool <SetupAsync>b__0();
    }

    private struct <PerformanceAsync>d__6 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.FittingRoomView <>4__this;
        public string cueName;
        private Cysharp.Threading.Tasks.UniTask <motionTask>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <SetupAsync>d__5 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.FittingRoomView <>4__this;
        public PRISM.UnitIdol unitIdol;
        private <>c__DisplayClass5_0 <>8__1;
        private PRISM.UnitIdol[] <unitIdols>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=870 FD922BA1BA1A25D73168E82FC9F86C87BAB00AB1D59F0B5F3646A8C06163615D;
    private static __StaticArrayInitTypeSize=432 FF81545CD1C38E1C59E68FE34AA113688614F98DE29D6ADF09550341F50493EA;

    private struct __StaticArrayInitTypeSize=432 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=870 : System.ValueType
    {
    }
}
