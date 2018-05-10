using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class comandosBasicos : MonoBehaviour {

	public void carregaCena(string nomeCena)
    {
        SceneManager.LoadScene(nomeCena);
    }
}
