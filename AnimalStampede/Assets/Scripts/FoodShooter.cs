using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodShooter : MonoBehaviour
{
    public float speed = 41.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
