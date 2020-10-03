using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Score : MonoBehaviour
{
    [SerializeField] int playerScore = 0;
    [SerializeField] int sceneIndex;

    private void Awake()
    {
        SetUpSingleton();
    }
    private void SetUpSingleton()
    {
        int numberOfScores = FindObjectsOfType<Score>().Length;
        if (numberOfScores > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        if (SceneManager.GetActiveScene() != SceneManager.GetSceneByName("Game over"))
            sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }
    private void Update()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(0)) // Destroying Score while on Start Menu
        {
            Destroy(gameObject);
        }
    }
    // Score management
    public int GetPlayerScore()
    {
        return playerScore;
    }
    public void AddPlayerScore(int amount)
    {
        playerScore += amount;
    }
    // PreviousScene management
    public int GetPreviousScene()
    {
        return sceneIndex;
    }
}
