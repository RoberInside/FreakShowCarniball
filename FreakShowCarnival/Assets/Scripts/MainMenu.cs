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
    public bool activeMenu;
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);  
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ActiveMenu()
    {
        cortDcha = GetComponent<Animator>();
        menu = GetComponent<MainMenu>();
        if (true)
        {

        }
    }
}
