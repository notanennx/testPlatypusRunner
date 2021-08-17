using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    public GameObject playerEntity;

    // Start
    private Rigidbody playerRigidbody;
    private Transform playerTransform;
    void Start()
    {
        playerTransform = playerEntity.GetComponent<Transform>();
        playerRigidbody = playerEntity.GetComponent<Rigidbody>();
    }

    // Update
    void Update()
    {
        /*
        if (Input.GetKeyDown("space"))
        {
            Transform[] routesTransform = routesEntity.GetComponentsInChildren<Transform>();
            foreach (Transform routeTransform in routesTransform)
            {
                if (routeTransform.gameObject.GetInstanceID() != routesEntity.GetInstanceID())
                {
                    //print(routeTransform.name);
                }
                
            }
        }
        */
    }
}
