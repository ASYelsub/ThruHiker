using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTestMovement : MonoBehaviour
{
    GameObject thisObject;
    public Camera camera;
    Vector3 movementVec;
    Vector3 notMoving;
    float speed = .05f;

    public float minX = -60f;
    public float maxX = 60f;

    public float sensitivity;

    float rotY = 0f;
    float rotX = 0f;
    bool isOpen = false;
    private void Start()
    {
        thisObject = this.gameObject;
        movementVec = new Vector3();
        notMoving = new Vector3(0, 0, 0);

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = true;

    }
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            movementVec = Vector3.right * speed;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            movementVec = Vector3.left * speed;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            movementVec = Vector3.forward * speed;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            movementVec = Vector3.back * speed;
        }
        else
        {
            movementVec = notMoving;
        }

        gameObject.transform.localPosition = gameObject.transform.localPosition + movementVec;
        
        if (Input.GetKeyDown(KeyCode.Escape) && isOpen == false)
        {
            isOpen = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && isOpen == true)
        {
            isOpen = false;
        }
        if(isOpen == false)
        {
            rotY += Input.GetAxis("Mouse X") * sensitivity;
            rotX += Input.GetAxis("Mouse Y") * sensitivity;

            rotX = Mathf.Clamp(rotX, minX, maxX);

            transform.localEulerAngles = new Vector3(0, rotY, 0);
            gameObject.transform.localEulerAngles = new Vector3(0, rotY, 0);
            camera.transform.localEulerAngles = new Vector3(-rotX, 0, 0);
        }
    }

  
}
