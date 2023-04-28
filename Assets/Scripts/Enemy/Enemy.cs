using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Enemy
/// This class implements an enemy.
/// </summary>
public class Enemy : MonoBehaviour
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
    GameObject trailObject;

    public void Start()
    {
       // this.hiddenPosition = transform.position;
    //    this.speed = Random.Range(speedMin, speedMax);
    }
    public void Awake()
    {
      this.hiddenPosition = transform.position;

    //Random speed selection?

      this.speed = Random.Range(speedMin, speedMax); 
    }

    void Update()
    {
        Move();
        // transform.Translate(direction * speed * Time.deltaTime);
        CheckArea();
    }

        void FixUpdate()
        {
            
        }


        void CheckArea()
    {
        if (transform.position.y >= 10.0f ||
            transform.position.y <= -10.0f)
        {
            Destroy(gameObject);
        }
    }

     void Move()
    {
        //determine vector speed ?
        Vector2 velocity = this.direction * this.speed;
        switch (this.movementType) {
            case MovementType.Straight: {
                    transform.Translate(direction * speed * Time.deltaTime);
                } break;

            case MovementType.Zigzag:
                {
                    // Move by velocity.
                    transform.Translate(velocity * Time.deltaTime);

                    Vector2 pos = transform.position;

                    // How fast turn it can be.
                    float rate = 2.0f;

                    // Calculate x variable to move zigzag.
                    float x = Mathf.Cos(Time.time * rate);

                    // Cos returns -1 ~ +1, so we should multiply a radius to get the final position.
                    float radius = 3.0f;
                    pos.x = x * radius;

                    // Apply it. x variable from Cos, other variables from the velocity.
                    transform.Translate(pos);
                }
                break;


            case MovementType.ToPlayer:
                {
                    // The velocity already sets to player, so it is same as the Straight formula.
                    transform.Translate(velocity * Time.deltaTime);
                }
                break;

        }
                }

}
