using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterdoor_movement : MonoBehaviour
{
    public Animator anim;
    private void Start(){
        GetComponent<Collider2D>().isTrigger = true;
        //anim = GetComponentInParent<Animator>();
    }
    private void Update(){
        
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
