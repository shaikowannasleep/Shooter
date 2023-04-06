using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{

  //  [Header("Prefab explosion")]
  //  [SerializeField]
   // GameObject prefabExplosion;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "EnemyVip" 
            &&gameObject.tag == "Player") 
        {
           // GameObject.Instantiate(this.prefabExplosion, transform.position, Quaternion.identity);
           // Destroy(gameObject);
            gameObject.SetActive(false);
            GameController gameController = GameObject.Find("GameController").GetComponent<GameController>();
            gameController.SetGameOver();
        } 
        else if (collision.gameObject.tag == "EnemyVip"
            && gameObject.tag == "PlayerAuto")
        {Destroy(gameObject);}
      }
    

}
