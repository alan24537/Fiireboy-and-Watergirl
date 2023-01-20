using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckMarkChanger : MonoBehaviour {

    public Sprite checkmark;

    // Start is called before the first frame update
    void Start() {
        if (PlayerStats.fire_gems == PlayerStats.fire_gems_per_level[PlayerStats.level] && PlayerStats.water_gems == PlayerStats.water_gems_per_level[PlayerStats.level]) {
            GetComponent<Image>().sprite = checkmark;
        }
    }

    // Update is called once per frame
    void Update() {
        
    }
}
