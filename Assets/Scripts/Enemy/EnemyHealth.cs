using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public static float HealtPoints;
    public int AmountOfHealth;

    public EnemyDead ded;

    void Start()
    {
        
    }

  
    void Update()
    {

        if (AmountOfHealth == 0)
        {
            Destroy(gameObject);
            ded.DropAmmoPack();
            
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
