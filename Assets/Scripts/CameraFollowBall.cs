using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowBall : MonoBehaviour
{
    public Transform ball;

    private Vector3 offset;
    private float ballPos = 2f;

    private void Start()
    {
        offset = transform.position - ball.position;
    }

    private void LateUpdate()
    {
        if (ball.transform.position.y < ballPos)
        {
            Vector3 newPos = Vector3.Lerp(transform.position, ball.position + offset, 1f);
            transform.position = newPos;
            ballPos = ball.transform.position.y;
        }
    }
}
