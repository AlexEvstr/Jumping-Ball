using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingDestroy : MonoBehaviour
{
    private Transform ball;

    private float _explosionForce = 10.0f;
    private float _explosionRadius = 50.0f;

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
            Rigidbody rb = GetComponent<Rigidbody>();

            rb.AddExplosionForce(_explosionForce, transform.position, _explosionRadius);
            Destroy(gameObject, 2);
        }

    }
}
