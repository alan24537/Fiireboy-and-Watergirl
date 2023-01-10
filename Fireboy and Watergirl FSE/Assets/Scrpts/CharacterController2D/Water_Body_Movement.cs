using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water_Body_Movement : MonoBehaviour {
    public Animator animator;
    public PlayerMovementWater watermove;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
        animator.SetFloat("Speed",Mathf.Abs(watermove.horizontalMove));
        animator.SetBool("isJumping",watermove.IsJumping);
        if (Input.GetButtonDown("JumpWater")) {
            animator.SetBool("isJumping",true);
        }
    }
    void FixedUpdate() {
    }
}
