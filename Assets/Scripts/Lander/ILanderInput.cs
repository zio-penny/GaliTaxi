public interface ILanderInput

{
    public float MainThrottle { get; }
    public float StrafeThrottle { get; }

    public event StrutNotify OnStrutToggle;
    public event ArmDisarmNotify OnArmDisarmToggle;
}

public delegate void StrutNotify();
public delegate void ArmDisarmNotify();