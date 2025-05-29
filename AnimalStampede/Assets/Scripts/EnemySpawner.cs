using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public int animalIndex;
    public Vector3 spawnpos;
    public float spawnRangeX = 20f;
    public float SpawnPosZ;
    public float betweenSpawnTime;
    public float spawnStartDelayTime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", spawnStartDelayTime, betweenSpawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Delete)) {
            SpawnRandomAnimal();
        }
    }
    //random animals spawn on their own
    void SpawnRandomAnimal()  {
        Vector3 spawnpos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), SpawnPosZ, 40);
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        Instantiate(animalPrefabs[animalIndex], spawnpos, animalPrefabs[animalIndex].transform.rotation);
    }
}
