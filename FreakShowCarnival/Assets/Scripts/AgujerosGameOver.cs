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
        agujerosSC = FindObjectOfType<Agujeros>();
        audioManagerSC = FindObjectOfType<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Pelota")
        {
            audioManagerSC.PlayRisaGameOver();
            agujerosSC.panelGameObject.SetActive(true);
            agujerosSC.ballGO.SetActive(false);
            StartCoroutine(ChangeScene());
        }

        

    }
    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(2);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        SceneManager.UnloadScene(1);

    }
}
