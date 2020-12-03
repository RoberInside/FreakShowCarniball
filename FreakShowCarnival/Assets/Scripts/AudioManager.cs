using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource gameMusic;

    // Start is called before the first frame update
    void Start()
    {
        gameMusic = GameObject.Find("Canvas").GetComponent<AudioSource>();
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

    }
}
