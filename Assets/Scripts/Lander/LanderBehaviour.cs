using System;
using UnityEngine;

public class LanderBehaviour : MonoBehaviour
{
    [SerializeField] LanderStruts _struts;


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"Collision Velocity: {collision.relativeVelocity}");
        Debug.Log($"Collision magnitude: {collision.relativeVelocity.magnitude}");
    }
}
