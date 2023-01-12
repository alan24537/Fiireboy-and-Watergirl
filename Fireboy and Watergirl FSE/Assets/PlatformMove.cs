using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour {
    // Get the current position of the object
    public Vector3 start_pos, end_pos;

    // Create constant varriable for the speed
    public float speed = 1f;
    
    bool towardsStart;

    void Start () {

    }

    void Update () {

        if (transform.position == start_pos) {
            towardsStart = false;
        }
        else if (transform.position == end_pos) {
            towardsStart = true;
        }

        // If the current position is equal to the start position
        if (!towardsStart) {
            // Move the object to the end position
            transform.position = Vector3.MoveTowards(transform.position, end_pos, Time.deltaTime * speed);
        }
        // If the current position is equal to the end position
        else if (towardsStart) {
            // Move the object to the start position
            transform.position = Vector3.MoveTowards(transform.position, start_pos, Time.deltaTime * speed);
        }
    }
}