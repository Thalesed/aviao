using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Diretor : MonoBehaviour { 
    [SerializeField] private GameObject imagemGameOver;
    private Aviao aviao;
    private Pontuacao point;

    public void FinalizarJogo(){
        this.point.state = false;
        Time.timeScale = 0;
        //habilitar a imagem Game Over
        this.imagemGameOver.SetActive(true);
        //SceneManager.LoadScene("GameOver");
    }

    private void Start(){
        this.aviao = GameObject.FindObjectOfType<Aviao>();
        this.point = GameObject.FindObjectOfType<Pontuacao>();
    }

    private void DestruirObstaculos(){
        Obstaculo[] obstaculos = GameObject.FindObjectsOfType<Obstaculo>();
        foreach(Obstaculo obstaculo in obstaculos){
            obstaculo.Destruir();
        }
    } 

    public void ReiniciarJogo() {
        this.point.Reiniciar();
        this.imagemGameOver.SetActive(false);
        Time.timeScale = 1;
        this.aviao.Reiniciar();
        this.DestruirObstaculos();
    }

}

