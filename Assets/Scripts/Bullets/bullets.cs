using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullets : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;

    public GameObject explosion;
    private float deleteBullet;
    // Use this for initialization
    void Start () {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0f,speed);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        deleteBullet = Time.time + 5;
    }
    //private void FixedUpdate()
    //{
    // //   this.transform.position = new Vector2(0f, speed * Time.deltaTime);
    //   // Debug.Log(transform.position);
    //}

    // Update is called once per frame
    void Update () {

        if (deleteBullet < Time.time)
        {
           Destroy(gameObject);
        }

        /*if (transform.position.x > screenBounds.x * -2){
            Destroy(this.gameObject);
        } */

    }







    private void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "EnemyVip"){
            GameObject e = Instantiate(explosion) as GameObject;
            e.transform.position = transform.position;
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
