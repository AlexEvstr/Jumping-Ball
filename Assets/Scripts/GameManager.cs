using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

public class GameManager : MonoBehaviour
{
    private DataController _dataController;

    public static bool gameOver;
    public static bool levelPassed;
    public static bool startMenu;


    [Inject]
    private void Construct(DataController dataController)
    {
        _dataController = dataController;
    }

    [SerializeField] private GameObject _gameOverPanel;
    [SerializeField] private GameObject _levelPassedPanel;
    [SerializeField] private GameObject _startMenuPanel;

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
            _gameOverPanel.SetActive(true);
        }
        else if (levelPassed == true)
        {
            _levelPassedPanel.SetActive(true);
        }
    }

    public void LoadNextLevel()
    {
        _dataController.IncreaseLevel();
        _dataController.ResetColorIndex();
        _dataController.SaveColorIndex();
        SceneManager.LoadScene(0);
    }

    public void ReloadScene()
    {
        _dataController.SaveColorIndex();
        SceneManager.LoadScene(0);
    }

    public void StartGame()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            _startMenuPanel.SetActive(false);
            startMenu = false;
        }

    }
}
