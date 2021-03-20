using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 StartPosition;
    private float repeatwidth;
    void Start()
    {
        StartPosition = transform.position;
        repeatwidth = GetComponent<BoxCollider>().size.x / 2;
    }

   
    void Update()
    {
        if (transform.position.x < StartPosition.x - repeatwidth)
        {
            transform.position = StartPosition;
        }
    }
}
