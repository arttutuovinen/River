using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Alustaminen = Initiation
    public float rotationSpeed = 5.0f;
    public float moveForce = 100.0f; // Adjust this value to control the movement force.
    private Rigidbody rb;
    public bool isPlayerMovable = false;
    public AudioSource rowingSound;
    public float horizontalInput;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rowingSound = GetComponent<AudioSource>();
    }

    void MovePlayer()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        // Get the player's input for forward and backward movement.
        verticalInput = Input.GetAxis("Vertical");


        // Check for left and right arrow keys (or 'A' and 'D' keys) and rotate the player accordingly.
        if (horizontalInput != 0)
        {
            float rotationAmount = horizontalInput * rotationSpeed * Time.deltaTime;
            transform.Rotate(new Vector3(0, 1, 0), rotationAmount);

        }

        if (verticalInput != 0)
        {
            // Calculate the movement direction based on where the player is looking.
            Vector3 moveDirection = transform.forward * verticalInput * Time.deltaTime;

            // Apply force to move the player in the calculated direction.
            rb.AddForce(moveDirection * moveForce, ForceMode.Force);
        }

       
        
    }

    public void PlayRowingSound()
    {
        
       
            rowingSound.Play();
        
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
