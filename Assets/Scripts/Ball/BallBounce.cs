using UnityEngine;

public class BallBounce : MonoBehaviour
{
    [SerializeField] private SoundManager _audioManager;
    private Rigidbody _rigidbody;
    private ColorManager _colorManager;

    private float _bouncePower = 500.0f;
    private float _speedToDestroy = 23.0f;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision other)
    {
        //_colorManager.SetBallColorBlue();
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
    private void Update()
    {
        if (_rigidbody.velocity.magnitude > _speedToDestroy)
        {
            Debug.Log("more then 23");
            _colorManager.SetBallColorRed();
        }
    }
}
