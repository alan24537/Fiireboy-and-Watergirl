using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireDoor_Movement : MonoBehaviour
{
    public Animator anim;
    [HideInInspector] public bool isDone;
    private void Start(){
        GetComponent<Collider2D>().isTrigger = true;
        isDone = false;
        anim = GetComponent<Animator>();
    }
    private void Update(){
        if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 1 && !anim.IsInTransition(0) && anim.GetCurrentAnimatorStateInfo(0).IsName("firedoor_up")) {
            isDone = true;
        }
        else if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 1 && !anim.IsInTransition(0) && anim.GetCurrentAnimatorStateInfo(0).IsName("firedoor_down")) {
            isDone = false;
        }
    }
    void OnTriggerEnter2D (Collider2D c2d) {

        // Check if the filename of the collider is "Fireboy" and the collied objects filename contians "fire_diamond"
        if (c2d.name.Contains("Fireboy") && gameObject.name.Contains("FireDoor")) {
            anim.SetBool("isOn",true);
        }


    }
    void OnTriggerExit2D (Collider2D c2d) {

        // Check if the filename of the collider is "Fireboy" and the collied objects filename contians "fire_diamond"
        if (c2d.name.Contains("Fireboy") && gameObject.name.Contains("FireDoor")) {
            anim.SetBool("isOn",false);
        }

    }
}
