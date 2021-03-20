using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject ObstaclePrefab;
    private Vector3 spawnpoint = new Vector3(20, 0, 0);
    void Start()
    {
        InvokeRepeating("Spawn", 1, 2);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Spawn()
    {
        Instantiate(ObstaclePrefab, spawnpoint, ObstaclePrefab.transform.rotation);
    }
}
