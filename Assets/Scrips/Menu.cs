using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public void PlayGame () {
        SceneManager.LoadScene ("Main");
    }
    public void Back () {
        SceneManager.LoadScene ("Testes");
    }
    public void Quit () {
        Application.Quit ();
    }
}