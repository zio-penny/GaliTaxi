using UnityEngine;
using UnityEngine.Events;
using static GaliTaxiInput;

public interface ILanderInput

{
    public float MainThrottle { get; }
    public float StrafeThrottle { get; }

    public event StrutNotify OnStrutToggle;

}

public delegate void StrutNotify();