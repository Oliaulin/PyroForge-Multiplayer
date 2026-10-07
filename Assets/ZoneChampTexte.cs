using UnityEngine;

public class ZoneChampTexte : MonoBehaviour
{
    [SerializeField] private GameObject champTexte;
    [SerializeField] private Transform xrOrigin;

    private void OnTriggerEnter(Collider other)
    {
        // Vérifie si le collider appartient au XR Origin
        if (other.transform == xrOrigin || other.transform.IsChildOf(xrOrigin))
        {
            champTexte.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Le joueur quitte la plateforme
        if (other.transform == xrOrigin || other.transform.IsChildOf(xrOrigin))
        {
            champTexte.SetActive(false);
        }
    }
}
