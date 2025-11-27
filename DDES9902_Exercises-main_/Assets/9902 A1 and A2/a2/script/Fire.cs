using UnityEngine;

public class Fire : MonoBehaviour
{
    public ExtinguisherType[] affectTypes;

    public void Extinguish(ExtinguisherType type)
    {
        foreach (ExtinguisherType atype in affectTypes)
        {
            if (atype == type)//match
            {
                Debug.Log("Fire type match!");
                gameObject.SetActive(false);
            }
        }
    }
}