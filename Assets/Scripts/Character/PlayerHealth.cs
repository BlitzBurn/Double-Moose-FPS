using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public  int playerHealth=10;
    public static bool isVulnerable;

    private float invisFrames = 1;
    private float time;

    public bool playerIsAlive;

   
    void Start()
    {
        time = 0;
        playerIsAlive = true;
    }

    public  void PlayerTakesDamage()
    {
        if (time >= invisFrames) {
            playerHealth -= 1;
            time = 0;
        }
    }


   
    void Update()
    {
        time += Time.deltaTime;
        if (playerHealth == 0 && playerIsAlive == true)
        {
            playerIsAlive = false;
            Debug.Log("You ded, big boy");
            
        }

    }

    void OnGUI()
    {
        GUI.Label(new Rect(10, 100, 150, 150), ""+playerHealth+" "+invisFrames+" "+ time);
    }

}
