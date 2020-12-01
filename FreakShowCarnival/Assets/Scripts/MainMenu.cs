using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Animations;

public class MainMenu : MonoBehaviour
{
    public MainMenu menu;
    public Animator cortDcha;
    public Animator cortIzda;
    public Animator cartel;
    public AnimationClip cartelClip;
    public bool activeMenu;
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);  
    }
    private void Start()
    {
        cartel = GameObject.Find("atlas_cartel").GetComponent<Animator>();
        
        cortDcha = GetComponent<Animator>();
        //ActiveMenu();
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    
    //public void ()
    //{
    //    menu = GetComponent<MainMenu>();
    //    if ()
    //    {

    //    }
    //}
}
