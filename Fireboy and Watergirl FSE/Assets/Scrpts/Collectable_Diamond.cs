using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable_Diamond : MonoBehaviour {

    public static int totalFireDiamonds = 0;
    public static int totalWaterDiamonds = 0;

    void Awake () {
        // Set the diamond's value to 1
        GetComponent<Collider2D>().isTrigger = true;
    }

    void OnTriggerEnter2D (Collider2D c2d) {

        // Check if the filename of the collider is "Fireboy" and the collied objects filename contians "fire_diamond"
        if (c2d.name.Contains("Fireboy") && gameObject.name.Contains("fire_diamond")) {
            // Add 1 to the total diamonds
            totalFireDiamonds ++;
            Destroy(gameObject);
        }

        // Check if the filename of the collider is "Waterboy" and the collied objects filename contians "water_diamond"
        else if (c2d.name.Contains("Watergirl") && gameObject.name.Contains("water_diamond")) {
            // Add 1 to the total diamonds
            totalWaterDiamonds ++;
            Destroy(gameObject);
        }

    }
}
