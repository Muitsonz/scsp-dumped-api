
private class <Module>
{
}

// Namespace: Microsoft.CodeAnalysis
private class EmbeddedAttribute : System.Attribute
{
}

// Namespace: System.Runtime.CompilerServices
private class IsUnmanagedAttribute : System.Attribute
{
}

// Namespace: System.Runtime.CompilerServices
private class NullableAttribute : System.Attribute
{
    public byte[] NullableFlags;
}

// Namespace: System.Runtime.CompilerServices
private class NullableContextAttribute : System.Attribute
{
    public byte Flag;
}

public class DisposableExtensions
{
    public static T AddTo<T>(T disposable, System.Threading.CancellationToken cancellationToken);
}

public class Debug
{
    public static UnityEngine.ILogger unityLogger;
    public static void Log(object message);
    public static void Log(object message, UnityEngine.Object context);
    public static void LogFormat(string format, object[] args);
    public static void LogFormat(UnityEngine.Object context, string format, object[] args);
    public static void LogFormat(UnityEngine.LogType logType, UnityEngine.LogOption logOptions, UnityEngine.Object context, string format, object[] args);
    public static void LogError(object message);
    public static void LogError(object message, UnityEngine.Object context);
    public static void LogErrorFormat(string format, object[] args);
    public static void LogErrorFormat(UnityEngine.Object context, string format, object[] args);
    public static void LogException(System.Exception exception);
    public static void LogException(System.Exception exception, UnityEngine.Object context);
    public static void LogWarning(object message);
    public static void LogWarning(object message, UnityEngine.Object context);
    public static void LogWarningFormat(string format, object[] args);
    public static void LogWarningFormat(UnityEngine.Object context, string format, object[] args);
    public static void Assert(bool condition);
    public static void Assert(bool condition, UnityEngine.Object context);
    public static void Assert(bool condition, object message);
    public static void Assert(bool condition, string message);
    public static void Assert(bool condition, object message, UnityEngine.Object context);
    public static void Assert(bool condition, string message, UnityEngine.Object context);
    public static void AssertFormat(bool condition, string format, object[] args);
    public static void AssertFormat(bool condition, UnityEngine.Object context, string format, object[] args);
    public static void LogAssertion(object message);
    public static void LogAssertion(object message, UnityEngine.Object context);
    public static void LogAssertionFormat(string format, object[] args);
    public static void LogAssertionFormat(UnityEngine.Object context, string format, object[] args);
    public static void Assert(bool condition, string format, object[] args);
    public static void DrawLine(UnityEngine.Vector3 start, UnityEngine.Vector3 end, UnityEngine.Color color, float duration);
    public static void DrawLine(UnityEngine.Vector3 start, UnityEngine.Vector3 end, UnityEngine.Color color);
    public static void DrawLine(UnityEngine.Vector3 start, UnityEngine.Vector3 end);
    public static void DrawLine(UnityEngine.Vector3 start, UnityEngine.Vector3 end, UnityEngine.Color color, float duration, bool depthTest);

    private class SilentLogHandler : UnityEngine.ILogHandler
    {
        public void LogFormat(UnityEngine.LogType logType, UnityEngine.Object context, string format, object[] args);
        public void LogException(System.Exception exception, UnityEngine.Object context);
    }

    private class SilentLogger : UnityEngine.ILogger, UnityEngine.ILogHandler
    {
        private UnityEngine.ILogHandler <logHandler>k__BackingField;
        private bool <logEnabled>k__BackingField;
        private UnityEngine.LogType <filterLogType>k__BackingField;
        public UnityEngine.ILogHandler logHandler { get; set; }
        public bool logEnabled { get; set; }
        public UnityEngine.LogType filterLogType { get; set; }
        public void LogFormat(UnityEngine.LogType logType, UnityEngine.Object context, string format, object[] args);
        public void LogException(System.Exception exception, UnityEngine.Object context);
        public bool IsLogTypeAllowed(UnityEngine.LogType logType);
        public void Log(UnityEngine.LogType logType, object message);
        public void Log(UnityEngine.LogType logType, object message, UnityEngine.Object context);
        public void Log(UnityEngine.LogType logType, string tag, object message);
        public void Log(UnityEngine.LogType logType, string tag, object message, UnityEngine.Object context);
        public void Log(object message);
        public void Log(string tag, object message);
        public void Log(string tag, object message, UnityEngine.Object context);
        public void LogWarning(string tag, object message);
        public void LogWarning(string tag, object message, UnityEngine.Object context);
        public void LogError(string tag, object message);
        public void LogError(string tag, object message, UnityEngine.Object context);
        public void LogFormat(UnityEngine.LogType logType, string format, object[] args);
        public void LogException(System.Exception exception);
    }
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

// Namespace: System.Runtime.CompilerServices
public class IsExternalInit
{
}

// Namespace: System.Runtime.CompilerServices
public class RequiredMemberAttribute : System.Attribute
{
}

// Namespace: System.Runtime.CompilerServices
public class CompilerFeatureRequiredAttribute : System.Attribute
{
    private string <FeatureName>k__BackingField;
    private bool <IsOptional>k__BackingField;
    public static string RefStructs;
    public static string RequiredMembers;
    public string FeatureName { get; set; }
    public bool IsOptional { get; set; }
}

// Namespace: PRISM
public struct AnimatorHashIDs : System.ValueType
{
    public static int ResultOn;
    public static int ResultSkip;
    public static int TipsOn;
    public static int AppealOn;
    public static int start;
    public static int skill_on;
    public static int skill_off;
    public static int SpaceKeepOff;
    public static int Draw;
    public static int UseOn;
    public static int UseOff;
    public static int R;
    public static int SR;
    public static int SSR;
    public static int rare;
    public static int ShakeOff;
    public static int rate_up;
    public static int rate_stay;
    public static int rate_up_loop;
    public static int rate_stay_loop;
    public static int on;
    public static int none;
    public static int loop;
    public static int stamp;
    public static int star;
    public static int idle;
    public static int player_to_player;
    public static int player_to_enemy;
    public static int FanAreaOn;
    public static int ParameterAreaOn;
    public static int SlideOn;
    public static int count_up;
    public static int exclusion;
    public static int CounterEffectOn;
    public static int AnimStart;
    public static int AnimStart2;
    public static int resultValue;
    public static int CountTrigger;
    public static int CountNum;
    public static int other;
    public static int Start;
    public static int CutInType;
    public static int Reload;
    public static int ReloadEnd;
    public static int Mouth_A;
    public static int Mouth_I;
    public static int Mouth_U;
    public static int Mouth_E;
    public static int Mouth_O;
    public static int Mouth_SA;
    public static int Mouth_SI;
    public static int Mouth_SE;
    public static int MouthSerious;
    public static int MouthSurprise;
    public static int MouthShy;
    public static int MouthAnger;
    public static int EyeLClose;
    public static int EyeRClose;
    public static int EyeLSmile;
    public static int EyeRSmile;
    public static int EyeBrowSerious;
    public static int EyeBrowSad;
    public static int EyeBrowUnique;
    public static int EyeBrowUp;
    public static int EyeBrowDown;
    public static int LipSyncRate;
    public static int NoseDelete;
    public static int Mouth_Tongue;
    public static int FaceCustom;
    public static int BuffDebuffSimpleBar_Alpha_Initialize;
    public static int BuffDebuffSimpleBar_Alpha_ForceFadeout;
    public static int BuffDebuffSimpleBar_Position_InitializeSelf;
    public static int BuffDebuffSimpleBar_Position_InitializeOpponent;
    public static int Scroll;
    public static int Init;
    public static int Idle;
    public static int FadeIn;
    public static int FadeInLeft;
    public static int FadeInRight;
    public static int FadeOut;
    public static int FadeOutLeft;
    public static int FadeOutRight;
    public static int Select;
    public static int Deselect;
    public static int finish_reload;
    public static string MobileCallBtn_Twesta;
    public static string MobileCallBtn_Chain;
    public static string MobileCallBtn_Call;
    public static int next;
    public static int complete;
    public static int IdleStamp;
    public static int IdleNext;
    public static int Default;
    public static int StartRotation;
    public static int StartNext;
    public static int TransitionIn;
    public static int TransitionOut;
    public static int Long;
    public static int Short;
    public static int First;
}

// Namespace: PRISM
public class EnumerableExtensions
{
    public static TSource MaxBy<TSource, TKey>(System.Collections.Generic.IEnumerable<TSource> self, System.Func<TSource, TKey> keySelector);
    public static TSource MinBy<TSource, TKey>(System.Collections.Generic.IEnumerable<TSource> self, System.Func<TSource, TKey> keySelector);
    private static TSource MinOrMaxBy<TSource, TKey>(System.Collections.Generic.IEnumerable<TSource> self, System.Func<TSource, TKey> keySelector, int sign);
    public static T Max<T>(System.Collections.Generic.IEnumerable<T> self, System.Collections.Generic.IComparer<T> comparer);
    public static T Min<T>(System.Collections.Generic.IEnumerable<T> self, System.Collections.Generic.IComparer<T> comparer);
    private static T _minOrMax<T>(System.Collections.Generic.IEnumerable<T> self, System.Collections.Generic.IComparer<T> comparer, int sign);
    public static void ZipExecute<T, U>(System.Collections.Generic.IEnumerable<T> first, System.Collections.Generic.IEnumerable<U> second, System.Action<T, U> action);
    public static System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<T>> Chunk<T>(System.Collections.Generic.IEnumerable<T> source, int chunkSize);
    public static System.Collections.Generic.IEnumerable<T> DistinctBy<T, TKey>(System.Collections.Generic.IEnumerable<T> source, System.Func<T, TKey> selector);
    public static int CountDistinctBy<T, TKey>(System.Collections.Generic.IEnumerable<T> source, System.Func<T, TKey> selector);
    public static System.Collections.Generic.IEnumerable<T> WhereNotNull<T>(System.Collections.Generic.IEnumerable<T> source);

    private class <>c__7`1<T>
    {
        public static <>c__7<T> <>9;
        public static System.Func<T, int, System.ValueTuple<T, int>> <>9__7_0;
        public static System.Func<System.ValueTuple<T, int>, T> <>9__7_2;
        private System.ValueTuple<T, int> <Chunk>b__7_0(T item, int index);
        private T <Chunk>b__7_2(System.ValueTuple<T, int> x);
    }

    private class <>c__DisplayClass7_0`1<T>
    {
        public int chunkSize;
        private int <Chunk>b__1(System.ValueTuple<T, int> x);
    }

    private class <DistinctBy>d__8`2<T, TKey> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
    {
        private int <>1__state;
        private T <>2__current;
        private int <>l__initialThreadId;
        private System.Collections.Generic.IEnumerable<T> source;
        public System.Collections.Generic.IEnumerable<T> <>3__source;
        private System.Func<T, TKey> selector;
        public System.Func<T, TKey> <>3__selector;
        private System.Collections.Generic.HashSet<TKey> <hashSet>5__2;
        private System.Collections.Generic.IEnumerator<T> <>7__wrap2;
        private T System.Collections.Generic.IEnumerator<T>.Current { get; set; }
        private object System.Collections.IEnumerator.Current { get; set; }
        private void System.IDisposable.Dispose();
        private bool MoveNext();
        private void <>m__Finally1();
        private void System.Collections.IEnumerator.Reset();
        private System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
    }
}

// Namespace: PRISM
public class ListExtensions
{
    public static T RandomOrDefault<T>(System.Collections.Generic.IList<T> self);
    public static void Shuffle<T>(System.Collections.Generic.IList<T> self);
    public static int FindIndex<T>(System.Collections.Generic.IList<T> self, System.Predicate<T> match, int startIndex);
    public static bool IsNullOrEmpty<T>(System.Collections.Generic.IList<T> list);
    public static bool TryGetValue<T>(System.Collections.Generic.IList<T> array, int index, T& result);
    public static System.Span<T> AsSpan<T>(System.Collections.Generic.List<T> list);
    public static void Deconstruct<T>(System.Collections.Generic.IList<T> list, T& value0, T& value1);

    private class ListDummy`1<T>
    {
        public T[] Items;
    }
}

// Namespace: PRISM
public class ReadOnlyListExtensions
{
    public static bool ListAny<TSource, TState>(System.Collections.Generic.IReadOnlyList<TSource> source, TState state, System.Func<TSource, TState, bool> predicate);
    public static bool ListAll<TSource, TState>(System.Collections.Generic.IReadOnlyList<TSource> source, TState state, System.Func<TSource, TState, bool> predicate);
    public static TSource ListFirst<TSource, TState>(System.Collections.Generic.IReadOnlyList<TSource> source, TState state, System.Func<TSource, TState, bool> predicate);
    public static TSource ListFirstOrDefault<TSource, TState>(System.Collections.Generic.IReadOnlyList<TSource> source, TState state, System.Func<TSource, TState, bool> predicate);
    public static int ListFindIndex<TSource, TState>(System.Collections.Generic.IReadOnlyList<TSource> source, TState state, System.Func<TSource, TState, bool> predicate);
    public static int ListCount<TSource, TState>(System.Collections.Generic.IReadOnlyList<TSource> source, TState state, System.Func<TSource, TState, bool> predicate);
    public static int ListSum<TSource, TState>(System.Collections.Generic.IReadOnlyList<TSource> source, TState state, System.Func<TSource, TState, int> selector);
    public static long ListSum<TSource, TState>(System.Collections.Generic.IReadOnlyList<TSource> source, TState state, System.Func<TSource, TState, long> selector);
    public static float ListSum<TSource, TState>(System.Collections.Generic.IReadOnlyList<TSource> source, TState state, System.Func<TSource, TState, float> selector);
    public static double ListSum<TSource, TState>(System.Collections.Generic.IReadOnlyList<TSource> source, TState state, System.Func<TSource, TState, double> selector);
    public static int ListMin<TSource, TState>(System.Collections.Generic.IReadOnlyList<TSource> source, TState state, System.Func<TSource, TState, int> selector);
    public static long ListMin<TSource, TState>(System.Collections.Generic.IReadOnlyList<TSource> source, TState state, System.Func<TSource, TState, long> selector);
    public static float ListMin<TSource, TState>(System.Collections.Generic.IReadOnlyList<TSource> source, TState state, System.Func<TSource, TState, float> selector);
    public static double ListMin<TSource, TState>(System.Collections.Generic.IReadOnlyList<TSource> source, TState state, System.Func<TSource, TState, double> selector);
    public static int ListMax<TSource, TState>(System.Collections.Generic.IReadOnlyList<TSource> source, TState state, System.Func<TSource, TState, int> selector);
    public static long ListMax<TSource, TState>(System.Collections.Generic.IReadOnlyList<TSource> source, TState state, System.Func<TSource, TState, long> selector);
    public static float ListMax<TSource, TState>(System.Collections.Generic.IReadOnlyList<TSource> source, TState state, System.Func<TSource, TState, float> selector);
    public static double ListMax<TSource, TState>(System.Collections.Generic.IReadOnlyList<TSource> source, TState state, System.Func<TSource, TState, double> selector);
    public static System.Collections.Generic.IList<T> ToIList<T>(System.Collections.Generic.IReadOnlyList<T> source);
}

// Namespace: PRISM
public class SpanExtensions
{
    public static void SpanShakerSort(System.Span<int>& list, int size);
}

// Namespace: PRISM
public class PRISMLogger
{
    public static PRISM.Definitions.Logger.CategorizedLogger UnityLog;
    public static PRISM.Definitions.Logger.CategorizedLogger SaveData;
    public static PRISM.Definitions.Logger.CategorizedLogger ResourceLoader;
    public static PRISM.Definitions.Logger.CategorizedLogger DebugLogViewer;
    public static PRISM.Definitions.Logger.CategorizedLogger Asset;
    public static PRISM.Definitions.Logger.CategorizedLogger Time;
    public static PRISM.Definitions.Logger.CategorizedLogger AppTrackingTransparency;
    public static PRISM.Definitions.Logger.CategorizedLogger InputBlock;
    public static PRISM.Definitions.Logger.CategorizedLogger Gleipnir;
    public static PRISM.Definitions.Logger.CategorizedLogger Limelight;
    public static PRISM.Definitions.Logger.CategorizedLogger Boot;
    public static PRISM.Definitions.Logger.CategorizedLogger NetworkError;
    public static PRISM.Definitions.Logger.CategorizedLogger Tutorial;
    public static PRISM.Definitions.Logger.CategorizedLogger Render3D;
    public static PRISM.Definitions.Logger.CategorizedLogger Live;
    public static PRISM.Definitions.Logger.CategorizedLogger Character;
    public static PRISM.Definitions.Logger.CategorizedLogger Gasha;
    public static PRISM.Definitions.Logger.CategorizedLogger Shop;
    public static PRISM.Definitions.Logger.CategorizedLogger Mobile;
    public static PRISM.Definitions.Logger.CategorizedLogger Streaming;
    public static PRISM.Definitions.Logger.CategorizedLogger Adjust;
    public static PRISM.Definitions.Logger.CategorizedLogger Produce;
    public static PRISM.Definitions.Logger.CategorizedLogger SoundManager;
    public static PRISM.Definitions.Logger.CategorizedLogger Networking;
    public static PRISM.Definitions.Logger.CategorizedLogger ADV;
    public static PRISM.Definitions.Logger.CategorizedLogger Notification;
    public static PRISM.Definitions.Logger.CategorizedLogger PrivacyOption;
    public static PRISM.Definitions.Logger.CategorizedLogger AppReview;
    public static PRISM.Definitions.Logger.CategorizedLogger Analytics;
    public static PRISM.Definitions.Logger.CategorizedLogger Crachlytics;
    public static PRISM.Definitions.Logger.CategorizedLogger Photo;
    public static PRISM.Definitions.Logger.CategorizedLogger Scenario;
    public static PRISM.Definitions.Logger.CategorizedLogger Story;
    public static PRISM.Definitions.Logger.CategorizedLogger Drama;
}

// Namespace: PRISM.Interactions
public enum MusicRateRewardListCellType : System.Enum
{
    public int value__;
    public static PRISM.Interactions.MusicRateRewardListCellType Default;
    public static PRISM.Interactions.MusicRateRewardListCellType UnlockShiny;
    public static PRISM.Interactions.MusicRateRewardListCellType PostUnlockShiny;
    public static PRISM.Interactions.MusicRateRewardListCellType UnlockMaster;
}

// Namespace: PRISM.Interactions
public enum MusicRateRewardListAcquiredType : System.Enum
{
    public int value__;
    public static PRISM.Interactions.MusicRateRewardListAcquiredType NotAcquired;
    public static PRISM.Interactions.MusicRateRewardListAcquiredType Next;
    public static PRISM.Interactions.MusicRateRewardListAcquiredType Acquired;
}

// Namespace: PRISM.Definitions
public class CommonAssetKeyConst
{
    public static string SeOutGameCueSheet;
}

// Namespace: PRISM.Definitions
public class CharacterConst
{
    public static int FesUnitLimit;
    public static int FesUnitTransferLimit;
    public static int MaxPieceSelectedNum;
    public static int PieceChangeRate;
    public static System.Collections.Generic.Dictionary<int, int> SupportEffectFilterSchedule;
    public static System.Collections.Generic.Dictionary<int, System.Collections.Generic.HashSet<int>> SupportEffectFilterScheduleDetail;
    public static System.Collections.Generic.HashSet<int> ProducePassiveEffectTypeIdNotRefersToSchedule;
    public static System.Collections.Generic.HashSet<int> ProducePassiveEffectTypeIdRefersToScheduleDetail;
    public static System.Collections.Generic.HashSet<int> ProducePassiveEffectTypeIdRefersToSchedule;
    public static int SupportEffectFilterScheduleMinId;
    public static int RequiredItemsNumByGroup;
    public static float FUnitLabelBlinkDuration;
    public static int ManoCharacterId;
    public static int Hazuki;
    public static int ProducerCharacterId;
    public static int PresidentCharacterId;
    public static string HazukiBirthdayCueName;
    public static int MaxDigits5;
    public static int DressOrderItemsNumByGroup;
    public static int DressOrderTicketAcquisitionStar;
    public static int DressOrderTicketProductId;
    public static int[] SlotBySupportCharaDiamondLv;
    public static string IdolSkillLvIconTagText;
    public static string IdolSkillLvMaxIconTagText;
    public static int NotebookMstId;
}

// Namespace: PRISM.Definitions
public struct IdolParameter : System.ValueType, System.IEquatable<PRISM.Definitions.IdolParameter>
{
    private int <Vocal>k__BackingField;
    private int <Dance>k__BackingField;
    private int <Visual>k__BackingField;
    private int <Mental>k__BackingField;
    public int Vocal { get; set; }
    public int Dance { get; set; }
    public int Visual { get; set; }
    public int Mental { get; set; }
    public int Total { get; set; }
    public static PRISM.Definitions.IdolParameter op_Addition(PRISM.Definitions.IdolParameter& a, PRISM.Definitions.IdolParameter& b);
    public static PRISM.Definitions.IdolParameter op_Subtraction(PRISM.Definitions.IdolParameter& a, PRISM.Definitions.IdolParameter& b);
    public static PRISM.Definitions.IdolParameter op_Multiply(PRISM.Definitions.IdolParameter& a, int b);
    public static PRISM.Definitions.IdolParameter op_Division(PRISM.Definitions.IdolParameter& a, int b);
    public string ToString();
    private bool PrintMembers(System.Text.StringBuilder builder);
    public static bool op_Inequality(PRISM.Definitions.IdolParameter left, PRISM.Definitions.IdolParameter right);
    public static bool op_Equality(PRISM.Definitions.IdolParameter left, PRISM.Definitions.IdolParameter right);
    public int GetHashCode();
    public bool Equals(object obj);
    public bool Equals(PRISM.Definitions.IdolParameter other);
    public void Deconstruct(int& Vocal, int& Dance, int& Visual, int& Mental);
}

// Namespace: PRISM.Definitions
public class FrameRateConstants
{
    public static int Shared;
    public static int WhenPaused;
    public static int LiveHigh;
    public static int ProduceIngame;
    public static int DefaultRenderFPS;
    public static int PowerSavingRenderFPS;
}

// Namespace: PRISM.Definitions
public enum HelpListCellType : System.Enum
{
    public int value__;
    public static PRISM.Definitions.HelpListCellType Large;
    public static PRISM.Definitions.HelpListCellType Small;
}

// Namespace: PRISM.Definitions
public enum IdolStatusType : System.Enum
{
    public int value__;
    public static PRISM.Definitions.IdolStatusType Vocal;
    public static PRISM.Definitions.IdolStatusType Dance;
    public static PRISM.Definitions.IdolStatusType Visual;
    public static PRISM.Definitions.IdolStatusType Mental;
}

// Namespace: PRISM.Definitions
public class PhysicsConst
{
    public static int DefaultSimulationFrequency;
    public static int DefaultSimulationCount;
    public static int HighSimulationFrequency;
    public static int HighSimulationCount;
}

// Namespace: PRISM.Definitions
public class PopupButtonText
{
    public static PRISM.Definitions.LocalizationKey Ok;
    public static PRISM.Definitions.LocalizationKey Close;
    public static PRISM.Definitions.LocalizationKey Cancel;
    public static PRISM.Definitions.LocalizationKey No;
    public static PRISM.Definitions.LocalizationKey Yes;
    public static PRISM.Definitions.LocalizationKey Decide;
}

// Namespace: PRISM.Definitions
public class PopupEnum
{

    public enum PopupSizeType : System.Enum
    {
        public int value__;
        public static PopupSizeType Small;
        public static PopupSizeType Middle;
        public static PopupSizeType Large;
        public static PopupSizeType ExtraLarge;
        public static PopupSizeType Square;
        public static PopupSizeType Tall;
        public static PopupSizeType ExpandVertical;
    }

    public enum PopupButtonType : System.Enum
    {
        public int value__;
        public static PopupButtonType Normal;
        public static PopupButtonType Positive;
        public static PopupButtonType Warning;
        public static PopupButtonType Function;
        public static PopupButtonType Purchase;
    }
}

// Namespace: PRISM.Definitions
public enum FilterType : System.Enum
{
    public int value__;
    public static PRISM.Definitions.FilterType FavoriteMark;
    public static PRISM.Definitions.FilterType Attribute;
    public static PRISM.Definitions.FilterType LiveSkill;
    public static PRISM.Definitions.FilterType LiveCenterEffect;
    public static PRISM.Definitions.FilterType LiveCenterEffectCondition;
    public static PRISM.Definitions.FilterType VocalSeparatedCharacter;
    public static PRISM.Definitions.FilterType Character;
    public static PRISM.Definitions.FilterType MissionAchieve;
    public static PRISM.Definitions.FilterType MissionCategory;
    public static PRISM.Definitions.FilterType SeasonMissionCategory;
    public static PRISM.Definitions.FilterType MissionReward;
    public static PRISM.Definitions.FilterType ReadOrUnread;
    public static PRISM.Definitions.FilterType StoryType;
    public static PRISM.Definitions.FilterType Achievement;
    public static PRISM.Definitions.FilterType MusicFavorite;
    public static PRISM.Definitions.FilterType MusicAttribute;
    public static PRISM.Definitions.FilterType ScoreRank;
    public static PRISM.Definitions.FilterType LiveClearInfo;
    public static PRISM.Definitions.FilterType MusicBackgroundMode;
    public static PRISM.Definitions.FilterType RecordVersion;
    public static PRISM.Definitions.FilterType LiveSupportEffect;
    public static PRISM.Definitions.FilterType LiveSupportEffectCondition;
    public static PRISM.Definitions.FilterType SupportCharacterRarity;
    public static PRISM.Definitions.FilterType MasterTraining;
    public static PRISM.Definitions.FilterType GoodSchedule;
    public static PRISM.Definitions.FilterType PotentialSupportSkill;
    public static PRISM.Definitions.FilterType SupportEffectTitle;
    public static PRISM.Definitions.FilterType SupportEffect1;
    public static PRISM.Definitions.FilterType SupportEffect2;
    public static PRISM.Definitions.FilterType Event;
    public static PRISM.Definitions.FilterType PIdolStar;
    public static PRISM.Definitions.FilterType PIdolInitialStar;
    public static PRISM.Definitions.FilterType AwakeningLevel;
    public static PRISM.Definitions.FilterType IdolSkill;
    public static PRISM.Definitions.FilterType DressOrder;
    public static PRISM.Definitions.FilterType StoryCharacter;
    public static PRISM.Definitions.FilterType MstExchangeProduct;
    public static PRISM.Definitions.FilterType LivePIdolDress;
}

// Namespace: PRISM.Definitions
public class FilterTypeExtensions
{
    public static string ToFactoryName(PRISM.Definitions.FilterType self);
}

// Namespace: PRISM.Definitions
public class SortFilterSettings
{
    public static PRISM.Definitions.SortFilterSettings Default;
    public PRISM.Definitions.SortType SortType;
    public PRISM.Definitions.SortDirection SortDirection;
    public System.Collections.Generic.IReadOnlyDictionary<PRISM.Definitions.FilterType, System.Collections.Generic.ISet<int>> FilterOnIds;
    public string ToString();
    public bool IsAnyFilterOn();

    private class <>O
    {
        public static System.Func<string, int> <0>__Parse;
    }

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<System.Collections.Generic.ISet<int>, bool> <>9__7_0;
        private bool <IsAnyFilterOn>b__7_0(System.Collections.Generic.ISet<int> x);
    }
}

// Namespace: PRISM.Definitions
public enum SortDirection : System.Enum
{
    public int value__;
    public static PRISM.Definitions.SortDirection Ascending;
    public static PRISM.Definitions.SortDirection Descending;
}

// Namespace: PRISM.Definitions
public enum SortType : System.Enum
{
    public int value__;
    public static PRISM.Definitions.SortType Unspecified;
    public static PRISM.Definitions.SortType AcquisitionOrder;
    public static PRISM.Definitions.SortType Idol;
    public static PRISM.Definitions.SortType Attribute;
    public static PRISM.Definitions.SortType Level;
    public static PRISM.Definitions.SortType TotalParameter;
    public static PRISM.Definitions.SortType Vocal;
    public static PRISM.Definitions.SortType Dance;
    public static PRISM.Definitions.SortType Visual;
    public static PRISM.Definitions.SortType Mental;
    public static PRISM.Definitions.SortType LiveSkillId;
    public static PRISM.Definitions.SortType LiveSkillLevel;
    public static PRISM.Definitions.SortType Default;
    public static PRISM.Definitions.SortType MusicName;
    public static PRISM.Definitions.SortType MusicLevel;
    public static PRISM.Definitions.SortType HighScore;
    public static PRISM.Definitions.SortType TotalNoteCount;
    public static PRISM.Definitions.SortType TechnicalScore;
    public static PRISM.Definitions.SortType TechnicalRate;
    public static PRISM.Definitions.SortType Character;
    public static PRISM.Definitions.SortType Rarity;
    public static PRISM.Definitions.SortType MasterTraining;
    public static PRISM.Definitions.SortType LiveSupportEffectLv;
    public static PRISM.Definitions.SortType GoodSchedule;
    public static PRISM.Definitions.SortType Star;
    public static PRISM.Definitions.SortType AwakeningLv;
    public static PRISM.Definitions.SortType RegisterDate;
    public static PRISM.Definitions.SortType FesUnitName;
    public static PRISM.Definitions.SortType AppearanceOrder;
    public static PRISM.Definitions.SortType Favorite;
    public static PRISM.Definitions.SortType PublicDate;
}

// Namespace: PRISM.Definitions
public class SortTypeExtensions
{
    public static string GetText(PRISM.Definitions.SortType type);
    public static string GetShortText(PRISM.Definitions.SortType type);
}

// Namespace: PRISM.Definitions
public class CommonSE
{
    public static string SheetName;
    public static PRISM.Definitions.SoundKey Decide;
    public static PRISM.Definitions.SoundKey Cancel;
    public static PRISM.Definitions.SoundKey PopupOpen;
    public static PRISM.Definitions.SoundKey RewardPopupOpen;
    public static PRISM.Definitions.SoundKey Select;
    public static PRISM.Definitions.SoundKey Swipe;
    public static PRISM.Definitions.SoundKey TapTab;
    public static PRISM.Definitions.SoundKey TouchStart;
    public static PRISM.Definitions.SoundKey LongPress;
    public static PRISM.Definitions.SoundKey NoticeDM;
    public static PRISM.Definitions.SoundKey NoticeNG;
    public static PRISM.Definitions.SoundKey Inactive;
    public static PRISM.Definitions.SoundKey ViewClose;
    public static PRISM.Definitions.SoundKey ErrorModal;
    public static PRISM.Definitions.SoundKey Toggle;
    public static PRISM.Definitions.SoundKey UnitSlide;
    public static PRISM.Definitions.SoundKey IdolSotaiLvUp;
}

// Namespace: PRISM.Definitions
public struct SoundKey : System.ValueType, System.IEquatable<PRISM.Definitions.SoundKey>
{
    private string <SheetName>k__BackingField;
    private string <CueName>k__BackingField;
    public string SheetName { get; set; }
    public string CueName { get; set; }
    public bool IsValid();
    public string ToString();
    private bool PrintMembers(System.Text.StringBuilder builder);
    public static bool op_Inequality(PRISM.Definitions.SoundKey left, PRISM.Definitions.SoundKey right);
    public static bool op_Equality(PRISM.Definitions.SoundKey left, PRISM.Definitions.SoundKey right);
    public int GetHashCode();
    public bool Equals(object obj);
    public bool Equals(PRISM.Definitions.SoundKey other);
    public void Deconstruct(string& SheetName, string& CueName);
}

// Namespace: PRISM.Definitions
public class DramaConst
{
    public static float AspectRatio;
    public static double FrameSecond;
}

// Namespace: PRISM.Definitions
public class RunwayEventConst
{
    public static int UnitMaxCount;
    public static int UnitMaxIdolCount;
    public static System.Collections.Generic.IReadOnlyList<int> OriginalMember;
    public static string XAccount;
}

// Namespace: PRISM.Definitions
public class ExchangeConst
{
    public static int ExchangeIdolPiecePaddingHead;
    public static int ExchangePaddingHead;
    public static int MinChangeCount;
    public static int MaxChangeCount;
    public static int ExchangeTicketDefaultCount;

    public enum ExchangeTabType : System.Enum
    {
        public int value__;
        public static ExchangeTabType Top;
        public static ExchangeTabType Money;
        public static ExchangeTabType IdolPiece;
        public static ExchangeTabType StarFragment;
        public static ExchangeTabType SeasonMedal;
        public static ExchangeTabType SelectionTicket;
        public static ExchangeTabType CostumeTicket;
        public static ExchangeTabType EventSeal;
        public static ExchangeTabType Event;
        public static ExchangeTabType LiveAllSongEvent;
        public static ExchangeTabType MasterBadge;
        public static ExchangeTabType Ticket;
        public static ExchangeTabType WingOfMemory;
    }
}

// Namespace: PRISM.Definitions
public class BufferWriterExtensions
{
    public static void Write(System.Buffers.IBufferWriter<byte> writer, byte value);
    public static void WriteString(System.Buffers.IBufferWriter<byte> writer, string value, System.Text.Encoding encoding);
    public static void WriteUnmanaged<T>(System.Buffers.IBufferWriter<byte> writer, T value);
}

// Namespace: PRISM.Definitions
public class DictionaryExtensions
{
    public static void RemoveAll<TKey, TValue>(System.Collections.Generic.IDictionary<TKey, TValue> self, System.Func<System.Collections.Generic.KeyValuePair<TKey, TValue>, bool> cond);
    public static TValue GetOrAdd<TKey, TValue>(System.Collections.Generic.IDictionary<TKey, TValue> self, TKey key);
}

// Namespace: PRISM.Definitions
public class EnumExtensions
{
    public static T GetAttribute<T>(System.Enum member);
}

// Namespace: PRISM.Definitions
public class ReactivePropertyExtensions
{
    public static UniRx.IReactiveProperty<int> ToInt<T>(UniRx.IReactiveProperty<T> self);
    public static UniRx.IReactiveProperty<int> ToInt(UniRx.IReactiveProperty<bool> self);

    private class ConvertReactiveProperty`2<TFrom, TTo> : UniRx.IReactiveProperty<TTo>, UniRx.IReadOnlyReactiveProperty<TTo>, System.IObservable<TTo>
    {
        private UniRx.IReactiveProperty<TFrom> baseProperty;
        public bool HasValue { get; set; }
        public TTo Value { get; set; }
        protected TTo ConvertTo(TFrom value);
        protected TFrom ConvertFrom(TTo value);
        public System.IDisposable Subscribe(System.IObserver<TTo> observer);

        private class <>c__DisplayClass9_0<TFrom, TTo>
        {
            public System.IObserver<TTo> observer;
            public ConvertReactiveProperty<TFrom, TTo> <>4__this;
            private void <Subscribe>b__0(TFrom x);
        }
    }

    private class BoolAsIntReactiveProperty : ConvertReactiveProperty<bool, int>
    {
        protected int ConvertTo(bool value);
        protected bool ConvertFrom(int value);
    }

    private class EnumAsIntReactiveProperty`1<T> : ConvertReactiveProperty<T, int>
    {
        protected int ConvertTo(T value);
        protected T ConvertFrom(int value);
    }
}

// Namespace: PRISM.Definitions
public class FriendEnum
{

    public enum CategoryType : System.Enum
    {
        public int value__;
        public static CategoryType Follow;
        public static CategoryType Follower;
        public static CategoryType Recommend;
    }

    public enum SortCategory : System.Enum
    {
        public int value__;
        public static SortCategory LoginDate;
        public static SortCategory Friend;
        public static SortCategory Follow;
    }

    public enum SortOrder : System.Enum
    {
        public int value__;
        public static SortOrder Ascending;
        public static SortOrder Descending;
    }

    public enum SwitchDisplayType : System.Enum
    {
        public int value__;
        public static SwitchDisplayType Data;
        public static SwitchDisplayType Guest;
    }
}

// Namespace: PRISM.Definitions
public class GashaEnum
{

    public enum SGashaPhase1FinishAnimationName : System.Enum
    {
        public int value__;
        public static SGashaPhase1FinishAnimationName Mot_Gasha_S1_SMP_Finish_R;
        public static SGashaPhase1FinishAnimationName Mot_Gasha_S1_SMP_Finish_SR;
        public static SGashaPhase1FinishAnimationName Mot_Gasha_S1_SMP_Finish_SSR;
    }

    public enum GashaResultItemAnimationName : System.Enum
    {
        public int value__;
        public static GashaResultItemAnimationName In_Normal;
        public static GashaResultItemAnimationName In_PickUP;
        public static GashaResultItemAnimationName In_Rarity_1;
        public static GashaResultItemAnimationName In_Rarity_2;
        public static GashaResultItemAnimationName In_Rarity_3;
    }
}

// Namespace: PRISM.Definitions
public class HomeConst
{
    public static string HomeMotionPathFormat;
    public static int CacheTime;
    public static float CharaMessageOpenMinTime;
    public static float CharaMessageOpenMaxTime;
    public static float CharaMessageCloseTime;
    public static float CharaMessageLeaveActionTime;
    public static float FirstCharaMessageOpenTime;
}

// Namespace: PRISM.Definitions
public class HomeEnum
{

    public enum LoginBonusViewType : System.Enum
    {
        public int value__;
        public static LoginBonusViewType Daily;
        public static LoginBonusViewType Special;
        public static LoginBonusViewType Single;
    }

    public enum Home3DViewType : System.Enum
    {
        public int value__;
        public static Home3DViewType Producer;
        public static Home3DViewType CutScene;
        public static Home3DViewType LoginBonus;
    }

    public enum FadeType : System.Enum
    {
        public int value__;
        public static FadeType In;
        public static FadeType Out;
    }

    public enum LoginBonusSkipType : System.Enum
    {
        public int value__;
        public static LoginBonusSkipType None;
        public static LoginBonusSkipType First;
        public static LoginBonusSkipType Second;
    }
}

// Namespace: PRISM.Definitions
public class ItemListConst
{
    public static int ExpireCautionDays;
}

// Namespace: PRISM.Definitions
public class ListComparer`1<T> : System.Collections.Generic.List<System.Comparison<T>>, System.Collections.Generic.IComparer<T>
{
    public void Add<TKey>(System.Func<T, TKey> keySelector);
    public int Compare(T x, T y);

    private class <>c__DisplayClass0_0`1<T, TKey>
    {
        public System.Func<T, TKey> keySelector;
        private int <Add>b__0(T x, T y);
    }
}

// Namespace: PRISM.Definitions
public enum CostumeCategory : System.Enum
{
    public int value__;
    public static PRISM.Definitions.CostumeCategory CostumeSet;
    public static PRISM.Definitions.CostumeCategory Costume;
    public static PRISM.Definitions.CostumeCategory Hairstyle;
    public static PRISM.Definitions.CostumeCategory Eye;
    public static PRISM.Definitions.CostumeCategory Earrings;
    public static PRISM.Definitions.CostumeCategory Makeup;
}

// Namespace: PRISM.Definitions
public enum CostumePartType : System.Enum
{
    public int value__;
    public static PRISM.Definitions.CostumePartType Costume;
    public static PRISM.Definitions.CostumePartType Hairstyle;
    public static PRISM.Definitions.CostumePartType Glasses;
    public static PRISM.Definitions.CostumePartType Earrings;
    public static PRISM.Definitions.CostumePartType Makeup;
    public static PRISM.Definitions.CostumePartType RightContactLens;
    public static PRISM.Definitions.CostumePartType LeftContactLens;
}

// Namespace: PRISM.Definitions
public enum RenderingDynamicRange : System.Enum
{
    public int value__;
    public static PRISM.Definitions.RenderingDynamicRange Low;
    public static PRISM.Definitions.RenderingDynamicRange High;
}

// Namespace: PRISM.Definitions
public enum VocalSeparatedSoundEffectMode : System.Enum
{
    public int value__;
    public static PRISM.Definitions.VocalSeparatedSoundEffectMode StageAudio;
    public static PRISM.Definitions.VocalSeparatedSoundEffectMode Normal;
}

// Namespace: PRISM.Definitions
public interface IMstCostumeDifference
{
    public int MstOriginalId { get; set; }
    public int MstDifferenceId { get; set; }
}

// Namespace: PRISM.Definitions
public interface IMstCostumePart
{
    public int Id { get; set; }
    public PRISM.Definitions.LocalizationKey Name { get; set; }
    public PRISM.Definitions.LocalizationKey Description { get; set; }
    public PRISM.Definitions.LocalizationKey UnlockPremise { get; set; }
    public PRISM.Definitions.MstCharacterInfo CharacterInfo { get; set; }
    public int CostumeType { get; set; }
    public bool IsDressOrderTarget { get; set; }
    public System.DateTime DressOrderBeginDate { get; set; }
}

// Namespace: PRISM.Definitions
public interface IMstMvStage
{
    public int Id { get; set; }
    public PRISM.Definitions.LocalizationKey Name { get; set; }
    public string CueSheet { get; set; }
    public string MvScene { get; set; }
    public int StageAudioType { get; set; }
    public string BackgroundImagePath { get; set; }
}

// Namespace: PRISM.Definitions
public struct LocalizationKey : System.ValueType, System.IEquatable<PRISM.Definitions.LocalizationKey>
{
    private string <Category>k__BackingField;
    private int <Id>k__BackingField;
    public string Category { get; set; }
    public int Id { get; set; }
    public static PRISM.Definitions.LocalizationKey op_Implicit(System.ValueTuple<string, int> key);
    public string ToString();
    private bool PrintMembers(System.Text.StringBuilder builder);
    public static bool op_Inequality(PRISM.Definitions.LocalizationKey left, PRISM.Definitions.LocalizationKey right);
    public static bool op_Equality(PRISM.Definitions.LocalizationKey left, PRISM.Definitions.LocalizationKey right);
    public int GetHashCode();
    public bool Equals(object obj);
    public bool Equals(PRISM.Definitions.LocalizationKey other);
    public void Deconstruct(string& Category, int& Id);
}

// Namespace: PRISM.Definitions
public class MasterData
{
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstAccessory> Accessories;
    public PRISM.Definitions.MasterTable<PRISM.Definitions.MstAccessoryDifferent> AccessoryDifferents;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstAccessoryResource> AccessoryResources;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstAchievement> Achievements;
    public PRISM.Definitions.SortedMasterTable<string, PRISM.Definitions.MstAdvInfo> AdvInfos;
    public PRISM.Definitions.MasterTable<PRISM.Definitions.MstAuditionSettings> AuditionSettingses;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstBannerGenre> BannerGenres;
    public PRISM.Definitions.MasterTable<PRISM.Definitions.MstBirthdayVoice> BirthdayVoices;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstChainGroup> ChainGroups;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstChainTalk> ChainTalks;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstChainTalkText> ChainTalkTexts;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstChainUser> ChainUsers;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstChallengeTour> ChallengeTours;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstChallengeTourMission> ChallengeTourMissions;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstChallengeTourStage> ChallengeTourStages;
    public PRISM.Definitions.MasterTable<PRISM.Definitions.MstCharacterBirthdayAdv> CharacterBirthdayAdvs;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstCharacterInfo> CharacterInfos;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstCostume> Costumes;
    public PRISM.Definitions.MasterTable<PRISM.Definitions.MstCostumeDifferent> CostumeDifferents;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstCostumeResource> CostumeResources;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstCostumeSet> CostumeSets;
    public PRISM.Definitions.MasterTable<PRISM.Definitions.MstCostumeShopItemGroup> CostumeShopItemGroups;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstDressOrderRecipe> DressOrderRecipes;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstDressUpRoomVoice> DressUpRoomVoices;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstEpisode> Episodes;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstEpisodeEventMissionBanner> EpisodeEventMissionBanners;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstEpisodeZeroStory> EpisodeZeroStories;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstEvent> Events;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstEventAlbum> EventAlbums;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstEventIcon> EventIcons;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstEventItem> EventItems;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstEventRanking> EventRankings;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstEventSong> EventSongs;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstEventStory> EventStories;
    public PRISM.Definitions.MasterTable<PRISM.Definitions.MstExchangeProduct> ExchangeProducts;
    public PRISM.Definitions.MasterTable<PRISM.Definitions.MstExchangeProductFilter> ExchangeProductFilters;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstExtraStory> ExtraStories;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstExtraStoryCategory> ExtraStoryCategories;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstExtraStorySubCategory> ExtraStorySubCategories;
    public PRISM.Definitions.MasterTable<PRISM.Definitions.MstFavoriteMark> FavoriteMarks;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstFavoriteSchedule> FavoriteSchedules;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstFirstProduceIdol> FirstProduceIdols;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstGalleryEtcCategory> GalleryEtcCategories;
    public PRISM.Definitions.SortedMasterTable<string, PRISM.Definitions.MstGashaResource> GashaResources;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstGashaTicket> GashaTickets;
    public PRISM.Definitions.MasterTable<PRISM.Definitions.MstGiftEventReward> GiftEventRewards;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstGiftEventTokenRelation> GiftEventTokenRelations;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstHairstyle> Hairstyles;
    public PRISM.Definitions.MasterTable<PRISM.Definitions.MstHairstyleDifferent> HairstyleDifferents;
    public PRISM.Definitions.SortedMasterTable<System.ValueTuple<int, int>, PRISM.Definitions.MstHairstyleResource> HairstyleResources;
    public PRISM.Definitions.MasterTable<PRISM.Definitions.MstHelp> Helps;
    public PRISM.Definitions.MasterTable<PRISM.Definitions.MstHelpGroup> HelpGroups;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstIdol> Idols;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstIdolSkill> IdolSkills;
    public PRISM.Definitions.MasterTable<PRISM.Definitions.MstIdolSkillEffect> IdolSkillEffects;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstIdolSkillLevelUpRecipe> IdolSkillLevelUpRecipes;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstIdolStandingPosition> IdolStandingPositions;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstIdolStory> IdolStories;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstItemPack> ItemPacks;
    public PRISM.Definitions.MasterTable<PRISM.Definitions.MstItemProvider> ItemProviders;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstLetter> Letters;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstLetterGroup> LetterGroups;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstLiveCenterEffect> LiveCenterEffects;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstLiveCenterEffectDetail> LiveCenterEffectDetails;
    public PRISM.Definitions.SortedMasterTable<System.ValueTuple<int, int>, PRISM.Definitions.MstLiveComboRankReward> LiveComboRankRewards;
    public PRISM.Definitions.SortedMasterTable<System.ValueTuple<int, int>, PRISM.Definitions.MstLiveComboRankTarget> LiveComboRankTargets;
    public PRISM.Definitions.MasterTable<PRISM.Definitions.MstLiveCutScene> LiveCutScenes;
    public PRISM.Definitions.MasterTable<PRISM.Definitions.MstLiveCutSceneCostume> LiveCutSceneCostumes;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstLiveEventBonus> LiveEventBonuses;
    public PRISM.Definitions.SortedMasterTable<System.ValueTuple<int, int>, PRISM.Definitions.MstLiveScoreRankReward> LiveScoreRankRewards;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstLiveSkill> LiveSkills;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstLiveSkillDetail> LiveSkillDetails;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstLiveSkillEffectType> LiveSkillEffectTypes;
    public PRISM.Definitions.SortedMasterTable<System.ValueTuple<int, int>, PRISM.Definitions.MstLiveSkillLevel> LiveSkillLevels;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstLiveSupportEffect> LiveSupportEffects;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstLiveSupportEffectDetail> LiveSupportEffectDetails;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstLiveSupportEffectType> LiveSupportEffectTypes;
    public PRISM.Definitions.MasterTable<PRISM.Definitions.MstLiveTotalHighScoreRateReward> LiveTotalHighScoreRateRewards;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstLiveTotalTechnicalRateReward> LiveTotalTechnicalRateRewards;
    public PRISM.Definitions.MasterTable<PRISM.Definitions.MstLiveUnitRankingCategory> LiveUnitRankingCategories;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstLoginBonus> LoginBonuses;
    public PRISM.Definitions.MasterTable<PRISM.Definitions.MstLoginBonusCostumeSet> LoginBonusCostumeSets;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstLoginBonusPass> LoginBonusPasses;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstMainStory> MainStories;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstMainStoryChapter> MainStoryChapters;
    public PRISM.Definitions.SortedMasterTable<string, PRISM.Definitions.MstMcsIdolOrder> McsIdolOrders;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstMissionGroup> MissionGroups;
    public PRISM.Definitions.MasterTable<PRISM.Definitions.MstMissionRemind> MissionReminds;
    public PRISM.Definitions.SortedMasterTable<string, PRISM.Definitions.MstNcsIdolOrder> NcsIdolOrders;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstNotebook> Notebooks;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstOutgameVoiceMotion> OutgameVoiceMotions;
    public PRISM.Definitions.SortedMasterTable<string, PRISM.Definitions.MstPcsIdolOrder> PcsIdolOrders;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstPhoneCall> PhoneCalls;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstPhoneCallText> PhoneCallTexts;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstPhoneGroup> PhoneGroups;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstPhoneUser> PhoneUsers;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstPotentialSupportSkill> PotentialSupportSkills;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstProduceActionEffect> ProduceActionEffects;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstProduceCardContentGroup> ProduceCardContentGroups;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstProduceIdol> ProduceIdols;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstProduceIdolEvent> ProduceIdolEvents;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstProduceIdolEvolutionLevel> ProduceIdolEvolutionLevels;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstProduceIdolEvolutionRecipe> ProduceIdolEvolutionRecipes;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstProduceIdolLevelExp> ProduceIdolLevelExps;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstProduceIdolLevelReward> ProduceIdolLevelRewards;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstProduceIdolLimitBreakRecipe> ProduceIdolLimitBreakRecipes;
    public PRISM.Definitions.SortedMasterTable<System.ValueTuple<int, int>, PRISM.Definitions.MstProduceIdolPersonalLimitBreakReward> ProduceIdolPersonalLimitBreakRewards;
    public PRISM.Definitions.MasterTable<PRISM.Definitions.MstProduceIdolReleaseCostumeSet> ProduceIdolReleaseCostumeSets;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstProduceMainIdolScenario> ProduceMainIdolScenarios;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstProduceMainScenario> ProduceMainScenarios;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstProducePassiveEffect> ProducePassiveEffects;
    public PRISM.Definitions.MasterTable<PRISM.Definitions.MstProducePromotionBanner> ProducePromotionBanners;
    public PRISM.Definitions.MasterTable<PRISM.Definitions.MstProduceUniqueCutScene> ProduceUniqueCutScenes;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstProductType> ProductTypes;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstRecoveryDrink> RecoveryDrinks;
    public PRISM.Definitions.MasterTable<PRISM.Definitions.MstRunwayStage> RunwayStages;
    public PRISM.Definitions.MasterTable<PRISM.Definitions.MstScheduleType> ScheduleTypes;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstSeasonMission> SeasonMissions;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstShinyCompetition> ShinyCompetitions;
    public PRISM.Definitions.MasterTable<PRISM.Definitions.MstShinyCompetitionIdol> ShinyCompetitionIdols;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstShinyCompetitionProduceBonus> ShinyCompetitionProduceBonuses;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstShinyCompetitionProduceBonusCondition> ShinyCompetitionProduceBonusConditions;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstShinyCompetitionRanking> ShinyCompetitionRankings;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstSkillBufferDisplay> SkillBufferDisplays;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstSong> Songs;
    public PRISM.Definitions.SortedMasterTable<System.ValueTuple<int, int>, PRISM.Definitions.MstSongDifficultyLevel> SongDifficultyLevels;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstSongOverrideOnStageIdolCount> SongOverrideOnStageIdolCounts;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstSongPartsCharacter> SongPartsCharacters;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstSongPositionExample> SongPositionExamples;
    public PRISM.Definitions.MasterTable<PRISM.Definitions.MstSongSpecialStartVoice> SongSpecialStartVoices;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstSongType> SongTypes;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstSpecialMission> SpecialMissions;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstStarGrowth> StarGrowths;
    public PRISM.Definitions.MasterTable<PRISM.Definitions.MstStoryReadCountReward> StoryReadCountRewards;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstStreamProgram> StreamPrograms;
    public PRISM.Definitions.MasterTable<PRISM.Definitions.MstSubSeasonOpeningAdvOption> SubSeasonOpeningAdvOptions;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstSupportCharacter> SupportCharacters;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstSupportCharacterEvent> SupportCharacterEvents;
    public PRISM.Definitions.MasterTable<PRISM.Definitions.MstSupportCharacterLevelExp> SupportCharacterLevelExps;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstSupportCharacterLevelReward> SupportCharacterLevelRewards;
    public PRISM.Definitions.MasterTable<PRISM.Definitions.MstSupportCharacterLimitBreakBonus> SupportCharacterLimitBreakBonuses;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstSupportCharacterLimitBreakRecipe> SupportCharacterLimitBreakRecipes;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstSupportEffect> SupportEffects;
    public PRISM.Definitions.MasterTable<PRISM.Definitions.MstTechnicalRankReward> TechnicalRankRewards;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstTechnicalRankTarget> TechnicalRankTargets;
    public PRISM.Definitions.MasterTable<PRISM.Definitions.MstTips> Tipses;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstTipsCategory> TipsCategories;
    public PRISM.Definitions.MasterTable<PRISM.Definitions.MstTitleBackground> TitleBackgrounds;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstTrainingTicket> TrainingTickets;
    public PRISM.Definitions.MasterTable<PRISM.Definitions.MstTutorial> Tutorials;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstTwestaArticle> TwestaArticles;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstTwestaComment> TwestaComments;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstTwestaUser> TwestaUsers;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstUnit> Units;
    public PRISM.Definitions.SortedMasterTable<int, PRISM.Definitions.MstVoiceResource> VoiceResources;
    public System.Collections.Generic.IEnumerable<int> FavoriteMarkIds { get; set; }
    public static void RegisterFormatter();

    private class Formatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MasterData>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MasterData& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MasterData& value);
    }

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Definitions.MstFavoriteMark, int> <>9__1_0;
        private int <get_FavoriteMarkIds>b__1_0(PRISM.Definitions.MstFavoriteMark x);
    }
}

// Namespace: PRISM.Definitions
public class PrimaryKeyAttribute : System.Attribute
{
}

// Namespace: PRISM.Definitions
public class ReferenceAttribute : System.Attribute
{
}

// Namespace: PRISM.Definitions
public class MasterTable`1<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
{
    protected T[] data;
    public int Count { get; set; }
    public System.Collections.Generic.IReadOnlyList<T> All { get; set; }
    private System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
    public Enumerator<T> GetEnumerator();

    public struct Enumerator<T> : System.ValueType, System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
    {
        private T[] data;
        private int i;
        public T Current { get; set; }
        private object System.Collections.IEnumerator.Current { get; set; }
        public bool MoveNext();
        public void Reset();
        public void Dispose();
    }
}

// Namespace: PRISM.Definitions
public class MstAccessory : PRISM.Definitions.IMstCostumePart, System.IComparable<PRISM.Definitions.MstAccessory>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstAccessory>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <MstCharacterInfoId>k__BackingField;
    private int <CostumeType>k__BackingField;
    private int <AccessoryType>k__BackingField;
    private int <ResourceId>k__BackingField;
    private PRISM.Definitions.MstCharacterInfo <CharacterInfo>k__BackingField;
    private PRISM.Definitions.MstAccessoryResource <Resource>k__BackingField;
    public int Id { get; set; }
    public PRISM.Definitions.LocalizationKey Name { get; set; }
    public PRISM.Definitions.LocalizationKey Description { get; set; }
    public PRISM.Definitions.LocalizationKey UnlockPremise { get; set; }
    public bool IsDressOrderTarget { get; set; }
    public System.DateTime DressOrderBeginDate { get; set; }
    public int MstCharacterInfoId { get; set; }
    public int CostumeType { get; set; }
    public int AccessoryType { get; set; }
    public int ResourceId { get; set; }
    public PRISM.Definitions.MstCharacterInfo CharacterInfo { get; set; }
    public PRISM.Definitions.MstAccessoryResource Resource { get; set; }
    public int CompareTo(PRISM.Definitions.MstAccessory other);
    public int CompareTo(int key);
    public void BindReferences(PRISM.Definitions.MasterData masterData);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstAccessory& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstAccessory& value);

    private class MstAccessoryFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstAccessory>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstAccessory& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstAccessory& value);
    }
}

// Namespace: PRISM.Definitions
public class MstAccessoryDifferent : PRISM.Definitions.IMstCostumeDifference, MemoryPack.IMemoryPackable<PRISM.Definitions.MstAccessoryDifferent>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <MstOriginalAccessoryId>k__BackingField;
    private int <MstAccessoryId>k__BackingField;
    public int MstOriginalAccessoryId { get; set; }
    public int MstAccessoryId { get; set; }
    public int MstOriginalId { get; set; }
    public int MstDifferenceId { get; set; }
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstAccessoryDifferent& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstAccessoryDifferent& value);

    private class MstAccessoryDifferentFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstAccessoryDifferent>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstAccessoryDifferent& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstAccessoryDifferent& value);
    }
}

// Namespace: PRISM.Definitions
public class MstAccessoryResource : System.IComparable<PRISM.Definitions.MstAccessoryResource>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstAccessoryResource>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private string <PrefabName>k__BackingField;
    public int Id { get; set; }
    public string PrefabName { get; set; }
    public int CompareTo(PRISM.Definitions.MstAccessoryResource other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstAccessoryResource& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstAccessoryResource& value);

    private class MstAccessoryResourceFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstAccessoryResource>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstAccessoryResource& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstAccessoryResource& value);
    }
}

// Namespace: PRISM.Definitions
public class MstAchievement : System.IComparable<PRISM.Definitions.MstAchievement>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstAchievement>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <SortId>k__BackingField;
    public int Id { get; set; }
    public PRISM.Definitions.LocalizationKey Name { get; set; }
    public PRISM.Definitions.LocalizationKey Description { get; set; }
    public PRISM.Definitions.LocalizationKey Condition { get; set; }
    public int SortId { get; set; }
    public string ImagePath { get; set; }
    public int CompareTo(PRISM.Definitions.MstAchievement other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstAchievement& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstAchievement& value);

    private class MstAchievementFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstAchievement>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstAchievement& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstAchievement& value);
    }
}

// Namespace: PRISM.Definitions
public class MstAdvInfo : System.IComparable<PRISM.Definitions.MstAdvInfo>, System.IComparable<string>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstAdvInfo>, MemoryPack.IMemoryPackFormatterRegister
{
    private string <Id>k__BackingField;
    private bool <UseIrregularSubTitle>k__BackingField;
    private bool <IsNewAdv>k__BackingField;
    public string Id { get; set; }
    public bool UseIrregularSubTitle { get; set; }
    public bool IsNewAdv { get; set; }
    public PRISM.Definitions.LocalizationKey GetTitle();
    public PRISM.Definitions.LocalizationKey GetSummary();
    public PRISM.Definitions.LocalizationKey GetIrregularSubTitle();
    private PRISM.Definitions.LocalizationKey _getLocalizationKey(string category);
    public int CompareTo(PRISM.Definitions.MstAdvInfo other);
    public int CompareTo(string key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstAdvInfo& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstAdvInfo& value);

    private class MstAdvInfoFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstAdvInfo>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstAdvInfo& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstAdvInfo& value);
    }
}

// Namespace: PRISM.Definitions
public class MstAuditionSettings : MemoryPack.IMemoryPackable<PRISM.Definitions.MstAuditionSettings>, MemoryPack.IMemoryPackFormatterRegister
{
    private string <SongId>k__BackingField;
    private int <StageZ>k__BackingField;
    private int <DelayFrame>k__BackingField;
    public string SongId { get; set; }
    public int StageZ { get; set; }
    public int DelayFrame { get; set; }
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstAuditionSettings& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstAuditionSettings& value);

    private class MstAuditionSettingsFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstAuditionSettings>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstAuditionSettings& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstAuditionSettings& value);
    }
}

// Namespace: PRISM.Definitions
public class MstBannerGenre : System.IComparable<PRISM.Definitions.MstBannerGenre>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstBannerGenre>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private string <Name>k__BackingField;
    private string <ResourceId>k__BackingField;
    public int Id { get; set; }
    public string Name { get; set; }
    public string ResourceId { get; set; }
    public string ImagePath { get; set; }
    public int CompareTo(PRISM.Definitions.MstBannerGenre other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstBannerGenre& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstBannerGenre& value);

    private class MstBannerGenreFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstBannerGenre>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstBannerGenre& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstBannerGenre& value);
    }
}

// Namespace: PRISM.Definitions
public class MstBirthdayVoice : MemoryPack.IMemoryPackable<PRISM.Definitions.MstBirthdayVoice>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <MstVoiceResourceId>k__BackingField;
    public int MstVoiceResourceId { get; set; }
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstBirthdayVoice& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstBirthdayVoice& value);

    private class MstBirthdayVoiceFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstBirthdayVoice>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstBirthdayVoice& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstBirthdayVoice& value);
    }
}

// Namespace: PRISM.Definitions
public enum ChainGroupTextColorType : System.Enum
{
    public int value__;
    public static PRISM.Definitions.ChainGroupTextColorType Black;
    public static PRISM.Definitions.ChainGroupTextColorType White;
}

// Namespace: PRISM.Definitions
public class MstChainGroup : System.IComparable<PRISM.Definitions.MstChainGroup>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstChainGroup>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <GroupType>k__BackingField;
    private PRISM.Definitions.ChainGroupTextColorType <TextColorType>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<int> <MstChainUserId>k__BackingField;
    public int Id { get; set; }
    public PRISM.Definitions.LocalizationKey Name { get; set; }
    public int GroupType { get; set; }
    public PRISM.Definitions.ChainGroupTextColorType TextColorType { get; set; }
    public System.Collections.Generic.IReadOnlyList<int> MstChainUserId { get; set; }
    public string IconPath { get; set; }
    public string TalkBackgroundPath { get; set; }
    public string GroupMemberBackgroundPath { get; set; }
    public int CompareTo(PRISM.Definitions.MstChainGroup other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstChainGroup& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstChainGroup& value);

    private class MstChainGroupFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstChainGroup>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstChainGroup& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstChainGroup& value);
    }
}

// Namespace: PRISM.Definitions
public class MstChainTalk : System.IComparable<PRISM.Definitions.MstChainTalk>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstChainTalk>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <MstChainGroupId>k__BackingField;
    public int Id { get; set; }
    public int MstChainGroupId { get; set; }
    public PRISM.Definitions.LocalizationKey Title { get; set; }
    public int CompareTo(PRISM.Definitions.MstChainTalk other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstChainTalk& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstChainTalk& value);

    private class MstChainTalkFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstChainTalk>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstChainTalk& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstChainTalk& value);
    }
}

// Namespace: PRISM.Definitions
public class MstChainTalkText : System.IComparable<PRISM.Definitions.MstChainTalkText>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstChainTalkText>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <MstChainTalkId>k__BackingField;
    private int <MstChainUserId>k__BackingField;
    private int <TextType>k__BackingField;
    private int <StampId>k__BackingField;
    private int <ThumbnailId>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<int> <NextId>k__BackingField;
    private int <ThinkingRate>k__BackingField;
    private int <TypingRate>k__BackingField;
    private bool <HasExtraThumbnail>k__BackingField;
    public int Id { get; set; }
    public int MstChainTalkId { get; set; }
    public int MstChainUserId { get; set; }
    public int TextType { get; set; }
    public PRISM.Definitions.LocalizationKey Body { get; set; }
    public int StampId { get; set; }
    public int ThumbnailId { get; set; }
    public System.Collections.Generic.IReadOnlyList<int> NextId { get; set; }
    public int ThinkingRate { get; set; }
    public int TypingRate { get; set; }
    public bool HasExtraThumbnail { get; set; }
    public string StampPath { get; set; }
    public string MoviePath { get; set; }
    public string DefaultThumbnailKey { get; set; }
    public System.Collections.Generic.IEnumerable<string> GetThumbnailPaths();
    public int CompareTo(PRISM.Definitions.MstChainTalkText other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstChainTalkText& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstChainTalkText& value);

    private class MstChainTalkTextFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstChainTalkText>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstChainTalkText& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstChainTalkText& value);
    }

    private class <GetThumbnailPaths>d__48 : System.Collections.Generic.IEnumerable<string>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<string>, System.Collections.IEnumerator, System.IDisposable
    {
        private int <>1__state;
        private string <>2__current;
        private int <>l__initialThreadId;
        public PRISM.Definitions.MstChainTalkText <>4__this;
        private string System.Collections.Generic.IEnumerator<System.String>.Current { get; set; }
        private object System.Collections.IEnumerator.Current { get; set; }
        private void System.IDisposable.Dispose();
        private bool MoveNext();
        private void System.Collections.IEnumerator.Reset();
        private System.Collections.Generic.IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator();
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
    }
}

// Namespace: PRISM.Definitions
public enum ChainUserChainSpeedType : System.Enum
{
    public int value__;
    public static PRISM.Definitions.ChainUserChainSpeedType VeryFast;
    public static PRISM.Definitions.ChainUserChainSpeedType Fast;
    public static PRISM.Definitions.ChainUserChainSpeedType Normal;
    public static PRISM.Definitions.ChainUserChainSpeedType Slow;
    public static PRISM.Definitions.ChainUserChainSpeedType VerySlow;
}

// Namespace: PRISM.Definitions
public class MstChainUser : System.IComparable<PRISM.Definitions.MstChainUser>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstChainUser>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private PRISM.Definitions.ChainUserChainSpeedType <TypingSpeedType>k__BackingField;
    private PRISM.Definitions.ChainUserChainSpeedType <ThinkingSpeedType>k__BackingField;
    public int Id { get; set; }
    public PRISM.Definitions.LocalizationKey Name { get; set; }
    public PRISM.Definitions.LocalizationKey Profile { get; set; }
    public PRISM.Definitions.ChainUserChainSpeedType TypingSpeedType { get; set; }
    public PRISM.Definitions.ChainUserChainSpeedType ThinkingSpeedType { get; set; }
    public string IconPath { get; set; }
    public string ProfileBackgroundPath { get; set; }
    public bool IsProducer { get; set; }
    public int CompareTo(PRISM.Definitions.MstChainUser other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstChainUser& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstChainUser& value);

    private class MstChainUserFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstChainUser>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstChainUser& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstChainUser& value);
    }
}

// Namespace: PRISM.Definitions
public class MstChallengeTour : System.IComparable<PRISM.Definitions.MstChallengeTour>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstChallengeTour>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <MstUnitId>k__BackingField;
    public int Id { get; set; }
    public int MstUnitId { get; set; }
    public string UnitCharaImagePath { get; set; }
    public int CompareTo(PRISM.Definitions.MstChallengeTour other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstChallengeTour& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstChallengeTour& value);

    private class MstChallengeTourFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstChallengeTour>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstChallengeTour& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstChallengeTour& value);
    }
}

// Namespace: PRISM.Definitions
public class MstChallengeTourMission : System.IComparable<PRISM.Definitions.MstChallengeTourMission>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstChallengeTourMission>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <MissionType>k__BackingField;
    private int <Value>k__BackingField;
    public int Id { get; set; }
    public int MissionType { get; set; }
    public int Value { get; set; }
    public PRISM.Definitions.LocalizationKey Text { get; set; }
    public int CompareTo(PRISM.Definitions.MstChallengeTourMission other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstChallengeTourMission& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstChallengeTourMission& value);

    private class MstChallengeTourMissionFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstChallengeTourMission>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstChallengeTourMission& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstChallengeTourMission& value);
    }
}

// Namespace: PRISM.Definitions
public class MstChallengeTourStage : System.IComparable<PRISM.Definitions.MstChallengeTourStage>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstChallengeTourStage>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <StageType>k__BackingField;
    public int Id { get; set; }
    public int StageType { get; set; }
    public PRISM.Definitions.LocalizationKey Description { get; set; }
    public int CompareTo(PRISM.Definitions.MstChallengeTourStage other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstChallengeTourStage& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstChallengeTourStage& value);

    private class MstChallengeTourStageFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstChallengeTourStage>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstChallengeTourStage& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstChallengeTourStage& value);
    }
}

// Namespace: PRISM.Definitions
public class MstCharacterBirthdayAdv : MemoryPack.IMemoryPackable<PRISM.Definitions.MstCharacterBirthdayAdv>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <MstCharacterInfoId>k__BackingField;
    private string <ResourceId>k__BackingField;
    public int MstCharacterInfoId { get; set; }
    public string ResourceId { get; set; }
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstCharacterBirthdayAdv& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstCharacterBirthdayAdv& value);

    private class MstCharacterBirthdayAdvFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstCharacterBirthdayAdv>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstCharacterBirthdayAdv& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstCharacterBirthdayAdv& value);
    }
}

// Namespace: PRISM.Definitions
public class MstCharacterInfo : System.IComparable<PRISM.Definitions.MstCharacterInfo>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstCharacterInfo>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <MstUnitId>k__BackingField;
    private string <FirstNameRoma>k__BackingField;
    private string <LastNameRoma>k__BackingField;
    private string <FirstNameKana>k__BackingField;
    private string <LastNameKana>k__BackingField;
    private int <Age>k__BackingField;
    private string <BloodType>k__BackingField;
    private string <Birthday>k__BackingField;
    private string <ZodiacSign>k__BackingField;
    private string <DominantHand>k__BackingField;
    private string <Birthplace>k__BackingField;
    private string <Height>k__BackingField;
    private string <Weight>k__BackingField;
    private string <Hobby>k__BackingField;
    private string <SpecialAbility>k__BackingField;
    private string <Description>k__BackingField;
    private string <ColorCode>k__BackingField;
    private string <ProfileFontColorCode>k__BackingField;
    private string <ProfileBgColorCode>k__BackingField;
    private int <MstDefaultCasualCostumeSetId>k__BackingField;
    private int <MstTracksuitLifeSizeCostumeSetId>k__BackingField;
    private int <MstTracksuitCbCostumeSetId>k__BackingField;
    private float <Shape>k__BackingField;
    private float <HeadShape>k__BackingField;
    private int <MotionType>k__BackingField;
    private string <LightColorCode>k__BackingField;
    private int <Order>k__BackingField;
    private PRISM.Definitions.MstCostumeSet <DefaultCasualCostumeSet>k__BackingField;
    private PRISM.Definitions.MstCostumeSet <TracksuitLifeSizeCostumeSet>k__BackingField;
    private PRISM.Definitions.MstCostumeSet <TracksuitCbCostumeSet>k__BackingField;
    private PRISM.Definitions.MstUnit <Unit>k__BackingField;
    public int Id { get; set; }
    public int MstUnitId { get; set; }
    public PRISM.Definitions.LocalizationKey Name { get; set; }
    public PRISM.Definitions.LocalizationKey FirstName { get; set; }
    public PRISM.Definitions.LocalizationKey LastName { get; set; }
    public string FirstNameRoma { get; set; }
    public string LastNameRoma { get; set; }
    public string FirstNameKana { get; set; }
    public string LastNameKana { get; set; }
    public PRISM.Definitions.LocalizationKey Cv { get; set; }
    public int Age { get; set; }
    public string BloodType { get; set; }
    public string Birthday { get; set; }
    public string ZodiacSign { get; set; }
    public string DominantHand { get; set; }
    public string Birthplace { get; set; }
    public string Height { get; set; }
    public string Weight { get; set; }
    public string Hobby { get; set; }
    public string SpecialAbility { get; set; }
    public string Description { get; set; }
    public string ColorCode { get; set; }
    public string ProfileFontColorCode { get; set; }
    public string ProfileBgColorCode { get; set; }
    public int MstDefaultCasualCostumeSetId { get; set; }
    public int MstTracksuitLifeSizeCostumeSetId { get; set; }
    public int MstTracksuitCbCostumeSetId { get; set; }
    public float Shape { get; set; }
    public float HeadShape { get; set; }
    public int MotionType { get; set; }
    public string LightColorCode { get; set; }
    public int Order { get; set; }
    public string TipsCharacterImagePath { get; set; }
    public string CharacterBaseButtonPrefabPath { get; set; }
    public string BirthdayBackgroundPrefabPath { get; set; }
    public string BirthdayRibbonPath { get; set; }
    public string BirthdayCharacterNamePath { get; set; }
    public string SDIconPath { get; set; }
    public string EpisodeZeroStoryIdolImagePath { get; set; }
    public string EpisodeZeroStoryIdolTabSelectedImagePath { get; set; }
    public string EpisodeZeroStoryIdolTabUnselectedImagePath { get; set; }
    public PRISM.Definitions.MstCostumeSet DefaultCasualCostumeSet { get; set; }
    public PRISM.Definitions.MstCostumeSet TracksuitLifeSizeCostumeSet { get; set; }
    public PRISM.Definitions.MstCostumeSet TracksuitCbCostumeSet { get; set; }
    public PRISM.Definitions.MstUnit Unit { get; set; }
    public int CompareTo(PRISM.Definitions.MstCharacterInfo other);
    public int CompareTo(int key);
    public void BindReferences(PRISM.Definitions.MasterData masterData);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstCharacterInfo& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstCharacterInfo& value);

    private class MstCharacterInfoFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstCharacterInfo>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstCharacterInfo& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstCharacterInfo& value);
    }
}

// Namespace: PRISM.Definitions
public class MstCostume : PRISM.Definitions.IMstCostumePart, System.IComparable<PRISM.Definitions.MstCostume>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstCostume>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <MstCharacterInfoId>k__BackingField;
    private int <CostumeType>k__BackingField;
    private int <ResourceId>k__BackingField;
    private bool <IsDressOrderTarget>k__BackingField;
    private System.DateTime <DressOrderBeginDate>k__BackingField;
    private PRISM.Definitions.MstCharacterInfo <CharacterInfo>k__BackingField;
    private PRISM.Definitions.MstCostumeResource <Resource>k__BackingField;
    public int Id { get; set; }
    public PRISM.Definitions.LocalizationKey Name { get; set; }
    public PRISM.Definitions.LocalizationKey Description { get; set; }
    public PRISM.Definitions.LocalizationKey UnlockPremise { get; set; }
    public int MstCharacterInfoId { get; set; }
    public int CostumeType { get; set; }
    public int ResourceId { get; set; }
    public bool IsDressOrderTarget { get; set; }
    public System.DateTime DressOrderBeginDate { get; set; }
    public PRISM.Definitions.MstCharacterInfo CharacterInfo { get; set; }
    public PRISM.Definitions.MstCostumeResource Resource { get; set; }
    public int CompareTo(PRISM.Definitions.MstCostume other);
    public int CompareTo(int key);
    public void BindReferences(PRISM.Definitions.MasterData masterData);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstCostume& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstCostume& value);

    private class MstCostumeFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstCostume>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstCostume& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstCostume& value);
    }
}

// Namespace: PRISM.Definitions
public class MstCostumeDifferent : PRISM.Definitions.IMstCostumeDifference, MemoryPack.IMemoryPackable<PRISM.Definitions.MstCostumeDifferent>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <MstOriginalCostumeId>k__BackingField;
    private int <MstCostumeId>k__BackingField;
    public int MstOriginalCostumeId { get; set; }
    public int MstCostumeId { get; set; }
    public int MstOriginalId { get; set; }
    public int MstDifferenceId { get; set; }
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstCostumeDifferent& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstCostumeDifferent& value);

    private class MstCostumeDifferentFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstCostumeDifferent>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstCostumeDifferent& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstCostumeDifferent& value);
    }
}

// Namespace: PRISM.Definitions
public class MstCostumeResource : System.IComparable<PRISM.Definitions.MstCostumeResource>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstCostumeResource>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private string <PrefabName>k__BackingField;
    public int Id { get; set; }
    public string PrefabName { get; set; }
    public int CompareTo(PRISM.Definitions.MstCostumeResource other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstCostumeResource& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstCostumeResource& value);

    private class MstCostumeResourceFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstCostumeResource>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstCostumeResource& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstCostumeResource& value);
    }
}

// Namespace: PRISM.Definitions
public class MstCostumeSet : System.IComparable<PRISM.Definitions.MstCostumeSet>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstCostumeSet>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <MstCostumeId>k__BackingField;
    private int <MstHairstyleId>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<int> <MstAccessoryIdList>k__BackingField;
    private int <SortId>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<int> <MstSongIdList>k__BackingField;
    private PRISM.Definitions.MstCostume <Costume>k__BackingField;
    private PRISM.Definitions.MstHairstyle <Hairstyle>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<PRISM.Definitions.MstAccessory> <Accessories>k__BackingField;
    public int Id { get; set; }
    public PRISM.Definitions.LocalizationKey Name { get; set; }
    public PRISM.Definitions.LocalizationKey Description { get; set; }
    public PRISM.Definitions.LocalizationKey UnlockPremise { get; set; }
    public int MstCostumeId { get; set; }
    public int MstHairstyleId { get; set; }
    public System.Collections.Generic.IReadOnlyList<int> MstAccessoryIdList { get; set; }
    public int SortId { get; set; }
    public System.Collections.Generic.IReadOnlyList<int> MstSongIdList { get; set; }
    public PRISM.Definitions.MstCostume Costume { get; set; }
    public PRISM.Definitions.MstHairstyle Hairstyle { get; set; }
    public System.Collections.Generic.IReadOnlyList<PRISM.Definitions.MstAccessory> Accessories { get; set; }
    public int[] GetAccessoryResourceIds();
    public int CompareTo(PRISM.Definitions.MstCostumeSet other);
    public int CompareTo(int key);
    public void BindReferences(PRISM.Definitions.MasterData masterData);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstCostumeSet& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstCostumeSet& value);

    private class MstCostumeSetFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstCostumeSet>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstCostumeSet& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstCostumeSet& value);
    }

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Definitions.MstAccessory, bool> <>9__45_0;
        private bool <BindReferences>b__45_0(PRISM.Definitions.MstAccessory x);
    }
}

// Namespace: PRISM.Definitions
public class MstCostumeShopItemGroup : MemoryPack.IMemoryPackable<PRISM.Definitions.MstCostumeShopItemGroup>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <DisplayOrder>k__BackingField;
    public int Id { get; set; }
    public int DisplayOrder { get; set; }
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstCostumeShopItemGroup& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstCostumeShopItemGroup& value);

    private class MstCostumeShopItemGroupFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstCostumeShopItemGroup>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstCostumeShopItemGroup& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstCostumeShopItemGroup& value);
    }
}

// Namespace: PRISM.Definitions
public class MstDressOrderRecipe : System.IComparable<PRISM.Definitions.MstDressOrderRecipe>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstDressOrderRecipe>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <MstUnitId>k__BackingField;
    private int <CostumeType>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<string> <RecipeList>k__BackingField;
    public int Id { get; set; }
    public int MstUnitId { get; set; }
    public int CostumeType { get; set; }
    public System.Collections.Generic.IReadOnlyList<string> RecipeList { get; set; }
    public int CompareTo(PRISM.Definitions.MstDressOrderRecipe other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstDressOrderRecipe& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstDressOrderRecipe& value);

    private class MstDressOrderRecipeFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstDressOrderRecipe>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstDressOrderRecipe& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstDressOrderRecipe& value);
    }
}

// Namespace: PRISM.Definitions
public class MstDressUpRoomVoice : System.IComparable<PRISM.Definitions.MstDressUpRoomVoice>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstDressUpRoomVoice>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <MstCharacterInfoId>k__BackingField;
    private int <VoiceType>k__BackingField;
    private int <MstVoiceResourceId>k__BackingField;
    private System.DateTime <ReleaseDate>k__BackingField;
    public int Id { get; set; }
    public int MstCharacterInfoId { get; set; }
    public int VoiceType { get; set; }
    public int MstVoiceResourceId { get; set; }
    public System.DateTime ReleaseDate { get; set; }
    public int CompareTo(PRISM.Definitions.MstDressUpRoomVoice other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstDressUpRoomVoice& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstDressUpRoomVoice& value);

    private class MstDressUpRoomVoiceFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstDressUpRoomVoice>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstDressUpRoomVoice& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstDressUpRoomVoice& value);
    }
}

// Namespace: PRISM.Definitions
public class MstEpisode : System.IComparable<PRISM.Definitions.MstEpisode>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstEpisode>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <MstUnitId>k__BackingField;
    private int <Chapter>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<int> <MstProduceIdolIdList>k__BackingField;
    public int Id { get; set; }
    public int MstUnitId { get; set; }
    public int Chapter { get; set; }
    public System.Collections.Generic.IReadOnlyList<int> MstProduceIdolIdList { get; set; }
    public PRISM.Definitions.LocalizationKey Title { get; set; }
    public PRISM.Definitions.LocalizationKey MvName { get; set; }
    public string CircleThumbnailPath { get; set; }
    public string RectThumbnailPath { get; set; }
    public string RectThumbnailForStoryEpisodeSelectPath { get; set; }
    public string RectThumbnailForStorySelectPath { get; set; }
    public string StoryBackgroundPath { get; set; }
    public int CompareTo(PRISM.Definitions.MstEpisode other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstEpisode& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstEpisode& value);

    private class MstEpisodeFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstEpisode>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstEpisode& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstEpisode& value);
    }
}

// Namespace: PRISM.Definitions
public class MstEpisodeEventMissionBanner : System.IComparable<PRISM.Definitions.MstEpisodeEventMissionBanner>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstEpisodeEventMissionBanner>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    public int Id { get; set; }
    public string BannerPath { get; set; }
    public int CompareTo(PRISM.Definitions.MstEpisodeEventMissionBanner other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstEpisodeEventMissionBanner& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstEpisodeEventMissionBanner& value);

    private class MstEpisodeEventMissionBannerFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstEpisodeEventMissionBanner>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstEpisodeEventMissionBanner& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstEpisodeEventMissionBanner& value);
    }
}

// Namespace: PRISM.Definitions
public class MstEpisodeZeroStory : System.IComparable<PRISM.Definitions.MstEpisodeZeroStory>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstEpisodeZeroStory>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private string <MstAdvInfoId>k__BackingField;
    private int <SortId>k__BackingField;
    private int <MstIdolId>k__BackingField;
    private int <ScenarioNumber>k__BackingField;
    private int <EpisodeNumber>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<int> <MstCharacterInfoIdList>k__BackingField;
    private int <UnlockPremiseMstEpisodeZeroStoryId>k__BackingField;
    private System.DateTime <ReleaseDate>k__BackingField;
    private int <PreviousMstEpisodeZeroStoryId>k__BackingField;
    private bool <EnableCasualCostume>k__BackingField;
    private PRISM.Definitions.MstAdvInfo <AdvInfo>k__BackingField;
    public int Id { get; set; }
    public string MstAdvInfoId { get; set; }
    public int SortId { get; set; }
    public int MstIdolId { get; set; }
    public int ScenarioNumber { get; set; }
    public int EpisodeNumber { get; set; }
    public System.Collections.Generic.IReadOnlyList<int> MstCharacterInfoIdList { get; set; }
    public int UnlockPremiseMstEpisodeZeroStoryId { get; set; }
    public System.DateTime ReleaseDate { get; set; }
    public int PreviousMstEpisodeZeroStoryId { get; set; }
    public bool EnableCasualCostume { get; set; }
    public string ThumbnailPath { get; set; }
    public PRISM.Definitions.MstAdvInfo AdvInfo { get; set; }
    public int CompareTo(PRISM.Definitions.MstEpisodeZeroStory other);
    public int CompareTo(int key);
    public void BindReferences(PRISM.Definitions.MasterData masterData);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstEpisodeZeroStory& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstEpisodeZeroStory& value);

    private class MstEpisodeZeroStoryFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstEpisodeZeroStory>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstEpisodeZeroStory& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstEpisodeZeroStory& value);
    }
}

// Namespace: PRISM.Definitions
public class MstEvent : System.IComparable<PRISM.Definitions.MstEvent>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstEvent>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <EventType>k__BackingField;
    private int <EventNumber>k__BackingField;
    private bool <HasStory>k__BackingField;
    private int <MstUnitId>k__BackingField;
    private System.DateTime <BeginDate>k__BackingField;
    private System.DateTime <EndDate>k__BackingField;
    private System.DateTime <DisplayEndDate>k__BackingField;
    private bool <IsProduce>k__BackingField;
    private bool <IsLive>k__BackingField;
    private int <CharacterImageCount>k__BackingField;
    private string <ResultImageKey>k__BackingField;
    private int <LinkedMstEventId>k__BackingField;
    public int Id { get; set; }
    public PRISM.Definitions.LocalizationKey Title { get; set; }
    public int EventType { get; set; }
    public int EventNumber { get; set; }
    public bool HasStory { get; set; }
    public int MstUnitId { get; set; }
    public System.DateTime BeginDate { get; set; }
    public System.DateTime EndDate { get; set; }
    public System.DateTime DisplayEndDate { get; set; }
    public bool IsProduce { get; set; }
    public bool IsLive { get; set; }
    public int CharacterImageCount { get; set; }
    public string ResultImageKey { get; set; }
    public int LinkedMstEventId { get; set; }
    public string LiveEventBannerPath { get; set; }
    public string BackgroundPath { get; set; }
    public string MoviePath { get; set; }
    public string BgmName { get; set; }
    public string EventStoryCategoryThumbnailPath { get; set; }
    public string EventStoryBackgroundPath { get; set; }
    public string LiveResultImagePath { get; set; }
    public string AllSongResultImagePath { get; set; }
    public string TechnicalChallengeResultImagePath { get; set; }
    public string TechnicalChallengeBannerPath { get; set; }
    public string LogoPath { get; set; }
    public string GetCharacterPrefabPath(int index);
    public string GetAllSongCharacterImagePath(int characterId);
    public int CompareTo(PRISM.Definitions.MstEvent other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstEvent& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstEvent& value);

    private class MstEventFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstEvent>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstEvent& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstEvent& value);
    }
}

// Namespace: PRISM.Definitions
public class MstEventAlbum : System.IComparable<PRISM.Definitions.MstEventAlbum>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstEventAlbum>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    public int Id { get; set; }
    public string ImagePath { get; set; }
    public int CompareTo(PRISM.Definitions.MstEventAlbum other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstEventAlbum& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstEventAlbum& value);

    private class MstEventAlbumFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstEventAlbum>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstEventAlbum& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstEventAlbum& value);
    }
}

// Namespace: PRISM.Definitions
public class MstEventIcon : System.IComparable<PRISM.Definitions.MstEventIcon>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstEventIcon>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private string <ImageResourceId>k__BackingField;
    private string <Text>k__BackingField;
    public int Id { get; set; }
    public string ImageResourceId { get; set; }
    public string Text { get; set; }
    public int CompareTo(PRISM.Definitions.MstEventIcon other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstEventIcon& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstEventIcon& value);

    private class MstEventIconFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstEventIcon>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstEventIcon& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstEventIcon& value);
    }
}

// Namespace: PRISM.Definitions
public class MstEventItem : System.IComparable<PRISM.Definitions.MstEventItem>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstEventItem>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <MstEventId>k__BackingField;
    public int Id { get; set; }
    public int MstEventId { get; set; }
    public int CompareTo(PRISM.Definitions.MstEventItem other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstEventItem& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstEventItem& value);

    private class MstEventItemFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstEventItem>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstEventItem& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstEventItem& value);
    }
}

// Namespace: PRISM.Definitions
public class MstEventRanking : System.IComparable<PRISM.Definitions.MstEventRanking>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstEventRanking>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <MstEventId>k__BackingField;
    private int <EventRankingType>k__BackingField;
    private int <MstIdolId>k__BackingField;
    private int <DifficultyLevel>k__BackingField;
    private int <CommentNumber>k__BackingField;
    public int Id { get; set; }
    public int MstEventId { get; set; }
    public int EventRankingType { get; set; }
    public int MstIdolId { get; set; }
    public int DifficultyLevel { get; set; }
    public int CommentNumber { get; set; }
    public int CompareTo(PRISM.Definitions.MstEventRanking other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstEventRanking& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstEventRanking& value);

    private class MstEventRankingFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstEventRanking>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstEventRanking& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstEventRanking& value);
    }
}

// Namespace: PRISM.Definitions
public class MstEventSong : System.IComparable<PRISM.Definitions.MstEventSong>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstEventSong>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <MstSongId>k__BackingField;
    public int Id { get; set; }
    public int MstSongId { get; set; }
    public int CompareTo(PRISM.Definitions.MstEventSong other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstEventSong& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstEventSong& value);

    private class MstEventSongFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstEventSong>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstEventSong& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstEventSong& value);
    }
}

// Namespace: PRISM.Definitions
public class MstEventStory : System.IComparable<PRISM.Definitions.MstEventStory>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstEventStory>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <EpisodeNumber>k__BackingField;
    private int <ScenarioNumber>k__BackingField;
    private int <MstUnitId>k__BackingField;
    private int <MstEventId>k__BackingField;
    private int <SortId>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<int> <MstCharacterInfoIdList>k__BackingField;
    private int <UnlockPremiseEventPoint>k__BackingField;
    private System.DateTime <ReleaseDate>k__BackingField;
    private PRISM.Definitions.MstEvent <MstEvent>k__BackingField;
    public int Id { get; set; }
    public PRISM.Definitions.LocalizationKey Title { get; set; }
    public int EpisodeNumber { get; set; }
    public int ScenarioNumber { get; set; }
    public int MstUnitId { get; set; }
    public int MstEventId { get; set; }
    public int SortId { get; set; }
    public System.Collections.Generic.IReadOnlyList<int> MstCharacterInfoIdList { get; set; }
    public int UnlockPremiseEventPoint { get; set; }
    public System.DateTime ReleaseDate { get; set; }
    public string ThumbnailPath { get; set; }
    public PRISM.Definitions.MstEvent MstEvent { get; set; }
    public int CompareTo(PRISM.Definitions.MstEventStory other);
    public int CompareTo(int key);
    public void BindReferences(PRISM.Definitions.MasterData masterData);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstEventStory& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstEventStory& value);

    private class MstEventStoryFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstEventStory>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstEventStory& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstEventStory& value);
    }
}

// Namespace: PRISM.Definitions
public class MstExchangeProduct : MemoryPack.IMemoryPackable<PRISM.Definitions.MstExchangeProduct>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private string <ProductIdWithAmount>k__BackingField;
    private System.DateTime <BeginDate>k__BackingField;
    private System.DateTime <EndDate>k__BackingField;
    public int Id { get; set; }
    public string ProductIdWithAmount { get; set; }
    public System.DateTime BeginDate { get; set; }
    public System.DateTime EndDate { get; set; }
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstExchangeProduct& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstExchangeProduct& value);

    private class MstExchangeProductFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstExchangeProduct>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstExchangeProduct& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstExchangeProduct& value);
    }
}

// Namespace: PRISM.Definitions
public class MstExchangeProductFilter : MemoryPack.IMemoryPackable<PRISM.Definitions.MstExchangeProductFilter>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    public int Id { get; set; }
    public PRISM.Definitions.LocalizationKey Name { get; set; }
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstExchangeProductFilter& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstExchangeProductFilter& value);

    private class MstExchangeProductFilterFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstExchangeProductFilter>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstExchangeProductFilter& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstExchangeProductFilter& value);
    }
}

// Namespace: PRISM.Definitions
public class MstExtraStory : System.IComparable<PRISM.Definitions.MstExtraStory>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstExtraStory>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <EpisodeNumber>k__BackingField;
    private int <MstExtraStorySubCategoryId>k__BackingField;
    private int <SortId>k__BackingField;
    private string <ScenarioId>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<int> <MstCharacterInfoIdList>k__BackingField;
    private System.DateTime <ReleaseDate>k__BackingField;
    private System.DateTime <UnlockDate>k__BackingField;
    private bool <HasUnlockDate>k__BackingField;
    private PRISM.Definitions.MstExtraStorySubCategory <MstExtraStorySubCategory>k__BackingField;
    public int Id { get; set; }
    public PRISM.Definitions.LocalizationKey Title { get; set; }
    public int EpisodeNumber { get; set; }
    public int MstExtraStorySubCategoryId { get; set; }
    public int SortId { get; set; }
    public string ScenarioId { get; set; }
    public System.Collections.Generic.IReadOnlyList<int> MstCharacterInfoIdList { get; set; }
    public System.DateTime ReleaseDate { get; set; }
    public System.DateTime UnlockDate { get; set; }
    public bool HasUnlockDate { get; set; }
    public string ThumbnailPath { get; set; }
    public PRISM.Definitions.MstExtraStorySubCategory MstExtraStorySubCategory { get; set; }
    public bool HasEpisodeNumber { get; set; }
    public int CompareTo(PRISM.Definitions.MstExtraStory other);
    public int CompareTo(int key);
    public void BindReferences(PRISM.Definitions.MasterData masterData);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstExtraStory& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstExtraStory& value);

    private class MstExtraStoryFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstExtraStory>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstExtraStory& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstExtraStory& value);
    }
}

// Namespace: PRISM.Definitions
public class MstExtraStoryCategory : System.IComparable<PRISM.Definitions.MstExtraStoryCategory>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstExtraStoryCategory>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <SortId>k__BackingField;
    public int Id { get; set; }
    public PRISM.Definitions.LocalizationKey Title { get; set; }
    public int SortId { get; set; }
    public string ThumbnailPath { get; set; }
    public int CompareTo(PRISM.Definitions.MstExtraStoryCategory other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstExtraStoryCategory& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstExtraStoryCategory& value);

    private class MstExtraStoryCategoryFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstExtraStoryCategory>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstExtraStoryCategory& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstExtraStoryCategory& value);
    }
}

// Namespace: PRISM.Definitions
public class MstExtraStorySubCategory : System.IComparable<PRISM.Definitions.MstExtraStorySubCategory>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstExtraStorySubCategory>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <MstExtraStoryCategoryId>k__BackingField;
    private int <SortId>k__BackingField;
    private int <JumpType>k__BackingField;
    private PRISM.Definitions.MstExtraStoryCategory <MstExtraStoryCategory>k__BackingField;
    public int Id { get; set; }
    public PRISM.Definitions.LocalizationKey Title { get; set; }
    public int MstExtraStoryCategoryId { get; set; }
    public int SortId { get; set; }
    public int JumpType { get; set; }
    public string ThumbnailPath { get; set; }
    public string ExtraStoryBackgroundPath { get; set; }
    public PRISM.Definitions.MstExtraStoryCategory MstExtraStoryCategory { get; set; }
    public PRISM.Definitions.ExtraStorySubCategoryJumpType GetJumpType();
    public int CompareTo(PRISM.Definitions.MstExtraStorySubCategory other);
    public int CompareTo(int key);
    public void BindReferences(PRISM.Definitions.MasterData masterData);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstExtraStorySubCategory& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstExtraStorySubCategory& value);

    private class MstExtraStorySubCategoryFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstExtraStorySubCategory>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstExtraStorySubCategory& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstExtraStorySubCategory& value);
    }
}

// Namespace: PRISM.Definitions
public enum ExtraStorySubCategoryJumpType : System.Enum
{
    public int value__;
    public static PRISM.Definitions.ExtraStorySubCategoryJumpType ExtraStory;
    public static PRISM.Definitions.ExtraStorySubCategoryJumpType ProducerBirthday;
}

// Namespace: PRISM.Definitions
public class MstFavoriteMark : MemoryPack.IMemoryPackable<PRISM.Definitions.MstFavoriteMark>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    public int Id { get; set; }
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstFavoriteMark& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstFavoriteMark& value);

    private class MstFavoriteMarkFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstFavoriteMark>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstFavoriteMark& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstFavoriteMark& value);
    }
}

// Namespace: PRISM.Definitions
public class MstFavoriteSchedule : System.IComparable<PRISM.Definitions.MstFavoriteSchedule>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstFavoriteSchedule>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <ScheduleDetailType>k__BackingField;
    private int <EntrustAppealType>k__BackingField;
    private int <EntrustScore>k__BackingField;
    public int ScheduleDetailType { get; set; }
    public int EntrustAppealType { get; set; }
    public int EntrustScore { get; set; }
    public int CompareTo(PRISM.Definitions.MstFavoriteSchedule other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstFavoriteSchedule& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstFavoriteSchedule& value);

    private class MstFavoriteScheduleFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstFavoriteSchedule>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstFavoriteSchedule& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstFavoriteSchedule& value);
    }
}

// Namespace: PRISM.Definitions
public class MstFirstProduceIdol : System.IComparable<PRISM.Definitions.MstFirstProduceIdol>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstFirstProduceIdol>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <MstProduceIdolId>k__BackingField;
    private int <MstVoiceResourceId>k__BackingField;
    private string <VoiceText>k__BackingField;
    private int <SortId>k__BackingField;
    private PRISM.Definitions.MstProduceIdol <ProduceIdol>k__BackingField;
    private PRISM.Definitions.MstVoiceResource <VoiceResource>k__BackingField;
    public int Id { get; set; }
    public int MstProduceIdolId { get; set; }
    public int MstVoiceResourceId { get; set; }
    public string VoiceText { get; set; }
    public int SortId { get; set; }
    public PRISM.Definitions.MstProduceIdol ProduceIdol { get; set; }
    public PRISM.Definitions.MstVoiceResource VoiceResource { get; set; }
    public string DescriptionCellPrefabPath { get; set; }
    public int CompareTo(PRISM.Definitions.MstFirstProduceIdol other);
    public int CompareTo(int key);
    public void BindReferences(PRISM.Definitions.MasterData masterData);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstFirstProduceIdol& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstFirstProduceIdol& value);

    private class MstFirstProduceIdolFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstFirstProduceIdol>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstFirstProduceIdol& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstFirstProduceIdol& value);
    }
}

// Namespace: PRISM.Definitions
public class MstGalleryEtcCategory : System.IComparable<PRISM.Definitions.MstGalleryEtcCategory>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstGalleryEtcCategory>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <DisplayPriority>k__BackingField;
    public int Id { get; set; }
    public PRISM.Definitions.LocalizationKey Name { get; set; }
    public int DisplayPriority { get; set; }
    public int CompareTo(PRISM.Definitions.MstGalleryEtcCategory other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstGalleryEtcCategory& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstGalleryEtcCategory& value);

    private class MstGalleryEtcCategoryFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstGalleryEtcCategory>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstGalleryEtcCategory& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstGalleryEtcCategory& value);
    }
}

// Namespace: PRISM.Definitions
public class MstGashaResource : System.IComparable<PRISM.Definitions.MstGashaResource>, System.IComparable<string>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstGashaResource>, MemoryPack.IMemoryPackFormatterRegister
{
    private string <Id>k__BackingField;
    private string <LogoImage>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<string> <MovieList>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<string> <MovieValueList>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<string> <ImageList>k__BackingField;
    private string <StepCatchphraseImage>k__BackingField;
    public string Id { get; set; }
    public string LogoImage { get; set; }
    public System.Collections.Generic.IReadOnlyList<string> MovieList { get; set; }
    public System.Collections.Generic.IReadOnlyList<string> MovieValueList { get; set; }
    public System.Collections.Generic.IReadOnlyList<string> ImageList { get; set; }
    public string StepCatchphraseImage { get; set; }
    public int CompareTo(PRISM.Definitions.MstGashaResource other);
    public int CompareTo(string key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstGashaResource& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstGashaResource& value);

    private class MstGashaResourceFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstGashaResource>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstGashaResource& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstGashaResource& value);
    }
}

// Namespace: PRISM.Definitions
public class MstGashaTicket : System.IComparable<PRISM.Definitions.MstGashaTicket>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstGashaTicket>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<string> <GashaResourceIdList>k__BackingField;
    public int Id { get; set; }
    public System.Collections.Generic.IReadOnlyList<string> GashaResourceIdList { get; set; }
    public int CompareTo(PRISM.Definitions.MstGashaTicket other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstGashaTicket& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstGashaTicket& value);

    private class MstGashaTicketFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstGashaTicket>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstGashaTicket& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstGashaTicket& value);
    }
}

// Namespace: PRISM.Definitions
public class MstGiftEventReward : MemoryPack.IMemoryPackable<PRISM.Definitions.MstGiftEventReward>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <MstCharacterInfoId>k__BackingField;
    private int <MstGiftEventTokenId>k__BackingField;
    private int <RequirePoint>k__BackingField;
    private string <Reward>k__BackingField;
    public int MstCharacterInfoId { get; set; }
    public int MstGiftEventTokenId { get; set; }
    public int RequirePoint { get; set; }
    public string Reward { get; set; }
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstGiftEventReward& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstGiftEventReward& value);

    private class MstGiftEventRewardFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstGiftEventReward>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstGiftEventReward& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstGiftEventReward& value);
    }
}

// Namespace: PRISM.Definitions
public class MstGiftEventTokenRelation : System.IComparable<PRISM.Definitions.MstGiftEventTokenRelation>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstGiftEventTokenRelation>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <MstEventId>k__BackingField;
    private int <MstGiftEventTokenId>k__BackingField;
    public int MstEventId { get; set; }
    public int MstGiftEventTokenId { get; set; }
    public int CompareTo(PRISM.Definitions.MstGiftEventTokenRelation other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstGiftEventTokenRelation& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstGiftEventTokenRelation& value);

    private class MstGiftEventTokenRelationFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstGiftEventTokenRelation>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstGiftEventTokenRelation& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstGiftEventTokenRelation& value);
    }
}

// Namespace: PRISM.Definitions
public class MstHairstyle : PRISM.Definitions.IMstCostumePart, System.IComparable<PRISM.Definitions.MstHairstyle>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstHairstyle>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <MstCharacterInfoId>k__BackingField;
    private int <CostumeType>k__BackingField;
    private int <HairResourceIdForClient>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<int> <HairAccessoryResourceIdListForClient>k__BackingField;
    private PRISM.Definitions.MstCharacterInfo <CharacterInfo>k__BackingField;
    private PRISM.Definitions.MstHairstyleResource <HairResource>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<PRISM.Definitions.MstAccessoryResource> <HairAccessoryResources>k__BackingField;
    public int Id { get; set; }
    public PRISM.Definitions.LocalizationKey Name { get; set; }
    public PRISM.Definitions.LocalizationKey Description { get; set; }
    public PRISM.Definitions.LocalizationKey UnlockPremise { get; set; }
    public bool IsDressOrderTarget { get; set; }
    public System.DateTime DressOrderBeginDate { get; set; }
    public int MstCharacterInfoId { get; set; }
    public int CostumeType { get; set; }
    public int HairResourceIdForClient { get; set; }
    public System.Collections.Generic.IReadOnlyList<int> HairAccessoryResourceIdListForClient { get; set; }
    public PRISM.Definitions.MstCharacterInfo CharacterInfo { get; set; }
    public PRISM.Definitions.MstHairstyleResource HairResource { get; set; }
    public System.Collections.Generic.IReadOnlyList<PRISM.Definitions.MstAccessoryResource> HairAccessoryResources { get; set; }
    public int CompareTo(PRISM.Definitions.MstHairstyle other);
    public int CompareTo(int key);
    public void BindReferences(PRISM.Definitions.MasterData masterData);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstHairstyle& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstHairstyle& value);

    private class MstHairstyleFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstHairstyle>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstHairstyle& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstHairstyle& value);
    }

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Definitions.MstAccessoryResource, bool> <>9__44_0;
        private bool <BindReferences>b__44_0(PRISM.Definitions.MstAccessoryResource x);
    }
}

// Namespace: PRISM.Definitions
public class MstHairstyleDifferent : PRISM.Definitions.IMstCostumeDifference, MemoryPack.IMemoryPackable<PRISM.Definitions.MstHairstyleDifferent>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <MstOriginalHairstyleId>k__BackingField;
    private int <MstHairstyleId>k__BackingField;
    public int MstOriginalHairstyleId { get; set; }
    public int MstHairstyleId { get; set; }
    public int MstOriginalId { get; set; }
    public int MstDifferenceId { get; set; }
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstHairstyleDifferent& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstHairstyleDifferent& value);

    private class MstHairstyleDifferentFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstHairstyleDifferent>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstHairstyleDifferent& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstHairstyleDifferent& value);
    }
}

// Namespace: PRISM.Definitions
public class MstHairstyleResource : System.IComparable<PRISM.Definitions.MstHairstyleResource>, System.IComparable<System.ValueTuple<int, int>>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstHairstyleResource>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <MstCharacterInfoId>k__BackingField;
    private int <StyleType>k__BackingField;
    private int <HairId>k__BackingField;
    private int <HeadWearId>k__BackingField;
    public int MstCharacterInfoId { get; set; }
    public int StyleType { get; set; }
    public int HairId { get; set; }
    public int HeadWearId { get; set; }
    public int CompareTo(PRISM.Definitions.MstHairstyleResource other);
    public int CompareTo(System.ValueTuple<int, int> key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstHairstyleResource& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstHairstyleResource& value);

    private class MstHairstyleResourceFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstHairstyleResource>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstHairstyleResource& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstHairstyleResource& value);
    }
}

// Namespace: PRISM.Definitions
public class MstHelp : MemoryPack.IMemoryPackable<PRISM.Definitions.MstHelp>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <MstHelpGroupId>k__BackingField;
    private bool <IsMobile>k__BackingField;
    private bool <IsGpg>k__BackingField;
    private bool <IsDmm>k__BackingField;
    public int Id { get; set; }
    public int MstHelpGroupId { get; set; }
    public PRISM.Definitions.LocalizationKey HelpTitle { get; set; }
    public PRISM.Definitions.LocalizationKey HelpBody { get; set; }
    public bool IsMobile { get; set; }
    public bool IsGpg { get; set; }
    public bool IsDmm { get; set; }
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstHelp& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstHelp& value);

    private class MstHelpFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstHelp>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstHelp& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstHelp& value);
    }
}

// Namespace: PRISM.Definitions
public class MstHelpGroup : MemoryPack.IMemoryPackable<PRISM.Definitions.MstHelpGroup>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <HelpType>k__BackingField;
    private System.DateTime <BeginDate>k__BackingField;
    private System.DateTime <EndDate>k__BackingField;
    public int Id { get; set; }
    public PRISM.Definitions.LocalizationKey HelpGroupTitle { get; set; }
    public int HelpType { get; set; }
    public System.DateTime BeginDate { get; set; }
    public System.DateTime EndDate { get; set; }
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstHelpGroup& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstHelpGroup& value);

    private class MstHelpGroupFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstHelpGroup>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstHelpGroup& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstHelpGroup& value);
    }
}

// Namespace: PRISM.Definitions
public class MstIdol : System.IComparable<PRISM.Definitions.MstIdol>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstIdol>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <MstDefaultLiveCostumeSetId>k__BackingField;
    private PRISM.Definitions.MstCostumeSet <DefaultLiveCostumeSet>k__BackingField;
    public int Id { get; set; }
    public int MstDefaultLiveCostumeSetId { get; set; }
    public PRISM.Definitions.MstCostumeSet DefaultLiveCostumeSet { get; set; }
    public int CompareTo(PRISM.Definitions.MstIdol other);
    public int CompareTo(int key);
    public void BindReferences(PRISM.Definitions.MasterData masterData);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstIdol& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstIdol& value);

    private class MstIdolFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstIdol>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstIdol& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstIdol& value);
    }
}

// Namespace: PRISM.Definitions
public class MstIdolSkill : System.IComparable<PRISM.Definitions.MstIdolSkill>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstIdolSkill>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<int> <AppealTypeList>k__BackingField;
    public int Id { get; set; }
    public PRISM.Definitions.LocalizationKey Description { get; set; }
    public System.Collections.Generic.IReadOnlyList<int> AppealTypeList { get; set; }
    public int CompareTo(PRISM.Definitions.MstIdolSkill other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstIdolSkill& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstIdolSkill& value);

    private class MstIdolSkillFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstIdolSkill>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstIdolSkill& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstIdolSkill& value);
    }
}

// Namespace: PRISM.Definitions
public class MstIdolSkillEffect : MemoryPack.IMemoryPackable<PRISM.Definitions.MstIdolSkillEffect>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <MstIdolSkillId>k__BackingField;
    private int <Level>k__BackingField;
    private int <Cost>k__BackingField;
    private int <UnlockPremiseStar>k__BackingField;
    private int <UsableCount>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<int> <MstProduceActionEffectIdList>k__BackingField;
    private int <MstProduceActionConditionTypeId>k__BackingField;
    private int <ConditionValue>k__BackingField;
    private int <StrengthScore>k__BackingField;
    public int Id { get; set; }
    public int MstIdolSkillId { get; set; }
    public int Level { get; set; }
    public int Cost { get; set; }
    public int UnlockPremiseStar { get; set; }
    public int UsableCount { get; set; }
    public System.Collections.Generic.IReadOnlyList<int> MstProduceActionEffectIdList { get; set; }
    public int MstProduceActionConditionTypeId { get; set; }
    public int ConditionValue { get; set; }
    public int StrengthScore { get; set; }
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstIdolSkillEffect& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstIdolSkillEffect& value);

    private class MstIdolSkillEffectFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstIdolSkillEffect>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstIdolSkillEffect& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstIdolSkillEffect& value);
    }
}

// Namespace: PRISM.Definitions
public class MstIdolSkillLevelUpRecipe : System.IComparable<PRISM.Definitions.MstIdolSkillLevelUpRecipe>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstIdolSkillLevelUpRecipe>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Level>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<string> <ProductIdWithAmountList>k__BackingField;
    private int <Money>k__BackingField;
    public int Level { get; set; }
    public System.Collections.Generic.IReadOnlyList<string> ProductIdWithAmountList { get; set; }
    public int Money { get; set; }
    public int CompareTo(PRISM.Definitions.MstIdolSkillLevelUpRecipe other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstIdolSkillLevelUpRecipe& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstIdolSkillLevelUpRecipe& value);

    private class MstIdolSkillLevelUpRecipeFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstIdolSkillLevelUpRecipe>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstIdolSkillLevelUpRecipe& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstIdolSkillLevelUpRecipe& value);
    }
}

// Namespace: PRISM.Definitions
public class MstIdolStandingPosition : System.IComparable<PRISM.Definitions.MstIdolStandingPosition>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstIdolStandingPosition>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <MstUnitId>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<int> <Order>k__BackingField;
    public int MstUnitId { get; set; }
    public System.Collections.Generic.IReadOnlyList<int> Order { get; set; }
    public int CompareTo(PRISM.Definitions.MstIdolStandingPosition other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstIdolStandingPosition& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstIdolStandingPosition& value);

    private class MstIdolStandingPositionFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstIdolStandingPosition>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstIdolStandingPosition& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstIdolStandingPosition& value);
    }
}

// Namespace: PRISM.Definitions
public class MstIdolStory : System.IComparable<PRISM.Definitions.MstIdolStory>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstIdolStory>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <EpisodeNumber>k__BackingField;
    private int <MstIdolId>k__BackingField;
    private int <SortId>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<int> <MstCharacterInfoIdList>k__BackingField;
    private int <UnlockPremiseIdolBaseDearness>k__BackingField;
    private System.DateTime <ReleaseDate>k__BackingField;
    public int Id { get; set; }
    public PRISM.Definitions.LocalizationKey Title { get; set; }
    public int EpisodeNumber { get; set; }
    public int MstIdolId { get; set; }
    public int SortId { get; set; }
    public System.Collections.Generic.IReadOnlyList<int> MstCharacterInfoIdList { get; set; }
    public int UnlockPremiseIdolBaseDearness { get; set; }
    public System.DateTime ReleaseDate { get; set; }
    public string ThumbnailPath { get; set; }
    public int CompareTo(PRISM.Definitions.MstIdolStory other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstIdolStory& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstIdolStory& value);

    private class MstIdolStoryFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstIdolStory>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstIdolStory& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstIdolStory& value);
    }
}

// Namespace: PRISM.Definitions
public class MstItemPack : System.IComparable<PRISM.Definitions.MstItemPack>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstItemPack>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<string> <ProductIdWithAmountList>k__BackingField;
    public int Id { get; set; }
    public System.Collections.Generic.IReadOnlyList<string> ProductIdWithAmountList { get; set; }
    public int CompareTo(PRISM.Definitions.MstItemPack other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstItemPack& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstItemPack& value);

    private class MstItemPackFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstItemPack>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstItemPack& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstItemPack& value);
    }
}

// Namespace: PRISM.Definitions
public class MstItemProvider : MemoryPack.IMemoryPackable<PRISM.Definitions.MstItemProvider>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private string <ProductId>k__BackingField;
    private int <ProviderType>k__BackingField;
    private string <ProviderParameter>k__BackingField;
    public int Id { get; set; }
    public string ProductId { get; set; }
    public int ProviderType { get; set; }
    public string ProviderParameter { get; set; }
    public PRISM.Definitions.LocalizationKey ScreenTitle { get; set; }
    public PRISM.Definitions.LocalizationKey ScreenTab { get; set; }
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstItemProvider& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstItemProvider& value);

    private class MstItemProviderFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstItemProvider>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstItemProvider& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstItemProvider& value);
    }
}

// Namespace: PRISM.Definitions
public class MstLetter : System.IComparable<PRISM.Definitions.MstLetter>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstLetter>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <MstLetterGroupId>k__BackingField;
    private int <MstUnitId>k__BackingField;
    private string <ResourceId>k__BackingField;
    private System.DateTime <GalleryReleaseDate>k__BackingField;
    public int Id { get; set; }
    public int MstLetterGroupId { get; set; }
    public int MstUnitId { get; set; }
    public string ResourceId { get; set; }
    public System.DateTime GalleryReleaseDate { get; set; }
    public string UnitLetterImagePath { get; set; }
    public int CompareTo(PRISM.Definitions.MstLetter other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstLetter& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstLetter& value);

    private class MstLetterFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstLetter>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstLetter& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstLetter& value);
    }
}

// Namespace: PRISM.Definitions
public class MstLetterGroup : System.IComparable<PRISM.Definitions.MstLetterGroup>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstLetterGroup>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private string <Name>k__BackingField;
    public int Id { get; set; }
    public string Name { get; set; }
    public static int GetLetterGroupId(PRISM.Definitions.LetterGroupType letterGroupType);
    public int CompareTo(PRISM.Definitions.MstLetterGroup other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstLetterGroup& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstLetterGroup& value);

    private class MstLetterGroupFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstLetterGroup>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstLetterGroup& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstLetterGroup& value);
    }
}

// Namespace: PRISM.Definitions
public enum LetterGroupType : System.Enum
{
    public int value__;
    public static PRISM.Definitions.LetterGroupType ValentineDay;
    public static PRISM.Definitions.LetterGroupType WhiteDay;
}

// Namespace: PRISM.Definitions
public class MstLiveCenterEffect : System.IComparable<PRISM.Definitions.MstLiveCenterEffect>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstLiveCenterEffect>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<int> <DetailIdList>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<PRISM.Definitions.MstLiveCenterEffectDetail> <DetailList>k__BackingField;
    public int Id { get; set; }
    public PRISM.Definitions.LocalizationKey Title { get; set; }
    public PRISM.Definitions.LocalizationKey Description { get; set; }
    public System.Collections.Generic.IReadOnlyList<int> DetailIdList { get; set; }
    public System.Collections.Generic.IReadOnlyList<PRISM.Definitions.MstLiveCenterEffectDetail> DetailList { get; set; }
    public int CompareTo(PRISM.Definitions.MstLiveCenterEffect other);
    public int CompareTo(int key);
    public void BindReferences(PRISM.Definitions.MasterData masterData);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstLiveCenterEffect& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstLiveCenterEffect& value);

    private class MstLiveCenterEffectFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstLiveCenterEffect>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstLiveCenterEffect& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstLiveCenterEffect& value);
    }
}

// Namespace: PRISM.Definitions
public class MstLiveCenterEffectDetail : System.IComparable<PRISM.Definitions.MstLiveCenterEffectDetail>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstLiveCenterEffectDetail>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <EffectType>k__BackingField;
    private int <EffectValue>k__BackingField;
    private int <ConditionType>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<int> <ConditionIdList>k__BackingField;
    public int Id { get; set; }
    public int EffectType { get; set; }
    public int EffectValue { get; set; }
    public int ConditionType { get; set; }
    public System.Collections.Generic.IReadOnlyList<int> ConditionIdList { get; set; }
    public int CompareTo(PRISM.Definitions.MstLiveCenterEffectDetail other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstLiveCenterEffectDetail& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstLiveCenterEffectDetail& value);

    private class MstLiveCenterEffectDetailFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstLiveCenterEffectDetail>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstLiveCenterEffectDetail& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstLiveCenterEffectDetail& value);
    }
}

// Namespace: PRISM.Definitions
public class MstLiveComboRankReward : System.IComparable<PRISM.Definitions.MstLiveComboRankReward>, System.IComparable<System.ValueTuple<int, int>>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstLiveComboRankReward>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <DifficultyLevel>k__BackingField;
    private int <ComboRank>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<string> <ProductIdWithAmountList>k__BackingField;
    public int DifficultyLevel { get; set; }
    public int ComboRank { get; set; }
    public System.Collections.Generic.IReadOnlyList<string> ProductIdWithAmountList { get; set; }
    public int CompareTo(PRISM.Definitions.MstLiveComboRankReward other);
    public int CompareTo(System.ValueTuple<int, int> key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstLiveComboRankReward& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstLiveComboRankReward& value);

    private class MstLiveComboRankRewardFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstLiveComboRankReward>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstLiveComboRankReward& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstLiveComboRankReward& value);
    }
}

// Namespace: PRISM.Definitions
public class MstLiveComboRankTarget : System.IComparable<PRISM.Definitions.MstLiveComboRankTarget>, System.IComparable<System.ValueTuple<int, int>>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstLiveComboRankTarget>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <MstSongId>k__BackingField;
    private int <DifficultyLevel>k__BackingField;
    private int <Rank2>k__BackingField;
    private int <Rank3>k__BackingField;
    private int <Rank4>k__BackingField;
    private int <Rank5>k__BackingField;
    private int <Rank6>k__BackingField;
    public int MstSongId { get; set; }
    public int DifficultyLevel { get; set; }
    public int Rank2 { get; set; }
    public int Rank3 { get; set; }
    public int Rank4 { get; set; }
    public int Rank5 { get; set; }
    public int Rank6 { get; set; }
    public int CompareTo(PRISM.Definitions.MstLiveComboRankTarget other);
    public int CompareTo(System.ValueTuple<int, int> key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstLiveComboRankTarget& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstLiveComboRankTarget& value);

    private class MstLiveComboRankTargetFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstLiveComboRankTarget>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstLiveComboRankTarget& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstLiveComboRankTarget& value);
    }
}

// Namespace: PRISM.Definitions
public class MstLiveCutScene : MemoryPack.IMemoryPackable<PRISM.Definitions.MstLiveCutScene>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <MstSongId>k__BackingField;
    private string <CutSceneName>k__BackingField;
    private PRISM.Definitions.LiveCutSceneConditionType <ConditionType>k__BackingField;
    public int Id { get; set; }
    public int MstSongId { get; set; }
    public string CutSceneName { get; set; }
    public PRISM.Definitions.LiveCutSceneConditionType ConditionType { get; set; }
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstLiveCutScene& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstLiveCutScene& value);

    private class MstLiveCutSceneFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstLiveCutScene>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstLiveCutScene& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstLiveCutScene& value);
    }
}

// Namespace: PRISM.Definitions
public enum LiveCutSceneConditionType : System.Enum
{
    public int value__;
    public static PRISM.Definitions.LiveCutSceneConditionType None;
    public static PRISM.Definitions.LiveCutSceneConditionType CenterCharacterId;
    public static PRISM.Definitions.LiveCutSceneConditionType Count;
    public static PRISM.Definitions.LiveCutSceneConditionType CenterCharacterNotMatch;
}

// Namespace: PRISM.Definitions
public class MstLiveCutSceneCostume : MemoryPack.IMemoryPackable<PRISM.Definitions.MstLiveCutSceneCostume>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <MstLiveCutSceneId>k__BackingField;
    private int <MstCostumeId>k__BackingField;
    public int MstLiveCutSceneId { get; set; }
    public int MstCostumeId { get; set; }
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstLiveCutSceneCostume& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstLiveCutSceneCostume& value);

    private class MstLiveCutSceneCostumeFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstLiveCutSceneCostume>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstLiveCutSceneCostume& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstLiveCutSceneCostume& value);
    }
}

// Namespace: PRISM.Definitions
public class MstLiveEventBonus : System.IComparable<PRISM.Definitions.MstLiveEventBonus>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstLiveEventBonus>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <MstEventId>k__BackingField;
    private int <MstProduceIdolId>k__BackingField;
    public int Id { get; set; }
    public int MstEventId { get; set; }
    public int MstProduceIdolId { get; set; }
    public int CompareTo(PRISM.Definitions.MstLiveEventBonus other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstLiveEventBonus& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstLiveEventBonus& value);

    private class MstLiveEventBonusFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstLiveEventBonus>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstLiveEventBonus& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstLiveEventBonus& value);
    }
}

// Namespace: PRISM.Definitions
public class MstLiveScoreRankReward : System.IComparable<PRISM.Definitions.MstLiveScoreRankReward>, System.IComparable<System.ValueTuple<int, int>>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstLiveScoreRankReward>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <DifficultyLevel>k__BackingField;
    private int <ScoreRank>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<string> <ProductIdWithAmountList>k__BackingField;
    public int DifficultyLevel { get; set; }
    public int ScoreRank { get; set; }
    public System.Collections.Generic.IReadOnlyList<string> ProductIdWithAmountList { get; set; }
    public int CompareTo(PRISM.Definitions.MstLiveScoreRankReward other);
    public int CompareTo(System.ValueTuple<int, int> key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstLiveScoreRankReward& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstLiveScoreRankReward& value);

    private class MstLiveScoreRankRewardFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstLiveScoreRankReward>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstLiveScoreRankReward& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstLiveScoreRankReward& value);
    }
}

// Namespace: PRISM.Definitions
public class MstLiveSkill : System.IComparable<PRISM.Definitions.MstLiveSkill>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstLiveSkill>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private bool <IsAutoActivate>k__BackingField;
    public int Id { get; set; }
    public bool IsAutoActivate { get; set; }
    public int CompareTo(PRISM.Definitions.MstLiveSkill other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstLiveSkill& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstLiveSkill& value);

    private class MstLiveSkillFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstLiveSkill>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstLiveSkill& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstLiveSkill& value);
    }
}

// Namespace: PRISM.Definitions
public class MstLiveSkillDetail : PRISM.Definitions.IMstLiveSkillDetail, System.IComparable<PRISM.Definitions.MstLiveSkillDetail>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstLiveSkillDetail>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <LiveSkillType>k__BackingField;
    private int <EffectValue>k__BackingField;
    private int <EffectValue2>k__BackingField;
    private int <EffectValue3>k__BackingField;
    private int <EffectValue4>k__BackingField;
    private int <EffectTime>k__BackingField;
    public int Id { get; set; }
    public int LiveSkillType { get; set; }
    public int EffectValue { get; set; }
    public int EffectValue2 { get; set; }
    public int EffectValue3 { get; set; }
    public int EffectValue4 { get; set; }
    public int EffectTime { get; set; }
    public int CompareTo(PRISM.Definitions.MstLiveSkillDetail other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstLiveSkillDetail& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstLiveSkillDetail& value);

    private class MstLiveSkillDetailFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstLiveSkillDetail>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstLiveSkillDetail& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstLiveSkillDetail& value);
    }
}

// Namespace: PRISM.Definitions
public interface IMstLiveSkillDetail
{
    public int LiveSkillType { get; set; }
    public int EffectValue { get; set; }
    public int EffectValue2 { get; set; }
    public int EffectValue3 { get; set; }
    public int EffectValue4 { get; set; }
    public int EffectTime { get; set; }
}

// Namespace: PRISM.Definitions
public class MstLiveSkillEffectType : System.IComparable<PRISM.Definitions.MstLiveSkillEffectType>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstLiveSkillEffectType>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private string <ValueText1>k__BackingField;
    private PRISM.Definitions.LiveSkillEffectDisplayType <ValueDisplayType1>k__BackingField;
    private string <ValueText2>k__BackingField;
    private PRISM.Definitions.LiveSkillEffectDisplayType <ValueDisplayType2>k__BackingField;
    private string <ValueText3>k__BackingField;
    private PRISM.Definitions.LiveSkillEffectDisplayType <ValueDisplayType3>k__BackingField;
    private string <ValueText4>k__BackingField;
    private PRISM.Definitions.LiveSkillEffectDisplayType <ValueDisplayType4>k__BackingField;
    private string <DurationText>k__BackingField;
    private PRISM.Definitions.LiveSkillEffectDisplayType <DurationDisplayType>k__BackingField;
    public int Id { get; set; }
    public string ValueText1 { get; set; }
    public PRISM.Definitions.LiveSkillEffectDisplayType ValueDisplayType1 { get; set; }
    public string ValueText2 { get; set; }
    public PRISM.Definitions.LiveSkillEffectDisplayType ValueDisplayType2 { get; set; }
    public string ValueText3 { get; set; }
    public PRISM.Definitions.LiveSkillEffectDisplayType ValueDisplayType3 { get; set; }
    public string ValueText4 { get; set; }
    public PRISM.Definitions.LiveSkillEffectDisplayType ValueDisplayType4 { get; set; }
    public string DurationText { get; set; }
    public PRISM.Definitions.LiveSkillEffectDisplayType DurationDisplayType { get; set; }
    public int CompareTo(PRISM.Definitions.MstLiveSkillEffectType other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstLiveSkillEffectType& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstLiveSkillEffectType& value);

    private class MstLiveSkillEffectTypeFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstLiveSkillEffectType>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstLiveSkillEffectType& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstLiveSkillEffectType& value);
    }
}

// Namespace: PRISM.Definitions
public enum LiveSkillEffectDisplayType : System.Enum
{
    public int value__;
    public static PRISM.Definitions.LiveSkillEffectDisplayType None;
    public static PRISM.Definitions.LiveSkillEffectDisplayType Percent;
    public static PRISM.Definitions.LiveSkillEffectDisplayType Time;
    public static PRISM.Definitions.LiveSkillEffectDisplayType Raw;
}

// Namespace: PRISM.Definitions
public class MstLiveSkillLevel : System.IComparable<PRISM.Definitions.MstLiveSkillLevel>, System.IComparable<System.ValueTuple<int, int>>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstLiveSkillLevel>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <MstLiveSkillId>k__BackingField;
    private int <Level>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<int> <MstLiveSkillDetailIdList>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<PRISM.Definitions.MstLiveSkillDetail> <DetailList>k__BackingField;
    public int Id { get; set; }
    public int MstLiveSkillId { get; set; }
    public int Level { get; set; }
    public PRISM.Definitions.LocalizationKey Title { get; set; }
    public PRISM.Definitions.LocalizationKey Description { get; set; }
    public System.Collections.Generic.IReadOnlyList<int> MstLiveSkillDetailIdList { get; set; }
    public System.Collections.Generic.IReadOnlyList<PRISM.Definitions.MstLiveSkillDetail> DetailList { get; set; }
    public int CompareTo(PRISM.Definitions.MstLiveSkillLevel other);
    public int CompareTo(System.ValueTuple<int, int> key);
    public void BindReferences(PRISM.Definitions.MasterData masterData);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstLiveSkillLevel& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstLiveSkillLevel& value);

    private class MstLiveSkillLevelFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstLiveSkillLevel>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstLiveSkillLevel& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstLiveSkillLevel& value);
    }
}

// Namespace: PRISM.Definitions
public class MstLiveSupportEffect : System.IComparable<PRISM.Definitions.MstLiveSupportEffect>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstLiveSupportEffect>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<int> <DetailIdList>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<PRISM.Definitions.MstLiveSupportEffectDetail> <DetailList>k__BackingField;
    public int Id { get; set; }
    public PRISM.Definitions.LocalizationKey Title { get; set; }
    public PRISM.Definitions.LocalizationKey DescriptionFormat { get; set; }
    public System.Collections.Generic.IReadOnlyList<int> DetailIdList { get; set; }
    public System.Collections.Generic.IReadOnlyList<PRISM.Definitions.MstLiveSupportEffectDetail> DetailList { get; set; }
    public int CompareTo(PRISM.Definitions.MstLiveSupportEffect other);
    public int CompareTo(int key);
    public void BindReferences(PRISM.Definitions.MasterData masterData);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstLiveSupportEffect& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstLiveSupportEffect& value);

    private class MstLiveSupportEffectFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstLiveSupportEffect>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstLiveSupportEffect& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstLiveSupportEffect& value);
    }
}

// Namespace: PRISM.Definitions
public class MstLiveSupportEffectDetail : System.IComparable<PRISM.Definitions.MstLiveSupportEffectDetail>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstLiveSupportEffectDetail>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <EffectTypeId>k__BackingField;
    private int <ConditionType>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<int> <ConditionIdList>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<int> <EffectValueList>k__BackingField;
    private PRISM.Definitions.MstLiveSupportEffectType <EffectType>k__BackingField;
    public int Id { get; set; }
    public int EffectTypeId { get; set; }
    public int ConditionType { get; set; }
    public System.Collections.Generic.IReadOnlyList<int> ConditionIdList { get; set; }
    public System.Collections.Generic.IReadOnlyList<int> EffectValueList { get; set; }
    public PRISM.Definitions.MstLiveSupportEffectType EffectType { get; set; }
    public int CompareTo(PRISM.Definitions.MstLiveSupportEffectDetail other);
    public int CompareTo(int key);
    public void BindReferences(PRISM.Definitions.MasterData masterData);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstLiveSupportEffectDetail& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstLiveSupportEffectDetail& value);

    private class MstLiveSupportEffectDetailFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstLiveSupportEffectDetail>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstLiveSupportEffectDetail& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstLiveSupportEffectDetail& value);
    }
}

// Namespace: PRISM.Definitions
public class MstLiveSupportEffectType : System.IComparable<PRISM.Definitions.MstLiveSupportEffectType>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstLiveSupportEffectType>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private bool <IsTime>k__BackingField;
    private bool <IsAll>k__BackingField;
    private PRISM.Definitions.LiveSkillEffectDisplayType <DisplayType>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<int> <TargetList>k__BackingField;
    public int Id { get; set; }
    public PRISM.Definitions.LocalizationKey Title { get; set; }
    public bool IsTime { get; set; }
    public bool IsAll { get; set; }
    public PRISM.Definitions.LiveSkillEffectDisplayType DisplayType { get; set; }
    public System.Collections.Generic.IReadOnlyList<int> TargetList { get; set; }
    public int CompareTo(PRISM.Definitions.MstLiveSupportEffectType other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstLiveSupportEffectType& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstLiveSupportEffectType& value);

    private class MstLiveSupportEffectTypeFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstLiveSupportEffectType>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstLiveSupportEffectType& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstLiveSupportEffectType& value);
    }
}

// Namespace: PRISM.Definitions
public class MstLiveTotalHighScoreRateReward : MemoryPack.IMemoryPackable<PRISM.Definitions.MstLiveTotalHighScoreRateReward>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <FrameType>k__BackingField;
    private int <Star>k__BackingField;
    private int <StartRate>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<string> <ProductIdWithAmountList>k__BackingField;
    public int Id { get; set; }
    public int FrameType { get; set; }
    public int Star { get; set; }
    public int StartRate { get; set; }
    public PRISM.Definitions.LocalizationKey GradeName { get; set; }
    public System.Collections.Generic.IReadOnlyList<string> ProductIdWithAmountList { get; set; }
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstLiveTotalHighScoreRateReward& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstLiveTotalHighScoreRateReward& value);

    private class MstLiveTotalHighScoreRateRewardFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstLiveTotalHighScoreRateReward>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstLiveTotalHighScoreRateReward& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstLiveTotalHighScoreRateReward& value);
    }
}

// Namespace: PRISM.Definitions
public class MstLiveTotalTechnicalRateReward : System.IComparable<PRISM.Definitions.MstLiveTotalTechnicalRateReward>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstLiveTotalTechnicalRateReward>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <FrameType>k__BackingField;
    private int <Star>k__BackingField;
    private float <StartRate>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<string> <ProductIdWithAmountList>k__BackingField;
    private int <SongLevelForMaster>k__BackingField;
    public int Id { get; set; }
    public int FrameType { get; set; }
    public int Star { get; set; }
    public float StartRate { get; set; }
    public PRISM.Definitions.LocalizationKey GradeName { get; set; }
    public System.Collections.Generic.IReadOnlyList<string> ProductIdWithAmountList { get; set; }
    public int SongLevelForMaster { get; set; }
    public int CompareTo(PRISM.Definitions.MstLiveTotalTechnicalRateReward other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstLiveTotalTechnicalRateReward& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstLiveTotalTechnicalRateReward& value);

    private class MstLiveTotalTechnicalRateRewardFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstLiveTotalTechnicalRateReward>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstLiveTotalTechnicalRateReward& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstLiveTotalTechnicalRateReward& value);
    }
}

// Namespace: PRISM.Definitions
public class MstLiveUnitRankingCategory : MemoryPack.IMemoryPackable<PRISM.Definitions.MstLiveUnitRankingCategory>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    public int Id { get; set; }
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstLiveUnitRankingCategory& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstLiveUnitRankingCategory& value);

    private class MstLiveUnitRankingCategoryFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstLiveUnitRankingCategory>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstLiveUnitRankingCategory& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstLiveUnitRankingCategory& value);
    }
}

// Namespace: PRISM.Definitions
public class MstLoginBonus : System.IComparable<PRISM.Definitions.MstLoginBonus>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstLoginBonus>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <LoginBonusType>k__BackingField;
    public int Id { get; set; }
    public int LoginBonusType { get; set; }
    public string TitleImagePath { get; set; }
    public string BgImagePath { get; set; }
    public int CompareTo(PRISM.Definitions.MstLoginBonus other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstLoginBonus& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstLoginBonus& value);

    private class MstLoginBonusFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstLoginBonus>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstLoginBonus& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstLoginBonus& value);
    }
}

// Namespace: PRISM.Definitions
public class MstLoginBonusCostumeSet : MemoryPack.IMemoryPackable<PRISM.Definitions.MstLoginBonusCostumeSet>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <MstCostumeSetId>k__BackingField;
    private System.DateTime <BeginDate>k__BackingField;
    private System.DateTime <EndDate>k__BackingField;
    public int Id { get; set; }
    public int MstCostumeSetId { get; set; }
    public System.DateTime BeginDate { get; set; }
    public System.DateTime EndDate { get; set; }
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstLoginBonusCostumeSet& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstLoginBonusCostumeSet& value);

    private class MstLoginBonusCostumeSetFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstLoginBonusCostumeSet>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstLoginBonusCostumeSet& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstLoginBonusCostumeSet& value);
    }
}

// Namespace: PRISM.Definitions
public class MstLoginBonusPass : System.IComparable<PRISM.Definitions.MstLoginBonusPass>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstLoginBonusPass>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private string <Name>k__BackingField;
    private int <AvailableDayCount>k__BackingField;
    private int <PurchaseAppealType>k__BackingField;
    public int Id { get; set; }
    public string Name { get; set; }
    public int AvailableDayCount { get; set; }
    public int PurchaseAppealType { get; set; }
    public int CompareTo(PRISM.Definitions.MstLoginBonusPass other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstLoginBonusPass& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstLoginBonusPass& value);

    private class MstLoginBonusPassFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstLoginBonusPass>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstLoginBonusPass& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstLoginBonusPass& value);
    }
}

// Namespace: PRISM.Definitions
public class MstMainStory : System.IComparable<PRISM.Definitions.MstMainStory>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstMainStory>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <EpisodeNumber>k__BackingField;
    private int <MstMainStoryChapterId>k__BackingField;
    private int <SortId>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<int> <MstCharacterInfoIdList>k__BackingField;
    private System.DateTime <ReleaseDate>k__BackingField;
    private PRISM.Definitions.MstMainStoryChapter <MstMainStoryChapter>k__BackingField;
    public int Id { get; set; }
    public PRISM.Definitions.LocalizationKey Title { get; set; }
    public int EpisodeNumber { get; set; }
    public int MstMainStoryChapterId { get; set; }
    public int SortId { get; set; }
    public System.Collections.Generic.IReadOnlyList<int> MstCharacterInfoIdList { get; set; }
    public System.DateTime ReleaseDate { get; set; }
    public string ThumbnailPath { get; set; }
    public PRISM.Definitions.MstMainStoryChapter MstMainStoryChapter { get; set; }
    public int CompareTo(PRISM.Definitions.MstMainStory other);
    public int CompareTo(int key);
    public void BindReferences(PRISM.Definitions.MasterData masterData);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstMainStory& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstMainStory& value);

    private class MstMainStoryFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstMainStory>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstMainStory& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstMainStory& value);
    }
}

// Namespace: PRISM.Definitions
public class MstMainStoryChapter : System.IComparable<PRISM.Definitions.MstMainStoryChapter>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstMainStoryChapter>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <MstUnitId>k__BackingField;
    private int <SortId>k__BackingField;
    public int Id { get; set; }
    public PRISM.Definitions.LocalizationKey Title { get; set; }
    public int MstUnitId { get; set; }
    public int SortId { get; set; }
    public string ThumbnailPath { get; set; }
    public string UnitSubStoryThumbnailPath { get; set; }
    public string MainStoryBackgroundPath { get; set; }
    public int CompareTo(PRISM.Definitions.MstMainStoryChapter other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstMainStoryChapter& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstMainStoryChapter& value);

    private class MstMainStoryChapterFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstMainStoryChapter>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstMainStoryChapter& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstMainStoryChapter& value);
    }
}

// Namespace: PRISM.Definitions
public class MstMcsIdolOrder : System.IComparable<PRISM.Definitions.MstMcsIdolOrder>, System.IComparable<string>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstMcsIdolOrder>, MemoryPack.IMemoryPackFormatterRegister
{
    private string <SongId>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<int> <CharaIdList>k__BackingField;
    public string SongId { get; set; }
    public System.Collections.Generic.IReadOnlyList<int> CharaIdList { get; set; }
    public int CompareTo(PRISM.Definitions.MstMcsIdolOrder other);
    public int CompareTo(string key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstMcsIdolOrder& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstMcsIdolOrder& value);

    private class MstMcsIdolOrderFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstMcsIdolOrder>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstMcsIdolOrder& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstMcsIdolOrder& value);
    }
}

// Namespace: PRISM.Definitions
public class MstMissionGroup : System.IComparable<PRISM.Definitions.MstMissionGroup>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstMissionGroup>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <MstEventId>k__BackingField;
    private System.DateTime <ReleaseDate>k__BackingField;
    private System.DateTime <EndDate>k__BackingField;
    public int Id { get; set; }
    public PRISM.Definitions.LocalizationKey Name { get; set; }
    public PRISM.Definitions.LocalizationKey Heading { get; set; }
    public int MstEventId { get; set; }
    public System.DateTime ReleaseDate { get; set; }
    public System.DateTime EndDate { get; set; }
    public int CompareTo(PRISM.Definitions.MstMissionGroup other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstMissionGroup& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstMissionGroup& value);

    private class MstMissionGroupFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstMissionGroup>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstMissionGroup& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstMissionGroup& value);
    }
}

// Namespace: PRISM.Definitions
public class MstMissionRemind : MemoryPack.IMemoryPackable<PRISM.Definitions.MstMissionRemind>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <MstMissionGroupId>k__BackingField;
    private int <RemindIntervalDays>k__BackingField;
    private int <MaxRemindTimes>k__BackingField;
    private int <RemindDaysBeforeEnd>k__BackingField;
    public int Id { get; set; }
    public int MstMissionGroupId { get; set; }
    public int RemindIntervalDays { get; set; }
    public int MaxRemindTimes { get; set; }
    public int RemindDaysBeforeEnd { get; set; }
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstMissionRemind& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstMissionRemind& value);

    private class MstMissionRemindFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstMissionRemind>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstMissionRemind& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstMissionRemind& value);
    }
}

// Namespace: PRISM.Definitions
public class MstNcsIdolOrder : System.IComparable<PRISM.Definitions.MstNcsIdolOrder>, System.IComparable<string>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstNcsIdolOrder>, MemoryPack.IMemoryPackFormatterRegister
{
    private string <SongId>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<int> <CharaIdList>k__BackingField;
    public string SongId { get; set; }
    public System.Collections.Generic.IReadOnlyList<int> CharaIdList { get; set; }
    public int CompareTo(PRISM.Definitions.MstNcsIdolOrder other);
    public int CompareTo(string key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstNcsIdolOrder& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstNcsIdolOrder& value);

    private class MstNcsIdolOrderFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstNcsIdolOrder>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstNcsIdolOrder& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstNcsIdolOrder& value);
    }
}

// Namespace: PRISM.Definitions
public class MstNotebook : System.IComparable<PRISM.Definitions.MstNotebook>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstNotebook>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <Exp>k__BackingField;
    private int <NeedMoney>k__BackingField;
    private System.DateTime <ReleaseDate>k__BackingField;
    public int Id { get; set; }
    public PRISM.Definitions.LocalizationKey Name { get; set; }
    public PRISM.Definitions.LocalizationKey Description { get; set; }
    public int Exp { get; set; }
    public int NeedMoney { get; set; }
    public System.DateTime ReleaseDate { get; set; }
    public int CompareTo(PRISM.Definitions.MstNotebook other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstNotebook& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstNotebook& value);

    private class MstNotebookFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstNotebook>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstNotebook& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstNotebook& value);
    }
}

// Namespace: PRISM.Definitions
public class MstOutgameVoiceMotion : System.IComparable<PRISM.Definitions.MstOutgameVoiceMotion>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstOutgameVoiceMotion>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <MstCharacterInfoId>k__BackingField;
    private int <ScreenType>k__BackingField;
    private int <MstProduceIdolId>k__BackingField;
    private int <MstSupportCharacterId>k__BackingField;
    private bool <ReachedGrowthLimit>k__BackingField;
    private int <MstVoiceResourceId>k__BackingField;
    private PRISM.Definitions.MstVoiceResource <Voice>k__BackingField;
    public int Id { get; set; }
    public int MstCharacterInfoId { get; set; }
    public int ScreenType { get; set; }
    public int MstProduceIdolId { get; set; }
    public int MstSupportCharacterId { get; set; }
    public bool ReachedGrowthLimit { get; set; }
    public int MstVoiceResourceId { get; set; }
    public PRISM.Definitions.MstVoiceResource Voice { get; set; }
    public int CompareTo(PRISM.Definitions.MstOutgameVoiceMotion other);
    public int CompareTo(int key);
    public void BindReferences(PRISM.Definitions.MasterData masterData);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstOutgameVoiceMotion& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstOutgameVoiceMotion& value);

    private class MstOutgameVoiceMotionFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstOutgameVoiceMotion>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstOutgameVoiceMotion& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstOutgameVoiceMotion& value);
    }
}

// Namespace: PRISM.Definitions
public class MstPcsIdolOrder : System.IComparable<PRISM.Definitions.MstPcsIdolOrder>, System.IComparable<string>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstPcsIdolOrder>, MemoryPack.IMemoryPackFormatterRegister
{
    private string <SongId>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<int> <CharaIdList>k__BackingField;
    public string SongId { get; set; }
    public System.Collections.Generic.IReadOnlyList<int> CharaIdList { get; set; }
    public int CompareTo(PRISM.Definitions.MstPcsIdolOrder other);
    public int CompareTo(string key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstPcsIdolOrder& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstPcsIdolOrder& value);

    private class MstPcsIdolOrderFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstPcsIdolOrder>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstPcsIdolOrder& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstPcsIdolOrder& value);
    }
}

// Namespace: PRISM.Definitions
public class MstPhoneCall : System.IComparable<PRISM.Definitions.MstPhoneCall>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstPhoneCall>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <MstPhoneUserId>k__BackingField;
    private int <TypeId>k__BackingField;
    private int <ScenarioId>k__BackingField;
    private int <ScenarioNumber>k__BackingField;
    private bool <IsAnswerphone>k__BackingField;
    public int Id { get; set; }
    public int MstPhoneUserId { get; set; }
    public PRISM.Definitions.LocalizationKey Title { get; set; }
    public int TypeId { get; set; }
    public int ScenarioId { get; set; }
    public int ScenarioNumber { get; set; }
    public bool IsAnswerphone { get; set; }
    public string GetCueSheetName(bool hasExtension);
    public static string GetAnswerphoneCueSheetName(bool hasExtension);
    public static string GetAnswerphoneStartCueName();
    public int CompareTo(PRISM.Definitions.MstPhoneCall other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstPhoneCall& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstPhoneCall& value);

    private class MstPhoneCallFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstPhoneCall>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstPhoneCall& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstPhoneCall& value);
    }
}

// Namespace: PRISM.Definitions
public class MstPhoneCallText : System.IComparable<PRISM.Definitions.MstPhoneCallText>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstPhoneCallText>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <MstPhoneCallId>k__BackingField;
    private int <MstPhoneUserId>k__BackingField;
    private int <TextBoxType>k__BackingField;
    private int <Order>k__BackingField;
    private int <SpeakerId>k__BackingField;
    public int Id { get; set; }
    public int MstPhoneCallId { get; set; }
    public int MstPhoneUserId { get; set; }
    public int TextBoxType { get; set; }
    public PRISM.Definitions.LocalizationKey Body { get; set; }
    public int Order { get; set; }
    public int SpeakerId { get; set; }
    public PRISM.Definitions.PhoneCallTextBoxType GetPhoneCallTextBoxType();
    public int CompareTo(PRISM.Definitions.MstPhoneCallText other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstPhoneCallText& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstPhoneCallText& value);

    private class MstPhoneCallTextFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstPhoneCallText>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstPhoneCallText& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstPhoneCallText& value);
    }
}

// Namespace: PRISM.Definitions
public enum PhoneCallTextBoxType : System.Enum
{
    public int value__;
    public static PRISM.Definitions.PhoneCallTextBoxType None;
    public static PRISM.Definitions.PhoneCallTextBoxType Idol;
    public static PRISM.Definitions.PhoneCallTextBoxType Producer;
    public static PRISM.Definitions.PhoneCallTextBoxType Other;
}

// Namespace: PRISM.Definitions
public class MstPhoneGroup : System.IComparable<PRISM.Definitions.MstPhoneGroup>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstPhoneGroup>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    public int Id { get; set; }
    public PRISM.Definitions.LocalizationKey Name { get; set; }
    public string IconKey { get; set; }
    public string CallPlaybackBackgroundKey { get; set; }
    public int CompareTo(PRISM.Definitions.MstPhoneGroup other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstPhoneGroup& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstPhoneGroup& value);

    private class MstPhoneGroupFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstPhoneGroup>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstPhoneGroup& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstPhoneGroup& value);
    }
}

// Namespace: PRISM.Definitions
public class MstPhoneUser : System.IComparable<PRISM.Definitions.MstPhoneUser>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstPhoneUser>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <MstCharacterInfoId>k__BackingField;
    public int Id { get; set; }
    public PRISM.Definitions.LocalizationKey Name { get; set; }
    public int MstCharacterInfoId { get; set; }
    public bool IsProducer { get; set; }
    public string IconKey { get; set; }
    public static string CreateIconKey(int id);
    public int CompareTo(PRISM.Definitions.MstPhoneUser other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstPhoneUser& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstPhoneUser& value);

    private class MstPhoneUserFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstPhoneUser>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstPhoneUser& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstPhoneUser& value);
    }
}

// Namespace: PRISM.Definitions
public class MstPotentialSupportSkill : System.IComparable<PRISM.Definitions.MstPotentialSupportSkill>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstPotentialSupportSkill>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <MstSupportSkillTypeId>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<int> <ValueList>k__BackingField;
    private int <MstSkillBufferDisplayId>k__BackingField;
    private int <GrantMstSkillBufferDisplayId>k__BackingField;
    private int <EntrustAppealType>k__BackingField;
    private int <EntrustScore>k__BackingField;
    public int Id { get; set; }
    public PRISM.Definitions.LocalizationKey Name { get; set; }
    public PRISM.Definitions.LocalizationKey Description { get; set; }
    public int MstSupportSkillTypeId { get; set; }
    public System.Collections.Generic.IReadOnlyList<int> ValueList { get; set; }
    public int MstSkillBufferDisplayId { get; set; }
    public int GrantMstSkillBufferDisplayId { get; set; }
    public int EntrustAppealType { get; set; }
    public int EntrustScore { get; set; }
    public string SupportSkillIconImagePath { get; set; }
    public int CompareTo(PRISM.Definitions.MstPotentialSupportSkill other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstPotentialSupportSkill& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstPotentialSupportSkill& value);

    private class MstPotentialSupportSkillFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstPotentialSupportSkill>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstPotentialSupportSkill& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstPotentialSupportSkill& value);
    }
}

// Namespace: PRISM.Definitions
public class MstProduceActionEffect : System.IComparable<PRISM.Definitions.MstProduceActionEffect>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstProduceActionEffect>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <MstProduceActionEffectTypeId>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<int> <ValueList>k__BackingField;
    private int <MstProduceActionEffectConditionTypeId>k__BackingField;
    private int <ConditionValue>k__BackingField;
    private int <SubMstProduceActionEffectConditionTypeId>k__BackingField;
    private int <SubConditionValue>k__BackingField;
    private bool <IsHideConditionEffect>k__BackingField;
    private int <MstProduceActionEffectActivationTimingTypeId>k__BackingField;
    private int <MstSkillBufferDisplayId>k__BackingField;
    private int <GrantMstSkillBufferDisplayId>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<int> <MstProduceActionEffectDisplayIdList>k__BackingField;
    private int <IconId>k__BackingField;
    public int Id { get; set; }
    public int MstProduceActionEffectTypeId { get; set; }
    public System.Collections.Generic.IReadOnlyList<int> ValueList { get; set; }
    public int MstProduceActionEffectConditionTypeId { get; set; }
    public int ConditionValue { get; set; }
    public int SubMstProduceActionEffectConditionTypeId { get; set; }
    public int SubConditionValue { get; set; }
    public bool IsHideConditionEffect { get; set; }
    public int MstProduceActionEffectActivationTimingTypeId { get; set; }
    public int MstSkillBufferDisplayId { get; set; }
    public int GrantMstSkillBufferDisplayId { get; set; }
    public System.Collections.Generic.IReadOnlyList<int> MstProduceActionEffectDisplayIdList { get; set; }
    public int IconId { get; set; }
    public string IconImagePath { get; set; }
    public int CompareTo(PRISM.Definitions.MstProduceActionEffect other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstProduceActionEffect& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstProduceActionEffect& value);

    private class MstProduceActionEffectFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstProduceActionEffect>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstProduceActionEffect& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstProduceActionEffect& value);
    }
}

// Namespace: PRISM.Definitions
public class MstProduceCardContentGroup : System.IComparable<PRISM.Definitions.MstProduceCardContentGroup>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstProduceCardContentGroup>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <MstProduceCardId>k__BackingField;
    private int <MstProduceCardContentGroupTypeId>k__BackingField;
    public int Id { get; set; }
    public int MstProduceCardId { get; set; }
    public int MstProduceCardContentGroupTypeId { get; set; }
    public PRISM.Definitions.LocalizationKey Name { get; set; }
    public string CardImagePath { get; set; }
    public string Phase1CardImagePath { get; set; }
    public string Phase2CardImagePath { get; set; }
    public int CompareTo(PRISM.Definitions.MstProduceCardContentGroup other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstProduceCardContentGroup& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstProduceCardContentGroup& value);

    private class MstProduceCardContentGroupFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstProduceCardContentGroup>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstProduceCardContentGroup& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstProduceCardContentGroup& value);
    }
}

// Namespace: PRISM.Definitions
public class MstProduceIdol : System.IComparable<PRISM.Definitions.MstProduceIdol>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstProduceIdol>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <ProduceIdolType>k__BackingField;
    private int <MstIdolId>k__BackingField;
    private int <InitialStar>k__BackingField;
    private int <InitialVocal>k__BackingField;
    private int <InitialDance>k__BackingField;
    private int <InitialVisual>k__BackingField;
    private int <InitialMental>k__BackingField;
    private int <LimitVocal>k__BackingField;
    private int <LimitDance>k__BackingField;
    private int <LimitVisual>k__BackingField;
    private int <LimitMental>k__BackingField;
    private int <MstStarGrowthId>k__BackingField;
    private int <MaxLevelVocal>k__BackingField;
    private int <MaxLevelDance>k__BackingField;
    private int <MaxLevelVisual>k__BackingField;
    private int <MaxLevelMental>k__BackingField;
    private int <Attribute>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<int> <MstIdolSkillIdList>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<int> <IdolSkillPremiseEvolutionLevelList>k__BackingField;
    private int <MstLiveCenterEffectId>k__BackingField;
    private int <MstLiveSkillId>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<int> <CostumeSetIdList>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<int> <CostumeSetPremiseStarList>k__BackingField;
    private System.DateTime <ReleaseDate>k__BackingField;
    private string <LimitBreakRecipeProductId>k__BackingField;
    private int <EvolutionRecipeGroupId>k__BackingField;
    private int <GashaVoiceMstVoiceResourceId>k__BackingField;
    private int <GashaSeMstVoiceResourceId>k__BackingField;
    private int <SignPositionIndex>k__BackingField;
    private PRISM.Definitions.MstCharacterInfo <CharacterInfo>k__BackingField;
    private PRISM.Definitions.MstLiveCenterEffect <LiveCenterEffect>k__BackingField;
    public int Id { get; set; }
    public int ProduceIdolType { get; set; }
    public int MstIdolId { get; set; }
    public PRISM.Definitions.LocalizationKey Name { get; set; }
    public int InitialStar { get; set; }
    public int InitialVocal { get; set; }
    public int InitialDance { get; set; }
    public int InitialVisual { get; set; }
    public int InitialMental { get; set; }
    public int LimitVocal { get; set; }
    public int LimitDance { get; set; }
    public int LimitVisual { get; set; }
    public int LimitMental { get; set; }
    public int MstStarGrowthId { get; set; }
    public int MaxLevelVocal { get; set; }
    public int MaxLevelDance { get; set; }
    public int MaxLevelVisual { get; set; }
    public int MaxLevelMental { get; set; }
    public int Attribute { get; set; }
    public System.Collections.Generic.IReadOnlyList<int> MstIdolSkillIdList { get; set; }
    public System.Collections.Generic.IReadOnlyList<int> IdolSkillPremiseEvolutionLevelList { get; set; }
    public int MstLiveCenterEffectId { get; set; }
    public int MstLiveSkillId { get; set; }
    public System.Collections.Generic.IReadOnlyList<int> CostumeSetIdList { get; set; }
    public System.Collections.Generic.IReadOnlyList<int> CostumeSetPremiseStarList { get; set; }
    public System.DateTime ReleaseDate { get; set; }
    public string LimitBreakRecipeProductId { get; set; }
    public int EvolutionRecipeGroupId { get; set; }
    public int GashaVoiceMstVoiceResourceId { get; set; }
    public int GashaSeMstVoiceResourceId { get; set; }
    public int SignPositionIndex { get; set; }
    public string AlignedFacePrefabPath { get; set; }
    public string StandingImagePath { get; set; }
    public string IconRectImagePath { get; set; }
    public string IconSqImagePath { get; set; }
    public string SkillCutInImagePath { get; set; }
    public string GashaMoviePath { get; set; }
    public PRISM.Definitions.MstCharacterInfo CharacterInfo { get; set; }
    public PRISM.Definitions.MstLiveCenterEffect LiveCenterEffect { get; set; }
    public int CompareTo(PRISM.Definitions.MstProduceIdol other);
    public int CompareTo(int key);
    public void BindReferences(PRISM.Definitions.MasterData masterData);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstProduceIdol& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstProduceIdol& value);

    private class MstProduceIdolFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstProduceIdol>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstProduceIdol& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstProduceIdol& value);
    }
}

// Namespace: PRISM.Definitions
public class MstProduceIdolEvent : System.IComparable<PRISM.Definitions.MstProduceIdolEvent>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstProduceIdolEvent>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <ProductType>k__BackingField;
    private string <MstAdvInfoId>k__BackingField;
    private int <MstProduceIdolId>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<int> <MstCharacterInfoIdList>k__BackingField;
    private int <ScenarioId>k__BackingField;
    private int <MstProduceScenarioRewardGroupId>k__BackingField;
    private System.DateTime <ReleaseDate>k__BackingField;
    private int <SortId>k__BackingField;
    public int Id { get; set; }
    public int ProductType { get; set; }
    public string MstAdvInfoId { get; set; }
    public int MstProduceIdolId { get; set; }
    public System.Collections.Generic.IReadOnlyList<int> MstCharacterInfoIdList { get; set; }
    public int ScenarioId { get; set; }
    public int MstProduceScenarioRewardGroupId { get; set; }
    public System.DateTime ReleaseDate { get; set; }
    public int SortId { get; set; }
    public int CompareTo(PRISM.Definitions.MstProduceIdolEvent other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstProduceIdolEvent& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstProduceIdolEvent& value);

    private class MstProduceIdolEventFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstProduceIdolEvent>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstProduceIdolEvent& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstProduceIdolEvent& value);
    }
}

// Namespace: PRISM.Definitions
public class MstProduceIdolEvolutionLevel : System.IComparable<PRISM.Definitions.MstProduceIdolEvolutionLevel>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstProduceIdolEvolutionLevel>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <EvolutionLevel>k__BackingField;
    private int <LimitProduceIdolLevel>k__BackingField;
    public int EvolutionLevel { get; set; }
    public int LimitProduceIdolLevel { get; set; }
    public int CompareTo(PRISM.Definitions.MstProduceIdolEvolutionLevel other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstProduceIdolEvolutionLevel& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstProduceIdolEvolutionLevel& value);

    private class MstProduceIdolEvolutionLevelFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstProduceIdolEvolutionLevel>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstProduceIdolEvolutionLevel& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstProduceIdolEvolutionLevel& value);
    }
}

// Namespace: PRISM.Definitions
public class MstProduceIdolEvolutionRecipe : System.IComparable<PRISM.Definitions.MstProduceIdolEvolutionRecipe>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstProduceIdolEvolutionRecipe>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <GroupId>k__BackingField;
    private int <EvolutionLevel>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<string> <ProductIdWithAmountList>k__BackingField;
    private int <Money>k__BackingField;
    public int Id { get; set; }
    public int GroupId { get; set; }
    public int EvolutionLevel { get; set; }
    public System.Collections.Generic.IReadOnlyList<string> ProductIdWithAmountList { get; set; }
    public int Money { get; set; }
    public int CompareTo(PRISM.Definitions.MstProduceIdolEvolutionRecipe other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstProduceIdolEvolutionRecipe& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstProduceIdolEvolutionRecipe& value);

    private class MstProduceIdolEvolutionRecipeFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstProduceIdolEvolutionRecipe>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstProduceIdolEvolutionRecipe& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstProduceIdolEvolutionRecipe& value);
    }
}

// Namespace: PRISM.Definitions
public class MstProduceIdolLevelExp : System.IComparable<PRISM.Definitions.MstProduceIdolLevelExp>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstProduceIdolLevelExp>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Level>k__BackingField;
    private int <Exp>k__BackingField;
    public int Level { get; set; }
    public int Exp { get; set; }
    public int CompareTo(PRISM.Definitions.MstProduceIdolLevelExp other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstProduceIdolLevelExp& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstProduceIdolLevelExp& value);

    private class MstProduceIdolLevelExpFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstProduceIdolLevelExp>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstProduceIdolLevelExp& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstProduceIdolLevelExp& value);
    }
}

// Namespace: PRISM.Definitions
public class MstProduceIdolLevelReward : System.IComparable<PRISM.Definitions.MstProduceIdolLevelReward>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstProduceIdolLevelReward>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <Level>k__BackingField;
    private int <MstProduceIdolId>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<string> <RewardList>k__BackingField;
    public int Id { get; set; }
    public int Level { get; set; }
    public int MstProduceIdolId { get; set; }
    public System.Collections.Generic.IReadOnlyList<string> RewardList { get; set; }
    public int CompareTo(PRISM.Definitions.MstProduceIdolLevelReward other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstProduceIdolLevelReward& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstProduceIdolLevelReward& value);

    private class MstProduceIdolLevelRewardFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstProduceIdolLevelReward>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstProduceIdolLevelReward& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstProduceIdolLevelReward& value);
    }
}

// Namespace: PRISM.Definitions
public class MstProduceIdolLimitBreakRecipe : System.IComparable<PRISM.Definitions.MstProduceIdolLimitBreakRecipe>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstProduceIdolLimitBreakRecipe>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <Star>k__BackingField;
    private int <Amount>k__BackingField;
    public int Id { get; set; }
    public int Star { get; set; }
    public int Amount { get; set; }
    public int CompareTo(PRISM.Definitions.MstProduceIdolLimitBreakRecipe other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstProduceIdolLimitBreakRecipe& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstProduceIdolLimitBreakRecipe& value);

    private class MstProduceIdolLimitBreakRecipeFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstProduceIdolLimitBreakRecipe>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstProduceIdolLimitBreakRecipe& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstProduceIdolLimitBreakRecipe& value);
    }
}

// Namespace: PRISM.Definitions
public class MstProduceIdolPersonalLimitBreakReward : System.IComparable<PRISM.Definitions.MstProduceIdolPersonalLimitBreakReward>, System.IComparable<System.ValueTuple<int, int>>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstProduceIdolPersonalLimitBreakReward>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <MstProduceIdolId>k__BackingField;
    private int <Star>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<string> <RewardList>k__BackingField;
    private System.DateTime <ReleaseDate>k__BackingField;
    public int MstProduceIdolId { get; set; }
    public int Star { get; set; }
    public System.Collections.Generic.IReadOnlyList<string> RewardList { get; set; }
    public System.DateTime ReleaseDate { get; set; }
    public int CompareTo(PRISM.Definitions.MstProduceIdolPersonalLimitBreakReward other);
    public int CompareTo(System.ValueTuple<int, int> key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstProduceIdolPersonalLimitBreakReward& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstProduceIdolPersonalLimitBreakReward& value);

    private class MstProduceIdolPersonalLimitBreakRewardFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstProduceIdolPersonalLimitBreakReward>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstProduceIdolPersonalLimitBreakReward& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstProduceIdolPersonalLimitBreakReward& value);
    }
}

// Namespace: PRISM.Definitions
public class MstProduceIdolReleaseCostumeSet : MemoryPack.IMemoryPackable<PRISM.Definitions.MstProduceIdolReleaseCostumeSet>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <MstProduceIdolId>k__BackingField;
    private int <MstCostumeSetId>k__BackingField;
    private int <Star>k__BackingField;
    private System.DateTime <ReleaseDate>k__BackingField;
    public int Id { get; set; }
    public int MstProduceIdolId { get; set; }
    public int MstCostumeSetId { get; set; }
    public int Star { get; set; }
    public System.DateTime ReleaseDate { get; set; }
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstProduceIdolReleaseCostumeSet& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstProduceIdolReleaseCostumeSet& value);

    private class MstProduceIdolReleaseCostumeSetFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstProduceIdolReleaseCostumeSet>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstProduceIdolReleaseCostumeSet& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstProduceIdolReleaseCostumeSet& value);
    }
}

// Namespace: PRISM.Definitions
public class MstProduceMainIdolScenario : System.IComparable<PRISM.Definitions.MstProduceMainIdolScenario>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstProduceMainIdolScenario>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <MstEpisodeId>k__BackingField;
    private int <MstCharacterInfoId>k__BackingField;
    private int <ScenarioId>k__BackingField;
    private int <EpisodeNumber>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<string> <MstCharacterInfoIdList>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<string> <UnlockPremiseMstStoryIdList>k__BackingField;
    private System.DateTime <ReleaseDate>k__BackingField;
    private int <SortId>k__BackingField;
    private PRISM.Definitions.MstEpisode <Episode>k__BackingField;
    private PRISM.Definitions.MstCharacterInfo <CharacterInfo>k__BackingField;
    public int Id { get; set; }
    public int MstEpisodeId { get; set; }
    public int MstCharacterInfoId { get; set; }
    public int ScenarioId { get; set; }
    public int EpisodeNumber { get; set; }
    public System.Collections.Generic.IReadOnlyList<string> MstCharacterInfoIdList { get; set; }
    public System.Collections.Generic.IReadOnlyList<string> UnlockPremiseMstStoryIdList { get; set; }
    public System.DateTime ReleaseDate { get; set; }
    public int SortId { get; set; }
    public PRISM.Definitions.MstEpisode Episode { get; set; }
    public PRISM.Definitions.MstCharacterInfo CharacterInfo { get; set; }
    public string CreateScenarioName();
    public int CompareTo(PRISM.Definitions.MstProduceMainIdolScenario other);
    public int CompareTo(int key);
    public void BindReferences(PRISM.Definitions.MasterData masterData);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstProduceMainIdolScenario& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstProduceMainIdolScenario& value);

    private class MstProduceMainIdolScenarioFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstProduceMainIdolScenario>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstProduceMainIdolScenario& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstProduceMainIdolScenario& value);
    }
}

// Namespace: PRISM.Definitions
public class MstProduceMainScenario : System.IComparable<PRISM.Definitions.MstProduceMainScenario>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstProduceMainScenario>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <MstEpisodeId>k__BackingField;
    private int <ScenarioId>k__BackingField;
    private int <EpisodeNumber>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<string> <UnlockPremiseMstStoryIdList>k__BackingField;
    private int <SortId>k__BackingField;
    private PRISM.Definitions.MstEpisode <Episode>k__BackingField;
    public int Id { get; set; }
    public int MstEpisodeId { get; set; }
    public int ScenarioId { get; set; }
    public int EpisodeNumber { get; set; }
    public System.Collections.Generic.IReadOnlyList<string> UnlockPremiseMstStoryIdList { get; set; }
    public int SortId { get; set; }
    public PRISM.Definitions.MstEpisode Episode { get; set; }
    public string CreateScenarioName();
    public int CompareTo(PRISM.Definitions.MstProduceMainScenario other);
    public int CompareTo(int key);
    public void BindReferences(PRISM.Definitions.MasterData masterData);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstProduceMainScenario& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstProduceMainScenario& value);

    private class MstProduceMainScenarioFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstProduceMainScenario>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstProduceMainScenario& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstProduceMainScenario& value);
    }
}

// Namespace: PRISM.Definitions
public class MstProducePassiveEffect : System.IComparable<PRISM.Definitions.MstProducePassiveEffect>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstProducePassiveEffect>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <MstProducePassiveEffectTypeId>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<int> <ValueList>k__BackingField;
    public int Id { get; set; }
    public int MstProducePassiveEffectTypeId { get; set; }
    public System.Collections.Generic.IReadOnlyList<int> ValueList { get; set; }
    public int CompareTo(PRISM.Definitions.MstProducePassiveEffect other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstProducePassiveEffect& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstProducePassiveEffect& value);

    private class MstProducePassiveEffectFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstProducePassiveEffect>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstProducePassiveEffect& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstProducePassiveEffect& value);
    }
}

// Namespace: PRISM.Definitions
public class MstProducePromotionBanner : MemoryPack.IMemoryPackable<PRISM.Definitions.MstProducePromotionBanner>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private string <ProducePromotionUrl>k__BackingField;
    private int <SortId>k__BackingField;
    private string <BannerPath>k__BackingField;
    private System.DateTime <BeginDate>k__BackingField;
    private System.DateTime <EndDate>k__BackingField;
    public int Id { get; set; }
    public string ProducePromotionUrl { get; set; }
    public int SortId { get; set; }
    public string BannerPath { get; set; }
    public System.DateTime BeginDate { get; set; }
    public System.DateTime EndDate { get; set; }
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstProducePromotionBanner& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstProducePromotionBanner& value);

    private class MstProducePromotionBannerFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstProducePromotionBanner>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstProducePromotionBanner& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstProducePromotionBanner& value);
    }
}

// Namespace: PRISM.Definitions
public class MstProduceUniqueCutScene : MemoryPack.IMemoryPackable<PRISM.Definitions.MstProduceUniqueCutScene>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private string <Csid>k__BackingField;
    public int Id { get; set; }
    public string Csid { get; set; }
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstProduceUniqueCutScene& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstProduceUniqueCutScene& value);

    private class MstProduceUniqueCutSceneFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstProduceUniqueCutScene>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstProduceUniqueCutScene& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstProduceUniqueCutScene& value);
    }
}

// Namespace: PRISM.Definitions
public class MstProductType : System.IComparable<PRISM.Definitions.MstProductType>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstProductType>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private bool <UseIndividualIcon>k__BackingField;
    private bool <UseCategoricalIcon>k__BackingField;
    private bool <VisibleItem>k__BackingField;
    private bool <IsPossessionOnlyOne>k__BackingField;
    private EnumItemType <ItemType>k__BackingField;
    private int <SortId>k__BackingField;
    public int Id { get; set; }
    public bool UseIndividualIcon { get; set; }
    public bool UseCategoricalIcon { get; set; }
    public bool VisibleItem { get; set; }
    public bool IsPossessionOnlyOne { get; set; }
    public EnumItemType ItemType { get; set; }
    public int SortId { get; set; }
    public int CompareTo(PRISM.Definitions.MstProductType other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstProductType& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstProductType& value);

    public enum EnumItemType : System.Enum
    {
        public int value__;
        public static EnumItemType None;
        public static EnumItemType Recovery;
        public static EnumItemType Disposable;
        public static EnumItemType LimitBreak;
        public static EnumItemType MasterTraining;
        public static EnumItemType GashaTicket;
        public static EnumItemType Etc;
        public static EnumItemType Sum;
    }

    private class MstProductTypeFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstProductType>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstProductType& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstProductType& value);
    }
}

// Namespace: PRISM.Definitions
public class MstRecoveryDrink : System.IComparable<PRISM.Definitions.MstRecoveryDrink>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstRecoveryDrink>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <StaminaType>k__BackingField;
    private int <Value>k__BackingField;
    public int Id { get; set; }
    public int StaminaType { get; set; }
    public int Value { get; set; }
    public int CompareTo(PRISM.Definitions.MstRecoveryDrink other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstRecoveryDrink& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstRecoveryDrink& value);

    private class MstRecoveryDrinkFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstRecoveryDrink>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstRecoveryDrink& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstRecoveryDrink& value);
    }
}

// Namespace: PRISM.Definitions
public class MstRunwayStage : PRISM.Definitions.IMstMvStage, MemoryPack.IMemoryPackable<PRISM.Definitions.MstRunwayStage>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private string <MvScene>k__BackingField;
    private int <StageAudioType>k__BackingField;
    public int Id { get; set; }
    public PRISM.Definitions.LocalizationKey Name { get; set; }
    public string CueSheet { get; set; }
    public string MvScene { get; set; }
    public int StageAudioType { get; set; }
    public string BackgroundImagePath { get; set; }
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstRunwayStage& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstRunwayStage& value);

    private class MstRunwayStageFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstRunwayStage>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstRunwayStage& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstRunwayStage& value);
    }
}

// Namespace: PRISM.Definitions
public class MstScheduleType : MemoryPack.IMemoryPackable<PRISM.Definitions.MstScheduleType>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <ScheduleSelectionType>k__BackingField;
    private int <Order>k__BackingField;
    public int Id { get; set; }
    public int ScheduleSelectionType { get; set; }
    public int Order { get; set; }
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstScheduleType& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstScheduleType& value);

    private class MstScheduleTypeFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstScheduleType>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstScheduleType& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstScheduleType& value);
    }
}

// Namespace: PRISM.Definitions
public class MstSeasonMission : System.IComparable<PRISM.Definitions.MstSeasonMission>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstSeasonMission>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    public int Id { get; set; }
    public PRISM.Definitions.LocalizationKey Name { get; set; }
    public string LogoPath { get; set; }
    public string LogoAndIllustPath { get; set; }
    public int CompareTo(PRISM.Definitions.MstSeasonMission other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstSeasonMission& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstSeasonMission& value);

    private class MstSeasonMissionFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstSeasonMission>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstSeasonMission& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstSeasonMission& value);
    }
}

// Namespace: PRISM.Definitions
public class MstShinyCompetition : System.IComparable<PRISM.Definitions.MstShinyCompetition>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstShinyCompetition>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private System.DateTime <DisplayBeginDate>k__BackingField;
    private System.DateTime <BeginDate>k__BackingField;
    private System.DateTime <EndDate>k__BackingField;
    private System.DateTime <ResultBeginDate>k__BackingField;
    private System.DateTime <DisplayEndDate>k__BackingField;
    public int Id { get; set; }
    public PRISM.Definitions.LocalizationKey Name { get; set; }
    public System.DateTime DisplayBeginDate { get; set; }
    public System.DateTime BeginDate { get; set; }
    public System.DateTime EndDate { get; set; }
    public System.DateTime ResultBeginDate { get; set; }
    public System.DateTime DisplayEndDate { get; set; }
    public int CompareTo(PRISM.Definitions.MstShinyCompetition other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstShinyCompetition& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstShinyCompetition& value);

    private class MstShinyCompetitionFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstShinyCompetition>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstShinyCompetition& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstShinyCompetition& value);
    }
}

// Namespace: PRISM.Definitions
public class MstShinyCompetitionIdol : MemoryPack.IMemoryPackable<PRISM.Definitions.MstShinyCompetitionIdol>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <MstShinyCompetitionId>k__BackingField;
    private int <MstProduceIdolId>k__BackingField;
    private int <PointBonusRate>k__BackingField;
    public int Id { get; set; }
    public int MstShinyCompetitionId { get; set; }
    public int MstProduceIdolId { get; set; }
    public int PointBonusRate { get; set; }
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstShinyCompetitionIdol& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstShinyCompetitionIdol& value);

    private class MstShinyCompetitionIdolFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstShinyCompetitionIdol>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstShinyCompetitionIdol& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstShinyCompetitionIdol& value);
    }
}

// Namespace: PRISM.Definitions
public class MstShinyCompetitionProduceBonus : System.IComparable<PRISM.Definitions.MstShinyCompetitionProduceBonus>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstShinyCompetitionProduceBonus>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <MstShinyCompetitionId>k__BackingField;
    private int <MstShinyCompetitionProduceBonusConditionId>k__BackingField;
    private int <Bonus>k__BackingField;
    public int Id { get; set; }
    public int MstShinyCompetitionId { get; set; }
    public int MstShinyCompetitionProduceBonusConditionId { get; set; }
    public int Bonus { get; set; }
    public int CompareTo(PRISM.Definitions.MstShinyCompetitionProduceBonus other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstShinyCompetitionProduceBonus& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstShinyCompetitionProduceBonus& value);

    private class MstShinyCompetitionProduceBonusFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstShinyCompetitionProduceBonus>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstShinyCompetitionProduceBonus& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstShinyCompetitionProduceBonus& value);
    }
}

// Namespace: PRISM.Definitions
public class MstShinyCompetitionProduceBonusCondition : System.IComparable<PRISM.Definitions.MstShinyCompetitionProduceBonusCondition>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstShinyCompetitionProduceBonusCondition>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private bool <IsResultOnly>k__BackingField;
    private int <ShinyCompetitionProduceBonusType>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<int> <ValueList>k__BackingField;
    public int Id { get; set; }
    public PRISM.Definitions.LocalizationKey Title { get; set; }
    public PRISM.Definitions.LocalizationKey TitleShort { get; set; }
    public bool IsResultOnly { get; set; }
    public int ShinyCompetitionProduceBonusType { get; set; }
    public System.Collections.Generic.IReadOnlyList<int> ValueList { get; set; }
    public int CompareTo(PRISM.Definitions.MstShinyCompetitionProduceBonusCondition other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstShinyCompetitionProduceBonusCondition& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstShinyCompetitionProduceBonusCondition& value);

    private class MstShinyCompetitionProduceBonusConditionFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstShinyCompetitionProduceBonusCondition>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstShinyCompetitionProduceBonusCondition& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstShinyCompetitionProduceBonusCondition& value);
    }
}

// Namespace: PRISM.Definitions
public class MstShinyCompetitionRanking : System.IComparable<PRISM.Definitions.MstShinyCompetitionRanking>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstShinyCompetitionRanking>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <MstShinyCompetitionId>k__BackingField;
    private int <RankingType>k__BackingField;
    private int <MstIdolId>k__BackingField;
    public int Id { get; set; }
    public int MstShinyCompetitionId { get; set; }
    public int RankingType { get; set; }
    public int MstIdolId { get; set; }
    public int CompareTo(PRISM.Definitions.MstShinyCompetitionRanking other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstShinyCompetitionRanking& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstShinyCompetitionRanking& value);

    private class MstShinyCompetitionRankingFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstShinyCompetitionRanking>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstShinyCompetitionRanking& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstShinyCompetitionRanking& value);
    }
}

// Namespace: PRISM.Definitions
public class MstSkillBufferDisplay : System.IComparable<PRISM.Definitions.MstSkillBufferDisplay>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstSkillBufferDisplay>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <MstSkillBufferIconId>k__BackingField;
    private int <MstSkillBufferGroupId>k__BackingField;
    private int <SimpleDisplayId>k__BackingField;
    public int Id { get; set; }
    public int MstSkillBufferIconId { get; set; }
    public int MstSkillBufferGroupId { get; set; }
    public int SimpleDisplayId { get; set; }
    public int CompareTo(PRISM.Definitions.MstSkillBufferDisplay other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstSkillBufferDisplay& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstSkillBufferDisplay& value);

    private class MstSkillBufferDisplayFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstSkillBufferDisplay>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstSkillBufferDisplay& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstSkillBufferDisplay& value);
    }
}

// Namespace: PRISM.Definitions
public class MstSong : PRISM.Definitions.IMstMvStage, System.IComparable<PRISM.Definitions.MstSong>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstSong>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private string <MvScene>k__BackingField;
    private int <MstSongTypeId>k__BackingField;
    private int <MstUnitId>k__BackingField;
    private int <SortId>k__BackingField;
    private int <Attribute>k__BackingField;
    private bool <IsSongParts>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<string> <LimitedSongPartsUnlockProductList>k__BackingField;
    private bool <IsFocusCamera>k__BackingField;
    private bool <Is3D>k__BackingField;
    private bool <Is2D>k__BackingField;
    private bool <IsHDR>k__BackingField;
    private bool <IsLDR>k__BackingField;
    private bool <IsMvOnly>k__BackingField;
    private int <ResultBg>k__BackingField;
    private string <PurchaseLink>k__BackingField;
    private System.DateTime <PurchaseLinkActiveDate>k__BackingField;
    private System.DateTime <EndDate>k__BackingField;
    private System.DateTime <PublicDate>k__BackingField;
    private int <StageAudioType>k__BackingField;
    private PRISM.Definitions.MstSongType <SongType>k__BackingField;
    public int Id { get; set; }
    public PRISM.Definitions.LocalizationKey Name { get; set; }
    public PRISM.Definitions.LocalizationKey ReadName { get; set; }
    public PRISM.Definitions.LocalizationKey Artist { get; set; }
    public PRISM.Definitions.LocalizationKey Lyricist { get; set; }
    public PRISM.Definitions.LocalizationKey Composer { get; set; }
    public PRISM.Definitions.LocalizationKey Arranger { get; set; }
    public string CueSheet { get; set; }
    public string MvScene { get; set; }
    public int MstSongTypeId { get; set; }
    public int MstUnitId { get; set; }
    public int SortId { get; set; }
    public int Attribute { get; set; }
    public bool IsSongParts { get; set; }
    public System.Collections.Generic.IReadOnlyList<string> LimitedSongPartsUnlockProductList { get; set; }
    public bool IsFocusCamera { get; set; }
    public bool Is3D { get; set; }
    public bool Is2D { get; set; }
    public bool IsHDR { get; set; }
    public bool IsLDR { get; set; }
    public bool IsMvOnly { get; set; }
    public int ResultBg { get; set; }
    public string PurchaseLink { get; set; }
    public System.DateTime PurchaseLinkActiveDate { get; set; }
    public System.DateTime EndDate { get; set; }
    public System.DateTime PublicDate { get; set; }
    public int StageAudioType { get; set; }
    public string JacketImagePath { get; set; }
    public string BackgroundImagePath { get; set; }
    public PRISM.Definitions.MstSongType SongType { get; set; }
    public int CompareTo(PRISM.Definitions.MstSong other);
    public int CompareTo(int key);
    public void BindReferences(PRISM.Definitions.MasterData masterData);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstSong& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstSong& value);

    private class MstSongFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstSong>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstSong& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstSong& value);
    }
}

// Namespace: PRISM.Definitions
public class MstSongDifficultyLevel : System.IComparable<PRISM.Definitions.MstSongDifficultyLevel>, System.IComparable<System.ValueTuple<int, int>>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstSongDifficultyLevel>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <MstSongId>k__BackingField;
    private int <DifficultyLevel>k__BackingField;
    private int <SongLevel>k__BackingField;
    private int <SongLevelForScoreRank>k__BackingField;
    private int <Notes>k__BackingField;
    public int MstSongId { get; set; }
    public int DifficultyLevel { get; set; }
    public int SongLevel { get; set; }
    public int SongLevelForScoreRank { get; set; }
    public int Notes { get; set; }
    public int CompareTo(PRISM.Definitions.MstSongDifficultyLevel other);
    public int CompareTo(System.ValueTuple<int, int> key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstSongDifficultyLevel& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstSongDifficultyLevel& value);

    private class MstSongDifficultyLevelFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstSongDifficultyLevel>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstSongDifficultyLevel& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstSongDifficultyLevel& value);
    }
}

// Namespace: PRISM.Definitions
public class MstSongOverrideOnStageIdolCount : System.IComparable<PRISM.Definitions.MstSongOverrideOnStageIdolCount>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstSongOverrideOnStageIdolCount>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <MstSongId>k__BackingField;
    private int <OnStageCount>k__BackingField;
    public int MstSongId { get; set; }
    public int OnStageCount { get; set; }
    public int CompareTo(PRISM.Definitions.MstSongOverrideOnStageIdolCount other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstSongOverrideOnStageIdolCount& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstSongOverrideOnStageIdolCount& value);

    private class MstSongOverrideOnStageIdolCountFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstSongOverrideOnStageIdolCount>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstSongOverrideOnStageIdolCount& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstSongOverrideOnStageIdolCount& value);
    }
}

// Namespace: PRISM.Definitions
public class MstSongPartsCharacter : System.IComparable<PRISM.Definitions.MstSongPartsCharacter>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstSongPartsCharacter>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <MstSongId>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<int> <MstCharacterIdList>k__BackingField;
    public int MstSongId { get; set; }
    public System.Collections.Generic.IReadOnlyList<int> MstCharacterIdList { get; set; }
    public int CompareTo(PRISM.Definitions.MstSongPartsCharacter other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstSongPartsCharacter& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstSongPartsCharacter& value);

    private class MstSongPartsCharacterFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstSongPartsCharacter>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstSongPartsCharacter& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstSongPartsCharacter& value);
    }
}

// Namespace: PRISM.Definitions
public class MstSongPositionExample : System.IComparable<PRISM.Definitions.MstSongPositionExample>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstSongPositionExample>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <MstSongId>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<int> <MstCharacterIdList>k__BackingField;
    public int MstSongId { get; set; }
    public System.Collections.Generic.IReadOnlyList<int> MstCharacterIdList { get; set; }
    public int CompareTo(PRISM.Definitions.MstSongPositionExample other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstSongPositionExample& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstSongPositionExample& value);

    private class MstSongPositionExampleFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstSongPositionExample>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstSongPositionExample& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstSongPositionExample& value);
    }
}

// Namespace: PRISM.Definitions
public class MstSongSpecialStartVoice : MemoryPack.IMemoryPackable<PRISM.Definitions.MstSongSpecialStartVoice>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <MstSongId>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<int> <MstCharacterIdList>k__BackingField;
    private int <Index>k__BackingField;
    public int MstSongId { get; set; }
    public System.Collections.Generic.IReadOnlyList<int> MstCharacterIdList { get; set; }
    public int Index { get; set; }
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstSongSpecialStartVoice& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstSongSpecialStartVoice& value);

    private class MstSongSpecialStartVoiceFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstSongSpecialStartVoice>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstSongSpecialStartVoice& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstSongSpecialStartVoice& value);
    }
}

// Namespace: PRISM.Definitions
public class MstSongType : System.IComparable<PRISM.Definitions.MstSongType>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstSongType>, MemoryPack.IMemoryPackFormatterRegister
{
    public static PRISM.Definitions.MstSongType All;
    private int <Id>k__BackingField;
    public int Id { get; set; }
    public string IconPath { get; set; }
    public string TabIconPath { get; set; }
    public int CompareTo(PRISM.Definitions.MstSongType other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstSongType& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstSongType& value);

    private class MstSongTypeFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstSongType>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstSongType& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstSongType& value);
    }
}

// Namespace: PRISM.Definitions
public class MstSpecialMission : System.IComparable<PRISM.Definitions.MstSpecialMission>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstSpecialMission>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private EnumSpecialMissionType <SpecialMissionType>k__BackingField;
    public int Id { get; set; }
    public EnumSpecialMissionType SpecialMissionType { get; set; }
    public int CompareTo(PRISM.Definitions.MstSpecialMission other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstSpecialMission& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstSpecialMission& value);

    public enum EnumSpecialMissionType : System.Enum
    {
        public int value__;
        public static EnumSpecialMissionType BeginnerMission;
    }

    private class MstSpecialMissionFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstSpecialMission>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstSpecialMission& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstSpecialMission& value);
    }
}

// Namespace: PRISM.Definitions
public class MstStarGrowth : System.IComparable<PRISM.Definitions.MstStarGrowth>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstStarGrowth>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private string <Name>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<float> <Growth>k__BackingField;
    public int Id { get; set; }
    public string Name { get; set; }
    public System.Collections.Generic.IReadOnlyList<float> Growth { get; set; }
    public int CompareTo(PRISM.Definitions.MstStarGrowth other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstStarGrowth& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstStarGrowth& value);

    private class MstStarGrowthFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstStarGrowth>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstStarGrowth& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstStarGrowth& value);
    }
}

// Namespace: PRISM.Definitions
public class MstStoryReadCountReward : MemoryPack.IMemoryPackable<PRISM.Definitions.MstStoryReadCountReward>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <StoryType>k__BackingField;
    private int <ReadCount>k__BackingField;
    private int <SortId>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<string> <RewardProductList>k__BackingField;
    public int StoryType { get; set; }
    public int ReadCount { get; set; }
    public int SortId { get; set; }
    public System.Collections.Generic.IReadOnlyList<string> RewardProductList { get; set; }
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstStoryReadCountReward& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstStoryReadCountReward& value);

    private class MstStoryReadCountRewardFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstStoryReadCountReward>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstStoryReadCountReward& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstStoryReadCountReward& value);
    }
}

// Namespace: PRISM.Definitions
public class MstStreamProgram : System.IComparable<PRISM.Definitions.MstStreamProgram>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstStreamProgram>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <StandbyIntImage>k__BackingField;
    private int <StartingIntImage>k__BackingField;
    private int <EndIntImage>k__BackingField;
    private int <GenericThumbnailId>k__BackingField;
    public int Id { get; set; }
    public int StandbyIntImage { get; set; }
    public int StartingIntImage { get; set; }
    public int EndIntImage { get; set; }
    public int GenericThumbnailId { get; set; }
    public string ThumbnailImagePath { get; set; }
    public string ThumbnailSmallImagePath { get; set; }
    public string ThumbnailCommonImagePath { get; set; }
    public int CompareTo(PRISM.Definitions.MstStreamProgram other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstStreamProgram& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstStreamProgram& value);

    private class MstStreamProgramFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstStreamProgram>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstStreamProgram& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstStreamProgram& value);
    }
}

// Namespace: PRISM.Definitions
public class MstSubSeasonOpeningAdvOption : MemoryPack.IMemoryPackable<PRISM.Definitions.MstSubSeasonOpeningAdvOption>, MemoryPack.IMemoryPackFormatterRegister
{
    private string <ScenarioId>k__BackingField;
    private int <Option0CharaId>k__BackingField;
    private int <Option1CharaId>k__BackingField;
    private int <Option2CharaId>k__BackingField;
    private int <Option3CharaId>k__BackingField;
    private int <Option4CharaId>k__BackingField;
    public string ScenarioId { get; set; }
    public int Option0CharaId { get; set; }
    public int Option1CharaId { get; set; }
    public int Option2CharaId { get; set; }
    public int Option3CharaId { get; set; }
    public int Option4CharaId { get; set; }
    public int[] Options { get; set; }
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstSubSeasonOpeningAdvOption& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstSubSeasonOpeningAdvOption& value);

    private class MstSubSeasonOpeningAdvOptionFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstSubSeasonOpeningAdvOption>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstSubSeasonOpeningAdvOption& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstSubSeasonOpeningAdvOption& value);
    }
}

// Namespace: PRISM.Definitions
public class MstSupportCharacter : System.IComparable<PRISM.Definitions.MstSupportCharacter>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstSupportCharacter>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <MstCharacterId>k__BackingField;
    private int <Rarity>k__BackingField;
    private int <GoodScheduleDetailType>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<int> <MstPotentialSupportSkillIdList>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<int> <MstSupportEffectIdList>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<int> <UnlockPremiseLevelList>k__BackingField;
    private System.DateTime <ReleaseDate>k__BackingField;
    private string <LimitBreakRecipeProductId>k__BackingField;
    private int <SignPositionIndex>k__BackingField;
    private int <InitialVocal>k__BackingField;
    private int <InitialDance>k__BackingField;
    private int <InitialVisual>k__BackingField;
    private int <InitialMental>k__BackingField;
    private int <MaxLevelVocal>k__BackingField;
    private int <MaxLevelDance>k__BackingField;
    private int <MaxLevelVisual>k__BackingField;
    private int <MaxLevelMental>k__BackingField;
    private int <MstLiveSupportEffectId>k__BackingField;
    private PRISM.Definitions.MstCharacterInfo <CharacterInfo>k__BackingField;
    private PRISM.Definitions.MstLiveSupportEffect <LiveSupportEffect>k__BackingField;
    public int Id { get; set; }
    public int MstCharacterId { get; set; }
    public PRISM.Definitions.LocalizationKey Name { get; set; }
    public int Rarity { get; set; }
    public int GoodScheduleDetailType { get; set; }
    public System.Collections.Generic.IReadOnlyList<int> MstPotentialSupportSkillIdList { get; set; }
    public System.Collections.Generic.IReadOnlyList<int> MstSupportEffectIdList { get; set; }
    public System.Collections.Generic.IReadOnlyList<int> UnlockPremiseLevelList { get; set; }
    public System.DateTime ReleaseDate { get; set; }
    public string LimitBreakRecipeProductId { get; set; }
    public int SignPositionIndex { get; set; }
    public int InitialVocal { get; set; }
    public int InitialDance { get; set; }
    public int InitialVisual { get; set; }
    public int InitialMental { get; set; }
    public int MaxLevelVocal { get; set; }
    public int MaxLevelDance { get; set; }
    public int MaxLevelVisual { get; set; }
    public int MaxLevelMental { get; set; }
    public int MstLiveSupportEffectId { get; set; }
    public string ADVStillImagePath { get; set; }
    public string IconRectImagePath { get; set; }
    public string IconSqImagePath { get; set; }
    public PRISM.Definitions.MstCharacterInfo CharacterInfo { get; set; }
    public PRISM.Definitions.MstLiveSupportEffect LiveSupportEffect { get; set; }
    public int CompareTo(PRISM.Definitions.MstSupportCharacter other);
    public int CompareTo(int key);
    public void BindReferences(PRISM.Definitions.MasterData masterData);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstSupportCharacter& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstSupportCharacter& value);

    private class MstSupportCharacterFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstSupportCharacter>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstSupportCharacter& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstSupportCharacter& value);
    }
}

// Namespace: PRISM.Definitions
public class MstSupportCharacterEvent : System.IComparable<PRISM.Definitions.MstSupportCharacterEvent>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstSupportCharacterEvent>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <ProductType>k__BackingField;
    private string <MstAdvInfoId>k__BackingField;
    private int <MstSupportCharacterId>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<int> <MstCharacterInfoIdList>k__BackingField;
    private int <ScenarioId>k__BackingField;
    private int <ScenarioNumber>k__BackingField;
    private int <MstProduceScenarioRewardGroupId>k__BackingField;
    private System.DateTime <ReleaseDate>k__BackingField;
    private bool <IsInvisible>k__BackingField;
    private int <SortId>k__BackingField;
    private bool <IsNonTitle>k__BackingField;
    public int Id { get; set; }
    public int ProductType { get; set; }
    public string MstAdvInfoId { get; set; }
    public int MstSupportCharacterId { get; set; }
    public System.Collections.Generic.IReadOnlyList<int> MstCharacterInfoIdList { get; set; }
    public int ScenarioId { get; set; }
    public int ScenarioNumber { get; set; }
    public int MstProduceScenarioRewardGroupId { get; set; }
    public System.DateTime ReleaseDate { get; set; }
    public bool IsInvisible { get; set; }
    public int SortId { get; set; }
    public bool IsNonTitle { get; set; }
    public int CompareTo(PRISM.Definitions.MstSupportCharacterEvent other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstSupportCharacterEvent& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstSupportCharacterEvent& value);

    private class MstSupportCharacterEventFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstSupportCharacterEvent>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstSupportCharacterEvent& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstSupportCharacterEvent& value);
    }
}

// Namespace: PRISM.Definitions
public class MstSupportCharacterLevelExp : MemoryPack.IMemoryPackable<PRISM.Definitions.MstSupportCharacterLevelExp>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Rarity>k__BackingField;
    private int <Level>k__BackingField;
    private int <Exp>k__BackingField;
    public int Rarity { get; set; }
    public int Level { get; set; }
    public int Exp { get; set; }
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstSupportCharacterLevelExp& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstSupportCharacterLevelExp& value);

    private class MstSupportCharacterLevelExpFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstSupportCharacterLevelExp>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstSupportCharacterLevelExp& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstSupportCharacterLevelExp& value);
    }
}

// Namespace: PRISM.Definitions
public class MstSupportCharacterLevelReward : System.IComparable<PRISM.Definitions.MstSupportCharacterLevelReward>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstSupportCharacterLevelReward>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <Level>k__BackingField;
    private int <MstSupportCharacterId>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<string> <RewardList>k__BackingField;
    public int Id { get; set; }
    public int Level { get; set; }
    public int MstSupportCharacterId { get; set; }
    public System.Collections.Generic.IReadOnlyList<string> RewardList { get; set; }
    public int CompareTo(PRISM.Definitions.MstSupportCharacterLevelReward other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstSupportCharacterLevelReward& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstSupportCharacterLevelReward& value);

    private class MstSupportCharacterLevelRewardFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstSupportCharacterLevelReward>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstSupportCharacterLevelReward& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstSupportCharacterLevelReward& value);
    }
}

// Namespace: PRISM.Definitions
public class MstSupportCharacterLimitBreakBonus : MemoryPack.IMemoryPackable<PRISM.Definitions.MstSupportCharacterLimitBreakBonus>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Rarity>k__BackingField;
    private int <Diamond>k__BackingField;
    private int <SkillSlot>k__BackingField;
    private int <LimitLv>k__BackingField;
    public int Rarity { get; set; }
    public int Diamond { get; set; }
    public int SkillSlot { get; set; }
    public int LimitLv { get; set; }
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstSupportCharacterLimitBreakBonus& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstSupportCharacterLimitBreakBonus& value);

    private class MstSupportCharacterLimitBreakBonusFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstSupportCharacterLimitBreakBonus>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstSupportCharacterLimitBreakBonus& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstSupportCharacterLimitBreakBonus& value);
    }
}

// Namespace: PRISM.Definitions
public class MstSupportCharacterLimitBreakRecipe : System.IComparable<PRISM.Definitions.MstSupportCharacterLimitBreakRecipe>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstSupportCharacterLimitBreakRecipe>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <Rarity>k__BackingField;
    private int <Diamond>k__BackingField;
    private int <Amount>k__BackingField;
    public int Id { get; set; }
    public int Rarity { get; set; }
    public int Diamond { get; set; }
    public int Amount { get; set; }
    public int CompareTo(PRISM.Definitions.MstSupportCharacterLimitBreakRecipe other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstSupportCharacterLimitBreakRecipe& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstSupportCharacterLimitBreakRecipe& value);

    private class MstSupportCharacterLimitBreakRecipeFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstSupportCharacterLimitBreakRecipe>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstSupportCharacterLimitBreakRecipe& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstSupportCharacterLimitBreakRecipe& value);
    }
}

// Namespace: PRISM.Definitions
public class MstSupportEffect : System.IComparable<PRISM.Definitions.MstSupportEffect>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstSupportEffect>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <EffectId>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<int> <MstProducePassiveEffectIdList>k__BackingField;
    private int <EntrustAppealType>k__BackingField;
    private int <EntrustScore>k__BackingField;
    private int <ChoiceWeight>k__BackingField;
    public int Id { get; set; }
    public int EffectId { get; set; }
    public PRISM.Definitions.LocalizationKey Name { get; set; }
    public PRISM.Definitions.LocalizationKey Description { get; set; }
    public System.Collections.Generic.IReadOnlyList<int> MstProducePassiveEffectIdList { get; set; }
    public int EntrustAppealType { get; set; }
    public int EntrustScore { get; set; }
    public int ChoiceWeight { get; set; }
    public int CompareTo(PRISM.Definitions.MstSupportEffect other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstSupportEffect& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstSupportEffect& value);

    private class MstSupportEffectFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstSupportEffect>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstSupportEffect& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstSupportEffect& value);
    }
}

// Namespace: PRISM.Definitions
public class MstTechnicalRankReward : MemoryPack.IMemoryPackable<PRISM.Definitions.MstTechnicalRankReward>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <MstEventId>k__BackingField;
    private int <MstTechnicalRankTargetId>k__BackingField;
    private System.Collections.Generic.IReadOnlyList<string> <RewardList>k__BackingField;
    public int MstEventId { get; set; }
    public int MstTechnicalRankTargetId { get; set; }
    public System.Collections.Generic.IReadOnlyList<string> RewardList { get; set; }
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstTechnicalRankReward& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstTechnicalRankReward& value);

    private class MstTechnicalRankRewardFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstTechnicalRankReward>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstTechnicalRankReward& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstTechnicalRankReward& value);
    }
}

// Namespace: PRISM.Definitions
public class MstTechnicalRankTarget : System.IComparable<PRISM.Definitions.MstTechnicalRankTarget>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstTechnicalRankTarget>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <TechnicalRank>k__BackingField;
    private int <Score>k__BackingField;
    public int TechnicalRank { get; set; }
    public int Score { get; set; }
    public int CompareTo(PRISM.Definitions.MstTechnicalRankTarget other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstTechnicalRankTarget& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstTechnicalRankTarget& value);

    private class MstTechnicalRankTargetFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstTechnicalRankTarget>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstTechnicalRankTarget& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstTechnicalRankTarget& value);
    }
}

// Namespace: PRISM.Definitions
public class MstTips : MemoryPack.IMemoryPackable<PRISM.Definitions.MstTips>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <MstTipsCategoryId>k__BackingField;
    private int <Weight>k__BackingField;
    public int Id { get; set; }
    public int MstTipsCategoryId { get; set; }
    public PRISM.Definitions.LocalizationKey Title { get; set; }
    public PRISM.Definitions.LocalizationKey Description { get; set; }
    public int Weight { get; set; }
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstTips& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstTips& value);

    private class MstTipsFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstTips>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstTips& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstTips& value);
    }
}

// Namespace: PRISM.Definitions
public class MstTipsCategory : System.IComparable<PRISM.Definitions.MstTipsCategory>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstTipsCategory>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private string <Color>k__BackingField;
    public int Id { get; set; }
    public PRISM.Definitions.LocalizationKey Title { get; set; }
    public string Color { get; set; }
    public int CompareTo(PRISM.Definitions.MstTipsCategory other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstTipsCategory& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstTipsCategory& value);

    private class MstTipsCategoryFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstTipsCategory>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstTipsCategory& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstTipsCategory& value);
    }
}

// Namespace: PRISM.Definitions
public class MstTitleBackground : MemoryPack.IMemoryPackable<PRISM.Definitions.MstTitleBackground>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <BackgroundType>k__BackingField;
    private string <BackgroundKey>k__BackingField;
    private string <BgmCueSheetName>k__BackingField;
    private string <BgmCueName>k__BackingField;
    private string <TitleCallCueSheetName>k__BackingField;
    private string <TitleCallCueName>k__BackingField;
    private System.DateTime <BeginDate>k__BackingField;
    private System.DateTime <EndDate>k__BackingField;
    public int BackgroundType { get; set; }
    public string BackgroundKey { get; set; }
    public string BgmCueSheetName { get; set; }
    public string BgmCueName { get; set; }
    public string TitleCallCueSheetName { get; set; }
    public string TitleCallCueName { get; set; }
    public System.DateTime BeginDate { get; set; }
    public System.DateTime EndDate { get; set; }
    public PRISM.Definitions.TitleBackgroundType GetTitleBackgroundType();
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstTitleBackground& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstTitleBackground& value);

    private class MstTitleBackgroundFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstTitleBackground>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstTitleBackground& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstTitleBackground& value);
    }
}

// Namespace: PRISM.Definitions
public enum TitleBackgroundType : System.Enum
{
    public int value__;
    public static PRISM.Definitions.TitleBackgroundType Image;
    public static PRISM.Definitions.TitleBackgroundType Movie;
}

// Namespace: PRISM.Definitions
public class MstTrainingTicket : System.IComparable<PRISM.Definitions.MstTrainingTicket>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstTrainingTicket>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <Exp>k__BackingField;
    private int <NeedMoney>k__BackingField;
    public int Id { get; set; }
    public PRISM.Definitions.LocalizationKey Name { get; set; }
    public PRISM.Definitions.LocalizationKey Description { get; set; }
    public int Exp { get; set; }
    public int NeedMoney { get; set; }
    public int CompareTo(PRISM.Definitions.MstTrainingTicket other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstTrainingTicket& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstTrainingTicket& value);

    private class MstTrainingTicketFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstTrainingTicket>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstTrainingTicket& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstTrainingTicket& value);
    }
}

// Namespace: PRISM.Definitions
public class MstTutorial : MemoryPack.IMemoryPackable<PRISM.Definitions.MstTutorial>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <TutorialCategory>k__BackingField;
    private int <Phase>k__BackingField;
    public int TutorialCategory { get; set; }
    public int Phase { get; set; }
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstTutorial& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstTutorial& value);

    private class MstTutorialFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstTutorial>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstTutorial& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstTutorial& value);
    }
}

// Namespace: PRISM.Definitions
public class MstTwestaArticle : System.IComparable<PRISM.Definitions.MstTwestaArticle>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstTwestaArticle>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private int <Thumbnail>k__BackingField;
    private int <SpecialContentType>k__BackingField;
    public int Id { get; set; }
    public PRISM.Definitions.LocalizationKey Name { get; set; }
    public PRISM.Definitions.LocalizationKey Body { get; set; }
    public int Thumbnail { get; set; }
    public int SpecialContentType { get; set; }
    public System.Collections.Generic.IEnumerable<string> GetThumbnailPaths();
    public System.Nullable<System.ValueTuple<string, string>> GetMovieKey();
    private string _createDefaultThumbnailKey();
    public int CompareTo(PRISM.Definitions.MstTwestaArticle other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstTwestaArticle& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstTwestaArticle& value);

    public enum SpecialContentTypeEnum : System.Enum
    {
        public int value__;
        public static SpecialContentTypeEnum Normal;
        public static SpecialContentTypeEnum ExtraThumbnail;
        public static SpecialContentTypeEnum Movie;
    }

    private class MstTwestaArticleFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstTwestaArticle>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstTwestaArticle& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstTwestaArticle& value);
    }

    private class <GetThumbnailPaths>d__17 : System.Collections.Generic.IEnumerable<string>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<string>, System.Collections.IEnumerator, System.IDisposable
    {
        private int <>1__state;
        private string <>2__current;
        private int <>l__initialThreadId;
        public PRISM.Definitions.MstTwestaArticle <>4__this;
        private string System.Collections.Generic.IEnumerator<System.String>.Current { get; set; }
        private object System.Collections.IEnumerator.Current { get; set; }
        private void System.IDisposable.Dispose();
        private bool MoveNext();
        private void System.Collections.IEnumerator.Reset();
        private System.Collections.Generic.IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator();
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
    }
}

// Namespace: PRISM.Definitions
public class MstTwestaComment : System.IComparable<PRISM.Definitions.MstTwestaComment>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstTwestaComment>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    public int Id { get; set; }
    public PRISM.Definitions.LocalizationKey Body { get; set; }
    public int CompareTo(PRISM.Definitions.MstTwestaComment other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstTwestaComment& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstTwestaComment& value);

    private class MstTwestaCommentFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstTwestaComment>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstTwestaComment& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstTwestaComment& value);
    }
}

// Namespace: PRISM.Definitions
public class MstTwestaUser : System.IComparable<PRISM.Definitions.MstTwestaUser>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstTwestaUser>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    public int Id { get; set; }
    public PRISM.Definitions.LocalizationKey Name { get; set; }
    public PRISM.Definitions.LocalizationKey Profile { get; set; }
    public string IconPath { get; set; }
    public int CompareTo(PRISM.Definitions.MstTwestaUser other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstTwestaUser& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstTwestaUser& value);

    private class MstTwestaUserFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstTwestaUser>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstTwestaUser& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstTwestaUser& value);
    }
}

// Namespace: PRISM.Definitions
public class MstUnit : System.IComparable<PRISM.Definitions.MstUnit>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstUnit>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private string <ColorCode>k__BackingField;
    private int <MstProductionId>k__BackingField;
    public int Id { get; set; }
    public PRISM.Definitions.LocalizationKey Name { get; set; }
    public string ColorCode { get; set; }
    public int MstProductionId { get; set; }
    public string SymbolImagePath { get; set; }
    public string LogoLargeImagePath { get; set; }
    public string IconImagePath { get; set; }
    public string IconWithOutlineImagePath { get; set; }
    public string IconSmallImagePath { get; set; }
    public string IconExtraLargeImagePath { get; set; }
    public string TutorialUnitTabImagePath { get; set; }
    public string EpisodeZeroStorySelectUnitLogoImagePath { get; set; }
    public string EpisodeZeroStorySelectUnitColorTapeImagePath { get; set; }
    public bool Is283Production();
    public bool Is765Production();
    public int CompareTo(PRISM.Definitions.MstUnit other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstUnit& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstUnit& value);

    private class MstUnitFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstUnit>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstUnit& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstUnit& value);
    }
}

// Namespace: PRISM.Definitions
public class MstVoiceResource : System.IComparable<PRISM.Definitions.MstVoiceResource>, System.IComparable<int>, MemoryPack.IMemoryPackable<PRISM.Definitions.MstVoiceResource>, MemoryPack.IMemoryPackFormatterRegister
{
    private int <Id>k__BackingField;
    private string <CueSheetName>k__BackingField;
    private string <CueName>k__BackingField;
    public int Id { get; set; }
    public PRISM.Definitions.LocalizationKey Text { get; set; }
    public string CueSheetName { get; set; }
    public string CueName { get; set; }
    public int CompareTo(PRISM.Definitions.MstVoiceResource other);
    public int CompareTo(int key);
    public static void RegisterFormatter();
    public static void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstVoiceResource& value);
    public static void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstVoiceResource& value);

    private class MstVoiceResourceFormatter : MemoryPack.MemoryPackFormatter<PRISM.Definitions.MstVoiceResource>
    {
        public void Serialize(MemoryPack.MemoryPackWriter& writer, PRISM.Definitions.MstVoiceResource& value);
        public void Deserialize(MemoryPack.MemoryPackReader& reader, PRISM.Definitions.MstVoiceResource& value);
    }
}

// Namespace: PRISM.Definitions
public class SortedMasterTable`2<TKey, TValue> : PRISM.Definitions.MasterTable<TValue>
{
    public bool TryGetValue(TKey key, TValue& value);
    public TValue GetValue(TKey key);
    public TValue GetValueOrDefault(TKey key);
    public bool ContainsKey(TKey key);
}

// Namespace: PRISM.Definitions
public class PhotoConst
{
    public static string SaveDateFormat;
}

// Namespace: PRISM.Definitions
public enum ARModeFooterButtonType : System.Enum
{
    public int value__;
    public static PRISM.Definitions.ARModeFooterButtonType Light;
    public static PRISM.Definitions.ARModeFooterButtonType Idol;
    public static PRISM.Definitions.ARModeFooterButtonType Costume;
    public static PRISM.Definitions.ARModeFooterButtonType Pose;
}

// Namespace: PRISM.Definitions
public enum SituationModeFooterButtonType : System.Enum
{
    public int value__;
    public static PRISM.Definitions.SituationModeFooterButtonType Light;
    public static PRISM.Definitions.SituationModeFooterButtonType Costume;
    public static PRISM.Definitions.SituationModeFooterButtonType Situation;
}

// Namespace: PRISM.Definitions
public enum PhotoAlbumFooterType : System.Enum
{
    public int value__;
    public static PRISM.Definitions.PhotoAlbumFooterType Default;
    public static PRISM.Definitions.PhotoAlbumFooterType Favorite;
    public static PRISM.Definitions.PhotoAlbumFooterType Delete;
}

// Namespace: PRISM.Definitions
public class PresentBoxConst
{
    public static int OnceMaxItems;
    public static int HistoryMasItems;
}

// Namespace: PRISM.Definitions
public class ChallengeTourConst
{
    public static string FilterTitle;
    public static string ResultAnimGet;
    public static string ResultAnimStar;
    public static UnityEngine.Vector2[][] ShilhouettePosition;
}

// Namespace: PRISM.Definitions
public class ChallengeTourEnum
{

    public enum StageType : System.Enum
    {
        public int value__;
        public static StageType None;
        public static StageType Normal;
        public static StageType Boss;
    }

    public enum StageFilterType : System.Enum
    {
        public int value__;
        public static StageFilterType NonStar;
        public static StageFilterType Star1;
        public static StageFilterType Star2;
    }

    public enum PIdilUnitDetailTabType : System.Enum
    {
        public int value__;
        public static PIdilUnitDetailTabType ProduceIdol;
        public static PIdilUnitDetailTabType ProduceCard;
    }

    public enum MissionType : System.Enum
    {
        public int value__;
        public static MissionType Clear;
        public static MissionType TimeClear;
        public static MissionType MeHigherClear;
        public static MissionType MeLowerClear;
        public static MissionType EnemyMentalBreakCount;
        public static MissionType NonMentalBreak;
        public static MissionType UseIdolSkillCountHigher;
        public static MissionType UseIdolSkillCountLower;
        public static MissionType VoAppealPoint;
        public static MissionType DaAppealPoint;
        public static MissionType ViAppealPoint;
        public static MissionType DeckCount;
        public static MissionType MeGuardHigher;
        public static MissionType AvoidRate;
        public static MissionType AvoidCount;
        public static MissionType HandCount;
        public static MissionType PhaseChangeCount;
        public static MissionType UseCostOneCardCount;
        public static MissionType UseCostDownCardCount;
        public static MissionType RemoveCardCount;
        public static MissionType VoReleaseCounterCount;
        public static MissionType DaReleaseCounterCount;
        public static MissionType ViReleaseCounterCount;
        public static MissionType MeDamageCount;
        public static MissionType MeRecoveryCount;
    }
}

// Namespace: PRISM.Definitions
public class ProduceConst
{
    public static int TutorialEpisodeId;
    public static int TutorialUnitId;
    public static int MinStaminaRate;
    public static int MaxStaminaRate;
    public static int MaxUnitNameLength;
    public static string RestScenarioIDSuffix;
    public static string AdviceScenarioIDSuffix;
    public static int SupportSkillPopupShowArrowCount;
    public static string AuditionScene;
}

// Namespace: PRISM.Definitions
public class ProduceEnum
{

    public enum LogItemType : System.Enum
    {
        public int value__;
        public static LogItemType None;
        public static LogItemType ProducePolicy;
        public static LogItemType MainScenario;
        public static LogItemType MainIdolScenario;
        public static LogItemType UnitCommunicationScenario;
        public static LogItemType ProduceIdolScenario;
        public static LogItemType SupportCharacterScenario;
        public static LogItemType NormalLimitEventScenario;
        public static LogItemType SubSeasonEventScenario;
        public static LogItemType SubSeasonEventIdolScenario;
        public static LogItemType RecommendScenario;
        public static LogItemType SupportCooperationEvent;
        public static LogItemType Lesson;
        public static LogItemType SpecialLesson;
        public static LogItemType Working;
        public static LogItemType Training;
        public static LogItemType Outing;
        public static LogItemType Shopping;
        public static LogItemType Rest;
        public static LogItemType Advice;
        public static LogItemType Audition;
        public static LogItemType InheritanceSkill;
        public static LogItemType VoiceScenarioRest;
        public static LogItemType VoiceScenarioAdvice;
        public static LogItemType AdvReward;
        public static LogItemType MiniLive;
        public static LogItemType TalkShow;
        public static LogItemType ScriptReading;
        public static LogItemType CostumeFitting;
        public static LogItemType PublicRelations;
        public static LogItemType ActingPractice;
    }
}

// Namespace: PRISM.Definitions
public class ShinyCompetitionEnum
{

    public enum RankingType : System.Enum
    {
        public int value__;
        public static RankingType Top3Total;
        public static RankingType IdolTotal;
    }
}

// Namespace: PRISM.Definitions
public class ProfileConst
{
    public static int MaxNameLenght;
    public static int MaxInputNameLength;
    public static int[] MonthMaxDays;
    public static int MaxCommentLength;
}

// Namespace: PRISM.Definitions
public class ProfileEnum
{

    public enum CategoryType : System.Enum
    {
        public int value__;
        public static CategoryType UserSelf;
        public static CategoryType Progress;
        public static CategoryType History;
    }

    public enum AchievementCategoryType : System.Enum
    {
        public int value__;
        public static AchievementCategoryType Producer;
        public static AchievementCategoryType Character;
        public static AchievementCategoryType Unit;
        public static AchievementCategoryType Live;
        public static AchievementCategoryType Produce;
        public static AchievementCategoryType Event;
        public static AchievementCategoryType Other;
    }

    public enum AchievementType : System.Enum
    {
        public int value__;
        public static AchievementType Normal;
        public static AchievementType Limited;
    }
}

// Namespace: PRISM.Definitions
public class RankingConstant
{
    public static int SpecialRankNumber;
}

// Namespace: PRISM.Definitions
public interface IReadOnlyReactiveHashSet`1<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
{
    public int Count { get; set; }
    public System.IObservable<int> OnCountChanged { get; set; }
    public System.IObservable<T> OnAdd { get; set; }
    public System.IObservable<T> OnRemove { get; set; }
    public bool Contains(T item);
}

// Namespace: PRISM.Definitions
public interface IReactiveHashSet`1<T> : PRISM.Definitions.IReadOnlyReactiveHashSet<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
{
    public bool Add(T item);
    public bool Remove(T item);
    public void Clear();
}

// Namespace: PRISM.Definitions
public class ReactiveHashSet`1<T> : PRISM.Definitions.IReactiveHashSet<T>, PRISM.Definitions.IReadOnlyReactiveHashSet<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.IDisposable
{
    private System.Collections.Generic.HashSet<T> innerHashSet;
    private UniRx.Subject<int> onCountChanged;
    private UniRx.Subject<T> onAdd;
    private UniRx.Subject<T> onRemove;
    public int Count { get; set; }
    public System.IObservable<int> OnCountChanged { get; set; }
    public System.IObservable<T> OnAdd { get; set; }
    public System.IObservable<T> OnRemove { get; set; }
    public System.Collections.Generic.IEnumerator<T> GetEnumerator();
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
    public bool Contains(T item);
    public bool Add(T item);
    public bool Remove(T item);
    public void Clear();
    public void Dispose();
}

// Namespace: PRISM.Definitions
public class ScopedReactiveProperty`1<T> : UniRx.IReadOnlyReactiveProperty<T>, System.IObservable<T>, System.IDisposable
{
    private System.Collections.Generic.List<Scope<T>> scopeList;
    private UniRx.ReactiveProperty<T> innerProperty;
    private PRISM.Definitions.Logger.CategorizedLogger logger;
    public T Value { get; set; }
    public bool HasValue { get; set; }
    public System.IDisposable CreateScope(T value);
    private void _applyValue(string label);
    public void Reset();
    public System.IDisposable Subscribe(System.IObserver<T> observer);
    public void Dispose();

    private class Scope<T> : System.IDisposable
    {
        private PRISM.Definitions.ScopedReactiveProperty<T> parent;
        public T Value;
        public void Dispose();
    }
}

// Namespace: PRISM.Definitions
public class ShopConst
{
    public static int ChargeLimitUnder16;
    public static int ChargeLimitUnder18;
    public static int AgeLimit16;
    public static int AgeLimit18;
    public static int MaxPurchaseCount;
    public static int ProductNameLengthPerLine;
    public static int MaxBirthDayStringLength;
    public static int HistoryShowDays;
    public static int[] ElapsedDaysArrayToPeriodEnd;
}

// Namespace: PRISM.Definitions
public class SkippableCancellationTokenSource : System.Threading.CancellationTokenSource
{
    private bool <IsSkipRequested>k__BackingField;
    public PRISM.Definitions.SkippableCancellationToken SkippableToken { get; set; }
    public bool IsSkipRequested { get; set; }
    public bool IsCancellationRequestedWithoutSkip { get; set; }
    public void Skip();
}

// Namespace: PRISM.Definitions
public struct SkippableCancellationToken : System.ValueType
{
    private PRISM.Definitions.SkippableCancellationTokenSource source;
    public System.Threading.CancellationToken Token { get; set; }
    public bool IsSkipRequested { get; set; }
    public bool IsCancellationRequestedWithoutSkip { get; set; }
    public static System.Threading.CancellationToken op_Implicit(PRISM.Definitions.SkippableCancellationToken self);
}

// Namespace: PRISM.Definitions
public class SpecialMissionEnum
{

    public enum MissionMstId : System.Enum
    {
        public int value__;
        public static MissionMstId BeginnerMission;
    }
}

// Namespace: PRISM.Definitions
public class StackableSubject`1<T> : UniRx.ISubject<T>, UniRx.ISubject<T, T>, System.IObserver<T>, System.IObservable<T>, System.IDisposable, UniRx.IOptimizedObservable<T>
{
    private System.Collections.Generic.List<System.IObserver<T>> observers;
    private bool isDisposed;
    public void OnNext(T value);
    public System.IDisposable Subscribe(System.IObserver<T> observer);
    public void Dispose();
    public void OnCompleted();
    public void OnError(System.Exception error);
    private void _dispose(System.Action action);
    private bool UniRx.IOptimizedObservable<T>.IsRequiredSubscribeOnCurrentThread();
    private void <OnCompleted>b__5_0();

    private class Subscription<T> : System.IDisposable
    {
        private PRISM.Definitions.StackableSubject<T> parent;
        private System.IObserver<T> unsubscribeTarget;
        private void System.IDisposable.Dispose();
    }

    private class <>c__DisplayClass6_0<T>
    {
        public PRISM.Definitions.StackableSubject<T> <>4__this;
        public System.Exception error;
        private void <OnError>b__0();
    }
}

// Namespace: PRISM.Definitions
public class StreamingEnum
{

    public enum FrontispieceImages : System.Enum
    {
        public int value__;
        public static FrontispieceImages StandBy;
        public static FrontispieceImages BeforeTheStart;
        public static FrontispieceImages AfterTheEnd;
    }

    public enum LiveViewingType : System.Enum
    {
        public int value__;
        public static LiveViewingType Realtime;
        public static LiveViewingType PreRecorded;
        public static LiveViewingType Movie;
    }
}

// Namespace: PRISM.Definitions
public class SystemSettingsConst
{
    public static UnityEngine.ScreenOrientation[] OrientationSettigns;
    public static int DefaultFullScreenIndex;
    public static int DefaultOrientationIndex;
    public static bool DefaultTitleCall;
    public static int DefaultSoundVolume;
    public static int MaxVolume;
    public static bool DefaultSoundIsMute;
    public static string SoundCueSheetName;
    public static string SoundCueName;
}

// Namespace: PRISM.Definitions
public class SystemSettingsEnum
{

    public enum GraphicProperty : System.Enum
    {
        public int value__;
        public static GraphicProperty Graphic;
        public static GraphicProperty Performance;
        public static GraphicProperty Custom;
        public static GraphicProperty Highest;
    }

    public enum UpScalingMode : System.Enum
    {
        public int value__;
        public static UpScalingMode Off;
        public static UpScalingMode Bilinear;
        public static UpScalingMode FidelityFXSuperResolution;
    }

    public enum QualityType : System.Enum
    {
        public int value__;
        public static QualityType Best;
        public static QualityType High;
        public static QualityType Medium;
        public static QualityType Low;
    }

    public enum AntiAliasingSMAA : System.Enum
    {
        public int value__;
        public static AntiAliasingSMAA High;
        public static AntiAliasingSMAA Middle;
        public static AntiAliasingSMAA Low;
        public static AntiAliasingSMAA Off;
    }

    public enum OutlineForMV : System.Enum
    {
        public int value__;
        public static OutlineForMV On;
        public static OutlineForMV PartiallyOn;
        public static OutlineForMV Off;
    }

    public enum RhythmGameMVEffectLevel : System.Enum
    {
        public int value__;
        public static RhythmGameMVEffectLevel High;
        public static RhythmGameMVEffectLevel Low;
        public static RhythmGameMVEffectLevel None;
    }

    public enum PowerSaving : System.Enum
    {
        public int value__;
        public static PowerSaving Off;
        public static PowerSaving On;
    }

    public enum StoryVoiceSetting : System.Enum
    {
        public int value__;
        public static StoryVoiceSetting AlwaysVisible;
        public static StoryVoiceSetting NoDisplayWithVoice;
        public static StoryVoiceSetting NoDisplayNoVoice;
    }

    public enum SkipSetting : System.Enum
    {
        public int value__;
        public static SkipSetting AlwaysVisible;
        public static SkipSetting NoDisplay;
    }

    public enum VolumeSettingsType : System.Enum
    {
        public int value__;
        public static VolumeSettingsType Bgm;
        public static VolumeSettingsType Se;
        public static VolumeSettingsType Voice;
    }

    public enum PhysicsSetting : System.Enum
    {
        public int value__;
        public static PhysicsSetting Default;
        public static PhysicsSetting High;
    }
}

// Namespace: PRISM.Definitions
public class TimelineSceneAssetPath
{
    private static string PrefabRoot;
    public static string TimelineSceneCameraPath;
    public static string TimelineSceneCharacterPath;
    public static string TimelineScenePropPath;
}

// Namespace: PRISM.Definitions
public struct EnumerateOnlyDictionary`2<TKey, TValue> : System.ValueType
{
    private System.Collections.Generic.Dictionary<TKey, TValue> inner;
    public Enumerator<TKey, TValue> GetEnumerator();
}

// Namespace: PRISM.Definitions
public class EnumerateOnlyDictionaryExtensions
{
    public static PRISM.Definitions.EnumerateOnlyDictionary<TKey, TValue> AsEnumerateOnly<TKey, TValue>(System.Collections.Generic.Dictionary<TKey, TValue> dictionary);
}

// Namespace: PRISM.Definitions
public class DisposableUtility
{
    public static System.IDisposable Combine(System.IDisposable disposable1, System.IDisposable disposable2);
    public static System.IDisposable Combine(System.IDisposable disposable1, System.IDisposable disposable2, System.IDisposable disposable3);

    private class CombinedDisposable2 : System.IDisposable
    {
        private System.IDisposable disposable1;
        private System.IDisposable disposable2;
        public void Dispose();
    }

    private class CombinedDisposable3 : System.IDisposable
    {
        private System.IDisposable disposable1;
        private System.IDisposable disposable2;
        private System.IDisposable disposable3;
        public void Dispose();
    }
}

// Namespace: PRISM.Definitions
public class MathUtility
{
    public static int DivCeil(int a, int b);
}

// Namespace: PRISM.Definitions
public class PermutationUtility
{
    public static int[] ToPermutation(int length, int id);
    public static int ToId(System.Collections.Generic.IReadOnlyList<int> array);
}

// Namespace: PRISM.Definitions
public class SimpleCrypt
{
    public static ulong[] Encrypt(string src, ulong seed);
    public static string Decrypt(System.Span<ulong> src);
    private static void _scramble(System.Span<ulong> data);
}

// Namespace: PRISM.Definitions
public class WeightedRandomPicker
{
    public static T Pick<T>(System.Collections.Generic.IReadOnlyList<T> data, System.Func<T, int> weightSelector);

    private class <>c__DisplayClass0_0`1<T>
    {
        public int target;
        public System.Func<T, int> weightSelector;
        private bool <Pick>b__0(T x);
    }
}

// Namespace: PRISM.Definitions.Utility
public class StringUtility
{
    public static string CreateRandomString(int length);
    public static string JoinURL(string url, string query);
}

// Namespace: PRISM.Definitions.Shop
public class ShopAssetKeyConst
{
    public static string MultiProductIconKey;
}

// Namespace: PRISM.Definitions.Shop
public class ShopEnums
{

    public enum GroupType : System.Enum
    {
        public int value__;
        public static GroupType None;
        public static GroupType Jewel;
        public static GroupType Item;
        public static GroupType SeasonPass;
        public static GroupType LoginPass;
        public static GroupType Costume;
        public static GroupType LimitedLoginPass;
    }

    public enum ProductPriceType : System.Enum
    {
        public int value__;
        public static ProductPriceType None;
        public static ProductPriceType Cash;
        public static ProductPriceType PaidJewel;
        public static ProductPriceType FreeJewel;
    }

    public enum ItemMasterType : System.Enum
    {
        public int value__;
        public static ItemMasterType None;
        public static ItemMasterType Store;
        public static ItemMasterType Shop;
    }

    public enum ImageType : System.Enum
    {
        public int value__;
        public static ImageType SmallIcon;
        public static ImageType LargeIcon;
        public static ImageType PassBg;
        public static ImageType PurchaseHistory;
        public static ImageType Costume;
    }

    public enum MonetaryTypeJpy : System.Enum
    {
        public int value__;
        public static MonetaryTypeJpy Sing;
        public static MonetaryTypeJpy Kanji;
    }

    public enum MonetaryTypeDmmPoint : System.Enum
    {
        public int value__;
        public static MonetaryTypeDmmPoint Pt;
        public static MonetaryTypeDmmPoint Point;
    }
}

// Namespace: PRISM.Definitions.Mobile
public class MobileEnums
{

    public class Call
    {

        public enum Order : System.Enum
        {
            public int value__;
            public static Order Idol;
            public static Order Call;
        }
    }

    public class Chain
    {

        public enum UserCategory : System.Enum
        {
            public int value__;
            public static UserCategory Idol;
            public static UserCategory Unit;
            public static UserCategory Etc;
        }

        public enum PostType : System.Enum
        {
            public int value__;
            public static PostType Balloon;
            public static PostType Stamp;
            public static PostType Thumbnail;
            public static PostType Movie;
        }

        public enum TalkerType : System.Enum
        {
            public int value__;
            public static TalkerType Other;
            public static TalkerType Self;
        }

        public enum TalkScreenType : System.Enum
        {
            public int value__;
            public static TalkScreenType Personal;
            public static TalkScreenType Group;
        }
    }

    public class Common
    {

        public enum Category : System.Enum
        {
            public int value__;
            public static Category Twesta;
            public static Category Chain;
            public static Category Phone;
            public static Category OurStream;
        }

        public enum ScreenType : System.Enum
        {
            public int value__;
            public static ScreenType MobileTop;
            public static ScreenType TwestaTop;
            public static ScreenType TwestaFavorite;
            public static ScreenType TwestaProfile;
            public static ScreenType TwestaDetail;
            public static ScreenType ChainTop;
            public static ScreenType ChainTalk;
            public static ScreenType ChainTalkHistory;
            public static ScreenType ChainProfile;
            public static ScreenType ChainGroupMember;
            public static ScreenType CallTop;
            public static ScreenType CallHistory;
            public static ScreenType CallPlayback;
            public static ScreenType OurStreamTop;
            public static ScreenType OurStreamArchiveDetail;
            public static ScreenType OurStreamFavoriteList;
            public static ScreenType OurStreamLiveViewing;
            public static ScreenType OurStreamArchive;
            public static ScreenType OurStreamArchivePMode;
            public static ScreenType None;
        }
    }

    public class OurStream
    {

        public enum LiveStatus : System.Enum
        {
            public int value__;
            public static LiveStatus Schedule;
            public static LiveStatus OnAir;
            public static LiveStatus End;
        }

        public enum ArchiveCategory : System.Enum
        {
            public int value__;
            public static ArchiveCategory Idol;
            public static ArchiveCategory Unit;
            public static ArchiveCategory Etc;
        }

        public enum OurStreamTicketConfirmPopupResult : System.Enum
        {
            public int value__;
            public static OurStreamTicketConfirmPopupResult Cancel;
            public static OurStreamTicketConfirmPopupResult LiveViewing;
            public static OurStreamTicketConfirmPopupResult OpenYouTube;
            public static OurStreamTicketConfirmPopupResult UseTicket;
        }
    }
}

// Namespace: PRISM.Definitions.Logger
public class CategorizedLogger
{
    private Category category;
    public void Message(Level logLevel, string format, object[] args);
    public void Message(Level logLevel, string format, System.Collections.Generic.IEnumerable<object> args);
    public void Debug(string format, System.Collections.Generic.IEnumerable<object> args);
    public void Debug(string format, object[] args);
    public void Info(string format, System.Collections.Generic.IEnumerable<object> args);
    public void Info(string format, object[] args);
    public void Warning(string format, System.Collections.Generic.IEnumerable<object> args);
    public void Warning(string format, object[] args);
    public void Assert(bool condition, string format, System.Collections.Generic.IEnumerable<object> args);
    public void Assert(bool condition, string format, object[] args);
    public void Error(string format, System.Collections.Generic.IEnumerable<object> args);
    public void Error(string format, object[] args);
    public void CrashReport(string format, System.Collections.Generic.IEnumerable<object> args);
    public void CrashReport(string format, object[] args);
    public void Exception(System.Exception exception, string format, object[] args);
    public void Exception(System.Exception exception);
}

// Namespace: PRISM.Definitions.Logger
public class LogConst
{

    public enum Category : System.Enum
    {
        public int value__;
        public static Category UnityLog;
        public static Category SaveData;
        public static Category ResourceLoader;
        public static Category DebugLogViewer;
        public static Category Asset;
        public static Category Time;
        public static Category AppTrackingTransparency;
        public static Category InputBlock;
        public static Category Gleipnir;
        public static Category Limelight;
        public static Category Boot;
        public static Category NetworkError;
        public static Category Tutorial;
        public static Category Render3D;
        public static Category Live;
        public static Category Character;
        public static Category Shop;
        public static Category Gasha;
        public static Category Mobile;
        public static Category Streaming;
        public static Category Adjust;
        public static Category Produce;
        public static Category SoundManager;
        public static Category Networking;
        public static Category ADV;
        public static Category Notification;
        public static Category PrivacyOption;
        public static Category AppReview;
        public static Category Analytics;
        public static Category Crashlytics;
        public static Category Photo;
        public static Category Scenario;
        public static Category Story;
        public static Category Drama;
    }

    public enum Level : System.Enum
    {
        public int value__;
        public static Level Debug;
        public static Level Info;
        public static Level Warning;
        public static Level Assert;
        public static Level Error;
        public static Level CrashReport;
        public static Level Exception;
    }
}

// Namespace: PRISM.Definitions.Logger
public class LoggerContext
{
    private static PRISM.Definitions.Logger.PRISMLoggerBase <Logger>k__BackingField;
    private PRISM.Definitions.Logger.PRISMLoggerBase Logger { get; set; }
    public static void Register(PRISM.Definitions.Logger.PRISMLoggerBase logger);
}

// Namespace: PRISM.Definitions.Logger
public class PRISMLoggerBase
{
    public void Message(Category category, Level level, string format, object[] args);
    public void ExceptionMessage(Category category, System.Exception exception, string format, object[] args);
}

// Namespace: PRISM.Definitions.Loading
public enum TransitionAnimationType : System.Enum
{
    public int value__;
    public static PRISM.Definitions.Loading.TransitionAnimationType Character;
    public static PRISM.Definitions.Loading.TransitionAnimationType Story;
    public static PRISM.Definitions.Loading.TransitionAnimationType Produce;
    public static PRISM.Definitions.Loading.TransitionAnimationType Live;
    public static PRISM.Definitions.Loading.TransitionAnimationType Shop;
    public static PRISM.Definitions.Loading.TransitionAnimationType Gasha;
}

// Namespace: PRISM.Definitions.Gasha
public class GashaConst
{
    public static int PrismGaugeHelpId;
    public static int ExchangePointHelpId;
}

// Namespace: PRISM.Definitions.DressUpRoom
public class DressUpRoomConst
{
    public static float PatentDeltaY;
    public static float DoubleClickInterval;
    public static float AbandonInterval;
    public static float DefaultCameraPositionY;
    public static float BaseFov;
    public static float TapTolerant;
    public static float VoiceIntervalMin;
    public static float VoiceIntervalMax;
    public static float VoiceStartWaitTime;
    public static string DressUpRoomScenarioName;
    public static string FittingRoomScenarioName;
    public static string VoiceCueSheetSuffix;
    public static float FittingRoomMotionStartTime;
}

// Namespace: PRISM.Definitions.DressUpRoom
public enum MainViewType : System.Enum
{
    public int value__;
    public static PRISM.Definitions.DressUpRoom.MainViewType Top;
    public static PRISM.Definitions.DressUpRoom.MainViewType CostumeChange;
}

// Namespace: PRISM.Definitions.DressUpRoom
public enum VoiceType : System.Enum
{
    public int value__;
    public static PRISM.Definitions.DressUpRoom.VoiceType None;
    public static PRISM.Definitions.DressUpRoom.VoiceType Greeting;
    public static PRISM.Definitions.DressUpRoom.VoiceType DressCostumeChange;
    public static PRISM.Definitions.DressUpRoom.VoiceType Default;
    public static PRISM.Definitions.DressUpRoom.VoiceType Abandon;
    public static PRISM.Definitions.DressUpRoom.VoiceType ShortMotion;
    public static PRISM.Definitions.DressUpRoom.VoiceType CasualCostumeChange;
}

// Namespace: PRISM.Definitions.DressUpRoom
public enum IntervalType : System.Enum
{
    public int value__;
    public static PRISM.Definitions.DressUpRoom.IntervalType Default;
    public static PRISM.Definitions.DressUpRoom.IntervalType Abandon;
    public static PRISM.Definitions.DressUpRoom.IntervalType Mix;
}

// Namespace: PRISM.Definitions.DressUpRoom
public enum DressOrderAvailableFilter : System.Enum
{
    public int value__;
    public static PRISM.Definitions.DressUpRoom.DressOrderAvailableFilter Available;
    public static PRISM.Definitions.DressUpRoom.DressOrderAvailableFilter NotAvailable;
}

// Namespace: PRISM.Definitions.Event
public class TechnicalChallengeAssetKeyConst
{
    public static string BackgroundKey;
}

// Namespace: PRISM.Definitions.Story
public class StoryAssetKeyConst
{
    public static string ProduceIdolScenarioThumbnailKey;
    public static string SupportCharacterScenarioThumbnailKey;
    public static string UnitSubStoryThumbnailKey;
    public static string IdolSubStoryThumbnailKey;
}

// Namespace: PRISM.Definitions.Story
public enum StoryCategoryType : System.Enum
{
    public int value__;
    public static PRISM.Definitions.Story.StoryCategoryType EpisodeZero;
    public static PRISM.Definitions.Story.StoryCategoryType Produce;
    public static PRISM.Definitions.Story.StoryCategoryType Event;
    public static PRISM.Definitions.Story.StoryCategoryType ProduceIdol;
    public static PRISM.Definitions.Story.StoryCategoryType SupportCharacter;
    public static PRISM.Definitions.Story.StoryCategoryType UnitSub;
    public static PRISM.Definitions.Story.StoryCategoryType IdolSub;
    public static PRISM.Definitions.Story.StoryCategoryType Extra;
}

// Namespace: PRISM.Definitions.Story
public class StoryEnums
{

    public enum StoryTopContentType : System.Enum
    {
        public int value__;
        public static StoryTopContentType EpisodeZero;
        public static StoryTopContentType ProduceScenario;
        public static StoryTopContentType Event;
        public static StoryTopContentType Idol;
        public static StoryTopContentType SubStory;
        public static StoryTopContentType Extra;
        public static StoryTopContentType Favorite;
        public static StoryTopContentType Search;
    }

    public enum ProduceScenarioType : System.Enum
    {
        public int value__;
        public static ProduceScenarioType ProduceIdol;
        public static ProduceScenarioType SupportCharacter;
    }

    public enum SubStoryType : System.Enum
    {
        public int value__;
        public static SubStoryType Unit;
        public static SubStoryType Idol;
    }
}

// Namespace: PRISM.Definitions.Drama
public class DramaAssetKeyConst
{
    public static string DramaUIViewKey;
}

// Namespace: PRISM.Definitions.Drama.UI
public enum DramaPlaySpeedType : System.Enum
{
    public int value__;
    public static PRISM.Definitions.Drama.UI.DramaPlaySpeedType Speed1_0;
    public static PRISM.Definitions.Drama.UI.DramaPlaySpeedType Speed1_5;
    public static PRISM.Definitions.Drama.UI.DramaPlaySpeedType Speed2_0;
    public static PRISM.Definitions.Drama.UI.DramaPlaySpeedType Speed4_0;
    public static PRISM.Definitions.Drama.UI.DramaPlaySpeedType Min;
    public static PRISM.Definitions.Drama.UI.DramaPlaySpeedType Max;
}

// Namespace: PRISM.Definitions.Drama.UI
public enum DramaScreenOperationType : System.Enum
{
    public int value__;
    public static PRISM.Definitions.Drama.UI.DramaScreenOperationType Modern;
    public static PRISM.Definitions.Drama.UI.DramaScreenOperationType Legacy;
}

// Namespace: PRISM.Definitions.Adv
public class AdvAssetKeyConst
{
    public static string ProducerLogIconKey;
    public static string PresidentLogIconKey;
    public static string MobLogIconKey;
    public static string MultipleIdolsIconKey;
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=10558 20A804A27392C39E0FCFC3510DA0DDB12F1ABE3AA1BA9AB7194839A04F7AD168;
    private static __StaticArrayInitTypeSize=20 3A795EE993DCFCD47AE2FD7282FAE2348DADC51429112235F8375626F9439A0B;
    private static __StaticArrayInitTypeSize=12 BD62D5246F9FCBE9B2173ED98AA4CB2946971DFFC4B05F7647C09C7B889FF44F;
    private static __StaticArrayInitTypeSize=48 E65577224EAF52384715036A7C44E5D26EDD02CA5E9AB88C8F313AF80E66A646;
    private static __StaticArrayInitTypeSize=17226 E9E3779F486318034600E845EDD40C90D66218910FF25D7A4AF264D07DA1BBEB;

    private struct __StaticArrayInitTypeSize=12 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=20 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=48 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=10558 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=17226 : System.ValueType
    {
    }
}
