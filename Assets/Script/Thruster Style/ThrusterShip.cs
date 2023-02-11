using UnityEngine;
using UnityEngine.InputSystem;
using static GaliTaxiInput;

public class ThrusterShip : MonoBehaviour, IFlightActions
{
    [SerializeField] Propulsion _thruster;
    [SerializeField] Propulsion _retroThruster;
    [SerializeField] Propulsion _leftThruster;
    [SerializeField] Propulsion _rightThruster;

    private GaliTaxiInput _input;
    
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

    public void OnMainThrust(InputAction.CallbackContext context)
    {
        _thruster.SetThrottle(Mathf.Max(context.ReadValue<float>(), 0.0f));
        _retroThruster.SetThrottle(Mathf.Max(-context.ReadValue<float>(), 0.0f));
    }

    public void OnPitch(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnRoll(InputAction.CallbackContext context)
    {
        _leftThruster.SetThrottle(Mathf.Max(-context.ReadValue<float>(), 0.0f));
        _rightThruster.SetThrottle(Mathf.Max(context.ReadValue<float>(), 0.0f));
    }

    public void OnYaw(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"Collision: {collision.collider}", collision.gameObject);
        
    }

    public void OnOverdrive(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }
}
