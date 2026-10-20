using UnityEngine;
using UnityEngine.InputSystem;

public class MovimientoInput : MonoBehaviour
{
    public float velocidad = 5f;
    private Vector2 movimiento;

    public void OnMove(InputValue value)
    {
        movimiento = value.Get<Vector2>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direcction = new Vector3(movimiento.x, movimiento.y, 0f);
        transform.Translate(direcction * velocidad * Time.deltaTime);
    }
}
