using UnityEngine;

[System.Serializable]
public class Palette
{
    public Color _platformColor;
    public Color _cylinderColor;
    public Color _background;

    public Palette(Color platformColor, Color cylinderColor, Color background)
    {
        _platformColor = platformColor;
        _cylinderColor = cylinderColor;
        _background = background;
    }
}
