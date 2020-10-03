using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CongratulationTextScript : MonoBehaviour
{
    TextMeshProUGUI text;
    Score score;
    int points;
    string[] congratulations = new string[] {   "You can do better", 
                                                "Not bad", 
                                                "Nice",
                                                "Very Good",
                                                "Great!", 
                                                "You are really good",
                                                "Wonderful!",
                                                "Fantastic!",
                                                "Amazing!", 
                                                "Excellent!",
                                                "WOW!",
                                                "SUPREME!!!",
                                                "This is just unbelievable"};
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        score = FindObjectOfType<Score>();
        points = score.GetPlayerScore();
        SetCongratulationText(points);
    }

    void SetCongratulationText(int points)
    {
        int textID;
        if (points < 5)
            textID = 0;
        else if (points < 10)
            textID = 1;
        else if (points < 20)
            textID = 2;
        else if (points < 30)
            textID = 3;
        else if (points < 50)
            textID = 4;
        else if (points < 100)
            textID = 5;
        else if (points < 150)
            textID = 6;
        else if (points < 250)
            textID = 7;
        else if (points < 350)
            textID = 8;
        else if (points < 500)
            textID = 9;
        else if (points < 700)
            textID = 10;
        else if (points < 1000)
            textID = 11;
        else
            textID = 12;

        text.text = congratulations[textID];
    }

}
