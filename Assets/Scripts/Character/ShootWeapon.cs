using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootWeapon : MonoBehaviour
{
    public GameObject plasmaProjectile;
    public Transform gun;
    public static float weaponFireRate=0.2f;
    private float time;

    public float bulletSpeed;


    public int ammo;
    public static int currentAmmo, maxAmmo;
    private static float currentAmmoFloat;

    
    
    void Start()
    {
        currentAmmo = ammo;
        maxAmmo = ammo;
      
    }

    public void ShootWeaponStandard()
    {
        GameObject instantiatedProjectile = Instantiate(plasmaProjectile, gun.position, gun.rotation);

        Rigidbody projectileRigidbody = instantiatedProjectile.GetComponent<Rigidbody>();

        projectileRigidbody.AddForce(gun.forward * bulletSpeed);
    }
    
    public void ShootWeaponQuadDamage()
    {
        for(int i = 0; i<4; i++)
        {
            GameObject instantiatedProjectile = Instantiate(plasmaProjectile, gun.position, gun.rotation);

            Rigidbody projectileRigidbody = instantiatedProjectile.GetComponent<Rigidbody>();

            int angle = +i;
            Debug.Log("Kaboom");
            projectileRigidbody.AddForce((gun.forward) * bulletSpeed);
        }
    }

    void FixedUpdate()
    {
       

        if (currentAmmo>maxAmmo)
        {
            currentAmmo = maxAmmo;
        }

        time += Time.deltaTime;

        if (Input.GetButton("Fire1") && time >= weaponFireRate && currentAmmo>0)
        {
          
                ShootWeaponStandard();
          
            
            currentAmmo = currentAmmo - 1;

            time = 0;
        }
    }

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 150, 50), "Ammo: " + currentAmmo + " /  " + maxAmmo);
    }
}
