using UnityEngine;

public class LanderLocomotion : MonoBehaviour
{
    [SerializeField] Rigidbody _body;

    public float UprightStrength = 0.0f;
    public float UprightDamper = 0.0f;

    Vector3 _mainThrottleForce = Vector3.zero;
    Vector3 _strafeThrottleForce = Vector3.zero;

    

    private void Awake()
    {
        if (_body == null)
        {
            _body = GetComponent<Rigidbody>();
        }
    }

    private void FixedUpdate()
    {
        _body.AddForce(_mainThrottleForce + _strafeThrottleForce);

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
}
