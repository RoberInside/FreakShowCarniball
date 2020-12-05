﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fundido : MonoBehaviour
{
    /* Script de las transiciones  entre escenas
     * */
    public Image fundido;   
    // Start is called before the first frame update
    void Start()
    {
        fundido = GetComponent<Image>();
        fundido.CrossFadeAlpha(0, 0.5f, false);  //accedemos a la imagen y le bajamos el alpha para hacer el fundido  
    }

    public void FadeOut()
    {
        fundido.CrossFadeAlpha(1, 0.5f, false);  //subimos el alpha para hacer el fade out       
        StartCoroutine(ChangeScene());
    }


    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(1);  //hacemos una corrutina para que haya un segundo de espera entre escena y escena
        SceneManager.LoadScene("Game");
    }
}
