using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootWeapon : MonoBehaviour
{
    public GameObject plasmaProjectile;
    public Transform gun;
    public float weaponFireRate;
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

    
    void FixedUpdate()
    {
       // maxAmmo = Mathf.Clamp(maxAmmo, 0, ammo);

        if (currentAmmo>maxAmmo)
        {
            currentAmmo = maxAmmo;
        }

        time += Time.deltaTime;

        if (Input.GetButton("Fire1") && time >= weaponFireRate && currentAmmo>0)
        {
            
            GameObject instantiatedProjectile = Instantiate(plasmaProjectile, gun.position, gun.rotation);

            Rigidbody projectileRigidbody = instantiatedProjectile.GetComponent<Rigidbody>();

            projectileRigidbody.AddForce(gun.forward*bulletSpeed);

            currentAmmo = currentAmmo - 1;

            time = 0;
        }
    }

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 150, 50), "Ammo: " + currentAmmo + " /  " + maxAmmo);
    }
}
