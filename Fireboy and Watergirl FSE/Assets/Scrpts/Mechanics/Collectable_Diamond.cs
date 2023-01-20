// This script is attached to the diamond game object. It checks if the player has collided with the diamond and if so, it adds 1 to the total diamonds and destroys the diamond.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable_Diamond : MonoBehaviour {

    void Awake () {
        // Set the diamond to be a trigger so that it doesn't have physical collisions
        GetComponent<Collider2D>().isTrigger = true;
    }

    void OnTriggerEnter2D (Collider2D c2d) {

        // Check if the filename of the collider is "Fireboy" and the collied objects filename contians "fire_diamond"
        if (c2d.name.Contains("Fireboy") && gameObject.name.Contains("fire_diamond")) {
            // Add 1 to the total diamonds and destroy the diamond
            PlayerStats.fire_gems ++;
            Destroy(gameObject);
        }

        // Check if the filename of the collider is "Waterboy" and the collied objects filename contians "water_diamond"
        else if (c2d.name.Contains("Watergirl") && gameObject.name.Contains("water_diamond")) {
            // Add 1 to the total diamonds and destroy the diamond
            PlayerStats.water_gems ++;
            Destroy(gameObject);
        }
        // Check if it is the special diamond
        else if (gameObject.name == "Special Diamond") {
            // Add 1 to the total diamonds and destroy the diamond
            PlayerStats.special_gems ++;
            Destroy(gameObject);
        }

    }
}
