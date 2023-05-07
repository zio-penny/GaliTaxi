using System.Collections.Generic;
using UnityEngine;

public class LanderSceneManager : MonoBehaviour
{
    [SerializeField] Planet _planet;
    [SerializeField] List<Rigidbody> _bodyList;

    private void Start()
    {
        Init();
    }

    public void Init()
    {
        Physics.gravity = _planet.Gravity;
    }

    public void SetPlanet(Planet planet)
    {
        _planet = planet;
    }
}
