using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    /// <summary>
    /// Load the Game screen when click the play button
    /// </summary>
    public void Play()
    {
        SceneManager.LoadScene("Game");
    }

    /// <summary>
    /// Application get quit when we press the Exit button
    /// </summary>
    public void Exit()
    {
        Application.Quit();
    }
}
