using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject[] platformPrefab;
    public float spawnInterval = 1.5f;
    public float xSpawnLimit;
    public float Baslangicdegeri = 0f;
    public float plusYvaluse = 2f;

    private float nextSpawnTime = 0f;

    private void Start()
    {
        for (int i = 0; i <15; i++)
        {
            SpawnPlatform();
        }


        InvokeRepeating("SpawnPlatform", 0f, 1f);
    }

    private void Update()
    {/*
        if (Time.time >= nextSpawnTime)
        {
            SpawnPlatform();
            nextSpawnTime = Time.time + spawnInterval;
        }*/
    }

    private void SpawnPlatform()
    {
        float randomX = Random.Range(-xSpawnLimit, xSpawnLimit);
        Vector3 spawnPosition = new Vector3(randomX, Baslangicdegeri, 0f);

        GameObject objectToSpawn = platformPrefab[Random.Range(0, platformPrefab.Length)];

        Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);

        Baslangicdegeri += plusYvaluse;
    }


   
}
