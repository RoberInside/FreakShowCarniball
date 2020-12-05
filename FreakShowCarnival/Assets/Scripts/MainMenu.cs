using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    //script paso entre escenas
    public AudioManager audioManagerSC;        
    public Fundido fadeSC;
    
    private void Start()
    {
        fadeSC = GameObject.Find("Fundido").GetComponent<Fundido>(); //accedemos al script del fundido           
        audioManagerSC = FindObjectOfType<AudioManager>(); //accedemos a la musica del juego 
        audioManagerSC.PlayGameMusic(); 
    }
    public void PlayGame()
    {
        fadeSC.FadeOut();   //llamamos al metodo del script fundido que es el que nos cambia de escena    
    }
    public void QuitGame()
    {
        Application.Quit(); //esta linea nos echa del juego
    }
    
    
}
