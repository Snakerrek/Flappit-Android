using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    TextMeshProUGUI text;
    Score score;
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        score = FindObjectOfType<Score>();
    }

    void Update()
    {
        text.text = score.GetPlayerScore().ToString();
    }
}
