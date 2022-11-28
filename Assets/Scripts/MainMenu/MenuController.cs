using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    public void StartButton()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        SceneManager.LoadScene("MainScene");
        Time.timeScale= 1.0f;
        //Debug.Log("+1");
    }

    public void QuitApp() { Application.Quit(); }


}
