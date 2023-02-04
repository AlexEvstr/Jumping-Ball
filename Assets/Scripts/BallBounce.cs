using UnityEngine;

public class BallBounce : MonoBehaviour
{
    [SerializeField] private SoundManager _audioManager;
    private Rigidbody _rigidbody;

    private float _bouncePower = 500.0f;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.CompareTag("GoodGround") && GameManager.gameOver != true)
        {
            _rigidbody.velocity = new Vector3(_rigidbody.velocity.x, _bouncePower * Time.deltaTime, _rigidbody.velocity.z);
          
            _audioManager.PlayBounceSound();
        }
        else if (other.gameObject.CompareTag("BadGround"))
        {
            GameManager.gameOver = true;

            _audioManager.PlayGameOverSound();
        }
        else if (other.gameObject.CompareTag("Finish"))
        {
            GameManager.levelPassed = true;

            _audioManager.PlayLevelPassedSound();
        }
    }
}
