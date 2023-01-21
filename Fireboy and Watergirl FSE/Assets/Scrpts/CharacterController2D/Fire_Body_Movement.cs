//script used to control the body animation, based of teh script FireMove

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_Body_Movement : MonoBehaviour
{
    //parameters to get from script
    public Animator animator; //animator for body
    public FireMoveAttempt firemove; //head scirpt

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
        animator.SetFloat("Speed",Mathf.Abs(firemove.horizontal)); //set the speed based on the direction we moving in
        animator.SetBool("isJumping",firemove.IsJumping); //based on the firemove script, we set according to the isjumpign var
    }
    void FixedUpdate() {
    }
}
