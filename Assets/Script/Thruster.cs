using UnityEngine;
using UnityEngine.InputSystem;
using static GaliTaxiInput;

public class Thruster : MonoBehaviour, IFlightActions
{
    [SerializeField] private Rigidbody _rigidBody;
    [SerializeField] private float _thrustPower = 256f;

    private float _throttle;
    private GaliTaxiInput _input;

    private void Awake()
    {
        if(!_rigidBody)
            _rigidBody = GetComponentInParent<Rigidbody>();

    }

    private void FixedUpdate()
    {
        _rigidBody.AddForceAtPosition(transform.up * _thrustPower * _throttle, transform.position);

    }


    private void OnEnable()
    {
        if(_input == null)
        {
            _input = new GaliTaxiInput();
            _input.Flight.SetCallbacks(this);
        }
        _input.Enable();
    }

    private void OnDisable()
    {
        _input.Disable();
    }

    public void OnMainThrust(InputAction.CallbackContext context)
    {
        switch(context.phase)
        {
            case InputActionPhase.Started:
            case InputActionPhase.Performed:
            case InputActionPhase.Canceled:
                _throttle = context.ReadValue<float>();
                break;
            default: break;

        }
    }

    public void OnYaw(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnPitch(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnRoll(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }
}
