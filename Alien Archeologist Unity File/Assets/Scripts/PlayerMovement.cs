using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    //Speed setting, in meters/second
    public float speed = 1;
    //Jump speed setting, in meters/second
    public float jumpSpeed = 10;
    private Rigidbody2D physicsBody = null;
    public Collider2D groundSensor = null;
    public LayerMask groundLayer = 0;

    private void Awake()
    {
        physicsBody = GetComponent<Rigidbody2D>();
    }

    public void MoveLeft()
    {
        //make a variable to hold our velocity and get
        //current velocity from the physics component
        Vector2 newVelocity = physicsBody.velocity;
        //set our velocity to move in the negative x (left) direction
        newVelocity.x = -speed;
        //update our physics component's velocity to be our newly changed value
        physicsBody.velocity = newVelocity;
    }

    public void MoveRight()
    {
        //make a variable to hold our velocity and get
        //current velocity from the physics component
        Vector2 newVelocity = physicsBody.velocity;
        //set our velocity to move in the negative x (left) direction
        newVelocity.x = +speed;
        //update our physics component's velocity to be our newly changed value
        physicsBody.velocity = newVelocity;
    }

    public void Jump()
    
    {
        if (groundSensor.IsTouchingLayers(groundLayer))
        {
            //Make a variable to hold our velocity and get the
            //Current velocity from the physics component
            Vector2 newVelocity = physicsBody.velocity;
            //Set our velocity to move in the positive y (up) direction
            newVelocity.y = jumpSpeed;
            //Update our physics component's velocity to be our newly changed value
            physicsBody.velocity = newVelocity;
        }
    }
            
}
