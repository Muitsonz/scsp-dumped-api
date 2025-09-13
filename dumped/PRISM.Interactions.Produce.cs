
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

// Namespace: PRISM
public class ScheduleChallengeMissionContent : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI missionDescriptionText;
    private UnityEngine.UI.RawImage missionIdolImage;
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Module.Networking.IScheduleDetailStatus scheduleDetail);
    private Cysharp.Threading.Tasks.UniTask _loadImageAsync(string path, UnityEngine.UI.RawImage uIImage);

    private struct <SetupAsync>d__2 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Module.Networking.IScheduleDetailStatus scheduleDetail;
        public PRISM.ScheduleChallengeMissionContent <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM
public class ScheduleDetailImageContent : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.Image scheduleImage;
    private UnityEngine.UI.Image scheduleTextImage;
    private UnityEngine.GameObject recommendObject;
    private UnityEngine.GameObject supportCharacterAreaObject;
    private System.Collections.Generic.List<PRISM.SupportCharacterSDIconContent> supportCharacterSDIconContentList;
    private UnityEngine.GameObject supportCooperationCharacterObject;
    private UnityEngine.UI.Image supportCooperationCharacterImage;
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Module.Networking.IScheduleDetailStatus scheduleDetail);
    private Cysharp.Threading.Tasks.UniTask _loadImageAsync(string path, UnityEngine.UI.Image image);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Module.Networking.ISupportCharacterIconStatus, bool> <>9__7_0;
        public static System.Func<PRISM.Module.Networking.ISupportCharacterIconStatus, bool> <>9__7_1;
        private bool <SetupAsync>b__7_0(PRISM.Module.Networking.ISupportCharacterIconStatus x);
        private bool <SetupAsync>b__7_1(PRISM.Module.Networking.ISupportCharacterIconStatus data);
    }

    private struct <SetupAsync>d__7 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.ScheduleDetailImageContent <>4__this;
        public PRISM.Module.Networking.IScheduleDetailStatus scheduleDetail;
        private Awaiter <>u__1;
        private System.Collections.Generic.List<PRISM.Module.Networking.ISupportCharacterIconStatus> <supportCharacterIconStatusDtoList>5__2;
        private int <i>5__3;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_loadImageAsync>d__8 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public string path;
        public UnityEngine.UI.Image image;
        private Awaiter<UnityEngine.Sprite> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM
public class ScheduleDetailTabButtonContent : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.Image baseImage;
    private UnityEngine.UI.Image lvBaseImage;
    private UnityEngine.GameObject recommendObject;
    private UnityEngine.GameObject supportCharacterAreaObject;
    private System.Collections.Generic.List<PRISM.SupportCharacterSDIconContent> supportCharacterSDIconContentList;
    private ENTERPRISE.UI.UITextMeshProUGUI selectedLabelText;
    private UnityEngine.GameObject selectedScheduleLevelParentObject;
    private UnityEngine.GameObject selectedScheduleLevelObject;
    private UnityEngine.GameObject selectedScheduleSupportLevelObject;
    private ENTERPRISE.UI.UITextMeshProUGUI selectedScheduleLevelText;
    private ENTERPRISE.UI.UITextMeshProUGUI selectedScheduleSupportLevelText;
    private UnityEngine.GameObject activateTabObject;
    private UnityEngine.GameObject supportBonusObject;
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Module.Networking.IScheduleDetailStatus scheduleDetail, bool isSelected, System.Threading.CancellationToken ct);
    public void TargetTabSelected(bool isSelected);
    private bool _isDisplayLevelScheduleDetail(ScheduleDetailType scheduleDetailType);
    private Cysharp.Threading.Tasks.UniTask _loadSpriteImageAsync(string path, UnityEngine.UI.Image uIImage, System.Threading.CancellationToken ct);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Module.Networking.ISupportCharacterIconStatus, bool> <>9__13_0;
        private bool <SetupAsync>b__13_0(PRISM.Module.Networking.ISupportCharacterIconStatus x);
    }

    private struct <SetupAsync>d__13 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.ScheduleDetailTabButtonContent <>4__this;
        public PRISM.Module.Networking.IScheduleDetailStatus scheduleDetail;
        public bool isSelected;
        public System.Threading.CancellationToken ct;
        private System.Collections.Generic.List<PRISM.Module.Networking.ISupportCharacterIconStatus> <supportCharacterIconStatusDtoList>5__2;
        private Awaiter <>u__1;
        private int <i>5__3;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_loadSpriteImageAsync>d__16 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public UnityEngine.UI.Image uIImage;
        public string path;
        public System.Threading.CancellationToken ct;
        private UnityEngine.UI.Image <>7__wrap1;
        private Awaiter<UnityEngine.Sprite> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM
public class ScheduleDetailTabGroupContent : UnityEngine.MonoBehaviour
{
    private System.Collections.Generic.List<PRISM.ScheduleDetailTabButtonContent> scheduleDetailTabButtonContentList;
    private ENTERPRISE.UI.UITabGroup scheduleDetailTabGroup;
    private ENTERPRISE.UI.UITextMeshProUGUI scheduleNameText;
    private ENTERPRISE.UI.UITextMeshProUGUI scheduleLvText;
    private UnityEngine.GameObject scheduleLvObject;
    private UnityEngine.UI.Image scheduleLvImage;
    private UnityEngine.GameObject supportBonusObject;
    private UnityEngine.GameObject noTabDisplayAreaObject;
    private UnityEngine.GameObject lv1Object;
    private UnityEngine.GameObject lv3Object;
    private UnityEngine.GameObject lv5Object;
    private System.Collections.Generic.List<PRISM.Module.Networking.IScheduleDetailStatus> scheduleDetailList;
    private bool isInitilized;
    private UniRx.Subject<int> onClickTab;
    public System.IObservable<int> OnClickTabObservable { get; set; }
    public UnityEngine.GameObject NoTabDisplayAreaObject { get; set; }
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Module.Networking.IScheduleStatus schedule);
    public void SetActiveTabButton(bool isActive);
    public Cysharp.Threading.Tasks.UniTask DisplayScheduleInfoAsync(PRISM.Module.Networking.IScheduleStatus schedule, System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask _setupTabInfoAsync();
    private void _setupTabGroup();
    private void _changeTargetTabIndex();
    private bool _isDisplayLevelSchedule(PRISM.Module.Networking.IScheduleStatus schedule);
    private Cysharp.Threading.Tasks.UniTask _loadSpriteImageAsync(string path, UnityEngine.UI.Image uIImage, System.Threading.CancellationToken ct);
    private bool <SetupAsync>b__18_0();
    private void <_setupTabGroup>b__22_0(int index, ENTERPRISE.UI.UITabGroup instance);

    private struct <DisplayScheduleInfoAsync>d__20 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.ScheduleDetailTabGroupContent <>4__this;
        public PRISM.Module.Networking.IScheduleStatus schedule;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <SetupAsync>d__18 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.ScheduleDetailTabGroupContent <>4__this;
        public PRISM.Module.Networking.IScheduleStatus schedule;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_loadSpriteImageAsync>d__25 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public UnityEngine.UI.Image uIImage;
        public string path;
        public System.Threading.CancellationToken ct;
        private UnityEngine.UI.Image <>7__wrap1;
        private Awaiter<UnityEngine.Sprite> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_setupTabInfoAsync>d__21 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.ScheduleDetailTabGroupContent <>4__this;
        private int <i>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM
public class ScheduleDetailTextContent : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI scheduleDetailText;
    private UnityEngine.GameObject scheduleDetailLevelObject;
    private ENTERPRISE.UI.UITextMeshProUGUI scheduleDetailLevelText;
    private UnityEngine.GameObject scheduleDetailSupportLevelObject;
    private ENTERPRISE.UI.UITextMeshProUGUI scheduleDetailSupportLevelText;
    private UnityEngine.GameObject scheduleDetailSupportBonusObject;
    public void Setup(PRISM.Module.Networking.IScheduleDetailStatus scheduleDetail);
    private bool _isLevelDisplay(ScheduleDetailType scheduleDetailType);
}

// Namespace: PRISM
public class ScheduleParameterContent : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.RawImage voRankImage;
    private ENTERPRISE.UI.UITextMeshProUGUI voValueText;
    private ENTERPRISE.UI.UITextMeshProUGUI voValiableText;
    private UnityEngine.UI.RawImage daRankImage;
    private ENTERPRISE.UI.UITextMeshProUGUI daValueText;
    private ENTERPRISE.UI.UITextMeshProUGUI daValiableText;
    private UnityEngine.UI.RawImage viRankImage;
    private ENTERPRISE.UI.UITextMeshProUGUI viValueText;
    private ENTERPRISE.UI.UITextMeshProUGUI viValiableText;
    private UnityEngine.UI.RawImage meRankImage;
    private ENTERPRISE.UI.UITextMeshProUGUI meValueText;
    private ENTERPRISE.UI.UITextMeshProUGUI meValiableText;
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Module.Networking.IScheduleDetailStatus scheduleDetail, PRISM.Module.Networking.IProduceBaseInfoStatus produceBaseInfo);
    public Cysharp.Threading.Tasks.UniTask SetupChallengeMissionAsync(PRISM.Module.Networking.IProduceParameterStatus produceParameter, PRISM.Module.Networking.IBuildUpParameterValueStatus buildUpParameterValue, PRISM.Module.Networking.IInProduceIdolBaseStatus idolBase);
    private string _getValiableDisplayString(int valiableValue, ScheduleDetailType scheduleDetailType);
    private bool _isOuting(ScheduleDetailType scheduleDetailType);

    private struct <SetupAsync>d__12 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Module.Networking.IProduceBaseInfoStatus produceBaseInfo;
        public PRISM.ScheduleParameterContent <>4__this;
        public PRISM.Module.Networking.IScheduleDetailStatus scheduleDetail;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <SetupChallengeMissionAsync>d__13 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Module.Networking.IProduceParameterStatus produceParameter;
        public PRISM.ScheduleParameterContent <>4__this;
        public PRISM.Module.Networking.IInProduceIdolBaseStatus idolBase;
        public PRISM.Module.Networking.IBuildUpParameterValueStatus buildUpParameterValue;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM
public class SupportCharacterSDIconContent : UnityEngine.MonoBehaviour
{
    private UnityEngine.GameObject supportCharaObject;
    private UnityEngine.GameObject supportCharaCooperationObject;
    private UnityEngine.GameObject supportCharaCooperationIconObject;
    private UnityEngine.UI.Image supportCharaImage;
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Module.Networking.ISupportCharacterIconStatus supportCharacterIconData);

    private struct <SetupAsync>d__4 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.SupportCharacterSDIconContent <>4__this;
        public PRISM.Module.Networking.ISupportCharacterIconStatus supportCharacterIconData;
        private UnityEngine.UI.Image <>7__wrap1;
        private Awaiter<UnityEngine.Sprite> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM
public class WeekDisplayContent : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.RawImage workOnRawImage;
    private ENTERPRISE.UI.UITextMeshProUGUI WorkOnText;
    private UnityEngine.GameObject WorkOnLineObject;
    private UnityEngine.UI.RawImage workOffRawImage;
    private ENTERPRISE.UI.UITextMeshProUGUI WorkOffText;
    private UnityEngine.GameObject WorkOffLineObject;
    public Cysharp.Threading.Tasks.UniTask SetupAsync(bool isTargetWeek, bool isLastWeek, int week, bool isInSubSeason);

    private struct <SetupAsync>d__6 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public bool isInSubSeason;
        public PRISM.WeekDisplayContent <>4__this;
        public bool isTargetWeek;
        public int week;
        public bool isLastWeek;
        private PRISM.ResourceManagement.IResourceLoader <resourceLoader>5__2;
        private string <timeUnit>5__3;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Produce
public class ProduceCardDetailPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IProduceCardDetailPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IEventSystemHandler
{
    private static string DescriptionSeparateStr;
    private UnityEngine.UI.RawImage unitIcon;
    private PRISM.VoDaViMeMultiView voDaViMeMultiView;
    private ENTERPRISE.UI.UITextMeshProUGUI cardNameText;
    private ENTERPRISE.UI.UITextMeshProUGUI cardInfoText;
    private PRISM.Produce.ProduceCardContent produceCardContent;
    private ENTERPRISE.UI.UITabGroup uiTabGroup;
    private UnityEngine.GameObject unitIconObject;
    private System.Collections.Generic.List<UnityEngine.GameObject> currentRankBalloonObjectList;
    private PRISM.Module.Networking.IProduceCardStatus produceCard;
    private System.Collections.Generic.IReadOnlyList<string> phaseCharaNames;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Initialize(PRISM.Module.Networking.IProduceCardStatus produceCard, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private void UpdateCardInfo(PRISM.Module.Networking.IProduceCardStatus card, int rank);
    public void SelectTab(int selectTab, ENTERPRISE.UI.UITabGroup uiTab);
    public void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
    private System.Collections.Generic.IReadOnlyList<int> _makeTmpLinkIDs(int selectIndex);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__19_0();
    private void <CreateFrameParameter>b__19_1();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Definitions.MstCharacterInfo, string> <>9__14_1;
        public static System.Func<TMPro.TMP_LinkInfo, bool> <>9__18_1;
        public static System.Func<TMPro.TMP_LinkInfo, int> <>9__18_2;
        private string <Initialize>b__14_1(PRISM.Definitions.MstCharacterInfo e);
        private bool <_makeTmpLinkIDs>b__18_1(TMPro.TMP_LinkInfo e);
        private int <_makeTmpLinkIDs>b__18_2(TMPro.TMP_LinkInfo e);
    }

    private class <>c__DisplayClass14_0
    {
        public int unitID;
        private bool <Initialize>b__0(PRISM.Definitions.MstCharacterInfo e);
    }

    private class <>c__DisplayClass18_0
    {
        public int selectIndex;
        private bool <_makeTmpLinkIDs>b__0(TMPro.TMP_LinkInfo t, int i);
    }
}

// Namespace: PRISM.Common
public class FilterAndSortView : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UIButton filterBtn;
    private UnityEngine.UI.Image filterBg;
    private ENTERPRISE.UI.UITextMeshProUGUI txtFilterBtn;
    private ENTERPRISE.UI.UIButton sortBtn;
    private ENTERPRISE.UI.UITextMeshProUGUI txtSortBtn;
    private UniRx.Subject<bool> onClickSubject;
    public System.IObservable<bool> OnClick { get; set; }
    private void Start();
    public void Setup(bool filtering, string sortTargetLabel);
    public void SetFilter(bool filtering);
    public void SetSort(string sortTargetLabel);
    public void SetSortButtonEnable(bool isEneble);
    public void SetFilterButtonEnable(bool isEneble);
    private void <Setup>b__9_0();
    private void <Setup>b__9_1();
}

// Namespace: PRISM.Definitions
public class ChallengeTourSeConst
{
    public static string SheetName;
    public static PRISM.Definitions.SoundKey GetStar;
    public static PRISM.Definitions.SoundKey Kirari;
}

// Namespace: PRISM.Interactions
public class ProduceAutoSettingPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IProduceAutoSettingPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClick;
    private PRISM.Interactions.ToggleGroupView ScheduleSelectionTypeToggle;
    private PRISM.Interactions.ToggleGroupView SystemTypeToggle;
    private PRISM.Interactions.ToggleGroupView RecoveryTimingTypeToggle;
    private PRISM.Interactions.ToggleGroupView RankUpBalanceTypeToggle;
    private PRISM.Interactions.ToggleGroupView CardDeleteTypeToggle;
    private PRISM.Interactions.ToggleGroupView CardCostBalanceTypeToggle;
    private PRISM.Interactions.ToggleGroupView DeckPolicyTypeToggle;
    private UnityEngine.Transform selectSubSeasonToggleContainer;
    private PRISM.Interactions.ButtonView selectSubSeasonTogglePrefab;
    private PRISM.Interactions.Produce.ProduceAutoSettingSubSeasonIdolToggleGroup selectSubSeasonIdolToggle;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void SetupScheduleSelectionType(int firstSelectIndex, System.Action<int> onChangeToggle);
    public void SetupSystemType(int firstSelectIndex, System.Action<int> onChangeToggle);
    public void SetupRecoveryTimingType(int firstSelectIndex, System.Action<int> onChangeToggle);
    public void SetupRankUpBalanceType(int firstSelectIndex, System.Action<int> onChangeToggle);
    public void SetupCardDeleteType(int firstSelectIndex, System.Action<int> onChangeToggle);
    public void SetupCardCostBalanceType(int firstSelectIndex, System.Action<int> onChangeToggle);
    public void SetupDeckPolicyType(int firstSelectIndex, System.Action<int> onChangeToggle);
    public void SetupSelectSubSeasonToggle(System.Collections.Generic.IReadOnlyList<string> subSeasonNameList, int firstSelectIndex, System.Action<int> onChangeToggle);
    public void SetupSelectIdolToggle(int mstUnitId, int firstSelectIndex, System.Action<int> onChangeToggle);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__13_0();
    private void <CreateFrameParameter>b__13_1();
    private PRISM.Interactions.ButtonView <SetupSelectSubSeasonToggle>b__21_0(string subSeasonName);
}

// Namespace: PRISM.Interactions
public class ProduceAutoOneSeasonScheduleContext : PRISM.EnhancedListViewContext
{
    public System.Func<PRISM.Adapters.ProduceAutoOneSeasonViewModel, int, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask> OnPostExecScheduleAsync;
}

// Namespace: PRISM.Interactions
public class ProduceAutoOneSeasonScheduleListCell : PRISM.EnhancedListViewCell<PRISM.Adapters.ProduceAutoOneSeasonViewModel, PRISM.Interactions.ProduceAutoOneSeasonScheduleContext>
{
    private ENTERPRISE.UI.UITextMeshProUGUI seasonText;
    private PRISM.Interactions.ProduceAutoOneWeekScheduleContent[] scheduleContents;
    public void UpdateContent(PRISM.Adapters.ProduceAutoOneSeasonViewModel data);
    private Cysharp.Threading.Tasks.UniTask _onPostExecScheduleAsync(PRISM.Adapters.ProduceAutoOneSeasonViewModel data, int weekIndex, System.Threading.CancellationToken cancellationToken);
    protected void _initialize();
}

// Namespace: PRISM.Interactions
public class ProduceAutoOneSeasonScheduleListView : PRISM.EnhancedListView<PRISM.Adapters.ProduceAutoOneSeasonViewModel, PRISM.Interactions.ProduceAutoOneSeasonScheduleContext>
{
    private float jumpTime;
    public float GetCellViewSize(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex);
    public Cysharp.Threading.Tasks.UniTask UpdateContentsWithJumpAsync(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.ProduceAutoOneSeasonViewModel> data, int jumpIndex, System.Threading.CancellationToken cancellationToken);
    public void UpdateContentsWithJumpImmediate(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.ProduceAutoOneSeasonViewModel> data, int jumpIndex);
    public Cysharp.Threading.Tasks.UniTask OnPostExecScheduleAsync(PRISM.Adapters.ProduceAutoOneSeasonViewModel data, int weekIndex, System.Threading.CancellationToken cancellationToken);
    public void Terminate();
    private Cysharp.Threading.Tasks.UniTask _updateContentsWithJumpAsync(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.ProduceAutoOneSeasonViewModel> data, int jumpIndex, float jumpTime, System.Threading.CancellationToken cancellationToken);

    private class <>c__DisplayClass6_0
    {
        public bool isJumped;
        private void <_updateContentsWithJumpAsync>b__0();
        private bool <_updateContentsWithJumpAsync>b__1();
    }
}

// Namespace: PRISM.Interactions
public class ProduceAutoOneWeekScheduleContent : UnityEngine.MonoBehaviour
{
    private UnityEngine.GameObject scheduleObject;
    private UnityEngine.UI.RawImage scheduleImage;
    private UnityEngine.GameObject scheduleLevelObject;
    private UnityEngine.GameObject scheduleBonusLevelObject;
    private UnityEngine.UI.Image scheduleLevelImage;
    private ENTERPRISE.UI.UITextMeshProUGUI scheduleLevelText;
    private ENTERPRISE.UI.UITextMeshProUGUI scheduleNameText;
    private UnityEngine.GameObject supportBonusImageObject;
    private UnityEngine.GameObject appearanceImageObject;
    private UnityEngine.GameObject recommendImageObject;
    private UnityEngine.GameObject supportCharacterAreaObject;
    private System.Collections.Generic.List<PRISM.SupportCharacterSDIconContent> supportCharacterSDIconContentList;
    private UnityEngine.UI.Image frameBlur;
    private UnityEngine.UI.Image bgGradation;
    private PRISM.Interactions.Produce.ProduceScheduleLevelColorData scheduleLevelColorData;
    private UnityEngine.GameObject failureUI;
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Adapters.ProduceAutoOneWeekScheduleViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask OnPostExecScheduleAsync(PRISM.Adapters.ProduceAutoOneWeekScheduleViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken cancellationToken);
    private bool _isShowFailure(PRISM.Adapters.ProduceAutoOneWeekScheduleViewModel viewModel);
    private Cysharp.Threading.Tasks.UniTask _levelDisplayAsync(PRISM.Adapters.ProduceAutoOneWeekScheduleViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken cancellationToken);
    private void _setBlur(PRISM.Adapters.ProduceAutoOneWeekScheduleViewModel viewModel);
    private Cysharp.Threading.Tasks.UniTask _scheduleDisplayAsync(PRISM.Adapters.ProduceAutoOneWeekScheduleViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken cancellationToken);
    private bool _isLesson(ScheduleType scheduleType);

    private struct <OnPostExecScheduleAsync>d__17 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ProduceAutoOneWeekScheduleContent <>4__this;
        public PRISM.Adapters.ProduceAutoOneWeekScheduleViewModel viewModel;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken cancellationToken;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <SetupAsync>d__16 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ProduceAutoOneWeekScheduleContent <>4__this;
        public PRISM.Adapters.ProduceAutoOneWeekScheduleViewModel viewModel;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken cancellationToken;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_levelDisplayAsync>d__19 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ProduceAutoOneWeekScheduleContent <>4__this;
        public PRISM.Adapters.ProduceAutoOneWeekScheduleViewModel viewModel;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken cancellationToken;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_scheduleDisplayAsync>d__21 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ProduceAutoOneWeekScheduleContent <>4__this;
        public PRISM.Adapters.ProduceAutoOneWeekScheduleViewModel viewModel;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken cancellationToken;
        private int <i>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class ProduceAutoResultPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IProduceAutoResultPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.SDCharacterDisplayModelView characterDisplay;
    private UnityEngine.UI.RawImage unitIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI episodeTitleText;
    private ENTERPRISE.UI.UITextMeshProUGUI difficultyText;
    private UnityEngine.UI.Graphic difficultyBg;
    private PRISM.UIGrayOutController episodeGraphicController;
    private PRISM.UIGrayOutController leftButtonGrayOutController;
    private PRISM.UIGrayOutController rightButtonGrayOutController;
    private ENTERPRISE.UI.ToggleButton autoToggleButton;
    private ENTERPRISE.UI.UIButton produceLogButton;
    private ENTERPRISE.UI.UIButton produceOptionButton;
    private UnityEngine.CanvasGroup leftCanvasGroup;
    private UnityEngine.CanvasGroup rightCanvasGroup;
    private PRISM.Interactions.ProduceAutoOneSeasonScheduleListView oneSeasonScheduleListView;
    private UniRx.Subject<UniRx.Unit> onClickNextButtonSubject;
    private UniRx.Subject<bool> onClickAutoToggleSubject;
    private UniRx.Subject<UniRx.Unit> onClickProduceLogButtonSubject;
    private UniRx.Subject<UniRx.Unit> onClickProduceOptionButtonSubject;
    private float minNextScheduleWaitTime;
    private float lastScheduleExecTime;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private bool inputEnable;
    private PRISM.Interactions.IPopupFrameView parent;
    public System.IObservable<bool> OnClickAutoToggle { get; set; }
    public System.IObservable<UniRx.Unit> OnClickProduceLogButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickProduceOptionButton { get; set; }
    public System.Threading.CancellationToken CancellationTokenOnTerminate { get; set; }
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Adapters.ProduceAutoResultPopupViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Func<Cysharp.Threading.Tasks.UniTask> onPreCloseFunc, System.Threading.CancellationToken cancellationToken);
    public void SetInputEnable(bool isEnable, bool isAutoToggleEnable);
    public Cysharp.Threading.Tasks.UniTask UpdateScheduleViewWithJumpAsync(System.Collections.Generic.IList<PRISM.Adapters.ProduceAutoOneSeasonViewModel> viewModels, System.Threading.CancellationToken cancellationToken);
    public void UpdateContentsWithJumpImmediate(System.Collections.Generic.IList<PRISM.Adapters.ProduceAutoOneSeasonViewModel> viewModels);
    public Cysharp.Threading.Tasks.UniTask OnPostExecScheduleAsync(PRISM.Adapters.ProduceAutoOneSeasonViewModel viewModel, int weekIndex, System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    private void _setDifficultyIcon(ProduceDifficultyType difficultyType);
    private Cysharp.Threading.Tasks.UniTask _setupScriptAsync(PRISM.UnitIdol[] unitIdols, System.Threading.CancellationToken cancellationToken);
    private void <CreateFrameParameter>b__32_0();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<bool> <>9__47_0;
        private bool <_setupScriptAsync>b__47_0();
    }

    private class <>c__DisplayClass33_0
    {
        public PRISM.Interactions.ProduceAutoResultPopupView <>4__this;
        public System.Func<Cysharp.Threading.Tasks.UniTask> onPreCloseFunc;
        private void <SetupAsync>b__0();
        private void <SetupAsync>b__1();
        private Cysharp.Threading.Tasks.UniTaskVoid <SetupAsync>b__2(UniRx.Unit _);

        private struct <<SetupAsync>b__2>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
        {
            public int <>1__state;
            public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
            public <>c__DisplayClass33_0 <>4__this;
            private Awaiter <>u__1;
            private void MoveNext();
            private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }

    private struct <OnPostExecScheduleAsync>d__37 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ProduceAutoResultPopupView <>4__this;
        public System.Threading.CancellationToken cancellationToken;
        public PRISM.Adapters.ProduceAutoOneSeasonViewModel viewModel;
        public int weekIndex;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <SetupAsync>d__33 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ProduceAutoResultPopupView <>4__this;
        public System.Func<Cysharp.Threading.Tasks.UniTask> onPreCloseFunc;
        public PRISM.Adapters.ProduceAutoResultPopupViewModel viewModel;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken cancellationToken;
        private <>c__DisplayClass33_0 <>8__1;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <TerminateAsync>d__38 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ProduceAutoResultPopupView <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_setupScriptAsync>d__47 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ProduceAutoResultPopupView <>4__this;
        public PRISM.UnitIdol[] unitIdols;
        public System.Threading.CancellationToken cancellationToken;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class ProduceAutoModeConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.ProduceAutoModeArgument>, PRISM.IProduceAutoModeConnector
{
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
    protected PRISM.Adapters.ProduceAutoModeArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
}

// Namespace: PRISM.Interactions
public class ProduceAutoModeView : UnityEngine.MonoBehaviour, PRISM.Adapters.IProduceAutoModeView
{
    public Cysharp.Threading.Tasks.UniTask SetupAsync(int chapter, System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask<PRISM.Produce.AiPatternDataScriptableObject> LoadAIPatternDataObjectAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken cancellationToken);
}

// Namespace: PRISM.Interactions
public class ChallengeTourResultConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.ChallengeTourResultArgument>, PRISM.IChallengeTourResultConnector
{
    protected PRISM.Adapters.ChallengeTourResultArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();

    private struct <_playBgmAsync>d__1 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        private Awaiter<CriWare.CriAtomExPlayback> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class ChallengeTourTopConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.ChallengeTourTopArgument>, PRISM.IChallengeTourTopConnector
{
    protected PRISM.Adapters.ChallengeTourTopArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();

    private struct <_playBgmAsync>d__1 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        private Awaiter<CriWare.CriAtomExPlayback> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class ProduceEpisodeSelectConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.ProduceEpisodeSelectArgument>, PRISM.Adapters.IProduceEpisodeSelectConnector
{
    protected PRISM.Adapters.ProduceEpisodeSelectArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
}

// Namespace: PRISM.Interactions
public class ProduceEpisodeSelectView : UnityEngine.MonoBehaviour, PRISM.Adapters.IProduceEpisodeSelectView
{
    private PRISM.Produce.ProducePreparationEpisodeSelectUnitBackgroundView unitBackgroundView;
    private PRISM.Produce.ProducePreparationEpisodeSelectUnitListView unitListView;
    private PRISM.Produce.ProducePreparationEpisodeSelectListView episodeListView;
    private PRISM.Produce.ProducePreparationEpisodeSelectDetailView detailView;
    private PRISM.Interactions.ButtonView confirmHowToPlayButton;
    private PRISM.Interactions.ButtonView featuresButton;
    private PRISM.Interactions.ButtonView tutorialButton;
    private PRISM.Interactions.ButtonView shinyCompetitionProduceBonusButton;
    protected string howToConfigRef;
    private string howToPlayManualKey;
    protected string difficultyReleasedConfigRef;
    private PRISM.ITutorialSequence tutorialInfoSequence;
    private PRISM.Adapters.ProduceEpisodeSelectViewModel model;
    private bool isInitilizing;
    private UniRx.Subject<UniRx.Unit> jumpIdolSelectViewSubject;
    private PRISM.ResourceManagement.IResourceLoader loader;
    public System.IObservable<UniRx.Unit> OnClickConfirmHowToPlayButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickFeaturesButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickTutorialButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickProduceBonusButton { get; set; }
    public System.IObservable<UniRx.Unit> OnJumpIdolSelectView { get; set; }
    public string HowToConfigRefKey { get; set; }
    public string HowToPlayManualKey { get; set; }
    public string difficultyReleasedConfigRefKey { get; set; }
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Adapters.ProduceEpisodeSelectViewModel model, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask<bool> ShowInfoTutorialPopupAsync();
    public Cysharp.Threading.Tasks.UniTask StartInfoTutorialAsync();
    public void SetupUnitList();
    public void SetBackGround(int id);
    public void SetupEpisodeList();
    public Cysharp.Threading.Tasks.UniTask SetupEpisodeDetailAsync(System.Threading.CancellationToken ct);
    public void SetActiveProduceBonusButton(bool isShowProduceBonusButton);
    private void _resetEpisodeList();
    private void _setupArrowButtonEnable(int index);
    private Cysharp.Threading.Tasks.UniTask _updateDetailViewAsync(System.Threading.CancellationToken ct);
    private void <SetupUnitList>b__35_1(int index);
    private Cysharp.Threading.Tasks.UniTaskVoid <SetupEpisodeList>b__37_0(int index);
    private void <SetupEpisodeList>b__37_1(int index);
    private void <SetupEpisodeList>b__37_4();
    private void <SetupEpisodeList>b__37_2();
    private void <SetupEpisodeList>b__37_3();
    private void <SetupEpisodeDetailAsync>b__38_0();
    private void <SetupEpisodeDetailAsync>b__38_1();
    private void <SetupEpisodeDetailAsync>b__38_2();
    private void <SetupEpisodeDetailAsync>b__38_5();
    private void <SetupEpisodeDetailAsync>b__38_3();
    private void <SetupEpisodeDetailAsync>b__38_6();
    private void <SetupEpisodeDetailAsync>b__38_4();

    private struct <<SetupEpisodeList>b__37_0>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
        public PRISM.Interactions.ProduceEpisodeSelectView <>4__this;
        public int index;
        private System.IDisposable <>7__wrap1;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Produce.ProducePreparationEpisodeSelectUnitEpisodeModel, PRISM.Produce.ProducePreparationEpisodeSelectUnitListItemData> <>9__35_0;
        private PRISM.Produce.ProducePreparationEpisodeSelectUnitListItemData <SetupUnitList>b__35_0(PRISM.Produce.ProducePreparationEpisodeSelectUnitEpisodeModel unitEpisodeModel);
    }

    private class <>c__DisplayClass38_0
    {
        public int index;
        public PRISM.Interactions.ProduceEpisodeSelectView <>4__this;
        private void <SetupEpisodeDetailAsync>b__7();
    }

    private struct <SetupAsync>d__32 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ProduceEpisodeSelectView <>4__this;
        public PRISM.Adapters.ProduceEpisodeSelectViewModel model;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <StartInfoTutorialAsync>d__34 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ProduceEpisodeSelectView <>4__this;
        private PRISM.ITutorialSequenceContext <tutorialContext>5__2;
        private Awaiter<PRISM.ITutorialSequenceContext> <>u__1;
        private Awaiter <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class ProduceFriendSupportListView : PRISM.CommonListView<PRISM.Interactions.ProduceFriendSupportListViewCell, PRISM.Adapters.IProduceFriendSupportViewModel, PRISM.Interactions.ProduceFriendSupportListViewContext>
{
    private UniRx.Subject<int> onLongPressCell;
    public System.IObservable<int> OnLongPressCell { get; set; }
    public System.IObservable<int> OnShowSCharaDetailPopup { get; set; }
    protected void Initialize();
    public void Terminate();
    private void <Initialize>b__5_0(int index);
}

// Namespace: PRISM.Interactions
public class ProduceFriendSupportListViewCell : PRISM.CommonListViewCell<PRISM.Adapters.IProduceFriendSupportViewModel, PRISM.Interactions.ProduceFriendSupportListViewContext>
{
    private PRISM.UI.SCharaIconView sCharaIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI friendNameText;
    private ENTERPRISE.UI.UITextMeshProUGUI loginTimeText;
    private ENTERPRISE.UI.UITextMeshProUGUI nickNameText;
    private ENTERPRISE.UI.UITextMeshProUGUI charaNameText;
    private UnityEngine.GameObject[] followSignObjects;
    private UnityEngine.GameObject[] skillSlots;
    private UnityEngine.GameObject[] skillSlotLocks;
    private ENTERPRISE.UI.UITextMeshProUGUI goodScheduleTypeText;
    private System.IDisposable disposable;
    public void Initialize();
    public void UpdateContent(PRISM.Adapters.IProduceFriendSupportViewModel data);
    private Cysharp.Threading.Tasks.UniTask _setupSCharaIconAsync(PRISM.Module.Networking.ISupportCharacterStatus supportCharacter, System.Threading.CancellationToken ct);
    private void _updateFollowSign(FriendState friendState);
    private void <Initialize>b__10_0(UnityEngine.EventSystems.PointerEventData _);
    private void <Initialize>b__10_1(System.ValueTuple<int, UnityEngine.GameObject> tuple);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<string, string> <>9__11_0;
        private string <UpdateContent>b__11_0(string kw);
    }
}

// Namespace: PRISM.Interactions
public class ProduceFriendSupportListViewContext : PRISM.CommonListViewContext
{
    private UniRx.Subject<int> onShowSCharaDetailPopup;
    public System.IObservable<int> OnShowSCharaDetailPopupObservable { get; set; }
    public System.IObserver<int> OnShowSCharaDetailPopupObserver { get; set; }
    public void Terminate();
}

// Namespace: PRISM.Interactions
public class ProduceFriendSupportSelectConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.ProduceFriendSupportSelectArgument>, PRISM.IProduceFriendSupportSelectConnector
{
    protected PRISM.Adapters.ProduceFriendSupportSelectArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
}

// Namespace: PRISM.Interactions
public class ProduceFriendSupportSelectView : UnityEngine.MonoBehaviour, PRISM.Adapters.IProduceFriendSupportSelectView
{
    private ENTERPRISE.UI.UIButton reloadButton;
    private UnityEngine.Animator reloadButtonAnimator;
    private PRISM.Interactions.ProduceFriendSupportListView listView;
    private FancyScrollView.Scroller scroller;
    private UniRx.Subject<int> onClickFriendSupportCell;
    private UniRx.Subject<UniRx.Unit> onClickReloadButton;
    public System.IObservable<int> OnClickFriendSupportCell { get; set; }
    public System.IObservable<int> OnLongPressFriendSupportCell { get; set; }
    public System.IObservable<int> OnShowSCharaDetailPopup { get; set; }
    public System.IObservable<UniRx.Unit> OnClickReloadButton { get; set; }
    public void Setup(System.Collections.Generic.IList<PRISM.Adapters.IProduceFriendSupportViewModel> friendSupports, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void ReloadFriendSupportList(System.Collections.Generic.IList<PRISM.Adapters.IProduceFriendSupportViewModel> friendSupports);
    public void Terminate();
    private void _setReloadButtonState(bool isReloading);
    private void <Setup>b__14_0(int index);
    private void <Setup>b__14_1(UniRx.Unit _);
}

// Namespace: PRISM.Interactions
public class ProduceEnemySkillDetailPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IProduceEnemySkillDetailPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private UniRx.Subject<System.Collections.Generic.List<int>> onClickKeyWordSubject;
    private PRISM.Produce.TrainerSkillIconView icon;
    private PRISM.VoDaViMeMultiView voDaViMeView;
    private ENTERPRISE.UI.UITextMeshProUGUI skillNameText;
    private ENTERPRISE.UI.UITextMeshProUGUI descriptionText;
    private PRISM.Interactions.TMPKeyWordTouchDetector tmpKeyWordTouchDetector;
    private PRISM.Interactions.PopupFrameParameter frameParameter;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public System.IObservable<System.Collections.Generic.List<int>> OnClickKeyWord { get; set; }
    public System.Threading.CancellationToken CancellationTokenOnTerminate { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(InGameType inGameType, PRISM.Adapters.ProduceEnemySkillDetailPopupViewModel viewModel, System.Threading.CancellationToken cancellationToken);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private int _getTitleType(InGameType inGameType);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    private void <InitializeAsync>b__14_1();
    private void <InitializeAsync>b__14_2();
    private void <InitializeAsync>b__14_0(System.ValueTuple<int, TMPro.TMP_TextInfo> info);

    private class <>O
    {
        public static System.Func<string, int> <0>__Parse;
    }
}

// Namespace: PRISM.Interactions
public class ChallengeTourInGamePausePopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IChallengeTourInGamePausePopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Produce.EnemySkillContentListView enemySkillContentListView;
    private PRISM.Interactions.Produce.ChallengeTourInGameMissionListView challengeTourStageMissionListView;
    private ENTERPRISE.UI.UIButton retryButton;
    private ENTERPRISE.UI.UIButton giveUpButton;
    private ENTERPRISE.UI.UIButton produceOptionButton;
    private UniRx.Subject<System.ValueTuple<int, PRISM.Produce.IngameSkillModel>> onClickEnemySkillIconSubject;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public System.IObservable<System.ValueTuple<int, PRISM.Produce.IngameSkillModel>> OnClickEnemySkillIcon { get; set; }
    public System.IObservable<UniRx.Unit> OnClickRetryButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickGiveUpButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickProduceButton { get; set; }
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Adapters.ChallengeTourInGamePausePopupViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken cancellationToken);
    public void Close();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__17_0();
    private void <CreateFrameParameter>b__17_1();

    private class <>c
    {
        public static <>c <>9;
        public static System.Action<int, System.ValueTuple<UniRx.Subject<System.ValueTuple<int, PRISM.Produce.IngameSkillModel>>, PRISM.Adapters.ChallengeTourInGamePausePopupViewModel>> <>9__18_0;
        private void <SetupAsync>b__18_0(int index, System.ValueTuple<UniRx.Subject<System.ValueTuple<int, PRISM.Produce.IngameSkillModel>>, PRISM.Adapters.ChallengeTourInGamePausePopupViewModel> state);
    }

    private struct <SetupAsync>d__18 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ChallengeTourInGamePausePopupView <>4__this;
        public PRISM.Adapters.ChallengeTourInGamePausePopupViewModel viewModel;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken cancellationToken;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class ProduceInGamePausePopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IProduceInGamePausePopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private UniRx.Subject<System.ValueTuple<int, PRISM.Produce.IngameSkillModel>> onClickEnemySkillIconSubject;
    private UniRx.Subject<UniRx.Unit> onClickRetryButtonSubject;
    private UniRx.Subject<UniRx.Unit> onClickGiveUpButtonSubject;
    private UniRx.Subject<UniRx.Unit> onClickProduceOptionButtonSubject;
    private PRISM.Produce.EnemySkillContentListView enemySkillContentListView;
    private ENTERPRISE.UI.UIButton retryButton;
    private ENTERPRISE.UI.UIButton giveUpButton;
    private PRISM.Produce.ChallengeMissionContent challengeMissionContent;
    private UnityEngine.GameObject notExistChallengeMissionUI;
    private ENTERPRISE.UI.UIButton produceOptionButton;
    private PRISM.Adapters.ProduceInGamePausePopupViewModel viewModel;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public System.IObservable<System.ValueTuple<int, PRISM.Produce.IngameSkillModel>> OnClickEnemySkillIcon { get; set; }
    public System.IObservable<UniRx.Unit> OnClickRetryButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickGiveUpButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickProduceOptionButton { get; set; }
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public System.Threading.CancellationToken CancellationTokenOnTerminate { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Adapters.ProduceInGamePausePopupViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Func<Cysharp.Threading.Tasks.UniTask> onPreCloseByRetryButtonFunc, System.Func<Cysharp.Threading.Tasks.UniTask> onPreCloseByGiveUpButtonFunc, System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    private void <CreateFrameParameter>b__24_0();
    private void <CreateFrameParameter>b__24_1();

    private class <>c
    {
        public static <>c <>9;
        public static System.Action<int, System.ValueTuple<UniRx.Subject<System.ValueTuple<int, PRISM.Produce.IngameSkillModel>>, PRISM.Adapters.ProduceInGamePausePopupViewModel>> <>9__25_0;
        public static System.Func<UniRx.Unit, System.ValueTuple<System.Func<Cysharp.Threading.Tasks.UniTask>, Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit>>, Cysharp.Threading.Tasks.UniTaskVoid> <>9__25_1;
        public static System.Func<UniRx.Unit, System.ValueTuple<System.Func<Cysharp.Threading.Tasks.UniTask>, Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit>>, Cysharp.Threading.Tasks.UniTaskVoid> <>9__25_2;
        public static System.Action<UniRx.Unit, UniRx.Subject<UniRx.Unit>> <>9__25_3;
        private void <SetupAsync>b__25_0(int index, System.ValueTuple<UniRx.Subject<System.ValueTuple<int, PRISM.Produce.IngameSkillModel>>, PRISM.Adapters.ProduceInGamePausePopupViewModel> state);
        private Cysharp.Threading.Tasks.UniTaskVoid <SetupAsync>b__25_1(UniRx.Unit _, System.ValueTuple<System.Func<Cysharp.Threading.Tasks.UniTask>, Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit>> state);
        private Cysharp.Threading.Tasks.UniTaskVoid <SetupAsync>b__25_2(UniRx.Unit _, System.ValueTuple<System.Func<Cysharp.Threading.Tasks.UniTask>, Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit>> state);
        private void <SetupAsync>b__25_3(UniRx.Unit _, UniRx.Subject<UniRx.Unit> state);

        private struct <<SetupAsync>b__25_1>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
        {
            public int <>1__state;
            public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
            public System.ValueTuple<System.Func<Cysharp.Threading.Tasks.UniTask>, Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit>> state;
            private Awaiter <>u__1;
            private void MoveNext();
            private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }

        private struct <<SetupAsync>b__25_2>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
        {
            public int <>1__state;
            public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
            public System.ValueTuple<System.Func<Cysharp.Threading.Tasks.UniTask>, Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit>> state;
            private Awaiter <>u__1;
            private void MoveNext();
            private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }

    private struct <SetupAsync>d__25 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ProduceInGamePausePopupView <>4__this;
        public PRISM.Adapters.ProduceInGamePausePopupViewModel viewModel;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken cancellationToken;
        public System.Func<Cysharp.Threading.Tasks.UniTask> onPreCloseByRetryButtonFunc;
        public System.Func<Cysharp.Threading.Tasks.UniTask> onPreCloseByGiveUpButtonFunc;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class ProduceResultShinyCompetitionEventPointProgressPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IProduceResultShinyCompetitionEventPointProgressPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.Produce.ProduceResultShinyCompetitionRewardScrollView rewardScrollView;
    private PRISM.Interactions.ButtonView skipButton;
    private float scrollDurationPerCell;
    private int delayMilisecondsOnEnter;
    private int delayMilisecondsOnStartScroll;
    private int delayMilisecondsOnOpenRewardPU;
    private PRISM.Adapters.ProduceResultShinyCompetitionEventPointProgressPopupViewModel viewModel;
    private bool isAnimationFinished;
    private PRISM.Definitions.SkippableCancellationTokenSource skippableSource;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    public void Assign(PRISM.Adapters.ProduceResultShinyCompetitionEventPointProgressPopupViewModel vm, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private System.Collections.Generic.IReadOnlyList<PRISM.Interactions.Produce.ProduceResultShinyCompetitionRewardCellData> _getStampAnimationCellDatas();
    private void _skipAnimation();
    private void <CreateFrameParameter>b__12_0();
    private void <CreateFrameParameter>b__12_1();
    private void <Assign>b__21_0(UniRx.Unit _);

    private struct <ShowAsync>d__17 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ProduceResultShinyCompetitionEventPointProgressPopupView <>4__this;
        public System.Threading.CancellationToken ct;
        private System.Threading.CancellationToken <skippableToken>5__2;
        private System.Threading.CancellationTokenSource <linkedTokenSource>5__3;
        private System.Threading.CancellationToken <linkedToken>5__4;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class ProduceResultShinyCompetitionProgressPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IProduceResultShinyCompetitionProgressPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.Produce.ProduceResultShinyCompetitionTotalPowerListScrollView totalPowerScrollView;
    private PRISM.Interactions.Produce.ProduceResultShinyCompetitionProduceBonusListView produceBonusScorollView;
    private ENTERPRISE.UI.UITextMeshProUGUI boostText;
    private PRISM.Interactions.CountUpUIAnimation getEventPointAnimation;
    private PRISM.Interactions.CountUpUIAnimation totalEventPointAnimation;
    private PRISM.UIAnimation uiAnimation;
    private PRISM.Interactions.ButtonView skipButton;
    private PRISM.Adapters.ProduceResultShinyCompetitionProgressPopupViewModel viewModel;
    private bool isAnimationFinished;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Definitions.SkippableCancellationTokenSource skippableSource;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    public void Assign(PRISM.Adapters.ProduceResultShinyCompetitionProgressPopupViewModel vm, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void SkipAnimation();
    private void <CreateFrameParameter>b__13_0();
    private void <CreateFrameParameter>b__13_1();
    private void <Assign>b__22_0(UniRx.Unit _);

    private struct <ShowAsync>d__18 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ProduceResultShinyCompetitionProgressPopupView <>4__this;
        public System.Threading.CancellationToken ct;
        private System.Threading.CancellationToken <skippableToken>5__2;
        private System.Threading.CancellationTokenSource <linkedTokenSource>5__3;
        private Cysharp.Threading.Tasks.UniTask <uiAnimationTask>5__4;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class ProduceResultTransferRewardPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IProduceResultTransferRewardPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private UnityEngine.Transform rewardParent;
    private PRISM.Interactions.RewardItemIcon itemIconPrefab;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void Setup(System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IRewardProductStatus> rewardList, PRISM.ResourceManagement.IResourceLoader loader);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__5_0();
    private void <CreateFrameParameter>b__5_1();
}

// Namespace: PRISM.Interactions
public class ResultIdolBaseRewardContentView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.IdolBaseRewardIdolView[] idolViews;
    private UnityEngine.Animator contentViewAnimator;
    private UnityEngine.CanvasGroup canvasGroup;
    private float canvasFadeDuration;
    private ENTERPRISE.UI.UIButton nextButton;
    private ENTERPRISE.UI.UIButton endButton;
    private ENTERPRISE.UI.UIButton memorialLiveButton;
    public System.IObservable<UniRx.Unit> OnClickNextButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickEndButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickMemorialLiveButton { get; set; }
    public Cysharp.Threading.Tasks.UniTask PrepareAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Collections.Generic.IEnumerable<int> characterIds, System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask AnimateAsync(System.Collections.Generic.IList<PRISM.Adapters.IdolBaseRewardIdolViewModel> viewModels, float duration, System.Threading.CancellationToken cancellationToken);
    public void SkipAnimation(System.Collections.Generic.IList<PRISM.Adapters.IdolBaseRewardIdolViewModel> viewModels);
    public void HideNextButton();
    public void HideEndButton();
    public void HideMemorialLiveButton();

    private class <>c__DisplayClass13_0
    {
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken cancellationToken;
        private Cysharp.Threading.Tasks.UniTask <PrepareAsync>b__0(PRISM.Interactions.IdolBaseRewardIdolView view, int id);
    }

    private class <>c__DisplayClass14_0
    {
        public System.Collections.Generic.IList<PRISM.Adapters.IdolBaseRewardIdolViewModel> viewModels;
        public float duration;
        public System.Threading.CancellationToken cancellationToken;
        private Cysharp.Threading.Tasks.UniTask <AnimateAsync>b__0(PRISM.Interactions.IdolBaseRewardIdolView e, int i);
    }
}

// Namespace: PRISM.Interactions
public class ProduceMvConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.ProduceMvArgument>, PRISM.Adapters.IProduceMvConnector
{
    protected PRISM.Adapters.ProduceMvArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
}

// Namespace: PRISM.Interactions
public class ProduceMvView : UnityEngine.MonoBehaviour, PRISM.Adapters.IProduceMvView
{
    private string mvSequencerScene;
    private UnityEngine.UI.RawImage image;
    private PRISM.Interactions.ButtonView skipButton;
    private int imageSwappingMillisec;
    private PRISM.SceneLoader sceneLoader;
    private PRISM.MvSequencer mvSequencer;
    private UniRx.Subject<UniRx.Unit> onEndMvSubject;
    private System.IDisposable endMvDisposable;
    public System.IObservable<UniRx.Unit> OnClickSkip { get; set; }
    public System.IObservable<UniRx.Unit> OnEndMv { get; set; }
    public bool IsEndMvSequencer { get; set; }
    public void Setup();
    public Cysharp.Threading.Tasks.UniTask SetupSceneLoaderAsync();
    public Cysharp.Threading.Tasks.UniTask SetupMvSequencerAsync(bool isArEffect, System.Threading.CancellationToken token);
    public Cysharp.Threading.Tasks.UniTask ShowStageImagesAsync(UnityEngine.Texture[] images, System.Threading.CancellationToken token);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <Setup>b__14_0(UniRx.Unit _);
    private bool <SetupMvSequencerAsync>b__16_0();

    private struct <SetupMvSequencerAsync>d__16 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ProduceMvView <>4__this;
        public System.Threading.CancellationToken token;
        public bool isArEffect;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <SetupSceneLoaderAsync>d__15 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ProduceMvView <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <ShowStageImagesAsync>d__17 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public UnityEngine.Texture[] images;
        public PRISM.Interactions.ProduceMvView <>4__this;
        public System.Threading.CancellationToken token;
        private int <current>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <TerminateAsync>d__18 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ProduceMvView <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class ShinyCompetitionBonusOverlayView : PRISM.Interactions.OverlayViewWithCloseButton, PRISM.Adapters.IShinyCompetitionBonusOverlayView, PRISM.Adapters.IClosableOverlayView<UniRx.Unit>, PRISM.Adapters.IOverlayView, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.ToggleGroupView verticalTabGroupView;
    private PRISM.Interactions.Produce.ShinyCompetitionPIdolBonusListView pIdolBonusListView;
    private PRISM.Interactions.Produce.ShinyCompetitionProduceBonusListView shinyCompetitionProduceBonusListView;
    private UnityEngine.GameObject totalProduceBonusObject;
    private ENTERPRISE.UI.UITextMeshProUGUI totalProduceBonusValueText;
    public Cysharp.Threading.Tasks.UniTask SetupAsync(System.Collections.Generic.IEnumerable<PRISM.Adapters.ShinyCompetitionPIdolBonusListViewModel> pIdolBonusList, System.Collections.Generic.IEnumerable<PRISM.Adapters.ShinyCompetitionProduceBonusListViewModel> produceBonusList, bool isShowTotalProduceBonus, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Adapters.ShinyCompetitionProduceBonusListViewModel, bool> <>9__5_0;
        public static System.Func<PRISM.Adapters.ShinyCompetitionProduceBonusListViewModel, int> <>9__5_1;
        private bool <SetupAsync>b__5_0(PRISM.Adapters.ShinyCompetitionProduceBonusListViewModel x);
        private int <SetupAsync>b__5_1(PRISM.Adapters.ShinyCompetitionProduceBonusListViewModel x);
    }

    private struct <SetupAsync>d__5 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ShinyCompetitionBonusOverlayView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Collections.Generic.IEnumerable<PRISM.Adapters.ShinyCompetitionPIdolBonusListViewModel> pIdolBonusList;
        public bool isShowTotalProduceBonus;
        public System.Collections.Generic.IEnumerable<PRISM.Adapters.ShinyCompetitionProduceBonusListViewModel> produceBonusList;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class DeckConfirmPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IDeckConfirmPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private ENTERPRISE.UI.UITextMeshProUGUI produceCardAmount;
    private PRISM.Interactions.ProduceCardGridView produceCardGridView;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void Setup(System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceCardStatus> deckCards, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__5_0();
    private void <CreateFrameParameter>b__5_1();
}

// Namespace: PRISM.Interactions
public class DeleteProduceCardConfirmPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IDeleteProduceCardConfirmPopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClosed;
    private PRISM.Interactions.PopupFrameParameter popupFrameParameter;
    private PRISM.Produce.ProduceCardContent cardPrefab;
    private UnityEngine.Transform cardArea;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceCardStatus> selectCards, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();

    private class <>c__DisplayClass7_0
    {
        public PRISM.Interactions.DeleteProduceCardConfirmPopupView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        private void <InitializeAsync>b__1();
        private void <InitializeAsync>b__2();
        private void <InitializeAsync>b__3();
        private Cysharp.Threading.Tasks.UniTask <InitializeAsync>b__0(PRISM.Module.Networking.IProduceCardStatus e);

        private struct <<InitializeAsync>b__0>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
        {
            public int <>1__state;
            public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
            public <>c__DisplayClass7_0 <>4__this;
            public PRISM.Module.Networking.IProduceCardStatus e;
            private PRISM.Produce.ProduceCardContent <content>5__2;
            private Awaiter <>u__1;
            private void MoveNext();
            private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }

    private struct <InitializeAsync>d__7 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.DeleteProduceCardConfirmPopupView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        public System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceCardStatus> selectCards;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class DeleteProduceCardPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IDeleteProduceCardPopupView, PRISM.Adapters.IClosablePopupFrame<System.Collections.Generic.IReadOnlyList<string>>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<System.Collections.Generic.IReadOnlyList<string>>
{
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<System.Collections.Generic.IReadOnlyList<string>> onClosed;
    private UniRx.Subject<UniRx.Unit> onClickEndButton;
    private UniRx.Subject<UniRx.Unit> onClickClearButton;
    private UniRx.Subject<UniRx.Unit> onClickDeleteButton;
    private PRISM.Interactions.SelectablePCardGridView selectablePCardGridView;
    private ENTERPRISE.UI.UITextMeshProUGUI deleteCountText;
    private ENTERPRISE.UI.UITextMeshProUGUI deckCountWarningText;
    private ENTERPRISE.UI.UITextMeshProUGUI havingCardAmount;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<System.Collections.Generic.IReadOnlyList<string>> OnCloseRequested { get; set; }
    public System.IObservable<int> OnClickCard { get; set; }
    public System.IObservable<UniRx.Unit> OnClickEndButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickClearButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickDeleteButton { get; set; }
    public System.Threading.CancellationToken CancellationTokenOnTerminate { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void Initialize(PRISM.Adapters.IDeleteProduceCardPopupViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void UpdateView(PRISM.Adapters.IDeleteProduceCardPopupViewModel viewModel);
    public void RequestClose(System.Collections.Generic.IReadOnlyList<string> deleteCardIds);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    private void <CreateFrameParameter>b__20_0();
    private void <CreateFrameParameter>b__20_1();
    private void <CreateFrameParameter>b__20_2();
    private void <CreateFrameParameter>b__20_3();
}

// Namespace: PRISM.Interactions
public class ProduceEditInformationPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IProduceEditInformationPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Interactions.ProduceIdolTabView produceIdolTabView;
    private PRISM.Interactions.SupportSkillTabView supportSkillTabView;
    private PRISM.Interactions.SupportEffectTabView supportEffectTabView;
    private PRISM.Interactions.ProduceInfoTabView produceInfoTabView;
    private ENTERPRISE.UI.UITabGroup tabGroup;
    private System.IObservable<int> onShowSelfSCharaDetailPopup;
    private System.IObservable<UniRx.Unit> onShowFriendSCharaDetailPopup;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public System.IObservable<int> OnShowSelfSCharaDetailPopup { get; set; }
    public System.IObservable<UniRx.Unit> OnShowFriendSCharaDetailPopup { get; set; }
    public System.IObservable<UniRx.Unit> OnLongPressInheritanceFesUnitIcon { get; set; }
    public System.Threading.CancellationToken CancellationTokenOnTerminate { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Adapters.ProduceEditInformationPopupViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    private void <CreateFrameParameter>b__18_0();
    private void <CreateFrameParameter>b__18_1();
    private void <SetupAsync>b__19_0(int index, ENTERPRISE.UI.UITabGroup _);

    private struct <SetupAsync>d__19 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ProduceEditInformationPopupView <>4__this;
        public PRISM.Adapters.ProduceEditInformationPopupViewModel viewModel;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class InProduceSupportEffectContentListView : UnityEngine.MonoBehaviour
{
    private UnityEngine.CanvasGroup canvasGroup;
    private PRISM.Interactions.InProduceSupportEffectContentView goContent;
    private UnityEngine.Transform contentParent;
    private System.Collections.Generic.List<PRISM.Interactions.InProduceSupportEffectContentView> contentList;
    public Cysharp.Threading.Tasks.UniTask SetupAsync(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.IInProduceSupportEffectContentViewModel> viewModels, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public void Show(bool isShow);
    private void _deleteAllContent();
}

// Namespace: PRISM.Interactions
public class InProduceSupportEffectContentView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.SupportEffectContentView supportEffectContentView;
    private PRISM.Interactions.InProduceSupportEffectSDCharaIconListView sCharaEditSDCharaIconListView;
    private UnityEngine.GameObject grayOutCover;
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Adapters.IInProduceSupportEffectContentViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
}

// Namespace: PRISM.Interactions
public class InProduceSupportEffectSDCharaIconListView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.InProduceSupportEffectSDCharaIconView iconViewPrefab;
    private UnityEngine.Transform contentArea;
    private System.Collections.Generic.List<PRISM.Interactions.InProduceSupportEffectSDCharaIconView> iconViews;
    public Cysharp.Threading.Tasks.UniTask SetupAsync(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.IInProduceSupportEffectSDCharaIconViewModel> viewModels, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
}

// Namespace: PRISM.Interactions
public class InProduceSupportEffectSDCharaIconView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.SCharaEditSDCharaIconView iconView;
    private PRISM.UIGrayOutController grayOutController;
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Adapters.IInProduceSupportEffectSDCharaIconViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
}

// Namespace: PRISM.Interactions
public class SupportSkillSlotGridView : PRISM.Interactions.GridView<PRISM.Interactions.SupportSkillSlotGridViewCell, PRISM.Adapters.SupportSkillSlotViewModel>
{
    protected void SetupCellTemplate();

    private class CellGroup : DefaultCellGroup<PRISM.Adapters.SupportSkillSlotViewModel, PRISM.Interactions.GridViewContext>
    {
    }
}

// Namespace: PRISM.Interactions
public class SupportSkillSlotGridViewCell : PRISM.Interactions.GridViewCell<PRISM.Adapters.SupportSkillSlotViewModel>
{
    private UnityEngine.GameObject slotObject;
    private ENTERPRISE.UI.UITextMeshProUGUI slotNumberText;
    private UnityEngine.GameObject slotBlankObject;
    private ENTERPRISE.UI.UITextMeshProUGUI slotBlankNumberText;
    private UnityEngine.GameObject skillSlotBaseObject;
    private ENTERPRISE.UI.UITextMeshProUGUI skillSlotEffectNameText;
    private ENTERPRISE.UI.UITextMeshProUGUI skillSlotEffectDescriptionText;
    private UnityEngine.UI.RawImage skillSlotIconImage;
    private UnityEngine.GameObject InheritanceObject;
    private UnityEngine.GameObject skillSlotBaseBlankObject;
    public void UpdateContent(PRISM.Adapters.SupportSkillSlotViewModel itemData);
    private Cysharp.Threading.Tasks.UniTask _loadSkillIconAsync(int skillId, System.Threading.CancellationToken ct);
}

// Namespace: PRISM.Interactions
public class ProduceIdolTabView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.UnitInfoProduceIdolContent produceIdolContentPrefab;
    private UnityEngine.Transform produceIdolContentArea;
    public Cysharp.Threading.Tasks.UniTask SetupAsync(int unitId, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IInProduceIdolStatus> produceIdols, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);

    private class <>c__DisplayClass2_0
    {
        public System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IInProduceIdolStatus> produceIdols;
        public PRISM.Interactions.ProduceIdolTabView <>4__this;
        public int unitId;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        private Cysharp.Threading.Tasks.UniTask <SetupAsync>b__0(int e);
    }

    private class <>c__DisplayClass2_1
    {
        public int e;
        private bool <SetupAsync>b__1(PRISM.Module.Networking.IInProduceIdolStatus idolData);
    }
}

// Namespace: PRISM.Interactions
public class ProduceInfoTabView : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI episodeNameAndDifficultyText;
    private System.Collections.Generic.List<PRISM.Produce.OneSchedulePolicyContent> oneSchedulePolicyContentList;
    private PRISM.UI.FUnitIconView fesUnitIconView;
    private UnityEngine.GameObject inheritanceArea;
    private UniRx.Subject<UniRx.Unit> onLongPressInheritanceFesUnitIcon;
    public System.IObservable<UniRx.Unit> OnLongPressInheritanceFesUnitIcon { get; set; }
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Module.Networking.IProduceBaseInfoStatus produceBaseInfo, System.Threading.CancellationToken ct);
    public void Terminate();
    private Cysharp.Threading.Tasks.UniTask _displayFesUnitIconAsync(PRISM.Module.Networking.IProduceBaseInfoStatus produceBaseInfo);
    private void <_displayFesUnitIconAsync>b__9_0(System.ValueTuple<int, UnityEngine.GameObject> _);

    private struct <_displayFesUnitIconAsync>d__9 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ProduceInfoTabView <>4__this;
        public PRISM.Module.Networking.IProduceBaseInfoStatus produceBaseInfo;
        private PRISM.Common.Model.FUnitIcon <fesUnitIcon>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class SupportEffectTabView : UnityEngine.MonoBehaviour
{
    private PRISM.UI.SCharaIconView[] selfSCharaIconViews;
    private PRISM.UI.SCharaIconView friendSCharaIconView;
    private ENTERPRISE.UI.UITextMeshProUGUI slotCountText;
    private PRISM.Interactions.InProduceSupportEffectContentListView supportEffectListView;
    private UniRx.Subject<int> onShowSelfSCharaDetailPopup;
    private UniRx.Subject<UniRx.Unit> onShowFriendSCharaDetailPopup;
    public System.IObservable<int> OnShowSelfSCharaDetailPopup { get; set; }
    public System.IObservable<UniRx.Unit> OnShowFriendSCharaDetailPopup { get; set; }
    public Cysharp.Threading.Tasks.UniTask SetupAsync(System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IInProduceSupportCharacterStatus> selfSupportCharacters, PRISM.Module.Networking.IInProduceSupportCharacterStatus friendSupportCharacter, System.Collections.Generic.IReadOnlyList<PRISM.Adapters.IInProduceSupportEffectContentViewModel> supportEffectViewModels, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public void Terminate();
    private Cysharp.Threading.Tasks.UniTask _setupSCharaIconAsync(System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IInProduceSupportCharacterStatus> selfSupportCharacters, PRISM.Module.Networking.IInProduceSupportCharacterStatus friendSupportCharacter, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask _setupSCharaIconAsync(PRISM.UI.SCharaIconView sCharaIconView, PRISM.Module.Networking.IInProduceSupportCharacterStatus sChara, int index, System.Action<int> onShowDetail, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Module.Networking.IInProduceSupportCharacterStatus, int> <>9__10_0;
        private int <SetupAsync>b__10_0(PRISM.Module.Networking.IInProduceSupportCharacterStatus e);
    }

    private class <>c__DisplayClass12_0
    {
        public System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IInProduceSupportCharacterStatus> selfSupportCharacters;
        public PRISM.Interactions.SupportEffectTabView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        private Cysharp.Threading.Tasks.UniTask <_setupSCharaIconAsync>b__0(PRISM.UI.SCharaIconView e, int index);
        private void <_setupSCharaIconAsync>b__1(int _);
    }

    private class <>c__DisplayClass13_0
    {
        public System.Action<int> onShowDetail;
        private void <_setupSCharaIconAsync>b__0(System.ValueTuple<int, UnityEngine.GameObject> tuple);
    }

    private struct <_setupSCharaIconAsync>d__13 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public System.Action<int> onShowDetail;
        public PRISM.Module.Networking.IInProduceSupportCharacterStatus sChara;
        public PRISM.UI.SCharaIconView sCharaIconView;
        public PRISM.Interactions.SupportEffectTabView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public int index;
        public System.Threading.CancellationToken ct;
        private PRISM.Common.Model.SCharaIcon <sCharaIcon>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class SupportSkillTabView : UnityEngine.MonoBehaviour
{
    private PRISM.UI.SCharaIconView[] selfSCharaIconViews;
    private PRISM.UI.SCharaIconView friendSCharaIconView;
    private ENTERPRISE.UI.UITextMeshProUGUI slotCountText;
    private PRISM.Interactions.SupportSkillSlotGridView supportSkillSlotGridView;
    private UniRx.Subject<int> onShowSelfSCharaDetailPopup;
    private UniRx.Subject<UniRx.Unit> onShowFriendSCharaDetailPopup;
    public System.IObservable<int> OnShowSelfSCharaDetailPopup { get; set; }
    public System.IObservable<UniRx.Unit> OnShowFriendSCharaDetailPopup { get; set; }
    public Cysharp.Threading.Tasks.UniTask SetupAsync(System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IInProduceSupportCharacterStatus> selfSupportCharacters, PRISM.Module.Networking.IInProduceSupportCharacterStatus friendSupportCharacter, System.Collections.Generic.IList<PRISM.Adapters.SupportSkillSlotViewModel> supportSkillSlotViewModels, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public void Terminate();
    private Cysharp.Threading.Tasks.UniTask _setupSCharaIconAsync(System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IInProduceSupportCharacterStatus> selfSupportCharacters, PRISM.Module.Networking.IInProduceSupportCharacterStatus friendSupportCharacter, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask _setupSCharaIconAsync(PRISM.UI.SCharaIconView sCharaIconView, PRISM.Module.Networking.IInProduceSupportCharacterStatus sChara, int index, System.Action<int> onShowDetailPopup, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Module.Networking.IInProduceSupportCharacterStatus, int> <>9__10_0;
        private int <SetupAsync>b__10_0(PRISM.Module.Networking.IInProduceSupportCharacterStatus e);
    }

    private class <>c__DisplayClass12_0
    {
        public System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IInProduceSupportCharacterStatus> selfSupportCharacters;
        public PRISM.Interactions.SupportSkillTabView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        private Cysharp.Threading.Tasks.UniTask <_setupSCharaIconAsync>b__0(PRISM.UI.SCharaIconView e, int index);
        private void <_setupSCharaIconAsync>b__1(int _);
    }

    private class <>c__DisplayClass13_0
    {
        public System.Action<int> onShowDetailPopup;
        private void <_setupSCharaIconAsync>b__0(System.ValueTuple<int, UnityEngine.GameObject> tuple);
    }

    private struct <_setupSCharaIconAsync>d__13 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public System.Action<int> onShowDetailPopup;
        public PRISM.Module.Networking.IInProduceSupportCharacterStatus sChara;
        public PRISM.UI.SCharaIconView sCharaIconView;
        public PRISM.Interactions.SupportSkillTabView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public int index;
        public System.Threading.CancellationToken ct;
        private PRISM.Common.Model.SCharaIcon <sCharaIcon>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class UnitInfoProduceIdolContent : UnityEngine.MonoBehaviour
{
    private PRISM.UI.PFIdolIconRectView pFIdolIconRectView;
    private PRISM.UI.IdolSkillIconView produceIdolSkillIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI baseVocalValue;
    private ENTERPRISE.UI.UITextMeshProUGUI baseDanceValue;
    private ENTERPRISE.UI.UITextMeshProUGUI baseVisualValue;
    private ENTERPRISE.UI.UITextMeshProUGUI baseMentalValue;
    private ENTERPRISE.UI.UITextMeshProUGUI vocalChangeValue;
    private ENTERPRISE.UI.UITextMeshProUGUI danceChangeValue;
    private ENTERPRISE.UI.UITextMeshProUGUI visualChangeValue;
    private ENTERPRISE.UI.UITextMeshProUGUI mentalChangeValue;
    private UnityEngine.UI.RawImage vocalRankImage;
    private UnityEngine.UI.RawImage danceRankImage;
    private UnityEngine.UI.RawImage visualRankImage;
    private UnityEngine.UI.RawImage mentalRankImage;
    public Cysharp.Threading.Tasks.UniTask SetupAsync(int unitId, PRISM.Module.Networking.IInProduceIdolStatus produceIdol, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask _setupParameterUIAsync(PRISM.Module.Networking.IInProduceIdolStatus produceIdol, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask _loadRankIconAsync(ProduceParameterRank rank, UnityEngine.UI.RawImage uIRawImage, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken token);
}

// Namespace: PRISM.Interactions
public class EndTutorialConfirmPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IEndTutorialConfirmPopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private ENTERPRISE.UI.UITextMeshProUGUI messageText;
    private UnityEngine.UI.RawImage image;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public Cysharp.Threading.Tasks.UniTask SetupAsync(string configKey, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__6_0();
    private void <CreateFrameParameter>b__6_1();
    private void <CreateFrameParameter>b__6_2();

    private struct <SetupAsync>d__5 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public string configKey;
        public System.Threading.CancellationToken ct;
        public PRISM.Interactions.EndTutorialConfirmPopupView <>4__this;
        private Awaiter<PRISM.HowToPlayPopupResourceConfig> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class GetProduceCardConfirmPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IGetProduceCardConfirmPopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClosed;
    private PRISM.Produce.ProduceCardContent produceCardPrefab;
    private UnityEngine.RectTransform produceCardArea;
    private ENTERPRISE.UI.UITextMeshProUGUI getMessageText;
    private PRISM.Interactions.PopupFrameParameter frameParameter;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public Cysharp.Threading.Tasks.UniTask SetupAsync(System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceCardStatus> selectCards, int gettableAmount, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();

    private class <>c__DisplayClass7_0
    {
        public PRISM.Interactions.GetProduceCardConfirmPopupView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        private void <SetupAsync>b__1();
        private void <SetupAsync>b__2();
        private void <SetupAsync>b__3();
        private Cysharp.Threading.Tasks.UniTask <SetupAsync>b__0(PRISM.Module.Networking.IProduceCardStatus e);
    }
}

// Namespace: PRISM.Interactions
public class GetProduceCardFinishPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IGetProduceCardFinishPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Produce.ProduceCardContent produceCardPrefab;
    private UnityEngine.RectTransform produceCardArea;
    private PRISM.Interactions.PopupFrameParameter frameParameter;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public Cysharp.Threading.Tasks.UniTask SetupAsync(System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceCardStatus> getCards, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();

    private class <>c__DisplayClass6_0
    {
        public PRISM.Interactions.GetProduceCardFinishPopupView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        private void <SetupAsync>b__1();
        private void <SetupAsync>b__2();
        private Cysharp.Threading.Tasks.UniTask <SetupAsync>b__0(PRISM.Module.Networking.IProduceCardStatus e);
    }

    private struct <SetupAsync>d__6 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.GetProduceCardFinishPopupView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        public System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceCardStatus> getCards;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class GetProduceCardPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IGetProduceCardPopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClosed;
    private PRISM.Interactions.GetProduceCardContent getProduceCardPrefab;
    private UnityEngine.RectTransform produceCardArea;
    private ENTERPRISE.UI.UITextMeshProUGUI getMessageText;
    private PRISM.Interactions.ButtonView confirmDeckButton;
    private PRISM.Interactions.PopupFrameParameter frameParameter;
    private System.Collections.Generic.List<PRISM.Interactions.GetProduceCardContent> getProduceCardContents;
    private UniRx.Subject<System.ValueTuple<int, SelectState>> onClickCard;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public System.IObservable<System.ValueTuple<int, SelectState>> OnClickCard { get; set; }
    public System.IObservable<UniRx.Unit> OnClickConfirmDeckButton { get; set; }
    public System.Threading.CancellationToken CancellationTokenOnTerminate { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public Cysharp.Threading.Tasks.UniTask SetupAsync(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.SelectablePCardViewModel> gettableCards, int gettableAmount, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Func<Cysharp.Threading.Tasks.UniTask> onPreCloseByGetButtonFunc, System.Func<Cysharp.Threading.Tasks.UniTask> onPreCloseByNotGetButtonFunc, System.Threading.CancellationToken ct);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void UpdateUIState(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.SelectablePCardViewModel> gettableCards);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);

    private class <>c__DisplayClass16_0
    {
        public System.Func<Cysharp.Threading.Tasks.UniTask> onPreCloseByNotGetButtonFunc;
        public System.Func<Cysharp.Threading.Tasks.UniTask> onPreCloseByGetButtonFunc;
        public PRISM.Interactions.GetProduceCardPopupView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        private void <SetupAsync>b__2();
        private void <SetupAsync>b__3();
        private void <SetupAsync>b__4();
        private Cysharp.Threading.Tasks.UniTask <SetupAsync>b__0(PRISM.Adapters.SelectablePCardViewModel e, int index);
        private void <SetupAsync>g___onPreClose|1(System.Func<Cysharp.Threading.Tasks.UniTask> func, bool result);
    }

    private class <>c__DisplayClass16_1
    {
        public int index;
        public <>c__DisplayClass16_0 CS$<>8__locals1;
        private void <SetupAsync>b__5(SelectState selectState);
    }

    private class <>c__DisplayClass16_2
    {
        public bool result;
        public <>c__DisplayClass16_0 CS$<>8__locals2;
        private bool <SetupAsync>b__6();
    }

    private struct <SetupAsync>d__16 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public System.Func<Cysharp.Threading.Tasks.UniTask> onPreCloseByNotGetButtonFunc;
        public System.Func<Cysharp.Threading.Tasks.UniTask> onPreCloseByGetButtonFunc;
        public PRISM.Interactions.GetProduceCardPopupView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        public System.Collections.Generic.IReadOnlyList<PRISM.Adapters.SelectablePCardViewModel> gettableCards;
        public int gettableAmount;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class GetProduceCardContent : UnityEngine.MonoBehaviour
{
    private UnityEngine.GameObject getObject;
    private UnityEngine.GameObject noGetObject;
    private PRISM.Interactions.SelectableProduceCardContent selectableProduceCardContent;
    public System.IObservable<SelectState> OnClick { get; set; }
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Module.Networking.IProduceCardStatus produceCard, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public void UpdateState(SelectState state);
}

// Namespace: PRISM.Interactions
public class ProduceLogCellListView : UnityEngine.MonoBehaviour, EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate
{
    private static int LittleIndexTopHeight;
    private static int LittleIndexHeight;
    private static int LittleIndexUnderHeight;
    private static int AccordionOffTopHeight;
    private static int AccordionOffHeight;
    private static int AccordionOffUnderHeight;
    private static int ProducePolicyHeight;
    private static int AdvHeight;
    private static int ScheduleHeight;
    private static int ScheduleHeightLineUnder3;
    private static int ScheduleHeightLineUnder6;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    private System.Threading.CancellationToken cancellationToken;
    private EnhancedUI.EnhancedScroller.EnhancedScroller scroller;
    private PRISM.Interactions.ProduceLogListCellAccordionOff produceLogListCellAccordionOff;
    private UnityEngine.UI.Scrollbar scrollbar;
    private UnityEngine.GameObject waitLoadImageObject;
    private System.Collections.Generic.List<PRISM.Adapters.IProduceLogCell> produceLogCellList;
    private int currentIndex;
    private int maxIndex;
    public float GetCellViewSize(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex);
    public int GetNumberOfCells(EnhancedUI.EnhancedScroller.EnhancedScroller scroller);
    public Cysharp.Threading.Tasks.UniTask SetupAsync(System.Collections.Generic.List<PRISM.Adapters.IProduceLogCell> produceLogCellList, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken cancellationToken);
    private float _getCellViewHeight(int dataIndex);
    public EnhancedUI.EnhancedScroller.EnhancedScrollerCellView GetCellView(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex, int cellIndex);
    private EnhancedUI.EnhancedScroller.EnhancedScrollerCellView _selectCellView(int dataIndex);
    private Cysharp.Threading.Tasks.UniTask _waitLoadingEndCellAsync();
    private void _cellViewVisibilityChanged(EnhancedUI.EnhancedScroller.EnhancedScrollerCellView cellView);
    private void _cellViewWillRecycle(EnhancedUI.EnhancedScroller.EnhancedScrollerCellView cellView);

    private struct <_waitLoadingEndCellAsync>d__26 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ProduceLogCellListView <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class ProduceLogListCellAccordionOff : EnhancedUI.EnhancedScroller.EnhancedScrollerCellView
{
    private UnityEngine.RectTransform littleIndexTransform;
    private ENTERPRISE.UI.UITextMeshProUGUI littleIndexText;
    private PRISM.Interactions.Produce.ProduceLogAccordionOffView baseProduceLogAccordionOffView;
    private PRISM.Interactions.Produce.ProduceLogAccordionOffView currentProduceLogAccordionOffView;
    private UnityEngine.RectTransform parentRectTransform;
    private UnityEngine.RectTransform cellRectTransform;
    public void UpdateContent(PRISM.Adapters.IProduceLogCell itemData, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken cancellationToken);
    public void Reset();
}

// Namespace: PRISM.Interactions
public class ProduceLogPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IProduceLogPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.ProduceLogCellListView produceLogCellListView;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClick;
    private PRISM.Interactions.PopupFrameParameter frameParam;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Initialize(string title, System.Collections.Generic.List<PRISM.Adapters.IProduceLogCell> produceLogCellList, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken cancellationToken);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <Initialize>b__5_0();
    private void <Initialize>b__5_1();
}

// Namespace: PRISM.Interactions
public class PCardRankUpConfirmPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IPCardRankUpConfirmPopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClosed;
    private PRISM.Interactions.RankUpProduceCardContent rankUpProduceCardPrefab;
    private UnityEngine.RectTransform produceCardArea;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask SetupAsync(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.IPCardRankUpViewModel> rankUpCardViewModels, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    private void <CreateFrameParameter>b__5_0();
    private void <CreateFrameParameter>b__5_1();
    private void <CreateFrameParameter>b__5_2();

    private class <>c__DisplayClass6_0
    {
        public PRISM.Interactions.PCardRankUpConfirmPopupView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        private Cysharp.Threading.Tasks.UniTask <SetupAsync>b__0(System.Collections.Generic.KeyValuePair<PRISM.Module.Networking.IProduceCardStatus, int> pair);
    }

    private struct <SetupAsync>d__6 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.PCardRankUpConfirmPopupView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        public System.Collections.Generic.IReadOnlyList<PRISM.Adapters.IPCardRankUpViewModel> rankUpCardViewModels;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class PCardExistRemainingRankUpCountPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IPCardExistRemainingRankUpCountPopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClosed;
    private ENTERPRISE.UI.UITextMeshProUGUI rankUpCountText;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void Setup(int current, int max);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    private void _setRankUpCountText(int current, int max);
    private void <CreateFrameParameter>b__4_0();
    private void <CreateFrameParameter>b__4_1();
    private void <CreateFrameParameter>b__4_2();
}

// Namespace: PRISM.Interactions
public class PCardRankUpContext : PRISM.Interactions.GridViewContext
{
    private UniRx.ReactiveProperty<float> rankUpIconBlinkValue;
    public UniRx.Subject<int> OnClickPlusButton;
    public UniRx.Subject<int> OnClickMinusButton;
    public int RemainingRankUpCount;
    public float RankUpIconBlinkValue { get; set; }
    public System.IObservable<float> OnChangeRankUpIconBlinkValue { get; set; }
    public void Dispose();
}

// Namespace: PRISM.Interactions
public class PCardRankUpGridCell : PRISM.Interactions.GridViewCell<PRISM.Adapters.IPCardRankUpViewModel, PRISM.Interactions.PCardRankUpContext>
{
    private UnityEngine.GameObject grayOutCover;
    private PRISM.Interactions.RankUpProduceCardContent rankUpPCardContent;
    private ENTERPRISE.UI.UIButton plusButton;
    private ENTERPRISE.UI.UIButton minusButton;
    public void Initialize();
    public void UpdateContent(PRISM.Adapters.IPCardRankUpViewModel model);
    private void _setOnClickPlus(System.Action onClick);
    private void _setOnClickMinus(System.Action onClick);
    private void _setEnable(bool isEnable);
    private void _setPlusButtonEnable(bool isEnable);
    private void _setMinusButtonEnable(bool isEnable);
    private void <Initialize>b__4_0();
    private void <Initialize>b__4_1();
    private void <Initialize>b__4_2(float alpha);
}

// Namespace: PRISM.Interactions
public class PCardRankUpGridView : PRISM.Interactions.GridView<PRISM.Interactions.PCardRankUpGridCell, PRISM.Adapters.IPCardRankUpViewModel, PRISM.Interactions.PCardRankUpContext>
{
    private float rankUpIconBlinkDuration;
    private float rankUpIconBlinkValue;
    private DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> rankUpIconBlinkTweener;
    public System.IObservable<int> OnClickPlusButton { get; set; }
    public System.IObservable<int> OnClickMinusButton { get; set; }
    public int RemainingRankUpCount { get; set; }
    protected void Initialize();
    protected void SetupCellTemplate();
    public void Terminate();
    private float <Initialize>b__4_0();
    private void <Initialize>b__4_1(float value);

    private class CellGroup : DefaultCellGroup<PRISM.Adapters.IPCardRankUpViewModel, PRISM.Interactions.PCardRankUpContext>
    {
    }
}

// Namespace: PRISM.Interactions
public class PCardRankUpPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IPCardRankUpPopupView, PRISM.Adapters.IClosablePopupFrame<System.Collections.Generic.IReadOnlyList<string>>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<System.Collections.Generic.IReadOnlyList<string>>
{
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<System.Collections.Generic.IReadOnlyList<string>> onClosed;
    private UniRx.Subject<UniRx.Unit> onClickEndButton;
    private UniRx.Subject<UniRx.Unit> onClickResetButton;
    private UniRx.Subject<UniRx.Unit> onClickRankUpButton;
    private PRISM.Interactions.PCardRankUpGridView gridView;
    private ENTERPRISE.UI.UITextMeshProUGUI rankUpCountText;
    private ENTERPRISE.UI.UITextMeshProUGUI havingCardAmountText;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<System.Collections.Generic.IReadOnlyList<string>> OnCloseRequested { get; set; }
    public System.IObservable<UniRx.Unit> OnClickRankUpButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickResetButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickEndButton { get; set; }
    public System.IObservable<int> OnClickPlusButton { get; set; }
    public System.IObservable<int> OnClickMinusButton { get; set; }
    public System.Threading.CancellationToken CancellationTokenOnTerminate { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void Setup(PRISM.Adapters.IPCardRankUpPopupViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void UpdateUIState(PRISM.Adapters.IPCardRankUpPopupViewModel viewModel);
    public void RequestClose(System.Collections.Generic.IReadOnlyList<string> rankUpCardIds);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    private void _setRankUpCountText(int current, int max);
    private void <CreateFrameParameter>b__21_0();
    private void <CreateFrameParameter>b__21_1();
    private void <CreateFrameParameter>b__21_2();
    private void <CreateFrameParameter>b__21_3();
}

// Namespace: PRISM.Interactions
public class RankUpProduceCardContent : UnityEngine.MonoBehaviour
{
    private PRISM.Produce.ProduceCardContent produceCardContent;
    private PRISM.UI.TexAdditive[] targetRankIcons;
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Module.Networking.IProduceCardStatus produceCard, int targetRank, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public void SetRankUpCount(int currentRank, int targetRank);
    public void SetRankUpIconBlinkValue(float blink);
}

// Namespace: PRISM.Interactions
public class ProduceOptionPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IProduceOptionPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.ToggleGroupView commuSkipGroup;
    private PRISM.Interactions.ToggleGroupView idolSkillSkipGroup;
    private PRISM.Interactions.ToggleGroupView shakeEffectGroup;
    private PRISM.Interactions.ToggleGroupView simpleBufferDisplayGroup;
    private PRISM.Interactions.ToggleGroupView confirmSkipGroup;
    private PRISM.Interactions.ToggleGroupView skitSkipGroup;
    private PRISM.Interactions.ToggleGroupView miniCharaSkipGroup;
    private PRISM.Interactions.ToggleGroupView autoGroup;
    private PRISM.Interactions.ToggleGroupView tapStopIngameGroup;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClick;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void Setup(PRISM.Produce.ProduceOptionSaveData saveData);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__12_0();
    private void <CreateFrameParameter>b__12_1();

    private class <>c__DisplayClass13_0
    {
        public PRISM.Produce.ProduceOptionSaveData saveData;
        private void <Setup>b__0(int selectedIndex);
        private void <Setup>b__1(int selectedIndex);
        private void <Setup>b__2(int selectedIndex);
        private void <Setup>b__3(int selectIndex);
        private void <Setup>b__4(int selectedIndex);
        private void <Setup>b__5(int selectedIndex);
        private void <Setup>b__6(int selectedIndex);
        private void <Setup>b__7(int selectedIndex);
        private void <Setup>b__8(int selectIndex);
    }
}

// Namespace: PRISM.Interactions
public class ProducePreparationIdolSkillSelectPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IProducePreparationIdolSkillSelectPopupView, PRISM.Adapters.IClosablePopupFrame<int>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<int>
{
    private ENTERPRISE.UI.UITextMeshProUGUI integrationNameArea;
    private UnityEngine.GameObject parentObject;
    private PRISM.Produce.ProducePreparationIdolSkillSelectListItemContent childObjectBase;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<int> onSelectedSkillSubject;
    private System.Threading.CancellationToken ct;
    private PRISM.Adapters.ProducePreparationIdolSkillSelectPopupViewModel vm;
    private PRISM.Produce.ProducePreparationIdolSkillSelectListItemContent[] producePreparationIdolSkillSelectListItemContentList;
    private int selectIndex;
    private int selectedIndex;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<int> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    private void Awake();
    public void Assign(PRISM.Adapters.ProducePreparationIdolSkillSelectPopupViewModel vm, PRISM.ResourceManagement.IResourceLoader loader);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void _selectSkillUpdate();
    private Cysharp.Threading.Tasks.UniTask _showIdolSkillDetailListPUAsync(int index);
    private void <CreateFrameParameter>b__13_0();
    private void <CreateFrameParameter>b__13_1();
    private void <CreateFrameParameter>b__13_2();

    private class <>c__DisplayClass12_0
    {
        public PRISM.Interactions.ProducePreparationIdolSkillSelectPopupView <>4__this;
        public int skillNum;
        public PRISM.Adapters.ProducePreparationIdolSkillSelectPopupViewModel vm;
        private void <Assign>g__skillButtonClicked|0(int index);
    }

    private class <>c__DisplayClass12_1
    {
        public int cacheIndex;
        public <>c__DisplayClass12_0 CS$<>8__locals1;
        private void <Assign>b__1();
        private void <Assign>b__2();

        private struct <<Assign>b__2>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
        {
            public int <>1__state;
            public System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
            public <>c__DisplayClass12_1 <>4__this;
            private Awaiter <>u__1;
            private void MoveNext();
            private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }
}

// Namespace: PRISM.Interactions
public class ProduceResumeConfirmPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IProduceResumeConfirmPopupView, PRISM.Adapters.IClosablePopupFrame<int>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<int>
{
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<int> onClosed;
    private ENTERPRISE.UI.UITextMeshProUGUI episodeMessage;
    private UnityEngine.GameObject[] difficultyObjectArray;
    private PRISM.UI.PFIdolIconRectView[] unitIdolButtonArray;
    private PRISM.UI.SCharaIconView[] supportButtonArray;
    private PRISM.UI.SCharaIconView friendButton;
    private UnityEngine.GameObject fUnitIconEmptyText;
    private UnityEngine.GameObject fUnitObjectRoot;
    private PRISM.UI.FUnitIconView fUnitIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI inheritanceCount;
    private System.Func<int, Cysharp.Threading.Tasks.UniTask> onPreCloseFunc;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<int> OnCloseRequested { get; set; }
    public System.IObservable<int> OnLongPressInheritanceFUnitIcon { get; set; }
    public System.Threading.CancellationToken CancellationTokenOnTerminate { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Adapters.ProduceResumeConfirmPopupViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Func<int, Cysharp.Threading.Tasks.UniTask> onPreCloseFunc, System.Threading.CancellationToken ct);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__13_1();
    private void <CreateFrameParameter>b__13_2();
    private void <CreateFrameParameter>b__13_3();
    private void <CreateFrameParameter>b__13_4();
    private void <CreateFrameParameter>g___onClickFooterButton|13_0(int index);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<System.ValueTuple<int, UnityEngine.GameObject>, int> <>9__15_0;
        private int <get_OnLongPressInheritanceFUnitIcon>b__15_0(System.ValueTuple<int, UnityEngine.GameObject> tuple);
    }

    private class <>c__DisplayClass13_0
    {
        public int index;
        public PRISM.Interactions.ProduceResumeConfirmPopupView <>4__this;
        private bool <CreateFrameParameter>b__5();
    }

    private struct <SetupAsync>d__18 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Adapters.ProduceResumeConfirmPopupViewModel viewModel;
        public PRISM.Interactions.ProduceResumeConfirmPopupView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        public System.Func<int, Cysharp.Threading.Tasks.UniTask> onPreCloseFunc;
        private ENTERPRISE.Localization.LocalizationManager <localizationManager>5__2;
        private int <i>5__3;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class ProduceStaminaUsagePopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IProduceStaminaUsagePopupView, PRISM.Adapters.IClosablePopupFrame<System.ValueTuple<bool, int, bool>>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<System.ValueTuple<bool, int, bool>>
{
    private PRISM.Interactions.Produce.ProduceStaminaUsageSliderView sliderView;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<System.ValueTuple<bool, int, bool>> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<System.ValueTuple<bool, int, bool>> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public void Setup(int currentSt, int episodeSt, int usageValue, bool isAlwaysMax);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__4_0();
    private void <CreateFrameParameter>b__4_1();
    private void <CreateFrameParameter>b__4_2();
}

// Namespace: PRISM.Interactions
public class ProduceSupportCharaReplaceConfirmPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IProduceSupportCharaReplaceConfirmPopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private PRISM.UI.SCharaIconRectView beforeSChara;
    private PRISM.UI.SCharaIconRectView afterSChara;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public System.IObservable<UniRx.Unit> OnShowBeforeSCharaDetailPopup { get; set; }
    public System.IObservable<UniRx.Unit> OnShowAfterSCharaDetailPopup { get; set; }
    public System.Threading.CancellationToken CancellationTokenOnTerminate { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Module.Networking.ISupportCharacterStatus sCharaBeforeReplacement, PRISM.Module.Networking.ISupportCharacterStatus sCharaAfterReplacement, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__11_0();
    private void <CreateFrameParameter>b__11_1();
    private void <CreateFrameParameter>b__11_2();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<System.ValueTuple<int, UnityEngine.GameObject>, UniRx.Unit> <>9__6_0;
        public static System.Func<System.ValueTuple<int, UnityEngine.GameObject>, UniRx.Unit> <>9__8_0;
        private UniRx.Unit <get_OnShowBeforeSCharaDetailPopup>b__6_0(System.ValueTuple<int, UnityEngine.GameObject> _);
        private UniRx.Unit <get_OnShowAfterSCharaDetailPopup>b__8_0(System.ValueTuple<int, UnityEngine.GameObject> _);
    }

    private struct <SetupAsync>d__12 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Module.Networking.ISupportCharacterStatus sCharaBeforeReplacement;
        public PRISM.Module.Networking.ISupportCharacterStatus sCharaAfterReplacement;
        public PRISM.Interactions.ProduceSupportCharaReplaceConfirmPopupView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private PRISM.Common.Model.SCharaIcon <beforeSCharaIcon>5__2;
        private PRISM.Common.Model.SCharaIcon <afterSCharaIcon>5__3;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class ProduceSupportCharaSelectGridView : FancyScrollView.FancyGridView<PRISM.Adapters.ProduceSupportCharaSelectGridViewCellViewModel, PRISM.ClickObservableContext<int>>
{
    private PRISM.Interactions.ProduceSupportCharaSelectGridViewCell cellPrefab;
    protected UnityEngine.GameObject emptyView;
    public System.IObservable<int> OnClickCell { get; set; }
    public System.IObservable<int> OnLongPressCell { get; set; }
    public void UpdateContents(System.Collections.Generic.IList<PRISM.Adapters.ProduceSupportCharaSelectGridViewCellViewModel> items);
    public void Dispose();
    protected void SetupCellTemplate();

    private class CellGroup : DefaultCellGroup<PRISM.Adapters.ProduceSupportCharaSelectGridViewCellViewModel, PRISM.ClickObservableContext<int>>
    {
    }
}

// Namespace: PRISM.Interactions
public class ProduceSupportCharaSelectGridViewCell : FancyScrollView.FancyGridViewCell<PRISM.Adapters.ProduceSupportCharaSelectGridViewCellViewModel, PRISM.ClickObservableContext<int>>
{
    private PRISM.UI.SCharaIconRectView idolIconView;
    private UnityEngine.GameObject cursorObject;
    private UnityEngine.GameObject pIdolDuplicatedObject;
    private System.IDisposable disposable;
    public void UpdateContent(PRISM.Adapters.ProduceSupportCharaSelectGridViewCellViewModel viewModel);

    private class <>c__DisplayClass4_0
    {
        public PRISM.Interactions.ProduceSupportCharaSelectGridViewCell <>4__this;
        public PRISM.Adapters.ProduceSupportCharaSelectGridViewCellViewModel viewModel;
        private void <UpdateContent>b__0();
        private void <UpdateContent>b__1(bool isSelected);
    }
}

// Namespace: PRISM.Interactions
public class ProduceSupportCharaSelectPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IProduceSupportCharaSelectPopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private PRISM.Interactions.ProduceSupportCharaSelectGridView gridView;
    private PRISM.Interactions.SortFilterView sortFilterView;
    private PRISM.Adapters.ProduceSupportCharaSelectPopupViewModel viewModel;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClosed;
    private UniRx.Subject<UniRx.Unit> onReplace;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public System.IObservable<UniRx.Unit> OnReplace { get; set; }
    public PRISM.Adapters.ISortFilterView SortFilterView { get; set; }
    public System.IObservable<int> OnClickSChara { get; set; }
    public System.IObservable<int> OnLongPressSChara { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void Setup(PRISM.Adapters.ProduceSupportCharaSelectPopupViewModel viewModel);
    public void UpdateSCharaList(System.Collections.Generic.IList<PRISM.Adapters.ProduceSupportCharaSelectGridViewCellViewModel> dataList);
    public void SetEnableDecideButton(bool isEnable);
    public void OnReplaceSupportCharacter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__15_0();
    private void <CreateFrameParameter>b__15_1();
    private void <CreateFrameParameter>b__15_2();
}

// Namespace: PRISM.Interactions
public class ProduceTopMenuPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IProduceTopMenuPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private ENTERPRISE.UI.UITextMeshProUGUI scenarioNameAndDifficultyText;
    private ENTERPRISE.UI.UIButton helpButton;
    private ENTERPRISE.UI.UIButton logButton;
    private ENTERPRISE.UI.UIButton backToHomeButton;
    private ENTERPRISE.UI.UIButton giveUpButton;
    private ENTERPRISE.UI.UIButton produceOptionButton;
    private ENTERPRISE.UI.UIButton systemOptionButton;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClick;
    private PRISM.Interactions.IPopupFrameView parent;
    public System.IObservable<UniRx.Unit> OnClickHelpObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnClickLogObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnClickBackToHomeObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnClickGiveUpObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnClickProduceOptionObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnClickSystemOptionObservable { get; set; }
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Initialize(int episodeId, ProduceDifficultyType difficultyType);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__23_0();
    private void <CreateFrameParameter>b__23_1();
}

// Namespace: PRISM.Interactions
public class RecommendSupportCharacterPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IRecommendSupportCharacterPopupView, PRISM.Adapters.IClosablePopupFrame<int>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<int>
{
    private PRISM.Interactions.ToggleGroupView toggleButtonGroup;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<int> onClosed;
    private UniRx.ReactiveProperty<int> selectedIndex;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<int> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    private void <CreateFrameParameter>b__6_0();
    private void <CreateFrameParameter>b__6_1();
    private void <CreateFrameParameter>b__6_2();
}

// Namespace: PRISM.Interactions
public class ProduceSCharaEditConfirmPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IProduceSCharaEditConfirmPopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClosed;
    private System.IDisposable androidBackKeyDisableScope;
    private PRISM.Interactions.SupportCharacterEditView editView;
    private PRISM.Interactions.PopupFrameParameter popupFrameParameter;
    private UniRx.Subject<int> onClickSelfSCharaIcon;
    private UniRx.Subject<int> onLongPressSelfSCharaIcon;
    private UniRx.Subject<UniRx.Unit> onLongPressFriendSCharaIcon;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public System.IObservable<int> OnClickSelfSCharaIcon { get; set; }
    public System.IObservable<int> OnLongPressSelfSCharaIcon { get; set; }
    public System.IObservable<UniRx.Unit> OnLongPressFriendSCharaIcon { get; set; }
    public System.Threading.CancellationToken CancellationTokenOnTerminate { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask SetupForCancelDecideAsync(string popupTitle, PRISM.Adapters.SupportCharacterEditViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask SetupForCloseAsync(string popupTitle, PRISM.Adapters.SupportCharacterEditViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask UpdateViewAsync(PRISM.Adapters.SupportCharacterEditViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask _showAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private Cysharp.Threading.Tasks.UniTask _editViewSetupAsync(PRISM.Adapters.SupportCharacterEditViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    private void _commonCreateFrameParameter(string title, FooterInfoParameter footerInfoParameter);
    private void <SetupForCancelDecideAsync>b__18_0();
    private void <SetupForCancelDecideAsync>b__18_1();
    private void <SetupForCloseAsync>b__19_0();
    private void <_commonCreateFrameParameter>b__31_0();

    private struct <_showAsync>d__26 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ProduceSCharaEditConfirmPopupView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class SelectablePCardGridCell : PRISM.Interactions.GridViewCell<PRISM.Adapters.SelectablePCardViewModel, PRISM.Interactions.GridViewContextWithClick<int>>
{
    private PRISM.Interactions.SelectableProduceCardContent selectableProduceCardContent;
    public void Initialize();
    public void UpdateContent(PRISM.Adapters.SelectablePCardViewModel data);
    private void <Initialize>b__1_0(SelectState _);
}

// Namespace: PRISM.Interactions
public class SelectablePCardGridView : PRISM.Interactions.GridView<PRISM.Interactions.SelectablePCardGridCell, PRISM.Adapters.SelectablePCardViewModel, PRISM.Interactions.GridViewContextWithClick<int>>
{
    public System.IObservable<int> OnCellClick { get; set; }
    protected void SetupCellTemplate();

    private class CellGroup : DefaultCellGroup<PRISM.Adapters.SelectablePCardViewModel, PRISM.Interactions.GridViewContextWithClick<int>>
    {
    }
}

// Namespace: PRISM.Interactions
public class SelectableProduceCardContent : UnityEngine.MonoBehaviour
{
    private PRISM.Produce.ProduceCardContent produceCardContent;
    private UnityEngine.GameObject selectFrame;
    private SelectState currentState;
    public System.IObservable<SelectState> OnClick { get; set; }
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Module.Networking.IProduceCardStatus produceCard, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public void UpdateState(SelectState state);
    private SelectState <get_OnClick>b__4_0(UniRx.Unit _);
}

// Namespace: PRISM.Interactions
public class SelectInheritanceFUnitPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.ISelectInheritanceFUnitPopupView, PRISM.Adapters.IClosablePopupFrame<string>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<string>
{
    private PRISM.Interactions.ToggleGroupView toggleGroupView;
    private PRISM.Interactions.Produce.SelectInheritanceFUnitListView selectableListView;
    private PRISM.Interactions.SortFilterView sortFilterView;
    private ENTERPRISE.UI.UITextMeshProUGUI numText;
    private PRISM.Adapters.Produce.SelectInheritanceFUnitPopupViewModel viewModel;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<string> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public PRISM.Adapters.ISortFilterView SortFilterView { get; set; }
    public System.IObservable<string> OnLongPressFUnitIcon { get; set; }
    public Cysharp.Threading.Tasks.UniTask<string> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Adapters.Produce.SelectInheritanceFUnitPopupViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__12_0();
    private void <CreateFrameParameter>b__12_1();
    private void <CreateFrameParameter>b__12_2();

    private class <>c
    {
        public static <>c <>9;
        public static System.Action<PRISM.Common.Model.FUnitIcon> <>9__13_1;
        private void <SetupAsync>b__13_1(PRISM.Common.Model.FUnitIcon data);
    }

    private class <>c__DisplayClass13_0
    {
        public System.Threading.CancellationToken ct;
        public PRISM.Interactions.SelectInheritanceFUnitPopupView <>4__this;
        private Cysharp.Threading.Tasks.UniTaskVoid <SetupAsync>b__0(System.Collections.Generic.IReadOnlyList<PRISM.Common.Model.FUnitIcon> data);

        private struct <<SetupAsync>b__0>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
        {
            public int <>1__state;
            public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
            public <>c__DisplayClass13_0 <>4__this;
            public System.Collections.Generic.IReadOnlyList<PRISM.Common.Model.FUnitIcon> data;
            private Awaiter <>u__1;
            private void MoveNext();
            private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }
}

// Namespace: PRISM.Interactions
public class ShinyCompetitionHistoryDetailPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IShinyCompetitionHistoryDetailPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.Produce.ShinyCompetitionHistoryListCell historyDetailContent;
    private PRISM.Interactions.Produce.ShinyCompetitionHistoryDetailListView recordListView;
    private ENTERPRISE.UI.UITextMeshProUGUI emptyText;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Adapters.ShinyCompetitionHistoryListCellViewModel viewModel;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void Inject(PRISM.Adapters.ShinyCompetitionHistoryListCellViewModel model, PRISM.ResourceManagement.IResourceLoader loader);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__8_0();
    private void <CreateFrameParameter>b__8_1();
}

// Namespace: PRISM.Interactions
public class ShinyCompetitionHistoryPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IShinyCompetitionHistoryPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.Produce.ShinyCompetitionHistoryListView historyListView;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private UniRx.Subject<int> onClickCell;
    private PRISM.Adapters.ShinyCompetitionHistoryPopupViewModel viewModel;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public System.IObservable<int> OnClickCell { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Inject(PRISM.Adapters.ShinyCompetitionHistoryPopupViewModel viewModel);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <Inject>b__8_0(int index);
    private void <CreateFrameParameter>b__9_0();
    private void <CreateFrameParameter>b__9_1();
}

// Namespace: PRISM.Interactions
public class SupportCharaUnitSetupPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.ISupportCharaUnitSetupPopupView, PRISM.Adapters.IClosablePopupFrame<System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.ISupportCharacterStatus>>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.ISupportCharacterStatus>>
{
    private PRISM.Interactions.SupportCharacterEditView supportCharacterEditView;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.ISupportCharacterStatus>> onClosed;
    private UniRx.Subject<PRISM.Module.Networking.ISupportCharacterStatus> onClickSCharaIconSubject;
    private UniRx.Subject<PRISM.Module.Networking.ISupportCharacterStatus> onLongPressSCharaIconSubject;
    private UniRx.Subject<UniRx.Unit> onClickRecommendEditSubject;
    private PRISM.Adapters.SupportCharaUnitSetupPopupViewModel viewModel;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.ISupportCharacterStatus>> OnCloseRequested { get; set; }
    public System.IObservable<PRISM.Module.Networking.ISupportCharacterStatus> OnClickSCharaIcon { get; set; }
    public System.IObservable<PRISM.Module.Networking.ISupportCharacterStatus> OnLongPressSCharaIcon { get; set; }
    public System.IObservable<UniRx.Unit> OnClickRecommendEdit { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.SupportCharaUnitSetupPopupViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask UpdateViewAsync(PRISM.Adapters.SupportCharaUnitSetupPopupViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__14_0();
    private void <CreateFrameParameter>b__14_1();
    private void <CreateFrameParameter>b__14_2();

    private class <>c__DisplayClass15_0
    {
        public PRISM.Adapters.SupportCharaUnitSetupPopupViewModel viewModel;
        public PRISM.Interactions.SupportCharaUnitSetupPopupView <>4__this;
        private void <InitializeAsync>b__0(int index);
        private void <InitializeAsync>b__1(int index);
        private void <InitializeAsync>b__2(UniRx.Unit _);
    }

    private struct <InitializeAsync>d__15 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Adapters.SupportCharaUnitSetupPopupViewModel viewModel;
        public PRISM.Interactions.SupportCharaUnitSetupPopupView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class ConfirmAndResultMultipleSupportSkillPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IConfirmAndResultMultipleSupportSkillPopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private ENTERPRISE.UI.UITextMeshProUGUI messageText;
    private UnityEngine.UI.ScrollRect scrollRect;
    private UnityEngine.UI.HorizontalLayoutGroup layoutGroup;
    private PRISM.Interactions.Produce.SupportSkillIconCell cellPrefab;
    private UnityEngine.GameObject leftArrowObject;
    private UnityEngine.GameObject rightArrowObject;
    private PRISM.Interactions.SupportSkillNode targetSkillNode;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClosed;
    private PRISM.Interactions.PopupFrameParameter popupFrameParameter;
    private System.Collections.Generic.List<PRISM.Interactions.Produce.SupportSkillIconCell> iconList;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    private void _createFrameParameter(string title, bool isConfirm);
    public void Setup(string title, string message, bool isConfirm, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IPotentialSupportSkillStatus> skills, PRISM.ResourceManagement.IResourceLoader loader);
    private void _setCellSelected(int index, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IPotentialSupportSkillStatus> skills);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <_createFrameParameter>b__13_0();
    private void <_createFrameParameter>b__13_1();
    private void <_createFrameParameter>b__13_2();
    private void <_createFrameParameter>b__13_3();
    private void <_createFrameParameter>b__13_4();

    private class <>c__DisplayClass14_0
    {
        public PRISM.Interactions.ConfirmAndResultMultipleSupportSkillPopupView <>4__this;
        public System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IPotentialSupportSkillStatus> skills;
        public System.Action<int> <>9__0;
        private void <Setup>b__0(int index);
    }

    private class <>c__DisplayClass14_1
    {
        public float epsilon;
        public <>c__DisplayClass14_0 CS$<>8__locals1;
        private void <Setup>b__1(UnityEngine.Vector2 value);
    }
}

// Namespace: PRISM.Interactions
public class DeleteMultipleSupportSkillPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IDeleteMultipleSupportSkillPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.SupportSkillNode nodePrefab;
    private UnityEngine.Transform nodeParent;
    private ENTERPRISE.UI.UIButton skillListButton;
    private ENTERPRISE.UI.UITextMeshProUGUI nowSlotText;
    private ENTERPRISE.UI.UITextMeshProUGUI maxSlotText;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private UniRx.Subject<int> onSelect;
    private UniRx.Subject<UniRx.Unit> onDecide;
    private UniRx.Subject<UniRx.Unit> onClickSkillList;
    private System.Collections.Generic.List<PRISM.Interactions.SupportSkillNode> nodeList;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public System.IObservable<int> OnSelect { get; set; }
    public System.IObservable<UniRx.Unit> OnDecide { get; set; }
    public System.IObservable<UniRx.Unit> OnClickSkillList { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void Setup(System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IPotentialSupportSkillStatus> skills, int maxSlot, int currentSlot);
    public void UpdateSlotCountText(int currentSlotNum, int maxSlotNum);
    public void SelectNode(int index, bool isSelected);
    public void SetButtonEnabled(bool isActive);
    public void Close();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__18_0();
    private void <Setup>b__19_0();

    private class <>c__DisplayClass19_0
    {
        public int index;
        public PRISM.Interactions.DeleteMultipleSupportSkillPopupView <>4__this;
        private void <Setup>b__1();
    }
}

// Namespace: PRISM.Interactions
public class GetMultipleSupportSkillPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IGetMultipleSupportSkillPopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private PRISM.Interactions.SupportSkillNode nodePrefab;
    private UnityEngine.Transform nodeParent;
    private ENTERPRISE.UI.UITextMeshProUGUI messageText;
    private ENTERPRISE.UI.UITextMeshProUGUI nowSlotText;
    private ENTERPRISE.UI.UITextMeshProUGUI maxSlotText;
    private UnityEngine.GameObject inheritanceObject;
    private ENTERPRISE.UI.UIButton skillListButton;
    private ENTERPRISE.UI.UITextMeshProUGUI inheritanceCountText;
    private ENTERPRISE.UI.UITextMeshProUGUI inheritanceLimitCountText;
    private UniRx.Subject<int> onSelect;
    private UniRx.Subject<bool> onDecide;
    private UniRx.Subject<UniRx.Unit> onClickSkillList;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClosed;
    private System.Collections.Generic.List<PRISM.Interactions.SupportSkillNode> nodeList;
    private PRISM.Interactions.PopupFrameParameter popupFrameParameter;
    private PRISM.Interactions.IPopupFrameView parent;
    public System.IObservable<int> OnSelect { get; set; }
    public System.IObservable<bool> OnDecide { get; set; }
    public System.IObservable<UniRx.Unit> OnClickSkillList { get; set; }
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void Setup(string title, string message, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IPotentialSupportSkillStatus> gettableSkills, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IPotentialSupportSkillStatus> acquiredSkills, int maxSlot, int currentSlot, bool isInheritance);
    public void SelectNode(int index, bool isSelected);
    public void SetInheritanceCount(int max, int current);
    public void SetButtonEnabled(bool isActive);
    public void Close(bool isGetSupportSkill);
    private void _createFrameParameter(string title);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <Setup>b__24_0();
    private void <_createFrameParameter>b__29_0();
    private void <_createFrameParameter>b__29_1();
    private void <_createFrameParameter>b__29_2();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Module.Networking.IPotentialSupportSkillStatus, int, bool> <>9__24_1;
        private bool <Setup>b__24_1(PRISM.Module.Networking.IPotentialSupportSkillStatus e, int state);
    }

    private class <>c__DisplayClass24_0
    {
        public int index;
        public PRISM.Interactions.GetMultipleSupportSkillPopupView <>4__this;
        private void <Setup>b__2();
    }
}

// Namespace: PRISM.Interactions
public class SupportSkillNode : UnityEngine.MonoBehaviour
{
    private UnityEngine.GameObject Skill;
    private UnityEngine.GameObject Blank;
    private UnityEngine.GameObject Get;
    private ENTERPRISE.UI.UIButton button;
    private UnityEngine.UI.RawImage Icon;
    private ENTERPRISE.UI.UITextMeshProUGUI Name;
    private ENTERPRISE.UI.UITextMeshProUGUI Description;
    private UnityEngine.GameObject baseBtn;
    private UnityEngine.GameObject SelectFrame;
    private UnityEngine.GameObject acquiredObject;
    private PRISM.AutoCancellationTokenSource canceller;
    public ENTERPRISE.UI.UIButton Button { get; set; }
    public void Setup(PRISM.Module.Networking.IPotentialSupportSkillStatus skill, bool isGetSkill, bool isButtonEnabled);
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Module.Networking.IPotentialSupportSkillStatus skill, PRISM.ResourceManagement.IResourceLoader resourceLoader, bool isGetSkill, bool isButtonEnabled, System.Threading.CancellationToken ct);
    public void Setup(PRISM.Module.Networking.IInProducePotentialSupportSkillStatus skill, bool isGetSkill, bool isButtonEnabled);
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Module.Networking.IInProducePotentialSupportSkillStatus skill, PRISM.ResourceManagement.IResourceLoader resourceLoader, bool isGetSkill, bool isButtonEnabled, System.Threading.CancellationToken ct);
    public void SetBlank();
    public void SetSelectFrame(bool isActive);
    public void SetAcquired();
}

// Namespace: PRISM.Interactions
public class SupportSkillConfirmPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.ISupportSkillConfirmPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private UnityEngine.RectTransform skillNodeArea;
    private PRISM.Interactions.SupportSkillNode skillNodePrefab;
    private ENTERPRISE.UI.UITextMeshProUGUI slotText;
    private UnityEngine.GameObject emptyView;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask SetupAsync(System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IPotentialSupportSkillStatus> supportSkills, int slotAmount, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__7_0();
    private void <CreateFrameParameter>b__7_1();

    private class <>c__DisplayClass8_0
    {
        public PRISM.Interactions.SupportSkillConfirmPopupView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        private Cysharp.Threading.Tasks.UniTask <SetupAsync>b__0(PRISM.Module.Networking.IPotentialSupportSkillStatus e);
    }
}

// Namespace: PRISM.Interactions
public class ProduceConfirmConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.ProduceConfirmArgument>, PRISM.Scenario.PlayableADV, PRISM.IProduceConfirmConnector
{
    private PRISM.Adapters.ProduceEpisodeSelectViewModel episodeSelectModel;
    protected string autoReleasedConfigRef;
    protected string inheritanceReleasedConfigRef;
    private PRISM.Interactions.Adv.AdvScreenView advUI;
    private UnityEngine.GameObject touchAreaPanel;
    protected PRISM.Adapters.ProduceConfirmArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
    public PRISM.Legacy.Adv.IAdvScreenPresenterForLegacy CreateAdvScreenPresenter(PRISM.Adv.AdvScreenViewModel viewModel, PRISM.Scenario.ScenarioManager scenarioManager);
    public void DisactivateWholeButton();
    public void ActivateWholeButton();
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
    protected Cysharp.Threading.Tasks.UniTask _onBeginIdleAsync();
    private Cysharp.Threading.Tasks.UniTask _showHowToPlayPopupAsync(string configRefKey);
    private Cysharp.Threading.Tasks.UniTask <>n__0();

    private struct <_onBeginIdleAsync>d__10 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ProduceConfirmConnector <>4__this;
        private bool <isDisplayedReleaseAutolHowToPlay>5__2;
        private bool <isTutorial>5__3;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_showHowToPlayPopupAsync>d__11 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public string configRefKey;
        private PRISM.HowToPlayPopupSaveData <saveData>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class ProduceConfirmView : UnityEngine.MonoBehaviour, PRISM.Adapters.IProduceConfirmView
{
    private UnityEngine.GameObject bgObject;
    private UnityEngine.RectTransform safeAreaRoot;
    private ENTERPRISE.UI.UITextMeshProUGUI episodeName;
    private UnityEngine.GameObject[] difficultyIcons;
    private PRISM.Interactions.ButtonView episodeDetailButton;
    private PRISM.Interactions.ButtonView subSeasonDetailButton;
    private UnityEngine.GameObject subSeasonCheckOn;
    private UnityEngine.GameObject subSeasonCheckOff;
    private PRISM.Interactions.ButtonView produceBonusButton;
    private PRISM.UI.PFIdolIconRectView[] unitIdolButtonArray;
    private PRISM.UI.SCharaIconView[] supportButtonArray;
    private PRISM.UI.SCharaIconView friendButton;
    private PRISM.Interactions.ButtonView supportConfirmButton;
    private PRISM.Interactions.ButtonView fUnitIconEmptyButton;
    private UnityEngine.GameObject fUnitObjectRoot;
    private PRISM.UI.FUnitIconView inheritanceFUnitIcon;
    private UnityEngine.GameObject inheritanceEmptyObject;
    private UnityEngine.GameObject inheritanceFullObject;
    private ENTERPRISE.UI.UITextMeshProUGUI inheritanceCount;
    private PRISM.Interactions.VoDaViMeRankView vodaviRankView;
    private PRISM.Interactions.ButtonView autoSettingButton;
    private PRISM.Interactions.ToggleButtonView autoPlayToggle;
    private PRISM.Interactions.ButtonView staminaUsageButton;
    private TMPro.TextMeshProUGUI staminaUsageStatusText;
    private PRISM.Interactions.ButtonView confirmHowToPlayButton;
    private string howToPlayManualKey;
    private PRISM.Interactions.ButtonView nextButton;
    private TMPro.TextMeshProUGUI startButtonStText;
    private TMPro.TextMeshProUGUI confirmMessage;
    private PRISM.Interactions.Stamina.StaminaRecoveryTypeItemPanelView staminaGaugeView;
    private PRISM.Interactions.ButtonView staminaRecoverButton;
    private PRISM.Interactions.ButtonView backButton;
    private UnityEngine.UI.Image footerBackGround;
    private UniRx.Subject<int> onClickPIdolIconSubject;
    private UniRx.Subject<System.ValueTuple<int, bool>> onClickSCharaIconSubject;
    private UniRx.Subject<UniRx.Unit> onClickInheritanceFUnitIconSubject;
    private UniRx.Subject<UniRx.Unit> onLongPressInheritanceFUnitIconSubject;
    private PRISM.ResourceManagement.IResourceLoader loader;
    public System.IObservable<UniRx.Unit> OnClickEpisodeDetail { get; set; }
    public System.IObservable<UniRx.Unit> OnClickSubSeasonDetail { get; set; }
    public System.IObservable<UniRx.Unit> OnClickProduceBonus { get; set; }
    public System.IObservable<int> OnClickPIdolButton { get; set; }
    public System.IObservable<System.ValueTuple<int, bool>> OnClickSCharaButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickInheritanceFUnitIcon { get; set; }
    public System.IObservable<UniRx.Unit> OnLongPressInheritanceFUnitIcon { get; set; }
    public System.IObservable<UniRx.Unit> OnClickEmptyFUnitButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickHint { get; set; }
    public string HowToPlayManualKey { get; set; }
    public System.IObservable<UniRx.Unit> OnClickAutoSettingButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickSupportConfirmButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickStaminaUsage { get; set; }
    public System.IObservable<UniRx.Unit> OnClickStaminaRecover { get; set; }
    public System.IObservable<UniRx.Unit> OnClickNext { get; set; }
    public System.IObservable<UniRx.Unit> OnClickBack { get; set; }
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Adapters.ProduceConfirmViewModel viewModel, PRISM.SubSeasonDetailContentViewModel subSeasonDetailViewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public void SetPIdolFavoriteMark(int index, int favoriteId);
    public void SetScharaFavoriteMark(int index, int favoriteId);
    public Cysharp.Threading.Tasks.UniTask UpdateInheritanceUnitAsync(PRISM.Common.Model.FUnitIcon fUnitIcon);
    public void SetStaminaUsageText(int rateValue, bool isAlwaysMax);
    public void SetStartButtonStaminaText(int needSt);
    public void SetupStaminaView(PRISM.Stamina.StaminaModel model, int episodeSt, int staminaUsageValue);
    public void UpdateStaminaView(PRISM.Stamina.StaminaModel model, int episodeSt, int staminaUsageValue);
    public void DisposeStaminaView();
    public void UpdateConfirmMessage(int needSt);
    public Cysharp.Threading.Tasks.UniTask PlayADVAsync(string scenarioId, System.Threading.CancellationToken ct);
    public void Terminate();
    private void _setupEpisodeInfo(PRISM.Module.Networking.IEpisodeStatus data, ProduceDifficultyType selectDifficulty);
    private void _setupSubSeasonButtonStatus(PRISM.SubSeasonDetailContentViewModel subSeasonDetailViewModel);
    private void <SetupAsync>b__70_0(System.ValueTuple<int, UnityEngine.GameObject> _);
    private void <SetupAsync>b__70_1(System.ValueTuple<int, UnityEngine.GameObject> _);
    private void <SetupAsync>b__70_2(System.ValueTuple<int, UnityEngine.GameObject> _);
    private void <SetupAsync>b__70_3(System.ValueTuple<int, UnityEngine.GameObject> _);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<bool> <>9__80_0;
        private bool <PlayADVAsync>b__80_0();
    }

    private class <>c__DisplayClass70_0
    {
        public int id;
        public PRISM.Interactions.ProduceConfirmView <>4__this;
        private void <SetupAsync>b__4(System.ValueTuple<int, UnityEngine.GameObject> _);
        private void <SetupAsync>b__5(System.ValueTuple<int, UnityEngine.GameObject> _);
    }

    private class <>c__DisplayClass70_1
    {
        public int id;
        public PRISM.Interactions.ProduceConfirmView <>4__this;
        private void <SetupAsync>b__6(System.ValueTuple<int, UnityEngine.GameObject> _);
        private void <SetupAsync>b__7(System.ValueTuple<int, UnityEngine.GameObject> _);
    }

    private struct <PlayADVAsync>d__80 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ProduceConfirmView <>4__this;
        public string scenarioId;
        public System.Threading.CancellationToken ct;
        private PRISM.PlayScenarioController <controller>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <SetupAsync>d__70 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ProduceConfirmView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        public PRISM.Adapters.ProduceConfirmViewModel viewModel;
        public PRISM.SubSeasonDetailContentViewModel subSeasonDetailViewModel;
        private <>c__DisplayClass70_0 <>8__1;
        private <>c__DisplayClass70_1 <>8__2;
        private Awaiter<PRISM.IdolSelectFooterColorData> <>u__1;
        private int <i>5__2;
        private Awaiter <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class ProduceIdolSelectConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.ProduceIdolSelectArgument>, PRISM.IProduceIdolSelectConnector
{
    protected PRISM.Adapters.ProduceIdolSelectArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
}

// Namespace: PRISM.Interactions
public class ProduceIdolSelectView : UnityEngine.MonoBehaviour, PRISM.Adapters.IProduceIdolSelectView
{
    private PRISM.Produce.ViewProducePreparationIdolSelectView view;
    private PRISM.Interactions.ButtonView howToPlayButton;
    private UnityEngine.UI.Toggle indicatorOriginal;
    private UnityEngine.RectTransform statusOpenTarget;
    private ENTERPRISE.UI.ToggleButton statusToggle;
    private UnityEngine.UI.Image statusOpenIcon;
    private UnityEngine.UI.Image statusCloseIcon;
    private PRISM.Interactions.Produce.SwipeToggle swipeToggle;
    private PRISM.Interactions.ButtonView produceBonusButton;
    private UniRx.Subject<UniRx.Unit> onClickStatusToggleSubject;
    private bool isStatusOpen;
    private PRISM.ResourceManagement.IResourceLoader <ResourceLoader>k__BackingField;
    public PRISM.Produce.ViewProducePreparationIdolSelectView View { get; set; }
    public System.IObservable<UniRx.Unit> OnClickStatusToggle { get; set; }
    public PRISM.ResourceManagement.IResourceLoader ResourceLoader { get; set; }
    public System.IObservable<UniRx.Unit> OnClickProduceBonus { get; set; }
    public System.IObservable<UniRx.Unit> OnClickHowToPlay { get; set; }
    public void SetPageNum(int num);
    public void SetPageIndex(int index);
    public void Start();
    public void ToggleStatusOpenClose();
    public void SetActiveProduceBonusButton(bool isActive);
    public void Initialize(PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <Start>b__25_0();
    private void <Start>b__25_1(bool up);
}

// Namespace: PRISM.Interactions
public class OneScheduleSelectionContent : UnityEngine.MonoBehaviour
{
    private UnityEngine.GameObject futureImageObject;
    private UnityEngine.GameObject scheduleObject;
    private UnityEngine.UI.RawImage scheduleImage;
    private UnityEngine.GameObject scheduleLevelParentObject;
    private UnityEngine.GameObject scheduleLevelObject;
    private UnityEngine.UI.Image scheduleLevelImage;
    private UnityEngine.GameObject scheduleBonusLevelObject;
    private ENTERPRISE.UI.UITextMeshProUGUI scheduleLevelText;
    private ENTERPRISE.UI.UITextMeshProUGUI scheduleNameText;
    private UnityEngine.GameObject supportBonusImageObject;
    private UnityEngine.GameObject appearanceImageObject;
    private UnityEngine.GameObject recommendImageObject;
    private UnityEngine.GameObject supportCharacterAreaObject;
    private System.Collections.Generic.List<PRISM.SupportCharacterSDIconContent> supportCharacterSDIconContentList;
    private UnityEngine.GameObject challengeMissionObject;
    private UnityEngine.UI.RawImage challengeMissionIconImage;
    private UnityEngine.GameObject selectedScheduleImageObject;
    private UnityEngine.GameObject nonSelectedScheduleImageObject;
    private UnityEngine.GameObject coverImageObject;
    private UnityEngine.GameObject successCoverObject;
    private UnityEngine.GameObject failureCoverObject;
    private ENTERPRISE.UI.UIButton touchImageButton;
    private UnityEngine.UI.Image frameBlur;
    private UnityEngine.UI.Image bgGradation;
    private PRISM.Interactions.Produce.ProduceScheduleLevelColorData scheduleLevelColorData;
    private UniRx.Subject<ScheduleType> onTouchImage;
    public System.IObservable<ScheduleType> OnTouchImageObservable { get; set; }
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Module.Networking.IScheduleStatus schedule, bool isTargetWeek, PRISM.Module.Networking.IProduceTermStatus produceTerm, int index, System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask _levelDisplayAsync(ScheduleType scheduleType, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IScheduleDetailStatus> scheduleDetailList, System.Threading.CancellationToken ct, bool isFuture, bool isNow);
    private Cysharp.Threading.Tasks.UniTask _scheduleDisplayAsync(ScheduleType scheduleType, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IScheduleDetailStatus> scheduleDetailList, bool isTargetWeek, PRISM.Module.Networking.IProduceTermStatus produceTerm, PRISM.Module.Networking.IScheduleStatus schedule, int index, System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask _loadImageAsync(string path, UnityEngine.UI.RawImage uIImage, System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask _loadSpriteImageAsync(string path, UnityEngine.UI.Image uIImage, System.Threading.CancellationToken ct);
    private bool _isRecommend(System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IScheduleDetailStatus> scheduleDetailList, bool isTargetWeek, PRISM.Module.Networking.IProduceTermStatus produceTerm, PRISM.Module.Networking.IScheduleStatus schedule, int index);
    private bool _isMiniDrama(ScheduleType type);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Module.Networking.IScheduleDetailStatus, bool> <>9__30_0;
        public static System.Func<PRISM.Module.Networking.ISupportCharacterIconStatus, int> <>9__30_1;
        public static System.Func<System.Linq.IGrouping<int, PRISM.Module.Networking.ISupportCharacterIconStatus>, PRISM.Module.Networking.ISupportCharacterIconStatus> <>9__30_2;
        public static System.Func<PRISM.Module.Networking.ISupportCharacterIconStatus, bool> <>9__30_3;
        public static System.Func<PRISM.Module.Networking.IScheduleDetailStatus, bool> <>9__30_4;
        public static System.Func<PRISM.Module.Networking.IScheduleDetailStatus, bool> <>9__33_0;
        private bool <_scheduleDisplayAsync>b__30_0(PRISM.Module.Networking.IScheduleDetailStatus detail);
        private int <_scheduleDisplayAsync>b__30_1(PRISM.Module.Networking.ISupportCharacterIconStatus p);
        private PRISM.Module.Networking.ISupportCharacterIconStatus <_scheduleDisplayAsync>b__30_2(System.Linq.IGrouping<int, PRISM.Module.Networking.ISupportCharacterIconStatus> group);
        private bool <_scheduleDisplayAsync>b__30_3(PRISM.Module.Networking.ISupportCharacterIconStatus x);
        private bool <_scheduleDisplayAsync>b__30_4(PRISM.Module.Networking.IScheduleDetailStatus challenge);
        private bool <_isRecommend>b__33_0(PRISM.Module.Networking.IScheduleDetailStatus data);
    }

    private class <>c__DisplayClass28_0
    {
        public PRISM.Interactions.OneScheduleSelectionContent <>4__this;
        public PRISM.Module.Networking.IScheduleStatus schedule;
        private void <SetupAsync>b__0();
    }

    private struct <SetupAsync>d__28 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.OneScheduleSelectionContent <>4__this;
        public PRISM.Module.Networking.IScheduleStatus schedule;
        public bool isTargetWeek;
        public System.Threading.CancellationToken ct;
        private <>c__DisplayClass28_0 <>8__1;
        public PRISM.Module.Networking.IProduceTermStatus produceTerm;
        public int index;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_levelDisplayAsync>d__29 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public ScheduleType scheduleType;
        public System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IScheduleDetailStatus> scheduleDetailList;
        public PRISM.Interactions.OneScheduleSelectionContent <>4__this;
        public bool isFuture;
        public System.Threading.CancellationToken ct;
        private int <currentScheduleLevel>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_loadSpriteImageAsync>d__32 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public UnityEngine.UI.Image uIImage;
        public string path;
        public System.Threading.CancellationToken ct;
        private UnityEngine.UI.Image <>7__wrap1;
        private Awaiter<UnityEngine.Sprite> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_scheduleDisplayAsync>d__30 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.OneScheduleSelectionContent <>4__this;
        public PRISM.Module.Networking.IScheduleStatus schedule;
        public System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IScheduleDetailStatus> scheduleDetailList;
        public bool isTargetWeek;
        public PRISM.Module.Networking.IProduceTermStatus produceTerm;
        public int index;
        public System.Threading.CancellationToken ct;
        public ScheduleType scheduleType;
        private System.Collections.Generic.List<PRISM.Module.Networking.ISupportCharacterIconStatus> <supportCharacterIconStatusDtoList>5__2;
        private PRISM.Module.Networking.IScheduleDetailStatus <challengeMission>5__3;
        private int <i>5__4;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class OneWeekScheduleSelectionContent : UnityEngine.MonoBehaviour
{
    private PRISM.WeekDisplayContent weekDisplayContent;
    private System.Collections.Generic.List<PRISM.Interactions.OneScheduleSelectionContent> oneScheduleSelectionContentList;
    private UniRx.Subject<System.ValueTuple<ScheduleType, int>> onTouchSchedule;
    private UniRx.CompositeDisposable disposables;
    public System.IObservable<System.ValueTuple<ScheduleType, int>> OnTouchImageObservable { get; set; }
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Module.Networking.IWeekScheduleStatus weekSchedule, PRISM.Module.Networking.IProduceTermStatus produceTerm, int index, PRISM.Module.Networking.ISubSeasonStatus subSeason);
    public void OnDisable();

    private class <>c__DisplayClass6_0
    {
        public PRISM.Interactions.OneWeekScheduleSelectionContent <>4__this;
        public int loopMax;
        private void <SetupAsync>b__0(ScheduleType type);
    }

    private class <>c__DisplayClass6_1
    {
        public int targetIndex;
        public <>c__DisplayClass6_0 CS$<>8__locals1;
        private void <SetupAsync>b__1(ScheduleType type);
    }

    private struct <SetupAsync>d__6 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.OneWeekScheduleSelectionContent <>4__this;
        public int index;
        public PRISM.Module.Networking.IProduceTermStatus produceTerm;
        public PRISM.Module.Networking.ISubSeasonStatus subSeason;
        public PRISM.Module.Networking.IWeekScheduleStatus weekSchedule;
        private <>c__DisplayClass6_0 <>8__1;
        private <>c__DisplayClass6_1 <>8__2;
        private System.Collections.Generic.List<PRISM.Module.Networking.IScheduleStatus> <scheduleList>5__2;
        private int <scheduleCount>5__3;
        private Awaiter <>u__1;
        private int <i>5__4;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class ProduceScheduleResultContent : UnityEngine.MonoBehaviour, PRISM.Adapters.IProduceScheduleResultContent
{
    private PRISM.Produce.ScheduleInfoContent scheduleInfoContent;
    private PRISM.Produce.MiniCharacterActionContent miniCharaContent;
    private PRISM.Produce.ParameterVariationContent parameterVariationContent;
    private PRISM.Interactions.ScheduleVitalityGauge vitalityGauge;
    private PRISM.Adapters.ProduceScheduleResultContentViewModel viewModel;
    public void Terminate();
    public Cysharp.Threading.Tasks.UniTask ShowAsync(PRISM.Adapters.ProduceScheduleResultContentViewModel vm, System.Threading.CancellationToken ct);
    private void Awake();
    private Cysharp.Threading.Tasks.UniTask _playAsync(System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask _playVitalityGaugeAsync(PRISM.Module.Networking.IVitalityVariationStatus vitalityStatus, PRISM.Module.Networking.IVitalityStatus vitality, System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask _playMiniCharaContentAsync(bool isTrouble, bool isSupportBonus, System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask _playParameterContentAsync(int unitId, int idolCount, PRISM.Module.Networking.IParameterVariationStatus parameterData, System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask _playFanVariationAsync(PRISM.Module.Networking.IFanVariationStatus fanData, System.Threading.CancellationToken ct);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<bool> <>9__8_0;
        public static System.Func<bool> <>9__8_3;
        public static System.Func<bool> <>9__8_1;
        public static System.Func<bool> <>9__8_2;
        private bool <_playAsync>b__8_0();
        private bool <_playAsync>b__8_3();
        private bool <_playAsync>b__8_1();
        private bool <_playAsync>b__8_2();
    }

    private struct <_playAsync>d__8 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ProduceScheduleResultContent <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private Awaiter<int> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class ParameterAreaPlusMemberContent : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI memberAmountText;
    private PRISM.ScheduleParameterContent scheduleParameterContent;
    private System.Collections.Generic.List<PRISM.Interactions.ScheduleRewardContent> scheduleRewardContentList;
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Module.Networking.IScheduleDetailStatus scheduleDetail, PRISM.Module.Networking.IProduceBaseInfoStatus produceBaseInfo, PRISM.ResourceManagement.IResourceLoader loader);

    private struct <SetupAsync>d__3 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ParameterAreaPlusMemberContent <>4__this;
        public PRISM.Module.Networking.IProduceBaseInfoStatus produceBaseInfo;
        public PRISM.Module.Networking.IScheduleDetailStatus scheduleDetail;
        public PRISM.ResourceManagement.IResourceLoader loader;
        private System.Collections.Generic.List<PRISM.Module.Networking.IScheduleRewardStatus> <rewardList>5__2;
        private Awaiter <>u__1;
        private int <i>5__3;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class ProducePolicyConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.ProducePolicyArgument>, PRISM.Scenario.PlayableADV, PRISM.IProducePolicyConnector
{
    private PRISM.Interactions.Adv.AdvScreenView advUI;
    private bool <IsAlreadyDisplayedHowToPlay>k__BackingField;
    public bool IsAlreadyDisplayedHowToPlay { get; set; }
    public void ActivateWholeButton();
    public void DisactivateWholeButton();
    public PRISM.Legacy.Adv.IAdvScreenPresenterForLegacy CreateAdvScreenPresenter(PRISM.Adv.AdvScreenViewModel viewModel, PRISM.Scenario.ScenarioManager scenarioManager);
    protected PRISM.Adapters.ProducePolicyArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
    protected Cysharp.Threading.Tasks.UniTask _onBeginIdleAsync();
    private Cysharp.Threading.Tasks.UniTask <>n__0();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<bool> <>9__10_0;
        private bool <_onBeginIdleAsync>b__10_0();
    }

    private struct <_onBeginIdleAsync>d__10 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ProducePolicyConnector <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_playBgmAsync>d__9 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ProducePolicyConnector <>4__this;
        private System.Threading.CancellationToken <ct>5__2;
        private Awaiter <>u__1;
        private Awaiter<CriWare.CriAtomExPlayback> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class ProducePolicyView : UnityEngine.MonoBehaviour, PRISM.Adapters.IProducePolicyView
{
    private PRISM.Interactions.CommonTitleView titleView;
    private System.Collections.Generic.List<ENTERPRISE.UI.UIButton> onClickPolicyDecideButtonList;
    private System.Collections.Generic.List<PRISM.Produce.OneSchedulePolicyContent> producePolicyChoiceContentList;
    private UnityEngine.GameObject producePolicyListObject;
    private PRISM.Produce.ProducePolicyDetailContent producePolicyDetailContentComponent;
    private UnityEngine.GameObject producePolicyDetailObject;
    private UnityEngine.Animator cutinAnimator;
    private UnityEngine.UI.RawImage seasonNoImage;
    private UnityEngine.RectTransform safeAreaRoot;
    private PRISM.Interactions.ScheduleVitalityGauge vitalityGauge;
    private UnityEngine.GameObject titleGameObject;
    private PRISM.Interactions.ProducePolicyConnector producePolicyConnector;
    private PRISM.Interactions.ScreenTapSkipAnimationPlayer screenTapSkipAnimationPlayer;
    private UnityEngine.GameObject[] bdgRecommend;
    private PRISM.Interactions.Produce.Model3dLoaderForProduceAdv model3dLoader;
    private System.Threading.CancellationToken ct;
    private System.Action onDecideButton;
    private PRISM.Scenario.ScenarioManager scenarioManager;
    private System.IDisposable disposable;
    private System.IDisposable backKeyDisposable;
    public PRISM.Adapters.Produce.IModel3dLoaderForProduceAdv Model3dLoader { get; set; }
    public void Initialize();
    public System.Collections.Generic.List<PRISM.Produce.OneSchedulePolicyContent> GetOneSchedulePolicyContentList();
    public Cysharp.Threading.Tasks.UniTask LoadSeasonNoAsync(int id);
    public void ActivateCutinAnimation(bool isEnable);
    public UnityEngine.Animator GetCutinAnimator();
    public UnityEngine.RectTransform GetSafeAreaRoot();
    public UnityEngine.MonoBehaviour GetMonoBehaviour();
    public PRISM.Adapters.IScheduleVitalityGauge GetVitalityGauge();
    public void DisplayDetail(int buttonIndex, PRISM.Module.Networking.IProduceStrategyStatus produceStrategyStatus);
    public Cysharp.Threading.Tasks.UniTask ControllUIAsync(System.Collections.Generic.List<PRISM.Module.Networking.IProduceStrategyStatus> strategyList, System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask _displayHowToPlayPUAsync(System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask _setupSchedulePolicyContentListAsync(System.Collections.Generic.List<PRISM.Module.Networking.IProduceStrategyStatus> produceStrategieList, System.Threading.CancellationToken ct);
    private void _onSetEnableProducePolicyListObject(bool isActive);
    private void _onClickDetailCancel();
    private void _onClickDetailDecide();
    public void DecideCallbackAction(System.Action onStartScenario);
    public void InActivateTitleView();
    public Cysharp.Threading.Tasks.UniTask WaitSeasonCutInAsync(System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask OnDestroy();
    private void <DisplayDetail>b__30_0(UniRx.Unit _);
    private bool <_displayHowToPlayPUAsync>b__32_0();
    private Cysharp.Threading.Tasks.UniTask <WaitSeasonCutInAsync>b__39_0(System.Threading.CancellationToken cancellationToken);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<bool> <>9__31_0;
        private bool <ControllUIAsync>b__31_0();
    }

    private struct <ControllUIAsync>d__31 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ProducePolicyView <>4__this;
        public System.Threading.CancellationToken ct;
        public System.Collections.Generic.List<PRISM.Module.Networking.IProduceStrategyStatus> strategyList;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <LoadSeasonNoAsync>d__24 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public int id;
        public PRISM.Interactions.ProducePolicyView <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <OnDestroy>d__40 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ProducePolicyView <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_setupSchedulePolicyContentListAsync>d__33 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ProducePolicyView <>4__this;
        public System.Collections.Generic.List<PRISM.Module.Networking.IProduceStrategyStatus> produceStrategieList;
        public System.Threading.CancellationToken ct;
        private int <i>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class ScheduleDetailContent : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI titleText;
    private UnityEngine.GameObject appearanceImageObject;
    private PRISM.ScheduleDetailTabGroupContent scheduleDetailTabGroupContent;
    private PRISM.Interactions.ParameterAreaPlusMemberContent parameterAreaPlusMemberContent;
    private PRISM.ScheduleDetailImageContent scheduleDetailImageContent;
    private PRISM.ScheduleDetailTextContent scheduleDetailTextContent;
    private UnityEngine.GameObject challengeMissionObject;
    private PRISM.ScheduleChallengeMissionContent ScheduleChallengeMissionContent;
    private PRISM.ScheduleParameterContent scheduleParameterContent;
    private PRISM.Interactions.ScheduleTroubleContent scheduleTroubleContent;
    private PRISM.Interactions.ScheduleVitalityGauge scheduleVitalityGauge;
    private ENTERPRISE.UI.UIButton cancelButton;
    private ENTERPRISE.UI.UIButton executeButton;
    private UnityEngine.GameObject blackCoverObject;
    private UnityEngine.CanvasGroup canvasGroup;
    private UnityEngine.GameObject alertTextObject;
    private PRISM.Module.Networking.IScheduleStatus cacheSchedule;
    private PRISM.Module.Networking.IProduceBaseInfoStatus cacheProduceBaseInfo;
    private PRISM.Module.Networking.IScheduleDetailStatus scheduleDetail;
    private PRISM.Module.Networking.IScheduleStatus schedule;
    private UniRx.Subject<UniRx.Unit> cacheOnClickCancel;
    private UniRx.Subject<PRISM.Module.Networking.IScheduleDetailStatus> cacheOnClickExecute;
    private bool isInitialized;
    public bool IsInitialized { get; set; }
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Module.Networking.IScheduleStatus schedule, PRISM.Module.Networking.IProduceBaseInfoStatus produceBaseInfo, UniRx.Subject<UniRx.Unit> onClickDetailScheduleCancel, UniRx.Subject<PRISM.Module.Networking.IScheduleDetailStatus> onClickDetailScheduleExecute, System.Action action, System.Action loadEnd, PRISM.ResourceManagement.IResourceLoader loader);
    private void Awake();
    private void Start();
    private Cysharp.Threading.Tasks.UniTask _displayData(int index, PRISM.ResourceManagement.IResourceLoader loader);
    private TabButtonDisplay _isDisplayTabButton(ScheduleType scheduleType);
    private void _activateCanvasGroup(bool isActive);
    private void <Start>b__28_0();
    private void <Start>b__28_1();
    private bool <_displayData>b__29_0(PRISM.Module.Networking.IInProduceIdolStatus unit);

    private class TabButtonDisplay
    {
        public bool IsDisplay;
        public string DisplayText;
    }

    private class <>c__DisplayClass26_0
    {
        public PRISM.Interactions.ScheduleDetailContent <>4__this;
        public PRISM.ResourceManagement.IResourceLoader loader;
        private Cysharp.Threading.Tasks.UniTaskVoid <SetupAsync>b__0(int selectIndex);

        private struct <<SetupAsync>b__0>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
        {
            public int <>1__state;
            public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
            public <>c__DisplayClass26_0 <>4__this;
            public int selectIndex;
            private Awaiter <>u__1;
            private void MoveNext();
            private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }

    private struct <SetupAsync>d__26 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ScheduleDetailContent <>4__this;
        public PRISM.ResourceManagement.IResourceLoader loader;
        public UniRx.Subject<UniRx.Unit> onClickDetailScheduleCancel;
        public UniRx.Subject<PRISM.Module.Networking.IScheduleDetailStatus> onClickDetailScheduleExecute;
        public PRISM.Module.Networking.IScheduleStatus schedule;
        public PRISM.Module.Networking.IProduceBaseInfoStatus produceBaseInfo;
        private <>c__DisplayClass26_0 <>8__1;
        public System.Action action;
        public System.Action loadEnd;
        private TabButtonDisplay <tabButtonState>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_displayData>d__29 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ScheduleDetailContent <>4__this;
        public int index;
        public PRISM.ResourceManagement.IResourceLoader loader;
        private bool <isVisible>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class ScheduleRewardContent : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.RawImage rewardImage;
    private ENTERPRISE.UI.UITextMeshProUGUI rewardText;
    private UnityEngine.GameObject HorizontalPartitionImageObject;
    private UnityEngine.GameObject emptyImageObject;
    private UnityEngine.GameObject specifiedObject;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Module.Networking.IScheduleRewardStatus scheduleReward, int unitId, bool IsCardRewardAffectedByPassiveEffect, PRISM.ResourceManagement.IResourceLoader loader);
    private Cysharp.Threading.Tasks.UniTask _loadImageAsync(string path, UnityEngine.UI.RawImage uIImage);
    private bool _isCardReward(PRISM.Module.Networking.IScheduleRewardStatus scheduleReward);

    private struct <SetupAsync>d__6 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ScheduleRewardContent <>4__this;
        public PRISM.ResourceManagement.IResourceLoader loader;
        public PRISM.Module.Networking.IScheduleRewardStatus scheduleReward;
        public int unitId;
        public bool IsCardRewardAffectedByPassiveEffect;
        private bool <isNull>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class ScheduleSelectionConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.ScheduleSelectionArgument>, PRISM.Scenario.PlayableADV, PRISM.IScheduleSelectionConnector
{
    private PRISM.Interactions.Adv.AdvScreenView advUI;
    private UnityEngine.GameObject touchAreaPanel;
    protected PRISM.Adapters.ScheduleSelectionArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
    protected Cysharp.Threading.Tasks.UniTask _beginViewAsync();
    public PRISM.Legacy.Adv.IAdvScreenPresenterForLegacy CreateAdvScreenPresenter(PRISM.Adv.AdvScreenViewModel viewModel, PRISM.Scenario.ScenarioManager scenarioManager);
    public void DisactivateWholeButton();
    public void ActivateWholeButton();
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
    private Cysharp.Threading.Tasks.UniTask <>n__0();

    private struct <_beginViewAsync>d__3 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ScheduleSelectionConnector <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_playBgmAsync>d__7 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ScheduleSelectionConnector <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class ScheduleSelectionListCarouselCell : PRISM.CarouselCell<PRISM.Interactions.ScheduleSelectionListCarouselCellData, PRISM.DefaultCarouselContext>
{
    private UnityEngine.RectTransform rect;
    private PRISM.Interactions.ScheduleDetailContent scheduleDetailContent;
    private UnityEngine.Animator animator;
    private UnityEngine.Canvas orderControllCanvas;
    private UnityEngine.UI.GraphicRaycaster graphicRaycaster;
    private ENTERPRISE.UI.UIButton rightMoveButton;
    private ENTERPRISE.UI.UIButton leftMoveButton;
    private UniRx.Subject<bool> cacheSubject;
    private UniRx.Subject<bool> cacheIsAuditionSubject;
    private bool isAudition;
    public void UpdateContent(PRISM.Interactions.ScheduleSelectionListCarouselCellData itemData);
    public void UpdatePosition(float position);
    private void _activateSideButton();

    private class <>c__DisplayClass10_0
    {
        public PRISM.Interactions.ScheduleSelectionListCarouselCell <>4__this;
        public PRISM.Interactions.ScheduleSelectionListCarouselCellData itemData;
        private void <UpdateContent>b__0(bool isActive);
        private void <UpdateContent>b__1(bool boolValue);
        private void <UpdateContent>b__2();
        private void <UpdateContent>b__3();
    }
}

// Namespace: PRISM.Interactions
public class ScheduleSelectionListCarouselCellData
{
    public PRISM.Module.Networking.IScheduleStatus ScheduleStatus;
    public PRISM.Adapters.ScheduleSelectionScheduleDetailViewModel ScheduleSelectionScheduleDetailViewModel;
    public UniRx.Subject<UniRx.Unit> OnCancel;
    public UniRx.Subject<PRISM.Module.Networking.IScheduleDetailStatus> OnExecute;
    public UniRx.Subject<bool> OnActiveCanvasGroup;
    public UniRx.Subject<UniRx.Unit> OnClickRightArrow;
    public UniRx.Subject<UniRx.Unit> OnClickLeftArrow;
    public UniRx.Subject<PRISM.Interactions.ScheduleDetailContent> OnSetupDetailContent;
    public System.Action OnEndLoad;
    public UniRx.Subject<bool> OnNotifyAudition;
    public bool IsAudition;
}

// Namespace: PRISM.Interactions
public class ScheduleSelectionView : UnityEngine.MonoBehaviour, PRISM.Adapters.IScheduleSelectionView
{
    private PRISM.Interactions.Adv.AdvScreenView advView;
    private PRISM.Interactions.CommonTitleView titleView;
    private PRISM.Interactions.ScheduleSelectionUnitIdolView unitidolView;
    private PRISM.Interactions.ScheduleSelectionLeftBottomAreaView leftBottomAreaView;
    private PRISM.Interactions.ScheduleSelectionLeftWeekView leftWeekView;
    private PRISM.Interactions.Produce.ScheduleSelectionScheduleCarouselView scheduleCarouselView;
    private PRISM.Interactions.ScheduleSelectionScheduleDetailView scheduleDetailView;
    private PRISM.Interactions.ButtonView subSeasonButton;
    private UnityEngine.GameObject subSeasonCheckOn;
    private UnityEngine.GameObject subSeasonCheckOff;
    private PRISM.Interactions.ButtonView ingameTutorialButton;
    private PRISM.Interactions.ButtonView hamburgerButton;
    private PRISM.Interactions.ButtonView produceBonusButton;
    private UnityEngine.GameObject hamburgerButtonObject;
    private UnityEngine.GameObject blackBackObject;
    private UnityEngine.RectTransform safeAreaRoot;
    private UnityEngine.RectTransform bgArea;
    private UnityEngine.RectTransform leftArea;
    private UnityEngine.RectTransform leftArea2;
    private UnityEngine.RectTransform rightCentralArea;
    private UnityEngine.RectTransform rightTopUIArea;
    private UnityEngine.GameObject normalBgObject;
    private UnityEngine.UI.Image normalBgBaseImage;
    private UnityEngine.UI.Image normalBgUnitLogoImage;
    private UnityEngine.UI.RawImage subSeasonBgRawImage;
    private ENTERPRISE.UI.UIButton touchFrontPanelButton;
    private UnityEngine.UI.RawImage touchFrontPanelImage;
    private UnityEngine.GameObject miniCharacterActionObject;
    private PRISM.Produce.ScheduleInfoContent scheduleInfoContent;
    private PRISM.Produce.ParameterVariationContent parameterVariationContent;
    private PRISM.Produce.MiniCharacterActionContent miniCharacterActionContent;
    private PRISM.Produce.ScheduleLevelUpContent scheduleLevelUpActionContent;
    private UnityEngine.GameObject scheduleLevelUpActionObject;
    private UnityEngine.GameObject expansionParameterContentObject;
    private UnityEngine.GameObject scheduleDisplayInActionObject;
    private UnityEngine.GameObject fanAreaObject;
    private UnityEngine.GameObject leftParamObject;
    private PRISM.Interactions.CommonTitleView commonTitleView;
    private PRISM.Interactions.ScheduleVitalityGauge executeScheduleVitalityGauge;
    private UnityEngine.RectTransform blockArea;
    private PRISM.Produce.TutorialData tutorialDataObject;
    protected string[] configRefKeys;
    private PRISM.Produce.SupportEffectDemonstrateUIContent supportEffectDemonstrateUIContent;
    private PRISM.Interactions.ProduceScheduleResultContent produceScheduleResultOverlayView;
    private PRISM.ITutorialSequence[] scheduleSelectTutorialSequences;
    private string howToPlayManualKey;
    private UnityEngine.Animator appearanceUIAnimator;
    private ENTERPRISE.UI.UITextMeshProUGUI appearanceText;
    private PRISM.Interactions.Produce.ProduceBonusNoticeContent produceBonusNoticeView;
    private PRISM.Produce.HowToPlayProduceManualData howToPlayProduceManualData;
    private System.Action<bool> onRingVoiceActivate;
    private System.IDisposable backKeyDisposable;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    public PRISM.Adapters.Adv.IAdvScreenView AdvView { get; set; }
    public PRISM.Adapters.IScheduleSelectionUnitIdolView UnitIdolView { get; set; }
    public PRISM.Adapters.IScheduleSelectionLeftBottomAreaView LeftBottomAreaView { get; set; }
    public PRISM.Adapters.IScheduleSelectionLeftWeekView LeftWeekView { get; set; }
    public PRISM.Adapters.Produce.IScheduleSelectionScheduleCarouselView ScheduleCarouselView { get; set; }
    public PRISM.Adapters.IScheduleSelectionScheduleDetailView ScheduleDetailView { get; set; }
    public PRISM.Adapters.IProduceScheduleResultContent ScheduleResultContentView { get; set; }
    public System.IObservable<UniRx.Unit> OnClickHamburgerButtonObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnClickIngameTutorialButtonObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnClickProduceBonusButtonObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnClickSubseasonButtonObservable { get; set; }
    public void SetButtonDisplay(bool isActive, bool isClearSubseasonCondition);
    public void SetBlackDisplay(bool isActive);
    public void SetActiveButtonDisplay(bool isActive);
    public UnityEngine.RectTransform GetSafeAreaRoot();
    public UnityEngine.RectTransform GetBgRoot();
    public UnityEngine.RectTransform GetLeftAreaRoot();
    public UnityEngine.RectTransform GetLeftArea2Root();
    public UnityEngine.RectTransform GetRightCentralArea();
    public UnityEngine.RectTransform GetRightTopUIArea();
    public ENTERPRISE.UI.UIButton GetTouchFrontPanelButton();
    public UnityEngine.UI.RawImage GetTouchFrontPanelImage();
    public UnityEngine.GameObject GetMiniCharacterActionObject();
    public PRISM.Produce.ScheduleInfoContent ScheduleInfoContent();
    public PRISM.Produce.ParameterVariationContent ParameterVariationContent();
    public PRISM.Produce.MiniCharacterActionContent MiniCharacterActionContent();
    public void UpdateMiniCharacterActionObject(bool isActive);
    public void DefaultParameterDisplay(PRISM.Module.Networking.IProduceParameterStatus produceParameter);
    public void SetBoolMinichacterAnimator(string animatorName, bool isPlay);
    public void SetMinichacterAnimatorEnabled(bool isEnabled);
    public Cysharp.Threading.Tasks.UniTask PlayResultAnimation(bool isTroubled, bool isSupportBonus);
    public PRISM.Interactions.ScheduleSelectionUnitIdolView GetUnitidolView();
    public PRISM.Interactions.ScheduleSelectionLeftBottomAreaView GetLeftBottomAreaView();
    public PRISM.Interactions.ScheduleSelectionLeftWeekView GetLeftWeekView();
    public UnityEngine.GameObject GetLeftParamObject();
    public UnityEngine.GameObject GetFanAreaObject();
    public PRISM.Adapters.ICommonTitleView GetCommonTitleView();
    public PRISM.Adapters.IScheduleVitalityGauge GetExecuteScheduleVitalityGauge();
    public PRISM.Produce.ScheduleLevelUpContent GetScheduleLevelUpActionContent();
    public UnityEngine.GameObject GetScheduleLevelUpActionObject();
    public UnityEngine.GameObject GetExpansionParameterContentObject();
    public UnityEngine.GameObject GetScheduleDisplayInActionObject();
    public PRISM.Produce.SupportEffectDemonstrateUIContent GetSupportEffectDemonstrateUI();
    public void DisplayIngameTutorialPopup(System.Action<bool> ringVoiceActivate, int unitId);
    public Cysharp.Threading.Tasks.UniTask DisplayAdditionalHowToPlayPopupAsync(int keyIndex);
    public void SetMiniTitleText(int mstSubSeasonId);
    public Cysharp.Threading.Tasks.UniTask SetBackgroundImageAsync(bool isSubSeason, string bgImageKey, int unitId);
    public void SetActiveTargetArea(UnityEngine.RectTransform rectTransform, bool isActive);
    public void SetActiveBlockArea(bool isActive);
    public PRISM.ITutorialSequence GetScheduleSelectTutorialSequence(int week);
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public Cysharp.Threading.Tasks.UniTask PlayAppearanceEffectAsync(System.Collections.Generic.IReadOnlyList<System.ValueTuple<int, ScheduleType>> appearanceList);
    public Cysharp.Threading.Tasks.UniTask PlayUnitInfoVitalityAnimationAsync(PRISM.Module.Networking.IVitalityVariationStatus vitalityVariation, int currentVitality, int maxVitality, bool isIncrease, System.Threading.CancellationToken ct);
    public void Set3DColor(UnityEngine.Color color);
    public void SetActiveProduceBonusButton(bool isActive);
    public void ShowProduceBonusNotice(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.ProduceBonusNoticeViewModel> list);
    public void ValidateBackKey();
    public void InvalidateBackKey();
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <DisplayIngameTutorialPopup>b__107_0();

    private struct <InitializeAsync>d__114 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ScheduleSelectionView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private Awaiter<PRISM.Produce.HowToPlayProduceManualData> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <PlayAppearanceEffectAsync>d__115 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public System.Collections.Generic.IReadOnlyList<System.ValueTuple<int, ScheduleType>> appearanceList;
        public PRISM.Interactions.ScheduleSelectionView <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <SetBackgroundImageAsync>d__110 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ScheduleSelectionView <>4__this;
        public bool isSubSeason;
        public string bgImageKey;
        public int unitId;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class ScheduleTroubleContent : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.RawImage troubleColorImage;
    private ENTERPRISE.UI.UITextMeshProUGUI troubleText;
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Module.Networking.IScheduleDetailStatus scheduleDetail);
    public bool IsDisplayTrouble(ScheduleDetailType scheduleDetailType);
    private Cysharp.Threading.Tasks.UniTask _loadImageAsync(int trouble);
    private int _getTroubleColorIndex(int trouble);

    private struct <SetupAsync>d__2 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ScheduleTroubleContent <>4__this;
        public PRISM.Module.Networking.IScheduleDetailStatus scheduleDetail;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class ScheduleVitalityGauge : UnityEngine.MonoBehaviour, PRISM.Adapters.IScheduleVitalityGauge, PRISM.Legacy.IScheduleVitalityGaugeForLegacy
{
    private UnityEngine.UI.Image backVitalityGauge;
    private UnityEngine.UI.Image frontVitalityGauge;
    private UnityEngine.UI.Image frontFlickerVitalityGauge;
    private ENTERPRISE.UI.UITextMeshProUGUI vitalityFrom;
    private ENTERPRISE.UI.UITextMeshProUGUI vitalityTo;
    private UnityEngine.GameObject fromObject;
    private UnityEngine.Animator gaugeChangeAnimator;
    private ENTERPRISE.UI.AnimatorWithEvent animatorEvent;
    private DG.Tweening.Tweener colorFadeTweener;
    private static int SeChangeLimit;
    private static string SeBigCrease;
    private static string SeLittleCrease;
    private static string SeBigDecrease;
    private static string SeLittleDecrease;
    private static string EmptyState;
    private static string IdleState;
    private static string Decrease1State;
    private static string Decrease2State;
    private static string Increase1State;
    private static string Increase2State;
    private static string Increase3State;
    private static string StartState;
    private static string EndState;
    private string cacheCueName;
    private System.Action cacheEndAnimation;
    private bool cacheIsCrease;
    private bool isEnd;
    private float currentAmount;
    private float estimateAmount;
    private CriWare.CriAtomExPlayback sePlayback;
    public void UpdateDisplayOnSchedule(int current, int max);
    public void UpdateDisplay(PRISM.Module.Networking.IScheduleDetailStatus scheduleDetail, PRISM.Module.Networking.IProduceBaseInfoStatus cacheProduceBaseInfo);
    public Cysharp.Threading.Tasks.UniTask GaugeAnimationDisplayAsync(int current, int changeValue, int max, bool isCrease, float delay, bool isIdle, System.Action endTween, System.Threading.CancellationToken ct);
    public void DefaultDisplay(PRISM.Module.Networking.IProduceBaseInfoStatus cacheProduceBaseInfo);
    private bool _isRecovery(PRISM.Module.Networking.IScheduleDetailStatus scheduleDetail);
    private int _calcVitalityValue(PRISM.Module.Networking.IScheduleDetailStatus scheduleDetail, PRISM.Module.Networking.IProduceBaseInfoStatus cacheProduceBaseInfo);
    public void SetActive(bool isActive);
    private System.ValueTuple<string, string> _getPlaySeAndAnimator(int current, int changeValue, int max, bool isCrease, bool isIdle);
    private void Start();
    private void OnDisable();
    private bool <GaugeAnimationDisplayAsync>b__32_0();
    private void <Start>b__38_0(string tag);
    private float <Start>b__38_1();
    private void <Start>b__38_2(float x);
    private float <Start>b__38_3();
    private void <Start>b__38_4(float x);
    private float <Start>b__38_5();
    private void <Start>b__38_6(float x);

    private struct <GaugeAnimationDisplayAsync>d__32 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ScheduleVitalityGauge <>4__this;
        public int current;
        public int changeValue;
        public int max;
        public bool isCrease;
        public bool isIdle;
        public float delay;
        public System.Threading.CancellationToken ct;
        public System.Action endTween;
        private string <playCueName>5__2;
        private string <playAnimator>5__3;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class UnitIdolContent : UnityEngine.MonoBehaviour, PRISM.Adapters.IUnitIdolContent
{
    private UnityEngine.RectTransform anchorRect;
    private PRISM.UI.IdolSkillIconView idolSkillIconView;
    private UnityEngine.UI.Image BgImage;
    private static float VitalityLimit;
    private static int VoiceMaxOnNormal;
    private static int VoiceMaxOnDamage;
    private PRISM.Module.Networking.IInProduceIdolStatus cacheInProduceIdol;
    private PRISM.Module.Networking.IProduceIdolStatus cacheProduceIdol;
    private PRISM.Module.Networking.IProduceUnitStatus cacheProduceUnit;
    private bool isDamagedVoisePlayed;
    private bool isDamaged;
    private System.Collections.Generic.List<string> voiceSheetList;
    private System.Collections.Generic.List<string> voiceCueList;
    private int beforeIndex;
    private int randomIndex;
    private System.Action<bool> onRingIdolVoiceActivate;
    private UniRx.Subject<System.ValueTuple<PRISM.Module.Networking.IProduceIdolStatus, PRISM.Module.Networking.IInProduceIdolStatus>> onLongClickIdol;
    public System.IObservable<System.ValueTuple<PRISM.Module.Networking.IProduceIdolStatus, PRISM.Module.Networking.IInProduceIdolStatus>> OnLongClickIdol { get; set; }
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Module.Networking.IInProduceIdolStatus inProduceIdol, int unitId, PRISM.Module.Networking.IProduceIdolStatus produceIdol, PRISM.Module.Networking.IProduceUnitStatus produceUnit, System.Action<bool> ringIdolVoiceActivate);
    private Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> _loadPrefabAsync(int id);
    public Cysharp.Threading.Tasks.UniTask RingIdolVoiceAsync(System.Threading.CancellationToken ct);

    private class <>c__DisplayClass19_0
    {
        public PRISM.Module.Networking.IInProduceIdolStatus inProduceIdol;
        public PRISM.Interactions.UnitIdolContent <>4__this;
        public PRISM.ProduceIdolModel idol;
        private bool <SetupAsync>b__0(PRISM.ProduceIdolModel idolData);
        private void <SetupAsync>b__1();
    }

    private struct <RingIdolVoiceAsync>d__21 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public System.Threading.CancellationToken ct;
        public PRISM.Interactions.UnitIdolContent <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <SetupAsync>d__19 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Module.Networking.IInProduceIdolStatus inProduceIdol;
        public PRISM.Interactions.UnitIdolContent <>4__this;
        public System.Action<bool> ringIdolVoiceActivate;
        public PRISM.Module.Networking.IProduceIdolStatus produceIdol;
        public PRISM.Module.Networking.IProduceUnitStatus produceUnit;
        public int unitId;
        private <>c__DisplayClass19_0 <>8__1;
        private int <i>5__2;
        private Awaiter <>u__1;
        private Awaiter<UnityEngine.GameObject> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_loadPrefabAsync>d__20 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<UnityEngine.GameObject> <>t__builder;
        public int id;
        public PRISM.Interactions.UnitIdolContent <>4__this;
        private Awaiter<UnityEngine.GameObject> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class UnitParameterContent : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.RawImage VocalRankTextImage;
    private ENTERPRISE.UI.UITextMeshProUGUI VocalValueText;
    private UnityEngine.UI.RawImage DanceRankTextImage;
    private ENTERPRISE.UI.UITextMeshProUGUI DanceValueText;
    private UnityEngine.UI.RawImage VisualRankTextImage;
    private ENTERPRISE.UI.UITextMeshProUGUI VisualValueText;
    private UnityEngine.UI.RawImage MentalRankTextImage;
    private ENTERPRISE.UI.UITextMeshProUGUI MentalValueText;
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Module.Networking.IProduceParameterStatus produceParameter);
    private Cysharp.Threading.Tasks.UniTask _loadParameterRankIconAsync(ProduceParameterRank parameterRank, UnityEngine.UI.RawImage displayImage);

    private struct <SetupAsync>d__8 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.UnitParameterContent <>4__this;
        public PRISM.Module.Networking.IProduceParameterStatus produceParameter;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class ScheduleSelectionLeftBottomAreaView : UnityEngine.MonoBehaviour, PRISM.Adapters.IScheduleSelectionLeftBottomAreaView, System.IDisposable
{
    private PRISM.Interactions.UnitParameterContent unitParameterContent;
    private PRISM.Interactions.ScheduleVitalityGauge vitalityGaugeContent;
    private ENTERPRISE.UI.UIButton editInfoButton;
    private ENTERPRISE.UI.UIButton deckListButton;
    private ENTERPRISE.UI.UIButton InheritanceButton;
    private UnityEngine.UI.Image InheritanceButtonCover;
    private ENTERPRISE.UI.UITextMeshProUGUI fanCountText;
    private PRISM.Adapters.ScheduleSelectionLeftBottomAreaViewModel scheduleSelectionLeftBottomAreaViewModel;
    private System.Action<bool> onRingIdolVoiceActivate;
    public System.IObservable<UniRx.Unit> OnClickEditInfoButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickDeckListButton { get; set; }
    public void Dispose();
    public Cysharp.Threading.Tasks.UniTask InitializeAsync();
    public void Inject(PRISM.Adapters.ScheduleSelectionLeftBottomAreaViewModel scheduleSelectionLeftBottomAreaViewModel);
    public void SetActive(bool isActive);
    public Cysharp.Threading.Tasks.UniTask SetupAsync(System.Action<bool> ringIdolVoiceActivate);
    public Cysharp.Threading.Tasks.UniTask StartVitalityAnimationAsync(PRISM.Module.Networking.IVitalityVariationStatus vitalityVariation, int currentVitality, int maxVitality, bool isIncrease, System.Threading.CancellationToken ct);
    private void _relationButton();
    private Cysharp.Threading.Tasks.UniTask _showDetailAsync();
    private void _inheritanceButtonCoverActivate(bool isActive);
    private Cysharp.Threading.Tasks.UniTask <_relationButton>b__19_0();

    private struct <<_relationButton>b__19_0>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ScheduleSelectionLeftBottomAreaView <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <SetupAsync>d__17 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ScheduleSelectionLeftBottomAreaView <>4__this;
        public System.Action<bool> ringIdolVoiceActivate;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_showDetailAsync>d__20 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ScheduleSelectionLeftBottomAreaView <>4__this;
        private System.Threading.CancellationToken <ct>5__2;
        private Awaiter<PRISM.Module.Networking.IFesUnitStatus> <>u__1;
        private Awaiter <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class ScheduleSelectionLeftWeekView : UnityEngine.MonoBehaviour, PRISM.Adapters.IScheduleSelectionLeftWeekView, System.IDisposable
{
    private PRISM.Interactions.Produce.ScheduleSelectScheduleLabel scheduleSelectScheduleLabel;
    private PRISM.Adapters.ScheduleSelectionLeftWeekViewModel leftWeekViewModel;
    public void Dispose();
    public Cysharp.Threading.Tasks.UniTask InitializeAsync();
    public void Inject(PRISM.Adapters.ScheduleSelectionLeftWeekViewModel leftWeekViewModel);
    public void SetActive(bool isActive);
    public void Setup();
}

// Namespace: PRISM.Interactions
public class ScheduleSelectionListCarousel : PRISM.Carousel<PRISM.Interactions.ScheduleSelectionListCarouselCellData, PRISM.DefaultCarouselContext>
{
    protected void Initialize();
}

// Namespace: PRISM.Interactions
public class ScheduleSelectionScheduleDetailView : UnityEngine.MonoBehaviour, PRISM.Adapters.IScheduleSelectionScheduleDetailView, System.IDisposable
{
    private UnityEngine.GameObject touchBleckObject;
    private UnityEngine.Canvas touchBleckCanvas;
    private FancyScrollView.Scroller scroller;
    private PRISM.Interactions.ScheduleSelectionListCarousel carousel;
    private System.Collections.Generic.List<UnityEngine.GameObject> indicatorObjectList;
    private System.Collections.Generic.List<UnityEngine.GameObject> indicatorOnObjectList;
    private System.Collections.Generic.List<UnityEngine.GameObject> indicatorOffObjectList;
    private UnityEngine.CanvasGroup detailDisplayCanvasGroup;
    private PRISM.ITutorialSequence finishWorkTutorialSequence;
    private UnityEngine.RectTransform safeAreaRoot;
    private PRISM.Adapters.ScheduleSelectionScheduleDetailViewModel scheduleDetailViewModel;
    private System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IScheduleStatus> weekScheduleDetailList;
    private UniRx.Subject<PRISM.Module.Networking.IScheduleDetailStatus> onClickScheduleExecute;
    private UniRx.Subject<UniRx.Unit> onClickScheduleCancel;
    private UniRx.Subject<bool> onCallBlackActive;
    private UniRx.Subject<UniRx.Unit> onClickDetailScheduleCancel;
    private UniRx.Subject<PRISM.Module.Networking.IScheduleDetailStatus> onClickDetailScheduleExecute;
    private UniRx.Subject<bool> onActivateCanvasGroup;
    private UniRx.Subject<UniRx.Unit> onClickRightButton;
    private UniRx.Subject<UniRx.Unit> onClickLeftButton;
    private UniRx.Subject<PRISM.Interactions.ScheduleDetailContent> onScheduleDetailContent;
    private System.Action onEndLoad;
    private UniRx.Subject<bool> onNotifyAudition;
    private PRISM.Interactions.ScheduleDetailContent cacheScheduleDetailContent;
    private bool isAudition;
    private int loadCount;
    private System.IDisposable backKeyDisposable;
    private PRISM.Adapters.Produce.IModel3dLoaderForScheduleDetail <Model3dLoader>k__BackingField;
    public System.IObservable<PRISM.Module.Networking.IScheduleDetailStatus> OnClickScheduleExecuteObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnClickScheduleCancelObservable { get; set; }
    public System.IObservable<bool> OnCallBlackActiveObservable { get; set; }
    public PRISM.Adapters.Produce.IModel3dLoaderForScheduleDetail Model3dLoader { get; set; }
    public Cysharp.Threading.Tasks.UniTask SetupDetailListAsync(int weekIndex, PRISM.ResourceManagement.IResourceLoader loader, System.Threading.CancellationToken ct);
    public void ShowDetailDisplay(ScheduleType scheduleType, int index);
    public Cysharp.Threading.Tasks.UniTask InitializeAsync();
    public void Inject(PRISM.Adapters.ScheduleSelectionScheduleDetailViewModel scheduleDetailViewModel);
    public void Setup();
    private void Start();
    public void Dispose();
    public Cysharp.Threading.Tasks.UniTask OnClickExecuteScheduleButtonAsync(PRISM.Module.Networking.IScheduleDetailStatus scheduleDetail, System.Action<bool> setBlackDisplay, int unitID, bool isSkitSkip, bool isMiniCharaSkip);
    public void UpdateBlackBack(bool isActive);
    public void SetSafeArea(UnityEngine.RectTransform rectTransform);
    public UnityEngine.RectTransform GetSafeArea();
    public void UpdateActivate(bool isActive);
    public PRISM.ITutorialSequence GetFinishWorkTutorialSequence();
    private void _activateIndicatiorObject(int index);
    private void _activateCanvasGroup(bool isActive);
    private void _checkAndSetAuditionSchedule();
    private void <Start>b__38_0(int index);
    private void <Start>b__38_1(UniRx.Unit _);
    private void <Start>b__38_2(PRISM.Module.Networking.IScheduleDetailStatus detail);
    private void <Start>b__38_3(UniRx.Unit _);
    private void <Start>b__38_7();
    private void <Start>b__38_4(UniRx.Unit _);
    private void <Start>b__38_8();
    private void <Start>b__38_5(PRISM.Interactions.ScheduleDetailContent content);
    private void <Start>b__38_6(UniRx.Unit _);
    private void <_activateCanvasGroup>b__50_0();
    private void <_activateCanvasGroup>b__50_1();

    private class <>c__DisplayClass33_0
    {
        public PRISM.Interactions.ScheduleSelectionScheduleDetailView <>4__this;
        public System.Collections.Generic.IList<PRISM.Interactions.ScheduleSelectionListCarouselCellData> psList;
        private void <SetupDetailListAsync>b__0();
        private bool <SetupDetailListAsync>b__1();
    }

    private class <>c__DisplayClass40_0
    {
        public int unitID;
        public SequenceType sequenceType;
        public bool isTutorialPUEnd;
        public System.Action<bool> <>9__2;
        private void <OnClickExecuteScheduleButtonAsync>b__1();
        private void <OnClickExecuteScheduleButtonAsync>b__2(bool result);
        private bool <OnClickExecuteScheduleButtonAsync>b__0();
    }

    private struct <OnClickExecuteScheduleButtonAsync>d__40 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public int unitID;
        public PRISM.Module.Networking.IScheduleDetailStatus scheduleDetail;
        public PRISM.Interactions.ScheduleSelectionScheduleDetailView <>4__this;
        private <>c__DisplayClass40_0 <>8__1;
        public bool isSkitSkip;
        public bool isMiniCharaSkip;
        public System.Action<bool> setBlackDisplay;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <SetupDetailListAsync>d__33 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ScheduleSelectionScheduleDetailView <>4__this;
        public int weekIndex;
        public PRISM.ResourceManagement.IResourceLoader loader;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class ScheduleSelectionUnitIdolView : UnityEngine.MonoBehaviour, PRISM.Adapters.IScheduleSelectionUnitIdolView, System.IDisposable
{
    private System.Collections.Generic.List<PRISM.Interactions.UnitIdolContent> unitIdolContentList;
    private PRISM.Adapters.ScheduleSelectionUnitIdolViewModel scheduleSelectionUnitIdolViewModel;
    public void Dispose();
    public Cysharp.Threading.Tasks.UniTask InitializeAsync();
    public void Inject(PRISM.Adapters.ScheduleSelectionUnitIdolViewModel unitIdolViewModel);
    public void SetActive(bool isActive);
    public Cysharp.Threading.Tasks.UniTask SetupAsync(System.Action<bool> ringIdolVoiceActivate);
    public System.Collections.Generic.List<PRISM.Adapters.IUnitIdolContent> GetUnitIdolContentList();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Module.Networking.IInProduceIdolStatus, int> <>9__6_0;
        public static System.Func<PRISM.Interactions.UnitIdolContent, System.IObservable<System.ValueTuple<PRISM.Module.Networking.IProduceIdolStatus, PRISM.Module.Networking.IInProduceIdolStatus>>> <>9__6_1;
        public static System.Func<PRISM.Interactions.UnitIdolContent, bool> <>9__7_0;
        private int <SetupAsync>b__6_0(PRISM.Module.Networking.IInProduceIdolStatus x);
        private System.IObservable<System.ValueTuple<PRISM.Module.Networking.IProduceIdolStatus, PRISM.Module.Networking.IInProduceIdolStatus>> <SetupAsync>b__6_1(PRISM.Interactions.UnitIdolContent x);
        private bool <GetUnitIdolContentList>b__7_0(PRISM.Interactions.UnitIdolContent idol);
    }

    private class <>c__DisplayClass6_0
    {
        public System.Collections.Generic.List<PRISM.Module.Networking.IInProduceIdolStatus> sortedUnitList;
        public System.Action<bool> ringIdolVoiceActivate;
        public System.Threading.CancellationToken ct;
        private Cysharp.Threading.Tasks.UniTaskVoid <SetupAsync>b__2(System.ValueTuple<PRISM.Module.Networking.IProduceIdolStatus, PRISM.Module.Networking.IInProduceIdolStatus> t);

        private struct <<SetupAsync>b__2>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
        {
            public int <>1__state;
            public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
            public <>c__DisplayClass6_0 <>4__this;
            public System.ValueTuple<PRISM.Module.Networking.IProduceIdolStatus, PRISM.Module.Networking.IInProduceIdolStatus> t;
            private Awaiter<bool> <>u__1;
            private void MoveNext();
            private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }

    private class <>c__DisplayClass6_1
    {
        public int i;
        public <>c__DisplayClass6_0 CS$<>8__locals1;
        private bool <SetupAsync>b__3(PRISM.Module.Networking.IProduceIdolStatus data);
    }

    private struct <SetupAsync>d__6 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public System.Action<bool> ringIdolVoiceActivate;
        public PRISM.Interactions.ScheduleSelectionUnitIdolView <>4__this;
        private <>c__DisplayClass6_1 <>8__1;
        private <>c__DisplayClass6_0 <>8__2;
        private PRISM.Module.Networking.ISelectedEpisodeStatus <episodeData>5__2;
        private System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceIdolStatus> <produceIdolList>5__3;
        private PRISM.Module.Networking.IProduceUnitStatus <produceUnit>5__4;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class ProduceCardGridView : PRISM.Interactions.GridView<PRISM.Interactions.ProduceCardGridViewCell, PRISM.Module.Networking.IProduceCardStatus>
{
    protected void SetupCellTemplate();

    private class CellGroup : DefaultCellGroup<PRISM.Module.Networking.IProduceCardStatus, PRISM.Interactions.GridViewContext>
    {
    }
}

// Namespace: PRISM.Interactions
public class ProduceCardGridViewCell : PRISM.Interactions.GridViewCell<PRISM.Module.Networking.IProduceCardStatus>
{
    private PRISM.Produce.ProduceCardContent produceCardContent;
    private System.Threading.CancellationTokenSource tokenSource;
    public void UpdateContent(PRISM.Module.Networking.IProduceCardStatus itemData);
    private System.Threading.CancellationToken _getNewCancellationToken();
    private void _cancel();
    private void OnDestroy();
}

// Namespace: PRISM.Interactions
public class ProduceBGMUtility
{
    public static Cysharp.Threading.Tasks.UniTask PlayPreparationBGMAsync(System.Threading.CancellationToken ct);
}

// Namespace: PRISM.Interactions.Produce
public class ProduceAutoSettingSubSeasonIdolToggleGroup : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ToggleGroupView[] toggleButtonGroups;
    public void Setup(int mstUnitId, int firstIndex, System.Action<int> onChangeToggle);
}

// Namespace: PRISM.Interactions.Produce
public class ChallengeTourRewardIcon : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.RewardItemIcon itemIcon;
    private UnityEngine.GameObject getIcon;
    public void Show(PRISM.Adapters.ChallengeTourRewardViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Interactions.Produce
public class ChallengeTourStageDetailOverlayView : PRISM.Interactions.OverlayViewWithCloseButton, PRISM.Adapters.IChallengeTourStageDetailOverlayView, PRISM.Adapters.IClosableOverlayView<UniRx.Unit>, PRISM.Adapters.IOverlayView, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.Produce.ChallengeTourStagePinPanelView stagePinView;
    private PRISM.Interactions.Produce.ChallengeTourStageDetailInfoPanelView infoPanelView;
    private PRISM.Interactions.Produce.ChallengeTourEnemyInfoPanelView enemyInfoPanelView;
    private PRISM.Interactions.Produce.ChallengeTourStageUnitDeckPanelView unitDeckPanelView;
    private UnityEngine.UI.Image backgroundImage;
    private PRISM.Interactions.ButtonView leftButton;
    private PRISM.Interactions.ButtonView rightButton;
    private PRISM.Interactions.ButtonView decideButton;
    private UnityEngine.Animator openAnimator;
    private PRISM.Adapters.ChallengeTourUnitViewModel viewModel;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    private Cysharp.Threading.Tasks.IPromise onShowTask;
    protected PRISM.Definitions.SoundKey closeSoundKey { get; set; }
    public System.IObservable<UniRx.Unit> OnDecide { get; set; }
    public System.IObservable<UniRx.Unit> OnMoveLeft { get; set; }
    public System.IObservable<UniRx.Unit> OnMoveRight { get; set; }
    public System.IObservable<UniRx.Unit> OnShowMissionInfo { get; set; }
    public System.IObservable<UniRx.Unit> OnShowOpponentDeckInfo { get; set; }
    public System.IObservable<int> OnShowOpponentSkill { get; set; }
    public System.IObservable<UniRx.Unit> OnShowDeckEdit { get; set; }
    public System.IObservable<UniRx.Unit> OnShowUnitDetail { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.ChallengeTourUnitViewModel viewModel, int stageIndex, PRISM.ResourceManagement.IResourceLoader resourceLoader, bool isAnimation, Cysharp.Threading.Tasks.IPromise onShowTask, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask UpdateViewAsync(int stageIndex, bool isAnimation, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask _loadBackgroundStageAsync(PRISM.Adapters.ChallengeTourStageViewModel stageViewModel, System.Threading.CancellationToken ct);
    private void _setButtonEnable(int index, PRISM.Adapters.ChallengeTourStageViewModel[] stageViewModels);

    private struct <UpdateViewAsync>d__31 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Produce.ChallengeTourStageDetailOverlayView <>4__this;
        public int stageIndex;
        public System.Threading.CancellationToken ct;
        public bool isAnimation;
        private PRISM.Adapters.ChallengeTourStageViewModel <stageViewModel>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Produce
public class ChallengeTourPIdolEditPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IChallengeTourPIdolEditPopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private PRISM.Interactions.Produce.ChallengeTourPIdolUnitPanelView[] pIdolUnitPanelViews;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClosed;
    private UniRx.Subject<int> onClickPIdol;
    private UniRx.Subject<int> onLongPressPIdol;
    private PRISM.Adapters.ChallengeTourPIdolUnitViewModel[] pIdolViewModels;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public System.IObservable<int> OnClickPIdolObservable { get; set; }
    public System.IObservable<int> OnLongPressPIdolObservable { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Inject(PRISM.Adapters.ChallengeTourPIdolUnitViewModel[] pIdolViewModels, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask SetPIdolUnitPanelAsync(int dataIndex);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__13_0();
    private void <CreateFrameParameter>b__13_1();
    private void <CreateFrameParameter>b__13_2();
    private void <LoadAsync>b__14_0(System.ValueTuple<int, UnityEngine.GameObject> value);
    private void <LoadAsync>b__14_1(System.ValueTuple<int, UnityEngine.GameObject> value);

    private struct <LoadAsync>d__14 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
        public PRISM.Interactions.Produce.ChallengeTourPIdolEditPopupView <>4__this;
        public System.Threading.CancellationToken ct;
        private int <i>5__2;
        private Awaiter <>u__1;
        private Awaiter<bool> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Produce
public class ChallengeTourPIdolSelectPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IChallengeTourPIdolSelectPopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private PRISM.Interactions.Produce.ChallengeTourPIdolSelectGridView pIdolSelectGridView;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClosed;
    private PRISM.Common.Model.PIdolIcon[] pIdolIcons;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public System.IObservable<int> OnClickPIdolObservable { get; set; }
    public System.IObservable<int> OnLongPressPIdolObservable { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Inject(PRISM.Common.Model.PIdolIcon[] pIdolIcons, PRISM.ResourceManagement.IResourceLoader loader);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    public void SetDecideButtonEnable(bool isEnable);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    private void <CreateFrameParameter>b__10_0();
    private void <CreateFrameParameter>b__10_1();
    private void <CreateFrameParameter>b__10_2();
}

// Namespace: PRISM.Interactions.Produce
public class ChallengeTourPIdolUnitDetailPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IChallengeTourPIdolUnitDetailPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private ENTERPRISE.UI.UITabGroup tabGroup;
    private PRISM.Interactions.VoDaViMeRankView voDaViMeRankView;
    private ENTERPRISE.UI.ButtonBase parameterDetailButton;
    private PRISM.Interactions.Produce.ChallengeTourPIdolUnitPanelView[] pIdolUnitPanelViews;
    private PRISM.Produce.ProduceCardContent goPCardPrefab;
    private UnityEngine.Transform trCardParent;
    private ENTERPRISE.UI.UITextMeshProUGUI cardCountText;
    private UnityEngine.GameObject[] showObjects;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClick;
    private UniRx.Subject<int> onClickPIdol;
    private PRISM.Adapters.ChallengeTourUnitViewModel viewModel;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public System.IObservable<int> OnPIdolObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnClickParameterDetail { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Inject(PRISM.Adapters.ChallengeTourUnitViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask _setupPIdolUnitPanelAsync(PRISM.Adapters.ChallengeTourPIdolUnitViewModel[] pIdolUnitViewModels, System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask _setupProduceCardListAsync(PRISM.Module.Networking.IProduceCardStatus[] cards, System.Threading.CancellationToken ct);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__19_0();
    private void <CreateFrameParameter>b__19_1();
    private void <LoadAsync>b__20_0(int index, ENTERPRISE.UI.UITabGroup _);
    private void <_setupPIdolUnitPanelAsync>b__21_0(System.ValueTuple<int, UnityEngine.GameObject> value);

    private struct <LoadAsync>d__20 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
        public PRISM.Interactions.Produce.ChallengeTourPIdolUnitDetailPopupView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private Awaiter<bool> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_setupPIdolUnitPanelAsync>d__21 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Adapters.ChallengeTourPIdolUnitViewModel[] pIdolUnitViewModels;
        public PRISM.Interactions.Produce.ChallengeTourPIdolUnitDetailPopupView <>4__this;
        private int <i>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_setupProduceCardListAsync>d__22 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Module.Networking.IProduceCardStatus[] cards;
        public PRISM.Interactions.Produce.ChallengeTourPIdolUnitDetailPopupView <>4__this;
        public System.Threading.CancellationToken ct;
        private PRISM.Module.Networking.IProduceCardStatus[] <>7__wrap1;
        private int <>7__wrap2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Produce
public class ChallengeTourResultRewardReceivePopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IChallengeTourResultRewardReceivePopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.Produce.ChallengeTourResultRewardReceiveListView receiveListView;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private System.Collections.Generic.List<PRISM.Adapters.ChallengeTourRewardViewModel> receiveModelList;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Inject(System.Collections.Generic.List<PRISM.Adapters.ChallengeTourRewardViewModel> receiveModelList, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__6_0();
    private void <CreateFrameParameter>b__6_1();
}

// Namespace: PRISM.Interactions.Produce
public class ChallengeTourStageFilterPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IChallengeTourStageFilterPopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private ENTERPRISE.UI.ToggleButton[] filterStarButtons;
    private ENTERPRISE.UI.UIButton resetButton;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClosed;
    private UniRx.Subject<int> onFilterClick;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public System.IObservable<int> OnFilterStarObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnFilterResetObservable { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void SetupFilerButton(bool[] isFilters);
    public void SetFilterStatus(bool[] isFilters);
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__10_0();
    private void <CreateFrameParameter>b__10_1();
    private void <CreateFrameParameter>b__10_2();

    private class <>c__DisplayClass11_0
    {
        public int index;
        public PRISM.Interactions.Produce.ChallengeTourStageFilterPopupView <>4__this;
        private void <SetupFilerButton>b__0();
    }
}

// Namespace: PRISM.Interactions.Produce
public class ChallengeTourStageMissionInfoPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IChallengeTourStageMissionInfoPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.Produce.ChallengeTourStageMissionListView lsitView;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClose;
    private PRISM.Adapters.ChallengeTourRewardViewModel[] viewModels;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Inject(PRISM.Adapters.ChallengeTourRewardViewModel[] viewModels, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__6_0();
    private void <CreateFrameParameter>b__6_1();
}

// Namespace: PRISM.Interactions.Produce
public class ChallengeTourResultFunPanelView : UnityEngine.MonoBehaviour
{
    private UnityEngine.Animator animator;
    private ENTERPRISE.UI.UITextMeshProUGUI funText;
    public void Setup(int funCount);
    public Cysharp.Threading.Tasks.UniTask StartAnimationAsync(System.Threading.CancellationToken ct);

    private struct <StartAnimationAsync>d__3 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Produce.ChallengeTourResultFunPanelView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Produce
public class ChallengeTourResultRewardPanelView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.Produce.ChallengeTourResultRewardViewCell[] rewardViewCells;
    public void Initialize(PRISM.Adapters.ChallengeTourRewardViewModel[] viewModels, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public Cysharp.Threading.Tasks.UniTask StartAnimationAsync(int index, System.Threading.CancellationToken ct);

    private struct <StartAnimationAsync>d__2 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Produce.ChallengeTourResultRewardPanelView <>4__this;
        public int index;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Produce
public class ChallengeTourResultRewardReceiveListView : PRISM.Interactions.ListView<PRISM.Interactions.Produce.ChallengeTourResultRewardReceiveListViewCell, PRISM.Adapters.ChallengeTourRewardViewModel>
{
}

// Namespace: PRISM.Interactions.Produce
public class ChallengeTourResultRewardReceiveListViewCell : PRISM.Interactions.ListViewCell<PRISM.Adapters.ChallengeTourRewardViewModel>
{
    private PRISM.Interactions.RewardItemIcon itemIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI nameText;
    public void UpdateContent(PRISM.Adapters.ChallengeTourRewardViewModel viewModel);
}

// Namespace: PRISM.Interactions.Produce
public class ChallengeTourResultRewardViewCell : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.RewardItemIcon itemIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI descriptionText;
    private UnityEngine.Animator animator;
    private ENTERPRISE.UI.AnimatorWithEvent animatorEvent;
    public void Initialize();
    public void Setup(PRISM.Adapters.ChallengeTourRewardViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public Cysharp.Threading.Tasks.UniTask StartGetAnimationAsync(System.Threading.CancellationToken ct);
    private void _playSE(string tag);
    private void <Initialize>b__4_0(string tag);

    private struct <StartGetAnimationAsync>d__6 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Produce.ChallengeTourResultRewardViewCell <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Produce
public class ChallengeTourResultView : UnityEngine.MonoBehaviour, PRISM.Adapters.IChallengeTourResultView
{
    private ENTERPRISE.UI.UITextMeshProUGUI stageTitleText;
    private PRISM.Interactions.Produce.ChallengeTourResultFunPanelView funPanelView;
    private PRISM.Interactions.Produce.ChallengeTourResultRewardPanelView rewardPanelView;
    private ENTERPRISE.UI.UIButton nextButton;
    private PRISM.Adapters.ChallengeTourResultViewModel viewModel;
    private PRISM.Interactions.Produce.InGameResultScriptController scriptController;
    public System.IObservable<UniRx.Unit> OnClickNextOvservable { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.ChallengeTourResultViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public Cysharp.Threading.Tasks.UniTask Setup3DSceneAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask StartFanAnimationAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask StartGetRewardAnimationAsync(int index, System.Threading.CancellationToken ct);
    public void SetNextButtonEnable(bool isEnable);
    public Cysharp.Threading.Tasks.UniTask PlayVoiceAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();

    private struct <Setup3DSceneAsync>d__9 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Produce.ChallengeTourResultView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <TerminateAsync>d__14 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Produce.ChallengeTourResultView <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Produce
public class ChallengeTourArrivalStagePanelView : UnityEngine.MonoBehaviour
{
    private TMPro.TextMeshProUGUI arrivalStageText;
    private TMPro.TextMeshProUGUI getStarText;
    public void Setup(PRISM.Adapters.ChallengeTourUnitViewModel viewModel);
}

// Namespace: PRISM.Interactions.Produce
public class ChallengeTourEnemyInfoPanelView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.Produce.ChallengeTourEnemySilhouettePanelView[] enemySilhouettePanelViews;
    private PRISM.Interactions.Produce.ChallengeTourEnemySkillIcon[] enemySkillIcons;
    private ENTERPRISE.UI.UITextMeshProUGUI totalStatusText;
    private ENTERPRISE.UI.UIButton enemyInfoButton;
    private UniRx.Subject<int> onClick;
    public System.IObservable<UniRx.Unit> OnEnemyInfoObservable { get; set; }
    public System.IObservable<int> OnEnemySkillObservable { get; set; }
    public void Initialize();
    public void Setup(PRISM.Adapters.ChallengeTourStageViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private void <Initialize>b__9_0(int index);
}

// Namespace: PRISM.Interactions.Produce
public class ChallengeTourEnemySilhouettePanelView : UnityEngine.MonoBehaviour
{
    private UnityEngine.Transform shilhouetteParent;
    private UnityEngine.GameObject instanceObject;
    public void Setup(int shilhouetteId, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private Cysharp.Threading.Tasks.UniTask _loadPrefabAsync(int shilhouetteId, PRISM.ResourceManagement.IResourceLoader resourceLoader);

    private struct <_loadPrefabAsync>d__3 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public int shilhouetteId;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public PRISM.Interactions.Produce.ChallengeTourEnemySilhouettePanelView <>4__this;
        private Awaiter<UnityEngine.GameObject> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Produce
public class ChallengeTourEnemySkillIcon : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UIButton button;
    private UnityEngine.UI.RawImage iconImage;
    private ENTERPRISE.UI.UITextMeshProUGUI costText;
    private UniRx.Subject<int> onClick;
    private int dataIndex;
    public System.IObservable<int> OnClickObservable { get; set; }
    public void Initialize(int dataIndex);
    public void Setup(PRISM.Adapters.ProduceEnemySkillDetailPopupViewModel skillDetailViewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private void <Initialize>b__7_0();
}

// Namespace: PRISM.Interactions.Produce
public class ChallengeTourIdolIcon : UnityEngine.MonoBehaviour
{
    private PRISM.UI.PFIdolIconView idolIcon;
    private UnityEngine.GameObject blankObject;
    public System.IObservable<System.ValueTuple<int, UnityEngine.GameObject>> OnClickObservable { get; set; }
    public System.IObservable<System.ValueTuple<int, UnityEngine.GameObject>> OnLongPressObservable { get; set; }
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Common.Model.PIdolIcon pIdolIcon, int dataIndex, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Common.Model.FIdolIcon fIdolIcon, int dataIndex, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void Hide();

    private struct <SetupAsync>d__6 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Produce.ChallengeTourIdolIcon <>4__this;
        public PRISM.Common.Model.PIdolIcon pIdolIcon;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public int dataIndex;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <SetupAsync>d__7 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Common.Model.FIdolIcon fIdolIcon;
        public PRISM.Interactions.Produce.ChallengeTourIdolIcon <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public int dataIndex;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Produce
public class ChallengeTourPIdolUnitPanelView : UnityEngine.MonoBehaviour
{
    private PRISM.UI.PFIdolIconView iconView;
    private PRISM.UI.IdolSkillIconView skillIconView;
    private PRISM.Interactions.VoDaViMeRankView voDaViMeRankView;
    private PRISM.Interactions.VoDaViMeView voDaViMeView;
    public System.IObservable<System.ValueTuple<int, UnityEngine.GameObject>> OnClickObservable { get; set; }
    public System.IObservable<System.ValueTuple<int, UnityEngine.GameObject>> OnLongPressObservable { get; set; }
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Adapters.ChallengeTourPIdolUnitViewModel viewModel, int dataIndex, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void SetPIdolOnClickSound(bool isPlaySound);

    private struct <SetupAsync>d__8 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Produce.ChallengeTourPIdolUnitPanelView <>4__this;
        public PRISM.Adapters.ChallengeTourPIdolUnitViewModel viewModel;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public int dataIndex;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Produce
public class ChallengeTourStageDetailInfoPanelView : UnityEngine.MonoBehaviour
{
    private UnityEngine.GameObject normalPinObject;
    private UnityEngine.GameObject bossPinObject;
    private ENTERPRISE.UI.UITextMeshProUGUI stageTitleText;
    private ENTERPRISE.UI.UITextMeshProUGUI stageNumberText;
    private UnityEngine.GameObject clearIcon;
    private UnityEngine.GameObject[] starObjects;
    private PRISM.Interactions.Produce.ChallengeTourRewardIcon itemIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI enemyInfoText;
    private ENTERPRISE.UI.UIButton missionInfoButton;
    public System.IObservable<UniRx.Unit> OnMissionInfoObservable { get; set; }
    public void Setup(PRISM.Adapters.ChallengeTourStageViewModel model, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Interactions.Produce
public class ChallengeTourStageListView : PRISM.Carousel<PRISM.Adapters.ChallengeTourStageViewModel, PRISM.DefaultCarouselContext>
{
    private ENTERPRISE.UI.UIButton nextButton;
    private ENTERPRISE.UI.UIButton prevButton;
    public System.IObservable<int> OnClickCellOvservable { get; set; }
    public int CurrentIndex { get; set; }
    protected void Initialize();
    public void SetButtonEnable(int index, int length);
    private void <Initialize>b__6_0();
    private void <Initialize>b__6_1();
}

// Namespace: PRISM.Interactions.Produce
public class ChallengeTourStageListViewCell : PRISM.CarouselCell<PRISM.Adapters.ChallengeTourStageViewModel, PRISM.DefaultCarouselContext>
{
    private PRISM.Interactions.Produce.ChallengeTourStagePinPanelView pinPanelView;
    private UnityEngine.GameObject clearObject;
    private UnityEngine.Animator animator;
    public void Initialize();
    public void UpdateContent(PRISM.Adapters.ChallengeTourStageViewModel model);
    public void UpdatePosition(float position);
}

// Namespace: PRISM.Interactions.Produce
public class ChallengeTourStageMissionListView : PRISM.Interactions.ListView<PRISM.Interactions.Produce.ChallengeTourStageMissionListViewCell, PRISM.Adapters.ChallengeTourRewardViewModel>
{
}

// Namespace: PRISM.Interactions.Produce
public class ChallengeTourStageMissionListViewCell : PRISM.Interactions.ListViewCell<PRISM.Adapters.ChallengeTourRewardViewModel>
{
    private PRISM.Interactions.Produce.ChallengeTourRewardIcon itemIcon;
    private UnityEngine.GameObject starObject;
    private ENTERPRISE.UI.UITextMeshProUGUI descriptionText;
    public void UpdateContent(PRISM.Adapters.ChallengeTourRewardViewModel viewModel);
}

// Namespace: PRISM.Interactions.Produce
public class ChallengeTourStagePinPanelView : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.Image thumbnail;
    private UnityEngine.GameObject normalPinObject;
    private UnityEngine.GameObject bossPinObject;
    private UnityEngine.GameObject lockObject;
    private ENTERPRISE.UI.UITextMeshProUGUI stageNumberText;
    private UnityEngine.GameObject[] starObjects;
    public void Setup(PRISM.Adapters.ChallengeTourStageViewModel model, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private Cysharp.Threading.Tasks.UniTask _loadThumbnailAsync(PRISM.Adapters.ChallengeTourStageViewModel model, PRISM.ResourceManagement.IResourceLoader resourceLoader);

    private struct <_loadThumbnailAsync>d__7 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Adapters.ChallengeTourStageViewModel model;
        public PRISM.Interactions.Produce.ChallengeTourStagePinPanelView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private UnityEngine.UI.Image <>7__wrap1;
        private Awaiter<UnityEngine.Sprite> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Produce
public class ChallengeTourStageUnitDeckPanelView : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI totalStatusText;
    private PRISM.Interactions.Produce.ChallengeTourIdolIcon[] pIdolIcons;
    private ENTERPRISE.UI.UIButton deckButton;
    private ENTERPRISE.UI.UIButton deckEditButton;
    public System.IObservable<UniRx.Unit> OnDeckEditObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnUnitDetailObservable { get; set; }
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Adapters.ChallengeTourUnitViewModel unitViewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);

    private struct <SetupAsync>d__8 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Produce.ChallengeTourStageUnitDeckPanelView <>4__this;
        public PRISM.Adapters.ChallengeTourUnitViewModel unitViewModel;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private int <i>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Produce
public class ChallengeTourTopView : UnityEngine.MonoBehaviour, PRISM.Adapters.IChallengeTourTopView
{
    private PRISM.Interactions.Produce.ChallengeTourUnitListView unitListView;
    private PRISM.Interactions.Produce.ChallengeTourStageListView stageListView;
    private PRISM.Interactions.Produce.ChallengeTourUnitView unitView;
    private PRISM.Interactions.Produce.ChallengeTourArrivalStagePanelView arrivalStagePanelView;
    private PRISM.Common.FilterAndSortView filterView;
    private PRISM.Adapters.ChallengeTourTopViewModel viewModel;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    public System.Action<int> OnUnitCellClicked { get; set; }
    public System.IObservable<int> OnSelectionChangedObservable { get; set; }
    public System.IObservable<int> OnSelectionCellObservable { get; set; }
    public System.IObservable<bool> OnClickFilterOvservable { get; set; }
    public void Inject(PRISM.Adapters.ChallengeTourTopViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public Cysharp.Threading.Tasks.UniTask SetupAsync(bool isFilter, int unitIndex, int stageIndex, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask SetUnitListSelectedAsync(int unitIndex, int stageIndex, System.Threading.CancellationToken ct);
    public void SetListData(int unitIndex, int stageIndex);
    public void SetArrowButtonEnable(int unitIndex, int stageIndex);
    public void JumpStageListIndex(int unitIndex, int stageIndex);
    public void SetFilterLabel(bool isFilter);
}

// Namespace: PRISM.Interactions.Produce
public class ChallengeTourUnitListView : PRISM.CommonListView<PRISM.Interactions.Produce.ChallengeTourUnitListViewCell, PRISM.Adapters.ChallengeTourUnitViewModel, PRISM.CommonListViewContext>
{
}

// Namespace: PRISM.Interactions.Produce
public class ChallengeTourUnitListViewCell : PRISM.CommonListViewCell<PRISM.Adapters.ChallengeTourUnitViewModel, PRISM.CommonListViewContext>
{
    private UnityEngine.UI.Image unitIconImage;
    private PRISM.AutoCancellationTokenSource canceller;
    public void Initialize();
    public void UpdateContent(PRISM.Adapters.ChallengeTourUnitViewModel viewModel);
}

// Namespace: PRISM.Interactions.Produce
public class ChallengeTourUnitView : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.Image unitLogoImage;
    private UnityEngine.UI.Image unitImage;
    private UnityEngine.UI.Image[] arrowImages;
    private UnityEngine.Animator animator;
    public Cysharp.Threading.Tasks.UniTask SetupAsync(int challengeTourId, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);

    private struct <SetupAsync>d__4 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public int challengeTourId;
        public PRISM.Interactions.Produce.ChallengeTourUnitView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        private int <unitId>5__2;
        private UnityEngine.UI.Image <>7__wrap2;
        private Awaiter<UnityEngine.Sprite> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Produce
public class ChallengeTourPIdolSelectGridView : FancyScrollView.FancyGridView<PRISM.Common.Model.PIdolIcon, PRISM.ClickObservableContext<int>>
{
    private PRISM.Interactions.Produce.ChallengeTourPIdolSelectGridViewCell cellPrefab;
    public PRISM.ClickObservableContext<int> ViewContext { get; set; }
    public void Dispose();
    protected void SetupCellTemplate();

    private class CellGroup : DefaultCellGroup<PRISM.Common.Model.PIdolIcon, PRISM.ClickObservableContext<int>>
    {
    }
}

// Namespace: PRISM.Interactions.Produce
public class ChallengeTourPIdolSelectGridViewCell : FancyScrollView.FancyGridViewCell<PRISM.Common.Model.PIdolIcon, PRISM.ClickObservableContext<int>>
{
    private PRISM.UI.PFIdolIconView pIdolIconView;
    private System.IDisposable disposable;
    public void UpdateContent(PRISM.Common.Model.PIdolIcon pIdolIcon);
    private void <UpdateContent>b__2_0(bool isSelected);
}

// Namespace: PRISM.Interactions.Produce
public class ChallengeTourUnitEditConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.ChallengeTourUnitEditArgument>, PRISM.IChallengeTourUnitEditConnector
{
    protected PRISM.Adapters.ChallengeTourUnitEditArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();

    private struct <_playBgmAsync>d__1 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        private Awaiter<CriWare.CriAtomExPlayback> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Produce
public class ChallengeTourUnitEditGridView : PRISM.Interactions.GridView<PRISM.Interactions.Produce.ChallengeTourUnitEditGridViewCell, PRISM.Common.Model.FUnitIcon, PRISM.ClickObservableContext<int>>
{
    public System.IObservable<int> OnClick { get; set; }
    public System.IObservable<int> OnLongPress { get; set; }
    protected void SetupCellTemplate();

    private class CellGroup : DefaultCellGroup<PRISM.Common.Model.FUnitIcon, PRISM.ClickObservableContext<int>>
    {
    }
}

// Namespace: PRISM.Interactions.Produce
public class ChallengeTourUnitEditGridViewCell : PRISM.Interactions.GridViewCell<PRISM.Common.Model.FUnitIcon, PRISM.ClickObservableContext<int>>
{
    private PRISM.UI.FUnitIconView fUnitIcon;
    private UnityEngine.GameObject settingsObject;
    public void UpdateContent(PRISM.Common.Model.FUnitIcon icon);
    private Cysharp.Threading.Tasks.UniTask _setupFUnitIconAsync(PRISM.Common.Model.FUnitIcon icon);

    private struct <_setupFUnitIconAsync>d__3 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Produce.ChallengeTourUnitEditGridViewCell <>4__this;
        public PRISM.Common.Model.FUnitIcon icon;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Produce
public class ChallengeTourUnitEditView : UnityEngine.MonoBehaviour, PRISM.Adapters.IChallengeTourUnitEditView
{
    private PRISM.Interactions.Produce.ChallengeTourUnitEditGridView unitEditGridView;
    private PRISM.Interactions.SortFilterView sortFilterView;
    private ENTERPRISE.UI.UIButton decideButton;
    private UnityEngine.GameObject pIdolSelectedObject;
    private ENTERPRISE.UI.UIButton pIdolSelectButton;
    private ENTERPRISE.UI.UITextMeshProUGUI totalCountText;
    private ENTERPRISE.UI.UITextMeshProUGUI emptyMessageText;
    private PRISM.Interactions.ButtonView backButton;
    private PRISM.Adapters.ChallengeTourUnitEditViewModel viewModel;
    public System.IObservable<int> OnClickObservable { get; set; }
    public System.IObservable<int> OnLongPressObservable { get; set; }
    public PRISM.Adapters.ISortFilterView SortFilterView { get; set; }
    public System.IObservable<UniRx.Unit> OnDecideObservable { get; set; }
    public System.IObservable<UniRx.Unit> OnPIdolSelectObserbavle { get; set; }
    public System.IObservable<UniRx.Unit> OnClickBack { get; set; }
    public void Inject(PRISM.Adapters.ChallengeTourUnitEditViewModel viewModel, PRISM.ResourceManagement.IResourceLoader loader);
    public void Setup();
    public void SetDecideButtonEnable(bool isEnable);
    private void _setCurrentNumText(int currentNum);
    private void <Setup>b__22_0(System.Collections.Generic.IReadOnlyList<PRISM.Common.Model.FUnitIcon> icons);
}

// Namespace: PRISM.Interactions.Produce
public class ProduceFrontMenuBannerCell : PRISM.EnhancedListViewCell<PRISM.Adapters.Produce.IProduceFrontMenuBannerCellData, PRISM.Interactions.Produce.ProduceFrontMenuBannerGroupContext>
{
    private ENTERPRISE.UI.ButtonBase button;
    private UnityEngine.UI.Image bannerImage;
    private UnityEngine.Sprite spriteForChallengeTour;
    private System.Threading.CancellationTokenSource cts;
    protected void _initialize();
    public void UpdateContent(PRISM.Adapters.Produce.IProduceFrontMenuBannerCellData data);
    private void OnDestroy();
    private void <_initialize>b__4_0();
}

// Namespace: PRISM.Interactions.Produce
public class ProduceFrontMenuBannerGroup : PRISM.EnhancedListView<PRISM.Adapters.Produce.IProduceFrontMenuBannerCellData, PRISM.Interactions.Produce.ProduceFrontMenuBannerGroupContext>, PRISM.Adapters.Produce.IProduceFrontMenuBannerGroup
{
    private PRISM.Interactions.UIShifter shifter;
    private PRISM.Interactions.Produce.ProduceFrontMenuBannerCell[] shifterCells;
    private PRISM.CarouselIndicator indicator;
    private UniRx.Subject<PRISM.Adapters.Produce.IProduceFrontMenuBannerCellData> onClickCell;
    public System.IObservable<PRISM.Adapters.Produce.IProduceFrontMenuBannerCellData> OnClickBanner { get; set; }
    public void SetUp(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.Produce.IProduceFrontMenuBannerCellData> cellDataList, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    protected void Initialize();
    private void <Initialize>b__7_0(System.ValueTuple<UnityEngine.RectTransform, int> x);

    private class <>c__DisplayClass6_0
    {
        public PRISM.Interactions.Produce.ProduceFrontMenuBannerGroup <>4__this;
        public System.Collections.Generic.IReadOnlyList<PRISM.Adapters.Produce.IProduceFrontMenuBannerCellData> cellDataList;
        private void <SetUp>b__0(int index);
    }

    private class <>c__DisplayClass7_0
    {
        public System.ValueTuple<UnityEngine.RectTransform, int> x;
        private bool <Initialize>b__1(PRISM.Interactions.Produce.ProduceFrontMenuBannerCell y);
    }
}

// Namespace: PRISM.Interactions.Produce
public class ProduceFrontMenuBannerGroupContext : PRISM.EnhancedListViewContext
{
    private System.Action<int> <OnCellClicked>k__BackingField;
    public System.Action<int> OnCellClicked { get; set; }
}

// Namespace: PRISM.Interactions.Produce
public class ProduceFrontMenuCharacterView : UnityEngine.MonoBehaviour, PRISM.Adapters.IProduceFrontMenuCharacterView
{
    private PRISM.UI.UICharacterViewer uiCharacterViewer;
    public Cysharp.Threading.Tasks.UniTask<bool> SetupHazukiVoiceMotionAsync(PRISM.UnitIdol unitIdol, PRISM.UI.UICharacterVoicePattern voicePattern);
    public void OnNextViewPreparation();
    public Cysharp.Threading.Tasks.UniTask ReleaseAsync();
}

// Namespace: PRISM.Interactions.Produce
public class ProduceFrontMenuConnector : PRISM.Interactions.ViewConnector, PRISM.Legacy.IProduceFrontMenuConnector
{
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
}

// Namespace: PRISM.Interactions.Produce
public class ProduceFrontMenuView : UnityEngine.MonoBehaviour, PRISM.Adapters.IProduceFrontMenuView
{
    private PRISM.Interactions.ButtonView[] buttons;
    private PRISM.Interactions.StaminaView produceStaminaView;
    private PRISM.Interactions.ViewStateChanger produceStateChanger;
    private PRISM.Interactions.ButtonView shinyCompetitionButton;
    private PRISM.Interactions.ViewStateChanger shinyCompetitionStateChanger;
    private ENTERPRISE.UI.UITextMeshProUGUI shinyCompetitionDateText;
    private PRISM.Interactions.Produce.ProduceFrontMenuBannerGroup bannerGroup;
    private PRISM.Adapters.ProduceFrontMenuViewModel viewModel;
    public System.IObservable<SelectButtonType> OnClick { get; set; }
    public PRISM.Adapters.IStaminaView ProduceStaminaView { get; set; }
    public PRISM.Adapters.Produce.IProduceFrontMenuBannerGroup Banner { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeViewAsync(PRISM.Adapters.ProduceFrontMenuViewModel viewModel, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void _beginProduceView(System.Threading.CancellationToken ct);
    private void _beginShinyCompetitionView(System.Threading.CancellationToken ct);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Interactions.ButtonView, int, System.IObservable<SelectButtonType>> <>9__9_0;
        private System.IObservable<SelectButtonType> <get_OnClick>b__9_0(PRISM.Interactions.ButtonView button, int index);
    }

    private class <>c__DisplayClass9_0
    {
        public int index;
        private SelectButtonType <get_OnClick>b__1(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.Produce
public class ChallengeTourInGameMissionListView : PRISM.Interactions.ListView<PRISM.Interactions.Produce.ChallengeTourInGameMissionListViewCell, PRISM.Adapters.ChallengeTourRewardViewModel, PRISM.Interactions.Produce.ChallengeTourInGameMissionListViewContext>
{
    public void Setup(PRISM.Produce.ChallengeTourMissionProgressCalcModel model);
    public void UpdateContents(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.ChallengeTourRewardViewModel> items);
}

// Namespace: PRISM.Interactions.Produce
public class ChallengeTourInGameMissionListViewCell : PRISM.Interactions.ListViewCell<PRISM.Adapters.ChallengeTourRewardViewModel, PRISM.Interactions.Produce.ChallengeTourInGameMissionListViewContext>
{
    private PRISM.Interactions.Produce.ChallengeTourRewardIcon itemIcon;
    private UnityEngine.GameObject starObject;
    private ENTERPRISE.UI.UITextMeshProUGUI descriptionText;
    private ENTERPRISE.UI.UITextMeshProUGUI clearText;
    public void UpdateContent(PRISM.Adapters.ChallengeTourRewardViewModel viewModel);
}

// Namespace: PRISM.Interactions.Produce
public class ChallengeTourInGameMissionListViewContext : PRISM.Interactions.ListViewContext
{
    public System.Func<int, int> GetMissionProgress;
}

// Namespace: PRISM.Interactions.Produce
public class AuditionSuccessResultConnector : PRISM.Interactions.Produce.InGameResultConnector<PRISM.Adapters.Produce.AuditionSuccessResultArgument>, PRISM.Produce.IAuditionSuccessResultConnector, PRISM.Scenario.PlayableADV
{
    private PRISM.Interactions.Produce.InGameResultADVView advView;
    protected string bgmCueName { get; set; }
    public PRISM.Legacy.Adv.IAdvScreenPresenterForLegacy CreateAdvScreenPresenter(PRISM.Adv.AdvScreenViewModel viewModel, PRISM.Scenario.ScenarioManager scenarioManager);
    public void DisactivateWholeButton();
    public void ActivateWholeButton();
    protected PRISM.Adapters.Produce.AuditionSuccessResultArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
}

// Namespace: PRISM.Interactions.Produce
public class AuditionSuccessResultView : UnityEngine.MonoBehaviour, PRISM.Adapters.Produce.IAuditionSuccessResultView, PRISM.Adapters.Produce.IInGameResultView
{
    private UnityEngine.CanvasGroup canvasGroup;
    private ENTERPRISE.UI.UITextMeshProUGUI titleText;
    private ENTERPRISE.UI.UITextMeshProUGUI clearTimeCount;
    private UnityEngine.UI.RawImage rankIcon;
    private UnityEngine.UI.RawImage rankTextImage;
    private UnityEngine.GameObject greatEffect;
    private ENTERPRISE.UI.UITextMeshProUGUI acquireProduceFan;
    private ENTERPRISE.UI.AnimatorWithEvent fanUpAnimatorEvent;
    private int waitFanUpAnimationFrame;
    private PRISM.Produce.ParameterContent parameterContent;
    private ENTERPRISE.UI.AnimatorWithEvent animatorWithEvent;
    private int waitParameterAnimationFrame;
    private PRISM.Interactions.ScreenTapSkipAnimationPlayer animationPlayer;
    private ENTERPRISE.UI.UIButton nextButton;
    private UniRx.Subject<UniRx.Unit> onClickNextButtonSubject;
    private PRISM.Interactions.Produce.InGameResultScriptController scriptController;
    private System.Threading.CancellationTokenSource voiceTokenSource;
    public System.IObservable<UniRx.Unit> OnClickNextButton { get; set; }
    public PRISM.Adapters.Produce.IModel3dLoaderForProduceInGameResult Model3dLoaderForProduceInGameResult { get; set; }
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Adapters.Produce.AuditionSuccessResultArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken cancellationToken);
    public void SetInputEnable(bool isEnable);
    public void PlayVoice();
    public void StopVoice();
    public Cysharp.Threading.Tasks.UniTask PlayResultAnimationAsync(PRISM.Module.Networking.IParameterVariationStatus unitParameterVariation, System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private Cysharp.Threading.Tasks.UniTask _loadClearRankIconAsync(ProduceClearRank clearRank, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken cancellationToken);
    private Cysharp.Threading.Tasks.UniTask _playFanUpAnimationAsync(System.Threading.CancellationToken cancellationToken);
    private Cysharp.Threading.Tasks.UniTask _playParameterAnimationAsync(PRISM.Module.Networking.IParameterVariationStatus unitParameterVariation, System.Threading.CancellationToken cancellationToken);

    private class <>c
    {
        public static <>c <>9;
        public static System.Action<string> <>9__21_2;
        private void <SetupAsync>b__21_2(string tag);
    }

    private class <>c__DisplayClass21_0
    {
        public PRISM.Interactions.Produce.AuditionSuccessResultView <>4__this;
        public PRISM.Adapters.Produce.AuditionSuccessResultArgument argument;
        private void <SetupAsync>b__0();
        private void <SetupAsync>b__1(string tag);
    }

    private class <>c__DisplayClass25_0
    {
        public PRISM.Interactions.Produce.AuditionSuccessResultView <>4__this;
        public PRISM.Module.Networking.IParameterVariationStatus unitParameterVariation;
        private Cysharp.Threading.Tasks.UniTask <PlayResultAnimationAsync>b__0(System.Threading.CancellationToken linkedCancellationToken);
        private void <PlayResultAnimationAsync>b__1();
    }

    private class <>c__DisplayClass28_0
    {
        public PRISM.Interactions.Produce.AuditionSuccessResultView <>4__this;
        public System.Threading.CancellationToken cancellationToken;
        private Cysharp.Threading.Tasks.UniTask <_playFanUpAnimationAsync>b__0();
    }

    private class <>c__DisplayClass29_0
    {
        public PRISM.Interactions.Produce.AuditionSuccessResultView <>4__this;
        public PRISM.Module.Networking.IParameterVariationStatus unitParameterVariation;
        public System.Threading.CancellationToken cancellationToken;
        private Cysharp.Threading.Tasks.UniTask <_playParameterAnimationAsync>b__0();
    }

    private struct <SetupAsync>d__21 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Produce.AuditionSuccessResultView <>4__this;
        public PRISM.Adapters.Produce.AuditionSuccessResultArgument argument;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken cancellationToken;
        private <>c__DisplayClass21_0 <>8__1;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <TerminateAsync>d__26 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Produce.AuditionSuccessResultView <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Produce
public class InGameResultADVView : UnityEngine.MonoBehaviour, PRISM.Adapters.Produce.IInGameResultADVView
{
    private UnityEngine.RectTransform safeAreaRoot;
    private PRISM.Interactions.Adv.AdvScreenView advUI;
    private UnityEngine.GameObject[] inAdvDeactivatedObjectList;
    private PRISM.Interactions.ScheduleVitalityGauge vitalityGauge;
    private PRISM.Produce.ParameterVariationContent parameterVariationContent;
    private PRISM.Produce.SupportEffectDemonstrateUIContent supportEffectDemonstrateUIContent;
    public PRISM.Interactions.Adv.AdvScreenView ADVUI { get; set; }
    public void DeactivateWholeButton();
    public Cysharp.Threading.Tasks.UniTask ShowIdolParameterVariationAsync(PRISM.Module.Networking.IParameterVariationStatus parameterVariation, System.Threading.CancellationToken cancellationToken);
    public void HideParameterVariation();
    public Cysharp.Threading.Tasks.UniTask<ProduceNextOrderType> PlayMainScenarioAsync(ProduceNextOrderType produceNextOrderType, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask ShowSupportEffectUIAsync(System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IExertSupportEffectStatus> exertSupportEffects, PRISM.Module.Networking.IProduceBaseInfoStatus produceBaseInfo, System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask<System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.ISelectionSupportSkillStatus>> ShowGetSupportSkillPopupAsync(System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IGettablePotentialSupportSkillStatus> gettablePotentialSupportSkillList, PRISM.Module.Networking.IInProducePotentialSupportSkillStatus[] supportSkills, int maxSlot, int selectableNum, System.Threading.CancellationToken cancellationToken);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Module.Networking.IGettablePotentialSupportSkillStatus, PRISM.Module.Networking.IPotentialSupportSkillStatus> <>9__13_0;
        public static System.Func<PRISM.Module.Networking.IInProducePotentialSupportSkillStatus, PRISM.Module.Networking.IPotentialSupportSkillStatus> <>9__13_1;
        private PRISM.Module.Networking.IPotentialSupportSkillStatus <ShowGetSupportSkillPopupAsync>b__13_0(PRISM.Module.Networking.IGettablePotentialSupportSkillStatus x);
        private PRISM.Module.Networking.IPotentialSupportSkillStatus <ShowGetSupportSkillPopupAsync>b__13_1(PRISM.Module.Networking.IInProducePotentialSupportSkillStatus x);
    }
}

// Namespace: PRISM.Interactions.Produce
public class InGameResultConnector`1<TArgument> : PRISM.Interactions.ViewConnector<TArgument>
{
    protected string bgmCueName { get; set; }
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();

    private struct <_playBgmAsync>d__2<TArgument> : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Produce.InGameResultConnector<TArgument> <>4__this;
        private Awaiter<CriWare.CriAtomExPlayback> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Produce
public class InGameResultScriptController
{
    private PRISM.Scenario.ScenarioManager scenarioManager;
    private PRISM.Interactions.Produce.InGameResultVoicePlayer voicePlayer;
    private PRISM.Interactions.Produce.Model3dLoaderForProduceInGameResult model3dLoader;
    public PRISM.Adapters.Produce.IModel3dLoaderForProduceInGameResult Model3dLoader { get; set; }
    public Cysharp.Threading.Tasks.UniTask SetupLessonScriptAsync(PRISM.UnitIdol[] unitIdols, int unitID, ScheduleDetailType scheduleDetailType, bool isSuccess, System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask SetupAuditionScriptAsync(PRISM.UnitIdol[] unitIdols, int unitID, bool isSuccess, System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask SetupProduceResultScriptAsync(PRISM.UnitIdol[] unitIdols, int unitID, ProduceParameterRank produceRank, System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask PlayVoiceAsync(IdolBaseProduceScenarioTypeId firstVoiceType, IdolBaseProduceScenarioTypeId secondVoiceType, System.Threading.CancellationToken cancellationToken);
    public void SetDoAction();
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private Cysharp.Threading.Tasks.UniTask _setUpAsync(string scenarioName, PRISM.UnitIdol[] unitIdols, int unitID, int bgValue, System.Collections.Generic.Dictionary<string, int> additionalSetValue, int voicePatternNum, System.Threading.CancellationToken cancellationToken);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<bool> <>9__11_0;
        private bool <_setUpAsync>b__11_0();
    }

    private class <>c__DisplayClass8_0
    {
        public PRISM.Interactions.Produce.InGameResultScriptController <>4__this;
        public IdolBaseProduceScenarioTypeId secondVoiceType;
        public System.Threading.CancellationToken cancellationToken;
        private Cysharp.Threading.Tasks.UniTask <PlayVoiceAsync>b__0();
    }

    private struct <_setUpAsync>d__11 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Produce.InGameResultScriptController <>4__this;
        public string scenarioName;
        public PRISM.UnitIdol[] unitIdols;
        public int bgValue;
        public System.Collections.Generic.Dictionary<string, int> additionalSetValue;
        public int unitID;
        public System.Threading.CancellationToken cancellationToken;
        public int voicePatternNum;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Produce
public class InGameResultVoicePlayer
{
    private VoiceModel firstVoiceModel;
    private VoiceModel secondVoiceModel;
    private int voicePatternNum;
    private PRISM.UnitIdol[] unitIdols;
    private PRISM.Scenario.ScenarioManager scenarioManager;
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Scenario.ScenarioManager scenarioManager, PRISM.UnitIdol[] unitIdols, int voicePatternNum, System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask PlayFirstVoiceAsync(IdolBaseProduceScenarioTypeId voiceType, System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask PlaySecondVoiceAsync(IdolBaseProduceScenarioTypeId voiceType, System.Threading.CancellationToken cancellationToken);
    private Cysharp.Threading.Tasks.UniTask _playVoiceAsync(VoiceModel voiceModel, IdolBaseProduceScenarioTypeId voiceType, System.Threading.CancellationToken cancellationToken);
    private string _getVoiceCueName(int charaID, IdolBaseProduceScenarioTypeId voiceType);

    private class VoiceModel
    {
        public int CharaIndex;
        public int CharaID;
        public string CueSheet;
    }

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<int, System.Guid> <>9__6_0;
        public static System.Func<PRISM.UnitIdol, int> <>9__6_1;
        public static System.Func<bool> <>9__9_0;
        private System.Guid <SetupAsync>b__6_0(int x);
        private int <SetupAsync>b__6_1(PRISM.UnitIdol x);
        private bool <_playVoiceAsync>b__9_0();
    }

    private struct <_playVoiceAsync>d__9 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Produce.InGameResultVoicePlayer <>4__this;
        public VoiceModel voiceModel;
        public IdolBaseProduceScenarioTypeId voiceType;
        public System.Threading.CancellationToken cancellationToken;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Produce
public class LessonSuccessResultConnector : PRISM.Interactions.Produce.InGameResultConnector<PRISM.Adapters.Produce.LessonSuccessResultArgument>, PRISM.Produce.ILessonSuccessResultConnector, PRISM.Scenario.PlayableADV
{
    private PRISM.Interactions.Produce.InGameResultADVView advView;
    protected string bgmCueName { get; set; }
    public PRISM.Legacy.Adv.IAdvScreenPresenterForLegacy CreateAdvScreenPresenter(PRISM.Adv.AdvScreenViewModel viewModel, PRISM.Scenario.ScenarioManager scenarioManager);
    public void DisactivateWholeButton();
    public void ActivateWholeButton();
    protected PRISM.Adapters.Produce.LessonSuccessResultArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
}

// Namespace: PRISM.Interactions.Produce
public class LessonSuccessResultView : UnityEngine.MonoBehaviour, PRISM.Adapters.Produce.ILessonSuccessResultView, PRISM.Adapters.Produce.IInGameResultView
{
    private UnityEngine.CanvasGroup canvasGroup;
    private UnityEngine.GameObject noSupportBonusUI;
    private ENTERPRISE.UI.UITextMeshProUGUI levelText;
    private UnityEngine.GameObject supportBonusUI;
    private ENTERPRISE.UI.UITextMeshProUGUI supportBonusLevelText;
    private ENTERPRISE.UI.UITextMeshProUGUI titleText;
    private ENTERPRISE.UI.UITextMeshProUGUI clearTimeCount;
    private UnityEngine.UI.RawImage rankIcon;
    private UnityEngine.UI.RawImage rankTextImage;
    private UnityEngine.GameObject greatEffect;
    private PRISM.Produce.ScheduleRewardContent scheduleRewardContent;
    private PRISM.Produce.ChallengeMissionContent challengeMission;
    private bool isChallengeMissionAchieved;
    private ENTERPRISE.UI.AnimatorWithEvent animatorWithEvent;
    private int waitParameterAnimationFrame;
    private PRISM.Interactions.ScreenTapSkipAnimationPlayer animationPlayer;
    private ENTERPRISE.UI.UIButton nextButton;
    private UniRx.Subject<UniRx.Unit> onClickNextButtonSubject;
    private PRISM.Produce.ScheduleLevelUpContent scheduleLevelUpContent;
    private PRISM.Produce.SupportEffectDemonstrateUIContent supportEffectDemonstrateUIContent;
    private System.Threading.CancellationTokenSource voiceTokenSource;
    private PRISM.Interactions.Produce.InGameResultScriptController scriptController;
    public System.IObservable<UniRx.Unit> OnClickNextButton { get; set; }
    public PRISM.Adapters.Produce.IModel3dLoaderForProduceInGameResult Model3dLoaderForProduceInGameResult { get; set; }
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Adapters.Produce.LessonSuccessResultArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken cancellationToken);
    public void SetInputEnable(bool isEnable);
    public void PlayVoice();
    public void StopVoice();
    public Cysharp.Threading.Tasks.UniTask PlayResultAnimationAsync(PRISM.Module.Networking.IParameterVariationStatus unitParameterVariation, PRISM.Module.Networking.IParameterVariationStatus challengeMissionParameterVariation, System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask ShowScheduleLevelUpAsync(PRISM.Module.Networking.IScheduleVariationStatus scheduleVariation, System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask DisplaySupportEffectUIAsync(System.Collections.Generic.List<PRISM.Module.Networking.IExertSupportEffectStatus> exertSupportEffectList, PRISM.Module.Networking.IProduceBaseInfoStatus produceBaseInfo, System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private Cysharp.Threading.Tasks.UniTask _loadClearRankIconAsync(ProduceClearRank clearRank, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken cancellationToken);
    private Cysharp.Threading.Tasks.UniTask _playParameterAnimationAsync(PRISM.Module.Networking.IParameterVariationStatus unitParameterVariation, PRISM.Module.Networking.IParameterVariationStatus challengeMissionParameterVariation, System.Threading.CancellationToken cancellationToken);

    private class <>c__DisplayClass26_0
    {
        public PRISM.Interactions.Produce.LessonSuccessResultView <>4__this;
        public PRISM.Adapters.Produce.LessonSuccessResultArgument argument;
        private void <SetupAsync>b__0(string tag);
        private void <SetupAsync>b__1();
    }

    private class <>c__DisplayClass30_0
    {
        public PRISM.Interactions.Produce.LessonSuccessResultView <>4__this;
        public PRISM.Module.Networking.IParameterVariationStatus unitParameterVariation;
        public PRISM.Module.Networking.IParameterVariationStatus challengeMissionParameterVariation;
        private Cysharp.Threading.Tasks.UniTask <PlayResultAnimationAsync>b__0(System.Threading.CancellationToken ct);
        private void <PlayResultAnimationAsync>b__1();
    }

    private class <>c__DisplayClass31_0
    {
        public PRISM.Interactions.Produce.LessonSuccessResultView <>4__this;
        public PRISM.Module.Networking.IScheduleVariationStatus scheduleVariation;
        private Cysharp.Threading.Tasks.UniTask <ShowScheduleLevelUpAsync>b__0(System.Threading.CancellationToken ct);
    }

    private struct <DisplaySupportEffectUIAsync>d__32 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Produce.LessonSuccessResultView <>4__this;
        public System.Collections.Generic.List<PRISM.Module.Networking.IExertSupportEffectStatus> exertSupportEffectList;
        public PRISM.Module.Networking.IProduceBaseInfoStatus produceBaseInfo;
        public System.Threading.CancellationToken cancellationToken;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <SetupAsync>d__26 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Produce.LessonSuccessResultView <>4__this;
        public PRISM.Adapters.Produce.LessonSuccessResultArgument argument;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken cancellationToken;
        private <>c__DisplayClass26_0 <>8__1;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <TerminateAsync>d__33 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Produce.LessonSuccessResultView <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_playParameterAnimationAsync>d__35 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Produce.LessonSuccessResultView <>4__this;
        public System.Threading.CancellationToken cancellationToken;
        public PRISM.Module.Networking.IParameterVariationStatus unitParameterVariation;
        public PRISM.Module.Networking.IParameterVariationStatus challengeMissionParameterVariation;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Produce
public class Model3dLoaderForProduceInGameResult : PRISM.Adapters.Produce.IModel3dLoaderForProduceInGameResult
{
    private PRISM.Scenario.Model3dLoaderCore core;
    public PRISM.Scenario.ScenarioManager GetScenarioManager();
    public void FinishScenario();
    public Cysharp.Threading.Tasks.UniTask SetUpAsync(string scenarioName, PRISM.UnitIdol[] unitIdols, int bgValue, int unitId, System.Collections.Generic.Dictionary<string, int> additionalSetValue, System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask ReleaseAsync();
}

// Namespace: PRISM.Interactions.Produce
public class ProduceFailureResultConnector : PRISM.Interactions.Produce.InGameResultConnector<PRISM.Adapters.Produce.ProduceFailureResultArgument>, PRISM.Produce.IProduceFailureResultConnector, PRISM.Scenario.PlayableADV
{
    private PRISM.Interactions.Produce.InGameResultADVView advView;
    protected string bgmCueName { get; set; }
    public PRISM.Legacy.Adv.IAdvScreenPresenterForLegacy CreateAdvScreenPresenter(PRISM.Adv.AdvScreenViewModel viewModel, PRISM.Scenario.ScenarioManager scenarioManager);
    public void DisactivateWholeButton();
    public void ActivateWholeButton();
    protected PRISM.Adapters.Produce.ProduceFailureResultArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
}

// Namespace: PRISM.Interactions.Produce
public class ProduceFailureResultRewardView : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI titleText;
    private UnityEngine.GameObject scheduleLevelUI;
    private ENTERPRISE.UI.UITextMeshProUGUI scheduleLevelText;
    private ENTERPRISE.UI.UITextMeshProUGUI produceProgressText;
    private UnityEngine.UI.Image progressBar;
    private PRISM.Live.LiveResultRewardItem rewardPrefab;
    private UnityEngine.RectTransform rewardViewArea;
    private ENTERPRISE.UI.AnimatorWithEvent animatorWithEvent;
    private ENTERPRISE.UI.AnimatorWithEvent tipsAnimatorEvent;
    private int waitTipsAnimationFrame;
    public void Setup(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Adapters.Produce.ProduceFailureResultRewardViewModel viewModel);
    public Cysharp.Threading.Tasks.UniTask PlayAnimationAsync(System.Threading.CancellationToken cancellationToken);
    public void SkipAnimation();
    private Cysharp.Threading.Tasks.UniTask _playTipsAnimationAsync(System.Threading.CancellationToken cancellationToken);

    private class <>c
    {
        public static <>c <>9;
        public static System.Action<string> <>9__10_0;
        private void <Setup>b__10_0(string tag);
    }

    private class <>c__DisplayClass13_0
    {
        public PRISM.Interactions.Produce.ProduceFailureResultRewardView <>4__this;
        public System.Threading.CancellationToken cancellationToken;
        private Cysharp.Threading.Tasks.UniTask <_playTipsAnimationAsync>b__0();
    }
}

// Namespace: PRISM.Interactions.Produce
public class ProduceFailureResultView : UnityEngine.MonoBehaviour, PRISM.Adapters.Produce.IProduceFailureResultView, PRISM.Adapters.Produce.IInGameResultView
{
    private UnityEngine.CanvasGroup canvasGroup;
    private PRISM.Interactions.Produce.ProduceFailureResultRewardView rewardView;
    private PRISM.Interactions.ResultIdolBaseRewardContentView idolBaseRewardContentView;
    private ENTERPRISE.UI.UIButton nextButton;
    private UniRx.Subject<UniRx.Unit> onClickNextButtonSubject;
    private PRISM.Interactions.ScreenTapSkipAnimationPlayer animationPlayer;
    private PRISM.Interactions.Produce.InGameResultScriptController scriptController;
    private ScheduleDetailType scheduleDetailType;
    private System.Threading.CancellationTokenSource voiceTokenSource;
    public System.IObservable<UniRx.Unit> OnClickNextButton { get; set; }
    public PRISM.Adapters.Produce.IModel3dLoaderForProduceInGameResult Model3dLoaderForProduceInGameResult { get; set; }
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Adapters.Produce.ProduceFailureResultArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken cancellationToken);
    public void SetInputEnable(bool isEnable);
    public void PlayVoice();
    public void StopVoice();
    public Cysharp.Threading.Tasks.UniTask PlayRewardAnimationAsync(System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask PlayIdolBaseRewardAnimation(System.Collections.Generic.IEnumerable<PRISM.Module.Networking.IIdolBaseRewardStatus> idolBaseRewards, float duration, System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <SetupAsync>b__13_0();
    private Cysharp.Threading.Tasks.UniTask <PlayRewardAnimationAsync>b__17_0(System.Threading.CancellationToken linkedCancellationToken);
    private void <PlayRewardAnimationAsync>b__17_1();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Module.Networking.IIdolBaseRewardStatus, PRISM.Adapters.IdolBaseRewardIdolViewModel> <>9__18_0;
        private PRISM.Adapters.IdolBaseRewardIdolViewModel <PlayIdolBaseRewardAnimation>b__18_0(PRISM.Module.Networking.IIdolBaseRewardStatus e);
    }

    private class <>c__DisplayClass18_0
    {
        public PRISM.Interactions.Produce.ProduceFailureResultView <>4__this;
        public PRISM.Adapters.IdolBaseRewardIdolViewModel[] viewModels;
        public float duration;
        private Cysharp.Threading.Tasks.UniTask <PlayIdolBaseRewardAnimation>b__1(System.Threading.CancellationToken ct);
        private void <PlayIdolBaseRewardAnimation>b__2();
    }

    private struct <PlayIdolBaseRewardAnimation>d__18 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Produce.ProduceFailureResultView <>4__this;
        public float duration;
        public System.Collections.Generic.IEnumerable<PRISM.Module.Networking.IIdolBaseRewardStatus> idolBaseRewards;
        public System.Threading.CancellationToken cancellationToken;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <SetupAsync>d__13 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public System.Threading.CancellationToken cancellationToken;
        public PRISM.Interactions.Produce.ProduceFailureResultView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public PRISM.Adapters.Produce.ProduceFailureResultArgument argument;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <TerminateAsync>d__19 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Produce.ProduceFailureResultView <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Produce
public class ProduceResultShinyCompetitionIdolTotalPowerCell : PRISM.Interactions.ListViewCell<PRISM.Interactions.Produce.ProduceResultShinyCompetitionIdolTotalPowerCellData, PRISM.Interactions.Produce.ProduceResultShinyCompetitionIdolTotalPowerCellContext>
{
    private PRISM.Interactions.ProduceIdolIconView idolIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI totalPowerText;
    private ENTERPRISE.UI.UITextMeshProUGUI produceBonusText;
    private UnityEngine.GameObject bonus;
    private ENTERPRISE.UI.UITextMeshProUGUI bonusText;
    private ENTERPRISE.UI.UITextMeshProUGUI scoreText;
    private PRISM.Interactions.Produce.ProduceResultShinyCompetitionNewRecordIcon highScoreLabel;
    private PRISM.UIAnimation animatedObject;
    private UnityEngine.GameObject nextObjectSeparateLine;
    public void UpdateContent(PRISM.Interactions.Produce.ProduceResultShinyCompetitionIdolTotalPowerCellData data);
    public PRISM.UIAnimation GetUIAnimation();
}

// Namespace: PRISM.Interactions.Produce
public struct ProduceResultShinyCompetitionIdolTotalPowerCellData : System.ValueType, System.IEquatable<PRISM.Interactions.Produce.ProduceResultShinyCompetitionIdolTotalPowerCellData>
{
    private PRISM.Adapters.ProduceResultShinyCompetitionIdolTotalPowerCellViewModel <ViewModel>k__BackingField;
    private bool <IsLastElement>k__BackingField;
    public PRISM.Adapters.ProduceResultShinyCompetitionIdolTotalPowerCellViewModel ViewModel { get; set; }
    public bool IsLastElement { get; set; }
    public string ToString();
    private bool PrintMembers(System.Text.StringBuilder builder);
    public static bool op_Inequality(PRISM.Interactions.Produce.ProduceResultShinyCompetitionIdolTotalPowerCellData left, PRISM.Interactions.Produce.ProduceResultShinyCompetitionIdolTotalPowerCellData right);
    public static bool op_Equality(PRISM.Interactions.Produce.ProduceResultShinyCompetitionIdolTotalPowerCellData left, PRISM.Interactions.Produce.ProduceResultShinyCompetitionIdolTotalPowerCellData right);
    public int GetHashCode();
    public bool Equals(object obj);
    public bool Equals(PRISM.Interactions.Produce.ProduceResultShinyCompetitionIdolTotalPowerCellData other);
    public void Deconstruct(PRISM.Adapters.ProduceResultShinyCompetitionIdolTotalPowerCellViewModel& ViewModel, bool& IsLastElement);
}

// Namespace: PRISM.Interactions.Produce
public class ProduceResultShinyCompetitionIdolTotalPowerCellContext : PRISM.Interactions.ListViewContext
{
    public bool IsAutoScrolling;
    public float DelayUIAnimation;
    public System.Threading.CancellationToken Ct;
}

// Namespace: PRISM.Interactions.Produce
public class ProduceResultShinyCompetitionNewRecordIcon : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.CompositeUIAnimation addedCompositeUIAnimation;
    private float playSEDelay;
    private PRISM.Interactions.PlaySEUIAnimation additionalSeUIAnimation;
    public void SetActive(bool isActive);
}

// Namespace: PRISM.Interactions.Produce
public class ProduceResultShinyCompetitionProduceBonusListCell : PRISM.Interactions.ListViewCell<PRISM.Adapters.ShinyCompetitionProduceBonusListViewModel>
{
    private ENTERPRISE.UI.UITextMeshProUGUI missionText;
    private ENTERPRISE.UI.UITextMeshProUGUI bonusValueText;
    private ENTERPRISE.UI.UITextMeshProUGUI ptText;
    private PRISM.Interactions.ViewStateChanger clearedObjectChanger;
    private UnityEngine.Color normalColor;
    private UnityEngine.Color clearedColor;
    private PRISM.UIAnimation uiAnimation;
    public PRISM.UIAnimation UIAnimationTop { get; set; }
    public void UpdateContent(PRISM.Adapters.ShinyCompetitionProduceBonusListViewModel data);
}

// Namespace: PRISM.Interactions.Produce
public class ProduceResultShinyCompetitionProduceBonusListView : PRISM.Interactions.ListView<PRISM.Interactions.Produce.ProduceResultShinyCompetitionProduceBonusListCell, PRISM.Adapters.ShinyCompetitionProduceBonusListViewModel>
{
    private PRISM.Interactions.SequentialUIAnimation sequentialUIAnimation;
    public void Setup(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.ShinyCompetitionProduceBonusListViewModel> items);
    private bool <Setup>b__1_0(PRISM.Interactions.Produce.ProduceResultShinyCompetitionProduceBonusListCell x);
}

// Namespace: PRISM.Interactions.Produce
public class ProduceResultShinyCompetitionRewardCell : PRISM.Interactions.ListViewCell<PRISM.Interactions.Produce.ProduceResultShinyCompetitionRewardCellData, PRISM.Interactions.Produce.ProduceResultShinyCompetitionRewardCellContext>
{
    private ENTERPRISE.UI.UITextMeshProUGUI pointText;
    private UnityEngine.RectTransform rewardIconList;
    private UnityEngine.GameObject[] checkboxList;
    private UnityEngine.Animator overlayAnimator;
    private float delayPlayStampSE;
    private PRISM.Interactions.Produce.ProduceResultShinyCompetitionRewardItemIcon rewardItemIconPrefab;
    private PRISM.AutoCancellationTokenSource animationCanceller;
    private AnimationType animationType;
    private static PRISM.Definitions.SoundKey StampSE;
    public void UpdateContent(PRISM.Interactions.Produce.ProduceResultShinyCompetitionRewardCellData data);
    public void ExecuteAnimation(int delayStampAnimationMiliseconds);
    private Cysharp.Threading.Tasks.UniTask _executeAnimationWithDelayAsync(UnityEngine.Animator animator, string trigger, int delayMiliseconds, bool isPlayStampSE, System.Threading.CancellationToken ct);
    private void OnDestroy();

    private struct <_executeAnimationWithDelayAsync>d__11 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public int delayMiliseconds;
        public System.Threading.CancellationToken ct;
        public UnityEngine.Animator animator;
        public string trigger;
        public bool isPlayStampSE;
        public PRISM.Interactions.Produce.ProduceResultShinyCompetitionRewardCell <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Produce
public struct ProduceResultShinyCompetitionRewardCellData : System.ValueType, System.IEquatable<PRISM.Interactions.Produce.ProduceResultShinyCompetitionRewardCellData>
{
    private PRISM.Adapters.ProduceResultShinyCompetitionRewardCellViewModel <ViewModel>k__BackingField;
    private AnimationType <StampAnimationType>k__BackingField;
    public PRISM.Adapters.ProduceResultShinyCompetitionRewardCellViewModel ViewModel { get; set; }
    public AnimationType StampAnimationType { get; set; }
    public string ToString();
    private bool PrintMembers(System.Text.StringBuilder builder);
    public static bool op_Inequality(PRISM.Interactions.Produce.ProduceResultShinyCompetitionRewardCellData left, PRISM.Interactions.Produce.ProduceResultShinyCompetitionRewardCellData right);
    public static bool op_Equality(PRISM.Interactions.Produce.ProduceResultShinyCompetitionRewardCellData left, PRISM.Interactions.Produce.ProduceResultShinyCompetitionRewardCellData right);
    public int GetHashCode();
    public bool Equals(object obj);
    public bool Equals(PRISM.Interactions.Produce.ProduceResultShinyCompetitionRewardCellData other);
    public void Deconstruct(PRISM.Adapters.ProduceResultShinyCompetitionRewardCellViewModel& ViewModel, AnimationType& StampAnimationType);

    public enum AnimationType : System.Enum
    {
        public int value__;
        public static AnimationType Having;
        public static AnimationType Get1st;
        public static AnimationType Get2ndMore;
        public static AnimationType NotHaving;
    }
}

// Namespace: PRISM.Interactions.Produce
public class ProduceResultShinyCompetitionRewardCellContext : PRISM.Interactions.ListViewContext
{
    private AnimationContext <CurrentAnimationContext>k__BackingField;
    private int <DelayMilisecondsOnStartScroll>k__BackingField;
    private int <DelayMilisecondsOnEnter>k__BackingField;
    private float <ScrollDurationPerCell>k__BackingField;
    public AnimationContext CurrentAnimationContext { get; set; }
    public int DelayMilisecondsOnStartScroll { get; set; }
    public int DelayMilisecondsOnEnter { get; set; }
    public float ScrollDurationPerCell { get; set; }

    public enum AnimationContext : System.Enum
    {
        public int value__;
        public static AnimationContext BeforeScroll;
        public static AnimationContext Scrolling;
        public static AnimationContext AfterScroll;
    }
}

// Namespace: PRISM.Interactions.Produce
public class ProduceResultShinyCompetitionRewardItemIcon : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.RewardItemIcon rewardItemIcon;
    public void Setup(PRISM.Module.Networking.IProductWithAmountStatus product, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Interactions.Produce
public class ProduceResultShinyCompetitionRewardScrollView : PRISM.Interactions.ListView<PRISM.Interactions.Produce.ProduceResultShinyCompetitionRewardCell, PRISM.Interactions.Produce.ProduceResultShinyCompetitionRewardCellData, PRISM.Interactions.Produce.ProduceResultShinyCompetitionRewardCellContext>
{
    private EasingCore.Ease easeType;
    private UnityEngine.CanvasGroup thisCanvasGroup;
    private int clearCellCount;
    private int firstClearCellIndex;
    private int lastClearCellIndex;
    public void SetupContents(System.Collections.Generic.IReadOnlyList<PRISM.Interactions.Produce.ProduceResultShinyCompetitionRewardCellData> items);
    public void SetupStampAnimationParameterContexts(int delayMilisecondsOnStartScroll, int delayMilisecondsOnEnter, float scrollDurationPerCell);
    public void SetScrollEnable(bool enable);
    public void UpdateAnimation(AnimationContext animationContext);
    public Cysharp.Threading.Tasks.UniTask AutoScrollAsync(System.Threading.CancellationToken ct);
    public void SkipScroll();

    private class <>c__DisplayClass9_0
    {
        public bool isComplete;
        private void <AutoScrollAsync>b__0();
        private bool <AutoScrollAsync>b__1();
    }

    private struct <AutoScrollAsync>d__9 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Produce.ProduceResultShinyCompetitionRewardScrollView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Produce
public class ProduceResultShinyCompetitionScrollerUIAnimation : PRISM.UIAnimation
{
    private PRISM.Interactions.Produce.ProduceResultShinyCompetitionTotalPowerListScrollView scrollView;
    public float Duration { get; set; }
    public Cysharp.Threading.Tasks.UniTask PlayAsync(float delay, System.Threading.CancellationToken ct);
    public void Skip();
}

// Namespace: PRISM.Interactions.Produce
public class ProduceResultShinyCompetitionTotalPowerListScrollView : PRISM.Interactions.ListView<PRISM.Interactions.Produce.ProduceResultShinyCompetitionIdolTotalPowerCell, PRISM.Interactions.Produce.ProduceResultShinyCompetitionIdolTotalPowerCellData, PRISM.Interactions.Produce.ProduceResultShinyCompetitionIdolTotalPowerCellContext>
{
    private float delayUIAnimationEnterCell;
    private float delayAutoScrollFromCellAnimation;
    private int lastIndex;
    private float cellUIAnimationDuration;
    public void Setup(System.Collections.Generic.IEnumerable<PRISM.Adapters.ProduceResultShinyCompetitionIdolTotalPowerCellViewModel> cellViewModels, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public Cysharp.Threading.Tasks.UniTask PlayAnimationAsync(float delay, System.Threading.CancellationToken ct);
    public void SkipAnimation();
    public float CalculateAnimationDuration();
    private Cysharp.Threading.Tasks.UniTask _autoScrollAsync(float delay, System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask _animateDefaultDisplayedCellAsunc(float delay, System.Threading.CancellationToken ct);
    private float _calculateScrollDuration();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Adapters.ProduceResultShinyCompetitionIdolTotalPowerCellViewModel, PRISM.Interactions.Produce.ProduceResultShinyCompetitionIdolTotalPowerCellData> <>9__4_0;
        private PRISM.Interactions.Produce.ProduceResultShinyCompetitionIdolTotalPowerCellData <Setup>b__4_0(PRISM.Adapters.ProduceResultShinyCompetitionIdolTotalPowerCellViewModel x);
    }

    private class <>c__DisplayClass8_0
    {
        public bool isComplete;
        private void <_autoScrollAsync>b__0();
        private bool <_autoScrollAsync>b__1();
    }

    private struct <_autoScrollAsync>d__8 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Produce.ProduceResultShinyCompetitionTotalPowerListScrollView <>4__this;
        public float delay;
        public System.Threading.CancellationToken ct;
        private float <scrollDuration>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Produce
public class ProduceResultConnector : PRISM.Interactions.Produce.InGameResultConnector<PRISM.Adapters.Produce.ProduceResultArgument>, PRISM.Produce.IProduceResultConnector
{
    protected string bgmCueName { get; set; }
    protected PRISM.Adapters.Produce.ProduceResultArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
}

// Namespace: PRISM.Interactions.Produce
public class ProduceResultRewardView : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.Graphic difficultyBG;
    private UnityEngine.Color[] difficultyBGColors;
    private ENTERPRISE.UI.UITextMeshProUGUI difficultyText;
    private ENTERPRISE.UI.UITextMeshProUGUI episodeTitleText;
    private PRISM.Produce.ParameterContent unitParameterContent;
    private UnityEngine.UI.RawImage unitRankIcon;
    private UnityEngine.UI.RawImage unitRankRibbonImage;
    private ENTERPRISE.UI.UITextMeshProUGUI unitOverallValueText;
    private PRISM.Live.LiveResultRewardItem rewardPrefab;
    private UnityEngine.RectTransform rewardViewArea;
    private System.Collections.Generic.List<PRISM.Live.LiveResultRewardItem> rewardItems;
    private ENTERPRISE.UI.AnimatorWithEvent animatorWithEvent;
    private int waitParameterAnimationFrame;
    private int waitRewardItemAnimationFrame;
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Adapters.Produce.ProduceResultRewardViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask PlayAnimationAsync(PRISM.Module.Networking.IParameterVariationStatus unitParameterVariation, System.Threading.CancellationToken cancellationToken);
    public void SkipAnimation(PRISM.Module.Networking.IParameterVariationStatus unitParameterVariation);
    private Cysharp.Threading.Tasks.UniTask _loadUnitRankIconAsync(ProduceParameterRank rank, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken cancellationToken);
    private Cysharp.Threading.Tasks.UniTask _playRewardItemAnimationAsync(System.Threading.CancellationToken cancellationToken);
    private Cysharp.Threading.Tasks.UniTask _playParameterAnimationAsync(PRISM.Module.Networking.IParameterVariationStatus unitParameterVariation, System.Threading.CancellationToken cancellationToken);

    private class <>c__DisplayClass14_0
    {
        public PRISM.Adapters.Produce.ProduceResultRewardViewModel viewModel;
        private void <SetupAsync>b__0(string tag);
    }

    private struct <SetupAsync>d__14 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Adapters.Produce.ProduceResultRewardViewModel viewModel;
        public PRISM.Interactions.Produce.ProduceResultRewardView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken cancellationToken;
        private <>c__DisplayClass14_0 <>8__1;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_playParameterAnimationAsync>d__19 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Produce.ProduceResultRewardView <>4__this;
        public System.Threading.CancellationToken cancellationToken;
        public PRISM.Module.Networking.IParameterVariationStatus unitParameterVariation;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_playRewardItemAnimationAsync>d__18 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Produce.ProduceResultRewardView <>4__this;
        public System.Threading.CancellationToken cancellationToken;
        private Awaiter <>u__1;
        private Enumerator<PRISM.Live.LiveResultRewardItem> <>7__wrap1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Produce
public class ProduceResultView : UnityEngine.MonoBehaviour, PRISM.Adapters.Produce.IProduceResultView, PRISM.Adapters.Produce.IInGameResultView
{
    private UnityEngine.CanvasGroup canvasGroup;
    private PRISM.Interactions.Produce.ProduceResultRewardView rewardView;
    private PRISM.Interactions.ResultIdolBaseRewardContentView idolBaseRewardContentView;
    private PRISM.Interactions.Produce.ProduceBonusNoticeContent produceBonusNoticeView;
    private ENTERPRISE.UI.UIButton nextButton;
    private PRISM.Interactions.ScreenTapSkipAnimationPlayer animationPlayer;
    private string howToPlayConfigRefKey;
    private UniRx.Subject<UniRx.Unit> onClickNextButtonSubject;
    private PRISM.Interactions.Produce.InGameResultScriptController scriptController;
    private ProduceParameterRank fesUnitRank;
    private System.Threading.CancellationTokenSource voiceTokenSource;
    public System.IObservable<UniRx.Unit> OnClickNextButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickEndButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickMemorialLiveButton { get; set; }
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Adapters.Produce.ProduceResultArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken cancellationToken);
    public void HideEndButton();
    public void SetInputEnable(bool isEnable);
    public void PlayVoice();
    public void StopVoice();
    public Cysharp.Threading.Tasks.UniTask PlayRewardAnimationAsync(PRISM.Module.Networking.IParameterVariationStatus unitParameterVariation, System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask PlayIdolBaseRewardAnimationAsync(System.Collections.Generic.IEnumerable<PRISM.Module.Networking.IIdolBaseRewardStatus> idolBaseRewards, float duration, System.Threading.CancellationToken cancellationToken);
    public void ShowProduceBonusNotice(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.ProduceBonusNoticeViewModel> list);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <SetupAsync>b__17_0();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Module.Networking.IIdolBaseRewardStatus, PRISM.Adapters.IdolBaseRewardIdolViewModel> <>9__23_0;
        private PRISM.Adapters.IdolBaseRewardIdolViewModel <PlayIdolBaseRewardAnimationAsync>b__23_0(PRISM.Module.Networking.IIdolBaseRewardStatus e);
    }

    private class <>c__DisplayClass22_0
    {
        public PRISM.Interactions.Produce.ProduceResultView <>4__this;
        public PRISM.Module.Networking.IParameterVariationStatus unitParameterVariation;
        private Cysharp.Threading.Tasks.UniTask <PlayRewardAnimationAsync>b__0(System.Threading.CancellationToken linkedCancellationToken);
        private void <PlayRewardAnimationAsync>b__1();
    }

    private class <>c__DisplayClass23_0
    {
        public PRISM.Interactions.Produce.ProduceResultView <>4__this;
        public PRISM.Adapters.IdolBaseRewardIdolViewModel[] viewModels;
        public float duration;
        private Cysharp.Threading.Tasks.UniTask <PlayIdolBaseRewardAnimationAsync>b__1(System.Threading.CancellationToken ct);
        private void <PlayIdolBaseRewardAnimationAsync>b__2();
    }

    private struct <PlayIdolBaseRewardAnimationAsync>d__23 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Produce.ProduceResultView <>4__this;
        public float duration;
        public System.Collections.Generic.IEnumerable<PRISM.Module.Networking.IIdolBaseRewardStatus> idolBaseRewards;
        public System.Threading.CancellationToken cancellationToken;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <SetupAsync>d__17 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public System.Threading.CancellationToken cancellationToken;
        public PRISM.Interactions.Produce.ProduceResultView <>4__this;
        public PRISM.Adapters.Produce.ProduceResultArgument argument;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Produce
public class SpecialLessonResultConnector : PRISM.Interactions.Produce.InGameResultConnector<PRISM.Adapters.Produce.SpecialLessonResultArgument>, PRISM.Produce.ISpecialLessonResultConnector, PRISM.Scenario.PlayableADV
{
    private PRISM.Interactions.Produce.InGameResultADVView advView;
    protected string bgmCueName { get; set; }
    public PRISM.Legacy.Adv.IAdvScreenPresenterForLegacy CreateAdvScreenPresenter(PRISM.Adv.AdvScreenViewModel viewModel, PRISM.Scenario.ScenarioManager scenarioManager);
    public void DisactivateWholeButton();
    public void ActivateWholeButton();
    protected PRISM.Adapters.Produce.SpecialLessonResultArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
}

// Namespace: PRISM.Interactions.Produce
public class SpecialLessonResultView : UnityEngine.MonoBehaviour, PRISM.Adapters.Produce.ISpecialLessonResultView, PRISM.Adapters.Produce.IInGameResultView
{
    private UnityEngine.CanvasGroup canvasGroup;
    private ENTERPRISE.UI.UITextMeshProUGUI titleText;
    private ENTERPRISE.UI.UITextMeshProUGUI levelText;
    private ENTERPRISE.UI.UITextMeshProUGUI appealPointText;
    private PRISM.Produce.AppealPointGaugeContent appealPointGauge;
    private ENTERPRISE.UI.UITextMeshProUGUI rankUpProduceCardText;
    private float appealGaugeAnimationTime;
    private ENTERPRISE.UI.AnimatorWithEvent rankUpCountAnimatorEvent;
    private int waitParameterAnimationFrame;
    private CriWare.CriAtomExPlayback loopSEPlayback;
    private PRISM.Produce.ParameterContent bonusParameterContent;
    private UnityEngine.GameObject bonusScoreObject;
    private UnityEngine.GameObject nonBonusScoreObject;
    private bool isUnitParameterUp;
    private ENTERPRISE.UI.UIButton nextButton;
    private UniRx.Subject<UniRx.Unit> onClickNextButtonSubject;
    private PRISM.Produce.ScheduleLevelUpContent scheduleLevelUpContent;
    private PRISM.Produce.SupportEffectDemonstrateUIContent supportEffectDemonstrateUIContent;
    private ENTERPRISE.UI.AnimatorWithEvent animatorWithEvent;
    private int waitGaugeAnimationFrame;
    private PRISM.Interactions.ScreenTapSkipAnimationPlayer animationPlayer;
    private PRISM.Interactions.Produce.InGameResultScriptController scriptController;
    private System.Threading.CancellationTokenSource voiceCancellationTokenSource;
    public System.IObservable<UniRx.Unit> OnClickNextButton { get; set; }
    public PRISM.Adapters.Produce.IModel3dLoaderForProduceInGameResult Model3dLoaderForProduceInGameResult { get; set; }
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Adapters.Produce.SpecialLessonResultArgument argument, System.Threading.CancellationToken cancellationToken);
    public void SetInputEnable(bool isEnable);
    public void PlayVoice();
    public void StopVoice();
    public Cysharp.Threading.Tasks.UniTask PlayAnimationAsync(int appealPoint, int targetAppealPoint, PRISM.Module.Networking.IParameterVariationStatus unitParameterVariation, System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask ShowScheduleLevelUpAsync(PRISM.Module.Networking.IScheduleVariationStatus scheduleVariation, System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask DisplaySupportEffectUIAsync(System.Collections.Generic.List<PRISM.Module.Networking.IExertSupportEffectStatus> exertSupportEffectList, PRISM.Module.Networking.IProduceBaseInfoStatus produceBaseInfo, System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private Cysharp.Threading.Tasks.UniTask _playAppealGaugeAnimationAsync(int appealPoint, int targetAppealPoint, PRISM.Module.Networking.IParameterVariationStatus unitParameterVariation, System.Threading.CancellationToken cancellationToken);
    private void _stopLoopSE();
    private void _updateAppealGaugeView(int appeal, int maxAppeal);
    private Cysharp.Threading.Tasks.UniTask _playParameterAnimationAsync(PRISM.Module.Networking.IParameterVariationStatus unitParameterVariation, System.Threading.CancellationToken cancellationToken);

    private class <>c
    {
        public static <>c <>9;
        public static System.Action<string> <>9__27_1;
        private void <SetupAsync>b__27_1(string tag);
    }

    private class <>c__DisplayClass27_0
    {
        public PRISM.Interactions.Produce.SpecialLessonResultView <>4__this;
        public PRISM.Adapters.Produce.SpecialLessonResultArgument argument;
        private void <SetupAsync>b__0();
        private void <SetupAsync>b__2(string tag);
    }

    private class <>c__DisplayClass31_0
    {
        public PRISM.Interactions.Produce.SpecialLessonResultView <>4__this;
        public int appealPoint;
        public int targetAppealPoint;
        public PRISM.Module.Networking.IParameterVariationStatus unitParameterVariation;
        private Cysharp.Threading.Tasks.UniTask <PlayAnimationAsync>b__0(System.Threading.CancellationToken linkedCancellationToken);
        private void <PlayAnimationAsync>b__1();
    }

    private class <>c__DisplayClass32_0
    {
        public PRISM.Interactions.Produce.SpecialLessonResultView <>4__this;
        public PRISM.Module.Networking.IScheduleVariationStatus scheduleVariation;
        private Cysharp.Threading.Tasks.UniTask <ShowScheduleLevelUpAsync>b__0(System.Threading.CancellationToken ct);
    }

    private class <>c__DisplayClass35_0
    {
        public int displayAppeal;
        public PRISM.Interactions.Produce.SpecialLessonResultView <>4__this;
        public int targetAppealPoint;
        private void <_playAppealGaugeAnimationAsync>g__onTween|0(int appeal);
        private int <_playAppealGaugeAnimationAsync>b__1();
    }

    private struct <DisplaySupportEffectUIAsync>d__33 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Produce.SpecialLessonResultView <>4__this;
        public System.Collections.Generic.List<PRISM.Module.Networking.IExertSupportEffectStatus> exertSupportEffectList;
        public PRISM.Module.Networking.IProduceBaseInfoStatus produceBaseInfo;
        public System.Threading.CancellationToken cancellationToken;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <SetupAsync>d__27 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Produce.SpecialLessonResultView <>4__this;
        public PRISM.Adapters.Produce.SpecialLessonResultArgument argument;
        public System.Threading.CancellationToken cancellationToken;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <TerminateAsync>d__34 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Produce.SpecialLessonResultView <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_playAppealGaugeAnimationAsync>d__35 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Produce.SpecialLessonResultView <>4__this;
        public int targetAppealPoint;
        public System.Threading.CancellationToken cancellationToken;
        private <>c__DisplayClass35_0 <>8__1;
        public int appealPoint;
        public PRISM.Module.Networking.IParameterVariationStatus unitParameterVariation;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_playParameterAnimationAsync>d__38 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Produce.SpecialLessonResultView <>4__this;
        public System.Threading.CancellationToken cancellationToken;
        public PRISM.Module.Networking.IParameterVariationStatus unitParameterVariation;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Produce
public class Model3dLoaderForProduceAdv : PRISM.Adapters.Produce.IModel3dLoaderForProduceAdv
{
    private PRISM.Scenario.Model3dLoaderCore core;
    public PRISM.Scenario.ScenarioManager GetScenarioManager();
    public void FinishScenario();
    public Cysharp.Threading.Tasks.UniTask SetUpAsync(string scenarioName, PRISM.UnitIdol[] unitIdols, System.Func<Cysharp.Threading.Tasks.UniTask> onInitAsyncFunc, System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask ReleaseAsync();
}

// Namespace: PRISM.Interactions.Produce
public class ShinyCompetitionPIdolBonusListCell : PRISM.Interactions.GridViewCell<PRISM.Adapters.ShinyCompetitionPIdolBonusListViewModel>
{
    private ENTERPRISE.UI.UITextMeshProUGUI idolName;
    private PRISM.UI.PFIdolIconView idolIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI bonusRateText;
    private UnityEngine.GameObject grayOutObject;
    private int percentTextSize;
    private UniRx.CompositeDisposable disposables;
    public void Initialize();
    public void UpdateContent(PRISM.Adapters.ShinyCompetitionPIdolBonusListViewModel viewModel);
    private Cysharp.Threading.Tasks.UniTask _showPIdolDetailPopupAsync(bool isPossession, PRISM.Adapters.ShinyCompetitionPIdolBonusListViewModel viewModel, System.Threading.CancellationToken ct);

    private class <>c__DisplayClass7_0
    {
        public PRISM.Interactions.Produce.ShinyCompetitionPIdolBonusListCell <>4__this;
        public bool isPossession;
        public PRISM.Adapters.ShinyCompetitionPIdolBonusListViewModel viewModel;
        public System.Threading.CancellationToken ct;
        private void <UpdateContent>b__0();
        private void <UpdateContent>b__1(System.ValueTuple<int, UnityEngine.GameObject> _);
    }

    private class <>c__DisplayClass8_0
    {
        public PRISM.Adapters.ShinyCompetitionPIdolBonusListViewModel viewModel;
        public PRISM.Interactions.Produce.ShinyCompetitionPIdolBonusListCell <>4__this;
        private void <_showPIdolDetailPopupAsync>b__0(PRISM.Module.Networking.IProduceIdolStatus x);
    }
}

// Namespace: PRISM.Interactions.Produce
public class ShinyCompetitionPIdolBonusListView : PRISM.Interactions.GridView<PRISM.Interactions.Produce.ShinyCompetitionPIdolBonusListCell, PRISM.Adapters.ShinyCompetitionPIdolBonusListViewModel>
{
    protected void SetupCellTemplate();

    private class CellGroup : DefaultCellGroup<PRISM.Adapters.ShinyCompetitionPIdolBonusListViewModel, PRISM.Interactions.GridViewContext>
    {
    }
}

// Namespace: PRISM.Interactions.Produce
public class ShinyCompetitionProduceBonusListCell : PRISM.Interactions.ListViewCell<PRISM.Adapters.ShinyCompetitionProduceBonusListViewModel>
{
    private ENTERPRISE.UI.UITextMeshProUGUI missionText;
    private ENTERPRISE.UI.UITextMeshProUGUI bonusValueText;
    private PRISM.Interactions.ViewStateChanger clearedObjectChanger;
    private UnityEngine.Color normalColor;
    private UnityEngine.Color clearedColor;
    public void UpdateContent(PRISM.Adapters.ShinyCompetitionProduceBonusListViewModel data);
}

// Namespace: PRISM.Interactions.Produce
public class ShinyCompetitionProduceBonusListView : PRISM.Interactions.ListView<PRISM.Interactions.Produce.ShinyCompetitionProduceBonusListCell, PRISM.Adapters.ShinyCompetitionProduceBonusListViewModel>
{
}

// Namespace: PRISM.Interactions.Produce
public class IngameTutorialPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IIngameTutorialPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private UnityEngine.RectTransform parentRectTransform;
    private ENTERPRISE.UI.UIButton baseIngameTutorialButton;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Initialize(int unitId, PRISM.Produce.HowToPlayProduceManualData manualData);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__6_0();
    private void <CreateFrameParameter>b__6_1();

    private class <>c__DisplayClass5_0
    {
        public int unitId;
        public PRISM.HowToPlayPopupSaveData saveData;
        public System.Collections.Generic.List<HowToPlayProduceManual> datas;
        private bool <Initialize>b__0(HowToPlayProduceManual data);
        private bool <Initialize>b__1(HowToPlayProduceManual data);
    }

    private class <>c__DisplayClass5_1
    {
        public int targetIndex;
        public <>c__DisplayClass5_0 CS$<>8__locals1;
        private void <Initialize>b__2();
    }
}

// Namespace: PRISM.Interactions.Produce
public class InheritanceFUnitDetailPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IInheritanceFUnitDetailPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.UICharacter.FUnitDetailFUnitInfoPresenter fUnitInfoPresenter;
    private PRISM.UICharacter.FUnitDetailSupportPresenter supportPresenter;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Module.Networking.IFesUnitStatus fesUnit, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__6_0();
    private void <CreateFrameParameter>b__6_1();

    private struct <InitializeAsync>d__5 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public System.Threading.CancellationToken ct;
        public PRISM.Interactions.Produce.InheritanceFUnitDetailPopupView <>4__this;
        public PRISM.Module.Networking.IFesUnitStatus fesUnit;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private Awaiter <>u__1;
        private Awaiter<PRISM.Domain.ICachedIdolService> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Produce
public class ProduceLogAccordionOffView : UnityEngine.MonoBehaviour
{
    private UnityEngine.GameObject iconArea;
    private UnityEngine.UI.Image iconImage;
    private UnityEngine.UI.Image unitIconImage;
    private PRISM.Interactions.ProduceIdolIconView pIdolIconView;
    private UnityEngine.UI.RawImage squareIconImage;
    private UnityEngine.UI.RawImage squareIconFrame;
    private PRISM.Interactions.CharacterBaseIconView idolBaseIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI itemText;
    private UnityEngine.GameObject accordionOnButtonObject;
    private UnityEngine.GameObject accordionOffButtonObject;
    private ENTERPRISE.UI.UIButton accordionOnButton;
    private ENTERPRISE.UI.UIButton accordionOffButton;
    private UnityEngine.GameObject producePolicyObject;
    private PRISM.Produce.OneSchedulePolicyContent oneSchedulePolicyContent;
    private ENTERPRISE.UI.UITextMeshProUGUI producePolicyDetailText;
    private PRISM.UIGrayOutController uiGrayOutController;
    private UnityEngine.UI.ScrollRect scrollRect;
    private UnityEngine.Transform nodeListParent;
    private PRISM.Interactions.ADV.ADVLogTalkNode talkNodePrefab;
    private PRISM.Interactions.ADV.ADVLogActionNode actionNodePrefab;
    private PRISM.Interactions.Produce.ProduceScheduleLogNode produceScheduleLogNodePrefab;
    private UnityEngine.Transform scheduleNodeListParent;
    private UnityEngine.Transform scheduleNodeListParentUnder3;
    private UnityEngine.Transform scheduleNodeListParentUnder6;
    private UnityEngine.UI.ScrollRect scheduleScrollRect;
    private UnityEngine.UI.ScrollRect scheduleScrollRectUnder3;
    private UnityEngine.UI.ScrollRect scheduleScrollRectUnder6;
    private PRISM.Interactions.ADV.ADVLogTalkNodeVoicePlaybackContainer talkNodeVoicePlaybackContainer;
    public System.Collections.Generic.List<System.ValueTuple<string, string, string, string, bool>> contentList;
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Adapters.LogAccordionOffViewModel logAccordionOffViewModel, int season, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken cancellationToken);
    private Cysharp.Threading.Tasks.UniTask DisplayAsync(PRISM.Adapters.LogAccordionOffViewModel logAccordionOffViewModel, int season, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private void _activateIcon(IconType iconType);

    public enum IconType : System.Enum
    {
        public int value__;
        public static IconType None;
        public static IconType UnitIcon;
        public static IconType PIdol;
        public static IconType SChara;
        public static IconType IdolBase;
    }

    private class <>c__DisplayClass30_0
    {
        public PRISM.Adapters.LogAccordionOffViewModel logAccordionOffViewModel;
        public PRISM.Interactions.Produce.ProduceLogAccordionOffView <>4__this;
        private void <SetupAsync>b__0();
        private void <SetupAsync>b__1();
    }

    private struct <DisplayAsync>d__31 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Adapters.LogAccordionOffViewModel logAccordionOffViewModel;
        public int season;
        public PRISM.Interactions.Produce.ProduceLogAccordionOffView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private string <htmlString>5__2;
        private SupportCharacter <scenarioID_SupportChara>5__3;
        private UnityEngine.Texture2D <sCharatexture>5__4;
        private Awaiter <>u__1;
        private Awaiter<UnityEngine.Texture2D> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <SetupAsync>d__30 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Adapters.LogAccordionOffViewModel logAccordionOffViewModel;
        public PRISM.Interactions.Produce.ProduceLogAccordionOffView <>4__this;
        public int season;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private <>c__DisplayClass30_0 <>8__1;
        public System.Threading.CancellationToken cancellationToken;
        private bool <isOpened>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Produce
public class ProduceScheduleLogNode : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI scheduleContent;
    public void Initialize(string scheduleText);
}

// Namespace: PRISM.Interactions.Produce
public class ProducePreparationEpisodeDetailPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IProducePreparationEpisodeDetailPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private ENTERPRISE.UI.UITextMeshProUGUI title;
    private ENTERPRISE.UI.UITextMeshProUGUI synopsisText;
    private UnityEngine.UI.Image thumbnail;
    private PRISM.UIGrayOutController voAttributeGrayOutController;
    private PRISM.UIGrayOutController daAttributeGrayOutController;
    private PRISM.UIGrayOutController viAttributeGrayOutController;
    private PRISM.Produce.ProduceEpisodeEpisodeSelectDifficultyButton[] difficultyButtons;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.ProduceEpisodeSelectViewModel model, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__11_0();
    private void <CreateFrameParameter>b__11_1();
}

// Namespace: PRISM.Interactions.Produce
public class ProducePreparationIdolSelectIdolListView : PRISM.Interactions.SelectableGridView<PRISM.Interactions.Produce.ProducePreparationIdolSelectIdolListViewCell, PRISM.Interactions.Produce.ProducePreparationIdolSelectIdolListViewCellData, PRISM.Interactions.Produce.ProducePreparationIdolSelectIdolListViewContext>
{
    private PRISM.Interactions.CountToggleButtonView toggleButtonView;
    private static int MaxDisplaySwitchingCount;
    protected void SetupCellTemplate();
    public void SetInitialProduceIdolId(int id);
    public void SetBonusIdolIdList(System.Collections.Generic.IReadOnlyList<int> idList);
    public void SetSwitchingButtonObservable(UniRx.IReactiveProperty<int> displaySwitchingIndexRP);

    private class CellGroup : DefaultCellGroup<PRISM.Interactions.Produce.ProducePreparationIdolSelectIdolListViewCellData, PRISM.Interactions.Produce.ProducePreparationIdolSelectIdolListViewContext>
    {
    }
}

// Namespace: PRISM.Interactions.Produce
public struct ProducePreparationIdolSelectIdolListViewCellData : System.ValueType, System.IEquatable<PRISM.Interactions.Produce.ProducePreparationIdolSelectIdolListViewCellData>
{
    private PRISM.Module.Networking.IProduceIdolStatus <IdolStatus>k__BackingField;
    private PRISM.Module.Networking.IIdolBaseStatus <IdolBase>k__BackingField;
    public PRISM.Module.Networking.IProduceIdolStatus IdolStatus { get; set; }
    public PRISM.Module.Networking.IIdolBaseStatus IdolBase { get; set; }
    public string ToString();
    private bool PrintMembers(System.Text.StringBuilder builder);
    public static bool op_Inequality(PRISM.Interactions.Produce.ProducePreparationIdolSelectIdolListViewCellData left, PRISM.Interactions.Produce.ProducePreparationIdolSelectIdolListViewCellData right);
    public static bool op_Equality(PRISM.Interactions.Produce.ProducePreparationIdolSelectIdolListViewCellData left, PRISM.Interactions.Produce.ProducePreparationIdolSelectIdolListViewCellData right);
    public int GetHashCode();
    public bool Equals(object obj);
    public bool Equals(PRISM.Interactions.Produce.ProducePreparationIdolSelectIdolListViewCellData other);
    public void Deconstruct(PRISM.Module.Networking.IProduceIdolStatus& IdolStatus, PRISM.Module.Networking.IIdolBaseStatus& IdolBase);
}

// Namespace: PRISM.Interactions.Produce
public class ProducePreparationIdolSelectIdolListViewContext : PRISM.Interactions.SelectableGridViewContext<PRISM.Interactions.Produce.ProducePreparationIdolSelectIdolListViewCellData>
{
    private int <InitialProduceIdolId>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<int> <CurrentShinyCompetitionBonusIdolIdList>k__BackingField;
    private UniRx.IReactiveProperty<int> <DisplaySwitchingIndexRP>k__BackingField;
    public int InitialProduceIdolId { get; set; }
    public System.Collections.Generic.IReadOnlyList<int> CurrentShinyCompetitionBonusIdolIdList { get; set; }
    public UniRx.IReactiveProperty<int> DisplaySwitchingIndexRP { get; set; }
}

// Namespace: PRISM.Interactions.Produce
public class ProducePreparationIdolSelectIdolListViewCell : PRISM.Interactions.SelectableGridViewCell<PRISM.Interactions.Produce.ProducePreparationIdolSelectIdolListViewCellData, PRISM.Interactions.Produce.ProducePreparationIdolSelectIdolListViewContext>
{
    private PRISM.Interactions.ProduceIdolIconView iconView;
    private UnityEngine.UI.RawImage favoriteMark;
    private ENTERPRISE.UI.UITextMeshProUGUI totalIdolParameterText;
    private ENTERPRISE.UI.UITextMeshProUGUI[] idolParameterTexts;
    private ENTERPRISE.UI.UITextMeshProUGUI awakeningLvText;
    private PRISM.Interactions.StarsStateView starsStateView;
    private UnityEngine.GameObject builtIntoMark;
    private UnityEngine.Animator bonusAnimator;
    private PRISM.Interactions.ViewStateChanger viewStateChanger;
    private PRISM.AutoCancellationTokenSource canceller;
    public void Initialize();
    public void UpdateContent(PRISM.Interactions.Produce.ProducePreparationIdolSelectIdolListViewCellData itemData);
    private Cysharp.Threading.Tasks.UniTask _setFavoriteIconAsync(PRISM.Interactions.Produce.ProducePreparationIdolSelectIdolListViewCellData itemData, System.Threading.CancellationToken ct);
    private void OnDestroy();
    private void <Initialize>b__10_0(int state);

    private class <>c__DisplayClass11_0
    {
        public PRISM.Interactions.Produce.ProducePreparationIdolSelectIdolListViewCellData itemData;
        public System.Threading.CancellationToken ct;
        public PRISM.Interactions.Produce.ProducePreparationIdolSelectIdolListViewCell <>4__this;
        public System.Action<PRISM.Module.Networking.IProduceIdolStatus> <>9__1;
        private void <UpdateContent>b__0(UniRx.Unit _);
        private void <UpdateContent>b__1(PRISM.Module.Networking.IProduceIdolStatus pIdol);
    }

    private struct <_setFavoriteIconAsync>d__12 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Produce.ProducePreparationIdolSelectIdolListViewCell <>4__this;
        public PRISM.Interactions.Produce.ProducePreparationIdolSelectIdolListViewCellData itemData;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Produce
public class ProducePreparationIdolSelectPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IProducePreparationIdolSelectPopupView, PRISM.Adapters.IClosablePopupFrame<PRISM.ProduceIdolWithSkillId>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<PRISM.ProduceIdolWithSkillId>
{
    private PRISM.Interactions.Produce.ProducePreparationIdolSelectSelectedIdolView selectedIdolView;
    private PRISM.Interactions.Produce.ProducePreparationIdolSelectIdolListView idolListView;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<PRISM.ProduceIdolWithSkillId> onClosed;
    private UniRx.ReactiveProperty<PRISM.Interactions.Produce.ProducePreparationIdolSelectIdolListViewCellData> selectedIdol;
    private System.Collections.Generic.Dictionary<PRISM.Module.Networking.IProduceIdolStatus, int> selectedSkills;
    private PRISM.Interactions.IPopupFrameView parent;
    public System.IObservable<PRISM.ProduceIdolWithSkillId> OnClickSkillSelect { get; set; }
    public Cysharp.Threading.Tasks.UniTask<PRISM.ProduceIdolWithSkillId> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Initialize(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Module.Networking.IIdolBaseStatus idolBase, PRISM.ProduceIdolWithSkillId initialIdol, System.Collections.Generic.IEnumerable<PRISM.Module.Networking.IProduceIdolStatus> allIdols, System.Collections.Generic.IReadOnlyList<int> bonusIdolIdList, UniRx.IReactiveProperty<int> displaySwitchingIndexRP);
    public void ChangeSkillId(int skillId);
    private PRISM.ProduceIdolWithSkillId _getSelectedData();
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private PRISM.ProduceIdolWithSkillId <get_OnClickSkillSelect>b__3_0(UniRx.Unit _);
    private void <CreateFrameParameter>b__12_0();
    private void <CreateFrameParameter>b__12_1();
    private void <CreateFrameParameter>b__12_2();

    private class <>c__DisplayClass9_0
    {
        public PRISM.Interactions.Produce.ProducePreparationIdolSelectPopupView <>4__this;
        public PRISM.Module.Networking.IIdolBaseStatus idolBase;
        private void <Initialize>b__0(PRISM.Interactions.Produce.ProducePreparationIdolSelectIdolListViewCellData _);
        private PRISM.Interactions.Produce.ProducePreparationIdolSelectIdolListViewCellData <Initialize>b__1(PRISM.Module.Networking.IProduceIdolStatus x);
    }
}

// Namespace: PRISM.Interactions.Produce
public class ProducePreparationIdolSelectSelectedIdolView : UnityEngine.MonoBehaviour
{
    private UnityEngine.Transform prefabContainer;
    private PRISM.Interactions.StarsStateView starsStateView;
    private ENTERPRISE.UI.UITextMeshProUGUI awakeningLvText;
    private ENTERPRISE.UI.UITextMeshProUGUI charaNameText;
    private ENTERPRISE.UI.UITextMeshProUGUI nickNameText;
    private ENTERPRISE.UI.UITextMeshProUGUI vocalText;
    private ENTERPRISE.UI.UITextMeshProUGUI danceText;
    private ENTERPRISE.UI.UITextMeshProUGUI visualText;
    private ENTERPRISE.UI.UITextMeshProUGUI mentalText;
    private PRISM.UI.IdolSkillIconView skillIconView;
    private PRISM.VoDaViMeMultiView skillVoDaViMeView;
    private ENTERPRISE.UI.UITextMeshProUGUI skillNameText;
    private PRISM.Interactions.ButtonView skillSelectButton;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    private PRISM.Module.Networking.IIdolBaseStatus idolBase;
    private PRISM.AutoCancellationTokenSource canceller;
    public System.IObservable<UniRx.Unit> OnClickSkillSelect { get; set; }
    public void Initialize(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Module.Networking.IIdolBaseStatus idolBase);
    public void SetUp(PRISM.ProduceIdolWithSkillId data);
    private void OnDestroy();
    private UnityEngine.GameObject <SetUp>b__19_0(UnityEngine.GameObject prefab);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<int, ProduceParameterType> <>9__19_1;
        private ProduceParameterType <SetUp>b__19_1(int x);
    }
}

// Namespace: PRISM.Interactions.Produce
public class ProduceStaminaUsageSliderView : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.ToggleButton alwaysMaxToggle;
    private ENTERPRISE.UI.UITextMeshProUGUI currentValueText;
    private PRISM.UI.MarkingAttachedSlider slider;
    private UnityEngine.UI.Graphic sliderFill;
    private UnityEngine.UI.Graphic[] sliderCurrentMarkings;
    private UnityEngine.Color sliderNormalColor;
    private UnityEngine.Color sliderAlwaysMaxUsageColor;
    private UnityEngine.UI.Image rewardObjectImage;
    private ENTERPRISE.UI.UITextMeshProUGUI produceRewardText;
    private UnityEngine.UI.Image panelObjectImage;
    private ENTERPRISE.UI.UITextMeshProUGUI panelTitleText;
    private ENTERPRISE.UI.UITextMeshProUGUI valueText;
    private ColorData[] colorData;
    private System.Func<int, int> valueValidator;
    private int previousValue;
    public int CurrentValue { get; set; }
    public bool IsAlwaysMax { get; set; }
    public void SetUp(int currentSt, int episodeSt, int usageValue, bool isAlwaysMaxUsage, System.Func<int, int> validator);
    private void Start();
    private void _update(int value, bool playSE);
    private void _updateSliderStatus();
    private void <Start>b__21_0(float value);

    public class ColorData
    {
        public UnityEngine.Color PanelColor;
        public UnityEngine.Color TextTitleColor;
        public UnityEngine.Color TextColor;
        public UnityEngine.Sprite FramePanelSprite;
    }

    private class <>c__DisplayClass20_0
    {
        public PRISM.Interactions.Produce.ProduceStaminaUsageSliderView <>4__this;
        public int episodeSt;
        public int currentSt;
        private void <SetUp>b__0();
    }
}

// Namespace: PRISM.Interactions.Produce
public class SelectInheritanceFUnitListView : PRISM.Interactions.SelectableGridView<PRISM.Interactions.Produce.SelectInheritanceFUnitListViewCell, PRISM.Common.Model.FUnitIcon, PRISM.Interactions.Produce.SelectInheritanceFUnitListViewContext>
{
    public System.IObservable<string> OnLongPressFUnitIcon { get; set; }
    public void SetFesUnitIdSetting(PRISM.Common.Model.FUnitIcon initialUnit);
    protected void SetupCellTemplate();

    private class CellGroup : DefaultCellGroup<PRISM.Common.Model.FUnitIcon, PRISM.Interactions.Produce.SelectInheritanceFUnitListViewContext>
    {
    }
}

// Namespace: PRISM.Interactions.Produce
public class SelectInheritanceFUnitListViewContext : PRISM.Interactions.SelectableGridViewContext<PRISM.Common.Model.FUnitIcon>
{
    public string InitialSelectedFesUnitId;
    public UniRx.Subject<string> OnLongPressedSubject;
    public void Dispose();
}

// Namespace: PRISM.Interactions.Produce
public class SelectInheritanceFUnitListViewCell : PRISM.Interactions.SelectableGridViewCell<PRISM.Common.Model.FUnitIcon, PRISM.Interactions.Produce.SelectInheritanceFUnitListViewContext>
{
    private PRISM.UI.FUnitIconView fUnitIconView;
    private UnityEngine.GameObject selectedLabel;
    private PRISM.Common.Model.FUnitIcon model;
    private System.IDisposable disposable;
    public void Initialize();
    public void UpdateContent(PRISM.Common.Model.FUnitIcon itemData);
    private void _setSelectedLabel(bool enabled);
    private void OnDestroy();
    private void <UpdateContent>b__5_0();
    private void <UpdateContent>b__5_1(int i);
    private void <UpdateContent>b__5_2(int j);
}

// Namespace: PRISM.Interactions.Produce
public class ShinyCompetitionHistoryDetailListCell : PRISM.Interactions.ListViewCell<PRISM.Adapters.ShinyCompetitionHistoryDetailListCellViewModel>
{
    private PRISM.Interactions.RankingHeaderView rankingHeaderView;
    private UnityEngine.GameObject outOfRangeObject;
    private UnityEngine.GameObject logoObject;
    private PRISM.Interactions.CharacterBaseIconView iconView;
    private UnityEngine.GameObject totalTargetObject;
    private ENTERPRISE.UI.UITextMeshProUGUI pointText;
    private PRISM.Interactions.ViewStateChanger topRankCellStateChanger;
    public void UpdateContent(PRISM.Adapters.ShinyCompetitionHistoryDetailListCellViewModel viewModel);
}

// Namespace: PRISM.Interactions.Produce
public class ShinyCompetitionHistoryDetailListView : PRISM.Interactions.ListView<PRISM.Interactions.Produce.ShinyCompetitionHistoryDetailListCell, PRISM.Adapters.ShinyCompetitionHistoryDetailListCellViewModel>
{
}

// Namespace: PRISM.Interactions.Produce
public class ShinyCompetitionHistoryListCell : PRISM.CommonListViewCell<PRISM.Adapters.ShinyCompetitionHistoryListCellViewModel, PRISM.CommonListViewContext>
{
    private ENTERPRISE.UI.UITextMeshProUGUI countText;
    private ENTERPRISE.UI.UITextMeshProUGUI beginDateText;
    private ENTERPRISE.UI.UITextMeshProUGUI endDateText;
    public void UpdateContent(PRISM.Adapters.ShinyCompetitionHistoryListCellViewModel viewModel);
}

// Namespace: PRISM.Interactions.Produce
public class ShinyCompetitionHistoryListView : PRISM.CommonListView<PRISM.Interactions.Produce.ShinyCompetitionHistoryListCell, PRISM.Adapters.ShinyCompetitionHistoryListCellViewModel, PRISM.CommonListViewContext>
{
}

// Namespace: PRISM.Interactions.Produce
public class SubSeasonDetailPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.ISubSeasonDetailPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.SubSeasonDetailContent subseasonContent;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Initialize(PRISM.SubSeasonDetailContentViewModel viewModel, PRISM.Module.Networking.IProduceParameterStatus unitParam);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__5_0();
    private void <CreateFrameParameter>b__5_1();
}

// Namespace: PRISM.Interactions.Produce
public class SupportSkillIconCell : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.RawImage icon;
    private ENTERPRISE.UI.UIButton button;
    private UnityEngine.GameObject selectedFrame;
    private int index;
    private UniRx.Subject<int> onClickSubject;
    public System.IObservable<int> OnClickedCell { get; set; }
    public void Setup(int skillId, int index, PRISM.ResourceManagement.IResourceLoader loader);
    public void SetSelectedFrame(bool isSelected);
    private void OnDestroy();
    private void <Setup>b__7_0(UniRx.Unit _);
}

// Namespace: PRISM.Interactions.Produce
public class SwipeToggle : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IDragHandler
{
    private float minSwipeDistance;
    private UnityEngine.Vector2 startTouchPosition;
    private UnityEngine.Vector2 endTouchPosition;
    private UniRx.Subject<bool> onSwipeSubject;
    public System.IObservable<bool> OnSwipe { get; set; }
    public void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
    public void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
    private void DetectSwipe();
    private void OnDestroy();
}

// Namespace: PRISM.Interactions.Produce
public class ResourceLoaderExtensions
{
    public static Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadFesUnitRankLargeAsync(PRISM.ResourceManagement.IResourceLoader loader, ProduceParameterRank rank, System.Threading.CancellationToken ct);
    public static Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadFesUnitRankLargeRibbonAsync(PRISM.ResourceManagement.IResourceLoader loader, ProduceParameterRank rank, System.Threading.CancellationToken ct);
}

// Namespace: PRISM.Interactions.Produce
public class Model3dLoaderForScheduleDetail : PRISM.Adapters.Produce.IModel3dLoaderForScheduleDetail
{
    private PRISM.Scenario.Model3dLoaderCore core;
    public PRISM.CameraController GetCameraController();
    public void SetActiveInScene(bool isActive);
    public void FinishScenario();
    public Cysharp.Threading.Tasks.UniTask SetUpAsync(string scenarioName, PRISM.UnitIdol[] unitIdols, int supportCharaCount, System.Collections.Generic.Dictionary<string, int> additionalSetValue, System.Func<Cysharp.Threading.Tasks.UniTask> onInitAsyncFunc, System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask ReleaseAsync();
}

// Namespace: PRISM.Interactions.Produce
public class ProduceScheduleLevelColorData : UnityEngine.ScriptableObject
{
    private UnityEngine.Color[] levelColor;
    public UnityEngine.Color GetScheduleLevelColor(ScheduleLevel scheduleLevel);

    public enum ScheduleLevel : System.Enum
    {
        public int value__;
        public static ScheduleLevel Lv3;
        public static ScheduleLevel Lv5;
    }
}

// Namespace: PRISM.Interactions.Produce
public class ProduceSeasonThemeColorData : UnityEngine.ScriptableObject
{
    private UnityEngine.Color[] seasonThemeColor;
    private UnityEngine.Color[] subSeasonThemeColor;
    public UnityEngine.Color GetSeasonThemeColor(int seasonNum);
    public UnityEngine.Color GetSubSeasonThemeColor(SubSeasonType subSeasonType);

    public enum SeasonType : System.Enum
    {
        public int value__;
        public static SeasonType Season1;
        public static SeasonType Season2;
        public static SeasonType Season3;
    }

    public enum SubSeasonType : System.Enum
    {
        public int value__;
        public static SubSeasonType SubSeason;
    }
}

// Namespace: PRISM.Interactions.Produce
public class ScheduleSelectionPanelGroup : UnityEngine.MonoBehaviour
{
    private System.Collections.Generic.List<PRISM.Interactions.OneScheduleSelectionContent> panelList;
    private UniRx.Subject<System.ValueTuple<ScheduleType, int>> onClickSchedulePanelSubject;
    private UniRx.CompositeDisposable disposables;
    public System.IObservable<System.ValueTuple<ScheduleType, int>> OnClickSchedulePanel { get; set; }
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Adapters.Produce.ScheduleSelectionSchedulePanelViewModel viewModel, System.Threading.CancellationToken cancellationToken);
    private void OnDestroy();

    private class <>c__DisplayClass5_0
    {
        public PRISM.Interactions.Produce.ScheduleSelectionPanelGroup <>4__this;
        public int loopMax;
        private void <SetupAsync>b__0(ScheduleType type);
    }

    private class <>c__DisplayClass5_1
    {
        public int targetIndex;
        public <>c__DisplayClass5_0 CS$<>8__locals1;
        private void <SetupAsync>b__1(ScheduleType type);
    }

    private struct <SetupAsync>d__5 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Produce.ScheduleSelectionPanelGroup <>4__this;
        public PRISM.Adapters.Produce.ScheduleSelectionSchedulePanelViewModel viewModel;
        public System.Threading.CancellationToken cancellationToken;
        private <>c__DisplayClass5_0 <>8__1;
        private <>c__DisplayClass5_1 <>8__2;
        private PRISM.Module.Networking.IProduceTermStatus <produceTerm>5__2;
        private int <index>5__3;
        private System.Collections.Generic.List<PRISM.Module.Networking.IScheduleStatus> <scheduleList>5__4;
        private int <scheduleCount>5__5;
        private Awaiter <>u__1;
        private int <i>5__6;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Produce
public class ScheduleSelectionScheduleCarouselCell : PRISM.CarouselCell<PRISM.Adapters.Produce.ScheduleSelectionScheduleCarouselCellData, PRISM.Interactions.Produce.ScheduleSelectionScheduleCarouselContext>
{
    private UnityEngine.CanvasGroup canvasGroup;
    private UnityEngine.RectTransform cellRectTransform;
    private UnityEngine.UI.Image backgroundImage;
    private UnityEngine.GameObject backgroundGradation;
    private ENTERPRISE.UI.UITextMeshProUGUI timeValueText;
    private ENTERPRISE.UI.UITextMeshProUGUI timeUnitText;
    private PRISM.Interactions.Produce.ScheduleSelectionPanelGroup panelGroup;
    private System.IDisposable disposable;
    private PRISM.Adapters.Produce.ScheduleSelectionScheduleCarouselCellData cellData;
    public void UpdateContent(PRISM.Adapters.Produce.ScheduleSelectionScheduleCarouselCellData itemData);
    public void UpdatePosition(float position);
    private static float _getCellDistanceFromOffset(float position, float scrollOffset, float cellInterval);
    private float _approximatePow(float a, float x);

    private class <>c__DisplayClass9_0
    {
        public PRISM.Interactions.Produce.ScheduleSelectionScheduleCarouselCell <>4__this;
        public PRISM.Adapters.Produce.ScheduleSelectionScheduleCarouselCellData itemData;
        private void <UpdateContent>b__0(System.ValueTuple<ScheduleType, int> x);
    }
}

// Namespace: PRISM.Interactions.Produce
public class ScheduleSelectionScheduleCarouselContext : PRISM.DefaultCarouselContext
{
    private float <ScrollOffset>k__BackingField;
    private float <CellInterval>k__BackingField;
    private float <ScrollAreaSize>k__BackingField;
    private float <CellReductionRate>k__BackingField;
    private float <CellOffsetX>k__BackingField;
    private PRISM.Interactions.Produce.ProduceSeasonThemeColorData <SeasonThemeColorData>k__BackingField;
    private UniRx.Subject<System.ValueTuple<ScheduleType, int, int>> <OnClickSchedulePanel>k__BackingField;
    private UniRx.BoolReactiveProperty <IsCurrentWeekCellOnDefaultPosition>k__BackingField;
    public float ScrollOffset { get; set; }
    public float CellInterval { get; set; }
    public float ScrollAreaSize { get; set; }
    public float CellReductionRate { get; set; }
    public float CellOffsetX { get; set; }
    public PRISM.Interactions.Produce.ProduceSeasonThemeColorData SeasonThemeColorData { get; set; }
    public UniRx.Subject<System.ValueTuple<ScheduleType, int, int>> OnClickSchedulePanel { get; set; }
    public UniRx.BoolReactiveProperty IsCurrentWeekCellOnDefaultPosition { get; set; }
}

// Namespace: PRISM.Interactions.Produce
public class ScheduleSelectionScheduleCarouselView : PRISM.Carousel<PRISM.Adapters.Produce.ScheduleSelectionScheduleCarouselCellData, PRISM.Interactions.Produce.ScheduleSelectionScheduleCarouselContext>, PRISM.Adapters.Produce.IScheduleSelectionScheduleCarouselView
{
    private float scrollAreaSize;
    private float cellReductionRate;
    private float cellOffsetX;
    private PRISM.Interactions.Produce.ProduceSeasonThemeColorData seasonThemeThemeColorData;
    private ScrollResetButton scrollResetButton;
    public System.IObservable<System.ValueTuple<ScheduleType, int, int>> OnClickSchedulePanel { get; set; }
    public void Initialize(PRISM.Adapters.ScheduleSelectionScheduleDisplayViewModel scheduleDisplayViewModel);
    public void Show(bool isOn);
    public void SetScrollable(bool isScrollable);
    protected void Initialize();

    private class ScrollResetButton
    {
        private static float fadeDuration;
        private ENTERPRISE.UI.UIButton button;
        private UnityEngine.CanvasGroup canvasGroup;
        public void SetOnClick(System.Action onClick);
        public void Show(bool isActive);
    }

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Adapters.Produce.ScheduleSelectionScheduleCarouselCellData, int> <>9__7_1;
        private int <Initialize>b__7_1(PRISM.Adapters.Produce.ScheduleSelectionScheduleCarouselCellData x);
    }

    private class <>c__DisplayClass7_0
    {
        public PRISM.Module.Networking.IProduceTermStatus produceTerm;
        public PRISM.Module.Networking.ISubSeasonStatus subSeason;
        public PRISM.Interactions.Produce.ScheduleSelectionScheduleCarouselView <>4__this;
        public int targetIndex;
        private PRISM.Adapters.Produce.ScheduleSelectionScheduleCarouselCellData <Initialize>b__0(PRISM.Module.Networking.IWeekScheduleStatus schedule, int index);
        private void <Initialize>b__2();
        private void <Initialize>b__3(bool isCurrentWeek);
    }
}

// Namespace: PRISM.Interactions.Produce
public class ScheduleSelectScheduleLabel : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI eventNameText;
    private UnityEngine.UI.Image eventLabelImage;
    private ENTERPRISE.UI.UITextMeshProUGUI scheduleText;
    private ENTERPRISE.UI.UITextMeshProUGUI auditionText;
    private PRISM.Interactions.Produce.ProduceSeasonThemeColorData seasonThemeColorData;
    public void Setup(PRISM.Module.Networking.IProduceTermStatus produceTerm, PRISM.Module.Networking.ISubSeasonStatus subSeason);
}

// Namespace: PRISM.Interactions.Produce
public class ProduceBonusNoticeCell : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI missionText;
    private ENTERPRISE.UI.UITextMeshProUGUI bonusValueText;
    private static string MissionTextLabel;
    public void Setup(PRISM.Adapters.ProduceBonusNoticeViewModel data);
}

// Namespace: PRISM.Interactions.Produce
public class ProduceBonusNoticeContent : UnityEngine.MonoBehaviour
{
    private UnityEngine.Transform container;
    private PRISM.Interactions.Produce.ProduceBonusNoticeCell cellBase;
    public void Setup(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.ProduceBonusNoticeViewModel> list);
}

// Namespace: PRISM.Interactions.Produce
public class ShinyCompetitionPointRewardListCell : PRISM.Interactions.ListViewCell<PRISM.Adapters.ShinyCompetitionPointRewardListViewModel>
{
    private ENTERPRISE.UI.UITextMeshProUGUI pointText;
    private PRISM.UIGrayOutController uIGrayOutController;
    private UnityEngine.GameObject clearedStamp;
    private UnityEngine.Transform rewardIconContainer;
    private ENTERPRISE.OutGame.RewardItem rewardIconBase;
    private PRISM.AutoCancellationTokenSource canceller;
    public void UpdateContent(PRISM.Adapters.ShinyCompetitionPointRewardListViewModel viewModel);
}

// Namespace: PRISM.Interactions.Produce
public class ShinyCompetitionPointRewardListView : PRISM.Interactions.ListView<PRISM.Interactions.Produce.ShinyCompetitionPointRewardListCell, PRISM.Adapters.ShinyCompetitionPointRewardListViewModel>
{
    public void Reset();
}

// Namespace: PRISM.Interactions.Produce
public class ShinyCompetitionRankingPersonalListCell : PRISM.Interactions.ListViewCell<PRISM.Adapters.ShinyCompetitionRankingPersonalListViewModel>
{
    private PRISM.Interactions.RankingHeaderView rankingHeaderView;
    private UnityEngine.GameObject outOfRangeObject;
    private UnityEngine.GameObject logoObject;
    private PRISM.Interactions.CharacterBaseIconView iconView;
    private UnityEngine.GameObject totalTargetObject;
    private UnityEngine.GameObject totalOnlyObject;
    private ENTERPRISE.UI.UITextMeshProUGUI pointText;
    private PRISM.Interactions.ViewStateChanger topRankCellStateChanger;
    public void UpdateContent(PRISM.Adapters.ShinyCompetitionRankingPersonalListViewModel viewModel);
}

// Namespace: PRISM.Interactions.Produce
public class ShinyCompetitionRankingPersonalListView : PRISM.Interactions.ListView<PRISM.Interactions.Produce.ShinyCompetitionRankingPersonalListCell, PRISM.Adapters.ShinyCompetitionRankingPersonalListViewModel>
{
    public void Reset();
}

// Namespace: PRISM.Interactions.Produce
public class ShinyCompetitionRankingRewardListCell : PRISM.Interactions.ListViewCell<PRISM.Adapters.ShinyCompetitionRankingRewardListViewModel>
{
    private ENTERPRISE.UI.UITextMeshProUGUI titleText;
    private ENTERPRISE.UI.UITextMeshProUGUI borderRankText;
    private ENTERPRISE.UI.UITextMeshProUGUI scoreTitleText;
    private ENTERPRISE.UI.UITextMeshProUGUI borderScoreText;
    private UnityEngine.Transform rewardIconContainer;
    private ENTERPRISE.OutGame.RewardItem rewardIconBase;
    private PRISM.Interactions.SimpleAchievementIcon achievementIconBase;
    private PRISM.AutoCancellationTokenSource canceller;
    public void UpdateContent(PRISM.Adapters.ShinyCompetitionRankingRewardListViewModel viewModel);
}

// Namespace: PRISM.Interactions.Produce
public class ShinyCompetitionRankingRewardListView : PRISM.Interactions.ListView<PRISM.Interactions.Produce.ShinyCompetitionRankingRewardListCell, PRISM.Adapters.ShinyCompetitionRankingRewardListViewModel>
{
    public void Reset();
}

// Namespace: PRISM.Interactions.Produce
public class ShinyCompetitionRankingTabView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ToggleGroupView toggleGroupView;
    private PRISM.Interactions.Produce.ShinyCompetitionRankingPersonalListCell userTotalCell;
    private PRISM.Interactions.Produce.ShinyCompetitionRankingPersonalListView personalListView;
    private PRISM.Interactions.Produce.ShinyCompetitionRankingTop100ListView top100ListView;
    private PRISM.Interactions.Produce.ShinyCompetitionTabIdolIconListView tabIconView;
    private UnityEngine.GameObject aggregationPanel;
    private ENTERPRISE.UI.UITextMeshProUGUI aggregationTimeText;
    private UnityEngine.GameObject dataEmptyPanel;
    private PRISM.Adapters.ShinyCompetitionRankingViewModel viewModel;
    private UniRx.Subject<int> tabIconCellSubject;
    private UniRx.Subject<string> fUnitDetailSubject;
    public System.IObservable<int> OnClickTabIdolIcon { get; set; }
    public System.IObservable<string> OnClickFUnitIconDetail { get; set; }
    public void Setup(PRISM.Adapters.ShinyCompetitionRankingViewModel viewModel, System.Collections.Generic.List<PRISM.Adapters.ShinyCompetitionRankingTop100ListViewModel> top100ViewModelList, PRISM.ResourceManagement.IResourceLoader loader, System.Threading.CancellationToken ct);
    public void UpdateTop100ListView(System.Collections.Generic.List<PRISM.Adapters.ShinyCompetitionRankingTop100ListViewModel> top100ViewModelList);
    public void UpdateCommentMyself(string comment);
    private string _getDateText(System.Nullable<System.DateTime> date);
    private void OnDestroy();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Adapters.ShinyCompetitionRankingPersonalListViewModel, bool> <>9__15_0;
        public static System.Func<PRISM.Adapters.ShinyCompetitionRankingPersonalListViewModel, bool> <>9__15_1;
        private bool <Setup>b__15_0(PRISM.Adapters.ShinyCompetitionRankingPersonalListViewModel x);
        private bool <Setup>b__15_1(PRISM.Adapters.ShinyCompetitionRankingPersonalListViewModel x);
    }

    private class <>c__DisplayClass15_0
    {
        public PRISM.Interactions.Produce.ShinyCompetitionRankingTabView <>4__this;
        public System.Collections.Generic.IReadOnlyList<PRISM.Definitions.MstShinyCompetitionRanking> rankingIdolData;
        private void <Setup>b__2(string originId);
        private void <Setup>b__3(int _);
        private void <Setup>b__4(int index);
    }
}

// Namespace: PRISM.Interactions.Produce
public class ShinyCompetitionRankingTop100ListCell : PRISM.Interactions.ListViewCell<PRISM.Adapters.ShinyCompetitionRankingTop100ListViewModel, PRISM.Interactions.Produce.ShinyCompetitionRankingTop100ListViewContext>
{
    private PRISM.Interactions.RankingHeaderView headerView;
    private PRISM.Interactions.ProduceIdolIconView idolIcon;
    private PRISM.Interactions.ButtonView idolIconButtonView;
    private ENTERPRISE.UI.UITextMeshProUGUI userName;
    private PRISM.Interactions.SimpleAchievementIconGroup achievementIconGroup;
    private ENTERPRISE.UI.UITextMeshProUGUI point;
    private ENTERPRISE.UI.UITextMeshProUGUI commentText;
    private UnityEngine.GameObject myselfCellBase;
    private PRISM.Interactions.ViewStateChanger myselfCellStateChanger;
    private PRISM.Interactions.ButtonView fUnitDetailButton;
    private PRISM.Adapters.ShinyCompetitionRankingTop100ListViewModel viewModel;
    private UniRx.CompositeDisposable disposables;
    private PRISM.AutoCancellationTokenSource canceller;
    public void Initialize();
    public void UpdateContent(PRISM.Adapters.ShinyCompetitionRankingTop100ListViewModel data);
    private Cysharp.Threading.Tasks.UniTask _showProfilePopupAsync(PRISM.Adapters.ShinyCompetitionRankingTop100ListViewModel data, System.Threading.CancellationToken token);
    private void <Initialize>b__13_0(UniRx.Unit _);

    private class <>c__DisplayClass14_0
    {
        public PRISM.Interactions.Produce.ShinyCompetitionRankingTop100ListCell <>4__this;
        public PRISM.Adapters.ShinyCompetitionRankingTop100ListViewModel data;
        public System.Threading.CancellationToken token;
        private void <UpdateContent>b__0(UniRx.Unit _);
        private void <UpdateContent>b__1(string comment);
    }
}

// Namespace: PRISM.Interactions.Produce
public class ShinyCompetitionRankingTop100ListView : PRISM.Interactions.ListView<PRISM.Interactions.Produce.ShinyCompetitionRankingTop100ListCell, PRISM.Adapters.ShinyCompetitionRankingTop100ListViewModel, PRISM.Interactions.Produce.ShinyCompetitionRankingTop100ListViewContext>
{
    public System.IObservable<string> OnClickFUnitDetail { get; set; }
    public void Reset();
    public void SetRankingType(RankingType type);
    public void UpdateCommentMyself(string comment);
    private void <get_OnClickFUnitDetail>b__1_0(System.Action<string> h);
    private void <get_OnClickFUnitDetail>b__1_1(System.Action<string> h);
}

// Namespace: PRISM.Interactions.Produce
public class ShinyCompetitionRankingTop100ListViewContext : PRISM.Interactions.ListViewContext
{
    private System.Action<string> <OnClickFUnitDetail>k__BackingField;
    private RankingType <RankingType>k__BackingField;
    public UniRx.Subject<string> OnChangedComment;
    public System.Action<string> OnClickFUnitDetail { get; set; }
    public RankingType RankingType { get; set; }
    public void Dispose();
}

// Namespace: PRISM.Interactions.Produce
public class ShinyCompetitionRewardTabView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ToggleGroupView toggleGroupView;
    private PRISM.Interactions.Produce.ShinyCompetitionRankingRewardListView rankingRewardListView;
    private PRISM.Interactions.Produce.ShinyCompetitionPointRewardListView pointRewardListView;
    private ENTERPRISE.UI.UITextMeshProUGUI currentEventPointText;
    private PRISM.Interactions.Produce.ShinyCompetitionTabIdolIconListView tabIconView;
    private UniRx.Subject<int> tabIconCellSubject;
    public System.IObservable<int> OnClickTabIdolIcon { get; set; }
    public void Setup(int eventPoint, System.Collections.Generic.List<PRISM.Definitions.MstShinyCompetitionRanking> rankingIdolData, System.Collections.Generic.List<PRISM.Adapters.ShinyCompetitionRankingRewardListViewModel> rankingRewardList, System.Collections.Generic.List<PRISM.Adapters.ShinyCompetitionPointRewardListViewModel> pointRewardList, PRISM.ResourceManagement.IResourceLoader loader, System.Threading.CancellationToken ct);
    public void UpdateRankingRewardListView(System.Collections.Generic.List<PRISM.Adapters.ShinyCompetitionRankingRewardListViewModel> rankingRewardViewModelList);

    private class <>c__DisplayClass8_0
    {
        public PRISM.Interactions.Produce.ShinyCompetitionRewardTabView <>4__this;
        public System.Collections.Generic.List<PRISM.Definitions.MstShinyCompetitionRanking> rankingIdolData;
        private void <Setup>b__0(int _);
        private void <Setup>b__1(int index);
    }
}

// Namespace: PRISM.Interactions.Produce
public class ShinyCompetitionTabIdolIcon : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.CharacterBaseIconView characterBaseIconView;
    private UnityEngine.GameObject logoObject;
    private ENTERPRISE.UI.ButtonBase button;
    private UnityEngine.GameObject selecterFrame;
    private UniRx.Subject<int> onClickSubject;
    public System.IObservable<int> OnClick { get; set; }
    public Cysharp.Threading.Tasks.UniTask SetupAsync(int index, PRISM.Definitions.MstShinyCompetitionRanking data, PRISM.ResourceManagement.IResourceLoader loader, System.Threading.CancellationToken ct);
    public void SetSelectedFrame(bool isEnabled);
    private void OnDestroy();

    private class <>c__DisplayClass7_0
    {
        public PRISM.Interactions.Produce.ShinyCompetitionTabIdolIcon <>4__this;
        public int index;
        private void <SetupAsync>b__0();
    }

    private struct <SetupAsync>d__7 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Produce.ShinyCompetitionTabIdolIcon <>4__this;
        public int index;
        public PRISM.Definitions.MstShinyCompetitionRanking data;
        public PRISM.ResourceManagement.IResourceLoader loader;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Produce
public class ShinyCompetitionTabIdolIconListView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.Produce.ShinyCompetitionTabIdolIcon[] cells;
    private UniRx.Subject<int> onClickCellSubject;
    public System.IObservable<int> OnClickedCell { get; set; }
    public void Setup(System.Collections.Generic.IReadOnlyList<PRISM.Definitions.MstShinyCompetitionRanking> dataList, PRISM.ResourceManagement.IResourceLoader loader, System.Threading.CancellationToken ct);
    private void _setSelectedFrames(int enableIndex);
    private void OnDestroy();
    private void <Setup>b__4_0(int index);
}

// Namespace: PRISM.Interactions.Produce.SubSeasonSelect
public class ProduceSubSeasonSelectConnector : PRISM.Interactions.ViewConnector, PRISM.Scenario.PlayableADV, PRISM.Produce.SubSeasonSelect.IProduceSubSeasonSelectConnector
{
    private PRISM.Interactions.Adv.AdvScreenView advUI;
    public void ActivateWholeButton();
    public void DisactivateWholeButton();
    public PRISM.Legacy.Adv.IAdvScreenPresenterForLegacy CreateAdvScreenPresenter(PRISM.Adv.AdvScreenViewModel viewModel, PRISM.Scenario.ScenarioManager scenarioManager);
}

// Namespace: PRISM.Interactions.Produce.SubSeasonSelect
public class ProduceSubSeasonSelectView : UnityEngine.MonoBehaviour, PRISM.Adapters.Produce.SubSeasonSelect.IProduceSubSeasonSelectView
{
    private UniRx.Subject<int> onSelectSubseasonSubject;
    private UnityEngine.RectTransform safeAreaRoot;
    private UnityEngine.GameObject choiceButtonRoot;
    private System.Collections.Generic.List<ENTERPRISE.UI.UIButton> buttons;
    private System.Collections.Generic.List<ENTERPRISE.UI.UITextMeshProUGUI> buttonTexts;
    private PRISM.Interactions.Produce.Model3dLoaderForProduceAdv model3dLoader;
    private System.IDisposable backKeyDisposable;
    public System.IObservable<int> OnSelectSubSeason { get; set; }
    public Cysharp.Threading.Tasks.UniTask SetupAsync();
    public void SetUpButtons(System.Collections.Generic.IReadOnlyList<int> mstSubSeasonIdList);
    public Cysharp.Threading.Tasks.UniTask ShowChoiceButtonAsync();
    public void SetEnabledChoiceButtons(bool isEnabled);
    public Cysharp.Threading.Tasks.UniTask<ProduceNextOrderType> PlayProduceADVAsync();
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.ProduceIdolModel, PRISM.UnitIdol> <>9__9_0;
        public static System.Func<bool> <>9__11_0;
        private PRISM.UnitIdol <SetupAsync>b__9_0(PRISM.ProduceIdolModel x);
        private bool <ShowChoiceButtonAsync>b__11_0();
    }

    private class <>c__DisplayClass10_0
    {
        public int index;
        public PRISM.Interactions.Produce.SubSeasonSelect.ProduceSubSeasonSelectView <>4__this;
        private void <SetUpButtons>b__0();
    }

    private struct <PlayProduceADVAsync>d__13 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<ProduceNextOrderType> <>t__builder;
        public PRISM.Interactions.Produce.SubSeasonSelect.ProduceSubSeasonSelectView <>4__this;
        private Awaiter <>u__1;
        private Awaiter<PRISM.Module.Networking.IFinishProduceAdvReply> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <SetupAsync>d__9 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Produce.SubSeasonSelect.ProduceSubSeasonSelectView <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <ShowChoiceButtonAsync>d__11 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Produce.SubSeasonSelect.ProduceSubSeasonSelectView <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Produce.RankingEvent
public class ShinyCompetitionTopViewConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.Produce.ShinyCompetition.ShinyCompetitionTopViewArgument>, PRISM.Legacy.Produce.ShinyCompetition.IShinyCompetitionTopViewConnector
{
    protected PRISM.Adapters.Produce.ShinyCompetition.ShinyCompetitionTopViewArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
}

// Namespace: PRISM.Interactions.Produce.ShinyCompetition
public class ShinyCompetitionRankingConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.Produce.ShinyCompetition.ShinyCompetitionRankingArgument>, PRISM.Adapters.Produce.ShinyCompetition.IShinyCompetitionRankingConnector
{
    protected PRISM.Adapters.Produce.ShinyCompetition.ShinyCompetitionRankingArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
}

// Namespace: PRISM.Interactions.Produce.ShinyCompetition
public class ShinyCompetitionRankingView : UnityEngine.MonoBehaviour, PRISM.Adapters.Produce.ShinyCompetition.IShinyCompetitionRankingView
{
    private PRISM.Interactions.ToggleGroupView toggleGroupView;
    private PRISM.Interactions.Produce.ShinyCompetitionRankingTabView rankingTabView;
    private PRISM.Interactions.Produce.ShinyCompetitionRewardTabView rewardTabView;
    private PRISM.CommonInputFieldTMP commentInput;
    private UniRx.Subject<string> onEditCommentSubject;
    public System.IObservable<string> OnEditComment { get; set; }
    public Cysharp.Threading.Tasks.UniTask SetupAsync(int firstTabIndex, PRISM.Adapters.ShinyCompetitionRankingViewModel viewModel, PRISM.ResourceManagement.IResourceLoader loader, System.Threading.CancellationToken ct);
    public void UpdateCommentText(string comment);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Definitions.MstShinyCompetitionRanking, int> <>9__7_4;
        public static System.Func<PRISM.Definitions.MstShinyCompetitionRanking, int> <>9__7_5;
        private int <SetupAsync>b__7_4(PRISM.Definitions.MstShinyCompetitionRanking x);
        private int <SetupAsync>b__7_5(PRISM.Definitions.MstShinyCompetitionRanking x);
    }

    private class <>c__DisplayClass7_0
    {
        public PRISM.Adapters.ShinyCompetitionRankingViewModel viewModel;
        public System.Threading.CancellationToken ct;
        public PRISM.Interactions.Produce.ShinyCompetition.ShinyCompetitionRankingView <>4__this;
        private Cysharp.Threading.Tasks.UniTaskVoid <SetupAsync>b__0(int rankingId);
        private Cysharp.Threading.Tasks.UniTaskVoid <SetupAsync>b__1(string originId);
        private Cysharp.Threading.Tasks.UniTaskVoid <SetupAsync>b__2(int rankingId);
        private void <SetupAsync>b__3(string newComment);

        private struct <<SetupAsync>b__0>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
        {
            public int <>1__state;
            public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
            public <>c__DisplayClass7_0 <>4__this;
            public int rankingId;
            private Awaiter<System.Collections.Generic.IReadOnlyList<PRISM.Adapters.ShinyCompetitionRankingTop100ListViewModel>> <>u__1;
            private void MoveNext();
            private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }

        private struct <<SetupAsync>b__1>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
        {
            public int <>1__state;
            public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
            public <>c__DisplayClass7_0 <>4__this;
            public string originId;
            private Awaiter<PRISM.Module.Networking.IFesUnitStatus> <>u__1;
            private Awaiter <>u__2;
            private void MoveNext();
            private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }

        private struct <<SetupAsync>b__2>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
        {
            public int <>1__state;
            public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
            public <>c__DisplayClass7_0 <>4__this;
            public int rankingId;
            private Awaiter<System.Collections.Generic.IReadOnlyList<PRISM.Adapters.ShinyCompetitionRankingRewardListViewModel>> <>u__1;
            private void MoveNext();
            private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }

    private struct <SetupAsync>d__7 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Adapters.ShinyCompetitionRankingViewModel viewModel;
        public System.Threading.CancellationToken ct;
        public PRISM.Interactions.Produce.ShinyCompetition.ShinyCompetitionRankingView <>4__this;
        private <>c__DisplayClass7_0 <>8__1;
        public PRISM.ResourceManagement.IResourceLoader loader;
        public int firstTabIndex;
        private System.Collections.Generic.IReadOnlyList<PRISM.Adapters.ShinyCompetitionRankingTop100ListViewModel> <firstTop100RankingViewModelList>5__2;
        private Awaiter<System.Collections.Generic.IReadOnlyList<PRISM.Adapters.ShinyCompetitionRankingTop100ListViewModel>> <>u__1;
        private Awaiter<System.Collections.Generic.IReadOnlyList<PRISM.Adapters.ShinyCompetitionRankingRewardListViewModel>> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Produce.ShinyCompetition
public class ShinyCompetitionTopView : UnityEngine.MonoBehaviour, PRISM.Adapters.Produce.ShinyCompetition.IShinyCompetitionTopView
{
    private PRISM.Interactions.StaminaView staminaView;
    private UnityEngine.UI.RawImage[] produceIdolImages;
    private PRISM.Interactions.CharacterBaseIconView[] recommendPIdolIcons;
    private PRISM.Interactions.ButtonView howToPlayButton;
    private UnityEngine.GameObject recordButtonObject;
    private PRISM.Interactions.ButtonView recordButton;
    private PRISM.Interactions.ButtonView rewardButton;
    private PRISM.Interactions.ButtonView rankingButton;
    private PRISM.Interactions.ButtonView bonusButton;
    private PRISM.Interactions.ButtonView produceButton;
    private ENTERPRISE.UI.UITextMeshProUGUI startTimeText;
    private ENTERPRISE.UI.UITextMeshProUGUI endTimeText;
    private ENTERPRISE.UI.UITextMeshProUGUI remainTimeText;
    private UnityEngine.GameObject aggregationObject;
    private ENTERPRISE.UI.UITextMeshProUGUI aggregationTimeText;
    private UnityEngine.GameObject resultObject;
    private ENTERPRISE.UI.UITextMeshProUGUI resultTimeText;
    private ENTERPRISE.UI.UITextMeshProUGUI rankingPointText;
    private PRISM.HowToPlayPopupOpener howToPlayOpener;
    public PRISM.Adapters.IStaminaView StaminaView { get; set; }
    public System.IObservable<UniRx.Unit> OnClickHowToPlay { get; set; }
    public System.IObservable<UniRx.Unit> OnClickRecord { get; set; }
    public System.IObservable<UniRx.Unit> OnMoveReward { get; set; }
    public System.IObservable<UniRx.Unit> OnMoveRanking { get; set; }
    public System.IObservable<UniRx.Unit> OnClickBonus { get; set; }
    public System.IObservable<UniRx.Unit> OnMoveProduce { get; set; }
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Adapters.Produce.ShinyCompetition.ShinyCompetitionTopViewModel viewModel, PRISM.ResourceManagement.IResourceLoader loader, System.Threading.CancellationToken ct);
    public void SetupClosed();
    public Cysharp.Threading.Tasks.UniTask OpenHowToPlayPopupAsync(bool isOnBeginIdle, System.Threading.CancellationToken ct);
    public void SetActiveRecordButton(bool isActive);
    private string _getDateText(System.Nullable<System.DateTime> date);
    private string _getExpiredTimeText(System.DateTime endDate);

    private struct <SetupAsync>d__33 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Produce.ShinyCompetition.ShinyCompetitionTopView <>4__this;
        public PRISM.Adapters.Produce.ShinyCompetition.ShinyCompetitionTopViewModel viewModel;
        public PRISM.ResourceManagement.IResourceLoader loader;
        public System.Threading.CancellationToken ct;
        private int <i>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=15492 6A829A42FEC01793576821DAB45DDFC18E3B5E73400EC68CD75D86C54517E982;
    private static __StaticArrayInitTypeSize=25851 89CCC3A4A46943EA1B6A0301434497382DEB762602EDEB1293CA4E880994F557;

    private struct __StaticArrayInitTypeSize=15492 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=25851 : System.ValueType
    {
    }
}
