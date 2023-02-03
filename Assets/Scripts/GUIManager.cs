using TMPro;
using UnityEngine;

public class GUIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _currentLevelText;
    [SerializeField] private TextMeshProUGUI _nextLevelText;
    [SerializeField] private DataController _dataController;

    private void Start()
    {
        _currentLevelText.text = _dataController.CurrentLevelIndex.ToString();
        _nextLevelText.text = (_dataController.CurrentLevelIndex + DataController.STEP_LEVEL).ToString();
    }
}
