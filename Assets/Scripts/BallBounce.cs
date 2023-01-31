using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    private Rigidbody _ballRb;
    private float _bouncePower = 500.0f;

    void Start()
    {
        _ballRb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision other)
    {
        // Makes ball bounce on green platforms
        if (other.gameObject.CompareTag("GoodGround"))
        {
            _ballRb.velocity = new Vector3(_ballRb.velocity.x, _bouncePower * Time.deltaTime, _ballRb.velocity.z);
        }
        // Lose screen if jump on red platform
        else if (other.gameObject.CompareTag("BadGround"))
        {
            GameManager.gameOver = true;
        }
        else if (other.gameObject.CompareTag("Finish"))
        {
            GameManager.levelPassed = true;
        }
    }
}
