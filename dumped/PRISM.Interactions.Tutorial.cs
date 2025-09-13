
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
public class TutorialMovieConnector : PRISM.Interactions.ViewConnector, PRISM.ITutorialMovieConnector
{
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
}

// Namespace: PRISM.Interactions
public class TutorialMovieView : UnityEngine.MonoBehaviour, PRISM.Adapters.ITutorialMovieView
{
    private PRISM.Interactions.FullScreenMovieView movieView;
    private PRISM.ITutorialSequence onFinishSequence;
    public Cysharp.Threading.Tasks.UniTask PlayAsync();

    private class <>c__DisplayClass2_0
    {
        public PRISM.Interactions.TutorialMovieView <>4__this;
        public PRISM.ITutorialSequenceContext context;
        private Cysharp.Threading.Tasks.UniTask <PlayAsync>b__0();
    }
}

// Namespace: PRISM.Interactions.Tutorial
public class TutorialProduceIdolSelectConfirmPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.Tutorial.ITutorialProduceIdolSelectConfirmPopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private PRISM.Interactions.ProduceIdolIconView produceIdolIconView;
    private ENTERPRISE.UI.UITextMeshProUGUI messageText;
    private ENTERPRISE.UI.UITextMeshProUGUI idolAliasText;
    private ENTERPRISE.UI.UITextMeshProUGUI idolNameText;
    private PRISM.Interactions.ButtonView detailButton;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public Cysharp.Threading.Tasks.UniTask<System.IDisposable> InitializeAsync(int mstProduceIdolId, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__9_0();
    private void <CreateFrameParameter>b__9_1();
    private void <CreateFrameParameter>b__9_2();

    private class <>c__DisplayClass8_0
    {
        public int mstProduceIdolId;
        public PRISM.Interactions.Tutorial.TutorialProduceIdolSelectConfirmPopupView <>4__this;
        private Cysharp.Threading.Tasks.UniTaskVoid <InitializeAsync>b__0(UniRx.Unit _);

        private struct <<InitializeAsync>b__0>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
        {
            public int <>1__state;
            public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
            public <>c__DisplayClass8_0 <>4__this;
            private Awaiter<PRISM.Module.Networking.IProduceIdolStatus> <>u__1;
            private void MoveNext();
            private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }

    private struct <InitializeAsync>d__8 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<System.IDisposable> <>t__builder;
        public int mstProduceIdolId;
        public PRISM.Interactions.Tutorial.TutorialProduceIdolSelectConfirmPopupView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        private System.IDisposable <disposable>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Tutorial
public class DisableOnClickSequence : PRISM.ITutorialSequence
{
    public Cysharp.Threading.Tasks.UniTask ExecuteAsync(PRISM.ITutorialSequenceContext context);
}

// Namespace: PRISM.Interactions.Tutorial
public class SequentialSequence : PRISM.ITutorialSequence
{
    private PRISM.ITutorialSequence[] subSequences;
    public Cysharp.Threading.Tasks.UniTask ExecuteAsync(PRISM.ITutorialSequenceContext context);

    private struct <ExecuteAsync>d__1 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Tutorial.SequentialSequence <>4__this;
        public PRISM.ITutorialSequenceContext context;
        private PRISM.ITutorialSequence[] <>7__wrap1;
        private int <>7__wrap2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Tutorial
public class ParallelSequence : PRISM.ITutorialSequence
{
    private PRISM.ITutorialSequence[] subSequences;
    public Cysharp.Threading.Tasks.UniTask ExecuteAsync(PRISM.ITutorialSequenceContext context);

    private class <>c__DisplayClass1_0
    {
        public PRISM.ITutorialSequenceContext context;
        private Cysharp.Threading.Tasks.UniTask <ExecuteAsync>b__0(PRISM.ITutorialSequence x);
    }
}

// Namespace: PRISM.Interactions.Tutorial
public class FocusSequence : PRISM.ITutorialSequence
{
    private PRISM.ITutorialSequence subSequence;
    private UnityEngine.Sprite unmaskSprite;
    private PRISM.ArrowPosition arrowPosition;
    private PRISM.ArrowType arrowType;
    private UnityEngine.Vector2 arrowOffsetPosition;
    private PRISM.AnnotationPosition annotationPosition;
    private string annotationMessage;
    public Cysharp.Threading.Tasks.UniTask ExecuteAsync(PRISM.ITutorialSequenceContext context);

    private struct <ExecuteAsync>d__7 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.ITutorialSequenceContext context;
        public PRISM.Interactions.Tutorial.FocusSequence <>4__this;
        private System.IDisposable <_>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Tutorial
public class LabelSequence : PRISM.ITutorialSequence
{
    public Cysharp.Threading.Tasks.UniTask ExecuteAsync(PRISM.ITutorialSequenceContext context);
}

// Namespace: PRISM.Interactions.Tutorial
public class PhaseConditionalSequence : PRISM.ITutorialSequence
{
    private Data[] dataList;
    public Cysharp.Threading.Tasks.UniTask ExecuteAsync(PRISM.ITutorialSequenceContext context);

    private struct Data : System.ValueType
    {
        public int Phase;
        public PRISM.ITutorialSequence Sequence;
    }
}

// Namespace: PRISM.Interactions.Tutorial
public class UpdatePhaseSequence : PRISM.ITutorialSequence
{
    private int targetPhase;
    public Cysharp.Threading.Tasks.UniTask ExecuteAsync(PRISM.ITutorialSequenceContext context);
}

// Namespace: PRISM.Interactions.Tutorial
public class FinishSequence : PRISM.ITutorialSequence
{
    public Cysharp.Threading.Tasks.UniTask ExecuteAsync(PRISM.ITutorialSequenceContext context);
}

// Namespace: PRISM.Interactions.Tutorial
public class PlayADVSequence : PRISM.ITutorialSequence
{
    private string scenarioId;
    public Cysharp.Threading.Tasks.UniTask ExecuteAsync(PRISM.ITutorialSequenceContext context);
}

// Namespace: PRISM.Interactions.Tutorial
public class PlaySESequence : PRISM.ITutorialSequence
{
    private string cueSheetName;
    private string cueName;
    public Cysharp.Threading.Tasks.UniTask ExecuteAsync(PRISM.ITutorialSequenceContext context);
}

// Namespace: PRISM.Interactions.Tutorial
public class JumpViewSequence : PRISM.ITutorialSequence
{
    private string typeName;
    public Cysharp.Threading.Tasks.UniTask ExecuteAsync(PRISM.ITutorialSequenceContext context);
}

// Namespace: PRISM.Interactions.Tutorial
public class ExecuteStaticMethodSequence : PRISM.ITutorialSequence
{
    private string typeName;
    private string methodName;
    private string[] arguments;
    public Cysharp.Threading.Tasks.UniTask ExecuteAsync(PRISM.ITutorialSequenceContext context);

    private class <>c__DisplayClass3_0
    {
        public PRISM.ITutorialSequenceContext context;
        public PRISM.Interactions.Tutorial.ExecuteStaticMethodSequence <>4__this;
        private object <ExecuteAsync>b__0(System.Reflection.ParameterInfo p, int i);
    }
}

// Namespace: PRISM.Interactions.Tutorial
public class SetTargetSequence : PRISM.ITutorialSequence
{
    private UnityEngine.RectTransform target;
    public Cysharp.Threading.Tasks.UniTask ExecuteAsync(PRISM.ITutorialSequenceContext context);
}

// Namespace: PRISM.Interactions.Tutorial
public class SetTargetByNameSequence : PRISM.ITutorialSequence
{
    private string objectName;
    public Cysharp.Threading.Tasks.UniTask ExecuteAsync(PRISM.ITutorialSequenceContext context);
}

// Namespace: PRISM.Interactions.Tutorial
public class SetTargetByClassNameSequence : PRISM.ITutorialSequence
{
    private string className;
    private bool includeInactive;
    private int index;
    public Cysharp.Threading.Tasks.UniTask ExecuteAsync(PRISM.ITutorialSequenceContext context);
}

// Namespace: PRISM.Interactions.Tutorial
public class SetTargetByChildNameSequence : PRISM.ITutorialSequence
{
    private string objectName;
    public Cysharp.Threading.Tasks.UniTask ExecuteAsync(PRISM.ITutorialSequenceContext context);
}

// Namespace: PRISM.Interactions.Tutorial
public class SetTargetByChildIndexSequence : PRISM.ITutorialSequence
{
    private int index;
    public Cysharp.Threading.Tasks.UniTask ExecuteAsync(PRISM.ITutorialSequenceContext context);
}

// Namespace: PRISM.Interactions.Tutorial
public class SetPopupButtonTargetSequence : PRISM.ITutorialSequence
{
    private string popupName;
    private int index;
    public Cysharp.Threading.Tasks.UniTask ExecuteAsync(PRISM.ITutorialSequenceContext context);

    private struct <ExecuteAsync>d__2 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Tutorial.SetPopupButtonTargetSequence <>4__this;
        public PRISM.ITutorialSequenceContext context;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Tutorial
public class ShowEndButtonSequence : PRISM.ITutorialSequence
{
    public Cysharp.Threading.Tasks.UniTask ExecuteAsync(PRISM.ITutorialSequenceContext context);
}

// Namespace: PRISM.Interactions.Tutorial
public class HideEndButtonSequence : PRISM.ITutorialSequence
{
    public Cysharp.Threading.Tasks.UniTask ExecuteAsync(PRISM.ITutorialSequenceContext context);
}

// Namespace: PRISM.Interactions.Tutorial
public class ShowHowToPlaySequence : PRISM.ITutorialSequence
{
    private string configRef;
    public Cysharp.Threading.Tasks.UniTask ExecuteAsync(PRISM.ITutorialSequenceContext context);
}

// Namespace: PRISM.Interactions.Tutorial
public class TextWindowSequence : PRISM.ITutorialSequence
{
    private string cueName;
    private string message;
    public Cysharp.Threading.Tasks.UniTask ExecuteAsync(PRISM.ITutorialSequenceContext context);

    private struct <ExecuteAsync>d__2 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.ITutorialSequenceContext context;
        public PRISM.Interactions.Tutorial.TextWindowSequence <>4__this;
        private System.IDisposable <_>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Tutorial
public enum ButtonTargetRelation : System.Enum
{
    public int value__;
    public static PRISM.Interactions.Tutorial.ButtonTargetRelation Child;
    public static PRISM.Interactions.Tutorial.ButtonTargetRelation Parent;
    public static PRISM.Interactions.Tutorial.ButtonTargetRelation Sibling;
    public static PRISM.Interactions.Tutorial.ButtonTargetRelation Uncle;
}

// Namespace: PRISM.Interactions.Tutorial
public class WaitButtonClickSequence : PRISM.ITutorialSequence
{
    private PRISM.Interactions.Tutorial.ButtonTargetRelation buttonTargetRelation;
    public Cysharp.Threading.Tasks.UniTask ExecuteAsync(PRISM.ITutorialSequenceContext context);

    private struct <ExecuteAsync>d__1 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.ITutorialSequenceContext context;
        public PRISM.Interactions.Tutorial.WaitButtonClickSequence <>4__this;
        private System.Collections.Generic.IEnumerator<UnityEngine.Transform> <>7__wrap1;
        private System.IDisposable <_>5__3;
        private Awaiter <>u__1;
        private Awaiter<UniRx.Unit> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Tutorial
public class WaitPopupButtonEnabledSequence : PRISM.ITutorialSequence
{
    public Cysharp.Threading.Tasks.UniTask ExecuteAsync(PRISM.ITutorialSequenceContext context);

    private class <>c__DisplayClass0_0
    {
        public PRISM.Interactions.PopupButton button;
        private bool <ExecuteAsync>b__0();
    }
}

// Namespace: PRISM.Interactions.Tutorial
public class WaitSecondsSequence : PRISM.ITutorialSequence
{
    private float seconds;
    public Cysharp.Threading.Tasks.UniTask ExecuteAsync(PRISM.ITutorialSequenceContext context);

    private struct <ExecuteAsync>d__1 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Tutorial.WaitSecondsSequence <>4__this;
        public PRISM.ITutorialSequenceContext context;
        private System.IDisposable <_>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Tutorial
public class WaitInputBlockReleaseSequence : PRISM.ITutorialSequence
{
    public Cysharp.Threading.Tasks.UniTask ExecuteAsync(PRISM.ITutorialSequenceContext context);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<bool> <>9__0_0;
        public static System.Func<bool> <>9__0_1;
        private bool <ExecuteAsync>b__0_0();
        private bool <ExecuteAsync>b__0_1();
    }

    private struct <ExecuteAsync>d__0 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.ITutorialSequenceContext context;
        private System.IDisposable <_>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Tutorial
public class WaitObjectEnableSequence : PRISM.ITutorialSequence
{
    private string objectName;
    private bool exists;
    public Cysharp.Threading.Tasks.UniTask ExecuteAsync(PRISM.ITutorialSequenceContext context);
    private bool <ExecuteAsync>b__2_0();

    private struct <ExecuteAsync>d__2 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Tutorial.WaitObjectEnableSequence <>4__this;
        public PRISM.ITutorialSequenceContext context;
        private System.IDisposable <_>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Tutorial
public class WaitVoiceFinishedSequence : PRISM.ITutorialSequence
{
    public Cysharp.Threading.Tasks.UniTask ExecuteAsync(PRISM.ITutorialSequenceContext context);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<bool> <>9__0_0;
        private bool <ExecuteAsync>b__0_0();
    }

    private struct <ExecuteAsync>d__0 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.ITutorialSequenceContext context;
        private System.IDisposable <_>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Tutorial
public class WaitScreenTapSequence : PRISM.ITutorialSequence
{
    public Cysharp.Threading.Tasks.UniTask ExecuteAsync(PRISM.ITutorialSequenceContext context);
}

// Namespace: PRISM.Interactions.Tutorial
public class TutorialFocusView : UnityEngine.MonoBehaviour
{
    private UnityEngine.Canvas canvas;
    private PRISM.Legacy.UISafeArea safeArea;
    private UnityEngine.UI.Image unmaskImage;
    private UnityEngine.Sprite unmaskDefaultSprite;
    private Coffee.UIExtensions.Unmask unmask;
    private UnityEngine.RectTransform arrow;
    private UnityEngine.RectTransform speechBubbleArrow;
    private float arrowWidth;
    private ENTERPRISE.UI.UITextMeshProUGUI annotationMessageText;
    private float annotationArrowDistanceX;
    private float annotationArrowDistanceY;
    public System.IDisposable CreateFocusScope(UnityEngine.RectTransform target, UnityEngine.Sprite unmaskSprite, PRISM.ArrowPosition arrowPosition, PRISM.ArrowType arrowType, UnityEngine.Vector2 arrowOffsetPosition, PRISM.AnnotationPosition annotationPosition, string annotationMessage);

    private class <>c
    {
        public static <>c <>9;
        public static System.Action<UnityEngine.GameObject> <>9__11_1;
        private void <CreateFocusScope>b__11_1(UnityEngine.GameObject x);
    }

    private class <>c__DisplayClass11_0
    {
        public PRISM.Interactions.Tutorial.TutorialFocusView <>4__this;
        public PRISM.ArrowType arrowType;
        public PRISM.ArrowPosition arrowPosition;
        public UnityEngine.Vector2 arrowOffsetPosition;
        public bool hasAnnotation;
        public float annotationHalfSizeX;
        public float annotationHalfSizeY;
        public PRISM.AnnotationPosition annotationPosition;
        public UnityEngine.RectTransform annotationRectTransform;
        private bool <CreateFocusScope>b__0();
        private void <CreateFocusScope>g__SetFingerArrow|2();
        private void <CreateFocusScope>g__SetSpeechBubbleArrow|3();
        private void <CreateFocusScope>g__ApplyAnnotationPosition|4();
        private void <CreateFocusScope>g__ApplyAnnotationPositionForSpeechBubble|5();
    }
}

// Namespace: PRISM.Interactions.Tutorial
public class TutorialTextWindowView : UnityEngine.MonoBehaviour
{
    private string cueSheetName;
    private float textDuration;
    private float withCharacterFramePositionX;
    private UnityEngine.GameObject character;
    private UnityEngine.RectTransform frame;
    private TMPro.TextMeshProUGUI text;
    private UnityEngine.GameObject next;
    private UnityEngine.UI.Button coverButton;
    public Cysharp.Threading.Tasks.UniTask ShowAsync(string message, string cueName, System.Threading.CancellationToken cancellationToken);
    public void Release();

    private struct <ShowAsync>d__8 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public string cueName;
        public PRISM.Interactions.Tutorial.TutorialTextWindowView <>4__this;
        public System.Threading.CancellationToken cancellationToken;
        public string message;
        private CriWare.CriAtomExPlayback <playback>5__2;
        private DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> <tween>5__3;
        private Awaiter <>u__1;
        private Awaiter<int> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Tutorial
public class TutorialView : UnityEngine.MonoBehaviour, PRISM.ITutorialView
{
    private UnityEngine.Canvas canvas;
    private PRISM.Interactions.Tutorial.TutorialFocusView focusView;
    private PRISM.Interactions.Tutorial.TutorialTextWindowView textWindowView;
    private ENTERPRISE.UI.UIButton screenTapButton;
    private ENTERPRISE.UI.UIButton tutorialEndTapButton;
    private PRISM.ITutorialSequence[] beginSequences;
    private PRISM.Interactions.UICanvasManager uiCanvasManager;
    private UnityEngine.RectTransform <Target>k__BackingField;
    public UnityEngine.RectTransform Target { get; set; }
    public System.IObservable<UniRx.Unit> OnEndButtonClicked { get; set; }
    public PRISM.ITutorialSequence GetBeginSequence(int category);
    public void Inject(PRISM.Interactions.UICanvasManager uiCanvasManager);
    public System.IDisposable CreateFocusScope(UnityEngine.Sprite unmaskSprite, PRISM.ArrowPosition arrowPosition, PRISM.ArrowType arrowType, UnityEngine.Vector2 arrowOffsetPosition, PRISM.AnnotationPosition annotationPosition, string annotationMessage);
    public Cysharp.Threading.Tasks.UniTask ShowTextWindowAsync(string message, string cueName, System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask WaitScreenTapAsync(System.Threading.CancellationToken cancellationToken);
    public void ShowTutorialEndTapButton();
    public void HideTutorialEndTapButton();
    public void Release();

    private struct <ShowTextWindowAsync>d__16 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Tutorial.TutorialView <>4__this;
        public string message;
        public string cueName;
        public System.Threading.CancellationToken cancellationToken;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <WaitScreenTapAsync>d__17 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Tutorial.TutorialView <>4__this;
        public System.Threading.CancellationToken cancellationToken;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=1527 CB0A010AB4CEA28652E9524A4D0D1BA8E04BAD15500F7B1A3B74F8589B7DE4E2;
    private static __StaticArrayInitTypeSize=1946 CDD3FED66A6FC78CBFF20ADB9611AB0881487C9AA1638116C86DB3E2F2C791C3;

    private struct __StaticArrayInitTypeSize=1527 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=1946 : System.ValueType
    {
    }
}
