using UnityEngine;

public class BallAcceleration : MonoBehaviour
{
    #region Ball color data
    [SerializeField] private Material _materialBall;
    [SerializeField] private Color _ballDefault;
    [SerializeField] private Color _ballAcceleration;
    #endregion

    private int _countPassRing;
    public int CountPassRing => _countPassRing;

    private bool _isActive;
    public bool IsActive => _isActive;

    public void SetActive(bool isAcceleration)
    {
        if (isAcceleration) _materialBall.color = _ballAcceleration;
        else _materialBall.color = _ballDefault;
        _isActive = isAcceleration;
    }

    public void IncreaseCountPassRing()
    {
        if (!_isActive)
        {
            _countPassRing++;
            if (_countPassRing == 3)
            {
                SetActive(true);
                ResetCountPassRing();
            }
        }
    }

    public void ResetCountPassRing()
    {
        _countPassRing = 0;
    }
}
