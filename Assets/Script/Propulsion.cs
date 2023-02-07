using UnityEngine;

public class Propulsion : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidBody;
    [SerializeField] private float _mainThrustPower = 256f;
    [SerializeField] private float _throttle = 0.0f;

    public float MaxThrustPower => _mainThrustPower;
    public float Throttle => _throttle;

    private void Awake()
    {
        if (!_rigidBody)
            _rigidBody = GetComponentInParent<Rigidbody>();

    }

    private void FixedUpdate()
    {
        if(_throttle > 0.0f)
        {
            _rigidBody.AddForceAtPosition(transform.up * _mainThrustPower * Throttle, transform.position);

        }        
    }

    public void SetThrottle(float throttle)
    {
        _throttle = throttle;
    }
}
