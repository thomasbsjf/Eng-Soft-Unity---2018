using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class responder : MonoBehaviour {

    

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
    private int idTema;
    private float acertos;
    private float questoes;
    private float media;
    private int notaFinal;

    // Use this for initialization
    void Start () {
        idTema = PlayerPrefs.GetInt("idTema");
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
            media = 10 * (acertos / questoes); //Calcula com base no percentual de acerto
            notaFinal = Mathf.RoundToInt(media); //Arredonda

            if(notaFinal > PlayerPrefs.GetInt("notaFinal" + idTema.ToString()))
            {
                PlayerPrefs.SetInt("notaFinal" + idTema.ToString(), notaFinal);
                PlayerPrefs.SetInt("acertos" + idTema.ToString(), (int)acertos);
            }

            PlayerPrefs.SetInt("notaFinalTemp" + idTema.ToString(), notaFinal);
            PlayerPrefs.SetInt("acertosTemp" + idTema.ToString(), (int)acertos);

            SceneManager.LoadScene("nota");
        }
    }
}
