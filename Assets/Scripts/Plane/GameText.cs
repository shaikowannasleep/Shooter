using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameText : MonoBehaviour
{
    public Text txt;
    public static int scoreValue = 0;

    private void Start()
    {
        scoreValue = 0; 
        
    }


    void Update()
    {
        txt.text = "Score : " + scoreValue;
    }
}
