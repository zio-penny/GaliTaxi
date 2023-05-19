using UnityEngine;
using UnityEngine.InputSystem;
using static GaliTaxiInput;

public class LanderPlayerController : MonoBehaviour, ILanderInput, IFlightActions
{
    GaliTaxiInput _input;
    [SerializeField] LanderStruts _struts;

    float _mainThrottle = 0f;
    public float MainThrottle => _mainThrottle;

    float _strafeThrottle = 0f;
    public float StrafeThrottle => _strafeThrottle;

    public event StrutNotify OnStrutToggle;

    private void OnEnable()
    {
        if(_input == null)
        {
            _input = new GaliTaxiInput();
            _input.Flight.SetCallbacks(this);
        }

        if (_struts == null)
        {
            _struts = GetComponentInChildren<LanderStruts>();
        }

        _input.Flight.Enable();
    }

    private void OnDisable()
    {
        _input.Flight.Disable();
    }


    public void OnArmDisarm(InputAction.CallbackContext context)
    {
        switch(context.phase)
        {
            case InputActionPhase.Performed:
                OnStrutToggle?.Invoke();
                break;
        }
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
            case InputActionPhase.Canceled:
                _mainThrottle = context.ReadValue<float>();
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
            case InputActionPhase.Canceled:
                _strafeThrottle = context.ReadValue<float>();
                break;
        }
    }
}
