using UnityEngine;
using TMPro;

public class RetroActionMains : MonoBehaviour
{

    public TextMeshProUGUI preuve;
    public AudioSource musique; 
    //public GameObject balle;
    //Vector3 originalScale;

    void Start()
    {
        //originalScale = balle.transform.localScale;
        //preuve.text = originalScale.ToString();
    }
    public void Pistolet()
    {
        preuve.text = "Pistolet OK";   
    }

    public void Mauvais()
    {
        preuve.text = "Mauvais Doigt OK";
    }
     public void Point()
    {
        preuve.text = "point ferme OK";
    }
     public void MusiqueOn()
    {
        preuve.text = "Musique On";
        if(!musique.isPlaying)
        {
            musique.Play();
        }
    }
      public void MusiqueOff()
    {
        preuve.text = "Musique Off";
        musique.Pause();
    }
        public void HautBalle()
    {
        preuve.text = "Au dessus de la balle";
        //balle.transform.localScale = originalScale * 0.5f;
    }
    public void Effacer()
    {
        
        //balle.transform.localScale = originalScale;
        preuve.text = "";//originalScale.ToString();
    }

}
