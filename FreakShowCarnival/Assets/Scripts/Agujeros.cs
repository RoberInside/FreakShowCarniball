using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Agujeros : MonoBehaviour
{
    /*Script que reinicia el nivel para ganar puntos
     */
    public bool newMapa;                                                    //control de la destruccion del mapa                              

    public GameObject panelGameObject;                                      //panel del canvas del gameover
    public GameObject ballGO;
    public GameManager gameManagerSC;

    public AudioManager audioManagerSC;
    
    // Start is called before the first frame update
    void Start()
    {
        //encuentra los componentes u objetos en la escena
        ballGO = GameObject.Find("Pelota");
        panelGameObject = GameObject.Find("PanelGameOver");
        panelGameObject.SetActive(false);
        gameManagerSC = FindObjectOfType<GameManager>();
        audioManagerSC = FindObjectOfType<AudioManager>();
    }

   
    void OnTriggerEnter2D(Collider2D other)
    { 
        if (other.gameObject.name == "Pelota")                      //si la pelota toca el agujero 
        {
            audioManagerSC.PlayBlackHole();                         //sonido
            ballGO.transform.position = new Vector2(0, 3);          //la pelota vuelve arriba para reiniciar el nivel

            newMapa = true;                                         //habilita la llamada de DestroySecciones() en el GameManager
        }
        
        if (newMapa == true)                                        //destruye las secciones y se vuelve al bucle de creacion       
        {   
            gameManagerSC.DestroySecciones();
            newMapa = false;                                        //false hasta que se vuelva a tocar el agujero
        }
       
    }
    
}
