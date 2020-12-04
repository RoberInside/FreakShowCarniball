using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AgujerosGameOver : MonoBehaviour
{
    public Agujeros agujerosSC;
    // Start is called before the first frame update
    void Start()
    {
        agujerosSC = FindObjectOfType<Agujeros>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Pelota")
        {
            agujerosSC.panelGameObject.SetActive(true);
            agujerosSC.ballGO.SetActive(false);
            StartCoroutine(ChangeScene());
        }

        

    }
    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(3);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        SceneManager.UnloadScene(1);

    }
}
