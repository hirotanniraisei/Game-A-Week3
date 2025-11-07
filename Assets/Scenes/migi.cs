using UnityEngine;

public class migi : MonoBehaviour
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

        if (Input.GetKey(KeyCode.Q))
        {
            moveY = 1f;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            moveY = -1f;
        }

        rb.linearVelocity = new Vector2(0, moveY * speed);
    }
}