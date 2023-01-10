using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementFire : MonoBehaviour {

    public CharacterController2D controller;
    public Animator animator;
    public float runSpeed = 40f;
    public bool Falling = false;
    public Rigidbody2D m_Rigidbody2D;
    public float horizontalMove = 0f;
    bool jump = false;
    public bool IsJumping = false;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
        horizontalMove =  Input.GetAxisRaw("HorizontalFire") * runSpeed;
        animator.SetFloat("Speed",Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("JumpFire")) {
            jump = true;
            animator.SetBool("isJumping",true);
            IsJumping = true;
        }

        if (m_Rigidbody2D.velocity.y <0){
            Falling = true;
            animator.SetBool("isFalling",true);
            animator.SetBool("isJumping",false);
            IsJumping = false;
        }
        else{
            Falling = false;
            animator.SetBool("isFalling",false);
        }
    }
    public void OnLanding(){
        animator.SetBool("isJumping",false);
        IsJumping = false;
    }
    void FixedUpdate() {
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
