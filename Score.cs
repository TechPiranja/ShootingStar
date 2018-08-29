using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public static int count;

    void Start()
    {
        count = 0;
    }

    void Update()
    {
        scoreText.text = count.ToString();
    }
}
