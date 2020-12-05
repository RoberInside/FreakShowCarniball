using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundButton : MonoBehaviour
{
    public Button bttn;
    public Sprite onbttn;
    public Sprite offbttn;
    public bool activeSound;
    private void Start()
    {
        bttn = FindObjectOfType<Button>(); //accedemos al botón
        activeSound = true; //fijamos el valor del booleano en true, para que haya sonido desde el principio
    }
    public void ChangeImage()
    {
        activeSound = AudioListener.pause; //igualamos el bool al audiolistener para que recoja su valor y lo guarde
        if (!activeSound)
        {
            Debug.Log("Me desactivo");
            bttn.image.overrideSprite = offbttn; //sobreescribimos la imagen del boton cuando el sonido esté inactivo
            activeSound = true;
        }
        else
        {
            Debug.Log("Me activo");
            bttn.image.overrideSprite = onbttn; //sobreescribimos la imagen del boton cuando el sonido esté activo
            activeSound = false;
        }
        AudioListener.pause = activeSound;
    }
}
