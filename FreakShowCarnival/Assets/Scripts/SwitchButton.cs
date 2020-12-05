using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;

public class SwitchButton : MonoBehaviour
{
    public int switchState = 1;
    public GameObject switchBttn;
    public AudioSource audioManagerAS;                                                  
    public AudioManager audioManagerSC;
    

    private void Start()
    {

        audioManagerSC = FindObjectOfType<AudioManager>();
        audioManagerAS = GameObject.Find("Main Camera").GetComponent<AudioSource>(); //accedemos a la musica del juego
        
    }
    public void OnSwitchButtonClicked()
    {
        switchBttn.transform.DOLocalMoveX(-switchBttn.transform.localPosition.x, 0.2f); //con esta librería cambiamos la posicion del boton y nos ahorramos los vectores
        switchState = Math.Sign(-switchBttn.transform.localPosition.x); //cambia posicion del boton
        Debug.Log("bttn state: " + switchState);
        

        if (switchState > 0)
        {          
            audioManagerAS.Stop(); //si el valor del boton es 1 (dcha) la musica para
            
        }

        else if (switchState < 0 )
        {          
            audioManagerAS.Play(); //si el valor del boton es -1 (izda) la musica se reproduce
        }
    }


}
