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
        if (!activeSound)
        {
            bttn.image.overrideSprite = offbttn;
            activeSound = true;
        }
        else
        {
            bttn.image.overrideSprite = onbttn;
            activeSound = false;
        }
        AudioListener.pause = activeSound;
    }
}
