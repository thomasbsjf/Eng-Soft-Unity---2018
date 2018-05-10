using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class responder : MonoBehaviour {

    public int idTema;

    public Text pergunta;
    public Text respostaA;
    public Text respostaB;
    public Text respostaC;
    public Text respostaD;
    public Text infoResposta;

    public string[] perguntas;          // armazena todas as perguntas
    public string[] alternativasA;      // armazena todas as alternativas A
    public string[] alternativasB;      // armazena todas as alternativas B
    public string[] alternativasC;      // armazena todas as alternativas C
    public string[] alternativasD;      // armazena todas as alternativas D
    public string[] corretas;           // armazena as alternativas corretas

    private int idpergunta;

    private float acertos;
    private float questoes;
    private float media;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
