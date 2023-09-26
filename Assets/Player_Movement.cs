using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player_Movement : MonoBehaviour
{
    [SerializeField] private float velocity = 0.05f;
    public int coins = 0;
    public TextMeshProUGUI coinsText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Si yo Mantengo presionado la tecla flecha izquierda va a ocurrir algo
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-velocity,0,0);
        }
        // Si yo Mantengo presionado la tecla flecha derecha va a ocurrir algo
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(velocity,0,0);
        }
    }
    /// <summary>
    /// OnCollisionEnter is called when this collider/rigidbody has begun
    /// touching another rigidbody/collider.
    /// </summary>
    /// <param name="other">The Collision data associated with this collision.</param>
    void OnCollisionEnter(Collision other)
    {
        Debug.Log("Colisioné con el Objeto: " + other.gameObject.name);
    }
    void OnCollisionExit(Collision other)
    {
        Debug.Log("Dejé de colisionar con el Objeto: " + other.gameObject.name);
    }
    void OnCollisionStay(Collision other)
    {
        Debug.Log("Estoy colisionando con el Objeto: " + other.gameObject.name);
    }

    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Intersecté con el Objeto: " + other.gameObject.name);
        if(other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coins++;
            coinsText.text = " " + coins;
        }
    }
    void OnTriggerStay(Collider other)
    {
        Debug.Log("Estoy Intersectando con el Objeto: " + other.gameObject.name);
    }
    void OnTriggerExit(Collider other)
    {
        Debug.Log("Dejé de Intersectar con el Objeto: " + other.gameObject.name);
    }

}
