using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public Joystick joystick;
    private float horizontalMove = 0f;
    private float verticalMove = 0f;

    [SerializeField] private float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        
        /*
        horizontalMove = joystick.Horizontal * speed;
        verticalMove = joystick.Vertical * speed;

        if (joystick.Horizontal >= .2f)
        {
            horizontalMove = speed;
        }
        else if (joystick.Horizontal <= -.2f)
        {
            horizontalMove = -speed;
        }
        else
        {
            horizontalMove = 0f;
        }

        if (joystick.Vertical >= .2f)
        {
            verticalMove = speed;
        }
        else if (joystick.Vertical <= -.2f)
        {
            verticalMove = -speed;
        }
        else
        {
            verticalMove = 0f;
        } */
        // x: moveHorizontal, y: speed, moveVertical
        // Vector3 movement = new Vector3(horizontalMove, speed, verticalMove);
        Vector3 movement = new Vector3(moveHorizontal, speed, moveVertical);

        rb.AddForce(movement);
    }
}
