using UnityEngine;

public class CambioColor : MonoBehaviour
{
    private SpriteRenderer spriteRenderer; // referencia al componente SpriteRenderer del GameObject
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Busca el componente SpriteRenderer en el GameObject 
     spriteRenderer = GetComponent<SpriteRenderer>();   
    }

// metodo para cambio de color

public void CambiarColor(Color nuevoColorPorTecla)
    {
        spriteRenderer.color = nuevoColorPorTecla; // Cambia el color del sprite a un nuevo color
    }

    //Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            spriteRenderer.color = Color.purple;
        }  
   
    }
}