using System;
using UnityEngine;

public class TeleortAnchor : MonoBehaviour
{
    public Transform player;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            player.GetComponent<RaycastInteractor>().DropMovable();
            player.position = Vector3.zero;
            
        }
    }
}
