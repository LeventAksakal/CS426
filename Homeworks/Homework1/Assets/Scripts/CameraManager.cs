using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Camera primaryCamera;
    public Camera secondaryCamera;
    public Transform targetObject;
    public float smoothSpeed = 0.125f;
    public Vector3 offset = new Vector3(10f, 10f, 0f); // Offset from the target object

    private bool isSecondaryCameraActive = false;

    // Start is called before the first frame update
    void Start()
    {
        primaryCamera.enabled = true;
        secondaryCamera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isSecondaryCameraActive = !isSecondaryCameraActive;
            primaryCamera.enabled = !isSecondaryCameraActive;
            secondaryCamera.enabled = isSecondaryCameraActive;
        }

        if (isSecondaryCameraActive)
        {
            Vector3 desiredPosition = targetObject.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(secondaryCamera.transform.position, desiredPosition, smoothSpeed);
            secondaryCamera.transform.position = smoothedPosition;

            Vector3 lookAtPosition = targetObject.position;
            lookAtPosition.y = secondaryCamera.transform.position.y; // Maintain the camera's y position
            secondaryCamera.transform.LookAt(lookAtPosition);
        }
    }
}