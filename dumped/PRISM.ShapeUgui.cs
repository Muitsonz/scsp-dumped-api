
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

// Namespace: PRISM
public class LineMeshHelperUgui
{
    public static UnityEngine.Vector2[] GetLineDirections(UnityEngine.Vector2[] originVertices, bool isClosed);
    public static System.ValueTuple<UnityEngine.UIVertex[], int[]> GetLineMesh(UnityEngine.Vector2[] originVertices, float rightTickness, float leftTickness, UnityEngine.Color32 color, bool isClosed);
}

// Namespace: PRISM
public struct Matrix2x2 : System.ValueType
{
    public float a;
    public float b;
    public float c;
    public float d;
    public PRISM.Matrix2x2 identity { get; set; }
    public PRISM.Matrix2x2 zero { get; set; }
    public float determinant { get; set; }
    public PRISM.Matrix2x2 inverse { get; set; }
    public PRISM.Matrix2x2 transpose { get; set; }
    public UnityEngine.Matrix4x4 matrix4x4 { get; set; }
    public static PRISM.Matrix2x2 GetRotationMatrix(float angle);
    public static PRISM.Matrix2x2 op_Addition(PRISM.Matrix2x2 lhs, PRISM.Matrix2x2 rhs);
    public static PRISM.Matrix2x2 op_Multiply(PRISM.Matrix2x2 lhs, PRISM.Matrix2x2 rhs);
    public static UnityEngine.Vector2 op_Multiply(PRISM.Matrix2x2 lhs, UnityEngine.Vector2 vector);
    public static PRISM.Matrix2x2 op_Multiply(PRISM.Matrix2x2 lhs, float s);
    public static PRISM.Matrix2x2 op_Multiply(float s, PRISM.Matrix2x2 lhs);
    public string ToString();
    public static UnityEngine.Vector2 ChangeOfBasis(UnityEngine.Vector2 vector, PRISM.Matrix2x2 originBasis, PRISM.Matrix2x2 changeOfBasis);
    public static UnityEngine.Vector2 ChangeOfBasis(UnityEngine.Vector2 vector, UnityEngine.Vector2 originBasisColumn1, UnityEngine.Vector2 originBasisColumn2, UnityEngine.Vector2 changeOfBasisColumn1, UnityEngine.Vector2 changeOfBasisColumn2);
    public static UnityEngine.Vector2 ChangeOfBasis(UnityEngine.Vector2 vector, PRISM.Matrix2x2 changeOfBasis);
    public static UnityEngine.Vector2 ChangeOfBasis(UnityEngine.Vector2 vector, UnityEngine.Vector2 changeOfBasisVectorColumn1, UnityEngine.Vector2 changeOfBasisVectorColumn2);
}

// Namespace: PRISM
public class ShapeOutlineUgui : UnityEngine.UI.MaskableGraphic, ENTERPRISE.UI.IIsIgnoreParentColor
{
    private UnityEngine.Texture _texture;
    private PRISM.IShapeUgui _shapeUgui;
    private bool _isIgnoreParentColor;
    public UnityEngine.Texture texture { get; set; }
    public UnityEngine.Texture mainTexture { get; set; }
    public bool isMonospased { get; set; }
    public UnityEngine.Vector3 scaleOffset { get; set; }
    public UnityEngine.Vector2 basisVectorX { get; set; }
    public UnityEngine.Vector2 basisVectorY { get; set; }
    public float scaleAspect { get; set; }
    public float size { get; set; }
    public System.Collections.Generic.List<UnityEngine.Vector2> positions { get; set; }
    public int positionCount { get; set; }
    public bool IsIgnoreParentColor { get; set; }
    public UnityEngine.Color color { get; set; }
    private UnityEngine.Vector2 GetObjectToWorld(UnityEngine.Vector2 origin);
    protected void OnRectTransformDimensionsChange();
    public void SetOutlineParameter(PRISM.IShapeUgui shapeUgui);
    protected void OnPopulateMesh(UnityEngine.UI.VertexHelper vh);
    private void SetupMesh(UnityEngine.UI.VertexHelper& vh);
    private void SetupMonospacedOutline(UnityEngine.UI.VertexHelper& vh);
    private bool IsInside(UnityEngine.Vector2 basisPosition, UnityEngine.Vector2[] vertices);
    private System.ValueTuple<UnityEngine.Vector2, UnityEngine.Vector2> GetVertexPosition(UnityEngine.Vector2 originPosition, UnityEngine.Vector2 centerPosition);
    private UnityEngine.Vector2 GetCenterPosition(System.Collections.Generic.IReadOnlyCollection<UnityEngine.Vector2> positions, UnityEngine.Rect rect);
    public void SetDirty();

    private class <>c__DisplayClass35_0
    {
        public UnityEngine.Rect rect;
        public PRISM.ShapeOutlineUgui <>4__this;
        private UnityEngine.Vector2 <SetupMonospacedOutline>b__0(UnityEngine.Vector2 p);
    }
}

// Namespace: PRISM
public interface IShapeUgui
{
    public System.Collections.Generic.List<UnityEngine.Vector2> vertices { get; set; }
    public int vertexCount { get; set; }
    public float outlineSize { get; set; }
    public bool isMonospacedOutline { get; set; }
    public UnityEngine.Color outlineColor { get; set; }
    public UnityEngine.RectTransform rectTransform { get; set; }
    public UnityEngine.Vector3 scaleOffset { get; set; }
    public UnityEngine.Vector2 basisVectorX { get; set; }
    public UnityEngine.Vector2 basisVectorY { get; set; }
}

// Namespace: PRISM
public class ShapeUgui : UnityEngine.UI.MaskableGraphic, ENTERPRISE.UI.IIsIgnoreParentColor, PRISM.IShapeUgui
{
    private UnityEngine.Texture _texture;
    private System.Collections.Generic.List<UnityEngine.Vector2> _vertices;
    private float _outlineSize;
    private UnityEngine.Vector3 _scaleOffset;
    private bool _isMonospacedOutline;
    private UnityEngine.Color _outlineColor;
    private PRISM.ShapeOutlineUgui _outline;
    private bool _isIgnoreParentColor;
    private bool _isDirtyOutline;
    private UnityEngine.Bounds _bounds;
    public UnityEngine.Texture texture { get; set; }
    public UnityEngine.Texture mainTexture { get; set; }
    public System.Collections.Generic.List<UnityEngine.Vector2> vertices { get; set; }
    public int vertexCount { get; set; }
    public float outlineSize { get; set; }
    public UnityEngine.Vector3 scaleOffset { get; set; }
    public UnityEngine.Vector3 outlineScale { get; set; }
    public UnityEngine.Vector2 basisVectorX { get; set; }
    public UnityEngine.Vector2 basisVectorY { get; set; }
    public bool isMonospacedOutline { get; set; }
    public UnityEngine.Color outlineColor { get; set; }
    public bool IsIgnoreParentColor { get; set; }
    public UnityEngine.Color color { get; set; }
    public UnityEngine.Bounds bounds { get; set; }
    public void SetDirtyOutline();
    protected void Awake();
    private void Update();
    private void UpdateOutline();
    protected void OnRectTransformDimensionsChange();
    protected void OnPopulateMesh(UnityEngine.UI.VertexHelper vh);
    public UnityEngine.Vector2 GetPositionFromNormalizePosition(UnityEngine.Vector2 normalizePosition);
    public static UnityEngine.Vector2 GetPositionFromNormalizePosition(UnityEngine.Vector2 normalizePosition, UnityEngine.Rect rect);
    public UnityEngine.Vector2 GetNormalizePositionFromPosition(UnityEngine.Vector2 targetPosition);
    private UnityEngine.Vector2 GetCenterPoint();
    public int GetPositions(UnityEngine.Vector3[] positions);
    public void SetPositions(UnityEngine.Vector3[] positions);
    public void SetVertices(UnityEngine.Vector2[] vertices);
    public void SetVertex(int index, UnityEngine.Vector2 vertex);
    public void UpdateBounds();
    public void SetDirty();
}

// Namespace: PRISM
public class SplitScreen : UnityEngine.MonoBehaviour
{
    private static UnityEngine.Vector2 DefaultSensorSize;
    private UnityEngine.Animator captureAnimator;
    private PRISM.SplitScreenCaptureCamera captureCamera;
    private Cinemachine.CinemachineVirtualCamera virtualCamera;
    private UnityEngine.RenderTexture captureRenderTexture;
    private UnityEngine.GameObject displayRootObject;
    private UnityEngine.Animator displayAnimator;
    private UnityEngine.Canvas canvas;
    private UnityEngine.UI.RawImage backgroundImage;
    private UnityEngine.UI.RawImage captureDisplayImage;
    private PRISM.ShapeUgui shape;
    private bool isIgnore1FrameDissolve;
    private bool isIgnoreDrawReflection;
    private UnityEngine.RenderTexture dynamicCreatedRenderTexture;
    public UnityEngine.Animator CaptureAnimator { get; set; }
    public PRISM.SplitScreenCaptureCamera CaptureCamera { get; set; }
    public Cinemachine.CinemachineVirtualCamera VirtualCamera { get; set; }
    public UnityEngine.Animator DisplayAnimator { get; set; }
    public UnityEngine.UI.RawImage BackgroundImage { get; set; }
    public bool IsIgnore1FrameDissolve { get; set; }
    public bool IsIgnoreDrawReflection { get; set; }
    private void Awake();
    private void OnDisable();
    private void _setupRenderTexture();
    private void _attachRenderTexture(UnityEngine.RenderTexture captureTexture);
    public UnityEngine.RenderTexture CreateRenderTexture(UnityEngine.Vector2Int size);
    private static UnityEngine.RenderTexture _createRenderTexture(UnityEngine.Vector2Int size, string gameObjectName);
    private void Update();
    private void _updateCaptureDisplayCanvas();
    private void _updateRenderTexture();
    private bool _isNeedCreateRenderTexture();
    public bool TryGetDisplaySize(UnityEngine.Vector2Int& size);
    public static UnityEngine.Timeline.ControlTrack FindControlTrack(UnityEngine.IExposedPropertyTable propertyTable, System.Collections.Generic.List<UnityEngine.Timeline.ControlTrack> controlTracks, UnityEngine.Object targetObject);
    public void AdjustSensorSize();
}

// Namespace: PRISM
public class SplitScreenCaptureCamera : UnityEngine.MonoBehaviour
{
    private UnityEngine.Camera myCamera;
    private bool <IsCompleteFirstRendering>k__BackingField;
    public UnityEngine.Camera MyCamera { get; set; }
    public bool IsCompleteFirstRendering { get; set; }
    private void OnEnable();
    private void OnDisable();
    private void _onEndCameraRendering(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera targetCamera);
    public void SetTargetTexture(UnityEngine.RenderTexture renderTexture);
}

// Namespace: ENTERPRISE.UI
public interface IIsIgnoreParentColor
{
    public bool IsIgnoreParentColor { get; set; }
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=213 01D543A526AC1192F33C2288DF9E4857ED72A1D54DA0A04BD6F835B260217D33;
    private static __StaticArrayInitTypeSize=366 F100462EDF7CD93DDBF8373EC6558655FE25C6FC8A6E5E0ABCA6334A27F1DA1E;

    private struct __StaticArrayInitTypeSize=213 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=366 : System.ValueType
    {
    }
}
