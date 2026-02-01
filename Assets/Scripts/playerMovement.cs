using UnityEngine;

public class playerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    float h;
    float v;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");

            rb.linearVelocity = new Vector2 (h,v).normalized * speed;

        
        
    }
}
