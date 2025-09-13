
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

// Namespace: PRISM.Definitions
public class SpecialMissionSeConst
{
    public static string SheetName;
    public static PRISM.Definitions.SoundKey StepComplete;
    public static PRISM.Definitions.SoundKey AllStepComplete;
}

// Namespace: PRISM.Interactions
public class SpecialMissionAllCompletePopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.ISpecialMissionAllCompletePopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClick;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__3_0();
    private void <CreateFrameParameter>b__3_1();
}

// Namespace: PRISM.Interactions
public class SpecialMissionCompleteRewardListView : PRISM.Interactions.ListView<PRISM.Interactions.SpecialMissionCompleteRewardListViewCell, PRISM.Adapters.SpecialMissionCompleteRewardListViewModel>
{
    public void UpdateContents(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.SpecialMissionCompleteRewardListViewModel> items);
}

// Namespace: PRISM.Interactions
public class SpecialMissionCompleteRewardListViewCell : PRISM.Interactions.ListViewCell<PRISM.Adapters.SpecialMissionCompleteRewardListViewModel>
{
    private PRISM.Interactions.ReceiveRewardItem rewardItem;
    public void UpdateContent(PRISM.Adapters.SpecialMissionCompleteRewardListViewModel model);
}

// Namespace: PRISM.Interactions
public class SpecialMissionCompleteRewardPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.ISpecialMissionCompleteRewardPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private UnityEngine.Sprite[] stepNumImageList;
    private UnityEngine.UI.Image stepNumImage;
    private TMPro.TextMeshProUGUI completeText;
    private PRISM.Interactions.SpecialMissionCompleteRewardListView completeRewardListView;
    private PRISM.Interactions.SpecialMissionCompleteRewardListViewCell rewardViewCell;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClick;
    private PopupSizeType popupSize;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    public void Setup(System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IRewardProductStatus> rewardList, int stepNum, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private void <CreateFrameParameter>b__9_0();
    private void <CreateFrameParameter>b__9_1();
}

// Namespace: PRISM.Interactions
public class SpecialMissionCompleteRewardView : UnityEngine.MonoBehaviour, PRISM.Adapters.ISpecialMissionCompleteRewardView
{
    private PRISM.Interactions.RewardItemIcon[] rewardIcons;
    private ENTERPRISE.UI.UITextMeshProUGUI missionProgresLabelText;
    private ENTERPRISE.UI.UITextMeshProUGUI missionProgresText;
    private UnityEngine.GameObject missionCompleteObject;
    private UnityEngine.GameObject missionTermRoot;
    private ENTERPRISE.UI.UITextMeshProUGUI missionTermLabelText;
    private ENTERPRISE.UI.UITextMeshProUGUI missionTermText;
    private ENTERPRISE.UI.UITextMeshProUGUI missionCompleteLabelText;
    private UnityEngine.GameObject completeRewardReceivedObject;
    public void UpdateCompleteReward(int missionProgress, int missionMax, System.Collections.Generic.IEnumerable<PRISM.Module.Networking.IProductWithAmountStatus> Product, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Nullable<System.DateTime> term, bool isCompleteRewardReceived, bool isUnlocked);
}

// Namespace: PRISM.Interactions
public class SpecialMissionHintPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.ISpecialMissionHintPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClick;
    private PRISM.Adapters.SpecialMissionHintPopupViewModel viewModel;
    private ENTERPRISE.UI.UITextMeshProUGUI missionText;
    private ENTERPRISE.UI.UITextMeshProUGUI hintText;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public void Assign(PRISM.Adapters.SpecialMissionHintPopupViewModel vm);
    private void _setup();
    private void <CreateFrameParameter>b__6_0();
    private void <CreateFrameParameter>b__6_1();

    private struct <LoadAsync>d__14 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
        public PRISM.Interactions.SpecialMissionHintPopupView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter<bool> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <ShowAsync>d__12 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.SpecialMissionHintPopupView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class SpecialMissionListContext : PRISM.Interactions.ListViewContext
{
    public UniRx.Subject<PRISM.Adapters.SpecialMissionListViewModel> OnListButtonClickedSubject;
    public UniRx.Subject<PRISM.Adapters.SpecialMissionListViewModel> OnUnknownButtonClickedSubject;
    public void Dispose();
}

// Namespace: PRISM.Interactions
public class SpecialMissionListView : PRISM.Interactions.ListView<PRISM.Interactions.SpecialMissionListViewCell, PRISM.Adapters.SpecialMissionListViewModel, PRISM.Interactions.SpecialMissionListContext>, PRISM.Adapters.ISpecialMissionListView
{
    private ENTERPRISE.UI.UITextMeshProUGUI emptyText;
    public System.IObservable<PRISM.Adapters.SpecialMissionListViewModel> OnMissionButtonClicked { get; set; }
    public System.IObservable<PRISM.Adapters.SpecialMissionListViewModel> OnUnknownnButtonClicked { get; set; }
    public void SetEmptyText(string text);
    public void UpdateContents(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.SpecialMissionListViewModel> items);
}

// Namespace: PRISM.Interactions
public class SpecialMissionListViewCell : PRISM.Interactions.ListViewCell<PRISM.Adapters.SpecialMissionListViewModel, PRISM.Interactions.SpecialMissionListContext>
{
    private ENTERPRISE.UI.ButtonBase listButton;
    private ENTERPRISE.UI.ButtonBase unknownButton;
    private UnityEngine.GameObject getButtonObject;
    private UnityEngine.GameObject challengeButtonObject;
    private UnityEngine.GameObject closeButtonObject;
    private ENTERPRISE.UI.UITextMeshProUGUI missionText;
    private UnityEngine.UI.Image gauge;
    private ENTERPRISE.UI.UITextMeshProUGUI progressText;
    private PRISM.Interactions.RewardItemIcon[] rewardItemIcon;
    private UnityEngine.GameObject closeLayoutObject;
    private UnityEngine.GameObject clearStampObject;
    public void UpdateContent(PRISM.Adapters.SpecialMissionListViewModel viewModel);

    private class <>c__DisplayClass11_0
    {
        public PRISM.Interactions.SpecialMissionListViewCell <>4__this;
        public PRISM.Adapters.SpecialMissionListViewModel viewModel;
        private void <UpdateContent>b__0();
        private void <UpdateContent>b__1();
    }
}

// Namespace: PRISM.Interactions
public class SpecialMissionPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.ISpecialMissionPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.SpecialMissionListView specialMissionListView;
    private PRISM.Interactions.SpecialMissionCompleteRewardView specialMissionCompleteRewardView;
    private PRISM.Interactions.SpecialMissionTabGroupView specialMissionTabGroupView;
    private ENTERPRISE.UI.UIButton allGetButton;
    private ENTERPRISE.UI.UIButton closeButton;
    private UnityEngine.GameObject allGetButtonPositiveObject;
    private UnityEngine.GameObject allGetButtonBlockObject;
    private PRISM.Adapters.SpecialMissionPopupViewModel viewModel;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    private PRISM.Interactions.IPopupFrameView parent;
    public System.IObservable<UniRx.Unit> OnAllReceiveClicked { get; set; }
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public PRISM.Adapters.ISpecialMissionListView SpecialMissionListView { get; set; }
    public PRISM.Adapters.ISpecialMissionCompleteRewardView SpecialMissionCompleteRewardView { get; set; }
    public PRISM.Adapters.ISpecialMissionTabGroupView SpecialMissionTabGroupView { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public void Assign(PRISM.Adapters.SpecialMissionPopupViewModel vm, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public Cysharp.Threading.Tasks.UniTask ShowRewardPopupAsync(System.Collections.Generic.IEnumerable<PRISM.Module.Networking.IRewardProductStatus> rewardList, System.Threading.CancellationToken ct);
    public void UpdateAll();
    public void UpdateTabChange();
    private void _setup();
    private void _updateList();
    private void _updateCompleteReward();
    private void _updateAllGetButton();
    private void <CreateFrameParameter>b__19_0();

    private struct <LoadAsync>d__27 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
        public PRISM.Interactions.SpecialMissionPopupView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter<bool> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <ShowAsync>d__25 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.SpecialMissionPopupView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class SpecialMissionTab : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.Image newIcon;
    private UnityEngine.UI.Image lockIcon;
    private UnityEngine.UI.Image selectedCompleteIcon;
    private UnityEngine.UI.Image normalCompleteIcon;
    private ENTERPRISE.OutGame.BadgeNumber selectedBadge;
    private ENTERPRISE.OutGame.BadgeNumber normalBadge;
    private ENTERPRISE.UI.UITabButton tabButton;
    public void Setup(int count, bool isComplete, bool isLock, string txt);
    public void SetNewIcon(bool isNew);
}

// Namespace: PRISM.Interactions
public class SpecialMissionTabGroupView : ENTERPRISE.UI.UITabGroup, PRISM.Adapters.ISpecialMissionTabGroupView
{
    private System.Collections.Generic.List<PRISM.Interactions.SpecialMissionTab> specialMissionTabList;
    private UnityEngine.GameObject tabPrefab;
    private UnityEngine.Transform tabRoot;
    public void CreateTabGroup(System.Collections.Generic.IReadOnlyList<PRISM.Domain.SpecialMissionStep> StepList, int defaultTab);
    public void UpdateTab(System.Collections.Generic.IReadOnlyList<PRISM.Domain.SpecialMissionStep> StepList);
    public void SetNextTabSelected();
    private void _updateTab(int index, PRISM.Domain.SpecialMissionStep missionStep);
    private ENTERPRISE.UI.UITabGroup PRISM.Adapters.ISpecialMissionTabGroupView.SetOnTabSelected(System.Action<int, ENTERPRISE.UI.UITabGroup> action);
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=677 11523F982DA0EEE8CEA56E9B08EAEE42A5E2B668F05F0807C14C56EFE2A24554;
    private static __StaticArrayInitTypeSize=1146 CA29751EF9AC1B082E2C58885AD4294C14B71354E1DAA09A4F97A4BB80363150;

    private struct __StaticArrayInitTypeSize=677 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=1146 : System.ValueType
    {
    }
}
