using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Get horizontal and vertical input from the player.
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the movement direction based on input.
        Vector3 moveDirection = new Vector3(horizontalInput, 0.0f, verticalInput).normalized;

        // Apply force to move the player.
        Vector3 movement = moveDirection * moveSpeed;
        rb.AddForce(movement);
    }
}


