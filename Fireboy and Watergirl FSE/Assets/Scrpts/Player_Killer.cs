using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Killer : MonoBehaviour {
    
    void Awake() {
        GetComponent<Collider2D>().isTrigger = true;
    }

    void OnTriggerEnter2D(Collider2D c2d) {

        if (gameObject.name == "Green Goo Tilemap") {
            Destroy(c2d.gameObject);
        }
        else if (c2d.name.Contains("Fireboy") && gameObject.name == "Water Tilemap") {
            Destroy(c2d.gameObject);
        }
        else if (c2d.name.Contains("Watergirl") && gameObject.name == "Lava Tilemap") {
            Destroy(c2d.gameObject);
        }
    }
}
