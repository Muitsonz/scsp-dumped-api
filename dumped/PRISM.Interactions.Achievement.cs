
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

// Namespace: PRISM.Interactions.Achievement
public class AchievementDetailPanelView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.Achievement.AchievementIcon icon;
    private ENTERPRISE.UI.UIButton button;
    private UnityEngine.GameObject selectFrame;
    private UnityEngine.GameObject normalFrame;
    private ENTERPRISE.UI.UITextMeshProUGUI achievementName;
    private ENTERPRISE.UI.UITextMeshProUGUI getCondtionText;
    private UnityEngine.GameObject informationRoot;
    private UnityEngine.GameObject emptyText;
    private int achievementId;
    private UniRx.Subject<int> onClick;
    private UniRx.Subject<int> onLongPress;
    public System.IObservable<int> OnClick { get; set; }
    public System.IObservable<int> OnLongPress { get; set; }
    public void Setup(int achievementId, PRISM.ResourceManagement.IResourceLoader resourceLoader, bool selected, bool isNew);
    public void UpdateSelectedFrame(bool isSelected);
    public void SetButtonEnable(bool isEnable);
    private void <Setup>b__15_0();
    private void <Setup>b__15_1();
}

// Namespace: PRISM.Interactions.Achievement
public class AchievementDetailPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IAchievementDetailPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.Achievement.AchievementDetailPanelView panelView;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClose;
    private int achievementId;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Inject(int achievementId, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__7_0();
    private void <CreateFrameParameter>b__7_1();
}

// Namespace: PRISM.Interactions.Achievement
public class AchievementIcon : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UIButton button;
    private UnityEngine.UI.Image achievementImage;
    private UnityEngine.GameObject nonSettingsObject;
    private UnityEngine.GameObject selectPulsIcon;
    private UnityEngine.GameObject newBadgeIcon;
    private UnityEngine.GameObject selectedCursor;
    private UniRx.Subject<int> onClick;
    private UniRx.Subject<int> onLongPress;
    private int achievementId;
    private PRISM.AutoCancellationTokenSource canceller;
    public System.IObservable<int> OnClick { get; set; }
    public System.IObservable<int> OnLongPress { get; set; }
    public Cysharp.Threading.Tasks.UniTask SetupAsync(int achievementId, PRISM.ResourceManagement.IResourceLoader resourceLoader, bool isPlusIcon, bool isNewIcon, bool isSelectedCursor);
    public void SetNewIcon(bool isActive);
    public void SetButtonEnable(bool isEnable);
    public void SetClickSoundEnable(bool isEnable);
    public void SetLongPressSoundEnable(bool isEnable);
    public void SetSelectedCursor(bool isSelectedCursor);
    private Cysharp.Threading.Tasks.UniTask _setupAsync(int achievementId, PRISM.ResourceManagement.IResourceLoader resourceLoader, bool isPlusIcon, bool isNewIcon, bool isSelectedCursor);
    private Cysharp.Threading.Tasks.UniTask _loadAchievementIconAsync(int mstAchievementId, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private void <SetupAsync>b__14_0();
    private void <SetupAsync>b__14_1();

    private struct <_loadAchievementIconAsync>d__21 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public int mstAchievementId;
        public PRISM.Interactions.Achievement.AchievementIcon <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private UnityEngine.UI.Image <>7__wrap1;
        private Awaiter<UnityEngine.Sprite> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_setupAsync>d__20 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.Achievement.AchievementIcon <>4__this;
        public int achievementId;
        public bool isPlusIcon;
        public bool isNewIcon;
        public bool isSelectedCursor;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.Achievement
public class AchievementPanelView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.Achievement.AchievementIcon[] achievementIcons;
    private UniRx.Subject<System.ValueTuple<int, int>> onClick;
    private UniRx.Subject<System.ValueTuple<int, int>> onLongPress;
    private System.IDisposable[] clickDisposables;
    private System.IDisposable[] longPressDisposables;
    public System.IObservable<System.ValueTuple<int, int>> OnClickObservable { get; set; }
    public System.IObservable<System.ValueTuple<int, int>> OnLongPressObservable { get; set; }
    public Cysharp.Threading.Tasks.UniTask SetupAsync(System.Collections.Generic.IReadOnlyList<int> achievementIds, PRISM.ResourceManagement.IResourceLoader resourceLoader, bool isNewIcon, bool isNonSettingsIcon);
    public void SetNewIcon(int index, bool isActive);
    public void SetButtonEnable(int index, bool isEnable);
    public void SetClickSoundEnable(int index, bool isEnable);
    public void SetLongPressSoundEnable(int index, bool isEnable);

    private class <>c__DisplayClass9_0
    {
        public int index;
        public PRISM.Interactions.Achievement.AchievementPanelView <>4__this;
        private void <SetupAsync>b__0(int id);
        private void <SetupAsync>b__1(int id);
    }
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=231 1E5FBEF990C186F6D71709C759AE7F83A0AF3B6D25DAF9EB16B2B25CEC372199;
    private static __StaticArrayInitTypeSize=315 4FD9AAC89E8AD0FB5AADCC33DD95053302CC71140BB02F1178454F22E41AE81C;

    private struct __StaticArrayInitTypeSize=231 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=315 : System.ValueType
    {
    }
}
