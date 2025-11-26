using _9902_A1;
using UnityEngine;

public class MyPlayer : MonoBehaviour
{
    RaycastInteractor rayInteractor;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rayInteractor = GetComponent<RaycastInteractor>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.G))
        {
            if (rayInteractor.moveSubject != null)
            {
                var extinguisher = rayInteractor.moveSubject.GetComponent<Extinguisher>();
                if (extinguisher != null)
                {
                    extinguisher.Spray();
                }
            }
        }

        if (Input.GetKeyUp(KeyCode.G))
        {
            if (rayInteractor.moveSubject != null)
            {
                var extinguisher = rayInteractor.moveSubject.GetComponent<Extinguisher>();
                if (extinguisher != null)
                {
                    extinguisher.stop();
                }
            }
        }
    }
}