using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public static int ringsProgress;

    public Slider progressBar;
    public LevelBuilder levelBuilder;


    void Start()
    {
        ringsProgress = 0;
        levelBuilder = FindObjectOfType<LevelBuilder>();
    }

    public void Update()
    {
        int progress = ringsProgress * 100 / (levelBuilder.levelLength * 6);
        progressBar.value = progress;
    }

}
