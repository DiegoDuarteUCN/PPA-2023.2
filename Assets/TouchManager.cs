using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchManager : MonoBehaviour
{
    // Variable que almacena el touch
    private Touch touch;

    // Variable que detecta si es que se está tocando la pantalla
    private bool isTouching = false;

    // Update is called once per frame
    void Update()
    {
        TouchPhases();
    }

    public void TouchPhases() 
    {
        // Validar si estoy presionando la pantalla
        if (Input.touchCount > 0) 
        {
            // Variable tipo touch para almacenar el tipo de touch
            touch = Input.GetTouch(0);

            switch (touch.phase) 
            {
                case TouchPhase.Began:
                    Debug.Log("Detecta cuando estoy comenzando el touch en el teléfono");
                    isTouching = true;
                    break;
                case TouchPhase.Canceled:
                    Debug.Log("Se pierde la referencia del touch en el teléfono");
                    isTouching = false;
                    break;
                case TouchPhase.Ended:
                    Debug.Log("Detecta cuando estoy dejando el touch en el teléfono");
                    isTouching = false;
                    break;
                case TouchPhase.Moved:
                    Debug.Log("Detecta cuando estoy moviendo los dedos en el touch del teléfono");
                    isTouching = true;
                    break;
                case TouchPhase.Stationary:
                    Debug.Log("Detecta cuando me mantengo con el touch en el teléfono");
                    isTouching = true;
                    break;
            }
        }
    }

    private void FixedUpdate()
    {
        MouseInputDebug();
        TouchInputDebug();
    }

    public void MouseInputDebug() 
    {
        // Si yo presiono la barra espaciadora
        if (Input.GetKey(KeyCode.Mouse0)) 
        {
            // Crear un rayo que va desde el inicio de mi camara a donde está el mouse
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // Detectar la colision de este rayo cuando finalice
            RaycastHit hit;

            // Le damos una distancia de largo
            float rayDistance = 100f;

            // Debugueamos en la ventana de Scene si el rayo funciona correctamente
            Debug.DrawRay(ray.origin, ray.direction * rayDistance, Color.red);

            // Condicionamos con qué choca nuestro Rayo
            if (Physics.Raycast(ray, out hit, rayDistance)) 
            {
                // SI yo colisiono con un elemento que tenga un collider
                if (hit.collider != null) 
                {
                    // Debugueo con qué colisioné
                    Debug.Log("Estoy colisionando con el objeto: " + hit.collider.gameObject.name);
                }
            }
        }
    }
    public void TouchInputDebug()
    {
        Vector3 touchPosition = touch.position;

        // Si yo presiono la barra espaciadora
        if (isTouching)
        {
            // Crear un rayo que va desde el inicio de mi camara a donde está el mouse
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // Detectar la colision de este rayo cuando finalice
            RaycastHit hit;

            // Le damos una distancia de largo
            float rayDistance = 100f;

            // Debugueamos en la ventana de Scene si el rayo funciona correctamente
            Debug.DrawRay(ray.origin, ray.direction * rayDistance, Color.red);

            // Condicionamos con qué choca nuestro Rayo
            if (Physics.Raycast(ray, out hit, rayDistance))
            {
                // SI yo colisiono con un elemento que tenga un collider
                if (hit.collider != null)
                {
                    // Debugueo con qué colisioné
                    Debug.Log("Estoy colisionando con el objeto: " + hit.collider.gameObject.name);
                }
            }
        }
    }
}
