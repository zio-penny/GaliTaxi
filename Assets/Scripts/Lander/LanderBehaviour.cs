using UnityEngine;

public class LanderBehaviour : MonoBehaviour
{
    [SerializeField] float _maxHullPoints = 128f;
    float _hullPoints = 128f;

    [SerializeField] float _mainPower = 48f;
    public float MainPower => _mainPower;

    [SerializeField] float _strafePower = 32f;
    public float StrafePower => _strafePower;

    Rigidbody _rigidBody;
    public Rigidbody Rigidbody => _rigidBody;

    ILanderInput _landerInput;
    public ILanderInput Input => _landerInput;
    
    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
        _landerInput = GetComponent<ILanderInput>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody otherRB = collision.gameObject.GetComponent<Rigidbody>();
        if (otherRB)
        {
            float relativeMass = otherRB.mass / _rigidBody.mass;
            if(relativeMass < 1.0f)
            {
                AddHullPoints(-1 * collision.relativeVelocity.magnitude * _rigidBody.mass * relativeMass);
            }
            Debug.Log($"RB Collision: {collision.relativeVelocity.magnitude * _rigidBody.mass * relativeMass} hp, Relative Mass: {relativeMass}, Remaining Hull: {_hullPoints}");
        }
            
        AddHullPoints(-1 * collision.relativeVelocity.magnitude * _rigidBody.mass);
        Debug.Log($"Remaining Hull: {_hullPoints}");
    }

    public void AddHullPoints(float amount)
    {
        _hullPoints = _hullPoints + amount > _maxHullPoints ? _maxHullPoints : _hullPoints + amount;
        if(_hullPoints < 0f)
        {
            Die();
        }
    }

    public void Die()
    {
        AudioManager.Instance.PlayDeathSound();
        Destroy(gameObject);
    }
}
