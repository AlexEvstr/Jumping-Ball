using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static bool gameOver;
    public static bool levelPassed;

    public GameObject gameOverPanel;
    public GameObject levelPassedPanel;

    private void Start()
    {
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

}
