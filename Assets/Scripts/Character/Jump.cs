using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    public GameObject Player;
    public Transform playerTransform;
    private bool PlayerIsTouchingTheGround;
    RaycastHit groundHit;

    [Range(0.0f, 2f)]
    public float downwardRaycast;
    public float jumpForce;
    Rigidbody PlayerRidgidbody;

    void Start()
    {

        
        
        
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump")&&PlayerIsTouchingTheGround==true)
        {
            
            PlayerRidgidbody = Player.GetComponent<Rigidbody>();

            PlayerRidgidbody.AddForce(playerTransform.up*jumpForce);
        }
    }

    void FixedUpdate()
    {
        
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out groundHit, downwardRaycast))
        {
         
           // 
            PlayerIsTouchingTheGround = true;
           

        }
        else
        {
            PlayerIsTouchingTheGround = false;
        }
    }

    

}
