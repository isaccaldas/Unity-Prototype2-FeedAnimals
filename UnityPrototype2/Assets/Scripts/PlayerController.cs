using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float speed = 30.0f;
    private float xRange = 20.0f;
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Não deixa o personagem
        if(transform.position.x < -xRange){

            // A posiçao atual do player recebera esse novo Vector3
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);

        }

        if(transform.position.x > xRange){

            // A posiçao atual do player recebera esse novo Vector3
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);

        }

        if(Input.GetKeyDown(KeyCode.Space)){

            //launch a projectile from the player
            //Instancia um objeto projectilePrefab, seguido de sua posição inicial, e a rotação desejada
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation); 

        }
        
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed *  Time.deltaTime);
    }
}
