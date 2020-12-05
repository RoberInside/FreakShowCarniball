using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Creditos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void IrCreditos()
    {
        StartCoroutine(ChangeSceneCreditos());

    }

    IEnumerator ChangeSceneCreditos()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Creditos");
    }
    public void VolverMenu()
    {
         StartCoroutine(ChangeSceneMenu());

    }

    IEnumerator ChangeSceneMenu()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Menu");
    }
}
