using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField] private GameObject imagemGameOver;
    [SerializeField] private GameObject button;
    private Aviao aviao;
    private Pontuacao pontuacao;

    public void FinalizarJogo(){
        Time.timeScale = 0;
        //habilitar a imagem Game Over
        this.imagemGameOver.SetActive(true);
        this.button.SetActive(true);
    }

    private void Start(){
        this.aviao = GameObject.FindObjectOfType<Aviao>();
        this.pontuacao = GameObject.FindObjectOfType<Pontuacao>();
    }

    private void DestruirObstaculos(){
        Obstaculo[] obstaculos = GameObject.FindObjectsOfType<Obstaculo>();
        foreach(Obstaculo obstaculo in obstaculos){
            obstaculo.Destruir();
        }
    } 

    public void ReiniciarJogo() {
        this.imagemGameOver.SetActive(false);
        this.button.SetActive(false);
        Time.timeScale = 1;
        this.aviao.Reiniciar();
        this.DestruirObstaculos();
        this.pontuacao.Reiniciar();
    }


}
