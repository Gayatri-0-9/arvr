using UnityEngine;

public class BallBouceController : MonoBehaviour
{
    public float bounceDuration = 5f;         // Duration in seconds
    public float dampingFactor = 0.98f;       // Gradual bounce reduction
    public float stopVelocityThreshold = 0.1f; // Minimum bounce speed to stop

    private Rigidbody rb;
    private float timer = 0f;
    private bool isDamping = false;
    private bool isStopped = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (isStopped)
            return;

        timer += Time.fixedDeltaTime;

        if (timer >= bounceDuration)
        {
            isDamping = true;
        }

        if (isDamping)
        {
            Vector3 velocity = rb.linearVelocity;

            // Gradually reduce vertical motion
            velocity.y *= dampingFactor;
            rb.linearVelocity = velocity;

            // Check if ball has come to rest
            if (Mathf.Abs(rb.linearVelocity.y) < stopVelocityThreshold && rb.transform.position.y <= 0.51f)
            {
                rb.linearVelocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
                rb.isKinematic = true; // Only freeze when it�s basically stopped and on the ground
                isStopped = true;
            }
        }
    }
}