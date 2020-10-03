using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopMaterialChanger : MonoBehaviour
{
    Material material;
    int previousScene;
    void Start()
    {
        previousScene = FindObjectOfType<Score>().GetPreviousScene();
        ChangeMaterial(previousScene - 1); // becouse of scene 0 being the start game scene
    }

    void ChangeMaterial(int sceneIndex)
    {
        material = FindObjectOfType<MaterialsHolder>().GetTopMaterial(sceneIndex);
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material = material;
    }
}
