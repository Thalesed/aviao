using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Pontuacao : MonoBehaviour {
    private int pontos;
    public bool state = true; 
    [SerializeField] public TextMeshProUGUI textoPontuacao;
    private AudioSource audioPontuacao;

    private void Awake(){
        this.audioPontuacao = this.GetComponent<AudioSource>();
    }

    public void Update()
    {
        if(this.state == true){
            this.pontos++;
            this.audioPontuacao.Play();
        }
        this.textoPontuacao.text = "Pontuação: " + (this.pontos / 100).ToString();
    } 

    public void Reiniciar(){
        this.state = true;
        this.pontos = 0;
        this.textoPontuacao.text = this.pontos.ToString();
    }

}
