
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

// Namespace: PRISM.Interactions.FriendInvitation
public class FriendInvitationOverlayMissionGridView : PRISM.Interactions.GridView<PRISM.Interactions.FriendInvitation.FriendInvitationOverlayMissonGridViewCell, PRISM.Adapters.FriendInvitationOverlayViewCellModel>
{
    protected void SetupCellTemplate();

    private class CellGroup : DefaultCellGroup<PRISM.Adapters.FriendInvitationOverlayViewCellModel, PRISM.Interactions.GridViewContext>
    {
    }
}

// Namespace: PRISM.Interactions.FriendInvitation
public class FriendInvitationOverlayMissonGridViewCell : PRISM.Interactions.GridViewCell<PRISM.Adapters.FriendInvitationOverlayViewCellModel>
{
    private ENTERPRISE.UI.UITextMeshProUGUI missionText;
    private PRISM.Interactions.RewardItemIcon rewardItemIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI progressText;
    private UnityEngine.UI.Image progressImage;
    private UnityEngine.GameObject closeLayoutObject;
    private UnityEngine.GameObject clearStampImageObject;
    public void UpdateContent(PRISM.Adapters.FriendInvitationOverlayViewCellModel mission);
}

// Namespace: PRISM.Interactions.FriendInvitation
public class FriendInvitationOverlayView : PRISM.Interactions.OverlayViewWithCloseButton, PRISM.Adapters.IFriendInvitationOverlayView, PRISM.Adapters.IClosableOverlayView<UniRx.Unit>, PRISM.Adapters.IOverlayView, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private UnityEngine.GameObject expiryObject;
    private TMPro.TextMeshProUGUI expiryDate;
    private PRISM.CommonInputFieldTMP inputField;
    private TMPro.TextMeshProUGUI inputFieldText;
    private UnityEngine.GameObject inputFieldMask;
    private PRISM.Interactions.ButtonView okButton;
    private PRISM.Interactions.FriendInvitation.FriendInvitationOverlayMissonGridViewCell missionCell;
    private TMPro.TextMeshProUGUI myInvitationCode;
    private PRISM.Interactions.ButtonView copyButton;
    private PRISM.Interactions.ButtonView issueButton;
    private PRISM.Interactions.FriendInvitation.FriendInvitationOverlayMissionGridView missionGridView;
    private UnityEngine.CanvasGroup canvasGroup;
    private PRISM.Adapters.FriendInvitationOverlayViewModel viewModel;
    public System.IObservable<UniRx.Unit> OkObservable { get; set; }
    public System.IObservable<UniRx.Unit> IssueObservable { get; set; }
    public void Setup(PRISM.Adapters.FriendInvitationOverlayViewModel viewModel);
    private void _copyInvitationCode();
    public Cysharp.Threading.Tasks.UniTask UseInvitationCodePopupAsync(bool isSuccess, System.Collections.Generic.IEnumerable<PRISM.Module.Networking.IRewardProductStatus> rewardProduct, PRISM.Module.Networking.IFriendInvitationMissionStatus selfMissons);
    public void SetMyInvitationCode(string invitationCode);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public void SetFriendInvitationCode();
    private void <Setup>b__17_0(UniRx.Unit _);

    private struct <UseInvitationCodePopupAsync>d__19 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public bool isSuccess;
        public PRISM.Module.Networking.IFriendInvitationMissionStatus selfMissons;
        public PRISM.Interactions.FriendInvitation.FriendInvitationOverlayView <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=292 39A4F5F65028D02DFDE4D4697B3EEA6469DF7621346F3C1F053EECF317164ABA;
    private static __StaticArrayInitTypeSize=318 EA37257B448C71D77987452E901C304EC21FCF6D5906E0E4D787692B9799C831;

    private struct __StaticArrayInitTypeSize=292 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=318 : System.ValueType
    {
    }
}
