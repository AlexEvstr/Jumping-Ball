using UnityEngine;
using UnityEngine.UI;
using Zenject;

[RequireComponent(typeof(Button))]
public abstract class UIBaseButton : MonoBehaviour
{
    protected Button _btn;
    protected GameManager _gameManager;

    [Inject]
    protected virtual void Construct(GameManager gameManager)
    {
        _gameManager = gameManager;
        _btn = GetComponent<Button>();
    }

    private void OnEnable()
    {
        _btn.onClick.AddListener(OnClick);
    }

    private void OnDisable()
    {
        _btn.onClick.RemoveAllListeners();
    }

    public abstract void OnClick();
}
