using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private GameObject enemyRed;
    [SerializeField] private GameObject enemyYel;
    [SerializeField] private GameObject enemyPur;
    [SerializeField] private GameObject enemyBlu;
    [SerializeField] private float spawnStep = 1f;
    private float nextSpawn;

    void Update()
    {
        if (Time.time > nextSpawn)
        {
            System.Random rnd = new System.Random();
            int enemyType = rnd.Next(0, 3);
            if (enemyType == 0) { var enemy = Instantiate(enemyRed, transform); }
            else if(enemyType == 1) { var enemy = Instantiate(enemyYel, transform); }
            else if (enemyType == 2) { var enemy = Instantiate(enemyPur, transform); }
            else { var enemy = Instantiate(enemyBlu, transform); }
            nextSpawn = Time.time + spawnStep;
        }
    }
}
