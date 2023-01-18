using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class GameText : MonoBehaviour
{
    public Text scoreText;
   // public static int CurrentscoreValue;
    private int score;
    //public static int scoreValue = 0;

    private void Start()
    {
        score = 0;
        this.updateScore(0);
      //  scoreValue = 0;
    }
    public void updateScore(int scoreToAdd)
    {
        //score += scoreToAdd;
       // scoreText.text = "Score: " + score;
        //  txt.text = "Score : " + CurrentscoreValue;
    }

    void Update()
    {
       // scoreText.text = "Score: " + score.ToString();
    }
}
