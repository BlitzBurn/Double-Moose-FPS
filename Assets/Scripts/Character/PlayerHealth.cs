using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public GameObject gun;
    public GameObject canvasObject;

    public  int playerHealth=10;
    public static bool isVulnerable;

    private float invisFrames = 1;
    private float time;

    public static bool playerIsAlive;

   
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
            PlayerDies();
        }

    }

    public void PlayerDies()
    {
        gun.gameObject.SetActive(false);

        GetComponent<Jump>().enabled = false;
        GetComponent<CharacterMovement>().enabled = false;
        GetComponent<PlayerRotator>().enabled = false;
        GetComponent<ShootWeapon>().enabled = false;
        // GetComponent<>().enabled = false;
        canvasObject.SetActive(true);
        
    }

    void OnGUI()
    {
        if (playerIsAlive == true)
        {
            GUI.Label(new Rect(10, 100, 150, 150), "" + playerHealth);
        }
        else if(playerIsAlive==false)
        {
            GUIStyle styleDead = new GUIStyle();
            styleDead.alignment = TextAnchor.MiddleCenter;
            styleDead.fontSize = 30;
            styleDead.normal.textColor = Color.red;

            GUI.Label(new Rect(Screen.width / 2 - 200, Screen.height - 250, 400, 30), "Game Over", styleDead);
        }
    }

}
