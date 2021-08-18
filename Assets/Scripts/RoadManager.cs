using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using DG.Tweening;

public class RoadManager : MonoBehaviour
{
    public bool isMoving;
    public float moveSpeed = 16f;
    public float currentSpeed = 0f;

    public GameObject[] roadsLibrary;

    // Awake
    public float roadSize = 30f;
    public static RoadManager i;
    void Awake()
    {
        i = this;
    }

    // Roads

        // Stop
        public void RoadStop()
        {
            isMoving = false;
            currentSpeed = 0f;
        }

        // Start
        public void RoadStart()
        {
            isMoving = true;
            currentSpeed = moveSpeed;
        }

        // Spawn
        public void RoadSpawn(GameObject currentRoad)
        {
            // Select
            GameObject randomRoad = roadsLibrary[Random.Range (0, roadsLibrary.Length)];

            // Progress
            ProgressDisplay.i.Progress();

            // Calculate
            float addZ = (roadSize * 2f);
            Vector3 newPosition = currentRoad.transform.position + new Vector3(0f, -10f, addZ);

            // Instantiate
            GameObject spawnedRoad = Instantiate(randomRoad, newPosition, Quaternion.identity);
                spawnedRoad.transform.DOMoveY(0f, 0.4f);

                // Trigger
                GameObject roadPlane = spawnedRoad.transform.Find("Plane").gameObject;
                    Trigger roadTrigger = roadPlane.transform.Find("Spawn Trigger").gameObject.GetComponent<Trigger>();
        }
}
