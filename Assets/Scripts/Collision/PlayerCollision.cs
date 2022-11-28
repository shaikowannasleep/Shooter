using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public GameController gameController;

    void Start()
    {
     //   mybody= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "EnemyVip")
        {
            Destroy(gameObject);
           gameController.GameOver();
        }
    }


    IEnumerator ReloadCurrentScene()
    {
        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene(0);
    }


}
