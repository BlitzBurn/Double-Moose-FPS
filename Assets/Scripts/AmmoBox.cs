using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBox : MonoBehaviour
{
    private int AmmoInBox = 10;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="Player" && ShootWeapon.currentAmmo<ShootWeapon.maxAmmo)
        {
            ShootWeapon.currentAmmo += AmmoInBox;
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
