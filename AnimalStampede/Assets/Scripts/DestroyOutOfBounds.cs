using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float UnloadValue = 41;
    public float UnloadValueBottom = -29;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > UnloadValue)
        {
            Destroy(gameObject);
        }
        if (transform.position.z < UnloadValueBottom)
        {
            Destroy(gameObject);
        }
    }
}
