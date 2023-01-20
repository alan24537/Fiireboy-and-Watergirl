// This script is used to determine if the lever is on or off and is attached to the lever object. 
// It checks the rotation of the lever's hinge joint 2d and if it is less than -75 degrees, it sets isOn to true. If it is greater than -75 degrees, it sets isOn to false.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverActivate : MonoBehaviour {

    private float rotation; // The rotation of the lever's hinge joint 2d
    [HideInInspector] public bool isOn; // Whether the lever is on or off

    float GetRotation() { // Returns the rotation of the lever's hinge joint 2d
        return GetComponent<HingeJoint2D>().jointAngle;
    }

    void Start() {
        rotation = 0f;
        isOn = false;
    }

    // Update is called once per frame
    void Update() {

        // Checks if the lever is on or off by checking the rotation of the lever's hinge joint 2d
        rotation = GetRotation();
        if (rotation < -75f) {
            isOn = true;
        }
        else {
            isOn = false;
        }
        
    }
}
