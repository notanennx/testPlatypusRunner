using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using DG.Tweening;

public class RoadManager : MonoBehaviour
{
    public bool isMoving;
    public float currentSpeed = 0f;

    public GameObject[] roadsLibrary;

    // Awake
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

            Player.i.SetAnimation("Idle");
        }

        // Start
        public void RoadStart()
        {
            isMoving = true;
            currentSpeed = Config.i.RoadSpeed;

            Player.i.SetAnimation("Running");
        }

        // Spawn
        public void RoadSpawn(GameObject currentRoad)
        {
            // Select
            GameObject randomRoad = Config.i.RoadLibrary[Random.Range(0, Config.i.RoadLibrary.Length)];

            // Progress
            ProgressDisplay.i.Progress();

            // Calculate
            float addZ = (Config.i.RoadSize * 2f);
            Vector3 newPosition = currentRoad.transform.position + new Vector3(0f, -10f, addZ);

            // Instantiate
            GameObject spawnedRoad = Instantiate(randomRoad, newPosition, Quaternion.identity);
                spawnedRoad.transform.DOMoveY(0f, 0.4f);

                // Trigger
                GameObject roadPlane = spawnedRoad.transform.Find("Plane").gameObject;
                    Trigger roadTrigger = roadPlane.transform.Find("Spawn Trigger").gameObject.GetComponent<Trigger>();
        }
}
