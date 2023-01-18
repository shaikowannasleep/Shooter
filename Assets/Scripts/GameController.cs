using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject pauseBtn;
    public GameObject gameOverPanel;
    public GameObject resumeBtn;
    public GameObject exitBtn1;
    public GameObject exitBtn2;
    public GameObject reloadBtn;
    
    public static GameController instance;
    [SerializeField] public GameObject resultPanel;

    /// <summary>
    ///  change in 17/1/2023
    /// </summary>
    [SerializeField] private Text scoreText;
    [SerializeField] private Text levelText;




    private int score;
    private int level;

    private bool isGameOver;
    private bool isPause;
    private bool isSelected;



    /// <summary>
    ///  change in 17/1/2023
  
    private void Update()
    {
        if (!isPause && !isGameOver)
        {
            levelText.text = "LEVEL: " + level;
           scoreText.text = "Score: " + score.ToString();

        }
        CheckWin();
    }

    /// </summary>
    void Start()
    {
        ///
        //// change in 17/1/2023
        score = 0;
        level = PlayerPrefs.GetInt("level");
        isGameOver = false;
        isPause = false;

        ///
        pauseMenu.SetActive(false);
        pauseBtn.SetActive(true);
        gameOverPanel.SetActive(false);
    }




    public void SetGameOver()
    {
        isGameOver = true;
        gameOverPanel.SetActive(true);
        pauseBtn.SetActive(false);
        Time.timeScale = 0f;
    }

    public bool IsGameOver()
    {
        return isGameOver;
    }

    public bool IsPause()
    {
        return isPause;
    }

    public void SetPause(bool pause)
    {
        isPause = pause;
    }

    public int GetLevel()
    {
        return level;
    }

    public void SetLevel(int level)
    {
        this.level = level;
    }

    public void CheckWin()
    {
        if (isGameOver)
        {
            float remainTime = GetComponent<TimeCounter>().GetRemainTime();
            resultPanel.GetComponent<ResultPanel>().Show(isGameOver,this.score, remainTime);

        }
    }

    public void AddScore()
    {
        int point = 10;
        score = score + point;
    }

    public void PauseGame()
    {
        isPause = true;
        pauseBtn.SetActive(false);
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        pauseBtn.SetActive(true);
        Time.timeScale = 1f;
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        pauseBtn.SetActive(false);
        Time.timeScale = 0f;
    }

    public void ExitGame()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ReloadScene() {

        SceneManager.LoadScene("MainScene");
        Time.timeScale = 1f;
    }

}
