using UnityEngine;

public class newVitesseFeu : MonoBehaviour
{
    public controleFeu controleFeu;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider autreObjet)
    {
        if (autreObjet.tag == "balle")
        {
            //Debug.Log("strike!");
            controleFeu.vitesseReset();
            if (gameObject.name == "VFX_Fire_01_Big_Simple-1")
            {
                controleFeu.feu1.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
            } else if (gameObject.name == "VFX_Fire_01_Big_Simple-2")
            {
                controleFeu.feu2.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
            } else if (gameObject.name == "VFX_Fire_01_Big_Simple-3")
            {
                controleFeu.feu3.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
            } else if (gameObject.name == "VFX_Fire_01_Big_Simple-4")
            {
                controleFeu.feu4.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
            }
        }

        if (autreObjet.tag == "glace")
        {
            //Debug.Log("strike!");
            controleFeu.vitesseReset();
            if (gameObject.name == "VFX_Fire_01_Big_Simple-1")
            {
                controleFeu.feu1.transform.localScale -= new Vector3(0.2f, 0.2f, 0.2f);
            }
            else if (gameObject.name == "VFX_Fire_01_Big_Simple-2")
            {
                controleFeu.feu2.transform.localScale -= new Vector3(0.2f, 0.2f, 0.2f);
            }
            else if (gameObject.name == "VFX_Fire_01_Big_Simple-3")
            {
                controleFeu.feu3.transform.localScale -= new Vector3(0.2f, 0.2f, 0.2f);
            }
            else if (gameObject.name == "VFX_Fire_01_Big_Simple-4")
            {
                controleFeu.feu4.transform.localScale -= new Vector3(0.2f, 0.2f, 0.2f);
            }
        }
    }
}
