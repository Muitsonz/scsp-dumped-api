
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

// Namespace: PRISM.Interactions.Tutorial
public class TutorialIdolDescriptionCellView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView detailButton;
    private PRISM.Interactions.ButtonView voicePlayButton;
    private PRISM.Interactions.ViewStateChanger voicePlayButtonImageChanger;
    private UnityEngine.Animator animator;
    public System.IObservable<UniRx.Unit> OnClickDetailButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickVoicePlayButton { get; set; }
    public void SwitchVoicePlayButtonImage(bool isOn);
    public void PlayFirstViewAnimation();
    public void PlayFadeInAnimation(bool moveRight);
    public void FadeOutAnimation(bool moveRight);
    private void Awake();
}

// Namespace: PRISM.Interactions.Tutorial
public class TutorialIdolSelectConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.Tutorial.TutorialIdolSelectArgument>, PRISM.ITutorialIdolSelectConnector
{
    protected PRISM.Adapters.Tutorial.TutorialIdolSelectArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
}

// Namespace: PRISM.Interactions.Tutorial
public class TutorialIdolSelectDetailPanelView : UnityEngine.MonoBehaviour, PRISM.Adapters.Tutorial.ITutorialIdolSelectDetailPanelView
{
    private UnityEngine.Transform descriptionCellRoot;
    private PRISM.Interactions.Tutorial.TutorialIdolSelectSwipeChangerView swipeChangerView;
    private PRISM.Interactions.Tutorial.TutorialIdolSelectProduceIdolIconButtonView[] produceIdolIcons;
    private PRISM.Interactions.ButtonView backButton;
    private PRISM.Interactions.ButtonView selectIdolButton;
    private UnityEngine.Animator animator;
    private UnityEngine.Animator iconListAnimator;
    private UnityEngine.Animator buttonAreaAnimator;
    private System.Collections.Generic.List<PRISM.Interactions.Tutorial.TutorialIdolDescriptionCellView> idolDescriptionCellViews;
    private UniRx.Subject<UniRx.Unit> onClickBackButton;
    private UniRx.Subject<UniRx.Unit> onClickDetailButton;
    private UniRx.CompositeDisposable disposables;
    private string currentVoiceCueSheet;
    private PRISM.AutoCancellationTokenSource showCanceller;
    private PRISM.AutoCancellationTokenSource changeIdolCanceller;
    private PRISM.AutoCancellationTokenSource playVoiceCanceller;
    private System.Nullable<CriWare.CriAtomExPlayback> voicePlayback;
    public System.IObservable<UniRx.Unit> OnClickBackButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickSelectIdolButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickDetailButton { get; set; }
    public void Initialize();
    public Cysharp.Threading.Tasks.UniTask ShowAsync(UniRx.IReactiveProperty<int> selectedMstProduceIdolId, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void Hide();
    public void StopVoice();
    private Cysharp.Threading.Tasks.UniTask _updateViewAsync(System.ValueTuple<int, int> index, int mstProduceIdolId, System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask _setUpProduceIdolIconsAsync(System.Collections.Generic.IReadOnlyList<PRISM.Definitions.MstFirstProduceIdol> targetProduceIdols, UniRx.IReactiveProperty<int> selectedMstProduceIdolId, UniRx.IReactiveProperty<int> currentIndex, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private Cysharp.Threading.Tasks.UniTask _setUpIdolDescriptionPanelsAsync(System.Collections.Generic.IReadOnlyList<PRISM.Definitions.MstFirstProduceIdol> targetProduceIdols, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    private void Awake();
    private void OnDestroy();
    private Cysharp.Threading.Tasks.UniTask _playVoiceAsync(PRISM.Interactions.Tutorial.TutorialIdolDescriptionCellView cell, string cueName);
    private void <_setUpIdolDescriptionPanelsAsync>b__29_0(UniRx.Unit _);
    private bool <_playVoiceAsync>b__32_0();
    private bool <_playVoiceAsync>b__32_1();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Definitions.MstFirstProduceIdol, int> <>9__24_1;
        public static System.Func<PRISM.Definitions.MstFirstProduceIdol, int, bool> <>9__24_2;
        public static System.Func<PRISM.Definitions.MstFirstProduceIdol, int, System.ValueTuple<int, int>> <>9__28_0;
        private int <ShowAsync>b__24_1(PRISM.Definitions.MstFirstProduceIdol x);
        private bool <ShowAsync>b__24_2(PRISM.Definitions.MstFirstProduceIdol e, int state);
        private System.ValueTuple<int, int> <_setUpProduceIdolIconsAsync>b__28_0(PRISM.Definitions.MstFirstProduceIdol p, int i);
    }

    private class <>c__DisplayClass24_0
    {
        public int mstUnitId;
        public PRISM.Interactions.Tutorial.TutorialIdolSelectDetailPanelView <>4__this;
        public PRISM.Definitions.MstFirstProduceIdol[] targetProduceIdols;
        public UniRx.IReactiveProperty<int> selectedMstProduceIdolId;
        private bool <ShowAsync>b__0(PRISM.Definitions.MstFirstProduceIdol x);
        private void <ShowAsync>b__3(UniRx.Pair<int> index);
        private void <ShowAsync>b__4(UniRx.Unit _);
        private void <ShowAsync>b__5(UniRx.Unit _);
    }

    private class <>c__DisplayClass28_0
    {
        public UniRx.IReactiveProperty<int> selectedMstProduceIdolId;
        public UniRx.IReactiveProperty<int> currentIndex;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private Cysharp.Threading.Tasks.UniTask <_setUpProduceIdolIconsAsync>b__1(System.ValueTuple<int, int> mstProduceIdol, PRISM.Interactions.Tutorial.TutorialIdolSelectProduceIdolIconButtonView icon);
    }

    private class <>c__DisplayClass28_1
    {
        public PRISM.Interactions.Tutorial.TutorialIdolSelectProduceIdolIconButtonView icon;
        public System.ValueTuple<int, int> mstProduceIdol;
        public <>c__DisplayClass28_0 CS$<>8__locals1;
        private Cysharp.Threading.Tasks.UniTask <_setUpProduceIdolIconsAsync>b__2();

        private struct <<_setUpProduceIdolIconsAsync>b__2>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
        {
            public int <>1__state;
            public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
            public <>c__DisplayClass28_1 <>4__this;
            private Awaiter <>u__1;
            private void MoveNext();
            private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }

    private class <>c__DisplayClass29_0
    {
        public PRISM.Definitions.MstFirstProduceIdol produceIdol;
        public PRISM.Interactions.Tutorial.TutorialIdolDescriptionCellView cell;
        public PRISM.Interactions.Tutorial.TutorialIdolSelectDetailPanelView <>4__this;
        private void <_setUpIdolDescriptionPanelsAsync>b__1(UniRx.Unit _);
    }

    private struct <ShowAsync>d__24 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Tutorial.TutorialIdolSelectDetailPanelView <>4__this;
        public UniRx.IReactiveProperty<int> selectedMstProduceIdolId;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private <>c__DisplayClass24_0 <>8__1;
        private System.Threading.CancellationToken <showCt>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_playVoiceAsync>d__32 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Tutorial.TutorialIdolSelectDetailPanelView <>4__this;
        public string cueName;
        public PRISM.Interactions.Tutorial.TutorialIdolDescriptionCellView cell;
        private System.Threading.CancellationTokenSource <linkedTokenSource>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_setUpIdolDescriptionPanelsAsync>d__29 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Tutorial.TutorialIdolSelectDetailPanelView <>4__this;
        public System.Collections.Generic.IReadOnlyList<PRISM.Definitions.MstFirstProduceIdol> targetProduceIdols;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        private <>c__DisplayClass29_0 <>8__1;
        private System.Collections.Generic.IEnumerator<PRISM.Definitions.MstFirstProduceIdol> <>7__wrap1;
        private Awaiter<UnityEngine.GameObject> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_updateViewAsync>d__27 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public int mstProduceIdolId;
        public PRISM.Interactions.Tutorial.TutorialIdolSelectDetailPanelView <>4__this;
        public System.Threading.CancellationToken ct;
        public System.ValueTuple<int, int> index;
        private PRISM.Definitions.MstVoiceResource <mstVoiceResource>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Tutorial
public class TutorialIdolSelectIdolListPanelIdolView : UnityEngine.MonoBehaviour
{
    private int mstCharacterInfoId;
    private PRISM.Interactions.ButtonView button;
    private UnityEngine.Animator animator;
    private float landStripSecond;
    private PRISM.AutoCancellationTokenSource fadeInSeCanceller;
    public int MstCharacterInfoId { get; set; }
    public System.IObservable<int> OnClickIdolButton { get; set; }
    public void PlayFadeInAnimation();
    public void PlayFadeOutAnimation();
    public void PlaySelectAnimation();
    public void PlayIdleAnimation();
    public void ResetAnimation();
    private void Awake();
    private int <get_OnClickIdolButton>b__8_0(UniRx.Unit _);
    private bool <get_OnClickIdolButton>b__8_1(PRISM.Definitions.MstFirstProduceIdol x);

    private class <>c__DisplayClass9_0
    {
        public PRISM.Interactions.Tutorial.TutorialIdolSelectIdolListPanelIdolView <>4__this;
        public System.Threading.CancellationToken ct;
        private Cysharp.Threading.Tasks.UniTask <PlayFadeInAnimation>b__0();

        private struct <<PlayFadeInAnimation>b__0>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
        {
            public int <>1__state;
            public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
            public <>c__DisplayClass9_0 <>4__this;
            private Awaiter <>u__1;
            private void MoveNext();
            private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }
}

// Namespace: PRISM.Interactions.Tutorial
public class TutorialIdolSelectIdolListPanelUnitGroupView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.Tutorial.TutorialIdolSelectIdolListPanelIdolView[] idolViews;
    private UnityEngine.Animator unitAnimator;
    private UnityEngine.Animator catchphraseAnimator;
    private float fadeInIntervalDuration;
    private float landStripSecond;
    private PRISM.AutoCancellationTokenSource fadeInCanceller;
    public System.IObservable<int> OnClickIdolButton { get; set; }
    public Cysharp.Threading.Tasks.UniTask FadeInAsync();
    public void FadeOut(bool moveRight);
    public void PlaySelectAnimation(int mstProduceIdolId);
    public void PlayIdleAnimation();
    private void OnDestroy();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Interactions.Tutorial.TutorialIdolSelectIdolListPanelIdolView, System.IObservable<int>> <>9__7_0;
        public static System.Func<PRISM.Interactions.Tutorial.TutorialIdolSelectIdolListPanelIdolView, int, bool> <>9__10_0;
        private System.IObservable<int> <get_OnClickIdolButton>b__7_0(PRISM.Interactions.Tutorial.TutorialIdolSelectIdolListPanelIdolView x);
        private bool <PlaySelectAnimation>b__10_0(PRISM.Interactions.Tutorial.TutorialIdolSelectIdolListPanelIdolView e, int state);
    }

    private class <>c__DisplayClass8_0
    {
        public PRISM.Interactions.Tutorial.TutorialIdolSelectIdolListPanelUnitGroupView <>4__this;
        public System.Threading.CancellationToken ct;
        private Cysharp.Threading.Tasks.UniTask <FadeInAsync>b__0();

        private struct <<FadeInAsync>b__0>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
        {
            public int <>1__state;
            public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
            public <>c__DisplayClass8_0 <>4__this;
            private Awaiter <>u__1;
            private void MoveNext();
            private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }

    private struct <FadeInAsync>d__8 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Tutorial.TutorialIdolSelectIdolListPanelUnitGroupView <>4__this;
        private <>c__DisplayClass8_0 <>8__1;
        private int <index>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Tutorial
public class TutorialIdolSelectIdolListPanelView : UnityEngine.MonoBehaviour, PRISM.Adapters.Tutorial.ITutorialIdolSelectIdolListPanelView
{
    private UnityEngine.CanvasGroup canvasGroup;
    private PRISM.Interactions.Tutorial.TutorialIdolSelectUnitIconCarouselView unitIconCarouselView;
    private PRISM.Interactions.Tutorial.TutorialIdolSelectSwipeChangerView swipeChangerView;
    private PRISM.Interactions.Tutorial.TutorialIdolSelectIdolListPanelUnitGroupView[] unitGroupViews;
    private UnityEngine.Animator animator;
    private UnityEngine.Animator getIdolTextAnimator;
    private UniRx.Triggers.ObservableDragTrigger dragTrigger;
    private PRISM.UI.OnDragSender onDragSender;
    private UniRx.Subject<UniRx.Unit> onSelectIdol;
    private UniRx.CompositeDisposable disposables;
    private System.Threading.CancellationTokenSource cts;
    private UniRx.IReactiveProperty<int> selectedMstProduceIdolId;
    private string unitBgmCueSheetName;
    private string[] unitBgmCueNames;
    public System.IObservable<UniRx.Unit> OnSelectIdol { get; set; }
    public void Initialize(UniRx.IReactiveProperty<int> selectedMstProduceIdolId, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void Show(bool showCutInAnimation);
    public void Hide();
    private void _playCutInAnimation(bool animateUnitIconLogo);
    private void OnDestroy();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Definitions.MstUnit, bool> <>9__16_0;
        public static System.Func<PRISM.Definitions.MstUnit, int, PRISM.Adapters.Tutorial.TutorialIdolSelectUnitIconCarouselCellViewModel> <>9__16_1;
        public static System.Func<PRISM.Adapters.Tutorial.TutorialIdolSelectUnitIconCarouselCellViewModel, int, bool> <>9__16_2;
        private bool <Initialize>b__16_0(PRISM.Definitions.MstUnit x);
        private PRISM.Adapters.Tutorial.TutorialIdolSelectUnitIconCarouselCellViewModel <Initialize>b__16_1(PRISM.Definitions.MstUnit x, int index);
        private bool <Initialize>b__16_2(PRISM.Adapters.Tutorial.TutorialIdolSelectUnitIconCarouselCellViewModel e, int state);
    }

    private class <>c__DisplayClass16_0
    {
        public UniRx.IReactiveProperty<int> selectedMstProduceIdolId;
        public PRISM.Interactions.Tutorial.TutorialIdolSelectIdolListPanelView <>4__this;
        public System.Action<int> <>9__5;
        private void <Initialize>b__5(int mstProduceIdolId);
        private void <Initialize>b__3(UniRx.Pair<int> index);
        private void <Initialize>b__4(int index);
    }
}

// Namespace: PRISM.Interactions.Tutorial
public class TutorialIdolSelectProduceIdolIconButtonView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ProduceIdolIconView produceIdolIcon;
    private PRISM.Interactions.ButtonView buttonView;
    private PRISM.Interactions.ViewStateChanger selectStateChanger;
    private System.IDisposable disposable1;
    private System.IDisposable disposable2;
    private PRISM.AutoCancellationTokenSource canceller;
    public Cysharp.Threading.Tasks.UniTask SetUpAsync(int mstProduceIdolId, UniRx.IReactiveProperty<int> selectedMstProduceIdolId, int index, UniRx.IReactiveProperty<int> selectedIndex, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private void Awake();
    private void OnDestroy();

    private class <>c__DisplayClass6_0
    {
        public int mstProduceIdolId;
        public PRISM.Interactions.Tutorial.TutorialIdolSelectProduceIdolIconButtonView <>4__this;
        public UniRx.IReactiveProperty<int> selectedIndex;
        public int index;
        private void <SetUpAsync>b__0(int id);
        private void <SetUpAsync>b__1(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.Tutorial
public class TutorialIdolSelectSeConst
{
    public static string CueSheet;
    public static PRISM.Definitions.SoundKey LandStrip;
    public static PRISM.Definitions.SoundKey AppearStrip;
    public static PRISM.Definitions.SoundKey TapStrip;
}

// Namespace: PRISM.Interactions.Tutorial
public class TutorialIdolSelectSwipeChangerView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.SwipeAndArrowChangerView changerView;
    private UniRx.CompositeDisposable disposables;
    private UniRx.ReactiveProperty<int> index;
    public UniRx.IReactiveProperty<int> Index { get; set; }
    public void SetSe(PRISM.Definitions.SoundKey se);
    public void Setup(int firstIndex, int indexCount);
    private void OnDestroy();

    private class <>c__DisplayClass6_0
    {
        public PRISM.Interactions.Tutorial.TutorialIdolSelectSwipeChangerView <>4__this;
        public int indexCount;
        private void <Setup>b__0(int i);
        private void <Setup>b__1(int i);
    }
}

// Namespace: PRISM.Interactions.Tutorial
public class TutorialIdolSelectView : UnityEngine.MonoBehaviour, PRISM.Adapters.Tutorial.ITutorialIdolSelectView
{
    private PRISM.Interactions.Tutorial.TutorialIdolSelectIdolListPanelView idolListPanelView;
    private PRISM.Interactions.Tutorial.TutorialIdolSelectDetailPanelView detailPanelView;
    private UnityEngine.CanvasGroup hideScreenCanvasGroup;
    private PRISM.ITutorialSequence tutorialSequence;
    private PRISM.ITutorialSequence skipTutorialSequence;
    public PRISM.ITutorialSequence TutorialSequence { get; set; }
    public PRISM.ITutorialSequence SkipTutorialSequence { get; set; }
    public PRISM.Adapters.Tutorial.ITutorialIdolSelectIdolListPanelView IdolListPanelView { get; set; }
    public PRISM.Adapters.Tutorial.ITutorialIdolSelectDetailPanelView DetailPanelView { get; set; }
    public Cysharp.Threading.Tasks.UniTask LoadSeAsync(System.Threading.CancellationToken ct);
    public void UnloadSe();
    public Cysharp.Threading.Tasks.UniTask ShowHideScreenAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask PlayGashaMovieAsync(PRISM.Adapters.CharacterAcquisitionModel characterAcquisitionModel, System.Threading.CancellationToken ct);

    private struct <PlayGashaMovieAsync>d__16 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public System.Threading.CancellationToken ct;
        public PRISM.Adapters.CharacterAcquisitionModel characterAcquisitionModel;
        private object <>7__wrap1;
        private int <>7__wrap2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Tutorial
public class TutorialIdolSelectUnitIconCarouselCellView : PRISM.CarouselCell<PRISM.Adapters.Tutorial.TutorialIdolSelectUnitIconCarouselCellViewModel, PRISM.Interactions.Tutorial.TutorialIdolSelectUnitIconCarouselViewContext>
{
    private PRISM.Interactions.ButtonView buttonView;
    private UnityEngine.UI.Image unitIconImage;
    private UnityEngine.Animator animator;
    private System.IDisposable buttonDisposable;
    private PRISM.AutoCancellationTokenSource canceller;
    public void Initialize();
    public void UpdateContent(PRISM.Adapters.Tutorial.TutorialIdolSelectUnitIconCarouselCellViewModel data);
    public void UpdatePosition(float position);
    private void <Initialize>b__5_0();

    private class <>c__DisplayClass6_0
    {
        public PRISM.Interactions.Tutorial.TutorialIdolSelectUnitIconCarouselCellView <>4__this;
        public PRISM.Adapters.Tutorial.TutorialIdolSelectUnitIconCarouselCellViewModel data;
        private void <UpdateContent>b__0(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.Tutorial
public class TutorialIdolSelectUnitIconCarouselView : PRISM.Carousel<PRISM.Adapters.Tutorial.TutorialIdolSelectUnitIconCarouselCellViewModel, PRISM.Interactions.Tutorial.TutorialIdolSelectUnitIconCarouselViewContext>
{
    public System.IObservable<int> OnClickCell { get; set; }
    protected void Initialize();
    protected void _playSelectionChangedSE();
}

// Namespace: PRISM.Interactions.Tutorial
public class TutorialIdolSelectUnitIconCarouselViewContext : PRISM.DefaultCarouselContext, System.IDisposable
{
    private UniRx.Subject<int> onClickCell;
    public UniRx.ISubject<int> OnClickCell { get; set; }
    public void Dispose();
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=1353 6899CCDD47FF8E5B2D293CB67D052F35C23A57F7A50C9B076B7A0FF2F311B1AF;
    private static __StaticArrayInitTypeSize=887 7D48CC5EA552A0D01672665C0EC265917EDDD630B86D1DA0F83C5B8E30D1B9D9;

    private struct __StaticArrayInitTypeSize=887 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=1353 : System.ValueType
    {
    }
}
