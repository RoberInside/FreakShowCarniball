using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource gameMusic;
    public AudioSource blackHoleAS;
    public AudioSource pickUpAS;

    // Start is called before the first frame update
    void Start()
    {
        gameMusic = GameObject.Find("Main Camera").GetComponent<AudioSource>();
        blackHoleAS = FindObjectOfType<Agujeros>().GetComponent<AudioSource>();
        pickUpAS = FindObjectOfType<PickUp>().GetComponent<AudioSource>();
        PlayGameMusic();
    }

    public void PlayGameMusic()
    {
        gameMusic.Play();
    }

    public void StopGameMusic()
    {
        gameMusic.Stop();
    }

    public void PlayBlackHole()
    {
        blackHoleAS.Play();
    }

    public void PlayPickUp()
    {
        pickUpAS.Play();
    }
}
