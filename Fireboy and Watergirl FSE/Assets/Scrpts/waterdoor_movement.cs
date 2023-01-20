// Controls the animation of the water door

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDoor_Movement : MonoBehaviour {
    [SerializeField] public Animator anim; // The animator of the water door
    [HideInInspector] public bool isDone; // Used to check if the door is fully up or down
    private void Start(){
        GetComponent<Collider2D>().isTrigger = true;
        isDone = false;
        anim = GetComponent<Animator>();
    }
    private void Update() {

        // if the water door is fully up, set isDone to true
        if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 1 && !anim.IsInTransition(0) && anim.GetCurrentAnimatorStateInfo(0).IsName("waterdoor_up")) {
            isDone = true;
        }
        // if the water door is fully down, set isDone to false
        else if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 1 && !anim.IsInTransition(0) && anim.GetCurrentAnimatorStateInfo(0).IsName("waterdoor_down")) {
            isDone = false;
        }
    }
    void OnTriggerEnter2D (Collider2D c2d) {

        // Check if the filename of the collider is "Fireboy" and the collied objects filename contians "fire_diamond"
        if (c2d.name.Contains("Watergirl") && gameObject.name.Contains("WaterDoor")) {
            anim.SetBool("isOn",true);
        }
    }
    void OnTriggerExit2D (Collider2D c2d) {

        // Check if the filename of the collider is "Fireboy" and the collied objects filename contians "fire_diamond"
        if (c2d.name.Contains("Watergirl") && gameObject.name.Contains("WaterDoor")) {
            anim.SetBool("isOn",false);
        }
    }
}
