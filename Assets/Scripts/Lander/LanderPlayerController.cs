using UnityEngine;
using UnityEngine.InputSystem;
using static GaliTaxiInput;

public class LanderPlayerController : MonoBehaviour, IFlightActions, ILanderInput
{
    float _mainThrottle = 0f;
    public float MainThrottle => _mainThrottle;

    float _strafeThrottle = 0f;
    public float StrafeThrottle => _strafeThrottle;

    public event StrutNotify OnStrutToggle;
    public event ArmDisarmNotify OnArmDisarmToggle;

    GaliTaxiInput _playerControls;

    private void OnEnable()
    {
        if (_playerControls == null)
        {
            _playerControls = new GaliTaxiInput();
            _playerControls.Flight.SetCallbacks(this);
        }

        _playerControls.Flight.Enable();
    }

    private void OnDisable()
    {
        _playerControls.Flight.Disable();
    }

    public void OnMainThrust(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Started:
            case InputActionPhase.Performed:
            case InputActionPhase.Canceled:
                _mainThrottle = context.ReadValue<float>();
                break;
        }
    }
    public void OnStrafe(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Started:
            case InputActionPhase.Performed:
            case InputActionPhase.Canceled:
                _strafeThrottle = context.ReadValue<float>();
                break;
        }
    }

    public void OnToggleStruts(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Performed:
                OnStrutToggle.Invoke();
                break;
        }
    }
    public void OnArmDisarm(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Performed:
                OnArmDisarmToggle.Invoke();
                break;
        }
    }
}
