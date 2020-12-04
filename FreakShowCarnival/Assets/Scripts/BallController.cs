using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{  
    public float speed;

    public Rigidbody2D ballRb;
    public GameObject ballGO;
    public GameManager gameManagerSC;
    public Camera cam;
    public AudioManager aMSC;
    
    public bool gyroActive;
    public bool newMapa;
    public Gyroscope m_Gyro;    
    // Start is called before the first frame update
    void Start()
    {
        Input.backButtonLeavesApp = true;
        aMSC = FindObjectOfType<AudioManager>();
        gameManagerSC = FindObjectOfType<GameManager>();
        ballRb = GetComponent<Rigidbody2D>();
        ballGO = GameObject.Find("Pelota");
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();        
        EnableGyro();                                                     //se activa el girocopio si el dispositivo tiene

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveH = Input.GetAxis("Horizontal");                  //prueba niveles
        Move(m_Gyro, moveH);                
    }
    private void Move(Gyroscope g, float axis)     
    {
        Vector2 movement;
        float impulso;
        if (gyroActive)                                              //girsocopio si esta activado se usa sino no
        {
            movement = new Vector2(g.rotationRate.z ,0.0f );       //la direccion en la que se mueve en la escena dada por la orientacion del giroscopio
            impulso = g.gravity.y;                                   //se toma la gravedad del giroscopio como la magnitud del impulso de la pelota
        }
        else                                                        //pruebas de nivel con teclado
        {
            movement = new Vector3(axis, 0.0f);
            impulso = speed;
            ballRb.AddForce(movement * speed);
        }
        ballRb.AddForce(movement * impulso);                        //se añade la fueza correspondiente 

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PickUp"))
        {
            aMSC.PlayPickUp();
            other.gameObject.SetActive(false);
            gameManagerSC.puntuacion += other.gameObject.GetComponent<PickUp>().value;
            gameManagerSC.SetScoreText();
        }
        
            newMapa = false;
        

    }
    
    public void EnableGyro()
    {
        if (SystemInfo.supportsGyroscope)                           //si el dispositivo soporta giroscopio
        {
            m_Gyro = Input.gyro;
            m_Gyro.enabled = gyroActive;
        }
        else
            gyroActive = false;
    }
    

}
