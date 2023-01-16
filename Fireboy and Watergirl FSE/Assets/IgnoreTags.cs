using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreTags : MonoBehaviour {

    public string[] tagsToIgnore;

    // Start is called before the first frame update
    void Start() {
        foreach (string tag in tagsToIgnore) {
            GameObject[] objects = GameObject.FindGameObjectsWithTag(tag);
            foreach (GameObject obj in objects) {
                Physics2D.IgnoreCollision(obj.GetComponent<Collider2D>(), GetComponent<Collider2D>());
            }
        }
    }

    // Update is called once per frame
    void Update() {
        
    }
}
