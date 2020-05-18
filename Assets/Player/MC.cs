using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MC : MonoBehaviour
{
    public CharacterController2D controller;

    float horizontalMove = 0f;
    public float runSpeed = 40f;
    bool jump = false;
    bool crouch = false;

    public Animator animator;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Input.GetAxisRaw("Horizontal"));
        
        horizontalMove =  Input.GetAxisRaw("Horizontal")*runSpeed;

        animator.SetFloat("Sp", Mathf.Abs(horizontalMove));

        if(Input.GetButtonDown("Jump"))
        {
            Debug.Log("JUMP");
            jump = true;
            animator.SetBool("IsJumping", true);
        }
        if(Input.GetButtonDown("Crouch"))
        {
           
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            
            crouch = false;
        }
    }

    public void OnLanding()
    {
        Debug.Log("FALSE");
        animator.SetBool("IsJumping", false);
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove*Time.fixedDeltaTime,crouch,jump);
        jump = false;
    }
}
