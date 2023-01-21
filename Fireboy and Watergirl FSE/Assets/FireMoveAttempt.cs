// Reference - https://www.youtube.com/watch?v=K1xZ-rycYY8
// We edited it to make sure u can only jump once and not continously when holding the jump button

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMoveAttempt : MonoBehaviour
{
    public float horizontal; //holds the dir of hori move
    private float speed = 3f; //how fast they move 
    private float jumpingPower = 5f; //how high the jump
    private bool isFacingRight = true; //when character is facing right or not (used when flipping animation)
    public bool IsJumping = false; //for teh animator to konw when we are jumping
    private bool jump; // if we are allowed to jump. (we can only single jump, meaing holding the button has no continuous jump)


    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Animator animator;

    // Start is called before the first frame update
    void Update()
    {
        horizontal = Input.GetAxisRaw("HorizontalFire"); //gets the axis input from the 'w' and 'a' direction
        animator.SetFloat("Speed",Mathf.Abs(horizontal)); //to tell animator tht the player is moving left or right

        if (Input.GetButton("JumpFire") && IsGrounded() && jump){ // allow jump when the player is on the ground and has only jumped once (single jumps not continuous when you hold the jump button)
            rb.velocity = new Vector2(rb.velocity.x,jumpingPower); //the rigid body's velocity, makes the jump depending on the jumping power
            IsJumping = true; //sets teh variable to true,
            animator.SetBool("isJumping",true); //tell the animator we are jumping so we know to chnage the animation
            jump = false; //do not allow jump
        }
        if (Input.GetButtonUp("JumpFire") && rb.velocity.y>0f){ //when teh button is released, we start to fall
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y*0.5f); // this allows for short jumps and long jumps
        }
        if(Input.GetButtonDown("JumpFire")){ // when the button is pressed down again, then we set jump to true (when we loop through again is is turned false stopping continuous jumping)
            jump = true;
        }
        if (rb.velocity.y <0){ //if the player is falling
            animator.SetBool("isFalling",true); //tell animator falling true
            animator.SetBool("isJumping",false); // meaining fallling is false
            IsJumping = false; // not jumping
        }
        else{ // ofhterwise, we are not falling
            animator.SetBool("isFalling",false);
        }
        Flip(); //flips based on which direction player is facing
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y); //change the players position based on what is happining
    }
    private void Flip(){
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f){ //if we are facing right and not going right or facing left but going right
            isFacingRight = !isFacingRight; //reverse the dir
            Vector3 localScale = transform.localScale; //flipts the characters
            localScale.x *= -1f;
            transform.localScale = localScale;
    }
    }

    private bool IsGrounded(){ //checks if the player is hitting teh gound
        return Physics2D.OverlapCircle(groundCheck.position, 0.1f, groundLayer); //circle area checks if the ground is in its ares, if so returns true
    }
}