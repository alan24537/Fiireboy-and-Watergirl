// This is the script for the button. It checks if the button's hitbox has collided with the button activator and if so, 
// it sets the isOn variable to true. When the button hixbox leaves the trigger, isOn is set to false.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonActivate : MonoBehaviour {

    [HideInInspector] public bool isOn; // Whether the button is on or off

    // Start is called before the first frame update
    void Start() {
        isOn = false;
    }

    void OnTriggerEnter2D(Collider2D c2d) { // If the button's hitbox has collided with the button activator, set isOn to true
        isOn = true;
    }

    void OnTriggerExit2D(Collider2D c2d) { // If the button's hitbox has left the button activator, set isOn to false
        isOn = false;
    }
}
