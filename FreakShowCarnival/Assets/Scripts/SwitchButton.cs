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
    //public AudioManager audioManagerSC;
    public MuteButton muteSC;
    

    private void Start()
    {

        //audioManagerSC = FindObjectOfType<AudioManager>(); //accedemos al script de audiomanager
        audioManagerAS = GameObject.Find("Main Camera").GetComponent<AudioSource>(); //encontramos la música del juego, asignada a la camara
        muteSC = FindObjectOfType<MuteButton>(); //accedemos al script del mute
    }
    public void OnSwitchButtonClicked() //evento para que funcione el boton de sonido
    {
        switchBttn.transform.DOLocalMoveX(-switchBttn.transform.localPosition.x, 0.2f); //con la librería Dotween cambiamos la posición del handler, nos ahorramos vectores
        switchState = Math.Sign(-switchBttn.transform.localPosition.x);
        Debug.Log("bttn state: " + switchState);
        

        if (switchState > 0)
        {
            muteSC.MutedPressed(); //si el boton está en 1 (posición dcha) se mutea el sonido
            
        }

        else if (switchState < 0 )
        {          
            audioManagerAS.Play(); //si el boton está en -1 (posición izda) el sonido se mantiene/reanuda
            muteSC.MutedPressed();

        }
    }


}
