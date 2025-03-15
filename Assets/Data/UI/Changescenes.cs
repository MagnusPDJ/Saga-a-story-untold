using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Changescenes : MonoBehaviour
{
    public void GoToSceneMainMenu() {
        SceneManager.LoadScene("MainMenu");
    }

    public void GoToSceneOptions() {
        SceneManager.LoadScene("Options");
    }

    public void GoToScenePlayMenu() {
        SceneManager.LoadScene("PlayMenu");
    }

    public void GoToSceneNewGame() {
        SceneManager.LoadScene("NewGame");
    }

    public void GoToSceneX(int x) {
        SceneManager.LoadScene(x);
    }
}
