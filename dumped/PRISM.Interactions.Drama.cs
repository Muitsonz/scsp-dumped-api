
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
public class DramaLogOverlayView : PRISM.Interactions.OverlayViewWithCloseButton, PRISM.Adapters.IDramaLogOverlayView, PRISM.Adapters.IClosableOverlayView<UniRx.Unit>, PRISM.Adapters.IOverlayView, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private ENTERPRISE.UI.UITextMeshProUGUI scenarioTitleText;
    private PRISM.Interactions.Drama.UI.DramaLogCellScrollerView scrollerView;
    private PRISM.Interactions.ButtonView howToPlayButton;
    public void Initialize(string scenarioTitle, System.Collections.Generic.IReadOnlyList<PRISM.Adapters.Drama.UI.DramaLogCellViewModel> cellViewModels, PRISM.Adapters.Drama.IDramaScene dramaScene, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public Cysharp.Threading.Tasks.UniTask HideAsync();

    private class <>c__DisplayClass3_0
    {
        public PRISM.Adapters.Drama.IDramaScene dramaScene;
        public PRISM.Interactions.DramaLogOverlayView <>4__this;
        private void <Initialize>b__0(double time);
        private void <Initialize>b__1(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions
public class DramaSettingsPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.Drama.UI.IDramaSettingsPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.Drama.DramaSettingsPanelView panelView;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Initialize(PRISM.Adapters.Drama.UI.IDramaSettingsPanelViewModel viewModel);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__5_0();
    private void <CreateFrameParameter>b__5_1();
}

// Namespace: PRISM.Interactions.Sujigaki
public class SujigakiLineMixerBehaviour : PRISM.Interactions.Sujigaki.TimingMixerBehaviour
{
}

// Namespace: PRISM.Interactions.Sujigaki
public class SujigakiLinePlayableAsset : UnityEngine.Playables.PlayableAsset, UnityEngine.Timeline.ITimelineClipAsset, PRISM.Interactions.Drama.ITimingPlayableAsset
{
    public PRISM.Interactions.Sujigaki.SujigakiLinePlayableBehaviour behaviour;
    public UnityEngine.Timeline.ClipCaps clipCaps { get; set; }
    public PRISM.Interactions.Sujigaki.TimingPlayableBehaviour GetBehaviour();
    public UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go);
    public bool IsExistTimingLink(UnityEngine.Timeline.TimelineClip clip);
    public void AddTimingLinkClip(UnityEngine.Timeline.TimelineClip clip);
    public PRISM.Interactions.Sujigaki.SujigakiLinePlayableActing GetActing(string charaName);
    public UnityEngine.Timeline.TimelineClip GetDirectionActivationClip();
    public UnityEngine.Timeline.TimelineClip GetDirectionCinemachineClip();
    public UnityEngine.Timeline.TimelineClip GetDirectionFadeClip();
    public UnityEngine.Timeline.TimelineClip GetDirectionCrossFadeClip();
    public UnityEngine.Timeline.TimelineClip GetDirectionAudioClip();
}

// Namespace: PRISM.Interactions.Sujigaki
public class SerializeClip
{
    public UnityEngine.Timeline.TrackAsset parentTrack;
    public UnityEngine.Playables.PlayableAsset asset;
    private UnityEngine.Timeline.TimelineClip cachedClip;
    public UnityEngine.Timeline.TimelineClip GetClip();
    public bool IsValidAsset();
    private UnityEngine.Timeline.TimelineClip _searchClip();
}

// Namespace: PRISM.Interactions.Sujigaki
public class SujigakiLinePlayableActing
{
    public string name;
    public string facialAnimationName;
    public string bodyAnimationName;
    public bool lipSync;
    public int lookAtTargetAssetModelId;
    public string lookAtTargetName;
    public PRISM.Interactions.Sujigaki.SerializeClip facialAnimationClip;
    public PRISM.Interactions.Sujigaki.SerializeClip bodyAnimationClip;
    public PRISM.Interactions.Sujigaki.SerializeClip lipAnimationClip;
    public void DeleteFacialAnimationClip();
    public void DeleteBodyAnimationClip();
    public void DeleteLipAnimationClip();
}

// Namespace: PRISM.Interactions.Sujigaki
public class SujigakiLinePlayableText
{
    public string talkerName;
    public string displayTalkerName;
    public string message;
    public string cueName;
    public PRISM.Interactions.Sujigaki.SerializeClip textClip;
    public PRISM.Interactions.Sujigaki.SerializeClip voiceAudioClip;
}

// Namespace: PRISM.Interactions.Sujigaki
public class SujigakiLinePlayableAudio
{
    public string cueName;
    public PRISM.Interactions.Sujigaki.SerializeClip voiceAudioClip;
    public bool IsEmpty();
}

// Namespace: PRISM.Interactions.Sujigaki
public class SujigakiLinePlayableDirection
{
    public Sujigaki.SujigakiEpisodeLineDirectionStageType stageType;
    public PRISM.Interactions.Sujigaki.SerializeClip fadeClip;
    public PRISM.Interactions.Sujigaki.SerializeClip crossFadeClip;
    public PRISM.Interactions.Sujigaki.SerializeClip activationClip;
    public PRISM.Interactions.Sujigaki.SerializeClip animationClip;
    public PRISM.Interactions.Sujigaki.SerializeClip cinemachineClip;
    public PRISM.Interactions.Sujigaki.SerializeClip audioClip;
}

// Namespace: PRISM.Interactions.Sujigaki
public class SujigakiLinePlayableChoicePair
{
    public string text;
    public string label;
}

// Namespace: PRISM.Interactions.Sujigaki
public class SujigakiLinePlayableChoice
{
    public System.Collections.Generic.List<PRISM.Interactions.Sujigaki.SujigakiLinePlayableChoicePair> pairs;
}

// Namespace: PRISM.Interactions.Sujigaki
public class SujigakiLinePlayableLabel
{
    public string value;
}

// Namespace: PRISM.Interactions.Sujigaki
public class SujigakiLinePlayableJump
{
    public string label;
}

// Namespace: PRISM.Interactions.Sujigaki
public class TimingLink
{
    public double startOffset;
    public double endOffset;
    public PRISM.Interactions.Sujigaki.SerializeClip clip;
}

// Namespace: PRISM.Interactions.Sujigaki
public class SujigakiLinePlayableBehaviour : PRISM.Interactions.Sujigaki.TimingPlayableBehaviour
{
    public string uniqueId;
    public Sujigaki.SujigakiEpisodeLineType type;
    public PRISM.Interactions.Sujigaki.SujigakiLinePlayableText text;
    public PRISM.Interactions.Sujigaki.SujigakiLinePlayableAudio audio;
    public System.Collections.Generic.List<PRISM.Interactions.Sujigaki.SujigakiLinePlayableActing> actings;
    public PRISM.Interactions.Sujigaki.SujigakiLinePlayableDirection direction;
    public PRISM.Interactions.Sujigaki.SujigakiLinePlayableChoice choice;
    public PRISM.Interactions.Sujigaki.SujigakiLinePlayableLabel label;
    public PRISM.Interactions.Sujigaki.SujigakiLinePlayableJump jump;
    public PRISM.Interactions.Sujigaki.SujigakiLinePlayableActing GetActing(string charaName);

    private class <>c__DisplayClass9_0
    {
        public string charaName;
        private bool <GetActing>b__0(PRISM.Interactions.Sujigaki.SujigakiLinePlayableActing a);
    }
}

// Namespace: PRISM.Interactions.Sujigaki
public class SujigakiLineTrack : UnityEngine.Timeline.TrackAsset
{
    private PRISM.Interactions.Sujigaki.SujigakiLineMixerBehaviour mixerBehaviour;
    public UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner, int inputCount);
}

// Namespace: PRISM.Interactions.Sujigaki
public class TimingMixerBehaviour : UnityEngine.Playables.PlayableBehaviour
{
    private UnityEngine.Timeline.TimelineClip[] clips;
    public void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, object playerData);
}

// Namespace: PRISM.Interactions.Sujigaki
public class TimingPlayableAsset : UnityEngine.Playables.PlayableAsset, UnityEngine.Timeline.ITimelineClipAsset, PRISM.Interactions.Drama.ITimingPlayableAsset
{
    public PRISM.Interactions.Sujigaki.TimingPlayableBehaviour behaviour;
    public UnityEngine.Timeline.ClipCaps clipCaps { get; set; }
    public PRISM.Interactions.Sujigaki.TimingPlayableBehaviour GetBehaviour();
    public UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go);
    public bool IsExistTimingLink(UnityEngine.Timeline.TimelineClip clip);
    public void AddTimingLinkClip(UnityEngine.Timeline.TimelineClip clip);
}

// Namespace: PRISM.Interactions.Sujigaki
public class TimingPlayableBehaviour : UnityEngine.Playables.PlayableBehaviour
{
    public System.Collections.Generic.List<PRISM.Interactions.Sujigaki.TimingLink> startTimingLinks;
    public System.Collections.Generic.List<PRISM.Interactions.Sujigaki.TimingLink> timingLinks;
    public System.Collections.Generic.List<PRISM.Interactions.Sujigaki.TimingLink> endTimingLinks;
    public bool IsExistTimingLink(UnityEngine.Timeline.TimelineClip clip);
    public void AddTimingLinkClip(UnityEngine.Timeline.TimelineClip clip);
}

// Namespace: PRISM.Interactions.Sujigaki
public class TimingTrack : UnityEngine.Timeline.TrackAsset
{
    private PRISM.Interactions.Sujigaki.TimingMixerBehaviour mixerBehaviour;
    public UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner, int inputCount);
}

// Namespace: PRISM.Interactions.Drama
public class DramaLauncherConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.Drama.IDramaLauncherArgument>, PRISM.Legacy.Drama.IDramaLauncherConnector
{
    protected PRISM.Adapters.Drama.IDramaLauncherArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
}

// Namespace: PRISM.Interactions.Drama
public class DramaLauncherView : UnityEngine.MonoBehaviour, PRISM.Adapters.Drama.IDramaLauncherView
{
    private PRISM.SceneLoader sceneLoader;
    private PRISM.Interactions.Drama.DramaScene dramaScene;
    private PRISM.Adapters.Drama.IDramaLauncherArgument argument;
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Adapters.Drama.IDramaLauncherArgument argument);
    public Cysharp.Threading.Tasks.UniTask PlayAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask ReleaseAsync();
    private bool <PlayAsync>b__4_0();

    private struct <ReleaseAsync>d__5 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Drama.DramaLauncherView <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <SetupAsync>d__3 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Drama.DramaLauncherView <>4__this;
        public PRISM.Adapters.Drama.IDramaLauncherArgument argument;
        private object <>7__wrap1;
        private int <>7__wrap2;
        private System.Exception <e>5__4;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Drama
public class DramaScene : UnityEngine.MonoBehaviour, PRISM.Adapters.Drama.IDramaScene
{
    public static string ForEditorGroupTrackName;
    public static string FaceAnimationTrackName;
    public static string BodyAnimationTrackName;
    private PRISM.Interactions.TimelineScene timelineScene;
    private UnityEngine.Playables.PlayableDirector director;
    private PRISM.CameraController mainCamera;
    private UnityEngine.Rendering.Volume volume;
    private UnityEngine.RuntimeAnimatorController facialAnimatorController;
    private UnityEngine.GameObject faceKeyControllerObject;
    private Render3DManager render3DManager;
    private PRISM.Interactions.Drama.DramaSceneText text;
    private PRISM.RawImage4Normals fadeRawImage;
    private UnityEngine.Transform bgModelRoot;
    private UnityEngine.Transform characterRoot;
    private UnityEngine.Transform propsRoot;
    private UnityEngine.Transform cinemachineCameraRoot;
    private UnityEngine.Transform effectRoot;
    private UnityEngine.Transform audioRoot;
    private MagicaCloth2.MagicaWindZone windZone;
    private UnityEngine.UI.RawImage captureImage;
    private PRISM.Interactions.Drama.DramaChoiceButtonGroupView choiceGroup;
    private UnityEngine.Transform uiViewRoot;
    private PRISM.Interactions.Drama.UI.DramaSubtitleView subtitleView;
    private UnityEngine.Camera uiCamera;
    private PRISM.Interactions.Drama.DramaSceneDebugInformation debugInformation;
    private PRISM.Interactions.Drama.DramaSceneForEditorPreview forEditorPreview;
    private PRISM.Interactions.Drama.DramaSceneHandler handler;
    private bool <IsInitializationCompleted>k__BackingField;
    public UnityEngine.UI.RawImage CaptureImage { get; set; }
    public UnityEngine.Camera UiCamera { get; set; }
    public PRISM.Interactions.Drama.DramaSceneDebugInformation DebugInformation { get; set; }
    public bool IsInitializationCompleted { get; set; }
    public PRISM.Interactions.TimelineScene TimelineScene { get; set; }
    public PRISM.Interactions.Drama.DramaSceneForEditorPreview ForEditorPreview { get; set; }
    public UnityEngine.Playables.PlayableDirector Director { get; set; }
    public PRISM.Adapters.Drama.IDramaSceneOperationHandler OperationHandler { get; set; }
    public PRISM.Adapters.Drama.IDramaSceneTimeHandler TimeHandler { get; set; }
    public PRISM.Adapters.Drama.IDramaSceneChoiceHandler ChoiceHandler { get; set; }
    public void SetMuteForEditorTrack(bool muted);
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.Drama.IDramaLauncherArgument launcherArgument);
    private void Update();
    private void OnDestroy();

    private struct <InitializeAsync>d__50 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Drama.DramaScene <>4__this;
        public PRISM.Adapters.Drama.IDramaLauncherArgument launcherArgument;
        private PRISM.Interactions.Drama.DramaSceneInitializerResult <result>5__2;
        private Awaiter<PRISM.Interactions.Drama.DramaSceneInitializerResult> <>u__1;
        private Awaiter <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Drama
public class DramaSceneChoiceHandler : UnityEngine.MonoBehaviour, PRISM.Adapters.Drama.IDramaSceneChoiceHandler
{
    private PRISM.Interactions.Drama.DramaScene dramaScene;
    private UnityEngine.Camera uiCamera;
    private PRISM.Interactions.Drama.DramaChoiceButtonGroupView choiceGroup;
    private PRISM.Interactions.Drama.DramaSceneOperationHandler operationHandler;
    private PRISM.Interactions.Drama.DramaSceneJumpHandler jumpHandler;
    private UniRx.ReactiveProperty<string> chosenLabel;
    private System.Collections.Generic.IReadOnlyCollection<int> selectedChoiceIds;
    private PRISM.Adapters.Drama.UI.IDramaUIView uiView;
    private UnityEngine.Timeline.TimelineClip <ChoiceClip>k__BackingField;
    public UnityEngine.Timeline.TimelineClip ChoiceClip { get; set; }
    public UniRx.IReadOnlyReactiveProperty<string> ChosenLabel { get; set; }
    public bool ChoiceExists { get; set; }
    public System.Nullable<double> ChoiceStartTime { get; set; }
    public void Inject(UnityEngine.Timeline.TimelineClip choiceClip, PRISM.Adapters.Drama.UI.IDramaUIView uiView);
    public void ManualUpdate();
    public void JumpToChoice();
    public void SetSelectedChoiceIds(System.Collections.Generic.IReadOnlyCollection<int> ids);
    public void ClearChoose();
    private PRISM.Adapters.Drama.DramaChoiceButtonViewModel <ManualUpdate>b__19_0(PRISM.Interactions.Sujigaki.SujigakiLinePlayableChoicePair x);
    private void <ManualUpdate>b__19_1(string label);
}

// Namespace: PRISM.Interactions.Drama
public class DramaSceneHandler : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.Drama.DramaScene dramaScene;
    private PRISM.Interactions.Drama.DramaSceneOperationHandler operationHandler;
    private PRISM.Interactions.Drama.DramaSceneTimeHandler timeHandler;
    private PRISM.Interactions.Drama.DramaSceneChoiceHandler choiceHandler;
    private PRISM.Interactions.Drama.DramaSceneJumpHandler jumpHandler;
    private PRISM.Interactions.Drama.DramaSceneSoundHandler soundHandler;
    private PRISM.Interactions.Drama.DramaScenePhysicsHandler physicsHandler;
    public PRISM.Interactions.Drama.DramaSceneOperationHandler OperationHandler { get; set; }
    public PRISM.Interactions.Drama.DramaSceneTimeHandler TimeHandler { get; set; }
    public PRISM.Interactions.Drama.DramaSceneChoiceHandler ChoiceHandler { get; set; }
    public System.IDisposable Initialize(PRISM.Interactions.Drama.DramaSceneInitializerResult result);
    private void <Initialize>b__13_0(long _);
}

// Namespace: PRISM.Interactions.Drama
public class DramaSceneInitializerParameter
{
    private UnityEngine.Transform <UIViewRoot>k__BackingField;
    private PRISM.Interactions.Drama.UI.DramaSubtitleView <SubtitleView>k__BackingField;
    private PRISM.Interactions.Drama.DramaChoiceButtonGroupView <ChoiceGroup>k__BackingField;
    public UnityEngine.Transform UIViewRoot { get; set; }
    public PRISM.Interactions.Drama.UI.DramaSubtitleView SubtitleView { get; set; }
    public PRISM.Interactions.Drama.DramaChoiceButtonGroupView ChoiceGroup { get; set; }
}

// Namespace: PRISM.Interactions.Drama
public class DramaSubtitleOperateData
{
    public double startTime;
    public double endTime;
    public PRISM.Interactions.Drama.DramaSubtitlePlayableBehaviour behaviour;
}

// Namespace: PRISM.Interactions.Drama
public class DramaSceneInitializerResult
{
    private PRISM.Adapters.Drama.UI.IDramaUIPresenter <UIPresenter>k__BackingField;
    private PRISM.ResourceManagement.IResourceLoader <ResourceLoader>k__BackingField;
    private PRISM.Adapters.Drama.IDramaLauncherArgument <LauncherArgument>k__BackingField;
    private PRISM.Interactions.Drama.DramaSubtitleOperateData[] <SubtitleOperateDataArray>k__BackingField;
    private UnityEngine.Timeline.TimelineClip <ChoiceClip>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<UnityEngine.Timeline.TimelineClip> <LabelClips>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<UnityEngine.Timeline.TimelineClip> <JumpClips>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<PRISM.Interactions.Drama.DramaFinishMarker> <FinishMarkers>k__BackingField;
    private bool <WithVoice>k__BackingField;
    public PRISM.Adapters.Drama.UI.IDramaUIPresenter UIPresenter { get; set; }
    public PRISM.ResourceManagement.IResourceLoader ResourceLoader { get; set; }
    public PRISM.Adapters.Drama.IDramaLauncherArgument LauncherArgument { get; set; }
    public PRISM.Interactions.Drama.DramaSubtitleOperateData[] SubtitleOperateDataArray { get; set; }
    public UnityEngine.Timeline.TimelineClip ChoiceClip { get; set; }
    public System.Collections.Generic.IReadOnlyList<UnityEngine.Timeline.TimelineClip> LabelClips { get; set; }
    public System.Collections.Generic.IReadOnlyList<UnityEngine.Timeline.TimelineClip> JumpClips { get; set; }
    public System.Collections.Generic.IReadOnlyList<PRISM.Interactions.Drama.DramaFinishMarker> FinishMarkers { get; set; }
    public bool WithVoice { get; set; }
}

// Namespace: PRISM.Interactions.Drama
public class DramaSceneInitializer
{
    public static Cysharp.Threading.Tasks.UniTask<PRISM.Interactions.Drama.DramaSceneInitializerResult> InitializeAsync(PRISM.Interactions.Drama.DramaScene dramaScene, PRISM.Interactions.Drama.DramaSceneInitializerParameter parameter, PRISM.Adapters.Drama.IDramaLauncherArgument launcherArgument);
    private static System.Collections.Generic.List<PRISM.Interactions.Drama.DramaSubtitleOperateData> _createSubtitleOperateDataList(UnityEngine.Playables.PlayableDirector director, System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> tracks, double startTime);
    private static System.ValueTuple<UnityEngine.Timeline.TimelineClip, System.Collections.Generic.IReadOnlyList<UnityEngine.Timeline.TimelineClip>, System.Collections.Generic.IReadOnlyList<UnityEngine.Timeline.TimelineClip>> _setupChoice(PRISM.Interactions.Drama.DramaScene dramaScene, PRISM.Interactions.Drama.DramaChoiceButtonGroupView choiceGroup, PRISM.Adapters.Drama.IDramaLauncherArgument launcherArgument);
    private static System.Collections.Generic.IReadOnlyList<PRISM.Interactions.Drama.DramaFinishMarker> _getFinishMarkers(UnityEngine.Playables.PlayableDirector director);
    private static System.Collections.Generic.IEnumerable<PRISM.Interactions.Drama.DramaFinishMarker> <_getFinishMarkers>g___enumerateFinishMarkers|3_0(UnityEngine.Playables.PlayableDirector director, double timeOffset);

    private class <<_getFinishMarkers>g___enumerateFinishMarkers|3_0>d : System.Collections.Generic.IEnumerable<PRISM.Interactions.Drama.DramaFinishMarker>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<PRISM.Interactions.Drama.DramaFinishMarker>, System.Collections.IEnumerator, System.IDisposable
    {
        private int <>1__state;
        private PRISM.Interactions.Drama.DramaFinishMarker <>2__current;
        private int <>l__initialThreadId;
        private UnityEngine.Playables.PlayableDirector director;
        public UnityEngine.Playables.PlayableDirector <>3__director;
        private double timeOffset;
        public double <>3__timeOffset;
        private System.Collections.Generic.IEnumerator<PRISM.Interactions.Drama.DramaFinishMarker> <>7__wrap1;
        private PRISM.Interactions.Drama.DramaFinishMarker System.Collections.Generic.IEnumerator<PRISM.Interactions.Drama.DramaFinishMarker>.Current { get; set; }
        private object System.Collections.IEnumerator.Current { get; set; }
        private void System.IDisposable.Dispose();
        private bool MoveNext();
        private void <>m__Finally1();
        private void System.Collections.IEnumerator.Reset();
        private System.Collections.Generic.IEnumerator<PRISM.Interactions.Drama.DramaFinishMarker> System.Collections.Generic.IEnumerable<PRISM.Interactions.Drama.DramaFinishMarker>.GetEnumerator();
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
    }

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<UnityEngine.Timeline.TimelineClip, Sujigaki.SujigakiEpisodeLineType> <>9__2_0;
        public static System.Func<System.Linq.IGrouping<Sujigaki.SujigakiEpisodeLineType, UnityEngine.Timeline.TimelineClip>, Sujigaki.SujigakiEpisodeLineType> <>9__2_1;
        public static System.Func<System.Linq.IGrouping<Sujigaki.SujigakiEpisodeLineType, UnityEngine.Timeline.TimelineClip>, System.Linq.IGrouping<Sujigaki.SujigakiEpisodeLineType, UnityEngine.Timeline.TimelineClip>> <>9__2_2;
        public static System.Func<System.ValueTuple<UnityEngine.Playables.PlayableDirector, UnityEngine.Timeline.TimelineClip>, System.Collections.Generic.IEnumerable<PRISM.Interactions.Drama.DramaFinishMarker>> <>9__3_1;
        private Sujigaki.SujigakiEpisodeLineType <_setupChoice>b__2_0(UnityEngine.Timeline.TimelineClip x);
        private Sujigaki.SujigakiEpisodeLineType <_setupChoice>b__2_1(System.Linq.IGrouping<Sujigaki.SujigakiEpisodeLineType, UnityEngine.Timeline.TimelineClip> x);
        private System.Linq.IGrouping<Sujigaki.SujigakiEpisodeLineType, UnityEngine.Timeline.TimelineClip> <_setupChoice>b__2_2(System.Linq.IGrouping<Sujigaki.SujigakiEpisodeLineType, UnityEngine.Timeline.TimelineClip> x);
        private System.Collections.Generic.IEnumerable<PRISM.Interactions.Drama.DramaFinishMarker> <_getFinishMarkers>b__3_1(System.ValueTuple<UnityEngine.Playables.PlayableDirector, UnityEngine.Timeline.TimelineClip> x);
    }

    private class <>c__DisplayClass0_0
    {
        public string[] loadedCueSheets;
        private void <InitializeAsync>b__0();
    }

    private struct <InitializeAsync>d__0 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<PRISM.Interactions.Drama.DramaSceneInitializerResult> <>t__builder;
        public PRISM.Interactions.Drama.DramaScene dramaScene;
        public PRISM.Adapters.Drama.IDramaLauncherArgument launcherArgument;
        public PRISM.Interactions.Drama.DramaSceneInitializerParameter parameter;
        private <>c__DisplayClass0_0 <>8__1;
        private System.Threading.CancellationToken <ct>5__2;
        private System.Collections.Generic.IReadOnlyList<string> <cueSheets>5__3;
        private System.ValueTuple<UnityEngine.Timeline.TimelineClip, System.Collections.Generic.IReadOnlyList<UnityEngine.Timeline.TimelineClip>, System.Collections.Generic.IReadOnlyList<UnityEngine.Timeline.TimelineClip>> <choiceClipData>5__4;
        private PRISM.Interactions.Drama.DramaSubtitleOperateData[] <subtitleOperateDataArray>5__5;
        private PRISM.ResourceManagement.IResourceLoader <resourceLoader>5__6;
        private PRISM.Adapters.Drama.UI.DramaUIPresenter <uiPresenter>5__7;
        private Awaiter<PRISM.Adapters.TimelineSceneDependency> <>u__1;
        private Awaiter <>u__2;
        private Awaiter<UnityEngine.GameObject> <>u__3;
        private Awaiter<string[]> <>u__4;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Drama
public class DramaSceneJumpHandler : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.Drama.DramaScene dramaScene;
    private PRISM.Interactions.Drama.DramaSceneOperationHandler operationHandler;
    private System.Collections.Generic.IReadOnlyList<UnityEngine.Timeline.TimelineClip> labelClips;
    private System.Collections.Generic.IReadOnlyList<UnityEngine.Timeline.TimelineClip> jumpClips;
    public void Inject(System.Collections.Generic.IReadOnlyList<UnityEngine.Timeline.TimelineClip> labelClips, System.Collections.Generic.IReadOnlyList<UnityEngine.Timeline.TimelineClip> jumpClips);
    public void ManualUpdate();
    public UnityEngine.Timeline.TimelineClip GetLabelClipOrDefault(string label);
    public UnityEngine.Timeline.TimelineClip GetFirstJumpClipOrDefault(double time, System.Func<double, UnityEngine.Timeline.TimelineClip, bool> predicate);
    public void JumpToLabel(double time, string label);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<double, UnityEngine.Timeline.TimelineClip, bool> <>9__5_0;
        private bool <ManualUpdate>b__5_0(double time, UnityEngine.Timeline.TimelineClip clip);
    }

    private class <>c__DisplayClass6_0
    {
        public string label;
        private bool <GetLabelClipOrDefault>b__0(UnityEngine.Timeline.TimelineClip c);
    }
}

// Namespace: PRISM.Interactions.Drama
public class DramaSceneOperationHandler : UnityEngine.MonoBehaviour, PRISM.Adapters.Drama.IDramaSceneOperationHandler
{
    private PRISM.Interactions.Drama.DramaScene dramaScene;
    private PRISM.Interactions.Drama.DramaSceneTimeHandler timeHandler;
    private PRISM.Interactions.Drama.DramaSceneChoiceHandler choiceHandler;
    private PRISM.Interactions.Drama.DramaSceneSoundHandler soundHandler;
    private PRISM.Interactions.Drama.DramaScenePhysicsHandler physicsHandler;
    private UnityEngine.RenderTexture reservedRenderTexture;
    private UniRx.ReactiveProperty<bool> isPaused;
    private PRISM.Interactions.Drama.DramaSubtitleOperateData[] dramaSubtitleOperateDataArray;
    private System.Collections.Generic.IReadOnlyList<PRISM.Interactions.Drama.DramaFinishMarker> finishMarkers;
    private bool <IsEnd>k__BackingField;
    private PRISM.Definitions.Drama.UI.DramaPlaySpeedType <PlaySpeedType>k__BackingField;
    public UniRx.IReadOnlyReactiveProperty<bool> IsPaused { get; set; }
    public bool IsEnd { get; set; }
    public PRISM.Definitions.Drama.UI.DramaPlaySpeedType PlaySpeedType { get; set; }
    public void Initialize(PRISM.Interactions.Drama.DramaSubtitleOperateData[] dramaSubtitleOperateDataArray, System.Collections.Generic.IReadOnlyList<PRISM.Interactions.Drama.DramaFinishMarker> finishMarkers);
    public void ManualUpdate();
    public void Play();
    public void ResetTimeScale();
    public void SetPaused(bool isActive, bool isCallDirectorPause, bool muteLoopSound);
    public void TogglePause();
    public System.IDisposable CreateTemporalPauseScope(bool isCallDirectorPause);
    public void TurnPageForward();
    private static bool _tryGetNextClipOrDefault(PRISM.Interactions.Drama.DramaSubtitleOperateData[] dataArray, double targetTime, double& startTime);
    public void TurnPageBackward();
    private double _correctJumpToTiming(double startTime);
    private Cysharp.Threading.Tasks.UniTask _moveTimeAsync(double time, bool clearCrossFade);
    private static bool _tryGetPrevStartTime(PRISM.Interactions.Drama.DramaSubtitleOperateData[] dataArray, double targetTime, double& startTime);
    public void JumpByNormalizedTime(float normalizeTime);
    public void JumpByTimelineTime(double time, bool clearCrossFade);
    public void SetPlaySpeed(PRISM.Definitions.Drama.UI.DramaPlaySpeedType speedType);
    public System.Collections.Generic.IEnumerable<PRISM.Adapters.Drama.UI.DramaLogCellViewModel> CreateDramaLogCellViewModels();
    private void OnDestroy();
    private void _setPlaySpeed(float playSpeed);
    private static void _clearAllCrossfadeBuffer(UnityEngine.Playables.PlayableDirector director);
    private void _updateCinemachineCamera(float deltaTime);
    private void <ManualUpdate>g___finish|20_0(double currentTime, <>c__DisplayClass20_0& );
    private void <JumpByNormalizedTime>b__32_0();
    private static void <_clearAllCrossfadeBuffer>g__ProcessPlayableGraphRecursively|38_0<TPlayableType>(UnityEngine.Playables.Playable playable, System.Action<TPlayableType> action);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Interactions.Drama.DramaSubtitleOperateData, PRISM.Adapters.Drama.UI.DramaLogCellViewModel> <>9__35_1;
        public static System.Action<PRISM.FadeMixerBehaviour> <>9__38_1;
        private PRISM.Adapters.Drama.UI.DramaLogCellViewModel <CreateDramaLogCellViewModels>b__35_1(PRISM.Interactions.Drama.DramaSubtitleOperateData data);
        private void <_clearAllCrossfadeBuffer>b__38_1(PRISM.FadeMixerBehaviour fadeMixerBehaviour);
    }

    private struct <>c__DisplayClass20_0 : System.ValueType
    {
        public double duration;
        public PRISM.Interactions.Drama.DramaSceneOperationHandler <>4__this;
    }

    private class <>c__DisplayClass20_1
    {
        public string chosenLabel;
        private bool <ManualUpdate>b__1(PRISM.Interactions.Drama.DramaFinishMarker x);
    }

    private class <>c__DisplayClass25_0
    {
        public PRISM.Interactions.Drama.DramaSceneOperationHandler <>4__this;
        public bool isPausedPrev;
        public bool isCallDirectorPause;
        private void <CreateTemporalPauseScope>b__0();
    }

    private class <>c__DisplayClass35_0
    {
        public double currentStartTime;
        public PRISM.Interactions.Drama.DramaSceneOperationHandler <>4__this;
        private bool <CreateDramaLogCellViewModels>b__0(PRISM.Interactions.Drama.DramaSubtitleOperateData data);
    }

    private struct <_moveTimeAsync>d__30 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Drama.DramaSceneOperationHandler <>4__this;
        public double time;
        public bool clearCrossFade;
        private Awaiter <>u__1;
        private Awaiter <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Drama
public class DramaScenePhysicsHandler : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.Drama.DramaScene dramaScene;
    private System.Collections.Generic.IReadOnlyList<PRISM.ConeConstrain> coneConstrains;
    private System.Collections.Generic.List<KeepMagicaParameter> keepParameters;
    public void Initialize();
    public Cysharp.Threading.Tasks.UniTask ResetMagicaClothSimulationAsync();
    public void ExecuteConeConstrainsLateUpdate();
    public void PauseSwayBoneManager(bool isActive);
    public void SetPhysicsGlobalTimeScale(float rate);

    private class KeepMagicaParameter
    {
        private float worldInertia;
        private float localInertia;
        private float stablizationTimeAfterReset;
        private CameraCullingMode cameraCullingMode;
        private bool distanceCullingLengthUse;
        private MagicaCloth2.ClothUpdateMode updateMode;
        private float rootRotation;
        private MagicaCloth2.MagicaCloth cloth;
        public void Rollback();
    }

    private struct <ResetMagicaClothSimulationAsync>d__5 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Drama.DramaScenePhysicsHandler <>4__this;
        private float <timeScale>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Drama
public class DramaSceneSoundHandler : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.Drama.DramaScene dramaScene;
    private System.Collections.Generic.Dictionary<SoundLoopType, System.Collections.Generic.List<CriAtomTrackData>> criAtomTrackDataDictionary;
    private System.Collections.Generic.List<CriAtomTrackData> voiceCriAtomTrackDataList;
    private static SoundLoopType _toLoopType(SoundType soundType);
    public void Initialize(bool withVoice);
    private void _collectCriAtomTrackData();
    public void SetOneShotAtomTrackStopAtGraphEnd(bool isActive, bool isVoiceOnly);
    public Cysharp.Threading.Tasks.UniTask StopAllOneShotAtomSourcesAsync(bool isVoiceOnly);
    private static void _stopAllCriAtomBehaviours(UnityEngine.Playables.PlayableGraph playableGraph, CriWare.CriAtomSource target);
    public void MuteOneShotSound(bool muted);
    public void MuteLoopSound(bool muted);
    private static void _setMuted(bool muted, System.Collections.Generic.IReadOnlyList<CriAtomTrackData> criAtomTrackDataList);
    private void <_collectCriAtomTrackData>g__AddCriAtomTrackDataToDictionary|8_0(UnityEngine.Playables.PlayableDirector director);
    private static UnityEngine.Playables.ScriptPlayable<CriWare.CriTimeline.Atom.CriAtomMixerBehaviour> <_stopAllCriAtomBehaviours>g__SearchCriAtomMixerBehaviourScriptPlayable|11_0(UnityEngine.Playables.Playable playable, <>c__DisplayClass11_0& );

    private struct CriAtomTrackData : System.ValueType, System.IEquatable<CriAtomTrackData>
    {
        private SoundType <SoundType>k__BackingField;
        private CriWare.CriTimeline.Atom.CriAtomTrack <Track>k__BackingField;
        private CriWare.CriAtomSource <Source>k__BackingField;
        private UnityEngine.Playables.PlayableDirector <Director>k__BackingField;
        public SoundType SoundType { get; set; }
        public CriWare.CriTimeline.Atom.CriAtomTrack Track { get; set; }
        public CriWare.CriAtomSource Source { get; set; }
        public UnityEngine.Playables.PlayableDirector Director { get; set; }
        public string ToString();
        private bool PrintMembers(System.Text.StringBuilder builder);
        public static bool op_Inequality(CriAtomTrackData left, CriAtomTrackData right);
        public static bool op_Equality(CriAtomTrackData left, CriAtomTrackData right);
        public int GetHashCode();
        public bool Equals(object obj);
        public bool Equals(CriAtomTrackData other);
        public void Deconstruct(SoundType& SoundType, CriWare.CriTimeline.Atom.CriAtomTrack& Track, CriWare.CriAtomSource& Source, UnityEngine.Playables.PlayableDirector& Director);
    }

    private enum SoundType : System.Enum
    {
        public int value__;
        public static SoundType Bgm;
        public static SoundType Environment;
        public static SoundType Se;
        public static SoundType Voice;
    }

    private enum SoundLoopType : System.Enum
    {
        public int value__;
        public static SoundLoopType OneShot;
        public static SoundLoopType Loop;
    }

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<UnityEngine.Timeline.TrackAsset, bool> <>9__8_1;
        private bool <_collectCriAtomTrackData>b__8_1(UnityEngine.Timeline.TrackAsset track);
    }

    private class <>c__DisplayClass10_0
    {
        public CriWare.CriAtomSource atomSource;
        private bool <StopAllOneShotAtomSourcesAsync>b__0();
    }

    private struct <>c__DisplayClass11_0 : System.ValueType
    {
        public CriWare.CriAtomSource target;
    }

    private struct <StopAllOneShotAtomSourcesAsync>d__10 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public bool isVoiceOnly;
        public PRISM.Interactions.Drama.DramaSceneSoundHandler <>4__this;
        private <>c__DisplayClass10_0 <>8__1;
        private Enumerator<CriAtomTrackData> <>7__wrap1;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Drama
public class DramaSceneTimeHandler : UnityEngine.MonoBehaviour, PRISM.Adapters.Drama.IDramaSceneTimeHandler
{
    private PRISM.Interactions.Drama.DramaScene dramaScene;
    private PRISM.Interactions.Drama.DramaSceneChoiceHandler choiceHandler;
    private PRISM.Interactions.Drama.DramaSceneJumpHandler jumpHandler;
    private System.Collections.Generic.IReadOnlyList<PRISM.Interactions.Drama.DramaFinishMarker> finishMarkers;
    public void Inject(System.Collections.Generic.IReadOnlyList<PRISM.Interactions.Drama.DramaFinishMarker> finishMarkers);
    public double GetStartTime();
    public double GetEndTime();
    public double GetDuration();
    public double GetCurrentTime(bool needNormalize);
    private double <GetEndTime>g___getEndTime|6_0();
    private bool <GetEndTime>b__6_1(PRISM.Interactions.Drama.DramaFinishMarker x);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<double, UnityEngine.Timeline.TimelineClip, bool> <>9__5_0;
        private bool <GetStartTime>b__5_0(double time, UnityEngine.Timeline.TimelineClip clip);
    }
}

// Namespace: PRISM.Interactions.Drama
public class DramaChoiceButtonGroupView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.Drama.DramaChoiceButtonView[] buttons;
    private UnityEngine.Animator animator;
    private PRISM.Interactions.ViewStateChanger showChoiceChanger;
    private UniRx.CompositeDisposable buttonDisposables;
    public void Show(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.Drama.DramaChoiceButtonViewModel> viewModels, System.Action<string> onChoose);
    public void Hide();
    private void OnDestroy();

    private class <>c__DisplayClass4_0
    {
        public PRISM.Interactions.Drama.DramaChoiceButtonGroupView <>4__this;
        public System.Action<string> onChoose;
    }

    private class <>c__DisplayClass4_1
    {
        public PRISM.Adapters.Drama.DramaChoiceButtonViewModel viewModel;
        public <>c__DisplayClass4_0 CS$<>8__locals1;
        private void <Show>b__0(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.Drama
public class DramaChoiceButtonView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView button;
    private ENTERPRISE.UI.UITextMeshProUGUI text;
    private PRISM.Interactions.ViewStateChanger isSelectedChanger;
    public System.IObservable<UniRx.Unit> OnClick { get; set; }
    public void Initialize(PRISM.Adapters.Drama.DramaChoiceButtonViewModel viewModel);
}

// Namespace: PRISM.Interactions.Drama
public class DramaMarkerBase : UnityEngine.Timeline.Marker, UnityEngine.Playables.INotification
{
    public UnityEngine.PropertyName id { get; set; }
    public void Invoke(UnityEngine.Playables.Playable origin, object context, PRISM.Interactions.Drama.DramaScene scene);
}

// Namespace: PRISM.Interactions.Drama
public class DramaNotificationReceiver : UnityEngine.MonoBehaviour, UnityEngine.Playables.INotificationReceiver
{
    private PRISM.Interactions.Drama.DramaScene dramaScene;
    private void Start();
    public void OnNotify(UnityEngine.Playables.Playable origin, UnityEngine.Playables.INotification notification, object context);
}

// Namespace: PRISM.Interactions.Drama
public class DramaSceneDebugInformation : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.Drama.DramaScene dramaScene;
    private ENTERPRISE.UI.UITextMeshProUGUI text;
}

// Namespace: PRISM.Interactions.Drama
public class DramaSceneForEditorPreview : UnityEngine.MonoBehaviour
{
    private UnityEngine.Transform debugTextRoot;
    private ENTERPRISE.UI.UITextMeshProUGUI directionText;
    private PRISM.Interactions.Drama.DramaSceneGuidelines guidelines;
    public UnityEngine.Transform DebugTextRoot { get; set; }
    public ENTERPRISE.UI.UITextMeshProUGUI DirectionText { get; set; }
    public PRISM.Interactions.Drama.DramaSceneGuidelines Guidelines { get; set; }
}

// Namespace: PRISM.Interactions.Drama
public class DramaSceneGuidelines : PRISM.Interactions.Drama.DramaSceneRectTransformAspectFitter
{
    private UnityEngine.CanvasGroup canvasGroup;
    private UnityEngine.RectTransform centerVerticalLine;
    private UnityEngine.RectTransform centerHorizontalLine;
    private UnityEngine.RectTransform trisectionVerticalLine;
    private UnityEngine.RectTransform trisectionHorizontalLine;
    private float <Alpha>k__BackingField;
    private float <Size>k__BackingField;
    private UnityEngine.Color <Color>k__BackingField;
    public UnityEngine.RectTransform CenterVerticalLine { get; set; }
    public UnityEngine.RectTransform CenterHorizontalLine { get; set; }
    public UnityEngine.RectTransform TrisectionVerticalLine { get; set; }
    public UnityEngine.RectTransform TrisectionHorizontalLine { get; set; }
    public float Alpha { get; set; }
    public float Size { get; set; }
    public UnityEngine.Color Color { get; set; }
    protected void Update();
    public void Apply();
}

// Namespace: PRISM.Interactions.Drama
public class DramaSceneLetterBox : UnityEngine.MonoBehaviour
{
    private UnityEngine.RectTransform myRectTransform;
    private UnityEngine.RectTransform left;
    private UnityEngine.RectTransform right;
    private UnityEngine.RectTransform top;
    private UnityEngine.RectTransform bottom;
    private void Update();
}

// Namespace: PRISM.Interactions.Drama
public class DramaSceneRectTransformAspectFitter : UnityEngine.MonoBehaviour
{
    private UnityEngine.RectTransform myRectTransform;
    protected void Update();
}

// Namespace: PRISM.Interactions.Drama
public class DramaSceneText : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI talkerName;
    private ENTERPRISE.UI.UITextMeshProUGUI text;
    private UnityEngine.UI.Image indicator;
    private UnityEngine.RectTransform myRectTransform;
    private UnityEngine.RectTransform parentRectTransform;
    private ENTERPRISE.UI.ColorToOutlineForTextMeshProUGUI talkerTextOutline;
    private ENTERPRISE.UI.ColorToOutlineForTextMeshProUGUI messageOutline;
    public UnityEngine.UI.Image Indicator { get; set; }
    public void SetText(string talkerNameText, string messageText);
    public void UpdateManuallyOutline();
    private void _setMessageText(string input);
    private static void <_setMessageText>g___replaceTextIfNeeded|11_0(<>c__DisplayClass11_0& );

    private struct <>c__DisplayClass11_0 : System.ValueType
    {
        public int count;
        public Cysharp.Text.Utf16ValueStringBuilder sb;
    }
}

// Namespace: PRISM.Interactions.Drama
public class DramaSceneExtensions
{
    public static UnityEngine.Timeline.TimelineClip GetPrevClipOrDefault(PRISM.Interactions.Drama.DramaScene dramaScene, string trackPath, System.Nullable<double> time);
    public static UnityEngine.Timeline.TimelineClip GetCurrentClipOrDefault(PRISM.Interactions.Drama.DramaScene dramaScene, string trackPath, System.Nullable<double> time);
    public static UnityEngine.Timeline.TimelineClip GetNextClipOrDefault(PRISM.Interactions.Drama.DramaScene dramaScene, string trackPath, System.Nullable<double> time);
    public static UnityEngine.Timeline.TimelineClip GetCurrentSubtitleClipOrDefault(PRISM.Interactions.Drama.DramaScene dramaScene);
}

// Namespace: PRISM.Interactions.Drama
public interface ITimingPlayableAsset
{
    public PRISM.Interactions.Sujigaki.TimingPlayableBehaviour GetBehaviour();
}

// Namespace: PRISM.Interactions.Drama
public class DramaFinishMarker : PRISM.Interactions.Drama.DramaMarkerBase
{
    private string label;
    private double timeOffset;
    public string Label { get; set; }
    public double TimeWithOffset { get; set; }
    public void SetTimeOffset(double offset);
    public void Invoke(UnityEngine.Playables.Playable origin, object context, PRISM.Interactions.Drama.DramaScene scene);
}

// Namespace: PRISM.Interactions.Drama
public enum DramaLabelPlayableAssetType : System.Enum
{
    public int value__;
    public static PRISM.Interactions.Drama.DramaLabelPlayableAssetType JumpFrom;
    public static PRISM.Interactions.Drama.DramaLabelPlayableAssetType JumpTo;
}

// Namespace: PRISM.Interactions.Drama
public class DramaPlaySeMarker : PRISM.Interactions.Drama.DramaMarkerBase
{
    private string cueSheet;
    private string cueName;
    private float volume;
    private bool isMuted;
    public void Invoke(UnityEngine.Playables.Playable origin, object context, PRISM.Interactions.Drama.DramaScene scene);
}

// Namespace: PRISM.Interactions.Drama
public class DramaSubtitleMixerBehaviour : PRISM.MixerBehaviourBase<PRISM.Interactions.Drama.DramaSceneText>
{
    protected void Apply(UnityEngine.Timeline.TimelineClip timelineClip, double time);
    protected void NoHitClip(UnityEngine.Timeline.TimelineClip beforeClip, UnityEngine.Timeline.TimelineClip nextClip);

    private class <>c__DisplayClass0_0
    {
        public PRISM.Interactions.Drama.DramaSubtitlePlayableAsset clip;
        private bool <Apply>b__0(UnityEngine.Timeline.TimelineClip c);
    }
}

// Namespace: PRISM.Interactions.Drama
public class DramaSubtitlePlayableAsset : PRISM.PlayableAssetBase<PRISM.Interactions.Drama.DramaSubtitlePlayableBehaviour>, UnityEngine.Timeline.ITimelineClipAsset
{
    public UnityEngine.Timeline.ClipCaps clipCaps { get; set; }
}

// Namespace: PRISM.Interactions.Drama
public class DramaSubtitlePlayableBehaviour : UnityEngine.Playables.PlayableBehaviour
{
    public string uniqueId;
    public string text;
    public string talkerName;
    public string displayTalkerName;
    public int mstCharacterInfoId;
    public string cueName;
    public bool isAutoStartSpaceTime;
    public float startSpaceTime;
    public string DisplayTalkerName();
    public bool HasVoice();
}

// Namespace: PRISM.Interactions.Drama
public class DramaSubtitleTrack : PRISM.TrackAssetBase<PRISM.Interactions.Drama.DramaSceneText, PRISM.Interactions.Drama.DramaSubtitleMixerBehaviour>
{
    private ClipExtrapolation m_InfiniteClipPreExtrapolation;
    private ClipExtrapolation m_InfiniteClipPostExtrapolation;
    public ClipExtrapolation infiniteClipPreExtrapolation { get; set; }
    public ClipExtrapolation infiniteClipPostExtrapolation { get; set; }
    public UnityEngine.Timeline.TimelineClip FindClip(string uniqueId);
}

// Namespace: PRISM.Interactions.Drama
public class MarkerBase : UnityEngine.Timeline.Marker, UnityEngine.Playables.INotification
{
    public UnityEngine.PropertyName id { get; set; }
    public void Invoke(UnityEngine.Playables.Playable origin, object context);
}

// Namespace: PRISM.Interactions.Drama
public enum DramaTransitionFadeType : System.Enum
{
    public int value__;
    public static PRISM.Interactions.Drama.DramaTransitionFadeType None;
    public static PRISM.Interactions.Drama.DramaTransitionFadeType White;
    public static PRISM.Interactions.Drama.DramaTransitionFadeType Black;
}

// Namespace: PRISM.Interactions.Drama
public class DramaLogCellView : PRISM.EnhancedListViewCell<PRISM.Adapters.Drama.UI.DramaLogCellViewModel, PRISM.Interactions.Drama.UI.DramaLogScrollerContext>
{
    private PRISM.Interactions.CharacterBaseIconView characterBaseIcon;
    private UnityEngine.UI.Image otherIconImage;
    private PRISM.Interactions.ViewStateChanger isCharacterChanger;
    private ENTERPRISE.UI.UITextMeshProUGUI talkerNameText;
    private PRISM.Interactions.ViewStateChanger isProducerChanger;
    private ENTERPRISE.UI.UITextMeshProUGUI dialogueText;
    private PRISM.Interactions.ButtonView voiceButton;
    private PRISM.Interactions.ViewStateChanger hasVoiceChanger;
    private PRISM.Interactions.ViewStateChanger voicePlayingChanger;
    private PRISM.Interactions.ButtonView jumpButton;
    private PRISM.AutoCancellationTokenSource canceller;
    private PRISM.AutoCancellationTokenSource voiceCanceller;
    private double currentStartTime;
    public void UpdateContent(PRISM.Adapters.Drama.UI.DramaLogCellViewModel viewModel);
    protected void _initialize();
    private Cysharp.Threading.Tasks.UniTask _playVoiceAsync(PRISM.Adapters.Drama.UI.DramaLogCellViewModel viewModel);
    private void <_initialize>b__14_0(UniRx.Unit _);
    private bool <_playVoiceAsync>b__15_0();
    private bool <_playVoiceAsync>b__15_1();

    private class <>c__DisplayClass13_0
    {
        public PRISM.Interactions.Drama.DramaLogCellView <>4__this;
        public PRISM.Adapters.Drama.UI.DramaLogCellViewModel viewModel;
        private void <UpdateContent>b__0(UniRx.Unit _);
        private void <UpdateContent>b__1(CriWare.CriAtomExPlayback _);
    }

    private struct <_playVoiceAsync>d__15 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Drama.DramaLogCellView <>4__this;
        public PRISM.Adapters.Drama.UI.DramaLogCellViewModel viewModel;
        private System.Threading.CancellationTokenSource <linkedCt>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Drama
public class DramaSettingsPanelView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ToggleGroupView screenOperationTypeGroup;
    private PRISM.Interactions.ToggleGroupView pauseOnTapGroup;
    private PRISM.Interactions.ToggleGroupView confirmOnSkipGroup;
    private PRISM.Interactions.ToggleGroupView confirmOnJumpGroup;
    private PRISM.Interactions.ToggleGroupView notifyUnreadChoiceGroup;
    private PRISM.Interactions.ToggleGroupView showSubtitleIndicatorGroup;
    public void Initialize(PRISM.Adapters.Drama.UI.IDramaSettingsPanelViewModel viewModel);
}

// Namespace: PRISM.Interactions.Drama.UI
public class DramaJumpToStoryButtonView : UnityEngine.MonoBehaviour, PRISM.Adapters.Drama.UI.IDramaJumpToStoryButtonView
{
    private PRISM.Interactions.ButtonView button;
    private PRISM.Interactions.StoryThumbnailView thumbnailView;
    public System.IObservable<UniRx.Unit> OnClick { get; set; }
    public System.IDisposable Initialize(System.ValueTuple<PRISM.Adapters.Drama.IDramaLauncherArgument, PRISM.Adapters.Drama.IDramaLauncherArgument> launcherArguments, PRISM.Adapters.Drama.IDramaScene dramaScene, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);

    private class <>c__DisplayClass4_0
    {
        public System.ValueTuple<PRISM.Adapters.Drama.IDramaLauncherArgument, PRISM.Adapters.Drama.IDramaLauncherArgument> launcherArguments;
        public PRISM.Adapters.Drama.IDramaScene dramaScene;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        private void <Initialize>b__0(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.Drama.UI
public class DramaMenuView : UnityEngine.MonoBehaviour, PRISM.Adapters.Drama.UI.IDramaMenuView
{
    private static string TimeFormat;
    private UnityEngine.CanvasGroup canvasGroup;
    private float fadeDuration;
    private PRISM.Interactions.ButtonView hideMenuButton;
    private PRISM.Interactions.ButtonView togglePauseButton;
    private PRISM.Interactions.ViewStateChanger pauseStateChanger;
    private PRISM.Interactions.ButtonView turnPageButtonForward;
    private PRISM.Interactions.ButtonView turnPageButtonBackward;
    private PRISM.Interactions.ButtonView shareButton;
    private PRISM.Interactions.ButtonView settingsButton;
    private PRISM.Interactions.ButtonView logButton;
    private PRISM.Interactions.ButtonView skipButton;
    private ENTERPRISE.UI.UITextMeshProUGUI currentTimeText;
    private ENTERPRISE.UI.UITextMeshProUGUI timeDurationText;
    private UnityEngine.UI.Slider seekBar;
    private PRISM.Interactions.OnDragDetector seekBarOnDragDetector;
    private PRISM.Interactions.ButtonView playSpeedButton;
    private ENTERPRISE.UI.UITextMeshProUGUI playSpeedButtonText;
    private PRISM.Interactions.ToggleButtonView showSubtitlesToggle;
    private PRISM.Interactions.Drama.UI.DramaJumpToStoryButtonView jumpToPrevStoryButton;
    private PRISM.Interactions.Drama.UI.DramaJumpToStoryButtonView jumpToNextStoryButton;
    private UniRx.Subject<bool> onVisibleChanged;
    private System.IObservable<UniRx.Unit> <OnAnyInput>k__BackingField;
    public System.IObservable<bool> OnVisibleChanged { get; set; }
    public System.IObservable<UniRx.Unit> OnClickTogglePauseButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickHideMenuButton { get; set; }
    public System.IObservable<float> OnSeekBarValueChanged { get; set; }
    public System.IObservable<UniRx.Unit> OnClickTurnPageButtonForward { get; set; }
    public System.IObservable<UniRx.Unit> OnClickTurnPageButtonBackward { get; set; }
    public System.IObservable<UniRx.Unit> OnClickShareButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickSettingsButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickLogButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickSkipButton { get; set; }
    public PRISM.Adapters.Drama.UI.IDramaJumpToStoryButtonView JumpToPrevStoryButtonView { get; set; }
    public PRISM.Adapters.Drama.UI.IDramaJumpToStoryButtonView JumpToNextStoryButtonView { get; set; }
    public System.IObservable<UniRx.Unit> OnAnyInput { get; set; }
    public void Initialize(PRISM.Adapters.Drama.IDramaSceneOperationHandler operationHandler, UniRx.IReactiveProperty<bool> showSubtitles, UniRx.IReactiveProperty<PRISM.Definitions.Drama.UI.DramaPlaySpeedType> playSpeedType);
    public void UpdateSeekBarValue(float normalizeTime);
    public void Show(bool isShow, bool withFade);
    public System.IDisposable CreateHideMenuScope();
    public void SetCurrentText(System.TimeSpan timeSpan);
    public void SetTimeDurationText(System.TimeSpan timeSpan);
    private void Awake();
    private void <CreateHideMenuScope>b__53_0();

    private class <>c__DisplayClass50_0
    {
        public PRISM.Interactions.Drama.UI.DramaMenuView <>4__this;
        public UniRx.IReactiveProperty<PRISM.Definitions.Drama.UI.DramaPlaySpeedType> playSpeedType;
        public System.IDisposable temporalPauseScope;
        public PRISM.Adapters.Drama.IDramaSceneOperationHandler operationHandler;
        private void <Initialize>b__0(bool value);
        private void <Initialize>b__1(UniRx.Unit _);
        private void <Initialize>b__2(PRISM.Definitions.Drama.UI.DramaPlaySpeedType value);
        private void <Initialize>b__3(bool isDragging);
    }
}

// Namespace: PRISM.Interactions.Drama.UI
public class DramaScreenOperationLegacyView : UnityEngine.MonoBehaviour, PRISM.Adapters.Drama.UI.IDramaScreenOperationView
{
    private PRISM.Interactions.ButtonView showMenuButton;
    private string turnPageButtonForwardName;
    private PRISM.Interactions.Drama.UI.DramaScreenOperationViewInputDetector inputDetector;
    public System.IObservable<UniRx.Unit> OnClickShowMenuButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickTurnPageButtonForward { get; set; }
    public System.IObservable<UniRx.Unit> OnClickTurnPageButtonBackward { get; set; }
    public System.IObservable<bool> OnLongPressStart { get; set; }
    public void SetActive(bool isActive);
    public void Initialize();
    private bool <get_OnClickTurnPageButtonForward>b__6_0(UnityEngine.EventSystems.PointerEventData x);
    private bool <get_OnClickTurnPageButtonForward>b__6_1(UnityEngine.GameObject y);

    private class <>c
    {
        public static <>c <>9;
        public static System.Action<UniRx.Unit> <>9__12_0;
        private void <Initialize>b__12_0(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.Drama.UI
public class DramaScreenOperationView : UnityEngine.MonoBehaviour, PRISM.Adapters.Drama.UI.IDramaScreenOperationView
{
    private string showMenuButtonName;
    private string turnPageButtonForwardName;
    private string turnPageButtonBackwardName;
    private UnityEngine.UI.Image turnPageImageForward;
    private UnityEngine.UI.Image turnPageImageBackward;
    private float turnPageImageFadeAlpha;
    private float turnPageImageFadeDuration;
    private PRISM.Interactions.Drama.UI.DramaScreenOperationViewInputDetector inputDetector;
    private DG.Tweening.Sequence tweenSequenceTurnPageForward;
    private DG.Tweening.Sequence tweenSequenceTurnPageBackward;
    public System.IObservable<UniRx.Unit> OnClickShowMenuButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickTurnPageButtonForward { get; set; }
    public System.IObservable<UniRx.Unit> OnClickTurnPageButtonBackward { get; set; }
    public System.IObservable<bool> OnLongPressStart { get; set; }
    public void SetActive(bool isActive);
    public void Initialize();
    private static DG.Tweening.Sequence _createTurnPageFadeSequence(UnityEngine.UI.Image turnPageImage, float maxAlpha, float duration, UnityEngine.GameObject linkTarget);
    private bool <get_OnClickShowMenuButton>b__11_0(UnityEngine.EventSystems.PointerEventData x);
    private bool <get_OnClickShowMenuButton>b__11_1(UnityEngine.GameObject y);
    private bool <get_OnClickTurnPageButtonForward>b__13_0(UnityEngine.EventSystems.PointerEventData x);
    private bool <get_OnClickTurnPageButtonForward>b__13_1(UnityEngine.GameObject y);
    private bool <get_OnClickTurnPageButtonBackward>b__15_0(UnityEngine.EventSystems.PointerEventData x);
    private bool <get_OnClickTurnPageButtonBackward>b__15_1(UnityEngine.GameObject y);
    private void <Initialize>b__19_0(UniRx.Unit _);
    private void <Initialize>b__19_1(UniRx.Unit _);
}

// Namespace: PRISM.Interactions.Drama.UI
public class DramaScreenOperationViewInputDetector : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerClickHandler
{
    private float longPressThreshold;
    private UniRx.Subject<UnityEngine.EventSystems.PointerEventData> onShortPressCompleted;
    private UniRx.ReactiveProperty<bool> isLongPressing;
    private float timer;
    private bool isPressing;
    public System.IObservable<bool> OnLongPressStart { get; set; }
    public System.IObservable<UnityEngine.EventSystems.PointerEventData> OnShortPressCompleted { get; set; }
    private void UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
    private void UnityEngine.EventSystems.IPointerClickHandler.OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
    private void Update();
    private void OnDestroy();
    private void OnApplicationPause(bool pauseStatus);
    private void OnDisable();
    private void _resetInput();
}

// Namespace: PRISM.Interactions.Drama.UI
public class DramaSubtitleView : UnityEngine.MonoBehaviour, PRISM.Adapters.Drama.UI.IDramaSubtitleView
{
    private UnityEngine.GameObject indicator;
    public void Show(bool isShow);
    public void ShowIndicator(bool isShow);
}

// Namespace: PRISM.Interactions.Drama.UI
public class DramaUIView : UnityEngine.MonoBehaviour, PRISM.Adapters.Drama.UI.IDramaUIView
{
    private PRISM.Interactions.Drama.UI.DramaScreenOperationView screenOperationView;
    private PRISM.Interactions.Drama.UI.DramaScreenOperationLegacyView screenOperationLegacyView;
    private PRISM.Interactions.Drama.UI.DramaMenuView menuView;
    private PRISM.Interactions.AdvTitleView titleView;
    private UnityEngine.CanvasGroup playSpeedUpViewCanvasGroup;
    private PRISM.Interactions.Drama.UI.DramaSubtitleView subtitleView;
    public PRISM.Adapters.Drama.UI.IDramaScreenOperationView ScreenOperationLegacyView { get; set; }
    public PRISM.Adapters.Drama.UI.IDramaScreenOperationView ScreenOperationView { get; set; }
    public PRISM.Adapters.Drama.UI.IDramaMenuView MenuView { get; set; }
    public PRISM.Adapters.Drama.UI.IDramaSubtitleView SubtitleView { get; set; }
    public PRISM.Adapters.IAdvTitleView TitleView { get; set; }
    public void Inject(PRISM.Interactions.Drama.UI.DramaSubtitleView subtitleView);
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(System.Threading.CancellationToken ct);
    public void Terminate();
    public void ShowPlaySpeedUpView(bool show);
}

// Namespace: PRISM.Interactions.Drama.UI
public class DramaLogCellScrollerView : PRISM.EnhancedListView<PRISM.Adapters.Drama.UI.DramaLogCellViewModel, PRISM.Interactions.Drama.UI.DramaLogScrollerContext>
{
    public System.IObservable<double> OnClickJumpButton { get; set; }
    public void StopVoice();
}

// Namespace: PRISM.Interactions.Drama.UI
public class DramaLogScrollerContext : PRISM.EnhancedListViewContext, System.IDisposable
{
    public UniRx.Subject<double> OnClickJumpButton;
    public UniRx.ReactiveProperty<CriWare.CriAtomExPlayback> VoicePlayback;
    public void Dispose();
}

// Namespace: PRISM.Interactions.Drama.UI
public class DramaConfirmSkipPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.Drama.UI.IDramaConfirmSkipPopupView, PRISM.Adapters.IClosablePopupFrame<PRISM.Adapters.Drama.UI.DramaConfirmSkipPopupResultType>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<PRISM.Adapters.Drama.UI.DramaConfirmSkipPopupResultType>
{
    private PRISM.Interactions.ToggleButtonView showPopupNextTimeToggleButton;
    private ENTERPRISE.UI.UITextMeshProUGUI notionText;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<PRISM.Adapters.Drama.UI.DramaConfirmSkipPopupResultType> onClosed;
    private PRISM.Interactions.PopupFrameParameter frameParameter;
    private PRISM.Interactions.IPopupFrameView parent;
    private Cysharp.Threading.Tasks.UniTask<PRISM.Adapters.Drama.UI.DramaConfirmSkipPopupResultType> onCloseRequested;
    public Cysharp.Threading.Tasks.UniTask<PRISM.Adapters.Drama.UI.DramaConfirmSkipPopupResultType> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Initialize(bool choiceExists, UniRx.IReactiveProperty<bool> needConfirmOnSkip);
    private ButtonInfoParameter _createButtonParameter(PRISM.Adapters.Drama.UI.DramaConfirmSkipPopupResultType resultType);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <Initialize>b__4_0();

    private class <>c__DisplayClass5_0
    {
        public PRISM.Interactions.Drama.UI.DramaConfirmSkipPopupView <>4__this;
        public PRISM.Adapters.Drama.UI.DramaConfirmSkipPopupResultType resultType;
        private void <_createButtonParameter>b__0();
        private void <_createButtonParameter>b__1();
        private void <_createButtonParameter>b__2();
    }
}

// Namespace: PRISM.Interactions.Drama.UI
public class DramaConfirmStoryJumpPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.Drama.UI.IDramaConfirmStoryJumpPopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private PRISM.Interactions.NewStoryCellView storyCellView;
    private PRISM.Interactions.ToggleButtonView showPopupNextTimeToggleButton;
    private ENTERPRISE.UI.UITextMeshProUGUI downloadSizeText;
    private ENTERPRISE.UI.UITextMeshProUGUI notionText;
    private PRISM.Interactions.ViewStateChanger needDownloadChanger;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.NewStoryCellViewModel storyCellViewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, UniRx.IReactiveProperty<bool> needConfirmOnJump, PRISM.Adapters.Story.IStoryDownloader storyDownloader, bool needVoice, System.Threading.CancellationToken ct);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__9_0();
    private void <CreateFrameParameter>b__9_1();
    private void <CreateFrameParameter>b__9_2();
}

// Namespace: PRISM.Interactions.Drama.UI
public class DramaConfirmUnreadChoicePopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.Drama.UI.IDramaConfirmUnreadChoicePopupView, PRISM.Adapters.IClosablePopupFrame<PRISM.Adapters.Drama.UI.DramaConfirmUnreadChoicePopupResult>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<PRISM.Adapters.Drama.UI.DramaConfirmUnreadChoicePopupResult>
{
    private PRISM.Interactions.ButtonView readFromStartButton;
    private PRISM.Interactions.ButtonView readFromChoiceButton;
    private PRISM.Interactions.ButtonView jumpToNextStoryButton;
    private ENTERPRISE.UI.UITextMeshProUGUI downloadSizeText;
    private PRISM.Interactions.ViewStateChanger needDownloadChanger;
    private PRISM.Interactions.ToggleButtonView skipFromNextTimeToggle;
    private ENTERPRISE.UI.UITextMeshProUGUI notionText;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<PRISM.Adapters.Drama.UI.DramaConfirmUnreadChoicePopupResult> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<PRISM.Adapters.Drama.UI.DramaConfirmUnreadChoicePopupResult> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Initialize(bool nextScenarioExists, UniRx.IReactiveProperty<bool> skipPopupFromNextTime);
    public void SetNextStoryDownloadSize(PRISM.Adapters.Story.IStorySize storySize, bool needVoice);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <Initialize>b__8_0(UniRx.Unit _);
    private void <Initialize>b__8_1(UniRx.Unit _);
    private void <Initialize>b__8_2(UniRx.Unit _);
    private void <CreateFrameParameter>b__12_0();
    private void <CreateFrameParameter>b__12_1();
}

// Namespace: PRISM.Interactions.Drama.Timeline
public class ClothBlendWeightMarker : PRISM.Interactions.Drama.DramaMarkerBase
{
    private float start;
    private float end;
    private double time;
    private UnityEngine.AnimationCurve easing;
    private PRISM.Interactions.Drama.DramaScene dramaScene;
    private double startTime;
    private System.Collections.Generic.Dictionary<MagicaCloth2.MagicaCloth, float> defaultBlendWeights;
    public void Invoke(UnityEngine.Playables.Playable origin, object context, PRISM.Interactions.Drama.DramaScene scene);
    private Cysharp.Threading.Tasks.UniTask _executeAsync();
    private void _setBlendWeight(float value);
    private void _rollback();

    private struct <_executeAsync>d__8 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Drama.Timeline.ClothBlendWeightMarker <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Drama.Timeline
public class DramaChoiceMixerBehaviour : PRISM.MixerBehaviourBase<PRISM.Interactions.Drama.DramaChoiceButtonGroupView>
{
    protected void Apply(UnityEngine.Timeline.TimelineClip timelineClip, double time);
    protected void NoHitClip(UnityEngine.Timeline.TimelineClip beforeClip, UnityEngine.Timeline.TimelineClip nextClip);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Interactions.Drama.Timeline.DramaChoiceData, PRISM.Adapters.Drama.DramaChoiceButtonViewModel> <>9__0_0;
        private PRISM.Adapters.Drama.DramaChoiceButtonViewModel <Apply>b__0_0(PRISM.Interactions.Drama.Timeline.DramaChoiceData x);
    }
}

// Namespace: PRISM.Interactions.Drama.Timeline
public class DramaChoicePlayableAsset : PRISM.PlayableAssetBase<PRISM.Interactions.Drama.Timeline.DramaChoicePlayableBehaviour>, UnityEngine.Timeline.ITimelineClipAsset
{
    public UnityEngine.Timeline.ClipCaps clipCaps { get; set; }
}

// Namespace: PRISM.Interactions.Drama.Timeline
public class DramaChoicePlayableBehaviour : UnityEngine.Playables.PlayableBehaviour
{
    public PRISM.Interactions.Drama.Timeline.DramaChoiceData[] labels;
}

// Namespace: PRISM.Interactions.Drama.Timeline
public class DramaChoiceData
{
    public string text;
    public string toLabel;
}

// Namespace: PRISM.Interactions.Drama.Timeline
public class DramaChoiceTrack : PRISM.TrackAssetBase<PRISM.Interactions.Drama.DramaChoiceButtonGroupView, PRISM.Interactions.Drama.Timeline.DramaChoiceMixerBehaviour>
{
}

// Namespace: PRISM.Interactions.Drama.Timeline
public class DramaLabelMixerBehaviour : UnityEngine.Playables.PlayableBehaviour
{
}

// Namespace: PRISM.Interactions.Drama.Timeline
public class DramaLabelPlayableAsset : UnityEngine.Playables.PlayableAsset, UnityEngine.Timeline.ITimelineClipAsset
{
    public PRISM.Interactions.Drama.Timeline.DramaLabelPlayableBehaviour behaviour;
    public UnityEngine.Timeline.ClipCaps clipCaps { get; set; }
    public UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go);
}

// Namespace: PRISM.Interactions.Drama.Timeline
public class DramaLabelPlayableBehaviour : UnityEngine.Playables.PlayableBehaviour
{
    public string label;
    public PRISM.Interactions.Drama.DramaLabelPlayableAssetType type;
}

// Namespace: PRISM.Interactions.Drama.Timeline
public class DramaLabelTrack : UnityEngine.Timeline.TrackAsset
{
    public UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner, int inputCount);
}

// Namespace: PRISM.Interactions.Drama.Timeline
public class ResetClothMarker : PRISM.Interactions.Drama.MarkerBase
{
    private bool keepPose;
    public void Invoke(UnityEngine.Playables.Playable origin, object context);
}

// Namespace: PRISM.Interactions.Drama.Timeline
public class SimulateClothMarker : PRISM.Interactions.Drama.MarkerBase
{
    private bool isReset;
    private int simulateCount;
    public void Invoke(UnityEngine.Playables.Playable origin, object context);
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=4063 135F499134BBB39455AA89591A4B8EEDD37E9841FEC73746BD36014D49901245;
    private static __StaticArrayInitTypeSize=6098 76A252A00530FAD949A3FA310AFD7928B1B4CE8C3136667D03EC0C14DC5223B0;

    private struct __StaticArrayInitTypeSize=4063 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=6098 : System.ValueType
    {
    }
}
