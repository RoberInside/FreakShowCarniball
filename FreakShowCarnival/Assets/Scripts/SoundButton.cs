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
        bttn = FindObjectOfType<Button>();
        activeSound = true;
    }
    public void ChangeImage()
    {
        activeSound = AudioListener.pause;
        if (!activeSound)
        {
            Debug.Log("Me desactivo");
            bttn.image.overrideSprite = offbttn;
            activeSound = true;
        }
        else
        {
            Debug.Log("Me activo");
            bttn.image.overrideSprite = onbttn;
            activeSound = false;
        }
        AudioListener.pause = activeSound;
    }
}
