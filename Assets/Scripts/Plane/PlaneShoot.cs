using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneShoot : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject bullet;
    [SerializeField] private float delaytime;
    private Rigidbody2D mybody;
    private bool canShoot = true ;
    
    void Awake()
    {
        mybody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
      if (Input.GetKey(KeyCode.Mouse0))
        {
            if (canShoot)
            {
                StartCoroutine(Shoot());
            }
          
        }
    }

    IEnumerator Shoot()
    {
        Vector3 temp = transform.position;
        temp.y += 0.5f;
        canShoot = false;
        Instantiate(bullet,temp, Quaternion.identity);
        yield return new WaitForSeconds(delaytime);
         canShoot = true;
    }

 
}
