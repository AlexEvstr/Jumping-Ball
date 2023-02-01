using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowBall : MonoBehaviour
{
    public Transform ball;

    private Vector3 _offset;
    private float _ballPos = 2f;

    private void Start()
    {
        _offset = transform.position - ball.position;
    }

    private void LateUpdate()
    {
        if (ball.transform.position.y < _ballPos)
        {
            Vector3 newPos = Vector3.Lerp(transform.position, ball.position + _offset, 1f);
            transform.position = newPos;
            _ballPos = ball.transform.position.y;
        }
    }
}
