using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuadDamage : MonoBehaviour
{
    public GameObject quadDamage;
    public static bool quadDamageEnabled;

    void Start()
    {
        quadDamageEnabled = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            quadDamageEnabled = true;
            Destroy(quadDamage);
        }
    }

    void Update()
    {
        
    }
}
