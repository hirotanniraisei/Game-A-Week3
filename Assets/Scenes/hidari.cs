using UnityEngine;

public class hidari : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float moveY = 0f;

        // QÇ≈è„ÅAAÇ≈â∫
        if (Input.GetKey(KeyCode.E))
        {
            moveY = 1f;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            moveY = -1f;
        }

        rb.linearVelocity = new Vector2(0, moveY * speed);
    }
}
