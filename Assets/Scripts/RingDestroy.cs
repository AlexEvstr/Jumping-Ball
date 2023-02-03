using UnityEngine;

public class RingDestroy : MonoBehaviour
{
    private Transform _ball;
    //public AudioManager _audioManager;

    private float _explosionForce = 10.0f;
    private float _explosionRadius = 50.0f;
    private bool _isDone = false;
    private Rigidbody _rigidbody;

    void Start()
    { 
        _ball = GameObject.FindGameObjectWithTag("Ball").transform;
        _rigidbody = GetComponent<Rigidbody>();

      //  _audioManager = GetComponent<AudioManager>();


    }

    void Update()
    {
        if (transform.position.y > _ball.position.y + 0.3f)
        {
            _rigidbody.isKinematic = false;
            _rigidbody.useGravity = true;

            _rigidbody.AddExplosionForce(_explosionForce, transform.position, _explosionRadius);

            Destroy(gameObject, 2);

           // _audioManager.PlayRingDestroySound();

            if (_isDone == true)
                return;
            if (_isDone == false)
            {
                ProgressBar.ringsProgress++;
                _isDone = true;
            }
        }
    }
}
