using System.Collections;
using System.Collections.Generic;
using Unity.Profiling;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [Header("Columns parameters")]
    [SerializeField] float columnsSpeed = 1f;
    [SerializeField] float columnsSpawnDelay = 3f;
    [SerializeField] float minSpawnYpos = -4f;
    [SerializeField] float maxSpawnYpos = 4f;

    [Header("Player parameters")]
    [SerializeField] float playerVelocityY = 4f;

    [Header("World space parameters")]
    [SerializeField] float backgroundScrollSpeed = 0.5f;
    [SerializeField] float bottomScrollSpeed = 0.5f;

    [Header("Points added per gap")]
    [SerializeField] int points = 1;

    public float GetColumnsSpeed()
    {
        return columnsSpeed;
    }
    public float GetPlayerVelocityY()
    {
        return playerVelocityY;
    }
    public float GetSpawnDelay()
    {
        return columnsSpawnDelay;
    }

    public float GetMaxSpawnYpos()
    {
        return maxSpawnYpos;
    }
    public float GetMinSpawnYpos()
    {
        return minSpawnYpos;
    }

    public float GetBackgroundScrollSpeed()
    {
        return backgroundScrollSpeed;
    }
    public float GetBottomScrollSpeed()
    {
        return bottomScrollSpeed;
    }
    public int GetPoints()
    {
        return points;
    }
}
