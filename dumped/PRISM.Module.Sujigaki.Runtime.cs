
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

// Namespace: Sujigaki
public enum SujigakiCameraCutType : System.Enum
{
    public int value__;
    public static Sujigaki.SujigakiCameraCutType FaceUp;
    public static Sujigaki.SujigakiCameraCutType BustUp;
    public static Sujigaki.SujigakiCameraCutType UpperUp;
    public static Sujigaki.SujigakiCameraCutType LowerUp;
    public static Sujigaki.SujigakiCameraCutType FullBody;
    public static Sujigaki.SujigakiCameraCutType RootBase;
    public static Sujigaki.SujigakiCameraCutType LeftHand;
    public static Sujigaki.SujigakiCameraCutType RightHand;
    public static Sujigaki.SujigakiCameraCutType Stage;
}

// Namespace: Sujigaki
public enum SujigakiCharacterPopPositionType : System.Enum
{
    public int value__;
    public static Sujigaki.SujigakiCharacterPopPositionType Origin;
    public static Sujigaki.SujigakiCharacterPopPositionType Front;
    public static Sujigaki.SujigakiCharacterPopPositionType Right;
    public static Sujigaki.SujigakiCharacterPopPositionType Left;
}

// Namespace: Sujigaki
public enum SujigakiEpisodeLineDirectionStageType : System.Enum
{
    public int value__;
    public static Sujigaki.SujigakiEpisodeLineDirectionStageType Unknown;
    public static Sujigaki.SujigakiEpisodeLineDirectionStageType Delay;
    public static Sujigaki.SujigakiEpisodeLineDirectionStageType PopCharacter;
    public static Sujigaki.SujigakiEpisodeLineDirectionStageType RemoveCharacter;
    public static Sujigaki.SujigakiEpisodeLineDirectionStageType CameraCut;
    public static Sujigaki.SujigakiEpisodeLineDirectionStageType Background;
    public static Sujigaki.SujigakiEpisodeLineDirectionStageType Prop;
    public static Sujigaki.SujigakiEpisodeLineDirectionStageType Bgm;
    public static Sujigaki.SujigakiEpisodeLineDirectionStageType Environment;
    public static Sujigaki.SujigakiEpisodeLineDirectionStageType Se;
    public static Sujigaki.SujigakiEpisodeLineDirectionStageType Fade;
    public static Sujigaki.SujigakiEpisodeLineDirectionStageType CrossFade;
    public static Sujigaki.SujigakiEpisodeLineDirectionStageType Wind;
    public static Sujigaki.SujigakiEpisodeLineDirectionStageType CameraShake;
}

// Namespace: Sujigaki
public enum SujigakiEpisodeLineType : System.Enum
{
    public int value__;
    public static Sujigaki.SujigakiEpisodeLineType Text;
    public static Sujigaki.SujigakiEpisodeLineType AudioRecording;
    public static Sujigaki.SujigakiEpisodeLineType DirectionText;
    public static Sujigaki.SujigakiEpisodeLineType Acting;
    public static Sujigaki.SujigakiEpisodeLineType Direction;
    public static Sujigaki.SujigakiEpisodeLineType Choice;
    public static Sujigaki.SujigakiEpisodeLineType Jump;
    public static Sujigaki.SujigakiEpisodeLineType Label;
}
