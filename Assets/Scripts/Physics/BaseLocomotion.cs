using UnityEditorInternal;
using UnityEngine;

public class BaseLocomotion : MonoBehaviour
{
    [SerializeField] protected Rigidbody _body;
    [SerializeField] protected bool _isUprighting = true;
    public bool UprightActive => _isUprighting;
    public float UprightStrength = 8.0f;
    public float UprightDamper = 2f;

    
    protected virtual void Awake()
    {
        if(_body == null)
        {
            _body= GetComponent<Rigidbody>();
        }
    }

    protected virtual void FixedUpdate()
    {
        if (_isUprighting) UpdateUprightForce();
    }

    protected void UpdateUprightForce()
    {
        if (transform.rotation == Quaternion.identity) return;

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
