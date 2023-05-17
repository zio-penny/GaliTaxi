using UnityEngine;

public abstract class LanderInput: MonoBehaviour
{
    virtual public float MainThrottle { get; }
    virtual public float StrafeThrottle { get; }

}