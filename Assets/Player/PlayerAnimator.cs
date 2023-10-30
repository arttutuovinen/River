using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{

    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Forward movement
        if (Input.GetAxis("Vertical") > 0.0f)
        {
            animator.SetBool("IsMovingForward", true);
        }

        else
        {
            animator.SetBool("IsMovingForward", false);
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

        //Turning right
        if (Input.GetAxis("Horizontal") > 0.0f)
        {
            animator.SetBool("IsTurningRight", true);
        }

        else
        {
            animator.SetBool("IsTurningRight", false);
        }

       //Turning left
        if (Input.GetAxis("Horizontal") < 0.0f)
        {
            animator.SetBool("IsTurningLeft", true);
        }

        else
        {
            animator.SetBool("IsTurningLeft", false);
        }
    }
}
