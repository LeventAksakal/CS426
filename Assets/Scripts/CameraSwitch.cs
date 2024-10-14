using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera mainCamera;      // Reference to the main camera
    public Camera secondCamera;    // Reference to the second camera
    public GameObject ball;        // Reference to the ball
    public Rigidbody ballRigidbody; // Reference to the Rigidbody component of the ball
    public float smoothSpeed = 0.125f;  // Speed at which the camera follows the ball
    public Vector3 offset;              // Offset from the ball position

    private bool isMainCameraActive = true; // Keep track of the active camera

    void Start()
    {
        // Ensure the main camera is active at the start
        mainCamera.enabled = true;
        secondCamera.enabled = false;
    }

    void Update()
    {
        // Detect mouse click to toggle cameras
        if (Input.GetMouseButtonDown(0))
        {
            isMainCameraActive = !isMainCameraActive;

            // Switch cameras
            mainCamera.enabled = isMainCameraActive;
            secondCamera.enabled = !isMainCameraActive;
        }

        // If the second camera is active, make it follow and face the ball's velocity direction
        if (!isMainCameraActive)
        {
            FollowBall();
            AlignCameraToBall();
        }
    }

    // Make the camera follow the ball with smoothing
    void FollowBall()
    {
        Vector3 desiredPosition = ball.transform.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(secondCamera.transform.position, desiredPosition, smoothSpeed);
        secondCamera.transform.position = smoothedPosition;
    }

    // Align the camera to face the ball
    void AlignCameraToBall()
    {
        secondCamera.transform.LookAt(ball.transform);
    }
}