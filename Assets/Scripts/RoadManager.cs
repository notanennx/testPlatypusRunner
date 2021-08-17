using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadManager : MonoBehaviour
{
    public bool isMoving;
    public float moveSpeed = 10f;
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
            GameObject randomRoad = roadsLibrary[Random.Range (0, roadsLibrary.Length)];

            // Calculate
            float addZ = (currentRoad.GetComponent<Collider>().bounds.size.z * 2f);
            Vector3 newPosition = currentRoad.transform.position + new Vector3(0f, 0f, addZ);

            // Instantiate
            GameObject spawnedRoad = Instantiate(randomRoad, newPosition, Quaternion.identity);
                Trigger roadTrigger = spawnedRoad.transform.Find("Spawn Trigger").gameObject.GetComponent<Trigger>();
                
                    //roadTrigger.onTriggered
            //print("We should spawn the road now!");
        }
}
