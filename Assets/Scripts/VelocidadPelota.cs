using UnityEngine;

public class VelocidadPelota : MonoBehaviour
{
    public float velocidadHorizontal = 4;

    private Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        rb.linearVelocity = new Vector2(velocidadHorizontal, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
