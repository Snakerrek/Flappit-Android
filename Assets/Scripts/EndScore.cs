using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndScore : MonoBehaviour
{
    TextMeshProUGUI text;
    Score score;
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        score = FindObjectOfType<Score>();

        text.text = score.GetPlayerScore().ToString();
        if(PlayerPrefs.GetInt("BestScore") < score.GetPlayerScore())
            PlayerPrefs.SetInt("BestScore", score.GetPlayerScore());
    }
}
