using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TargetSpawner : MonoBehaviour
{
    public GameObject targetPrefab; 
    public RectTransform spawnArea; 

    void Start()
    {
        SpawnTarget();
    }

    void SpawnTarget()
    {
        Vector2 randomPosition = new Vector2(
            Random.Range(0, spawnArea.rect.width),
            Random.Range(0, spawnArea.rect.height));
        GameObject newTarget = Instantiate(targetPrefab, spawnArea);
        RectTransform targetRect = newTarget.GetComponent<RectTransform>();
        targetRect.anchoredPosition = randomPosition;
    }
}
