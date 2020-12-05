using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteButton : MonoBehaviour
{
    public bool isMuted; //creamos un booleano que nos va a permitir activar y desactivar el audio 

    // Start is called before the first frame update
    void Start()
    {
        //    isMuted = PlayerPrefs.GetInt("MUTED") == 1; // si el valor de nuestro int se ha seteado en hyu1, entonces el booleano de isMuted será true y se silenciará el sonido
        //    AudioListener.pause = isMuted;
        isMuted = false;
    }
    public void MutedPressed()
    {
        isMuted = !isMuted;
        AudioListener.pause = isMuted; // igualamos el audiolistener al booleano, para que se pause o se reanude en base a su valor
       // PlayerPrefs.SetInt("MUTED", isMuted ? 1 : 0); // guardamos la preferencia del jugador con un set int (si quiere o no quiere el sonido), que va adjunto al switchbutton
                                                     //si estamos muteados tendremos el valor 1, sino tendremos el valor 0
    }                                                //si tenemos el valoe 1, isMuted será true, si tenemos 0 será false

}
