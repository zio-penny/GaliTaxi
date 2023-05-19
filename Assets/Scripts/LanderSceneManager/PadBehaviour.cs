using System.Collections.Generic;
using UnityEngine;

public class PadBehaviour : MonoBehaviour
{
    [SerializeField] Vector3 _passengerSpawn = new Vector3(0,0.5f, -0.75f);
    List<LanderBehaviour> _landers = new List<LanderBehaviour>();
    public List<LanderBehaviour> Landers => _landers;


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

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawSphere(transform.position + _passengerSpawn, 0.2f);
    }
}
