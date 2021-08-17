using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using DG.Tweening;

public class Routes : MonoBehaviour
{
    public int currentRoute;
    public int routesAmount;
    public GameObject playerEntity;

    // Start
    void Start()
    {
        //playerTransform = playerEntity.GetComponent<Transform>();
        //playerRigidbody = playerEntity.GetComponent<Rigidbody>();
    }

    // Update
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            MoveToRoute(currentRoute - 1);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            MoveToRoute(currentRoute + 1);
        }
    }

    // Moving
    void MoveToRoute(int routeNum)
    {
        currentRoute = Mathf.Clamp(routeNum, -routesAmount, routesAmount);

        Transform desiredRoute = FindRoute(currentRoute);
        if (desiredRoute)
        {
            Vector3 playerPosition = playerEntity.transform.position;
            Vector3 desiredPosition = desiredRoute.position;

            playerEntity.transform.DOMove(new Vector3(desiredPosition.x, playerPosition.y, playerPosition.z), 0.3f);
        }
    }

    // Finding
    Transform FindRoute(int routeNum)
    {
        Transform lookupRoute = transform.Find(routeNum.ToString());
        if (lookupRoute)
        {
            return lookupRoute;
        }
        else
        {
            return null;
        }
    }
}
