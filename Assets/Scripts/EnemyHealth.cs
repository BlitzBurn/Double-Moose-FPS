using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public static float HealtPoints;
    public int AmountOfHealth;

    

    void Start()
    {
        
    }

  
    void Update()
    {

        if (AmountOfHealth == 0)
        {
            Destroy(gameObject);
            Debug.Log("Ded");
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Plasmatag")
        {
            RemoveProjectile explodeScript = collision.gameObject.GetComponent<RemoveProjectile>();
            AmountOfHealth = AmountOfHealth - 1;
            explodeScript.DestroyProjectile();
        }
        
        
    }


     

}
