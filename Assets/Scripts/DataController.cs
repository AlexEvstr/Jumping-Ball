using UnityEngine;
using System;

public class DataController : MonoBehaviour
{
    public const int STEP_LEVEL = 1;

    public int CurrentLevelIndex => _currentLevelIndex;
    private int _currentLevelIndex;

    private void Awake()
    {
        _currentLevelIndex = PlayerPrefs.GetInt("currentLevelIndex", 1);
    }

    public void IncreaseLevel()
    {
        PlayerPrefs.SetInt("currentLevelIndex", _currentLevelIndex + 1);
    }
}
