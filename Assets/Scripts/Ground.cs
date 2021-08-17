using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    // Update
    void Update()
    {
        transform.Translate(-Vector3.forward * Time.deltaTime * RoadManager.i.currentSpeed);
    }

    // OnTriggerEnter
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Remover") Destroy(gameObject);
    }
}
