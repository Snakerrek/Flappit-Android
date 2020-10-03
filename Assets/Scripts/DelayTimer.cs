using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
   
public class DelayTimer : MonoBehaviour
{
    float delay = 3;
    TextMeshProUGUI text;
    SceneLoader sceneLoader;
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        StartCoroutine(StartDelay());
    }

    IEnumerator StartDelay()
    {
        Time.timeScale = 0;
        float pauseTime = Time.realtimeSinceStartup + delay;
        while (Time.realtimeSinceStartup < pauseTime)
        {
            yield return 0;
        }
        Time.timeScale = 1;
    }

    public void ChangeText(int a)
    {
        text.text = a.ToString();
    }
}
