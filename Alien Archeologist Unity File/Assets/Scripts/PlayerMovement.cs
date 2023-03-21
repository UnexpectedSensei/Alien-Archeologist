using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    //Speed setting, in meters/second
    public float speed = 1;
    //Reference variable to use RigidBody
    //Set to null by default, meaning we DON'T have a reference yet.
    private Rigidbody2D physicsBody = null;

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
}
