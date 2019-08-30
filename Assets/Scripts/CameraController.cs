using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public float horizontalSpeed;
    public float verticalSpeed;

    private float rotHor=0.0f;
    private float rotVer=0.0f;

    void Start()
    {
        
    }

   
    void FixedUpdate()
    {
        rotHor += horizontalSpeed * Input.GetAxis("Mouse X");
        rotVer -= verticalSpeed * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(rotVer, rotHor, 0.0f);
    }
}
