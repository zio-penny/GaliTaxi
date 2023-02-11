using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipStats : MonoBehaviour
{
    [SerializeField] float _mass = 16f;
    [SerializeField] float _mainThrust = 128f;
    [SerializeField] float _retroThrust = 16f;
    [SerializeField] float _rotationThrust = 8f;
    [SerializeField] float _overdriveMultiplier = 4.0f;

    public float Mass => _mass;
    public float MainThrust => _mainThrust;
    public float RetroThrust => _retroThrust;
    public float RotationThrust => _rotationThrust;
    public float OverdriveMultiplier => _overdriveMultiplier;
}
