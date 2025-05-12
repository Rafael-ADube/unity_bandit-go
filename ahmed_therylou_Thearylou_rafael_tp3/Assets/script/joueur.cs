using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class joueur : MonoBehaviour
{
   
    public DynamicMoveProvider dynamicMoveProvider;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bonus")
        {
            dynamicMoveProvider.moveSpeed = 100f;
        }
        else if (other.tag == "Malus")
        {
            dynamicMoveProvider.moveSpeed = 3f;
        }
    }

  
}
