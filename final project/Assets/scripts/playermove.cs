using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{

    public float speed = 6f;
    public float gravity = 20f;
    public float jump  = 6f;

    CharacterController controller;
    Vector3 movediractoin = Vector3.zero; 

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();  
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.isGrounded)
        {

            movediractoin = new Vector3(Input.GetAxis("Horizontal"), .0f, Input.GetAxis("Vertical"));

            movediractoin *= speed;
            movediractoin = transform.TransformDirection(movediractoin);
            if(Input.GetButton ("Jump"))
            {

                movediractoin.y = jump; 
            }
        }

        movediractoin.y -= gravity * Time.deltaTime;

        controller.Move(movediractoin * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {

            speed = 15f; 
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 6f; 
        }
    }


}
