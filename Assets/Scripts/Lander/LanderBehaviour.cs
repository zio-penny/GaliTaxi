using UnityEngine;

public class LanderBehaviour : MonoBehaviour
{
    [SerializeField] float _maxHullPoints = 128f;
    float _hullPoints = 128f;

    Rigidbody _rigidBody;
    
    private void Awake()
    {
        if(_rigidBody == null)
        {
            _rigidBody = GetComponent<Rigidbody>();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        AddHullPoints(-1 * collision.relativeVelocity.magnitude * _rigidBody.mass);
        Debug.Log($"Collision Damage: {collision.relativeVelocity.magnitude * _rigidBody.mass}");
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
