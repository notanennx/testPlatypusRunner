using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start
    void Start()
    {
        
    }

    // Update
    void Update()
    {
        
    }

    // OnTriggerEnter
    void OnTriggerEnter(Collider collider)
    {
        Trigger colliderTrigger = collider.gameObject.GetComponent<Trigger>();
            colliderTrigger.onTriggered.Invoke();
    }
}
