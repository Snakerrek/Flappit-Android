using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomScroller : MonoBehaviour
{
    Vector2 offSet;
    float bottomScrollSpeed;

    GameController gameController;
    Material myMaterial;

    void Start()
    {
        gameController = FindObjectOfType<GameController>();
        bottomScrollSpeed = gameController.GetBottomScrollSpeed();
        myMaterial = GetComponent<Renderer>().material;
        offSet = new Vector2(bottomScrollSpeed, 0);
    }

    void Update()
    {
        myMaterial.mainTextureOffset += offSet * Time.deltaTime;
    }
}
