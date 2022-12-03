using UnityEngine;

public class Ship : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"Collision: {collision.collider}", collision.gameObject);
        
    }

}
