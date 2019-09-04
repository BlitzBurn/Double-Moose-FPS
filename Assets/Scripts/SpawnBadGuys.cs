using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBadGuys : MonoBehaviour
{

    public GameObject meleeEnemy;
    public GameObject rangedEnemy;

    public GameObject spawnPoint1, spawnPoint2, spawnPoint3, spawnPoint4, spawnPoint5, spawnPoint6, spawnPoint7;
    private GameObject BaseSpawnPoint;

    public float enemyRespawnTimer;
    private float time;

    private float spawnModifierX, spawnModifierZ, spawnBaseX, spawnBaseZ;

    void Start()
    {
        SpawnSomeEnemies();
    }

    void Update()
    {
        time += Time.deltaTime;

        if (time>=enemyRespawnTimer)
        {
            SpawnSomeEnemies();
            time = 0;
        }

    }


    private void SpawnSomeEnemies()
    {
        int numberOfEnemies = Random.Range(4,8);

        for (int i = 0; i < numberOfEnemies; i++)
        {
            GenerateSpawnPlace();
        }
    }

    private void GenerateSpawnPlace()
    {
        int pickSpawnPoint = Random.Range(1, 7);

        if (pickSpawnPoint == 1)
        {
            BaseSpawnPoint = spawnPoint1;
        }
        else if (pickSpawnPoint ==2 )
        {
            BaseSpawnPoint = spawnPoint2;
        }
        else if (pickSpawnPoint ==3 )
        {
            BaseSpawnPoint = spawnPoint3;
        }
        else if (pickSpawnPoint == 4)
        {
            BaseSpawnPoint = spawnPoint4;
        }
        else if (pickSpawnPoint == 5)
        {
            BaseSpawnPoint = spawnPoint5;
        }
        else if (pickSpawnPoint ==6 )
        {
            BaseSpawnPoint = spawnPoint6;
        }
        else if (pickSpawnPoint == 7)
        {
            BaseSpawnPoint = spawnPoint7;
        }

        spawnModifierX = Random.Range(-2f, 2f);
        spawnModifierZ = Random.Range(-2f, 2f);

        Vector3 spawnPlace = (new Vector3(spawnModifierX, 0f, spawnModifierZ) + BaseSpawnPoint.transform.position);

        int typeOfEnemy = Random.Range(1, 4);

        if (typeOfEnemy == 1 || typeOfEnemy == 2)
        {
            
            SpawnMeleeEnemy(spawnPlace);
        }
        else if (typeOfEnemy == 3)
        {

            SpawnRangedEnemy(spawnPlace);
        }

    }

    private void SpawnRangedEnemy(Vector3 spawnPlace)
    {
        GameObject instantiatedRangedEnemy = Instantiate(rangedEnemy, spawnPlace, rangedEnemy.transform.rotation);
    }

    private void SpawnMeleeEnemy(Vector3 spawnPlace)
    {
        GameObject instantiatedMeleeEnemy = Instantiate(meleeEnemy, spawnPlace, meleeEnemy.transform.rotation);
    }
}
