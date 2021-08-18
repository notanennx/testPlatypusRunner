using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUI : MonoBehaviour
{
    public GameObject targetEnemy;
    public GameObject buttonsObject;

    // Awake
    public static GUI i;
    void Awake()
    {
        i = this;
    }
}
