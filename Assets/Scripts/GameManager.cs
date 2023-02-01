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
    }

    private void Update()
    {
        StartGame();
        if (gameOver == true)
        {
            gameOverPanel.SetActive(true);
        }
        else if (levelPassed == true)
        {
            levelPassedPanel.SetActive(true);
        }
    }
    public void LoadSceneButon()
    {
        SceneManager.LoadScene(0);
    }

    public void StartGame()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            startMenuPanel.SetActive(false);
            startMenu = false;
        }
        
    }

}
