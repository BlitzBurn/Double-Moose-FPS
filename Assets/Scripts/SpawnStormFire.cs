using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStormFire : MonoBehaviour
{
    public float stormFireTimer;
    public static float timeToStormFireSpawn = 0;

    public GameObject stormFireSpawnPlace;
    public GameObject stormFirePrefab;

    public static bool stormFireSpawnedBool;
       
    void Update()
    {
        timeToStormFireSpawn += Time.deltaTime;

        if (timeToStormFireSpawn >= stormFireTimer && stormFireSpawnedBool == false)
        {
            stormFireSpawnedBool = true;
            Instantiate(stormFirePrefab, stormFireSpawnPlace.transform.position, stormFireSpawnPlace.transform.rotation);
            timeToStormFireSpawn = 0;
        }

    }
}
