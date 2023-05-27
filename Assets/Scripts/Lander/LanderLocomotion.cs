using UnityEngine;

public class LanderLocomotion : BaseLocomotion
{
    [SerializeField] LanderBehaviour _lander;
    
    override protected void Awake()
    {
        base.Awake();
        _lander = GetComponent<LanderBehaviour>();
    }

    override protected void FixedUpdate()
    {
        base.FixedUpdate();
        _body.AddForce(_lander.Input.MainThrottle * _lander.MainPower * transform.up + _lander.Input.StrafeThrottle * _lander.StrafePower * transform.right);
    }
}
