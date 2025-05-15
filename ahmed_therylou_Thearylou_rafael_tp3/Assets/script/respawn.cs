using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;

public class respawn : MonoBehaviour
{
    public XROrigin xr;
    private void Start()
    {
       // xr = GetComponent<XROrigin>();
    }
    public GameObject positionRespawn;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "voiture")
        {
            xr.MoveCameraToWorldLocation(positionRespawn.transform.position);
               
        } 
    }
}
