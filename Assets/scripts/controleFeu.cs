using System;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class controleFeu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject feu1;
    public GameObject feu2;
    public GameObject feu3;
    public GameObject feu4;

    public float vitesseFeu1;
    public float vitesseFeu2;
    public float vitesseFeu3;
    public float vitesseFeu4;

    public bool perte;

    public AudioSource audioSource;
    public AudioClip sonFeu;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        feu1.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
        feu2.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
        feu3.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
        feu4.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);

        vitesseFeu1 = UnityEngine.Random.Range(0.0002f, 0.0006f);
        vitesseFeu2 = UnityEngine.Random.Range(0.0002f, 0.0006f);
        vitesseFeu3 = UnityEngine.Random.Range(0.0002f, 0.0006f);
        vitesseFeu4 = UnityEngine.Random.Range(0.0002f, 0.0006f);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(vitesseFeu);
        if (feu1.transform.localScale.x > 0)
        {
            feu1.transform.localScale -= new Vector3(vitesseFeu1, vitesseFeu1, vitesseFeu1);
        }
        if (feu2.transform.localScale.x > 0)
        {
            feu2.transform.localScale -= new Vector3(vitesseFeu2, vitesseFeu2, vitesseFeu2);
        }
        if (feu3.transform.localScale.x > 0)
        {
            feu3.transform.localScale -= new Vector3(vitesseFeu3, vitesseFeu3, vitesseFeu3);
        }
        if (feu4.transform.localScale.x > 0)
        {
            feu4.transform.localScale -= new Vector3(vitesseFeu4, vitesseFeu4, vitesseFeu4);
        }

        if (feu1.transform.localScale.x <= 0 && feu2.transform.localScale.x <= 0 && feu3.transform.localScale.x <= 0 && feu4.transform.localScale.x <= 0)
        {
            //Debug.Log("fin du jeu declenché");
            SceneManager.LoadScene(2);
        }
    }

    public void vitesseReset()
    {
        vitesseFeu1 = UnityEngine.Random.Range(0.0002f, 0.0006f);
        vitesseFeu2 = UnityEngine.Random.Range(0.0002f, 0.0006f);
        vitesseFeu3 = UnityEngine.Random.Range(0.0002f, 0.0006f);
        vitesseFeu4 = UnityEngine.Random.Range(0.0002f, 0.0006f);
        audioSource.PlayOneShot(sonFeu);
    }
}
