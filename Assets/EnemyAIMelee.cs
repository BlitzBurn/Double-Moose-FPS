using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAIMelee : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;

    public NavMeshAgent agent;
    RaycastHit hit;
    float distance;
    private bool hasLineOfSight;

    void Start()
    {
        
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(30, 30, 180, 80), "Distance: " +distance+hasLineOfSight );
    }

    void FixedUpdate()
    {
        //agent.SetDestination(player.transform.position);

        distance = Vector3.Distance(enemy.transform.position, (player.transform.position));

        if (Physics.Raycast(enemy.transform.position, (player.transform.position- enemy.transform.position), out hit, Mathf.Infinity))
        {
            Debug.DrawRay(enemy.transform.position, (player.transform.position-enemy.transform.position), Color.red);
            hasLineOfSight = true;

            
        }

    }
}
