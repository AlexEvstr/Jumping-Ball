using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShot : MonoBehaviour
{
    [Header("File data")]
    public string FileName;
    public string FilePathToSave;
    public string FileResolution;

    [Header("Key")]
    public KeyCode keyToPress;

    private int _countScreenshots;

    private void Start()
    {
        _countScreenshots = PlayerPrefs.GetInt("CountScreen", 0);
    }

    private void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            ScreenCapture.CaptureScreenshot($"{FileName}_{_countScreenshots}.{FileResolution}");
            _countScreenshots++;
        }
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("CountScreen", _countScreenshots);
    }
}
