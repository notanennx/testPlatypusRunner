using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
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

    // OnTriggerEnter
    void OnTriggerEnter(Collider collider)
    {
        Trigger colliderTrigger = collider.gameObject.GetComponent<Trigger>();
            colliderTrigger.onTriggered.Invoke();
    }
}
