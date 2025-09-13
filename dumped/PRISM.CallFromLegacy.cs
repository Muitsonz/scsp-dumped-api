
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

// Namespace: PRISM.CallFromLegacy
public class IdolSkillDetailPopupListCallerImplement : PRISM.Legacy.IIdolSkillDetailListPopupCaller, PRISM.Legacy.ILegacyCaller
{
    public Cysharp.Threading.Tasks.UniTask ShowAsync(int mstIdolSkillId, int currentSkillLv, System.Threading.CancellationToken cancellationToken);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<int, ProduceParameterType> <>9__0_0;
        private ProduceParameterType <ShowAsync>b__0_0(int x);
    }
}

// Namespace: PRISM.CallFromLegacy
public class IdolSkillSingleDetailPopupCallerImplement : PRISM.Legacy.IIdolSkillSingleDetailPopupCaller, PRISM.Legacy.ILegacyCaller
{
    public Cysharp.Threading.Tasks.UniTask ShowAsync(int mstIdolSkillId, int iconId, int pp, System.Collections.Generic.IReadOnlyList<ProduceParameterType> appealTypeList, int level, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IIdolSkillActionEffectStatus> skillDetailValueList, PRISM.Module.Networking.IIdolSkillActionConditionStatus condition, System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(int mstIdolSkillId, int iconId, int pp, System.Collections.Generic.IReadOnlyList<ProduceParameterType> appealTypeList, int level, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceActionEffectStatus> skillDetailValueList, PRISM.Module.Networking.IProduceActionConditionStatus condition, System.Threading.CancellationToken cancellationToken);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Module.Networking.IProduceActionEffectStatus, System.ValueTuple<int, System.Collections.Generic.IReadOnlyList<int>>> <>9__1_0;
        private System.ValueTuple<int, System.Collections.Generic.IReadOnlyList<int>> <ShowAsync>b__1_0(PRISM.Module.Networking.IProduceActionEffectStatus x);
    }
}

// Namespace: PRISM.CallFromLegacy
public class ProduceCardDetailPopupCallerImplement : PRISM.IProduceCardDetailPopupCaller, PRISM.Legacy.ILegacyCaller
{
    public Cysharp.Threading.Tasks.UniTask ShowAsync(PRISM.Module.Networking.IProduceCardStatus produceCard, System.Threading.CancellationToken ct);

    private class <>c__DisplayClass0_0
    {
        public PRISM.Module.Networking.IProduceCardStatus produceCard;
        private void <ShowAsync>b__0(PRISM.Adapters.IProduceCardDetailPopupView view, PRISM.ResourceManagement.IResourceLoader loader);
    }
}

// Namespace: PRISM.CallFromLegacy
public class LiveDefaultBehaviourCallerImplement : PRISM.ILiveDefaultBehaviourCaller, PRISM.Legacy.ILegacyCaller
{
    public PRISM.Live.ILiveBehaviour Create(PRISM.Live.LiveStartData startData, PRISM.Adapters.IRhythmGameSpecialViewLocator locator);
}

// Namespace: PRISM.CallFromLegacy
public class LiveMVOverlayCallerImplement : PRISM.Legacy.ILiveMVOverlayCaller, PRISM.Legacy.ILegacyCaller
{
    public Cysharp.Threading.Tasks.UniTask Start3DMVAsync(PRISM.Live.LiveMVStartData startData, PRISM.Live.LiveProgressManager progressManager, PRISM.EffectPlayer effectPlayer, PRISM.IPausable mvPauser, PRISM.TimelineController timelineController, System.Collections.Generic.IEnumerable<float> cameraChangeTimes);
    public Cysharp.Threading.Tasks.UniTask Start2DMVAsync(PRISM.Live.LiveMVStartData startData, PRISM.Live.LiveProgressManager progressManager);

    private class <>c__DisplayClass0_0
    {
        public PRISM.Live.LiveMVStartData startData;
        public PRISM.Live.LiveProgressManager progressManager;
        public PRISM.IPausable mvPauser;
        public PRISM.TimelineController timelineController;
        public System.Collections.Generic.IEnumerable<float> cameraChangeTimes;
        public PRISM.EffectPlayer effectPlayer;
        private Cysharp.Threading.Tasks.UniTask<System.IDisposable> <Start3DMVAsync>b__0(PRISM.Adapters.Live.ILiveMVOverlayView view, PRISM.ResourceManagement.IResourceLoader _);

        private struct <<Start3DMVAsync>b__0>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
        {
            public int <>1__state;
            public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<System.IDisposable> <>t__builder;
            public <>c__DisplayClass0_0 <>4__this;
            public PRISM.Adapters.Live.ILiveMVOverlayView view;
            private PRISM.Adapters.Live.LiveMVOverlaySequencer <sequencer>5__2;
            private Awaiter <>u__1;
            private void MoveNext();
            private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }

    private class <>c__DisplayClass1_0
    {
        public PRISM.Live.LiveMVStartData startData;
        public PRISM.Live.LiveProgressManager progressManager;
        private Cysharp.Threading.Tasks.UniTask<System.IDisposable> <Start2DMVAsync>b__0(PRISM.Adapters.Live.ILiveMVOverlayView view, PRISM.ResourceManagement.IResourceLoader _);

        private struct <<Start2DMVAsync>b__0>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
        {
            public int <>1__state;
            public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<System.IDisposable> <>t__builder;
            public <>c__DisplayClass1_0 <>4__this;
            public PRISM.Adapters.Live.ILiveMVOverlayView view;
            private PRISM.Adapters.Live.LiveMVOverlaySequencer <sequencer>5__2;
            private Awaiter <>u__1;
            private void MoveNext();
            private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }
}

// Namespace: PRISM.CallFromLegacy
public class LiveSettingPopupCallerImplement : PRISM.Live.ILiveSettingPopupCaller, PRISM.Legacy.ILegacyCaller
{
    public Cysharp.Threading.Tasks.UniTask ShowAsync(string rhythmGameCueSheetName, System.Threading.CancellationToken cancellationToken);
}

// Namespace: PRISM.CallFromLegacy
public class OverlayManagerCallerImplement : PRISM.Legacy.IOverlayManagerCaller, PRISM.Legacy.ILegacyCaller
{
    public Cysharp.Threading.Tasks.UniTask PopAllOverlayAsync();
}

// Namespace: PRISM.CallFromLegacy
public class PIdolDetailPopupCallerImplement : PRISM.UICharacter.IPIdolDetailPopupCaller, PRISM.Legacy.ILegacyCaller
{
    public Cysharp.Threading.Tasks.UniTask LaunchWithADVAsync(int mstProduceIdolId, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask<bool> LaunchWithADVAsync(int mstProduceIdolId, System.Threading.CancellationToken ct, System.Action<PRISM.Module.Networking.IProduceIdolStatus> onChangeFavoriteMarkAction, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceIdolScenarioStatus> produceAdvStatusList, bool inLive);
    public Cysharp.Threading.Tasks.UniTask<bool> LaunchMaximumPIdolFromProductAsync(int mstProduceIdolId, System.Threading.CancellationToken ct, bool withAdvList);
    private Cysharp.Threading.Tasks.UniTask<bool> _launch(PRISM.Adapters.PIdolDetailPopupViewModel vm, System.Threading.CancellationToken ct, System.Action<PRISM.Module.Networking.IProduceIdolStatus> onChangeFavoriteMarkAction);

    private struct <LaunchMaximumPIdolFromProductAsync>d__2 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
        public int mstProduceIdolId;
        public System.Threading.CancellationToken ct;
        public bool withAdvList;
        public PRISM.CallFromLegacy.PIdolDetailPopupCallerImplement <>4__this;
        private PRISM.Module.Networking.IProduceIdolStatus <pIdol>5__2;
        private PRISM.Service.Communicator.IServiceContainer <serviceContainer>5__3;
        private System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceIdolScenarioStatus> <advStatusList>5__4;
        private PRISM.Adapters.PIdolDetailPopupViewModel <vm>5__5;
        private Awaiter<PRISM.Module.Networking.IProduceIdolStatus> <>u__1;
        private Awaiter<PRISM.Module.Networking.IGetProduceIdolScenarioListReply> <>u__2;
        private Awaiter<PRISM.Domain.ICachedCostumeService> <>u__3;
        private Awaiter<bool> <>u__4;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <LaunchWithADVAsync>d__0 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public int mstProduceIdolId;
        public System.Threading.CancellationToken ct;
        private Awaiter<bool> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <LaunchWithADVAsync>d__1 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
        public int mstProduceIdolId;
        public System.Threading.CancellationToken ct;
        public bool inLive;
        public System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceIdolScenarioStatus> produceAdvStatusList;
        public PRISM.CallFromLegacy.PIdolDetailPopupCallerImplement <>4__this;
        public System.Action<PRISM.Module.Networking.IProduceIdolStatus> onChangeFavoriteMarkAction;
        private PRISM.Service.Communicator.IServiceContainer <serviceContainer>5__2;
        private PRISM.Module.Networking.IProduceIdolStatus <pIdol>5__3;
        private PRISM.Domain.ICachedCostumeService <costumeService>5__4;
        private PRISM.Adapters.PIdolDetailPopupViewModel <vm>5__5;
        private Awaiter<PRISM.Module.Networking.IProduceIdolStatus> <>u__1;
        private Awaiter<PRISM.Domain.ICachedCostumeService> <>u__2;
        private Awaiter<PRISM.Module.Networking.IIdolBaseStatus> <>u__3;
        private Awaiter<bool> <>u__4;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.CallFromLegacy
public class ChallengeTourInGamePausePopupCallerImplement : PRISM.Legacy.ChallengeTourInGamePausePopupCaller
{
    private UniRx.Subject<PRISM.Produce.ProduceOptionSaveData> onApplyProduceOptionSubject;
    private UniRx.Subject<UniRx.Unit> onClickRetryButtonSubject;
    private UniRx.Subject<UniRx.Unit> onClickGiveUpButtonSubject;
    private UniRx.Subject<UniRx.Unit> onHidePopupSubject;
    private PRISM.Adapters.ChallengeTourInGamePausePopupViewModel viewModel;
    public System.IObservable<PRISM.Produce.ProduceOptionSaveData> OnApplyProduceOption { get; set; }
    public System.IObservable<UniRx.Unit> OnClickRetryButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickGiveUpButton { get; set; }
    public System.IObservable<UniRx.Unit> OnHidePopup { get; set; }
    public void Setup(System.Collections.Generic.IReadOnlyList<PRISM.Produce.EnemySkillContentViewModel> enemySkillModelList, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IChallengeTourStageRewardStatus> missionList, PRISM.Produce.ChallengeTourMissionProgressCalcModel calcModel);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Module.Networking.IChallengeTourStageRewardStatus, PRISM.Adapters.ChallengeTourRewardViewModel> <>9__13_0;
        private PRISM.Adapters.ChallengeTourRewardViewModel <Setup>b__13_0(PRISM.Module.Networking.IChallengeTourStageRewardStatus x);
    }

    private struct <ShowAsync>d__14 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.CallFromLegacy.ChallengeTourInGamePausePopupCallerImplement <>4__this;
        public System.Threading.CancellationToken cancellationToken;
        private Awaiter<PRISM.Adapters.ChallengeTourInGamePausePopupResult> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.CallFromLegacy
public class DeckConfirmPopupCallerImplement : PRISM.Legacy.IDeckConfirmPopupCaller, PRISM.Legacy.ILegacyCaller
{
    public Cysharp.Threading.Tasks.UniTask RunAsync(System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceCardStatus> deckCards, System.Threading.CancellationToken ct);
}

// Namespace: PRISM.CallFromLegacy
public class GetProduceCardPopupCallerImplement : PRISM.Legacy.IGetProduceCardPopupCaller, PRISM.Legacy.ILegacyCaller
{
    public Cysharp.Threading.Tasks.UniTask<System.Collections.Generic.IReadOnlyList<string>> RunAsync(System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceCardStatus> gettableCards, int gettableAmount, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IProduceCardStatus> deckCards, System.Threading.CancellationToken ct);
}

// Namespace: PRISM.CallFromLegacy
public class GetSupportSkillPopupCallerImplement : PRISM.Legacy.IGetSupportSkillPopupCaller, PRISM.Legacy.ILegacyCaller
{
    public Cysharp.Threading.Tasks.UniTask<System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.ISelectionSupportSkillStatus>> ShowAsync(System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IPotentialSupportSkillStatus> gettableSupportSkillList, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IInProducePotentialSupportSkillStatus> skillList, int maxSlotNum, int selectableCount, bool isInheritance, System.Threading.CancellationToken ct);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Module.Networking.IInProducePotentialSupportSkillStatus, PRISM.Module.Networking.IPotentialSupportSkillStatus> <>9__0_0;
        private PRISM.Module.Networking.IPotentialSupportSkillStatus <ShowAsync>b__0_0(PRISM.Module.Networking.IInProducePotentialSupportSkillStatus x);
    }
}

// Namespace: PRISM.CallFromLegacy
public class ProduceInGamePausePopupCallerImplement : PRISM.Produce.ProduceInGamePausePopupCaller
{
    private UniRx.Subject<PRISM.Produce.ProduceOptionSaveData> onApplyProduceOptionSubject;
    private UniRx.Subject<UniRx.Unit> onClickRetryButtonSubject;
    private UniRx.Subject<UniRx.Unit> onClickGiveUpButtonSubject;
    private UniRx.Subject<UniRx.Unit> onHidePopupSubject;
    private PRISM.Adapters.ProduceInGamePausePopupViewModel viewModel;
    private bool isShowPopup;
    private bool isClosingPopup;
    private System.Func<Cysharp.Threading.Tasks.UniTask> onPreCloseByRetryButtonFunc;
    private System.Func<Cysharp.Threading.Tasks.UniTask> onPreCloseByGiveUpButtonFunc;
    public System.IObservable<PRISM.Produce.ProduceOptionSaveData> OnApplyProduceOption { get; set; }
    public System.IObservable<UniRx.Unit> OnHidePopup { get; set; }
    public void Setup(System.Collections.Generic.IReadOnlyList<PRISM.Produce.EnemySkillContentViewModel> enemySkillViewModels, InGameType inGameType, PRISM.Produce.ChallengeMissionViewModel challengeMissionViewModel, System.Func<Cysharp.Threading.Tasks.UniTask> onPreCloseByRetryButtonFunc, System.Func<Cysharp.Threading.Tasks.UniTask> onPreCloseByGiveUpButtonFunc);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <ShowAsync>b__14_0(PRISM.Produce.ProduceOptionSaveData option);

    private struct <ShowAsync>d__14 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.CallFromLegacy.ProduceInGamePausePopupCallerImplement <>4__this;
        public System.Threading.CancellationToken cancellationToken;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.CallFromLegacy
public class SCharaDetailPopupCallerImplement : PRISM.UICharacter.ISCharaDetailPopupCaller, PRISM.Legacy.ILegacyCaller
{
    public Cysharp.Threading.Tasks.UniTask<bool> LaunchAsync(int mstSupportCharaId, System.Threading.CancellationToken ct, bool withAdvList, bool isChangeableFavorite, System.Action<PRISM.Module.Networking.ISupportCharacterStatus> onChangeFavoriteMarkAction, bool upgradingButtonActive);
    public Cysharp.Threading.Tasks.UniTask<bool> LaunchOtherSCharaAsync(PRISM.Module.Networking.ISupportCharacterStatus otherSChara, System.Threading.CancellationToken ct, bool asMax);
    public Cysharp.Threading.Tasks.UniTask<bool> LaunchMaximumSCharaFromProductAsync(int mstSupportCharaId, System.Threading.CancellationToken ct, bool withAdvList);

    private struct <LaunchMaximumSCharaFromProductAsync>d__2 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
        public int mstSupportCharaId;
        public System.Threading.CancellationToken ct;
        private Awaiter<PRISM.Module.Networking.ISupportCharacterStatus> <>u__1;
        private Awaiter<bool> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.CallFromLegacy
public class SystemSettingsCaller : PRISM.Legacy.ISystemSettingsCaller, PRISM.Legacy.ILegacyCaller
{
    public UpScalingMode UpScalingMode { get; set; }
    public QualityType Quality3D { get; set; }
    public QualityType ShadowQuality { get; set; }
    public QualityType ReflectionQuality { get; set; }
    public AntiAliasingSMAA AntiAliasingSmaa { get; set; }
    public OutlineForMV OutlineForMV { get; set; }
    public PowerSaving PowerSaving { get; set; }
    public PhysicsSetting PhysicsSetting { get; set; }
    public RhythmGameMVEffectLevel RhythmGame3DEffectLevel { get; set; }
    public void GPUDetectIfNeeded();
    public void ApplySettings(bool isIngame, bool isRhythmGame);
    public void Save();
    public float CalculateCategoryVolume(PRISM.SoundCategory category);
    public void ApplySMAA();
    private static PRISM.Service.SystemSettingsSaveData _getSaveData();
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=815 410214557272145C68CDF25386565190173902A68AF31BAAF9062DA0BA535B09;
    private static __StaticArrayInitTypeSize=1286 635299B81A64258590DBBFEDE43F27101AFFAC1E4C75D32A6CDE42ED55A4156C;

    private struct __StaticArrayInitTypeSize=815 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=1286 : System.ValueType
    {
    }
}
