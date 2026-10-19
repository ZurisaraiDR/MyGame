using UnityEngine;

public class NaveMovimiento : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Rigidbody2D rb;
    void Start()
    {
         rb = GetComponent<Rigidbody2D>();
    }

     public float propulsorForce = 80f;

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector2.up * propulsorForce, ForceMode2D.Force);
            // transform.Translate(Vector3.up * propulsorForce * Time.deltaTime);
        };

         if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector2.left * propulsorForce, ForceMode2D.Force);
            // transform.Translate(Vector3.left * propulsorForce * Time.deltaTime);
        };

         if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector2.right * propulsorForce, ForceMode2D.Force);
            // transform.Translate(Vector3.right * propulsorForce * Time.deltaTime);
        };

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector2.down * propulsorForce, ForceMode2D.Force);
            // transform.Translate(Vector3.down * propulsorForce * Time.deltaTime);
        };
    }
}
