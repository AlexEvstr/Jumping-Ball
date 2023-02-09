using UnityEngine;
using Zenject;

public class BallFacade : MonoBehaviour
{
    #region Reference
    private BallBounce _player;
    private BallAcceleration _ballAcceleration;
    private LevelBuilder _levelBuilder;
    private LevelProgress _levelProgress;
    private SoundManager _soundManager;
    #endregion

    #region Working variable
    private RingController _currentRing;
    private int _ringProgress;
    public int RingsProgress => _ringProgress;
    #endregion

    [Inject]
    private void Construct(
        BallBounce player, 
        LevelBuilder levelBuilder,
        LevelProgress levelProgress,
        SoundManager soundManager,
        BallAcceleration ballAcceleration)
    {
        _player = player;
        _levelBuilder = levelBuilder;
        _levelProgress = levelProgress;
        _soundManager = soundManager;
        _ballAcceleration = ballAcceleration;
    }

    private void Start()
    {
        _currentRing = _levelBuilder.GetActiveRing();
    }

    private void Update()
    {
        if (_player.transform.position.y < _currentRing.transform.position.y - 1f)
        {
            _ringProgress++;
            _ballAcceleration.IncreaseCountPassRing();
            OnPassRing();
        }
    }

    public void OnPassRing()
    {
        _currentRing.DestroyRing();
        _levelProgress.FillProgress();
        _soundManager.PlayRingDestroySound();
        _currentRing = _levelBuilder.GetActiveRing();

    }
}
