using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float horizontalSpeed;


    void FixedUpdate()
    {
        transform.Translate(Input.GetAxis("Horizontal")*horizontalSpeed*Time.deltaTime, 0f, Input.GetAxis("Vertical")*horizontalSpeed * Time.deltaTime);
    }
}
