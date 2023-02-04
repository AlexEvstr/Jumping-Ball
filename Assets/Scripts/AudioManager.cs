using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource _bounceSound;
    [SerializeField] private AudioSource ringDestroySound;
    [SerializeField] private AudioSource gameOverSound;
    [SerializeField] private AudioSource levelPassedSound;

    public void PlayBounceSound()
    {
        _bounceSound.Play();
    }

    public void PlayRingDestroySound()
    {
        ringDestroySound.Play();
    }

    public void PlayGameOverSound()
    {
        gameOverSound.Play();
    }

    public void PlayLevelPassedSound()
    {
        levelPassedSound.Play();
    }


}
