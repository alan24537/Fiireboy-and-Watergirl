// Controls what happens when the player collides with a liquid tilemap

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Killer : MonoBehaviour {
    
    void Awake() {
        GetComponent<Collider2D>().isTrigger = true; // sets the tilemap to be a trigger so that it doesn't have physical collisions
    }

    void OnTriggerEnter2D(Collider2D c2d) {

        if (gameObject.name.Contains("Acid Tilemap")) { // if either player collides with the acid tilemap, they die
            Destroy(c2d.gameObject);
            StartCoroutine(waitAndLoadNextScene()); 
        }
        else if (c2d.name.Contains("Fireboy") && gameObject.name.Contains("Water Tilemap")) { // if fireboy collides with the water tilemap, he dies
            Destroy(c2d.gameObject);
            StartCoroutine(waitAndLoadNextScene()); 
        }
        else if (c2d.name.Contains("Watergirl") && gameObject.name.Contains("Lava Tilemap")) { // if watergirl collides with the lava tilemap, she dies
            Destroy(c2d.gameObject);
            StartCoroutine(waitAndLoadNextScene()); 
        }
    }

    IEnumerator waitAndLoadNextScene() { // Waits 1 second before loading the next retry scene
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneMover.DEATH_SCENE);
    }
}
