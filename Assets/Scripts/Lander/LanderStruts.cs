using UnityEngine;

public class LanderStruts : MonoBehaviour
{
    [SerializeField] private bool _strutEnabled = false;

    [SerializeField] private float _strutHeight = 1.0f;
    [SerializeField] private float _strutSensor = .2f;
    [SerializeField] private float _strutWidth = 0.5f;

    [SerializeField] private float _strutStrength = 8f;
    [SerializeField] private float _strutDamper = 1f;

    [SerializeField, Range(0.0f, 1.0f)] private float _strutGrip = 0.6f;
    [SerializeField] private float _strutMass = 16f;
    [SerializeField] GameObject _footPrefab;

    LanderBehaviour _parentLander;
    Rigidbody _parentRB;
    ILanderInput _input;

    PadBehaviour _currentPad = null;
    bool _isDocked = false;

    GameObject _leftFootVisual;
    GameObject _rightFootVisual;

    public Vector3 LeftStrutOrigin => transform.position + (-transform.right * _strutWidth);
    public Vector3 RightStrutOrigin => transform.position + (transform.right * _strutWidth);

    private void Start()
    {
        _parentLander = GetComponentInParent<LanderBehaviour>();
        _parentRB = _parentLander.Rigidbody;
        
        _input = _parentLander.Input;
        _input.OnStrutToggle += ToggleStruts;

        _leftFootVisual = Instantiate(_footPrefab, transform);
        _leftFootVisual.SetActive(_strutEnabled);
        _rightFootVisual = Instantiate(_footPrefab, transform);
        _rightFootVisual.SetActive(_strutEnabled);
    }

    private void OnEnable()
    {
        if(_input != null) _input.OnStrutToggle += ToggleStruts;
    }

    private void OnDisable()
    {
        _input.OnStrutToggle -= ToggleStruts;
    }

        
    private void FixedUpdate()
    {
        if (_strutEnabled)
        {
            RaycastHit leftHit;
            RaycastHit rightHit;

            PadBehaviour leftPad = null;
            PadBehaviour rightPad = null;
            
            if(Physics.Raycast(LeftStrutOrigin, -transform.up, out leftHit, _strutHeight + _strutSensor))
            {
                leftPad = leftHit.collider.gameObject.GetComponent<PadBehaviour>();

                Vector3 worldVelocity = _parentRB.GetPointVelocity(LeftStrutOrigin);
                float offset = _strutHeight - leftHit.distance;
                if (offset < 0f && _input.MainThrottle > 0.25f) // should probably inverse this or something
                {
                    
                } else
                {
                    float velocity = Vector3.Dot(transform.up, worldVelocity);
                    float force = (offset * _strutStrength) - (velocity * _strutDamper);

                    _parentRB.AddForceAtPosition(transform.up * force, LeftStrutOrigin);
                    float xVelocity = worldVelocity.x;
                    float desiredAcceleration = (-xVelocity * _strutGrip) / Time.fixedDeltaTime;
                    _parentRB.AddForceAtPosition(Vector3.right * _strutMass * desiredAcceleration, LeftStrutOrigin);
                    _leftFootVisual.transform.position = leftHit.point;
                }
            } else
            {
                _leftFootVisual.transform.position = LeftStrutOrigin + (-transform.up * _strutHeight);
            }

            if (Physics.Raycast(RightStrutOrigin, -transform.up, out rightHit, _strutHeight + _strutSensor))
            {
                rightPad = rightHit.collider.gameObject.GetComponent<PadBehaviour>();

                Vector3 worldVelocity = _parentRB.GetPointVelocity(RightStrutOrigin);
                float offset = _strutHeight - rightHit.distance;
                if (offset < 0f && _input.MainThrottle > 0.25f) 
                { 
                
                } else
                {
                    float velocity = Vector3.Dot(transform.up, worldVelocity);
                    float force = (offset * _strutStrength) - (velocity * _strutDamper);

                    _parentRB.AddForceAtPosition(transform.up * force, RightStrutOrigin);
                    float xVelocity = worldVelocity.x;
                    float desiredAcceleration = (-xVelocity * _strutGrip) / Time.fixedDeltaTime;
                    _parentRB.AddForceAtPosition(Vector3.right * _strutMass * desiredAcceleration, RightStrutOrigin);
                    _rightFootVisual.transform.position = rightHit.point;
                }
            } else
            {
                _rightFootVisual.transform.position = RightStrutOrigin + (-transform.up * _strutHeight);
            }

            if(leftPad && rightPad)
            {
                if(leftPad == rightPad && _parentRB.velocity.magnitude < 0.01f && !_isDocked)
                {
                    _currentPad = rightPad;
                    _currentPad.Dock(_parentLander);
                    _isDocked = true;
                }
            } else
            {
                if(_currentPad)
                {
                    _currentPad.Undock(_parentLander);
                    _currentPad = null;
                }
                _isDocked = false;
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

        Gizmos.DrawLine(LeftStrutOrigin, LeftStrutOrigin + (-transform.up * _strutHeight));
        Gizmos.DrawLine(RightStrutOrigin, RightStrutOrigin + (-transform.up * _strutHeight));

        Gizmos.color = Color.blue;
        Gizmos.DrawLine(LeftStrutOrigin + (-transform.up * _strutHeight), LeftStrutOrigin + (-transform.up * (_strutHeight + _strutSensor)));
        Gizmos.DrawLine(RightStrutOrigin + (-transform.up * _strutHeight), RightStrutOrigin + (-transform.up * (_strutHeight + _strutSensor)));
    }

    void ToggleStruts()
    {
        SetStruts(!_strutEnabled);
    }

    public void SetStruts(bool isOn)
    {
        _strutEnabled = isOn;
        _leftFootVisual.SetActive(isOn);
        _rightFootVisual.SetActive(isOn);
    }
}
