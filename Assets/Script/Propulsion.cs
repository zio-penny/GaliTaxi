using UnityEngine;

public class Propulsion : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidBody;
    [SerializeField] private float _maxThrustPower = 256f;

    public float Throttle = 0.0f;

    private void Awake()
    {
        if (!_rigidBody)
            _rigidBody = GetComponentInParent<Rigidbody>();

    }

    private void FixedUpdate()
    {
        _rigidBody.AddForceAtPosition(transform.up * _maxThrustPower * Throttle, transform.position);

    }
}
