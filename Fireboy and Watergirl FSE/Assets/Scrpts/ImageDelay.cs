// Delays an UI image for a certain amount of time

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageDelay : MonoBehaviour {

    [SerializeField] public float delay; // The delay in seconds
    [SerializeField] public Image img; // The image to delay

    // Start is called before the first frame update
    void Start() {
        img.enabled = false; // Disables the image
        StartCoroutine(waitAndLoadNextScene()); // Starts the delay
    }

    IEnumerator waitAndLoadNextScene() { // Waits delay amount of seconds before enabling the image
        yield return new WaitForSeconds(delay);
        img.enabled = true;
    }
}
