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
        for(int i = 0; i < _pads.Count; i++)
        {
            _pads[i].InitPad(i);
            _pads[i].OnPlayerCollide += CheckPad;
        }
    }

    public void SetPlanet(Planet planet)
    {
        _planet = planet;
    }

    private void CheckPad(PadBehaviour pad)
    {
        Debug.Log($"Player Touched {pad.name}");
    }

    private void OnDisable()
    {
        for (int i = 0; i < _pads.Count; i++)
        {
            _pads[i].InitPad(i);
            _pads[i].OnPlayerCollide -= CheckPad;
        }
    }
}
