using System.Collections.Generic;
using UnityEngine;

public class LanderSceneManager : MonoBehaviour
{
    [SerializeField] Planet _planet;
    [SerializeField] GameObject _player;
    [SerializeField] List<PadBehaviour> _pads;

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

    private void CheckPad(PadBehaviour pad)
    {
        Debug.Log($"Player Touched {pad.name}");
    }
}
