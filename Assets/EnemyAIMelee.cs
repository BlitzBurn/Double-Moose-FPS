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
    public float attackRange;

    private bool hasLineOfSight;

    public PlayerHealth ph;

    public void Start()
    {
        
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(30, 30, 180, 80), "Distance: " +distance+hasLineOfSight );
    }

    private void Update()
    {
        if (distance <= attackRange && hasLineOfSight == true) 
        {
            //PlayerHealth ph = gameObject.GetComponent<PlayerHealth>();

            ph.PlayerTakesDamage();
        }
    }

    void FixedUpdate()
    {
        agent.SetDestination(player.transform.position);

        distance = Vector3.Distance(enemy.transform.position, (player.transform.position));

        if (Physics.Raycast(enemy.transform.position, (player.transform.position- enemy.transform.position), out hit, Mathf.Infinity) && hit.transform.gameObject.tag == "Player")
        {
            
            Debug.DrawRay(enemy.transform.position, (player.transform.position-enemy.transform.position), Color.red);
            hasLineOfSight = true;

            
        }
        else
        {
            hasLineOfSight = false;
        }

    }
}
