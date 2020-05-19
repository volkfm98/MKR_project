using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MC : MonoBehaviour {
    public CharacterController2D controller;

    //TO BE DELETED:
    [SerializeField] private Transform StaticTeleport;

    float horizontalMove = 0f;
    public float runSpeed = 40f;
    bool jump = false;
    bool crouch = false;

    public Animator animator;
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        //Debug.Log(Input.GetAxisRaw("Horizontal"));

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Sp", Mathf.Abs(horizontalMove));

        //TO BE DELETED
        if (Input.GetButtonDown("Fire1")) {
            controller.Teleport(StaticTeleport);
            Debug.Log("Teleport!");
        }

        if (Input.GetButtonDown("Jump")) {
            Debug.Log("JUMP");
            jump = true;
            animator.SetBool("IsJumping", true);
        }
        if (Input.GetButtonDown("Crouch")) {

            crouch = true;
        } else if (Input.GetButtonUp("Crouch")) {

            crouch = false;
        }
    }

    public void OnLanding() {
        Debug.Log("FALSE");
        animator.SetBool("IsJumping", false);
    }

    public void OnCrouch() {

    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove*Time.fixedDeltaTime,crouch,jump);
        jump = false;
    }
}
