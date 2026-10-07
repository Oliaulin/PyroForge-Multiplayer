using UnityEngine;

public class balleRetour : MonoBehaviour
{
    private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -10 || transform.position.x > 10)
        {
            gameObject.transform.position = new Vector3(0, 1, 2);
            rb.linearVelocity = new Vector3(0, 0, 0);
        }
        if (transform.position.z < -10 || transform.position.z > 10)
        {
            gameObject.transform.position = new Vector3(0, 1, 2);
            rb.linearVelocity = new Vector3(0, 0, 0);
        }
    }
}
