using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemySpawner : MonoBehaviour
{
    ///// <summary>
    ///// EnemySpawner
    ///// This class spawns multiple enemies.
    ///// </summary>
    //// Start is called before the first frame update

    [Header("Enemy prefab array")]
    [SerializeField]
    Enemy[] prefabEnemies;

    [Header("Delay before spawn enemies")]
    [Space(20)]
    [SerializeField]
    float startDelay = 1.0f;

   [Header("Interval between each wave")]
    [SerializeField]
   float intervalMin = 1.0f;

   [SerializeField]
    float intervalMax = 3.0f;


    [Header("Spawn count per one wave")]
    [SerializeField]
    int countMin = 2;

    [SerializeField]
    int countMax = 5;


    [Header("Spawn area")]
    [SerializeField]
    Vector2 spawnArea = Vector2.one;

    private void OnEnable()
    {
        StartCoroutine(SpawnLoop());
    }

      

    IEnumerator SpawnLoop()
    {
       // Wait for seconds before start.
        if (this.startDelay > 0.0f)
            {
                yield return new WaitForSeconds(this.startDelay);
            }

        while (true)
        {
            RunWave();
            float invterval = Random.Range(this.intervalMin, this.intervalMax);
            yield return new WaitForSeconds(invterval);
        }
    }

    void RunWave()
    {
       // It determines how many enemies to be spawned on this wave.
        int count = Random.Range(this.countMin, this.countMax + 1);
        for (int i = 0; i < count; ++i)
        {
           // Pick one enemy prefab randomly.
            int enemyIndex = Random.Range(0, this.prefabEnemies.Length);

           // Instantiate it.
          Enemy enemy = GameObject.Instantiate(this.prefabEnemies[enemyIndex], transform, false);

         //  Set its position.
           enemy.transform.position = GetRandomPosition();
            enemy.Start();
        }
    }
    Vector2 GetRandomPosition()
    {
        float x = Random.Range(-this.spawnArea.x, this.spawnArea.x);
        float y = Random.Range(-this.spawnArea.y, this.spawnArea.y);

        return (Vector2)transform.position + new Vector2(x, y);
    }

    /// <summary>
    /// Draw the rectanble of this spawn area for debug.
    /// </summary>
    /// 

    private void OnDrawGizmos()
    {
        Vector2 leftTop = (Vector2)transform.position + new Vector2(-this.spawnArea.x, this.spawnArea.y);
        Vector2 rightTop = (Vector2)transform.position + new Vector2(this.spawnArea.x, this.spawnArea.y);
        Vector2 leftBottom = (Vector2)transform.position + new Vector2(-this.spawnArea.x, -this.spawnArea.y);
        Vector2 rightBottom = (Vector2)transform.position + new Vector2(this.spawnArea.x, -this.spawnArea.y);

        Gizmos.color = Color.red;
        Gizmos.DrawLine(leftTop, rightTop);
        Gizmos.DrawLine(rightTop, rightBottom);
        Gizmos.DrawLine(rightBottom, leftBottom);
        Gizmos.DrawLine(leftBottom, leftTop);
    }
}
