using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour {
    // Get the current position of the object
    public Vector3 start_pos, end_pos;

    // Create constant varriable for the speed
    public float speed;
    public bool isOn;

    // Lever object to see if we want to turn on the platform
    public LeverActivate lever;
    public ButtonActivate button;

    void Start () {
        speed = 1f;

        if (lever == null && button == null) {
            isOn = true;
        }
        else {
            isOn = false;
        }
    }

    void Update () {

        if (button != null) {
            isOn = button.isOn;
        }
        if (lever != null) {
            isOn = lever.isOn;
        }

        if (isOn) {
            // Move the object to the end position
            transform.position = Vector3.MoveTowards(transform.position, end_pos, Time.deltaTime * speed);
        }
        else {
            // Move the object to the start position
            transform.position = Vector3.MoveTowards(transform.position, start_pos, Time.deltaTime * speed);
        }
    }
}