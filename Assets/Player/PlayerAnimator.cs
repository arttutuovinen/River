using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{

    Animator animator;
    public bool isPlayerMovable = false;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Enable player movement when the spacebar is pressed for the first time
            if (!isPlayerMovable)
            {
                isPlayerMovable = true;
            }
        }


        if (isPlayerMovable == true)
        {
            //Forward movement
            if (Input.GetAxis("Vertical") > 0.0f)
            {
                animator.SetBool("IsMovingForward", true);
            }

            //TEST

            else if (Input.GetAxis("Horizontal") > 0.0f)
            {
                animator.SetBool("IsTurningRight", true);
            }

            else if (Input.GetAxis("Horizontal") < 0.0f)
            {
                animator.SetBool("IsTurningLeft", true);
            }

            else
            {
                animator.SetBool("IsMovingForward", false);
                animator.SetBool("IsTurningRight", false);
                animator.SetBool("IsTurningLeft", false);

            }





            //Backwards movement
            if (Input.GetAxis("Vertical") < 0.0f)
            {
                animator.SetBool("IsMovingBackwards", true);
            }

            else
            {
                animator.SetBool("IsMovingBackwards", false);
            }

        }
        
        
    }
}
