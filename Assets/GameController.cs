using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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

    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
        pauseBtn.SetActive(true);
        gameOverPanel.SetActive(false);

    }

    public void PauseGame()
    {
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
