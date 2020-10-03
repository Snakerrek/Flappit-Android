using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] Animator transition = null;
    public void LoadClassicWorld()
    {
        StartCoroutine(LoadLevel("Classic"));
    }
    public void LoadSeaWorld()
    {
        StartCoroutine(LoadLevel("Underwater"));
    }
    public void LoadStartMenu()
    {
        StartCoroutine(LoadLevel("Start"));
    }
    public void LoadGameOver()
    {
        StartCoroutine(LoadLevel("Game Over"));
    }
    public void LoadCosmosWorld()
    {
        StartCoroutine(LoadLevel("Cosmos"));
    }

    public void LoadPreviusScene()
    {
        StartCoroutine(LoadLevel(FindObjectOfType<Score>().GetPreviousScene()));
        Destroy(FindObjectOfType<Score>().gameObject);
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(levelIndex);
    }
    IEnumerator LoadLevel(string levelName)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(levelName);
    }
}
