using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public MainMenu menu;
   
    public Fundido fadeSC;
    
    private void Start()
    {
        fadeSC = GameObject.Find("Fundido").GetComponent<Fundido>();
            
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
