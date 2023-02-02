using UnityEngine;

public class RingDestroy : MonoBehaviour
{
    private Transform ball;

    private float _explosionForce = 10.0f;
    private float _explosionRadius = 50.0f;
    private bool _isDone = false;

    void Start()
    {
        ball = GameObject.FindGameObjectWithTag("Ball").transform;
        
    }

    void Update()
    {
        if (transform.position.y > ball.position.y + 0.3f)
        {
            gameObject.GetComponent<Rigidbody>().isKinematic = false;
            gameObject.GetComponent<Rigidbody>().useGravity = true;

            Rigidbody RingRb = GetComponent<Rigidbody>();
            RingRb.AddExplosionForce(_explosionForce, transform.position, _explosionRadius);

            Destroy(gameObject, 2);

            if (_isDone == true)
                return;
            if (_isDone == false)
            {
                ProgressBar.ringsProgress++;
                Debug.Log(ProgressBar.ringsProgress);
                _isDone = true;
            }
        }
    }
}
