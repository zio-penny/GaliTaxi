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
    [SerializeField] GameObject _footPrefab;

    ILanderInput _input;

    LanderBehaviour _parentLander;
    PadBehaviour _currentPad = null;
    bool _isDocked = false;

    GameObject _leftFootVisual;
    GameObject _rightFootVisual;

    public Vector3 LeftStrutOrigin => transform.position + (-transform.right * _strutWidth);
    public Vector3 RightStrutOrigin => transform.position + (transform.right * _strutWidth);

    private void Awake()
    {
        _parentRB = GetComponentInParent<Rigidbody>();
        _parentLander = _parentRB.GetComponent<LanderBehaviour>();
        _input = GetComponentInParent<ILanderInput>();
    }

    private void OnEnable()
    {
        _input.OnStrutToggle += ToggleStruts;
    }

    private void OnDisable()
    {
        _input.OnStrutToggle -= ToggleStruts;
    }

    private void Start()
    {   
        _leftFootVisual = Instantiate(_footPrefab, transform);
        _leftFootVisual.SetActive(_strutEnabled);
        _rightFootVisual = Instantiate(_footPrefab, transform);
        _rightFootVisual.SetActive(_strutEnabled);
    }
    private void FixedUpdate()
    {
        if (_strutEnabled)
        {
            RaycastHit leftHit;
            RaycastHit rightHit;

            PadBehaviour leftPad = null;
            PadBehaviour rightPad = null;
            
            if(Physics.Raycast(LeftStrutOrigin, -transform.up, out leftHit, _strutHeight))
            {
                leftPad = leftHit.collider.gameObject.GetComponent<PadBehaviour>();

                Vector3 worldVelocity = _parentRB.GetPointVelocity(LeftStrutOrigin);
                float offset = _strutHeight - leftHit.distance;
                float velocity = Vector3.Dot(transform.up, worldVelocity);
                float force = (offset * _strutStrength) - (velocity * _strutDamper);

                _parentRB.AddForceAtPosition(transform.up * force, LeftStrutOrigin);
                float xVelocity = worldVelocity.x;
                float desiredAcceleration = (-xVelocity * _strutGrip) / Time.fixedDeltaTime;
                _parentRB.AddForceAtPosition(Vector3.right * _strutMass * desiredAcceleration, LeftStrutOrigin);
                _leftFootVisual.transform.position = leftHit.point;
            } else
            {
                _leftFootVisual.transform.position = LeftStrutOrigin + (-transform.up * _strutHeight);
            }

            if (Physics.Raycast(RightStrutOrigin, -transform.up, out rightHit, _strutHeight))
            {
                rightPad = rightHit.collider.gameObject.GetComponent<PadBehaviour>();

                Vector3 worldVelocity = _parentRB.GetPointVelocity(RightStrutOrigin);
                float offset = _strutHeight - rightHit.distance;
                float velocity = Vector3.Dot(transform.up, worldVelocity);
                float force = (offset * _strutStrength) - (velocity * _strutDamper);

                _parentRB.AddForceAtPosition(transform.up * force, RightStrutOrigin);
                float xVelocity = worldVelocity.x;
                float desiredAcceleration = (-xVelocity * _strutGrip) / Time.fixedDeltaTime;
                _parentRB.AddForceAtPosition(Vector3.right * _strutMass * desiredAcceleration, RightStrutOrigin);
                _rightFootVisual.transform.position = rightHit.point;
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
