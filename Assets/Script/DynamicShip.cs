using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static GaliTaxiInput;

public class DynamicShip : MonoBehaviour, IFlightActions
{
    private Rigidbody _rigidBody;
    private ShipStats _shipStats;

    private GaliTaxiInput _input;

    private float _mainThrottle;
    private float _yawThrottle;

    private void OnEnable()
    {
        if (_input == null)
        {
            _input = new GaliTaxiInput();
            _input.Flight.SetCallbacks(this);
        }

        _input.Flight.Enable();
    }

    private void OnDisable()
    {
        _input.Flight.Disable();
    }

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
        _shipStats = GetComponent<ShipStats>();
        
        UpdateRigidBody();
    }

    private void FixedUpdate()
    {
        ProcessInput();
    }

    private void ProcessInput()
    {
        if (_mainThrottle != 0.0f)
        {
            Vector3 maxThrust = _mainThrottle > 0.0f ? 
                transform.up * _shipStats.MainThrust: 
                transform.up * _shipStats.RetroThrust;

            _rigidBody.AddForce(maxThrust * _mainThrottle);
        }

        if(_yawThrottle != 0.0f)
        {
            _rigidBody.AddTorque(-transform.forward * _shipStats.RotationThrust * _yawThrottle);
        }
    }

    void UpdateRigidBody()
    {
        _rigidBody.mass = _shipStats.Mass;
    }

    public void OnMainThrust(InputAction.CallbackContext context)
    {
        _mainThrottle = context.ReadValue<float>();
    }

    public void OnPitch(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnRoll(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnYaw(InputAction.CallbackContext context)
    {
        _yawThrottle= context.ReadValue<float>();
    }
}
