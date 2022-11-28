using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planeAutoShoot : MonoBehaviour
{

    [SerializeField] private GameObject bullet;
    [SerializeField] private float delaytime;
    [SerializeField] private float Direction;
    public Transform spawnPoint1;


    private void Start()
    {
        StartCoroutine(Shoot());
    }
    void Fire()
    {
        Instantiate(bullet, spawnPoint1.position, Quaternion.identity);
       
    }


    IEnumerator Shoot()
    {
        while (true)
        {
            yield return new WaitForSeconds(delaytime);
            Fire();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
