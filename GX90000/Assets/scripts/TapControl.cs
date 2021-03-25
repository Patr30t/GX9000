using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapControl : MonoBehaviour
{
    Rigidbody rb;

    bool moveLeft;
    bool moveRight;

    float horizontalMove;
    float verticalMove;

    public float speed = 300;

    // fetch RigidBody
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    //leftbutton
    public void ButtonDownLeft()
    {
        moveLeft = false;
    }

    //rightbutton
    public void ButtonDownRight()
    {
        moveRight = false;
    }

    private void Update() {
        Move();
    }

    void Move()
    {
        if (moveLeft)
        {
            horizontalMove =-speed;
        }

        else if (moveRight)
        {
            horizontalMove = speed;
        }
        else
        {
            horizontalMove = 0;
        }
    }

    private void FixedUpdate() {
        rb.velocity = new Vector3(horizontalMove * Time.deltaTime, rb.velocity.y, verticalMove * Time.deltaTime);
    }

}
