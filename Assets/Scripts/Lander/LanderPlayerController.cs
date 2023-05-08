using UnityEngine;
using UnityEngine.InputSystem;
using static GaliTaxiInput;

public class LanderPlayerController : LanderInput, IFlightActions
{
    GaliTaxiInput _input;
    float _main = 0f;
    float _strafe = 0f;
    override public float MainThrottle => _main;
    override public float StrafeThrottle => _strafe;

    private void OnEnable()
    {
        if(_input == null)
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


    public void OnArmDisarm(InputAction.CallbackContext context)
    {
        //throw new System.NotImplementedException();
    }

    public void OnFlipMode(InputAction.CallbackContext context)
    {
        //throw new System.NotImplementedException();
    }

    public void OnMainThrust(InputAction.CallbackContext context)
    {
        //Debug.Log(context.ReadValue<float>());
        switch (context.phase)
        {
            case InputActionPhase.Started:
            case InputActionPhase.Performed:
                _main = context.ReadValue<float>();
                break;
            case InputActionPhase.Canceled:
                _main = 0.0f;
                break;
        }
    }

    public void OnOverdrive(InputAction.CallbackContext context)
    {
        //throw new System.NotImplementedException();
    }

    public void OnYaw(InputAction.CallbackContext context)
    {
        switch(context.phase)
        {
            case InputActionPhase.Started:
            case InputActionPhase.Performed:
                _strafe = context.ReadValue<float>();
                break;
            case InputActionPhase.Canceled:
                _strafe = 0.0f;
                break;
        }
    }
}
