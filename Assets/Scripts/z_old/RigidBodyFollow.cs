using UnityEngine;

public class RigidBodyFollow: MonoBehaviour
{
    public bool _isFollowing = true;
    public Transform _target;
    [SerializeField] float _offset = -16f;
    [SerializeField] float _lookAheadMaximumLength = 32f;
    [SerializeField] float _lookAheadMultiplier = 4.0f;
    [SerializeField] float _maxMoveSpeed = 512f;

    private void Start()
    {

    }

    private void Update()
    {
        if(_isFollowing && _target != null) 
        {
            Vector3 desiredPosition = _target.position;

            desiredPosition.z = _offset;
            transform.position = desiredPosition;
        }
    }

}
