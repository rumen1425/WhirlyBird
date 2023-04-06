using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMan : MonoBehaviour
{
    [SerializeField] private GameObject platformPrefab;
    public int platformCount = 300;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < platformCount; i++) 
        {
            spawnPosition.y += UnityEngine.Random.Range(.5f, 2f);

            // To restrict x_positions of platforms to screen boundaries
            float minX = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).x + 1;
            float maxX = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0)).x + 1;

            spawnPosition.x = UnityEngine.Random.Range(.2f, 1f);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
    }
}

