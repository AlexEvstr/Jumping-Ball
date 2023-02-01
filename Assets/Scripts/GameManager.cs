using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static bool gameOver;
    public static bool levelPassed;
    public static bool startMenu;

    public GameObject gameOverPanel;
    public GameObject levelPassedPanel;
    public GameObject startMenuPanel;

    private void Start()
    {
        startMenu = true;
        gameOver = false;
        levelPassed = false;
        Time.timeScale = 1;
    }

    private void Update()
    {
        if (gameOver == true)
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }
        else if (levelPassed == true)
        {
            Time.timeScale = 0;
            levelPassedPanel.SetActive(true);
        }
    }
    public void LoadSceneButon()
    {
        SceneManager.LoadScene(0);
    }

    public void StartGameButon()
    {
        startMenuPanel.SetActive(false);
        startMenu = false;
    }

}
