
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
public class GiftEventChainRewardButton : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView button;
    private ENTERPRISE.UI.UITextMeshProUGUI buttonText;
    private UnityEngine.UI.Image chainIconImage;
    private UnityEngine.UI.Image charaIconImage;
    private PRISM.Interactions.RewardItemIcon rewardIcon;
    public System.IObservable<UniRx.Unit> OnClickButton { get; set; }
    public void Setup(PRISM.Adapters.GiftEventDetailIdolModel idolModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct, bool unreleased);
}

// Namespace: PRISM.Interactions
public class GiftEventDetailConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.GiftEventDetailArgument>, PRISM.Legacy.IGiftEventDetailConnector
{
    protected PRISM.Adapters.GiftEventDetailArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
}

// Namespace: PRISM.Interactions
public class GiftEventDetailSwipeView : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IDragHandler
{
    private PRISM.Interactions.ButtonView leftButton;
    private PRISM.Interactions.ButtonView rightButton;
    private float minSwipeDistance;
    private bool canSwipe;
    private UnityEngine.Vector2 startTouchPosition;
    private UnityEngine.Vector2 endTouchPosition;
    private UniRx.Subject<bool> onSwipeSubject;
    public System.IObservable<bool> OnSwipe { get; set; }
    public void Initialize();
    public void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
    public void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
    private bool _isValidEvent(UnityEngine.EventSystems.PointerEventData eventData);
    private void _calcSwipe();
    private void OnDestroy();
    private void <Initialize>b__9_0(UniRx.Unit _);
    private void <Initialize>b__9_1(UniRx.Unit _);
}

// Namespace: PRISM.Interactions
public class GiftEventDetailView : UnityEngine.MonoBehaviour, PRISM.Adapters.IGiftEventDetailView
{
    private UnityEngine.UI.RawImage charaRawImage;
    private CharaRawImageOffset[] charaRawImageOffsets;
    private PRISM.Interactions.GiftEventChainRewardButton valentinesDayChainButton;
    private PRISM.Interactions.GiftEventChainRewardButton whiteDayChainButton;
    private PRISM.Interactions.GiftEventRewardGaugeView rewardGaugeView;
    private ENTERPRISE.UI.UITextMeshProUGUI presentCountText;
    private ENTERPRISE.UI.UITextMeshProUGUI giftCountText;
    private PRISM.Interactions.SendGiftSelector sendGiftSelector;
    private PRISM.Interactions.ButtonView presentButton;
    private PRISM.Interactions.GiftEventDetailSwipeView swipeView;
    private ENTERPRISE.OutGame.RewardItem giftIcon;
    private ENTERPRISE.OutGame.RewardItem presentGiftIcon;
    private PRISM.AutoCancellationTokenSource canceller;
    public System.IObservable<UniRx.Unit> OnClickValentinesDayChainButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickWhiteDayChainButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickPresentButton { get; set; }
    public System.IObservable<bool> OnSwipe { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.GiftEventDetailViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public void UpdateView(PRISM.Adapters.GiftEventDetailViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private void _setCharaRawImageOffset(int characterId);
    private void OnDestroy();
    private void <InitializeAsync>b__22_0(int x);

    public struct CharaRawImageOffset : System.ValueType
    {
        public int CharacterId;
        public float PosX;
    }

    private class <>c__DisplayClass24_0
    {
        public int characterId;
        private bool <_setCharaRawImageOffset>b__0(CharaRawImageOffset x);
    }
}

// Namespace: PRISM.Interactions
public class GiftEventRewardGaugeView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.GiftRewardItemIcon[] rewardItems;
    private UnityEngine.UI.Image fillImage;
    public void Setup(PRISM.Adapters.GiftEventDetailIdolModel idolModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public void SetGauge(int currentCount, int maxCount);
}

// Namespace: PRISM.Interactions
public class GiftEventTopConnector : PRISM.Interactions.ViewConnector<PRISM.Adapters.GiftEventTopArgument>, PRISM.Legacy.IGiftEventTopConnector
{
    protected PRISM.Adapters.GiftEventTopArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
}

// Namespace: PRISM.Interactions
public class GiftEventTopIdolListView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.GiftIdolIcon idolIcon;
    private UnityEngine.Transform iconParent;
    private UniRx.Subject<int> onClickIdolIcon;
    public System.IObservable<int> OnClickIdolIcon { get; set; }
    public void Setup(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.GiftIdolIconViewModel> viewModelList, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    private void OnDestroy();

    private class <>c__DisplayClass5_0
    {
        public PRISM.Adapters.GiftIdolIconViewModel iconModel;
        public PRISM.Interactions.GiftEventTopIdolListView <>4__this;
        private void <Setup>b__0(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions
public class GiftEventTopView : UnityEngine.MonoBehaviour, PRISM.Adapters.IGiftEventTopView
{
    private PRISM.Interactions.ButtonView gashaButton;
    private PRISM.Interactions.ButtonView shopButton;
    private PRISM.Interactions.ButtonView missionButton;
    private PRISM.Interactions.ButtonView receiveRewardAllButton;
    private ENTERPRISE.UI.UITextMeshProUGUI giftCountText;
    private ENTERPRISE.OutGame.RewardItem giftIcon;
    private ENTERPRISE.OutGame.RewardItem presentGiftIcon;
    private PRISM.Interactions.GiftEventTopIdolListView idolListView;
    public System.IObservable<UniRx.Unit> OnClickGashaButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickShopButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickMissionButton { get; set; }
    public System.IObservable<UniRx.Unit> OnClickReceiveRewardAllButton { get; set; }
    public System.IObservable<int> OnClickIdolIcon { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(PRISM.Adapters.GiftEventTopViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);

    private class <>c__DisplayClass18_0
    {
        public PRISM.Interactions.GiftEventTopView <>4__this;
        public PRISM.Adapters.GiftEventTopViewModel viewModel;
        private void <InitializeAsync>b__0(long amount);
        private void <InitializeAsync>b__1(bool unreceived);
    }
}

// Namespace: PRISM.Interactions
public class GiftIdolIcon : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.CharacterBaseIconView baseIcon;
    private PRISM.Interactions.ButtonView button;
    private UnityEngine.UI.Image fillImage;
    private UnityEngine.GameObject maxTextObject;
    public System.IObservable<UniRx.Unit> OnClickButton { get; set; }
    public void Setup(PRISM.Adapters.GiftIdolIconViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public void SetGauge(int currentCount, int maxCount);
}

// Namespace: PRISM.Interactions
public class GiftRewardItemIcon : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.RewardItemIcon rewardIcon;
    private PRISM.Interactions.ViewStateChanger acquiredChanger;
    private ENTERPRISE.UI.UITextMeshProUGUI requiredNumText;
    public void Setup(PRISM.Adapters.GiftRewardItemIconViewModel model, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
}

// Namespace: PRISM.Interactions
public class SendGiftSelector : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI giftCountText;
    private PRISM.Interactions.NumberFluctuateButtonView[] buttons;
    private int maxCount;
    public void Setup(UniRx.IReactiveProperty<int> presentCount, int max);
    public void SetMaxCount(int count, int max);
    private void _changeGiftCount(int count);
    private void _setInteractableButton(int count, int max);

    private class <>c__DisplayClass3_0
    {
        public PRISM.Interactions.SendGiftSelector <>4__this;
        public UniRx.IReactiveProperty<int> presentCount;
        private void <Setup>b__0(int count);
        private void <Setup>b__1(int diff);
    }
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=829 080BBC011067F4EA66E42F2D974AFFE9966A4DB6BCD22E1B31350C814BE19131;
    private static __StaticArrayInitTypeSize=551 E0566F5B63185C06365DF9A84198AF21A92CF7E46474B61FA31EBE2E8FC981B0;

    private struct __StaticArrayInitTypeSize=551 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=829 : System.ValueType
    {
    }
}
