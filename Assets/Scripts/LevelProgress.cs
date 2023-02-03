using System;
using UnityEngine;
using UnityEngine.UI;

public class LevelProgress : MonoBehaviour
{
    [SerializeField] private Slider _progressBar;
    [SerializeField] private LevelBuilder _levelBuilder;
    [SerializeField] private BallFacade _ballFacade;

    private float _progress = 0.1f;
    private const float STEP_PROGRESS = .1f;

    public void FillProgress()
    {
        _progressBar.value = 100 * _ballFacade.RingsProgress / _levelBuilder.LevelLength;
    }

}
