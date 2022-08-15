using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[ ] animalPrefabs;
    private float xPosition = 20;
    private float yPosition = 0;
    private float zPosition = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S)){
            
            // A variável animalIndex recebe um valor aleatório de zero ao tamanho máximo do array.
            int animalIndex = Random.Range(0,animalPrefabs.Length);

            //Gera uma posição aleatório do objeto na cena.
            Vector3 spawPosition = new Vector3(Random.Range(-xPosition, xPosition), yPosition, zPosition); 

           

            //Cria um objeto toda vez que a tecla s é pressionada.
            //new Vector3(0,0,20) é a posiçao inicial que o objeto será criado
            //animalPrefabs[animalIndex].transform.rotation indica a rotaçao inicial desse objeto.
            //animalPrefabs[animalIndex] é um array onde cada posiçao se trata de um objeto.
            
            Instantiate(animalPrefabs[animalIndex], spawPosition, 
            animalPrefabs[animalIndex].transform.rotation);
        }   
    }
}