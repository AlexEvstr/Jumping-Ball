using UnityEngine;
using Zenject;

public class ColorManager : MonoBehaviour
{
    [SerializeField] private Color[] _cylinderColors;
    [SerializeField] private Color[] _goodPlatformColors;
    [SerializeField] private Color[] _badPlatformColors;

    [SerializeField] private Material _materialGoodPlatform;
    [SerializeField] private Material _materialCylinder;

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
        SetGoodPlatformColor();
    }

    private void CalculateRandomIndexColor()
    {
        if (_data.ColorIndex != -1) return;
        _data.ColorIndex = Random.Range(0, 15);
    }

    private void SetCylinderColor()
    {
        _materialCylinder.color = _cylinderColors[_data.ColorIndex];
    }

    private void SetGoodPlatformColor()
    {
        _materialGoodPlatform.color = _goodPlatformColors[_data.ColorIndex];
    }
}