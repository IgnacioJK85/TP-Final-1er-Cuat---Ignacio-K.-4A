﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    Quaternion originalRotation;
    public float movementSpeed, rotationSpeed, jumpForce;
    public int maxJumps;
    int hasJump;
    public float rotationResetSpeed;
    Rigidbody rb;

    void Start()
    {
        originalRotation = transform.rotation;
        hasJump = maxJumps;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(-movementSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(movementSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -rotationSpeed, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotationSpeed, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space) && hasJump > 0)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            hasJump--;
        }

        if (transform.rotation.x != 0f || transform.rotation.z != 0f)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, originalRotation, Time.time * rotationResetSpeed);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Plane" || col.gameObject.transform.parent.name == "Plane")
        {
            hasJump = maxJumps;
        }
    }  
}