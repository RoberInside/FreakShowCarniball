using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampa : MonoBehaviour
{
    
     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Pelota")
        {
            Destroy(gameObject);                    //interactua con un bloque falso que hace que se caiga la pelota
        }

    }
    
}
