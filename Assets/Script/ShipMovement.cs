using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShipMovement : MonoBehaviour
{
    public float Gravity = 9.81f;
    public Vector3 Velocity => _velocity;

    private Vector3 _velocity = Vector3.zero;
    private Vector3 _acceleration = Vector3.zero;
    
    private void Awake()
    {
    }

    // Update is called once per frame
    void Update()
    {
        _acceleration = Vector3.zero;
        _acceleration += Vector3.down * Gravity;



        _velocity += _acceleration;
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Debug.Log(hit.gameObject.name);
    }
}
