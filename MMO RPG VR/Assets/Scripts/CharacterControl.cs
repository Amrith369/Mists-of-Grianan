﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour {

	public float walk = 6.0f;
	public float sprint = 12.0f;
	public float jump = 8.0f;
	public float gravity = 20.0f;
	private Vector3 moveDirection = Vector3.zero;
	public GameObject pauseMenu;
	private bool menuOpen;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		PauseGame ();
		CharacterController controller = GetComponent<CharacterController> ();
		moveDirection = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
		moveDirection = transform.TransformDirection (moveDirection);
		moveDirection *= walk;
		if (Input.GetButtonDown ("Jump")) 
		{
			//controller.moveDirection.y = jump;
			moveDirection.y = (jump * Time.deltaTime) + (gravity);
		}
		if (Input.GetButton ("Sprint")) {
			walk = sprint;

		} else if (Input.GetButton("Sprint") == false)
		{
			walk = 6.0f;
		}

		moveDirection.y -= 3*(gravity * Time.deltaTime);
		controller.Move (moveDirection * Time.deltaTime);
	}

	void PauseGame()
	{
		if (Input.GetKeyDown (KeyCode.Tab) && menuOpen == false) {
			print ("Menu Activated");
			pauseMenu.SetActive (true);
			menuOpen = true;

		} else if (Input.GetKeyDown (KeyCode.Tab) && menuOpen == true) {
			print ("Menu Deactivated");
			pauseMenu.SetActive (false);
			menuOpen = false;

		}
	}
}
