using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonActivate : MonoBehaviour {

    public bool isOn;

    // Start is called before the first frame update
    void Start() {
        isOn = false;
    }

    // Update is called once per frame
    void Update() {
        
    }

    void OnTriggerEnter2D(Collider2D c2d) {
        isOn = true;
    }

    void OnTriggerExit2D(Collider2D c2d) {
        isOn = false;
    }
}
