using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Creditos : MonoBehaviour
{
    /*
     * Script que hace cambiar a la escena que reproduce los creditos con corrutinas para que haya un delay entre el cambio mediante el click del 
     * boton creditos del editor
     */
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
