﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody rbplayer;
    public float GravityModifier;
    public float JumpForce;
    private bool onground = true;
    public bool gameover = false;
    private Animator Animplayer;
    void Start()
    {
       rbplayer = GetComponent<Rigidbody>();
        Physics.gravity *= GravityModifier;
        Animplayer = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool spacedown = Input.GetKeyDown(KeyCode.Space);
        if (spacedown && onground && !gameover)
        {
            rbplayer.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
            onground = false;
            Animplayer.SetTrigger("Jump_trig");
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
       if (collision.gameObject.CompareTag("Ground"))
        {
            onground = true;
        }
       else if (collision.gameObject.CompareTag("Barrier"))
        {
            Debug.Log("Game Over");
            gameover = true;
            Animplayer.SetBool("Death_b", true);
            Animplayer.SetInteger("Deathtype_int", 2);
            
        }
    }
}
