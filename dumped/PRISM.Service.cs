
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

// Namespace: PRISM.Service
public class AnnounceModel
{
    private static int PageLimit;
    private System.Collections.Generic.Dictionary<AnnounceCategory, CategoryInfo> categoryInfos;
    private PRISM.Domain.IAnnounceService announceService;
    private System.Collections.Generic.IReadOnlyList<AnnounceCategory> <VisibleCategories>k__BackingField;
    public System.Collections.Generic.IReadOnlyList<AnnounceCategory> VisibleCategories { get; set; }
    public static Cysharp.Threading.Tasks.UniTask<PRISM.Service.AnnounceModel> CreateAsync(PRISM.Domain.IAnnounceService announceService, System.Threading.CancellationToken ct);
    public CategoryInfo GetCategoryInfo(AnnounceCategory category);
    public Cysharp.Threading.Tasks.UniTask ReloadCategoryInfoAsync(AnnounceCategory category, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask RequestMoreDataAsync(AnnounceCategory category, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask<PRISM.Module.Networking.IAnnounceDetailStatus> GetAnnounceDetailReplyAsync(string articleId, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask<PRISM.Module.Networking.IGetAnnouncePopUpReply> GetAnnouncePopUpReplyAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask<PRISM.Module.Networking.IConfirmedAnnounceReply> ConfirmedAnnounceReplyAsync(string articleId, System.Threading.CancellationToken ct);

    public class CategoryInfo
    {
        private string <cursor>k__BackingField;
        private System.Collections.Generic.List<PRISM.Module.Networking.IAnnounceStatus> <announceStatusList>k__BackingField;
        public string cursor { get; set; }
        public System.Collections.Generic.List<PRISM.Module.Networking.IAnnounceStatus> announceStatusList { get; set; }
    }

    private class <>c__DisplayClass10_0
    {
        public CategoryInfo info;
        private bool <RequestMoreDataAsync>b__0(PRISM.Module.Networking.IAnnounceStatus x);
    }

    private class <>c__DisplayClass10_1
    {
        public PRISM.Module.Networking.IAnnounceStatus x;
        private bool <RequestMoreDataAsync>b__1(PRISM.Module.Networking.IAnnounceStatus y);
    }

    private struct <ConfirmedAnnounceReplyAsync>d__13 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<PRISM.Module.Networking.IConfirmedAnnounceReply> <>t__builder;
        public PRISM.Service.AnnounceModel <>4__this;
        public string articleId;
        public System.Threading.CancellationToken ct;
        private Awaiter<PRISM.Module.Networking.IConfirmedAnnounceReply> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <CreateAsync>d__7 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<PRISM.Service.AnnounceModel> <>t__builder;
        public PRISM.Domain.IAnnounceService announceService;
        public System.Threading.CancellationToken ct;
        private PRISM.Service.AnnounceModel <model>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <GetAnnounceDetailReplyAsync>d__11 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<PRISM.Module.Networking.IAnnounceDetailStatus> <>t__builder;
        public PRISM.Service.AnnounceModel <>4__this;
        public string articleId;
        public System.Threading.CancellationToken ct;
        private Awaiter<PRISM.Module.Networking.IGetAnnounceDetailReply> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <GetAnnouncePopUpReplyAsync>d__12 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<PRISM.Module.Networking.IGetAnnouncePopUpReply> <>t__builder;
        public PRISM.Service.AnnounceModel <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter<PRISM.Module.Networking.IGetAnnouncePopUpReply> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <ReloadCategoryInfoAsync>d__9 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Service.AnnounceModel <>4__this;
        public AnnounceCategory category;
        public System.Threading.CancellationToken ct;
        private CategoryInfo <info>5__2;
        private Awaiter<PRISM.Module.Networking.IGetAnnounceListReply> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <RequestMoreDataAsync>d__10 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Service.AnnounceModel <>4__this;
        public AnnounceCategory category;
        public System.Threading.CancellationToken ct;
        private <>c__DisplayClass10_0 <>8__1;
        private Awaiter<PRISM.Module.Networking.IGetAnnounceListReply> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Service
public class TransferContactPopupModel
{
    public Cysharp.Threading.Tasks.UniTask<string> GetContactUrlAsync(System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask<PRISM.Module.Networking.IGetVersionReply> _getVersionAsync(System.Threading.CancellationToken ct);

    private struct <GetContactUrlAsync>d__0 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<string> <>t__builder;
        public PRISM.Service.TransferContactPopupModel <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter<PRISM.Module.Networking.IGetVersionReply> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Service
public class FilterItem`1<T>
{
    private System.Func<T, System.Collections.Generic.ISet<int>, bool> matchFunction;
    public System.Collections.Generic.IEnumerable<T> Apply(System.Collections.Generic.IEnumerable<T> query, System.Collections.Generic.ISet<int> onIds);

    private class <>c__DisplayClass1_0<T>
    {
        public System.Func<T, int> idGetter;
        private bool <.ctor>b__0(T data, System.Collections.Generic.ISet<int> onIds);
    }

    private class <>c__DisplayClass2_0<T>
    {
        public System.Func<T, System.Collections.Generic.IEnumerable<int>> idsGetter;
        private bool <.ctor>b__0(T data, System.Collections.Generic.ISet<int> onIds);
        private bool <.ctor>b__1(T data, System.Collections.Generic.ISet<int> onIds);
    }

    private class <>c__DisplayClass4_0<T>
    {
        public PRISM.Service.FilterItem<T> <>4__this;
        public System.Collections.Generic.ISet<int> onIds;
        private bool <Apply>b__0(T data);
    }
}

// Namespace: PRISM.Service
public enum FilterMatchType : System.Enum
{
    public int value__;
    public static PRISM.Service.FilterMatchType And;
    public static PRISM.Service.FilterMatchType Or;
}

// Namespace: PRISM.Service
public interface ISortFilterModel
{
    public System.Collections.Generic.IEnumerable<PRISM.Definitions.SortType> SortTypes { get; set; }
    public System.Collections.Generic.IEnumerable<PRISM.Definitions.FilterType> FilterTypes { get; set; }
    public UniRx.IReadOnlyReactiveProperty<PRISM.Definitions.SortFilterSettings> CurrentSettings { get; set; }
    public void UpdateSettings(PRISM.Definitions.SortFilterSettings settings);
}

// Namespace: PRISM.Service
public class SortFilterModel`1<T> : PRISM.Service.ISortFilterModel, System.IDisposable
{
    private UniRx.ReactiveProperty<PRISM.Definitions.SortFilterSettings> currentSettings;
    private UniRx.ReactiveProperty<System.Collections.Generic.IReadOnlyList<T>> currentData;
    private System.Collections.Generic.IReadOnlyList<T> allData;
    private System.Collections.Generic.IReadOnlyDictionary<PRISM.Definitions.SortType, PRISM.Service.SortItem<T>> sortItems;
    private System.Collections.Generic.IReadOnlyDictionary<PRISM.Definitions.FilterType, PRISM.Service.FilterItem<T>> filterItems;
    public System.Collections.Generic.IEnumerable<PRISM.Definitions.SortType> SortTypes { get; set; }
    public System.Collections.Generic.IEnumerable<PRISM.Definitions.FilterType> FilterTypes { get; set; }
    public UniRx.IReadOnlyReactiveProperty<PRISM.Definitions.SortFilterSettings> CurrentSettings { get; set; }
    public UniRx.IReadOnlyReactiveProperty<System.Collections.Generic.IReadOnlyList<T>> CurrentData { get; set; }
    public void UpdateSettings(PRISM.Definitions.SortFilterSettings settings);
    public void UpdateAllData(System.Collections.Generic.IReadOnlyList<T> allData);
    private System.Collections.Generic.IEnumerable<T> _apply(System.Collections.Generic.IEnumerable<T> query, PRISM.Definitions.SortFilterSettings settings);
    public void Dispose();
}

// Namespace: PRISM.Service
public class SortItem`1<T>
{
    public System.Func<System.Collections.Generic.IEnumerable<T>, PRISM.Definitions.SortDirection, System.Linq.IOrderedEnumerable<T>> Sorter;
    public static PRISM.Service.SortItem<T> Create<TKey>(System.Func<T, TKey> keySelector, AdditionalSorter<T> additionalSorter);

    public class AdditionalSorter<T> : System.MulticastDelegate
    {
        public System.Linq.IOrderedEnumerable<T> Invoke(System.Linq.IOrderedEnumerable<T> query);
        public System.IAsyncResult BeginInvoke(System.Linq.IOrderedEnumerable<T> query, System.AsyncCallback callback, object object);
        public System.Linq.IOrderedEnumerable<T> EndInvoke(System.IAsyncResult result);
    }

    private class <>c__DisplayClass3_0`1<T, TKey>
    {
        public System.Func<T, TKey> keySelector;
        public AdditionalSorter<T> additionalSorter;
        private System.Linq.IOrderedEnumerable<T> <Create>b__0(System.Collections.Generic.IEnumerable<T> query, PRISM.Definitions.SortDirection direction);
    }
}

// Namespace: PRISM.Service
public class LiveEventSaveData : UnityEngine.ISerializationCallbackReceiver
{
    private System.Collections.Generic.List<int> onceDisplayedResult;
    private int[] albumViewedIds;
    private long lastViewedBeginBreakTime;
    private int selectedAllSongIdolTab;
    private bool isShowSelfRankBorder;
    private System.Collections.Generic.HashSet<int> albumViewedIdsHashSet;
    public bool IsShowSelfRankBorder { get; set; }
    public int SelectedAllSongIdolTab { get; set; }
    public void SetAlbumViewed(int id);
    public bool IsAlbumViewed(int id);
    public bool HasDisplayedResult(int eventId);
    public void SetDisplayedResult(int eventId);
    public bool NeedsBreakTimePopup(System.DateTime beginBreakTime);
    public void SetLastViewedBreakTime(System.DateTime beginBreakTime);
    private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
    private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
}

// Namespace: PRISM.Service
public class MedalGashaSaveData : UnityEngine.ISerializationCallbackReceiver
{
    private int[] isUnLockedHashSetIds;
    private int gashaCountSetting;
    private System.Collections.Generic.HashSet<int> isUnLockedHashSet;
    public int GashaCountSetting { get; set; }
    public bool IsLocked(int gashaId);
    public void Apply(int gashaId, bool isOn);
    public void OnBeforeSerialize();
    public void OnAfterDeserialize();
}

// Namespace: PRISM.Service
public class RunwayUnitConfirmationSaveData
{
    private int selectedUnitIndex;
    private int selectedUnitEditTabType;
    private bool isShowUnlockedCostumeOnly;
    public int SelectedUnitIndex { get; set; }
    public int SelectedUnitEditTabType { get; set; }
    public bool IsShowUnlockedCostumeOnly { get; set; }
    public void ApplySelectedUnitIndex(int index);
    public void ApplySelectedUnitEditTabType(int type);
    public void ApplyShowUnlockedCostumeOnly(bool unlockOnly);
}

// Namespace: PRISM.Service
public class TechnicalChallengeSaveData
{
    private SongDifficultyLevel selectedDifficultyLevel;
    private int firstTimeOpenRankingResultLastEventId;
    public SongDifficultyLevel SelectedDifficultyLevel { get; set; }
    public int FirstTimeOpenRankingResultLastEventId { get; set; }
}

// Namespace: PRISM.Service
public class FesDataPossessionLimitChecker
{
    public static Cysharp.Threading.Tasks.UniTask<System.ValueTuple<bool, int>> Check(System.Threading.CancellationToken ct);

    private struct <Check>d__0 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<System.ValueTuple<bool, int>> <>t__builder;
        public System.Threading.CancellationToken ct;
        private Awaiter<int> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Service
public class MissionSaveData : UnityEngine.ISerializationCallbackReceiver
{
    private int[] readMissionIds;
    private System.Collections.Generic.List<PRISM.Service.MissionRemindSaveData> reminds;
    public System.Collections.Generic.HashSet<int> ReadMissionIds;
    public void OnBeforeSerialize();
    public void OnAfterDeserialize();
    public PRISM.Service.MissionRemindSaveData GetRemind(int missionGroupId);
    public void ClearRemind();

    private class <>c__DisplayClass5_0
    {
        public int missionGroupId;
        private bool <GetRemind>b__0(PRISM.Service.MissionRemindSaveData x);
    }
}

// Namespace: PRISM.Service
public class MissionRemindSaveData
{
    private int missionGroupId;
    private int displayCount;
    private long lastDisplayDate;
    public int MissionGroupId { get; set; }
    public int DisplayCount { get; set; }
    public System.DateTime LastDisplayDate { get; set; }
    public void SetDisplayed(System.DateTime date);
}

// Namespace: PRISM.Service
public class NotificationSaveData
{
    public string StaminaNotificationId;
    public string LiveBonusNotificationId;
    public string DailyMissionNotificationId;
    public int DailyMissionNotificationDay;
    public string UserBirthdayNotificationId;
    public string ComebackNotificationId;
    public void Reset();
}

// Namespace: PRISM.Service
public class AutoIngameModel
{
    private PRISM.Produce.ProduceBaseModel baseModel;
    private UniRx.CompositeDisposable disposable;
    private bool isRun;
    private bool isWin;
    private System.Threading.CancellationToken cancellation;
    public void SetupLesson(PRISM.Module.Networking.ITrainerStatus trainer, PRISM.Module.Networking.IOpponentStatus opponent, PRISM.Module.Networking.IProduceBaseInfoStatus baseInfo, ScheduleDetailType scheduleDetailType);
    public void SetupAuditon(PRISM.Module.Networking.IRivalUnitStatus rivalUnitData, PRISM.Module.Networking.IOpponentStatus opponentData, PRISM.Module.Networking.IProduceBaseInfoStatus baseInfo);
    private Cysharp.Threading.Tasks.UniTask _startIngameModelAsync(System.Threading.CancellationToken token);
    public void Terminate();
    public PRISM.Module.Networking.IInGameResultStatus Execute();
    public void CalcUpdate(float deltaTime);
    private void <_startIngameModelAsync>b__7_0(GameEndStatus status);

    private struct <_startIngameModelAsync>d__7 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Service.AutoIngameModel <>4__this;
        public System.Threading.CancellationToken token;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Service
public class AutoModePCardModel
{
    private static SimplePhase DefaultPhase;
    private PRISM.Module.Networking.IProduceCardStatus produceCard;
    private ProduceParameterType[] appealTypes;
    private int baseCost;
    private bool isCardRankOverWrite;
    private int overWriteCardRank;
    public int UnitID { get; set; }
    public int ProduceCardID { get; set; }
    public string ID { get; set; }
    public int Cost { get; set; }
    public ProduceParameterType AppealTypeFirst { get; set; }
    public int GetStrengthScore();
    public void AddOverWriteCardRank(int addRank);
    public void ResetOverWriteCardRank();
    public int GetCardRank();
    public int CalcGrowRank();
    public int GetMaxRank();
    public bool IsUnitCard();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<ProduceParameterType, bool> <>9__16_0;
        public static System.Func<ProduceParameterType, bool> <>9__16_1;
        private bool <.ctor>b__16_0(ProduceParameterType e);
        private bool <.ctor>b__16_1(ProduceParameterType e);
    }
}

// Namespace: PRISM.Service
public class CardSeceltModel
{
    private PRISM.Produce.AiPatternDataScriptableObject aiPatternDataScriptableObject;
    private PRISM.Service.ProduceAutoSettingModel produceAutoSettingModel;
    private System.Collections.Generic.List<ScoreData> selectScoreList;
    private System.Collections.Generic.List<PRISM.Service.AutoModePCardModel> selectCardList;
    private System.Random random;
    private float[] lowCostRate;
    private float[] middleCostRate;
    private float[] highCostRate;
    private float[] balanceCostRate;
    private static int ScoreBorderline;
    private static int DeleteBorcerLine;
    private int unitId;
    private System.Collections.Generic.List<PRISM.Service.AutoModePCardModel> deckList;
    private System.Collections.Generic.List<PRISM.Service.AutoModePCardModel> cardList;
    private System.Collections.Generic.List<PRISM.Service.AutoModePCardModel> rankUpSelectList;
    private int maxDeleteCardNum;
    public void Setup(PRISM.Produce.AiPatternDataScriptableObject aiPatternDataScriptableObject, PRISM.Service.ProduceAutoSettingModel produceAutoSettingModel, int unitId, int deleteCardNum);
    public System.Collections.Generic.IReadOnlyList<string> CalcSelectCard(System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceCardStatus> cards, int num, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceCardStatus> deckCrads, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IInProduceIdolSkillStatus> idolSkills, bool isAdd);
    public System.Collections.Generic.IReadOnlyList<string> CalcRankUpCardList(System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceCardStatus> deckCards, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IInProduceIdolSkillStatus> idolSkills, int rankUpNum);
    private PRISM.Service.AutoModePCardModel _calcRankUpCard(System.Collections.Generic.List<PRISM.Service.AutoModePCardModel> targetCardList, System.Collections.Generic.IReadOnlyList<PRISM.Service.AutoModePCardModel> randUppedList, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IInProduceIdolSkillStatus> idolSkills);
    private int _calcBestScore(System.Collections.Generic.IReadOnlyList<ScoreData> scoreCards);
    private int _calcLowCost(System.Collections.Generic.IReadOnlyList<ScoreData> scoreCards);
    private System.Collections.Generic.List<ScoreData> _calcCardScoreList(System.Collections.Generic.IReadOnlyList<PRISM.Service.AutoModePCardModel> cardList, System.Collections.Generic.IReadOnlyList<PRISM.Service.AutoModePCardModel> deckList, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IInProduceIdolSkillStatus> idolSkills, bool isAdd);
    private System.Collections.Generic.IReadOnlyList<ScoreData> _calcCardScore(System.Collections.Generic.IReadOnlyList<PRISM.Service.AutoModePCardModel> cardList, System.Collections.Generic.IReadOnlyList<PRISM.Service.AutoModePCardModel> deckList, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IInProduceIdolSkillStatus> idolSkills, bool isAdd);
    private System.Collections.Generic.IReadOnlyList<PRISM.Service.AutoModePCardModel> _calcSelectCardScoreList(System.Collections.Generic.IReadOnlyList<PRISM.Service.AutoModePCardModel> cardList, System.Collections.Generic.IReadOnlyList<PRISM.Service.AutoModePCardModel> deckList, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IInProduceIdolSkillStatus> idolSkills, int maxNum, int deleteCardNum, bool isAdd);
    private int _calcComboScore(PRISM.Produce.EditorAiPattern comboSet, PRISM.Service.AutoModePCardModel card, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IInProduceIdolSkillStatus> idolSkills, bool isFarstCard);
    private int _calcScore(PRISM.Service.AutoModePCardModel card, System.Collections.Generic.IReadOnlyList<PRISM.Service.AutoModePCardModel> deckList, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IInProduceIdolSkillStatus> idolSkills, bool isAdd);
    private bool _isFindById(System.Collections.Generic.IReadOnlyList<PRISM.Service.AutoModePCardModel> cards, int id);
    private PRISM.Service.AutoModePCardModel _findById(System.Collections.Generic.IReadOnlyList<PRISM.Service.AutoModePCardModel> cards, int id);
    private bool _isFindBySkillId(System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IInProduceIdolSkillStatus> idolSkills, int id);
    private PRISM.Module.Networking.IInProduceIdolSkillStatus _findBySkillId(System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IInProduceIdolSkillStatus> idolSkills, int id);
    private float _calcBestNumDiff(int cost, System.Collections.Generic.IReadOnlyList<PRISM.Service.AutoModePCardModel> deckList, bool isAdd);
    private int _getNumByCost(int cost, System.Collections.Generic.IReadOnlyList<PRISM.Service.AutoModePCardModel> deckList);
    private float _getBestCardNumRate(int cost);

    private struct ScoreData : System.ValueType
    {
        private int <Score>k__BackingField;
        private PRISM.Service.AutoModePCardModel <Card>k__BackingField;
        public int Score { get; set; }
        public PRISM.Service.AutoModePCardModel Card { get; set; }
    }

    private class <>c
    {
        public static <>c <>9;
        public static System.Predicate<PRISM.Service.AutoModePCardModel> <>9__19_0;
        public static System.Predicate<PRISM.Service.AutoModePCardModel> <>9__20_10;
        public static System.Predicate<PRISM.Service.AutoModePCardModel> <>9__20_11;
        public static System.Predicate<PRISM.Service.AutoModePCardModel> <>9__20_12;
        public static System.Predicate<PRISM.Service.AutoModePCardModel> <>9__20_13;
        public static System.Predicate<PRISM.Service.AutoModePCardModel> <>9__20_14;
        public static System.Predicate<PRISM.Service.AutoModePCardModel> <>9__20_15;
        public static System.Predicate<ScoreData> <>9__20_4;
        public static System.Predicate<ScoreData> <>9__20_5;
        public static System.Comparison<ScoreData> <>9__23_0;
        public static System.Comparison<ScoreData> <>9__23_1;
        private bool <CalcRankUpCardList>b__19_0(PRISM.Service.AutoModePCardModel card);
        private bool <_calcRankUpCard>b__20_10(PRISM.Service.AutoModePCardModel card);
        private bool <_calcRankUpCard>b__20_11(PRISM.Service.AutoModePCardModel card);
        private bool <_calcRankUpCard>b__20_12(PRISM.Service.AutoModePCardModel card);
        private bool <_calcRankUpCard>b__20_13(PRISM.Service.AutoModePCardModel card);
        private bool <_calcRankUpCard>b__20_14(PRISM.Service.AutoModePCardModel card);
        private bool <_calcRankUpCard>b__20_15(PRISM.Service.AutoModePCardModel card);
        private bool <_calcRankUpCard>b__20_4(ScoreData scoreData);
        private bool <_calcRankUpCard>b__20_5(ScoreData scoreData);
        private int <_calcCardScoreList>b__23_0(ScoreData a, ScoreData b);
        private int <_calcCardScoreList>b__23_1(ScoreData a, ScoreData b);
    }

    private class <>c__DisplayClass20_0
    {
        public int bestScore;
        public int lowCost;
        private bool <_calcRankUpCard>b__0(ScoreData scoreData);
        private bool <_calcRankUpCard>b__1(ScoreData scoreData);
        private bool <_calcRankUpCard>b__2(ScoreData scoreData);
        private bool <_calcRankUpCard>b__3(ScoreData scoreData);
        private bool <_calcRankUpCard>b__6(ScoreData scoreData);
        private bool <_calcRankUpCard>b__7(ScoreData scoreData);
        private bool <_calcRankUpCard>b__8(ScoreData scoreData);
        private bool <_calcRankUpCard>b__9(ScoreData scoreData);
    }

    private class <>c__DisplayClass27_0
    {
        public PRISM.Service.CardSeceltModel <>4__this;
        public PRISM.Service.AutoModePCardModel card;
        public System.Predicate<PRISM.Produce.EditorAiCombo> <>9__2;
        private bool <_calcScore>b__1(PRISM.Produce.EditorAiPattern Item);
        private bool <_calcScore>b__0(PRISM.Produce.EditorAiSynergy Item);
        private bool <_calcScore>b__2(PRISM.Produce.EditorAiCombo synergy);
    }
}

// Namespace: PRISM.Service
public class CardSelectAiData
{
    private ParameterType <Parameter>k__BackingField;
    private DeckCostType <DeckCost>k__BackingField;
    private bool <IsAppealMentalDamage>k__BackingField;
    private bool <IsAppealMentalRecovery>k__BackingField;
    private bool <IsAppealPointRateUp>k__BackingField;
    private bool <IsBeforeUseProducePoint>k__BackingField;
    private bool <IsMentalGuard>k__BackingField;
    private bool <IsContinueAppeal>k__BackingField;
    private bool <IsFixValue>k__BackingField;
    private bool <IsTime>k__BackingField;
    private bool <IsNotGet>k__BackingField;
    private bool <IsMentalRecoveryOthers>k__BackingField;
    private bool <IsAppealPointRateUpOthers>k__BackingField;
    private bool <IsRecoveryIdolSkillCountOthers>k__BackingField;
    private bool <IsSwapCardOthers>k__BackingField;
    private bool <IsGetMentalGuardOthers>k__BackingField;
    private bool <IsNotGetOthers>k__BackingField;
    private bool <IsNoneEffectAvoid>k__BackingField;
    private bool <IsAppealPointRateUpAvoid>k__BackingField;
    private bool <IsMentalDamageUpAvoid>k__BackingField;
    private bool <IsAvoidCountRef>k__BackingField;
    private bool <IsMentalRecoveryAvoid>k__BackingField;
    private bool <IsNotGetAvoid>k__BackingField;
    private bool <IsAppealPointRateUpAvoidBuff>k__BackingField;
    private bool <IsAppealPointAvoidCountRateUpAvoidBuff>k__BackingField;
    private bool <IsAppealPointAvoidBuffCountRateUpAvoidBuff>k__BackingField;
    private bool <IsNotGetAvoidBuff>k__BackingField;
    private bool <IsAppealAvoidBuffNoConsumption>k__BackingField;
    private bool <IsAppealAvoidRateRef>k__BackingField;
    private bool <IsNotGetNoNoctyl>k__BackingField;
    public ParameterType Parameter { get; set; }
    public DeckCostType DeckCost { get; set; }
    public bool IsAppealMentalDamage { get; set; }
    public bool IsAppealMentalRecovery { get; set; }
    public bool IsAppealPointRateUp { get; set; }
    public bool IsBeforeUseProducePoint { get; set; }
    public bool IsMentalGuard { get; set; }
    public bool IsContinueAppeal { get; set; }
    public bool IsFixValue { get; set; }
    public bool IsTime { get; set; }
    public bool IsNotGet { get; set; }
    public bool IsMentalRecoveryOthers { get; set; }
    public bool IsAppealPointRateUpOthers { get; set; }
    public bool IsRecoveryIdolSkillCountOthers { get; set; }
    public bool IsSwapCardOthers { get; set; }
    public bool IsGetMentalGuardOthers { get; set; }
    public bool IsNotGetOthers { get; set; }
    public bool IsNoneEffectAvoid { get; set; }
    public bool IsAppealPointRateUpAvoid { get; set; }
    public bool IsMentalDamageUpAvoid { get; set; }
    public bool IsAvoidCountRef { get; set; }
    public bool IsMentalRecoveryAvoid { get; set; }
    public bool IsNotGetAvoid { get; set; }
    public bool IsAppealPointRateUpAvoidBuff { get; set; }
    public bool IsAppealPointAvoidCountRateUpAvoidBuff { get; set; }
    public bool IsAppealPointAvoidBuffCountRateUpAvoidBuff { get; set; }
    public bool IsNotGetAvoidBuff { get; set; }
    public bool IsAppealAvoidBuffNoConsumption { get; set; }
    public bool IsAppealAvoidRateRef { get; set; }
    public bool IsNotGetNoNoctyl { get; set; }

    public enum ParameterType : System.Enum
    {
        public int value__;
        public static ParameterType Vocal;
        public static ParameterType Dance;
        public static ParameterType Visual;
        public static ParameterType VocalAndDance;
        public static ParameterType VocalAndVisual;
        public static ParameterType DanceAndVisual;
        public static ParameterType None;
    }

    public enum DeckCostType : System.Enum
    {
        public int value__;
        public static DeckCostType High;
        public static DeckCostType Middle;
        public static DeckCostType Low;
        public static DeckCostType None;
    }
}

// Namespace: PRISM.Service
public class AuditionAutoExecModel : PRISM.Service.IInGameAutoExecModel
{
    private PRISM.Domain.IProduceService service;
    private UniRx.Subject<PRISM.Module.Networking.IProduceFailureResultReply> onFailure;
    private System.Func<PRISM.Module.Networking.IStartAuditionReply, PRISM.Module.Networking.IInGameResultStatus> <OnExecuteAudition>k__BackingField;
    private System.Func<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>>> <OnExecScenarioAsync>k__BackingField;
    private System.Func<PRISM.Module.Networking.IStartAuditionReply, PRISM.Module.Networking.IInGameResultStatus> OnExecuteAudition { get; set; }
    private System.Func<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>>> OnExecScenarioAsync { get; set; }
    public System.IObservable<PRISM.Module.Networking.IProduceFailureResultReply> OnFailure { get; set; }
    public void Inject(PRISM.Domain.IProduceService service);
    public Cysharp.Threading.Tasks.UniTask<PRISM.Module.Networking.IInGameResultStatus> ExecInGameAsync(System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>> ExecSuccessResultAsync(PRISM.Module.Networking.IInGameResultStatus result, System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>> ExecFailureResultAsync(PRISM.Module.Networking.IInGameResultStatus result, System.Threading.CancellationToken cancellationToken);
    public void Terminate();

    private struct <ExecFailureResultAsync>d__15 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>> <>t__builder;
        public PRISM.Service.AuditionAutoExecModel <>4__this;
        public System.Threading.CancellationToken cancellationToken;
        private Awaiter<PRISM.Module.Networking.IProduceFailureResultReply> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <ExecInGameAsync>d__13 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<PRISM.Module.Networking.IInGameResultStatus> <>t__builder;
        public PRISM.Service.AuditionAutoExecModel <>4__this;
        public System.Threading.CancellationToken cancellationToken;
        private Awaiter<PRISM.Module.Networking.IStartAuditionReply> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <ExecSuccessResultAsync>d__14 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>> <>t__builder;
        public PRISM.Service.AuditionAutoExecModel <>4__this;
        public PRISM.Module.Networking.IInGameResultStatus result;
        public System.Threading.CancellationToken cancellationToken;
        private Awaiter<PRISM.Module.Networking.IFinishAuditionReply> <>u__1;
        private Awaiter<PRISM.Module.Networking.IFinishAuditionResultReply> <>u__2;
        private Awaiter<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>> <>u__3;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Service
public interface IInGameAutoExecModel
{
    public void Inject(PRISM.Domain.IProduceService service);
    public Cysharp.Threading.Tasks.UniTask<PRISM.Module.Networking.IInGameResultStatus> ExecInGameAsync(System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>> ExecSuccessResultAsync(PRISM.Module.Networking.IInGameResultStatus result, System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>> ExecFailureResultAsync(PRISM.Module.Networking.IInGameResultStatus result, System.Threading.CancellationToken cancellationToken);
    public void Terminate();
}

// Namespace: PRISM.Service
public class LessonAutoExecModel : PRISM.Service.IInGameAutoExecModel
{
    private PRISM.Domain.IProduceService service;
    private System.Func<PRISM.Module.Networking.IStartLessonReply, PRISM.Module.Networking.IInGameResultStatus> <OnExecuteLesson>k__BackingField;
    private System.Func<System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceCardStatus>, int, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceCardStatus>, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IInProduceIdolSkillStatus>, System.Collections.Generic.IReadOnlyList<string>> <OnSelectProduceCard>k__BackingField;
    private System.Func<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>>> <OnExecScenarioAsync>k__BackingField;
    private System.Func<PRISM.Module.Networking.IStartLessonReply, PRISM.Module.Networking.IInGameResultStatus> OnExecuteLesson { get; set; }
    private System.Func<System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceCardStatus>, int, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceCardStatus>, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IInProduceIdolSkillStatus>, System.Collections.Generic.IReadOnlyList<string>> OnSelectProduceCard { get; set; }
    private System.Func<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>>> OnExecScenarioAsync { get; set; }
    public void Inject(PRISM.Domain.IProduceService service);
    public Cysharp.Threading.Tasks.UniTask<PRISM.Module.Networking.IInGameResultStatus> ExecInGameAsync(System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>> ExecSuccessResultAsync(PRISM.Module.Networking.IInGameResultStatus result, System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>> ExecFailureResultAsync(PRISM.Module.Networking.IInGameResultStatus result, System.Threading.CancellationToken cancellationToken);
    public void Terminate();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Module.Networking.IInProduceIdolStatus, PRISM.Module.Networking.IInProduceIdolSkillStatus> <>9__15_0;
        private PRISM.Module.Networking.IInProduceIdolSkillStatus <ExecSuccessResultAsync>b__15_0(PRISM.Module.Networking.IInProduceIdolStatus idol);
    }

    private struct <ExecFailureResultAsync>d__16 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>> <>t__builder;
        public PRISM.Service.LessonAutoExecModel <>4__this;
        public PRISM.Module.Networking.IInGameResultStatus result;
        public System.Threading.CancellationToken cancellationToken;
        private Awaiter<PRISM.Module.Networking.IFinishLessonReply> <>u__1;
        private Awaiter<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <ExecInGameAsync>d__14 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<PRISM.Module.Networking.IInGameResultStatus> <>t__builder;
        public PRISM.Service.LessonAutoExecModel <>4__this;
        public System.Threading.CancellationToken cancellationToken;
        private Awaiter<PRISM.Module.Networking.IStartLessonReply> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <ExecSuccessResultAsync>d__15 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>> <>t__builder;
        public PRISM.Service.LessonAutoExecModel <>4__this;
        public PRISM.Module.Networking.IInGameResultStatus result;
        public System.Threading.CancellationToken cancellationToken;
        private Awaiter<PRISM.Module.Networking.IFinishLessonReply> <>u__1;
        private Awaiter<PRISM.Module.Networking.IFinishLessonResultReply> <>u__2;
        private Awaiter<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>> <>u__3;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Service
public class ProduceInGameAutoExecModel
{
    private PRISM.Service.LessonAutoExecModel lessonExecModel;
    private PRISM.Service.SpecialLessonAutoExecModel specialLessonExecModel;
    private PRISM.Service.AuditionAutoExecModel auditionExecModel;
    public System.Func<PRISM.Module.Networking.IStartLessonReply, PRISM.Module.Networking.IInGameResultStatus> OnExecuteLesson { get; set; }
    public System.Func<System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceCardStatus>, int, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceCardStatus>, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IInProduceIdolSkillStatus>, System.Collections.Generic.IReadOnlyList<string>> OnSelectProduceCard { get; set; }
    public System.Func<PRISM.Module.Networking.IStartSpecialLessonReply, PRISM.Module.Networking.IInGameResultStatus> OnExecuteSpecialLesson { get; set; }
    public System.Func<System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceCardStatus>, int, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IInProduceIdolSkillStatus>, System.Collections.Generic.IReadOnlyList<string>> OnRankUpProduceCard { get; set; }
    public System.Func<PRISM.Module.Networking.IStartAuditionReply, PRISM.Module.Networking.IInGameResultStatus> OnExecuteAudition { get; set; }
    public System.Func<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>>> OnExecScenarioAsync { get; set; }
    public System.IObservable<PRISM.Module.Networking.IProduceFailureResultReply> OnFailure { get; set; }
    public void Inject(PRISM.Domain.IProduceService service);
    public Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus, bool>> ExecAsync(ProduceNextOrderType nextOrder, System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>> ExecResultAsync(ProduceNextOrderType nextOrder, PRISM.Module.Networking.IInGameResultStatus result, System.Threading.CancellationToken cancellationToken);
    public void Terminate();
    private Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus, bool>> _execInGameAsync(PRISM.Service.IInGameAutoExecModel execModel, System.Threading.CancellationToken cancellationToken);

    private struct <_execInGameAsync>d__21 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus, bool>> <>t__builder;
        public PRISM.Service.IInGameAutoExecModel execModel;
        public System.Threading.CancellationToken cancellationToken;
        private PRISM.Module.Networking.IInGameResultStatus <result>5__2;
        private Awaiter<PRISM.Module.Networking.IInGameResultStatus> <>u__1;
        private Awaiter<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Service
public class SpecialLessonAutoExecModel : PRISM.Service.IInGameAutoExecModel
{
    private PRISM.Domain.IProduceService service;
    private System.Func<PRISM.Module.Networking.IStartSpecialLessonReply, PRISM.Module.Networking.IInGameResultStatus> <OnExecuteSpecialLesson>k__BackingField;
    private System.Func<System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceCardStatus>, int, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IInProduceIdolSkillStatus>, System.Collections.Generic.IReadOnlyList<string>> <OnRankUpProduceCard>k__BackingField;
    private System.Func<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>>> <OnExecScenarioAsync>k__BackingField;
    private System.Func<PRISM.Module.Networking.IStartSpecialLessonReply, PRISM.Module.Networking.IInGameResultStatus> OnExecuteSpecialLesson { get; set; }
    private System.Func<System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceCardStatus>, int, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IInProduceIdolSkillStatus>, System.Collections.Generic.IReadOnlyList<string>> OnRankUpProduceCard { get; set; }
    private System.Func<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>>> OnExecScenarioAsync { get; set; }
    public void Inject(PRISM.Domain.IProduceService service);
    public Cysharp.Threading.Tasks.UniTask<PRISM.Module.Networking.IInGameResultStatus> ExecInGameAsync(System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>> ExecSuccessResultAsync(PRISM.Module.Networking.IInGameResultStatus result, System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>> ExecFailureResultAsync(PRISM.Module.Networking.IInGameResultStatus result, System.Threading.CancellationToken cancellationToken);
    public void Terminate();
    private Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>> _execResultAsync(PRISM.Module.Networking.IInGameResultStatus result, System.Threading.CancellationToken cancellationToken);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Module.Networking.IInProduceIdolStatus, PRISM.Module.Networking.IInProduceIdolSkillStatus> <>9__18_0;
        private PRISM.Module.Networking.IInProduceIdolSkillStatus <_execResultAsync>b__18_0(PRISM.Module.Networking.IInProduceIdolStatus idol);
    }

    private struct <ExecInGameAsync>d__14 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<PRISM.Module.Networking.IInGameResultStatus> <>t__builder;
        public PRISM.Service.SpecialLessonAutoExecModel <>4__this;
        public System.Threading.CancellationToken cancellationToken;
        private Awaiter<PRISM.Module.Networking.IStartSpecialLessonReply> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_execResultAsync>d__18 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>> <>t__builder;
        public PRISM.Service.SpecialLessonAutoExecModel <>4__this;
        public PRISM.Module.Networking.IInGameResultStatus result;
        public System.Threading.CancellationToken cancellationToken;
        private Awaiter<PRISM.Module.Networking.IFinishSpecialLessonReply> <>u__1;
        private Awaiter<PRISM.Module.Networking.ICardRankUpReply> <>u__2;
        private Awaiter<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>> <>u__3;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Service
public class ProduceAutoExecModel
{
    private PRISM.Domain.IProduceService service;
    private System.Func<PRISM.Module.Networking.IProduceBaseInfoStatus, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask> onProduceStartAsync;
    private System.Func<System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceAutoPlayProgressedSeasonStatus>, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask> onProduceResumeAsync;
    private PRISM.Service.ProduceSelectStrategyAutoExecModel selectStrategyModel;
    private PRISM.Service.ProduceSelectScheduleAutoExecModel selectScheduleModel;
    private PRISM.Service.ProduceInGameAutoExecModel inGameModel;
    private PRISM.Service.ProduceScenarioAutoExecModel scenarioModel;
    private PRISM.Service.ProduceResumeAutoExecModel resumeModel;
    private PRISM.Service.ScheduleSelectionAIModel scheduleSelectionAIModel;
    private PRISM.Service.CardSeceltModel cardSelectModel;
    private PRISM.Service.SubSeasonSelectModel subSeasonSelectModel;
    private PRISM.Service.SelectSupportSkill selectSupportSkillModel;
    private PRISM.Service.ProduceStrategySelectModel strategySelectModel;
    private PRISM.Service.AutoIngameModel autoInGameModel;
    private ProduceNextOrderType lastNextOrder;
    private PRISM.Module.Networking.IProduceBaseInfoStatus lastProduceBaseInfo;
    private System.Func<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus, bool> <OnCheckAutoPause>k__BackingField;
    public System.Func<PRISM.Module.Networking.IProduceBaseInfoStatus, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask> OnProduceStartAsync { get; set; }
    public System.Func<System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceAutoPlayProgressedSeasonStatus>, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask> OnProduceResumeAsync { get; set; }
    public System.Func<System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceStrategyStatus>, int> OnSelectStrategy { get; set; }
    public System.Func<PRISM.Module.Networking.IWeekScheduleStatus, PRISM.Module.Networking.IProduceBaseInfoStatus, ScheduleDetailType> OnSelectSchedule { get; set; }
    public System.Func<System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceCardStatus>, int, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IInProduceIdolSkillStatus>, System.Collections.Generic.IReadOnlyList<string>> OnDeleteProduceCard { get; set; }
    public System.Func<PRISM.Module.Networking.IProduceTermStatus, PRISM.Module.Networking.ISubSeasonStatus, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask> OnStartSeasonAsync { get; set; }
    public System.Func<ScheduleType, PRISM.Module.Networking.IScheduleDetailStatus, PRISM.Module.Networking.IProduceTermStatus, PRISM.Module.Networking.ISubSeasonStatus, bool, bool, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask> OnPostExecScheduleAsync { get; set; }
    public System.Func<PRISM.Module.Networking.IProduceTermStatus, PRISM.Module.Networking.ISubSeasonStatus, bool, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask> OnPostSingleExecScheduleAsync { get; set; }
    public System.Func<PRISM.Module.Networking.IStartLessonReply, PRISM.Module.Networking.IInGameResultStatus> OnExecuteLesson { get; set; }
    public System.Func<PRISM.Module.Networking.IStartSpecialLessonReply, PRISM.Module.Networking.IInGameResultStatus> OnExecuteSpecialLesson { get; set; }
    public System.Func<System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceCardStatus>, int, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IInProduceIdolSkillStatus>, System.Collections.Generic.IReadOnlyList<string>> OnRankUpProduceCard { get; set; }
    public System.Func<PRISM.Module.Networking.IStartAuditionReply, PRISM.Module.Networking.IInGameResultStatus> OnExecuteAudition { get; set; }
    public System.Func<System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceAdvOptionStatus>, int> OnSelectADVOption { get; set; }
    public System.Func<System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IGettablePotentialSupportSkillStatus>, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IInProducePotentialSupportSkillStatus>, int, int, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.ISelectionSupportSkillStatus>> OnInheritanceSkill { get; set; }
    public System.Func<System.Collections.Generic.IReadOnlyList<int>, int, int> OnSelectSubSeason { get; set; }
    public System.Func<System.Collections.Generic.IReadOnlyList<int>, int, int> OnSelectSubSeasonIdol { get; set; }
    public System.Func<System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceCardStatus>, int, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceCardStatus>, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IInProduceIdolSkillStatus>, System.Collections.Generic.IReadOnlyList<string>> OnSelectProduceCard { get; set; }
    public System.Func<System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IGettablePotentialSupportSkillStatus>, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IInProducePotentialSupportSkillStatus>, int, int, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.ISelectionSupportSkillStatus>> OnSelectSupportSkill { get; set; }
    private System.Func<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus, bool> OnCheckAutoPause { get; set; }
    public System.IObservable<PRISM.Module.Networking.IProduceFailureResultReply> OnInGameFailure { get; set; }
    public void Setup(PRISM.Domain.IProduceService produceService, PRISM.Service.ProduceAutoSettingModel autoSetting, PRISM.Produce.AiPatternDataScriptableObject aiPatternData, int unitId, int episodeId);
    public Cysharp.Threading.Tasks.UniTask<ProduceNextOrderType> StartProduceAsync(int episodeID, ProduceDifficultyType difficulty, PRISM.Produce.ProduceUnitModel produceUnitModel, PRISM.Module.Networking.IProduceAutoPlaySettingsStatus autoPlaySettings, int produceBoost, System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask<ProduceNextOrderType> ReStartExecAsync(System.Threading.CancellationToken cancellationToken);
    public void Terminate();
    private Cysharp.Threading.Tasks.UniTask<ProduceNextOrderType> _execProduceAsync(ProduceNextOrderType nextOrder, PRISM.Module.Networking.IProduceBaseInfoStatus produceBaseInfo, System.Threading.CancellationToken cancellationToken);
    private Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>> _execProduceOrderAsync(ProduceNextOrderType nextOrder, PRISM.Module.Networking.IProduceBaseInfoStatus produceBaseInfo, System.Threading.CancellationToken cancellationToken);
    private void _setupExecModel();
    private System.Collections.Generic.IReadOnlyList<string> <Setup>b__58_1(System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceCardStatus> deckCards, int num, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IInProduceIdolSkillStatus> idolSkills);
    private PRISM.Module.Networking.IInGameResultStatus <Setup>b__58_2(PRISM.Module.Networking.IStartAuditionReply reply);
    private PRISM.Module.Networking.IInGameResultStatus <Setup>b__58_3(PRISM.Module.Networking.IStartLessonReply reply);
    private PRISM.Module.Networking.IInGameResultStatus <Setup>b__58_4(PRISM.Module.Networking.IStartSpecialLessonReply reply);
    private System.Collections.Generic.IReadOnlyList<string> <Setup>b__58_5(System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceCardStatus> cards, int num, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceCardStatus> deckCards, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IInProduceIdolSkillStatus> idolSkills);
    private System.Collections.Generic.IReadOnlyList<string> <Setup>b__58_6(System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceCardStatus> deckCards, int num, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IInProduceIdolSkillStatus> idolSkills);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceAdvOptionStatus>, int> <>9__58_0;
        public static System.Func<PRISM.ProduceIdolModel, PRISM.Module.Networking.ISetProduceUnitIdolStatus> <>9__59_0;
        public static System.Func<PRISM.Produce.SupportCharacterModel, int> <>9__59_1;
        private int <Setup>b__58_0(System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceAdvOptionStatus> advOptions);
        private PRISM.Module.Networking.ISetProduceUnitIdolStatus <StartProduceAsync>b__59_0(PRISM.ProduceIdolModel x);
        private int <StartProduceAsync>b__59_1(PRISM.Produce.SupportCharacterModel x);
    }

    private struct <StartProduceAsync>d__59 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<ProduceNextOrderType> <>t__builder;
        public PRISM.Service.ProduceAutoExecModel <>4__this;
        public System.Threading.CancellationToken cancellationToken;
        public PRISM.Produce.ProduceUnitModel produceUnitModel;
        public int episodeID;
        public ProduceDifficultyType difficulty;
        public PRISM.Module.Networking.IProduceAutoPlaySettingsStatus autoPlaySettings;
        public int produceBoost;
        private Awaiter<PRISM.Module.Networking.IGetProduceResumeReply> <>u__1;
        private Awaiter<PRISM.Module.Networking.IGetProduceAutoPlayProgressReply> <>u__2;
        private Awaiter <>u__3;
        private PRISM.Module.Networking.IStartProduceReply <startReply>5__2;
        private Awaiter<PRISM.Module.Networking.ISetProduceUnitReply> <>u__4;
        private Awaiter<PRISM.Module.Networking.IStartProduceReply> <>u__5;
        private Awaiter<ProduceNextOrderType> <>u__6;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_execProduceAsync>d__62 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<ProduceNextOrderType> <>t__builder;
        public PRISM.Service.ProduceAutoExecModel <>4__this;
        public ProduceNextOrderType nextOrder;
        public PRISM.Module.Networking.IProduceBaseInfoStatus produceBaseInfo;
        public System.Threading.CancellationToken cancellationToken;
        private Awaiter<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Service
public class ProduceResumeAutoExecModel
{
    private PRISM.Domain.IProduceService service;
    private System.Func<ProduceNextOrderType, PRISM.Module.Networking.IInGameResultStatus, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>>> <OnExecInGameResultAsync>k__BackingField;
    private System.Func<System.Collections.Generic.IReadOnlyList<int>, int, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>>> <OnSelectSubSeasonIdolAsync>k__BackingField;
    private System.Func<System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>>> <OnSelectInheritanceSkillAsync>k__BackingField;
    private System.Func<ProduceNextOrderType, PRISM.Module.Networking.IInGameResultStatus, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>>> OnExecInGameResultAsync { get; set; }
    private System.Func<System.Collections.Generic.IReadOnlyList<int>, int, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>>> OnSelectSubSeasonIdolAsync { get; set; }
    private System.Func<System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>>> OnSelectInheritanceSkillAsync { get; set; }
    public void Inject(PRISM.Domain.IProduceService service);
    public Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>> ExecAsync(ProduceNextOrderType nextOrder, PRISM.Module.Networking.IProduceBaseInfoStatus produceBaseInfo, System.Threading.CancellationToken cancellationToken);
    public void Terminate();

    private struct <ExecAsync>d__14 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>> <>t__builder;
        public ProduceNextOrderType nextOrder;
        public PRISM.Service.ProduceResumeAutoExecModel <>4__this;
        public System.Threading.CancellationToken cancellationToken;
        public PRISM.Module.Networking.IProduceBaseInfoStatus produceBaseInfo;
        private Awaiter<PRISM.Module.Networking.ISelectProduceStrategyReply> <>u__1;
        private Awaiter<PRISM.Module.Networking.ISelectProduceStrategyRewardReply> <>u__2;
        private Awaiter<PRISM.Module.Networking.ISelectProduceAdvOptionReply> <>u__3;
        private Awaiter<PRISM.Module.Networking.ISelectSubSeasonReply> <>u__4;
        private Awaiter<PRISM.Module.Networking.ISelectSubSeasonIdolReply> <>u__5;
        private Awaiter<PRISM.Module.Networking.IFinishProduceAdvReply> <>u__6;
        private Awaiter<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>> <>u__7;
        private Awaiter<PRISM.Module.Networking.ISelectInheritanceSkillReply> <>u__8;
        private Awaiter<PRISM.Module.Networking.ISelectScheduleReply> <>u__9;
        private Awaiter<PRISM.Module.Networking.IFinishSupportCooperationEventReply> <>u__10;
        private Awaiter<PRISM.Module.Networking.IFinishScheduleWorkingReply> <>u__11;
        private Awaiter<PRISM.Module.Networking.IFinishScheduleOutingReply> <>u__12;
        private Awaiter<PRISM.Module.Networking.IFinishScheduleShoppingReply> <>u__13;
        private Awaiter<PRISM.Module.Networking.IFinishScheduleRestReply> <>u__14;
        private Awaiter<PRISM.Module.Networking.IFinishScheduleTrainingReply> <>u__15;
        private Awaiter<PRISM.Module.Networking.IFinishLessonResultReply> <>u__16;
        private Awaiter<PRISM.Module.Networking.ICardRankUpReply> <>u__17;
        private Awaiter<PRISM.Module.Networking.IFinishAuditionResultReply> <>u__18;
        private Awaiter<PRISM.Module.Networking.IFinishScheduleAdviceReply> <>u__19;
        private Awaiter<PRISM.Module.Networking.IFinishScheduleMiniLiveReply> <>u__20;
        private Awaiter<PRISM.Module.Networking.IFinishScheduleTalkShowReply> <>u__21;
        private Awaiter<PRISM.Module.Networking.IFinishScheduleScriptReadingReply> <>u__22;
        private Awaiter<PRISM.Module.Networking.IFinishScheduleCostumeFittingReply> <>u__23;
        private Awaiter<PRISM.Module.Networking.IFinishSchedulePublicRelationsReply> <>u__24;
        private Awaiter<PRISM.Module.Networking.IFinishScheduleActingPracticeReply> <>u__25;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Service
public class ProduceScenarioAutoExecModel
{
    private PRISM.Domain.IProduceService service;
    private System.Func<System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceCardStatus>, int, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceCardStatus>, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IInProduceIdolSkillStatus>, System.Collections.Generic.IReadOnlyList<string>> <OnSelectProduceCard>k__BackingField;
    private System.Func<System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IGettablePotentialSupportSkillStatus>, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IInProducePotentialSupportSkillStatus>, int, int, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.ISelectionSupportSkillStatus>> <OnSelectSupportSkill>k__BackingField;
    private System.Func<System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceAdvOptionStatus>, int> <OnSelectADVOption>k__BackingField;
    private System.Func<System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IGettablePotentialSupportSkillStatus>, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IInProducePotentialSupportSkillStatus>, int, int, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.ISelectionSupportSkillStatus>> <OnInheritanceSkill>k__BackingField;
    private System.Func<System.Collections.Generic.IReadOnlyList<int>, int, int> <OnSelectSubSeason>k__BackingField;
    private System.Func<System.Collections.Generic.IReadOnlyList<int>, int, int> <OnSelectSubSeasonIdol>k__BackingField;
    private System.Func<System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceCardStatus>, int, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceCardStatus>, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IInProduceIdolSkillStatus>, System.Collections.Generic.IReadOnlyList<string>> OnSelectProduceCard { get; set; }
    private System.Func<System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IGettablePotentialSupportSkillStatus>, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IInProducePotentialSupportSkillStatus>, int, int, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.ISelectionSupportSkillStatus>> OnSelectSupportSkill { get; set; }
    private System.Func<System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceAdvOptionStatus>, int> OnSelectADVOption { get; set; }
    private System.Func<System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IGettablePotentialSupportSkillStatus>, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IInProducePotentialSupportSkillStatus>, int, int, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.ISelectionSupportSkillStatus>> OnInheritanceSkill { get; set; }
    private System.Func<System.Collections.Generic.IReadOnlyList<int>, int, int> OnSelectSubSeason { get; set; }
    private System.Func<System.Collections.Generic.IReadOnlyList<int>, int, int> OnSelectSubSeasonIdol { get; set; }
    public void Inject(PRISM.Domain.IProduceService service);
    public Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>> ExecAsync(ProduceNextOrderType nextOrder, PRISM.Module.Networking.IProduceBaseInfoStatus produceBaseInfo, System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>> SelectSubSeasonIdolAsync(System.Collections.Generic.IReadOnlyList<int> idolIDs, int season, System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>> SelectInheritanceSkillAsync(System.Threading.CancellationToken cancellationToken);
    public void Terminate();
    private Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>> _execProduceADVAsync(System.Threading.CancellationToken cancellationToken);
    private Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>> _execSupportCooperationEventAsync(System.Threading.CancellationToken cancellationToken);
    private Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>> _execSubSeasonListAsync(System.Threading.CancellationToken cancellationToken);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Module.Networking.IInProduceIdolStatus, int> <>9__30_0;
        public static System.Func<PRISM.Module.Networking.IInProduceIdolStatus, PRISM.Module.Networking.IInProduceIdolSkillStatus> <>9__30_1;
        public static System.Func<PRISM.Module.Networking.IInProduceIdolStatus, PRISM.Module.Networking.IInProduceIdolSkillStatus> <>9__31_0;
        private int <_execProduceADVAsync>b__30_0(PRISM.Module.Networking.IInProduceIdolStatus e);
        private PRISM.Module.Networking.IInProduceIdolSkillStatus <_execProduceADVAsync>b__30_1(PRISM.Module.Networking.IInProduceIdolStatus idol);
        private PRISM.Module.Networking.IInProduceIdolSkillStatus <_execSupportCooperationEventAsync>b__31_0(PRISM.Module.Networking.IInProduceIdolStatus idol);
    }

    private struct <ExecAsync>d__26 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>> <>t__builder;
        public ProduceNextOrderType nextOrder;
        public PRISM.Service.ProduceScenarioAutoExecModel <>4__this;
        public System.Threading.CancellationToken cancellationToken;
        public PRISM.Module.Networking.IProduceBaseInfoStatus produceBaseInfo;
        private Awaiter<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <SelectInheritanceSkillAsync>d__28 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>> <>t__builder;
        public PRISM.Service.ProduceScenarioAutoExecModel <>4__this;
        public System.Threading.CancellationToken cancellationToken;
        private Awaiter<PRISM.Module.Networking.IInheritanceSkillListReply> <>u__1;
        private Awaiter<PRISM.Module.Networking.ISelectInheritanceSkillReply> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <SelectSubSeasonIdolAsync>d__27 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>> <>t__builder;
        public PRISM.Service.ProduceScenarioAutoExecModel <>4__this;
        public System.Collections.Generic.IReadOnlyList<int> idolIDs;
        public int season;
        public System.Threading.CancellationToken cancellationToken;
        private Awaiter<PRISM.Module.Networking.ISelectSubSeasonIdolReply> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_execProduceADVAsync>d__30 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>> <>t__builder;
        public PRISM.Service.ProduceScenarioAutoExecModel <>4__this;
        public System.Threading.CancellationToken cancellationToken;
        private PRISM.Module.Networking.IStartProduceAdvReply <startReply>5__2;
        private System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceCardStatus> <gettableProduceCards>5__3;
        private int <gettableProduceCardAmount>5__4;
        private System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IGettablePotentialSupportSkillStatus> <gettablePotentialSupportSkillList>5__5;
        private Awaiter<PRISM.Module.Networking.IStartProduceAdvReply> <>u__1;
        private Awaiter<PRISM.Module.Networking.ISelectProduceAdvOptionReply> <>u__2;
        private Awaiter<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>> <>u__3;
        private Awaiter<PRISM.Module.Networking.IFinishProduceAdvReply> <>u__4;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_execSubSeasonListAsync>d__32 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>> <>t__builder;
        public PRISM.Service.ProduceScenarioAutoExecModel <>4__this;
        public System.Threading.CancellationToken cancellationToken;
        private Awaiter<PRISM.Module.Networking.ISubSeasonListReply> <>u__1;
        private Awaiter<PRISM.Module.Networking.ISelectSubSeasonReply> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_execSupportCooperationEventAsync>d__31 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>> <>t__builder;
        public PRISM.Service.ProduceScenarioAutoExecModel <>4__this;
        public System.Threading.CancellationToken cancellationToken;
        private Awaiter<PRISM.Module.Networking.IStartSupportCooperationEventReply> <>u__1;
        private Awaiter<PRISM.Module.Networking.IFinishSupportCooperationEventReply> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Service
public class ProduceSelectScheduleAutoExecModel
{
    private PRISM.Domain.IProduceService service;
    private System.Func<PRISM.Module.Networking.IWeekScheduleStatus, PRISM.Module.Networking.IProduceBaseInfoStatus, ScheduleDetailType> <OnSelectSchedule>k__BackingField;
    private System.Func<System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceCardStatus>, int, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceCardStatus>, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IInProduceIdolSkillStatus>, System.Collections.Generic.IReadOnlyList<string>> <OnSelectProduceCard>k__BackingField;
    private System.Func<System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceCardStatus>, int, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IInProduceIdolSkillStatus>, System.Collections.Generic.IReadOnlyList<string>> <OnDeleteProduceCard>k__BackingField;
    private System.Func<System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceCardStatus>, int, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IInProduceIdolSkillStatus>, System.Collections.Generic.IReadOnlyList<string>> <OnRankUpProduceCard>k__BackingField;
    private System.Func<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>>> <OnExecScenarioAsync>k__BackingField;
    private System.Func<ProduceNextOrderType, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus, bool>>> <OnExecInGameAsync>k__BackingField;
    private System.Func<PRISM.Module.Networking.IProduceTermStatus, PRISM.Module.Networking.ISubSeasonStatus, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask> <OnStartSeasonAsync>k__BackingField;
    private System.Func<ScheduleType, PRISM.Module.Networking.IScheduleDetailStatus, PRISM.Module.Networking.IProduceTermStatus, PRISM.Module.Networking.ISubSeasonStatus, bool, bool, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask> <OnPostExecScheduleAsync>k__BackingField;
    private System.Func<PRISM.Module.Networking.IProduceTermStatus, PRISM.Module.Networking.ISubSeasonStatus, bool, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask> <OnPostSingleExecScheduleAsync>k__BackingField;
    private System.Func<PRISM.Module.Networking.IWeekScheduleStatus, PRISM.Module.Networking.IProduceBaseInfoStatus, ScheduleDetailType> OnSelectSchedule { get; set; }
    private System.Func<System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceCardStatus>, int, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceCardStatus>, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IInProduceIdolSkillStatus>, System.Collections.Generic.IReadOnlyList<string>> OnSelectProduceCard { get; set; }
    private System.Func<System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceCardStatus>, int, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IInProduceIdolSkillStatus>, System.Collections.Generic.IReadOnlyList<string>> OnDeleteProduceCard { get; set; }
    private System.Func<System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceCardStatus>, int, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IInProduceIdolSkillStatus>, System.Collections.Generic.IReadOnlyList<string>> OnRankUpProduceCard { get; set; }
    private System.Func<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>>> OnExecScenarioAsync { get; set; }
    private System.Func<ProduceNextOrderType, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus, bool>>> OnExecInGameAsync { get; set; }
    private System.Func<PRISM.Module.Networking.IProduceTermStatus, PRISM.Module.Networking.ISubSeasonStatus, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask> OnStartSeasonAsync { get; set; }
    private System.Func<ScheduleType, PRISM.Module.Networking.IScheduleDetailStatus, PRISM.Module.Networking.IProduceTermStatus, PRISM.Module.Networking.ISubSeasonStatus, bool, bool, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask> OnPostExecScheduleAsync { get; set; }
    private System.Func<PRISM.Module.Networking.IProduceTermStatus, PRISM.Module.Networking.ISubSeasonStatus, bool, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask> OnPostSingleExecScheduleAsync { get; set; }
    public void Inject(PRISM.Domain.IProduceService service);
    public Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>> ExecAsync(ProduceNextOrderType nextOrder, PRISM.Module.Networking.IProduceBaseInfoStatus produceBaseInfo, System.Threading.CancellationToken cancellationToken);
    public bool IsExecOrder(ProduceNextOrderType nextOrder);
    public void Terminate();
    private Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>> _getProduceTopAndExecScheduleAsync(System.Threading.CancellationToken cancellationToken);
    private Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>> _execScheduleAsync(ProduceNextOrderType nextOrder, PRISM.Module.Networking.IProduceBaseInfoStatus produceBaseInfo, System.Func<PRISM.Module.Networking.IProduceTermStatus, PRISM.Module.Networking.ISubSeasonStatus, bool, Cysharp.Threading.Tasks.UniTask> onPostExecAsync, System.Threading.CancellationToken cancellationToken);
    private Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus, bool>> _execGetProduceCardScheduleAsync(ProduceNextOrderType nextOrder, System.Threading.CancellationToken cancellationToken);
    private Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus, bool>> _execRestAsync(System.Threading.CancellationToken cancellationToken);
    private Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus, bool>> _execTrainingAsync(System.Threading.CancellationToken cancellationToken);
    private Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus, bool>> _execAdviceAsync(System.Threading.CancellationToken cancellationToken);
    private Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus, bool>> _execGetAndDeleteProduceCardScheduleAsync(ProduceNextOrderType orderType, System.Threading.CancellationToken cancellationToken);
    private Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus, bool>> _execScriptReadingAsync(System.Threading.CancellationToken cancellationToken);
    private Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus, bool>> _execActingPracticeAsync(System.Threading.CancellationToken cancellationToken);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Module.Networking.IInProduceIdolStatus, PRISM.Module.Networking.IInProduceIdolSkillStatus> <>9__43_0;
        public static System.Func<PRISM.Module.Networking.IInProduceIdolStatus, PRISM.Module.Networking.IInProduceIdolSkillStatus> <>9__46_0;
        public static System.Func<PRISM.Module.Networking.IInProduceIdolStatus, PRISM.Module.Networking.IInProduceIdolSkillStatus> <>9__47_0;
        public static System.Func<PRISM.Module.Networking.IInProduceIdolStatus, PRISM.Module.Networking.IInProduceIdolSkillStatus> <>9__48_0;
        public static System.Func<PRISM.Module.Networking.IInProduceIdolStatus, PRISM.Module.Networking.IInProduceIdolSkillStatus> <>9__49_0;
        private PRISM.Module.Networking.IInProduceIdolSkillStatus <_execGetProduceCardScheduleAsync>b__43_0(PRISM.Module.Networking.IInProduceIdolStatus idol);
        private PRISM.Module.Networking.IInProduceIdolSkillStatus <_execAdviceAsync>b__46_0(PRISM.Module.Networking.IInProduceIdolStatus idol);
        private PRISM.Module.Networking.IInProduceIdolSkillStatus <_execGetAndDeleteProduceCardScheduleAsync>b__47_0(PRISM.Module.Networking.IInProduceIdolStatus idol);
        private PRISM.Module.Networking.IInProduceIdolSkillStatus <_execScriptReadingAsync>b__48_0(PRISM.Module.Networking.IInProduceIdolStatus idol);
        private PRISM.Module.Networking.IInProduceIdolSkillStatus <_execActingPracticeAsync>b__49_0(PRISM.Module.Networking.IInProduceIdolStatus idol);
    }

    private class <>c__DisplayClass38_0
    {
        public PRISM.Service.ProduceSelectScheduleAutoExecModel <>4__this;
        public System.Threading.CancellationToken cancellationToken;
        private Cysharp.Threading.Tasks.UniTask <ExecAsync>b__0(PRISM.Module.Networking.IProduceTermStatus term, PRISM.Module.Networking.ISubSeasonStatus subSeason, bool isFailure);
    }

    private class <>c__DisplayClass41_0
    {
        public PRISM.Service.ProduceSelectScheduleAutoExecModel <>4__this;
        public System.Threading.CancellationToken cancellationToken;
    }

    private class <>c__DisplayClass41_1
    {
        public PRISM.Module.Networking.IScheduleDetailStatus selectScheduleDetail;
        public ScheduleDetailType selectScheduleType;
        public PRISM.Module.Networking.IScheduleStatus selectSchedule;
        public <>c__DisplayClass41_0 CS$<>8__locals1;
        public System.Func<PRISM.Module.Networking.IScheduleDetailStatus, bool> <>9__1;
        private bool <_getProduceTopAndExecScheduleAsync>b__0(PRISM.Module.Networking.IScheduleStatus schedule);
        private bool <_getProduceTopAndExecScheduleAsync>b__1(PRISM.Module.Networking.IScheduleDetailStatus detail);
        private Cysharp.Threading.Tasks.UniTask <_getProduceTopAndExecScheduleAsync>b__2(PRISM.Module.Networking.IProduceTermStatus term, PRISM.Module.Networking.ISubSeasonStatus subSeason, bool isFailure);
    }

    private class <>c__DisplayClass49_0
    {
        public System.Collections.Generic.IReadOnlyList<string> deleteCards;
        private bool <_execActingPracticeAsync>b__1(PRISM.Module.Networking.IProduceCardStatus x);
    }

    private struct <ExecAsync>d__38 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>> <>t__builder;
        public PRISM.Service.ProduceSelectScheduleAutoExecModel <>4__this;
        public System.Threading.CancellationToken cancellationToken;
        public ProduceNextOrderType nextOrder;
        public PRISM.Module.Networking.IProduceBaseInfoStatus produceBaseInfo;
        private Awaiter<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_execActingPracticeAsync>d__49 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus, bool>> <>t__builder;
        public PRISM.Service.ProduceSelectScheduleAutoExecModel <>4__this;
        public System.Threading.CancellationToken cancellationToken;
        private <>c__DisplayClass49_0 <>8__1;
        private PRISM.Module.Networking.IStartScheduleActingPracticeReply <startReply>5__2;
        private Awaiter<PRISM.Module.Networking.IStartScheduleActingPracticeReply> <>u__1;
        private Awaiter<PRISM.Module.Networking.IFinishScheduleActingPracticeReply> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_execAdviceAsync>d__46 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus, bool>> <>t__builder;
        public PRISM.Service.ProduceSelectScheduleAutoExecModel <>4__this;
        public System.Threading.CancellationToken cancellationToken;
        private Awaiter<PRISM.Module.Networking.IStartScheduleAdviceReply> <>u__1;
        private Awaiter<PRISM.Module.Networking.IFinishScheduleAdviceReply> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_execGetAndDeleteProduceCardScheduleAsync>d__47 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus, bool>> <>t__builder;
        public ProduceNextOrderType orderType;
        public PRISM.Service.ProduceSelectScheduleAutoExecModel <>4__this;
        public System.Threading.CancellationToken cancellationToken;
        private PRISM.Module.Networking.IProduceBaseInfoStatus <finishProduceBaseInfo>5__2;
        private bool <isTrouble>5__3;
        private Awaiter<PRISM.Module.Networking.IStartScheduleMiniLiveReply> <>u__1;
        private Awaiter<PRISM.Module.Networking.IStartScheduleTalkShowReply> <>u__2;
        private Awaiter<PRISM.Module.Networking.IStartScheduleCostumeFittingReply> <>u__3;
        private Awaiter<PRISM.Module.Networking.IFinishScheduleMiniLiveReply> <>u__4;
        private Awaiter<PRISM.Module.Networking.IFinishScheduleTalkShowReply> <>u__5;
        private Awaiter<PRISM.Module.Networking.IFinishScheduleCostumeFittingReply> <>u__6;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_execGetProduceCardScheduleAsync>d__43 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus, bool>> <>t__builder;
        public ProduceNextOrderType nextOrder;
        public PRISM.Service.ProduceSelectScheduleAutoExecModel <>4__this;
        public System.Threading.CancellationToken cancellationToken;
        private bool <isFailure>5__2;
        private Awaiter<PRISM.Module.Networking.IStartScheduleWorkingReply> <>u__1;
        private Awaiter<PRISM.Module.Networking.IStartScheduleOutingReply> <>u__2;
        private Awaiter<PRISM.Module.Networking.IStartScheduleShoppingReply> <>u__3;
        private Awaiter<PRISM.Module.Networking.IStartSchedulePublicRelationsReply> <>u__4;
        private Awaiter<PRISM.Module.Networking.IFinishScheduleWorkingReply> <>u__5;
        private Awaiter<PRISM.Module.Networking.IFinishScheduleOutingReply> <>u__6;
        private Awaiter<PRISM.Module.Networking.IFinishScheduleShoppingReply> <>u__7;
        private Awaiter<PRISM.Module.Networking.IFinishSchedulePublicRelationsReply> <>u__8;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_execRestAsync>d__44 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus, bool>> <>t__builder;
        public PRISM.Service.ProduceSelectScheduleAutoExecModel <>4__this;
        public System.Threading.CancellationToken cancellationToken;
        private Awaiter<PRISM.Module.Networking.IStartScheduleRestReply> <>u__1;
        private Awaiter<PRISM.Module.Networking.IFinishScheduleRestReply> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_execScheduleAsync>d__42 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>> <>t__builder;
        public PRISM.Module.Networking.IProduceBaseInfoStatus produceBaseInfo;
        public ProduceNextOrderType nextOrder;
        public PRISM.Service.ProduceSelectScheduleAutoExecModel <>4__this;
        public System.Threading.CancellationToken cancellationToken;
        public System.Func<PRISM.Module.Networking.IProduceTermStatus, PRISM.Module.Networking.ISubSeasonStatus, bool, Cysharp.Threading.Tasks.UniTask> onPostExecAsync;
        private PRISM.Module.Networking.IProduceTermStatus <term>5__2;
        private PRISM.Module.Networking.ISubSeasonStatus <subSeason>5__3;
        private Awaiter<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus, bool>> <>u__1;
        private Awaiter<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>> <>u__2;
        private Awaiter <>u__3;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_execScriptReadingAsync>d__48 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus, bool>> <>t__builder;
        public PRISM.Service.ProduceSelectScheduleAutoExecModel <>4__this;
        public System.Threading.CancellationToken cancellationToken;
        private PRISM.Module.Networking.IStartScheduleScriptReadingReply <startReply>5__2;
        private Awaiter<PRISM.Module.Networking.IStartScheduleScriptReadingReply> <>u__1;
        private Awaiter<PRISM.Module.Networking.IFinishScheduleScriptReadingReply> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_execTrainingAsync>d__45 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus, bool>> <>t__builder;
        public PRISM.Service.ProduceSelectScheduleAutoExecModel <>4__this;
        public System.Threading.CancellationToken cancellationToken;
        private PRISM.Module.Networking.IStartScheduleTrainingReply <startReply>5__2;
        private Awaiter<PRISM.Module.Networking.IStartScheduleTrainingReply> <>u__1;
        private Awaiter<PRISM.Module.Networking.IFinishScheduleTrainingReply> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_getProduceTopAndExecScheduleAsync>d__41 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>> <>t__builder;
        public PRISM.Service.ProduceSelectScheduleAutoExecModel <>4__this;
        public System.Threading.CancellationToken cancellationToken;
        private <>c__DisplayClass41_0 <>8__1;
        private <>c__DisplayClass41_1 <>8__2;
        private PRISM.Module.Networking.IGetProduceTopReply <topReply>5__2;
        private PRISM.Module.Networking.IProduceBaseInfoStatus <produceBaseInfo>5__3;
        private ProduceNextOrderType <nextOrder>5__4;
        private Awaiter<PRISM.Module.Networking.IGetProduceTopReply> <>u__1;
        private Awaiter <>u__2;
        private PRISM.Module.Networking.IWeekScheduleStatus <weekSchedule>5__5;
        private Awaiter<PRISM.Module.Networking.ISelectScheduleReply> <>u__3;
        private Awaiter<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>> <>u__4;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Service
public class ProduceSelectStrategyAutoExecModel
{
    private PRISM.Domain.IProduceService service;
    private System.Func<System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceStrategyStatus>, int> <OnSelectStrategy>k__BackingField;
    private System.Func<System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IGettablePotentialSupportSkillStatus>, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IInProducePotentialSupportSkillStatus>, int, int, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.ISelectionSupportSkillStatus>> <OnSelectSupportSkill>k__BackingField;
    private System.Func<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>>> <OnExecScenarioAsync>k__BackingField;
    private System.Func<System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceStrategyStatus>, int> OnSelectStrategy { get; set; }
    private System.Func<System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IGettablePotentialSupportSkillStatus>, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IInProducePotentialSupportSkillStatus>, int, int, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.ISelectionSupportSkillStatus>> OnSelectSupportSkill { get; set; }
    private System.Func<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>>> OnExecScenarioAsync { get; set; }
    public void Inject(PRISM.Domain.IProduceService service);
    public Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>> ExecAsync(System.Threading.CancellationToken cancellationToken);
    public void Terminate();

    private struct <ExecAsync>d__14 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>> <>t__builder;
        public PRISM.Service.ProduceSelectStrategyAutoExecModel <>4__this;
        public System.Threading.CancellationToken cancellationToken;
        private Awaiter<PRISM.Module.Networking.IProduceStrategyListReply> <>u__1;
        private Awaiter<PRISM.Module.Networking.ISelectProduceStrategyReply> <>u__2;
        private Awaiter<System.ValueTuple<ProduceNextOrderType, PRISM.Module.Networking.IProduceBaseInfoStatus>> <>u__3;
        private Awaiter<PRISM.Module.Networking.ISelectProduceStrategyRewardReply> <>u__4;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Service
public class ProduceAutoSettingModel : UnityEngine.ISerializationCallbackReceiver
{
    private ScheduleSelectionType <ScheduleSelection>k__BackingField;
    private SystemType <System>k__BackingField;
    private RecoveryTimingType <RecoveryTiming>k__BackingField;
    private RankUpBalanceType <RankUpBalance>k__BackingField;
    private CardDeleteType <CardDelete>k__BackingField;
    private CardCostBalanceType <CardCostBalance>k__BackingField;
    private DeckPolicyType <DeckPolicy>k__BackingField;
    public System.Collections.Generic.Dictionary<System.ValueTuple<int, int>, System.ValueTuple<int, int>> SelectSubSeasonDictionary;
    private SelectSubSeasonData[] selectSubSeasonDatas;
    public ScheduleSelectionType ScheduleSelection { get; set; }
    public SystemType System { get; set; }
    public RecoveryTimingType RecoveryTiming { get; set; }
    public RankUpBalanceType RankUpBalance { get; set; }
    public CardDeleteType CardDelete { get; set; }
    public CardCostBalanceType CardCostBalance { get; set; }
    public DeckPolicyType DeckPolicy { get; set; }
    public PRISM.Module.Networking.IProduceAutoPlaySettingsStatus CreateAutoPlaySettingsStatus(int mstEpisodeId);
    public int GetDeleteCardNum();
    public void OnBeforeSerialize();
    public void OnAfterDeserialize();

    public enum ScheduleSelectionType : System.Enum
    {
        public int value__;
        public static ScheduleSelectionType Balance;
        public static ScheduleSelectionType Status;
        public static ScheduleSelectionType Deck;
    }

    public enum SystemType : System.Enum
    {
        public int value__;
        public static SystemType Balance;
        public static SystemType Voice;
        public static SystemType Dance;
        public static SystemType Visual;
    }

    public enum RecoveryTimingType : System.Enum
    {
        public int value__;
        public static RecoveryTimingType Recovery_60_51;
        public static RecoveryTimingType Recovery_50_41;
        public static RecoveryTimingType Recovery_40_31;
        public static RecoveryTimingType Recovery_Under30;
    }

    public enum RankUpBalanceType : System.Enum
    {
        public int value__;
        public static RankUpBalanceType Active;
        public static RankUpBalanceType Balance;
        public static RankUpBalanceType None;
    }

    public enum CardDeleteType : System.Enum
    {
        public int value__;
        public static CardDeleteType Card_6;
        public static CardDeleteType Card_5_4;
        public static CardDeleteType Card_3_2;
        public static CardDeleteType Card_1_0;
    }

    public enum CardCostBalanceType : System.Enum
    {
        public int value__;
        public static CardCostBalanceType LowCost;
        public static CardCostBalanceType MiddleCost;
        public static CardCostBalanceType HighCost;
        public static CardCostBalanceType Balance;
    }

    public enum DeckPolicyType : System.Enum
    {
        public int value__;
        public static DeckPolicyType Card;
        public static DeckPolicyType Combo;
        public static DeckPolicyType Synergy;
    }

    public class SelectSubSeasonData
    {
        public int MstEpisodeId;
        public int Season;
        public int MstSubSeasonId;
        public int MstIdolId;
    }

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<System.Collections.Generic.KeyValuePair<System.ValueTuple<int, int>, System.ValueTuple<int, int>>, PRISM.Module.Networking.IProduceAutoPlaySubSeasonSettingStatus> <>9__37_1;
        public static System.Func<System.Collections.Generic.KeyValuePair<System.ValueTuple<int, int>, System.ValueTuple<int, int>>, SelectSubSeasonData> <>9__39_0;
        public static System.Func<SelectSubSeasonData, System.ValueTuple<int, int>> <>9__40_0;
        public static System.Func<SelectSubSeasonData, System.ValueTuple<int, int>> <>9__40_1;
        private PRISM.Module.Networking.IProduceAutoPlaySubSeasonSettingStatus <CreateAutoPlaySettingsStatus>b__37_1(System.Collections.Generic.KeyValuePair<System.ValueTuple<int, int>, System.ValueTuple<int, int>> x);
        private SelectSubSeasonData <OnBeforeSerialize>b__39_0(System.Collections.Generic.KeyValuePair<System.ValueTuple<int, int>, System.ValueTuple<int, int>> pair);
        private System.ValueTuple<int, int> <OnAfterDeserialize>b__40_0(SelectSubSeasonData data);
        private System.ValueTuple<int, int> <OnAfterDeserialize>b__40_1(SelectSubSeasonData data);
    }

    private class <>c__DisplayClass37_0
    {
        public int mstEpisodeId;
        private bool <CreateAutoPlaySettingsStatus>b__0(System.Collections.Generic.KeyValuePair<System.ValueTuple<int, int>, System.ValueTuple<int, int>> x);
    }
}

// Namespace: PRISM.Service
public class ProduceStrategySelectModel
{
    private System.Random rnd;
    public int Select(System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceStrategyStatus> produceStrategyList);
}

// Namespace: PRISM.Service
public class ScheduleSelectionAIModel
{
    private static float SupportBonusRate;
    private static float ScheduleSelectionTypeRate;
    private static float SystemTypeRate;
    private static float LvRate;
    private System.Collections.Generic.List<PRISM.Module.Networking.IScheduleStatus> scheduleList;
    private PRISM.Service.ProduceAutoSettingModel data;
    private int deleteCardNum;
    private System.Random rnd;
    private PRISM.Produce.ProduceOptionSaveData saveData;
    private System.Collections.Generic.List<PRISM.Module.Networking.IScheduleDetailStatus> calcDetalList;
    private System.Collections.Generic.List<PRISM.Module.Networking.IScheduleDetailStatus> bestScheduleList;
    public void Setup(PRISM.Service.ProduceAutoSettingModel data, int deleteCardNum);
    public ScheduleDetailType Select(PRISM.Module.Networking.IWeekScheduleStatus weekSchedule, PRISM.Module.Networking.IProduceBaseInfoStatus produceBaseInfo);
    private PRISM.Module.Networking.IScheduleDetailStatus _calcHightScore(System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IScheduleDetailStatus> list, System.Collections.Generic.IEnumerable<ScheduleDetailType> preferentialScheduleTypes);
    private float _calcScore(PRISM.Module.Networking.IScheduleDetailStatus scheduleDetail, System.Collections.Generic.IEnumerable<ScheduleDetailType> preferentialScheduleTypes);
    private float _calcBaseScore(PRISM.Module.Networking.IScheduleDetailStatus scheduleDetail, System.Collections.Generic.IEnumerable<ScheduleDetailType> preferentialScheduleTypes);
    private float _calcSystemTypeRate(PRISM.Module.Networking.IScheduleDetailStatus scheduleDetail, System.Collections.Generic.IEnumerable<ScheduleDetailType> preferentialScheduleTypes);
    private float _calcLvRate(PRISM.Module.Networking.IScheduleDetailStatus scheduleDetail);
    private bool _isMatchScheduleType(ScheduleType scheduleType);
    private PRISM.Module.Networking.IScheduleStatus _getScheduleType(ScheduleType scheduleType);
    private System.Collections.Generic.List<PRISM.Module.Networking.IScheduleStatus> _getScheduleTypeList(System.Predicate<PRISM.Module.Networking.IScheduleStatus> match);
    private bool _isExistAppearabceSchedule();
    private int _calcCardGrowth(PRISM.Module.Networking.IProduceBaseInfoStatus produceBaseInfo);
    private bool _calcSelectAdvice(PRISM.Module.Networking.IProduceBaseInfoStatus produceBaseInfo, PRISM.Service.ProduceAutoSettingModel data);
    private bool _calcSelectRest(PRISM.Module.Networking.IProduceBaseInfoStatus produceBaseInfo, PRISM.Service.ProduceAutoSettingModel data);
    private bool _IsLesson(ScheduleType scheduleType);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Module.Networking.IInProduceSupportCharacterStatus, ScheduleDetailType> <>9__12_0;
        public static System.Func<PRISM.Module.Networking.IScheduleStatus, bool> <>9__12_4;
        public static System.Predicate<PRISM.Module.Networking.IScheduleDetailStatus> <>9__12_2;
        public static System.Predicate<PRISM.Module.Networking.IScheduleDetailStatus> <>9__12_7;
        public static System.Func<PRISM.Module.Networking.IScheduleDetailStatus, int, bool> <>9__12_8;
        public static System.Predicate<PRISM.Module.Networking.IScheduleStatus> <>9__21_0;
        private ScheduleDetailType <Select>b__12_0(PRISM.Module.Networking.IInProduceSupportCharacterStatus x);
        private bool <Select>b__12_4(PRISM.Module.Networking.IScheduleStatus x);
        private bool <Select>b__12_2(PRISM.Module.Networking.IScheduleDetailStatus item);
        private bool <Select>b__12_7(PRISM.Module.Networking.IScheduleDetailStatus item);
        private bool <Select>b__12_8(PRISM.Module.Networking.IScheduleDetailStatus item, int state);
        private bool <_isExistAppearabceSchedule>b__21_0(PRISM.Module.Networking.IScheduleStatus item);
    }

    private class <>c__DisplayClass12_0
    {
        public System.Collections.Generic.IEnumerable<ScheduleDetailType> goodScheduleList;
        private bool <Select>b__1(ScheduleDetailType x);
    }

    private class <>c__DisplayClass12_1
    {
        public ScheduleDetailType x;
        private bool <Select>b__3(ScheduleDetailType y);
    }

    private class <>c__DisplayClass12_2
    {
        public int recoverVitality;
        private bool <Select>b__5(PRISM.Module.Networking.IScheduleDetailStatus match);
    }

    private class <>c__DisplayClass12_3
    {
        public int recoverVitality;
        private bool <Select>b__6(PRISM.Module.Networking.IScheduleDetailStatus match);
    }

    private class <>c__DisplayClass12_4
    {
        public int trouble;
        private bool <Select>b__9(PRISM.Module.Networking.IScheduleDetailStatus item);
    }

    private class <>c__DisplayClass15_0
    {
        public PRISM.Module.Networking.IScheduleDetailStatus scheduleDetail;
        private bool <_calcBaseScore>b__0(ScheduleDetailType x);
    }

    private class <>c__DisplayClass16_0
    {
        public PRISM.Module.Networking.IScheduleDetailStatus scheduleDetail;
        private bool <_calcSystemTypeRate>b__0(ScheduleDetailType x);
    }

    private class <>c__DisplayClass18_0
    {
        public ScheduleType scheduleType;
        private bool <_isMatchScheduleType>b__0(PRISM.Module.Networking.IScheduleStatus item);
    }

    private class <>c__DisplayClass19_0
    {
        public ScheduleType scheduleType;
        private bool <_getScheduleType>b__0(PRISM.Module.Networking.IScheduleStatus item);
    }
}

// Namespace: PRISM.Service
public class SelectSupportSkill
{
    private System.Collections.Generic.List<PRISM.Module.Networking.IInProducePotentialSupportSkillStatus> cacheSkillList;
    private PRISM.Service.ProduceAutoSettingModel produceAutoSettingModel;
    public void Setup(PRISM.Service.ProduceAutoSettingModel produceAutoSettingModel);
    public PRISM.Module.Networking.ISelectionSupportSkillStatus Select(PRISM.Module.Networking.IGettablePotentialSupportSkillStatus getSkill, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IInProducePotentialSupportSkillStatus> skillList, int slotNum);
    public System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.ISelectionSupportSkillStatus> SelectList(System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IGettablePotentialSupportSkillStatus> getSkillList, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IInProducePotentialSupportSkillStatus> skillList, int slotNum, int gettableCount);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Module.Networking.IGettablePotentialSupportSkillStatus, int> <>9__4_0;
        public static System.Func<PRISM.Module.Networking.ISelectionSupportSkillStatus, int> <>9__4_3;
        public static System.Func<PRISM.Module.Networking.IInProducePotentialSupportSkillStatus, int> <>9__4_2;
        private int <SelectList>b__4_0(PRISM.Module.Networking.IGettablePotentialSupportSkillStatus x);
        private int <SelectList>b__4_3(PRISM.Module.Networking.ISelectionSupportSkillStatus x);
        private int <SelectList>b__4_2(PRISM.Module.Networking.IInProducePotentialSupportSkillStatus x);
    }

    private class <>c__DisplayClass4_0
    {
        public System.Collections.Generic.List<PRISM.Module.Networking.ISelectionSupportSkillStatus> returnList;
        public System.Func<PRISM.Module.Networking.IInProducePotentialSupportSkillStatus, bool> <>9__1;
        private bool <SelectList>b__1(PRISM.Module.Networking.IInProducePotentialSupportSkillStatus x);
    }
}

// Namespace: PRISM.Service
public class SubSeasonSelectModel
{
    private System.Random random;
    private int mstEpisodeId;
    private PRISM.Service.ProduceAutoSettingModel settingModel;
    public void Setup(PRISM.Service.ProduceAutoSettingModel produceAutoSettingModel, int mstEpisodeId);
    public int Select(System.Collections.Generic.IReadOnlyList<int> mstSubSeasonIds, int season);
    public int IdolSelect(System.Collections.Generic.IReadOnlyList<int> mstIdolIds, int season);
}

// Namespace: PRISM.Service
public class UnitCommunityModel
{
    private System.Random random;
    public void Setup();
    public int Select(int num);
}

// Namespace: PRISM.Service
public class CardRankUpModel
{
    private PRISM.Module.Networking.ICardRankUpReply cacheCardRankUpReply;
    public void SetFinishLessonResult(PRISM.Module.Networking.ICardRankUpReply cardRankUpReply);
    public PRISM.Module.Networking.ICardRankUpReply GetFinishLessonResult();
}

// Namespace: PRISM.Service
public class ProducePolicyModel
{
    private int seletedIndex;
    public int SeletedIndex { get; set; }
}

// Namespace: PRISM.Service
public class FinishAdviceModel
{
    private PRISM.Module.Networking.IFinishScheduleAdviceReply cacheFinishScheduleAdviceReply;
    public void SetFinishScheduleAdvice(PRISM.Module.Networking.IFinishScheduleAdviceReply finishScheduleAdviceReply);
    public PRISM.Module.Networking.IFinishScheduleAdviceReply GetFinishScheduleAdvice();
}

// Namespace: PRISM.Service
public class FinishAuditionModel
{
    private PRISM.Module.Networking.IFinishAuditionReply cacheFinishAuditionReply;
    public void SetStartAudition(PRISM.Module.Networking.IFinishAuditionReply finishAuditionReply);
    public PRISM.Module.Networking.IFinishAuditionReply GetFinishAudition();
}

// Namespace: PRISM.Service
public class FinishAuditionResultModel
{
    private PRISM.Module.Networking.IFinishAuditionResultReply cacheFinishAuditionResultReply;
    public void SetFinishAuditionResult(PRISM.Module.Networking.IFinishAuditionResultReply finishAuditionResultReply);
    public PRISM.Module.Networking.IFinishAuditionResultReply GetFinishLessonResult();
}

// Namespace: PRISM.Service
public class FinishLessonModel
{
    private PRISM.Module.Networking.IFinishLessonReply cacheFinishLessonReply;
    public void SetFinishLessonData(PRISM.Module.Networking.IFinishLessonReply finishLessonReply);
    public PRISM.Module.Networking.IFinishLessonReply GetFinishLessonReply();
}

// Namespace: PRISM.Service
public class FinishLessonResultModel
{
    private PRISM.Module.Networking.IFinishLessonResultReply cacheFinishLessonResultReply;
    public void SetFinishLessonResult(PRISM.Module.Networking.IFinishLessonResultReply finishLessonResultReply);
    public PRISM.Module.Networking.IFinishLessonResultReply GetFinishLessonResult();
}

// Namespace: PRISM.Service
public class FinishMiniLiveModel
{
    private PRISM.Module.Networking.IProduceNextOrderStatus <NextOrder>k__BackingField;
    public PRISM.Module.Networking.IProduceNextOrderStatus NextOrder { get; set; }
}

// Namespace: PRISM.Service
public class FinishOutingModel
{
    private PRISM.Module.Networking.IFinishScheduleOutingReply cacheFinishScheduleOutingReply;
    public void SetFinishScheduleOuting(PRISM.Module.Networking.IFinishScheduleOutingReply finishScheduleOutingReply);
    public PRISM.Module.Networking.IFinishScheduleOutingReply GetFinishScheduleOuting();
}

// Namespace: PRISM.Service
public class FinishProduceAdvModel
{
    private PRISM.Module.Networking.IFinishProduceAdvReply cacheFinishProduceAdvReply;
    public void SetFinishProduceAdv(PRISM.Module.Networking.IFinishProduceAdvReply finishProduceAdvReply);
    public PRISM.Module.Networking.IFinishProduceAdvReply GetFinishProduceAdv();
}

// Namespace: PRISM.Service
public class FinishRestModel
{
    private PRISM.Module.Networking.IFinishScheduleRestReply cacheFinishScheduleRestReply;
    public void SetFinishScheduleRest(PRISM.Module.Networking.IFinishScheduleRestReply finishScheduleRestReply);
    public PRISM.Module.Networking.IFinishScheduleRestReply GetFinishScheduleRest();
}

// Namespace: PRISM.Service
public class FinishShoppingModel
{
    private PRISM.Module.Networking.IFinishScheduleShoppingReply cacheFinishScheduleShoppingReply;
    public void SetFinishScheduleShopping(PRISM.Module.Networking.IFinishScheduleShoppingReply finishScheduleShoppingReply);
    public PRISM.Module.Networking.IFinishScheduleShoppingReply GetFinishScheduleShopping();
}

// Namespace: PRISM.Service
public class FinishSpecialLessonModel
{
    private PRISM.Module.Networking.IFinishSpecialLessonReply cacheFinishSpecialLessonReply;
    public void SetStartSpecialLessonData(PRISM.Module.Networking.IFinishSpecialLessonReply finishSpecialLessonReply);
    public PRISM.Module.Networking.IFinishSpecialLessonReply GetFinishSpecialLessonData();
}

// Namespace: PRISM.Service
public class FinishSupportCooperationEventModel
{
    private PRISM.Module.Networking.IFinishSupportCooperationEventReply cacheFinishSupportCooperationEventReply;
    public void SetFinishSupportCooperationEvent(PRISM.Module.Networking.IFinishSupportCooperationEventReply finishSupportCooperationEventReply);
    public PRISM.Module.Networking.IFinishSupportCooperationEventReply GetFinishSupportCooperationEvent();
}

// Namespace: PRISM.Service
public class FinishTalkShowModel
{
    private PRISM.Module.Networking.IProduceNextOrderStatus <NextOrder>k__BackingField;
    public PRISM.Module.Networking.IProduceNextOrderStatus NextOrder { get; set; }
}

// Namespace: PRISM.Service
public class FinishTrainingModel
{
    private PRISM.Module.Networking.IFinishScheduleTrainingReply cacheFinishScheduleTrainingReply;
    public void SetFinishScheduleTraining(PRISM.Module.Networking.IFinishScheduleTrainingReply finishScheduleTrainingReply);
    public PRISM.Module.Networking.IFinishScheduleTrainingReply GetFinishScheduleTraining();
}

// Namespace: PRISM.Service
public class FinishWorkingModel
{
    private PRISM.Module.Networking.IFinishScheduleWorkingReply cacheFinishScheduleWorkingReply;
    public void SetFinishScheduleWorking(PRISM.Module.Networking.IFinishScheduleWorkingReply finishScheduleWorkingReply);
    public PRISM.Module.Networking.IFinishScheduleWorkingReply GetFinishScheduleWorking();
}

// Namespace: PRISM.Service
public class StartAdviceModel
{
    private PRISM.Module.Networking.IStartScheduleAdviceReply cacheStartScheduleAdviceReply;
    public void SetStartAdviceData(PRISM.Module.Networking.IStartScheduleAdviceReply startScheduleAdviceReply);
    public PRISM.Module.Networking.IStartScheduleAdviceReply GetStartAdviceData();
}

// Namespace: PRISM.Service
public class StartAuditionModel
{
    private PRISM.Module.Networking.IStartAuditionReply cacheStartAuditionReply;
    public void SetStartAudition(PRISM.Module.Networking.IStartAuditionReply startAuditionReply);
    public PRISM.Module.Networking.IStartAuditionReply GetStartAudition();
}

// Namespace: PRISM.Service
public class StartLessonModel
{
    private PRISM.Module.Networking.IStartLessonReply cacheStartLessonReply;
    public void SetStartLessonData(PRISM.Module.Networking.IStartLessonReply startLessonReply);
    public PRISM.Module.Networking.IStartLessonReply GetStartLessonData();
}

// Namespace: PRISM.Service
public class StartMiniLiveModel
{
    private PRISM.Module.Networking.IProduceNextOrderStatus <NextOrder>k__BackingField;
    private PRISM.Module.Networking.IProduceBaseInfoStatus <ProduceBaseInfo>k__BackingField;
    private ScheduleDetailType <ScheduleDetailType>k__BackingField;
    private int <MstUnitId>k__BackingField;
    private int <GettableProduceCardAmount>k__BackingField;
    private int <DeletableProduceCardAmount>k__BackingField;
    private PRISM.Module.Networking.IParameterVariationStatus <UnitParamVariation>k__BackingField;
    private PRISM.Module.Networking.IFanVariationStatus <FanVariation>k__BackingField;
    private PRISM.Module.Networking.IVitalityVariationStatus <VitalityVariation>k__BackingField;
    private bool <IsTrouble>k__BackingField;
    public System.Collections.Generic.IReadOnlyList<int> MstCharacterInfoIdList;
    public System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IExertSupportEffectStatus> ExertSupportEffectList;
    public System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceCardStatus> GettableProduceCardList;
    public PRISM.Module.Networking.IProduceNextOrderStatus NextOrder { get; set; }
    public PRISM.Module.Networking.IProduceBaseInfoStatus ProduceBaseInfo { get; set; }
    public ScheduleDetailType ScheduleDetailType { get; set; }
    public int MstUnitId { get; set; }
    public int GettableProduceCardAmount { get; set; }
    public int DeletableProduceCardAmount { get; set; }
    public PRISM.Module.Networking.IParameterVariationStatus UnitParamVariation { get; set; }
    public PRISM.Module.Networking.IFanVariationStatus FanVariation { get; set; }
    public PRISM.Module.Networking.IVitalityVariationStatus VitalityVariation { get; set; }
    public bool IsTrouble { get; set; }
}

// Namespace: PRISM.Service
public class StartOutingModel
{
    private PRISM.Module.Networking.IStartScheduleOutingReply cacheStartScheduleOutingReply;
    public void SetStartOutingData(PRISM.Module.Networking.IStartScheduleOutingReply startScheduleOutingReply);
    public PRISM.Module.Networking.IStartScheduleOutingReply GetStartOutingData();
}

// Namespace: PRISM.Service
public class StartRestModel
{
    private PRISM.Module.Networking.IStartScheduleRestReply cacheStartScheduleRestReply;
    public void SetStartRestData(PRISM.Module.Networking.IStartScheduleRestReply startScheduleRestReply);
    public PRISM.Module.Networking.IStartScheduleRestReply GetStartRestData();
}

// Namespace: PRISM.Service
public class StartShoppingModel
{
    private PRISM.Module.Networking.IStartScheduleShoppingReply cacheStartScheduleShoppingReply;
    public void SetStartShoppingData(PRISM.Module.Networking.IStartScheduleShoppingReply startScheduleShoppingReply);
    public PRISM.Module.Networking.IStartScheduleShoppingReply GetStartShoppingData();
}

// Namespace: PRISM.Service
public class StartSpecialLessonModel
{
    private PRISM.Module.Networking.IStartSpecialLessonReply cacheStartSpecialLessonReply;
    public void SetStartSpecialLessonData(PRISM.Module.Networking.IStartSpecialLessonReply startSpecialLessonReply);
    public PRISM.Module.Networking.IStartSpecialLessonReply GetStartSpecialLessonData();
}

// Namespace: PRISM.Service
public class StartSupportCooperationEventModel
{
    private PRISM.Module.Networking.IStartSupportCooperationEventReply cacheStartSupportCooperationEventReply;
    public void SetStartSupportCooperationEvent(PRISM.Module.Networking.IStartSupportCooperationEventReply startSupportCooperationEventReply);
    public PRISM.Module.Networking.IStartSupportCooperationEventReply GetStartSupportCooperationEvent();
}

// Namespace: PRISM.Service
public class StartTalkShowModel
{
    private PRISM.Module.Networking.IProduceNextOrderStatus <NextOrder>k__BackingField;
    private PRISM.Module.Networking.IProduceBaseInfoStatus <ProduceBaseInfo>k__BackingField;
    private ScheduleDetailType <ScheduleDetailType>k__BackingField;
    private int <MstUnitId>k__BackingField;
    private int <GettableProduceCardAmount>k__BackingField;
    private int <DeletableProduceCardAmount>k__BackingField;
    private PRISM.Module.Networking.IParameterVariationStatus <UnitParamVariation>k__BackingField;
    private PRISM.Module.Networking.IFanVariationStatus <FanVariation>k__BackingField;
    private PRISM.Module.Networking.IVitalityVariationStatus <VitalityVariation>k__BackingField;
    private bool <IsTrouble>k__BackingField;
    public System.Collections.Generic.IReadOnlyList<int> MstCharacterInfoIdList;
    public System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IExertSupportEffectStatus> ExertSupportEffectList;
    public System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceCardStatus> GettableProduceCardList;
    public PRISM.Module.Networking.IProduceNextOrderStatus NextOrder { get; set; }
    public PRISM.Module.Networking.IProduceBaseInfoStatus ProduceBaseInfo { get; set; }
    public ScheduleDetailType ScheduleDetailType { get; set; }
    public int MstUnitId { get; set; }
    public int GettableProduceCardAmount { get; set; }
    public int DeletableProduceCardAmount { get; set; }
    public PRISM.Module.Networking.IParameterVariationStatus UnitParamVariation { get; set; }
    public PRISM.Module.Networking.IFanVariationStatus FanVariation { get; set; }
    public PRISM.Module.Networking.IVitalityVariationStatus VitalityVariation { get; set; }
    public bool IsTrouble { get; set; }
}

// Namespace: PRISM.Service
public class StartTraningModel
{
    private PRISM.Module.Networking.IStartScheduleTrainingReply cacheStartScheduleTrainingReply;
    public void SetStartTrainingData(PRISM.Module.Networking.IStartScheduleTrainingReply startScheduleTrainingReply);
    public PRISM.Module.Networking.IStartScheduleTrainingReply GetStartTrainingData();
}

// Namespace: PRISM.Service
public class StartWorkingModel
{
    private PRISM.Module.Networking.IStartScheduleWorkingReply cacheStartScheduleWorkingReply;
    public void SetStartScheduleWorkingData(PRISM.Module.Networking.IStartScheduleWorkingReply startScheduleWorkingReply);
    public PRISM.Module.Networking.IStartScheduleWorkingReply GetStartWorkingData();
}

// Namespace: PRISM.Service
public class ScheduleSelectionModel
{
    private PRISM.Service.StartLessonModel cacheStartLessonModel;
    private PRISM.Service.StartRestModel cacheStartRestModel;
    private PRISM.Service.StartTraningModel cacheStartTraningModel;
    private PRISM.Service.StartWorkingModel cacheStartWorkingModel;
    private PRISM.Service.StartOutingModel cacheStartOutingModel;
    private PRISM.Service.StartShoppingModel cacheStartShoppingModel;
    private PRISM.Service.StartAdviceModel cacheStartAdviceModel;
    private PRISM.Service.StartSpecialLessonModel cacheStartSpecialLessonModel;
    private PRISM.Service.StartAuditionModel cacheStartAuditionModel;
    private PRISM.Service.StartSupportCooperationEventModel cacheStartSupportCooperationEventModel;
    private PRISM.Service.StartMiniLiveModel cacheStartMiniLiveModel;
    private PRISM.Service.StartTalkShowModel cacheStartTalkShowModel;
    public PRISM.Module.Networking.IStartScheduleScriptReadingReply StartScriptReadingReply;
    public PRISM.Module.Networking.IStartScheduleCostumeFittingReply StartCostumeFittingReply;
    public PRISM.Module.Networking.IStartSchedulePublicRelationsReply StartPublicRelationsReply;
    public PRISM.Module.Networking.IStartScheduleActingPracticeReply StartActingPracticeReply;
    private PRISM.Service.FinishTrainingModel cacheFinishTrainingModel;
    private PRISM.Service.FinishWorkingModel cacheFinishWorkingModel;
    private PRISM.Service.FinishOutingModel cacheFinishOutingModel;
    private PRISM.Service.FinishShoppingModel cacheFinishShoppingModel;
    private PRISM.Service.FinishRestModel cacheFinishRestModel;
    private PRISM.Service.FinishAdviceModel cacheFinishAdviceModel;
    private PRISM.Service.FinishSupportCooperationEventModel cacheFinishSupportCooperationEventModel;
    private PRISM.Service.FinishMiniLiveModel cacheFinishMiniLiveModel;
    private PRISM.Service.FinishTalkShowModel cacheFinishTalkShowModel;
    public PRISM.Module.Networking.IFinishScheduleScriptReadingReply FinishScriptReadingReply;
    public PRISM.Module.Networking.IFinishScheduleCostumeFittingReply FinishCostumeFittingReply;
    public PRISM.Module.Networking.IFinishSchedulePublicRelationsReply FinishPublicRelationsReply;
    public PRISM.Module.Networking.IFinishScheduleActingPracticeReply FinishActingPracticeReply;
    public PRISM.Service.StartLessonModel GetStartLessonModel();
    public void SetStartLessonData(PRISM.Service.StartLessonModel startLessonModel);
    public PRISM.Service.StartRestModel GetStartRestModel();
    public void SetStartRestData(PRISM.Service.StartRestModel startRestModel);
    public PRISM.Service.StartTraningModel GetStartTraningModel();
    public void SetStartTraningData(PRISM.Service.StartTraningModel startTraningModel);
    public PRISM.Service.StartWorkingModel GetStartWorkingModel();
    public void SetStartWorkingData(PRISM.Service.StartWorkingModel startWorkingModel);
    public PRISM.Service.StartOutingModel GetStartOutingModel();
    public void SetStartOutingData(PRISM.Service.StartOutingModel startOutingModel);
    public PRISM.Service.StartShoppingModel GetStartShoppingModel();
    public void SetStartShoppingData(PRISM.Service.StartShoppingModel startShoppingModel);
    public PRISM.Service.StartAdviceModel GetStartAdviceModel();
    public void SetStartAdviceData(PRISM.Service.StartAdviceModel startAdviceModel);
    public PRISM.Service.StartSpecialLessonModel GetStartSpecialLessonModel();
    public void SetSpecialLessonData(PRISM.Service.StartSpecialLessonModel startSpecialLessonModel);
    public PRISM.Service.StartAuditionModel GetStartAuditionModel();
    public void SetAuditionData(PRISM.Service.StartAuditionModel startAuditionModel);
    public PRISM.Service.StartSupportCooperationEventModel GetStartSupportCooperationEventModel();
    public void SetSupportCooperationEventData(PRISM.Service.StartSupportCooperationEventModel startSupportCooperationEventModel);
    public PRISM.Service.FinishTrainingModel GetFinishTrainingModel();
    public void SetFinishTrainingData(PRISM.Service.FinishTrainingModel finishTrainingModel);
    public PRISM.Service.FinishWorkingModel GetFinishWorkingModel();
    public void SetFinishWorkingData(PRISM.Service.FinishWorkingModel finishWorkingModel);
    public PRISM.Service.FinishOutingModel GetFinishOutingModel();
    public void SetFinishOutingData(PRISM.Service.FinishOutingModel finishOutingModel);
    public PRISM.Service.FinishShoppingModel GetFinishShoppingModel();
    public void SetFinishShoppingData(PRISM.Service.FinishShoppingModel finishShoppingModel);
    public PRISM.Service.FinishRestModel GetFinishRestModel();
    public void SetFinishRestData(PRISM.Service.FinishRestModel finishRestModel);
    public PRISM.Service.FinishAdviceModel GetFinishAdviceModel();
    public void SetFinishAdviceData(PRISM.Service.FinishAdviceModel finishAdviceModel);
    public PRISM.Service.FinishSupportCooperationEventModel GetFinishSupportCooperationEventModel();
    public void SetFinishSupportCooperationEventData(PRISM.Service.FinishSupportCooperationEventModel finishSupportCooperationEventModel);
    public void SetStartMiniLiveModel(PRISM.Service.StartMiniLiveModel model);
    public void SetStartTalkShowModel(PRISM.Service.StartTalkShowModel model);
    public PRISM.Service.StartMiniLiveModel GetStartMiniLiveModel();
    public PRISM.Service.StartTalkShowModel GetStartTalkShowModel();
    public void SetFinishMiniLiveModel(PRISM.Service.FinishMiniLiveModel model);
    public void SetFinishtTalkShowModel(PRISM.Service.FinishTalkShowModel model);
    public PRISM.Service.FinishMiniLiveModel GetFinishMiniLiveModel();
    public PRISM.Service.FinishTalkShowModel GetFinishTalkShowModel();
}

// Namespace: PRISM.Service
public class SelectProduceAdvOptionModel
{
    private PRISM.Module.Networking.ISelectProduceAdvOptionReply cacheSelectProduceAdvOptionReply;
    public void SetFinishLessonResult(PRISM.Module.Networking.ISelectProduceAdvOptionReply selectProduceAdvOptionReply);
    public PRISM.Module.Networking.ISelectProduceAdvOptionReply GetFinishLessonResult();
}

// Namespace: PRISM.Service
public class ShinyCompetitionProduceBonusData
{
    public int MstShinyCompetitionId;
    public int MstProduceBonusId;
    public int[] MissionValues;
    public int BonusValue;
    public bool IsCleared;
}

// Namespace: PRISM.Service
public class ShinyCompetitionProduceBonusSaveData : UnityEngine.ISerializationCallbackReceiver
{
    private System.Collections.Generic.List<PRISM.Service.ShinyCompetitionProduceBonusData> <ShinyCompetitionProduceBonusList>k__BackingField;
    private PRISM.Service.ShinyCompetitionProduceBonusData[] shinyCompetitionProduceBonusDatas;
    public System.Collections.Generic.List<PRISM.Service.ShinyCompetitionProduceBonusData> ShinyCompetitionProduceBonusList { get; set; }
    public void Initialize();
    public void SetShinyCompetitionProduceBonusList(System.Collections.Generic.IReadOnlyList<PRISM.Service.ShinyCompetitionProduceBonusData> newList);
    public void OnBeforeSerialize();
    public void OnAfterDeserialize();
}

// Namespace: PRISM.Service
public class ProfileAchievementIsNewSaveData
{
    private AchievementData[] achievementData;
    private System.Collections.Generic.Dictionary<int, AchievementInfo> achievementMap;
    public void Initialize();
    public void UpdateAchievementData();
    public bool CheckIsNew(int id);
    public void MarkNotNew(int id);

    public class AchievementInfo
    {
        public bool IsNew;
    }

    private class AchievementData
    {
        public int ID;
        public AchievementInfo Info;
    }

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<System.Collections.Generic.KeyValuePair<int, AchievementInfo>, AchievementData> <>9__3_0;
        private AchievementData <UpdateAchievementData>b__3_0(System.Collections.Generic.KeyValuePair<int, AchievementInfo> x);
    }
}

// Namespace: PRISM.Service
public class SeasonMissionSaveData
{
    private long lastDisplayedDateTime;
    public System.DateTime LastDisplayedDateTime { get; set; }
}

// Namespace: PRISM.Service
public interface IOverlay
{
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
}

// Namespace: PRISM.Service
public class OverlayManager
{
    private System.Collections.Generic.HashSet<PRISM.Service.IOverlay> displayingOverlays;
    public bool IsOverlayShow { get; set; }
    public Cysharp.Threading.Tasks.UniTask PushOverlayAsync(PRISM.Service.IOverlay overlay, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask PopOverlayAsync(PRISM.Service.IOverlay overlay);
    public Cysharp.Threading.Tasks.UniTask PopAllOverlayAsync();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Service.IOverlay, Cysharp.Threading.Tasks.UniTask> <>9__5_0;
        private Cysharp.Threading.Tasks.UniTask <PopAllOverlayAsync>b__5_0(PRISM.Service.IOverlay x);
    }
}

// Namespace: PRISM.Service
public class DownloadSaveData
{
    private string checkedResourceVersion;
    private int downloadType;
    public string CheckedResourceVersion { get; set; }
    public int DownloadType { get; set; }
    public void Update(string checkedResourceVersion, int downloadType);
}

// Namespace: PRISM.Service
public struct GraphicSettings : System.ValueType
{
    private UpScalingMode <UpScalingMode>k__BackingField;
    private QualityType <Quality3D>k__BackingField;
    private QualityType <ShadowQuality>k__BackingField;
    private QualityType <ReflectionQuality>k__BackingField;
    private AntiAliasingSMAA <AntiAliasingSmaa>k__BackingField;
    private OutlineForMV <OutlineForMV>k__BackingField;
    private RhythmGameMVEffectLevel <RhythmGame3DEffectLevel>k__BackingField;
    private PowerSaving <PowerSaving>k__BackingField;
    private PhysicsSetting <PhysicsSetting>k__BackingField;
    public static PRISM.Service.GraphicSettings Highest;
    public static PRISM.Service.GraphicSettings Graphic;
    public static PRISM.Service.GraphicSettings Performance;
    public UpScalingMode UpScalingMode { get; set; }
    public QualityType Quality3D { get; set; }
    public QualityType ShadowQuality { get; set; }
    public QualityType ReflectionQuality { get; set; }
    public AntiAliasingSMAA AntiAliasingSmaa { get; set; }
    public OutlineForMV OutlineForMV { get; set; }
    public RhythmGameMVEffectLevel RhythmGame3DEffectLevel { get; set; }
    public PowerSaving PowerSaving { get; set; }
    public PhysicsSetting PhysicsSetting { get; set; }
    public bool IsMatch(PRISM.Service.SystemSettingsSaveData saveData);
    public void ApplyTo(PRISM.Service.SystemSettingsSaveData saveData);
    public static void ApplyTo(GraphicProperty graphicProperty, PRISM.Service.SystemSettingsSaveData saveData);
    public static GraphicProperty GetCurrentProperty(PRISM.Service.SystemSettingsSaveData saveData);
}

// Namespace: PRISM.Service
public class NotificationSettingsSaveData
{
    public bool IsStaminaRecoveryNotification;
    public bool IsLiveBonusRecoveryNotification;
    public bool IsMissionNotClearNotification;
    public bool IsNotMidnightNotification;
    public bool IsContinuousLaunch;
}

// Namespace: PRISM.Service
public class SystemSettingsSaveData : UnityEngine.ISerializationCallbackReceiver
{
    private static float[] outGameResolutions;
    private static float[] mvGameResolutions;
    private static float[] rhythmGameResolutions;
    private UnityEngine.ScreenOrientation orientation;
    private bool gpuDetectedOnce;
    private GraphicProperty graphic;
    private UpScalingMode upScalingMode;
    private QualityType quality3D;
    private QualityType shadowQuality;
    private QualityType reflectionQuality;
    private AntiAliasingSMAA antiAliasingSmaa;
    private PowerSaving powerSaving;
    private OutlineForMV outlineForMV;
    private StoryVoiceSetting storyVoice;
    private SkipSetting skip;
    private PRISM.Legacy.SoundVolumeSettings bgmSettings;
    private PRISM.Legacy.SoundVolumeSettings seSettings;
    private PRISM.Legacy.SoundVolumeSettings voiceSettings;
    private bool isTitleCall;
    private float screenShrinkRate;
    private PhysicsSetting physicsSetting;
    private RhythmGameMVEffectLevel rhythmGame3DEffectLevel;
    private bool isFullScreenMode;
    public UnityEngine.ScreenOrientation Orientation { get; set; }
    public GraphicProperty Graphic { get; set; }
    public UpScalingMode UpScalingMode { get; set; }
    public QualityType Quality3D { get; set; }
    public QualityType ShadowQuality { get; set; }
    public QualityType ReflectionQuality { get; set; }
    public AntiAliasingSMAA AntiAliasingSmaa { get; set; }
    public PowerSaving PowerSaving { get; set; }
    public OutlineForMV OutlineForMV { get; set; }
    public StoryVoiceSetting StoryVoice { get; set; }
    public SkipSetting Skip { get; set; }
    public PRISM.Legacy.SoundVolumeSettings BgmSettings { get; set; }
    public PRISM.Legacy.SoundVolumeSettings SeSettings { get; set; }
    public PRISM.Legacy.SoundVolumeSettings VoiceSettings { get; set; }
    public bool IsTitleCall { get; set; }
    public float ScreenShrinkRate { get; set; }
    public PhysicsSetting PhysicsSetting { get; set; }
    public bool IsFullScreenMode { get; set; }
    public RhythmGameMVEffectLevel RhythmGame3DEffectLevel { get; set; }
    public void GPUDetectIfNeeded();
    public void ApplySettings(bool isIngame, bool isRhythmGame);
    public void ApplyOrientation();
    public void ApplySMAA();
    public void ApplyFrameRate();
    public void OnBeforeSerialize();
    public void OnAfterDeserialize();
}

// Namespace: PRISM.Service
public class TransferStopPopupModel
{
    private string <UserId>k__BackingField;
    public string UserId { get; set; }
    public Cysharp.Threading.Tasks.UniTask<string> GetFaqUrlAsync(System.Threading.CancellationToken ct);

    private struct <GetFaqUrlAsync>d__5 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<string> <>t__builder;
        public System.Threading.CancellationToken ct;
        private Awaiter<PRISM.Module.Networking.IGetVersionReply> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Service.Story
public class TutorialSaveData
{
    public int SelectedIdolId;
}

// Namespace: PRISM.Service.Shop
public class LoginBonusPassPopupData
{
    private int loginBonusPassMstProductId;
    public bool IsNotShowLoginPassReward;
    public long EffectEndViewLatestedTime;
    public int LoginBonusPassMstProductId { get; set; }
    public System.Nullable<System.DateTime> LoginBonusPassEffectEndPopupLastDisplayedDate { get; set; }
}

// Namespace: PRISM.Service.Shop
private class ProductItemDisplayedData
{
    private System.Nullable<System.DateTime> endDate;
    public ShopItemType ShopItemType;
    public ItemMasterType ItemMasterType;
    public int Id;
    public bool IsRead;
    public bool IsProductExpired(System.Nullable<System.DateTime> dateTime);
    public void SetDisplayed();
}

// Namespace: PRISM.Service.Shop
public class ShopSaveData : UnityEngine.ISerializationCallbackReceiver
{
    private long remindPopupLatestTime;
    private PRISM.Service.Shop.ProductItemDisplayedData[] productItemArray;
    private PRISM.Service.Shop.LoginBonusPassPopupData[] loginBonusPassPopupDatas;
    private System.Collections.Generic.List<PRISM.Service.Shop.ProductItemDisplayedData> <DisplayedDataList>k__BackingField;
    private System.Collections.Generic.List<PRISM.Service.Shop.LoginBonusPassPopupData> <LoginBonusPassPopupDataList>k__BackingField;
    private System.Collections.Generic.List<PRISM.Service.Shop.ProductItemDisplayedData> DisplayedDataList { get; set; }
    private System.Collections.Generic.List<PRISM.Service.Shop.LoginBonusPassPopupData> LoginBonusPassPopupDataList { get; set; }
    private long RemindPopupLatestTime { get; set; }
    private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
    private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
    public void AddDisplayedDataIfNotExists(int mstId, ShopItemType itemType, ItemMasterType masterType, System.Nullable<System.DateTime> endDate);
    public void RemoveExpiredDisplayedData();
    public void AddLoginBonusPassDataWithNeedSkipReceiveRewardPopupStatus(int masterId, bool isNotShow);
    public void AddLoginBonusPassDataWithPassEffectEndPopupLastDisplayedDate(int masterId, System.DateTime date);
    public void SetRemindPopupLastDisplayedDate(System.DateTime date);
    private PRISM.Service.Shop.LoginBonusPassPopupData _getOrCreateLoginBonusPassPopupData(int masterId);

    private class <>c__DisplayClass15_0
    {
        public int mstId;
        public ShopItemType itemType;
        public ItemMasterType masterType;
        private bool <AddDisplayedDataIfNotExists>b__0(PRISM.Service.Shop.ProductItemDisplayedData product);
    }

    private class <>c__DisplayClass16_0
    {
        public System.DateTime nowDateTime;
        private bool <RemoveExpiredDisplayedData>b__0(PRISM.Service.Shop.ProductItemDisplayedData x);
    }

    private class <>c__DisplayClass20_0
    {
        public int masterId;
        private bool <_getOrCreateLoginBonusPassPopupData>b__0(PRISM.Service.Shop.LoginBonusPassPopupData pd);
    }
}

// Namespace: PRISM.Service.Shop
public class ShopSaveDataExtensions
{
    public static bool AnyDisplayedDataExists(PRISM.Service.Shop.ShopSaveData self);
    public static bool IsDisplayed(PRISM.Service.Shop.ShopSaveData self, int id, ShopItemType type, ItemMasterType masterType);
    public static bool IsAllDisplayed(PRISM.Service.Shop.ShopSaveData self, ShopItemType itemType);
    public static void SetDisplayed(PRISM.Service.Shop.ShopSaveData self, ShopItemType itemType, int mstId, ItemMasterType masterType);
    public static void SetAllDisplayed(PRISM.Service.Shop.ShopSaveData self, ShopItemType itemType);
    public static bool NeedSkipLoginBonusPassRewardPopup(PRISM.Service.Shop.ShopSaveData self, int mstProductId);
    public static System.Nullable<System.DateTime> LoginBonusPassEffectEndPopupLastDisplayedDate(PRISM.Service.Shop.ShopSaveData self, int mstProductId);
    public static System.DateTime RemindPopupLatestDisplayedDate(PRISM.Service.Shop.ShopSaveData self);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Service.Shop.ProductItemDisplayedData, bool> <>9__2_1;
        private bool <IsAllDisplayed>b__2_1(PRISM.Service.Shop.ProductItemDisplayedData x);
    }

    private class <>c__DisplayClass1_0
    {
        public int id;
        public ShopItemType type;
        public ItemMasterType masterType;
        private bool <IsDisplayed>b__0(PRISM.Service.Shop.ProductItemDisplayedData x);
    }

    private class <>c__DisplayClass2_0
    {
        public ShopItemType itemType;
        private bool <IsAllDisplayed>b__0(PRISM.Service.Shop.ProductItemDisplayedData x);
    }

    private class <>c__DisplayClass3_0
    {
        public int mstId;
        public ShopItemType itemType;
        public ItemMasterType masterType;
        private bool <SetDisplayed>b__0(PRISM.Service.Shop.ProductItemDisplayedData x);
    }

    private class <>c__DisplayClass4_0
    {
        public ShopItemType itemType;
        public System.Func<PRISM.Service.Shop.ProductItemDisplayedData, bool> <>9__0;
        private bool <SetAllDisplayed>b__0(PRISM.Service.Shop.ProductItemDisplayedData x);
    }

    private class <>c__DisplayClass5_0
    {
        public int mstProductId;
        private bool <NeedSkipLoginBonusPassRewardPopup>b__0(PRISM.Service.Shop.LoginBonusPassPopupData pd);
    }

    private class <>c__DisplayClass6_0
    {
        public int mstProductId;
        private bool <LoginBonusPassEffectEndPopupLastDisplayedDate>b__0(PRISM.Service.Shop.LoginBonusPassPopupData pd);
    }
}

// Namespace: PRISM.Service.Produce
public class ChallengeTourSelectUnitStageSaveData
{
    private int selectUnitIndex;
    private int selectStageIndex;
    public int SelectUnitIndex { get; set; }
    public int SelectStageIndex { get; set; }
    public void Apply(int selectUnitIndex, int selectStageIndex);
}

// Namespace: PRISM.Service.Produce
public class ChallengeTourStageFilterPermanentData
{
    private bool[] isFilters;
    public bool[] IsFilters { get; set; }
    public bool IsFilterSettings { get; set; }
    public bool IsUpdate(bool[] flags);
    public void Apply(bool[] flags);
}

// Namespace: PRISM.Service.Produce
public class InheritanceFUnitSelectionSaveData
{
    private int selectedUnitIndex;
    private string sortFilterSettings;
    public int SelectedUnitIndex { get; set; }
    public PRISM.Definitions.SortFilterSettings SortFilterSettings { get; set; }
}

// Namespace: PRISM.Service.Produce
public class ProduceIdolSelectPermanentData
{
    private int unitNumber;
    private bool isShowFooter;
    public int UnitNumber { get; set; }
    public bool IsShowFooter { get; set; }
    public bool ApplyUnitNumber(int _unitNumber);
    public void ApplyShowFooterFlag(bool isShowFooter);
}

// Namespace: PRISM.Service.Produce
public class ProduceStaminaUsageSaveData
{
    private bool isAlwaysMax;
    private int usageValue;
    public bool IsAlwaysMax { get; set; }
    public int UsageValue { get; set; }
    public int GetUsableUsageValue(int currentStamina, int episodeStamina);
    public int GetNeedStaminaValue(int currentStamina, int episodeStamina);
    public void Apply(bool isAlwaysMax, int usageValue);
}

// Namespace: PRISM.Service.Notification
private class BirthdayNotification
{
    private static int NotificationHour;
    private int month;
    private int day;
    private string <Birthday>k__BackingField;
    public string Birthday { get; set; }
    public bool ExistUserBirthday { get; set; }
    public void SetBirthday(string birthday);
    public System.DateTime GetNotificationDay(System.DateTime currentTime);
}

// Namespace: PRISM.Service.Notification
public interface IMessagingHandler : System.IDisposable
{
    public bool IsListening { get; set; }
    public System.IObservable<Firebase.Messaging.FirebaseMessage> MessageReceived { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(bool firstInitialize, System.Threading.CancellationToken token);
    public Cysharp.Threading.Tasks.UniTask AskMessagingPermissionAsync(System.Threading.CancellationToken token);
    public Cysharp.Threading.Tasks.UniTask SetListeningAsync(bool listening, System.Threading.CancellationToken token);
    public Cysharp.Threading.Tasks.UniTask SwitchTopicAsync(Topic type, bool enable, System.Threading.CancellationToken token);
}

// Namespace: PRISM.Service.Notification
public interface INotificationHandler
{
    public void Initialize();
    public Cysharp.Threading.Tasks.UniTask<bool> AskNotificationPermissionAsync();
    public string SetScheduleNotification(PRISM.Service.Notification.NotificationModel model);
    public void RemoveScheduledNotification(string id);
    public void RemoveNotification(string id);
    public void RemoveBadge();
    public void OnApplicationSuspend();
    public string GetLastRespondedNotificationId();
    public void RemoveAllScheduledNotification();
}

// Namespace: PRISM.Service.Notification
public interface INotificationTextReader
{
    public string GetText(Kind key);
}

// Namespace: PRISM.Service.Notification
public class NotificationConst
{
    public static int MaxChannelCount;

    public enum Topic : System.Enum
    {
        public int value__;
        public static Topic StartGasha;
        public static Topic StartEvent;
        public static Topic StartSeason;
        public static Topic Bow;
        public static Topic StartStream;
        public static Topic BowImportant;
    }

    public enum Kind : System.Enum
    {
        public int value__;
        public static Kind StaminaMax;
        public static Kind LiveBoostMax;
        public static Kind Comeback;
        public static Kind ProducerBirthday;
        public static Kind DailyMission;
        public static Kind Topic;
    }
}

// Namespace: PRISM.Service.Notification
public class NotificationManager : PRISM.Legacy.INotificationManagerForLegacy, System.IDisposable
{
    private static string PrismTitle;
    private PRISM.Service.Notification.INotificationHandler notificationHandler;
    private PRISM.Service.Notification.ServerMessageFilter messageFilter;
    private Gleipnir.Savedata.SavableJsonObject<PRISM.Service.NotificationSettingsSaveData> settingsSaveData;
    private Gleipnir.Savedata.SavableJsonObject<PRISM.Service.NotificationSaveData> notificationSaveData;
    private PRISM.Service.Notification.INotificationTextReader textReader;
    private PRISM.Service.Notification.BirthdayNotification birthdayNotification;
    private UniRx.CompositeDisposable disposables;
    private bool moduleInitialized;
    private bool serverPushInitialized;
    private bool isNotificationPermission;
    private bool serverNotificationActivated;
    private System.Threading.CancellationTokenSource tokenSource;
    private bool isApplicationPause;
    public void Initialize();
    public Cysharp.Threading.Tasks.UniTask AskNotificationPermissionAsync();
    public Cysharp.Threading.Tasks.UniTask SetScheduleStaminaRecoveryAsync(System.Threading.CancellationToken ct);
    public void RemoveScheduleStaminaRecovery();
    public Cysharp.Threading.Tasks.UniTask SetScheduleLiveBoostRecoveryAsync(System.Threading.CancellationToken ct);
    public void RemoveScheduleLiveBoostRecovery();
    public void SetScheduleDailyMission();
    public void RemoveScheduleDailyMission();
    public void SetComebackNotification();
    public Cysharp.Threading.Tasks.UniTask ActivateServerNotificationAsync(bool enable, System.Threading.CancellationToken token);
    public void SetScheduleProducerBirthday(string birthday);
    public void ReplaceSaveData(Gleipnir.Savedata.SavableJsonObject<PRISM.Service.NotificationSettingsSaveData> settingsSaveData, Gleipnir.Savedata.SavableJsonObject<PRISM.Service.NotificationSaveData> notificationSaveData);
    public void Dispose();
    private bool _checkMidnight(System.DateTime notificationTime);
    private void _removeBirthdayNotification();
    private void _removeComebackNotification();
    private void _applicationPause(bool isPause);
    private void _removeNotificationActiveWhenApplication();
    private void _messageReceived(Firebase.Messaging.FirebaseMessage message);

    private struct <AskNotificationPermissionAsync>d__16 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Service.Notification.NotificationManager <>4__this;
        private Awaiter<bool> <>u__1;
        private Awaiter <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <SetScheduleLiveBoostRecoveryAsync>d__19 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Service.Notification.NotificationManager <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter<PRISM.Stamina.StaminaModel> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <SetScheduleStaminaRecoveryAsync>d__17 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Service.Notification.NotificationManager <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter<PRISM.Stamina.StaminaModel> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Service.Notification
public class NotificationModel
{
    private string <Title>k__BackingField;
    private string <Message>k__BackingField;
    private Kind <Kind>k__BackingField;
    private System.Nullable<System.DateTime> <NotificationTime>k__BackingField;
    private bool <IsShowForeground>k__BackingField;
    public string Title { get; set; }
    public string Message { get; set; }
    public Kind Kind { get; set; }
    public System.Nullable<System.DateTime> NotificationTime { get; set; }
    public bool IsUtcTime { get; set; }
    public bool IsShowForeground { get; set; }
}

// Namespace: PRISM.Service.Notification
private class ServerMessageFilter : System.IDisposable
{
    private PRISM.Service.Notification.IMessagingHandler messagingHandler;
    private UniRx.CompositeDisposable disposables;
    private bool allActivated;
    public bool IsAllActivated { get; set; }
    public System.IObservable<Firebase.Messaging.FirebaseMessage> MessageReceived { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(bool firstLaunch, System.Threading.CancellationToken token);
    public void Dispose();
    public Cysharp.Threading.Tasks.UniTask AskMessagingPermissionAsync(System.Threading.CancellationToken token);
    public Cysharp.Threading.Tasks.UniTask ActivateAllTopicAsync(bool enable, System.Threading.CancellationToken token);

    private class <>c__DisplayClass11_0
    {
        public PRISM.Service.Notification.ServerMessageFilter <>4__this;
        public bool enable;
        public System.Threading.CancellationToken token;
        private Cysharp.Threading.Tasks.UniTask <ActivateAllTopicAsync>b__0(Topic value);
    }

    private struct <InitializeAsync>d__8 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Service.Notification.ServerMessageFilter <>4__this;
        public bool firstLaunch;
        public System.Threading.CancellationToken token;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Service.Mobile
public class ChainGroupMemberScreenModel
{
}

// Namespace: PRISM.Service.Mobile
public class ChainProfileScreenModel
{
}

// Namespace: PRISM.Service.Mobile
public class MobileTopScreenModel
{
    private PRISM.Domain.StreamProgramService streamService;
    private System.Func<bool> unreadTwestaExistenceChecker;
    public bool IsUnread(Category category);
}

// Namespace: PRISM.Service.Mobile
public class MobileNotificationModel
{
    private PRISM.Domain.MobileService service;
    private PRISM.Domain.StreamProgramService streamService;
    private System.Collections.Generic.IEnumerable<PRISM.Module.Networking.ITwestaArticleStatus> newestTwestaArticles;
    public Cysharp.Threading.Tasks.UniTask UpdateTwestaCacheAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask UpdateOurStreamArchiveCacheAsync(System.Threading.CancellationToken ct);
    public System.Collections.Generic.IEnumerable<System.ValueTuple<int, int>> GetUnreadTwestaIds();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Module.Networking.ITwestaArticleStatus, bool> <>9__5_0;
        public static System.Func<PRISM.Module.Networking.ITwestaArticleStatus, System.Nullable<System.DateTime>> <>9__5_1;
        public static System.Func<PRISM.Module.Networking.ITwestaArticleStatus, int> <>9__5_2;
        public static System.Func<PRISM.Module.Networking.ITwestaArticleStatus, System.ValueTuple<int, int>> <>9__5_3;
        private bool <GetUnreadTwestaIds>b__5_0(PRISM.Module.Networking.ITwestaArticleStatus x);
        private System.Nullable<System.DateTime> <GetUnreadTwestaIds>b__5_1(PRISM.Module.Networking.ITwestaArticleStatus x);
        private int <GetUnreadTwestaIds>b__5_2(PRISM.Module.Networking.ITwestaArticleStatus x);
        private System.ValueTuple<int, int> <GetUnreadTwestaIds>b__5_3(PRISM.Module.Networking.ITwestaArticleStatus x);
    }

    private struct <UpdateTwestaCacheAsync>d__3 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Service.Mobile.MobileNotificationModel <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter<PRISM.Module.Networking.IGetTwestaListReply> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Service.Mobile
public class MobileNotificationPermanentData
{
    private NotifiedMobileIdList notifiedTwestaIdList;
    private NotifiedMobileIdList notifiedChainIdList;
    private NotifiedMobileIdList notifiedPhoneIdList;
    public bool AddTwestaArticleId(int twestaArticleId);
    public bool AddChainTalkId(int chainTalkId);
    public bool AddPhoneCallId(int phoneCallId);
    public bool IsTwestaNotified(int twestaArticleId);
    public bool IsChainNotified(int chainTalkId);
    public bool IsPhoneNotified(int phoneCallId);

    private class NotifiedMobileIdList
    {
        private System.Collections.Generic.List<int> notifiedMobileIdList;
        public bool Apply(int id);
        public bool IsRegistered(int id);
    }
}

// Namespace: PRISM.Service.Mobile
public class OurStreamArchiveDetailModel
{
    private PRISM.Domain.StreamProgramService service;
    public PRISM.Module.Networking.IArchiveStreamProgramStatus GetArchiveStream(int mstStreamProgramId);
    public Cysharp.Threading.Tasks.UniTask SetFavoriteAsync(int mstStreamProgramId, bool isOn, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask<PRISM.Module.Networking.IGetStreamArchiveLiveURLReply> GetArchiveInfoAsync(int mstStreamProgramId, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask<PRISM.Module.Networking.IReleasePremiumStreamReply> ReleasePremiumStreamAsync(int mstStreamProgramId, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask<PRISM.Module.Networking.IPlayStreamReply> PlayStreamAsync(int mstStreamProgramId, StreamMovieType streamMovieType, System.Collections.Generic.IEnumerable<PRISM.Module.Networking.IStreamCastStatus> castList, System.Threading.CancellationToken ct);
}

// Namespace: PRISM.Service.Mobile
public class OurStreamFavoriteListModel
{
    private PRISM.Domain.StreamProgramService service;
    private System.Collections.Generic.List<PRISM.Module.Networking.IArchiveStreamProgramStatus> favoriteList;
    public Cysharp.Threading.Tasks.UniTask GetArchiveListAsync(System.Threading.CancellationToken ct);
    public System.Collections.Generic.List<PRISM.Module.Networking.IArchiveStreamProgramStatus> GetFavoriteList();
    public Cysharp.Threading.Tasks.UniTask SetFavoriteAsync(int mstStreamProgramId, bool isOn, System.Threading.CancellationToken ct);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Module.Networking.IArchiveStreamProgramStatus, bool> <>9__3_0;
        public static System.Func<PRISM.Module.Networking.IArchiveStreamProgramStatus, System.Nullable<System.DateTime>> <>9__3_1;
        private bool <GetFavoriteList>b__3_0(PRISM.Module.Networking.IArchiveStreamProgramStatus x);
        private System.Nullable<System.DateTime> <GetFavoriteList>b__3_1(PRISM.Module.Networking.IArchiveStreamProgramStatus x);
    }
}

// Namespace: PRISM.Service.Mobile
public class OurStreamTopModel
{
    private PRISM.Domain.StreamProgramService service;
    private System.Collections.Generic.ISet<StreamCategoryType> archiveHeaderTabSelectedIndexList;
    public System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.ILiveStreamProgramStatus> LiveList { get; set; }
    public System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IArchiveStreamProgramStatus> ArchiveList { get; set; }
    public int NotDisplayedArchiveCount { get; set; }
    public Cysharp.Threading.Tasks.UniTask LiveListAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask ArchiveListAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask SetFavoriteAsync(int mstStreamProgramId, bool isOn, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask<PRISM.Module.Networking.IGetStreamProgramURLReply> GetLiveInfoAsync(int mstStreamProgramId, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask<PRISM.Module.Networking.IReleasePremiumStreamReply> ReleasePremiumStreamAsync(int mstStreamProgramId, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask<PRISM.Module.Networking.IPlayStreamReply> PlayStreamAsync(int mstStreamProgramId, StreamMovieType streamMovieType, System.Collections.Generic.IEnumerable<PRISM.Module.Networking.IStreamCastStatus> castList, System.Threading.CancellationToken ct);
    public void AddArchiveHeaderTabSelectedIndexList(int index);
    public Cysharp.Threading.Tasks.UniTask MarkDisplayedArchiveAsync(System.Threading.CancellationToken ct);

    private struct <LiveListAsync>d__8 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Service.Mobile.OurStreamTopModel <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter<PRISM.Module.Networking.IGetStreamProgramListReply> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <MarkDisplayedArchiveAsync>d__15 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Service.Mobile.OurStreamTopModel <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter<PRISM.Module.Networking.IMarkDisplayedArchiveStreamProgramReply> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Service.Mobile
public class MobileOverlayModel
{
    private PRISM.Domain.MobileService service;
    private PRISM.Domain.StreamProgramService streamService;
    private System.Func<bool> unreadTwestaExistenceChecker;
    public bool IsUnread(Category category);
}

// Namespace: PRISM.Service.Mobile
public class TwestaArticleTemporaryCache
{
    private System.Collections.Generic.Dictionary<int, PRISM.Module.Networking.ITwestaArticleStatus> cachedArticles;
    public System.Collections.Generic.IReadOnlyDictionary<int, PRISM.Module.Networking.ITwestaArticleStatus> Articles { get; set; }
    public void Store(System.Collections.Generic.IEnumerable<PRISM.Module.Networking.ITwestaArticleStatus> articles);
    public void SetAllRead();
    public void UpdateFavoriteStatus(int twestaArticleId, bool isFavorite, System.DateTime favoriteDate);
    public void Clear();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<System.Collections.Generic.KeyValuePair<int, PRISM.Module.Networking.ITwestaArticleStatus>, bool> <>9__4_0;
        private bool <SetAllRead>b__4_0(System.Collections.Generic.KeyValuePair<int, PRISM.Module.Networking.ITwestaArticleStatus> x);
    }
}

// Namespace: PRISM.Service.Live
public interface ILiveUnitConfirmationCommonModel
{
    public PRISM.Live.MusicData MusicData { get; set; }
    public SongDifficultyLevel Difficulty { get; set; }
    public UniRx.IReadOnlyReactiveProperty<PRISM.Live.ILiveUnit> CurrentUnit { get; set; }
    public PRISM.Service.Live.LiveUnitConfirmationReactiveSaveDataModel SaveData { get; set; }
    public UniRx.ReactiveProperty<PRISM.RhythmGame.LiveBackgroundMode> BackgroundMode { get; set; }
    public PRISM.RhythmGame.LiveBackgroundMode GetAvailableBackgroundMode(PRISM.RhythmGame.LiveBackgroundMode mode);
    public bool IsAvailable(PRISM.RhythmGame.LiveBackgroundMode mode);
    public PRISM.RhythmGame.LiveBackgroundMode GetNextBackgroundMode(PRISM.RhythmGame.LiveBackgroundMode mode);
}

// Namespace: PRISM.Service.Live
public class LiveUnitConfirmationCommonModelExtensions
{
    public static void AdjustBackgroundMode(PRISM.Service.Live.ILiveUnitConfirmationCommonModel model);
}

// Namespace: PRISM.Service.Live
public class LiveAutoLoopSaveData
{
    public int LiveBoostUsageCount;
    public int LoopCount;
    public bool ForceLightweightBackground;
    public bool EnableAutoRecovery;
    public bool IsConsumeJewel;
    public int[] ConsumeRecoveryDrinkIds;
}

// Namespace: PRISM.Service.Live
public class LiveGuestSelectionSaveData
{
    private string sortFilterSettings;
    public PRISM.Definitions.SortFilterSettings SortFilterSettings { get; set; }
}

// Namespace: PRISM.Service.Live
public class LiveMusicSelectionModel : System.IDisposable
{
    private System.Collections.Generic.List<PRISM.Live.MusicData> allMusic;
    private System.Collections.Generic.Dictionary<int, System.Collections.Generic.IReadOnlyList<PRISM.Live.MusicData>> rawMusicListDic;
    private System.Collections.Generic.Dictionary<int, PRISM.Live.MusicData> selectedMusicDic;
    private PRISM.Live.LiveMusicSelectionSaveData saveData;
    private System.Collections.Generic.Dictionary<FavoriteSongSlot, PRISM.Live.FavoriteMusicGroup> favoriteMusicGroups;
    private int unlockedSongLevelForMaster;
    private UniRx.CompositeDisposable disposable;
    private System.Collections.Generic.IList<PRISM.Definitions.MstSongType> <MusicCategoryList>k__BackingField;
    private int <SelectedCategoryIndex>k__BackingField;
    public UniRx.ReactiveProperty<PRISM.Live.MusicListSwitchDisplayType> ListDisplayType;
    private PRISM.Service.Live.MusicListSortFilterModel sortFilterModel;
    private SongDifficultyLevel <SelectedMusicDifficulty>k__BackingField;
    public System.Collections.Generic.IList<PRISM.Definitions.MstSongType> MusicCategoryList { get; set; }
    public int SelectedCategoryIndex { get; set; }
    public PRISM.Live.MusicData CurrentCategorySelectedMusic { get; set; }
    public System.Collections.Generic.IEnumerable<PRISM.Live.MusicData> AllMusic { get; set; }
    public PRISM.Service.ISortFilterModel SortFilterModel { get; set; }
    public SongDifficultyLevel SelectedMusicDifficulty { get; set; }
    public SongDifficultyLevel SavedMusicDifficulty { get; set; }
    public System.Collections.Generic.IEnumerable<PRISM.Live.FavoriteMusicGroup> FavoriteMusicGroups { get; set; }
    public PRISM.Live.MusicRateType RateViewType { get; set; }
    public static PRISM.Definitions.SortFilterSettings AdjustSortFilterSettings(PRISM.Definitions.SortFilterSettings settings);
    public System.Collections.Generic.IReadOnlyList<PRISM.Live.MusicData> GetCurrentCategorySortFilterAppliedMusicList(bool forceReapply);
    public PRISM.Live.FavoriteMusicGroup GetFavoriteMusicGroup(FavoriteSongSlot slot);
    public void SaveSelection();
    public void SaveDisplayedMusic();
    public bool IsMasterLocked();
    public void Dispose();
    private PRISM.Live.MusicData <.ctor>b__34_4(PRISM.Module.Networking.ISongStatus s);
    private void <.ctor>b__34_5(PRISM.Live.MusicListSwitchDisplayType value);
    private SongDifficultyLevel <.ctor>b__34_6();
    private void <.ctor>b__34_7(PRISM.Definitions.SortFilterSettings settings);
    private bool <GetCurrentCategorySortFilterAppliedMusicList>b__36_0(PRISM.Live.MusicData m);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Definitions.MstSongType, int> <>9__34_1;
        public static System.Func<PRISM.Module.Networking.IFavoriteSongStatus, FavoriteSongSlot> <>9__34_2;
        public static System.Func<PRISM.Module.Networking.IFavoriteSongStatus, PRISM.Live.FavoriteMusicGroup> <>9__34_3;
        public static System.Func<PRISM.Live.MusicData, bool> <>9__39_0;
        public static System.Func<PRISM.Live.MusicData, int> <>9__39_1;
        private int <.ctor>b__34_1(PRISM.Definitions.MstSongType x);
        private FavoriteSongSlot <.ctor>b__34_2(PRISM.Module.Networking.IFavoriteSongStatus x);
        private PRISM.Live.FavoriteMusicGroup <.ctor>b__34_3(PRISM.Module.Networking.IFavoriteSongStatus x);
        private bool <SaveDisplayedMusic>b__39_0(PRISM.Live.MusicData m);
        private int <SaveDisplayedMusic>b__39_1(PRISM.Live.MusicData m);
    }

    private class <>c__DisplayClass34_0
    {
        public PRISM.Definitions.MasterData masterData;
        private PRISM.Definitions.MstSongType <.ctor>b__0(PRISM.Module.Networking.ISongStatus s);
    }
}

// Namespace: PRISM.Service.Live
public class LiveMvUnitConfirmationModel : PRISM.Service.Live.ILiveUnitConfirmationCommonModel, System.IDisposable
{
    private static int UnitMaxCount;
    private static int UnitMaxCountSummer;
    private PRISM.Live.MusicData <MusicData>k__BackingField;
    private UniRx.ReadOnlyReactiveProperty<PRISM.Live.ILiveUnit> currentUnit;
    private PRISM.Service.Live.LiveUnitConfirmationReactiveSaveDataModel <SaveData>k__BackingField;
    private UniRx.ReactiveProperty<PRISM.RhythmGame.LiveBackgroundMode> <BackgroundMode>k__BackingField;
    private UniRx.ReactiveProperty<PRISM.Definitions.RenderingDynamicRange> <RenderingDynamicRange>k__BackingField;
    private System.Collections.Generic.IList<PRISM.Live.LiveMVUnit> <Units>k__BackingField;
    private PRISM.Live.LiveMVUnit <MvOriginalUnit>k__BackingField;
    public UniRx.ReactiveProperty<PRISM.Live.LiveMVUnitConfirmationUnitEditTabType> TabType;
    public UniRx.IReadOnlyReactiveProperty<bool> CanPlay;
    private UniRx.CompositeDisposable disposables;
    private PRISM.Live.LiveMVUnitConfirmationSaveData saveData;
    private PRISM.Domain.ICachedCostumeService costumeService;
    private PRISM.Service.Live.LiveUnitEasyCostumeChanger easyCostumeChanger;
    public PRISM.Live.MusicData MusicData { get; set; }
    public SongDifficultyLevel Difficulty { get; set; }
    public UniRx.IReadOnlyReactiveProperty<PRISM.Live.ILiveUnit> CurrentUnit { get; set; }
    public PRISM.Service.Live.LiveUnitConfirmationReactiveSaveDataModel SaveData { get; set; }
    public UniRx.ReactiveProperty<PRISM.RhythmGame.LiveBackgroundMode> BackgroundMode { get; set; }
    public UniRx.ReactiveProperty<PRISM.Definitions.RenderingDynamicRange> RenderingDynamicRange { get; set; }
    public System.Collections.Generic.IList<PRISM.Live.LiveMVUnit> Units { get; set; }
    public PRISM.Live.LiveMVUnit MvOriginalUnit { get; set; }
    public bool MvOriginalCostumeExists { get; set; }
    public void Dispose();
    public Cysharp.Threading.Tasks.UniTask ResetUnitAsync(int unitId, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask CopyUnitAsync(int unitFrom, int unitTo, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask UpdateRecommendedUnitAsync(PRISM.Live.LiveMvUnitRecommendConfig config, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask ExchangeMemberPositionAsync(PRISM.Live.LiveMVUnit unit, int index1, int index2, System.Threading.CancellationToken ct);
    public void UpdateUnit(PRISM.Module.Networking.IMvUnitStatus unit);
    private void _updateUnit(PRISM.Live.LiveMVUnit unit);
    public void ToggleRenderingDynamicRange();
    private void _updateRenderingDynamicRange();
    public System.ValueTuple<PRISM.Live.LiveMVStartData, PRISM.Live.ILiveUnit> ToStartData();
    public Cysharp.Threading.Tasks.UniTask LiveUnitEasyCostumeChangeAsync(PRISM.Live.LiveUnitRecommendCostume costume, System.Threading.CancellationToken ct);

    private class <>O
    {
        public static System.Func<PRISM.Live.LiveMVIdol, PRISM.Module.Networking.IMvIdolStatus> <0>__NewMvIdol;
    }

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Module.Networking.IMvUnitStatus, int> <>9__33_0;
        public static System.Func<PRISM.Live.IIdol, bool> <>9__33_5;
        public static System.Func<PRISM.Live.LiveMVIdol, bool> <>9__37_4;
        public static System.Func<PRISM.Live.LiveMVIdol, bool> <>9__37_5;
        public static System.Func<PRISM.Live.LiveMVIdol, int, PRISM.Module.Networking.IMvUnitSlotStatus> <>9__37_0;
        public static System.Func<PRISM.Live.LiveMVIdol, int, PRISM.Module.Networking.IMvUnitSlotStatus> <>9__44_0;
        private int <.ctor>b__33_0(PRISM.Module.Networking.IMvUnitStatus unit);
        private bool <.ctor>b__33_5(PRISM.Live.IIdol idol);
        private bool <UpdateRecommendedUnitAsync>b__37_4(PRISM.Live.LiveMVIdol x);
        private bool <UpdateRecommendedUnitAsync>b__37_5(PRISM.Live.LiveMVIdol _);
        private PRISM.Module.Networking.IMvUnitSlotStatus <UpdateRecommendedUnitAsync>b__37_0(PRISM.Live.LiveMVIdol idol, int index);
        private PRISM.Module.Networking.IMvUnitSlotStatus <LiveUnitEasyCostumeChangeAsync>b__44_0(PRISM.Live.LiveMVIdol x, int i);
    }

    private class <>c__DisplayClass33_0
    {
        public PRISM.Live.LiveMVUnitConfirmationSaveData saveData;
        public PRISM.Service.Live.LiveMvUnitConfirmationModel <>4__this;
        private void <.ctor>b__1(PRISM.RhythmGame.LiveBackgroundMode mode);
        private void <.ctor>b__2(PRISM.Live.LiveMVUnitConfirmationUnitEditTabType type);
        private PRISM.Live.ILiveUnit <.ctor>b__3(int index, PRISM.Live.LiveMVUnitConfirmationUnitEditTabType tabType);
        private bool <.ctor>b__4(PRISM.Live.ILiveUnit unit, PRISM.RhythmGame.LiveBackgroundMode backgroundMode);
    }

    private class <>c__DisplayClass37_0
    {
        public System.Collections.Generic.HashSet<int> originalMembers;
        public int currentIndex;
        public PRISM.Live.LiveMVIdol[] idols;
        public PRISM.Live.LiveMVIdol[] allIdols;
        public PRISM.Service.Live.LiveMvUnitConfirmationModel <>4__this;
        private bool <UpdateRecommendedUnitAsync>b__6(PRISM.Live.LiveMVIdol idol);
        private void <UpdateRecommendedUnitAsync>g__AddOriginalMembers|1();
        private void <UpdateRecommendedUnitAsync>g__SelectUnitMembers|2(int unitId);
        private void <UpdateRecommendedUnitAsync>g__SelectIdols|3(System.Func<PRISM.Live.LiveMVIdol, bool> idolSelector);
    }

    private class <>c__DisplayClass37_1
    {
        public int id;
        private bool <UpdateRecommendedUnitAsync>b__7(PRISM.Live.LiveMVIdol x);
    }

    private class <>c__DisplayClass37_2
    {
        public int unitId;
        private bool <UpdateRecommendedUnitAsync>b__8(PRISM.Live.LiveMVIdol idol);
        private bool <UpdateRecommendedUnitAsync>b__9(PRISM.Live.LiveMVIdol idol);
    }

    private class <>c__DisplayClass40_0
    {
        public PRISM.Live.LiveMVUnit unit;
        private bool <_updateUnit>b__0(PRISM.Live.LiveMVUnit x);
    }

    private struct <CopyUnitAsync>d__36 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public int unitFrom;
        public int unitTo;
        public System.Threading.CancellationToken ct;
        public PRISM.Service.Live.LiveMvUnitConfirmationModel <>4__this;
        private Awaiter<PRISM.Module.Networking.ICopyMvUnitReply> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <ExchangeMemberPositionAsync>d__38 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Live.LiveMVUnit unit;
        public int index1;
        public int index2;
        public System.Threading.CancellationToken ct;
        public PRISM.Service.Live.LiveMvUnitConfirmationModel <>4__this;
        private Awaiter<PRISM.Module.Networking.ISetMvUnitReply> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <LiveUnitEasyCostumeChangeAsync>d__44 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Service.Live.LiveMvUnitConfirmationModel <>4__this;
        public PRISM.Live.LiveUnitRecommendCostume costume;
        public System.Threading.CancellationToken ct;
        private PRISM.Live.LiveMVUnit <unit>5__2;
        private Awaiter<PRISM.Module.Networking.ISetMvOriginalMemberReply> <>u__1;
        private Awaiter<PRISM.Module.Networking.ISetMvUnitReply> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <ResetUnitAsync>d__35 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public int unitId;
        public System.Threading.CancellationToken ct;
        public PRISM.Service.Live.LiveMvUnitConfirmationModel <>4__this;
        private Awaiter<PRISM.Module.Networking.IResetMvUnitReply> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <UpdateRecommendedUnitAsync>d__37 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Service.Live.LiveMvUnitConfirmationModel <>4__this;
        public System.Threading.CancellationToken ct;
        private <>c__DisplayClass37_0 <>8__1;
        public PRISM.Live.LiveMvUnitRecommendConfig config;
        private System.IDisposable <_>5__2;
        private Awaiter<System.Collections.Generic.IReadOnlyList<PRISM.Live.LiveMVIdol>> <>u__1;
        private Awaiter<PRISM.Module.Networking.ISetMvUnitReply> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Service.Live
public class LiveResultSaveData
{
    private bool showJudgeDetail;
    public bool ShowJudgeDetail { get; set; }
}

// Namespace: PRISM.Service.Live
public class LiveSupportMemberSelector
{
    public static System.Collections.Generic.Dictionary<LiveUnitSupportMemberType, PRISM.Module.Networking.ISupportCharacterStatus> Select(System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<PRISM.Module.Networking.ISupportCharacterStatus>> candidates);
    private static void <Select>g__SearchRecursive|0_2(<>c__DisplayClass0_0& );

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<LiveUnitSupportMemberType, bool> <>9__0_0;
        public static System.Func<LiveUnitSupportMemberType, System.ValueTuple<LiveUnitSupportMemberType, System.Collections.Generic.List<System.ValueTuple<PRISM.Module.Networking.ISupportCharacterStatus, int, int>>>> <>9__0_1;
        public static System.Comparison<System.ValueTuple<PRISM.Module.Networking.ISupportCharacterStatus, int, int>> <>9__0_3;
        private bool <Select>b__0_0(LiveUnitSupportMemberType x);
        private System.ValueTuple<LiveUnitSupportMemberType, System.Collections.Generic.List<System.ValueTuple<PRISM.Module.Networking.ISupportCharacterStatus, int, int>>> <Select>b__0_1(LiveUnitSupportMemberType x);
        private int <Select>b__0_3(System.ValueTuple<PRISM.Module.Networking.ISupportCharacterStatus, int, int> x, System.ValueTuple<PRISM.Module.Networking.ISupportCharacterStatus, int, int> y);
    }

    private struct <>c__DisplayClass0_0 : System.ValueType
    {
        public System.Collections.Generic.List<System.ValueTuple<LiveUnitSupportMemberType, System.Collections.Generic.List<System.ValueTuple<PRISM.Module.Networking.ISupportCharacterStatus, int, int>>>> selectors;
        public int selectedParameter;
        public int maxParameter;
        public System.Collections.Generic.Dictionary<LiveUnitSupportMemberType, PRISM.Module.Networking.ISupportCharacterStatus> selectedCharacters;
        public System.Collections.Generic.Dictionary<LiveUnitSupportMemberType, PRISM.Module.Networking.ISupportCharacterStatus> result;
    }
}

// Namespace: PRISM.Service.Live
public class LiveSupportSelectionSaveData
{
    private int selectedDisplayModeIndex;
    private string sortFilterSettings;
    public int SelectedDisplayModeIndex { get; set; }
    public PRISM.Definitions.SortFilterSettings SortFilterSettings { get; set; }
}

// Namespace: PRISM.Service.Live
public class LiveUnitConfirmationModel : PRISM.Service.Live.ILiveUnitConfirmationCommonModel, System.IDisposable
{
    private static int UnitMaxCount;
    private static int UnitMaxCountSummer;
    private PRISM.Live.MusicData <MusicData>k__BackingField;
    private SongDifficultyLevel <Difficulty>k__BackingField;
    private UniRx.ReadOnlyReactiveProperty<PRISM.Live.ILiveUnit> currentUnit;
    private PRISM.Service.Live.LiveUnitConfirmationReactiveSaveDataModel <SaveData>k__BackingField;
    private UniRx.ReactiveProperty<PRISM.RhythmGame.LiveBackgroundMode> <BackgroundMode>k__BackingField;
    private System.Collections.Generic.IList<PRISM.Live.LiveUnit> <Units>k__BackingField;
    public UniRx.ReactiveProperty<PRISM.Live.LiveUnitConfirmationUnitEditTabType> TabType;
    public UniRx.ReactiveProperty<PRISM.Live.LiveUnitConfirmationStatusDisplayType> StatusDisplayType;
    public UniRx.ReactiveProperty<PRISM.Live.LiveSupportSelectionDisplayMode> SupportStatusDisplayType;
    private UniRx.CompositeDisposable disposables;
    private PRISM.Live.LiveIdolFactory liveIdolFactory;
    private PRISM.Domain.ILiveService service;
    private PRISM.Service.Live.LiveUnitEasyCostumeChanger easyCostumeChanger;
    public PRISM.Live.MusicData MusicData { get; set; }
    public SongDifficultyLevel Difficulty { get; set; }
    public UniRx.IReadOnlyReactiveProperty<PRISM.Live.ILiveUnit> CurrentUnit { get; set; }
    public PRISM.Service.Live.LiveUnitConfirmationReactiveSaveDataModel SaveData { get; set; }
    public UniRx.ReactiveProperty<PRISM.RhythmGame.LiveBackgroundMode> BackgroundMode { get; set; }
    public System.Collections.Generic.IList<PRISM.Live.LiveUnit> Units { get; set; }
    public bool MvOriginalCostumeExists { get; set; }
    public void Dispose();
    public Cysharp.Threading.Tasks.UniTask ResetCurrentUnitAsync(System.Collections.Generic.IReadOnlyList<bool> resultToggleStatusList, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask ResetUnitAsync(int unitId, System.Collections.Generic.IReadOnlyList<bool> resultToggleStatusList, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask CopyUnitAsync(int unitFrom, int unitTo, System.Collections.Generic.IReadOnlyList<bool> resultToggleStatusList, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask UpdateRecommendedUnitAsync(PRISM.Live.LiveUnitRecommendConfig config, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask ExchangeMemberPositionAsync(PRISM.Live.LiveUnit unit, int index1, int index2, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask ChangeMemberAsync(PRISM.Live.LiveUnit unit, int index, PRISM.Live.LiveIdol idol, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask ChangeSupportMemberAsync(PRISM.Live.LiveUnit unit, LiveUnitSupportMemberType type, int supportCharacterId, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask ExchangeSupportMemberPositionAsync(PRISM.Live.LiveUnit unit, LiveUnitSupportMemberType type1, LiveUnitSupportMemberType type2, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask ChangeGuestAsync(PRISM.Live.LiveUnit unit, string guestUserId, int guestProduceIdolId, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask ChangeSkillOrdersAsync(PRISM.Live.LiveUnit unit, System.Collections.Generic.IReadOnlyList<int> orders, System.Threading.CancellationToken ct);
    public void UpdateUnit(PRISM.Module.Networking.ILiveUnitDetailStatus unit);
    private void _updateUnit(PRISM.Live.LiveUnit unit);
    public Cysharp.Threading.Tasks.UniTask<PRISM.Live.LiveStartData> GetLiveStartDataAsync(PRISM.Live.LiveUnit unit, int useLiveBoost, System.Nullable<PRISM.RhythmGame.LiveBackgroundMode> overrideBackgroundMode, PRISM.Live.LiveAutoLoopConfig autoLoopConfig, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask LiveUnitEasyCostumeChangeAsync(PRISM.Live.LiveUnitRecommendCostume costume, System.Threading.CancellationToken ct);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Live.LiveIdol, int, PRISM.Module.Networking.ILiveUnitSlotStatus> <>9__34_0;
        public static System.Func<System.Collections.Generic.KeyValuePair<LiveUnitSupportMemberType, PRISM.Module.Networking.ISupportCharacterStatus>, PRISM.Module.Networking.ILiveUnitSupportMemberStatus> <>9__34_1;
        public static System.Func<PRISM.Live.LiveIdol, int, PRISM.Module.Networking.ILiveUnitSlotStatus> <>9__44_0;
        private PRISM.Module.Networking.ILiveUnitSlotStatus <UpdateRecommendedUnitAsync>b__34_0(PRISM.Live.LiveIdol x, int i);
        private PRISM.Module.Networking.ILiveUnitSupportMemberStatus <UpdateRecommendedUnitAsync>b__34_1(System.Collections.Generic.KeyValuePair<LiveUnitSupportMemberType, PRISM.Module.Networking.ISupportCharacterStatus> x);
        private PRISM.Module.Networking.ILiveUnitSlotStatus <LiveUnitEasyCostumeChangeAsync>b__44_0(PRISM.Live.LiveIdol x, int i);
    }

    private class <>c__DisplayClass29_0
    {
        public PRISM.Service.Live.LiveUnitConfirmationModel <>4__this;
        public PRISM.Live.LiveUnitConfirmationSaveData saveData;
        private PRISM.Live.ILiveUnit <.ctor>b__0(int i);
        private void <.ctor>b__1(PRISM.RhythmGame.LiveBackgroundMode mode);
        private void <.ctor>b__2(PRISM.Live.LiveUnitConfirmationUnitEditTabType type);
        private void <.ctor>b__3(PRISM.Live.LiveUnitConfirmationStatusDisplayType type);
        private void <.ctor>b__4(PRISM.Live.LiveSupportSelectionDisplayMode type);
    }

    private class <>c__DisplayClass36_0
    {
        public PRISM.Live.LiveIdol idol;
        private bool <ChangeMemberAsync>b__0(PRISM.Live.LiveIdol x);
    }

    private class <>c__DisplayClass37_0
    {
        public LiveUnitSupportMemberType type;
        private bool <ChangeSupportMemberAsync>b__0(System.Collections.Generic.KeyValuePair<LiveUnitSupportMemberType, PRISM.Live.LiveSupportCharacterViewModel> m);
    }

    private class <>c__DisplayClass42_0
    {
        public PRISM.Live.LiveUnit unit;
        private bool <_updateUnit>b__0(PRISM.Live.LiveUnit x);
    }

    private struct <ChangeGuestAsync>d__39 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Service.Live.LiveUnitConfirmationModel <>4__this;
        public PRISM.Live.LiveUnit unit;
        public string guestUserId;
        public int guestProduceIdolId;
        public System.Threading.CancellationToken ct;
        private Awaiter<PRISM.Module.Networking.ISetLiveUnitGuestReply> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <ChangeMemberAsync>d__36 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Live.LiveIdol idol;
        public PRISM.Live.LiveUnit unit;
        public PRISM.Service.Live.LiveUnitConfirmationModel <>4__this;
        public int index;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private Awaiter<PRISM.Module.Networking.ISetLiveUnitReply> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <ChangeSkillOrdersAsync>d__40 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Service.Live.LiveUnitConfirmationModel <>4__this;
        public PRISM.Live.LiveUnit unit;
        public System.Collections.Generic.IReadOnlyList<int> orders;
        public System.Threading.CancellationToken ct;
        private Awaiter<PRISM.Module.Networking.ISetLiveUnitSkillOrderReply> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <ChangeSupportMemberAsync>d__37 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public LiveUnitSupportMemberType type;
        public int supportCharacterId;
        public PRISM.Live.LiveUnit unit;
        public PRISM.Service.Live.LiveUnitConfirmationModel <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter<PRISM.Module.Networking.ISetLiveUnitSupportMemberReply> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <CopyUnitAsync>d__33 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public int unitFrom;
        public int unitTo;
        public System.Collections.Generic.IReadOnlyList<bool> resultToggleStatusList;
        public System.Threading.CancellationToken ct;
        public PRISM.Service.Live.LiveUnitConfirmationModel <>4__this;
        private Awaiter<PRISM.Module.Networking.ICopyLiveUnitReply> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <ExchangeMemberPositionAsync>d__35 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Service.Live.LiveUnitConfirmationModel <>4__this;
        public PRISM.Live.LiveUnit unit;
        public int index1;
        public int index2;
        public System.Threading.CancellationToken ct;
        private Awaiter<PRISM.Module.Networking.ISetLiveUnitReply> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <ExchangeSupportMemberPositionAsync>d__38 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Service.Live.LiveUnitConfirmationModel <>4__this;
        public PRISM.Live.LiveUnit unit;
        public LiveUnitSupportMemberType type1;
        public LiveUnitSupportMemberType type2;
        public System.Threading.CancellationToken ct;
        private Awaiter<PRISM.Module.Networking.ISetLiveUnitSupportMemberReply> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <LiveUnitEasyCostumeChangeAsync>d__44 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Service.Live.LiveUnitConfirmationModel <>4__this;
        public PRISM.Live.LiveUnitRecommendCostume costume;
        public System.Threading.CancellationToken ct;
        private Awaiter<PRISM.Module.Networking.ISetLiveUnitReply> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <ResetCurrentUnitAsync>d__31 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Service.Live.LiveUnitConfirmationModel <>4__this;
        public System.Collections.Generic.IReadOnlyList<bool> resultToggleStatusList;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <ResetUnitAsync>d__32 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Service.Live.LiveUnitConfirmationModel <>4__this;
        public int unitId;
        public System.Collections.Generic.IReadOnlyList<bool> resultToggleStatusList;
        public System.Threading.CancellationToken ct;
        private Awaiter<PRISM.Module.Networking.IResetLiveUnitReply> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <UpdateRecommendedUnitAsync>d__34 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Service.Live.LiveUnitConfirmationModel <>4__this;
        public PRISM.Live.LiveUnitRecommendConfig config;
        public System.Threading.CancellationToken ct;
        private PRISM.Live.LiveUnit <unit>5__2;
        private PRISM.Service.Live.LiveUnitRecommendCalculator <calculator>5__3;
        private Awaiter<PRISM.Module.Networking.ISetLiveUnitReply> <>u__1;
        private Awaiter<PRISM.Module.Networking.ISetLiveUnitSupportMemberReply> <>u__2;
        private Awaiter<PRISM.Module.Networking.IGetLiveGuestListReply> <>u__3;
        private Awaiter<PRISM.Module.Networking.ISetLiveUnitGuestReply> <>u__4;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Service.Live
public class LiveUnitConfirmationReactiveSaveDataModel : System.IDisposable
{
    public UniRx.ReactiveProperty<int> SelectedUnitIndex;
    public UniRx.ReactiveProperty<PRISM.Live.LiveCameraModeSetting> CameraModeSetting;
    public UniRx.ReactiveProperty<bool> IsVocalSeparatedOn;
    public UniRx.ReactiveProperty<bool> IsAlreadyShowVocalSeparated;
    public UniRx.ReactiveProperty<PRISM.Definitions.VocalSeparatedSoundEffectMode> SoundEffectMode;
    private UniRx.CompositeDisposable disposables;
    public void Dispose();

    private class <>c__DisplayClass6_0
    {
        public PRISM.Live.LiveUnitConfirmationSaveDataBase saveData;
        public int specialUnitCount;
        public PRISM.Live.MusicData musicData;
        private void <.ctor>b__0(int index);
        private void <.ctor>b__1(PRISM.Live.LiveCameraModeSetting setting);
        private void <.ctor>b__2(bool isOn);
        private void <.ctor>b__3(bool isShow);
        private void <.ctor>b__4(PRISM.Definitions.VocalSeparatedSoundEffectMode soundEffectMode);
    }
}

// Namespace: PRISM.Service.Live
public class LiveUnitEasyCostumeChanger
{
    private PRISM.Domain.ICachedCostumeService costumeService;
    private int mstSongId;
    private System.Random random;
    public bool MvOriginalCostumeExists();
    public void ChangeLiveIdolCostume(PRISM.Live.LiveUnitRecommendCostume costume, System.Collections.Generic.IReadOnlyList<PRISM.Live.IIdol> idols, bool isCostumeUnlimited);
    private bool <MvOriginalCostumeExists>b__4_0(PRISM.Definitions.MstCostumeSet x);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Domain.CostumeSetData, bool> <>9__5_4;
        public static System.Func<PRISM.Domain.CostumeSetData, bool> <>9__5_5;
        public static System.Func<PRISM.Module.Networking.IHairstyleStatus, bool> <>9__5_9;
        public static System.Func<PRISM.Module.Networking.IAccessoryStatus, bool> <>9__5_11;
        private bool <ChangeLiveIdolCostume>b__5_4(PRISM.Domain.CostumeSetData x);
        private bool <ChangeLiveIdolCostume>b__5_5(PRISM.Domain.CostumeSetData x);
        private bool <ChangeLiveIdolCostume>b__5_9(PRISM.Module.Networking.IHairstyleStatus x);
        private bool <ChangeLiveIdolCostume>b__5_11(PRISM.Module.Networking.IAccessoryStatus x);
    }

    private class <>c__DisplayClass5_0
    {
        public PRISM.Service.Live.LiveUnitEasyCostumeChanger <>4__this;
        public System.Collections.Generic.IReadOnlyList<PRISM.Live.IIdol> idols;
        public bool isCostumeUnlimited;
        public System.Func<int, PRISM.Domain.CostumeSetData> <>9__6;
        private PRISM.Domain.CostumeSetData <ChangeLiveIdolCostume>b__6(int x);
        private bool <ChangeLiveIdolCostume>b__2(PRISM.Definitions.MstCostumeSet x);
        private PRISM.Domain.CostumeSetData <ChangeLiveIdolCostume>b__3(PRISM.Definitions.MstCostumeSet x);
        private void <ChangeLiveIdolCostume>g__ChangeCostumeRandom|0(CostumeType costumeType);
        private PRISM.Module.Networking.IAccessoryStatus <ChangeLiveIdolCostume>g__GetRandomAccessory|1(AccessoryType accessoryType, PRISM.CostumePartMatcher matcher);
    }

    private class <>c__DisplayClass5_1
    {
        public PRISM.Domain.CostumeSetData costumeSet;
        private bool <ChangeLiveIdolCostume>b__7(PRISM.Live.IIdol x);
    }

    private class <>c__DisplayClass5_2
    {
        public PRISM.Live.IIdol idol;
        public <>c__DisplayClass5_0 CS$<>8__locals1;
        private bool <ChangeLiveIdolCostume>b__8(PRISM.Module.Networking.ICostumeStatus x);
    }

    private class <>c__DisplayClass5_3
    {
        public AccessoryType accessoryType;
        private bool <ChangeLiveIdolCostume>b__10(PRISM.Module.Networking.IAccessoryStatus x);
    }
}

// Namespace: PRISM.Service.Live
public class LiveUnitEditUseRecommendedSaveData
{
    private int target;
    private int costume;
    private int memberPriority;
    private int memberPriorityUnitIndex;
    private int supportMemberPriority;
    private int guestPriority;
    public PRISM.Live.LiveUnitRecommendTarget Target { get; set; }
    public PRISM.Live.LiveUnitRecommendCostume Costume { get; set; }
    public PRISM.Live.LiveUnitRecommendMemberPriority MemberPriority { get; set; }
    public int MemberPriorityUnitIndex { get; set; }
    public PRISM.Live.LiveUnitRecommendSupportMemberPriority SupportMemberPriority { get; set; }
    public PRISM.Live.LiveUnitRecommendGuestPriority GuestPriority { get; set; }
}

// Namespace: PRISM.Service.Live
public class LiveUnitMemberChangeSaveData
{
    private int selectedStatusDisplayType;
    private string sortFilterSettings;
    public int SelectedStatusDisplayType { get; set; }
    public PRISM.Definitions.SortFilterSettings SortFilterSettings { get; set; }
}

// Namespace: PRISM.Service.Live
public class LiveUnitRecommendCalculator
{
    private PRISM.Live.LiveUnitRecommendConfig config;
    private PRISM.Definitions.MasterData masterData;
    public PRISM.Live.LiveIdol[] GetProduceIdols(PRISM.Live.MusicData musicData, System.Collections.Generic.IEnumerable<PRISM.Live.LiveIdol> allLiveIdols);
    private static T _getBestCenter<T>(PRISM.Live.LiveIdol[] members, System.Collections.Generic.IEnumerable<T> centerCandidates, System.Func<T, PRISM.Definitions.MstProduceIdol> masterGetter);
    public System.Collections.Generic.Dictionary<LiveUnitSupportMemberType, PRISM.Module.Networking.ISupportCharacterStatus> GetSupportCharacters(PRISM.Live.LiveIdol[] members, System.Collections.Generic.IEnumerable<PRISM.Module.Networking.ISupportCharacterStatus> allSupportCharacters);
    public PRISM.Module.Networking.ILiveGuestProfileStatus GetGuest(PRISM.Live.LiveIdol[] members, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.ILiveGuestProfileStatus> guestList);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Live.LiveIdol, int> <>9__3_1;
        public static System.Func<System.Linq.IGrouping<int, PRISM.Live.LiveIdol>, PRISM.Live.LiveIdol> <>9__3_2;
        public static System.Func<PRISM.Live.LiveIdol, int> <>9__3_11;
        public static System.Func<PRISM.Live.LiveIdol, bool> <>9__3_13;
        public static System.Func<PRISM.Live.LiveIdol, int> <>9__5_0;
        public static System.Func<PRISM.Live.LiveIdol, System.Collections.Generic.IEnumerable<PRISM.Definitions.MstLiveSkillDetail>> <>9__5_1;
        public static System.Func<PRISM.Definitions.MstLiveSkillDetail, int> <>9__5_2;
        public static System.Func<System.Linq.IGrouping<System.ValueTuple<bool, int>, PRISM.Module.Networking.ISupportCharacterStatus>, bool> <>9__5_4;
        public static System.Func<System.Linq.IGrouping<System.ValueTuple<bool, int>, PRISM.Module.Networking.ISupportCharacterStatus>, int> <>9__5_5;
        public static System.Func<PRISM.Module.Networking.ILiveGuestProfileStatus, int> <>9__6_1;
        public static System.Func<System.Linq.IGrouping<int, PRISM.Module.Networking.ILiveGuestProfileStatus>, int> <>9__6_2;
        public static System.Func<PRISM.Module.Networking.ILiveGuestProfileStatus, System.Nullable<System.DateTime>> <>9__6_3;
        private int <GetProduceIdols>b__3_1(PRISM.Live.LiveIdol x);
        private PRISM.Live.LiveIdol <GetProduceIdols>b__3_2(System.Linq.IGrouping<int, PRISM.Live.LiveIdol> x);
        private int <GetProduceIdols>b__3_11(PRISM.Live.LiveIdol x);
        private bool <GetProduceIdols>b__3_13(PRISM.Live.LiveIdol idol);
        private int <GetSupportCharacters>b__5_0(PRISM.Live.LiveIdol x);
        private System.Collections.Generic.IEnumerable<PRISM.Definitions.MstLiveSkillDetail> <GetSupportCharacters>b__5_1(PRISM.Live.LiveIdol x);
        private int <GetSupportCharacters>b__5_2(PRISM.Definitions.MstLiveSkillDetail x);
        private bool <GetSupportCharacters>b__5_4(System.Linq.IGrouping<System.ValueTuple<bool, int>, PRISM.Module.Networking.ISupportCharacterStatus> x);
        private int <GetSupportCharacters>b__5_5(System.Linq.IGrouping<System.ValueTuple<bool, int>, PRISM.Module.Networking.ISupportCharacterStatus> x);
        private int <GetGuest>b__6_1(PRISM.Module.Networking.ILiveGuestProfileStatus x);
        private int <GetGuest>b__6_2(System.Linq.IGrouping<int, PRISM.Module.Networking.ILiveGuestProfileStatus> x);
        private System.Nullable<System.DateTime> <GetGuest>b__6_3(PRISM.Module.Networking.ILiveGuestProfileStatus x);
    }

    private class <>c__4`1<T>
    {
        public static <>c__4<T> <>9;
        public static System.Func<PRISM.Live.LiveIdol, int> <>9__4_1;
        private int <_getBestCenter>b__4_1(PRISM.Live.LiveIdol x);
    }

    private class <>c__DisplayClass3_0
    {
        public PRISM.Live.MusicData musicData;
        public System.Collections.Generic.HashSet<int> originalMembers;
        public PRISM.Live.LiveIdol[] sortedUniqueCharaIdols;
        public PRISM.Live.LiveIdol[] idols;
        public int currentIndex;
        private int <GetProduceIdols>b__0(PRISM.Live.LiveIdol idol);
        private int <GetProduceIdols>b__3(PRISM.Live.LiveIdol idol);
        private void <GetProduceIdols>g__FillRecommended|4();
        private void <GetProduceIdols>g__FillOriginalMembers|5();
        private PRISM.Live.LiveIdol <GetProduceIdols>b__16(int id);
        private bool <GetProduceIdols>b__17(PRISM.Live.LiveIdol x);
        private void <GetProduceIdols>g__Fill|6(System.Collections.Generic.IEnumerable<PRISM.Live.LiveIdol> candidateIdols);
        private void <GetProduceIdols>g__CalculateCenter|7(int searchCount);
    }

    private class <>c__DisplayClass3_1
    {
        public int unitId;
        private bool <GetProduceIdols>b__8(PRISM.Live.LiveIdol idol);
        private bool <GetProduceIdols>b__9(PRISM.Live.LiveIdol idol);
    }

    private class <>c__DisplayClass3_2
    {
        public int targetCharaId;
        private bool <GetProduceIdols>b__10(PRISM.Live.LiveIdol x);
        private bool <GetProduceIdols>b__12(PRISM.Live.LiveIdol x);
    }

    private class <>c__DisplayClass3_3
    {
        public System.Collections.Generic.HashSet<int> candidateMembers;
        private bool <GetProduceIdols>b__14(PRISM.Live.LiveIdol x);
        private bool <GetProduceIdols>b__15(PRISM.Live.LiveIdol x);
    }

    private class <>c__DisplayClass3_4
    {
        public int id;
        private bool <GetProduceIdols>b__18(PRISM.Live.LiveIdol x);
    }

    private class <>c__DisplayClass3_5
    {
        public PRISM.Live.LiveIdol[] parameterTargetIdols;
        private PRISM.Definitions.MstProduceIdol <GetProduceIdols>b__19(int i);
    }

    private class <>c__DisplayClass4_0`1<T>
    {
        public PRISM.Live.LiveIdol[] members;
        public System.Func<T, PRISM.Definitions.MstProduceIdol> masterGetter;
        private int <_getBestCenter>b__0(T center);
    }

    private class <>c__DisplayClass5_0
    {
        public PRISM.Service.Live.LiveUnitRecommendCalculator <>4__this;
        public System.Collections.Generic.HashSet<int> liveSkillIds;
        public System.Collections.Generic.HashSet<int> liveSkillTypes;
        public System.Func<PRISM.Definitions.MstLiveSupportEffectDetail, bool> <>9__6;
        private System.ValueTuple<bool, int> <GetSupportCharacters>b__3(PRISM.Module.Networking.ISupportCharacterStatus x);
        private bool <GetSupportCharacters>b__6(PRISM.Definitions.MstLiveSupportEffectDetail effect);
    }

    private class <>c__DisplayClass5_1
    {
        public System.Collections.Generic.HashSet<int> ids;
        private bool <GetSupportCharacters>b__7(int id);
    }

    private class <>c__DisplayClass6_0
    {
        public PRISM.Live.LiveIdol[] members;
        public PRISM.Service.Live.LiveUnitRecommendCalculator <>4__this;
        private PRISM.Module.Networking.ILiveGuestProfileStatus <GetGuest>g__GetByCenterEffect|0(System.Collections.Generic.IEnumerable<PRISM.Module.Networking.ILiveGuestProfileStatus> list);
        private PRISM.Definitions.MstProduceIdol <GetGuest>b__4(PRISM.Module.Networking.ILiveGuestProfileStatus x);
    }
}

// Namespace: PRISM.Service.Live
public class MusicListSortFilterModel : PRISM.Service.SortFilterModel<PRISM.Live.MusicData>
{
    private static int[] NoFavoriteArray;
    private static System.Collections.Generic.IReadOnlyDictionary<PRISM.Definitions.SortType, PRISM.Service.SortItem<PRISM.Live.MusicData>> _createSortItems(System.Func<SongDifficultyLevel> difficultyGetter);
    private static System.Collections.Generic.IReadOnlyDictionary<PRISM.Definitions.FilterType, PRISM.Service.FilterItem<PRISM.Live.MusicData>> _createFilterItems(System.Func<SongDifficultyLevel> difficultyGetter, System.Collections.Generic.IReadOnlyList<PRISM.Live.FavoriteMusicGroup> favoriteMusicGroups);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Live.MusicData, int> <>9__2_1;
        public static AdditionalSorter<PRISM.Live.MusicData> <>9__2_0;
        public static System.Func<PRISM.Live.MusicData, int> <>9__2_2;
        public static System.Func<PRISM.Live.MusicData, System.DateTime> <>9__2_3;
        public static System.Func<PRISM.Live.MusicData, string> <>9__2_4;
        public static System.Func<PRISM.Live.MusicData, int> <>9__2_6;
        public static System.Func<PRISM.Live.FavoriteMusicGroup, int> <>9__3_7;
        public static System.Func<PRISM.Live.MusicData, int> <>9__3_1;
        public static System.Func<PRISM.Live.MusicData, System.Collections.Generic.ISet<int>, bool> <>9__3_4;
        public static System.Func<PRISM.Live.MusicData, int> <>9__3_5;
        private System.Linq.IOrderedEnumerable<PRISM.Live.MusicData> <_createSortItems>b__2_0(System.Linq.IOrderedEnumerable<PRISM.Live.MusicData> q);
        private int <_createSortItems>b__2_1(PRISM.Live.MusicData x);
        private int <_createSortItems>b__2_2(PRISM.Live.MusicData m);
        private System.DateTime <_createSortItems>b__2_3(PRISM.Live.MusicData m);
        private string <_createSortItems>b__2_4(PRISM.Live.MusicData m);
        private int <_createSortItems>b__2_6(PRISM.Live.MusicData m);
        private int <_createFilterItems>b__3_7(PRISM.Live.FavoriteMusicGroup g);
        private int <_createFilterItems>b__3_1(PRISM.Live.MusicData x);
        private bool <_createFilterItems>b__3_4(PRISM.Live.MusicData x, System.Collections.Generic.ISet<int> onIds);
        private int <_createFilterItems>b__3_5(PRISM.Live.MusicData x);
    }

    private class <>c__DisplayClass2_0
    {
        public System.Func<SongDifficultyLevel> difficultyGetter;
        private int <_createSortItems>b__5(PRISM.Live.MusicData m);
        private int <_createSortItems>b__7(PRISM.Live.MusicData m);
        private int <_createSortItems>b__8(PRISM.Live.MusicData m);
        private int <_createSortItems>b__9(PRISM.Live.MusicData m);
        private float <_createSortItems>b__10(PRISM.Live.MusicData m);
    }

    private class <>c__DisplayClass3_0
    {
        public System.Collections.Generic.IReadOnlyList<PRISM.Live.FavoriteMusicGroup> favoriteMusicGroups;
        public System.Func<SongDifficultyLevel> difficultyGetter;
        private System.Collections.Generic.IEnumerable<int> <_createFilterItems>b__0(PRISM.Live.MusicData x);
        private int <_createFilterItems>b__2(PRISM.Live.MusicData x);
        private int <_createFilterItems>b__3(PRISM.Live.MusicData x);
    }

    private class <>c__DisplayClass3_1
    {
        public PRISM.Live.MusicData x;
        private bool <_createFilterItems>b__6(PRISM.Live.FavoriteMusicGroup g);
    }

    private class <>c__DisplayClass3_2
    {
        public PRISM.Live.MusicData x;
        private bool <_createFilterItems>b__8(int id);
    }
}

// Namespace: PRISM.Service.DressUpRoom
public class DressUpRoomSaveData
{
    private bool saved;
    private int selectedCharacterInfoId;
    private int costumeType;
    private bool isShowUnlockedCostumeOnly;
    public bool Saved { get; set; }
    public int SelectedCharacterInfoId { get; set; }
    public CostumeType CostumeType { get; set; }
    public bool IsShowUnlockedCostumeOnly { get; set; }
    public void Apply(int mstCharacterInfoId);
    public void Apply(CostumeType _costumeType);
    public void Apply(bool unlockOnly);
}

// Namespace: PRISM.Service.Drama.UI
public class DramaSettingsSaveData
{
    private PRISM.Definitions.Drama.UI.DramaScreenOperationType screenOperationType;
    private bool isPauseOnTap;
    private bool needConfirmOnSkip;
    private bool needConfirmOnJump;
    private bool needConfirmUnreadChoice;
    private bool showSubtitleIndicator;
    private bool showSubtitle;
    private PRISM.Definitions.Drama.UI.DramaPlaySpeedType playSpeedType;
    public PRISM.Definitions.Drama.UI.DramaScreenOperationType ScreenOperationType { get; set; }
    public bool IsPauseOnTap { get; set; }
    public bool NeedConfirmOnSkip { get; set; }
    public bool NeedConfirmOnJump { get; set; }
    public bool NeedConfirmUnreadChoice { get; set; }
    public bool ShowSubtitleIndicator { get; set; }
    public bool ShowSubtitle { get; set; }
    public PRISM.Definitions.Drama.UI.DramaPlaySpeedType PlaySpeedType { get; set; }
}

// Namespace: PRISM.Service.PrivacyOption
public class LoggingForPrivacyOptionDecorator : PRISM.Module.PrivacyOption.IAsyncDecorator
{
    public Cysharp.Threading.Tasks.UniTask<PRISM.Module.PrivacyOption.ResponseContext> SendAsync(PRISM.Module.PrivacyOption.RequestContext requestContext, System.Func<PRISM.Module.PrivacyOption.RequestContext, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask<PRISM.Module.PrivacyOption.ResponseContext>> nextAsync, System.Threading.CancellationToken ct);

    private struct <SendAsync>d__0 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<PRISM.Module.PrivacyOption.ResponseContext> <>t__builder;
        public PRISM.Module.PrivacyOption.RequestContext requestContext;
        public System.Func<PRISM.Module.PrivacyOption.RequestContext, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask<PRISM.Module.PrivacyOption.ResponseContext>> nextAsync;
        public System.Threading.CancellationToken ct;
        private Awaiter<PRISM.Module.PrivacyOption.ResponseContext> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Service.PrivacyOption
public class PrivacyOptionCommunicator
{
    private System.TimeSpan timeout;
    private static string consentTypeHeader;
    private static string subUrlTerm;
    private static string subUrlConsentInfos;
    private static string subUrlConsentInfosUserId;
    private string baseUrl;
    private string token;
    public Cysharp.Threading.Tasks.UniTask<PRISM.Service.PrivacyOption.TermUrlResponse> GetTermURLAsync(System.Threading.CancellationToken ct, PRISM.Module.PrivacyOption.IAsyncDecorator[] additionalDecorators);
    public Cysharp.Threading.Tasks.UniTask<bool> PostConsentAsync(PRISM.Service.PrivacyOption.ConsentRequest consent, System.Threading.CancellationToken ct, PRISM.Module.PrivacyOption.IAsyncDecorator[] additionalDecorators);
    public Cysharp.Threading.Tasks.UniTask<System.ValueTuple<bool, PRISM.Service.PrivacyOption.ConsentResponse>> GetConsentAsync(string userId, System.Threading.CancellationToken ct, PRISM.Module.PrivacyOption.IAsyncDecorator[] additionalDecorators);
    public static PRISM.Service.PrivacyOption.PrivacyOptionCommunicator Create();

    private struct <GetConsentAsync>d__9 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<System.ValueTuple<bool, PRISM.Service.PrivacyOption.ConsentResponse>> <>t__builder;
        public PRISM.Service.PrivacyOption.PrivacyOptionCommunicator <>4__this;
        public PRISM.Module.PrivacyOption.IAsyncDecorator[] additionalDecorators;
        public string userId;
        public System.Threading.CancellationToken ct;
        private PRISM.Module.PrivacyOption.UnityWebRequestClient <client>5__2;
        private Awaiter<PRISM.Module.PrivacyOption.ResponseContext> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <GetTermURLAsync>d__7 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<PRISM.Service.PrivacyOption.TermUrlResponse> <>t__builder;
        public PRISM.Service.PrivacyOption.PrivacyOptionCommunicator <>4__this;
        public PRISM.Module.PrivacyOption.IAsyncDecorator[] additionalDecorators;
        public System.Threading.CancellationToken ct;
        private PRISM.Module.PrivacyOption.UnityWebRequestClient <client>5__2;
        private Awaiter<PRISM.Module.PrivacyOption.ResponseContext> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <PostConsentAsync>d__8 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
        public PRISM.Service.PrivacyOption.PrivacyOptionCommunicator <>4__this;
        public PRISM.Module.PrivacyOption.IAsyncDecorator[] additionalDecorators;
        public PRISM.Service.PrivacyOption.ConsentRequest consent;
        public System.Threading.CancellationToken ct;
        private PRISM.Module.PrivacyOption.UnityWebRequestClient <client>5__2;
        private Awaiter<PRISM.Module.PrivacyOption.ResponseContext> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Service.PrivacyOption
public class PrivacyOptionConst
{
    public static string UserNotExistText;
}

// Namespace: PRISM.Service.PrivacyOption
public enum ConsentType : System.Enum
{
    public int value__;
    public static PRISM.Service.PrivacyOption.ConsentType Summary;
    public static PRISM.Service.PrivacyOption.ConsentType Analytics;
    public static PRISM.Service.PrivacyOption.ConsentType Advertisement;
    public static PRISM.Service.PrivacyOption.ConsentType CustomizeAds;
    public static PRISM.Service.PrivacyOption.ConsentType SnsAnalytics;
}

// Namespace: PRISM.Service.PrivacyOption
public class TermUrlResponse
{
    public bool ok;
    public System.Collections.Generic.List<string> errors;
    public System.Collections.Generic.List<Result> results;

    public class Result
    {
        private int id;
        private int consent_type;
        public URL url;

        public class URL
        {
            public string ja;
            public string en;
        }
    }
}

// Namespace: PRISM.Service.PrivacyOption
public class ConsentRequest
{
    public string user_id;
    public System.Collections.Generic.List<string> errors;
    public System.Collections.Generic.List<Detail> details;
    public bool IsConsent(PRISM.Service.PrivacyOption.ConsentType type);

    public class Detail
    {
        public int consent_type;
        public int consent_flg;
    }

    private class <>c__DisplayClass5_0
    {
        public PRISM.Service.PrivacyOption.ConsentType type;
        private bool <IsConsent>b__0(Detail x);
    }
}

// Namespace: PRISM.Service.PrivacyOption
public class ConsentResponse
{
    public bool ok;
    public System.Collections.Generic.List<string> errors;
    public Result results;
    public bool IsAllConsentsResponded();
    public bool IsConsent(PRISM.Service.PrivacyOption.ConsentType type);

    public class Result
    {
        public int user_id;
        public System.Collections.Generic.List<Detail> details;

        public class Detail
        {
            public int consent_type;
            public int consent_flg;
        }
    }

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<Detail, int> <>9__4_0;
        private int <IsAllConsentsResponded>b__4_0(Detail x);
    }

    private class <>c__DisplayClass5_0
    {
        public PRISM.Service.PrivacyOption.ConsentType type;
        private bool <IsConsent>b__0(Detail x);
    }
}

// Namespace: PRISM.Service.Character
public class CharacterBaseSelectPermanentData
{
    private int unitId;
    public int UnitId { get; set; }
    public bool Apply(int _unitId);
}

// Namespace: PRISM.Service.Character
public class CharacterSelectPIPermanentData
{
    private int selectedDisplayModeIndex;
    private string sortFilterSettings;
    public int SelectedDisplayModeIndex { get; set; }
    public PRISM.Definitions.SortFilterSettings SortFilterSettings { get; set; }
}

// Namespace: PRISM.Service.Character
public class CharacterSelectSCPermanentData
{
    private int selectedDisplayModeIndex;
    private string sortFilterSettings;
    public int SelectedDisplayModeIndex { get; set; }
    public PRISM.Definitions.SortFilterSettings SortFilterSettings { get; set; }
}

// Namespace: PRISM.Service.Character
public class CharacterSelectSCUpgradingFilterPermanentData
{
    private bool canMasterTraining;
    private bool canTraining;
    public bool CanMasterTraining { get; set; }
    public bool CanTraining { get; set; }
    public bool Apply(bool canMasterTraining, bool canTraining);
}

// Namespace: PRISM.Service.Character
public class CharacterSessionData
{
    public UniRx.ReactiveProperty<PRISM.UI.BitProduceIdolUpgradingFilterType> ProduceIdolUpgradingFilter;
    public UniRx.ReactiveProperty<PRISM.UI.BitSupportCharaUpgradingFilterType> SupportCharaUpgradingFilter;
}

// Namespace: PRISM.Service.Character
public class IdolBaseDetailPermanentData
{
    private int tabIndex;
    public int TabIndex { get; set; }
    public bool Apply(int index);
}

// Namespace: PRISM.Service.Character
public class IdolListFUSortFilterPermanentData
{
    private int selectedUnitId;
    private string sortFilterSettings;
    public int SelectedUnitId { get; set; }
    public PRISM.Definitions.SortFilterSettings SortFilterSettings { get; set; }
}

// Namespace: PRISM.Service.Character
public class IdolListPermanentData
{
    private int tabIndex;
    public int TabIndex { get; set; }
    public bool Apply(int index);
}

// Namespace: PRISM.Service.Character
public class IdolListPISortFilterPermanentData
{
    private int selectedDisplayModeIndex;
    private string sortFilterSettings;
    public int SelectedDisplayModeIndex { get; set; }
    public PRISM.Definitions.SortFilterSettings SortFilterSettings { get; set; }
}

// Namespace: PRISM.Service.Character
public class IdolListSCSortFilterPermanentData
{
    private int selectedDisplayModeIndex;
    private string sortFilterSettings;
    public int SelectedDisplayModeIndex { get; set; }
    public PRISM.Definitions.SortFilterSettings SortFilterSettings { get; set; }
}

// Namespace: PRISM.Service.AppReview
public class AppReviewManager
{
    public Cysharp.Threading.Tasks.UniTask RequestReviewAsync(System.Threading.CancellationToken ct);

    private struct <RequestReviewAsync>d__0 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Service.AppReview
public class AppReviewSaveData
{
    private long displayTime;
    public System.DateTime DisplayTime { get; set; }
}

// Namespace: PRISM.Service.ADV
public class ADVLogActionData : PRISM.Service.ADV.IADVLogNodeData
{
    private string <Content>k__BackingField;
    public string Content { get; set; }
    public string ClassName { get; set; }
}

// Namespace: PRISM.Service.ADV
public class ADVLogModel
{
    private PRISM.Scenario.ScenarioId <ScenarioId>k__BackingField;
    private string <Title>k__BackingField;
    private System.Collections.Generic.List<PRISM.Service.ADV.IADVLogNodeData> <ContentList>k__BackingField;
    private PRISM.Definitions.MasterData <MasterData>k__BackingField;
    public PRISM.Scenario.ScenarioId ScenarioId { get; set; }
    public string Title { get; set; }
    public System.Collections.Generic.List<PRISM.Service.ADV.IADVLogNodeData> ContentList { get; set; }
    public PRISM.Definitions.MasterData MasterData { get; set; }
}

// Namespace: PRISM.Service.ADV
public class ADVLogTalkData : PRISM.Service.ADV.IADVLogNodeData
{
    private string <CharaId>k__BackingField;
    private string <SpeakerName>k__BackingField;
    private string <Content>k__BackingField;
    private string <VoiceId>k__BackingField;
    private bool <IsChoice>k__BackingField;
    public string CharaId { get; set; }
    public string SpeakerName { get; set; }
    public string Content { get; set; }
    public string VoiceId { get; set; }
    public bool IncludeVoice { get; set; }
    public bool IsChoice { get; set; }
    public string ClassName { get; set; }
}

// Namespace: PRISM.Service.ADV
public interface IADVLogNodeData
{
    public string ClassName { get; set; }
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=16 099AB87D2B7D3B5134F23826F70D8C7378F2857F139C14815ED42ECFB87BD075;
    private static __StaticArrayInitTypeSize=11066 68A031F08E20B3E337E016BF02D5C739916DC3E4B7819ABC53D0F0A5A22E079A;
    private static __StaticArrayInitTypeSize=16 68DB723EF00BE4CE1E535CCDC9AE683EBA4DE39802688AD415E80DF37B43CB16;
    private static __StaticArrayInitTypeSize=16 6C98AD18A18E0E2C2D77D3204894466EDC0B64E0FF5FCF1A1C4240B0255F82C0;
    private static __StaticArrayInitTypeSize=44 73A34026F3B48F0EF4C4B3506D501180970D31FF4FFC03E02B9F1B95022C4831;
    private static __StaticArrayInitTypeSize=7038 7D7FD16C312297A4A3FA024753135078C40A5885CC832B108730D42F14ABD139;
    private static __StaticArrayInitTypeSize=44 7DE3C63E518818BDEC6F3540E0A98247CF98D12FF04D4895754EAB71148610E7;
    private static __StaticArrayInitTypeSize=44 A7256E3A46EBC55CC6BC9E036E6C6FFE404C94068462DFF90BFF2EFAEADB959B;
    private static __StaticArrayInitTypeSize=12 B6599D21CE74F24FA42D57991D6B0D0C5770322C90AF734EEB36A37F74090137;
    private static __StaticArrayInitTypeSize=44 F47362215AD061FD681C0EA9D3A9E2C1FFDB94395F10477DFE1B6D84D9D6E226;

    private struct __StaticArrayInitTypeSize=12 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=16 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=44 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=7038 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=11066 : System.ValueType
    {
    }
}
