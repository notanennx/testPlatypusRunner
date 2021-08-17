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
        // Start Road
        if (SwipeManager.IsSwiping() && (!RoadManager.i.isMoving))
            {
                RoadManager.i.RoadStart();
                //return;
            }

        // Swiping Controls
        if (SwipeManager.IsSwipingLeft())
        {
            Routes.instance.ChangeRoute(-1);
        }
        else if (SwipeManager.IsSwipingRight())
        {
            Routes.instance.ChangeRoute(1);
        }
    }
}
