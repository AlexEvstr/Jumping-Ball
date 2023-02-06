using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    [SerializeField] private Color[] _cylinderColors;
    [SerializeField] private Color[] _goodPlatformColors;
    [SerializeField] private Color[] _badPlatformColors;

    private int _colorIndex;

    private void Start()
    {
        if (PlayerPrefs.HasKey("colorIndex"))
        {
            _colorIndex = PlayerPrefs.GetInt("colorIndex");
        }
        else
        {
            SetRandomColorIndex();
        }
        ChangeLevelColor();
    }

    private void ChangeLevelColor()
    { 
        ChangeCylinderColor();
        ChangeGoodPlatformColor();
        ChangeBadPlatformColor();
    }

    private void SetRandomColorIndex()
    {
        _colorIndex = Random.Range(0, 15);
    }

    public void SaveColorIndex()
    {
        PlayerPrefs.SetInt("colorIndex", _colorIndex);
    }

    private void ChangeCylinderColor()
    {
        GameObject[] Cylinders = GameObject.FindGameObjectsWithTag("Cylinder");

        foreach (GameObject cylinder in Cylinders)
        {
            cylinder.GetComponent<MeshRenderer>().material.color = _cylinderColors[_colorIndex];
        }
    }

    private void ChangeGoodPlatformColor()
    {
        GameObject[] GoodPlatforms = GameObject.FindGameObjectsWithTag("GoodGround");

        foreach (GameObject platform in GoodPlatforms)
        {
            platform.GetComponent<MeshRenderer>().material.color = _goodPlatformColors[_colorIndex];
        }
    }

    private void ChangeBadPlatformColor()
    {
        GameObject[] BadPlatforms = GameObject.FindGameObjectsWithTag("BadGround");

        foreach (GameObject platform in BadPlatforms)
        {
            platform.GetComponent<MeshRenderer>().material.color = _badPlatformColors[_colorIndex];
        }
    }
}