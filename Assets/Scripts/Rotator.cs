using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    private float rotationSpeed = 30.0f;

    private void Update()
    {
        // Rotate construction by finger
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            float xDeltaPos = Input.GetTouch(0).deltaPosition.x;
            transform.Rotate(0, -xDeltaPos * rotationSpeed * Time.deltaTime, 0);
        }
    }
}
