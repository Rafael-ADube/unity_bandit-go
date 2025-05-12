using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_destruction : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "voiture")
        {
            Destroy(other.gameObject);
        }
    }
}
