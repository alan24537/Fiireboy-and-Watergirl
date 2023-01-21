// Used to decide which gem animation to show on the level clear screen

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGemChanger : MonoBehaviour {

    [SerializeField] public float delay; // The delay in seconds
    private Transform purple_gem;
    private Transform orange_gem;


    // Start is called before the first frame update
    void Start() {
        purple_gem = transform.Find("Level Gem Purple");
        orange_gem = transform.Find("Level Gem Orange");

        purple_gem.gameObject.SetActive(false);
        orange_gem.gameObject.SetActive(false);

        StartCoroutine(waitAndLoadAnim()); // Starts the delay
    }

    IEnumerator waitAndLoadAnim() { // Waits delay seconds before loading the next retry scene
        yield return new WaitForSeconds(delay);

        if (PlayerStats.special_gems_per_level[PlayerStats.level] == 0) { // if the level has no special gems
            // if the player has collected all the gems in the level
            if (PlayerStats.fire_gems == PlayerStats.fire_gems_per_level[PlayerStats.level] && PlayerStats.water_gems == PlayerStats.water_gems_per_level[PlayerStats.level]) {
                purple_gem.gameObject.SetActive(true);
                orange_gem.gameObject.SetActive(false);
            }
            else {
            purple_gem.gameObject.SetActive(false);
            orange_gem.gameObject.SetActive(true);
            }
        }
        else if (PlayerStats.special_gems_per_level[PlayerStats.level] == 1) { // if the level has a special gem
            if (PlayerStats.special_gems == 1) { // if the player has collected the special gem
                purple_gem.gameObject.SetActive(true);
                orange_gem.gameObject.SetActive(false);
            }
            else {
            purple_gem.gameObject.SetActive(false);
            orange_gem.gameObject.SetActive(true);
            }
        }
        else {
            purple_gem.gameObject.SetActive(false);
            orange_gem.gameObject.SetActive(true);
        }
    }
}
