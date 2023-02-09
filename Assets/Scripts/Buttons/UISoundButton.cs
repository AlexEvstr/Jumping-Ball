using UnityEngine;
using UnityEngine.UI;

public class UISoundButton : MonoBehaviour
{
    [SerializeField] private Sprite _soundOn;
    [SerializeField] private Sprite _soundOff;

    public GameObject SoundButton;

    private int _soundIndex = 0;

    private void Awake()
    {
        if (PlayerPrefs.HasKey("soundIndex"))
        {
            StopSound();
        }
        else
            PlayerPrefs.DeleteKey("soundIndex");
        
    }

    public void AudioTumbler()
    {
        if (AudioListener.volume == 1)
        {
            StopSound();
            SaveSoundIndex();
        }
        else
        {
            PlaySound();
            PlayerPrefs.DeleteKey("soundIndex");
        }
    }

    private void PlaySound()
    {
        AudioListener.volume = 1;
        SoundButton.GetComponent<Image>().sprite = _soundOn;
    }

    private void StopSound()
    {
        AudioListener.volume = 0;
        SoundButton.GetComponent<Image>().sprite = _soundOff;
    }

    private void SaveSoundIndex()
    {
        PlayerPrefs.SetInt("soundIndex", _soundIndex);
    }
}
