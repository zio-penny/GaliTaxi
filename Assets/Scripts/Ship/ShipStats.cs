using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ShipStats : MonoBehaviour
{
    [SerializeField] float _mass = 8f; // metric tons

    [SerializeField] float _mainThrust = 64f; // newtons
    [SerializeField] float _mainOverdriveMultiplier = 2.5f;

    [SerializeField] float _retroThrust = 8f; // newtons
    [SerializeField] float _retroOverdriveMultiplier = 1.5f;

    //[SerializeField] float _maxSpeed = 64f; // meters per second, TODO: revisit this later, maybe determined by autopilot

    [SerializeField] float _torqueThrust = 8f; // radians? - angularVel += _torqueThrust * deltatime / mass
    [SerializeField] float _MaxRotation = 6.28f; // Radians per second
    [SerializeField] float _overdriveMultiplier = 4f;

    [SerializeField] float _forwardDragMultiplier = 1.0f;
    [SerializeField] float _sideDragMultiplier = 2.0f;
    [SerializeField] float _backDragMultiplier = 4.0f;

    public float Mass => _mass;

    public float MainThrust => _mainThrust;
    public float OverdriveMainThrust => _mainOverdriveMultiplier;
    public float RetroThrust => _retroThrust;
    //public float MaxSpeed => _maxSpeed;
    public float RotationThrust => _torqueThrust;
    public float MaxRotation => _MaxRotation;
    public float OverdriveMultiplier => _overdriveMultiplier;

    public float ForwardDragMultiplier => _forwardDragMultiplier;
    public float SideDragMultiplier => _sideDragMultiplier;
    public float BackDragMultiplier => _backDragMultiplier;
}
