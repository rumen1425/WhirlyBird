using System.Collections.Generic;
using UnityEngine;

public class GameMan : MonoBehaviour
{
    [SerializeField] private List<GameObject> platformPrefabs;
    [SerializeField] private List<float> spawnRates;
    [SerializeField] private int platformCount = 500;
    [SerializeField] private float minSpawnY = 0.5f;
    [SerializeField] private float maxSpawnY = 2f;
    [SerializeField] private float minSpawnX = 0.2f;
    [SerializeField] private float maxSpawnX = 1f;
    private float totalSpawnRate;

    private void Start()
    {
        totalSpawnRate = 0f;
        foreach (float rate in spawnRates)
        {
            totalSpawnRate += rate;
        }
        SpawnPlatforms();
    }

    private void SpawnPlatforms()
    {
        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < platformCount; i++)
        {
            spawnPosition.y += UnityEngine.Random.Range(minSpawnY, maxSpawnY);

            float minX = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).x + 1;
            float maxX = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0)).x + 1;

            float randomValue = UnityEngine.Random.Range(0f, totalSpawnRate);
            float weightSum = 0f;
            GameObject prefabToSpawn = null;

            for (int j = 0; j < platformPrefabs.Count; j++)
            {
                weightSum += spawnRates[j];
                if (randomValue < weightSum)
                {
                    prefabToSpawn = platformPrefabs[j];
                    break;
                }
            }

            if (prefabToSpawn != null)
            {
                spawnPosition.x = UnityEngine.Random.Range(minSpawnX, maxSpawnX);
                Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);
            }
        }
    }
}
