// Provides methods to move between scenes

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMover : MonoBehaviour {

    public static int MENU_SCENE = 0;
    public static int DEATH_SCENE = 1;
    public static int CONTINUE_SCENE = 2;
    public static int FINISH_SCENE = 12;

    public void playGame() { // loads the next level

        // Reset the player stats
        PlayerStats.reset_player_stats();

        PlayerStats.level ++; // Increment the level
        if (PlayerStats.level == 10) { // If the player has completed all the levels, load the end screen
            SceneManager.LoadScene(FINISH_SCENE);
        }
        else {
            SceneManager.LoadScene(PlayerStats.level + 2); // Load the next level
        }
    }

    public void goToMenu() { // loads the menu
        SceneManager.LoadScene(MENU_SCENE);
    }

    public void quitGame() { // quits the game
        Application.Quit();
    }

    public void retryGame() { // reloads the current level
        SceneManager.LoadScene(PlayerStats.level + 2);
    }
}
