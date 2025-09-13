
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

// Namespace: PRISM.Interactions.SystemSettings
public class SystemSettingsBasicPanelView : UnityEngine.MonoBehaviour
{
    private UnityEngine.GameObject orientationRoot;
    private UnityEngine.GameObject fullScreenRoot;
    private PRISM.Interactions.ToggleGroupView fullScreenGroup;
    private PRISM.Interactions.ToggleGroupView orientationGroup;
    private PRISM.Interactions.ToggleGroupView storyVoiceGroup;
    private PRISM.Interactions.ToggleGroupView skipGroup;
    private PRISM.Interactions.ToggleButtonView titleCallToggle;
    private UnityEngine.GameObject screenShrinkRateArea;
    private UnityEngine.UI.Slider screenShrinkRateSlider;
    private PRISM.Interactions.ButtonView resetButton;
    private UnityEngine.GameObject fullScreenButtonCover;
    public void Initialize(PRISM.Adapters.SystemSettingsBasicPanelViewModel viewModel);

    private class <>c__DisplayClass11_0
    {
        public PRISM.Adapters.SystemSettingsBasicPanelViewModel viewModel;
        private void <Initialize>b__0(float value);
        private void <Initialize>b__1(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.SystemSettings
public class SystemSettingsGraphicQualityPanelView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ViewStateChanger gpuSpecStateChanger;
    private PRISM.Interactions.ToggleGroupView graphicGroup;
    private PRISM.Interactions.ToggleGroupView quality3DGroup;
    private PRISM.Interactions.ToggleGroupView shadowQualityGroup;
    private PRISM.Interactions.ToggleGroupView reflectionQualityGroup;
    private PRISM.Interactions.ToggleGroupView antiAliasingSmaaGroup;
    private PRISM.Interactions.ToggleGroupView outlineForMvGroup;
    private PRISM.Interactions.ToggleGroupView rhythmGame3DEffectLevelGroup;
    private PRISM.Interactions.ToggleGroupView powerSavingGroup;
    private PRISM.Interactions.ToggleGroupView physicsSettingGroup;
    private PRISM.Interactions.ToggleGroupView upScalingModeGroup;
    private PRISM.Interactions.ButtonView resetButton;
    public void Initialize(PRISM.Adapters.SystemSettingsGraphicQualityPanelViewModel viewModel);

    private class <>c__DisplayClass12_0
    {
        public PRISM.Adapters.SystemSettingsGraphicQualityPanelViewModel viewModel;
        private void <Initialize>b__0(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.SystemSettings
public class SystemSettingsNotificationPanelView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ToggleButtonView staminaRecoveryToggle;
    private PRISM.Interactions.ToggleButtonView liveBoostRecoveryToggle;
    private PRISM.Interactions.ToggleButtonView missionNotClearToggle;
    private PRISM.Interactions.ToggleButtonView notMidnightNotificationToggle;
    private PRISM.Interactions.ButtonView resetButton;
    public void Initialize(PRISM.Adapters.SystemSettingsNotificationPanelViewModel viewModel);

    private class <>c__DisplayClass5_0
    {
        public PRISM.Adapters.SystemSettingsNotificationPanelViewModel viewModel;
        private void <Initialize>b__0(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.SystemSettings
public class SystemSettingsPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.ISystemSettingsPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.ToggleGroupView tabGroupView;
    private PRISM.Interactions.SystemSettings.SystemSettingsBasicPanelView basicPanelView;
    private PRISM.Interactions.SystemSettings.SystemSettingsNotificationPanelView notificationPanelView;
    private PRISM.Interactions.SystemSettings.SystemSettingsSoundPanelView soundPanelView;
    private PRISM.Interactions.SystemSettings.SystemSettingsGraphicQualityPanelView graphicQualityPanelView;
    private UnityEngine.GameObject notificationCover;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClose;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Initialize(PRISM.Adapters.SystemSettingsPopupViewModel viewModel);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    private void <CreateFrameParameter>b__10_0();
    private void <CreateFrameParameter>b__10_1();

    private struct <LoadAsync>d__11 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
        public System.Threading.CancellationToken ct;
        public PRISM.Interactions.SystemSettings.SystemSettingsPopupView <>4__this;
        private Awaiter <>u__1;
        private Awaiter<bool> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions.SystemSettings
public class SystemSettingsSoundPanelView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.SystemSettings.SystemSettingsVolumeSlider bgmSlider;
    private PRISM.Interactions.SystemSettings.SystemSettingsVolumeSlider seSlider;
    private PRISM.Interactions.SystemSettings.SystemSettingsVolumeSlider voiceSlider;
    private PRISM.Interactions.ButtonView resetButton;
    public void Initialize(PRISM.Adapters.SystemSettingsSoundPanelViewModel viewModel);

    private class <>c
    {
        public static <>c <>9;
        public static System.Action<PRISM.Legacy.SoundVolumeSettings> <>9__4_0;
        public static System.Action<PRISM.Legacy.SoundVolumeSettings> <>9__4_1;
        public static System.Action<PRISM.Legacy.SoundVolumeSettings> <>9__4_2;
        private void <Initialize>b__4_0(PRISM.Legacy.SoundVolumeSettings x);
        private void <Initialize>b__4_1(PRISM.Legacy.SoundVolumeSettings x);
        private void <Initialize>b__4_2(PRISM.Legacy.SoundVolumeSettings x);
    }

    private class <>c__DisplayClass4_0
    {
        public PRISM.Adapters.SystemSettingsSoundPanelViewModel viewModel;
        private void <Initialize>b__3(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.SystemSettings
public class SystemSettingsVolumeSlider : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.Slider slider;
    private PRISM.Interactions.ButtonView muteButton;
    private PRISM.Interactions.ViewStateChanger muteStateChanger;
    private PRISM.Interactions.ViewStateChanger isPlusStateChanger;
    public void Initialize(UniRx.IReactiveProperty<PRISM.Legacy.SoundVolumeSettings> settings);

    private class <>c__DisplayClass4_0
    {
        public UniRx.IReactiveProperty<PRISM.Legacy.SoundVolumeSettings> settings;
        public PRISM.Interactions.SystemSettings.SystemSettingsVolumeSlider <>4__this;
        private void <Initialize>b__0(float value);
        private void <Initialize>b__1(UniRx.Unit _);
        private void <Initialize>b__2(PRISM.Legacy.SoundVolumeSettings x);
    }
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=411 C275589B937B33D4413FD4462B04A27374A23EFBEA65AB5FA7E290E1B4C4B27C;
    private static __StaticArrayInitTypeSize=537 FB5973422E5CA22841204625E0BCE72B0F6AE76A959B40E8EDB82134E0AB699C;

    private struct __StaticArrayInitTypeSize=411 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=537 : System.ValueType
    {
    }
}
