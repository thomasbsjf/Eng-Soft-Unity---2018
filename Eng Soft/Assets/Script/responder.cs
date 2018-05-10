using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class responder : MonoBehaviour {

    public int idTema;

    public Text pergunta;
    public Text respostaA;
    public Text respostaB;
    public Text respostaC;
    public Text respostaD;
    public Text infoRespostas;

    public string[] perguntas; // perguntas
    public string[] alternativaA; //alt A
    public string[] alternativaB; //alt B
    public string[] alternativaC; //alt C
    public string[] alternativaD; //alt D
    public string[] corretas; // corretas

    private int idPergunta;

    private float acertos;
    private float questoes;
    private float media;

    // Use this for initialization
    void Start () {
        idPergunta = 0;
        questoes = perguntas.Length;
        pergunta.text = perguntas[idPergunta];
        respostaA.text = alternativaA[idPergunta];
        respostaB.text = alternativaB[idPergunta];
        respostaC.text = alternativaC[idPergunta];
        respostaD.text = alternativaD[idPergunta];

        infoRespostas.text = "Respondendo " + (idPergunta + 1).ToString() + " de " + questoes.ToString() + " perguntas";
    }
	
    public void resposta(string alternativa)
    {
        if(alternativa == "A")
        {
            if(alternativaA[idPergunta] == corretas[idPergunta])
            {
                acertos += 1;
            }
        }
        else if (alternativa == "B")
        {
            if (alternativaB[idPergunta] == corretas[idPergunta])
            {
                acertos += 1;
            }

        }
        else if (alternativa == "C")
        {

            if (alternativaC[idPergunta] == corretas[idPergunta])
            {
                acertos += 1;
            }
        }
        else if (alternativa == "D")
        {

            if (alternativaD[idPergunta] == corretas[idPergunta])
            {
                acertos += 1;
            }
        }
        proximaPergunta();
    }

    void proximaPergunta()
    {
        idPergunta++;

        if (idPergunta <= (questoes - 1))
        {
            pergunta.text = perguntas[idPergunta];
            respostaA.text = alternativaA[idPergunta];
            respostaB.text = alternativaB[idPergunta];
            respostaC.text = alternativaC[idPergunta];
            respostaD.text = alternativaD[idPergunta];

            infoRespostas.text = "Respondendo " + (idPergunta + 1).ToString() + " de " + questoes.ToString() + " perguntas";
        }
        else
        {
            SceneManager.LoadScene("nota");
        }
    }
}
