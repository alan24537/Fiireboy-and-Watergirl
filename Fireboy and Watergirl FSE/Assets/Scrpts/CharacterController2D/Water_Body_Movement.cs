using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water_Body_Movement : MonoBehaviour {
    public Animator animator;
    public WaterMovementAttempt watermove;
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
        animator.SetFloat("Speed",Mathf.Abs(watermove.horizontal));
        animator.SetBool("isJumping",watermove.IsJumping);
    }
    void FixedUpdate() {
    }
}
