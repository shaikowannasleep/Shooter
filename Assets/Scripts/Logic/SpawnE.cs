using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class SpawnE : MonoBehaviour
{

    [SerializeField] private GameObject enemies;
    private BoxCollider2D box;
    [SerializeField] float posMin = -2.0f;
    [SerializeField] float posMax = -5.0f;
    float speed = 0.25f;
    private Vector2 boxPos = new Vector2();
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

    private void Update()
    {
       // boxPos.y = Random.Range(posMin, posMax);
      //  transform.Translate(Vector2.down* speed* Time.deltaTime);
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
