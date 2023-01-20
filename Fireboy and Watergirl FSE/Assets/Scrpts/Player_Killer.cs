using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Killer : MonoBehaviour {
    
    void Awake() {
        GetComponent<Collider2D>().isTrigger = true;
    }

    void OnTriggerEnter2D(Collider2D c2d) {

        if (gameObject.name.Contains("Acid Tilemap")) {
            Destroy(c2d.gameObject);
            StartCoroutine(waitAndLoadNextScene(c2d)); 
        }
        else if (c2d.name.Contains("Fireboy") && gameObject.name.Contains("Water Tilemap")) {
            Destroy(c2d.gameObject);
            StartCoroutine(waitAndLoadNextScene(c2d)); 
        }
        else if (c2d.name.Contains("Watergirl") && gameObject.name.Contains("Lava Tilemap")) {
            Destroy(c2d.gameObject);
            StartCoroutine(waitAndLoadNextScene(c2d)); 
        }
    }

    IEnumerator waitAndLoadNextScene(Collider2D c2d) { // Waits 1 second before loading the next retry scene
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneMover.DEATH_SCENE);
    }
}
