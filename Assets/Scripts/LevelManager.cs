using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelManager : MonoBehaviour
{
    private int _currentLevelIndex;
    private int _nextLevelIndex;

    public TextMeshProUGUI _currentLevelText;
    public TextMeshProUGUI _nextLevelText;

    void Start()
    {
        _currentLevelIndex = PlayerPrefs.GetInt("currentLevelIndex", 1);
        _nextLevelIndex = _currentLevelIndex + 1;

        _currentLevelText.text = _currentLevelIndex.ToString();
        _nextLevelText.text = _nextLevelIndex.ToString();
    }

    void Update()
    {
        if (GameManager.levelPassed == true)
        {
            PlayerPrefs.SetInt("currentLevelIndex", _currentLevelIndex + 1);
        }
    }
}
