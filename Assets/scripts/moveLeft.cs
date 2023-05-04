using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveLeft : MonoBehaviour
{
    public float speed = 5f; // Velocidade do movimento
    private Vector3 startPos; // Posição inicial do objeto

    private void Start()
    {
        // Salva a posição inicial do objeto
        startPos = transform.position;
    }

    private void Update()
    {
        // Move o objeto para a esquerda
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        // Verifica se o objeto saiu da tela
        if (transform.position.x < startPos.x - 60f)
        {
            // Retorna o objeto para a posição inicial
            transform.position = startPos;
        }
    }

     private void OnBecameInvisible(){
         Destroy(gameObject, 1f);
     }
}
