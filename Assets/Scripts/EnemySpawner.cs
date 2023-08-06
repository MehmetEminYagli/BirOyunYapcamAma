using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject EnemyPrefab;
    public float spawnInterval = 1.5f;
    public float xSpawnLimit;
    public float Baslangicdegeri = 0f;
    public float plusYvaluse = 2f;

    private void Start()
    {
        for (int i = 0; i < 15; i++)
        {
            düsmanSpawner();
        }


        InvokeRepeating("düsmanSpawner", 0f, 1f);
    }

    private void düsmanSpawner()
    {
        float randomX = Random.Range(-xSpawnLimit, xSpawnLimit);
        Vector3 spawnPosition = new Vector3(randomX, Baslangicdegeri, 0f);
        Instantiate(EnemyPrefab, spawnPosition, Quaternion.identity);

        Baslangicdegeri += plusYvaluse;
    }
}
