using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CosmosShadow : MonoBehaviour
{
    Canvas canvas;
    void Start()
    {
        if(PlayerPrefs.GetInt("BestScore") > 149)
        {
            canvas = GetComponent<Canvas>();
            canvas.gameObject.SetActive(false);
        }
    }
}
