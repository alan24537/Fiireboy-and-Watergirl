using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreGround : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        GameObject ground = GameObject.FindGameObjectWithTag("Ground");
        Physics2D.IgnoreCollision(ground.GetComponent<Collider2D>(), GetComponent<Collider2D>());
    }

    // Update is called once per frame
    void Update() {
        
    }
}
