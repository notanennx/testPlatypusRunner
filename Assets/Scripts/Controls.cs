using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

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

    // Reset
    public void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Update
    void Update()
    {
        // Check
        if ((!Player.i.isAlive) || (GUI.i.enemyMenu.activeSelf)) return;

        // Start Road
        if ((SwipeManager.IsSwiping() || Input.GetMouseButtonDown(0)) && (!RoadManager.i.isMoving))
            {
                RoadManager.i.RoadStart();
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
