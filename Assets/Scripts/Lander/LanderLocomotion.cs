using UnityEngine;

public class LanderLocomotion : BaseLocomotion
{
    [SerializeField] float _mainPower = 48f;
    [SerializeField] float _strafePower = 32f;
    [SerializeField] ILanderInput _input;
    
    override protected void Awake()
    {
        base.Awake();   

        if(_input == null)
        {
            _input= GetComponent<ILanderInput>();
        }
    }

    override protected void FixedUpdate()
    {
        base.FixedUpdate();
        _body.AddForce(_input.MainThrottle * _mainPower * transform.up + _input.StrafeThrottle * _strafePower * transform.right);
    }
}
