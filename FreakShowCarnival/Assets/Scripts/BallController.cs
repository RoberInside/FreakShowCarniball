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

    // Start is called before the first frame update
    void Start()
    {
        gameManagerSC = FindObjectOfType<GameManager>();
        ballRb = GetComponent<Rigidbody2D>();
        ballGO = GameObject.Find("Atlas_pelota");
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveH = Input.GetAxis("Horizontal");
        
        Move(moveH);        
        
    }
    private void Move(float axis)     //esto para puebas con teclado luego se cambia por el input de android
    {
        Vector2 movement = new Vector3(axis, 0.0f);
        ballRb.AddForce( movement * speed);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            gameManagerSC.puntuacion += other.gameObject.GetComponent<PickUp>().value;
            gameManagerSC.SetScoreText();

        }

    }
}
