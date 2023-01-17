using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMover : MonoBehaviour {

    private static int MENU_SCENE = 0;

    public void playGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void goToMenu() {
        SceneManager.LoadScene(MENU_SCENE);
    }

    public void quitGame() {
        Application.Quit();
    }
}
