using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Enemy
/// This class implements an enemy.
/// </summary>
public class Enemy2 : MonoBehaviour
{
    enum MovementType
    {
        Straight,
        Zigzag,
        ToPlayer,
        Circle,
    }

    [Header("Movement speed")]
    [Space(20)]
    [SerializeField]
    float speedMin = 2.0f;
    [SerializeField]
    float speedMax = 5.0f;

    [Header("Movement direction")]
    [SerializeField]
    Vector2 direction = new Vector2(0f, -1);

    [Header("Movement type")]
    [SerializeField]
    MovementType movementType;

    [Header("Enemy Scale")]
    [SerializeField]
    float scaleMin = 1.0f;

    [SerializeField]
    float scaleMax = 1.5f;

    // Private variables.
    float speed;
    Vector2 hiddenPosition;

    public void Start()
    {   
        this.hiddenPosition = transform.position;
        this.speed = Random.Range(speedMin, speedMax); 
    }



    void Update()
    {
        //Move();
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
