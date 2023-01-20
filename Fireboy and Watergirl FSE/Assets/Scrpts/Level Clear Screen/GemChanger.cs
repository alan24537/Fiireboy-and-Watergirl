// Changes the gem sprite to grey if there is a special gem in the level

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemChanger : MonoBehaviour {
    [SerializeField] public Sprite grey_gem; // The image to change to

    // Start is called before the first frame update
    void Start() {

        // if there is a special gem in the level, change the origanal image to the new image
        if (PlayerStats.special_gems_per_level[PlayerStats.level] == 1) {
            GetComponent<Image>().sprite = grey_gem;
        }
    }
}
