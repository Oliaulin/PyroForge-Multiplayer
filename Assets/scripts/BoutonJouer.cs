using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoutonJouer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void boutonJouer()
    {
        SceneManager.LoadScene(1);
    }

    public void boutonMenuPrincipal()
    {
        SceneManager.LoadScene(0);
    }
}
