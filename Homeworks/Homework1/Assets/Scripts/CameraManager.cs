using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Camera primaryCamera;
    public Camera secondaryCamera;
    public Transform targetObject;
    public float smoothSpeed = 0.125f;

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
            Vector3 desiredPosition = targetObject.position + targetObject.forward * -10f + Vector3.up * 2f;
            Vector3 smoothedPosition = Vector3.Lerp(secondaryCamera.transform.position, desiredPosition, smoothSpeed);
            secondaryCamera.transform.position = smoothedPosition;

            Quaternion desiredRotation = Quaternion.LookRotation(targetObject.forward);
            Quaternion smoothedRotation = Quaternion.Slerp(secondaryCamera.transform.rotation, desiredRotation, smoothSpeed);
            secondaryCamera.transform.rotation = smoothedRotation;
        }
    }
}