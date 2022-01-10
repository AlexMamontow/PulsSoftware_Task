using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    public float minSpawnTime = 0.5f, maxSpawnTime = 2f;

    private float spawnDelay 
    {
        get 
        {
            Debug.Log("Get Value");
            return UnityEngine.Random.Range(minSpawnTime, maxSpawnTime);             
        } 
    }

    [SerializeField] Transform upSpawnPoint, downSpawnPoint;
    [SerializeField] GameObject obstaclePref;

    private float lastSpawnTime = 0f;

    private void Start()
    {
        StartCoroutine(SpawnCoroutine());
    }    

    private void Spawn()
    {
        int obstacleRandom = UnityEngine.Random.Range(0, 2);
        Transform currentSpawnPoint = obstacleRandom == 0? downSpawnPoint : upSpawnPoint; //setSpawnPoint
        Quaternion currentObstacleRotation = obstacleRandom == 0 ? Quaternion.identity : Quaternion.Euler(0f, 0f, 180f);

        Instantiate(obstaclePref, currentSpawnPoint.position, currentObstacleRotation);
        Debug.Log("spawn");
    }

    private IEnumerator SpawnCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnDelay);
            Spawn();
        }
        
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
    }
}
