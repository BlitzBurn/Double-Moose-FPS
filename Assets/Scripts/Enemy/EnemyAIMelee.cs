using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAIMelee : MonoBehaviour
{
    public GameObject player;
    private GameObject playerTracker;

    public GameObject enemy;

    public NavMeshAgent agent;

    RaycastHit hit;

    float distance;
    public float attackRange;

    private bool hasLineOfSight;

    //public PlayerHealth ph;

    public void Start()
    {
        playerTracker = GameObject.FindWithTag("Player");
        
    }

    private void OnGUI()
    {
        //GUI.Label(new Rect(30, 30, 180, 80), "Distance: " +distance+hasLineOfSight );
    }

    private void Update()
    {
        if (distance <= attackRange && hasLineOfSight == true) 
        {
            PlayerHealth playerHealthReference = GameObject.FindObjectOfType(typeof(PlayerHealth)) as PlayerHealth;
            playerHealthReference.PlayerTakesDamage();
        }
    }

    void FixedUpdate()
    {
        agent.SetDestination(playerTracker.transform.position);

        distance = Vector3.Distance(enemy.transform.position, (playerTracker.transform.position));

        if (Physics.Raycast(enemy.transform.position, (playerTracker.transform.position- enemy.transform.position), out hit, Mathf.Infinity) && hit.transform.gameObject.tag == "Player")
        {
            
            //Debug.DrawRay(enemy.transform.position, (playerTracker.transform.position-enemy.transform.position), Color.red);
            hasLineOfSight = true;

            
        }
        else
        {
            hasLineOfSight = false;
        }

    }
}
