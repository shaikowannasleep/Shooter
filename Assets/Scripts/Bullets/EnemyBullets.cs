using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullets : MonoBehaviour
{
    /// <summary>
    /// Bullet
    /// This class implements a bullet.
    /// It contains...
    /// - Straight type.

    [SerializeField] private float speed = 10.0f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;

    private float deleteBullet;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Private variables.
    // Default direction.
    Vector3 direction = new Vector3(0, 0, 1);

    public void SetDirection(Vector3 direction)
    {
        this.direction = direction;
    }

    public void SetSpeed(float speed)
    {
        this.speed = -speed;
    }
    void Move()
    {
        deleteBullet = Time.time + 3;
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0f, speed);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        //Vector3 velocity = transform.forward * this.speed;
        //transform.position += Time.deltaTime * velocity;
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

    // Update is called once per frame
    void Update()
    {
        Move();
        CheckArea();
      //  SelfDestroy();
      //  Debug.Log(rb.position);
    }

    void SelfDestroy()
    {
        if (deleteBullet < Time.time)
        {
            Destroy(gameObject);
        }
    }

}
