using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{
    //Public vars
    public float speed;
    public float sprint;

    //Private vars

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

     if (Input.GetKey(KeyCode.W))
        {
            new Vector3(0, 0, speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            new Vector3(0, 0, -speed);
        }

    }
}
