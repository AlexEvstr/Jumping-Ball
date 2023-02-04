using UnityEngine;

public class BallFacade : MonoBehaviour
{
    [SerializeField] private Transform _playerTranform;
    [SerializeField] private LevelBuilder _levelBuilder;
    [SerializeField] private LevelProgress _levelProgress;
    [SerializeField] private SoundManager _soundManager;
    private RingController _currentRing;

    private int _ringProgress;
    public int RingsProgress => _ringProgress;

    private void Start()
    {
        _currentRing = _levelBuilder.GetActiveRing();
    }

    private void Update()
    {
        if (_playerTranform.position.y < _currentRing.transform.position.y - 1f)
        {
            _ringProgress++;
            _currentRing.DestroyRing();
            _levelProgress.FillProgress();
            _currentRing = _levelBuilder.GetActiveRing();
            _soundManager.PlayRingDestroySound();
        }
    }
}
