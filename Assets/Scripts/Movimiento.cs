using UnityEngine;

public class Movimiento : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() // todo lo que se inicializa una vez después de iniciar la escena(play)
    {}

    public float speed = 10f; // Variable para controlar la velocidad de movimiento

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)){ 
            Debug.Log("Flecha Arriba");
            transform.Translate(Vector3.up * speed * Time.deltaTime); // Multiplicamos por Time.deltaTime para que el movimiento sea independiente de la velocidad de fotogramas
          
        };

        if(Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)){
              Debug.Log("Flecha Abajo");
              transform.Translate(Vector3.down * speed * Time.deltaTime);
              
        };

        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)){
              Debug.Log("Flecha A la Izquierda");
              transform.Translate(Vector3.left * speed * Time.deltaTime);
              
        };

        if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)){
            Debug.Log("Flecha A la Derecha");
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            
        };
        }
    }

