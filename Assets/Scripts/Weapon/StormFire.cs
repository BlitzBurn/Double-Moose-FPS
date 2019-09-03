using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StormFire : MonoBehaviour
{
    public static bool stormFireEnabled = false;

    public float stormFireDuration;

    public GameObject stormFireOrb;

    private static float stormFireTimer;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            stormFireTimer = 0;
            stormFireEnabled = true;
            Debug.Log(stormFireEnabled);
            Debug.Log(stormFireTimer);
            
            stormFireOrb.transform.position = new Vector3(0, -50, 0);
        }
    }

    void Awake()
    {
        stormFireEnabled = false;
        stormFireTimer = 0;
    }

    
    void FixedUpdate()
    {
       
        stormFireTimer += Time.deltaTime;

        if (stormFireEnabled == true&& stormFireTimer <= stormFireDuration)
        {
            Debug.Log("StormFire Enabled");
            ShootWeapon.weaponFireRate = 0.05f;
            ShootWeapon.currentAmmo = ShootWeapon.maxAmmo;
        }
        else if (stormFireTimer >= stormFireDuration && stormFireEnabled==true)
        {
            Debug.Log(stormFireTimer);
            ShootWeapon.weaponFireRate = 0.3f;
            stormFireEnabled = false;
            Destroy(stormFireOrb);
        }
        
    }
}
