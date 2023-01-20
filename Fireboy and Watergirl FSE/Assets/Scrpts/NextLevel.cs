// Used to move to the next level when the player has completed the current level

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {

    [SerializeField] public FireDoor_Movement fireDoor;
    [SerializeField] public WaterDoor_Movement waterDoor;

    // Update is called once per frame
    void Update() {

        // If both doors are up, move to the next level scene
        if (fireDoor.isDone && waterDoor.isDone) {
            SceneManager.LoadScene(SceneMover.CONTINUE_SCENE);
        }
    }
}
