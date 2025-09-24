
private class <Module>
{
}

public class GashaEffectBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.GashaEffectArgument>
{
    private PRISM.Interactions.Gasha.GashaEffectView effectView;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.GashaEffectArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);

    private struct <BuildAsync>d__1 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<PRISM.IViewPresenter> <>t__builder;
        public PRISM.Adapters.GashaEffectArgument argument;
        public GashaEffectBuilder <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private Awaiter<PRISM.Adapters.GashaEffectPresenter> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

public class GashaResultBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.GashaResultArgument>
{
    private PRISM.Interactions.Gasha.GashaResultView resultView;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.GashaResultArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);

    private struct <BuildAsync>d__1 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<PRISM.IViewPresenter> <>t__builder;
        public PRISM.Adapters.GashaResultArgument argument;
        public GashaResultBuilder <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private Awaiter<PRISM.Adapters.GashaResultPresenter> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

public class ProducePolicyBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.ProducePolicyArgument>
{
    private PRISM.Interactions.ProducePolicyView producePolicyView;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.ProducePolicyArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);

    private struct <BuildAsync>d__1 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<PRISM.IViewPresenter> <>t__builder;
        public ProducePolicyBuilder <>4__this;
        public PRISM.Adapters.ProducePolicyArgument argument;
        private Awaiter<PRISM.IViewPresenter> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

// Namespace: PRISM
public class CharacterBaseSelectBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder, PRISM.Adapters.IViewBuilder<PRISM.Adapters.NullArgument>
{
    private PRISM.Interactions.CharacterBaseSelectView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.NullArgument _, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM
public class IdolListBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.IdolListArgument>
{
    private PRISM.Interactions.IdolListView view;
    private PRISM.Interactions.ProduceIdolIconListView piView;
    private PRISM.Interactions.SupportCharaListView scView;
    private PRISM.Interactions.FesUnitListView fuView;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.IdolListArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM
public class ProduceIdolUpgradingBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.ProduceIdolUpgradingArgument>
{
    private PRISM.Interactions.CommonTitleView titleView;
    private PRISM.Interactions.ProduceIdolUpgradingUICharacterView uiCharacterView;
    private PRISM.Interactions.ProduceIdolUpgradingView view;
    private PRISM.Interactions.ProduceIdolPIdolLvView pIdolLvView;
    private PRISM.Interactions.ProduceIdolAwakeningView awakeningView;
    private PRISM.Interactions.ProduceIdolTrainingView trainingView;
    private PRISM.Interactions.ProduceIdolSkillView skillView;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.ProduceIdolUpgradingArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);

    private class <>c__DisplayClass7_0
    {
        public PRISM.Direction.IDirectionLocator locator;
        private bool <BuildAsync>b__0();
    }
}

// Namespace: PRISM
public class SupportCharaUpgradingBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.SupportCharaUpgradingArgument>
{
    private PRISM.Interactions.SupportCharaUpgradingView view;
    private PRISM.Interactions.SupportCharaStatusView statusView;
    private PRISM.Interactions.SupportCharaTrainingView trainingView;
    private PRISM.Interactions.SupportCharaMasterTrainingView masterTrainingView;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.SupportCharaUpgradingArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM
public class CharacterTopBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder, PRISM.Adapters.IViewBuilder<PRISM.Adapters.NullArgument>
{
    private PRISM.Interactions.CharacterTopView topView;
    private PRISM.Interactions.CharacterTopUICharacterView uiCharacterView;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.NullArgument _, PRISM.ResourceManagement.IResourceLoader resourceLoader);

    private class <>c__DisplayClass2_0
    {
        public PRISM.Service.OverlayManager overlayManager;
        private bool <BuildAsync>b__0();
    }
}

// Namespace: PRISM
public class FittingRoomBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.FittingRoomArgument>
{
    private PRISM.Interactions.FittingRoomView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.FittingRoomArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM
public class LiveEventBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.LiveEventArgument>
{
    private PRISM.Interactions.LiveEventView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.LiveEventArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM
public class MedalGashaBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.MedalGashaArgument>
{
    private PRISM.Interactions.MedalGashaView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.MedalGashaArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM
public class TechnicalChallengeTopBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.TechnicalChallengeTopArgument>
{
    private PRISM.Interactions.TechnicalChallengeTopView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.TechnicalChallengeTopArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM
public class GashaTopBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.GashaTopArgument>
{
    private PRISM.Interactions.Gasha.GashaTopView topView;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.GashaTopArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);

    private struct <BuildAsync>d__1 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<PRISM.IViewPresenter> <>t__builder;
        public PRISM.Adapters.GashaTopArgument argument;
        public PRISM.GashaTopBuilder <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private Awaiter<PRISM.Adapters.GashaTopPresenter> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM
public class IntroductionRewardBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder, PRISM.Adapters.IViewBuilder<PRISM.Adapters.NullArgument>
{
    private PRISM.Interactions.Introduction.IntroductionRewardView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.NullArgument _, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM
public class OurStreamLiveViewingBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.OurstreamLiveViewingArgument>
{
    private PRISM.Interactions.Mobile.OurStreamLiveViewingView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.OurstreamLiveViewingArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM
public class PhotoViewBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder, PRISM.Adapters.IViewBuilder<PRISM.Adapters.NullArgument>
{
    private PRISM.Interactions.PhotoView view;
    private PRISM.Interactions.SituationModeView situationModeView;
    private PRISM.Interactions.PhotoAlbumView photoAlbumView;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.NullArgument _, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM
public class ProduceAutoModeBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.ProduceAutoModeArgument>
{
    private PRISM.Interactions.ProduceAutoModeView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.ProduceAutoModeArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM
public class ChallengeTourResultBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.ChallengeTourResultArgument>
{
    private PRISM.Interactions.Produce.ChallengeTourResultView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.ChallengeTourResultArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM
public class ChallengeTourTopBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.ChallengeTourTopArgument>
{
    private PRISM.Interactions.Produce.ChallengeTourTopView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.ChallengeTourTopArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);

    private struct <BuildAsync>d__1 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<PRISM.IViewPresenter> <>t__builder;
        public PRISM.Adapters.ChallengeTourTopArgument argument;
        public PRISM.ChallengeTourTopBuilder <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private Awaiter<PRISM.IViewPresenter> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM
public class ChallengeTourUnitEditBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.ChallengeTourUnitEditArgument>
{
    private PRISM.Interactions.Produce.ChallengeTourUnitEditView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.ChallengeTourUnitEditArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);

    private struct <BuildAsync>d__1 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<PRISM.IViewPresenter> <>t__builder;
        public PRISM.Adapters.ChallengeTourUnitEditArgument argument;
        public PRISM.ChallengeTourUnitEditBuilder <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private Awaiter<PRISM.IViewPresenter> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM
public class ProduceFriendSupportSelectBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.ProduceFriendSupportSelectArgument>
{
    private PRISM.Interactions.ProduceFriendSupportSelectView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.ProduceFriendSupportSelectArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM
public class ProduceFrontMenuBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.NullArgument>
{
    private PRISM.Interactions.Produce.ProduceFrontMenuView view;
    private PRISM.Interactions.Produce.ProduceFrontMenuCharacterView characterView;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.NullArgument _, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM
public class ProduceConfirmBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.ProduceConfirmArgument>
{
    private PRISM.Interactions.ProduceConfirmView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.ProduceConfirmArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM
public class ProduceIdolSelectBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.ProduceIdolSelectArgument>
{
    private PRISM.Interactions.ProduceIdolSelectView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.ProduceIdolSelectArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM
public class ScheduleSelectionBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.ScheduleSelectionArgument>
{
    private PRISM.Interactions.ScheduleSelectionView scheduleSelectionView;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.ScheduleSelectionArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);

    private struct <BuildAsync>d__1 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<PRISM.IViewPresenter> <>t__builder;
        public PRISM.ScheduleSelectionBuilder <>4__this;
        public PRISM.Adapters.ScheduleSelectionArgument argument;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private Awaiter<PRISM.IViewPresenter> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM
public class TutorialMovieBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder, PRISM.Adapters.IViewBuilder<PRISM.Adapters.NullArgument>
{
    private PRISM.Interactions.TutorialMovieView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.NullArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM
public class TutorialIntroductionBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder, PRISM.Adapters.IViewBuilder<PRISM.Adapters.NullArgument>
{
    private PRISM.Interactions.TutorialIntroduction.TutorialIntroductionView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.NullArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Story.Direction
public class ExtraStorySubcategorySelectBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.Story.ExtraStorySubcategorySelectArgument>
{
    private PRISM.Interactions.Story.ExtraStorySubcategorySelectView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.Story.ExtraStorySubcategorySelectArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Story.Direction
public class IdolSubStoryIdolSelectBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.Story.IdolSubStoryIdolSelectArgument>
{
    private PRISM.Interactions.Story.IdolSubStoryIdolSelectView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.Story.IdolSubStoryIdolSelectArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Story.Direction
public class IdolSubStorySelectBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.Story.IdolSubStorySelectArgument>
{
    private PRISM.Interactions.Story.IdolSubStorySelectView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.Story.IdolSubStorySelectArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Story.Direction
public class ProduceIdolScenarioIdolSelectBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.Story.ProduceIdolScenarioIdolSelectArgument>
{
    private PRISM.Interactions.Story.ProduceScenarioIdolSelectView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.Story.ProduceIdolScenarioIdolSelectArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Story.Direction
public class SupportCharacterScenarioCharacterSelectBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.Story.SupportCharacterScenarioCharacterSelectArgument>
{
    private PRISM.Interactions.Story.SupportCharacterScenarioCharacterSelectView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.Story.SupportCharacterScenarioCharacterSelectArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Story.Direction
public class UnitSubStoryUnitSelectBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.Story.UnitSubStoryUnitSelectArgument>
{
    private PRISM.Interactions.Story.UnitSubStoryUnitSelectView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.Story.UnitSubStoryUnitSelectArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Produce
public class AuditionSuccessResultBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.Produce.AuditionSuccessResultArgument>
{
    private PRISM.Interactions.Produce.AuditionSuccessResultView view;
    private PRISM.Interactions.Produce.InGameResultADVView advView;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.Produce.AuditionSuccessResultArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);

    private struct <BuildAsync>d__2 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<PRISM.IViewPresenter> <>t__builder;
        public PRISM.Adapters.Produce.AuditionSuccessResultArgument argument;
        public PRISM.Produce.AuditionSuccessResultBuilder <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private Awaiter<PRISM.IViewPresenter> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Produce
public class LessonSuccessResultBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.Produce.LessonSuccessResultArgument>
{
    private PRISM.Interactions.Produce.LessonSuccessResultView view;
    private PRISM.Interactions.Produce.InGameResultADVView advView;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.Produce.LessonSuccessResultArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Produce
public class ProduceFailureResultBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.Produce.ProduceFailureResultArgument>
{
    private PRISM.Interactions.Produce.ProduceFailureResultView view;
    private PRISM.Interactions.Produce.InGameResultADVView advView;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.Produce.ProduceFailureResultArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);

    private struct <BuildAsync>d__2 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<PRISM.IViewPresenter> <>t__builder;
        public PRISM.Adapters.Produce.ProduceFailureResultArgument argument;
        public PRISM.Produce.ProduceFailureResultBuilder <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private Awaiter<PRISM.IViewPresenter> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Produce
public class ProduceResultBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.Produce.ProduceResultArgument>
{
    private PRISM.Interactions.Produce.ProduceResultView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.Produce.ProduceResultArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Produce
public class SpecialLessonResultBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.Produce.SpecialLessonResultArgument>
{
    private PRISM.Interactions.Produce.SpecialLessonResultView view;
    private PRISM.Interactions.Produce.InGameResultADVView advView;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.Produce.SpecialLessonResultArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);

    private struct <BuildAsync>d__2 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<PRISM.IViewPresenter> <>t__builder;
        public PRISM.Adapters.Produce.SpecialLessonResultArgument argument;
        public PRISM.Produce.SpecialLessonResultBuilder <>4__this;
        private Awaiter<PRISM.IViewPresenter> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Produce.SubSeasonSelect
public class ProduceSubSeasonSelectBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder, PRISM.Adapters.IViewBuilder<PRISM.Adapters.NullArgument>
{
    private PRISM.Interactions.Produce.SubSeasonSelect.ProduceSubSeasonSelectView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.NullArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.CallFromLegacy
public class AdvScreenBuilderForLegacyImplement : PRISM.Legacy.Adv.AdvScreenBuilderForLegacy
{
    private PRISM.Interactions.Adv.AdvScreenView view;
    public void SetViewActive(bool isActive);
    public PRISM.Legacy.Adv.IAdvScreenPresenterForLegacy Build(PRISM.Adv.AdvScreenViewModel viewModel, PRISM.Scenario.ScenarioManager scenarioManager);
}

// Namespace: PRISM.Direction
public class AprilPhotoCostumeChangeBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.AprilEvent.AprilPhotoArgument>
{
    private PRISM.Interactions.AprilPhotoCostumeChangeView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.AprilEvent.AprilPhotoArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Direction
public class CharacterBaseDetailBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.CharacterBaseDetailArgument>
{
    private PRISM.Interactions.IdolBaseDetailUICharacterView uiCharacterView;
    private PRISM.Interactions.IdolBaseDetailView view;
    private PRISM.Interactions.IdolBaseDetailProfileView profileView;
    private PRISM.Interactions.IdolBaseDetailGalleryView galleryView;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.CharacterBaseDetailArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<bool> <>9__4_0;
        private bool <BuildAsync>b__4_0();
    }
}

// Namespace: PRISM.Direction
public class IdolBaseDetailBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.IdolBaseDetailArgument>
{
    private PRISM.Interactions.IdolBaseDetailUICharacterView uiCharacterView;
    private PRISM.Interactions.IdolBaseDetailView view;
    private PRISM.Interactions.IdolBaseDetailProfileView profileView;
    private PRISM.Interactions.IdolBaseDetailStatusView statusView;
    private PRISM.Interactions.IdolBaseDetailGalleryView galleryView;
    private PRISM.Interactions.IdolBaseDetailCasualCostumeView casualCostumeView;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.IdolBaseDetailArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);

    private class <>c__DisplayClass6_0
    {
        public PRISM.Direction.IDirectionLocator locator;
        private bool <BuildAsync>b__0();
    }
}

// Namespace: PRISM.Direction
public class ProduceIdolSelectionBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.ProduceIdolSelectionArgument>
{
    private PRISM.Interactions.ProduceIdolSelectionView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.ProduceIdolSelectionArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Direction
public class SupportCharaSelectionBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.SupportCharaSelectionArgument>
{
    private PRISM.Interactions.SupportCharaSelectionView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.SupportCharaSelectionArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Direction
public interface IDirectionLocator
{
    private static PRISM.Direction.IDirectionLocator <Instance>k__BackingField;
    public PRISM.Direction.IDirectionLocator Instance { get; set; }
    public PRISM.Service.OverlayManager OverlayManager { get; set; }
    public PRISM.Adapters.ICommonSequencerContainer CommonSequencerContainer { get; set; }
    public PRISM.Adapters.Data.SaveDataContainer SaveData { get; set; }
    public PRISM.Adapters.Data.PermanentDataContainer PermanentData { get; set; }
    public PRISM.Module.Networking.Implementation.ResettableServiceContainer ResettableServiceContainer { get; set; }
    public PRISM.Adapters.Reporter.ICrashlytics Crashlytics { get; set; }
    public PRISM.ITutorialSequenceContext TutorialContext { get; set; }
    public PRISM.Service.Notification.NotificationManager NotificationManager { get; set; }
    public void ClearSaveData();
    public UnityEngine.AsyncOperation UnloadUnusedResource();
}

// Namespace: PRISM.Direction
public class LegacyCallerResolver : PRISM.Legacy.ILegacyCallerResolver
{
    public T Resolve<T>();

    private class Cache`1<T>
    {
        public static T Instance;

        private class <>c<T>
        {
            public static <>c<T> <>9;
            private bool <.cctor>b__1_0(System.Reflection.Assembly x);
        }
    }
}

// Namespace: PRISM.Direction
public class UnusedResourceUnloader
{
    public static UnityEngine.AsyncOperation UnloadUnusedResource();
}

// Namespace: PRISM.Direction
public class LoggerAnalysis : PRISM.Module.PRISMLogger.ILoggerAnalysis
{
    private PRISM.Adapters.Reporter.IAnalytics analytics;
    private PRISM.Adapters.Reporter.ICrashlytics crashlytics;
    public void Log(string message);
    public void LogException(System.Exception exception);
}

// Namespace: PRISM.Direction
public class DressUpRoomBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.DressUpRoomArgument>
{
    private PRISM.Interactions.DressUpRoomView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.DressUpRoomArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<bool> <>9__1_0;
        private bool <BuildAsync>b__1_0();
    }
}

// Namespace: PRISM.Direction
public class GiftEventDetailBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.GiftEventDetailArgument>
{
    private PRISM.Interactions.GiftEventDetailView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.GiftEventDetailArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Direction
public class GiftEventTopBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.GiftEventTopArgument>
{
    private PRISM.Interactions.GiftEventTopView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.GiftEventTopArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Direction
public class PrismInitializer
{
    private static InitialContext <Context>k__BackingField;
    public InitialContext Context { get; set; }
    private static void _initializeBoth();
    private static void _initializeLogger();
    private static void _initializeRuntime();

    public class InitialContext : System.IDisposable
    {
        public PRISM.Direction.Reporter.FBCrashlytics crashlytics;
        public PRISM.Direction.Reporter.FBAnalytics analytics;
        public PRISM.Module.PRISMLogger.LoggerInstaller installer;
        public PRISM.Direction.FirebaseAPI firebase;
        public void Dispose();
    }

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<TMPro.TMP_Settings> <>9__7_0;
        private TMPro.TMP_Settings <_initializeRuntime>b__7_0();
    }
}

// Namespace: PRISM.Direction
public class LiveCostumeChangeBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.LiveCostumeChangeArgument>
{
    private PRISM.Interactions.LiveCostumeChangeView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.LiveCostumeChangeArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Direction
public class LiveMusicSelectionBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.LiveMusicSelectionArgument>
{
    private PRISM.Interactions.Live.LiveMusicSelectionView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.LiveMusicSelectionArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Direction
public class LiveMvUnitConfirmationBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.LiveMvUnitConfirmationArgument>
{
    private PRISM.Interactions.Live.LiveMvUnitConfirmationView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.LiveMvUnitConfirmationArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Direction
public class LiveMvUnitMemberChangeBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.LiveMvUnitMemberChangeArgument>
{
    private PRISM.Interactions.Live.LiveMvUnitMemberChangeView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.LiveMvUnitMemberChangeArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Direction
public class LiveResultBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.LiveResultArgument>
{
    private PRISM.Interactions.Live.LiveResultView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.LiveResultArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Direction
public class LiveUnitConfirmationBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.LiveUnitConfirmationArgument>
{
    private PRISM.Interactions.Live.LiveUnitConfirmationView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.LiveUnitConfirmationArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Direction
public class TechnicalChallengeLiveResultBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.TechnicalChallengeLiveResultArgument>
{
    private PRISM.Interactions.Live.TechnicalChallengeLiveResultView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.TechnicalChallengeLiveResultArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Direction
public class PRISMMain : UnityEngine.MonoBehaviour, PRISM.Legacy.IPRISMMainAccessor
{
    private UnityEngine.Canvas overlayCanvasPrefab;
    private UnityEngine.Camera overlayCanvasBelowBlurCamera;
    private UnityEngine.Camera overlayCanvasAboveBlurCamera;
    private PRISM.Interactions.Loading.LoadingCanvas loadingCanvas;
    private PRISM.Interactions.Loading.LoadingView loadingView;
    private PRISM.Interactions.ConnectingView connectingView;
    private PRISM.ErrorModalWindow errorModalWindow;
    private PRISM.Interactions.UICanvasManager canvasManager;
    public Cysharp.Threading.Tasks.UniTask SetupAsync(System.Threading.CancellationToken ct);
    private void _setupUserData(PRISM.Adapters.Data.PermanentDataContainer permanentData, PRISM.Adapters.Data.SaveDataContainer userSaveData);
    private static void _setupInputDevice();
    private PRISM.Adapters.Loading.LoadingPresenter _setupLoadingInstance();
    private BackKeySubject _setupBackKeySubject();
    private void _setupFullScreenSwitch();
    private void Awake();
    private void OnApplicationPause(bool pause);
    private void OnDestroy();
    private static void _releaseResources();
    private bool <Awake>b__14_0(PRISM.Direction.PRISMMain x);

    private class Locator : PRISM.Adapters.IAdapterLocator, PRISM.Interactions.IInteractionLocator, PRISM.Direction.IDirectionLocator, PRISM.ILegacyLocator
    {
        private PRISM.Service.OverlayManager <OverlayManager>k__BackingField;
        private PRISM.Adapters.IOverlayViewFactory <OverlayViewFactory>k__BackingField;
        private PRISM.Adapters.IPopupViewFactory <PopupViewFactory>k__BackingField;
        private PRISM.Adapters.Data.SaveDataContainer <SaveData>k__BackingField;
        private PRISM.Adapters.Data.PermanentDataContainer <PermanentData>k__BackingField;
        private PRISM.Adapters.Data.SessionDataContainer <SessionData>k__BackingField;
        private PRISM.Module.Networking.Implementation.ResettableServiceContainer <ResettableServiceContainer>k__BackingField;
        private PRISM.Adapters.IButtonGotoTypeProcessor <ButtonGotoTypeProcessor>k__BackingField;
        private PRISM.Interactions.IOverlayInstantiator <OverlayInstantiator>k__BackingField;
        private PRISM.Adapters.IBackKeyObservable <BackKeyObservable>k__BackingField;
        private PRISM.Adapters.ICommonSequencerContainer <CommonSequencerContainer>k__BackingField;
        private PRISM.Service.Notification.NotificationManager <NotificationManager>k__BackingField;
        private PRISM.Service.AppReview.AppReviewManager <AppReviewManager>k__BackingField;
        private PRISM.Adapters.ISystemCall <SystemCall>k__BackingField;
        private PRISM.Adapters.Reporter.ICrashlytics <Crashlytics>k__BackingField;
        private PRISM.Adapters.Reporter.IAnalytics <Analytics>k__BackingField;
        private PRISM.Adapters.ILoadingPresenter <LoadingPresenter>k__BackingField;
        private PRISM.IConnectingView <ConnectingView>k__BackingField;
        private PRISM.ITutorialBuilder <TutorialBuilder>k__BackingField;
        private PRISM.ITutorialSequenceContext <TutorialContext>k__BackingField;
        private PRISM.Legacy.ILegacyCallerResolver <LegacyCallerResolver>k__BackingField;
        private ENTERPRISE.ViewManager <ViewManager>k__BackingField;
        private UniRx.IReadOnlyReactiveProperty<PRISM.Interactions.ScreenWrapper> <ScreenWrapper>k__BackingField;
        private PRISM.ErrorModalWindow <ErrorModalWindow>k__BackingField;
        private PRISM.Definitions.ScopedReactiveProperty<bool> <IsForcePortrait>k__BackingField;
        public PRISM.Service.OverlayManager OverlayManager { get; set; }
        public PRISM.Adapters.IOverlayViewFactory OverlayViewFactory { get; set; }
        public PRISM.Adapters.IPopupViewFactory PopupViewFactory { get; set; }
        private PRISM.IOverlayInstantiatorForLegacy PRISM.ILegacyLocator.OverlayInstantiator { get; set; }
        public PRISM.Adapters.Data.SaveDataContainer SaveData { get; set; }
        private PRISM.Data.LegacySaveDataContainer PRISM.ILegacyLocator.SaveData { get; set; }
        public PRISM.Adapters.Data.PermanentDataContainer PermanentData { get; set; }
        public PRISM.Adapters.Data.SessionDataContainer SessionData { get; set; }
        public PRISM.Module.Networking.Implementation.ResettableServiceContainer ResettableServiceContainer { get; set; }
        public PRISM.Adapters.IButtonGotoTypeProcessor ButtonGotoTypeProcessor { get; set; }
        private PRISM.Legacy.IButtonGotoTypeProcessorForLegacy PRISM.ILegacyLocator.ButtonGotoTypeProcessor { get; set; }
        public PRISM.Interactions.IOverlayInstantiator OverlayInstantiator { get; set; }
        public PRISM.Adapters.IBackKeyObservable BackKeyObservable { get; set; }
        private PRISM.IBackKeyObservableForLegacy PRISM.ILegacyLocator.BackKeyObservable { get; set; }
        public PRISM.Adapters.ICommonSequencerContainer CommonSequencerContainer { get; set; }
        private PRISM.ICommonSequencerContainerForLegacy PRISM.ILegacyLocator.CommonSequencerContainer { get; set; }
        public PRISM.Service.Notification.NotificationManager NotificationManager { get; set; }
        public PRISM.Service.AppReview.AppReviewManager AppReviewManager { get; set; }
        public PRISM.ResourceManagement.IResourceLoaderContainer ResourceLoaderContainer { get; set; }
        public PRISM.ResourceManagement.IResourceDownloader ResourceDownloader { get; set; }
        public PRISM.Adapters.ISystemCall SystemCall { get; set; }
        private PRISM.Legacy.ISystemCallForLegacy PRISM.ILegacyLocator.SystemCall { get; set; }
        private PRISM.Legacy.INotificationManagerForLegacy PRISM.ILegacyLocator.NotificationManager { get; set; }
        public PRISM.Definitions.MasterData MasterData { get; set; }
        public ENTERPRISE.Localization.LocalizationManager LocalizationManager { get; set; }
        public PRISM.Adapters.Reporter.ICrashlytics Crashlytics { get; set; }
        private PRISM.ICrashlyticsForLegacy PRISM.ILegacyLocator.Crashlytics { get; set; }
        public PRISM.Adapters.Reporter.IAnalytics Analytics { get; set; }
        private PRISM.IAnalyticsForLegacy PRISM.ILegacyLocator.Analytics { get; set; }
        public PRISM.Service.Communicator.IServiceContainer ServiceContainer { get; set; }
        private PRISM.Legacy.IServiceContainerForLegacy PRISM.ILegacyLocator.ServiceContainer { get; set; }
        public PRISM.Adapters.ILoadingPresenter LoadingPresenter { get; set; }
        private PRISM.Legacy.ILoadingPresenterForLegacy PRISM.ILegacyLocator.LoadingPresenter { get; set; }
        public PRISM.IConnectingView ConnectingView { get; set; }
        public PRISM.ITutorialBuilder TutorialBuilder { get; set; }
        public PRISM.ITutorialSequenceContext TutorialContext { get; set; }
        public PRISM.Legacy.ILegacyCallerResolver LegacyCallerResolver { get; set; }
        public ENTERPRISE.ViewManager ViewManager { get; set; }
        public UniRx.IReadOnlyReactiveProperty<PRISM.Interactions.ScreenWrapper> ScreenWrapper { get; set; }
        public PRISM.ErrorModalWindow ErrorModalWindow { get; set; }
        public PRISM.Definitions.ScopedReactiveProperty<bool> IsForcePortrait { get; set; }
        public UnityEngine.AsyncOperation UnloadUnusedResource();
        private void PRISM.Direction.IDirectionLocator.ClearSaveData();
        private void PRISM.ILegacyLocator.LaunchAdv(PRISM.Adv.AdvParameter parameter);
        private void _initializeSaveData();
        private PRISM.Service.Notification.NotificationManager _buildNotificationManager();
    }

    private class BackKeySubject : PRISM.Definitions.StackableSubject<UniRx.Unit>, PRISM.Adapters.IBackKeyObservable, PRISM.IBackKeyObservableForLegacy, System.IObservable<UniRx.Unit>
    {
        public void ShowDisabledMessage();
        public System.IDisposable CreateDisableScope();
        private void <CreateDisableScope>b__1_0(UniRx.Unit _);
    }

    private class <>O
    {
        public static System.Action <0>___releaseResources;
    }

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<long, bool> <>9__12_0;
        private bool <_setupBackKeySubject>b__12_0(long _);
    }

    private class <>c__DisplayClass12_0
    {
        public BackKeySubject backKeySubject;
        private void <_setupBackKeySubject>b__1(long _);
    }

    private class <>c__DisplayClass13_0
    {
        public bool isFullScreen;
        private void <_setupFullScreenSwitch>b__0(long _);
    }

    private class <>c__DisplayClass8_0
    {
        public InitialContext initialContext;
        public PRISM.Direction.PRISMMain <>4__this;
        public Locator locator;
        private bool <SetupAsync>b__0();
        private void <SetupAsync>b__1(UnityEngine.Canvas sceneTransitionCanvas);
        private void <SetupAsync>b__2(bool isPortrait);
    }

    private struct <SetupAsync>d__8 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Direction.PRISMMain <>4__this;
        public System.Threading.CancellationToken ct;
        private <>c__DisplayClass8_0 <>8__1;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Direction
private class SkipMaintenanceNotificationHandler : PRISM.Service.Notification.INotificationHandler
{
    private static System.DateTime MaintenanceDate;
    private PRISM.Service.Notification.INotificationHandler parent;
    public string SetScheduleNotification(PRISM.Service.Notification.NotificationModel model);
    public void Initialize();
    public Cysharp.Threading.Tasks.UniTask<bool> AskNotificationPermissionAsync();
    public void RemoveScheduledNotification(string id);
    public void RemoveNotification(string id);
    public void RemoveBadge();
    public void OnApplicationSuspend();
    public string GetLastRespondedNotificationId();
    public void RemoveAllScheduledNotification();
}

// Namespace: PRISM.Direction
public class CommonSequencerContainer : PRISM.Adapters.ICommonSequencerContainer, PRISM.ICommonSequencerContainerForLegacy
{
    private PRISM.Adapters.ExchangeOverlaySequencer exchangeOverlaySequencer;
    private PRISM.Adapters.IAnnounceSequencer <Announce>k__BackingField;
    private PRISM.IErrorPopupSequencerForLegacy <Error>k__BackingField;
    private PRISM.IHowToPlayPopupSequencerForLegacy <HowToPlay>k__BackingField;
    public PRISM.Adapters.IAnnounceSequencer Announce { get; set; }
    public PRISM.IErrorPopupSequencerForLegacy Error { get; set; }
    public PRISM.IHowToPlayPopupSequencerForLegacy HowToPlay { get; set; }
    public PRISM.Adapters.IMessagePopupBuilderEmpty CreateMessagePopupBuilder(PopupSizeType sizeType, bool isEnableOutOfRange);
    public PRISM.Adapters.IMessagePopupBuilderEmpty CreateMessageScrollPopupBuilder(PopupSizeType sizeType, bool isEnableOutOfRange);
    public Cysharp.Threading.Tasks.UniTask ShowMessagePopupAsync(PRISM.Definitions.LocalizationKey title, PRISM.Definitions.LocalizationKey message, System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask ShowItemDetailAsync(PRISM.Domain.ProductKey productKey, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask ShowGlobalMenuAsync(System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask ShowReceiveRewardPopupAsync(PRISM.Adapters.Common.ReceiveRewardPopupViewModel viewModel, System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask ShowExchangeTopOverlayAsync(PRISM.Adapters.ExchangeTopViewModel viewModel, System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask ShowExchangeConfirmPopupAsync(PRISM.Domain.ProductKey productKey, ExchangeTabType tabType, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask ShowCostumeLineupPopupAsync(PRISM.Domain.ProductKey ticketKey, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask ShowSelectionTicketLineupPopupAsync(PRISM.Domain.ProductKey ticketKey, System.Threading.CancellationToken ct);
}

// Namespace: PRISM.Direction
public class ProduceEpisodeSelectBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.ProduceEpisodeSelectArgument>
{
    private PRISM.Interactions.ProduceEpisodeSelectView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.ProduceEpisodeSelectArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Direction
public class ProduceMvBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.ProduceMvArgument>
{
    private PRISM.Interactions.ProduceMvView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.ProduceMvArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Direction
public class RunwayCostumeChangeBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.RunwayCostumeChangeArgument>
{
    private PRISM.Interactions.RunwayCostumeChangeView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.RunwayCostumeChangeArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Direction
public class RunwayEventTopBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.RunwayEventArgument>
{
    private PRISM.Interactions.RunwayEventTopView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.RunwayEventArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Direction
public class RunwayUnitConfirmationBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.RunwayEventArgument>
{
    private PRISM.Interactions.RunwayUnitConfirmationView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.RunwayEventArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Direction
public class FirebaseAPI : System.IDisposable
{
    private UniRx.ReactiveProperty<bool> initialized;
    public bool Initialized { get; set; }
    public System.IObservable<UniRx.Unit> OnInitialized { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync();
    public void Dispose();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<bool, bool> <>9__4_0;
        public static System.Func<bool, UniRx.Unit> <>9__4_1;
        private bool <get_OnInitialized>b__4_0(bool value);
        private UniRx.Unit <get_OnInitialized>b__4_1(bool _);
    }

    private struct <InitializeAsync>d__5 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Direction.FirebaseAPI <>4__this;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Direction
public class TitleBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.TitleArgument>
{
    private PRISM.Interactions.Title.TitleView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.TitleArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private Cysharp.Threading.Tasks.UniTask _startGameAsync(PRISM.Module.Networking.ISelfStatus user);
    private static Cysharp.Threading.Tasks.UniTask _checkIntroductionAsync();
    private void <BuildAsync>b__1_0(PRISM.Module.Networking.ISelfStatus x);

    private struct <_checkIntroductionAsync>d__3 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        private Awaiter <>u__1;
        private Awaiter<PRISM.Adapters.Introduction.IIntroductionModel> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_startGameAsync>d__2 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Module.Networking.ISelfStatus user;
        private Awaiter<PRISM.ITutorialSequenceContext> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Direction
public class FinishWholeTutorialSequence : PRISM.ITutorialSequence
{
    public Cysharp.Threading.Tasks.UniTask ExecuteAsync(PRISM.ITutorialSequenceContext context);
}

// Namespace: PRISM.Direction
public class TutorialBuilder : PRISM.ITutorialBuilder
{
    private static string ViewKey;
    private PRISM.Interactions.UICanvasManager uiCanvasManager;
    public Cysharp.Threading.Tasks.UniTask<PRISM.ITutorialSequenceContext> BuildAsync(PRISM.Module.Networking.ITutorialStatus status, System.Threading.CancellationToken cancellationToken);

    private class <>c__DisplayClass3_0
    {
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private void <BuildAsync>b__0();
    }

    private struct <BuildAsync>d__3 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<PRISM.ITutorialSequenceContext> <>t__builder;
        public System.Threading.CancellationToken cancellationToken;
        public PRISM.Direction.TutorialBuilder <>4__this;
        public PRISM.Module.Networking.ITutorialStatus status;
        private <>c__DisplayClass3_0 <>8__1;
        private PRISM.Adapters.TutorialPresenter <presenter>5__2;
        private Awaiter<UnityEngine.GameObject> <>u__1;
        private Awaiter <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Direction
public class ScreenWrapperObserver
{
    public static UniRx.IReadOnlyReactiveProperty<PRISM.Interactions.ScreenWrapper> Observe<T>(T observer);

    private class <>c__0`1<T>
    {
        public static <>c__0<T> <>9;
        public static System.Func<T, System.ValueTuple<UnityEngine.Rect, int, int, float>> <>9__0_0;
        public static System.Func<System.ValueTuple<UnityEngine.Rect, int, int, float>, PRISM.Interactions.ScreenWrapper> <>9__0_1;
        private System.ValueTuple<UnityEngine.Rect, int, int, float> <Observe>b__0_0(T _);
        private PRISM.Interactions.ScreenWrapper <Observe>b__0_1(System.ValueTuple<UnityEngine.Rect, int, int, float> data);
    }
}

// Namespace: PRISM.Direction.Tutorial
public class StartWholeTutorialSequence : PRISM.ITutorialSequence
{
    private PRISM.ITutorialSequence allSkipSequence;
    private PRISM.ITutorialSequence skipSequence;
    private int phaseBeforeSelectProduceIdol;
    private int phaseTitleTutorialEnd;
    public Cysharp.Threading.Tasks.UniTask ExecuteAsync(PRISM.ITutorialSequenceContext context);
    private Cysharp.Threading.Tasks.UniTask _skipTutorialIfPossibleAsync(PRISM.ITutorialSequenceContext context, System.Collections.Generic.IReadOnlyList<PRISM.Definitions.MstTutorial> phases);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Definitions.MstTutorial, bool> <>9__4_0;
        public static System.Func<PRISM.Definitions.MstTutorial, int> <>9__4_1;
        public static System.Func<PRISM.Definitions.MstTutorial, int> <>9__5_0;
        private bool <ExecuteAsync>b__4_0(PRISM.Definitions.MstTutorial x);
        private int <ExecuteAsync>b__4_1(PRISM.Definitions.MstTutorial x);
        private int <_skipTutorialIfPossibleAsync>b__5_0(PRISM.Definitions.MstTutorial x);
    }

    private struct <ExecuteAsync>d__4 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.ITutorialSequenceContext context;
        public PRISM.Direction.Tutorial.StartWholeTutorialSequence <>4__this;
        private PRISM.Definitions.MstTutorial[] <phases>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_skipTutorialIfPossibleAsync>d__5 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.ITutorialSequenceContext context;
        public PRISM.Direction.Tutorial.StartWholeTutorialSequence <>4__this;
        public System.Collections.Generic.IReadOnlyList<PRISM.Definitions.MstTutorial> phases;
        private Awaiter<bool> <>u__1;
        private PRISM.ITutorialSequence <sequence>5__2;
        private Awaiter <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Direction.Tutorial
public class TutorialIdolSelectBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.Tutorial.TutorialIdolSelectArgument>
{
    private PRISM.Interactions.Tutorial.TutorialIdolSelectView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.Tutorial.TutorialIdolSelectArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Direction.Story
public class EpisodeZeroStorySelectBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.Story.EpisodeZeroStorySelectArgument>
{
    private PRISM.Interactions.Story.EpisodeZeroStorySelectView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.Story.EpisodeZeroStorySelectArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Direction.Story
public class EventStorySelectBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.Story.EventStorySelectArgument>
{
    private PRISM.Interactions.Story.EventStorySelectView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.Story.EventStorySelectArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Direction.Story
public class ExtraStorySelectBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.Story.ExtraStorySelectArgument>
{
    private PRISM.Interactions.Story.ExtraStorySelectView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.Story.ExtraStorySelectArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Direction.Story
public class ProduceIdolScenarioSelectBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.Story.ProduceIdolScenarioSelectArgument>
{
    private PRISM.Interactions.Story.ProduceIdolScenarioSelectView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.Story.ProduceIdolScenarioSelectArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Direction.Story
public class ProduceMainScenarioEpisodeSelectBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.Story.ProduceMainScenarioEpisodeSelectArgument>
{
    private PRISM.Interactions.Story.ProduceMainScenarioEpisodeSelectView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.Story.ProduceMainScenarioEpisodeSelectArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Direction.Story
public class ProduceMainScenarioSelectBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.Story.ProduceMainScenarioSelectArgument>
{
    private PRISM.Interactions.Story.ProduceMainScenarioSelectView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.Story.ProduceMainScenarioSelectArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Direction.Story
public class StoryTopBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.Story.StoryTopArgument>
{
    private PRISM.Interactions.Story.StoryTopView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.Story.StoryTopArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Direction.Story
public class SupportCharacterScenarioSelectBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.Story.SupportCharacterScenarioSelectArgument>
{
    private PRISM.Interactions.Story.SupportCharacterScenarioSelectView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.Story.SupportCharacterScenarioSelectArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Direction.Story
public class UnitSubStorySelectBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.Story.UnitSubStorySelectArgument>
{
    private PRISM.Interactions.Story.UnitSubStorySelectView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.Story.UnitSubStorySelectArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Direction.Reporter
public class FBAnalytics : PRISM.Adapters.Reporter.IAnalytics, PRISM.IAnalyticsForLegacy
{
    private static int LogActionLimit;
    private System.Collections.Generic.List<System.Action> logActions;
    private System.IDisposable watcher;
    public void SetUserId(string userId);
    public void TrackLogin();
    public void TrackTutorialComplete();
    public void TrackPurchase(int amount, string currency);
    public void LogEvent(string message);
    public void LogEvent(string eventName, string name, int value);
    public void LogException(System.Exception exception);
    public void Dispose();
    private void <.ctor>b__3_0(UniRx.Unit _);

    private class <>c__DisplayClass10_0
    {
        public PRISM.Direction.Reporter.FBAnalytics <>4__this;
        public System.Exception exception;
        private void <LogException>b__0();
    }

    private class <>c__DisplayClass4_0
    {
        public PRISM.Direction.Reporter.FBAnalytics <>4__this;
        public string userId;
        private void <SetUserId>b__0();
    }

    private class <>c__DisplayClass7_0
    {
        public PRISM.Direction.Reporter.FBAnalytics <>4__this;
        public int amount;
        public string currency;
        private void <TrackPurchase>b__0();
    }

    private class <>c__DisplayClass8_0
    {
        public PRISM.Direction.Reporter.FBAnalytics <>4__this;
        public string message;
        private void <LogEvent>b__0();
    }

    private class <>c__DisplayClass9_0
    {
        public PRISM.Direction.Reporter.FBAnalytics <>4__this;
        public string eventName;
        public string name;
        public int value;
        private void <LogEvent>b__0();
    }
}

// Namespace: PRISM.Direction.Reporter
public class FBCrashlytics : PRISM.Adapters.Reporter.ICrashlytics, PRISM.ICrashlyticsForLegacy
{
    private static int LogActionLimit;
    private System.Collections.Generic.List<System.Action> logActions;
    private System.IDisposable watcher;
    private UniRx.CompositeDisposable disposables;
    private bool suppressReport;
    public void SetUserId(string id);
    public void Log(string log);
    public void LogException(System.Exception exception);
    public void SetCustomKey(string key, string value);
    public void Dispose();
    private void <.ctor>b__5_0(UniRx.Unit _);
    private void <.ctor>b__5_1(UniRx.Unit _);

    private class <>c__DisplayClass6_0
    {
        public PRISM.Direction.Reporter.FBCrashlytics <>4__this;
        public string id;
        private void <SetUserId>b__0();
    }

    private class <>c__DisplayClass7_0
    {
        public PRISM.Direction.Reporter.FBCrashlytics <>4__this;
        public string log;
        private void <Log>b__0();
    }

    private class <>c__DisplayClass8_0
    {
        public PRISM.Direction.Reporter.FBCrashlytics <>4__this;
        public System.Exception exception;
        private void <LogException>b__0();
    }

    private class <>c__DisplayClass9_0
    {
        public PRISM.Direction.Reporter.FBCrashlytics <>4__this;
        public string key;
        public string value;
        private void <SetCustomKey>b__0();
    }
}

// Namespace: PRISM.Direction.Produce.ShinyCompetition
public class ShinyCompetitionRankingBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.Produce.ShinyCompetition.ShinyCompetitionRankingArgument>
{
    private PRISM.Interactions.Produce.ShinyCompetition.ShinyCompetitionRankingView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.Produce.ShinyCompetition.ShinyCompetitionRankingArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Direction.Produce.ShinyCompetition
public class ShinyCompetitionTopViewBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.Produce.ShinyCompetition.ShinyCompetitionTopViewArgument>
{
    private PRISM.Interactions.Produce.ShinyCompetition.ShinyCompetitionTopView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.Produce.ShinyCompetition.ShinyCompetitionTopViewArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Direction.Mobile
public class CallHistoryScreenBuilder : UnityEngine.MonoBehaviour, PRISM.Interactions.Mobile.IMobileScreenBuilder
{
    private PRISM.Interactions.Mobile.CallHistoryScreenView viewPrefab;
    private UnityEngine.Transform viewParent;
    public void Inject(UnityEngine.Transform viewParent);
    public PRISM.Adapters.Mobile.IMobileScreenPresenter Build(PRISM.Adapters.Mobile.IMobileScreenParameter parameter, PRISM.Adapters.Mobile.IMobileScreenCommonInfoContainer container);
}

// Namespace: PRISM.Direction.Mobile
public class CallPlaybackScreenBuilder : UnityEngine.MonoBehaviour, PRISM.Interactions.Mobile.IMobileScreenBuilder
{
    private PRISM.Interactions.Mobile.CallPlaybackScreenView viewPrefab;
    private UnityEngine.Transform viewParent;
    public void Inject(UnityEngine.Transform viewParent);
    public PRISM.Adapters.Mobile.IMobileScreenPresenter Build(PRISM.Adapters.Mobile.IMobileScreenParameter parameter, PRISM.Adapters.Mobile.IMobileScreenCommonInfoContainer container);
}

// Namespace: PRISM.Direction.Mobile
public class CallTopScreenBuilder : UnityEngine.MonoBehaviour, PRISM.Interactions.Mobile.IMobileScreenBuilder
{
    private PRISM.Interactions.Mobile.CallTopScreenView viewPrefab;
    private UnityEngine.Transform viewParent;
    public void Inject(UnityEngine.Transform viewParent);
    public PRISM.Adapters.Mobile.IMobileScreenPresenter Build(PRISM.Adapters.Mobile.IMobileScreenParameter parameter, PRISM.Adapters.Mobile.IMobileScreenCommonInfoContainer container);
}

// Namespace: PRISM.Direction.Mobile
public class ChainGroupMemberScreenBuilder : UnityEngine.MonoBehaviour, PRISM.Interactions.Mobile.IMobileScreenBuilder
{
    private PRISM.Interactions.Mobile.ChainGroupMemberScreenView viewPrefab;
    private UnityEngine.Transform viewParent;
    public void Inject(UnityEngine.Transform viewParent);
    public PRISM.Adapters.Mobile.IMobileScreenPresenter Build(PRISM.Adapters.Mobile.IMobileScreenParameter parameter, PRISM.Adapters.Mobile.IMobileScreenCommonInfoContainer container);
}

// Namespace: PRISM.Direction.Mobile
public class ChainProfileScreenBuilder : UnityEngine.MonoBehaviour, PRISM.Interactions.Mobile.IMobileScreenBuilder
{
    private PRISM.Interactions.Mobile.ChainProfileScreenView viewPrefab;
    private UnityEngine.Transform viewParent;
    public void Inject(UnityEngine.Transform viewParent);
    public PRISM.Adapters.Mobile.IMobileScreenPresenter Build(PRISM.Adapters.Mobile.IMobileScreenParameter parameter, PRISM.Adapters.Mobile.IMobileScreenCommonInfoContainer container);
}

// Namespace: PRISM.Direction.Mobile
public class ChainTalkHistoryScreenBuilder : UnityEngine.MonoBehaviour, PRISM.Interactions.Mobile.IMobileScreenBuilder
{
    private PRISM.Interactions.Mobile.ChainTalkHistoryScreenView viewPrefab;
    private UnityEngine.Transform viewParent;
    public void Inject(UnityEngine.Transform viewParent);
    public PRISM.Adapters.Mobile.IMobileScreenPresenter Build(PRISM.Adapters.Mobile.IMobileScreenParameter parameter, PRISM.Adapters.Mobile.IMobileScreenCommonInfoContainer container);
}

// Namespace: PRISM.Direction.Mobile
public class ChainTalkScreenBuilder : UnityEngine.MonoBehaviour, PRISM.Interactions.Mobile.IMobileScreenBuilder
{
    private PRISM.Interactions.Mobile.ChainTalkScreenView viewPrefab;
    private UnityEngine.Transform viewParent;
    public void Inject(UnityEngine.Transform viewParent);
    public PRISM.Adapters.Mobile.IMobileScreenPresenter Build(PRISM.Adapters.Mobile.IMobileScreenParameter parameter, PRISM.Adapters.Mobile.IMobileScreenCommonInfoContainer container);
}

// Namespace: PRISM.Direction.Mobile
public class ChainTopScreenBuilder : UnityEngine.MonoBehaviour, PRISM.Interactions.Mobile.IMobileScreenBuilder
{
    private PRISM.Interactions.Mobile.ChainTopScreenView viewPrefab;
    private UnityEngine.Transform viewParent;
    public void Inject(UnityEngine.Transform viewParent);
    public PRISM.Adapters.Mobile.IMobileScreenPresenter Build(PRISM.Adapters.Mobile.IMobileScreenParameter parameter, PRISM.Adapters.Mobile.IMobileScreenCommonInfoContainer container);
}

// Namespace: PRISM.Direction.Mobile
public class MobileLauncherBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.Mobile.MobileLauncherArgument>
{
    private PRISM.Interactions.Mobile.MobileLauncherView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.Mobile.MobileLauncherArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Direction.Mobile
public class MobileTopScreenBuilder : UnityEngine.MonoBehaviour, PRISM.Interactions.Mobile.IMobileScreenBuilder
{
    private PRISM.Interactions.Mobile.MobileTopScreenView viewPrefab;
    private UnityEngine.Transform viewParent;
    public void Inject(UnityEngine.Transform viewParent);
    public PRISM.Adapters.Mobile.IMobileScreenPresenter Build(PRISM.Adapters.Mobile.IMobileScreenParameter parameter, PRISM.Adapters.Mobile.IMobileScreenCommonInfoContainer container);
}

// Namespace: PRISM.Direction.Mobile
public class OurStreamArchiveDetailScreenBuilder : UnityEngine.MonoBehaviour, PRISM.Interactions.Mobile.IMobileScreenBuilder
{
    private PRISM.Interactions.Mobile.OurStreamArchiveDetailScreenView viewPrefab;
    private UnityEngine.Transform viewParent;
    public void Inject(UnityEngine.Transform viewParent);
    public PRISM.Adapters.Mobile.IMobileScreenPresenter Build(PRISM.Adapters.Mobile.IMobileScreenParameter parameter, PRISM.Adapters.Mobile.IMobileScreenCommonInfoContainer container);
}

// Namespace: PRISM.Direction.Mobile
public class OurStreamFavoriteListScreenBuilder : UnityEngine.MonoBehaviour, PRISM.Interactions.Mobile.IMobileScreenBuilder
{
    private PRISM.Interactions.Mobile.OurStreamFavoriteListScreenView viewPrefab;
    private UnityEngine.Transform viewParent;
    public void Inject(UnityEngine.Transform viewParent);
    public PRISM.Adapters.Mobile.IMobileScreenPresenter Build(PRISM.Adapters.Mobile.IMobileScreenParameter parameter, PRISM.Adapters.Mobile.IMobileScreenCommonInfoContainer container);
}

// Namespace: PRISM.Direction.Mobile
public class OurStreamTopScreenBuilder : UnityEngine.MonoBehaviour, PRISM.Interactions.Mobile.IMobileScreenBuilder
{
    private PRISM.Interactions.Mobile.OurStreamTopScreenView viewPrefab;
    private UnityEngine.Transform viewParent;
    public void Inject(UnityEngine.Transform viewParent);
    public PRISM.Adapters.Mobile.IMobileScreenPresenter Build(PRISM.Adapters.Mobile.IMobileScreenParameter parameter, PRISM.Adapters.Mobile.IMobileScreenCommonInfoContainer container);
}

// Namespace: PRISM.Direction.Mobile
public class TwestaDetailScreenBuilder : UnityEngine.MonoBehaviour, PRISM.Interactions.Mobile.IMobileScreenBuilder
{
    private PRISM.Interactions.Mobile.TwestaDetailScreenView viewPrefab;
    private UnityEngine.Transform viewParent;
    public void Inject(UnityEngine.Transform viewParent);
    public PRISM.Adapters.Mobile.IMobileScreenPresenter Build(PRISM.Adapters.Mobile.IMobileScreenParameter parameter, PRISM.Adapters.Mobile.IMobileScreenCommonInfoContainer container);
}

// Namespace: PRISM.Direction.Mobile
public class TwestaFavoriteScreenBuilder : UnityEngine.MonoBehaviour, PRISM.Interactions.Mobile.IMobileScreenBuilder
{
    private PRISM.Interactions.Mobile.TwestaFavoriteScreenView viewPrefab;
    private UnityEngine.Transform viewParent;
    public void Inject(UnityEngine.Transform viewParent);
    public PRISM.Adapters.Mobile.IMobileScreenPresenter Build(PRISM.Adapters.Mobile.IMobileScreenParameter parameter, PRISM.Adapters.Mobile.IMobileScreenCommonInfoContainer container);
}

// Namespace: PRISM.Direction.Mobile
public class TwestaProfileScreenBuilder : UnityEngine.MonoBehaviour, PRISM.Interactions.Mobile.IMobileScreenBuilder
{
    private PRISM.Interactions.Mobile.TwestaProfileScreenView viewPrefab;
    private UnityEngine.Transform viewParent;
    public void Inject(UnityEngine.Transform viewParent);
    public PRISM.Adapters.Mobile.IMobileScreenPresenter Build(PRISM.Adapters.Mobile.IMobileScreenParameter parameter, PRISM.Adapters.Mobile.IMobileScreenCommonInfoContainer container);
}

// Namespace: PRISM.Direction.Mobile
public class TwestaTopScreenBuilder : UnityEngine.MonoBehaviour, PRISM.Interactions.Mobile.IMobileScreenBuilder
{
    private PRISM.Interactions.Mobile.TwestaTopScreenView viewPrefab;
    private UnityEngine.Transform viewParent;
    public void Inject(UnityEngine.Transform viewParent);
    public PRISM.Adapters.Mobile.IMobileScreenPresenter Build(PRISM.Adapters.Mobile.IMobileScreenParameter parameter, PRISM.Adapters.Mobile.IMobileScreenCommonInfoContainer container);
}

// Namespace: PRISM.Direction.Loading
public class CommonLoadingContentBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.Loading.ICommonLoadingContentBuilder
{
    private PRISM.Interactions.Loading.CommonLoadingContentView loadingContentView;
    public PRISM.Adapters.Loading.CommonLoadingContentPresenter Build();
}

// Namespace: PRISM.Direction.Loading
public class SimpleFadeLoadingContentBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.Loading.ISimpleFadeLoadingContentBuilder
{
    private PRISM.Interactions.Loading.SimpleFadeLoadingContentView loadingContentView;
    public PRISM.Adapters.Loading.SimpleFadeLoadingContentPresenter Build();
}

// Namespace: PRISM.Direction.Loading
public class SpecialLoadingContentBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.Loading.ISpecialLoadingContentBuilder
{
    private PRISM.Interactions.Loading.SpecialLoadingContentView loadingContentView;
    public PRISM.Adapters.Loading.SpecialLoadingContentPresenter Build();
}

// Namespace: PRISM.Direction.Introduction
public class IntroductionCharacterSelectBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder, PRISM.Adapters.IViewBuilder<PRISM.Adapters.NullArgument>
{
    private PRISM.Interactions.Introduction.IntroductionCharacterSelectView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.NullArgument _, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Direction.Introduction
public class IntroductionLauncherBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.IntroductionLauncherArgument>
{
    private PRISM.Interactions.Introduction.IntroductionLauncherView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.IntroductionLauncherArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Direction.Introduction
public class IntroductionUnitLetterBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.Introduction.IntroductionUnitLetterArgument>
{
    private PRISM.Interactions.Introduction.IntroductionUnitLetterView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.Introduction.IntroductionUnitLetterArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Direction.Home
public class HomeBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.HomeArgument>
{
    private PRISM.Interactions.HomeView view;
    private PRISM.Interactions.Home.HomeMainView mainView;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.HomeArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Direction.Drama
public class DramaLauncherBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.Drama.IDramaLauncherArgument>
{
    private PRISM.Interactions.Drama.DramaLauncherView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.Drama.IDramaLauncherArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Direction.AprilEvent
public class AprilEventTopBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder, PRISM.Adapters.IViewBuilder<PRISM.Adapters.NullArgument>
{
    private PRISM.Interactions.AprilEvent.AprilEventTopView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.NullArgument _, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Direction.AprilEvent
public class AprilPhotoBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.AprilEvent.AprilPhotoArgument>
{
    private PRISM.Interactions.AprilEvent.AprilPhotoView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.AprilEvent.AprilPhotoArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Direction.Adv
public class AdvLauncherBuilder : UnityEngine.MonoBehaviour, PRISM.Adapters.IViewBuilder<PRISM.Adapters.Adv.AdvLauncherArgument>
{
    private PRISM.Interactions.Adv.AdvLauncherView view;
    public Cysharp.Threading.Tasks.UniTask<PRISM.IViewPresenter> BuildAsync(PRISM.Adapters.Adv.AdvLauncherArgument argument, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=9471 063BB9911A0AFC006284E84D4B9299872E369CA8D091711B9CEDEA0CB477B1A5;
    private static __StaticArrayInitTypeSize=5582 6813BAF6A8D23350697593077CBD9A6206D8D22BC46213AE6F25669492DAF6A5;

    private struct __StaticArrayInitTypeSize=5582 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=9471 : System.ValueType
    {
    }
}
