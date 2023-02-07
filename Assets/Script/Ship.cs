using UnityEngine;
using UnityEngine.InputSystem;
using static GaliTaxiInput;

public class Ship : MonoBehaviour, IFlightActions
{
    [SerializeField] Propulsion _thruster;
    private GaliTaxiInput _input;
    
    private void Awake()
    {
        if(!_thruster)
        {
            _thruster = GetComponentInChildren<Propulsion>();
        }
    }

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
        _thruster.SetThrottle(context.ReadValue<float>());
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
        throw new System.NotImplementedException();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"Collision: {collision.collider}", collision.gameObject);
        
    }

}
