using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaShadow : MonoBehaviour
{
    Canvas canvas;
    void Start()
    {
        if (PlayerPrefs.GetInt("BestScore") > 49)
        {
            canvas = GetComponent<Canvas>();
            canvas.gameObject.SetActive(false);
        }
    }
}
