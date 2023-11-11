using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float rotationSpeed = 5.0f;
    public float moveForce = 10.0f; // Adjust this value to control the movement force.
    private Rigidbody rb;
    public bool isPlayerMovable = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void MovePlayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        // Get the player's input for forward and backward movement.
        float verticalInput = Input.GetAxis("Vertical");


        // Check for left and right arrow keys (or 'A' and 'D' keys) and rotate the player accordingly.
        if (horizontalInput != 0)
        {
            float rotationAmount = horizontalInput * rotationSpeed * Time.deltaTime;
            transform.Rotate(Vector3.up, rotationAmount);
        }

        // Calculate the movement direction based on where the player is looking.
        Vector3 moveDirection = transform.forward * verticalInput;

        // Apply force to move the player in the calculated direction.
        rb.AddForce(moveDirection * moveForce, ForceMode.Force);
    }


    // Update is called once per frame
    void Update()
    {

        if (isPlayerMovable)
        {
            MovePlayer();
        }

    }
   
}
