using TMPro;
using UnityEngine;
using Zenject;

public class GUIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _currentLevelText;
    [SerializeField] private TextMeshProUGUI _nextLevelText;
    private DataController _dataController;

    [Inject]
    private void Construct(DataController dataController)
    {
        _dataController = dataController;
    }

    private void Start()
    {
        Debug.Log(_dataController.CurrentLevelIndex);
        _currentLevelText.text = _dataController.CurrentLevelIndex.ToString();
        _nextLevelText.text = (_dataController.CurrentLevelIndex + DataController.STEP_LEVEL).ToString();
    }
}
