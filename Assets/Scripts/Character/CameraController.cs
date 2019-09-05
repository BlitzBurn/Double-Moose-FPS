using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public static float mouseSensitivity=5f;

    private float cameraRotationHorizontal=0.0f;
    private float cameraRotationVertical=0.0f;

    void Awake()
    {
        LockCursor();        
    }

   
    void LateUpdate()
    {
        cameraRotationHorizontal += mouseSensitivity * Input.GetAxis("Mouse X");
        cameraRotationVertical -= mouseSensitivity * Input.GetAxis("Mouse Y");

        cameraRotationVertical = Mathf.Clamp(cameraRotationVertical,-90.0f, 90.0f);
        transform.eulerAngles = new Vector3(cameraRotationVertical, cameraRotationHorizontal, 0.0f);     
    }

    private void LockCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

}
