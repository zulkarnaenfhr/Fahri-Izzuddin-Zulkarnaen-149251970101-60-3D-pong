using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void HowToPlayScene()
    {
        SceneManager.LoadScene("How To Play");
    }

    public void ExitGame()
    {
        Application.Quit();
        EditorApplication.isPlaying = false;
    }
}
