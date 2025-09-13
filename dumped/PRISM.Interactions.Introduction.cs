
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
public class IntroductionContentPlayerOverlayView : UnityEngine.MonoBehaviour, PRISM.Adapters.IIntroductionContentPlayerOverlayView, PRISM.Adapters.IClosableOverlayView<UniRx.Unit>, PRISM.Adapters.IOverlayView, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private UnityEngine.Transform contentPos;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClose;
    private PRISM.Interactions.Introduction.IIntroductionContentPlayerComponent player;
    private System.Collections.Generic.IReadOnlyList<string> prefabParameters;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(string prefabPath, System.Collections.Generic.IReadOnlyList<string> parameters, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();

    private struct <InitializeAsync>d__6 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.IntroductionContentPlayerOverlayView <>4__this;
        public System.Collections.Generic.IReadOnlyList<string> parameters;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public string prefabPath;
        public System.Threading.CancellationToken ct;
        private Awaiter<UnityEngine.GameObject> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <ShowAsync>d__7 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.IntroductionContentPlayerOverlayView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class IntroductionLauncherConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.IntroductionLauncherArgument>, PRISM.IIntroductionLauncherConnector
{
    protected PRISM.Adapters.IntroductionLauncherArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
}

// Namespace: PRISM.Interactions.Introduction
public class IntroductionCharacterSelectConnector : PRISM.Interactions.ViewConnector, PRISM.IIntroductionCharacterSelectConnector
{
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
}

// Namespace: PRISM.Interactions.Introduction
public class IntroductionCharacterSelectGridView : PRISM.Interactions.GridView<PRISM.Interactions.Introduction.IntroductionCharacterSelectGridViewCell, int, PRISM.Interactions.GridViewContextWithClick<int>>
{
    public System.IObservable<int> OnClick { get; set; }
    protected void SetupCellTemplate();

    private class CellGroup : DefaultCellGroup<int, PRISM.Interactions.GridViewContextWithClick<int>>
    {
    }
}

// Namespace: PRISM.Interactions.Introduction
public class IntroductionCharacterSelectGridViewCell : PRISM.Interactions.GridViewCell<int, PRISM.Interactions.GridViewContextWithClick<int>>
{
    private PRISM.Interactions.CharacterBaseIconView characterBaseIcon;
    private PRISM.Interactions.ButtonView button;
    private PRISM.AutoCancellationTokenSource canceller;
    public void UpdateContent(int characterId);
    private void OnDestroy();

    private class <>c__DisplayClass3_0
    {
        public PRISM.Interactions.Introduction.IntroductionCharacterSelectGridViewCell <>4__this;
        public int characterId;
        private void <UpdateContent>b__0(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.Introduction
public class IntroductionCharacterSelectView : UnityEngine.MonoBehaviour, PRISM.Adapters.IIntroductionCharacterSelectView
{
    private PRISM.Interactions.Introduction.IntroductionCharacterSelectGridView gridView;
    private PRISM.Interactions.Introduction.IntroductionUICharacterView uiCharacterView;
    private PRISM.Adapters.IntroductionCharacterSelectViewModel viewModel;
    public System.IObservable<int> OnSelectedCharacterOvservable { get; set; }
    public void Inject(PRISM.Adapters.IntroductionCharacterSelectViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public Cysharp.Threading.Tasks.UniTask SetupAsync();
    public void OnNextViewPreparation();
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
}

// Namespace: PRISM.Interactions.Introduction
public interface IIntroductionContentPlayerComponent
{
    public Cysharp.Threading.Tasks.UniTask PlayAsync(System.Collections.Generic.IReadOnlyList<string> parameters, System.Threading.CancellationToken ct);
}

// Namespace: PRISM.Interactions.Introduction
public class IntroductionMoviePlayer : UnityEngine.MonoBehaviour, PRISM.Interactions.Introduction.IIntroductionContentPlayerComponent
{
    private PRISM.MoviePlayer moviePlayer;
    public Cysharp.Threading.Tasks.UniTask PlayAsync(System.Collections.Generic.IReadOnlyList<string> parameters, System.Threading.CancellationToken ct);

    private struct <PlayAsync>d__1 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public System.Collections.Generic.IReadOnlyList<string> parameters;
        public PRISM.Interactions.Introduction.IntroductionMoviePlayer <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Introduction
public class IntroductionPausableMoviePlayer : UnityEngine.MonoBehaviour, PRISM.Interactions.Introduction.IIntroductionContentPlayerComponent
{
    private PRISM.Interactions.FullScreenMovieView movieView;
    public Cysharp.Threading.Tasks.UniTask PlayAsync(System.Collections.Generic.IReadOnlyList<string> parameters, System.Threading.CancellationToken ct);
}

// Namespace: PRISM.Interactions.Introduction
public class IntroductionUICharacterView : UnityEngine.MonoBehaviour
{
    private PRISM.UI.UICharacterViewer uiCharacterViewer;
    private PRISM.UI.CenteringObjectsOutsideSafeArea characterPositionAdjuster;
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.UnitIdol unitIdol, string cueSheetName);
    public Cysharp.Threading.Tasks.UniTask SetupHazukiVoiceMotionAsync(PRISM.UnitIdol unitIdol, PRISM.UI.UICharacterVoicePattern voicePattern, string cueSheetName);
    public void SetAnimation(string cueName);
    public void ReturnBackGroundFrom3D();
    public Cysharp.Threading.Tasks.UniTask ReleaseAsync();

    private class <>c__DisplayClass2_0
    {
        public PRISM.LiveCharacterController liveCharacterController;
        private bool <SetupAsync>b__0();
    }

    private class <>c__DisplayClass3_0
    {
        public PRISM.LiveCharacterController liveCharacterController;
        private bool <SetupHazukiVoiceMotionAsync>b__0();
    }

    private struct <SetupAsync>d__2 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Introduction.IntroductionUICharacterView <>4__this;
        public PRISM.UnitIdol unitIdol;
        public string cueSheetName;
        private <>c__DisplayClass2_0 <>8__1;
        private Awaiter<bool> <>u__1;
        private Awaiter <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <SetupHazukiVoiceMotionAsync>d__3 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Introduction.IntroductionUICharacterView <>4__this;
        public PRISM.UnitIdol unitIdol;
        public PRISM.UI.UICharacterVoicePattern voicePattern;
        public string cueSheetName;
        private <>c__DisplayClass3_0 <>8__1;
        private Awaiter<bool> <>u__1;
        private Awaiter <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Introduction
public class IntroductionLauncherView : UnityEngine.MonoBehaviour, PRISM.Adapters.IIntroductionLauncherView
{
}

// Namespace: PRISM.Interactions.Introduction
public class IntroductionLetterOverlayView : UnityEngine.MonoBehaviour, PRISM.Adapters.Introduction.IIntroductionLetterOverlayView, PRISM.Adapters.IClosableOverlayView<UniRx.Unit>, PRISM.Adapters.IOverlayView, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private UnityEngine.UI.Image letterImage;
    private ENTERPRISE.UI.UIButton closeButton;
    private ENTERPRISE.UI.UITextMeshProUGUI buttonText;
    private UnityEngine.Animator animator;
    private UniRx.Subject<UniRx.Unit> onNextStep;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClose;
    private System.IDisposable backKeyDisposable;
    private PRISM.Adapters.Introduction.IntroductionLetterOverlayViewModel viewModel;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.Introduction.IntroductionLetterOverlayViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    private Cysharp.Threading.Tasks.UniTask _executeAsync(System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask _startOpenAnimationAsync(System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask _showReceiveRewardPopupAsync(System.Threading.CancellationToken ct);

    private struct <ShowAsync>d__12 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Introduction.IntroductionLetterOverlayView <>4__this;
        public System.Threading.CancellationToken ct;
        private UnityEngine.UI.Image <>7__wrap1;
        private Awaiter<UnityEngine.Sprite> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_executeAsync>d__14 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public System.Threading.CancellationToken ct;
        public PRISM.Interactions.Introduction.IntroductionLetterOverlayView <>4__this;
        private Awaiter<CriWare.CriAtomExPlayback> <>u__1;
        private Awaiter <>u__2;
        private Awaiter<UniRx.Unit> <>u__3;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_startOpenAnimationAsync>d__15 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Introduction.IntroductionLetterOverlayView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Introduction
public class IntroductionLetterSoundConst
{
    private static PRISM.Definitions.SoundKey <OpenLetterBgm>k__BackingField;
    private static PRISM.Definitions.SoundKey <OpenLetterSe>k__BackingField;
    public PRISM.Definitions.SoundKey OpenLetterBgm { get; set; }
    public PRISM.Definitions.SoundKey OpenLetterSe { get; set; }
}

// Namespace: PRISM.Interactions.Introduction
public class IntroductionRewardBackgroundView : UnityEngine.MonoBehaviour
{
    private UnityEngine.GameObject characterLayout;
    private UnityEngine.GameObject producerLayout;
    private UnityEngine.Transform backgroundParent;
    private UnityEngine.Animator animator;
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Adapters.Introduction.IIntroductionRewardViewModel model, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void StartAnimation();

    private struct <SetupAsync>d__4 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Adapters.Introduction.IIntroductionRewardViewModel model;
        public PRISM.Interactions.Introduction.IntroductionRewardBackgroundView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private Awaiter<UnityEngine.GameObject> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Introduction
public class IntroductionRewardConnector : PRISM.Interactions.ViewConnector, PRISM.IIntroductionRewardConnector
{
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
}

// Namespace: PRISM.Interactions.Introduction
public class IntroductionRewardItemIcon : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.RewardItemIcon rewardItemIcon;
    private UnityEngine.Animator iconAnimator;
    public void Setup(PRISM.Module.Networking.IProductWithAmountStatus reward, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public Cysharp.Threading.Tasks.UniTask StartStampAnimationAsync(System.Threading.CancellationToken ct);

    private struct <StartStampAnimationAsync>d__3 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public System.Threading.CancellationToken ct;
        public PRISM.Interactions.Introduction.IntroductionRewardItemIcon <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Introduction
public class IntroductionRewardPanelView : UnityEngine.MonoBehaviour
{
    private UnityEngine.GameObject characterLayout;
    private UnityEngine.GameObject producerLayout;
    private PRISM.Interactions.Introduction.IntroductionRewardItemIcon characterRewardIcon;
    private PRISM.Interactions.Introduction.IntroductionRewardItemIcon producerRewardIcon;
    private UnityEngine.UI.RawImage characterRibbonImage;
    private UnityEngine.UI.RawImage characterNameImage;
    private ENTERPRISE.UI.UITextMeshProUGUI characterBirthDayText;
    private UnityEngine.Animator animator;
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Adapters.Introduction.IIntroductionRewardViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void StartLogoAnimation();
    public Cysharp.Threading.Tasks.UniTask StartStampAnimationAsync(PRISM.Adapters.Introduction.IIntroductionRewardViewModel viewModel, System.Threading.CancellationToken ct);

    private struct <SetupAsync>d__8 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Adapters.Introduction.IIntroductionRewardViewModel viewModel;
        public PRISM.Interactions.Introduction.IntroductionRewardPanelView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private PRISM.Adapters.Introduction.IntroductionCharacterBirthdayRewardViewModel <characterBirthdayViewModel>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <StartStampAnimationAsync>d__10 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Adapters.Introduction.IIntroductionRewardViewModel viewModel;
        public PRISM.Interactions.Introduction.IntroductionRewardPanelView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Introduction
public class IntroductionRewardView : UnityEngine.MonoBehaviour, PRISM.Adapters.Introduction.IIntroductionRewardView
{
    private PRISM.Interactions.Introduction.IntroductionRewardBackgroundView backgroundView;
    private PRISM.Interactions.Introduction.IntroductionRewardPanelView panelView;
    private PRISM.Interactions.Introduction.IntroductionUICharacterView uiCharacterView;
    private ENTERPRISE.UI.UIButton windowTapButton;
    private PRISM.Adapters.Introduction.IIntroductionRewardViewModel viewModel;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    private System.IDisposable backKeyDisposable;
    public System.IObservable<UniRx.Unit> OnClickButtonObservable { get; set; }
    public void Inject(PRISM.Adapters.Introduction.IIntroductionRewardViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public Cysharp.Threading.Tasks.UniTask SetupAsync();
    public Cysharp.Threading.Tasks.UniTask StartLogoAnimationAsync();
    public Cysharp.Threading.Tasks.UniTask StartStampAnimationAsync(System.Threading.CancellationToken ct);
    public void OnNextViewPreparation();
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private Cysharp.Threading.Tasks.UniTask _crackerAnimationAsync();
    private Cysharp.Threading.Tasks.UniTask _titleAnimationAsync();

    private struct <SetupAsync>d__10 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Introduction.IntroductionRewardView <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <StartLogoAnimationAsync>d__11 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Introduction.IntroductionRewardView <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <TerminateAsync>d__14 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Introduction.IntroductionRewardView <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_crackerAnimationAsync>d__15 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_titleAnimationAsync>d__16 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Introduction
public class IntroductionUnitSelectCell : PRISM.CommonListViewCell<PRISM.Adapters.Introduction.IntroductionUnitSelectCellData>
{
    private UnityEngine.UI.Image unitLogoImage;
    private ENTERPRISE.UI.UITextMeshProUGUI title;
    private System.IDisposable buttonDisposable;
    private System.Threading.CancellationTokenSource cts;
    public void UpdateContent(PRISM.Adapters.Introduction.IntroductionUnitSelectCellData cellData);
    private void OnDestroy();

    private class <>c__DisplayClass4_0
    {
        public PRISM.Interactions.Introduction.IntroductionUnitSelectCell <>4__this;
        public PRISM.Adapters.Introduction.IntroductionUnitSelectCellData cellData;
        private void <UpdateContent>b__0(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.Introduction
public class IntroductionUnitSelectCellList : PRISM.CommonListView<PRISM.Interactions.Introduction.IntroductionUnitSelectCell, PRISM.Adapters.Introduction.IntroductionUnitSelectCellData>
{
    private UniRx.Subject<int> onClickCellSubject;
    public System.IObservable<int> OnClickCell { get; set; }
    public void InitializeCellList(System.Collections.Generic.IEnumerable<PRISM.Adapters.Introduction.IntroductionUnitSelectCellData> cellDataList);
}

// Namespace: PRISM.Interactions.Introduction
public class IntroductionUnitSelectView : UnityEngine.MonoBehaviour
{
    private PRISM.UI.UICharacterViewer uiCharacterViewer;
    private PRISM.UI.CenteringObjectsOutsideSafeArea characterPositionAdjuster;
    private PRISM.Interactions.CommonTitleView titleView;
    private PRISM.Interactions.Introduction.IntroductionUnitSelectCellList unitSelectCellList;
    public System.IObservable<int> OnClickUnitSelectCell { get; set; }
    public void Inject(PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.Introduction.IIntroductionUnitSelectViewModel viewModel, System.Threading.CancellationToken ct);
    public void OnNextViewPreparation();
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();

    private struct <InitializeAsync>d__7 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Introduction.IntroductionUnitSelectView <>4__this;
        public PRISM.Adapters.Introduction.IIntroductionUnitSelectViewModel viewModel;
        private Awaiter<bool> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Introduction
public class IntroductionUnitLetterConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.Introduction.IntroductionUnitLetterArgument>, PRISM.Legacy.Introduction.IIntroductionUnitLetterConnector
{
    protected PRISM.Adapters.Introduction.IntroductionUnitLetterArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
}

// Namespace: PRISM.Interactions.Introduction
public class IntroductionUnitLetterView : UnityEngine.MonoBehaviour, PRISM.Adapters.Introduction.IIntroductionUnitLetterView
{
    private PRISM.Interactions.Introduction.IntroductionUnitSelectView unitSelectView;
    public System.IObservable<int> OnClickUnitSelectCell { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Adapters.Introduction.IntroductionUnitLetterViewModel unitLetterViewModel, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    public Cysharp.Threading.Tasks.UniTask ShowLetterOverlayAsync(PRISM.Adapters.Introduction.IntroductionLetterOverlayViewModel overlayViewModel, System.Threading.CancellationToken ct);
    private static Cysharp.Threading.Tasks.UniTask _playDefaultBgmAsync(System.Threading.CancellationToken ct);

    private struct <ShowLetterOverlayAsync>d__5 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Adapters.Introduction.IntroductionLetterOverlayViewModel overlayViewModel;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=2343 758684CB290E202ACA6E661D322E6B9324DDA2567E53C698DA65C2B665017A63;
    private static __StaticArrayInitTypeSize=1583 A6ADA55FB54823FEA2EE9D92F411A254BEE15C9C94DE9B501285A93EA855E780;

    private struct __StaticArrayInitTypeSize=1583 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=2343 : System.ValueType
    {
    }
}
