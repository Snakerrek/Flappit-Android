using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    float backgroundScrollSpeed;
    Vector2 offSet;

    GameController gameController;
    Material myMaterial;

    void Start()
    {
        gameController = FindObjectOfType<GameController>();
        backgroundScrollSpeed = gameController.GetBackgroundScrollSpeed();
        myMaterial = GetComponent<Renderer>().material;
        offSet = new Vector2(backgroundScrollSpeed, 0);
    }

    void Update()
    {
        myMaterial.mainTextureOffset += offSet * Time.deltaTime;
    }
}
