using UnityEngine;

public class NaveEquilibrio : MonoBehaviour
{
    public float fuerza = 8f;
    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector2 direccion = new Vector2(horizontal, vertical);

        rb.AddForce(direccion * fuerza);
    }
}
