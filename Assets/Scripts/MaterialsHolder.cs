using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialsHolder : MonoBehaviour
{
    [SerializeField] Material[] bottomMaterials;
    [SerializeField] Material[] topMaterials;

    public Material GetBottomMaterial(int sceneIndex)
    {
        return bottomMaterials[sceneIndex];
    }

    public Material GetTopMaterial(int sceneIndex)
    {
        return topMaterials[sceneIndex];
    }
}
