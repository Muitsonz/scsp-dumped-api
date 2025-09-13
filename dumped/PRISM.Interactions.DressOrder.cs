
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
public class OrderedCostumeContent : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.HorizontalAutoScrollingText costumeName;
    private PRISM.Interactions.CostumeIconView costumeIconView;
    public void Set(int costumeId, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Interactions
public class DressOrderCompletedPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IDressOrderCompletedPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private ENTERPRISE.UI.UITextMeshProUGUI txtMessage;
    private PRISM.Interactions.OrderedCostumeContent orderedCostumeContent;
    private UnityEngine.Transform orderedCostumeContentParent;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Assign(System.Collections.Generic.IList<int> costumeIdList, bool isPITraining, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__7_0();
    private void <CreateFrameParameter>b__7_1();
}

// Namespace: PRISM.Interactions
public class DressOrderConfirmedPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IDressOrderConfirmedPopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private PRISM.Interactions.CostumeIconView orderedCostumeIconView;
    private PRISM.Interactions.ItemPager itemPager;
    private PRISM.Interactions.ButtonView btnHowToGet;
    private UnityEngine.GameObject goInsufficientWarning;
    private ENTERPRISE.UI.UITextMeshProUGUI txtMessage;
    private ENTERPRISE.UI.UITextMeshProUGUI txtRequiredItemLabel;
    private ENTERPRISE.UI.UITextMeshProUGUI txtHowToGetButtonLabel;
    private ENTERPRISE.UI.UITextMeshProUGUI txtWarning;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public System.IObservable<UniRx.Unit> OnHowToGet { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Assign(PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Collections.Generic.List<PRISM.Adapters.RequiredItemIconViewModel> requiredItemIconViewModels, int orderCostumeId);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <Assign>b__13_3(bool _);
    private void <CreateFrameParameter>b__14_0();
    private void <CreateFrameParameter>b__14_1();
    private void <CreateFrameParameter>b__14_2();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Adapters.RequiredItemIconViewModel, bool> <>9__13_0;
        public static System.Func<PRISM.Adapters.RequiredItemIconViewModel, System.IObservable<bool>> <>9__13_1;
        public static System.Func<bool, bool> <>9__13_2;
        private bool <Assign>b__13_0(PRISM.Adapters.RequiredItemIconViewModel x);
        private System.IObservable<bool> <Assign>b__13_1(PRISM.Adapters.RequiredItemIconViewModel x);
        private bool <Assign>b__13_2(bool b);
    }
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=149 B8B1A0ADD97B309C7EA3F0D365D009F36EA9875C5913B921BF2E5564695BE621;
    private static __StaticArrayInitTypeSize=297 BCAF0F1C677DA82A1891374155DEA54C0134C46D0A18E4E9C7A6862B0D3D648D;

    private struct __StaticArrayInitTypeSize=149 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=297 : System.ValueType
    {
    }
}
