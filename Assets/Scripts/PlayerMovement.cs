using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public static float moveSpeed = 8f;
    public static float jumpSpeed = 16f;

    public PowerUP Power;

    // skapar en Groundcheck
    public GroundChecker groundCheck;
    // skapar en rigidbody
    private Rigidbody2D rbody;

    public bool CanDoubleJump;

    // Use this for initialization
    void Start()
    {
        moveSpeed = 6;
        jumpSpeed = 12;
        // hämtar rigidbody i 2D
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Sätter velocity på spelaren i direktionen (i vector 2) ditåt man trycker * movespeed
        rbody.velocity = new Vector2(
            Input.GetAxisRaw("Horizontal") * moveSpeed,
            rbody.velocity.y);
        // om man trycker på hopp knapen (spacebar)
        if(Input.GetButtonDown("Jump"))
        {
            // Kollar om spelaren är på marken från scriptet "groundCheck" så man inte kan hoppa när man är i luften
            if (groundCheck.isGrounded > 0)
            {
                // Sätter velocity på spelarn rigidbody jumpspeed
                rbody.velocity = new Vector2(rbody.velocity.x,jumpSpeed);
            }
        }
        

        
    }
}
