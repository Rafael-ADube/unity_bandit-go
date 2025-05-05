using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class voiture_rouge : MonoBehaviour
{
    public AudioSource sourceSonore;
    public AudioClip avancer;
    public AudioClip klaxon;
    public GameObject voitureDestruction;


    private int random;

    public float vitesseVoiture = 30f;

    private void Start()
    {
        StartCoroutine("jouerSon");
    }

    public IEnumerator jouerSon()
    {
        yield return new WaitWhile(() => sourceSonore.isPlaying);

        random = Random.Range(0, 6);

        if (random <= 4)
        {
            sourceSonore.PlayOneShot(avancer);
        } else if (random == 5)
        {
            sourceSonore.PlayOneShot(klaxon);
        }
        StartCoroutine(jouerSon());
        yield break;
    }
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * vitesseVoiture);
        Destroy(voitureDestruction.gameObject, 10f);
    }
}
