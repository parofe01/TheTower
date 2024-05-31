using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour
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
        bool isWalking = animator.GetBool("isWalking");
        bool moveForward = Input.GetKey("w");
        bool moveLeft = Input.GetKey("d");
        bool moveRight = Input.GetKey("a");
        bool moveBackwards = Input.GetKey("s");
        bool isJumping = Input.GetKey("space");
        bool isRunning = Input.GetKey("left shift");

        //moving forward
        if (moveForward)
        {
            animator.SetBool("isWalking", true);
        }
        if (!moveForward)
        {
            animator.SetBool("isWalking", false);
        }

        // moving left
        if (moveLeft)
        {
            animator.SetBool("isWalkingLeft", true);
        }
        if (!moveLeft)
        {
            animator.SetBool("isWalkingLeft", false);
        }

        // moving right
        if (moveRight)
        {
            animator.SetBool("isWalkingRight", true);
        }
        if (!moveRight)
        {
            animator.SetBool("isWalkingRight", false);
        }



        //movimg backward


        if (moveBackwards)
        {
            animator.SetBool("isWalkingBackward", true);
        }
        if (!moveBackwards)
        {
            animator.SetBool("isWalkingBackward", false);
        }

        //isSprinting
        if (isRunning && (moveForward || moveBackwards || moveLeft || moveRight))
        {
            animator.SetBool("isRunning", true);
        }
        if (!isRunning)
        {
            animator.SetBool("isRunning", false);
        }
        // isJumping
        if (isJumping && (moveForward || moveBackwards || moveLeft || moveRight))
        {
            animator.SetBool("isJumping", true);
        }
        if (!isJumping)
        {
            animator.SetBool("isJumping", false);
        }

    }


}