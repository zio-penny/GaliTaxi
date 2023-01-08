using UnityEngine;

public class Propulsion : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidBody;
    [SerializeField] private float _mainThrustPower = 256f;
    [SerializeField] private Transform[] _thrusters;

    public float MaxThrustPower => _mainThrustPower;
    public float Throttle = 0.0f;

    private void Awake()
    {
        if (!_rigidBody)
            _rigidBody = GetComponentInParent<Rigidbody>();

    }

    private void FixedUpdate()
    {
        // get ground effect
        // shoot ray down from each
        _rigidBody.AddForce(transform.up * _mainThrustPower * Throttle);
        
    }
}
