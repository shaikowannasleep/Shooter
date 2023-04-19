using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] float speedMin = 2.0f;
    [SerializeField] float speedMax = 5.0f;

    [Header("Movement direction")]
    [SerializeField]
    Vector2 direction = new Vector2(0f, -1);
    [SerializeField]
    Vector2 horizontalDirection = new Vector2(1, -1);

    // Private variables.
    float speed;
    Vector2 hiddenPosition;

    public void Start()
    {
        this.hiddenPosition = transform.position;
        this.speed = Random.Range(speedMin, speedMax);
    }


    void Move()
    {
        // transform.Translate(Vector2.down * speed * Time.deltaTime);
    }

    void Update()
    {
        //Move();
        //  transform.Translate(Vector2.down * speed * Time.deltaTime);
        transform.Translate(horizontalDirection * speed * Time.deltaTime);
        CheckArea();
    }


    void CheckArea()
    {
        if (transform.position.y >= 10.0f ||
            transform.position.y <= -10.0f)
        {
            Destroy(gameObject);
        }
    }

}