using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    
    public AudioManager audioManagerSC;
    public Fundido fadeSC;
    
    private void Start()
    {
        audioManagerSC = FindObjectOfType<AudioManager>();
        fadeSC = GameObject.Find("Fundido").GetComponent<Fundido>();            
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
