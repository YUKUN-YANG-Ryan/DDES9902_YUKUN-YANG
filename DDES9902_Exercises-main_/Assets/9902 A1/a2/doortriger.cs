using System;
using UnityEngine;

public class doortriger : MonoBehaviour
{
    public door mdoor;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            mdoor.Open();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            mdoor.Close();
        }
    }
}
