using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUI : MonoBehaviour
{
    public GameObject targetEnemy;
    public GameObject enemyMenu;
    public GameObject restartButton;

    // Awake
    public static GUI i;
    void Awake()
    {
        i = this;
    }

    // Костыль, но в голову пока ничего лучше не пришло

    // Hit
    public void HitEnemy()
    {
        Enemy enemyScript = targetEnemy.GetComponent<Enemy>();
            enemyScript.Hit();
    }

    // Bribe
    public void BribeEnemy()
    {
        Enemy enemyScript = targetEnemy.GetComponent<Enemy>();
            enemyScript.Bribe();
    }
}
