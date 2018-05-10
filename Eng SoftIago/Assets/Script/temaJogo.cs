using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class temaJogo : MonoBehaviour {

    public Button       buttonPlay;
    public Text         txtNomeTema;

    public GameObject   infoTema;
    public Text         txtInfoTema;
    public GameObject   estrela1;
    public GameObject   estrela2;
    public GameObject   estrela3;

    public string[]     nomeTema;
    public int          numerosQuestoes;

    private int         idTema;


    // Use this for initialization
    void Start () {
        idTema = 0;
        txtNomeTema.text = nomeTema[idTema];
        txtInfoTema.text = "Você acertou x de x questões";
        infoTema.SetActive(false);
        estrela1.SetActive(false);
        estrela2.SetActive(false);
        estrela3.SetActive(false);

        buttonPlay.interactable = false;

    }

    public void selecioneTema(int i)
    {
        idTema = i;
        txtInfoTema.text = nomeTema[idTema];

        int notaFinal = 0;
        int acertos = 0;

        txtInfoTema.text = "Você acertou " +acertos.ToString() + " de " + numerosQuestoes.ToString()+" questões!"; 
        infoTema.SetActive(true);
        buttonPlay.interactable = true;
    }

    public void jogar()
    {
        SceneManager.LoadScene("tema"+idTema.ToString());

    }


    // Update is called once per frame
    void Update () {
		
	}
}
