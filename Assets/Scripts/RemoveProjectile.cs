using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveProjectile : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Player"&&collision.gameObject.tag!="Plasmatag") {
            DestroyProjectile();
        }
        
    }

    public void DestroyProjectile()
    {

        Destroy(gameObject);
    }

}
