using System;
using System.Collections;
using UnityEngine;

public class doortriger : MonoBehaviour
{
    public door mdoor;

    public GameObject tips;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            mdoor.Open();
            tips.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            mdoor.Close();
            StartCoroutine(delayHIDE());
        }
    }

    IEnumerator delayHIDE()
    {
        yield return new WaitForSeconds(10f);
        tips.SetActive(false);
    }
}
