using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{

    public CharacterController controller;

    public float maxSpeed = 10.0f;
    public float gravity = -30.0f;
    public float jumpHeight = 3.0f;
    public float groundRadius = 0.5f;


    public LayerMask groundMask;
    public Transform groundCheck;

    public Boolean isGrounded;
    

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }


    void Update()
    {

    }
}
