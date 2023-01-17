using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMoveAttempt : MonoBehaviour
{
   private float horizontal;
    private float speed = 8f;
    private float jumpingPower = 8f;
    private bool isFacingRight = true;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Animator animator;

    // Start is called before the first frame update
    void Update()
    {
        horizontal = Input.GetAxisRaw("HorizontalFire");
        animator.SetFloat("Speed",Mathf.Abs(horizontal));

        if (Input.GetButton("JumpFire") && IsGrounded()){
            rb.velocity = new Vector2(rb.velocity.x,jumpingPower);
        }
        if (Input.GetButtonUp("JumpFire") && rb.velocity.y>0f){
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y*0.5f);
        }
        if (Input.GetButtonDown("JumpFire")) {
            animator.SetBool("isJumping",true);
        }

        if (rb.velocity.y <0){
            animator.SetBool("isFalling",true);
            animator.SetBool("isJumping",false);
        }
        else{
            animator.SetBool("isFalling",false);
        }
        if(IsGrounded()){
            animator.SetBool("isJumping",false);
        }
        Flip();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }
    private void Flip(){
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f){
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
    }
    }

    private bool IsGrounded(){
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }
}
