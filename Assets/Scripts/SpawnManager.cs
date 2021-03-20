using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject ObstaclePrefab;
    private Vector3 spawnpoint = new Vector3(20, 0, 0);
    private PlayerControl playercontroller;
    void Start()
    {
        InvokeRepeating("Spawn", 1, 2);
        playercontroller = GameObject.Find("Player").GetComponent<PlayerControl>();

    }

   
    void Spawn()
    {
        if (playercontroller.gameover == false)
        {
            Instantiate(ObstaclePrefab, spawnpoint, ObstaclePrefab.transform.rotation);
        }
       
    }
}
