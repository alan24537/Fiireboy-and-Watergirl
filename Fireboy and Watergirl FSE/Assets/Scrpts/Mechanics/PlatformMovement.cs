// This script will move a platform from one position to another. The platform can be turned on and off by a lever or button. 
// If there is no lever or button, the platform will always be on.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour {
    // Get the current position of the object
    [SerializeField] public Vector3 start_pos, end_pos; // The start and end positions of the platform

    // object to see if we want to turn on the platform
    [SerializeField] public LeverActivate lever;
    [SerializeField] public ButtonActivate button1;
    [SerializeField] public ButtonActivate button2;

    [SerializeField] public float speed; // The speed at which the platform moves
    [HideInInspector] public bool isOn; // Whether the platform is on or off


    void Start () {
        // speed = 1f;

        if (lever == null && button1 == null && button2 == null) { // If there is no lever or button, the platform will always be on
            isOn = true;
        }
        else {
            isOn = false;
        }
    }

    void Update () {

        if (button1 != null && button2 == null) { // if there is only one button, set isOn to the button's isOn
            isOn = button1.isOn;
        }
        if (button2 != null && button1 == null) { // if there is only one button, set isOn to the button's isOn
            isOn = button2.isOn;
        }
        if (button1 != null && button2 != null) { // if there are two buttons, isOn is true if either button is on
            isOn = button1.isOn || button2.isOn;
        }
        if (lever != null) { // if there is a lever, set isOn to the lever's isOn
            isOn = lever.isOn;
        }

        if (isOn) { // If the platform is on, move it from start_pos to end_pos
            transform.position = Vector3.MoveTowards(transform.position, end_pos, Time.deltaTime * speed);
        }
        else { // If the platform is off, move it from end_pos to start_pos
            transform.position = Vector3.MoveTowards(transform.position, start_pos, Time.deltaTime * speed);
        }
    }
}