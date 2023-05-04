using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public float spawnDelay = 1f; // Atraso entre cada spawn
    public float spawnRadius = 5f; // Raio de spawn

    private void Start()
    {
        // Inicia o spawn de objetos
        //StartCoroutine(SpawnObjects());
    }

    private void Update()
    {
        if(Random.Range(0, 255) == 1){
            // Escolhe um objeto aleatório do array de objetos

            Vector3 spawnPosition;
            spawnPosition = transform.position + new Vector3(30f, 0f, 0);

            // Instancia o objeto na posição aleatória
            Instantiate(gameObject, spawnPosition, Quaternion.identity);

        }
    }
    
    private void OnBecameInvisible(){
         Destroy(gameObject, 1f);
     }
}
