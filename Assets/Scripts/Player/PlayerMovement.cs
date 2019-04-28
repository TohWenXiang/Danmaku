using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    public float accelerationMagnitude;
    public float maximumAccelerationMagnitude;

    private Rigidbody2D playerRB;
    private Vector2 movementInput;
    private Vector2 acceleration;
    private Vector2 velocity;
    private float maximumAccelerationMagnitudeSquared
    {
        get
        {
            return maximumAccelerationMagnitude * maximumAccelerationMagnitude;
        }
    }

    private void Awake()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //--------------------gather input here--------------------
        movementInput.x = Input.GetAxisRaw("Horizontal");
        movementInput.y = Input.GetAxisRaw("Vertical");
        movementInput.Normalize();
        //---------------------------------------------------------
    }

    //physics based movement here
    private void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        //--------------------Physics based movement here--------------------
        //calculate acceleration
        acceleration = movementInput * accelerationMagnitude;

        //calculate velocity
        velocity = playerRB.velocity + (acceleration * Time.fixedDeltaTime);

        //make velocity magnitude same in all direction
        velocity = velocity.normalized * velocity.magnitude;

        //clamp to maximum magnitude
        if (velocity.sqrMagnitude > maximumAccelerationMagnitudeSquared)
        {
            velocity = velocity.normalized * maximumAccelerationMagnitude;
        }

        //apply drag if not moving
        //seek for help online!!!

        //update velocity
        playerRB.velocity = velocity;

        

        //-------------------------------------------------------------------
    }


}
