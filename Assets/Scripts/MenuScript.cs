using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    Canvas canvas;
    public void DisableCanvas()
    {
        canvas = GetComponent<Canvas>();
        canvas.gameObject.SetActive(false);
    }
    public void EnableCanvas()
    {
        canvas = GetComponent<Canvas>();
        canvas.gameObject.SetActive(true);
    }
}
