using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AgujerosGameOver : MonoBehaviour
{
    public Agujeros agujerosSC;
    public AudioManager audioManagerSC;

    // Start is called before the first frame update
    void Start()
    {
        //encuentra los componentes en la escena
        agujerosSC = FindObjectOfType<Agujeros>();
        audioManagerSC = FindObjectOfType<AudioManager>();
    }
    void OnTriggerEnter2D(Collider2D other)                 //trigguer que hace perder el juego y cambia al menu principal
    {
        if (other.gameObject.name == "Pelota")
        {
            audioManagerSC.PlayRisaGameOver();
            agujerosSC.panelGameObject.SetActive(true);
            agujerosSC.ballGO.SetActive(false);
            StartCoroutine(ChangeScene());
        }
    }
    IEnumerator ChangeScene()                                                   //corrutina que hace que cambie de escena
    {
        yield return new WaitForSeconds(2);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        SceneManager.UnloadScene(1);
    }
}
