using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour {
    public float totalTime;
    public Text tempo;

    private float minutes;
    private float seconds;
    public static bool endGame;
    void Start () {
        seconds = 60;
    }
    void TimeLevel () {
        totalTime -= Time.deltaTime;
        minutes = (int) (totalTime / 60);
        seconds = (int) (totalTime % 60);
        tempo.text = minutes.ToString () + ": " + seconds.ToString ();

        if (seconds >= 0) {
            transform.Translate (0, 0, 0);

        } else {
            endGame = true;
        }
    }
    void EndGame () {
        if (seconds <= 0) {
            totalTime = 0;
            tempo.text = "Fim de Jogo";
        }
    }

    void Update () {

        if (endGame) {
            EndGame ();
        } else {
            TimeLevel ();
        }
    }

}