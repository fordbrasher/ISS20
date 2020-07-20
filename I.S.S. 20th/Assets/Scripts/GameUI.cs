using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameUI : MonoBehaviour
{
    public new GameObject camera;

    public void GameOver()
    {
        //end game conditions here
        GoToScene(2);
    }

    public void StartGame()
    {
        //initial conditions here
        GoToScene(1);
    }

    public void GoToScene(int buildIndex)
    {
        SceneManager.LoadScene(buildIndex);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT GAME");
        Application.Quit();
    }

    public void Tweet()
    {
        System.Diagnostics.Process.Start("https://ctt.ac/ABaDY");
    }

}
