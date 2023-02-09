using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    [SerializeField] private BallBounce _ballTransfrom;
    [SerializeField] private LevelBuilder _levelBuilder;
    [SerializeField] private LevelProgress _levelProgress;
    [SerializeField] private SoundManager _soundManager;

    [SerializeField] private GameManager _gameManager;
    [SerializeField] private DataController _dataController;
    [SerializeField] private BallFacade _ballFacade;
    [SerializeField] private BallAcceleration _ballAcceleration;

    public override void InstallBindings()
    {
        BallFasadBinding();
        ManagersBinding();
        LevelBinding();
    }

    private void ManagersBinding()
    {
        Container.BindInstance(_gameManager);
        Container.BindInstance(_dataController);
        Container.BindInstance(_soundManager);
    }

    private void LevelBinding()
    {
        Container.BindInstance(_levelBuilder);
        Container.BindInstance(_levelProgress);
    }

    private void BallFasadBinding()
    {
        Container.BindInstance(_ballTransfrom);
        Container.BindInstance(_ballFacade);
        Container.BindInstance(_ballAcceleration);
    }
}