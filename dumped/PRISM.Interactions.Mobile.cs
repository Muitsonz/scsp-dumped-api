
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
public class OurStreamLiveContentDetailPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IOurStreamLiveContentDetailPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private UnityEngine.RectTransform layoutRoot;
    private ENTERPRISE.UI.UITextMeshProUGUI liveTitleLabelText;
    private ENTERPRISE.UI.UITextMeshProUGUI liveTitleText;
    private ENTERPRISE.UI.UITextMeshProUGUI detailLabelText;
    private ENTERPRISE.UI.UITextMeshProUGUI detailText;
    private ENTERPRISE.UI.UITextMeshProUGUI dateLabelText;
    private ENTERPRISE.UI.UITextMeshProUGUI dateText;
    private UnityEngine.GameObject limitDateArea;
    private ENTERPRISE.UI.UITextMeshProUGUI limitDateLabelText;
    private ENTERPRISE.UI.UITextMeshProUGUI limitDateText;
    private ENTERPRISE.UI.UITextMeshProUGUI streamerLabelText;
    private ENTERPRISE.UI.UITextMeshProUGUI streamerText;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClick;
    private PRISM.Interactions.IPopupFrameView parent;
    public UnityEngine.RectTransform Rect { get; set; }
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void Initialize(string title, string description, System.Nullable<System.DateTime> date, System.Nullable<System.DateTime> limitDate, System.Collections.Generic.IReadOnlyList<int> streamerIdList);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void _setup(string title, string description, System.Nullable<System.DateTime> date, System.Nullable<System.DateTime> limitDate, System.Collections.Generic.IReadOnlyList<int> streamerIdList);
    private void <CreateFrameParameter>b__13_0();
    private void <CreateFrameParameter>b__13_1();
}

// Namespace: PRISM.Interactions
public class OurStreamTicketConfirmPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IOurStreamTicketConfirmPopupView, PRISM.Adapters.IClosablePopupFrame<OurStreamTicketConfirmPopupResult>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<OurStreamTicketConfirmPopupResult>
{
    private ENTERPRISE.UI.UITextMeshProUGUI topMessageText;
    private ENTERPRISE.UI.UITextMeshProUGUI beforText;
    private ENTERPRISE.UI.UITextMeshProUGUI afterText;
    private ENTERPRISE.UI.UITextMeshProUGUI itemText;
    private PRISM.Interactions.ButtonView itemButton;
    private UnityEngine.UI.RawImage itemImage;
    private UnityEngine.UI.RawImage miniItemImage;
    private ENTERPRISE.UI.UITextMeshProUGUI cationText;
    private ENTERPRISE.UI.UITextMeshProUGUI specifiedCommercialText;
    private PRISM.Interactions.ButtonView specifiedCommercialButton;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<OurStreamTicketConfirmPopupResult> onClosed;
    private PRISM.Interactions.PopupFrameParameter frameParameter;
    private PRISM.Adapters.OurStreamTicketConfirmPopupViewModel viewModel;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<OurStreamTicketConfirmPopupResult> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void Setup(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Adapters.OurStreamTicketConfirmPopupViewModel viewModel);
    private FooterInfoParameter _getFooterParamater();
    private void _setContentsText();
    private Cysharp.Threading.Tasks.UniTask _showShopOverlayAsync(System.Threading.CancellationToken ct);
    private void _onDecideButtonClicked();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();

    private class <>c__DisplayClass16_0
    {
        public PRISM.Interactions.OurStreamTicketConfirmPopupView <>4__this;
        public PRISM.Adapters.OurStreamTicketConfirmPopupViewModel viewModel;
        public System.Threading.CancellationToken ct;
        private void <Setup>b__2();
        private void <Setup>b__0(UniRx.Unit _);
        private void <Setup>b__1(UniRx.Unit _);
    }

    private class <>c__DisplayClass17_0
    {
        public PRISM.Interactions.OurStreamTicketConfirmPopupView <>4__this;
        public OurStreamTicketConfirmPopupResult centerResult;
        private void <_getFooterParamater>b__0();
        private void <_getFooterParamater>b__1();
        private void <_getFooterParamater>b__2();
    }

    private struct <_showShopOverlayAsync>d__19 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public System.Threading.CancellationToken ct;
        public PRISM.Interactions.OurStreamTicketConfirmPopupView <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class OurStreamTicketDetailPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IOurStreamTicketDetailPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private ENTERPRISE.UI.UITextMeshProUGUI itemNameText;
    private ENTERPRISE.UI.UITextMeshProUGUI itemAmountText;
    private ENTERPRISE.UI.UITextMeshProUGUI itemInfoText;
    private ENTERPRISE.OutGame.RewardItem itemIcon;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Initialize(PRISM.Adapters.Mobile.OurStreamTicketModel ticketModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    private FooterInfoParameter _getFooterParamater();
    private Cysharp.Threading.Tasks.UniTask _showShopOverlayAsync(System.Threading.CancellationToken ct);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <Initialize>b__7_0(PRISM.Module.Networking.IHavingProductStatus ticket);
    private void <CreateFrameParameter>b__8_0();
    private void <_getFooterParamater>b__9_0();
    private void <_getFooterParamater>b__9_1();

    private struct <_showShopOverlayAsync>d__10 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Mobile
public class CallHistoryCellView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView button;
    private ENTERPRISE.UI.UITextMeshProUGUI dateText;
    private ENTERPRISE.UI.UITextMeshProUGUI titleText;
    private UnityEngine.GameObject noticeBadge;
    public System.IObservable<UniRx.Unit> OnClickCell { get; set; }
    public void Initialize(PRISM.Adapters.Mobile.CallHistoryCellViewModel viewModel);
}

// Namespace: PRISM.Interactions.Mobile
public class CallHistoryScreenView : UnityEngine.MonoBehaviour, PRISM.Adapters.Mobile.ICallHistoryScreenView
{
    private PRISM.Interactions.Mobile.MobileScreenHeader header;
    private UnityEngine.GameObject emptyView;
    private ENTERPRISE.UI.UITextMeshProUGUI emptyText;
    private UnityEngine.UI.Image groupIconImage;
    private UnityEngine.Transform buttonParent;
    private PRISM.Interactions.Mobile.CallHistoryCellView cellPrefab;
    private PRISM.Interactions.Mobile.MobileScreenFader screenFader;
    private UnityEngine.UI.ScrollRect scrollRect;
    private UniRx.Subject<int> onClickCallHistoryCell;
    public System.IObservable<int> OnClickCallHistoryCell { get; set; }
    public float GetCurrentScrollPosition();
    public void SetScrollPosition(float scrollPosition);
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.Mobile.CallHistoryScreenViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public void Terminate();
    private void <Terminate>b__14_0();

    private class <>c__DisplayClass13_0
    {
        public PRISM.Adapters.Mobile.CallHistoryCellViewModel buttonCellViewModel;
        public PRISM.Interactions.Mobile.CallHistoryScreenView <>4__this;
        private void <InitializeAsync>b__0(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.Mobile
public class CallPlaybackExecutorView : UnityEngine.MonoBehaviour, PRISM.Adapters.Mobile.ICallPlaybackExecutorView
{
    private float displayTextDurationRate;
    private float stopButtonFadeInSecond;
    private float fadedBgmVolume;
    private float fadeOutSecond;
    private float fadeInSecond;
    private UnityEngine.UI.Image userIconImage;
    private ENTERPRISE.UI.UITextMeshProUGUI userName;
    private UnityEngine.GameObject textBoxBody;
    private PRISM.Interactions.ViewStateChanger textBoxStateChanger;
    private ENTERPRISE.UI.UITextMeshProUGUI bodyText;
    private UnityEngine.GameObject pageFeed;
    private PRISM.Interactions.ButtonView replayButton;
    private ENTERPRISE.UI.UITextMeshProUGUI replayButtonText;
    private PRISM.Interactions.ButtonView stopButton;
    private UnityEngine.CanvasGroup stopButtonCanvasGroup;
    private PRISM.Interactions.ButtonView touchArea;
    private PRISM.Adapters.Mobile.CallPlaybackExecutorViewModel viewModel;
    private bool isClicked;
    private System.Action stopCurrentVoiceAction;
    private System.IDisposable touchAreaButtonDisposable;
    public System.IObservable<UniRx.Unit> OnClickReplayButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickStopButton { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.Mobile.CallPlaybackExecutorViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public void Terminate();
    public Cysharp.Threading.Tasks.UniTask StartCallAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask FinishCallAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask PlayCallsAsync(System.Threading.CancellationToken ct);
    private void _showStopButton(bool isActive, bool needFadeAnimation);
    public Cysharp.Threading.Tasks.UniTask FadeInBgmAsync(System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask _fadeOutBgmAsync(System.Threading.CancellationToken ct);
    public void StopCurrentCallVoice();
    private DG.Tweening.Tween _createTextAnimationTween(string text);
    private Cysharp.Threading.Tasks.UniTask _playOneCallAsync(PRISM.Adapters.Mobile.ICallPlaybackOneCallViewModel oneCall, System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask _waitUntilClickedOrPhoneCallEndedAsync(DG.Tweening.Tween tween, System.Func<bool> isVoiceStopped, System.Action stopVoice, bool isProducer, System.Threading.CancellationToken ct);
    private void <InitializeAsync>b__24_0(UniRx.Unit _);

    private class <>c
    {
        public static <>c <>9;
        public static DG.Tweening.TweenCallback<float> <>9__30_0;
        public static DG.Tweening.TweenCallback<float> <>9__31_0;
        private void <FadeInBgmAsync>b__30_0(float value);
        private void <_fadeOutBgmAsync>b__31_0(float value);
    }

    private class <>c__DisplayClass26_0
    {
        public CriWare.CriAtomExPlayback playBack;
        private bool <StartCallAsync>b__0();
    }

    private class <>c__DisplayClass34_0
    {
        public CriWare.CriAtomExPlayback playBack;
        private void <_playOneCallAsync>b__0();
        private bool <_playOneCallAsync>b__1();
    }

    private class <>c__DisplayClass34_1
    {
        public PRISM.Interactions.Mobile.MobileCallPlaybackPlayerForProducer wordOnSePlayer;
        private void <_playOneCallAsync>b__2();
        private bool <_playOneCallAsync>b__3();
    }

    private class <>c__DisplayClass35_0
    {
        public PRISM.Interactions.Mobile.CallPlaybackExecutorView <>4__this;
        public System.Func<bool> isVoiceStopped;
        public DG.Tweening.Tween tween;
        private bool <_waitUntilClickedOrPhoneCallEndedAsync>b__0();
        private bool <_waitUntilClickedOrPhoneCallEndedAsync>b__1();
        private bool <_waitUntilClickedOrPhoneCallEndedAsync>b__2();
    }

    private struct <FinishCallAsync>d__27 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Mobile.CallPlaybackExecutorView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <PlayCallsAsync>d__28 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Mobile.CallPlaybackExecutorView <>4__this;
        public System.Threading.CancellationToken ct;
        private int <i>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <StartCallAsync>d__26 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Mobile.CallPlaybackExecutorView <>4__this;
        public System.Threading.CancellationToken ct;
        private <>c__DisplayClass26_0 <>8__1;
        private System.Threading.CancellationTokenSource <linkedTokenSource>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_playOneCallAsync>d__34 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public System.Threading.CancellationToken ct;
        public PRISM.Interactions.Mobile.CallPlaybackExecutorView <>4__this;
        public PRISM.Adapters.Mobile.ICallPlaybackOneCallViewModel oneCall;
        private <>c__DisplayClass34_0 <>8__1;
        private <>c__DisplayClass34_1 <>8__2;
        private System.Threading.CancellationTokenSource <tokenSource>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_waitUntilClickedOrPhoneCallEndedAsync>d__35 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Mobile.CallPlaybackExecutorView <>4__this;
        public System.Func<bool> isVoiceStopped;
        public DG.Tweening.Tween tween;
        public System.Threading.CancellationToken ct;
        private <>c__DisplayClass35_0 <>8__1;
        public bool isProducer;
        public System.Action stopVoice;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Mobile
public class CallPlaybackScreenView : UnityEngine.MonoBehaviour, PRISM.Adapters.Mobile.ICallPlaybackScreenView
{
    private PRISM.Interactions.Mobile.CallPlaybackExecutorView callPlaybackExecutorView;
    private PRISM.Interactions.Mobile.MobileScreenBackground backGround;
    private PRISM.Interactions.Mobile.MobileScreenFader screenFader;
    public PRISM.Interactions.Mobile.CallPlaybackExecutorView GetCallPlaybackExecutorView();
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(int phoneGroupId, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public void Terminate();
    public void StopAllVoice();
    private void <Terminate>b__5_0();

    private struct <InitializeAsync>d__4 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public int phoneGroupId;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        public PRISM.Interactions.Mobile.CallPlaybackScreenView <>4__this;
        private Awaiter<UnityEngine.Sprite> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Mobile
public class MobileCallPlaybackPlayerForProducer
{
    private System.TimeSpan delayTime;
    private bool <IsPlaying>k__BackingField;
    public bool IsPlaying { get; set; }
    public void Play(string text);
    public void Stop();

    private class <>c__DisplayClass5_0
    {
        public PRISM.Interactions.Mobile.MobileCallPlaybackPlayerForProducer <>4__this;
        public int textLength;
        private Cysharp.Threading.Tasks.UniTask <Play>b__0();

        private struct <<Play>b__0>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
        {
            public int <>1__state;
            public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
            public <>c__DisplayClass5_0 <>4__this;
            private int <i>5__2;
            private Awaiter <>u__1;
            private void MoveNext();
            private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }
}

// Namespace: PRISM.Interactions.Mobile
public class CallTopPhoneGroupCellView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView userButton;
    private UnityEngine.UI.Image iconImage;
    private ENTERPRISE.UI.UITextMeshProUGUI userNameText;
    private UnityEngine.GameObject noticeBadge;
    public System.IObservable<UniRx.Unit> OnClickUserButton { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.Mobile.CallTopPhoneGroupCellViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    private void Awake();
}

// Namespace: PRISM.Interactions.Mobile
public class CallTopScreenView : UnityEngine.MonoBehaviour, PRISM.Adapters.Mobile.ICallTopScreenView
{
    private PRISM.Interactions.Mobile.MobileScreenHeader header;
    private PRISM.Interactions.Mobile.MobileHeaderTabGroup headerTabGroup;
    private UnityEngine.Transform[] buttonParents;
    private PRISM.Interactions.Mobile.CallTopPhoneGroupCellView phoneGroupCellPrefab;
    private PRISM.Interactions.Mobile.MobileScreenFader screenFader;
    private UnityEngine.UI.ScrollRect[] scrollRects;
    private UniRx.Subject<int> onClickUserButton;
    public System.IObservable<int> OnClickHeaderTab { get; set; }
    public System.IObservable<int> OnClickCallGroupButton { get; set; }
    public float GetCurrentScrollPosition(Order order);
    public void SetScrollPosition(Order order, float scrollPosition);
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.Mobile.CallTopScreenViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public void Terminate();
    private Cysharp.Threading.Tasks.UniTask _createPhoneGroupButtonsAsync(Order order, System.Collections.Generic.IEnumerable<PRISM.Adapters.Mobile.CallTopPhoneGroupCellViewModel> cellViewModels, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    private void <Terminate>b__14_0();

    private class <>c__DisplayClass15_0
    {
        public int phoneUserId;
        public PRISM.Interactions.Mobile.CallTopScreenView <>4__this;
        private void <_createPhoneGroupButtonsAsync>b__0(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.Mobile
public class ChainGroupMemberButton : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UIButton userButton;
    private UnityEngine.UI.Image iconImage;
    private ENTERPRISE.UI.UITextMeshProUGUI userNameText;
    public System.IObservable<UniRx.Unit> OnClickUserButton { get; set; }
    public void SetUpUserName(string userName);
    public void SetNameColor(ENTERPRISE.UI.TextFontColorId fontColorId, ENTERPRISE.UI.TextOutlineColorId outlineColorId);
    public void SetUpIconImage(UnityEngine.Sprite iconSprite);
    private void Awake();
}

// Namespace: PRISM.Interactions.Mobile
public class ChainGroupMemberScreenView : UnityEngine.MonoBehaviour, PRISM.Adapters.Mobile.IChainGroupMemberScreenView
{
    private PRISM.Interactions.Mobile.MobileScreenHeader header;
    private PRISM.Interactions.Mobile.MobileScreenBackground background;
    private UnityEngine.Transform buttonParent;
    private PRISM.Interactions.Mobile.ChainGroupMemberButton buttonPrefab;
    private UnityEngine.UI.ScrollRect scrollRect;
    private PRISM.Interactions.Mobile.MobileScreenFader screenFader;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    private UniRx.Subject<int> onClickUserButtonSubject;
    public System.IObservable<int> OnClickUserButton { get; set; }
    public float GetCurrentScrollPosition();
    public void SetScrollPosition(float scrollPosition);
    public void Inject(PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void Terminate();
    public void SetUpHeader(int chainGroupId);
    public Cysharp.Threading.Tasks.UniTask SetUpBackgroundAsync(int chainGroupId, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask InstantiateButtonsAsync(int chainGroupId, System.Threading.CancellationToken ct);
    private void <Terminate>b__13_0();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<int, bool> <>9__16_2;
        private bool <InstantiateButtonsAsync>b__16_2(int x);
    }

    private class <>c__DisplayClass16_0
    {
        public PRISM.Interactions.Mobile.ChainGroupMemberScreenView <>4__this;
        public System.Threading.CancellationToken ct;
        public PRISM.Definitions.MstChainUser mstChainUserProducer;
        public PRISM.Interactions.Mobile.ChainGroupMemberButton producerButton;
        private void <InstantiateButtonsAsync>b__0(UniRx.Unit _);
        private Cysharp.Threading.Tasks.UniTask <InstantiateButtonsAsync>b__1();

        private struct <<InstantiateButtonsAsync>b__1>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
        {
            public int <>1__state;
            public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
            public <>c__DisplayClass16_0 <>4__this;
            private Awaiter<UnityEngine.Sprite> <>u__1;
            private void MoveNext();
            private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }

    private class <>c__DisplayClass16_1
    {
        public int chainUserId;
        public <>c__DisplayClass16_0 CS$<>8__locals1;
        private void <InstantiateButtonsAsync>b__3(UniRx.Unit _);
    }

    private class <>c__DisplayClass16_2
    {
        public PRISM.Definitions.MstChainUser mstChainUser;
        public PRISM.Interactions.Mobile.ChainGroupMemberButton button;
        public <>c__DisplayClass16_1 CS$<>8__locals2;
        private Cysharp.Threading.Tasks.UniTask <InstantiateButtonsAsync>b__4();

        private struct <<InstantiateButtonsAsync>b__4>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
        {
            public int <>1__state;
            public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
            public <>c__DisplayClass16_2 <>4__this;
            private Awaiter<UnityEngine.Sprite> <>u__1;
            private void MoveNext();
            private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }

    private struct <SetUpBackgroundAsync>d__15 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public int chainGroupId;
        public PRISM.Interactions.Mobile.ChainGroupMemberScreenView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter<UnityEngine.Sprite> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Mobile
public class ChainGroupTextColorTypeExtensions
{
    public static System.ValueTuple<ENTERPRISE.UI.TextFontColorId, ENTERPRISE.UI.TextOutlineColorId> ToColor(PRISM.Definitions.ChainGroupTextColorType textColorType);
}

// Namespace: PRISM.Interactions.Mobile
public class ChainProfileScreenView : UnityEngine.MonoBehaviour, PRISM.Adapters.Mobile.IChainProfileScreenView
{
    private PRISM.Interactions.Mobile.MobileScreenBackground background;
    private UnityEngine.UI.Image profileIconImage;
    private ENTERPRISE.UI.UITextMeshProUGUI userNameText;
    private ENTERPRISE.UI.UITextMeshProUGUI unitNameText;
    private ENTERPRISE.UI.UITextMeshProUGUI commentText;
    private PRISM.Interactions.Mobile.MobileScreenFader screenFader;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    public void Inject(PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void Terminate();
    public Cysharp.Threading.Tasks.UniTask SetUpBackgroundImageAsync(int chainUserId, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask SetUpIconImageAsync(int chainUserId, System.Threading.CancellationToken ct);
    public void SetUpText(int chainUserId);
    private void <Terminate>b__8_0();

    private struct <SetUpBackgroundImageAsync>d__9 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public int chainUserId;
        public PRISM.Interactions.Mobile.ChainProfileScreenView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter<UnityEngine.Sprite> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Mobile
public class ChainTalkCellBalloon : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.Image balloonImage;
    private ENTERPRISE.UI.UITextMeshProUGUI balloonText;
    public void Initialize(PRISM.Adapters.Mobile.ChainTalkCellBalloonData data);
    private void _resizeBalloon(TMPro.TMP_Text text);
}

// Namespace: PRISM.Interactions.Mobile
public class ChainTalkCellBase : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.Mobile.ChainTalkCellHeader header;
    private PRISM.Interactions.Mobile.ChainTalkCellContentContainer contentContainer;
    public System.IObservable<int> OnClickIcon { get; set; }
    public System.IObservable<PRISM.Adapters.Mobile.ChainTalkCellThumbnailData> OnClickThumbnail { get; set; }
    public System.IObservable<PRISM.Adapters.Mobile.ChainTalkCellMovieData> OnClickMovie { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.Mobile.IChainTalkCellData cellData, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public void ShowContent(bool isActive);
}

// Namespace: PRISM.Interactions.Mobile
public class ChainTalkCellContentContainer : UnityEngine.MonoBehaviour
{
    private UnityEngine.Transform contentPos;
    private PRISM.Interactions.Mobile.ChainTalkCellBalloon balloon;
    private PRISM.Interactions.Mobile.ChainTalkCellStamp stamp;
    private PRISM.Interactions.Mobile.ChainTalkCellThumbnail thumbnail;
    private PRISM.Interactions.Mobile.ChainTalkCellMovie movie;
    public System.IObservable<PRISM.Adapters.Mobile.ChainTalkCellThumbnailData> OnClickThumbnail { get; set; }
    public System.IObservable<PRISM.Adapters.Mobile.ChainTalkCellMovieData> OnClickMovie { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.Mobile.IChainTalkCellData cellData, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public void ShowContent(bool isActive);
    private void _hideAll();

    private struct <InitializeAsync>d__9 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Mobile.ChainTalkCellContentContainer <>4__this;
        public PRISM.Adapters.Mobile.IChainTalkCellData cellData;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Mobile
public class ChainTalkCellHeader : UnityEngine.MonoBehaviour
{
    private UnityEngine.GameObject iconBody;
    private UnityEngine.UI.Image iconImage;
    private ENTERPRISE.UI.UIButton iconButton;
    private ENTERPRISE.UI.UITextMeshProUGUI talkerNameText;
    private PRISM.Adapters.Mobile.ChainTalkCellHeaderData data;
    public System.IObservable<int> OnClickIcon { get; set; }
    public void Show(bool isActive);
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.Mobile.ChainTalkCellHeaderData data, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    private bool <get_OnClickIcon>b__6_0(UniRx.Unit _);
    private int <get_OnClickIcon>b__6_1(UniRx.Unit _);
}

// Namespace: PRISM.Interactions.Mobile
public class ChainTalkCellMovie : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.Image movieThumbnailImage;
    private PRISM.Interactions.ButtonView movieButton;
    private PRISM.Adapters.Mobile.ChainTalkCellMovieData data;
    public System.IObservable<PRISM.Adapters.Mobile.ChainTalkCellMovieData> OnClick { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.Mobile.ChainTalkCellMovieData data, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    private PRISM.Adapters.Mobile.ChainTalkCellMovieData <get_OnClick>b__4_0(UniRx.Unit _);
}

// Namespace: PRISM.Interactions.Mobile
public class ChainTalkCellStamp : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.Image image;
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.Mobile.ChainTalkCellStampData data, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
}

// Namespace: PRISM.Interactions.Mobile
public class ChainTalkCellThumbnail : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.Mobile.MobileThumbnail thumbnail;
    private PRISM.Adapters.Mobile.ChainTalkCellThumbnailData data;
    public System.IObservable<PRISM.Adapters.Mobile.ChainTalkCellThumbnailData> OnClick { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.Mobile.ChainTalkCellThumbnailData data, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    private PRISM.Adapters.Mobile.ChainTalkCellThumbnailData <get_OnClick>b__3_0(UniRx.Unit _);
}

// Namespace: PRISM.Interactions.Mobile
public class ChainTalkSeparatorCell : PRISM.EnhancedListViewCell<PRISM.Adapters.Mobile.IChainTalkCellData, PRISM.Interactions.Mobile.ChainTalkReadScrollerViewContext>
{
}

// Namespace: PRISM.Interactions.Mobile
public class ChainTalkChoiceButtonGroup : UnityEngine.MonoBehaviour
{
    private UnityEngine.GameObject buttonParent;
    private UnityEngine.Animator animator;
    private ChainTalkChoiceButton[] choiceButtons;
    private bool isWaiting;
    private int choiceIndex;
    private UniRx.Subject<bool> onShowSubject;
    private int button2;
    private int button3;
    public System.IObservable<bool> OnShow { get; set; }
    public Cysharp.Threading.Tasks.UniTask HideAsync(bool needsWait, System.Threading.CancellationToken ct);
    public void Show(System.Collections.Generic.IEnumerable<string> buttonLabels);
    public Cysharp.Threading.Tasks.UniTask<int> WaitUntilAnyButtonClicked(System.Threading.CancellationToken ct);
    private void Start();
    private bool <WaitUntilAnyButtonClicked>b__13_0();

    private class ChainTalkChoiceButton
    {
        private ENTERPRISE.UI.UIButton button;
        private ENTERPRISE.UI.UITextMeshProUGUI text;
        public ENTERPRISE.UI.UIButton Button { get; set; }
        public ENTERPRISE.UI.UITextMeshProUGUI Text { get; set; }
    }

    private class <>c__DisplayClass14_0
    {
        public int tmp;
        public PRISM.Interactions.Mobile.ChainTalkChoiceButtonGroup <>4__this;
        private void <Start>b__0();
    }

    private struct <HideAsync>d__11 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public bool needsWait;
        public System.Threading.CancellationToken ct;
        public PRISM.Interactions.Mobile.ChainTalkChoiceButtonGroup <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <WaitUntilAnyButtonClicked>d__13 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<int> <>t__builder;
        public PRISM.Interactions.Mobile.ChainTalkChoiceButtonGroup <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Mobile
public class ChainTalkHamburgerButton : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UIButton button;
    private UnityEngine.UI.Image image;
    public System.IObservable<UniRx.Unit> OnClickAsObservable();
    public void SetEnabled(bool isEnabled, bool needsFade);
}

// Namespace: PRISM.Interactions.Mobile
public class ChainTalkMenuButton : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UIButton button;
    private ENTERPRISE.UI.UITextMeshProUGUI label;
    public System.IObservable<UniRx.Unit> OnClick { get; set; }
    public void SetText(string text);
}

// Namespace: PRISM.Interactions.Mobile
public class ChainTalkScreenView : UnityEngine.MonoBehaviour, PRISM.Adapters.Mobile.IChainTalkScreenView
{
    private PRISM.Interactions.Mobile.MobileScreenBackground background;
    private PRISM.Interactions.Mobile.MobileScreenHeader header;
    private UnityEngine.GameObject loadingBackgroundBody;
    private UnityEngine.UI.Image loadingBackgroundImage;
    private ENTERPRISE.UI.UIButton touchArea;
    private PRISM.Interactions.Mobile.ChainTalkHamburgerButton hamburgerButton;
    private UnityEngine.GameObject menuButtonParent;
    private PRISM.Interactions.Mobile.ChainTalkMenuButton profileMenuButton;
    private PRISM.Interactions.Mobile.ChainTalkMenuButton groupMemberMenuButton;
    private PRISM.Interactions.Mobile.ChainTalkMenuButton talkHistoryMenuButton;
    private ENTERPRISE.UI.UITextMeshProUGUI placeholderText;
    private PRISM.Interactions.Mobile.ChainTalkChoiceButtonGroup choiceButtonGroup;
    private PRISM.Interactions.Mobile.ChainTalkUnreadScrollerView unreadScrollerView;
    private PRISM.Interactions.Mobile.ChainTalkReadScrollerView readScrollerView;
    private UnityEngine.UI.Image emptyViewImage;
    private PRISM.Interactions.Mobile.MobileScreenFader screenFader;
    public PRISM.Interactions.Mobile.ChainTalkReadScrollerView ReadScrollerView { get; set; }
    public PRISM.Interactions.Mobile.ChainTalkUnreadScrollerView UnreadScrollerView { get; set; }
    public System.IObservable<UniRx.Unit> OnClickProfileMenuButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickGroupMemberMenuButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickTalkHistoryMenuButton { get; set; }
    public void OnInstantiate();
    public void ShowLoadingBackground(bool isOn);
    public void ShowTouchArea(bool isOn);
    public void ShowHamburgerButton(bool isOn);
    public void SetHamburgerButtonEnabled(bool isEnabled, bool needsFade);
    public void Terminate();
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, int chainGroupId, System.Threading.CancellationToken ct);
    private void <Terminate>b__31_0();
    private void <InitializeAsync>b__32_0(UniRx.Unit _);
    private void <InitializeAsync>b__32_1(bool isOn);

    private struct <InitializeAsync>d__32 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public int chainGroupId;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        public PRISM.Interactions.Mobile.ChainTalkScreenView <>4__this;
        private Awaiter<UnityEngine.Sprite> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Mobile
public class ChainTalkScrollButton : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UIButton button;
    private UnityEngine.CanvasGroup canvasGroup;
    public System.IObservable<UniRx.Unit> OnClick { get; set; }
    public void Show(bool isOn, bool shouldFade);
}

// Namespace: PRISM.Interactions.Mobile
public class ChainTalkCellForReadScroller : PRISM.EnhancedListViewCell<PRISM.Adapters.Mobile.IChainTalkCellData, PRISM.Interactions.Mobile.ChainTalkReadScrollerViewContext>
{
    private PRISM.Interactions.Mobile.ChainTalkCellBase cellBase;
    private UniRx.CompositeDisposable disposables;
    private System.Threading.CancellationTokenSource cts;
    public void UpdateContent(PRISM.Adapters.Mobile.IChainTalkCellData data);
    protected void _initialize();
    private void <UpdateContent>b__3_0(int chainUserId);
    private void <UpdateContent>b__3_1(PRISM.Adapters.Mobile.ChainTalkCellThumbnailData thumbnailData);
    private void <UpdateContent>b__3_2(PRISM.Adapters.Mobile.ChainTalkCellMovieData movieData);
}

// Namespace: PRISM.Interactions.Mobile
public class ChainTalkReadScrollerView : PRISM.EnhancedListView<PRISM.Adapters.Mobile.IChainTalkCellData, PRISM.Interactions.Mobile.ChainTalkReadScrollerViewContext>, PRISM.Adapters.Mobile.IChainReadTalkScrollerView
{
    private UnityEngine.UI.Scrollbar scrollbar;
    private ENTERPRISE.UI.UITextMeshProUGUI emptyText;
    private PRISM.Interactions.Mobile.ChainTalkScrollButton scrollButton;
    private PRISM.Interactions.Mobile.ChainTalkCellForReadScroller[] talkCellPrefabs;
    private PRISM.Interactions.Mobile.ChainTalkSeparatorCell separatorCellPrefab;
    private float scrollingDurationRatio;
    private bool isScrolling;
    public System.IObservable<int> OnClickIcon { get; set; }
    public System.IObservable<PRISM.Adapters.Mobile.ChainTalkCellThumbnailData> OnClickThumbnail { get; set; }
    public System.IObservable<PRISM.Adapters.Mobile.ChainTalkCellMovieData> OnClickMovie { get; set; }
    public float CurrentScrollPosition { get; set; }
    public void Inject(PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void Initialize(int chainGroupId);
    public void UpdateScroller(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.Mobile.IChainTalkCellData> cellDataList, float scrollPosition);
    public void ShowScroller(bool isOn);
    public float GetCellViewSize(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex);
    public EnhancedUI.EnhancedScroller.EnhancedScrollerCellView GetCellView(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex, int cellIndex);
    private void _initializeScrollButton();
    private void <_initializeScrollButton>b__21_0(float _);
    private void <_initializeScrollButton>b__21_1(UniRx.Unit _);
    private void <_initializeScrollButton>b__21_2(float scrollPosition);
    private void <_initializeScrollButton>b__21_3();
}

// Namespace: PRISM.Interactions.Mobile
public class ChainTalkReadScrollerViewContext : PRISM.EnhancedListViewContext, System.IDisposable
{
    private UniRx.Subject<int> onClickIcon;
    private UniRx.Subject<PRISM.Adapters.Mobile.ChainTalkCellThumbnailData> onClickThumbnail;
    private UniRx.Subject<PRISM.Adapters.Mobile.ChainTalkCellMovieData> onClickMovie;
    public System.IObservable<int> OnClickIcon { get; set; }
    public System.IObservable<PRISM.Adapters.Mobile.ChainTalkCellThumbnailData> OnClickThumbnail { get; set; }
    public System.IObservable<PRISM.Adapters.Mobile.ChainTalkCellMovieData> OnClickMovie { get; set; }
    public void ClickIcon(int chainUserId);
    public void ClickThumbnail(PRISM.Adapters.Mobile.ChainTalkCellThumbnailData thumbnailData);
    public void ClickMovie(PRISM.Adapters.Mobile.ChainTalkCellMovieData movieData);
    public void Dispose();
}

// Namespace: PRISM.Interactions.Mobile
public class ChainTalkUserTypingData : UnityEngine.ScriptableObject, PRISM.Adapters.Mobile.IChainTalkUserTypingData
{
    private float[] defaultThinkingSecond;
    private float[] defaultTypeNonTextSecond;
    private float[] defaultTypingRate;
    private float typingSecondLimitsMin;
    private float typingSecondLimitsMax;
    public System.ValueTuple<float, float, float> GetTypingData(int chainUserId);
    public System.ValueTuple<float, float> GetTypingSecondLimit();
}

// Namespace: PRISM.Interactions.Mobile
public class ChainTalkCellForUnreadScroller : UnityEngine.MonoBehaviour, PRISM.Adapters.Mobile.IChainTalkCellForUnreadScroller
{
    private PRISM.Interactions.Mobile.ChainTalkCellBase cellBase;
    private UnityEngine.GameObject typingBalloon;
    private UnityEngine.UI.LayoutElement layoutElement;
    private PRISM.Adapters.Mobile.ChainTalkCellDataForUnreadScroller currentCellData;
    public void InjectCellData(PRISM.Adapters.Mobile.ChainTalkCellDataForUnreadScroller cellData);
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public void ShowCell(bool isActive);
    public void ShowTypingBalloon(bool isActive);
    private void _adjustHeight(bool isAnyContentActive, bool isTypingBalloon);

    private struct <InitializeAsync>d__5 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Mobile.ChainTalkCellForUnreadScroller <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Mobile
public class ChainTalkUnreadScrollerView : UnityEngine.MonoBehaviour, PRISM.Adapters.Mobile.IChainUnreadTalkScrollerView
{
    private UnityEngine.UI.ScrollRect scrollRect;
    private ENTERPRISE.UI.UIButton touchArea;
    private UnityEngine.Transform cellParent;
    private PRISM.Interactions.Mobile.ChainTalkCellForUnreadScroller[] cellPrefabs;
    private PRISM.Interactions.Mobile.ChainTalkSeparatorCell separatorCellBasePrefab;
    private PRISM.Interactions.Mobile.ChainTalkChoiceButtonGroup choiceButtonGroup;
    private PRISM.Interactions.Mobile.ChainTalkUserTypingData typingDataScriptableObject;
    private bool isClicked;
    public void ShowScroller(bool isActive);
    public PRISM.Adapters.Mobile.IChainTalkCellForUnreadScroller InstantiateTalkCell(PRISM.Adapters.Mobile.ChainTalkCellDataForUnreadScroller cellData);
    public void InstantiateSeparatorCell();
    public Cysharp.Threading.Tasks.UniTask<int> ShowChoicesAsync(System.Collections.Generic.IList<int> nextTalkTextIdList, System.Threading.CancellationToken ct);
    public void PlayPopTalkSe();
    public Cysharp.Threading.Tasks.UniTask AdjustScrollPositionAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask PauseWhileThinkingAsync(PRISM.Adapters.Mobile.ChainTalkCellDataForUnreadScroller cellData, bool skipThinking, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask PauseWhileTypingAsync(PRISM.Adapters.Mobile.ChainTalkCellDataForUnreadScroller cellData, System.Threading.CancellationToken ct);
    private static float _correctRate(int rate);
    private Cysharp.Threading.Tasks.UniTask _waitUntilScreenClicked(System.Threading.CancellationToken ct);
    private void Awake();
    private bool <_waitUntilScreenClicked>b__17_0();
    private void <Awake>b__18_0(UniRx.Unit _);

    private class <>O
    {
        public static System.Func<int, string> <0>__TalkBodyText;
    }

    private struct <AdjustScrollPositionAsync>d__13 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Mobile.ChainTalkUnreadScrollerView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <ShowChoicesAsync>d__11 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<int> <>t__builder;
        public System.Threading.CancellationToken ct;
        public PRISM.Interactions.Mobile.ChainTalkUnreadScrollerView <>4__this;
        public System.Collections.Generic.IList<int> nextTalkTextIdList;
        private int <nextTalkContentIdIndex>5__2;
        private Awaiter <>u__1;
        private Awaiter<int> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Mobile
public class ChainTalkHistoryButton : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UIButton button;
    private ENTERPRISE.UI.UITextMeshProUGUI talkNameText;
    public System.IObservable<UniRx.Unit> OnClickButton { get; set; }
    public void SetUpTalkName(string talkName);
    private void Awake();
}

// Namespace: PRISM.Interactions.Mobile
public class ChainTalkHistoryScreenView : UnityEngine.MonoBehaviour, PRISM.Adapters.Mobile.IChainTalkHistoryScreenView
{
    private PRISM.Interactions.Mobile.MobileScreenHeader header;
    private UnityEngine.GameObject emptyView;
    private ENTERPRISE.UI.UITextMeshProUGUI emptyText;
    private UnityEngine.UI.Image userIconImage;
    private UnityEngine.Transform buttonsParent;
    private PRISM.Interactions.Mobile.ChainTalkHistoryButton buttonPrefab;
    private UnityEngine.UI.ScrollRect scrollRect;
    private PRISM.Interactions.Mobile.MobileScreenFader screenFader;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    private UniRx.Subject<int> onClickTalkHistoryButtonSubject;
    public void Inject(PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void Terminate();
    public System.IObservable<int> OnClickButton();
    public float GetCurrentScrollPosition();
    public void SetScrollPosition(float scrollPosition);
    public void SetUpHeader();
    public void SetUpEmptyView(bool isEmpty);
    public Cysharp.Threading.Tasks.UniTask SetUpIconImageAsync(int chainGroupId, System.Threading.CancellationToken ct);
    public void InstantiateButtons(System.Collections.Generic.IEnumerable<int> chainTalkIds);
    private void <Terminate>b__11_0();

    private class <>c__DisplayClass18_0
    {
        public int talkId;
        public PRISM.Interactions.Mobile.ChainTalkHistoryScreenView <>4__this;
        private void <InstantiateButtons>b__0(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.Mobile
public class ChainTopScreenView : UnityEngine.MonoBehaviour, PRISM.Adapters.Mobile.IChainTopScreenView
{
    private PRISM.Interactions.Mobile.MobileHeaderTabGroup headerTabGroup;
    private UnityEngine.Transform[] buttonParents;
    private UnityEngine.UI.ScrollRect[] scrollRects;
    private PRISM.Interactions.Mobile.ChainTopUserButton userButtonPrefab;
    private PRISM.Interactions.Mobile.MobileScreenFader screenFader;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    private System.Collections.Generic.Dictionary<int, PRISM.Interactions.Mobile.ChainTopUserButton> userButtons;
    public System.IObservable<int> OnClickHeaderTab { get; set; }
    public System.IObservable<UniRx.Unit> OnClickUserButton(int chainGroupId);
    public System.IObservable<UniRx.Unit> OnClickIconButton(int chainGroupId);
    public void Inject(PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void Terminate();
    public void SetUpHeaderTab(UserCategory category, int unreadCountIdol, int unreadCountUnit, int unreadCountEtc);
    public void SetScrollPosition(UserCategory category, float normalizedScrollPosition);
    public float GetCurrentScrollPosition(UserCategory category);
    public void InstantiateUserButtons(UserCategory userCategory, System.Collections.Generic.IEnumerable<int> chainGroupIds);
    public void SetButtonNoticeBadge(int chainGroupId, bool isUnread);
    public Cysharp.Threading.Tasks.UniTask SetUpIconImageAsync(int chainGroupId, System.Threading.CancellationToken ct);
    private void <Terminate>b__12_0();

    private struct <SetUpIconImageAsync>d__18 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public int chainGroupId;
        public PRISM.Interactions.Mobile.ChainTopScreenView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter<UnityEngine.Sprite> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Mobile
public class ChainTopUserButton : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UIButton userButton;
    private ENTERPRISE.UI.UIButton iconButton;
    private UnityEngine.UI.Image iconImage;
    private ENTERPRISE.UI.UITextMeshProUGUI userNameText;
    private UnityEngine.GameObject noticeBadge;
    public System.IObservable<UniRx.Unit> OnClickUserButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickIconButton { get; set; }
    public void SetUpUserName(string userName);
    public void SetNoticeBadgeActive(bool isActive);
    public void SetUpIconImage(UnityEngine.Sprite iconSprite);
    private void Awake();
}

// Namespace: PRISM.Interactions.Mobile
public class ChainUserIdUtil
{
    public static bool IsProducer(int chainUserId);
    public static string GetProducerName();
    public static string GetUnitNameFrom(int chainUserId);
}

// Namespace: PRISM.Interactions.Mobile
public class MobileAssetUtility
{

    public class OurStream
    {
        public static string StreamerIcon(int streamerId);
        public static string LiveThumbnail(int streamId, int commonThumbnailId);
        public static string ArchiveThumbnail(int streamId);
        public static string ArchiveListThumbnail(int streamId);
        public static string FrontispieceImage(int id);
    }
}

// Namespace: PRISM.Interactions.Mobile
public class MobileCategoryButton : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView button;
    private UnityEngine.GameObject noticeBadge;
    private ENTERPRISE.UI.UITextMeshProUGUI nameText;
    public System.IObservable<UniRx.Unit> OnClick { get; set; }
    public void ShowNoticeBadge(bool isOn);
    public void SetName(string label);
}

// Namespace: PRISM.Interactions.Mobile
public class MobileHeaderTab : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UIButton tabButton;
    private UnityEngine.GameObject parentOn;
    private ENTERPRISE.UI.UITextMeshProUGUI onText;
    private UnityEngine.GameObject noticeBadgeOn;
    private ENTERPRISE.UI.UITextMeshProUGUI noticeBadgeTextOn;
    private UnityEngine.GameObject parentOff;
    private ENTERPRISE.UI.UITextMeshProUGUI offText;
    private UnityEngine.GameObject noticeBadgeOff;
    private ENTERPRISE.UI.UITextMeshProUGUI noticeBadgeTextOff;
    public System.IObservable<UniRx.Unit> OnClickAsObservable();
    public void SetText(string text);
    public void SetNoticeBadge(int count);
    public void Toggle(bool isOn);
    private void Awake();
}

// Namespace: PRISM.Interactions.Mobile
public class MobileHeaderTabGroup : UnityEngine.MonoBehaviour
{
    private TabContentPair[] tabContentPairs;
    private UniRx.Subject<int> onClickTabSubject;
    public System.IObservable<int> OnClickTab { get; set; }
    public void Initialize(int groupType);
    public void SetText(int groupType, string text);
    public void SetNoticeBadge(int groupType, int count);
    private void OnDestroy();
    private void _onClickTab(int groupTypeIndex);

    private class TabContentPair
    {
        public PRISM.Interactions.Mobile.MobileHeaderTab Tab;
        public UnityEngine.GameObject Content;
    }

    private class <>c__DisplayClass5_0
    {
        public int indexTmp;
        public PRISM.Interactions.Mobile.MobileHeaderTabGroup <>4__this;
        private void <Initialize>b__0(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.Mobile
public class MobileLauncherConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.Mobile.MobileLauncherArgument>, PRISM.Legacy.Mobile.IMobileLauncherConnector
{
    protected PRISM.Adapters.Mobile.MobileLauncherArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
}

// Namespace: PRISM.Interactions.Mobile
public class MobileLauncherView : UnityEngine.MonoBehaviour, PRISM.Adapters.Mobile.IMobileLauncherView
{
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(System.Threading.CancellationToken ct);
    public void Terminate();
}

// Namespace: PRISM.Interactions.Mobile
public class MobileLoadingScreen : UnityEngine.MonoBehaviour, PRISM.Adapters.Mobile.IMobileLoadingScreen
{
    private UnityEngine.GameObject defaultLoadingScreen;
    private int counter;
    public System.IDisposable Show();
    private void _hide();

    private class <>c
    {
        public static <>c <>9;
        public static System.Action<PRISM.Interactions.Mobile.MobileLoadingScreen> <>9__2_0;
        private void <Show>b__2_0(PRISM.Interactions.Mobile.MobileLoadingScreen x);
    }
}

// Namespace: PRISM.Interactions.Mobile
public class MobileMenu : UnityEngine.MonoBehaviour, PRISM.Adapters.Mobile.IMobileMenu
{
    private UnityEngine.GameObject body;
    private PRISM.Interactions.Mobile.MobileCategoryButton twestaButton;
    private PRISM.Interactions.Mobile.MobileCategoryButton chainButton;
    private PRISM.Interactions.Mobile.MobileCategoryButton phoneButton;
    private PRISM.Interactions.Mobile.MobileCategoryButton ourStreamButton;
    public System.IObservable<UniRx.Unit> OnClickButton(Category category);
    public void ShowMenu(bool isOn);
    public void ShowNoticeBadge(Category category, bool isOn);
    private PRISM.Interactions.Mobile.MobileCategoryButton _getButton(Category category);
}

// Namespace: PRISM.Interactions.Mobile
public class MobileMlTextUtil
{

    public class Chain
    {
        public static string UserName(int id);
        public static string GroupName(int id);
        public static string UserProfile(int id);
        public static string TalkTitle(int id);
        public static string TalkBodyText(int chainTalkTextId);

        public class UI
        {
            public string EnChain { get; set; }
            public string JaChain { get; set; }
            public string Idol { get; set; }
            public string Unit { get; set; }
            public string Etc { get; set; }
            public string Profile { get; set; }
            public string Members { get; set; }
            public string TalkHistory { get; set; }
            public string ChooseResponse { get; set; }
            public string TalkNotExist { get; set; }
            public string TalkHistoryNotExist { get; set; }
            private static string _getChainUIText(int id);
        }
    }

    public class Common
    {

        public class UI
        {
            public string Mobile { get; set; }
            private static string _getCommonUIText(int id);
        }
    }

    public class OurStream
    {
        public static string StreamerName(int streamerId);

        public class UI
        {
            public string TextKey { get; set; }
            public string EnOurStream { get; set; }
            public string JaOurStream { get; set; }
            public string JaOurStream2 { get; set; }
            public string OnAir { get; set; }
            public string Schedule { get; set; }
            public string Archive { get; set; }
            public string ContentDetailTitle { get; set; }
            public string StreamTitle { get; set; }
            public string StreamDetail { get; set; }
            public string StreamDate { get; set; }
            public string StreamLimit { get; set; }
            public string Streamer { get; set; }
            public string LiveViewingButton { get; set; }
            public string ArchiveButton { get; set; }
            public string ArchiveYoutubeButton { get; set; }
            public string Favorite { get; set; }
            public string FavoriteNotExist { get; set; }
            public string RecommendFavorite { get; set; }
            public string StreamEndTitle { get; set; }
            public string StreamEndDetail { get; set; }
            public string ArchiveEndTitle { get; set; }
            public string ArchiveEndDetail { get; set; }
            public string ReconnectTitle { get; set; }
            public string ReconnectDetail { get; set; }
            public string ConnectErrorTitle { get; set; }
            public string ConnectErrorDetail { get; set; }
            public string StreamWaiting { get; set; }
            public string StreamWillStartSoon { get; set; }
            public string StreamEnded { get; set; }
            public string ArchiveNotExist { get; set; }
            public string Idol { get; set; }
            public string Unit { get; set; }
            public string Etc { get; set; }
            public string CameraSwitching { get; set; }
            public string CameraSwitchingPMode { get; set; }
            public string ScheduleDate { get; set; }
            public string ReleaseTitle { get; set; }
            public string ReleaseMessage { get; set; }
            public string ReleaseButton { get; set; }
            public string ReleaseCompletedTitle { get; set; }
            public string ReleaseCompletedMessage { get; set; }
            public string NotHavingTicketCation { get; set; }
            public string PurchaseTicket { get; set; }
            public string ChangeStreamerCostume { get; set; }
            public string StreamWaitingPremium { get; set; }
            private static string _getOurStreamUIText(int id);
        }
    }

    public class Twesta
    {
        public static string UserName(int twestaUserId);
        public static string UserProfile(int twestaUserId);
        public static string ArticleBody(int articleId);
        public static string CommentBody(int articleId);

        public class UI
        {
            public string EnTwesta { get; set; }
            public string JaTwesta { get; set; }
            public string Favorite { get; set; }
            public string ProfileAndHistory { get; set; }
            public string FavoriteNotExist { get; set; }
            public string RecommendFavorite { get; set; }
            public static string CommentCount(int count);
            private static string _getTwestaUIText(int id);
        }
    }
}

// Namespace: PRISM.Interactions.Mobile
public class MobileSafeAreaAdjuster : UnityEngine.MonoBehaviour
{
    private void Start();

    private class <>c__DisplayClass0_0
    {
        public UnityEngine.RectTransform rect;
        private void <Start>b__0(PRISM.Interactions.ScreenWrapper screen);
    }
}

// Namespace: PRISM.Interactions.Mobile
public class MobileScreenBackground : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.Image backgroundImage;
    public void SetUpBackgroundImage(UnityEngine.Sprite backgroundSprite);
    public void ShowBackground(bool isOn);
}

// Namespace: PRISM.Interactions.Mobile
public class MobileScreenConnectorView : UnityEngine.MonoBehaviour, PRISM.Adapters.Mobile.IMobileScreenConnectorView
{
    private UnityEngine.Transform screenParent;
    private KeyBuilderPair[] screenBuilders;
    private System.Collections.Generic.Dictionary<int, PRISM.Interactions.Mobile.IMobileScreenBuilder> screenBuilderDic;
    public void Initialize();
    public bool ScreenExists(ScreenType screenType);
    public PRISM.Adapters.Mobile.IMobileScreenPresenter BuildScreenPresenter(ScreenType screenType, PRISM.Adapters.Mobile.IMobileScreenParameter screenParameter, PRISM.Adapters.Mobile.IMobileScreenCommonInfoContainer container);
    public System.IDisposable BlockInput();

    private class KeyBuilderPair
    {
        public ScreenType ScreenType;
        public TNRD.SerializableInterface<PRISM.Interactions.Mobile.IMobileScreenBuilder> Builder;
    }

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<KeyBuilderPair, int> <>9__4_0;
        public static System.Func<KeyBuilderPair, PRISM.Interactions.Mobile.IMobileScreenBuilder> <>9__4_1;
        private int <Initialize>b__4_0(KeyBuilderPair x);
        private PRISM.Interactions.Mobile.IMobileScreenBuilder <Initialize>b__4_1(KeyBuilderPair x);
    }
}

// Namespace: PRISM.Interactions.Mobile
public class MobileScreenFader : UnityEngine.MonoBehaviour
{
    public static float ScreenFadeOutSecond;
    private UnityEngine.CanvasGroup canvasGroup;
    public void FadeOut(System.Action onKill);

    private class <>c__DisplayClass2_0
    {
        public System.Action onKill;
        private void <FadeOut>b__0();
    }
}

// Namespace: PRISM.Interactions.Mobile
public class MobileScreenHeader : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.Image headerImage;
    private ENTERPRISE.UI.UITextMeshProUGUI headerTextMesh;
    public void SetActive(bool isActive);
    public void SetUpHeaderImage(UnityEngine.Sprite headerSprite);
    public void SetUpHeaderText(string text);
}

// Namespace: PRISM.Interactions.Mobile
public class MobileScreenView : UnityEngine.MonoBehaviour, PRISM.Adapters.Mobile.IMobileScreenView
{
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask BeginScreenAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask EndScreenAsync(System.Threading.CancellationToken ct);
    public void Terminate();
    public void Inject(PRISM.Adapters.Mobile.IMobileScreenParameter parameter);
}

// Namespace: PRISM.Interactions.Mobile
public class MobileStandbyScreenView : UnityEngine.MonoBehaviour, PRISM.Adapters.Mobile.IMobileStandbyScreenView
{
    private UnityEngine.CanvasGroup canvasGroup;
    private void PRISM.Adapters.Mobile.IMobileStandbyScreenView.InitializeView();
}

// Namespace: PRISM.Interactions.Mobile
public class MobileThumbnail : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.Image image;
    private ENTERPRISE.UI.UIButton button;
    private UnityEngine.GameObject pictogram;
    public System.IObservable<UniRx.Unit> OnClick { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(string imageKey, bool showPictogram, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public void SetButtonEnable(bool isEnable);
}

// Namespace: PRISM.Interactions.Mobile
public class MobileTopScreenView : UnityEngine.MonoBehaviour, PRISM.Adapters.Mobile.IMobileTopScreenView
{
    private UnityEngine.GameObject contentPos;
    private PRISM.Interactions.Mobile.MobileCategoryButton twestaButton;
    private PRISM.Interactions.Mobile.MobileCategoryButton chainButton;
    private PRISM.Interactions.Mobile.MobileCategoryButton phoneButton;
    private PRISM.Interactions.Mobile.MobileCategoryButton streamingButton;
    private PRISM.Interactions.Mobile.MobileScreenFader screenFader;
    public System.IObservable<UniRx.Unit> OnClickTwestaButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickChainButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickPhoneButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickOurStreamButton { get; set; }
    public void SetUpCategoryButton(Category category, bool isUnread);
    public void Terminate();
    private void <Terminate>b__15_0();
}

// Namespace: PRISM.Interactions.Mobile
public class MobileNotificationButtonView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView button;
    private UnityEngine.Animator animator;
    private ENTERPRISE.UI.UITextMeshProUGUI titleText;
    private ENTERPRISE.UI.UITextMeshProUGUI messageText;
    private UnityEngine.UI.Image iconImage;
    private UnityEngine.UI.Image notificationImage;
    private string animatorHashId;
    public System.IObservable<UniRx.Unit> OnClickButton { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.Mobile.IMobileNotificationButtonViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask PlayAnimationAsync(System.Threading.CancellationToken ct);
}

// Namespace: PRISM.Interactions.Mobile
public class MobileNotificationView : UnityEngine.MonoBehaviour, PRISM.Adapters.Mobile.IMobileNotificationView
{
    private UnityEngine.Transform buttonParent;
    private PRISM.Interactions.Mobile.MobileNotificationButtonView buttonPrefab;
    private UniRx.Subject<PRISM.Adapters.Mobile.IMobileNotificationButtonViewModel> onClickNotificationButton;
    private UniRx.ReactiveProperty<bool> isNotificationDisplayed;
    private int existingNotificationCounter;
    private CriWare.CriAtomExPlayback currentPlayback;
    private PRISM.Interactions.Mobile.MobileNotificationButtonView currentButton;
    public System.IObservable<PRISM.Adapters.Mobile.IMobileNotificationButtonViewModel> OnClickNotificationButton { get; set; }
    public UniRx.IReadOnlyReactiveProperty<bool> IsNotificationDisplayed { get; set; }
    public void StopNotificationSe();
    public void RemoveCurrentNotification();
    public Cysharp.Threading.Tasks.UniTask ShowNotificationAsync(PRISM.Adapters.Mobile.IMobileNotificationButtonViewModel buttonViewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    private void OnDestroy();

    private class <>c__DisplayClass13_0
    {
        public PRISM.Interactions.Mobile.MobileNotificationView <>4__this;
        public PRISM.Adapters.Mobile.IMobileNotificationButtonViewModel buttonViewModel;
        public PRISM.Interactions.Mobile.MobileNotificationButtonView button;
        public System.IDisposable buttonDisposable;
        public System.Threading.CancellationToken ct;
        public System.Action <>9__3;
        public System.Action <>9__4;
        private void <ShowNotificationAsync>b__0(UniRx.Unit _);
        private void <ShowNotificationAsync>b__1(UniRx.Unit _);
        private Cysharp.Threading.Tasks.UniTask <ShowNotificationAsync>b__2();
        private void <ShowNotificationAsync>b__3();
        private void <ShowNotificationAsync>b__4();

        private struct <<ShowNotificationAsync>b__2>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
        {
            public int <>1__state;
            public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
            public <>c__DisplayClass13_0 <>4__this;
            private Awaiter <>u__1;
            private void MoveNext();
            private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }

    private struct <ShowNotificationAsync>d__13 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Mobile.MobileNotificationView <>4__this;
        public PRISM.Adapters.Mobile.IMobileNotificationButtonViewModel buttonViewModel;
        public System.Threading.CancellationToken ct;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private <>c__DisplayClass13_0 <>8__1;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Mobile
public class OurStreamArchiveCellView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView cellButton;
    private PRISM.Interactions.ButtonView favoriteToggle;
    private PRISM.Interactions.ViewStateChanger isOnStateChanger;
    private UnityEngine.UI.Image thumbnailImage;
    private ENTERPRISE.UI.UITextMeshProUGUI titleText;
    private ENTERPRISE.UI.UITextMeshProUGUI timeText;
    private UnityEngine.CanvasGroup dateCanvasGroup;
    private ENTERPRISE.UI.UITextMeshProUGUI dateLabelText;
    private ENTERPRISE.UI.UITextMeshProUGUI dateText;
    private UnityEngine.CanvasGroup limitDateCanvasGroup;
    private ENTERPRISE.UI.UITextMeshProUGUI limitDateLabelText;
    private ENTERPRISE.UI.UITextMeshProUGUI limitDateText;
    private PRISM.Interactions.ViewStateChanger badgeStateChanger;
    private PRISM.Interactions.ViewStateChanger unreleasedStateChanger;
    private float displayTime;
    private float duration;
    private float interval;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    private bool isTerminate;
    private PRISM.AutoCancellationTokenSource canceller;
    private UniRx.ReactiveProperty<bool> isFavorite;
    public System.IObservable<UniRx.Unit> OnClickButton { get; set; }
    public System.IObservable<bool> OnClickFavoriteToggle { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Module.Networking.IArchiveStreamProgramStatus archiveData, System.Threading.CancellationToken ct);
    public void Terminate();
    private void _setUpFavoriteToggle(bool isFavorite, System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask _fadeDateTextAsync(System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask _fadeCanvasGroupAsync(UnityEngine.CanvasGroup canvasGroup, System.Threading.CancellationToken ct);
    protected Cysharp.Threading.Tasks.UniTask _loadThumbnailImageAsync(int streamId, System.Threading.CancellationToken ct);
    private void <_setUpFavoriteToggle>b__27_0(UniRx.Unit _);
    private void <_setUpFavoriteToggle>b__27_1(bool isOn);

    private struct <_fadeCanvasGroupAsync>d__29 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public UnityEngine.CanvasGroup canvasGroup;
        public PRISM.Interactions.Mobile.OurStreamArchiveCellView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_fadeDateTextAsync>d__28 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Mobile.OurStreamArchiveCellView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Mobile
public class OurStreamArchiveDetailCellView : PRISM.Interactions.Mobile.OurStreamDetailCellViewBase
{
    private PRISM.Interactions.ButtonView favoriteToggle;
    private PRISM.Interactions.ViewStateChanger isOnStateChanger;
    private PRISM.Interactions.ButtonView archiveButton;
    private ENTERPRISE.UI.UITextMeshProUGUI archiveButtonText;
    private UnityEngine.CanvasGroup dateTextCanvasGroup;
    private UnityEngine.CanvasGroup limitTextCanvasGroup;
    private ENTERPRISE.UI.UITextMeshProUGUI limitDateLabelText;
    private ENTERPRISE.UI.UITextMeshProUGUI limitDateText;
    private ENTERPRISE.UI.UITextMeshProUGUI timeText;
    private ENTERPRISE.UI.UITextMeshProUGUI changeStreamerCostumeText;
    private float displayTime;
    private float duration;
    private float interval;
    private bool isTerminate;
    private UniRx.ReactiveProperty<bool> isFavorite;
    public System.IObservable<UniRx.Unit> OnClickArchiveButton { get; set; }
    public System.IObservable<bool> OnClickFavoriteToggle { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Module.Networking.IArchiveStreamProgramStatus archiveData, System.Threading.CancellationToken ct);
    public void Terminate();
    private void _setUpFavoriteToggle(bool isFavorite);
    private Cysharp.Threading.Tasks.UniTask _fadeDateTextAsync(System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask _fadeCanvasGroupAsync(UnityEngine.CanvasGroup canvasGroup, System.Threading.CancellationToken ct);
    private void <_setUpFavoriteToggle>b__21_0(UniRx.Unit _);
    private void <_setUpFavoriteToggle>b__21_1(bool isOn);

    private struct <_fadeCanvasGroupAsync>d__23 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public UnityEngine.CanvasGroup canvasGroup;
        public PRISM.Interactions.Mobile.OurStreamArchiveDetailCellView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_fadeDateTextAsync>d__22 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Mobile.OurStreamArchiveDetailCellView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Mobile
public class OurStreamArchiveDetailScreenView : UnityEngine.MonoBehaviour, PRISM.Adapters.Mobile.IOurStreamArchiveDetailScreenView
{
    private PRISM.Interactions.ButtonView favoriteButton;
    private PRISM.Interactions.Mobile.OurStreamTicketButton ticketButton;
    private PRISM.Interactions.Mobile.OurStreamArchiveDetailCellView cellView;
    private PRISM.Interactions.Mobile.MobileScreenFader screenFader;
    public System.IObservable<UniRx.Unit> OnClickFavoriteButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickDetailButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickArchiveButton { get; set; }
    public System.IObservable<bool> OnClickFavoriteToggle { get; set; }
    public System.IObservable<int> OnClickStreamerIcon { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Module.Networking.IArchiveStreamProgramStatus archiveData, PRISM.Adapters.Mobile.OurStreamTicketModel ticketModel, System.Threading.CancellationToken ct);
    public void Terminate();
    public Cysharp.Threading.Tasks.UniTask ShowArchiveViewingPeriodExpiredPopupAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask<bool> ShowOurStreamTicketCompletedPopupAsync(bool isLive, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask RefreshAsync(PRISM.Module.Networking.IArchiveStreamProgramStatus archiveData, System.Threading.CancellationToken ct);
    private void <Terminate>b__15_0();
}

// Namespace: PRISM.Interactions.Mobile
public class OurStreamDetailCellViewBase : UnityEngine.MonoBehaviour
{
    protected PRISM.Interactions.ButtonView detailButton;
    protected UnityEngine.UI.Image thumbnailImage;
    protected ENTERPRISE.UI.UITextMeshProUGUI titleText;
    protected ENTERPRISE.UI.UITextMeshProUGUI dateLabelText;
    protected ENTERPRISE.UI.UITextMeshProUGUI dateText;
    protected ENTERPRISE.UI.UITextMeshProUGUI streamerLabelText;
    protected UnityEngine.Transform streamerIconParent;
    protected UnityEngine.UI.Image streamerIcon;
    protected UnityEngine.Animator accountIconAnim;
    protected UnityEngine.GameObject accountIconOnAir;
    protected PRISM.ResourceManagement.IResourceLoader resourceLoader;
    private System.Collections.Generic.List<UnityEngine.UI.Image> streamerIconList;
    private UnityEngine.Pool.ObjectPool<UnityEngine.UI.Image> streamerIconPool;
    private UniRx.Subject<int> onClickStreamerIconSubject;
    public System.IObservable<UniRx.Unit> OnClickDetailButton { get; set; }
    public System.IObservable<int> OnClickStreamerIcon { get; set; }
    public void Inject(PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void Terminate();
    protected Cysharp.Threading.Tasks.UniTask _loadThumbnailImageAsync(string key, System.Threading.CancellationToken ct);
    protected Cysharp.Threading.Tasks.UniTask _loadStreamerIconsAsync(System.Collections.Generic.IReadOnlyList<int> StreamerIdList, System.Threading.CancellationToken ct, bool iconButtonEnabled);
    protected Cysharp.Threading.Tasks.UniTask _loadStreamerIconAsync(int streamerId, UnityEngine.UI.Image iconImage, bool iconButtonEnabled, System.Threading.CancellationToken ct);
    private UnityEngine.Pool.ObjectPool<UnityEngine.UI.Image> _createStreamerIconPool();
    private void _clearStreamerIcon();
    private void OnDestroy();
    private UnityEngine.UI.Image <_createStreamerIconPool>b__23_0();

    private class <>c
    {
        public static <>c <>9;
        public static System.Action<UnityEngine.UI.Image> <>9__23_1;
        public static System.Action<UnityEngine.UI.Image> <>9__23_2;
        public static System.Action<UnityEngine.UI.Image> <>9__23_3;
        private void <_createStreamerIconPool>b__23_1(UnityEngine.UI.Image target);
        private void <_createStreamerIconPool>b__23_2(UnityEngine.UI.Image target);
        private void <_createStreamerIconPool>b__23_3(UnityEngine.UI.Image target);
    }

    private class <>c__DisplayClass22_0
    {
        public PRISM.Interactions.Mobile.OurStreamDetailCellViewBase <>4__this;
        public int streamerId;
        private void <_loadStreamerIconAsync>b__0(UniRx.Unit _);
    }

    private struct <_loadStreamerIconAsync>d__22 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Mobile.OurStreamDetailCellViewBase <>4__this;
        public int streamerId;
        public System.Threading.CancellationToken ct;
        public UnityEngine.UI.Image iconImage;
        public bool iconButtonEnabled;
        private <>c__DisplayClass22_0 <>8__1;
        private Awaiter<UnityEngine.Sprite> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Mobile
public class OurStreamFavoriteListScreenView : UnityEngine.MonoBehaviour, PRISM.Adapters.Mobile.IOurStreamFavoriteListScreenView
{
    private PRISM.Interactions.Mobile.MobileScreenHeader header;
    private PRISM.Interactions.Mobile.OurStreamTicketButton ticketButton;
    private UnityEngine.Transform archiveCellViewParent;
    private PRISM.Interactions.Mobile.OurStreamArchiveCellView archiveCellViewPrefab;
    private UnityEngine.GameObject emptyView;
    private ENTERPRISE.UI.UITextMeshProUGUI emptyText;
    private ENTERPRISE.UI.UITextMeshProUGUI emptyText2;
    private PRISM.Interactions.Mobile.MobileScreenFader screenFader;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    private UniRx.CompositeDisposable disposable;
    private UniRx.Subject<int> onClickArchiveSelectSubject;
    private UniRx.Subject<System.ValueTuple<int, bool>> onClickFavoriteToggleSubject;
    private System.Collections.Generic.List<PRISM.Interactions.Mobile.OurStreamArchiveCellView> archiveCellList;
    public System.IObservable<int> OnClickArchiveButton { get; set; }
    public System.IObservable<System.ValueTuple<int, bool>> OnClickFavoriteToggle { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IArchiveStreamProgramStatus> favoriteList, PRISM.Adapters.Mobile.OurStreamTicketModel ticketModel, System.Threading.CancellationToken ct);
    public void Terminate();
    public Cysharp.Threading.Tasks.UniTask UpdateFavoriteListAsync(System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IArchiveStreamProgramStatus> favoriteList, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask ShowArchiveViewingPeriodExpiredPopupAsync(System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask _createFavoriteListAsync(System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IArchiveStreamProgramStatus> favoriteList, System.Threading.CancellationToken ct);
    private void _deleteArchiveCellList();
    private void <Terminate>b__18_0();

    private class <>c__DisplayClass21_0
    {
        public int index;
        public int id;
        public PRISM.Interactions.Mobile.OurStreamFavoriteListScreenView <>4__this;
        private void <_createFavoriteListAsync>b__0(UniRx.Unit _);
        private void <_createFavoriteListAsync>b__1(bool isOn);
    }
}

// Namespace: PRISM.Interactions.Mobile
public interface IOurStreamLiveViewingArchiveView
{
    public bool IsPlayStart { get; set; }
    public bool IsPaused { get; set; }
    public double CurrentTime { get; set; }
    public double MaxTime { get; set; }
    public void Terminate();
    public void Pause();
    public void Resume();
    public void Stop();
    public void SetSeekToTime(double time);
}

// Namespace: PRISM.Interactions.Mobile
public class OurStreamLiveViewingCameraControlView : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IScrollHandler
{
    private PRISM.Interactions.Mobile.OurStreamLiveViewingScreenTapUIView tapUIView;
    private UnityEngine.UI.Image unavailableIcon;
    private float showUnavailableIconTime;
    private float fadeUnavailableIconTime;
    private float minRotateXSensitivity;
    private float minRotateYSensitivity;
    private float maxRotateXSensitivity;
    private float maxRotateYSensitivity;
    private float limitRotateX;
    private float limitRotateY;
    private float zoomSensitivity;
    private float zoomMouseScrollSensitivity;
    private float maxZoomInValue;
    private float maxZoomOutValue;
    private float resetPCameraFadeTime;
    private bool showUnavailableIcon;
    private float currentUnavailableIconTime;
    private float rotateX;
    private float rotateY;
    private float zoomValue;
    private PRISM.StreamingViewer.CameraView cameraView;
    private bool isLive;
    private System.IDisposable changeCameraControlDisposable;
    private System.Threading.CancellationTokenSource cts;
    public void Setup(PRISM.StreamingViewer.CameraView cameraView, bool isLive);
    public void Terminate();
    public void ResetPCamera(bool isFade);
    public void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
    public void OnScroll(UnityEngine.EventSystems.PointerEventData eventData);
    private bool _isAvailable();
    private void _showUnavailableIcon();
    private Cysharp.Threading.Tasks.UniTask _showUnavailableIconAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask _resetPCameraFadeAsync(bool isFade, System.Threading.CancellationToken ct);
    private bool <_showUnavailableIconAsync>b__31_0();

    private class <>c__DisplayClass24_0
    {
        public bool tempAvailable;
        public PRISM.Interactions.Mobile.OurStreamLiveViewingCameraControlView <>4__this;
        private void <Setup>b__0(bool isAvailable);
    }

    private struct <_resetPCameraFadeAsync>d__32 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public bool isFade;
        public PRISM.Interactions.Mobile.OurStreamLiveViewingCameraControlView <>4__this;
        public System.Threading.CancellationToken ct;
        private float <currentTime>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_showUnavailableIconAsync>d__31 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Mobile.OurStreamLiveViewingCameraControlView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Mobile
public class OurStreamLiveViewingConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.OurstreamLiveViewingArgument>, PRISM.IOurStreamLiveViewingConnector
{
    protected PRISM.Adapters.OurstreamLiveViewingArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
}

// Namespace: PRISM.Interactions.Mobile
public class OurStreamLiveViewingMovieView : UnityEngine.MonoBehaviour, PRISM.Interactions.Mobile.IOurStreamLiveViewingArchiveView
{
    private System.IDisposable playStartDisposable;
    private System.IDisposable playEndDisposable;
    private bool isPlayStart;
    private UniRx.Subject<UniRx.Unit> playEndSubject;
    public bool IsPlayStart { get; set; }
    public bool IsPaused { get; set; }
    public System.IObservable<UniRx.Unit> OnPlayEnd { get; set; }
    public double CurrentTime { get; set; }
    public double MaxTime { get; set; }
    public void PlayMovie(string url);
    public void Terminate();
    public void Pause();
    public void Resume();
    public void Stop();
    public void SetSeekToTime(double time);
}

// Namespace: PRISM.Interactions.Mobile
public class OurStreamLiveViewingPreRecordedView : UnityEngine.MonoBehaviour, PRISM.Interactions.Mobile.IOurStreamLiveViewingArchiveView
{
    private PRISM.StreamingNetwork.PrismStreamingCDN streamingCDN;
    private PRISM.StreamingViewer.SoundView soundView;
    private bool isPlayStart;
    public bool IsPlayStart { get; set; }
    public bool IsPaused { get; set; }
    public double CurrentTime { get; set; }
    public double MaxTime { get; set; }
    public void SetSoundView(PRISM.StreamingViewer.SoundView soundView);
    public void PlayStart();
    public void Terminate();
    public void Pause();
    public void Resume();
    public void Stop();
    public void SetSeekToTime(double time);
}

// Namespace: PRISM.Interactions.Mobile
public class OurStreamLiveViewingScreenTapUIView : UnityEngine.MonoBehaviour
{
    private UnityEngine.CanvasGroup uiCanvasGroup;
    private PRISM.Interactions.ButtonView screenTapButton;
    private PRISM.Interactions.ButtonView cameraSwitchingButton;
    private ENTERPRISE.UI.UITextMeshProUGUI cameraSwitchingButtonText;
    private UnityEngine.UI.Image cameraLiveViewLogo;
    private UnityEngine.GameObject archiveArea;
    private ENTERPRISE.UI.UITextMeshProUGUI titleText;
    private UnityEngine.UI.Slider seekBarSlider;
    private ENTERPRISE.UI.UITextMeshProUGUI timeText;
    private PRISM.Interactions.ButtonView stopButton;
    private PRISM.Interactions.ButtonView resumeButton;
    private PRISM.Interactions.ButtonView rewindButton;
    private PRISM.Interactions.ButtonView fastForwardButton;
    private float displayTime;
    private float closeTime;
    private System.Threading.CancellationTokenSource cts;
    private bool isShowing;
    private bool isMoveSlider;
    private UniRx.Subject<bool> onPointerUpDownSeekBarSliderSubject;
    public System.IObservable<UniRx.Unit> OnClickScreen { get; set; }
    public System.IObservable<UniRx.Unit> OnClickCameraSwitchingButton { get; set; }
    public System.IObservable<float> OnValueChangedSeekBar { get; set; }
    public System.IObservable<bool> OnPointerUpDownSeekBarSlider { get; set; }
    public System.IObservable<UniRx.Unit> OnClickStopButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickResumeButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickRewindButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickFastForwardButton { get; set; }
    public bool IsShowing { get; set; }
    public bool IsMoveSlider { get; set; }
    public float GetSeekBarSliderValue { get; set; }
    public void Initialize(PRISM.Adapters.OurstreamLiveViewingArgument argument);
    public void Terminate();
    public void TapScreen();
    public void SetSeekBar(float currentTime, float maxTime);
    public void SetTimeText(int currentTime, int maxTime);
    public void SetActivePlayButton(bool isPlay);
    public void SetActiveCameraSwitchingButton(bool isActive);
    public void SetCameraSwitchingButtonText(bool isPMode);
    public void OnApplicationSuspend();
    public void ShowUICanvas(bool isWaitClose);
    public void CloseUICanvas();
    private Cysharp.Threading.Tasks.UniTask _waitCanvasGroupAsync(System.Threading.CancellationToken ct);
    private void _cancelCurrentCancellationTokenSource();
    private void <Initialize>b__41_0(UnityEngine.EventSystems.PointerEventData eventData);
    private void <Initialize>b__41_2(UnityEngine.EventSystems.PointerEventData eventData);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<UnityEngine.EventSystems.PointerEventData, bool> <>9__41_1;
        private bool <Initialize>b__41_1(UnityEngine.EventSystems.PointerEventData e);
    }

    private struct <_waitCanvasGroupAsync>d__52 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Mobile.OurStreamLiveViewingScreenTapUIView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Mobile
public class OurStreamLiveViewingView : UnityEngine.MonoBehaviour, PRISM.Adapters.Mobile.IOurStreamLiveViewingView
{
    private string sceneReference;
    private UnityEngine.CanvasGroup frontispiece;
    private UnityEngine.UI.Image frontispieceImage;
    private UnityEngine.GameObject frontispieceMessageArea;
    private ENTERPRISE.UI.UITextMeshProUGUI frontispieceMessage;
    private UnityEngine.UI.Image premiumImage;
    private PRISM.Interactions.Mobile.OurStreamLiveViewingScreenTapUIView screenTapUIView;
    private PRISM.Interactions.Mobile.OurStreamLiveViewingMovieView movieView;
    private PRISM.Interactions.Mobile.OurStreamLiveViewingPreRecordedView preRecordedView;
    private PRISM.Interactions.Mobile.OurStreamLiveViewingCameraControlView cameraControlView;
    private UnityEngine.GameObject reconnectingScreen;
    private PRISM.Interactions.ButtonView backButton;
    private int[] imageIdArray;
    private string[] frontispieceMessages;
    private UnityEngine.Sprite[] frontispieceSprites;
    private bool readyToWatch;
    private bool isLive;
    private bool isInitPMode;
    private bool isPremium;
    private LiveViewingType liveViewingType;
    private PRISM.Interactions.Mobile.IOurStreamLiveViewingArchiveView currentArchiveView;
    private PRISM.CameraController cameraController;
    private PRISM.StreamingViewer.OperatorView operatorView;
    private PRISM.StreamingViewer.SoundView soundView;
    private PRISM.StreamingViewer.CameraView cameraView;
    private int bgmFadeTime;
    private float premiumImageFadeTime;
    private float bgmCurrentTime;
    private bool isBgmPlaying;
    private bool beforePaused;
    private bool showPremiumImage;
    private bool changeCameraFrontispiece;
    private bool isSeekBarSliderEnded;
    private PRISM.Definitions.MstStreamProgram mstStreamData;
    private PRISM.SceneLoader sceneLoader;
    private System.Threading.CancellationTokenSource cts;
    private System.IDisposable updateTimeDisposable;
    public System.IObservable<UniRx.Unit> OnClickScreen { get; set; }
    public System.IObservable<UniRx.Unit> OnClickCameraSwitchingButton { get; set; }
    public System.IObservable<float> OnValueChangedSeekBar { get; set; }
    public System.IObservable<bool> OnPointerUpDownSeekBarSlider { get; set; }
    public System.IObservable<UniRx.Unit> OnClickStopButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickResumeButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickRewindButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickFastForwardButton { get; set; }
    public Cysharp.Threading.Tasks.UniTask BeginViewAsync();
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Adapters.OurstreamLiveViewingArgument argument);
    public Cysharp.Threading.Tasks.UniTask EndViewAsync();
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    public void TapScreen();
    public void CameraSwitchingViewPoint();
    public void SetSeekBar(float value);
    public void OnSeekBarSlider(bool isOn);
    public void Pause();
    public void Resume();
    public void Rewind(float time);
    public void Fastforward(float time);
    public void OnArchiveFinished();
    public Cysharp.Threading.Tasks.UniTask ConfirmStreamingInfoAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask<bool> ShowLiveStreamingErrorPopupAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask ShowLiveViewingEndedPopupAsync(System.Threading.CancellationToken ct);
    public void OnRecieveOnAirStatus(Status status, PModeStatus pModeStatus);
    public void OnApplicationSuspend();
    public void OnApplicationResume();
    public void ShowReconnectingScreen(bool show);
    private void _initializeUI(PRISM.Adapters.OurstreamLiveViewingArgument argument);
    private void _changeFrontispiece(bool enable, FrontispieceImages image, bool fadeFlag, bool waitPremium, bool isBlackScreen);
    private Cysharp.Threading.Tasks.UniTask _loadFrontispieceAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    private void _setActivePremiumImage(PModeStatus pModeStatus);
    private void _stopBGM();
    private void _startBGM();
    private bool <ConfirmStreamingInfoAsync>b__66_0();
    private bool <_initializeUI>b__73_0(UniRx.Unit _);
    private bool <_initializeUI>b__73_1(UniRx.Unit _);
    private void <_initializeUI>b__73_2(UniRx.Unit _);

    private class <>c
    {
        public static <>c <>9;
        public static System.Action<UniRx.Unit> <>9__54_0;
        private void <InitializeAsync>b__54_0(UniRx.Unit _);
    }

    private class <>c__DisplayClass66_0
    {
        public PRISM.StreamingViewer.StageView stageViewComponent;
        private bool <ConfirmStreamingInfoAsync>b__1();
    }

    private class <>c__DisplayClass66_1
    {
        public PRISM.StreamingViewer.AvatarView avatarViewComponent;
        private bool <ConfirmStreamingInfoAsync>b__2();
    }

    private struct <ConfirmStreamingInfoAsync>d__66 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Mobile.OurStreamLiveViewingView <>4__this;
        public System.Threading.CancellationToken ct;
        private System.Collections.Generic.List<PRISM.StreamingNetwork.PrismView> <viewList>5__2;
        private Awaiter <>u__1;
        private int <i>5__3;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <InitializeAsync>d__54 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Mobile.OurStreamLiveViewingView <>4__this;
        public PRISM.Adapters.OurstreamLiveViewingArgument argument;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private Awaiter<CriWare.CriAtomExPlayback> <>u__1;
        private Awaiter <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <TerminateAsync>d__56 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Mobile.OurStreamLiveViewingView <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_loadFrontispieceAsync>d__75 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Mobile.OurStreamLiveViewingView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        private int <i>5__2;
        private UnityEngine.Sprite[] <>7__wrap2;
        private int <>7__wrap3;
        private Awaiter<UnityEngine.Sprite> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Mobile
public class OurStreamMessagePopupCaller
{
    public static Cysharp.Threading.Tasks.UniTask ShowLiveViewingEndedPopupAsync(System.Threading.CancellationToken ct);
    public static Cysharp.Threading.Tasks.UniTask ShowArchiveViewingPeriodExpiredPopupAsync(System.Threading.CancellationToken ct);
    public static Cysharp.Threading.Tasks.UniTask<bool> ShowLiveStreamingErrorPopupAsync(System.Threading.CancellationToken ct);
    public static Cysharp.Threading.Tasks.UniTask<bool> ShowOurStreamTicketCompletedPopupAsync(bool isLive, System.Threading.CancellationToken ct);
}

// Namespace: PRISM.Interactions.Mobile
public class OurStreamTabButton : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView tabButton;
    private ENTERPRISE.UI.UITextMeshProUGUI tabText;
    private ENTERPRISE.OutGame.BadgeNumber badgeNumber;
    private LiveStatus <LiveStatus>k__BackingField;
    public PRISM.Interactions.ButtonView Button { get; set; }
    public LiveStatus LiveStatus { get; set; }
    public System.IObservable<UniRx.Unit> OnClickTabButton { get; set; }
    public void Setup(LiveStatus status, string text, int badgeCount);
    public void SetText(string text);
    public void SetBadgeNumber(int count);
}

// Namespace: PRISM.Interactions.Mobile
public class OurStreamTabGroup : UnityEngine.MonoBehaviour, PRISM.Adapters.IOurStreamTabGroup
{
    private PRISM.Interactions.Mobile.OurStreamTabButton[] tabButtons;
    public System.IObservable<System.ValueTuple<int, LiveStatus>> OnClickTabButton { get; set; }
    public void Initialize(UniRx.IReactiveProperty<int> selectedIndex, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.ILiveStreamProgramStatus> tabLiveList, int notDisplayedArchiveCount);
    public void UpdateTabButtons(System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.ILiveStreamProgramStatus> tabLiveList, int notDisplayedArchiveCount);
    public void SetActive(bool isActive);
    private System.Collections.Generic.List<LiveStatus> _getTabStatusList(System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.ILiveStreamProgramStatus> tabLiveList);
    private string _getTabName(LiveStatus liveStatus);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Interactions.Mobile.OurStreamTabButton, int, System.IObservable<System.ValueTuple<int, LiveStatus>>> <>9__2_0;
        public static System.Func<PRISM.Interactions.Mobile.OurStreamTabButton, PRISM.Interactions.ButtonView> <>9__3_0;
        private System.IObservable<System.ValueTuple<int, LiveStatus>> <get_OnClickTabButton>b__2_0(PRISM.Interactions.Mobile.OurStreamTabButton x, int i);
        private PRISM.Interactions.ButtonView <Initialize>b__3_0(PRISM.Interactions.Mobile.OurStreamTabButton x);
    }

    private class <>c__DisplayClass2_0
    {
        public int i;
        public PRISM.Interactions.Mobile.OurStreamTabButton x;
        private System.ValueTuple<int, LiveStatus> <get_OnClickTabButton>b__1(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.Mobile
public class OurStreamTicketButton : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView button;
    private UnityEngine.UI.RawImage ticketImage;
    private ENTERPRISE.UI.UITextMeshProUGUI ticketNumText;
    public void Initialize(PRISM.Adapters.Mobile.OurStreamTicketModel ticketModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);

    private class <>c__DisplayClass3_0
    {
        public PRISM.Adapters.Mobile.OurStreamTicketModel ticketModel;
        public PRISM.Interactions.Mobile.OurStreamTicketButton <>4__this;
        private void <Initialize>b__0(UniRx.Unit _);
        private void <Initialize>b__1(PRISM.Module.Networking.IHavingProductStatus ticket);
    }
}

// Namespace: PRISM.Interactions.Mobile
public class OurStreamArchiveListHeaderTab : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView tabButton;
    private PRISM.Interactions.ViewStateChanger selectStateChanger;
    private PRISM.Interactions.ViewStateChanger sortStateChanger;
    private ENTERPRISE.OutGame.BadgeNumber badgeNumber;
    private bool <IsSortDown>k__BackingField;
    public bool IsSortDown { get; set; }
    public System.IObservable<UniRx.Unit> OnClickAsObservable();
    public void ChangeSortToggle();
    public void SetSortToggle(bool isSortDown);
    public void Toggle(bool isOn);
    public void SetBadgeNumber(int count);
    private void Awake();
}

// Namespace: PRISM.Interactions.Mobile
public class OurStreamArchiveListHeaderTabGroup : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.Mobile.OurStreamArchiveListHeaderTab[] tabArray;
    private UniRx.Subject<System.ValueTuple<int, bool>> onClickTabSubject;
    private int currentTabIndex;
    public System.IObservable<System.ValueTuple<int, bool>> OnClickHeaderTabButton { get; set; }
    public void Initialize(int tabIndex);
    public void SetTab(int tabIndex);
    public void SetSortTab(int tabIndex, bool isSortDown);
    public void ResetSortToggle();
    public void SetArchiveTabBadgeNumber(System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IArchiveStreamProgramStatus> archiveList);
    private void OnDestroy();
    private void _onClickTab(int tabIndex);
    private void _setArchiveTabBadgeNumber(System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IArchiveStreamProgramStatus> archiveList, ArchiveCategory category);

    private class <>c__DisplayClass12_0
    {
        public ArchiveCategory category;
        private bool <_setArchiveTabBadgeNumber>b__0(PRISM.Module.Networking.IArchiveStreamProgramStatus x);
    }

    private class <>c__DisplayClass5_0
    {
        public int index;
        public PRISM.Interactions.Mobile.OurStreamArchiveListHeaderTabGroup <>4__this;
        private void <Initialize>b__0(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.Mobile
public class OurStreamLiveDetailCellView : PRISM.Interactions.Mobile.OurStreamDetailCellViewBase
{
    private PRISM.Interactions.ButtonView liveViewingButton;
    private ENTERPRISE.UI.UITextMeshProUGUI liveViewingButtonText;
    private PRISM.Interactions.ViewStateChanger liveStatusStateChanger;
    private System.IDisposable beginTimeDisposable;
    private UniRx.Subject<UniRx.Unit> onRefreshSubject;
    public System.IObservable<UniRx.Unit> OnClickLiveViewingButton { get; set; }
    public System.IObservable<UniRx.Unit> OnRefresh { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Module.Networking.ILiveStreamProgramStatus liveData, System.Threading.CancellationToken ct);
    public void Terminate();
    private void _setLiveStatus(LiveStreamProgramState status);
    private void _liveStreamBeginTimer(LiveStreamProgramState status, System.Nullable<System.DateTime> beginDate);

    private class <>c__DisplayClass12_0
    {
        public System.Nullable<System.DateTime> beginDate;
        public PRISM.Interactions.Mobile.OurStreamLiveDetailCellView <>4__this;
        private void <_liveStreamBeginTimer>b__0(long _);
    }
}

// Namespace: PRISM.Interactions.Mobile
public class OurStreamTopScreenView : UnityEngine.MonoBehaviour, PRISM.Adapters.Mobile.IOurStreamTopScreenView
{
    private PRISM.Interactions.ButtonView favoriteButton;
    private PRISM.Interactions.Mobile.OurStreamTicketButton ticketButton;
    private UnityEngine.Transform liveCellViewParent;
    private PRISM.Interactions.Mobile.OurStreamLiveDetailCellView liveCellViewPrefab;
    private PRISM.Interactions.Mobile.OurStreamArchiveListHeaderTabGroup archiveHeaderTabGroup;
    private UnityEngine.GameObject archiveViewArea;
    private UnityEngine.Transform archiveCellViewParent;
    private PRISM.Interactions.Mobile.OurStreamArchiveCellView archiveCellViewPrefab;
    private UnityEngine.GameObject archiveListEmptyView;
    private ENTERPRISE.UI.UITextMeshProUGUI emptyText;
    private PRISM.Interactions.Mobile.MobileScreenFader screenFader;
    private PRISM.HowToPlayPopupOpener howToPlayOurStreamPopupOpener;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    private UniRx.CompositeDisposable disposableCellView;
    private UniRx.Subject<int> onClickLiveDetailSubject;
    private UniRx.Subject<int> onClickLiveViewingSubject;
    private UniRx.Subject<int> onClickArchiveSelectSubject;
    private UniRx.Subject<System.ValueTuple<int, bool>> onClickFavoriteToggleSubject;
    private UniRx.Subject<UniRx.Unit> onRefreshSubject;
    private System.Collections.Generic.List<PRISM.Interactions.Mobile.OurStreamLiveDetailCellView> liveCellViewList;
    private System.Collections.Generic.List<PRISM.Interactions.Mobile.OurStreamArchiveCellView> archiveCellList;
    private UnityEngine.Pool.ObjectPool<PRISM.Interactions.Mobile.OurStreamLiveDetailCellView> liveCellViewPool;
    private UnityEngine.Pool.ObjectPool<PRISM.Interactions.Mobile.OurStreamArchiveCellView> archiveCellViewPool;
    private UnityEngine.UI.ScrollRect archiveScrollRect;
    public System.IObservable<int> OnClickDetailButton { get; set; }
    public System.IObservable<int> OnClickLiveViewingButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickFavoriteButton { get; set; }
    public System.IObservable<int> OnClickArchiveButton { get; set; }
    public System.IObservable<System.ValueTuple<int, bool>> OnClickFavoriteToggle { get; set; }
    public System.IObservable<System.ValueTuple<int, bool>> OnClickHeaderTabButton { get; set; }
    public System.IObservable<UniRx.Unit> OnRefresh { get; set; }
    public float ArchiveVerticalNormalizedPosition { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Adapters.Mobile.OurStreamTopParameter parameter, System.Collections.Generic.List<PRISM.Module.Networking.ILiveStreamProgramStatus> tabLiveList, System.Collections.Generic.List<PRISM.Module.Networking.IArchiveStreamProgramStatus> archiveList, PRISM.Adapters.Mobile.OurStreamTicketModel ticketModel, System.Threading.CancellationToken ct);
    public void Terminate();
    public Cysharp.Threading.Tasks.UniTask OnClickTabAsync(int index, int headerTabIndex, System.Collections.Generic.List<PRISM.Module.Networking.ILiveStreamProgramStatus> tabLiveList, System.Collections.Generic.List<PRISM.Module.Networking.IArchiveStreamProgramStatus> archiveList, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask OnClickArchiveHeaderTabAsync(System.Collections.Generic.List<PRISM.Module.Networking.IArchiveStreamProgramStatus> archiveList, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask UpdateArchiveListAsync(System.Collections.Generic.List<PRISM.Module.Networking.IArchiveStreamProgramStatus> archiveList, System.Threading.CancellationToken ct);
    public void SetArchiveTabBadgeNumber(System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IArchiveStreamProgramStatus> archiveList);
    public Cysharp.Threading.Tasks.UniTask ShowArchiveViewingPeriodExpiredPopupAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask ShowLiveViewingEndedPopupAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask<bool> ShowOurStreamTicketCompletedPopupAsync(bool isLive, System.Threading.CancellationToken ct);
    private void _initObjectPool();
    private Cysharp.Threading.Tasks.UniTask _createLiveCellViewAsync(System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.ILiveStreamProgramStatus> tabLiveList, System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask _createArchiveListAsync(System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IArchiveStreamProgramStatus> archiveList, System.Threading.CancellationToken ct);
    private void _changeTabContant(int nextIndex);
    private void _clearLiveCellViewList();
    private void _clearArchiveCellList();
    private void <Terminate>b__41_0();
    private PRISM.Interactions.Mobile.OurStreamLiveDetailCellView <_initObjectPool>b__49_0();
    private PRISM.Interactions.Mobile.OurStreamArchiveCellView <_initObjectPool>b__49_4();
    private void <_createLiveCellViewAsync>b__50_2(UniRx.Unit _);
    private void <_createArchiveListAsync>b__51_0();

    private class <>c
    {
        public static <>c <>9;
        public static System.Action<PRISM.Interactions.Mobile.OurStreamLiveDetailCellView> <>9__49_1;
        public static System.Action<PRISM.Interactions.Mobile.OurStreamLiveDetailCellView> <>9__49_2;
        public static System.Action<PRISM.Interactions.Mobile.OurStreamLiveDetailCellView> <>9__49_3;
        public static System.Action<PRISM.Interactions.Mobile.OurStreamArchiveCellView> <>9__49_5;
        public static System.Action<PRISM.Interactions.Mobile.OurStreamArchiveCellView> <>9__49_6;
        public static System.Action<PRISM.Interactions.Mobile.OurStreamArchiveCellView> <>9__49_7;
        private void <_initObjectPool>b__49_1(PRISM.Interactions.Mobile.OurStreamLiveDetailCellView target);
        private void <_initObjectPool>b__49_2(PRISM.Interactions.Mobile.OurStreamLiveDetailCellView target);
        private void <_initObjectPool>b__49_3(PRISM.Interactions.Mobile.OurStreamLiveDetailCellView target);
        private void <_initObjectPool>b__49_5(PRISM.Interactions.Mobile.OurStreamArchiveCellView target);
        private void <_initObjectPool>b__49_6(PRISM.Interactions.Mobile.OurStreamArchiveCellView target);
        private void <_initObjectPool>b__49_7(PRISM.Interactions.Mobile.OurStreamArchiveCellView target);
    }

    private class <>c__DisplayClass50_0
    {
        public int index;
        public PRISM.Interactions.Mobile.OurStreamTopScreenView <>4__this;
        private void <_createLiveCellViewAsync>b__0(UniRx.Unit _);
        private void <_createLiveCellViewAsync>b__1(UniRx.Unit _);
    }

    private class <>c__DisplayClass51_0
    {
        public int index;
        public int id;
        public PRISM.Interactions.Mobile.OurStreamTopScreenView <>4__this;
        private void <_createArchiveListAsync>b__1(UniRx.Unit _);
        private void <_createArchiveListAsync>b__2(bool isOn);
    }

    private struct <InitializeAsync>d__40 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Mobile.OurStreamTopScreenView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public PRISM.Adapters.Mobile.OurStreamTopParameter parameter;
        public System.Collections.Generic.List<PRISM.Module.Networking.ILiveStreamProgramStatus> tabLiveList;
        public System.Threading.CancellationToken ct;
        public System.Collections.Generic.List<PRISM.Module.Networking.IArchiveStreamProgramStatus> archiveList;
        public PRISM.Adapters.Mobile.OurStreamTicketModel ticketModel;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <OnClickTabAsync>d__42 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Mobile.OurStreamTopScreenView <>4__this;
        public int headerTabIndex;
        public System.Collections.Generic.List<PRISM.Module.Networking.ILiveStreamProgramStatus> tabLiveList;
        public System.Threading.CancellationToken ct;
        public System.Collections.Generic.List<PRISM.Module.Networking.IArchiveStreamProgramStatus> archiveList;
        public int index;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_createArchiveListAsync>d__51 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Mobile.OurStreamTopScreenView <>4__this;
        public System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IArchiveStreamProgramStatus> archiveList;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Mobile
public class OurStreamUtility
{
    public static string GetArchiveTimeFormatText(int seconds);
    public static string GetDateFormatText(System.Nullable<System.DateTime> dateTime);
    public static string GetShortDateFormatText(System.Nullable<System.DateTime> dateTime);
}

// Namespace: PRISM.Interactions.Mobile
public class MobileOverlayView : UnityEngine.MonoBehaviour, PRISM.Adapters.Mobile.IMobileOverlayView, PRISM.Adapters.IClosableOverlayView<PRISM.Adapters.Mobile.MobileOverlayResult>, PRISM.Adapters.IOverlayView, PRISM.Adapters.IClosable<PRISM.Adapters.Mobile.MobileOverlayResult>
{
    private int mobilePuDeviceIn;
    private int mobilePuDeviceInSkip;
    private int mobilePuDeviceOut;
    private int mobilePuDeviceOutSkip;
    private UnityEngine.Animator animator;
    private UnityEngine.GameObject overlayTitleBody;
    private ENTERPRISE.UI.UITextMeshProUGUI overlayTitleText;
    private PRISM.Interactions.Mobile.MobileLoadingScreen loadingScreen;
    private UnityEngine.GameObject uiParent;
    private PRISM.Interactions.ButtonView backButton;
    private PRISM.Interactions.ButtonView headerBackButtonSimple;
    private PRISM.Interactions.ButtonView headerBackButtonWithBg;
    private PRISM.Interactions.ButtonView canselButton;
    private PRISM.Interactions.Mobile.MobileMenu mobileMenu;
    private PRISM.Interactions.Mobile.OurStreamTabGroup ourStreamTabGroup;
    private PRISM.Interactions.ButtonView howToPlayOurStreamButton;
    private PRISM.HowToPlayPopupOpener howToPlayOurStreamPopupOpener;
    private PRISM.Interactions.Mobile.MobileStandbyScreenView standbyScreenView;
    private PRISM.Interactions.Mobile.MobileScreenConnectorView screenConnectorView;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<PRISM.Adapters.Mobile.MobileOverlayResult> onCloseRequested;
    private PRISM.Adapters.Mobile.MobileOverlayViewModel viewModel;
    private EndConnectorAsync endConnectorAsyncFunc;
    private TerminateConnectorAsync terminateConnectorAsyncFunc;
    public PRISM.Adapters.Mobile.IMobileMenu MobileMenu { get; set; }
    public PRISM.Adapters.IOurStreamTabGroup OurStreamTabGroup { get; set; }
    public PRISM.Adapters.Mobile.IMobileLoadingScreen LoadingScreen { get; set; }
    public PRISM.Adapters.Mobile.IMobileStandbyScreenView StandbyScreenView { get; set; }
    public PRISM.Adapters.Mobile.IMobileScreenConnectorView ScreenConnectorView { get; set; }
    private Cysharp.Threading.Tasks.UniTask<PRISM.Adapters.Mobile.MobileOverlayResult> PRISM.Adapters.IClosable<PRISM.Adapters.Mobile.MobileOverlayResult>.OnCloseRequested { get; set; }
    private Cysharp.Threading.Tasks.UniTask PRISM.Adapters.IOverlayView.ShowAsync(System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask PRISM.Adapters.IOverlayView.HideAsync();
    public void Initialize(PRISM.Adapters.Mobile.MobileOverlayViewModel viewModel, EndConnectorAsync onEndConnectorAsyncFunc, TerminateConnectorAsync onTerminateConnectorAsyncFunc);
    public PRISM.Adapters.Mobile.MobileScreenConnectorPresenter CreateConnector();
    public void ShowTitle(bool isOn);
    public void ShowAllUI(bool isOn);
    public void ShowHeaderBackButton(bool isActive, bool withBg);
    public void ShowHowToPlayOurStreamButton(bool isActive);
    public Cysharp.Threading.Tasks.UniTask PlayShowAnimationAsync(System.Threading.CancellationToken cancellationToken);
    private Cysharp.Threading.Tasks.UniTask _closeOverlayAsync(System.Action viewJumper);
    private Cysharp.Threading.Tasks.UniTask _backScreenAsync(PRISM.Adapters.Mobile.MobileScreenConnectorPresenter screenConnector, System.Threading.CancellationToken ct);
    private void <CreateConnector>b__38_0(System.Action viewJumper);

    private class <>c__DisplayClass37_0
    {
        public PRISM.Interactions.Mobile.MobileOverlayView <>4__this;
        public PRISM.Adapters.Mobile.MobileOverlayViewModel viewModel;
        private void <Initialize>b__0(UniRx.Unit _);
        private void <Initialize>b__1(UniRx.Unit _);
        private void <Initialize>b__2(UniRx.Unit _);
    }

    private struct <PRISM-Adapters-IOverlayView-HideAsync>d__36 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Mobile.MobileOverlayView <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_backScreenAsync>d__45 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Adapters.Mobile.MobileScreenConnectorPresenter screenConnector;
        public PRISM.Interactions.Mobile.MobileOverlayView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private Awaiter<BackResultType> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_closeOverlayAsync>d__44 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Mobile.MobileOverlayView <>4__this;
        public System.Action viewJumper;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Mobile
public class MobileThumbnailOverlayView : UnityEngine.MonoBehaviour, PRISM.Adapters.IMobileThumbnailOverlayView, PRISM.Adapters.IClosableOverlayView<UniRx.Unit>, PRISM.Adapters.IOverlayView, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private UnityEngine.UI.Image thumbnailImage;
    private ENTERPRISE.UI.UIButton thumbnailButton;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private int currentSpriteIndex;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(System.Collections.Generic.IEnumerable<string> imageKeys, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken cancellationToken);
    private Cysharp.Threading.Tasks.UniTask PRISM.Adapters.IOverlayView.ShowAsync(System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask PRISM.Adapters.IOverlayView.HideAsync();

    private class <>c
    {
        public static <>c <>9;
        public static System.Action<UniRx.Unit, PRISM.Interactions.Mobile.MobileThumbnailOverlayView> <>9__6_0;
        private void <InitializeAsync>b__6_0(UniRx.Unit _, PRISM.Interactions.Mobile.MobileThumbnailOverlayView state);
    }

    private class <>c__DisplayClass6_0
    {
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken cancellationToken;
        public UnityEngine.Sprite[] sprites;
        private Cysharp.Threading.Tasks.UniTask<UnityEngine.Sprite> <InitializeAsync>b__2(string x);
        private void <InitializeAsync>b__1(UniRx.Unit _, PRISM.Interactions.Mobile.MobileThumbnailOverlayView state);
    }

    private struct <InitializeAsync>d__6 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken cancellationToken;
        public PRISM.Interactions.Mobile.MobileThumbnailOverlayView <>4__this;
        public System.Collections.Generic.IEnumerable<string> imageKeys;
        private <>c__DisplayClass6_0 <>8__1;
        private Awaiter<UnityEngine.Sprite[]> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Mobile
public class TwestaArticleCell : EnhancedUI.EnhancedScroller.EnhancedScrollerCellView
{
    private ENTERPRISE.UI.UIButton articleButton;
    private UnityEngine.GameObject noticeBadge;
    private PRISM.Interactions.Mobile.TwestaFavoriteToggle favoriteToggle;
    private ENTERPRISE.UI.UITextMeshProUGUI userNameText;
    private ENTERPRISE.UI.UITextMeshProUGUI articleBodyText;
    private UnityEngine.UI.Image iconImage;
    private ENTERPRISE.UI.UIButton iconButton;
    private UnityEngine.GameObject thumbnailPos;
    private PRISM.Interactions.Mobile.MobileThumbnail thumbnail;
    private UnityEngine.GameObject moviePos;
    private UnityEngine.UI.Image movieThumbnailImage;
    private PRISM.Interactions.ButtonView movieButton;
    private UnityEngine.GameObject commentCountPos;
    private ENTERPRISE.UI.UITextMeshProUGUI commentCountText;
    private UnityEngine.Transform commentPos;
    private PRISM.Interactions.Mobile.TwestaCommentCell commentCellPrefab;
    private int maxCommentNum;
    private UnityEngine.GameObject separator;
    private System.Collections.Generic.List<PRISM.Interactions.Mobile.TwestaCommentCell> activeCommentCellViewList;
    private UnityEngine.Pool.ObjectPool<PRISM.Interactions.Mobile.TwestaCommentCell> commentCellViewPool;
    public System.IObservable<UniRx.Unit> OnClickArticle { get; set; }
    public System.IObservable<UniRx.Unit> OnClickIcon { get; set; }
    public System.IObservable<bool> OnClickFavoriteToggle { get; set; }
    public System.IObservable<UniRx.Unit> OnClickThumbnail { get; set; }
    public System.IObservable<UniRx.Unit> OnClickMovie { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.Mobile.ITwestaArticleCellData cellData, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask _initializeIconAsync(PRISM.Adapters.Mobile.ITwestaArticleCellData cellData, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask _initializeThumbnailAsync(PRISM.Adapters.Mobile.ITwestaArticleCellData cellData, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask _initializeThumbnailForMovieAsync(PRISM.Adapters.Mobile.ITwestaArticleCellData cellData, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask _initializeCommentsAsync(PRISM.Adapters.Mobile.ITwestaArticleCellData cellData, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    private void Awake();
    private PRISM.Interactions.Mobile.TwestaCommentCell <Awake>b__35_0();

    private class <>c
    {
        public static <>c <>9;
        public static System.Action<PRISM.Interactions.Mobile.TwestaCommentCell> <>9__35_1;
        public static System.Action<PRISM.Interactions.Mobile.TwestaCommentCell> <>9__35_2;
        public static System.Action<PRISM.Interactions.Mobile.TwestaCommentCell> <>9__35_3;
        private void <Awake>b__35_1(PRISM.Interactions.Mobile.TwestaCommentCell target);
        private void <Awake>b__35_2(PRISM.Interactions.Mobile.TwestaCommentCell target);
        private void <Awake>b__35_3(PRISM.Interactions.Mobile.TwestaCommentCell target);
    }
}

// Namespace: PRISM.Interactions.Mobile
public class TwestaCommentCell : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI userNameText;
    private ENTERPRISE.UI.UITextMeshProUGUI commentText;
    private UnityEngine.UI.Image iconImage;
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.Mobile.TwestaCommentCellData cellData, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
}

// Namespace: PRISM.Interactions.Mobile
public class TwestaDetailScreenView : UnityEngine.MonoBehaviour, PRISM.Adapters.Mobile.ITwestaDetailScreenView
{
    private PRISM.Interactions.Mobile.TwestaScrollerView scrollerView;
    private PRISM.Interactions.Mobile.MobileScreenFader screenFader;
    public PRISM.Adapters.Mobile.ITwestaScrollerView TwestaScrollerView { get; set; }
    public void Inject(PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void Terminate();
    private void <Terminate>b__5_0();
}

// Namespace: PRISM.Interactions.Mobile
public class TwestaFavoriteScreenView : UnityEngine.MonoBehaviour, PRISM.Adapters.Mobile.ITwestaFavoriteScreenView
{
    private PRISM.Interactions.Mobile.MobileScreenHeader header;
    private ENTERPRISE.UI.UITextMeshProUGUI[] emptyTexts;
    private PRISM.Interactions.Mobile.TwestaScrollerView scrollerView;
    private PRISM.Interactions.Mobile.MobileScreenFader screenFader;
    public PRISM.Adapters.Mobile.ITwestaScrollerView TwestaScrollerView { get; set; }
    public void Initialize(PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void Terminate();
    private void <Terminate>b__7_0();
}

// Namespace: PRISM.Interactions.Mobile
public class TwestaFavoriteToggle : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.ToggleButton favoriteToggle;
    private UnityEngine.ParticleSystem particle;
    private UniRx.Subject<bool> onClickSubject;
    public System.IObservable<bool> OnClick { get; set; }
    public void Initialize(bool isFavorite);
    private void Awake();
    private void <Initialize>b__5_0();
}

// Namespace: PRISM.Interactions.Mobile
public class TwestaProfileScreenView : UnityEngine.MonoBehaviour, PRISM.Adapters.Mobile.ITwestaProfileScreenView
{
    private PRISM.Interactions.Mobile.MobileScreenHeader header;
    private PRISM.Interactions.Mobile.TwestaScrollerView scrollerView;
    private PRISM.Interactions.Mobile.MobileScreenFader screenFader;
    public PRISM.Adapters.Mobile.ITwestaScrollerView TwestaScrollerView { get; set; }
    public void Initialize(PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void Terminate();
    private void <Terminate>b__6_0();
}

// Namespace: PRISM.Interactions.Mobile
public class TwestaScrollerView : UnityEngine.MonoBehaviour, EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate, PRISM.Adapters.Mobile.ITwestaScrollerView
{
    private EnhancedUI.EnhancedScroller.EnhancedScroller scroller;
    private PRISM.Interactions.Mobile.TwestaArticleCell articleCellPrefab;
    private UnityEngine.GameObject emptyView;
    private UniRx.Subject<PRISM.Adapters.Mobile.ITwestaArticleCellData> onClickArticle;
    private UniRx.Subject<int> onClickIcon;
    private UniRx.Subject<PRISM.Adapters.Mobile.ITwestaArticleCellData> onClickFavoriteToggle;
    private UniRx.Subject<PRISM.Adapters.Mobile.ITwestaArticleCellData> onClickThumbnail;
    private UniRx.Subject<PRISM.Adapters.Mobile.ITwestaArticleCellData> onClickMovieThumbnail;
    private System.Collections.Generic.List<TwestaArticleCellDataWithDisposables> cellDataWithDisposablesList;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    public System.IObservable<PRISM.Adapters.Mobile.ITwestaArticleCellData> OnClickArticle { get; set; }
    public System.IObservable<int> OnClickIcon { get; set; }
    public System.IObservable<PRISM.Adapters.Mobile.ITwestaArticleCellData> OnClickFavoriteToggle { get; set; }
    public System.IObservable<PRISM.Adapters.Mobile.ITwestaArticleCellData> OnClickThumbnail { get; set; }
    public System.IObservable<PRISM.Adapters.Mobile.ITwestaArticleCellData> OnClickMovieThumbnail { get; set; }
    public float CurrentScrollPosition { get; set; }
    public void Inject(PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void Initialize();
    public void Terminate();
    public void UpdateScrollPosition(float scrollPosition);
    public bool CellExists(int twestaArticleId);
    public void AddCell(PRISM.Adapters.Mobile.ITwestaArticleCellData cellData);
    public void RemoveCell(int twestaArticleId);
    public void UpdateView();
    private int EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate.GetNumberOfCells(EnhancedUI.EnhancedScroller.EnhancedScroller scroller);
    private float EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate.GetCellViewSize(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex);
    public EnhancedUI.EnhancedScroller.EnhancedScrollerCellView GetCellView(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex, int cellIndex);
    private void _scrollerCellViewVisibilityChanged(EnhancedUI.EnhancedScroller.EnhancedScrollerCellView cellView);
    private void _cellViewWillRecycle(EnhancedUI.EnhancedScroller.EnhancedScrollerCellView cellView);

    private class TwestaArticleCellDataWithDisposables
    {
        private PRISM.Adapters.Mobile.ITwestaArticleCellData <CellData>k__BackingField;
        private UniRx.CompositeDisposable <Disposables>k__BackingField;
        private System.Threading.CancellationTokenSource <CancellationTokenSource>k__BackingField;
        public PRISM.Adapters.Mobile.ITwestaArticleCellData CellData { get; set; }
        public UniRx.CompositeDisposable Disposables { get; set; }
        public System.Threading.CancellationTokenSource CancellationTokenSource { get; set; }
    }

    private class <>c__DisplayClass26_0
    {
        public int twestaArticleId;
        private bool <CellExists>b__0(TwestaArticleCellDataWithDisposables x);
    }

    private class <>c__DisplayClass28_0
    {
        public int twestaArticleId;
        private bool <RemoveCell>b__0(TwestaArticleCellDataWithDisposables x);
    }

    private class <>c__DisplayClass33_0
    {
        public PRISM.Interactions.Mobile.TwestaScrollerView <>4__this;
        public PRISM.Adapters.Mobile.ITwestaArticleCellData cellData;
        private void <_scrollerCellViewVisibilityChanged>b__0(UniRx.Unit _);
        private void <_scrollerCellViewVisibilityChanged>b__1(UniRx.Unit _);
        private void <_scrollerCellViewVisibilityChanged>b__2(bool _);
        private void <_scrollerCellViewVisibilityChanged>b__3(UniRx.Unit _);
        private void <_scrollerCellViewVisibilityChanged>b__4(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.Mobile
public class TwestaTopScreenView : UnityEngine.MonoBehaviour, PRISM.Adapters.Mobile.ITwestaTopScreenView
{
    private ENTERPRISE.UI.UIButton favoriteButton;
    private PRISM.Interactions.Mobile.TwestaScrollerView scrollerView;
    private PRISM.Interactions.Mobile.MobileScreenFader screenFader;
    private UniRx.Subject<UniRx.Unit> onClickFavoriteButtonSubject;
    public PRISM.Adapters.Mobile.ITwestaScrollerView TwestaScrollerView { get; set; }
    public System.IObservable<UniRx.Unit> OnClickFavoriteButton { get; set; }
    public void Initialize(PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void Terminate();
    private void <Initialize>b__8_0();
    private void <Terminate>b__9_0();
}

// Namespace: PRISM.Interactions.Mobile
public class TwestaFavoriteEffectGenerator : UnityEngine.MonoBehaviour
{
    private int favoriteEffectAnimatorNameIdle;
    private int favoriteEffectAnimatorNameOn;
    private UnityEngine.Animator twestaFavoriteEffect;
    private UnityEngine.Transform targetPos;
    private UnityEngine.Pool.ObjectPool<UnityEngine.Animator> effectPool;
    public void Initialize();
    public void ShowFavoriteEffect();
    public void Terminate();
    private UnityEngine.Animator <Initialize>b__5_0();
    private void <Initialize>b__5_2(UnityEngine.Animator target);

    private class <>c
    {
        public static <>c <>9;
        public static System.Action<UnityEngine.Animator> <>9__5_1;
        public static System.Action<UnityEngine.Animator> <>9__5_3;
        private void <Initialize>b__5_1(UnityEngine.Animator target);
        private void <Initialize>b__5_3(UnityEngine.Animator target);
    }

    private class <>c__DisplayClass6_0
    {
        public UnityEngine.Animator effect;
        public PRISM.Interactions.Mobile.TwestaFavoriteEffectGenerator <>4__this;
        private Cysharp.Threading.Tasks.UniTask <ShowFavoriteEffect>b__0();

        private struct <<ShowFavoriteEffect>b__0>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
        {
            public int <>1__state;
            public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
            public <>c__DisplayClass6_0 <>4__this;
            private Awaiter <>u__1;
            private void MoveNext();
            private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=5884 0F3D740C17DCAC0DBBFA2611F3E8A568044EE12605718E58C67FDA174C722EA0;
    private static __StaticArrayInitTypeSize=8780 C5126F5E15C13D47F2CB2213B5EB1C50DED8DF1EBA61100DF8B758F4E3125BBB;

    private struct __StaticArrayInitTypeSize=5884 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=8780 : System.ValueType
    {
    }
}
