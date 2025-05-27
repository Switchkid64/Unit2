using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public int animalIndex;
    public Vector3 spawnpos;
    private float spawnRangeX;
    private float SpawnPosZ;
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
        Vector3 spawnpos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), SpawnPosZ, 7);
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        Instantiate(animalPrefabs[animalIndex], new Vector3(0, 0, 40), animalPrefabs[animalIndex].transform.rotation);
    }
}
