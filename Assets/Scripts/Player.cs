using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool isAlive = true;
    public Animator playerAnimator;

    // Awake
    public static Player i;
    void Awake()
    {
        i = this;
    }

    // Animation
    public void SetAnimation(string name)
    {
        playerAnimator.SetTrigger(name);
    }

    // MeetEnemy
    public void MeetEnemy(GameObject target)
    {
        RoadManager.i.RoadStop();

        GUI.i.targetEnemy = target;
        GUI.i.buttonsObject.SetActive(true);
    }

    // OnTriggerEnter
    void OnTriggerEnter(Collider collider)
    {
        Trigger colliderTrigger = collider.gameObject.GetComponent<Trigger>();
            colliderTrigger.onTriggered.Invoke();
    }
}
