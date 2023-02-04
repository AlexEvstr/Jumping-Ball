public class UINextLevelButton : UIBaseButton
{
    public override void OnClick()
    {
        _gameManager.LoadNextLevel();
    }
}
