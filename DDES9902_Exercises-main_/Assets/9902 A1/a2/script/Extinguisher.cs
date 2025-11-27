using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

namespace _9902_A1
{
    public class Extinguisher : MonoBehaviour
    {
        public ExtinguisherType extinguishType;
        public Transform firePoint;
        public AudioSource maudiosource;

        public void Spray()
        {
            Debug.Log("affect");
            if (Physics.Raycast(firePoint.position, firePoint.forward, out RaycastHit hit))
            {
                Debug.Log(hit.collider.name);
                if (hit.collider.tag == "Fire")
                {
                    Fire fire = hit.collider.GetComponent<Fire>();
                    fire.Extinguish(extinguishType);
                    maudiosource.Play();
                }
            }
        }

        public void stop()
        {
            maudiosource.Stop();
        }
    }
}