﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interact : MonoBehaviour {

	public GameObject hit;
	public string collideobject;
	public bool hasCollided = false;
	public string text = "";
	private sceneChangeFade anotherScript;


	void Start () {
		anotherScript = GetComponent<sceneChangeFade> ();
	}

	void Update () {
		
		if (hasCollided == true)
		{   
			//GUI.Box(new Rect(140,Screen.height-50,Screen.width-300,120),(text));
			print("Gotcha");
			if (Input.GetAxisRaw("Confirm") > 0) {
				GetComponent<sceneChangeFade> ().enabled = true;
			}
		}

	}

	void OnGUI()
	{
		/*if (hasCollided == true)
		{    
			GUI.Box(new Rect(140,Screen.height-50,Screen.width-300,120),(text));
		}*/
	}
	void OnTriggerEnter(Collider collision)
	{
		if (collision.gameObject.tag == "Player") {
			hasCollided = true;
			if (Input.GetAxisRaw("Confirm") > 0) {
				GetComponent<sceneChangeFade> ().enabled = true;

			}
		}
	}

	void OnTriggerExit(Collider collision){
		hasCollided = false;
	}

	// Use this for initialization


	// Update is called once per frame
}
