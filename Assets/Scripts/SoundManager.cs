using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource _bounceSound;
    [SerializeField] private AudioSource _ringDestroySound;
    [SerializeField] private AudioSource _gameOverSound;
    [SerializeField] private AudioSource _levelPassedSound;

    public void PlayBounceSound()
    {
        _bounceSound.Play();
    }

    public void PlayRingDestroySound()
    {
        _ringDestroySound.Play();
    }

    public void PlayGameOverSound()
    {
        _gameOverSound.Play();
    }

    public void PlayLevelPassedSound()
    {
        _levelPassedSound.Play();
    }
}
