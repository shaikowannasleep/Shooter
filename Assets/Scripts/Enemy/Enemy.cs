using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update 


    [SerializeField] float speedMin = 2.0f;
    [SerializeField] float speedMax = 5.0f;

    [SerializeField] float maxHp = 2;

    [Header("Movement direction")]
    [SerializeField]
    Vector2 direction = new Vector2(0f, -1);

    // Private variables.
    float speed;
    float currentHp;
    Vector2 hiddenPosition;
    GameObject player;
    public GameText gametxt;
    public void Start()
    {

        this.hiddenPosition = transform.position;
        // Determines enemyship's movement speed 
        this.speed = Random.Range(speedMin, speedMax); 
        // Refresh hp variables. 1 type of enemy -> no need to create Hp type
        this.currentHp = maxHp;
    }

    public void OnDamage(Vector2 collisionPoint)
    {
        //Decrease hp
        --this.currentHp;

        // If the current hp is less equal than zero, it will be destroyed.
        if (this.currentHp <= 0.0f)
        {
            DestroyNow();
        }
    }

    private void DestroyNow()
    {
        // Instantiate the destroy effect. ( Still under Working)

        // Destroy this enemey.
        Destroy(gameObject);
       // Debug.Log("Destroyed");
    }

    void Move()
    {
       // transform.Translate(Vector2.down * speed * Time.deltaTime);

    }

    // Update is called once per frame
    void Update()
    {
       //Move();
        transform.Translate(Vector2.down * speed * Time.deltaTime);
        CheckArea();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "PlayerBullets")
        {
            //OnDamage(collision.transform.position);
            //Debug.Log(collision.transform.position);

            --this.currentHp;
            
            // If the current hp is less equal than zero, it will be destroyed.
            if (this.currentHp <= 0.0f)
            {
                DestroyNow();
                GameText.scoreValue += 1;
            }
        }
    }

    void CheckArea()
    {
        // It is destroy when position is over.
        if (transform.position.y >= 10.0f ||
            transform.position.y <= -10.0f)
        {
            Destroy(gameObject);
        }
    }

}
