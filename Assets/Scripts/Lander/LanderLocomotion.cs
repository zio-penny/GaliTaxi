using UnityEngine;

public class LanderLocomotion : BaseLocomotion
{
    [SerializeField] float _mainPower = 48f;
    [SerializeField] float _strafePower = 32f;
    [SerializeField] ILanderInput _controller;
    
    override protected void Awake()
    {
        base.Awake();
        _controller = GetComponent<LanderController>();

    }

    override protected void FixedUpdate()
    {
        base.FixedUpdate();
        _body.AddForce(_controller.MainThrottle * _mainPower * transform.up + _controller.StrafeThrottle * _strafePower * transform.right);
    }
}
