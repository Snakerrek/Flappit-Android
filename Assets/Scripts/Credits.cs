using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour
{
    Canvas canvas;
    public void EnableCanvas()
    {
        canvas = GetComponent<Canvas>();
        canvas.gameObject.SetActive(true);
    }
    public void DisableCanvas()
    {
        canvas = GetComponent<Canvas>();
        canvas.gameObject.SetActive(false);
    }
}
