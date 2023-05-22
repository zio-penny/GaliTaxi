using UnityEngine;
using UnityEngine.InputSystem;

public class LanderController : MonoBehaviour
{
    [SerializeField] LanderStruts _struts;

    float _mainThrottle = 0f;
    public float MainThrottle => _mainThrottle;

    float _strafeThrottle = 0f;
    public float StrafeThrottle => _strafeThrottle;

    private void Awake()
    {
        _struts = GetComponentInChildren<LanderStruts>();
    }
}
