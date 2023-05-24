using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeObstaculos : MonoBehaviour {
    [SerializeField] private float tempoParaGerar;
    [SerializeField] private GameObject manualDeInstrucoes;
    private float cronometro;

    private void Awake(){
        this.cronometro = this.tempoParaGerar;
    } 
    void Update () { 
        //Quando que eu quero gerar? Tempo
        this.cronometro -= Time.deltaTime;
        if(this.cronometro < 0)
        {
            Vector3 spawnPosition;
            spawnPosition = this.manualDeInstrucoes.transform.position + new Vector3(30f, 0f, 0);

            GameObject.Instantiate(this.manualDeInstrucoes, spawnPosition, Quaternion.identity);
            this.cronometro = this.tempoParaGerar;
        }
    }

}