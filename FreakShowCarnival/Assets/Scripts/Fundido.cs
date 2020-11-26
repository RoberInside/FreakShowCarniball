using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fundido : MonoBehaviour
{
    public Image fundido;
    public string[] scenes;
    // Start is called before the first frame update
    void Start()
    {
        fundido = GetComponent<Image>();
        fundido.CrossFadeAlpha(0, 0.5f, false);
    }

    public void FadeOut(int sceneIndex)
    {
        fundido.CrossFadeAlpha(1, 0.5f, false);
        StartCoroutine(ChangeScene(scenes[sceneIndex]));
    }

    IEnumerator ChangeScene(string scene)
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(scene);
    }
}
