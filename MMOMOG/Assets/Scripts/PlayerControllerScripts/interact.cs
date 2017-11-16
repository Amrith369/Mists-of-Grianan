using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interact : MonoBehaviour {

	public GameObject hit;
	public string collideobject;
	public bool hasCollided = false;
	public string text = "";
	sceneChangeFade fade = new sceneChangeFade();


	void Start () {
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			fade.Avera ();
			print ("Teleporting to Avera");
		}


		if (hasCollided == true)
		{    
			GUI.Box(new Rect(140,Screen.height-50,Screen.width-300,120),(text));

		}

	}

	void OnGUI()
	{
		if (hasCollided == true)
		{    
			GUI.Box(new Rect(140,Screen.height-50,Screen.width-300,120),(text));
			print ("gui box");
		}
	}

	void OnTriggerEnter(Collider collision)
	{
		print ("Collision 1");
		if (collision.gameObject.tag == "Player") {
			hasCollided = true;
			print ("Collision 2");


		}
	}

	void OnTriggerExit(Collider collision){
		hasCollided = false;
		print ("Exiting Collision");
	}

	// Use this for initialization


	// Update is called once per frame
}
