using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
      public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "EnemyVip" &&gameObject.tag == "Player") 
        {
            Destroy(gameObject);
            GameController gameController = GameObject.Find("GameController").GetComponent<GameController>();
            gameController.SetGameOver();
        } 
        else if (collision.gameObject.tag == "EnemyVip" && gameObject.tag == "PlayerAuto")
        {Destroy(gameObject);}
      }
    

}
