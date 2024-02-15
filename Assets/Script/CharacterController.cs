using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("IsFlyWalking", true); 
        }
        else
        {
            animator.SetBool("IsFlyWalking", false); 
        }
        if (Input.GetKey(KeyCode.Space))
        {
            animator.SetBool("IsJumpingDown", true); 
        }
        else
        {
            animator.SetBool("IsJumpingDown", false); 
        }
    }
}
