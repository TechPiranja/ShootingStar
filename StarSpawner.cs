using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarSpawner : MonoBehaviour
{
    public Text availStars;
    public static int availableStars;
    public int maxShootingStars;
    public Image LoadingSymbol;
    public int waitTime;

    void Start()
    {
        availableStars = 3;
        LoadingSymbol.fillAmount = 0;
    }

    private void Update()
    {
        availStars.text = availableStars.ToString();

        if (availableStars < maxShootingStars && LoadingSymbol.fillAmount < 1)
        {
            LoadingSymbol.fillAmount += 1.0f / waitTime * Time.deltaTime;
            if (LoadingSymbol.fillAmount >= 1)
            {
                availableStars++;
                LoadingSymbol.fillAmount = 0;
            }
                
        }
    }
}
