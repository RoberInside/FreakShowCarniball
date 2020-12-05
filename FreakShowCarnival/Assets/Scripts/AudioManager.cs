using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{       
    public AudioSource audioS;
    public AudioSource audioSBM;
    public AudioClip[] sonidos;

    void Start()
    {
        //busca objetos en la escena
        audioS = GetComponent<AudioSource>();
        audioSBM = GameObject.Find("Main Camera").GetComponent<AudioSource>();                         
    }

    //Cada metodo reproduce un sonido, ajusta el loop, el volumen y lo reproduce
    public void PlayGameMusic()
    {
        audioSBM.playOnAwake = true;
        audioSBM.volume = 0.3f;
        audioSBM.Play();
    }

    public void StopGameMusic()
    {
        audioSBM.Stop();
    }

    public void PlayBlackHole()
    {
        audioS.loop = false;
        audioS.clip = sonidos[0]; //asignamos el valor del elemento en el array
        audioS.volume = 0.5f;
        audioS.Play();
    }

    public void PlayPickUp()
    {
        audioS.loop = false;
        audioS.clip = sonidos[1]; //asignamos el valor del elemento en el array
        audioS.volume = 1;
        audioS.Play();
    }

    public void PlayRisaGameOver()
    {
        audioS.loop = false;
        audioS.clip = sonidos[2]; //asignamos el valor del elemento en el array
        audioS.volume = 2;
        audioS.Play();
    }
}
