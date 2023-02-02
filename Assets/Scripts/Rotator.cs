using UnityEngine;

public class Rotator : MonoBehaviour
{
    private float _rotationSpeed = 50.0f;

    private void Update()
    {
        // Rotate construction by finger
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved && GameManager.gameOver == false && GameManager.levelPassed == false)
        {
            float xDeltaPos = Input.GetTouch(0).deltaPosition.x;
            transform.Rotate(0, -xDeltaPos * _rotationSpeed * Time.deltaTime, 0);
        }
    }
}
