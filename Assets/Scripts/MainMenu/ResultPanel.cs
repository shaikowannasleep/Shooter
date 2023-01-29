using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ResultPanel : MonoBehaviour
{


    [SerializeField] private GameObject resultPanel;
    [SerializeField] public Text resultScoreText;
    [SerializeField] public Text resultTimePlayedText;

    [SerializeField] public Text GameOverTxt;

    [SerializeField] public Button playAgainButton;
    [SerializeField] public Button exitToMenuButton;

    // Start is called before the first frame update
    void Start()
    {
        playAgainButton.onClick.AddListener(PlayAgain);
        exitToMenuButton.onClick.AddListener(ReturnToMenu);
    }


    public void Show(bool winStatus, int score, float playTime)
    {
        resultPanel.SetActive(true);

       // gameOverImage.SetActive(!winStatus);
        //victoryImage.SetActive(winStatus);
        resultScoreText.text = "Score: " + score;
        Debug.Log(score+ " " + playTime);
        int TotalHours = Mathf.FloorToInt(playTime / 3600);
        int Minutes = Mathf.FloorToInt(playTime / 60);
        int Seconds = Mathf.FloorToInt(playTime - Minutes * 60f);
        string timeStr = string.Format("{0:00}:{1:00}:{2:00}",
           TotalHours,
                Minutes,
                Seconds);

        resultTimePlayedText.text = "Time: " + timeStr;

        if (!winStatus)
        {
            GameOverTxt.text = "NEXT LEVEL";
        }
        else
        {
            GameOverTxt.text = "TRY AGAIN";
        }
    }

    private void PlayAgain()
    {
        if (GameOverTxt.text == "TRY AGAIN")
        {
            SceneManager.LoadScene("MainScene");
        }
        else if (GameOverTxt.text == "NEXT LEVEL")
        {
            int level = PlayerPrefs.GetInt("level");
            if (level < 2)
            {
                PlayerPrefs.SetInt("level", level + 1);
            }
            else if (level == 2)
            {
                PlayerPrefs.SetInt("level", 1);
            }

            SceneManager.LoadScene("MainScene");
        }
    }


    private void ReturnToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

        
}
