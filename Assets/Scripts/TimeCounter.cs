using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimeCounter : MonoBehaviour
{

    [SerializeField] private int timeRemaining;
    public bool timerIsRunning = false;
    public Text timeText;


    private float roundTimeLeft;
    private void Start()
    {
        timerIsRunning = true;
        roundTimeLeft = (float)timeRemaining;

    }
    void Update()
    {

        if (GetComponent<GameController>().IsPause()
            || GetComponent<GameController>().IsGameOver())
        {
            return;
        }

        if (timerIsRunning)
        {
            if (roundTimeLeft > 0f)
            {
                roundTimeLeft -= Time.deltaTime;
                DisplayTime(roundTimeLeft);
            }
            else
            {
                Debug.Log("Time has run out!");
                roundTimeLeft = 0f;
                gameObject.GetComponent<GameController>().SetGameOver();
                timerIsRunning = false;
            }
        }
    }
    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);


        int TotalHours = Mathf.FloorToInt(roundTimeLeft / 3600);
        int Minutes = Mathf.FloorToInt(roundTimeLeft / 60);
        int Seconds = Mathf.FloorToInt(roundTimeLeft - Minutes * 60f);
        timeText.text = string.Format("{0:00}:{1:00}:{2:00}",
           TotalHours,
                Minutes,
                Seconds);
    }

    public float GetRemainTime()
    {
        return (float)timeRemaining - roundTimeLeft;
    }
}
