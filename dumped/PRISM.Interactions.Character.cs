
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
public class AbstractEnhancedCharacterSelectGridCellView : EnhancedUI.EnhancedScroller.EnhancedScrollerCellView
{
    public void Setup(int startDataIndexInRow, PRISM.Common.Model.CharacterIcon[] icons, PRISM.Interactions.CharacterSelectClickObservableInt context);
}

// Namespace: PRISM.Interactions
public class AdditionalLvSelector : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView lvDownButton;
    private PRISM.Interactions.ButtonView lvUpButton;
    private ENTERPRISE.UI.UITextMeshProUGUI lvText;
    private System.IObservable<PRISM.UI.LvTicketSelectorButtonType> <OnClick>k__BackingField;
    public System.IObservable<PRISM.UI.LvTicketSelectorButtonType> OnClick { get; set; }
    public void Setup(PRISM.Adapters.AdditionalLvSelectorViewModel vm, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private void <Setup>b__7_0(int lv);
    private void <Setup>b__7_1(PRISM.UI.LvTicketSelectorButtonStateType state);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<UniRx.Unit, PRISM.UI.LvTicketSelectorButtonType> <>9__7_2;
        public static System.Func<UniRx.Unit, PRISM.UI.LvTicketSelectorButtonType> <>9__7_3;
        private PRISM.UI.LvTicketSelectorButtonType <Setup>b__7_2(UniRx.Unit _);
        private PRISM.UI.LvTicketSelectorButtonType <Setup>b__7_3(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions
public class CharacterBaseDetailConnector : PRISM.Interactions.CharacterViewConnector<PRISM.Adapters.CharacterBaseDetailArgument>, PRISM.ICharacterBaseDetailConnector
{
    protected PRISM.Adapters.CharacterBaseDetailArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
}

// Namespace: PRISM.Interactions
public class BaseSelectView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.CharacterPlateView[] plateViews;
    private PRISM.AutoCancellationTokenSource canceller;
    public System.IObservable<int> OnTapPosition { get; set; }
    public Cysharp.Threading.Tasks.UniTask ApplyUnitMemberDataAsync(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.CharacterBaseSelectCharacterViewModel> viewModels, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private void OnDestroy();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Interactions.CharacterPlateView, int, System.IObservable<int>> <>9__2_0;
        private System.IObservable<int> <get_OnTapPosition>b__2_0(PRISM.Interactions.CharacterPlateView x, int i);
    }

    private class <>c__DisplayClass2_0
    {
        public int i;
        private int <get_OnTapPosition>b__1(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions
public class CharacterBaseSelectConnector : PRISM.Interactions.CharacterViewConnector, PRISM.ICharacterBaseSelectConnector
{
}

// Namespace: PRISM.Interactions
public class CharacterBaseSelectView : UnityEngine.MonoBehaviour, PRISM.Adapters.ICharacterBaseSelectView
{
    private PRISM.Interactions.UnitTabGroupView unitTabGroup;
    private PRISM.Interactions.BaseSelectView baseSelectView;
    public System.IObservable<int> OnTapPosition { get; set; }
    public void Setup(PRISM.Adapters.CharacterBaseSelectViewModel vm, PRISM.ResourceManagement.IResourceLoader resourceLoader);

    private class <>c__DisplayClass4_0
    {
        public PRISM.Interactions.CharacterBaseSelectView <>4__this;
        public PRISM.Adapters.CharacterBaseSelectViewModel vm;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private void <Setup>b__0(int _);
    }
}

// Namespace: PRISM.Interactions
public class CharacterPlateView : UnityEngine.MonoBehaviour
{
    private UnityEngine.Transform container;
    private PRISM.Interactions.ButtonView button;
    private PRISM.Interactions.ViewStateChanger ownedStateChanger;
    private PRISM.Interactions.ViewStateChanger loadingStateChanger;
    private System.Collections.Generic.Dictionary<int, UnityEngine.GameObject> instantiatedObjects;
    public System.IObservable<UniRx.Unit> OnTapPosition { get; set; }
    public Cysharp.Threading.Tasks.UniTask ChangeIdolImageAsync(PRISM.Adapters.CharacterBaseSelectCharacterViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);

    private struct <ChangeIdolImageAsync>d__7 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.CharacterPlateView <>4__this;
        public PRISM.Adapters.CharacterBaseSelectCharacterViewModel viewModel;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        private Awaiter<UnityEngine.GameObject> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class UnitTabGroupView : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.ScrollRect scrollRect;
    private PRISM.Interactions.UnitTabGroupViewCell cellBase;
    public void Initialize(UniRx.ReactiveProperty<int> selectedUnitId, PRISM.ResourceManagement.IResourceLoader resourceLoader);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Definitions.MstUnit, bool> <>9__2_0;
        private bool <Initialize>b__2_0(PRISM.Definitions.MstUnit x);
    }

    private class <>c__DisplayClass2_0
    {
        public UniRx.ReactiveProperty<int> selectedUnitId;
        private bool <Initialize>b__1(PRISM.Definitions.MstUnit x);
    }
}

// Namespace: PRISM.Interactions
public class UnitTabGroupViewCell : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView buttonView;
    private UnityEngine.UI.Image logoImage;
    public void Initialize(PRISM.Definitions.MstUnit unit, UniRx.ReactiveProperty<int> selectedUnitId, PRISM.ResourceManagement.IResourceLoader resourceLoader);

    private class <>c__DisplayClass2_0
    {
        public UniRx.ReactiveProperty<int> selectedUnitId;
        public PRISM.Definitions.MstUnit unit;
        public PRISM.Interactions.UnitTabGroupViewCell <>4__this;
        private void <Initialize>b__0(UniRx.Unit _);
        private void <Initialize>b__1(int id);
    }
}

// Namespace: PRISM.Interactions
public class CharacterSelectClickObservableInt : PRISM.ClickObservableContext<int>
{
    private bool <SimpleIcon>k__BackingField;
    private bool <AlbumIcon>k__BackingField;
    private UniRx.ReactiveProperty<int> <DisplaySwitchingIndexRP>k__BackingField;
    private UniRx.ReactiveProperty<PRISM.Definitions.SortType> <SortStateReactive>k__BackingField;
    private UniRx.ReactiveProperty<int> <SelectorIndexReactive>k__BackingField;
    public bool SimpleIcon { get; set; }
    public bool AlbumIcon { get; set; }
    public UniRx.ReactiveProperty<int> DisplaySwitchingIndexRP { get; set; }
    public UniRx.ReactiveProperty<PRISM.Definitions.SortType> SortStateReactive { get; set; }
    public UniRx.ReactiveProperty<int> SelectorIndexReactive { get; set; }
    public void Dispose();
}

// Namespace: PRISM.Interactions
public class CharacterViewConnector`1<TArgument> : PRISM.Interactions.ViewConnector<TArgument>
{
    protected Cysharp.Threading.Tasks.UniTask _playBgmAsync();
}

// Namespace: PRISM.Interactions
public class CharacterViewConnector : PRISM.Interactions.CharacterViewConnector<PRISM.Adapters.NullArgument>
{
    protected PRISM.Adapters.NullArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
}

// Namespace: PRISM.Interactions
public class EnhancedCharacterSelectGridView : UnityEngine.MonoBehaviour, EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate, System.IDisposable
{
    private EnhancedUI.EnhancedScroller.EnhancedScroller scroller;
    private EnhancedUI.EnhancedScroller.EnhancedScrollerCellView rowPrefab;
    private int iconsCountInRow;
    private UnityEngine.GameObject emptyView;
    private System.Collections.Generic.List<PRISM.Common.Model.CharacterIcon[]> iconRows;
    private System.Nullable<float> rowHeight;
    private int firstViewTargetId;
    private PRISM.Interactions.CharacterSelectClickObservableInt <ViewContext>k__BackingField;
    public PRISM.Interactions.CharacterSelectClickObservableInt ViewContext { get; set; }
    private int EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate.GetNumberOfCells(EnhancedUI.EnhancedScroller.EnhancedScroller scroller);
    private float EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate.GetCellViewSize(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex);
    private EnhancedUI.EnhancedScroller.EnhancedScrollerCellView EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate.GetCellView(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex, int cellIndex);
    public void Setup(PRISM.ResourceManagement.IResourceLoader resourceLoader, int firstViewTargetId);
    public void UpdateContent(System.Collections.Generic.IReadOnlyList<PRISM.Common.Model.CharacterIcon> charaIcons);
    public void Dispose();
    private void _activateCell(PRISM.Interactions.AbstractEnhancedCharacterSelectGridCellView cellView);
    private int <UpdateContent>b__14_1(System.ValueTuple<PRISM.Common.Model.CharacterIcon, int> t);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Interactions.AbstractEnhancedCharacterSelectGridCellView, bool> <>9__13_0;
        public static System.Func<PRISM.Common.Model.CharacterIcon, int, System.ValueTuple<PRISM.Common.Model.CharacterIcon, int>> <>9__14_0;
        public static System.Func<System.Linq.IGrouping<int, System.ValueTuple<PRISM.Common.Model.CharacterIcon, int>>, int> <>9__14_2;
        public static System.Func<System.ValueTuple<PRISM.Common.Model.CharacterIcon, int>, PRISM.Common.Model.CharacterIcon> <>9__14_5;
        public static System.Func<System.Linq.IGrouping<int, System.ValueTuple<PRISM.Common.Model.CharacterIcon, int>>, PRISM.Common.Model.CharacterIcon[]> <>9__14_3;
        public static System.Func<PRISM.Common.Model.CharacterIcon, int, bool> <>9__14_4;
        private bool <Setup>b__13_0(PRISM.Interactions.AbstractEnhancedCharacterSelectGridCellView cellView);
        private System.ValueTuple<PRISM.Common.Model.CharacterIcon, int> <UpdateContent>b__14_0(PRISM.Common.Model.CharacterIcon icon, int index);
        private int <UpdateContent>b__14_2(System.Linq.IGrouping<int, System.ValueTuple<PRISM.Common.Model.CharacterIcon, int>> x);
        private PRISM.Common.Model.CharacterIcon[] <UpdateContent>b__14_3(System.Linq.IGrouping<int, System.ValueTuple<PRISM.Common.Model.CharacterIcon, int>> g);
        private PRISM.Common.Model.CharacterIcon <UpdateContent>b__14_5(System.ValueTuple<PRISM.Common.Model.CharacterIcon, int> x);
        private bool <UpdateContent>b__14_4(PRISM.Common.Model.CharacterIcon m, int id);
    }
}

// Namespace: PRISM.Interactions
public class EnhancedPIdolSelectGridCellView : PRISM.Interactions.AbstractEnhancedCharacterSelectGridCellView
{
    private PRISM.UI.PFIdolIconView[] iconViews;
    private System.Threading.CancellationTokenSource cts;
    public void Setup(int startDataIndexInRow, PRISM.Common.Model.CharacterIcon[] icons, PRISM.Interactions.CharacterSelectClickObservableInt context);
    private void _iconSetup(PRISM.UI.PFIdolIconView pIdolIconView, PRISM.Common.Model.PIdolIcon pIdolIcon, PRISM.Interactions.CharacterSelectClickObservableInt context, int dataIndex);

    private class <>c__DisplayClass3_0
    {
        public PRISM.Interactions.CharacterSelectClickObservableInt context;
        private void <_iconSetup>b__0(int i);
        private void <_iconSetup>b__1(int i);
        private void <_iconSetup>b__2(int i);
        private void <_iconSetup>b__3(int i);
        private void <_iconSetup>b__4(int i);
        private void <_iconSetup>b__5(int i);
    }
}

// Namespace: PRISM.Interactions
public class EnhancedPieceSelectGridCellView : EnhancedUI.EnhancedScroller.EnhancedScrollerCellView
{
    private PRISM.Interactions.PieceIconView[] iconViews;
    private PRISM.AutoCancellationTokenSource canceller;
    public void Setup(int startDataIndexInRow, PRISM.Common.Model.PieceIcon[] icons, PRISM.Interactions.PieceSelectGridViewContext context);
    private void _iconSetup(PRISM.Interactions.PieceIconView iconView, PRISM.Common.Model.PieceIcon iconData, PRISM.Interactions.PieceSelectGridViewContext context, int dataIndex, System.Threading.CancellationToken ct);
    private void OnDestroy();
}

// Namespace: PRISM.Interactions
public class EnhancedPieceSelectGridView : UnityEngine.MonoBehaviour, EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate, System.IDisposable
{
    private EnhancedUI.EnhancedScroller.EnhancedScroller scroller;
    private EnhancedUI.EnhancedScroller.EnhancedScrollerCellView rowPrefab;
    private int iconsCountInRow;
    private UnityEngine.GameObject emptyView;
    private System.Collections.Generic.List<PRISM.Common.Model.PieceIcon[]> iconRows;
    private System.Nullable<float> rowHeight;
    private PRISM.Interactions.PieceSelectGridViewContext <ViewContext>k__BackingField;
    public PRISM.Interactions.PieceSelectGridViewContext ViewContext { get; set; }
    private int EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate.GetNumberOfCells(EnhancedUI.EnhancedScroller.EnhancedScroller scroller);
    private float EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate.GetCellViewSize(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex);
    private EnhancedUI.EnhancedScroller.EnhancedScrollerCellView EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate.GetCellView(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex, int cellIndex);
    public void Setup();
    public void UpdateContent(System.Collections.Generic.IReadOnlyList<PRISM.Common.Model.PieceIcon> icons);
    public void Dispose();
    private void _activateCell(PRISM.Interactions.EnhancedPieceSelectGridCellView cellView);
    private int <UpdateContent>b__13_1(System.ValueTuple<PRISM.Common.Model.PieceIcon, int> t);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Interactions.EnhancedPieceSelectGridCellView, bool> <>9__12_0;
        public static System.Func<PRISM.Common.Model.PieceIcon, int, System.ValueTuple<PRISM.Common.Model.PieceIcon, int>> <>9__13_0;
        public static System.Func<System.Linq.IGrouping<int, System.ValueTuple<PRISM.Common.Model.PieceIcon, int>>, int> <>9__13_2;
        public static System.Func<System.ValueTuple<PRISM.Common.Model.PieceIcon, int>, PRISM.Common.Model.PieceIcon> <>9__13_4;
        public static System.Func<System.Linq.IGrouping<int, System.ValueTuple<PRISM.Common.Model.PieceIcon, int>>, PRISM.Common.Model.PieceIcon[]> <>9__13_3;
        private bool <Setup>b__12_0(PRISM.Interactions.EnhancedPieceSelectGridCellView cellView);
        private System.ValueTuple<PRISM.Common.Model.PieceIcon, int> <UpdateContent>b__13_0(PRISM.Common.Model.PieceIcon icon, int index);
        private int <UpdateContent>b__13_2(System.Linq.IGrouping<int, System.ValueTuple<PRISM.Common.Model.PieceIcon, int>> x);
        private PRISM.Common.Model.PieceIcon[] <UpdateContent>b__13_3(System.Linq.IGrouping<int, System.ValueTuple<PRISM.Common.Model.PieceIcon, int>> g);
        private PRISM.Common.Model.PieceIcon <UpdateContent>b__13_4(System.ValueTuple<PRISM.Common.Model.PieceIcon, int> x);
    }
}

// Namespace: PRISM.Interactions
public class EnhancedSCharaSelectGridCellView : PRISM.Interactions.AbstractEnhancedCharacterSelectGridCellView
{
    private PRISM.Interactions.SupportCharacterSelectIconView[] iconViews;
    private System.Threading.CancellationTokenSource cts;
    public void Setup(int startDataIndexInRow, PRISM.Common.Model.CharacterIcon[] icons, PRISM.Interactions.CharacterSelectClickObservableInt context);
    private void _iconSetup(PRISM.Interactions.SupportCharacterSelectIconView iconView, PRISM.Common.Model.SCharaIcon sCharaIcon, PRISM.Interactions.CharacterSelectClickObservableInt context, int dataIndex);

    private class <>c__DisplayClass3_0
    {
        public PRISM.Interactions.CharacterSelectClickObservableInt context;
        public PRISM.Interactions.SupportCharacterSelectIconView iconView;
        private void <_iconSetup>b__0(int i);
        private void <_iconSetup>b__1(int i);
        private void <_iconSetup>b__2(int i);
        private void <_iconSetup>b__3(int i);
        private void <_iconSetup>b__4(int i);
        private void <_iconSetup>b__5(int i);
        private void <_iconSetup>b__6(int index);
        private void <_iconSetup>b__7(PRISM.Definitions.SortType sortType);
    }
}

// Namespace: PRISM.Interactions
public class EnhancedUnitSelectGridCellView : EnhancedUI.EnhancedScroller.EnhancedScrollerCellView
{
    private PRISM.UI.FUnitIconView[] iconViews;
    public void Setup(int startDataIndexInRow, PRISM.Common.Model.FUnitIcon[] icons, PRISM.Interactions.UnitSelectClickObservableInt context);
    public void Reset();

    private class <>c__DisplayClass1_0
    {
        public PRISM.Interactions.UnitSelectClickObservableInt context;
        public System.Action<int> <>9__0;
        public System.Action<int> <>9__1;
        private void <Setup>b__0(int dataIndex);
        private void <Setup>b__1(int dataIndex);
    }
}

// Namespace: PRISM.Interactions
public class EnhancedUnitSelectGridView : UnityEngine.MonoBehaviour, EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate, System.IDisposable
{
    private EnhancedUI.EnhancedScroller.EnhancedScroller scroller;
    private EnhancedUI.EnhancedScroller.EnhancedScrollerCellView rowPrefab;
    private int iconsCountInRow;
    private UnityEngine.GameObject emptyView;
    private System.Collections.Generic.List<PRISM.Common.Model.FUnitIcon[]> iconRows;
    private System.Nullable<float> rowHeight;
    private DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> tweenerCore;
    private PRISM.Interactions.UnitSelectClickObservableInt <ViewContext>k__BackingField;
    public PRISM.Interactions.UnitSelectClickObservableInt ViewContext { get; set; }
    private int EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate.GetNumberOfCells(EnhancedUI.EnhancedScroller.EnhancedScroller scroller);
    private float EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate.GetCellViewSize(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex);
    private EnhancedUI.EnhancedScroller.EnhancedScrollerCellView EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate.GetCellView(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex, int cellIndex);
    public void Setup(PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void UpdateContent(PRISM.Common.Model.FUnitIcon[] fUnitIcons);
    public void SetBlink(bool on);
    public void Dispose();
    private void _activateCell(PRISM.Interactions.EnhancedUnitSelectGridCellView cellView);
    private void _deactivateCell(PRISM.Interactions.EnhancedUnitSelectGridCellView cellView);
    private int <UpdateContent>b__14_1(System.ValueTuple<PRISM.Common.Model.FUnitIcon, int> t);
    private void <SetBlink>b__15_1(float value);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Interactions.EnhancedUnitSelectGridCellView, bool> <>9__13_0;
        public static System.Func<PRISM.Common.Model.FUnitIcon, int, System.ValueTuple<PRISM.Common.Model.FUnitIcon, int>> <>9__14_0;
        public static System.Func<System.Linq.IGrouping<int, System.ValueTuple<PRISM.Common.Model.FUnitIcon, int>>, int> <>9__14_2;
        public static System.Func<System.ValueTuple<PRISM.Common.Model.FUnitIcon, int>, PRISM.Common.Model.FUnitIcon> <>9__14_4;
        public static System.Func<System.Linq.IGrouping<int, System.ValueTuple<PRISM.Common.Model.FUnitIcon, int>>, PRISM.Common.Model.FUnitIcon[]> <>9__14_3;
        public static DG.Tweening.Core.DOGetter<float> <>9__15_0;
        private bool <Setup>b__13_0(PRISM.Interactions.EnhancedUnitSelectGridCellView cellView);
        private System.ValueTuple<PRISM.Common.Model.FUnitIcon, int> <UpdateContent>b__14_0(PRISM.Common.Model.FUnitIcon icon, int index);
        private int <UpdateContent>b__14_2(System.Linq.IGrouping<int, System.ValueTuple<PRISM.Common.Model.FUnitIcon, int>> x);
        private PRISM.Common.Model.FUnitIcon[] <UpdateContent>b__14_3(System.Linq.IGrouping<int, System.ValueTuple<PRISM.Common.Model.FUnitIcon, int>> g);
        private PRISM.Common.Model.FUnitIcon <UpdateContent>b__14_4(System.ValueTuple<PRISM.Common.Model.FUnitIcon, int> x);
        private float <SetBlink>b__15_0();
    }
}

// Namespace: PRISM.Interactions
public class SupportEffectFilterToggleButtonView : UnityEngine.MonoBehaviour
{
    private int id;
    private PRISM.Interactions.ButtonView button;
    private PRISM.Interactions.ViewStateChanger isOnStateChanger;
    public void Initialize(PRISM.Definitions.IReactiveHashSet<int> onIds, System.Threading.CancellationToken cancellationToken);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<int, bool> <>9__3_3;
        public static System.Func<int, bool> <>9__3_4;
        private bool <Initialize>b__3_3(int x);
        private bool <Initialize>b__3_4(int x);
    }

    private class <>c__DisplayClass3_0
    {
        public PRISM.Definitions.IReactiveHashSet<int> onIds;
        public PRISM.Interactions.SupportEffectFilterToggleButtonView <>4__this;
        private void <Initialize>b__0(UniRx.Unit _);
        private void <Initialize>b__1(int addId);
        private void <Initialize>b__2(int removeId);
    }
}

// Namespace: PRISM.Interactions
public class SupportEffectFilterToggleGroupView : PRISM.Interactions.FilterToggleGroupView
{
    private ENTERPRISE.UI.UITextMeshProUGUI titleText;
    private ENTERPRISE.UI.UITextMeshProUGUI selectedEffectTypeText;
    private ENTERPRISE.UI.UITextMeshProUGUI selectedScheduleText;
    private PRISM.Interactions.SupportEffectFilterToggleButtonView[] effectTypeToggles;
    private PRISM.Interactions.SupportEffectFilterToggleButtonView[] scheduleToggles;
    private PRISM.Interactions.ToggleButtonView toggleButton;
    private PRISM.Interactions.ButtonView resetButton;
    public void SetViewTitle(int index);
    public void Initialize(PRISM.Definitions.IReactiveHashSet<int> onIds, PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Adapters.IFilterToggleGroupViewOption option, System.Threading.CancellationToken cancellationToken);
    private void _setSelectedText(PRISM.Definitions.IReactiveHashSet<int> onIds);

    private class <>c__DisplayClass8_0
    {
        public PRISM.Definitions.IReactiveHashSet<int> onIds;
        public PRISM.Interactions.SupportEffectFilterToggleGroupView <>4__this;
        private void <Initialize>b__0(UniRx.Unit _);
        private void <Initialize>b__1(int addId);
    }
}

// Namespace: PRISM.Interactions
public class PieceIconView : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.OutGame.RewardItem rewardItem;
    private UnityEngine.CanvasGroup cgSelectedFrame;
    private UnityEngine.GameObject goBadge;
    private PRISM.UIGrayOutController grayOutController;
    private void Awake();
    public void SetUp(int index, PRISM.Common.Model.PieceIcon icon, bool isSurplus, PRISM.IContextClick<int> context, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    private void _setupItemIcon(PRISM.Common.Model.PieceIcon icon, bool isSurplus, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public void SetUpForPieceConversionConfirmed(PRISM.Common.Model.PieceIcon icon, bool isSurplus, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void SetUp(PRISM.Domain.ProductKey pk, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private void _switchSelected(bool isSelected);
    private void _grayOut(bool isGrayOut);

    private class <>c__DisplayClass5_0
    {
        public PRISM.IContextClick<int> context;
        public int index;
        public PRISM.Interactions.PieceIconView <>4__this;
        private void <SetUp>b__0();
        private void <SetUp>b__1(bool b);
        private void <SetUp>b__2(bool b);
    }
}

// Namespace: PRISM.Interactions
public class RequiredCurrentItemIconView : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.RawImage imgItem;
    private PRISM.Interactions.ButtonView button;
    private ENTERPRISE.UI.UITextMeshProUGUI txtRequiredAmount;
    private ENTERPRISE.UI.UITextMeshProUGUI txtCurrentAmount;
    private ENTERPRISE.UI.ColorToOutlineForTextMeshProUGUI outlineForTextMeshProUGUI;
    private PRISM.AutoCancellationTokenSource cts;
    public void Setup(PRISM.Domain.ProductKey pieceProductKey, long requiredAmount, long amount, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private void OnDestroy();

    private class <>c__DisplayClass6_0
    {
        public PRISM.Domain.ProductKey pieceProductKey;
        public System.Threading.CancellationToken ct;
        private void <Setup>b__0(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions
public class RequiredItemIconView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView button;
    private UnityEngine.UI.RawImage imgItem;
    private ENTERPRISE.UI.UITextMeshProUGUI txtRequired;
    private ENTERPRISE.UI.UITextMeshProUGUI txtHave;
    private PRISM.UIGrayOutController grayOutController;
    private PRISM.AutoCancellationTokenSource cts;
    public void Setup(PRISM.Adapters.RequiredItemIconViewModel item, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private void _setRequired(long amount);
    private void _setHave(long amount);
    private void OnDestroy();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Domain.ProductKey, bool> <>9__6_0;
        private bool <Setup>b__6_0(PRISM.Domain.ProductKey x);
    }

    private class <>c__DisplayClass6_0
    {
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public PRISM.Interactions.RequiredItemIconView <>4__this;
        public PRISM.Adapters.RequiredItemIconViewModel item;
        public System.Threading.CancellationToken ct;
        private void <Setup>b__1(PRISM.Domain.ProductKey key);
        private void <Setup>b__2(long r);
        private void <Setup>b__3(long h);
        private void <Setup>b__4(bool b);
        private void <Setup>b__5(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions
public class CostumeSettingView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ToggleGroupView toggleButtonGroup;
    private PRISM.Interactions.CostumeSetIconView costumeSetIconView;
    private PRISM.Interactions.ViewStateChanger isSetStateChanger;
    private UniRx.ReactiveProperty<int> toggleButtonIndex;
    public System.IObservable<bool> OnIsSetChanged { get; set; }
    public System.IObservable<UniRx.Unit> OnSelectCasualCostume { get; set; }
    private void Awake();
    public void Setup(bool isSet, PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Domain.ICostumeSetData costumeSet);
    private bool <get_OnSelectCasualCostume>b__7_0(UniRx.Unit _);
    private void <Setup>b__9_0(bool isSet);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<int, bool> <>9__5_0;
        private bool <get_OnIsSetChanged>b__5_0(int x);
    }
}

// Namespace: PRISM.Interactions
public class IdolBaseDetailCasualCostumeView : UnityEngine.MonoBehaviour, PRISM.Adapters.IIdolBaseDetailCasualCostumeView
{
    private PRISM.Interactions.CostumeSettingView inStoryCostumeSettingView;
    private PRISM.Interactions.CostumeSettingView inOtherCostumeSettingView;
    public System.IObservable<bool> OnChangeInStoryRadioBtnSelection { get; set; }
    public System.IObservable<bool> OnChangeInOtherRadioBtnSelection { get; set; }
    public System.IObservable<IdolBaseCostumeTargetSceneType> ToCasualCostumeSelection { get; set; }
    public void Assign(PRISM.Adapters.IdolBaseDetailCasualCostumeViewModel vm, PRISM.ResourceManagement.IResourceLoader resourceLoader);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<UniRx.Unit, IdolBaseCostumeTargetSceneType> <>9__7_0;
        public static System.Func<UniRx.Unit, IdolBaseCostumeTargetSceneType> <>9__7_1;
        private IdolBaseCostumeTargetSceneType <get_ToCasualCostumeSelection>b__7_0(UniRx.Unit _);
        private IdolBaseCostumeTargetSceneType <get_ToCasualCostumeSelection>b__7_1(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions
public class IdolBaseDetailConnector : PRISM.Interactions.CharacterViewConnector<PRISM.Adapters.IdolBaseDetailArgument>, PRISM.UICharacter.IIdolBaseDetailConnector
{
    protected PRISM.Adapters.IdolBaseDetailArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
}

// Namespace: PRISM.Interactions
public class IdolBaseDetailGalleryView : UnityEngine.MonoBehaviour, PRISM.Adapters.IIdolBaseDetailGalleryView
{
    private PRISM.Interactions.ButtonView[] buttons;
    public System.IObservable<PRISM.Adapters.GalleryContents> OnTap { get; set; }
    public void Assign(PRISM.Adapters.IdolBaseDetailGalleryViewModel vm);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Interactions.ButtonView, int, System.IObservable<PRISM.Adapters.GalleryContents>> <>9__2_0;
        private System.IObservable<PRISM.Adapters.GalleryContents> <get_OnTap>b__2_0(PRISM.Interactions.ButtonView x, int i);
    }

    private class <>c__DisplayClass2_0
    {
        public int i;
        private PRISM.Adapters.GalleryContents <get_OnTap>b__1(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions
public class IdolBaseDetailProfileView : UnityEngine.MonoBehaviour, PRISM.Adapters.IIdolBaseDetailProfileView
{
    private UnityEngine.UI.Image imgUnitIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI txtCharaReadingLastName;
    private ENTERPRISE.UI.UITextMeshProUGUI txtCharaReadingFirstName;
    private ENTERPRISE.UI.UITextMeshProUGUI txtCharaLastName;
    private ENTERPRISE.UI.UITextMeshProUGUI txtCharaFirstName;
    private ENTERPRISE.UI.UITextMeshProUGUI txtCv;
    private ENTERPRISE.UI.UITextMeshProUGUI txtAge;
    private ENTERPRISE.UI.UITextMeshProUGUI txtBloodType;
    private ENTERPRISE.UI.UITextMeshProUGUI txtBirthday;
    private ENTERPRISE.UI.UITextMeshProUGUI txtZodiacSign;
    private ENTERPRISE.UI.UITextMeshProUGUI txtDominantHand;
    private ENTERPRISE.UI.UITextMeshProUGUI txtBirthPlace;
    private ENTERPRISE.UI.UITextMeshProUGUI txtHeight;
    private ENTERPRISE.UI.UITextMeshProUGUI txtWeight;
    private ENTERPRISE.UI.UITextMeshProUGUI txtHobby;
    private ENTERPRISE.UI.UITextMeshProUGUI txtSpecialAbility;
    private ENTERPRISE.UI.UITextMeshProUGUI txtDescription;
    private UnityEngine.UI.Image[] imgLabels;
    private UnityEngine.UI.Image imgBg;
    public void Assign(int mstCharacterInfoId, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private static void <Assign>g__ChangeText|19_0(ENTERPRISE.UI.UITextMeshProUGUI tmp, string text, <>c__DisplayClass19_0& );
    private static string <Assign>g__ConvertBirthDay|19_1(string s);

    private struct <>c__DisplayClass19_0 : System.ValueType
    {
        public UnityEngine.Color fontColor;
    }
}

// Namespace: PRISM.Interactions
public class IdolBaseDetailStatusView : UnityEngine.MonoBehaviour, PRISM.Adapters.IIdolBaseDetailStatusView
{
    private ENTERPRISE.UI.UITextMeshProUGUI txtIdolLv;
    private UnityEngine.GameObject goIdolLvMax;
    private ENTERPRISE.UI.UITextMeshProUGUI txtIdolExp;
    private UnityEngine.UI.Image imgIdolExpFillColor;
    private ENTERPRISE.UI.UIButton btnIdolLvRewardList;
    private PRISM.Interactions.VoDaViMeView voDaViMeView;
    private ENTERPRISE.UI.UITextMeshProUGUI txtReliabilityLv;
    private UnityEngine.GameObject goReliabilityLvMax;
    private ENTERPRISE.UI.UITextMeshProUGUI txtReliabilityExp;
    private UnityEngine.UI.Image imgReliabilityExpFillColor;
    private ENTERPRISE.UI.UIButton btnReliabilityRewardList;
    private ENTERPRISE.UI.UITextMeshProUGUI txtFan;
    private UniRx.Subject<UniRx.Unit> onIdolLvRewardList;
    private UniRx.Subject<UniRx.Unit> onReliabilityRewardList;
    public System.IObservable<UniRx.Unit> OnIdolLvRewardList { get; set; }
    public System.IObservable<UniRx.Unit> OnReliabilityRewardList { get; set; }
    private void Awake();
    public void Assign(PRISM.Adapters.IdolBaseDetailStatusViewModel vm);
    private static string <Assign>g__toNumber2CommaText|19_8(long value);

    private class <>c__DisplayClass19_0
    {
        public PRISM.Interactions.IdolBaseDetailStatusView <>4__this;
        public ENTERPRISE.Localization.LocalizationManager localizationManager;
        private void <Assign>b__0();
        private void <Assign>b__1();
        private void <Assign>b__2(System.Collections.Generic.IList<int> x);
        private void <Assign>b__3(System.Collections.Generic.IList<long> x);
        private void <Assign>b__4(PRISM.Adapters.VoDaViMeViewModel x);
        private void <Assign>b__5(System.Collections.Generic.IList<int> x);
        private void <Assign>b__6(System.Collections.Generic.IList<long> x);
        private void <Assign>b__7(ulong x);
    }
}

// Namespace: PRISM.Interactions
public class IdolBaseDetailUICharacterView : UnityEngine.MonoBehaviour, PRISM.Adapters.IIdolBaseDetailUICharacterView
{
    private PRISM.UI.UICharacterViewer uiCharacterViewer;
    private PRISM.UI.CenteringObjectsOutsideSafeArea characterPositionAdjuster;
    public void Inject(System.Func<bool> isOverlayShowFunc);
    public Cysharp.Threading.Tasks.UniTask<bool> Setup3DCharaAsync(PRISM.UI.UICharacterVoiceInfo voiceInfo);
    public void ChangeCostume(PRISM.UnitIdol unitIdol);
    public void PausePlayingVoiceMotion();
    public void OnNextViewPreparation();
    public Cysharp.Threading.Tasks.UniTask ReleaseAsync();

    private struct <Setup3DCharaAsync>d__3 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
        public PRISM.Interactions.IdolBaseDetailUICharacterView <>4__this;
        public PRISM.UI.UICharacterVoiceInfo voiceInfo;
        private Awaiter<bool> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class IdolBaseDetailView : UnityEngine.MonoBehaviour, PRISM.Adapters.IIdolBaseDetailView
{
    private PRISM.Interactions.CommonTitleView titleView;
    private UnityEngine.UI.Image charaColorBg;
    private PRISM.Interactions.ToggleGroupView toggleGroup;
    private UnityEngine.GameObject[] tabObjects;
    public void Assign(PRISM.Adapters.IdolBaseDetailViewModel vm, UniRx.IReactiveProperty<int> selectedTabIndex);
    public void SetTabDisabled(int tabIndex);
}

// Namespace: PRISM.Interactions
public class FavoriteTransferFooterView : UnityEngine.MonoBehaviour
{
    private UnityEngine.CanvasGroup cgTotalCount;
    private UnityEngine.CanvasGroup cgSelectedFavorites;
    private UnityEngine.CanvasGroup cgSelectedTransfers;
    private UnityEngine.UI.RawImage imgFavoriteIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI txtTotalCount;
    private ENTERPRISE.UI.UITextMeshProUGUI txtSelectedFavorites;
    private ENTERPRISE.UI.UITextMeshProUGUI txtTransferLimits;
    private ENTERPRISE.UI.UITextMeshProUGUI txtSelectedTransfers;
    private ENTERPRISE.UI.UIButton btnRight;
    private ENTERPRISE.UI.UIButton btnLeftBlue;
    private ENTERPRISE.UI.UIButton btnLeftCancel;
    private ENTERPRISE.UI.UITextMeshProUGUI txtBtnRight;
    private UniRx.Subject<PRISM.Adapters.IdolListFooterType> onChangeType;
    private UniRx.Subject<UniRx.Unit> setAsFavorite;
    private UniRx.Subject<UniRx.Unit> transferSelected;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    private PRISM.Adapters.IdolListFooterType <CurrentType>k__BackingField;
    private int limit;
    public PRISM.Adapters.IdolListFooterType CurrentType { get; set; }
    public System.IObservable<PRISM.Adapters.IdolListFooterType> OnChangeType { get; set; }
    public System.IObservable<UniRx.Unit> SetAsFavorite { get; set; }
    public System.IObservable<UniRx.Unit> TransferSelected { get; set; }
    private void Awake();
    public void Setup(int _limit, int _transferLimit, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void SetSelectedFavoriteMark(int mstFavoriteMarkId);
    public void SetCurrentNum(int currentNum, bool isOver);
    public void Reset();
    private void _switchCanvasGroup(UnityEngine.CanvasGroup cg, bool active);
    private void _changeNormal();
    private void _changeFavorite();
    private void _changeTransfer();
    private void <Setup>b__28_0();
    private void <Setup>b__28_1();
    private void <_changeNormal>b__33_0();
    private void <_changeFavorite>b__34_0();
    private void <_changeTransfer>b__35_0();
}

// Namespace: PRISM.Interactions
public class FesUnitListView : UnityEngine.MonoBehaviour, PRISM.Adapters.IIdolListFesUnitListView, System.IDisposable
{
    private PRISM.Interactions.ToggleGroupView unitTabGroupView;
    private PRISM.Interactions.EnhancedUnitSelectGridView gridView;
    private ENTERPRISE.UI.UITextMeshProUGUI txtEmptyView;
    private PRISM.Interactions.SortFilterView sortFilterView;
    private PRISM.Interactions.FavoriteTransferFooterView footerView;
    private ENTERPRISE.UI.UITextMeshProUGUI txtGuide;
    private UniRx.Subject<int> onSelectIndex;
    private UniRx.Subject<int> onSelectIndexAsFavorite;
    private UniRx.Subject<int> onSelectIndexAsTransfer;
    private UniRx.Subject<PRISM.Adapters.IdolListFooterType> onChangeFooterType;
    private UniRx.Subject<UniRx.Unit> onBatchFavorite;
    private UniRx.Subject<UniRx.Unit> onBatchTransfer;
    private UniRx.CompositeDisposable disposables;
    public System.IObservable<int> OnSelectIndex { get; set; }
    public System.IObservable<int> OnSelectIndexAsFavorite { get; set; }
    public System.IObservable<int> OnSelectIndexAsTransfer { get; set; }
    public PRISM.Adapters.ISortFilterView SortFilterView { get; set; }
    public System.IObservable<PRISM.Adapters.IdolListFooterType> OnChangeFooterType { get; set; }
    public System.IObservable<UniRx.Unit> OnBatchFavorite { get; set; }
    public System.IObservable<UniRx.Unit> OnBatchTransfer { get; set; }
    public void Setup(UniRx.IReactiveProperty<int> selectedUnitTabIndex, int unitLimit, int transferUnitLimit, System.IObservable<System.ValueTuple<PRISM.Common.Model.FUnitIcon[], bool>> setDataObservable, System.IObservable<System.ValueTuple<int, bool>> currentNumObservable, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void FooterReset();
    public void SetFooterSelectedFavoriteMark(int selectedMarkId);
    public void Show(bool isShow);
    public void Dispose();
    private void <Setup>b__27_0(System.ValueTuple<int, bool> t);
    private void <Setup>b__27_1(System.ValueTuple<PRISM.Common.Model.FUnitIcon[], bool> t);
    private void <Setup>b__27_3(int index);
    private void <Setup>b__27_4(int index);
    private void <Setup>b__27_2(PRISM.Adapters.IdolListFooterType type);
}

// Namespace: PRISM.Interactions
public class IdolListConnector : PRISM.Interactions.CharacterViewConnector<PRISM.Adapters.IdolListArgument>, PRISM.IIdolListConnector
{
    protected PRISM.Adapters.IdolListArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
}

// Namespace: PRISM.Interactions
public class IdolListView : UnityEngine.MonoBehaviour, PRISM.Adapters.IIdolListView
{
    private PRISM.Interactions.ToggleGroupView toggleGroup;
    public void Setup(UniRx.IReactiveProperty<int> selectedIndex);
}

// Namespace: PRISM.Interactions
public class SupportCharaListView : UnityEngine.MonoBehaviour, PRISM.Adapters.ISupportCharaListView
{
    private PRISM.Interactions.EnhancedCharacterSelectGridView gridView;
    private PRISM.Interactions.SortFilterView sortFilterView;
    private PRISM.Interactions.ButtonView displaySwitchingButton;
    private ENTERPRISE.UI.UITextMeshProUGUI displaySwitchingText;
    private UniRx.Subject<int> onSelectIndex;
    private UniRx.Subject<int> onDetail;
    private System.IDisposable onClickDisposable;
    private System.IDisposable onLongPressDisposable;
    public System.IObservable<int> OnSelectIndex { get; set; }
    public System.IObservable<int> OnDetail { get; set; }
    public PRISM.Adapters.ISortFilterView SortFilterView { get; set; }
    public void Setup(PRISM.Adapters.SupportCharacterSelectModel model, PRISM.ResourceManagement.IResourceLoader resourceLoader, int firstViewTargetId);
    private void OnDestroy();
    private void _setChangeDisplaySwitching(UniRx.IReactiveProperty<int> currentIndex, int maxDisplaySwitchingCount);
    private void <Setup>b__14_0(System.ValueTuple<System.Collections.Generic.IReadOnlyList<PRISM.Common.Model.SCharaIcon>, PRISM.Definitions.SortType> x);
    private void <Setup>b__14_1(int index);
    private void <Setup>b__14_2(int index);

    private class <>c__DisplayClass16_0
    {
        public UniRx.IReactiveProperty<int> currentIndex;
        public int maxDisplaySwitchingCount;
        public PRISM.Interactions.SupportCharaListView <>4__this;
        private void <_setChangeDisplaySwitching>b__0(UniRx.Unit _);
        private void <_setChangeDisplaySwitching>b__1(int index);
    }
}

// Namespace: PRISM.Interactions
public interface ILvSelector
{
    public System.IObservable<UniRx.Unit> OnUp { get; set; }
    public System.IObservable<UniRx.Unit> OnDown { get; set; }
    public void SetMaxLv(int maxLv);
    public void UpdateData(PRISM.Adapters.LvSelectorViewModel vm);
}

// Namespace: PRISM.Interactions
public class ItemPager : UnityEngine.MonoBehaviour
{
    private UnityEngine.RectTransform baseRect;
    private UnityEngine.RectTransform rectContent;
    private PRISM.Interactions.RequiredItemIconGroup requiredItemIconGroupPrefab;
    private UnityEngine.Transform contentParent;
    private PRISM.Interactions.ButtonView nextArrowButton;
    private PRISM.Interactions.ButtonView beforeArrowButton;
    private PRISM.CarouselIndicator carouselIndicator;
    private int visiblePagesCount;
    private int currentPageNum;
    private System.Collections.Generic.List<PRISM.Interactions.RequiredItemIconGroup> itemGroups;
    private float itemGroupWidth;
    public System.Collections.Generic.List<PRISM.Interactions.RequiredItemIconView> Setup(int maxPages);
    public void UpdatePager(int pages);
    private void _setItemGroupRect();
    private System.Collections.Generic.List<PRISM.Interactions.RequiredItemIconView> _createItemGroups(int maxPages);
    private void _setContentPosition();
    private void _setBtnEnable();
    private void <Setup>b__11_0(UniRx.Unit _);
    private void <Setup>b__11_1(UniRx.Unit _);
}

// Namespace: PRISM.Interactions
public class LevelUpView : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI currentLvText;
    private ENTERPRISE.UI.UITextMeshProUGUI afterLvText;
    private ENTERPRISE.UI.UITextMeshProUGUI upText;
    private UnityEngine.UI.Image nextExpFillImage;
    private UnityEngine.UI.Image currentExpFillImage;
    private UniRx.Subject<UniRx.Unit> lvUpAnimationEnd;
    public System.IObservable<UniRx.Unit> LvUpAnimationEnd { get; set; }
    public void Setup(PRISM.Adapters.LevelUpViewModel vm);
    private void _setLv(int currentLv, int nextLv);
    private Cysharp.Threading.Tasks.UniTask _animateGaugeAsync(float beforeRate, float afterRate, float duration);
    private void _setAdditionalState(bool active);
    private void OnDestroy();
    private void <Setup>b__8_0(System.ValueTuple<int, int> x);
    private void <Setup>b__8_1(float x);
    private void <Setup>b__8_2(float x);
    private void <Setup>b__8_3(bool x);
    private void <Setup>b__8_4(System.ValueTuple<float, float, float> x);
    private void <Setup>b__8_5(bool b);

    private class <>c__DisplayClass10_0
    {
        public float beforeRate;
        public float afterRate;
        public PRISM.Interactions.LevelUpView <>4__this;
        private void <_animateGaugeAsync>b__0(float t);
    }

    private struct <_animateGaugeAsync>d__10 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public float beforeRate;
        public float afterRate;
        public PRISM.Interactions.LevelUpView <>4__this;
        public float duration;
        private System.IDisposable <_>5__2;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class LimitLevelUpView : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI currentLimitText;
    private ENTERPRISE.UI.UITextMeshProUGUI afterLimitText;
    public void SetText(int currentLimit, int afterLimit);
}

// Namespace: PRISM.Interactions
public class LimitProduceBonusContentView : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI slotText;
    private PRISM.Interactions.SkillSlotIconView[] skillSlotIconViews;
    private PRISM.Interactions.ViewStateChanger canvasGroupStateChanger;
    private PRISM.Interactions.ViewStateChanger coverObjStateChanger;
    public void Setup(PRISM.Adapters.LimitLvContentViewModel model, PRISM.ResourceManagement.IResourceLoader loader);
    private void <Setup>b__6_0(bool b);
    private void <Setup>b__6_2(bool _);

    private enum BackgroundColorType : System.Enum
    {
        public int value__;
        public static BackgroundColorType White;
        public static BackgroundColorType Yellow;
    }

    private enum CoverImageType : System.Enum
    {
        public int value__;
        public static CoverImageType Off;
        public static CoverImageType On;
    }

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<bool, bool> <>9__6_1;
        private bool <Setup>b__6_1(bool b);
    }
}

// Namespace: PRISM.Interactions
public class LimitProduceBonusView : UnityEngine.MonoBehaviour
{
    private UnityEngine.Transform contentParent;
    private PRISM.Interactions.LimitProduceBonusContentView contentPrefab;
    public void Setup(System.Collections.Generic.List<PRISM.Adapters.LimitLvContentViewModel> viewModelList, PRISM.ResourceManagement.IResourceLoader loader);
}

// Namespace: PRISM.Interactions
public class ListProduceIdolIconView : UnityEngine.MonoBehaviour
{
    public void Initialize(PRISM.Interactions.CharacterSelectClickObservableInt context);
    public Cysharp.Threading.Tasks.UniTask UpdateViewAsync(PRISM.Adapters.ListProduceIdolIconViewModel vm, int dataIndex, System.Threading.CancellationToken ct);
}

// Namespace: PRISM.Interactions
public class LiveSkillEffectLevelUpView : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI currentLevelText;
    private ENTERPRISE.UI.UITextMeshProUGUI afterLevelText;
    private ENTERPRISE.UI.UITextMeshProUGUI skillNameText;
    private ENTERPRISE.UI.UITextMeshProUGUI descriptionText;
    public void SetText(int diamondLevel, int afterDiamondLevel, string skillName, string description);
}

// Namespace: PRISM.Interactions
public class FullSizeImageOverlayView : PRISM.Interactions.OverlayViewWithCloseButton, PRISM.Adapters.IFullSizeImageOverlayView, PRISM.Adapters.IClosableOverlayView<UniRx.Unit>, PRISM.Adapters.IOverlayView, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private UnityEngine.UI.RawImage imgFullSize;
    private UnityEngine.UI.AspectRatioFitter aspectRatioFitter;
    public Cysharp.Threading.Tasks.UniTask AssignAsync(string resourceId, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);

    private struct <AssignAsync>d__2 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public string resourceId;
        public System.Threading.CancellationToken ct;
        public PRISM.Interactions.FullSizeImageOverlayView <>4__this;
        private Awaiter<UnityEngine.Texture2D> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class SCharaFullImageOverlayView : PRISM.Interactions.OverlayViewWithCloseButton, PRISM.Adapters.ISCharaFullImageOverlayView, PRISM.Adapters.IClosableOverlayView<UniRx.Unit>, PRISM.Adapters.IOverlayView, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private UnityEngine.UI.RawImage imgSCharaFull;
    public void Assign(int mstSupportCharacterId, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Interactions
public class PieceArchiveBottomView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView conversionButton;
    private PRISM.Interactions.ToggleButtonView checkButton;
    private ENTERPRISE.UI.UITextMeshProUGUI selectedCountText;
    private int selectedLimitCount;
    private System.IObservable<bool> <OnCheck>k__BackingField;
    public System.IObservable<bool> OnCheck { get; set; }
    public System.IObservable<UniRx.Unit> OnConversion { get; set; }
    public void Setup(bool isSurplus, int limitCount);
    public void CanConversion(bool isEnable);
    public void SetSelectedCount(int num);
}

// Namespace: PRISM.Interactions
public class PieceArchiveView : UnityEngine.MonoBehaviour, PRISM.Adapters.IPieceArchiveView
{
    private ENTERPRISE.UI.UITextMeshProUGUI txtPieceConversionItem;
    private PRISM.Interactions.ButtonView goToExchangeButton;
    private PRISM.Interactions.EnhancedPieceSelectGridView gridView;
    private PRISM.Interactions.PieceArchiveBottomView pieceArchiveBottomView;
    private UniRx.Subject<UniRx.Unit> toExchange;
    private UniRx.Subject<UniRx.Unit> onConversion;
    private PRISM.Adapters.PieceArchiveViewModel vm;
    private System.IObservable<bool> <OnCheck>k__BackingField;
    public System.IObservable<int> OnClick { get; set; }
    public System.IObservable<int> OnLongPressed { get; set; }
    public System.IObservable<UniRx.Unit> ToExchange { get; set; }
    public System.IObservable<bool> OnCheck { get; set; }
    public System.IObservable<UniRx.Unit> OnConversion { get; set; }
    public void Setup(PRISM.Adapters.PieceArchiveViewModel _vm, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private void OnDestroy();
    private void <Setup>b__19_0(System.Collections.Generic.IReadOnlyList<PRISM.Common.Model.PieceIcon> listData);
    private void <Setup>b__19_1(int num);
    private void <Setup>b__19_2(UniRx.Unit _);
    private void <Setup>b__19_3(System.ValueTuple<long, bool> t);
}

// Namespace: PRISM.Interactions
public class PieceSelectGridViewContext : PRISM.ClickObservableContext<int>
{
    private bool <IsSurplus>k__BackingField;
    private bool <PieceConversion>k__BackingField;
    public bool IsSurplus { get; set; }
    public bool PieceConversion { get; set; }
}

// Namespace: PRISM.Interactions
public class PieceGaugeView : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.Image imgFillColor;
    private ENTERPRISE.UI.UITextMeshProUGUI txtPieceCount;
    private ENTERPRISE.UI.UITextMeshProUGUI txtRequiredPieceCount;
    public void SetCount(long have, int required);
}

// Namespace: PRISM.Interactions
public class AlbumPopupContentView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.EnhancedCharacterSelectGridView gridView;
    private ENTERPRISE.UI.UITextMeshProUGUI possessionText;
    private PRISM.Interactions.ButtonView possessionOnlyToggleButton;
    private PRISM.Interactions.ViewStateChanger possessionOnlyStateChanger;
    private System.IObservable<int> <OnSelected>k__BackingField;
    public System.IObservable<int> OnSelected { get; set; }
    public void Initialize(PRISM.Adapters.AlbumContentViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);

    private class <>c__DisplayClass8_0
    {
        public PRISM.Adapters.AlbumContentViewModel viewModel;
        public PRISM.Interactions.AlbumPopupContentView <>4__this;
        private int <Initialize>b__0(int index);
        private void <Initialize>b__1(UniRx.Unit _);
        private void <Initialize>b__2(bool isPossessionOnly);
    }
}

// Namespace: PRISM.Interactions
public class AlbumPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IAlbumPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.ToggleGroupView tabGroup;
    private PRISM.Interactions.AlbumPopupContentView produceIdolView;
    private PRISM.Interactions.AlbumPopupContentView supportCharacterView;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClick;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public System.IObservable<int> OnPIdolSelected { get; set; }
    public System.IObservable<int> OnSCharaSelected { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Initialize(PRISM.Adapters.AlbumViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__11_0();
    private void <CreateFrameParameter>b__11_1();
}

// Namespace: PRISM.Interactions
public class CostumePartListContentRow : EnhancedUI.EnhancedScroller.EnhancedScrollerCellView
{
    private PRISM.Interactions.LockableCostumeIconView[] icons;
    private PRISM.AutoCancellationTokenSource canceller;
    public int Length { get; set; }
    public void SetUp(PRISM.ResourceManagement.IResourceLoader resourceLoader, System.ReadOnlySpan<PRISM.Adapters.CostumePopupCostumePartViewModel> viewModels);
    private void OnDestroy();
}

// Namespace: PRISM.Interactions
public class CostumePartListHeaderRow : EnhancedUI.EnhancedScroller.EnhancedScrollerCellView
{
    private PRISM.Interactions.ViewStateChanger partTypeStateChanger;
    public void SetUp(PRISM.Definitions.CostumePartType partType);
}

// Namespace: PRISM.Interactions
public class CostumePartListView : UnityEngine.MonoBehaviour, EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate
{
    private EnhancedUI.EnhancedScroller.EnhancedScroller scroller;
    private PRISM.Interactions.CostumePartListHeaderRow headerPrefab;
    private PRISM.Interactions.CostumePartListContentRow contentPrefab;
    private UnityEngine.GameObject emptyView;
    private System.Collections.Generic.IReadOnlyList<System.ValueTuple<PRISM.Definitions.CostumePartType, PRISM.Adapters.CostumePopupCostumePartViewModel[]>> itemList;
    public void Initialize(PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void UpdateContents(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.CostumePopupCostumePartViewModel> viewModels);
    private System.ValueTuple<int, int> _getIndex(int index);
    private int EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate.GetNumberOfCells(EnhancedUI.EnhancedScroller.EnhancedScroller scroller);
    private float EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate.GetCellViewSize(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex);
    private EnhancedUI.EnhancedScroller.EnhancedScrollerCellView EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate.GetCellView(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex, int cellIndex);
    private EnhancedUI.EnhancedScroller.EnhancedScrollerCellView _getCell(int index);
    private int <EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate.GetNumberOfCells>b__8_0(System.ValueTuple<PRISM.Definitions.CostumePartType, PRISM.Adapters.CostumePopupCostumePartViewModel[]> x);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Adapters.CostumePopupCostumePartViewModel, PRISM.Definitions.CostumePartType> <>9__6_0;
        public static System.Func<System.Linq.IGrouping<PRISM.Definitions.CostumePartType, PRISM.Adapters.CostumePopupCostumePartViewModel>, PRISM.Definitions.CostumePartType> <>9__6_1;
        public static System.Func<System.Linq.IGrouping<PRISM.Definitions.CostumePartType, PRISM.Adapters.CostumePopupCostumePartViewModel>, System.ValueTuple<PRISM.Definitions.CostumePartType, PRISM.Adapters.CostumePopupCostumePartViewModel[]>> <>9__6_2;
        private PRISM.Definitions.CostumePartType <UpdateContents>b__6_0(PRISM.Adapters.CostumePopupCostumePartViewModel x);
        private PRISM.Definitions.CostumePartType <UpdateContents>b__6_1(System.Linq.IGrouping<PRISM.Definitions.CostumePartType, PRISM.Adapters.CostumePopupCostumePartViewModel> x);
        private System.ValueTuple<PRISM.Definitions.CostumePartType, PRISM.Adapters.CostumePopupCostumePartViewModel[]> <UpdateContents>b__6_2(System.Linq.IGrouping<PRISM.Definitions.CostumePartType, PRISM.Adapters.CostumePopupCostumePartViewModel> x);
    }

    private class <>c__DisplayClass5_0
    {
        public PRISM.Interactions.CostumePartListView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private void <Initialize>b__0(EnhancedUI.EnhancedScroller.EnhancedScrollerCellView row);
    }
}

// Namespace: PRISM.Interactions
public class CostumePopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.ICostumePopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.ToggleGroupView costumeTypeToggleGroup;
    private PRISM.Interactions.ToggleGroupView costumeCategoryToggleGroup;
    private PRISM.Interactions.CostumeSetSelectGridView setGridView;
    private PRISM.Interactions.CostumePartListView partListView;
    private ENTERPRISE.UI.UITextMeshProUGUI possessionText;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClick;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Initialize(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Adapters.CostumePopupViewModel viewModel);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <Initialize>b__8_0(PRISM.Adapters.CostumePopupSelectedViewModel x);
    private void <CreateFrameParameter>b__9_0();
    private void <CreateFrameParameter>b__9_1();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Adapters.CostumePopupCostumeSetViewModel, bool> <>9__8_1;
        public static System.Func<PRISM.Adapters.CostumePopupCostumePartViewModel, bool> <>9__8_2;
        private bool <Initialize>b__8_1(PRISM.Adapters.CostumePopupCostumeSetViewModel y);
        private bool <Initialize>b__8_2(PRISM.Adapters.CostumePopupCostumePartViewModel y);
    }
}

// Namespace: PRISM.Interactions
public class CostumeSetSelectGridView : PRISM.Interactions.GridView<PRISM.Interactions.CostumeSetSelectGridViewCell, PRISM.Adapters.CostumePopupCostumeSetViewModel>
{
    protected void SetupCellTemplate();

    private class CellGroup : DefaultCellGroup<PRISM.Adapters.CostumePopupCostumeSetViewModel, PRISM.Interactions.GridViewContext>
    {
    }
}

// Namespace: PRISM.Interactions
public class CostumeSetSelectGridViewCell : PRISM.Interactions.GridViewCell<PRISM.Adapters.CostumePopupCostumeSetViewModel>
{
    private PRISM.Interactions.HorizontalAutoScrollingText nameText;
    private PRISM.Interactions.CostumeSetIconView iconView;
    private PRISM.Interactions.ViewStateChanger isUnlockedStateChanger;
    private PRISM.AutoCancellationTokenSource canceller;
    public void UpdateContent(PRISM.Adapters.CostumePopupCostumeSetViewModel itemData);
    private void OnDestroy();
}

// Namespace: PRISM.Interactions
public class CostumeAcquisitionPopupCostumeIconView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.CostumeIconView iconView;
    private UnityEngine.GameObject unlockedLabel;
    public void SetUp(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Domain.ProductKey productKey, bool isUnlocked);
}

// Namespace: PRISM.Interactions
public class CostumeAcquisitionPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.ICostumeAcquisitionPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.HorizontalAutoScrollingText costumeSetNameText;
    private PRISM.Interactions.CostumeAcquisitionPopupCostumeIconView iconBase;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClick;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Assign(PRISM.Adapters.CostumeAcquisitionPopupViewModel vm, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__6_0();
    private void <CreateFrameParameter>b__6_1();
}

// Namespace: PRISM.Interactions
public class CostumeDetailPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.ICostumeDetailPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private UnityEngine.UI.RawImage costumeIcon;
    private PRISM.Interactions.HorizontalAutoScrollingText costumeName;
    private ENTERPRISE.UI.UITextMeshProUGUI costumeDescription;
    private ENTERPRISE.UI.UITextMeshProUGUI costumeUnlockCondition;
    private UnityEngine.RectTransform tagParent;
    private UnityEngine.GameObject stageCostumeTag;
    private UnityEngine.GameObject casualCostumeTag;
    private ENTERPRISE.UI.UITextMeshProUGUI characterExclusiveTagText;
    private PRISM.Interactions.ViewStateChanger dressOrderTargetIconChanger;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClick;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Assign(PRISM.Adapters.CostumeDetailPopupViewModel vm, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__13_0();
    private void <CreateFrameParameter>b__13_1();
}

// Namespace: PRISM.Interactions
public class CostumeTryPopupCellView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ProduceIdolIconView produceIdolIconView;
    private PRISM.Interactions.StarsStateView starsStateView;
    private PRISM.Interactions.ButtonView produceIdolButton;
    private PRISM.Interactions.CharacterBaseIconView characterBaseIconView;
    private PRISM.Interactions.HorizontalAutoScrollingText nameText;
    private PRISM.Interactions.CostumeSetIconView costumeSetIconView;
    private PRISM.Interactions.ViewStateChanger dressOrderTargetIconChanger;
    private PRISM.Interactions.ButtonView tryButton;
    public System.IObservable<UniRx.Unit> OnTry { get; set; }
    public void Initialize(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Adapters.CostumeTryViewModel viewModel);

    private class <>c__DisplayClass10_0
    {
        public PRISM.Adapters.CostumeTryViewModel viewModel;
        public System.Threading.CancellationToken ct;
        private void <Initialize>b__0(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions
public class CostumeTryPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.ICostumeTryPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.CostumeTryPopupCellView cellBase;
    private UnityEngine.Transform costumeParent;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private System.IObservable<int> <OnTry>k__BackingField;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public System.IObservable<int> OnTry { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Initialize(PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Collections.Generic.IEnumerable<PRISM.Adapters.CostumeTryViewModel> viewModels);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__10_0();
    private void <CreateFrameParameter>b__10_1();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Interactions.CostumeTryPopupCellView, int, System.IObservable<int>> <>9__9_1;
        private System.IObservable<int> <Initialize>b__9_1(PRISM.Interactions.CostumeTryPopupCellView cell, int index);
    }

    private class <>c__DisplayClass9_0
    {
        public PRISM.Interactions.CostumeTryPopupView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private PRISM.Interactions.CostumeTryPopupCellView <Initialize>b__0(PRISM.Adapters.CostumeTryViewModel viewModel);
    }

    private class <>c__DisplayClass9_1
    {
        public int index;
        private int <Initialize>b__2(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions
public class EditUnitNamePopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IEditUnitNamePopupView, PRISM.Adapters.IClosablePopupFrame<string>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<string>
{
    private ENTERPRISE.UI.UITextMeshProUGUI txtComment;
    private PRISM.CommonInputFieldTMP tmpInputField;
    private ENTERPRISE.UI.UITextMeshProUGUI txtCharacterCount;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<string> onClick;
    private string currentName;
    private string characterLimit;
    private bool forProduce;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<string> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Assign(PRISM.Adapters.EditUnitNamePopupViewModel vm);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__10_0();
    private void <CreateFrameParameter>b__10_1();
    private void <CreateFrameParameter>b__10_2();

    private class <>c__DisplayClass9_0
    {
        public PRISM.Adapters.EditUnitNamePopupViewModel vm;
        public PRISM.Interactions.EditUnitNamePopupView <>4__this;
        private void <Assign>b__0(string input);
        private void <Assign>b__1(string input);
        private void <Assign>g__setCharacterCount|2(int current, bool isLimitOver);
        private void <Assign>g__setPopupButtonEnable|3(bool isLimitOver, string unitName);
    }
}

// Namespace: PRISM.Interactions
public class EtceteraCellListContext : System.IDisposable
{
    private UniRx.Subject<string> onSelect;
    private PRISM.ResourceManagement.IResourceLoader <ResourceLoader>k__BackingField;
    public PRISM.ResourceManagement.IResourceLoader ResourceLoader { get; set; }
    public System.IObservable<string> OnSelect { get; set; }
    public void Select(string resourceId);
    public void Dispose();
}

// Namespace: PRISM.Interactions
public class EtceteraCellListView : UnityEngine.MonoBehaviour, EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate, System.IDisposable
{
    private EnhancedUI.EnhancedScroller.EnhancedScroller scroller;
    private PRISM.Interactions.EtcetetaTitleCellView titleCellPrefab;
    private PRISM.Interactions.EtcetetaRowCellView rowCellPrefab;
    private System.Collections.Generic.IReadOnlyList<PRISM.Adapters.EtceteraListCellViewModel> viewModels;
    private PRISM.Interactions.EtceteraCellListContext context;
    private UniRx.Subject<string> onSelect;
    public System.IObservable<string> OnSelect { get; set; }
    public void Setup(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.EtceteraListCellViewModel> viewModels, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private void _activateCell(EnhancedUI.EnhancedScroller.EnhancedScrollerCellView cellView);
    private void _deactivateCell(EnhancedUI.EnhancedScroller.EnhancedScrollerCellView cellView);
    private int EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate.GetNumberOfCells(EnhancedUI.EnhancedScroller.EnhancedScroller scroller);
    private float EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate.GetCellViewSize(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex);
    private EnhancedUI.EnhancedScroller.EnhancedScrollerCellView EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate.GetCellView(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex, int cellIndex);
    private EnhancedUI.EnhancedScroller.EnhancedScrollerCellView _selectCellView(int dataIndex);
    public void Dispose();
    private void <Setup>b__8_0(string id);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<EnhancedUI.EnhancedScroller.EnhancedScrollerCellView, bool> <>9__8_1;
        private bool <Setup>b__8_1(EnhancedUI.EnhancedScroller.EnhancedScrollerCellView cellView);
    }
}

// Namespace: PRISM.Interactions
public class EtceteraImage : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.RawImage rawImage;
    private UnityEngine.UI.AspectRatioFitter aspectRatioFitter;
    private ENTERPRISE.UI.UIButton btn;
    private UnityEngine.UI.AspectRatioFitter attachedAspectRatioFitter;
    public Cysharp.Threading.Tasks.UniTask SetupAsync(string resourceId, PRISM.Interactions.EtceteraCellListContext context);
    public void Inactive();
    public void Cleanup();

    private class <>c__DisplayClass4_0
    {
        public PRISM.Interactions.EtceteraCellListContext context;
        public string resourceId;
        private void <SetupAsync>b__0();
    }

    private struct <SetupAsync>d__4 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.EtceteraCellListContext context;
        public string resourceId;
        public PRISM.Interactions.EtceteraImage <>4__this;
        private <>c__DisplayClass4_0 <>8__1;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class EtceteraPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IEtceteraPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.EtceteraCellListView listView;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Assign(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.EtceteraListCellViewModel> cellDataList, System.Action<string> onSelectAction, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__5_0();
    private void <CreateFrameParameter>b__5_1();

    private class <>c__DisplayClass4_0
    {
        public System.Action<string> onSelectAction;
        private void <Assign>b__0(string id);
    }
}

// Namespace: PRISM.Interactions
public class EtcetetaRowCellView : EnhancedUI.EnhancedScroller.EnhancedScrollerCellView
{
    private PRISM.Interactions.EtceteraImage[] images;
    private float height;
    public float Height { get; set; }
    public void Setup(System.Collections.Generic.IReadOnlyList<string> resourceIdList, PRISM.Interactions.EtceteraCellListContext context);
    public void Cleanup();
}

// Namespace: PRISM.Interactions
public class EtcetetaTitleCellView : EnhancedUI.EnhancedScroller.EnhancedScrollerCellView
{
    private ENTERPRISE.UI.UITextMeshProUGUI title;
    private float height;
    public float Height { get; set; }
    public void Setup(string categoryName);
}

// Namespace: PRISM.Interactions
public class FesDataTransferCompletedPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IFesDataTransferCompletedPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private ENTERPRISE.UI.UITextMeshProUGUI txt;
    private UnityEngine.Transform rewardParent;
    private PRISM.Interactions.RewardItemIcon itemIconPrefab;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClick;
    private string title;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Assign(PRISM.Adapters.FesDataTransferCompletedPopupViewModel vm, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__8_0();
    private void <CreateFrameParameter>b__8_1();
}

// Namespace: PRISM.Interactions
public class FesUnitTransferConfirmedPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IFesUnitTransferConfirmedPopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private PRISM.Interactions.EnhancedUnitSelectGridView gridView;
    private ENTERPRISE.UI.UITextMeshProUGUI[] amounts;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClick;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Assign(PRISM.Adapters.FesUnitTransferConfirmedPopupViewModel vm, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private void _updateContents(PRISM.Common.Model.FUnitIcon[] selectedIcons);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__7_0();
    private void <CreateFrameParameter>b__7_1();
    private void <CreateFrameParameter>b__7_2();
}

// Namespace: PRISM.Interactions
public class FUnitDetailDeckView : UnityEngine.MonoBehaviour
{
    private PRISM.Produce.ProduceCardContent goPCardPrefab;
    private UnityEngine.Transform trCardParent;
    private ENTERPRISE.UI.UITextMeshProUGUI cardCountText;
    private UniRx.Subject<System.Collections.Generic.List<int>> onEfficacyDetail;
    public System.IObservable<System.Collections.Generic.List<int>> OnEfficacyDetail { get; set; }
    private void Awake();
    public void Setup(PRISM.Module.Networking.IProduceCardStatus[] cards, PRISM.ResourceManagement.IResourceLoader resourceLoader);

    private class <>c__DisplayClass7_0
    {
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public PRISM.Interactions.FUnitDetailDeckView <>4__this;
    }

    private class <>c__DisplayClass7_1
    {
        public PRISM.Module.Networking.IProduceCardStatus card;
        public PRISM.Produce.ProduceCardContent cContent;
        public <>c__DisplayClass7_0 CS$<>8__locals1;
        private Cysharp.Threading.Tasks.UniTask <Setup>b__0();

        private struct <<Setup>b__0>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
        {
            public int <>1__state;
            public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
            public <>c__DisplayClass7_1 <>4__this;
            private Awaiter <>u__1;
            private void MoveNext();
            private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }
}

// Namespace: PRISM.Interactions
public class FUnitDetailFUnitInfoView : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.RawImage imgUnitIcon;
    private PRISM.UI.FUnitIconView fUnitIconView;
    private ENTERPRISE.UI.UITextMeshProUGUI txtUnitName;
    private UnityEngine.UI.RawImage imgTotalRank;
    private PRISM.Legacy.ParamRememberableAnimator rankEffectAnimator;
    private ENTERPRISE.UI.UITextMeshProUGUI txtTotal;
    private ENTERPRISE.UI.UITextMeshProUGUI txtTotalBaseBonus;
    private PRISM.Interactions.VoDaViMeRankView voDaViMeRankView;
    private ENTERPRISE.UI.UITextMeshProUGUI txtVoBaseBonus;
    private ENTERPRISE.UI.UITextMeshProUGUI txtDaBaseBonus;
    private ENTERPRISE.UI.UITextMeshProUGUI txtViBaseBonus;
    private ENTERPRISE.UI.UITextMeshProUGUI txtMeBaseBonus;
    private PRISM.Interactions.ViewStateChanger showBonusStateChanger;
    private PRISM.Interactions.ButtonView editUnitNameButton;
    private UnityEngine.UI.RawImage imgFavoriteMark;
    private PRISM.Interactions.ButtonView favoriteMarkButton;
    private PRISM.Interactions.ButtonView parameterDetailButton;
    private PRISM.Interactions.ViewStateChanger forReferenceStateChanger;
    private System.Threading.CancellationToken ct;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    public System.IObservable<UniRx.Unit> OnEditName { get; set; }
    public System.IObservable<UniRx.Unit> OnChangeFavoriteMark { get; set; }
    public System.IObservable<UniRx.Unit> OnParameterDetail { get; set; }
    private void Awake();
    public void SetupForFUnitDetail(int mstUnitId, string name, System.Collections.Generic.List<int> sortedPIdolList, int inheritanceCount, ProduceParameterRank rank, PRISM.Module.Networking.IProduceParameterStatus unitParameter, int mstFavoriteMarkId, bool forReference, PRISM.Module.Networking.IIdolParameterStatus baseBonusParameter, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void SetupForProduceResult(int mstUnitId, string name, System.Collections.Generic.List<int> sortedPIdolList, int inheritanceCount, ProduceParameterRank rank, PRISM.Module.Networking.IProduceParameterStatus unitParameter, int mstFavoriteMarkId, bool forReference, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void SetUnitName(string unitName);
    public void SetFavoriteMark(int favoriteMarkId);
    private void _setup(int mstUnitId, string name, ProduceParameterRank rank, PRISM.Module.Networking.IProduceParameterStatus unitParameter, int mstFavoriteMarkId, bool forReference, PRISM.Module.Networking.IIdolParameterStatus baseBonusParameter);
    private void _setBonusText(ENTERPRISE.UI.UITextMeshProUGUI text, int value);
    private void _setRankEffect(ProduceParameterRank rank);
}

// Namespace: PRISM.Interactions
public class FUnitDetailIdolView : UnityEngine.MonoBehaviour
{
    private System.Collections.Generic.List<PRISM.Interactions.UnitMemberView> goMemberList;
    private System.Collections.Generic.List<UnityEngine.GameObject> goSeparatorList;
    public void Setup(PRISM.Adapters.UnitMemberViewModel[] unitMembers, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Interactions
public class FUnitDetailPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IFUnitDetailPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.ToggleGroupView toggleGroup;
    private PRISM.Interactions.FUnitDetailFUnitInfoView fUnitInfoView;
    private PRISM.Interactions.FUnitDetailIdolView idolView;
    private PRISM.Interactions.FUnitDetailSupportView supportView;
    private PRISM.Interactions.FUnitDetailDeckView deckView;
    private PRISM.Interactions.FUnitDetailProduceInfoView produceInfoView;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClick;
    private System.IDisposable detectTouchDisposable;
    private PRISM.Interactions.PopupFrameParameter frameParameter;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public System.IObservable<UniRx.Unit> OnFavorite { get; set; }
    public System.IObservable<UniRx.Unit> OnEditName { get; set; }
    public System.IObservable<System.Collections.Generic.List<int>> OnEfficacyDetail { get; set; }
    public System.IObservable<UniRx.Unit> OnParameterDetail { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void SetupFrameParameter(PRISM.Definitions.LocalizationKey buttonTextKey, PopupButtonType buttonType);
    public void Assign(PRISM.Adapters.FUnitDetailPopupViewModel vm, int initialTabIndex, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void SetFavoriteMark(int mstFavoriteMarkId);
    public void SetUnitName(string name);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void _assign(PRISM.Adapters.FUnitDetailPopupViewModel vm, int initialTabIndex, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private void <SetupFrameParameter>b__19_0();
    private void <SetupFrameParameter>b__19_1();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Adapters.UnitMemberViewModel, bool> <>9__32_0;
        public static System.Func<PRISM.Adapters.UnitMemberViewModel, int> <>9__32_1;
        public static System.Func<PRISM.Adapters.UnitMemberViewModel, int> <>9__32_2;
        public static System.Func<PRISM.Adapters.UnitMemberViewModel, int> <>9__32_3;
        public static System.Func<PRISM.Adapters.UnitMemberViewModel, int> <>9__32_4;
        private bool <_assign>b__32_0(PRISM.Adapters.UnitMemberViewModel x);
        private int <_assign>b__32_1(PRISM.Adapters.UnitMemberViewModel x);
        private int <_assign>b__32_2(PRISM.Adapters.UnitMemberViewModel x);
        private int <_assign>b__32_3(PRISM.Adapters.UnitMemberViewModel x);
        private int <_assign>b__32_4(PRISM.Adapters.UnitMemberViewModel x);
    }
}

// Namespace: PRISM.Interactions
public class FUnitDetailProduceInfoView : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI txtEpisodeTitle;
    private ENTERPRISE.UI.UITextMeshProUGUI txtCreateDate;
    private ENTERPRISE.UI.UITextMeshProUGUI txtSkip;
    private PRISM.Interactions.ProduceStrategyContentView[] strategies;
    public void Setup(int mstEpisodeId, int difficultyLevel, System.DateTime createDate, bool isAuto, System.ValueTuple<int, int>[] strategyList, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Interactions
public class FUnitDetailSupportView : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI txtSlotCount;
    private PRISM.UI.SCharaIconRectView[] sCharaIconRectViews;
    private PRISM.UI.SCharaIconRectView sCharaIconRectViewOfFriendSetting;
    private PRISM.Interactions.SupportSkillContentView goSSkillContentPrefab;
    private UnityEngine.Transform trSSkillParent;
    public void Setup(PRISM.Adapters.UnitSupportCharacterViewModel[] mySupportSetting, PRISM.Adapters.UnitSupportCharacterViewModel friendSupportSetting, System.Collections.Generic.List<System.ValueTuple<int, bool>> attachedSupportSkills, PRISM.ResourceManagement.IResourceLoader resourceLoader);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Adapters.UnitSupportCharacterViewModel, int> <>9__5_0;
        private int <Setup>b__5_0(PRISM.Adapters.UnitSupportCharacterViewModel x);
    }
}

// Namespace: PRISM.Interactions
public class ProduceResultFUnitDetailIdolView : UnityEngine.MonoBehaviour
{
    private System.Collections.Generic.List<PRISM.Interactions.ProduceResultUnitMemberView> goMemberList;
    private System.Collections.Generic.List<UnityEngine.GameObject> goSeparatorList;
    public void Setup(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.ProduceResultUnitMemberViewModel> unitMembers, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken cancellationToken);
}

// Namespace: PRISM.Interactions
public class ProduceResultFUnitDetailPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IProduceResultFUnitDetailPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.ToggleGroupView toggleGroup;
    private PRISM.Interactions.FUnitDetailFUnitInfoView fUnitInfoView;
    private PRISM.Interactions.ProduceResultFUnitDetailIdolView idolView;
    private PRISM.Interactions.FUnitDetailSupportView supportView;
    private PRISM.Interactions.FUnitDetailDeckView deckView;
    private PRISM.Interactions.FUnitDetailProduceInfoView produceInfoView;
    private PRISM.Interactions.ScreenTapSkipAnimationPlayer animationPlayer;
    private float modalDisplayTime;
    private PRISM.Interactions.ButtonView produceLogButton;
    private PRISM.Interactions.ButtonView nextButton;
    private PRISM.Interactions.ButtonView transferButton;
    private UnityEngine.GameObject transferButtonCoverObject;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public System.IObservable<UniRx.Unit> OnFavorite { get; set; }
    public System.IObservable<UniRx.Unit> OnEditName { get; set; }
    public System.IObservable<UniRx.Unit> OnClickProduceLogButton { get; set; }
    public System.Threading.CancellationToken CancellationTokenOnTerminate { get; set; }
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Adapters.ProduceResultFUnitDetailPopupViewModel viewModel, PRISM.Adapters.LogIndexViewModel logModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Func<Cysharp.Threading.Tasks.UniTask> onPreCloseByTransferButtonFunc, System.Threading.CancellationToken cancellationToken);
    public void SetFavoriteMark(int mstFavoriteMarkId);
    public void SetProduceLogButtonEnable(bool isEnable);
    public void SetTransferButtonEnabled(bool isEnable);
    public void SetTransferButtonGrayOut(bool isEnable);
    public void SetUnitName(string name);
    public Cysharp.Threading.Tasks.UniTask ShowNGPUAsync(System.Threading.CancellationToken cancellationToken);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);

    private class <>c__DisplayClass24_0
    {
        public PRISM.Interactions.ProduceResultFUnitDetailPopupView <>4__this;
        public System.Func<Cysharp.Threading.Tasks.UniTask> onPreCloseByTransferButtonFunc;
        private void <SetupAsync>b__0(UniRx.Unit _);
        private Cysharp.Threading.Tasks.UniTaskVoid <SetupAsync>b__1(UniRx.Unit _);

        private struct <<SetupAsync>b__1>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
        {
            public int <>1__state;
            public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
            public <>c__DisplayClass24_0 <>4__this;
            private Awaiter <>u__1;
            private void MoveNext();
            private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }

    private struct <ShowAsync>d__32 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.ProduceResultFUnitDetailPopupView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class ProduceResultUnitMemberView : UnityEngine.MonoBehaviour
{
    private PRISM.UI.PFIdolIconView iconView;
    private PRISM.UI.IdolSkillIconView idolSkillIcon;
    private PRISM.Interactions.VoDaViMeRankView voDaViMeRankView;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Adapters.ProduceResultUnitMemberViewModel unitMember, PRISM.ResourceManagement.IResourceLoader resourceLoader);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<int, ProduceParameterType> <>9__4_0;
        private ProduceParameterType <SetupAsync>b__4_0(int x);
    }
}

// Namespace: PRISM.Interactions
public class SupportSkillContentView : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.RawImage imgSkillIcon;
    private UnityEngine.GameObject goInheritanceIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI txtSkillName;
    private ENTERPRISE.UI.UITextMeshProUGUI txtSKillDetail;
    public void Setup(int mstSupportSkillId, bool isInheritance, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Interactions
public class UnitMemberView : UnityEngine.MonoBehaviour
{
    private PRISM.UI.PFIdolIconView iconView;
    private PRISM.UI.IdolSkillIconView idolSkillIcon;
    private PRISM.Interactions.VoDaViMeRankView voDaViMeRankView;
    public void Setup(PRISM.Adapters.UnitMemberViewModel unitMember, PRISM.ResourceManagement.IResourceLoader resourceLoader);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<int, ProduceParameterType> <>9__3_0;
        private ProduceParameterType <Setup>b__3_0(int x);
    }
}

// Namespace: PRISM.Interactions
public class HowToGetItemsPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IHowToGetItemsPopupView, PRISM.Adapters.IClosablePopupFrame<System.ValueTuple<ButtonGoToType, string>>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<System.ValueTuple<ButtonGoToType, string>>
{
    private PRISM.Interactions.PlaceToGetCellListView placeToGetCellListView;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<System.ValueTuple<ButtonGoToType, string>> onClick;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<System.ValueTuple<ButtonGoToType, string>> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Assign(System.Collections.Generic.List<PRISM.Adapters.HowToGetItemsIconViewModel> vmList, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <Assign>b__4_0(System.ValueTuple<ButtonGoToType, string> t);
    private void <CreateFrameParameter>b__5_0();
    private void <CreateFrameParameter>b__5_1();
}

// Namespace: PRISM.Interactions
public class PlaceColumnView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView button;
    private ENTERPRISE.UI.UITextMeshProUGUI txtViewName;
    private ENTERPRISE.UI.UITextMeshProUGUI txtPlaceName;
    private PRISM.AutoCancellationTokenSource cts;
    public void Setup(int itemProviderId, ButtonGoToType buttonGoToType, string parameter, PRISM.Interactions.PlaceToGetCellListContext context);
    private void OnDestroy();

    private class <>c__DisplayClass4_0
    {
        public PRISM.Interactions.PlaceToGetCellListContext context;
        public ButtonGoToType buttonGoToType;
        public string parameter;
        private void <Setup>b__0(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions
public class PlaceToGetCellListContext : System.IDisposable
{
    private UniRx.Subject<System.ValueTuple<ButtonGoToType, string>> onSelectPlace;
    private PRISM.ResourceManagement.IResourceLoader <ResourceLoader>k__BackingField;
    public System.IObservable<System.ValueTuple<ButtonGoToType, string>> OnSelectPlace { get; set; }
    public PRISM.ResourceManagement.IResourceLoader ResourceLoader { get; set; }
    public void SelectPlace(ButtonGoToType goToType, string parameter);
    public void Dispose();
}

// Namespace: PRISM.Interactions
public class PlaceToGetCellView : EnhancedUI.EnhancedScroller.EnhancedScrollerCellView
{
    private UnityEngine.RectTransform rectTransform;
    private PRISM.Interactions.RequiredCurrentItemIconView itemIconView;
    private float itemSectionHeight;
    private ENTERPRISE.UI.UITextMeshProUGUI txtItemName;
    private float placeSectionTopPadding;
    private float placeSectionBottomPadding;
    private float placeListAreaTopPadding;
    private float placeListAreaBottomPadding;
    private UnityEngine.Transform placeListParent;
    private PRISM.Interactions.PlaceColumnView placeColumnPrefab;
    private float columnHeight;
    private float spaceBetweenColumn;
    private System.Collections.Generic.List<PRISM.Interactions.PlaceColumnView> activeColumns;
    private float cellHeight;
    private UnityEngine.Pool.ObjectPool<PRISM.Interactions.PlaceColumnView> columnPool;
    public void Reset();
    private void OnDestroy();
    public float GetCellHeight(int columnNum);
    public void Setup(PRISM.Adapters.HowToGetItemsIconViewModel vm, PRISM.Interactions.PlaceToGetCellListContext context);
    private UnityEngine.Pool.ObjectPool<PRISM.Interactions.PlaceColumnView> _createItemColumnPool(PRISM.Interactions.PlaceColumnView prefab);

    private class <>c
    {
        public static <>c <>9;
        public static System.Action<PRISM.Interactions.PlaceColumnView> <>9__19_2;
        public static System.Action<PRISM.Interactions.PlaceColumnView> <>9__19_3;
        private void <_createItemColumnPool>b__19_2(PRISM.Interactions.PlaceColumnView target);
        private void <_createItemColumnPool>b__19_3(PRISM.Interactions.PlaceColumnView target);
    }

    private class <>c__DisplayClass19_0
    {
        public PRISM.Interactions.PlaceColumnView prefab;
        public PRISM.Interactions.PlaceToGetCellView <>4__this;
        private PRISM.Interactions.PlaceColumnView <_createItemColumnPool>b__0();
        private void <_createItemColumnPool>b__1(PRISM.Interactions.PlaceColumnView target);
    }
}

// Namespace: PRISM.Interactions
public class IdolBaseDetailRewardListPopupView : UnityEngine.MonoBehaviour, PRISM.Adapters.IIdolBaseDetailRewardListPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>, PRISM.Interactions.IPopupContent
{
    private PRISM.Interactions.VariableCellListView listView;
    private PRISM.Adapters.IdolBaseDetailRewardListViewModel viewModel;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClose;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Assign(PRISM.Adapters.IdolBaseDetailRewardListViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__6_0();
    private void <CreateFrameParameter>b__6_1();
}

// Namespace: PRISM.Interactions
public class IdolSkillContentView : UnityEngine.MonoBehaviour
{
    private PRISM.UI.IdolSkillIconView iconView;
    private ENTERPRISE.UI.UITextMeshProUGUI txtSkillName;
    private PRISM.VoDaViMeMultiView voDaViMeMultiView;
    private ENTERPRISE.UI.UIButton btn;
    private UnityEngine.CanvasGroup cgLock;
    private ENTERPRISE.UI.UITextMeshProUGUI txtLock;
    private UniRx.Subject<int> onTap;
    private UniRx.Subject<int> onLongTap;
    public System.IObservable<int> OnTap { get; set; }
    public System.IObservable<int> OnLongTap { get; set; }
    private void Awake();
    public void Setup(PRISM.Adapters.IdolSkillContentViewModel vm, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private void _setVoDaViMe(System.Collections.Generic.IReadOnlyList<ProduceParameterType> appealTypeList);
    public void SetupWithLock(PRISM.Adapters.IdolSkillContentViewModel vm, PRISM.ResourceManagement.IResourceLoader resourceLoader);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Adapters.IdolSkillLevelViewModel, System.ValueTuple<int, int, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IIdolSkillActionEffectStatus>, PRISM.Module.Networking.IIdolSkillActionConditionStatus>> <>9__15_0;
        private System.ValueTuple<int, int, System.Collections.Generic.IReadOnlyList<PRISM.Module.Networking.IIdolSkillActionEffectStatus>, PRISM.Module.Networking.IIdolSkillActionConditionStatus> <SetupWithLock>b__15_0(PRISM.Adapters.IdolSkillLevelViewModel x);
    }

    private class <>c__DisplayClass13_0
    {
        public PRISM.Interactions.IdolSkillContentView <>4__this;
        public PRISM.Adapters.IdolSkillContentViewModel vm;
        private void <Setup>b__0();
        private void <Setup>b__1();
    }
}

// Namespace: PRISM.Interactions
public class IdolSkillLvContentView : UnityEngine.MonoBehaviour
{
    private PRISM.UI.IdolSkillIconView skillIconView;
    private PRISM.VoDaViMeMultiView voDaViMeMultiView;
    private ENTERPRISE.UI.UITextMeshProUGUI skillNameText;
    private PRISM.Interactions.ButtonView button;
    private ENTERPRISE.UI.UITextMeshProUGUI skillLvText;
    private UnityEngine.GameObject lockObject;
    private ENTERPRISE.UI.UITextMeshProUGUI lockText;
    private UniRx.Subject<int> onDetail;
    public System.IObservable<int> OnDetail { get; set; }
    private void Awake();
    public void Setup(PRISM.Adapters.IdolSkillContentViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);

    private class <>c__DisplayClass11_0
    {
        public PRISM.Interactions.IdolSkillLvContentView <>4__this;
        public PRISM.Adapters.IdolSkillContentViewModel viewModel;
        private void <Setup>b__0(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions
public class IdolSkillLvUpCompletedPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IIdolSkillLvUpCompletedPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private ENTERPRISE.UI.UITextMeshProUGUI aliasText;
    private ENTERPRISE.UI.UITextMeshProUGUI nameText;
    private ENTERPRISE.UI.UITextMeshProUGUI txtBeforeLv;
    private ENTERPRISE.UI.UITextMeshProUGUI txtAfterLv;
    private PRISM.Interactions.ProduceIdolIconView produceIdolIconView;
    private PRISM.Interactions.ButtonView produceIdolIconButton;
    private UnityEngine.Transform listParent;
    private PRISM.Interactions.IdolSkillContentView goSkillContentView;
    private UnityEngine.Animator animator;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClick;
    private UniRx.Subject<UniRx.Unit> onDetail;
    private string cueSheetName;
    private string cueName;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public System.IObservable<UniRx.Unit> OnProduceIdolDetail { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    private void Awake();
    public void Assign(PRISM.Adapters.IdolSkillLvUpCompletedPopupViewModel vm, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void PlaySE1();
    public void AnimatorDisable();
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <Assign>b__18_0(UniRx.Unit t);
    private void <CreateFrameParameter>b__21_0();
    private void <CreateFrameParameter>b__21_1();
}

// Namespace: PRISM.Interactions
public class LiveSkillEffectView : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI txtEffectName;
    private ENTERPRISE.UI.UITextMeshProUGUI txtEffectValue;
    public void Setup(string name, string value);
}

// Namespace: PRISM.Interactions
public class LiveSupportSkillContentView : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI skillNameText;
    private ENTERPRISE.UI.UITextMeshProUGUI levelText;
    private ENTERPRISE.UI.UITextMeshProUGUI skillDetailText;
    private PRISM.Interactions.LiveSkillEffectView liveSkillEffectViewBase;
    public void Setup(PRISM.Definitions.MstLiveSupportEffect supportEffect, int level);
    private string _getEffectLevelValueText(PRISM.Definitions.MstLiveSupportEffectDetail detail, int level);
}

// Namespace: PRISM.Interactions
public class LockableCostumeIconView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.CostumeIconView iconView;
    private PRISM.Interactions.ViewStateChanger isUnlockedStateChanger;
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Domain.ProductKey productKey, bool isUnlocked, bool setClickToDetail, System.Threading.CancellationToken ct);
}

// Namespace: PRISM.Interactions
public class MasterTrainingExecutionConfirmedPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IMasterTrainingExecutionConfirmedPopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private PRISM.Interactions.ToggleGroupView displayTabGroup;
    private PRISM.UI.DiamondDisplay beforeDiamonds;
    private PRISM.UI.DiamondDisplay afterDiamonds;
    private PRISM.Interactions.LimitLevelUpView limitLevelUpView;
    private PRISM.Interactions.LiveSkillEffectLevelUpView liveSkillEffectLevelUpView;
    private PRISM.Interactions.LimitProduceBonusView limitProduceBonusView;
    private PRISM.Interactions.PieceIconView pieceIconView;
    private ENTERPRISE.UI.UITextMeshProUGUI txtPieceCount;
    private UnityEngine.UI.Image imgFillColor;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClick;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Assign(PRISM.Adapters.SupportCharaMasterTrainingViewModel vm, PRISM.ResourceManagement.IResourceLoader loader);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void _setDiamond(int beforeLv, int afterLv);
    private void _setLimitLevelText(int beforeLv, int afterLv, int rarity);
    private void _setLiveSkillEffect(int sCharaId, int beforeLv, int afterLv);
    private void _setReleaseLimitBonus(System.Collections.Generic.List<PRISM.Adapters.LimitLvContentViewModel> limitLvs, int beforeLv, int afterLv, PRISM.ResourceManagement.IResourceLoader loader);
    private void _setPiece(PRISM.Domain.ProductKey pk, long amount, int required, PRISM.ResourceManagement.IResourceLoader loader);
    private void <CreateFrameParameter>b__13_0();
    private void <CreateFrameParameter>b__13_1();
    private void <CreateFrameParameter>b__13_2();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Adapters.LimitLvContentViewModel, int> <>9__25_1;
        private int <_setReleaseLimitBonus>b__25_1(PRISM.Adapters.LimitLvContentViewModel x);
    }

    private class <>c__DisplayClass23_0
    {
        public int rarity;
        public int beforeLv;
        public int afterLv;
        private bool <_setLimitLevelText>b__0(PRISM.Definitions.MstSupportCharacterLimitBreakBonus limit);
        private bool <_setLimitLevelText>b__1(PRISM.Definitions.MstSupportCharacterLimitBreakBonus limit);
        private bool <_setLimitLevelText>b__2(PRISM.Definitions.MstSupportCharacterLimitBreakBonus limit);
    }

    private class <>c__DisplayClass25_0
    {
        public int beforeLv;
        public int afterLv;
        private bool <_setReleaseLimitBonus>b__0(PRISM.Adapters.LimitLvContentViewModel x);
    }
}

// Namespace: PRISM.Interactions
public class MovieGridCategoryCellView : FancyScrollView.FancyGridViewCell<PRISM.Adapters.ICategoryElementGridCellViewModel, PRISM.Interactions.CategoryElementGridContext>
{
    private PRISM.Interactions.ButtonView playButton;
    private PRISM.Interactions.ViewStateChanger isPIdolStateChanger;
    private PRISM.UI.PFIdolIconView pfIdolIconView;
    private PRISM.UI.SCharaIconView sCharaIconView;
    private ENTERPRISE.UI.UITextMeshProUGUI txtTargetName1;
    private ENTERPRISE.UI.UITextMeshProUGUI txtTargetName2;
    private ENTERPRISE.UI.UITextMeshProUGUI txtMovieDescription;
    private PRISM.AutoCancellationTokenSource cts;
    public void UpdateContent(PRISM.Adapters.ICategoryElementGridCellViewModel iVM);
    private void OnDestroy();
    private void <UpdateContent>b__8_0(System.ValueTuple<int, UnityEngine.GameObject> t);
    private void <UpdateContent>b__8_1(System.ValueTuple<int, UnityEngine.GameObject> t);
    private void <UpdateContent>b__8_2(UniRx.Unit _);
}

// Namespace: PRISM.Interactions
public class MoviePopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IMoviePopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.ToggleGroupView toggleGroupView;
    private PRISM.Interactions.CategoryElementGridView pIdolGridView;
    private PRISM.Interactions.CategoryElementGridView sCharaGridView;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClick;
    private UniRx.Subject<int> onPlay;
    private System.IObservable<int> <OnDetailCellIcon>k__BackingField;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public System.IObservable<int> OnPlay { get; set; }
    public System.IObservable<int> OnDetailCellIcon { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    private void Awake();
    public void Assign(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Adapters.MoviePopupViewModel vm);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__15_0();
    private void <CreateFrameParameter>b__15_1();
}

// Namespace: PRISM.Interactions
public class PFIdolParameterDetailPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IPFIdolParameterDetailPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.PFIdolParameterDetailPopupViewCell[] cells;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    private PRISM.Adapters.IPFIdolParameterDetailPopupView ipfIdolParameterDetailPopupViewImplementation;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Initialize(System.Collections.Generic.IEnumerable<PRISM.Adapters.PFIdolParameterDetailPopupViewModel> viewModels, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__5_0();
    private void <CreateFrameParameter>b__5_1();
}

// Namespace: PRISM.Interactions
public class PFIdolParameterDetailPopupViewCell : UnityEngine.MonoBehaviour
{
    private PRISM.UI.PFIdolIconRectView icon;
    private PRISM.Interactions.VoDaViMeRankView parameterView;
    private PRISM.Interactions.VoDaViMeView baseParameterView;
    public void Initialize(PRISM.Adapters.PFIdolParameterDetailPopupViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Interactions
public class PIdolDetailCostumeSetView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.HorizontalAutoScrollingText nameText;
    private ENTERPRISE.UI.UITextMeshProUGUI starLvText;
    private PRISM.Interactions.LockableCostumeIconView iconBase;
    public void Setup(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Adapters.CostumeSetInfoViewModel viewModel, bool isAllUnlocked);
}

// Namespace: PRISM.Interactions
public class PIdolDetailCostumeView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.PIdolDetailCostumeSetView viewPrefab;
    private UnityEngine.Transform contentParent;
    public void Setup(PRISM.Adapters.PIdolDetailCostumeViewModel vm, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Interactions
public class PIdolDetailLiveSkillView : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI liveCenterSkillName;
    private ENTERPRISE.UI.UITextMeshProUGUI liveCenterSkillDescription;
    private UnityEngine.UI.RawImage liveSkillIconImage;
    private ENTERPRISE.UI.UITextMeshProUGUI liveSkillName;
    private ENTERPRISE.UI.UITextMeshProUGUI liveSkillLv;
    private ENTERPRISE.UI.UITextMeshProUGUI liveSkillDescription;
    private PRISM.Interactions.LiveSkillEffectView liveSkillEffectViewBase;
    public void Setup(PRISM.Adapters.PIdolDetailLiveViewModel vm, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Interactions
public class PIdolDetailPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IPIdolDetailPopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private PRISM.Interactions.ToggleGroupView tabGroup;
    private UnityEngine.GameObject liveTab;
    private UnityEngine.GameObject produceTab;
    private UnityEngine.GameObject scenarioTab;
    private PRISM.Interactions.PIdolDetailStatusView statusView;
    private PRISM.Interactions.PIdolDetailLiveSkillView liveSkillView;
    private PRISM.Interactions.PIdolDetailProduceView produceView;
    private PRISM.Interactions.PIdolDetailScenarioView scenarioView;
    private PRISM.Interactions.PIdolDetailCostumeView costumeView;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClick;
    private PRISM.Adapters.PIdolDetailPopupViewModel vm;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public System.IObservable<int> OnSkillDetail { get; set; }
    public System.IObservable<UniRx.Unit> OnChangeIdolSkill { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Assign(PRISM.Adapters.PIdolDetailPopupViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void UpdateIdolSkillView(PRISM.Adapters.IdolSkillContentViewModel vm);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    private System.Collections.Generic.IReadOnlyList<ButtonInfoParameter> _createButtons();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__19_0();
    private void <_createButtons>b__20_0();
    private void <_createButtons>b__20_1();
}

// Namespace: PRISM.Interactions
public class PIdolDetailProduceView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.IdolSkillLvContentView idolSkillLvContentViewPrefab;
    private UnityEngine.Transform contentParent;
    public void Setup(PRISM.Adapters.PIdolDetailProduceViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Interactions.IdolSkillLvContentView, System.IObservable<int>> <>9__2_0;
        private System.IObservable<int> <Setup>b__2_0(PRISM.Interactions.IdolSkillLvContentView x);
    }

    private class <>c__DisplayClass2_0
    {
        public PRISM.Adapters.PIdolDetailProduceViewModel viewModel;
        private void <Setup>b__1(int idolSkillId);
    }
}

// Namespace: PRISM.Interactions
public class PIdolDetailScenarioView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ScenarioContentView scenarioContentView;
    private UnityEngine.Transform contentParent;
    public void Setup(PRISM.Adapters.PIdolDetailScenarioViewModel viewModel);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Interactions.ScenarioContentView, System.IObservable<PRISM.Scenario.ScenarioId>> <>9__2_0;
        private System.IObservable<PRISM.Scenario.ScenarioId> <Setup>b__2_0(PRISM.Interactions.ScenarioContentView x);
    }

    private class <>c__DisplayClass2_0
    {
        public PRISM.Adapters.PIdolDetailScenarioViewModel viewModel;
        private void <Setup>b__1(PRISM.Scenario.ScenarioId scenarioId);
    }
}

// Namespace: PRISM.Interactions
public class PIdolDetailStatusView : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI idolAlias;
    private ENTERPRISE.UI.UITextMeshProUGUI idolName;
    private PRISM.Interactions.ProduceIdolIconWithStarParameter produceIdolIcon;
    private UnityEngine.UI.RawImage favoriteMark;
    private PRISM.Interactions.ButtonView favoriteButton;
    private ENTERPRISE.UI.UITextMeshProUGUI pIdolLvText;
    private UnityEngine.UI.Image expGaugeImage;
    private ENTERPRISE.UI.UITextMeshProUGUI[] voDaViMeTexts;
    private PRISM.Interactions.ViewStateChanger gaugeStatusStateChanger;
    private UnityEngine.GameObject maxStatusTextObject;
    private PRISM.UI.IdolSkillIconView idolSkillIconView;
    private PRISM.VoDaViMeMultiView voDaViMeMultiView;
    private ENTERPRISE.UI.UIButton btnIdolSkill;
    private ENTERPRISE.UI.UIButton btnChangeIdolSkill;
    private ENTERPRISE.UI.UITextMeshProUGUI txtSkillName;
    private UnityEngine.GameObject idolSkillContent;
    private PRISM.ResourceManagement.IResourceLoader loader;
    private UniRx.Subject<int> onSkillDetail;
    private UniRx.Subject<UniRx.Unit> onChangeIdolSkill;
    public System.IObservable<int> OnSkillDetail { get; set; }
    public System.IObservable<UniRx.Unit> OnChangeIdolSkill { get; set; }
    public void Setup(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Adapters.PIdolDetailPopupViewModel vm, UniRx.IReactiveProperty<int> selectedTabIndex, PRISM.Adapters.IdolSkillContentViewModel idolSkillViewModel);
    public void SetSelectedSkill(PRISM.Adapters.IdolSkillContentViewModel vm);

    private class <>c__DisplayClass23_0
    {
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public PRISM.Interactions.PIdolDetailStatusView <>4__this;
        public PRISM.Adapters.PIdolDetailPopupViewModel vm;
        public bool isChangeableIdolSkill;
        private void <Setup>b__3(int markId);
        private void <Setup>b__4(UniRx.Unit _);
        private void <Setup>b__0(int index);
        private void <Setup>b__1(PRISM.Definitions.IdolParameter p);
        private void <Setup>b__2();
    }

    private class <>c__DisplayClass24_0
    {
        public PRISM.Interactions.PIdolDetailStatusView <>4__this;
        public PRISM.Adapters.IdolSkillContentViewModel vm;
        private void <SetSelectedSkill>b__0();
    }
}

// Namespace: PRISM.Interactions
public class PIdolLvUpCompletedPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IPIdolLvUpCompletedPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private ENTERPRISE.UI.UITextMeshProUGUI aliasText;
    private ENTERPRISE.UI.UITextMeshProUGUI nameText;
    private ENTERPRISE.UI.UITextMeshProUGUI beforeLvText;
    private ENTERPRISE.UI.UITextMeshProUGUI afterLvText;
    private PRISM.Interactions.ProduceIdolIconView produceIdolIconView;
    private UnityEngine.Animator animator;
    private PRISM.Interactions.StatusUpView statusUpView;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClosed;
    private string cueSheetName;
    private string cueName;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Assign(int mstProduceIdolId, int mstCharacterInfoId, int beforeLv, int afterLv, int currentStarLv, string cueSheetName, string cueName, PRISM.Definitions.IdolParameter beforeParameter, PRISM.Definitions.IdolParameter afterParameter, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void PlaySE1();
    public void AnimatorDisable();
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__15_0();
    private void <CreateFrameParameter>b__15_1();
}

// Namespace: PRISM.Interactions
public class PieceConversionCompletedPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IPieceConversionCompletedPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private ENTERPRISE.OutGame.RewardItem rewardItem;
    private ENTERPRISE.UI.UITextMeshProUGUI txtBeforePoint;
    private ENTERPRISE.UI.UITextMeshProUGUI txtAfterPoint;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClick;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Assign(PRISM.Adapters.PieceConversionCompletedPopupViewModel vm, PRISM.ResourceManagement.IResourceLoader resourceLoader);
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
public class PieceConversionConfirmedPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IPieceConversionConfirmedPopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private PRISM.Interactions.EnhancedPieceSelectGridView gridView;
    private ENTERPRISE.UI.UITextMeshProUGUI txtBeforePoint;
    private ENTERPRISE.UI.UITextMeshProUGUI txtAfterPoint;
    private ENTERPRISE.UI.UITextMeshProUGUI txtAttention;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClick;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Assign(PRISM.Adapters.PieceConversionConfirmedPopupViewModel vm, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__8_0();
    private void <CreateFrameParameter>b__8_1();
    private void <CreateFrameParameter>b__8_2();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Common.Model.PieceIcon, bool> <>9__7_0;
        private bool <Assign>b__7_0(PRISM.Common.Model.PieceIcon x);
    }

    private class <>c__DisplayClass7_0
    {
        public PRISM.Adapters.PieceConversionConfirmedPopupViewModel vm;
        public PRISM.Interactions.PieceConversionConfirmedPopupView <>4__this;
        private void <Assign>b__1(int index);
    }
}

// Namespace: PRISM.Interactions
public class PITrainingExecutionConfirmedPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IPITrainingExecutionConfirmedPopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private PRISM.Interactions.ToggleGroupView displayTabGroup;
    private PRISM.Interactions.StarsStateView beforeStars;
    private PRISM.Interactions.StarsStateView afterStars;
    private PRISM.Interactions.StatusUpView statusUpView;
    private PRISM.Interactions.LiveSkillLvView liveSkillLvView;
    private PRISM.Interactions.IdolSkillLvView idolSkillLvView;
    private UnityEngine.Transform otherBonusContentParent;
    private PRISM.Interactions.OtherBonusContentView otherBonusContentViewPrefab;
    private PRISM.Interactions.PieceIconView pieceIconView;
    private ENTERPRISE.UI.UITextMeshProUGUI pieceCountText;
    private UnityEngine.UI.Image fillColorImage;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClick;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Assign(PRISM.Module.Networking.IProduceIdolStatus pi, PRISM.Module.Networking.IIdolBaseStatus idolBaseStatus, PRISM.Adapters.ProduceIdolTrainingViewModel vm, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void Assign(PRISM.Adapters.ProduceIdolTrainingViewModel vm, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__16_0();
    private void <CreateFrameParameter>b__16_1();
    private void <CreateFrameParameter>b__16_2();
}

// Namespace: PRISM.Interactions
public class PlaceToGetCellListView : UnityEngine.MonoBehaviour, EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate, System.IDisposable
{
    private EnhancedUI.EnhancedScroller.EnhancedScroller scroller;
    private PRISM.Interactions.PlaceToGetCellView placeToGetCellViewPrefab;
    private PRISM.Interactions.PlaceToGetCellListContext context;
    private System.Collections.Generic.List<PRISM.Adapters.HowToGetItemsIconViewModel> vmList;
    private System.IObservable<System.ValueTuple<ButtonGoToType, string>> <OnSelectPlace>k__BackingField;
    public System.IObservable<System.ValueTuple<ButtonGoToType, string>> OnSelectPlace { get; set; }
    public void Setup(System.Collections.Generic.List<PRISM.Adapters.HowToGetItemsIconViewModel> vmList, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void Dispose();
    private int EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate.GetNumberOfCells(EnhancedUI.EnhancedScroller.EnhancedScroller scroller);
    private float EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate.GetCellViewSize(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex);
    private EnhancedUI.EnhancedScroller.EnhancedScrollerCellView EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate.GetCellView(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex, int cellIndex);
    private void _activateCell(PRISM.Interactions.PlaceToGetCellView cellView);
    private void _deactivateCell(PRISM.Interactions.PlaceToGetCellView cellView);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Interactions.PlaceToGetCellView, bool> <>9__8_0;
        private bool <Setup>b__8_0(PRISM.Interactions.PlaceToGetCellView cellView);
    }
}

// Namespace: PRISM.Interactions
public class ProduceStrategyContentView : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.Image imgIcon;
    private ENTERPRISE.UI.UITextMeshProUGUI txtTitle;
    private ENTERPRISE.UI.UITextMeshProUGUI txtDetail;
    public void Setup(int produceStrategyTypeId, int produceStrategyId, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Interactions
public class RewardCellView : EnhancedUI.EnhancedScroller.EnhancedScrollerCellView
{
    private UnityEngine.RectTransform rectTransform;
    private ENTERPRISE.UI.UITextMeshProUGUI txtLv;
    private UnityEngine.Transform trRewardParent;
    private UnityEngine.UI.VerticalLayoutGroup verticalLayoutGroup;
    private UnityEngine.GameObject goArchived;
    private PRISM.UIGrayOutController grayOutController;
    private UnityEngine.Pool.ObjectPool<PRISM.Interactions.RewardItemColumn> itemColumnPool;
    private UnityEngine.Pool.ObjectPool<PRISM.Interactions.RewardStatusColumn> statusColumnPool;
    private UnityEngine.Pool.ObjectPool<UnityEngine.GameObject> borderLinePool;
    private System.Collections.Generic.List<PRISM.Interactions.RewardItemColumn> activeItemColumns;
    private System.Collections.Generic.List<PRISM.Interactions.RewardStatusColumn> activeStatusColumns;
    private System.Collections.Generic.List<UnityEngine.GameObject> activeBorderLines;
    public float PaddingTop { get; set; }
    public float PaddingBottom { get; set; }
    public float Space { get; set; }
    public void Setup(PRISM.Adapters.IdolBaseDetailRewardListCellData data, float cellHeight, PRISM.Interactions.RewardItemColumn itemColumnPrefab, PRISM.Interactions.RewardStatusColumn statusColumnPrefab, UnityEngine.GameObject borderLinePrefab, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private UnityEngine.Pool.ObjectPool<PRISM.Interactions.RewardItemColumn> _createItemColumnPool(PRISM.Interactions.RewardItemColumn prefab);
    private UnityEngine.Pool.ObjectPool<PRISM.Interactions.RewardStatusColumn> _createStatusColumnPool(PRISM.Interactions.RewardStatusColumn prefab);
    private UnityEngine.Pool.ObjectPool<UnityEngine.GameObject> _createBorderLinePool(UnityEngine.GameObject prefab);
    public void Reset();
    private void OnDestroy();

    private class <>c
    {
        public static <>c <>9;
        public static System.Action<PRISM.Interactions.RewardItemColumn> <>9__19_2;
        public static System.Action<PRISM.Interactions.RewardItemColumn> <>9__19_3;
        public static System.Action<PRISM.Interactions.RewardStatusColumn> <>9__20_2;
        public static System.Action<PRISM.Interactions.RewardStatusColumn> <>9__20_3;
        public static System.Action<UnityEngine.GameObject> <>9__21_2;
        public static System.Action<UnityEngine.GameObject> <>9__21_3;
        private void <_createItemColumnPool>b__19_2(PRISM.Interactions.RewardItemColumn target);
        private void <_createItemColumnPool>b__19_3(PRISM.Interactions.RewardItemColumn target);
        private void <_createStatusColumnPool>b__20_2(PRISM.Interactions.RewardStatusColumn target);
        private void <_createStatusColumnPool>b__20_3(PRISM.Interactions.RewardStatusColumn target);
        private void <_createBorderLinePool>b__21_2(UnityEngine.GameObject target);
        private void <_createBorderLinePool>b__21_3(UnityEngine.GameObject target);
    }

    private class <>c__DisplayClass19_0
    {
        public PRISM.Interactions.RewardItemColumn prefab;
        public PRISM.Interactions.RewardCellView <>4__this;
        private PRISM.Interactions.RewardItemColumn <_createItemColumnPool>b__0();
        private void <_createItemColumnPool>b__1(PRISM.Interactions.RewardItemColumn target);
    }

    private class <>c__DisplayClass20_0
    {
        public PRISM.Interactions.RewardStatusColumn prefab;
        public PRISM.Interactions.RewardCellView <>4__this;
        private PRISM.Interactions.RewardStatusColumn <_createStatusColumnPool>b__0();
        private void <_createStatusColumnPool>b__1(PRISM.Interactions.RewardStatusColumn target);
    }

    private class <>c__DisplayClass21_0
    {
        public UnityEngine.GameObject prefab;
        public PRISM.Interactions.RewardCellView <>4__this;
        private UnityEngine.GameObject <_createBorderLinePool>b__0();
        private void <_createBorderLinePool>b__1(UnityEngine.GameObject target);
    }
}

// Namespace: PRISM.Interactions
public class RewardItemColumn : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.OutGame.RewardItem rewardItem;
    private UnityEngine.CanvasGroup cgRewardItem;
    private UnityEngine.UI.RawImage imgReward;
    private UnityEngine.CanvasGroup cgReward;
    private ENTERPRISE.UI.UITextMeshProUGUI txtReward;
    public void Setup(PRISM.Module.Networking.IProductWithAmountStatus productWithAmount, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private void _switchCanvasGroup(UnityEngine.CanvasGroup cg, bool active);
}

// Namespace: PRISM.Interactions
public class RewardStatusColumn : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.VoDaViMeView voDaViMeView;
    public void Setup(PRISM.Adapters.VoDaViMeViewModel voDaViMe);
}

// Namespace: PRISM.Interactions
public class ScenarioContentView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView button;
    private ENTERPRISE.UI.UITextMeshProUGUI titleText;
    private ENTERPRISE.UI.UITextMeshProUGUI summaryText;
    private PRISM.UIGrayOutController uiGrayOutController;
    private UnityEngine.GameObject lockObject;
    private ENTERPRISE.UI.UITextMeshProUGUI lockTextTitle;
    private ENTERPRISE.UI.UITextMeshProUGUI lockTextSummary;
    private UniRx.Subject<PRISM.Scenario.ScenarioId> onClick;
    public System.IObservable<PRISM.Scenario.ScenarioId> OnClick { get; set; }
    private void Awake();
    public void Setup(PRISM.Adapters.ScenarioContentViewModel vm);

    private class <>c__DisplayClass11_0
    {
        public PRISM.Interactions.ScenarioContentView <>4__this;
        public PRISM.Adapters.ScenarioContentViewModel vm;
        private void <Setup>b__0(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions
public class SCharaDetailLiveSupportEffectView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.LiveSupportSkillContentView liveSkillContent;
    public void Setup(PRISM.Definitions.MstLiveSupportEffect supportEffect, int level);
}

// Namespace: PRISM.Interactions
public class SCharaDetailPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.ISCharaDetailPopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private PRISM.Interactions.ToggleGroupView tabGroup;
    private UnityEngine.GameObject liveTab;
    private UnityEngine.GameObject produceTab;
    private PRISM.Interactions.SCharaDetailStatusView statusView;
    private PRISM.Interactions.SCharaDetailLiveSupportEffectView liveSupportEffectView;
    private PRISM.Interactions.SCharaDetailSupportEffectView supportEffectView;
    private PRISM.Interactions.SCharaDetailSupportEventView supportEventView;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClick;
    private PRISM.Adapters.SCharaDetailPopupViewModel vm;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public System.IObservable<UniRx.Unit> OnFavoriteMark { get; set; }
    public System.IObservable<PRISM.Scenario.ScenarioId> OnPlayAdv { get; set; }
    public System.IObservable<UniRx.Unit> OnFullImage { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Assign(PRISM.Adapters.SCharaDetailPopupViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    private System.Collections.Generic.IReadOnlyList<ButtonInfoParameter> _createButtons();
    public void ChangeFavoriteMark(int mstFavoriteMarkId, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__18_0();
    private void <_createButtons>b__19_0();
    private void <_createButtons>b__19_1();
}

// Namespace: PRISM.Interactions
public class SCharaDetailPotentialSupportSkillView : UnityEngine.MonoBehaviour
{
    private UnityEngine.CanvasGroup canvasGroup;
    private PRISM.Interactions.PotentialSupportSkillContentView goContent;
    private UnityEngine.Transform contentParent;
    public void Setup(int[] potentialSupportSkillIds, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Interactions
public class SCharaDetailStatusView : UnityEngine.MonoBehaviour
{
    private PRISM.UI.SCharaIconRectView sCharaIconRectView;
    private ENTERPRISE.UI.UITextMeshProUGUI totalParameterText;
    private ENTERPRISE.UI.UITextMeshProUGUI txtAlias;
    private ENTERPRISE.UI.UITextMeshProUGUI txtName;
    private PRISM.UI.DiamondDisplay diamondDisplay;
    private PRISM.Interactions.SkillSlotIconView skillSlotIconView;
    private UnityEngine.Transform skillSlotParent;
    private ENTERPRISE.UI.UITextMeshProUGUI txtLv;
    private UnityEngine.UI.Image imgExpProgress;
    private ENTERPRISE.UI.UITextMeshProUGUI txtSpecialtySchedules;
    private UnityEngine.GameObject goCaution;
    private UnityEngine.UI.RawImage imgFavoriteMark;
    private PRISM.Interactions.ButtonView favoriteMarkButton;
    private PRISM.Interactions.ButtonView fullImageButton;
    private ENTERPRISE.UI.UITextMeshProUGUI vocalText;
    private ENTERPRISE.UI.UITextMeshProUGUI danceText;
    private ENTERPRISE.UI.UITextMeshProUGUI visualText;
    private ENTERPRISE.UI.UITextMeshProUGUI mentalText;
    public System.IObservable<UniRx.Unit> OnFavoriteMark { get; set; }
    public System.IObservable<UniRx.Unit> OnFullImage { get; set; }
    public void Setup(PRISM.Adapters.SCharaDetailPopupViewModel vm, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void SetFavoriteMark(int mstFavoriteMarkId, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Interactions
public class SCharaDetailSupportEffectView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.SupportEffectContentView goContent;
    private UnityEngine.Transform contentParent;
    private PRISM.Interactions.SCharaDetailPotentialSupportSkillView potentialSupportSkillView;
    public void Setup(PRISM.Adapters.SupportEffectContentViewModel[] viewModels, int[] potentialSupportSkillIds, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Interactions
public class SCharaDetailSupportEventView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ScenarioContentView goContent;
    private UnityEngine.Transform contentParent;
    private UnityEngine.GameObject emptyView;
    private UniRx.Subject<PRISM.Scenario.ScenarioId> onClick;
    public System.IObservable<PRISM.Scenario.ScenarioId> OnClick { get; set; }
    private void Awake();
    public void Setup(PRISM.Adapters.ScenarioContentViewModel[] eventModels);
    private void <Setup>b__7_1(PRISM.Scenario.ScenarioId scenarioId);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Interactions.ScenarioContentView, System.IObservable<PRISM.Scenario.ScenarioId>> <>9__7_0;
        private System.IObservable<PRISM.Scenario.ScenarioId> <Setup>b__7_0(PRISM.Interactions.ScenarioContentView x);
    }
}

// Namespace: PRISM.Interactions
public class FavoriteIconSelectGridView : FancyScrollView.FancyGridView<PRISM.Adapters.FavoriteIconViewModel, PRISM.ClickObservableContext<int>>, System.IDisposable
{
    private PRISM.Interactions.FavoriteIconSelectGridViewCell cellPrefab;
    protected UnityEngine.GameObject emptyView;
    public PRISM.ClickObservableContext<int> ViewContext { get; set; }
    public void UpdateContents(System.Collections.Generic.IList<PRISM.Adapters.FavoriteIconViewModel> items);
    public void Dispose();
    protected void SetupCellTemplate();

    private class CellGroup : DefaultCellGroup<PRISM.Adapters.FavoriteIconViewModel, PRISM.ClickObservableContext<int>>
    {
    }
}

// Namespace: PRISM.Interactions
public class FavoriteIconSelectGridViewCell : FancyScrollView.FancyGridViewCell<PRISM.Adapters.FavoriteIconViewModel, PRISM.ClickObservableContext<int>>
{
    private PRISM.Interactions.FavoriteIconView favoriteIconView;
    public void UpdateContent(PRISM.Adapters.FavoriteIconViewModel itemData);
}

// Namespace: PRISM.Interactions
public class FavoriteIconView : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UIButton btn;
    private UnityEngine.UI.RawImage imgIcon;
    private UnityEngine.CanvasGroup cgText;
    private UnityEngine.CanvasGroup cgSelected;
    private UniRx.Subject<System.ValueTuple<int, UnityEngine.GameObject>> onClickSubject;
    private int index;
    private System.IObservable<System.ValueTuple<int, UnityEngine.GameObject>> <OnLongPress>k__BackingField;
    public System.IObservable<System.ValueTuple<int, UnityEngine.GameObject>> OnClick { get; set; }
    public System.IObservable<System.ValueTuple<int, UnityEngine.GameObject>> OnLongPress { get; set; }
    private void Awake();
    public void Setup(int index, PRISM.Adapters.FavoriteIconViewModel data, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void SetOnClickContext(PRISM.IContextClick<int> context);

    private class <>c__DisplayClass12_0
    {
        public PRISM.Interactions.FavoriteIconView <>4__this;
        public int index;
        private void <Setup>b__0(bool b);
        private void <Setup>b__1();
    }

    private class <>c__DisplayClass13_0
    {
        public PRISM.IContextClick<int> context;
        public PRISM.Interactions.FavoriteIconView <>4__this;
        private void <SetOnClickContext>b__0();
    }
}

// Namespace: PRISM.Interactions
public class SelectFavoriteMarkPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.ISelectFavoriteMarkPopupView, PRISM.Adapters.IClosablePopupFrame<System.ValueTuple<bool, int>>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<System.ValueTuple<bool, int>>
{
    private PRISM.Interactions.FavoriteIconSelectGridView gridView;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<System.ValueTuple<bool, int>> onClick;
    private PRISM.Adapters.SelectFavoriteMarkViewModel vm;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<System.ValueTuple<bool, int>> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Assign(PRISM.Adapters.SelectFavoriteMarkViewModel vm, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <Assign>b__5_0(int index);
    private void <CreateFrameParameter>b__6_0();
    private void <CreateFrameParameter>b__6_1();
    private void <CreateFrameParameter>b__6_2();
}

// Namespace: PRISM.Interactions
public class SkillSlotIconView : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.RawImage imgIcon;
    public void SetLock(bool isLocked, PRISM.ResourceManagement.IResourceLoader resourceLoader);
}

// Namespace: PRISM.Interactions
public class SupportCharaLvUpCompletedPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.ISupportCharaLvUpCompletedPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.ToggleGroupView displayTabGroup;
    private PRISM.UI.SCharaIconRectView sCharaIconRectView;
    private ENTERPRISE.UI.UITextMeshProUGUI txtAlias;
    private ENTERPRISE.UI.UITextMeshProUGUI txtName;
    private ENTERPRISE.UI.UITextMeshProUGUI txtBeforeLv;
    private ENTERPRISE.UI.UITextMeshProUGUI txtAfterLv;
    private PRISM.Interactions.StatusUpView statusUpView;
    private PRISM.Interactions.SupportEffectView supportEffectView;
    private UnityEngine.Renderer[] lvUpParticleRenderers;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClick;
    private UniRx.Subject<int> onDetail;
    private string cueSheetName;
    private string cueName;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public System.IObservable<int> OnDetail { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public Cysharp.Threading.Tasks.UniTask AssignAsync(PRISM.Adapters.SupportCharaLvUpCompletedPopupViewModel vm, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public void PlaySE1();
    public void SetOrderInLayerForParticles(bool front);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__20_0();
    private void <CreateFrameParameter>b__20_1();

    private class <>c__DisplayClass17_0
    {
        public PRISM.Interactions.SupportCharaLvUpCompletedPopupView <>4__this;
        public PRISM.Adapters.SupportCharaLvUpCompletedPopupViewModel vm;
        private void <AssignAsync>b__0(System.ValueTuple<int, UnityEngine.GameObject> _);
        private bool <AssignAsync>b__1(PRISM.Adapters.SupportEffectContentViewModel x);
    }
}

// Namespace: PRISM.Interactions
public class ProduceResultTransferConfirmedPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IProduceResultTransferConfirmedPopupView, PRISM.Adapters.IClosablePopupFrame<bool>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<bool>
{
    private ENTERPRISE.UI.UIButton deckButton;
    private PRISM.UI.FUnitIconView fUnitIconView;
    private PRISM.UI.PFIdolIconView[] fIdolIconViews;
    private PRISM.Interactions.FUnitDetailSupportView supportView;
    private UnityEngine.GameObject[] bookIcons;
    private ENTERPRISE.UI.UITextMeshProUGUI[] amounts;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> onClosed;
    private PRISM.Interactions.IPopupFrameView parent;
    public System.IObservable<UniRx.Unit> OnClickDeck { get; set; }
    public Cysharp.Threading.Tasks.UniTask<bool> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Setup(PRISM.Adapters.ProduceResultTransferConfirmedPopupViewModel viewModel, PRISM.ResourceManagement.IResourceLoader loader);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__12_0();
    private void <CreateFrameParameter>b__12_1();
    private void <CreateFrameParameter>b__12_2();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Module.Networking.IFesUnitAttachedSupportSkillStatus, System.ValueTuple<int, bool>> <>9__11_0;
        public static System.Func<PRISM.Module.Networking.IProductWithAmountStatus, int> <>9__11_1;
        private System.ValueTuple<int, bool> <Setup>b__11_0(PRISM.Module.Networking.IFesUnitAttachedSupportSkillStatus x);
        private int <Setup>b__11_1(PRISM.Module.Networking.IProductWithAmountStatus x);
    }
}

// Namespace: PRISM.Interactions
public class VariableCellListView : UnityEngine.MonoBehaviour, EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate
{
    private EnhancedUI.EnhancedScroller.EnhancedScroller scroller;
    private EnhancedUI.EnhancedScroller.EnhancedScrollerCellView[] cellViewPrefabs;
    private PRISM.Interactions.RewardItemColumn itemColumnPrefab;
    private PRISM.Interactions.RewardStatusColumn statusColumnPrefab;
    private UnityEngine.GameObject borderLinePrefab;
    private PRISM.Adapters.IdolBaseDetailRewardListViewModel viewModel;
    private float itemColumnHeight;
    private float statusColumnHeight;
    private float borderLineHeight;
    public void Setup(PRISM.Adapters.IdolBaseDetailRewardListViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private void _activateCell(PRISM.Interactions.RewardCellView cellView, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private void _deactivateCell(PRISM.Interactions.RewardCellView cellView);
    private int EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate.GetNumberOfCells(EnhancedUI.EnhancedScroller.EnhancedScroller scroller);
    private float EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate.GetCellViewSize(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex);
    private EnhancedUI.EnhancedScroller.EnhancedScrollerCellView EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate.GetCellView(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex, int cellIndex);
    private EnhancedUI.EnhancedScroller.EnhancedScrollerCellView _selectCellView(int dataIndex);
    private float _getCellViewHeight(int dataIndex);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Interactions.RewardCellView, bool> <>9__9_0;
        public static System.Func<EnhancedUI.EnhancedScroller.EnhancedScrollerCellView, bool> <>9__15_0;
        private bool <Setup>b__9_0(PRISM.Interactions.RewardCellView cellView);
        private bool <_selectCellView>b__15_0(EnhancedUI.EnhancedScroller.EnhancedScrollerCellView x);
    }

    private class <>c__DisplayClass9_0
    {
        public PRISM.Interactions.VariableCellListView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private void <Setup>b__1(PRISM.Interactions.RewardCellView x);
    }
}

// Namespace: PRISM.Interactions
public class CategoryElementGridContext : FancyScrollView.FancyGridViewContext, System.IDisposable
{
    private UniRx.Subject<int> onClick;
    private UniRx.Subject<int> onDetail;
    private PRISM.Adapters.CategoryElementGridCellViewType <CellViewType>k__BackingField;
    private PRISM.ResourceManagement.IResourceLoader <ResourceLoader>k__BackingField;
    public System.IObservable<int> OnClickObservable { get; set; }
    public System.IObservable<int> OnDetailObservable { get; set; }
    public PRISM.Adapters.CategoryElementGridCellViewType CellViewType { get; set; }
    public PRISM.ResourceManagement.IResourceLoader ResourceLoader { get; set; }
    public void Set(PRISM.Adapters.CategoryElementGridCellViewType cellViewType, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void ClickOnNext(int value);
    public void DetailOnNext(int value);
    public void Dispose();
}

// Namespace: PRISM.Interactions
public class CategoryElementGridView : FancyScrollView.FancyGridView<PRISM.Adapters.ICategoryElementGridCellViewModel, PRISM.Interactions.CategoryElementGridContext>, System.IDisposable
{
    private FancyScrollView.FancyGridViewCell<PRISM.Adapters.ICategoryElementGridCellViewModel, PRISM.Interactions.CategoryElementGridContext> categoryCellPrefab;
    private FancyScrollView.FancyGridViewCell<PRISM.Adapters.ICategoryElementGridCellViewModel, PRISM.Interactions.CategoryElementGridContext> elementCellPrefab;
    protected UnityEngine.GameObject emptyView;
    public PRISM.Interactions.CategoryElementGridContext ViewContext { get; set; }
    public void UpdateContents(System.Collections.Generic.IList<PRISM.Adapters.ICategoryElementGridCellViewModel> items);
    public void Dispose();
    protected void SetupCellTemplate();

    private class CellGroup : DefaultCellGroup<PRISM.Adapters.ICategoryElementGridCellViewModel, PRISM.Interactions.CategoryElementGridContext>
    {
    }
}

// Namespace: PRISM.Interactions
public class VoiceGridCategoryCellView : FancyScrollView.FancyGridViewCell<PRISM.Adapters.ICategoryElementGridCellViewModel, PRISM.Interactions.CategoryElementGridContext>
{
    private ENTERPRISE.UI.UIButton btnCell;
    private PRISM.UI.PFIdolIconView pfIdolIconView;
    private PRISM.UI.SCharaIconView sCharaIconView;
    private ENTERPRISE.UI.UITextMeshProUGUI txtVoiceTargetName1;
    private ENTERPRISE.UI.UITextMeshProUGUI txtVoiceTargetName2;
    private ENTERPRISE.UI.UITextMeshProUGUI txtCounter;
    private UnityEngine.GameObject goGrayOut;
    private System.IDisposable onDetailDisposable;
    public void UpdateContent(PRISM.Adapters.ICategoryElementGridCellViewModel iVM);
    private void <UpdateContent>b__8_0(System.ValueTuple<int, UnityEngine.GameObject> t);
    private void <UpdateContent>b__8_1(System.ValueTuple<int, UnityEngine.GameObject> t);
    private void <UpdateContent>b__8_2();
}

// Namespace: PRISM.Interactions
public class VoiceGridElementCellView : FancyScrollView.FancyGridViewCell<PRISM.Adapters.ICategoryElementGridCellViewModel, PRISM.Interactions.CategoryElementGridContext>
{
    private PRISM.UIGrayOutController grayoutController;
    private ENTERPRISE.UI.UITextMeshProUGUI txtVoice;
    private ENTERPRISE.UI.UIButton btnStop;
    private ENTERPRISE.UI.UIButton btnPlay;
    public void UpdateContent(PRISM.Adapters.ICategoryElementGridCellViewModel iVM);
    private Cysharp.Threading.Tasks.UniTask _playVoiceAsync(string cueSheetName, string cueName);
    private void _stopPlayingVoice();
    private void _switchBtn(bool on);
    private void OnDestroy();

    private class <>c__DisplayClass4_0
    {
        public PRISM.Interactions.VoiceGridElementCellView <>4__this;
        public PRISM.Adapters.VoiceElementGridCellViewModel vm;
        private void <UpdateContent>b__0();
        private void <UpdateContent>b__1();
    }

    private struct <_playVoiceAsync>d__5 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.VoiceGridElementCellView <>4__this;
        public string cueSheetName;
        public string cueName;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class VoicePopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IVoicePopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.ToggleGroupView toggleGroupView;
    private PRISM.Interactions.CategoryElementGridView idolGridView;
    private PRISM.Interactions.CategoryElementGridView pIdolGridView;
    private PRISM.Interactions.CategoryElementGridView sCharaGridView;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClick;
    private System.IObservable<int> <OnClickCell>k__BackingField;
    private System.IObservable<int> <OnDetailCellIcon>k__BackingField;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public System.IObservable<int> OnClickCell { get; set; }
    public System.IObservable<int> OnDetailCellIcon { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    private void Awake();
    public void Assign(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Adapters.VoicePopupViewModel vm);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__17_0();
    private void <CreateFrameParameter>b__17_1();
}

// Namespace: PRISM.Interactions
public class VoicePlayListPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IVoicePlayListPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.CategoryElementGridView gridView;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClick;
    private PRISM.Adapters.VoicePlayListPopupViewModel vm;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Assign(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Adapters.VoicePlayListPopupViewModel _vm);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__6_0();
    private void <CreateFrameParameter>b__6_1();
}

// Namespace: PRISM.Interactions
public class VoicePlayTabListPopupView : UnityEngine.MonoBehaviour, PRISM.Interactions.IPopupContent, PRISM.Adapters.IVoicePlayTabListPopupView, PRISM.Adapters.IClosablePopupFrame<UniRx.Unit>, PRISM.Adapters.IPopupFrame, PRISM.Adapters.IClosable<UniRx.Unit>
{
    private PRISM.Interactions.ToggleGroupView toggleGroupView;
    private PRISM.Interactions.CategoryElementGridView homeGridView;
    private PRISM.Interactions.CategoryElementGridView produceGridView;
    private PRISM.Interactions.CategoryElementGridView liveGridView;
    private PRISM.Interactions.CategoryElementGridView otherGridView;
    private Cysharp.Threading.Tasks.UniTaskCompletionSource<UniRx.Unit> onClick;
    private PRISM.Adapters.VoicePlayTabListPopupViewModel vm;
    private PRISM.Interactions.IPopupFrameView parent;
    public Cysharp.Threading.Tasks.UniTask<UniRx.Unit> OnCloseRequested { get; set; }
    public UnityEngine.RectTransform Rect { get; set; }
    public void Assign(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Adapters.VoicePlayTabListPopupViewModel _vm);
    public PRISM.Interactions.PopupFrameParameter CreateFrameParameter();
    public void RegisterPopupFrame(PRISM.Interactions.IPopupFrameView parent);
    public Cysharp.Threading.Tasks.UniTask ShowAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask HideAsync();
    public Cysharp.Threading.Tasks.UniTask<bool> LoadAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask TerminateAsync();
    private void <CreateFrameParameter>b__10_0();
    private void <CreateFrameParameter>b__10_1();
}

// Namespace: PRISM.Interactions
public class ProduceIdolEnhancedGridCellView : EnhancedUI.EnhancedScroller.EnhancedScrollerCellView
{
    private PRISM.Interactions.ListProduceIdolIconView[] iconViews;
    private System.Threading.CancellationTokenSource cts;
    public void Initialize(PRISM.Interactions.CharacterSelectClickObservableInt context);
    public void UpdateCell(int startDataIndexInRow, PRISM.Adapters.ListProduceIdolIconViewModel[] viewModels);
    private void OnDestroy();
}

// Namespace: PRISM.Interactions
public class ProduceIdolEnhancedGridView : UnityEngine.MonoBehaviour, EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate, System.IDisposable
{
    private EnhancedUI.EnhancedScroller.EnhancedScroller scroller;
    private EnhancedUI.EnhancedScroller.EnhancedScrollerCellView rowPrefab;
    private int iconsCountInRow;
    private UnityEngine.GameObject emptyView;
    private System.Collections.Generic.List<PRISM.Adapters.ListProduceIdolIconViewModel[]> iconRows;
    private System.Nullable<float> rowHeight;
    private int firstViewTargetId;
    private PRISM.Interactions.CharacterSelectClickObservableInt <ViewContext>k__BackingField;
    public PRISM.Interactions.CharacterSelectClickObservableInt ViewContext { get; set; }
    private int EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate.GetNumberOfCells(EnhancedUI.EnhancedScroller.EnhancedScroller scroller);
    private float EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate.GetCellViewSize(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex);
    private EnhancedUI.EnhancedScroller.EnhancedScrollerCellView EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate.GetCellView(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex, int cellIndex);
    public void Initialize(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Definitions.SortType initialSortType, int firstViewTargetId);
    private void _cellInstantiated(EnhancedUI.EnhancedScroller.EnhancedScroller enhancedScroller, EnhancedUI.EnhancedScroller.EnhancedScrollerCellView cellView);
    private void _activateCell(EnhancedUI.EnhancedScroller.EnhancedScrollerCellView cellView);
    public void UpdateContent(System.Collections.Generic.IReadOnlyList<PRISM.Adapters.ListProduceIdolIconViewModel> iconViewModels);
    public void Dispose();
    private int <UpdateContent>b__16_1(System.ValueTuple<PRISM.Adapters.ListProduceIdolIconViewModel, int> t);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Adapters.ListProduceIdolIconViewModel, int, System.ValueTuple<PRISM.Adapters.ListProduceIdolIconViewModel, int>> <>9__16_0;
        public static System.Func<System.Linq.IGrouping<int, System.ValueTuple<PRISM.Adapters.ListProduceIdolIconViewModel, int>>, int> <>9__16_2;
        public static System.Func<System.ValueTuple<PRISM.Adapters.ListProduceIdolIconViewModel, int>, PRISM.Adapters.ListProduceIdolIconViewModel> <>9__16_5;
        public static System.Func<System.Linq.IGrouping<int, System.ValueTuple<PRISM.Adapters.ListProduceIdolIconViewModel, int>>, PRISM.Adapters.ListProduceIdolIconViewModel[]> <>9__16_3;
        public static System.Func<PRISM.Adapters.ListProduceIdolIconViewModel, int, bool> <>9__16_4;
        private System.ValueTuple<PRISM.Adapters.ListProduceIdolIconViewModel, int> <UpdateContent>b__16_0(PRISM.Adapters.ListProduceIdolIconViewModel icon, int index);
        private int <UpdateContent>b__16_2(System.Linq.IGrouping<int, System.ValueTuple<PRISM.Adapters.ListProduceIdolIconViewModel, int>> x);
        private PRISM.Adapters.ListProduceIdolIconViewModel[] <UpdateContent>b__16_3(System.Linq.IGrouping<int, System.ValueTuple<PRISM.Adapters.ListProduceIdolIconViewModel, int>> g);
        private PRISM.Adapters.ListProduceIdolIconViewModel <UpdateContent>b__16_5(System.ValueTuple<PRISM.Adapters.ListProduceIdolIconViewModel, int> x);
        private bool <UpdateContent>b__16_4(PRISM.Adapters.ListProduceIdolIconViewModel m, int id);
    }
}

// Namespace: PRISM.Interactions
public class ProduceIdolIconViewWithSelector : PRISM.Interactions.ListProduceIdolIconView
{
    private PRISM.Interactions.ProduceIdolIconView iconView;
    private PRISM.Interactions.ButtonView button;
    private ENTERPRISE.UI.UITextMeshProUGUI pIdolLvText;
    private PRISM.Interactions.StarsStateView starsView;
    private UnityEngine.GameObject selectedLabelObject;
    private UnityEngine.GameObject selector;
    private UniRx.CompositeDisposable disposables;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    private int dataIndex;
    public void Initialize(PRISM.Interactions.CharacterSelectClickObservableInt context);
    public Cysharp.Threading.Tasks.UniTask UpdateViewAsync(PRISM.Adapters.ListProduceIdolIconViewModel vm, int dataIndex, System.Threading.CancellationToken ct);
    private void <UpdateViewAsync>b__10_0(bool b);

    private class <>c__DisplayClass9_0
    {
        public PRISM.Interactions.CharacterSelectClickObservableInt context;
        public PRISM.Interactions.ProduceIdolIconViewWithSelector <>4__this;
        private void <Initialize>b__0(UniRx.Unit _);
        private void <Initialize>b__1(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions
public class ProduceIdolIconViewWithSwitchInfo : PRISM.Interactions.ListProduceIdolIconView
{
    private PRISM.Interactions.ProduceIdolIconView iconView;
    private PRISM.Interactions.ButtonView button;
    private UnityEngine.UI.RawImage favoriteIconImage;
    private PRISM.Interactions.ViewStateChanger infoViewStateChanger;
    private ENTERPRISE.UI.UITextMeshProUGUI pIdolLvText;
    private PRISM.Interactions.StarsStateView starsView;
    private ENTERPRISE.UI.UITextMeshProUGUI awakeningLvText;
    private ENTERPRISE.UI.UITextMeshProUGUI[] idolParameterTexts;
    private PRISM.Interactions.ViewStateChanger[] idolParameterTextColorStateChangers;
    private ENTERPRISE.UI.UITextMeshProUGUI totalIdolParameterText;
    private ENTERPRISE.UI.UITextMeshProUGUI liveSkillText;
    private ENTERPRISE.UI.UITextMeshProUGUI liveCenterEffectText;
    private UnityEngine.GameObject upperLabelEventBonusObject;
    private UniRx.CompositeDisposable disposables;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    private int dataIndex;
    public void Initialize(PRISM.Interactions.CharacterSelectClickObservableInt context);
    public Cysharp.Threading.Tasks.UniTask UpdateViewAsync(PRISM.Adapters.ListProduceIdolIconViewModel vm, int dataIndex, System.Threading.CancellationToken ct);

    private class <>c__DisplayClass16_0
    {
        public PRISM.Interactions.ProduceIdolIconViewWithSwitchInfo <>4__this;
        public PRISM.Interactions.CharacterSelectClickObservableInt context;
        private void <Initialize>b__0(int state);
        private void <Initialize>b__1(PRISM.Definitions.SortType sortType);
        private void <Initialize>b__2(UniRx.Unit _);
        private void <Initialize>b__3(UniRx.Unit _);
    }

    private class <>c__DisplayClass17_0
    {
        public PRISM.Interactions.ProduceIdolIconViewWithSwitchInfo <>4__this;
        public System.Threading.CancellationToken ct;
        private void <UpdateViewAsync>b__0(int id);
    }
}

// Namespace: PRISM.Interactions
public class ProduceIdolIconWithStarParameter : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ProduceIdolIconView iconView;
    private ENTERPRISE.UI.UITextMeshProUGUI parameterText;
    private PRISM.Interactions.StarsStateView starsView;
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, int mstProduceIdolId, UniRx.IReadOnlyReactiveProperty<PRISM.Definitions.IdolParameter> parameter, int currentStarLevel, System.Threading.CancellationToken ct);
    private void <SetupAsync>b__3_0(PRISM.Definitions.IdolParameter p);
}

// Namespace: PRISM.Interactions
public class ProduceIdolIconListView : UnityEngine.MonoBehaviour, PRISM.Adapters.IProduceIdolIconListView
{
    private PRISM.Interactions.ProduceIdolEnhancedGridView gridView;
    private PRISM.Interactions.SortFilterView sortFilterView;
    private PRISM.Interactions.ButtonView displaySwitchingButton;
    private ENTERPRISE.UI.UITextMeshProUGUI displaySwitchingText;
    private UniRx.Subject<int> onSelectIndexSubject;
    private UniRx.Subject<int> onDetailSubject;
    private System.IDisposable onClickDisposable;
    private System.IDisposable onLongPressDisposable;
    public System.IObservable<int> OnSelectIndex { get; set; }
    public System.IObservable<int> OnDetail { get; set; }
    public PRISM.Adapters.ISortFilterView SortFilterView { get; set; }
    public void Setup(PRISM.Adapters.ProduceIdolIconListModel model, PRISM.ResourceManagement.IResourceLoader resourceLoader, int firstViewTargetId);
    private void _setChangeDisplaySwitching(PRISM.Adapters.ProduceIdolIconListModel model, UniRx.IReactiveProperty<int> currentIndex, int maxDisplaySwitchingCount);
    private void OnDestroy();
    private void <Setup>b__14_0(System.ValueTuple<System.Collections.Generic.IReadOnlyList<PRISM.Adapters.ListProduceIdolIconViewModel>, PRISM.Definitions.SortType> x);
    private void <Setup>b__14_1(int index);
    private void <Setup>b__14_2(int index);

    private class <>c__DisplayClass15_0
    {
        public UniRx.IReactiveProperty<int> currentIndex;
        public int maxDisplaySwitchingCount;
        public PRISM.Adapters.ProduceIdolIconListModel model;
        public PRISM.Interactions.ProduceIdolIconListView <>4__this;
        private void <_setChangeDisplaySwitching>b__0(UniRx.Unit _);
        private void <_setChangeDisplaySwitching>b__1(int index);
    }
}

// Namespace: PRISM.Interactions
public class ProduceIdolSelectionConnector : PRISM.Interactions.CharacterViewConnector<PRISM.Adapters.ProduceIdolSelectionArgument>, PRISM.Legacy.IProduceIdolSelectionConnector
{
    protected PRISM.Adapters.ProduceIdolSelectionArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
}

// Namespace: PRISM.Interactions
public class ProduceIdolSelectionView : UnityEngine.MonoBehaviour, PRISM.Adapters.IProduceIdolSelectionView
{
    private PRISM.Interactions.ToggleGroupView toggleGroup;
    private PRISM.Interactions.ProduceIdolIconListView iconListView;
    private PRISM.Interactions.PieceArchiveView pieceArchiveView;
    private PRISM.Interactions.Character.PIdolUpgradingButtonView upgradingButtonView;
    public PRISM.Adapters.IProduceIdolIconListView IconListView { get; set; }
    public PRISM.Adapters.IPieceArchiveView PieceArchiveView { get; set; }
    public PRISM.Adapters.IPIdolUpgradingButtonView UpgradingButtonView { get; set; }
    public void Setup(UniRx.IReactiveProperty<int> tabSelectedIndex);
}

// Namespace: PRISM.Interactions
public class AwakeningLvSelector : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI awakeningLv;
    private PRISM.Interactions.ButtonView upButton;
    private PRISM.Interactions.ButtonView downButton;
    public void Setup(PRISM.Adapters.LevelSelectorViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<bool, bool> <>9__3_0;
        private bool <Setup>b__3_0(bool x);
    }

    private class <>c__DisplayClass3_0
    {
        public PRISM.Interactions.AwakeningLvSelector <>4__this;
        public PRISM.Adapters.LevelSelectorViewModel viewModel;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private void <Setup>b__1(bool _);
        private void <Setup>b__2(UniRx.Unit _);
        private void <Setup>b__3(UniRx.Unit _);
        private void <Setup>b__4(int lv);
        private void <Setup>b__5(PRISM.UI.LvRange x);
    }
}

// Namespace: PRISM.Interactions
public class AwakeningPerformanceView : UnityEngine.MonoBehaviour, PRISM.Adapters.IAwakeningPerformanceView, System.IDisposable
{
    private PRISM.Interactions.ButtonView button;
    private UnityEngine.Transform trCharaImageParent;
    private UnityEngine.Animator performanceAnimator;
    private UnityEngine.UI.Image colorBg;
    private ENTERPRISE.UI.UITextMeshProUGUI txtBeforeLv;
    private ENTERPRISE.UI.UITextMeshProUGUI txtAfterLv;
    private PRISM.Interactions.IdolLvExperienceGainView idolLvExperienceGainView;
    private PRISM.Adapters.AwakeningPerformanceViewModel vm;
    private UniRx.Subject<UniRx.Unit> onClose;
    private System.Threading.CancellationToken ct;
    private string[] additionalLoadedCueSheets;
    private PRISM.Definitions.MstOutgameVoiceMotion voiceMotion;
    public System.IObservable<UniRx.Unit> OnClose { get; set; }
    private void Awake();
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Adapters.AwakeningPerformanceViewModel _vm, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken _ct);
    public void Play();
    public void PlaySE1();
    public void PlayEnd();
    public void Dispose();
    private Cysharp.Threading.Tasks.UniTask _loadAlignedFaceIdolAsync(int produceIdolId, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private Cysharp.Threading.Tasks.UniTask _loadCueSheetsAsync(System.Collections.Generic.IEnumerable<string> requiredCueSheets);

    private class <>c
    {
        public static <>c <>9;
        public static System.Action<UniRx.Unit> <>9__15_0;
        private void <SetupAsync>b__15_0(UniRx.Unit _);
    }

    private class <>c__DisplayClass15_0
    {
        public PRISM.Interactions.AwakeningPerformanceView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private Cysharp.Threading.Tasks.UniTask <SetupAsync>g__PrepareAfterOnOkButtonAsync|1();
        private void <SetupAsync>b__4(UniRx.Unit _);
        private void <SetupAsync>b__5(UniRx.Unit _);
        private void <SetupAsync>b__2(UniRx.Unit _);
        private void <SetupAsync>b__3(UniRx.Unit _);
    }

    private struct <_loadAlignedFaceIdolAsync>d__20 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public int produceIdolId;
        public PRISM.Interactions.AwakeningPerformanceView <>4__this;
        private Awaiter<UnityEngine.GameObject> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_loadCueSheetsAsync>d__21 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public System.Collections.Generic.IEnumerable<string> requiredCueSheets;
        public PRISM.Interactions.AwakeningPerformanceView <>4__this;
        private Awaiter<string[]> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class IdolLvExperienceGainView : UnityEngine.MonoBehaviour, System.IDisposable
{
    private PRISM.Interactions.IdolBaseRewardIdolView idolView;
    private UnityEngine.Animator baseViewAnimator;
    private UnityEngine.Animator idolViewAnimator;
    private PRISM.Interactions.ViewStateChanger enterStateChanger;
    private PRISM.Interactions.ButtonView skipAnimationButton;
    private PRISM.Interactions.ButtonView nextButton;
    private System.Threading.CancellationTokenSource cts;
    private PRISM.Module.Networking.IIdolBaseRewardStatus reward;
    private PRISM.Adapters.IdolBaseRewardIdolViewModel idolViewModel;
    private bool isSkip;
    public System.IObservable<UniRx.Unit> OnClose { get; set; }
    private void Awake();
    public Cysharp.Threading.Tasks.UniTask PrepareAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, PRISM.Module.Networking.IIdolBaseRewardStatus _reward);
    public Cysharp.Threading.Tasks.UniTask EnterAsync();
    public void Dispose();
    private Cysharp.Threading.Tasks.UniTask _enterAsync();
    private void _skipAnimators();
    private void <get_OnClose>b__11_0(UniRx.Unit _);
    private void <Awake>b__12_0(UniRx.Unit _);
    private Cysharp.Threading.Tasks.UniTask <_enterAsync>g__AnimateAsync|16_0(float duration, System.Threading.CancellationToken cancellationToken);

    private struct <EnterAsync>d__14 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.IdolLvExperienceGainView <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_enterAsync>d__16 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.IdolLvExperienceGainView <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class IdolSkillListView : UnityEngine.MonoBehaviour
{
    private UnityEngine.Transform parent;
    private PRISM.Interactions.IdolSkillLvUpListContentView skillViewPrefab;
    private System.Collections.Generic.List<PRISM.Interactions.IdolSkillLvUpListContentView> list;
    private UniRx.Subject<int> openIdolSkillDetailSubject;
    private System.IDisposable disposable;
    public System.IObservable<int> OpenIdolSkillDetail { get; set; }
    public void Setup(PRISM.Adapters.IdolSkillLvUpListContentViewModel[] idolSkills, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private void OnDestroy();
    private void <Setup>b__7_1(int skillId);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Interactions.IdolSkillLvUpListContentView, System.IObservable<int>> <>9__7_0;
        private System.IObservable<int> <Setup>b__7_0(PRISM.Interactions.IdolSkillLvUpListContentView x);
    }
}

// Namespace: PRISM.Interactions
public class IdolSkillLvSelector : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI skillLv;
    private PRISM.Interactions.ButtonView upButton;
    private PRISM.Interactions.ButtonView downButton;
    public void Setup(PRISM.Adapters.LevelSelectorViewModel viewModel);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<bool, bool> <>9__3_0;
        private bool <Setup>b__3_0(bool x);
    }

    private class <>c__DisplayClass3_0
    {
        public PRISM.Interactions.IdolSkillLvSelector <>4__this;
        public PRISM.Adapters.LevelSelectorViewModel viewModel;
        private void <Setup>b__1(bool _);
        private void <Setup>b__2(UniRx.Unit _);
        private void <Setup>b__3(UniRx.Unit _);
        private void <Setup>b__4(int lv);
        private void <Setup>b__5(PRISM.UI.LvRange x);
    }
}

// Namespace: PRISM.Interactions
public class IdolSkillLvUpDetailContentView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView contentBaseButton;
    private PRISM.UI.IdolSkillIconView skillIconView;
    private PRISM.VoDaViMeMultiView voDaViMeMultiView;
    private ENTERPRISE.UI.UITextMeshProUGUI skillNameText;
    private ENTERPRISE.UI.UITextMeshProUGUI beforeCostText;
    private ENTERPRISE.UI.UITextMeshProUGUI beforeSkillDetailText;
    private ENTERPRISE.UI.UITextMeshProUGUI afterCostText;
    private ENTERPRISE.UI.UITextMeshProUGUI afterSkillDetailText;
    private PRISM.Interactions.TMPKeyWordTouchDetector beforeKeyWordTouchDetector;
    private PRISM.Interactions.TMPKeyWordTouchDetector afterKeyWordTouchDetector;
    public void Setup(PRISM.Adapters.IdolSkillViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<string, int> <>9__10_6;
        public static System.Func<PRISM.Adapters.IdolSkillLvUpListContentViewModel, bool> <>9__10_2;
        private int <Setup>b__10_6(string x);
        private bool <Setup>b__10_2(PRISM.Adapters.IdolSkillLvUpListContentViewModel x);
    }

    private class <>c__DisplayClass10_0
    {
        public PRISM.Adapters.IdolSkillViewModel viewModel;
        public PRISM.Interactions.IdolSkillLvUpDetailContentView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private void <Setup>b__0(UniRx.Unit _);
        private void <Setup>b__1(System.ValueTuple<int, TMPro.TMP_TextInfo> info);
        private void <Setup>b__3(PRISM.Adapters.IdolSkillLvUpListContentViewModel vm);
        private void <Setup>b__4(System.ValueTuple<int, string> t);
        private void <Setup>b__5(System.ValueTuple<int, string> t);
    }
}

// Namespace: PRISM.Interactions
public class IdolSkillLvUpListContentView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.ButtonView contentBaseButton;
    private PRISM.UI.IdolSkillIconView skillIconView;
    private PRISM.VoDaViMeMultiView voDaViMeMultiView;
    private ENTERPRISE.UI.UITextMeshProUGUI skillNameText;
    private UnityEngine.GameObject lockObject;
    private ENTERPRISE.UI.UITextMeshProUGUI lockText;
    private UnityEngine.GameObject buttonImageObject;
    private UnityEngine.UI.Image maskImage;
    private System.IObservable<int> <OnOpen>k__BackingField;
    public System.IObservable<int> OnOpen { get; set; }
    public void Setup(PRISM.Adapters.IdolSkillLvUpListContentViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader, bool showButton);

    private class <>c__DisplayClass12_0
    {
        public PRISM.Adapters.IdolSkillLvUpListContentViewModel viewModel;
        public PRISM.Interactions.IdolSkillLvUpListContentView <>4__this;
        public bool showButton;
        private int <Setup>b__0(UniRx.Unit _);
        private void <Setup>b__1(bool b);
    }
}

// Namespace: PRISM.Interactions
public class IdolSkillLvView : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI beforeText;
    private UnityEngine.GameObject afterAreaObject;
    private ENTERPRISE.UI.UITextMeshProUGUI afterText;
    public void Setup(PRISM.Adapters.IdolSkillLvViewModel vm);
    private void <Setup>b__3_0(int lv);
    private void <Setup>b__3_1(int lv);
}

// Namespace: PRISM.Interactions
public class LiveSkillLvView : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.RawImage iconImage;
    private ENTERPRISE.UI.UITextMeshProUGUI skillNameText;
    private ENTERPRISE.UI.UITextMeshProUGUI beforeLvText;
    private UnityEngine.GameObject afterLvAreaObject;
    private ENTERPRISE.UI.UITextMeshProUGUI afterLvText;
    private ENTERPRISE.UI.UITextMeshProUGUI descriptionText;
    public void Setup(PRISM.Adapters.LiveSkillLvViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<int, bool> <>9__6_2;
        private bool <Setup>b__6_2(int x);
    }

    private class <>c__DisplayClass6_0
    {
        public PRISM.Interactions.LiveSkillLvView <>4__this;
        public PRISM.Adapters.LiveSkillLvViewModel viewModel;
        private void <Setup>b__0(int lv);
        private void <Setup>b__1(int lv);
        private void <Setup>b__3(int lvId);
    }
}

// Namespace: PRISM.Interactions
public class OtherBonusContentView : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI text;
    private ENTERPRISE.UI.UITextMeshProUGUI beforeText;
    private UnityEngine.GameObject afterAreaObject;
    private ENTERPRISE.UI.UITextMeshProUGUI afterText;
    private UnityEngine.GameObject newDressObject;
    private UnityEngine.GameObject newDressOrangeTextObject;
    private UnityEngine.GameObject newDressRainbowTextObject;
    private ENTERPRISE.UI.UITextMeshProUGUI newDressBlackTextObject;
    public void Setup(PRISM.Adapters.OtherBonusContentViewModel vm);
    public void SetVisible(bool isActive);
    private static string _getText(int id);
    private void <Setup>b__8_2(PRISM.Adapters.OtherBonusReleasedCostumeType type);
    private void <Setup>b__8_4(PRISM.Adapters.OtherBonusReleasedCostumeType type);
    private void <Setup>b__8_0(bool b);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Adapters.OtherBonusReleasedCostumeType, bool> <>9__8_1;
        public static System.Func<PRISM.Adapters.OtherBonusReleasedCostumeType, bool> <>9__8_3;
        private bool <Setup>b__8_1(PRISM.Adapters.OtherBonusReleasedCostumeType x);
        private bool <Setup>b__8_3(PRISM.Adapters.OtherBonusReleasedCostumeType x);
    }
}

// Namespace: PRISM.Interactions
public class OtherBonusView : UnityEngine.MonoBehaviour
{
    private UnityEngine.Transform contentParent;
    private UnityEngine.GameObject contentPrefab;
    public void Setup(PRISM.Adapters.OtherBonusViewModel vm);
}

// Namespace: PRISM.Interactions
public class PITrainingPerformanceView : UnityEngine.MonoBehaviour, PRISM.Adapters.IPITrainingPerformanceView, System.IDisposable
{
    private PRISM.Interactions.ButtonView button;
    private UnityEngine.Transform trCharaImageParent;
    private UnityEngine.Animator performanceAnimator;
    private UnityEngine.UI.Image colorBg;
    private UnityEngine.GameObject[] beforeStarObjs;
    private UnityEngine.GameObject[] afterStarObjs;
    private PRISM.Interactions.IdolLvExperienceGainView idolLvExperienceGainView;
    private PRISM.Adapters.PITrainingPerformanceViewModel vm;
    private UniRx.Subject<UniRx.Unit> onClose;
    private System.Threading.CancellationToken ct;
    private string[] additionalLoadedCueSheets;
    private PRISM.Definitions.MstOutgameVoiceMotion voiceMotion;
    public System.IObservable<UniRx.Unit> OnClose { get; set; }
    private void Awake();
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Adapters.PITrainingPerformanceViewModel _vm, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken _ct);
    public void Play();
    public void PlaySE1();
    public void PlayEnd();
    public void GetStarAnimationTrigger();
    public void Dispose();
    private Cysharp.Threading.Tasks.UniTask _loadAlignedFaceIdolAsync(int produceIdolId, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private Cysharp.Threading.Tasks.UniTask _loadCueSheetsAsync(System.Collections.Generic.IEnumerable<string> requiredCueSheets);
    private Cysharp.Threading.Tasks.UniTaskVoid <GetStarAnimationTrigger>g__voidAsync|19_0();

    private struct <<GetStarAnimationTrigger>g__voidAsync|19_0>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
        public PRISM.Interactions.PITrainingPerformanceView <>4__this;
        private int <i>5__2;
        private Awaiter<bool> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private class <>c
    {
        public static <>c <>9;
        public static System.Action<UniRx.Unit> <>9__15_0;
        private void <SetupAsync>b__15_0(UniRx.Unit _);
    }

    private class <>c__DisplayClass15_0
    {
        public PRISM.Interactions.PITrainingPerformanceView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken _ct;
        private Cysharp.Threading.Tasks.UniTask <SetupAsync>g__PrepareAfterOnOkButtonAsync|1();
        private void <SetupAsync>b__4(UniRx.Unit _);
        private void <SetupAsync>b__5(UniRx.Unit _);
        private void <SetupAsync>b__2(UniRx.Unit _);
        private void <SetupAsync>b__3(UniRx.Unit _);
    }

    private struct <_loadAlignedFaceIdolAsync>d__21 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public int produceIdolId;
        public PRISM.Interactions.PITrainingPerformanceView <>4__this;
        private Awaiter<UnityEngine.GameObject> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_loadCueSheetsAsync>d__22 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public System.Collections.Generic.IEnumerable<string> requiredCueSheets;
        public PRISM.Interactions.PITrainingPerformanceView <>4__this;
        private Awaiter<string[]> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class ProduceIdolAwakeningView : UnityEngine.MonoBehaviour, PRISM.Adapters.IProduceIdolAwakeningView
{
    private PRISM.Interactions.ViewStateChanger displayTypeViewStateChanger;
    private ENTERPRISE.UI.UITextMeshProUGUI pIdolLvBeforeLevelText;
    private ENTERPRISE.UI.UITextMeshProUGUI pIdolLvAfterLevelText;
    private UnityEngine.GameObject pIdolLvAfterArea;
    private PRISM.Interactions.IdolSkillListView idolSkillListView;
    private UnityEngine.GameObject normalAreaRootObject;
    private PRISM.Interactions.AwakeningLvSelector awakeningLvSelector;
    private PRISM.Interactions.ItemPager itemPager;
    private PRISM.Interactions.ButtonView howToGetItemsButton;
    private ENTERPRISE.UI.UITextMeshProUGUI requiredMoneyText;
    private ENTERPRISE.UI.UITextMeshProUGUI moneyText;
    private UnityEngine.GameObject alertObject;
    private ENTERPRISE.UI.UITextMeshProUGUI alertText;
    private UnityEngine.GameObject maxAreaRootObject;
    private PRISM.Interactions.ButtonView executeButton;
    private PRISM.Adapters.ProduceIdolAwakeningViewModel viewModel;
    public System.IObservable<int> OpenIdolSkillDetail { get; set; }
    public void Setup(PRISM.Adapters.ProduceIdolAwakeningViewModel vm, PRISM.Adapters.IdolSkillLvUpListContentViewModel[] idolSkills, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void UpdateListView(PRISM.Adapters.IdolSkillLvUpListContentViewModel[] idolSkills, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void OnEnable();
    public void OnDisable();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<bool, bool> <>9__18_7;
        private bool <Setup>b__18_7(bool x);
    }

    private class <>c__DisplayClass18_0
    {
        public PRISM.Interactions.ProduceIdolAwakeningView <>4__this;
        public PRISM.Adapters.ProduceIdolAwakeningViewModel vm;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private void <Setup>b__0(int lv);
        private void <Setup>b__1(int lv);
        private void <Setup>b__2(int displayType);
        private void <Setup>b__3(int pages);
        private void <Setup>b__4(long x);
        private void <Setup>b__5(long x);
        private void <Setup>b__6(PRISM.UI.InsufficientReasonType reasonType);
        private void <Setup>b__8(bool _);
        private void <Setup>b__9(UniRx.Unit _);
        private void <Setup>b__10(UniRx.Unit _);
        private void <Setup>g__SetupItemPager|11();
        private void <Setup>g__SetMoneyFontColor|12();
        private void <Setup>g__SwitchAreaObject|13(bool maxLv);
    }
}

// Namespace: PRISM.Interactions
public class ProduceIdolPIdolLvView : UnityEngine.MonoBehaviour, PRISM.Adapters.IProduceIdolPIdolLvView
{
    private PRISM.Interactions.LevelUpView levelUpView;
    private PRISM.Interactions.StatusUpView statusUpView;
    private PRISM.Interactions.AdditionalLvSelector additionalLvSelector;
    private PRISM.Interactions.TicketSelector[] ticketSelectors;
    private PRISM.Interactions.ButtonView resetButton;
    private PRISM.Interactions.ButtonView optimalChoiceButton;
    private PRISM.Interactions.ButtonView executeButton;
    private UnityEngine.GameObject normalAreaRootObject;
    private UnityEngine.GameObject maxAreaRootObject;
    private UnityEngine.GameObject lvMaxSubTextObject;
    private PRISM.Adapters.ProduceIdolPIdolLvViewModel viewModel;
    public System.IObservable<PRISM.UI.LvTicketSelectorButtonType> OnLvButton { get; set; }
    public System.IObservable<System.ValueTuple<PRISM.UI.LvTicketSelectorButtonType, int>> OnTicketButton { get; set; }
    public System.IObservable<UniRx.Unit> Reset { get; set; }
    public System.IObservable<UniRx.Unit> OptimalChoice { get; set; }
    public System.IObservable<UniRx.Unit> LvUpAnimationEnd { get; set; }
    public void Setup(PRISM.Adapters.ProduceIdolPIdolLvViewModel vm, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void OnDisable();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Interactions.TicketSelector, System.IObservable<System.ValueTuple<PRISM.UI.LvTicketSelectorButtonType, int>>> <>9__14_0;
        private System.IObservable<System.ValueTuple<PRISM.UI.LvTicketSelectorButtonType, int>> <get_OnTicketButton>b__14_0(PRISM.Interactions.TicketSelector x);
    }

    private class <>c__DisplayClass21_0
    {
        public PRISM.Interactions.ProduceIdolPIdolLvView <>4__this;
        public PRISM.Adapters.ProduceIdolPIdolLvViewModel vm;
        private void <Setup>b__0(PRISM.Adapters.PIdolLvUpViewMaxLvType maxLvType);
        private void <Setup>b__1(bool b);
        private void <Setup>b__2(bool b);
        private void <Setup>b__3(bool b);
        private void <Setup>b__4(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions
public class ProduceIdolSkillLvUpListView : UnityEngine.MonoBehaviour
{
    private UnityEngine.Transform listParent;
    private PRISM.Interactions.IdolSkillLvUpListContentView idolSkillContentViewPrefab;
    private PRISM.Interactions.IdolSkillLvUpDetailContentView skillDetailView;
    private PRISM.Interactions.ViewStateChanger listDetailSwitcher;
    private UniRx.CompositeDisposable disposables;
    private System.Collections.Generic.List<PRISM.Interactions.IdolSkillLvUpListContentView> list;
    private PRISM.ResourceManagement.IResourceLoader loader;
    public void Setup(PRISM.Adapters.IdolSkillViewModel viewModel, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void ReloadSkillList(PRISM.Adapters.IdolSkillViewModel viewModel);
    private void OnDestroy();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Interactions.IdolSkillLvUpListContentView, System.IObservable<int>> <>9__8_1;
        private System.IObservable<int> <ReloadSkillList>b__8_1(PRISM.Interactions.IdolSkillLvUpListContentView x);
    }

    private class <>c__DisplayClass8_0
    {
        public PRISM.Interactions.ProduceIdolSkillLvUpListView <>4__this;
        public PRISM.Adapters.IdolSkillViewModel viewModel;
        private void <ReloadSkillList>b__0(bool b);
        private void <ReloadSkillList>b__2(int skillId);
    }
}

// Namespace: PRISM.Interactions
public class ProduceIdolSkillView : UnityEngine.MonoBehaviour, PRISM.Adapters.IProduceIdolSkillView
{
    private PRISM.Interactions.ProduceIdolSkillLvUpListView skillLvUpListView;
    private UnityEngine.GameObject normalAreaRootObject;
    private PRISM.Interactions.IdolSkillLvSelector idolSkillLvSelector;
    private PRISM.Interactions.ItemPager itemPager;
    private PRISM.Interactions.ButtonView howToGetItemsButton;
    private ENTERPRISE.UI.UITextMeshProUGUI requiredMoneyText;
    private ENTERPRISE.UI.UITextMeshProUGUI moneyText;
    private UnityEngine.GameObject alertObject;
    private ENTERPRISE.UI.UITextMeshProUGUI alertText;
    private UnityEngine.GameObject maxAreaRootObject;
    private PRISM.Interactions.ButtonView executeButton;
    private PRISM.Adapters.IdolSkillViewModel viewViewModel;
    public void Setup(PRISM.Adapters.IdolSkillViewModel vm, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void UpdateListView(PRISM.Adapters.IdolSkillViewModel vm);
    public void OnEnable();
    public void OnDisable();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<bool, bool> <>9__12_4;
        private bool <Setup>b__12_4(bool x);
    }

    private class <>c__DisplayClass12_0
    {
        public PRISM.Interactions.ProduceIdolSkillView <>4__this;
        public PRISM.Adapters.IdolSkillViewModel vm;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private void <Setup>b__0(int pages);
        private void <Setup>b__1(long x);
        private void <Setup>b__2(long x);
        private void <Setup>b__3(System.ValueTuple<PRISM.UI.InsufficientReasonType, string> t);
        private void <Setup>b__5(bool _);
        private void <Setup>b__6(UniRx.Unit _);
        private void <Setup>b__7(UniRx.Unit _);
        private void <Setup>g__SetupItemPager|8();
        private void <Setup>g__SetMoneyFontColor|9();
        private void <Setup>g__SwitchAreaObject|10(bool maxLv);
    }
}

// Namespace: PRISM.Interactions
public class ProduceIdolTrainingView : UnityEngine.MonoBehaviour, PRISM.Adapters.IProduceIdolTrainingView
{
    private PRISM.Interactions.StatusUpView statusUpView;
    private PRISM.Interactions.LiveSkillLvView liveSkillLvView;
    private PRISM.Interactions.IdolSkillLvView idolSkillLvView;
    private PRISM.Interactions.OtherBonusView otherBonusView;
    private PRISM.Interactions.ViewStateChanger liveProduceViewStateChanger;
    private UnityEngine.GameObject normalAreaRootObject;
    private PRISM.Interactions.TrainingLvSelector trainingLvSelector;
    private PRISM.Interactions.PieceIconView pieceIconView;
    private PRISM.Interactions.PieceGaugeView pieceGaugeView;
    private PRISM.Interactions.ButtonView pieceExchangeButton;
    private UnityEngine.GameObject alertObject;
    private UnityEngine.GameObject maxAreaRootObject;
    private PRISM.Interactions.ButtonView executeButton;
    private PRISM.Adapters.ProduceIdolTrainingViewModel viewModel;
    public void Setup(PRISM.Adapters.ProduceIdolTrainingViewModel vm, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void OnEnable();
    public void OnDisable();
    private void _setData();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<bool, bool> <>9__14_3;
        private bool <Setup>b__14_3(bool x);
    }

    private class <>c__DisplayClass14_0
    {
        public PRISM.Interactions.ProduceIdolTrainingView <>4__this;
        public PRISM.Adapters.ProduceIdolTrainingViewModel vm;
        private void <Setup>b__0(int type);
        private void <Setup>b__1(System.ValueTuple<long, int> x);
        private void <Setup>b__2(PRISM.UI.InsufficientReasonType reasonType);
        private void <Setup>b__4(bool _);
        private void <Setup>b__5(UniRx.Unit _);
        private void <Setup>b__6(UniRx.Unit _);
        private void <Setup>g__SwitchAreaObject|7(bool maxLv);
    }
}

// Namespace: PRISM.Interactions
public class ProduceIdolUpgradingConnector : PRISM.Interactions.CharacterViewConnector<PRISM.Adapters.ProduceIdolUpgradingArgument>, PRISM.IProduceIdolUpgradingConnector
{
    protected PRISM.Adapters.ProduceIdolUpgradingArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
}

// Namespace: PRISM.Interactions
public class ProduceIdolUpgradingUICharacterView : UnityEngine.MonoBehaviour, PRISM.Adapters.IProduceIdolUpgradingUICharacterView
{
    private PRISM.UI.UICharacterViewer uiCharacterViewer;
    private PRISM.UI.CenteringObjectsOutsideSafeArea characterPositionAdjuster;
    public void Inject(System.Func<bool> isOverlayShowFunc);
    public Cysharp.Threading.Tasks.UniTask Setup3DCharaAsync(PRISM.UI.UICharacterVoiceInfo voiceInfo, System.Threading.CancellationToken ct);
    public void PausePlayingVoiceMotion();
    public void OnNextViewPreparation();
    public Cysharp.Threading.Tasks.UniTask ReleaseAsync();
}

// Namespace: PRISM.Interactions
public class ProduceIdolUpgradingView : UnityEngine.MonoBehaviour, PRISM.Adapters.IProduceIdolUpgradingView
{
    private UnityEngine.UI.Image charaColorBackgroundImage;
    private UnityEngine.UI.RawImage favoriteImage;
    private PRISM.Interactions.ButtonView favoriteButton;
    private PRISM.Interactions.ButtonView detailButton;
    private ENTERPRISE.UI.UITextMeshProUGUI idolAliasText;
    private ENTERPRISE.UI.UITextMeshProUGUI idolNameText;
    private ENTERPRISE.UI.UITextMeshProUGUI pIdolLvText;
    private ENTERPRISE.UI.UITextMeshProUGUI awakeningLvText;
    private PRISM.Interactions.ViewStateChanger starsViewStateChanger;
    private PRISM.Interactions.AttributeIconView attributeIconView;
    private UnityEngine.Transform performanceAreaParent;
    private PRISM.UI.PerformanceFader performanceFader;
    private PRISM.Interactions.ToggleGroupView displayTabGroup;
    private PRISM.Interactions.ToggleGroupView upgradingTabGroup;
    private ENTERPRISE.UI.UITextMeshProUGUI[] upgradingTabGroupText;
    private PRISM.Interactions.ViewStateChanger panelGroupViewStateChanger;
    private UnityEngine.GameObject[] tabBadges;
    private PRISM.Interactions.ViewStateChanger badgesViewStateChanger;
    private PRISM.HowToPlayPopupOpener howToPlay;
    private PRISM.HowToPlayPopupOpener liveOnlyHowToPlay;
    private PRISM.ResourceManagement.IResourceLoader resourceLoader;
    private UnityEngine.GameObject awakeningPerformanceObj;
    private UnityEngine.GameObject piTrainingPerformanceObj;
    private ProduceIdolType produceIdolType;
    public PRISM.HowToPlayPopupOpener HowToPlay { get; set; }
    public void Setup(PRISM.Adapters.ProduceIdolUpgradingViewModel viewModel, UniRx.ReactiveProperty<int> displayType, UniRx.ReactiveProperty<int> tabType, ProduceIdolType produceIdolType, UniRx.IReadOnlyReactiveProperty<PRISM.Adapters.BitProduceIdolUpgradingViewTabBadgeType> tabBadge, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public Cysharp.Threading.Tasks.UniTask<PRISM.Adapters.IAwakeningPerformanceView> CreateAwakeningPerformanceViewAsync(System.Threading.CancellationToken ct);
    public void DisposeAwakeningPerformanceView();
    public Cysharp.Threading.Tasks.UniTask<PRISM.Adapters.IPITrainingPerformanceView> CreateTrainingPerformanceViewAsync(System.Threading.CancellationToken ct);
    public void DisposeTrainingPerformanceView();
    public Cysharp.Threading.Tasks.UniTask FadeInPerformanceAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask FadeOutPerformanceAsync(System.Threading.CancellationToken ct);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<int, bool> <>9__26_3;
        private bool <Setup>b__26_3(int x);
    }

    private class <>c__DisplayClass26_0
    {
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public PRISM.Interactions.ProduceIdolUpgradingView <>4__this;
        public PRISM.Adapters.ProduceIdolUpgradingViewModel viewModel;
        public UniRx.ReactiveProperty<int> tabType;
        public UniRx.ReactiveProperty<int> displayType;
        private void <Setup>b__0(int id);
        private void <Setup>b__1(int lv);
        private void <Setup>b__2(int lv);
        private void <Setup>b__4(int lv);
        private void <Setup>b__5(UniRx.Unit _);
        private void <Setup>b__6(UniRx.Unit _);
        private void <Setup>b__7(PRISM.Adapters.BitProduceIdolUpgradingViewTabBadgeType bit);
        private void <Setup>b__8(int index);
        private void <Setup>b__9(int index);
    }

    private struct <CreateAwakeningPerformanceViewAsync>d__27 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<PRISM.Adapters.IAwakeningPerformanceView> <>t__builder;
        public PRISM.Interactions.ProduceIdolUpgradingView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter<UnityEngine.GameObject> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <CreateTrainingPerformanceViewAsync>d__29 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<PRISM.Adapters.IPITrainingPerformanceView> <>t__builder;
        public PRISM.Interactions.ProduceIdolUpgradingView <>4__this;
        public System.Threading.CancellationToken ct;
        private Awaiter<UnityEngine.GameObject> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class TrainingLvSelector : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.StarsStateView stars;
    private PRISM.Interactions.ButtonView upButton;
    private PRISM.Interactions.ButtonView downButton;
    public void Setup(PRISM.Adapters.LevelSelectorViewModel viewModel);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<bool, bool> <>9__3_0;
        private bool <Setup>b__3_0(bool x);
    }

    private class <>c__DisplayClass3_0
    {
        public PRISM.Interactions.TrainingLvSelector <>4__this;
        public PRISM.Adapters.LevelSelectorViewModel viewModel;
        private void <Setup>b__1(bool _);
        private void <Setup>b__2(UniRx.Unit _);
        private void <Setup>b__3(UniRx.Unit _);
        private void <Setup>b__4(int lv);
        private void <Setup>b__5(PRISM.UI.LvRange x);
    }
}

// Namespace: PRISM.Interactions
public class RequiredItemIconGroup : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.RequiredItemIconView[] iconViews;
    public System.Collections.Generic.IEnumerable<PRISM.Interactions.RequiredItemIconView> IconViews { get; set; }
}

// Namespace: PRISM.Interactions
public class StatusUpElementView : UnityEngine.MonoBehaviour
{
    private ENTERPRISE.UI.UITextMeshProUGUI beforeText;
    private ENTERPRISE.UI.UITextMeshProUGUI afterText;
    private ENTERPRISE.UI.UITextMeshProUGUI upText;
    private int beforeValue;
    public void SetBefore(int value);
    public void SetAfter(int value);
}

// Namespace: PRISM.Interactions
public class StatusUpView : UnityEngine.MonoBehaviour
{
    private PRISM.Interactions.StatusUpElementView totalView;
    private PRISM.Interactions.StatusUpElementView vocalView;
    private PRISM.Interactions.StatusUpElementView danceView;
    private PRISM.Interactions.StatusUpElementView visualView;
    private PRISM.Interactions.StatusUpElementView mentalView;
    public void Setup(PRISM.Adapters.StatusUpViewModel vm);
    public void Setup(PRISM.Definitions.IdolParameter before, PRISM.Definitions.IdolParameter after);
    private void <Setup>b__5_0(PRISM.Definitions.IdolParameter x);
    private void <Setup>b__5_1(PRISM.Definitions.IdolParameter x);
}

// Namespace: PRISM.Interactions
public class SupportCharacterSelectIconView : UnityEngine.MonoBehaviour
{
    private PRISM.UI.SCharaIconRectView iconRectView;
    private PRISM.Interactions.ViewStateChanger displayChanger;
    private ENTERPRISE.UI.UITextMeshProUGUI voText;
    private ENTERPRISE.UI.UITextMeshProUGUI daText;
    private ENTERPRISE.UI.UITextMeshProUGUI viText;
    private ENTERPRISE.UI.UITextMeshProUGUI meText;
    private PRISM.Interactions.ViewStateChanger[] statusTextColorStateChangers;
    private ENTERPRISE.UI.UITextMeshProUGUI totalText;
    private ENTERPRISE.UI.UITextMeshProUGUI supportEffectText;
    public PRISM.UI.SCharaIconRectView IconRectView { get; set; }
    public void Setup(PRISM.Common.Model.SCharaIcon sCharaIcon);
    public void ChangeParameterTextColor(PRISM.Definitions.SortType sortType);
    public void ChangeDisplaySwitching(PRISM.UI.SupportCharaIconDisplayType displayType);
}

// Namespace: PRISM.Interactions
public class SupportCharaSelectionConnector : PRISM.Interactions.CharacterViewConnector<PRISM.Adapters.SupportCharaSelectionArgument>, PRISM.Legacy.ISupportCharaSelectionConnector
{
    protected PRISM.Adapters.SupportCharaSelectionArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
}

// Namespace: PRISM.Interactions
public class SupportCharaSelectionView : UnityEngine.MonoBehaviour, PRISM.Adapters.ISupportCharaSelectionView
{
    private PRISM.Interactions.ToggleGroupView toggleGroup;
    private PRISM.Interactions.SupportCharaListView charaListView;
    private PRISM.Interactions.PieceArchiveView pieceArchiveView;
    private PRISM.Interactions.Character.SCharaUpgradingButtonView upgradingButtonView;
    public PRISM.Adapters.ISupportCharaListView CharaListView { get; set; }
    public PRISM.Adapters.IPieceArchiveView PieceArchiveView { get; set; }
    public PRISM.Adapters.ISCharaUpgradingButtonView UpgradingButtonView { get; set; }
    public void Setup(UniRx.IReactiveProperty<int> tabSelectedIndex);
}

// Namespace: PRISM.Interactions
public class DiamondLvSelector : UnityEngine.MonoBehaviour, PRISM.Interactions.ILvSelector
{
    private PRISM.UI.DiamondDisplay diamond;
    private PRISM.Interactions.ButtonView upButton;
    private PRISM.Interactions.ButtonView downButton;
    public System.IObservable<UniRx.Unit> OnUp { get; set; }
    public System.IObservable<UniRx.Unit> OnDown { get; set; }
    public void SetMaxLv(int maxLv);
    public void UpdateData(PRISM.Adapters.LvSelectorViewModel vm);
    private void _setDisplay(PRISM.Adapters.LvSelectorViewModel vm);
}

// Namespace: PRISM.Interactions
public class MasterTrainingPerformanceView : UnityEngine.MonoBehaviour, PRISM.Adapters.IMasterTrainingPerformanceView, System.IDisposable
{
    private ENTERPRISE.UI.UIButton btn;
    private PRISM.UI.SCharaIconRectView sCharaIconRectView;
    private UnityEngine.Animator performanceAnimator;
    private UnityEngine.GameObject[] beforeDiaObjs;
    private UnityEngine.GameObject[] afterDiaObjs;
    private PRISM.Interactions.IdolLvExperienceGainView idolLvExperienceGainView;
    private PRISM.Adapters.MasterTrainingPerformanceViewModel vm;
    private UniRx.Subject<UniRx.Unit> onClose;
    private System.Threading.CancellationToken ct;
    private string[] additionalLoadedCueSheets;
    private PRISM.Definitions.MstOutgameVoiceMotion voiceMotion;
    public System.IObservable<UniRx.Unit> OnClose { get; set; }
    private void Awake();
    public Cysharp.Threading.Tasks.UniTask SetupAsync(PRISM.Adapters.MasterTrainingPerformanceViewModel _vm, PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken _ct);
    public void Play();
    public void PlaySE1();
    public void GetDiaAnimationTrigger();
    public void PlayEnd();
    public void Dispose();
    private Cysharp.Threading.Tasks.UniTask _loadCueSheetsAsync(System.Collections.Generic.IEnumerable<string> requiredCueSheets);
    private Cysharp.Threading.Tasks.UniTaskVoid <GetDiaAnimationTrigger>g__voidAsync|17_0();

    private struct <<GetDiaAnimationTrigger>g__voidAsync|17_0>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
        public PRISM.Interactions.MasterTrainingPerformanceView <>4__this;
        private int <i>5__2;
        private Awaiter<bool> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private class <>c
    {
        public static <>c <>9;
        public static System.Action<UniRx.Unit> <>9__14_0;
        private void <SetupAsync>b__14_0(UniRx.Unit _);
    }

    private class <>c__DisplayClass14_0
    {
        public PRISM.Interactions.MasterTrainingPerformanceView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken _ct;
        private Cysharp.Threading.Tasks.UniTask <SetupAsync>g__prepareAfterOKButtonAsync|1();
        private void <SetupAsync>b__4();
        private void <SetupAsync>b__5(UniRx.Unit _);
        private void <SetupAsync>b__2();
        private void <SetupAsync>b__3();
    }

    private struct <SetupAsync>d__14 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.MasterTrainingPerformanceView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken _ct;
        public PRISM.Adapters.MasterTrainingPerformanceViewModel _vm;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_loadCueSheetsAsync>d__20 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public System.Collections.Generic.IEnumerable<string> requiredCueSheets;
        public PRISM.Interactions.MasterTrainingPerformanceView <>4__this;
        private Awaiter<string[]> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class SupportCharaMasterTrainingView : UnityEngine.MonoBehaviour, PRISM.Adapters.ISupportCharaMasterTrainingView
{
    private PRISM.Interactions.ViewStateChanger maxStateChanger;
    private PRISM.Interactions.ButtonView pieceExchangeButton;
    private ENTERPRISE.UI.UITextMeshProUGUI txtRequiredPieceAmount;
    private ENTERPRISE.UI.UITextMeshProUGUI txtPieceAmount;
    private UnityEngine.UI.Image imgPieceFillColor;
    private UnityEngine.GameObject goAlert;
    private PRISM.Interactions.ButtonView executeButton;
    private PRISM.Interactions.DiamondLvSelector diamondLvSelector;
    private PRISM.Interactions.PieceIconView pieceIconView;
    private PRISM.Interactions.LimitLevelUpView limitLevelUpView;
    private PRISM.Interactions.LiveSkillEffectLevelUpView liveSkillEffectLevelUpView;
    private PRISM.Interactions.LimitProduceBonusView limitProduceBonusView;
    private PRISM.Adapters.SupportCharaMasterTrainingViewModel vm;
    private UniRx.Subject<UniRx.Unit> toExchange;
    private UniRx.Subject<int> exeMasterTraining;
    public System.IObservable<UniRx.Unit> ToExchange { get; set; }
    public System.IObservable<int> ExecuteMasterTraining { get; set; }
    private void Awake();
    public void Setup(PRISM.Adapters.SupportCharaMasterTrainingViewModel _vm, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void Show(bool isShow);
    private void _setLimitLevelText(int currentDaiamondLevel, int afterDaiamondLevel);
    private void _setPieceExchangeButtonEnable(bool isEnable);

    private class <>c__DisplayClass20_0
    {
        public PRISM.Interactions.SupportCharaMasterTrainingView <>4__this;
        public PRISM.Definitions.MstLiveSupportEffect mstSupportEffect;
        private void <Setup>b__0(PRISM.Adapters.LvSelectorViewModel lvSelector);
        private void <Setup>b__1(int limitLv);
        private void <Setup>b__2(int amount);
        private void <Setup>b__3(long amount);
        private void <Setup>b__4(float fillAmount);
        private void <Setup>b__5(bool isLess);
        private void <Setup>b__6(UniRx.Unit _);
        private void <Setup>b__7(UniRx.Unit _);
        private void <Setup>b__8(UniRx.Unit _);
        private void <Setup>b__9(UniRx.Unit _);
        private void <Setup>b__10(UniRx.Unit _);
        private void <Setup>g__setMaxLv|11(bool isMax);
        private void <Setup>g__setPieceFontColor|12();
    }

    private class <>c__DisplayClass22_0
    {
        public PRISM.Interactions.SupportCharaMasterTrainingView <>4__this;
        public int currentDaiamondLevel;
        public int afterDaiamondLevel;
        private bool <_setLimitLevelText>b__0(PRISM.Definitions.MstSupportCharacterLimitBreakBonus limit);
        private bool <_setLimitLevelText>b__1(PRISM.Definitions.MstSupportCharacterLimitBreakBonus limit);
        private bool <_setLimitLevelText>b__2(PRISM.Definitions.MstSupportCharacterLimitBreakBonus limit);
    }
}

// Namespace: PRISM.Interactions
public class SupportCharaStatusView : UnityEngine.MonoBehaviour, PRISM.Adapters.ISupportCharaStatusView
{
    private PRISM.UI.SCharaIconRectView sCharaIconRectView;
    private PRISM.Interactions.ButtonView detailButton;
    private UnityEngine.UI.RawImage favoriteImage;
    private PRISM.Interactions.ButtonView favoriteButton;
    private ENTERPRISE.UI.UITextMeshProUGUI aliasText;
    private ENTERPRISE.UI.UITextMeshProUGUI nameText;
    private ENTERPRISE.UI.UITextMeshProUGUI levelText;
    protected PRISM.UI.DiamondDisplay diamondDisplay;
    public System.IObservable<UniRx.Unit> OnDetail { get; set; }
    public System.IObservable<UniRx.Unit> OnFavorite { get; set; }
    public void Setup(PRISM.Adapters.SupportCharaStatusViewModel vm, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private void _setFavorite(int mstFavoriteMarkId, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    private void _setLevelText(int level);
    private void _setDiamond(int diamond);

    private class <>c__DisplayClass12_0
    {
        public PRISM.Interactions.SupportCharaStatusView <>4__this;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        private void <Setup>b__0(int x);
        private void <Setup>b__1(int x);
        private void <Setup>b__2(int x);
    }
}

// Namespace: PRISM.Interactions
public class SupportCharaTrainingView : UnityEngine.MonoBehaviour, PRISM.Adapters.ISupportCharaTrainingView
{
    private ENTERPRISE.UI.UITextMeshProUGUI txtRequiredMoney;
    private ENTERPRISE.UI.UITextMeshProUGUI txtMoney;
    private UnityEngine.GameObject goAlert;
    private PRISM.Interactions.ButtonView executeButton;
    private PRISM.Interactions.ButtonView resetButton;
    private PRISM.Interactions.ButtonView omakaseButton;
    private PRISM.Interactions.ViewStateChanger maxStateChanger;
    private ENTERPRISE.UI.UITextMeshProUGUI txtLvMaxSubText;
    private PRISM.Interactions.AdditionalLvSelector additionalLvSelector;
    private PRISM.Interactions.TicketSelector[] ticketSelectors;
    private PRISM.Interactions.SupportEffectView supportEffectView;
    private PRISM.Interactions.LevelUpView levelUpView;
    private PRISM.Interactions.StatusUpView statusUpView;
    private PRISM.Adapters.SupportCharaTrainingViewModel vm;
    public System.IObservable<PRISM.UI.LvTicketSelectorButtonType> OnLvButton { get; set; }
    public System.IObservable<System.ValueTuple<PRISM.UI.LvTicketSelectorButtonType, int>> OnTicketButton { get; set; }
    public System.IObservable<UniRx.Unit> LvUpAnimationEnd { get; set; }
    public void Setup(PRISM.Adapters.SupportCharaTrainingViewModel _vm, PRISM.ResourceManagement.IResourceLoader resourceLoader);
    public void Show(bool isShow);
    private void <Setup>b__20_0(int index);
    private void <Setup>b__20_1(System.ValueTuple<bool, bool> t);
    private void <Setup>b__20_2(long value);
    private void <Setup>b__20_3(long value);
    private void <Setup>b__20_4(bool b);
    private void <Setup>b__20_5(bool b);
    private void <Setup>b__20_6(PRISM.UI.InsufficientReasonType type);
    private void <Setup>b__20_7(bool b);
    private void <Setup>b__20_8(UniRx.Unit _);
    private void <Setup>b__20_9(UniRx.Unit _);
    private void <Setup>b__20_10(UniRx.Unit _);
    private void <Setup>g__setMax|20_11(bool isMax, bool isMasterTrainingCompleted);
    private void <Setup>g__setMoneyFontColor|20_12();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Interactions.TicketSelector, System.IObservable<System.ValueTuple<PRISM.UI.LvTicketSelectorButtonType, int>>> <>9__17_0;
        private System.IObservable<System.ValueTuple<PRISM.UI.LvTicketSelectorButtonType, int>> <get_OnTicketButton>b__17_0(PRISM.Interactions.TicketSelector x);
    }
}

// Namespace: PRISM.Interactions
public class SupportCharaUpgradingConnector : PRISM.Interactions.CharacterViewConnector<PRISM.Adapters.SupportCharaUpgradingArgument>, PRISM.ISupportCharaUpgradingConnector
{
    protected PRISM.Adapters.SupportCharaUpgradingArgument ParseFromLegacy(ENTERPRISE.IViewParameter parameter);
}

// Namespace: PRISM.Interactions
public class SupportCharaUpgradingView : UnityEngine.MonoBehaviour, PRISM.Adapters.ISupportCharaUpgradingView
{
    private PRISM.Interactions.ToggleGroupView displayTabGroup;
    private PRISM.Interactions.ToggleGroupView upgradeTabGroup;
    private PRISM.Interactions.ViewStateChanger[] upgradeTabBadgeStateChanger;
    private UnityEngine.Transform trPerformanceAreaParent;
    private PRISM.UI.PerformanceFader performanceFader;
    private UnityEngine.GameObject masterTrainingPerformanceObj;
    public void Setup(UniRx.IReactiveProperty<int> displayType, UniRx.IReactiveProperty<int> upgradeType);
    public void SetBadge(int index, bool on);
    public Cysharp.Threading.Tasks.UniTask<PRISM.Adapters.IMasterTrainingPerformanceView> CreateMasterTrainingPerformanceViewAsync(PRISM.ResourceManagement.IResourceLoader resourceLoader, System.Threading.CancellationToken ct);
    public void DisposeMasterTrainingPerformanceView();
    public Cysharp.Threading.Tasks.UniTask FadeInPerformanceAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask FadeOutPerformanceAsync(System.Threading.CancellationToken ct);

    private struct <CreateMasterTrainingPerformanceViewAsync>d__8 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<PRISM.Adapters.IMasterTrainingPerformanceView> <>t__builder;
        public PRISM.ResourceManagement.IResourceLoader resourceLoader;
        public System.Threading.CancellationToken ct;
        public PRISM.Interactions.SupportCharaUpgradingView <>4__this;
        private Awaiter<UnityEngine.GameObject> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class SupportEffectView : UnityEngine.MonoBehaviour
{
    private UnityEngine.RectTransform contentParent;
    private PRISM.Interactions.SupportEffectContentView goContentPrefab;
    private UnityEngine.GameObject goEmptyView;
    private UnityEngine.UI.ScrollRect scrollRect;
    private UnityEngine.RectTransform viewPortRect;
    private UnityEngine.UI.VerticalLayoutGroup verticalLayoutGroup;
    private bool isSetupCompleted;
    private System.Collections.Generic.List<PRISM.Interactions.SupportEffectContentView> effectContentViews;
    public void Setup(System.Collections.Generic.List<PRISM.Adapters.SupportEffectContentViewModel> data, bool forceBgColor);
    public Cysharp.Threading.Tasks.UniTask SetupWithAutoScrollAsync(System.Collections.Generic.List<PRISM.Adapters.SupportEffectContentViewModel> data);
    public Cysharp.Threading.Tasks.UniTask ScrollToIndexContentAsync(int index);
    private bool <ScrollToIndexContentAsync>b__10_0();

    private struct <ScrollToIndexContentAsync>d__10 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Interactions.SupportEffectView <>4__this;
        public int index;
        private Awaiter <>u__1;
        private TweenAwaiter <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <SetupWithAutoScrollAsync>d__9 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public System.Collections.Generic.List<PRISM.Adapters.SupportEffectContentViewModel> data;
        public PRISM.Interactions.SupportEffectView <>4__this;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Interactions
public class TicketSelector : UnityEngine.MonoBehaviour
{
    private UnityEngine.UI.RawImage ticketImage;
    private ENTERPRISE.UI.UITextMeshProUGUI ticketAmountText;
    private PRISM.Interactions.ButtonView ticketButton;
    private PRISM.Interactions.ButtonView ticketDownButton;
    private PRISM.Interactions.ButtonView ticketUpButton;
    private ENTERPRISE.UI.UITextMeshProUGUI selectedTicketAmountText;
    private System.IObservable<System.ValueTuple<PRISM.UI.LvTicketSelectorButtonType, int>> <OnClick>k__BackingField;
    public System.IObservable<System.ValueTuple<PRISM.UI.LvTicketSelectorButtonType, int>> OnClick { get; set; }
    public void Setup(int index, PRISM.Adapters.TicketSelectorViewModel vm, PRISM.ResourceManagement.IResourceLoader resourceLoader);

    private class <>c__DisplayClass10_0
    {
        public PRISM.Interactions.TicketSelector <>4__this;
        public int index;
        public PRISM.Adapters.TicketSelectorViewModel vm;
        private void <Setup>b__0(long x);
        private void <Setup>b__1(long x);
        private void <Setup>b__2(PRISM.UI.LvTicketSelectorButtonStateType state);
        private System.ValueTuple<PRISM.UI.LvTicketSelectorButtonType, int> <Setup>b__3(UniRx.Unit x);
        private System.ValueTuple<PRISM.UI.LvTicketSelectorButtonType, int> <Setup>b__4(UniRx.Unit x);
        private void <Setup>b__5(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions
public class CharacterTopConnector : PRISM.Interactions.CharacterViewConnector, PRISM.UICharacter.ICharacterTopConnector
{
}

// Namespace: PRISM.Interactions
public class CharacterTopUICharacterView : UnityEngine.MonoBehaviour, PRISM.Adapters.ICharacterTopUICharacterView
{
    private PRISM.UI.UICharacterViewer uiCharacterViewer;
    private PRISM.UI.CenteringObjectsOutsideSafeArea characterPositionAdjuster;
    public void Inject(System.Func<bool> isOverlayShowFunc);
    public Cysharp.Threading.Tasks.UniTask<bool> SetupHazukiVoiceMotionAsync(PRISM.UnitIdol unitIdol, PRISM.UI.UICharacterVoicePattern voicePattern);
    public void OnNextViewPreparation();
    public Cysharp.Threading.Tasks.UniTask ReleaseAsync();
}

// Namespace: PRISM.Interactions
public class CharacterTopView : UnityEngine.MonoBehaviour, PRISM.Adapters.Interface.ICharacterTopView
{
    private PRISM.Interactions.ButtonView[] buttons;
    private PRISM.HowToPlayPopupOpener dressOrderHowToPlay;
    public System.IObservable<PRISM.Adapters.SelectBtnType> OnClick { get; set; }
    public PRISM.HowToPlayPopupOpener DressOrderHowToPlay { get; set; }

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Interactions.ButtonView, int, System.IObservable<PRISM.Adapters.SelectBtnType>> <>9__3_0;
        private System.IObservable<PRISM.Adapters.SelectBtnType> <get_OnClick>b__3_0(PRISM.Interactions.ButtonView button, int index);
    }

    private class <>c__DisplayClass3_0
    {
        public int index;
        private PRISM.Adapters.SelectBtnType <get_OnClick>b__1(UniRx.Unit _);
    }
}

// Namespace: PRISM.Interactions
public class UnitSelectClickObservableInt : PRISM.ClickObservableContext<int>
{
    private UniRx.FloatReactiveProperty statusLabelBlinkValue;
    private bool <TapNotAvailable>k__BackingField;
    public bool TapNotAvailable { get; set; }
    public System.IObservable<float> StatusLabelBlinkValueObservable { get; set; }
    public void SetStatusLabelBlinkValue(float value);
    public void Dispose();
}

// Namespace: PRISM.Interactions.Character
public class GoodScheduleFilterToggleGroupViewFactory : PRISM.Interactions.DynamicFilterToggleGroupViewFactory
{
    protected System.Collections.Generic.IEnumerable<System.ValueTuple<int, string>> _enumerateItems();

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Definitions.MstFavoriteSchedule, int> <>9__0_0;
        public static System.Func<int, int> <>9__0_1;
        public static System.Func<int, System.ValueTuple<int, string>> <>9__0_2;
        private int <_enumerateItems>b__0_0(PRISM.Definitions.MstFavoriteSchedule x);
        private int <_enumerateItems>b__0_1(int x);
        private System.ValueTuple<int, string> <_enumerateItems>b__0_2(int x);
    }
}

// Namespace: PRISM.Interactions.Character
public class SupportEffectToggleGroupViewFactory : PRISM.Interactions.FilterToggleGroupViewFactory
{
    private PRISM.Interactions.SupportEffectFilterToggleGroupView prefab;
    private int supportEffectViewIndex;
    public PRISM.Interactions.FilterToggleGroupView Create(UnityEngine.Transform parent);
}

// Namespace: PRISM.Interactions.Character
public class PIdolUpgradingButtonView : UnityEngine.MonoBehaviour, PRISM.Adapters.IPIdolUpgradingButtonView
{
    private PRISM.Interactions.BitToggleButtonView canPIdolLvUpToggle;
    private PRISM.Interactions.BitToggleButtonView canAwakenToggle;
    private PRISM.Interactions.BitToggleButtonView canTrainingToggle;
    public void Setup(UniRx.IReactiveProperty<PRISM.UI.BitProduceIdolUpgradingFilterType> upgradingFilterType);
}

// Namespace: PRISM.Interactions.Character
public class ResourceLoaderExtensions
{
    public static Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadLiveSkillIconSmallAsync(PRISM.ResourceManagement.IResourceLoader loader, int liveSkillId, System.Threading.CancellationToken ct);
    public static Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadSCFullAsync(PRISM.ResourceManagement.IResourceLoader loader, string iconId, System.Threading.CancellationToken ct);
    public static Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadCostumeIconAsync(PRISM.ResourceManagement.IResourceLoader loader, int costumeId, System.Threading.CancellationToken ct);
    public static Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadHairStyleIdIconAsync(PRISM.ResourceManagement.IResourceLoader loader, int hairStyleId, System.Threading.CancellationToken ct);
    public static Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadAccessoryIconAsync(PRISM.ResourceManagement.IResourceLoader loader, int accessoryId, System.Threading.CancellationToken ct);
}

// Namespace: PRISM.Interactions.Character
public class SCharaUpgradingButtonView : UnityEngine.MonoBehaviour, PRISM.Adapters.ISCharaUpgradingButtonView
{
    private PRISM.Interactions.BitToggleButtonView canTrainingToggle;
    private PRISM.Interactions.BitToggleButtonView canMasterTrainingToggle;
    public void Setup(UniRx.IReactiveProperty<PRISM.UI.BitSupportCharaUpgradingFilterType> upgradingFilterType);
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=17699 3E85A0394DBD3024EB2AD34DA378AFDBBA49CBCEE7B2729860DF6A1895E8C94E;
    private static __StaticArrayInitTypeSize=9376 C2E6D86FB61010B45D8954363FBFAA5EDF781143E1536CBEFBAAE00CBEC83CD3;

    private struct __StaticArrayInitTypeSize=9376 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=17699 : System.ValueType
    {
    }
}
