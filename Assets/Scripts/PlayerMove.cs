using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //floats for movement and turning speed variables
    public float moveSpeed;
    public float turnSpeed;

    //a reference to the rigidbody
    public Rigidbody rBody;

    void Start()
    {
        
    }

    
    void Update()
    {
        //check if the player is holding down W
        if(Input.GetKey(KeyCode.W) == true)
        {
            //move the player in the direction they are facing
            transform.position += transform.forward * Time.deltaTime * moveSpeed;
        }
        //check if the player is holding down S
        else if(Input.GetKey(KeyCode.S) == true)
        {
            //move the player oppsite to the direction they are facing
            transform.position += -transform.forward * Time.deltaTime * moveSpeed;
        }

        //check if the player is holding down D
        if (Input.GetKey(KeyCode.D))
        {
            //turn the character to the right, modified by the turnSpeed
            Vector3 newDirection = Vector3.RotateTowards(transform.forward, transform.right, turnSpeed * Time.deltaTime, 0f);
            transform.rotation = Quaternion.LookRotation(newDirection);
        }
        //check if the player is holding down A
        else if (Input.GetKey(KeyCode.A))
        {
            //turn the character to the left, modified by the turnSpeed
            Vector3 newDirection = Vector3.RotateTowards(transform.forward, -transform.right, turnSpeed * Time.deltaTime, 0f);
            transform.rotation = Quaternion.LookRotation(newDirection);
        }
    }
}
