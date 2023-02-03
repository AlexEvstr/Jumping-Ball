using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    private Rigidbody _ballRb;
   // public AudioManager _audioManager;

    private float _bouncePower = 500.0f;

    void Start()
    {
        _ballRb = GetComponent<Rigidbody>();
       // _audioManager = GetComponent<AudioManager>();
    }

    private void OnCollisionEnter(Collision other)
    {
        // Makes ball bounce on green platforms
        if (other.gameObject.CompareTag("GoodGround"))
        {
            _ballRb.velocity = new Vector3(_ballRb.velocity.x, _bouncePower * Time.deltaTime, _ballRb.velocity.z);

           // _audioManager.PlayBounceSound();
        }
        // Lose screen if jump on red platform
        else if (other.gameObject.CompareTag("BadGround"))
        {
            GameManager.gameOver = true;

          //  _audioManager.PlayGameOverSound();
        }
        else if (other.gameObject.CompareTag("Finish"))
        {
            GameManager.levelPassed = true;

           // _audioManager.PlayLevelPassedSound();
        }
    }
}
