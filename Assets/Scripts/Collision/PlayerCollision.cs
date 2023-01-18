using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
  

    void Start()
    {
     //   mybody= GetComponent<Rigidbody2D>();

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "EnemyVip")
        {
            Destroy(gameObject);
            GameController gameController = GameObject.Find("GameController").GetComponent<GameController>();
            gameController.SetGameOver();
        }
    }


    IEnumerator ReloadCurrentScene()
    {
        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene(0);
    }


}
