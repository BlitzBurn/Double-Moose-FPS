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

    private IEnumerator StormFireActivated()
    {
        stormFireEnabled = true;
        

        yield return new WaitForSeconds(stormFireDuration);
        stormFireEnabled = false;
        
        Destroy(stormFireOrb);

    }

    void Awake()
    {
        stormFireEnabled = false;
        stormFireTimer = 100;
    }

    private void Update()
    {
        stormFireTimer += Time.deltaTime;

        if (stormFireEnabled==true)
        {
            ShootWeapon.weaponFireRate = 0.05f;
            ShootWeapon.currentAmmo = ShootWeapon.maxAmmo;
        }
        else if (stormFireEnabled == false)
        {
            ShootWeapon.weaponFireRate = 0.2f;
        }
       
    }

    void OnGUI()
    {
         if (stormFireEnabled==true)
         {
            GUIStyle stormFireStyle = new GUIStyle();
            stormFireStyle.alignment = TextAnchor.MiddleCenter;
            stormFireStyle.fontSize = 30;
            stormFireStyle.normal.textColor = Color.cyan;

            GUI.Label(new Rect(Screen.width / 2 - 200, Screen.height - 370, 400, 30), "StormFire", stormFireStyle);
          }
    }

}
