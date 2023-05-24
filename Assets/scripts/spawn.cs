using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

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
        if(Random.Range(0, 200) == 1){

            Vector3 spawnPosition;
            spawnPosition = transform.position + new Vector3(30f, 0f, 0);

            Instantiate(gameObject, spawnPosition, Quaternion.identity);
        }

    }
    
    private void OnBecameInvisible(){
         Destroy(gameObject, 10f);
     }
}
