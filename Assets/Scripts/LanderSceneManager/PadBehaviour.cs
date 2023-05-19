using System;
using System.Collections.Generic;
using UnityEngine;

public class PadBehaviour : MonoBehaviour
{
    [SerializeField] int _padID;

    List<LanderBehaviour> _landers = new List<LanderBehaviour>();
    public int PadID => _padID;
    public void InitPad(int padID)
    {
        _padID = padID;
        name = $"Pad {_padID}";
    }

    public void Dock(LanderBehaviour lander)
    {
        if (_landers.Contains(lander))
        {
            Debug.LogError($"Attempting to add a lander ({lander.name}) twice");
        }
        else { 
            _landers.Add(lander);
            Debug.Log($"{name}: {lander.name} docked");        
        }
    }

    public void Undock(LanderBehaviour lander)
    {
        _landers.Remove(lander);
        Debug.Log($"{name}: {lander.name} UNdocked");

    }
}
