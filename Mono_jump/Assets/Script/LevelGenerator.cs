using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {

    public GameObject platformPrefab;
    public GameObject jumpPlatformPrefab;

    public int numberOfPlatforms = 200;
    public int numberOfJumpPlatform = 10;
    public float levelWidth = 3f;
    public float minY = 1.0f;
    public float maxY = 2.0f;
    public float gap = 0.5f;

	// Use this for initialization
	void Start () {

        Vector3 spawnPosition = new Vector3();
        Vector3 jumpPlatformPosition = new Vector3();

        for (int i = 0; i < numberOfPlatforms; i++)
        {
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            spawnPosition.y += Random.Range(minY, maxY);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);

            if (Random.Range(1, 10) < 2 && numberOfJumpPlatform > 0) {

                jumpPlatformPosition.x = spawnPosition.x;
                jumpPlatformPosition.y = spawnPosition.y + gap;
                Instantiate(jumpPlatformPrefab, jumpPlatformPosition, Quaternion.identity);
                numberOfJumpPlatform -= 1;
            
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
