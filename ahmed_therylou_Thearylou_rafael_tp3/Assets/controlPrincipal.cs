using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlPrincipal : MonoBehaviour
{
    public GameObject[] voiture;
    public Transform[] spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("courroutineVoiture");
    }

    // Update is called once per frame
    public IEnumerator courroutineVoiture()
    {
        while(true)
        {
            for (int i = 0; i < spawnPoint.Length; i++)
            {
                Instantiate(voiture[0], spawnPoint[i].position, spawnPoint[i].rotation);
            }
            yield return new WaitForSeconds(Random.Range(0.5f , 3f)); 
        }
    }

}
