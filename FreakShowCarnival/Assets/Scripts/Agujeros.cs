using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agujeros : MonoBehaviour
{
    public GameObject ballGO;
    public bool newMapa;

    public GameManager gameManagerSC;

    // Start is called before the first frame update
    void Start()
    {
        ballGO = GameObject.Find("Pelota");
        gameManagerSC = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
  
        if (other.gameObject.name == "Pelota")
        {

            ballGO.transform.position = new Vector2(0, 3);
            

            newMapa = true;

        }
        
        if (newMapa == true)
        {

            gameManagerSC.DestroySecciones();
            newMapa = false;
        }
    }
   
}
