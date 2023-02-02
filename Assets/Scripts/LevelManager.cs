using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelManager : MonoBehaviour
{
    [SerializeField]private int _currentLevelIndex;
    [SerializeField]private int _nextLevelIndex;

    public TextMeshProUGUI _currentLevelText;
    public TextMeshProUGUI _nextLevelText;




    void Start()
    {
        _currentLevelIndex = PlayerPrefs.GetInt("currentLevelIndex", 1);
        _nextLevelIndex = _currentLevelIndex + 1;

        _currentLevelText.text = _currentLevelIndex.ToString();
        _nextLevelText.text = _nextLevelIndex.ToString();
    }

    
    void LateUpdate()
    {
        if (GameManager.levelPassed == true)
        {
            PlayerPrefs.SetInt("currentLevelIndex", _currentLevelIndex + 1);
        }
    }
}
