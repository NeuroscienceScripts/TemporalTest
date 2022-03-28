using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Vector2 rotation = Vector2.zero; 
    public float mouseSensitivity = 100;

    public bool active; 
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            active = !active; 
        if (active)
        {
            rotation.y += Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
            rotation.x -= Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

            transform.eulerAngles = (Vector2) rotation;
        }
    }
}
