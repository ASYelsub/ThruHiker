using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTestMovement : MonoBehaviour
{
    GameObject thisObject;
    public GameObject camera;
    Vector3 movementVec;
    float h = 40.0f;
    float v = 40.0f;
    // Update is called once per frame
    private void Start()
    {
        thisObject = this.gameObject;
        movementVec = new Vector3();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            movementVec = new Vector3(1, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            movementVec = new Vector3(-1, 0, 0);
        }

        if (Input.GetKey(KeyCode.W))
        {
            movementVec = new Vector3(0, 0, 1);
        }
        if (Input.GetKey(KeyCode.S))
        {
            movementVec = new Vector3(0, 0, -1);
        }
        if(!Input.GetKey(KeyCode.A) || !Input.GetKey(KeyCode.D) || !Input.GetKey(KeyCode.S) || !Input.GetKey(KeyCode.W))
        {
            movementVec = new Vector3(0, 0, 0);
        }
        gameObject.transform.position = gameObject.transform.position + movementVec;


        // If Right Button is clicked Camera will move.
        while (Input.GetMouseButtonDown(1))
        {
            h = h * Input.GetAxis("Mouse Y");
            v = v * Input.GetAxis("Mouse X");
            camera.transform.Translate(v, h, 0);
        }
    }

  
}
