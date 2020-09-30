using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{

    CharacterController characterController;
    //Public vars
    public float speed;
    public float sprint;
    public float mouseSensitivity;


    //Private vars

    // Start is called before the first frame update
    void Start()
    {
       characterController = GetComponent<CharacterController>();
    }

    void FixedUpdate()
    {

        //WASD movement
     if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + new Vector3(0, 0, speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + new Vector3(0, 0, -speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + new Vector3(-speed/2, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + new Vector3(speed/2, 0, 0);
        }
    }
}
