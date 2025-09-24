
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

// Namespace: PRISM.Module.CustomMagicaCloth
public class AMagicaBodyParamColliderController : UnityEngine.MonoBehaviour, PRISM.Module.CustomMagicaCloth.IAffectedByBodyParam
{
    private string category;
    private BodyParamType bodyParamType;
    private float minBodyParamValue;
    private float maxBodyParamValue;
    protected PRISM.Module.CustomMagicaCloth.BodyParamVector3Property center;
    public BodyParamType BodyParamType { get; set; }
    public float MinBodyParamValue { get; set; }
    public float MaxBodyParamValue { get; set; }
    public string Category { get; set; }
    public MagicaCloth2.ColliderComponent Collider { get; set; }
    public PRISM.Module.CustomMagicaCloth.BodyParamVector3Property Center { get; set; }
    public void ApplyBodyParam(float t);
}

// Namespace: PRISM.Module.CustomMagicaCloth
public class MagicaBodyParamCapsuleColliderController : PRISM.Module.CustomMagicaCloth.AMagicaBodyParamColliderController
{
    private MagicaCloth2.MagicaCapsuleCollider capsuleCollider;
    private PRISM.Module.CustomMagicaCloth.BodyParamFloatProperty length;
    private PRISM.Module.CustomMagicaCloth.BodyParamFloatProperty startRadius;
    private PRISM.Module.CustomMagicaCloth.BodyParamFloatProperty endRadius;
    public MagicaCloth2.ColliderComponent Collider { get; set; }
    public PRISM.Module.CustomMagicaCloth.BodyParamFloatProperty Length { get; set; }
    public PRISM.Module.CustomMagicaCloth.BodyParamFloatProperty StartRadius { get; set; }
    public PRISM.Module.CustomMagicaCloth.BodyParamFloatProperty EndRadius { get; set; }
    public MagicaCloth2.MagicaCapsuleCollider GetCapsuleCollider();
    public void ApplyBodyParam(float t);
    private void Awake();
}

// Namespace: PRISM.Module.CustomMagicaCloth
public class MagicaBodyParamPlaneColliderController : PRISM.Module.CustomMagicaCloth.AMagicaBodyParamColliderController
{
    private MagicaCloth2.MagicaPlaneCollider planeCollider;
    public MagicaCloth2.ColliderComponent Collider { get; set; }
    public MagicaCloth2.MagicaPlaneCollider GetPlaneCollider();
    public void ApplyBodyParam(float t);
    private void Awake();
}

// Namespace: PRISM.Module.CustomMagicaCloth
public class MagicaBodyParamSphereColliderController : PRISM.Module.CustomMagicaCloth.AMagicaBodyParamColliderController
{
    private MagicaCloth2.MagicaSphereCollider sphereCollider;
    private PRISM.Module.CustomMagicaCloth.BodyParamFloatProperty radius;
    public MagicaCloth2.ColliderComponent Collider { get; set; }
    public PRISM.Module.CustomMagicaCloth.BodyParamFloatProperty Radius { get; set; }
    public MagicaCloth2.MagicaSphereCollider GetSphereCollider();
    public void ApplyBodyParam(float t);
    private void Awake();
}

// Namespace: PRISM.Module.CustomMagicaCloth
public class MagicaColliderCategoryData
{
    private string category;
    private System.Collections.Generic.List<PRISM.Module.CustomMagicaCloth.AMagicaBodyParamColliderController> colliderControllers;
    public string Category { get; set; }
    public System.Collections.Generic.List<PRISM.Module.CustomMagicaCloth.AMagicaBodyParamColliderController> ColliderControllers { get; set; }
}

// Namespace: PRISM.Module.CustomMagicaCloth
public class AMagicaColliderParam
{
    private string <ParentName>k__BackingField;
    private UnityEngine.Vector3 <LocalPosition>k__BackingField;
    private UnityEngine.Quaternion <LocalRotation>k__BackingField;
    private UnityEngine.Vector3 <LocalScale>k__BackingField;
    private string <Name>k__BackingField;
    private string <Category>k__BackingField;
    private BodyParamType <BodyParamType>k__BackingField;
    private float <MinBodyParamValue>k__BackingField;
    private float <MaxBodyParamValue>k__BackingField;
    private PRISM.Module.CustomMagicaCloth.BodyParamVector3Property <Center>k__BackingField;
    public ColliderType ColliderType { get; set; }
    public string ParentName { get; set; }
    public UnityEngine.Vector3 LocalPosition { get; set; }
    public UnityEngine.Quaternion LocalRotation { get; set; }
    public UnityEngine.Vector3 LocalScale { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public BodyParamType BodyParamType { get; set; }
    public float MinBodyParamValue { get; set; }
    public float MaxBodyParamValue { get; set; }
    public PRISM.Module.CustomMagicaCloth.BodyParamVector3Property Center { get; set; }
}

// Namespace: PRISM.Module.CustomMagicaCloth
public class MagicaCapsuleColliderParam : PRISM.Module.CustomMagicaCloth.AMagicaColliderParam
{
    private Direction <Direction>k__BackingField;
    private bool <RadiusSeparation>k__BackingField;
    private bool <AlignedOnCenter>k__BackingField;
    private PRISM.Module.CustomMagicaCloth.BodyParamFloatProperty <StartRadius>k__BackingField;
    private PRISM.Module.CustomMagicaCloth.BodyParamFloatProperty <EndRadius>k__BackingField;
    private PRISM.Module.CustomMagicaCloth.BodyParamFloatProperty <Length>k__BackingField;
    private bool <ReverseDirection>k__BackingField;
    public ColliderType ColliderType { get; set; }
    public Direction Direction { get; set; }
    public bool RadiusSeparation { get; set; }
    public bool AlignedOnCenter { get; set; }
    public PRISM.Module.CustomMagicaCloth.BodyParamFloatProperty StartRadius { get; set; }
    public PRISM.Module.CustomMagicaCloth.BodyParamFloatProperty EndRadius { get; set; }
    public PRISM.Module.CustomMagicaCloth.BodyParamFloatProperty Length { get; set; }
    public bool ReverseDirection { get; set; }
}

// Namespace: PRISM.Module.CustomMagicaCloth
public class MagicaColliderSaveData
{
    private System.Collections.Generic.List<PRISM.Module.CustomMagicaCloth.ClothColliderParamSaveData> <ClothColliderParamDataList>k__BackingField;
    private System.Collections.Generic.List<PRISM.Module.CustomMagicaCloth.ColliderParamSaveData> <ColliderParamDataList>k__BackingField;
    public System.Collections.Generic.List<PRISM.Module.CustomMagicaCloth.ClothColliderParamSaveData> ClothColliderParamDataList { get; set; }
    public System.Collections.Generic.List<PRISM.Module.CustomMagicaCloth.ColliderParamSaveData> ColliderParamDataList { get; set; }
}

// Namespace: PRISM.Module.CustomMagicaCloth
public class ClothColliderParamSaveData
{
    private System.Collections.Generic.List<string> <RootBoneNames>k__BackingField;
    private System.Collections.Generic.List<string> <CollideCategories>k__BackingField;
    public System.Collections.Generic.List<string> RootBoneNames { get; set; }
    public System.Collections.Generic.List<string> CollideCategories { get; set; }
}

// Namespace: PRISM.Module.CustomMagicaCloth
public class ColliderParamSaveData
{
    private string <Category>k__BackingField;
    private System.Collections.Generic.List<PRISM.Module.CustomMagicaCloth.AMagicaColliderParam> <ColliderParams>k__BackingField;
    public string Category { get; set; }
    public System.Collections.Generic.List<PRISM.Module.CustomMagicaCloth.AMagicaColliderParam> ColliderParams { get; set; }
}

// Namespace: PRISM.Module.CustomMagicaCloth
public class MagicaPlaneColliderParam : PRISM.Module.CustomMagicaCloth.AMagicaColliderParam
{
    public ColliderType ColliderType { get; set; }
}

// Namespace: PRISM.Module.CustomMagicaCloth
public class MagicaSphereColliderParam : PRISM.Module.CustomMagicaCloth.AMagicaColliderParam
{
    private PRISM.Module.CustomMagicaCloth.BodyParamFloatProperty <Radius>k__BackingField;
    public ColliderType ColliderType { get; set; }
    public PRISM.Module.CustomMagicaCloth.BodyParamFloatProperty Radius { get; set; }
}

// Namespace: PRISM.Module.CustomMagicaCloth
public class ABodyParamProperty`1<T>
{
    public bool IsEnable;
    public T MinValue;
    public T MaxValue;
    public T GetValue(float t);
    public void Set(PRISM.Module.CustomMagicaCloth.ABodyParamProperty<T> property);
    protected T _getValue(float t);
}

// Namespace: PRISM.Module.CustomMagicaCloth
public class BodyParamFloatProperty : PRISM.Module.CustomMagicaCloth.ABodyParamProperty<float>
{
    protected float _getValue(float t);
}

// Namespace: PRISM.Module.CustomMagicaCloth
public class BodyParamVector3Property : PRISM.Module.CustomMagicaCloth.ABodyParamProperty<UnityEngine.Vector3>
{
    protected UnityEngine.Vector3 _getValue(float t);
}

// Namespace: PRISM.Module.CustomMagicaCloth
public interface IAffectedByBodyParam
{
    public BodyParamType BodyParamType { get; set; }
    public float MinBodyParamValue { get; set; }
    public float MaxBodyParamValue { get; set; }
    public void ApplyBodyParam(float t);
}

// Namespace: PRISM.Module.CustomMagicaCloth
public class MagicaClothEnums
{

    public enum BodyParamType : System.Enum
    {
        public int value__;
        public static BodyParamType None;
        public static BodyParamType Height;
        public static BodyParamType Bust;
        public static BodyParamType Head;
    }
}

// Namespace: PRISM.Module.CustomMagicaCloth
public class AffectedByBodyParamExtensions
{
    public static void ApplyBodyParam(PRISM.Module.CustomMagicaCloth.IAffectedByBodyParam affectedByBodyParam, float height, float bust, float head);
}

// Namespace: PRISM.Module.CustomMagicaCloth
public class TransformExtensions
{
    public static UnityEngine.Transform Find<TState>(UnityEngine.Transform transform, TState state, System.Func<UnityEngine.Transform, TState, bool> predicate, bool findAllChildren, bool findParent);
    public static void ForEach<TState>(UnityEngine.Transform transform, TState state, System.Action<UnityEngine.Transform, TState> action, bool invokeAllChildren, bool invokeParent);
}

// Namespace: PRISM.Module.CustomMagicaCloth
public class ChangePhysicsSimulationParamScopeComponent : UnityEngine.MonoBehaviour
{
    private int simulationFrequency;
    private int maxSimulationCountPerFrame;
    private void Start();
}

// Namespace: PRISM.Module.CustomMagicaCloth
public class GlobalMagicaClothControllerList
{
    private static System.Collections.Generic.List<PRISM.Module.CustomMagicaCloth.MagicaClothController> clothControllers;
    public System.Collections.Generic.IReadOnlyList<PRISM.Module.CustomMagicaCloth.MagicaClothController> ClothControllers { get; set; }
    public static void Add(PRISM.Module.CustomMagicaCloth.MagicaClothController clothController);
    public static void Remove(PRISM.Module.CustomMagicaCloth.MagicaClothController clothController);
}

// Namespace: PRISM.Module.CustomMagicaCloth
public class MagicaClothController : UnityEngine.MonoBehaviour, PRISM.Module.CustomMagicaCloth.IAffectedByBodyParam
{
    private PRISM.Module.CustomMagicaCloth.MagicaClothGroup clothGroup;
    private MagicaCloth2.MagicaCloth magicaCloth;
    private BodyParamType bodyParamType;
    private float minBodyParamValue;
    private float maxBodyParamValue;
    private PRISM.Module.CustomMagicaCloth.BodyParamFloatProperty springPower;
    private PRISM.Module.CustomMagicaCloth.BodyParamFloatProperty limitDistance;
    private PRISM.Module.CustomMagicaCloth.BodyParamFloatProperty inertia;
    private PRISM.Module.CustomMagicaCloth.BodyParamFloatProperty radius;
    private System.Collections.Generic.List<string> collideCategories;
    private bool isSupportedAdditiveAnimation;
    private bool currentDoAdditiveAnim;
    private System.Collections.Generic.List<MagicaCloth2.ColliderComponent> ColliderComponents { get; set; }
    public MagicaCloth2.MagicaCloth MagicaCloth { get; set; }
    public PRISM.Module.CustomMagicaCloth.MagicaClothGroup ClothGroup { get; set; }
    public PRISM.Module.CustomMagicaCloth.BodyParamFloatProperty SpringPower { get; set; }
    public PRISM.Module.CustomMagicaCloth.BodyParamFloatProperty LimitDistance { get; set; }
    public PRISM.Module.CustomMagicaCloth.BodyParamFloatProperty Inertia { get; set; }
    public PRISM.Module.CustomMagicaCloth.BodyParamFloatProperty Radius { get; set; }
    public System.Collections.Generic.IReadOnlyList<string> CollideCategories { get; set; }
    public bool IsSupportedAdditiveAnimation { get; set; }
    public BodyParamType BodyParamType { get; set; }
    public float MinBodyParamValue { get; set; }
    public float MaxBodyParamValue { get; set; }
    public void ApplyBodyParam(float t);
    public void LoadColliders();
    public void AddCollider(string category);
    public void AddCollider(PRISM.Module.CustomMagicaCloth.AMagicaBodyParamColliderController colliderController);
    public void RefreshCollider();
    public void OnSetAdditiveAnimation(bool isDoAdditiveAnim);
    public void SetClothEnable(bool enable);
    private void Awake();
    private void OnDestroy();

    private class <>c
    {
        public static <>c <>9;
        public static System.Predicate<MagicaCloth2.ColliderComponent> <>9__44_0;
        private bool <RefreshCollider>b__44_0(MagicaCloth2.ColliderComponent e);
    }
}

// Namespace: PRISM.Module.CustomMagicaCloth
public class MagicaClothGroup : UnityEngine.MonoBehaviour
{
    private System.Collections.Generic.List<PRISM.Module.CustomMagicaCloth.MagicaClothController> clothControllers;
    private System.Collections.Generic.List<PRISM.Module.CustomMagicaCloth.MagicaColliderCategoryData> colliderCategoryDatas;
    public System.Collections.Generic.IReadOnlyList<PRISM.Module.CustomMagicaCloth.MagicaClothController> ClothControllers { get; set; }
    public System.Collections.Generic.IReadOnlyList<PRISM.Module.CustomMagicaCloth.MagicaColliderCategoryData> ColliderCategoryDatas { get; set; }
    public void Initialize();
    public void ApplyBodyParam(float height, float bust, float head);
    public System.Collections.Generic.IReadOnlyList<PRISM.Module.CustomMagicaCloth.AMagicaBodyParamColliderController> GetColliderControllers(string category);
    public void AddRangeCollider(System.Collections.Generic.IReadOnlyList<PRISM.Module.CustomMagicaCloth.MagicaColliderCategoryData> colliderCategoryDatas);
    public void AddCollider(PRISM.Module.CustomMagicaCloth.AMagicaBodyParamColliderController colliderController);
    public void AddRangeCollider(System.Collections.Generic.IReadOnlyList<PRISM.Module.CustomMagicaCloth.AMagicaBodyParamColliderController> colliderControllers);
    public void RefreshCollider();
    public void OnSetAdditiveAnimation(bool isDoAdditiveAnim);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<PRISM.Module.CustomMagicaCloth.MagicaColliderCategoryData, string, bool> <>9__8_0;
        public static System.Func<PRISM.Module.CustomMagicaCloth.MagicaColliderCategoryData, string, bool> <>9__10_0;
        public static System.Predicate<PRISM.Module.CustomMagicaCloth.AMagicaBodyParamColliderController> <>9__12_0;
        private bool <GetColliderControllers>b__8_0(PRISM.Module.CustomMagicaCloth.MagicaColliderCategoryData e, string state);
        private bool <AddCollider>b__10_0(PRISM.Module.CustomMagicaCloth.MagicaColliderCategoryData e, string state);
        private bool <RefreshCollider>b__12_0(PRISM.Module.CustomMagicaCloth.AMagicaBodyParamColliderController e);
    }
}

// Namespace: PRISM.Module.CustomMagicaCloth
public struct PhysicsFrequencyScope : System.ValueType, System.IDisposable
{
    private int savedFrequency;
    private int savedMaxSimulationCountPerFrame;
    public void Dispose();
}

// Namespace: PRISM.Module.CustomMagicaCloth
public class MagicaPhysicsParam
{
    private string <Name>k__BackingField;
    private BodyParamType <BodyParamType>k__BackingField;
    private float <MinBodyParamValue>k__BackingField;
    private float <MaxBodyParamValue>k__BackingField;
    private PRISM.Module.CustomMagicaCloth.BodyParamFloatProperty <SpringPower>k__BackingField;
    private PRISM.Module.CustomMagicaCloth.BodyParamFloatProperty <LimitDistance>k__BackingField;
    private PRISM.Module.CustomMagicaCloth.BodyParamFloatProperty <Inertia>k__BackingField;
    private PRISM.Module.CustomMagicaCloth.BodyParamFloatProperty <Radius>k__BackingField;
    private MagicaCloth2.ClothSerializeData <ClothSerializeData>k__BackingField;
    private bool <isSupportedAdditiveAnimation>k__BackingField;
    public string Name { get; set; }
    public BodyParamType BodyParamType { get; set; }
    public float MinBodyParamValue { get; set; }
    public float MaxBodyParamValue { get; set; }
    public PRISM.Module.CustomMagicaCloth.BodyParamFloatProperty SpringPower { get; set; }
    public PRISM.Module.CustomMagicaCloth.BodyParamFloatProperty LimitDistance { get; set; }
    public PRISM.Module.CustomMagicaCloth.BodyParamFloatProperty Inertia { get; set; }
    public PRISM.Module.CustomMagicaCloth.BodyParamFloatProperty Radius { get; set; }
    public MagicaCloth2.ClothSerializeData ClothSerializeData { get; set; }
    public bool isSupportedAdditiveAnimation { get; set; }
}

// Namespace: PRISM.Module.CustomMagicaCloth
public class GlobalMagicaClothUtility
{
    public static void ResetSimulation(bool keepPose);
    public static void SetClothEnable(bool enable);
}

// Namespace: PRISM.Module.CustomMagicaCloth.SkirtConstraint
public struct CalcBoneRotationJob : System.ValueType, Unity.Jobs.IJobParallelFor
{
    public Unity.Mathematics.quaternion HipRotation;
    public PRISM.Module.CustomMagicaCloth.SkirtConstraint.LegConstraintData LeftLegData;
    public PRISM.Module.CustomMagicaCloth.SkirtConstraint.LegConstraintData RightLegData;
    public Unity.Collections.NativeArray<PRISM.Module.CustomMagicaCloth.SkirtConstraint.RootBoneCalcRotationJobData> RootBoneDataArray;
    public Unity.Collections.NativeArray<PRISM.Module.CustomMagicaCloth.SkirtConstraint.BoneCalcRotationJobData> BoneDataArray;
    public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> BoneRotationResults;
    public bool ConstraintLowLegBone;
    public void Execute(int index);
}

// Namespace: PRISM.Module.CustomMagicaCloth.SkirtConstraint
public struct RootBoneCalcRotationJobData : System.ValueType
{
    public int RootBoneIndex;
    public Unity.Mathematics.float3 LeftCenterToRootDirection;
    public Unity.Mathematics.float3 RightCenterToRootDirection;
    public int BoneCount;
    public bool NotReachLowLegBone;
}

// Namespace: PRISM.Module.CustomMagicaCloth.SkirtConstraint
public struct BoneCalcRotationJobData : System.ValueType
{
    public Unity.Mathematics.float3 RotateAxis;
    public Unity.Mathematics.quaternion InitLocalRotation;
}

// Namespace: PRISM.Module.CustomMagicaCloth.SkirtConstraint
public struct LegConstraintData : System.ValueType
{
    public float AngleWeight;
    public Unity.Mathematics.float3 ForCalcLegWeightDirection;
    public Unity.Mathematics.float3 UpLegDirection;
    public Unity.Mathematics.float3 LowLegDirection;
}

// Namespace: PRISM.Module.CustomMagicaCloth.SkirtConstraint
public class SkirtConstraint : UnityEngine.MonoBehaviour
{
    private PRISM.Module.CustomMagicaCloth.MagicaClothController clothController;
    private float weight;
    private float borderMinAngle;
    private float borderMaxAngle;
    private bool constraintLowLegBone;
    private PRISM.Module.CustomMagicaCloth.SkirtConstraint.BoneAxisData hipData;
    private PRISM.Module.CustomMagicaCloth.SkirtConstraint.BoneAxisData leftUpLegData;
    private PRISM.Module.CustomMagicaCloth.SkirtConstraint.BoneAxisData rightUpLegData;
    private PRISM.Module.CustomMagicaCloth.SkirtConstraint.BoneAxisData leftLowLegData;
    private PRISM.Module.CustomMagicaCloth.SkirtConstraint.BoneAxisData rightLowLegData;
    private PRISM.Module.CustomMagicaCloth.SkirtConstraint.RootBoneSerializeData[] rootBoneDataArray;
    private PRISM.Module.CustomMagicaCloth.SkirtConstraint.BoneSerializeData[] boneDataArray;
    private UnityEngine.Transform[] boneTransformArray;
    private UnityEngine.Jobs.TransformAccessArray boneTransformAccessArray;
    private Unity.Collections.NativeArray<PRISM.Module.CustomMagicaCloth.SkirtConstraint.RootBoneCalcRotationJobData> rootBoneDataNativeArray;
    private Unity.Collections.NativeArray<PRISM.Module.CustomMagicaCloth.SkirtConstraint.BoneCalcRotationJobData> boneDataNativeArray;
    private Unity.Collections.NativeArray<Unity.Mathematics.quaternion> boneResultRotationArray;
    public float Weight { get; set; }
    public float BorderMinAngle { get; set; }
    public float BorderMaxAngle { get; set; }
    public bool ConstraintLowLegBone { get; set; }
    public PRISM.Module.CustomMagicaCloth.SkirtConstraint.BoneAxisData HipData { get; set; }
    public PRISM.Module.CustomMagicaCloth.SkirtConstraint.BoneAxisData LeftUpLegData { get; set; }
    public PRISM.Module.CustomMagicaCloth.SkirtConstraint.BoneAxisData RightUpLegData { get; set; }
    public PRISM.Module.CustomMagicaCloth.SkirtConstraint.BoneAxisData LeftLowLegData { get; set; }
    public PRISM.Module.CustomMagicaCloth.SkirtConstraint.BoneAxisData RightLowLegData { get; set; }
    public void OnSetAdditiveAnimation(bool isDoAdditiveAnim);
    private void Start();
    private void _setUpNativeArray();
    private void _constraint();
    private void OnEnable();
    private void OnDisable();
}

// Namespace: PRISM.Module.CustomMagicaCloth.SkirtConstraint
public class BoneAxisData
{
    public UnityEngine.Transform Bone;
    public UnityEngine.Vector3 Axis;
}

// Namespace: PRISM.Module.CustomMagicaCloth.SkirtConstraint
public struct RootBoneSerializeData : System.ValueType
{
    public int RootBoneIndex;
    public UnityEngine.Vector3 LeftCenterToRootDirection;
    public UnityEngine.Vector3 RightCenterToRootDirection;
    public int BoneCount;
    public bool NotReachLowLegBone;
}

// Namespace: PRISM.Module.CustomMagicaCloth.SkirtConstraint
public struct BoneSerializeData : System.ValueType
{
    public UnityEngine.Vector3 RotateAxis;
    public UnityEngine.Quaternion InitLocalRotation;
}

// Namespace: PRISM.Module.CustomMagicaCloth.SkirtConstraint
public class SkirtConstraintUtility
{
    public static void CalcLegData(PRISM.Module.CustomMagicaCloth.SkirtConstraint.SkirtConstraint skirtConstraint, PRISM.Module.CustomMagicaCloth.SkirtConstraint.LegConstraintData& leftLegData, PRISM.Module.CustomMagicaCloth.SkirtConstraint.LegConstraintData& rightLegData);
    public static float GetLegWeight(PRISM.Module.CustomMagicaCloth.SkirtConstraint.LegConstraintData& legData, Unity.Mathematics.float3& centerToRootDirection, Unity.Mathematics.quaternion& hipRotation);
    private static void _calcLegDirectionAndAngleWeight(float& weight, Unity.Mathematics.quaternion& hipRotation, Unity.Mathematics.float3& hipAxis, Unity.Mathematics.quaternion& upLegRotation, Unity.Mathematics.float3& upLegAxis, Unity.Mathematics.quaternion& lowLegRotation, Unity.Mathematics.float3& lowLegAxis, float& minAngle, float& maxAngle, bool& constraintLowLegBone, PRISM.Module.CustomMagicaCloth.SkirtConstraint.LegConstraintData& legData);
    private static float _getLegAngle(Unity.Mathematics.float3 hipDirection, Unity.Mathematics.float3 legDirection, float minAngle);
    private static float _getDot01(Unity.Mathematics.float3 x, Unity.Mathematics.float3 y);
    private static void _calcLegDirectionAndAngleWeight$BurstManaged(float& weight, Unity.Mathematics.quaternion& hipRotation, Unity.Mathematics.float3& hipAxis, Unity.Mathematics.quaternion& upLegRotation, Unity.Mathematics.float3& upLegAxis, Unity.Mathematics.quaternion& lowLegRotation, Unity.Mathematics.float3& lowLegAxis, float& minAngle, float& maxAngle, bool& constraintLowLegBone, PRISM.Module.CustomMagicaCloth.SkirtConstraint.LegConstraintData& legData);

// Namespace: PRISM.Module.CustomMagicaCloth.SkirtConstraint
    class _calcLegDirectionAndAngleWeight_000000CB$PostfixBurstDelegate : System.MulticastDelegate
    {
        public void Invoke(float& weight, Unity.Mathematics.quaternion& hipRotation, Unity.Mathematics.float3& hipAxis, Unity.Mathematics.quaternion& upLegRotation, Unity.Mathematics.float3& upLegAxis, Unity.Mathematics.quaternion& lowLegRotation, Unity.Mathematics.float3& lowLegAxis, float& minAngle, float& maxAngle, bool& constraintLowLegBone, PRISM.Module.CustomMagicaCloth.SkirtConstraint.LegConstraintData& legData);
        public System.IAsyncResult BeginInvoke(float& weight, Unity.Mathematics.quaternion& hipRotation, Unity.Mathematics.float3& hipAxis, Unity.Mathematics.quaternion& upLegRotation, Unity.Mathematics.float3& upLegAxis, Unity.Mathematics.quaternion& lowLegRotation, Unity.Mathematics.float3& lowLegAxis, float& minAngle, float& maxAngle, bool& constraintLowLegBone, PRISM.Module.CustomMagicaCloth.SkirtConstraint.LegConstraintData& legData, System.AsyncCallback , object );
        public void EndInvoke(System.IAsyncResult );
    }

// Namespace: PRISM.Module.CustomMagicaCloth.SkirtConstraint
    class _calcLegDirectionAndAngleWeight_000000CB$BurstDirectCall
    {
        private static System.IntPtr Pointer;
        private static void GetFunctionPointerDiscard(System.IntPtr& );
        private static System.IntPtr GetFunctionPointer();
        public static void Invoke(float& weight, Unity.Mathematics.quaternion& hipRotation, Unity.Mathematics.float3& hipAxis, Unity.Mathematics.quaternion& upLegRotation, Unity.Mathematics.float3& upLegAxis, Unity.Mathematics.quaternion& lowLegRotation, Unity.Mathematics.float3& lowLegAxis, float& minAngle, float& maxAngle, bool& constraintLowLegBone, PRISM.Module.CustomMagicaCloth.SkirtConstraint.LegConstraintData& legData);
    }
}

// Namespace: PRISM.Module.CustomMagicaCloth.SkirtConstraint
public struct WriteBoneRotationJob : System.ValueType, UnityEngine.Jobs.IJobParallelForTransform
{
    public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> ResultRotations;
    public void Execute(int index, UnityEngine.Jobs.TransformAccess transform);
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=1964 2DEB77DCC2CFFB534FBD403BB63896B232A8868A0EBCAB062F55A84E3F5D737A;
    private static __StaticArrayInitTypeSize=2797 EE19FD999E6609A9B7006BE9D56CE29F8740942B6E08AEE5A94AE56670ED764B;

    private struct __StaticArrayInitTypeSize=1964 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=2797 : System.ValueType
    {
    }
}

private class $BurstDirectCallInitializer
{
    private static void Initialize();
}
