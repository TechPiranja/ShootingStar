using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour
{
    public GameObject LoadImageObject;
    public Image LoadImage;
    public float waitTime;
    public bool FadeIn;

    private void Start()
    {
        if (FadeIn)
        {
            LoadImageObject.SetActive(true);
            LoadImage.fillAmount = 1;
            StartCoroutine(Loading());
        }            
    }

    public void ChangeSceneTo(string sceneName)
    {
        LoadImageObject.SetActive(true);
        LoadImage.fillAmount = 0;
        StartCoroutine(Loading(sceneName));
    }

    private IEnumerator Loading(string sceneName)
    {
        while (LoadImage.fillAmount < 1)
        {
            LoadImage.fillAmount += 1.0f / waitTime * Time.deltaTime;
            yield return 0;
        }
        SceneManager.LoadScene(sceneName);
    }

    private IEnumerator Loading()
    {
        while (LoadImage.fillAmount > 0)
        {
            LoadImage.fillAmount -= 1.0f / waitTime * Time.deltaTime;
            yield return 0;
        }
    }

    public void Quit()
    {
        Application.Quit();
    }
}
