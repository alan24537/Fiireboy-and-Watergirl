// To change the checkmark image to a checkmark image if the player has collected all the gems in the level

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckMarkChanger : MonoBehaviour {

    [SerializeField] public Sprite img; // The image to change to

    // Start is called before the first frame update
    void Start() {

        if (PlayerStats.special_gems_per_level[PlayerStats.level] == 0) { // if the level has no special gems
            // if the player has collected all the gems in the level
            if (PlayerStats.fire_gems == PlayerStats.fire_gems_per_level[PlayerStats.level] && PlayerStats.water_gems == PlayerStats.water_gems_per_level[PlayerStats.level]) {
                GetComponent<Image>().sprite = img;
            }
        }
        else { // if the level has a special gem
            if (PlayerStats.special_gems == 1) { // if the player has collected the special gem
                GetComponent<Image>().sprite = img;
            }
        }
    }
}
