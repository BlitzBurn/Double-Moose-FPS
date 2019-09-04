using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStormFire : MonoBehaviour
{
    public float stormFireTimer;
    private float time = 0;

    public GameObject stormFireSpawnPlace;
    public GameObject stormFirePrefab;

       
    void Update()
    {
        time += Time.deltaTime;

        if (time>=stormFireTimer)
        {
            Instantiate(stormFirePrefab, stormFireSpawnPlace.transform.position, stormFireSpawnPlace.transform.rotation);
            time = 0;
        }

    }
}
