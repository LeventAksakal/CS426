using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjects : MonoBehaviour
{
    private Rigidbody rb;
    private float cooldownTime = 2f; // Cooldown time in seconds
    private float lastForceTime;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        lastForceTime = -cooldownTime; // Initialize to allow immediate force application
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Time.time >= lastForceTime + cooldownTime)
        {
            Vector3 randomDirection = new Vector3(
                Random.Range(-1f, 1f),
                Random.Range(-1f, 1f),
                Random.Range(-1f, 1f)
            ).normalized;

            rb.AddForce(randomDirection * 10f, ForceMode.Impulse);
            lastForceTime = Time.time; // Update the last force time
        }
    }
}