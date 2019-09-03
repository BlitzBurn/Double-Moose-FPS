using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAIRanged : MonoBehaviour
{
    //public GameObject player;
    public GameObject enemy;
    public GameObject missile;
    public GameObject barrel;

    private GameObject playerTracker;

    public float range;
    public float missileSpeed;

    private float time;
    private float timeBetweenShots;

    public NavMeshAgent agent;

    RaycastHit los; 

    void Start()
    {
        playerTracker = GameObject.FindWithTag("Player");
        timeBetweenShots = Random.Range(3f, 5f);
        time = 0f;
    }

    private void Update()
    {
        
    }

    void FixedUpdate()
    {
        time += Time.deltaTime;

        agent.SetDestination(playerTracker.transform.position);

        if (Physics.Raycast(enemy.transform.position, (playerTracker.transform.position - enemy.transform.position), out los, range) && los.transform.gameObject.tag =="Player" && time>=timeBetweenShots)
        {
           // FireMissile();
            timeBetweenShots = Random.Range(3f, 5f);
            time = 0;

            GameObject instantiatedMissile = Instantiate(missile, barrel.transform.position, barrel.transform.rotation);

            Rigidbody missileRigidbody = instantiatedMissile.GetComponent<Rigidbody>();

            missileRigidbody.AddForce((playerTracker.transform.position-barrel.transform.position) * missileSpeed);
        }

    }

}
