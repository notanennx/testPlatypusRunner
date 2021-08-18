using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using DG.Tweening;

public class Enemy : MonoBehaviour
{
    public Animator animator;

    // Start
    void Start()
    {
        animator.SetTrigger("Dizzy");
    }

    // Hit
    float[] jumpLength = {-16f, 16f};
    public void Hit()
    {
        transform.DORotate(new Vector3(0f, 180f, 0f), 0.2f);
        transform.DOLocalJump(transform.position + new Vector3(jumpLength[Random.Range(0, jumpLength.Length)], -32f, 16f), 16f, 1, 1.6f);

        // Continue
        RoadManager.i.RoadStart();
    }

    // Bribe
    public void Bribe()
    {
        CoinsDisplay.i.SetCoins(0);

        // Gui
        GUI.i.restartButton.SetActive(true);

        // Anims
        Player.i.isAlive = false;
        Player.i.playerAnimator.SetTrigger("Dizzy");
        Player.i.transform.DORotate(new Vector3(0f, 180f, 0f), 0.6f);

        // Enemy
        animator.SetTrigger("Idle");
        transform.DORotate(new Vector3(0f, 180f, 0f), 0.9f);
    }
}
