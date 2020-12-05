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
        fadeSC = GameObject.Find("Fundido").GetComponent<Fundido>();            
        audioManagerSC = FindObjectOfType<AudioManager>();
        audioManagerSC.PlayGameMusic();
    }
    public void PlayGame()
    {
        fadeSC.FadeOut();       
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    
    
}
