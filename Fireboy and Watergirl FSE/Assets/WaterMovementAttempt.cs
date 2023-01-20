using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterMovementAttempt : MonoBehaviour
{
    public float horizontal;
    private float speed = 4f;
    private float jumpingPower = 6f;
    private bool isFacingRight = true;
    public bool IsJumping = false;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Animator animator;

    // Start is called before the first frame update
    void Update()
    {
        horizontal = Input.GetAxisRaw("HorizontalWater");
        animator.SetFloat("Speed",Mathf.Abs(horizontal));

        if (Input.GetButton("JumpWater") && IsGrounded()){
            rb.velocity = new Vector2(rb.velocity.x,jumpingPower);
            IsJumping = true;
            animator.SetBool("isJumping",true);
        }
        if (Input.GetButtonUp("JumpWater") && rb.velocity.y>0f){
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y*0.5f);
        }
        if (rb.velocity.y <0){
            animator.SetBool("isFalling",true);
            animator.SetBool("isJumping",false);
            IsJumping = false;
        }
        else{
            animator.SetBool("isFalling",false);
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
        return Physics2D.OverlapCircle(groundCheck.position, 0f, groundLayer);
    }
}
