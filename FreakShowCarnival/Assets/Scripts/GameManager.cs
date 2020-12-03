﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text scoreText;
    public int puntuacion;
    public GameObject newSeccion;

    public Transform seccionInicialTF;
    public GameObject[] contenedorObstaculosArray;
    public GameObject[] oldSeccion;


    // Start is called before the first frame update
    void Start()
    {
        
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
       
        SetScoreText();
        GameStart();
    }

    // Update is called once per frame
    
    public void GameStart()
    {

        
        //puntuacion = 0;

         
       

        seccionInicialTF =GetComponent<Transform>(); //Creamos una seccion inicial y usamos su posicion como referencia.
        FindSeccion(); //Encuentra las secciones
    }
    public void FindSeccion()
    {
        contenedorObstaculosArray = null;
        contenedorObstaculosArray = GameObject.FindGameObjectsWithTag("Seccion"); // Busca todos los objetos con el tag seccion e introducelos en un array 

        ColocarSeccion();
        
    }
    public void ColocarSeccion()
    {
        float margen = 0.9f; //Margen de separación de secciones.

        for (int i = 0; i < 3; i++) // 3 es el numero de secciones que queremos que se creen dentro del mapa.
        {
            
            int index = Random.Range(0, contenedorObstaculosArray.Length); //Creamos un random para seleccionar una seccion aleatoria dentro del array e implementarla en el mapa
            GameObject newSeccion = Instantiate(contenedorObstaculosArray[index]); //Instanciamos la seccion sleccionada mediante el random 
            newSeccion.transform.position = new Vector2(seccionInicialTF.position.x, seccionInicialTF.transform.position.y - margen);//Colocamos la instancia en la posición indicada + el margen.
            newSeccion.transform.tag = "SeccionOld";
            

            margen +=0.9f; //sumamos 0.9 al margen para que cada instancia se aleje mas de la seccion inicial.

            
        }
        

    }
    public void DestroySecciones()
    {
        oldSeccion = GameObject.FindGameObjectsWithTag("SeccionOld");
        for (int i = 0; i < oldSeccion.Length; i++)
        {

            Destroy(oldSeccion[i]);

        }
        oldSeccion = null;
        contenedorObstaculosArray = null;
        FindSeccion();
        
    }
    public void SetScoreText()
    {
        scoreText.text = "Score: " + puntuacion.ToString();
    }
}
