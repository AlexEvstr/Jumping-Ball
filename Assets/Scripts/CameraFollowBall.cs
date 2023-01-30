using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowBall : MonoBehaviour
{
    public Transform ball;

    public Vector3 offset;

    private void Start()
    {
        offset = transform.position - ball.position;
    }

    private void LateUpdate()
    {
        Vector3 newPos = Vector3.Lerp(transform.position, ball.position + offset, 1);
        transform.position = newPos;
    }
}
