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
    private float _overdriveThrottle;

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
            float thrust = _mainThrottle > 0.0f ? _shipStats.MainThrust : _shipStats.RetroThrust;
            thrust *= _mainThrottle;
            thrust *= 1 + (_shipStats.OverdriveMultiplier * _overdriveThrottle); 
            _rigidBody.AddForce(transform.up * thrust);
        }

        if(_yawThrottle != 0.0f)
        {
            float rotation = _shipStats.RotationThrust * _yawThrottle;
            rotation *= 1 + (_shipStats.OverdriveMultiplier * _overdriveThrottle * 4);
            _rigidBody.AddTorque(-transform.forward * rotation);
        }
    }

    public void UpdateRigidBody()
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

    public void OnOverdrive(InputAction.CallbackContext context)
    {
        _overdriveThrottle= context.ReadValue<float>();
    }
}
