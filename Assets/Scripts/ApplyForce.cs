using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyForce : MonoBehaviour
{
    public GameObject obj;        // Reference to the ball
    private Rigidbody rb; // Reference to the Rigidbody component of the ball
    public float forceMagnitude = 10f; // Magnitude of the force to be applied

    // Start is called before the first frame update
    void Start()
    {
        this.rb = obj.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Vector3 forceDirection;

            // Check if the object is moving
            if (rb.velocity.magnitude > 0.1f)
            {
                // Apply force in the direction of movement with an upward component
                forceDirection = rb.velocity.normalized + Vector3.up * 0.5f;
            }
            else
            {
                // Apply force in a random direction with an upward component
                forceDirection = new Vector3(Random.Range(-1f, 1f), 0.5f, Random.Range(-1f, 1f)).normalized;
            }

            // Apply the force
            rb.AddForce(forceDirection * forceMagnitude, ForceMode.Impulse);
        }
    }
}