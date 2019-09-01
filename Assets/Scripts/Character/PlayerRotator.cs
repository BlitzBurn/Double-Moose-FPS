using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotator : MonoBehaviour
{
    private float cameraRotation=0.0f;
    
    void Start()
    {       
        
    }

    
    void LateUpdate()
    {
        cameraRotation += CameraController.mouseSensitivity * Input.GetAxis("Mouse X");

        transform.eulerAngles = new Vector3(0.0f, cameraRotation, 0.0f);

    }
}
