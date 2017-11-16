﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openmenu : MonoBehaviour {

	public Canvas IngameOption;
	private bool menuEnabled = false; // call this whatever you want mark
	public GameObject control;
	public GameObject pausemenu;
	public Animator anim;
	public bool IsDisplayed; 
	public bool tabpressed;
	public float timefin = 2f;
	private IEnumerable delaystart;
	public void DisableBoolAnimator (Animator anim)
	{
		anim.SetBool ("IsDisplayed", false);
	}
	public void EnableBoolAnimator(Animator anim)
	{
		anim.SetBool ("IsDisplayed", true);
	}
	public void NavigateTo(int scene)
	{
		Application.LoadLevel (scene);
	}
	public void ExitGame()
	{
		Application.Quit ();
	}




	// Use this for initialization
	void Start ()
	{
		IngameOption = IngameOption.GetComponent<Canvas>();
		menuEnabled = false;
		IngameOption.enabled = menuEnabled;
		pausemenu.SetActive (false);
		anim.GetBool("IsDisplayed");

	}

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Tab) && IsDisplayed == false) {
			anim.SetBool ("IsDisplayed", false);
			IsDisplayed = true;
			tabpressed = true;




		} else if (Input.GetKeyDown (KeyCode.Tab) && IsDisplayed == true) {
			menuEnabled = true;
			IngameOption.enabled = menuEnabled;
			control.GetComponent<CharacterControl> ().enabled = false;
			pausemenu.SetActive (true);
			anim.SetBool ("IsDisplayed", true);
			IsDisplayed = false;
			tabpressed = true;

		}
			
	
		if (IsDisplayed == true && timefin >= 0f) {
			timefin -= Time.deltaTime;

		}
		if (IsDisplayed == true && timefin <= 0f && tabpressed == true) {
			menuEnabled = false;
			IngameOption.enabled = menuEnabled;
			control.GetComponent<CharacterControl> ().enabled = true;
			pausemenu.SetActive (false);
			timefin = 2f;
			tabpressed = false;

		}
	}
	public void map() {
		anim.SetBool ("IsDisplayed", true);


	}
}
