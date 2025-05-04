using UnityEngine;

public class KickBall : MonoBehaviour
{
    public float kickForce = 5f; // Default force
    public Vector3 kickDirection = new Vector3(0, 0.1f, 1); // Slightly upward

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Kick(5f); // Low speed
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Kick(10f); // Medium speed
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Kick(40f); // High speed
        }
    }
    void Kick(float force)
    {
        rb.linearVelocity = Vector3.zero; // Reset any previous velocity
        rb.AddForce(kickDirection.normalized * force, ForceMode.Impulse);
    }
}
