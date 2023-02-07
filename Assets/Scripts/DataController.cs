using UnityEngine;

public class DataController : MonoBehaviour
{
    public const int STEP_LEVEL = 1;

    public int CurrentLevelIndex { get; private set; }
    public int ColorIndex { get; set; }

    private void Awake()
    {
        CurrentLevelIndex = PlayerPrefs.GetInt("currentLevelIndex", 1);
        if (PlayerPrefs.HasKey("colorIndex"))
            ColorIndex = PlayerPrefs.GetInt("colorIndex");
        else
            ColorIndex = -1;
    }

    public void IncreaseLevel()
    {
        PlayerPrefs.SetInt("currentLevelIndex", CurrentLevelIndex + 1);
    }

    public void SaveColorIndex()
    {
        PlayerPrefs.SetInt("colorIndex", ColorIndex);
    }

    public void ResetColorIndex()
    {
        ColorIndex = -1;
    }
}
