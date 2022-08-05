using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 30.0f;
    public float xRange = 20.0f;
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(transform.position.x < -xRange){

            // A posiçao atual do player recebera esse novo Vector3
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);

        }

        if(transform.position.x > xRange){

            // A posiçao atual do player recebera esse novo Vector3
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);

        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed *  Time.deltaTime);
    }
}
