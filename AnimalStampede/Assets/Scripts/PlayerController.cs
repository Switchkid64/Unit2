using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float HorizontalInput;
    public float speed = 10.0f;
    public float zRange = 23.45f;
    public GameObject flyingPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -zRange)
        {
           transform.position = new Vector3(-zRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > zRange)
        {
            transform.position = new Vector3(zRange, transform.position.y, transform.position.z);
        }
        HorizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * HorizontalInput * Time.deltaTime * speed);
        // Fires food with End
        if (Input.GetKeyDown(KeyCode.End));
        {
            // Food flies foward from the player's position
            Instantiate(flyingPrefab, transform.position, flyingPrefab.transform.rotation);
        }
    }
}
