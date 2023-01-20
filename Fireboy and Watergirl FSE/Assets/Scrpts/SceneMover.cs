using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMover : MonoBehaviour {

    public static int MENU_SCENE = 0;
    public static int DEATH_SCENE = 1;
    public static int CONTINUE_SCENE = 2;

    public void playGame() {

        // Reset the player stats
        PlayerStats.reset_player_stats();

        PlayerStats.level ++;
        Debug.Log("Level: " + PlayerStats.level);
        SceneManager.LoadScene(PlayerStats.level + 2);
    }

    public void goToMenu() {
        SceneManager.LoadScene(MENU_SCENE);
    }

    public void quitGame() {
        Application.Quit();
    }

    public void retryGame() {
        SceneManager.LoadScene(PlayerStats.level + 2);
    }
}
