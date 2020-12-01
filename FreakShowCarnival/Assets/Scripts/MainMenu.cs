using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Animations;

public class MainMenu : MonoBehaviour
{
    public MainMenu menu;
    public Button playB;
    public Button optionsB;
    public Button quitB;

    public Fundido fadeSC;
    public Animator cartel;
    //public AnimationClip cartelClip;
    public bool activeMenu;
    private void Start()
    {
        fadeSC = GameObject.Find("fundido").GetComponent<Fundido>();
       
        //playB = GameObject.Find("PlayButton").GetComponent<Button>();
        

        //cartel = GameObject.Find("atlas_cartel").GetComponent<Animator>();



        //ActiveMenu();
    }
    public void PlayGame()
    {
        //fadeSC.FadeOut();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);  
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    
    public void ActiveMenu()
    {
        //menu = GameObject.Find("MainMenu").GetComponentInChildren<>
        
        

    }
    
}
