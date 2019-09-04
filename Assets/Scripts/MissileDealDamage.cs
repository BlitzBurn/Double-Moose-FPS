using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileDealDamage : MonoBehaviour
{
    public GameObject Missile;
    public PlayerHealth playerHealthReference;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="Player")
        {
           
            playerHealthReference = GameObject.FindObjectOfType(typeof(PlayerHealth)) as PlayerHealth;

            playerHealthReference.PlayerTakesDamage();

            Destroy(Missile);
            
        }
    }

}
