using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletePrefabWithTag : MonoBehaviour
{
    public void DestroyPrefabsInScene(string tagName)
    {
        GameObject[] prefabs = GameObject.FindGameObjectsWithTag(tagName);
        foreach (GameObject prefab in prefabs)
        {
            Destroy(prefab);
        }
    }
}
