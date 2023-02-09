using UnityEngine;
using Zenject;

public class ColorManager : MonoBehaviour
{
    [SerializeField] private Material _materialCylinder;
    [SerializeField] private Material _materialPlatform;
    [SerializeField] private Palette[] _palettes = new Palette[0];
    [SerializeField] private Camera _mainCamera;
    
    private DataController _data;

    [Inject]
    private void Construct(DataController data)
    {
        _data = data;
    }

    private void Start()
    {
        CalculateRandomIndexColor();
        SetLevelColor();
    }

    public void SetLevelColor()
    { 
        SetCylinderColor();
        SetPlatformColor();
        SetBackgroundColor();
    }

    private void CalculateRandomIndexColor()
    {
        if (_data.ColorIndex != -1) return;
        _data.ColorIndex = Random.Range(0, 15);
    }

    private void SetCylinderColor()
    {
        _materialCylinder.color = _palettes[_data.ColorIndex]._cylinderColor;
    }

    private void SetPlatformColor()
    {
        _materialPlatform.color = _palettes[_data.ColorIndex]._platformColor;
    }

    private void SetBackgroundColor()
    {
        _mainCamera.backgroundColor = _palettes[_data.ColorIndex]._background;
    }
}