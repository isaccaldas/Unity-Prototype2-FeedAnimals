using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float HorizontalInput;
    private float speed = 20.0f;
    private float xRange = 15;
    
        // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x < -xRange) {

            //Limita o movimento do jogador até a posição negativa do eixo x, mantendo a posição no eixo y e z
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);

        }
        if (transform.position.x > xRange)
        {

            //Limita o movimento do jogador até a posição positiva do eixo x, mantendo a posição no eixo y e z
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);

        }


        HorizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * HorizontalInput * Time.deltaTime * speed);
    }
}
