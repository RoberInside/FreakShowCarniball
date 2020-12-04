using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioS;
    public AudioSource audioSBM; //creamos una variable para la musica del juego
    public AudioClip[] sonidos; // creamos un array donde vamos a almacenar los efectos de sonido del juego

    //public static AudioManager _instance;

    //private void Awake()
    //{
    //    if (_instance == null)
    //    {
    //        _instance = this;
    //        DontDestroyOnLoad(gameObject);
    //    }
    //    else
    //        Destroy(_instance);
    //}
    // Start is called before the first frame update
    void Start()
    {
        audioS = GetComponent<AudioSource>(); //accedemos al componente de audiosource del audiomanager para darle valor luego al array
        audioSBM = GameObject.Find("Main Camera").GetComponent<AudioSource>(); //accedemos a la musica del juego, que esta en la cámara
      
    }
    public void PlayGameMusic() //creamos un metodo para que se reproduzca la musica del juego
    {
        audioSBM.playOnAwake = true;
        audioSBM.volume = 0.3f;
        audioSBM.Play();
    }

    //public void StopGameMusic()
    //{
    //    audioSBM.Stop();
    //}

    public void PlayBlackHole() //creamos un metodo para que se reproduzca el sonido del agujero negro, y le asignamos un valor en el array
    {

        audioS.loop = false;
        audioS.clip = sonidos[0];
        audioS.volume = 0.5f;
        audioS.Play();
    }

    public void PlayPickUp() //creamos un metodo para que se reproduzca el sonido del pick up, y le asignamos un valor en el array
    {
        audioS.loop = false;
        audioS.clip = sonidos[1];
        audioS.volume = 1;
        audioS.Play();
    }

    public void PlayRisaGameOver() //creamos un metodo para que se reproduzca el sonido de risa cuando caes en el agujero que te mata y te salta el game over, y le asignamos un valor en el array
    {
        audioS.loop = false;
        audioS.clip = sonidos[2];
        audioS.volume = 2;
        audioS.Play();
    }
}
