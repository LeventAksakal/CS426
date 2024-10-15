using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleCubes : MonoBehaviour
{
    public Vector3 minScale = new Vector3(1f, 1f, 1f);
    public Vector3 maxScale = new Vector3(2f, 2f, 2f);
    public float scalingSpeed = 1f;
    public float intervalDuration = 2f;

    private bool scalingUp = true;
    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = minScale;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= intervalDuration)
        {
            scalingUp = !scalingUp;
            timer = 0f;
        }

        if (scalingUp)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, maxScale, scalingSpeed * Time.deltaTime);
        }
        else
        {
            transform.localScale = Vector3.Lerp(transform.localScale, minScale, scalingSpeed * Time.deltaTime);
        }
    }
}