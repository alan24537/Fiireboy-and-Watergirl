// To change the checkmark image to a checkmark image if the player has collected all the gems in the level

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckMarkChanger : MonoBehaviour {

    [SerializeField] public Sprite img; // The image to change to

    // Start is called before the first frame update
    void Start() {

        // If the player has collected all the gems in the level, change the origanal image to the new image
        if (PlayerStats.fire_gems == PlayerStats.fire_gems_per_level[PlayerStats.level] && PlayerStats.water_gems == PlayerStats.water_gems_per_level[PlayerStats.level]
            || PlayerStats.special_gems == 1) {
            GetComponent<Image>().sprite = img;
        }
    }
}
