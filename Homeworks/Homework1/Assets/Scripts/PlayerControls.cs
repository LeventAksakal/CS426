using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    private Rigidbody rb;

    public float forceMagnitude = 10f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * forceMagnitude);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.back * forceMagnitude);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * forceMagnitude);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * forceMagnitude);
        }
    }
}