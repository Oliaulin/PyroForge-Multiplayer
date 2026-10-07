using UnityEngine;

public class AvatarFootTracking : MonoBehaviour
{
    [Header("Références")]
    [SerializeField] private Transform xrHead;
    [SerializeField] private Transform leftFootTarget;
    [SerializeField] private Transform rightFootTarget;

    [Header("Position des pieds")]
    [SerializeField] private float distanceEntreLesPieds = 0.24f;
    [SerializeField] private float decalageVersArriere = 0.05f;
    [SerializeField] private float hauteurDuPied = 0.02f;

    [Header("Détection du sol")]
    [SerializeField] private LayerMask solLayer;
    [SerializeField] private float hauteurRayon = 1f;
    [SerializeField] private float distanceRayon = 2f;

    [Header("Lissage")]
    [SerializeField] private float vitessePosition = 12f;
    [SerializeField] private float vitesseRotation = 12f;

    private void Update()
    {
        if (xrHead == null ||
            leftFootTarget == null ||
            rightFootTarget == null)
        {
            return;
        }

        // Direction horizontale dans laquelle regarde le joueur.
        Vector3 forward = xrHead.forward;
        forward.y = 0f;

        if (forward.sqrMagnitude < 0.001f)
            forward = transform.forward;

        forward.Normalize();

        // Direction droite/gauche du joueur.
        Vector3 right = Vector3.Cross(Vector3.up, forward).normalized;

        Vector3 centreDesPieds =
            xrHead.position - forward * decalageVersArriere;

        float demiDistance = distanceEntreLesPieds * 0.5f;

        Vector3 positionGauche =
            centreDesPieds - right * demiDistance;

        Vector3 positionDroite =
            centreDesPieds + right * demiDistance;

        PlacerPied(leftFootTarget, positionGauche, forward);
        PlacerPied(rightFootTarget, positionDroite, forward);
    }

    private void PlacerPied(
        Transform footTarget,
        Vector3 positionSouhaitee,
        Vector3 forward)
    {
      Vector3 origineRayon = new Vector3(
        positionSouhaitee.x,
         xrHead.position.y + hauteurRayon,
        positionSouhaitee.z);

        Vector3 positionFinale = positionSouhaitee;
        Vector3 normaleDuSol = Vector3.up;

        if (Physics.Raycast(
            origineRayon,
            Vector3.down,
            out RaycastHit hit,
            distanceRayon,
            solLayer,
            QueryTriggerInteraction.Ignore))
        {
            positionFinale = hit.point +
                             hit.normal * hauteurDuPied;

            normaleDuSol = hit.normal;
        }

        footTarget.position = Vector3.Lerp(
            footTarget.position,
            positionFinale,
            vitessePosition * Time.deltaTime);

        // Oriente le pied vers l'avant tout en suivant
        // légèrement l'inclinaison du sol.
        Vector3 directionSurLeSol =
            Vector3.ProjectOnPlane(forward, normaleDuSol);

        if (directionSurLeSol.sqrMagnitude > 0.001f)
        {
            Quaternion rotationFinale =
                Quaternion.LookRotation(
                    directionSurLeSol.normalized,
                    normaleDuSol);

            footTarget.rotation = Quaternion.Slerp(
                footTarget.rotation,
                rotationFinale,
                vitesseRotation * Time.deltaTime);
        }
    }
}