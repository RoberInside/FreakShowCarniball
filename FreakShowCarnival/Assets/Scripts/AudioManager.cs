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

    //Cada metodo reporoduce un sonido, ajusta el loop, eñ volumen y lo reporduce
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
        audioS.clip = sonidos[0];
        audioS.volume = 0.5f;
        audioS.Play();
    }

    public void PlayPickUp()
    {
        audioS.loop = false;
        audioS.clip = sonidos[1];
        audioS.volume = 1;
        audioS.Play();
    }

    public void PlayRisaGameOver()
    {
        audioS.loop = false;
        audioS.clip = sonidos[2];
        audioS.volume = 2;
        audioS.Play();
    }
}
