using UnityEngine;
using UnityEngine.UI;

public class UISoundButton : MonoBehaviour
{
    private AudioSource _audioSource;

    public void OnClick()
    {
        if (AudioListener.volume == 1)
            AudioListener.volume = 0;
        else
            AudioListener.volume = 1;
    }
}
