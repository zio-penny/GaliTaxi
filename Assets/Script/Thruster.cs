using UnityEngine;

public class Thruster : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidBody;
    [SerializeField] private float _thrustPower = 256f;
    [SerializeField] private ThrustArray _thrustArray;

    public float Throttle = 0.0f;

    private void Awake()
    {
        if (!_rigidBody)
            _rigidBody = GetComponentInParent<Rigidbody>();

    }

    private void FixedUpdate()
    {
        _rigidBody.AddForceAtPosition(transform.up * _thrustPower * Throttle, transform.position);

    }
}
