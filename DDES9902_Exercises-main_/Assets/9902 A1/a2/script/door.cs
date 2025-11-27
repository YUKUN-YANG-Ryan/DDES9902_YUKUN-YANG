using System.Collections;
using UnityEngine;

public class door : MonoBehaviour
{
    public Vector3 open;
    public Vector3 close;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void Open()
    {
        transform.localEulerAngles = open;
    }

    public void Close()
    {
        StopAllCoroutines();
        StartCoroutine(delayClose());
    }

    IEnumerator delayClose()
    {
        yield return new WaitForSeconds(1.5f);
        transform.localEulerAngles = close;
    }
}
