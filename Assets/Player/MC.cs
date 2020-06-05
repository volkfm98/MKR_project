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

    Vector3 mousePos;

    public Animator animator;
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        //Debug.Log(Input.GetAxisRaw("Horizontal"));

        GameObject pauseMenuController = GameObject.Find("PauseMenuController");
        PauseMenu pauseMenu = pauseMenuController.GetComponent<PauseMenu>();

        if (!pauseMenu.isPaused)
        {
	        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
	        mousePos.z = 0;

	        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

	        animator.SetFloat("Sp", Mathf.Abs(horizontalMove));

	        //Fire on mouse left click
	        if (Input.GetButtonDown("Fire1")) {
	            controller.Fire();
	            Debug.Log("FIRE AT WILL!");
	        }

	        //Jump on space click
	        if (Input.GetButtonDown("Jump")) {
	            Debug.Log("JUMP");
	            jump = true;
	            animator.SetBool("IsJumping", true);
	        } else if (Input.GetButtonUp("Jump")) {
	            jump = false;
	        }

	    	//Crouch on "S" click
	        if (Input.GetButtonDown("Crouch")) {

	            crouch = true;
	        } else if (Input.GetButtonUp("Crouch")) {

	            crouch = false;
	        }
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
        controller.Move(horizontalMove*Time.fixedDeltaTime,crouch,jump, mousePos);
        jump = false;
    }
}
