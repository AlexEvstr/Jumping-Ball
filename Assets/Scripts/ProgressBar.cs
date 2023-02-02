using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public static int ringsProgress;

    public Slider progressBar;

    void Start()
    {
        ringsProgress = 0;
    }

    public void Update()
    {
            int progress = ringsProgress * 100 / (FindObjectOfType<LevelBuilder>().levelLength * 6);
            progressBar.value = progress;
            Debug.Log(ringsProgress);
    }

}
