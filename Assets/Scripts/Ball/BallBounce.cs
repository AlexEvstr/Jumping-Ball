using UnityEngine;
using Zenject;

[RequireComponent(typeof(Rigidbody))]
public class BallBounce : MonoBehaviour
{
    #region Reference
    private SoundManager _soundManager;
    private BallAcceleration _ballAcceleration;
    private BallFacade _ballFacade;
    #endregion

    private Rigidbody _rigidbody;

    private float _bouncePower = 500.0f;

    [Inject]
    private void Construct(
        SoundManager soundManager, 
        BallAcceleration ballAcceleration, 
        BallFacade ballFacade)
    {
        _soundManager = soundManager;
        _ballAcceleration = ballAcceleration;
        _ballFacade = ballFacade;
    }

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (!_ballAcceleration.IsActive)
            BehaviourDefault(other);
        else
            BehaviourActiveAcceleration(other);
    }

    private void BehaviourDefault(Collision other)
    {
        if (other.gameObject.CompareTag("GoodGround") && GameManager.gameOver != true)
        {
            _rigidbody.velocity = new Vector3(_rigidbody.velocity.x, _bouncePower * Time.deltaTime, _rigidbody.velocity.z);
            _soundManager.PlayBounceSound();
        }
        else if (other.gameObject.CompareTag("BadGround"))
        {
            GameManager.gameOver = true;

            _soundManager.PlayGameOverSound();
        }
        else if (other.gameObject.CompareTag("Finish"))
        {
            GameManager.levelPassed = true;

            _soundManager.PlayLevelPassedSound();
        }
        _ballAcceleration.ResetCountPassRing();
    }

    private void BehaviourActiveAcceleration(Collision other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            GameManager.levelPassed = true;

            _soundManager.PlayLevelPassedSound();
        }
        else
        {
            _ballFacade.OnPassRing();
            _rigidbody.velocity = new Vector3(_rigidbody.velocity.x, _bouncePower * Time.deltaTime, _rigidbody.velocity.z);
            

            _soundManager.PlayBounceSound();
        }
        _ballAcceleration.SetActive(false);
    }
}
