using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column : MonoBehaviour
{
    private float movementSpeed;
    void Start()
    {
        movementSpeed = FindObjectOfType<GameController>().GetColumnsSpeed();
    }

    void Update()
    {
        transform.Translate(Vector3.left * movementSpeed * Time.deltaTime);
    }
}
