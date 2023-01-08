 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipFoot : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _springRestDistance = 2f;
    [SerializeField] private float _springStrength = 128f;
    [SerializeField] private float _springDamper = 16f;
    [SerializeField] Transform _footMesh;
    private void Awake()
    {
        if (!_rigidbody)
            _rigidbody = GetComponentInParent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, -transform.up, out hit , _springRestDistance))
        {
            
            Vector3 tireWorldVelocity = _rigidbody.GetPointVelocity(transform.position);
            float offset = _springRestDistance - hit.distance;
            float velocity = Vector3.Dot(transform.up, tireWorldVelocity);
            float force = (offset * _springStrength) - (velocity * _springDamper);
            _rigidbody.AddForceAtPosition(transform.up * force, transform.position);
            Debug.DrawRay(transform.position, hit.distance * -transform.up, Color.magenta, 0.2f);
            _footMesh.localPosition = Vector3.down * hit.distance;

        } else
        {
            _footMesh.localPosition = Vector3.down * _springRestDistance;
        }

    }
}
