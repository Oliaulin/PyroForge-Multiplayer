using UnityEngine;
using TMPro;

public class AfficherTexte : MonoBehaviour
{
    // Champ dans lequel l'utilisateur écrit
    public TMP_InputField champSaisie;

    // Texte dans lequel on veut afficher le résultat
    public TMP_Text texteAffichage;


    // Cette fonction sera appelée par un bouton
    public void Afficher()
    {
        // Récupère le contenu du Input Field
        // et le copie dans le texte d'affichage
        texteAffichage.text = champSaisie.text;
    }
}