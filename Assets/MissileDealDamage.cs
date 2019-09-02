using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileDealDamage : MonoBehaviour
{

    public PlayerHealth playerHealthReference;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            //PlayerHealth playerHealthReference = gameObject.GetComponent<PlayerHealth>();
            playerHealthReference = GameObject.FindObjectOfType(typeof(PlayerHealth)) as PlayerHealth;

            playerHealthReference.PlayerTakesDamage();
            
        }
    }

}
