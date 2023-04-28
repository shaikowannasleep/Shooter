using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyColision : MonoBehaviour
{
    //Gamecontroller

    [SerializeField] float maxHp = 2;

    private float currentHp;
  //  [Header("Prefab explosion")]
   // [SerializeField]
   // GameObject prefabExplosion;


    public void Start()
    {
        this.currentHp = maxHp;
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerBullets")
        {
            //OnDamage(collision.transform.position);
            //Debug.Log(collision.transform.position);

            --this.currentHp;

            if (this.currentHp <= 0.0f)
            {
                DestroyNow();
                GameController gameController = GameObject
                    .Find("GameController").GetComponent<GameController>(); 
                gameController.AddScore();
            }
        }
    }


    private void DestroyNow()
    {
        // Instantiate the destroy effect.
       // GameObject.Instantiate(this.prefabExplosion, transform.position, Quaternion.identity); 
        Destroy(gameObject);

    }
}
