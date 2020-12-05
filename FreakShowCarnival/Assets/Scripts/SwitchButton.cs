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
    public AudioManager audioManagerSC;
    

    private void Start()
    {

        audioManagerSC = FindObjectOfType<AudioManager>();
        audioManagerAS = GameObject.Find("Main Camera").GetComponent<AudioSource>();
        
    }
    public void OnSwitchButtonClicked()
    {
        switchBttn.transform.DOLocalMoveX(-switchBttn.transform.localPosition.x, 0.2f);
        switchState = Math.Sign(-switchBttn.transform.localPosition.x);
        Debug.Log("bttn state: " + switchState);
        

        if (switchState > 0)
        {          
            audioManagerAS.Stop();
            
        }

        else if (switchState < 0 )
        {          
            audioManagerAS.Play();
        }
    }


}
