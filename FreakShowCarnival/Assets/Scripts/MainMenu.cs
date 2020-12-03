using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public MainMenu menu;
    public Button playB;
    public Button optionsB;
    public Button quitB;

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
