using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_Body_Movement : MonoBehaviour
{
    public Animator animator;
    public FireMoveAttempt firemove;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
        animator.SetFloat("Speed",Mathf.Abs(firemove.horizontal));
        animator.SetBool("isJumping",firemove.IsJumping);
    }
    void FixedUpdate() {
    }
}
