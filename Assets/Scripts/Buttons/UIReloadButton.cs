public class UIReloadButton : UIBaseButton
{
    public override void OnClick()
    {
        _gameManager.ReloadScene();
    }
}
