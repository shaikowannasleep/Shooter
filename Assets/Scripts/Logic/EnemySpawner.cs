using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    ///// <summary>
    ///// EnemySpawner
    ///// This class spawns multiple enemies.
    ///// </summary>
    //// Start is called before the first frame update

    //[Header("Enemy prefab array")]
    //[SerializeField]
    //Enemy[] prefabEnemies;

    //[Header("Delay before spawn enemies")]
    //[Space(20)]
    //[SerializeField]
    //float startDelay = 1.0f;

    //[Header("Interval between each wave")]
    //[SerializeField]
    //float intervalMin = 1.0f;

    //[SerializeField]
    //float intervalMax = 3.0f;


    //[Header("Spawn count per one wave")]
    //[SerializeField]
    //int countMin = 2;

    //[SerializeField]
    //int countMax = 5;

    //void Start()
    //{
        
    //}

    //// Update is called once per frame
    //void Update()
    //{
        
    //}

    //IEnumerator SpawnLoop()
    //{
    //    // Wait for seconds before start.
    //    if (this.startDelay > 0.0f)
    //    {
    //        yield return new WaitForSeconds(this.startDelay);
    //    }

    //    while (true)
    //    {
   
        
    //    }
    //}

    ////void RunWave()
    ////{
    ////    // It determines how many enemies to be spawned on this wave.
    ////    int count = Random.Range(this.countMin, this.countMax + 1);
    ////    for (int i = 0; i < count; ++i)
    ////    {
    ////        // Pick one enemy prefab randomly.
    ////        int enemyIndex = Random.Range(0, this.prefabEnemies.Length);

    ////        // Instantiate it.
    ////        Enemy enemy = GameObject.Instantiate(this.prefabEnemies[enemyIndex], transform, false);

    ////        // Set its position.
    ////        //enemy.transform.position = GetRandomPosition();
    ////        enemy.Start();
    ////    }
    ////}



}
