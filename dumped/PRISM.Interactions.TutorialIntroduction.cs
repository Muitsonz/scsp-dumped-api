
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
public class TutorialIntroductionConnector : PRISM.Interactions.ViewConnector, PRISM.ITutorialIntroductionConnector
{
}

// Namespace: PRISM.Interactions.TutorialIntroduction
public class TutorialIntroductionPhasePanelView : UnityEngine.MonoBehaviour
{
    private PRISM.MoviePlayer[] moviePlayers;
    public System.Collections.Generic.IEnumerable<string> GetMoviePaths();
    public void SetActive(bool isActive);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.MoviePlayer, string> <>9__1_0;
        public static System.Func<string, bool> <>9__1_1;
        public static System.Func<PRISM.MoviePlayer, Cysharp.Threading.Tasks.UniTask> <>9__3_0;
        private string <GetMoviePaths>b__1_0(PRISM.MoviePlayer moviePlayer);
        private bool <GetMoviePaths>b__1_1(string path);
        private Cysharp.Threading.Tasks.UniTask <TerminateAsync>b__3_0(PRISM.MoviePlayer moviePlayer);
    }
}

// Namespace: PRISM.Interactions.TutorialIntroduction
public class TutorialIntroductionView : UnityEngine.MonoBehaviour, PRISM.Adapters.ITutorialIntroductionView
{
    private PRISM.Interactions.TutorialIntroduction.TutorialIntroductionPhasePanelView[] panelViews;
    private ENTERPRISE.UI.UIButton prevButton;
    private ENTERPRISE.UI.UIButton nextButton;
    private PRISM.CarouselIndicator carouselIndicator;
    private PRISM.ITutorialSequence finishSequence;
    public System.IObservable<PRISM.ITutorialSequence> OnPrevPhaseObservable { get; set; }
    public System.IObservable<PRISM.ITutorialSequence> OnNextPhaseObservable { get; set; }
    public int PanelModelLength { get; set; }
    public System.Collections.Generic.IEnumerable<string> GetMoviePaths();
    public void Initialize();
    public void InitializePhasePanelView(int dataIndex);
    public void SetPrevButtonEnable(int currentIndex);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private PRISM.ITutorialSequence <get_OnPrevPhaseObservable>b__6_0(UniRx.Unit _);
    private PRISM.ITutorialSequence <get_OnNextPhaseObservable>b__8_0(UniRx.Unit _);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Interactions.TutorialIntroduction.TutorialIntroductionPhasePanelView, System.Collections.Generic.IEnumerable<string>> <>9__11_0;
        public static System.Func<PRISM.Interactions.TutorialIntroduction.TutorialIntroductionPhasePanelView, Cysharp.Threading.Tasks.UniTask> <>9__15_0;
        private System.Collections.Generic.IEnumerable<string> <GetMoviePaths>b__11_0(PRISM.Interactions.TutorialIntroduction.TutorialIntroductionPhasePanelView x);
        private Cysharp.Threading.Tasks.UniTask <TerminateAsync>b__15_0(PRISM.Interactions.TutorialIntroduction.TutorialIntroductionPhasePanelView x);
    }
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=201 32373EB9C9033BE8718421758CFBD4D0810085193F497ACFB3F06FEBB0A81C87;
    private static __StaticArrayInitTypeSize=285 B9CC568C1CC1A596FA3CA0FF07AF261924C5CC66754B82A618446A6D95D28D06;

    private struct __StaticArrayInitTypeSize=201 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=285 : System.ValueType
    {
    }
}
