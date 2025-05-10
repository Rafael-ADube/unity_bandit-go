using UnityEngine;
using UnityEngine.Events;

public class Trigger : MonoBehaviour
{
    [SerializeField] UnityEvent onTriggerEnter;
    [SerializeField] UnityEvent onTriggerExit;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("voiture")) return; 
        onTriggerEnter.Invoke();
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("voiture")) return; 
        onTriggerExit.Invoke();
    }
}
