using UnityEngine;

public class Propulsion : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidBody;
    [SerializeField] private float _thrustPower = 256f;
    [SerializeField] private float _throttle = 0.0f;
    [SerializeField] private bool _inverseThruster = false;

    public float MaxThrustPower => _thrustPower;
    public float Throttle => _throttle;

    private void Awake()
    {
        if (!_rigidBody)
            _rigidBody = GetComponentInParent<Rigidbody>();

    }

    private void FixedUpdate()
    {
        _rigidBody.AddForceAtPosition(transform.up * _thrustPower * Throttle, transform.position);    
    }

    public void SetThrottle(float throttle)
    {
        _throttle = throttle;
    }
}
