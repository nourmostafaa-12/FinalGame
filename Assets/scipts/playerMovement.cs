using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 direction;
    public float forwardSpeed; 
    private int desiredLane = 1;
    public float laneDistance = 4;
    public float jumpForce;
    public float Gravity = -20;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>(); // Add parentheses here
    }

    // Update is called once per frame
    void Update()
    {
        direction.z = forwardSpeed;
        
        if (controller.isGrounded)
        {
            direction.y = -1;
            if(Input.GetKeyDown(KeyCode.UpArrow))
            {
            Jump();
            }
        }
        else
        {
            direction.y += Gravity*Time.deltaTime;
        }
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            desiredLane++;
            if(desiredLane==3)
               desiredLane = 2 ;
        }
          if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            desiredLane--;
            if(desiredLane== -1)
               desiredLane = 0 ;
        }

        Vector3 targetPosition = transform.position.z * transform.forward + transform.position.y * transform.up;
        if (desiredLane == 0)
        {
            targetPosition += Vector3.left * laneDistance ;
        } else if (desiredLane == 2)
        {
            targetPosition += Vector3.right * laneDistance;
        }
        transform.position = targetPosition;
    }

    private void FixedUpdate()
    {
        controller.Move(direction * Time.deltaTime);
    }
    private void Jump()
    {
      direction.y = jumpForce;
    }
}