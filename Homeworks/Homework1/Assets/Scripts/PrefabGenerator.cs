using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab; // The prefab to be spawned
    public Vector3 spawnPosition; // The position where the prefab will be spawned
    public Vector3 randomForceRange; // The range of random force to be applied

    // Start is called before the first frame update
    void Start()
    {
        // Optionally, you can remove this if you don't want to spawn an object at the start
        // SpawnObject();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            SpawnObject();
        }
    }

    void SpawnObject()
    {
        // Instantiate the prefab at the specified position with a random rotation
        GameObject spawnedObject = Instantiate(prefab, spawnPosition, Random.rotation);

        // Apply a random force to the spawned object
        Rigidbody rb = spawnedObject.GetComponent<Rigidbody>();
        if (rb != null)
        {
            Vector3 randomForce = new Vector3(
                Random.Range(-randomForceRange.x, randomForceRange.x),
                Random.Range(-randomForceRange.y, randomForceRange.y),
                Random.Range(-randomForceRange.z, randomForceRange.z)
            );
            rb.AddForce(randomForce, ForceMode.Impulse);
        }
    }
}