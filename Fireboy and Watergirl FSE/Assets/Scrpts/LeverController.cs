using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverController : MonoBehaviour {
    // Start is called before the first frame update

    // Gets the current rotation of the lever's hinge joint 2d
    float rotation;
    public bool isOn;

    float GetRotation() {
        return GetComponent<HingeJoint2D>().jointAngle;
    }

    void Start() {
        rotation = 0f;
        isOn = false;
    }

    // Update is called once per frame
    void Update() {

        rotation = GetRotation();
        if (rotation < -75f) {
            isOn = true;
        }
        else {
            isOn = false;
        }
        
    }
}
