
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

// Namespace: PRISM.Interactions.GlobalMenu
public class GlobalMenuBannerCellScrollerView : PRISM.EnhancedListView<PRISM.Adapters.GlobalMenu.GlobalMenuBannerCellViewModel, PRISM.Interactions.GlobalMenu.GlobalMenuBannerCellScrollerViewContext>
{
    public System.IObservable<PRISM.Module.Networking.IBannerStatus> OnClickBanner { get; set; }
}

// Namespace: PRISM.Interactions.GlobalMenu
public class GlobalMenuBannerCellScrollerViewContext : PRISM.EnhancedListViewContext, System.IDisposable
{
    public PRISM.Legacy.WebTextureLoader WebTextureLoader;
    public UniRx.Subject<PRISM.Module.Networking.IBannerStatus> OnClickBanner;
    public void Dispose();
}

// Namespace: PRISM.Interactions.GlobalMenu
public class GlobalMenuBannerCellView : PRISM.EnhancedListViewCell<PRISM.Adapters.GlobalMenu.GlobalMenuBannerCellViewModel, PRISM.Interactions.GlobalMenu.GlobalMenuBannerCellScrollerViewContext>
{
    private PRISM.Interactions.ButtonView bannerButton;
    private UnityEngine.UI.RawImage bannerImage;
    private UnityEngine.UI.Image genreImage;
    private PRISM.AutoCancellationTokenSource canceller;
    private System.IDisposable buttonDisposable;
    public void UpdateContent(PRISM.Adapters.GlobalMenu.GlobalMenuBannerCellViewModel viewModel);
    private void OnDestroy();

    private class <>c__DisplayClass5_0
    {
        public PRISM.Interactions.GlobalMenu.GlobalMenuBannerCellView <>4__this;
        public PRISM.Adapters.GlobalMenu.GlobalMenuBannerCellViewModel viewModel;
        private void <UpdateContent>b__0(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions.GlobalMenu
public class GlobalMenuBannerGroupView : UnityEngine.MonoBehaviour, PRISM.Adapters.IGlobalMenuBannerGroupView
{
    private PRISM.Interactions.GlobalMenu.GlobalMenuBannerCellScrollerView scroller;
    public System.IObservable<PRISM.Module.Networking.IBannerStatus> OnClickBanner { get; set; }
    public void Initialize(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.GlobalMenu.GlobalMenuBannerCellViewModel> cellViewModels, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Interactions.GlobalMenu
public class GlobalMenuButtonGroupView : UnityEngine.MonoBehaviour, PRISM.Adapters.GlobalMenu.IGlobalMenuButtonGroupView
{
    private PRISM.Interactions.GlobalMenu.GlobalMenuButtonViewBase[] buttons;
    public PRISM.Adapters.GlobalMenu.IGlobalMenuButtonView MenuButton(PRISM.Adapters.GlobalMenu.GlobalMenuButtonType type);
}

// Namespace: PRISM.Interactions.GlobalMenu
public class GlobalMenuButtonView : PRISM.Interactions.GlobalMenu.GlobalMenuButtonViewBase
{
    private PRISM.Interactions.ButtonView button;
    private ENTERPRISE.UI.UITextMeshProUGUI label;
    private PRISM.Interactions.BadgeView badgeView;
    public System.IObservable<UniRx.Unit> OnClick { get; set; }
    public void SetLabel(string titleText);
    public void SetBadge(PRISM.Adapters.IBadgeModel badgeModel);
    public void SetButtonInteractable(bool isInteractable);
    private void Awake();
}

// Namespace: PRISM.Interactions.GlobalMenu
public class GlobalMenuButtonViewBase : UnityEngine.MonoBehaviour, PRISM.Adapters.GlobalMenu.IGlobalMenuButtonView
{
    public System.IObservable<UniRx.Unit> OnClick { get; set; }
    public void SetLabel(string label);
    public void SetBadge(PRISM.Adapters.IBadgeModel badgeModel);
    public void SetButtonInteractable(bool isInteractable);
}

// Namespace: PRISM.Interactions.GlobalMenu
public class GlobalMenuOverlayView : PRISM.Interactions.OverlayViewWithCloseButton, PRISM.Adapters.GlobalMenu.IGlobalMenuOverlayView, PRISM.Adapters.IClosableOverlayView<UniRx.Unit>, PRISM.Adapters.IOverlayView, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.GlobalMenu.GlobalMenuSeasonMissionBannerView seasonMissionBannerView;
    private PRISM.Interactions.GlobalMenu.GlobalMenuBannerGroupView bannerGroupView;
    private PRISM.Interactions.GlobalMenu.GlobalMenuButtonGroupView menuButtonGroupView;
    private PRISM.Interactions.MainFooterButtonGroupView footerButtonGroupView;
    private PRISM.Interactions.ButtonView homeButton;
    private PRISM.Interactions.ButtonView backgroundButton;
    private UnityEngine.CanvasGroup canvasGroup;
    private PRISM.Interactions.ButtonView applicationQuitButton;
    protected PRISM.Definitions.SoundKey closeSoundKey { get; set; }
    public System.IObservable<UniRx.Unit> OnClickHomeButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickApplicationQuitButton { get; set; }
    public PRISM.Adapters.GlobalMenu.IGlobalMenuSeasonMissionBannerView SeasonMissionBannerView { get; set; }
    public PRISM.Adapters.IGlobalMenuBannerGroupView BannerGroupView { get; set; }
    public PRISM.Adapters.GlobalMenu.IGlobalMenuButtonGroupView MenuButtonGroupView { get; set; }
    public PRISM.Adapters.IMainFooterButtonGroupView FooterButtonGroupView { get; set; }
    public void CloseOverlay();
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    private void Awake();
    private void <Awake>b__24_0(UniRx.Unit _);
}

// Namespace: PRISM.Interactions.GlobalMenu
public class GlobalMenuSeasonMissionBannerView : UnityEngine.MonoBehaviour, PRISM.Adapters.GlobalMenu.IGlobalMenuSeasonMissionBannerView
{
    private PRISM.Interactions.Home.BannerWithEndDateView banner;
    private PRISM.Interactions.ViewStateChanger resultLabelChanger;
    private PRISM.Interactions.BadgeView badgeView;
    private UnityEngine.GameObject sellingBadge;
    public System.IObservable<UniRx.Unit> OnClickBanner { get; set; }
    public void Initialize(PRISM.Adapters.Home.ISeasonMissionBannerViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void Hide();
    public void UpdateBadge(PRISM.Adapters.IBadgeModel badgeModel);
    public void ShowSellingBadge(bool isActive);
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=884 20D7F05AD531FC7D06885F41B216F995ED94F2C6379CE8F2BE83A7D912D57758;
    private static __StaticArrayInitTypeSize=558 7019232F9872E727484E983297EB7CE42A641BF1505CE27028E4AEADE738283C;

    private struct __StaticArrayInitTypeSize=558 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=884 : System.ValueType
    {
    }
}
