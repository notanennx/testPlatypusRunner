using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Config : MonoBehaviour
{
    public int RoadAmount = 8;
    public float RoadSize = 30f;
    public float RoadSpeed = 16f;
    public GameObject[] RoadLibrary;

    // Awake
    public static Config i;
    void Awake()
    {
        i = this;
    }
}
