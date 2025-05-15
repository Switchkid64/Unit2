using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public int animalIndex;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Delete)) {
            //randomly generate spawn location and object
            Vector3.spawmnpos = new Vector3(Random.Range(-spawnRangex, spawnRangeX, SpawnPosZ));
            int animalIndex = Random.Range(0, 3);

            Instantiate(animalPrefabs[animalIndex], new Vector3(0, 0, 40), animalPrefabs[animalIndex].transform.rotation);
        }
        
    }
}
