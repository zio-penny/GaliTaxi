using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;
using static GaliTaxiInput;

/// <summary>
/// 
/// 
/// 
/// </summary>

public class DynamicShip : MonoBehaviour, IFlightActions
{
    private Rigidbody _rigidBody;
    private ShipStats _shipStats;

    private GaliTaxiInput _input;

    private float _mainThrottle;
    private float _thrust;
    private float _yawThrottle;
    private float _rotation;
    private float _overdriveThrottle;



    private float _addedDrag;
    private float _addedAngularDrag;

    private List<PhysicsVolume> _physicsVolumes= new List<PhysicsVolume>();

    [SerializeField] private bool _armed = false;
    public bool Armed => _armed;

    [SerializeField] private bool _flipMode = false;
    public bool FlipMode => _flipMode;

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
        // might need checks here
    }

    private void FixedUpdate()
    {
        ProcessInput();
        ProcessPhysics();
    }



    private void ProcessInput()
    {        
        if(!_armed)
        {
            return;
        }

        if (_mainThrottle != 0.0f)
        {
            bool forwardThrust = _mainThrottle >= 0f;
            
            float overdriveMultiplier = forwardThrust ? _shipStats.MainODMultiplier : _shipStats.RetroODMultiplier;
            _thrust = forwardThrust ? _shipStats.MainThrust : _shipStats.RetroThrust;
            _thrust *= _mainThrottle;

            _thrust *= 1 + (overdriveMultiplier * _overdriveThrottle);
            if (_flipMode && forwardThrust) _thrust *= .25f; // forward thrust is rerouted to other thrusters
        } else _thrust = 0.0f;

        if(_yawThrottle != 0.0f)
        {
            _rotation = _shipStats.RotationThrust * _yawThrottle;
            if (_flipMode) _rotation *= (_shipStats.OverdriveMultiplier * _overdriveThrottle);
        } else _rotation = 0.0f;
    }

    private void ProcessPhysics()
    {
        _rigidBody.AddForce(transform.up * _thrust);
        _rigidBody.AddTorque(-transform.forward * _rotation, ForceMode.Force);

        // Clear Drag value
        _addedDrag = 0.0f;
        _addedAngularDrag = 0.0f;

        // add values from global, volumes, and aerodynamics
        foreach(PhysicsVolume volume in _physicsVolumes)
        {
            foreach(PhysicsVolumeAttribute attribute in volume.Attributes)
            {
                switch(attribute.ForceType)
                {
                    case ForceType.ADDFORCE:
                        _rigidBody.AddForce(attribute.X, attribute.Y, 0);
                        break;
                    case ForceType.ADDDRAG:
                        _addedDrag += attribute.X;
                        _addedAngularDrag += attribute.Y;
                        break;
                    case ForceType.ATTRACTREPEL:
                        Vector3 _directionToVolumeOrigin = volume.transform.position - transform.position;
                        _directionToVolumeOrigin.Normalize();
                        _rigidBody.AddForce(_directionToVolumeOrigin * attribute.X);
                        break;
                    default:
                        Debug.LogWarning($"Unknown ForceType: {attribute.ForceType}", this);
                        break;
                }
            }
        }


        float facingDragMultiplier;
        float velocityAndFacingDot = Vector3.Dot(_rigidBody.velocity.normalized, transform.up);
        
        // May work better with animation curves instead of lerp
        if(velocityAndFacingDot > 0.0f)
        {
            facingDragMultiplier = Mathf.Lerp(_shipStats.SideDragMultiplier, _shipStats.ForwardDragMultiplier, velocityAndFacingDot);
        } else
        {
            facingDragMultiplier = Mathf.Lerp(_shipStats.SideDragMultiplier, _shipStats.BackDragMultiplier, Mathf.Abs(velocityAndFacingDot));

        }
        _rigidBody.drag = (Environment.Instance.Drag + _addedDrag) * facingDragMultiplier;

        float rotationRatioDrag = Mathf.Max(1,_rigidBody.angularVelocity.z / _shipStats.MaxRotation);
        _rigidBody.angularDrag = (Environment.Instance.AngularDrag + _addedAngularDrag) * rotationRatioDrag;
    }

    public void OnMainThrust(InputAction.CallbackContext context)
    {
        _mainThrottle = context.ReadValue<float>();
    }

    public void OnYaw(InputAction.CallbackContext context)
    {
        _yawThrottle= context.ReadValue<float>();
    }

    public void OnOverdrive(InputAction.CallbackContext context)
    {
        _overdriveThrottle= context.ReadValue<float>();
    }

    public void OnFlipMode(InputAction.CallbackContext context)
    {
        switch(context.phase)
        {
            case InputActionPhase.Performed: _flipMode = !_flipMode; 
                break;
        }
    }

    public void OnArmDisarm(InputAction.CallbackContext context)
    {
        switch(context.phase)
        {
            case InputActionPhase.Performed: _armed = !_armed;
                break;
        }

        if(!_armed) { _flipMode = false; }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<PhysicsVolume>() != null)
        {
            PhysicsVolume volume = other.GetComponent<PhysicsVolume>();
            if(!_physicsVolumes.Contains(volume)) _physicsVolumes.Add(volume);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PhysicsVolume>() != null)
        {
            PhysicsVolume volume = other.GetComponent<PhysicsVolume>();
            _physicsVolumes.Remove(volume);
        }
    }
}
