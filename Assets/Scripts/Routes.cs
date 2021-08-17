using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using DG.Tweening;

public class Routes : MonoBehaviour
{
    public int currentRoute;
    public int routesAmount;
    public GameObject playerEntity;

    // Awake
    public static Routes instance;
    void Awake ()
    {
        instance = this;
    }

    // Find
    Transform FindRoute(int num)
    {
        Transform lookupRoute = transform.Find(num.ToString());
        if (lookupRoute)
        {
            return lookupRoute;
        }
        else
        {
            return null;
        }
    }

    // Move
    public void MoveToRoute(int num)
    {
        currentRoute = Mathf.Clamp(num, -routesAmount, routesAmount);

        Transform desiredRoute = FindRoute(currentRoute);
        if (desiredRoute)
        {
            Vector3 playerPosition = playerEntity.transform.position;
            Vector3 desiredPosition = desiredRoute.position;

            playerEntity.transform.DOMove(new Vector3(desiredPosition.x, playerPosition.y, playerPosition.z), 0.2f);
        }
    }

    // Change
    public void ChangeRoute(int num)
    {
        MoveToRoute(currentRoute + num);
    }
}
