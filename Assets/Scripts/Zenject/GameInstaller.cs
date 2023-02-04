using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    [SerializeField] private BallBounce _playerTransfrom;
    [SerializeField] private LevelBuilder _levelBuilder;
    [SerializeField] private LevelProgress _levelProgress;
    [SerializeField] private SoundManager _soundManager;

    [SerializeField] private GameManager _gameManager;
    [SerializeField] private DataController _dataController;

    public override void InstallBindings()
    {
        BallFasadBinding();

        Container.BindInstance(_gameManager);
        Container.BindInstance(_dataController);
    }

    private void BallFasadBinding()
    {
        Container.BindInstance(_playerTransfrom);
        Container.BindInstance(_levelBuilder);
        Container.BindInstance(_levelProgress);
        Container.BindInstance(_soundManager);
    }
}