using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    // Start
    void Start()
    {
        transform.Rotate(0f, Random.Range(0f, 180f), 0f, Space.World);
    }

    // Update
    private float floatSpeed = 6f;
    private float floatRange = 0.25f;
    void Update()
    {
        transform.localPosition = new Vector3(0f, floatRange * Mathf.Sin(Time.time * floatSpeed), 0f);
        transform.Rotate(0f, (Time.deltaTime * (floatSpeed * 22.5f)), 0f, Space.World);
        //transform.Rotate(Vector3(0f, Time.deltaTime * floatSpeed, 90f))
    }
}
