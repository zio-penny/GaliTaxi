using UnityEngine;
using UnityEngine.InputSystem;
using static GaliTaxiInput;

public class LanderLocomotion : MonoBehaviour, IFlightActions
{
    [SerializeField] Rigidbody _body;

    public float MainPower = 16f;
    public float StrafePower = 8f;

    public float UprightStrength = 8.0f;
    public float UprightDamper = 0.1f;
    [SerializeField] LanderPlayerController _input;

    
    private void Awake()
    {
        if(_body == null)
        {
            _body= GetComponent<Rigidbody>();
        }

        if(_input == null)
        {
            _input= GetComponent<LanderPlayerController>();
        }
    }

    private void FixedUpdate()
    {
        _body.AddForce(_input.MainThrottle * MainPower * Vector3.up + _input.StrafeThrottle * StrafePower * Vector3.right);
        UpdateUprightForce();
    }

    public void UpdateUprightForce()
    {
        Quaternion currentRotation = transform.rotation;
        Quaternion toGoal = ShortestRotation(Quaternion.identity, currentRotation);

        float rotationDegrees;
        Vector3 rotationAxis;
        toGoal.ToAngleAxis(out rotationDegrees, out rotationAxis);
        rotationAxis.Normalize();

        float rotationRadians = rotationDegrees * Mathf.Deg2Rad;

        _body.AddTorque((rotationAxis * (rotationRadians * UprightStrength)) - (_body.angularVelocity * UprightDamper));
    }

    public static Quaternion ShortestRotation(Quaternion a, Quaternion b)
    {

        if (Quaternion.Dot(a, b) < 0)

        {

            return a * Quaternion.Inverse(Multiply(b, -1));

        }

        else return a * Quaternion.Inverse(b);

    }
    public static Quaternion Multiply(Quaternion input, float scalar)

    {

        return new Quaternion(input.x * scalar, input.y * scalar, input.z * scalar, input.w * scalar);

    }

    public void OnMainThrust(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnYaw(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnOverdrive(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnFlipMode(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnArmDisarm(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }
}
