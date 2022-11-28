using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnE : MonoBehaviour
{

    [SerializeField] private GameObject enemies;
    private BoxCollider2D box;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemy());   
    }

    // Update is called once per frame
    void Awake()
    {
        box = GetComponent<BoxCollider2D>();
    }

    IEnumerator SpawnEnemy() {
        yield return new WaitForSeconds(Random.Range(0.5f, 2f));
        float minX = -box.size.x / 2f;
        float maxX = box.size.x / 2f;
        Vector3 temp = transform.position;
        temp.x = Random.Range(minX, maxX);
         Instantiate(enemies, temp,Quaternion.identity);
        StartCoroutine(SpawnEnemy());
    
    }
}
