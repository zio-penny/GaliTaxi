using UnityEngine;

public class QuintThrustArray : MonoBehaviour
{
    [SerializeField] Propulsion[] _thrusters;
    public Propulsion[] Thrusters => _thrusters;


}
