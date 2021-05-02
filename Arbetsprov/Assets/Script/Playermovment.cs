using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovment : MonoBehaviour
{

    public CharacterController2D controller;
    public Animator animator;
    public float RunSpeed = 40f;
    float Moveleftorright = 0f;
    bool jump = false;
    bool crouch = false;

    void Update() {
        Moveleftorright = Input.GetAxisRaw("Horizontal") * RunSpeed;

        animator.SetFloat("fart", Mathf.Abs(Moveleftorright)) ;


        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("hoppar", true);
        } 
           
       
    }
 

    public void onlanding ()
    {
        animator.SetBool("hoppar", false);
    }

    public void ondukar (bool dukar)
    {
        animator.SetBool("dukar", dukar);
    }

    void FixedUpdate() {
        controller.Move(Moveleftorright * Time.fixedDeltaTime, crouch ,jump);
        jump = false;
    }

   
}
