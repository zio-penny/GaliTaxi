using UnityEngine;

public class LanderStruts : MonoBehaviour
{
    [SerializeField] private bool _strutEnabled = false;

    [SerializeField] private float _strutHeight = 1.0f;
    [SerializeField] private float _strutWidth = 0.5f;

    [SerializeField] private float _strutStrength = 8f;
    [SerializeField] private float _strutDamper = 1f;

    [SerializeField, Range(0.0f, 1.0f)] private float _strutGrip = 0.6f;
    [SerializeField] private float _strutMass = 16f;
    [SerializeField] Rigidbody _parentRB;

    public Vector3 LeftStrutOrigin => transform.position + (-transform.right * _strutWidth);
    public Vector3 RightStrutOrigin => transform.position + (transform.right * _strutWidth);

    private void Start()
    {
        if(_parentRB == null) { 
            _parentRB = GetComponentInParent<Rigidbody>();
        }
    }
    private void FixedUpdate()
    {
        if (_strutEnabled)
        {
            RaycastHit leftHit;
            RaycastHit rightHit;

            if(Physics.Raycast(LeftStrutOrigin, -transform.up, out leftHit, _strutHeight))
            {
                Vector3 worldVelocity = _parentRB.GetPointVelocity(LeftStrutOrigin);
                float offset = _strutHeight - leftHit.distance;
                float velocity = Vector3.Dot(transform.up, worldVelocity);
                float force = (offset * _strutStrength) - (velocity * _strutDamper);

                _parentRB.AddForceAtPosition(transform.up * force, LeftStrutOrigin);
                float xVelocity = worldVelocity.x;
                float desiredAcceleration = (-xVelocity * _strutGrip) / Time.fixedDeltaTime;
                _parentRB.AddForceAtPosition(Vector3.right * _strutMass * desiredAcceleration, LeftStrutOrigin);

            }

            if (Physics.Raycast(RightStrutOrigin, -transform.up, out rightHit, _strutHeight))
            {
                Vector3 worldVelocity = _parentRB.GetPointVelocity(RightStrutOrigin);
                float offset = _strutHeight - rightHit.distance;
                float velocity = Vector3.Dot(transform.up, worldVelocity);
                float force = (offset * _strutStrength) - (velocity * _strutDamper);

                _parentRB.AddForceAtPosition(transform.up * force, RightStrutOrigin);
                float xVelocity = worldVelocity.x;
                float desiredAcceleration = (-xVelocity * _strutGrip) / Time.fixedDeltaTime;
                _parentRB.AddForceAtPosition(Vector3.right * _strutMass * desiredAcceleration, RightStrutOrigin);

            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (_strutEnabled)
        {
            Gizmos.color = Color.green;
        } else
        {
            Gizmos.color = Color.red;
        }
            Gizmos.DrawLine(LeftStrutOrigin, LeftStrutOrigin + (Vector3.down * _strutHeight));
            Gizmos.DrawLine(RightStrutOrigin, RightStrutOrigin + (Vector3.down * _strutHeight));
    }

    public void ToggleStruts()
    {
        SetStruts(!_strutEnabled);
    }

    public void SetStruts(bool isOn)
    {
        _strutEnabled = isOn;
    }
}
