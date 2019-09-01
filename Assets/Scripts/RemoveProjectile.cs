using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveProjectile : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Player") {
            DestroyProjectile();
        }
        
    }

    public void DestroyProjectile()
    {
       
        Destroy(gameObject);
    }

}
