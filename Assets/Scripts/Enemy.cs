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
    public void Hit()
    {
        transform.DORotate(new Vector3(0f, 90f, 0f), 0.2f);
        transform.DOLocalJump(transform.position + new Vector3(0f, 32f, 0f), 32f, 1, 06f);
        //transform.DOJump(transform.position, 64f, 2, 1f, false);

        // Continue
        RoadManager.i.RoadStart();
        print("Hit the enemy!");
    }

    // Payoff
    public void Payoff()
    {
        CoinsDisplay.i.SetCoins(0);

        // Anims
        Player.i.isAlive = false;
        Player.i.playerAnimator.SetTrigger("Dizzy");
        Player.i.transform.DORotate(new Vector3(0f, 180f, 0f), 0.6f);
    }
}
