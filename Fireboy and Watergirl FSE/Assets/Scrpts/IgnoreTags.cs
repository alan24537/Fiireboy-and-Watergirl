// Used to ignore collisions between objects with certain tags

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreTags : MonoBehaviour {

    [SerializeField] public string[] tagsToIgnore;

    // Start is called before the first frame update
    void Start() {

        // Ignore collisions between this object and all objects with the tags in tagsToIgnore
        foreach (string tag in tagsToIgnore) {
            GameObject[] objects = GameObject.FindGameObjectsWithTag(tag);
            foreach (GameObject obj in objects) {
                Physics2D.IgnoreCollision(obj.GetComponent<Collider2D>(), GetComponent<Collider2D>());
            }
        }
    }
}
