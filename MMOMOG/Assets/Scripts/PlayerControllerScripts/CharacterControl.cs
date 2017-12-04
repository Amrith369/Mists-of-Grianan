using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour {

	public float walk = 6.0f;
	public float sprint = 12.0f;
	public float jump = 8.0f;
	public float gravity = 20.0f;
	public float speed = 0;
	private Vector3 moveDirection = Vector3.zero;
	//public GameObject pauseMenu;
	private bool menuOpen;
	public GameObject map;
	public static float distanceFromTarget;
	public float toTarget;
	public Animator anim;
	



	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		//PauseGame ();
		CharacterController controller = GetComponent<CharacterController> ();
		moveDirection = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
		moveDirection = transform.TransformDirection (moveDirection);
		moveDirection *= walk;

		if (Input.GetButtonDown ("Jump")) {
			//controller.moveDirection.y = jump;
			//moveDirection.y += (jump / (Time.deltaTime * Time.deltaTime));
			//moveDirection.y = jump * Time.deltaTime * Time.deltaTime - gravity * (Time.deltaTime * Time.deltaTime)/2;
			speed = jump * 2;
			moveDirection.y += speed * Time.deltaTime;
			
		} else {
			//moveDirection.y -= (gravity / (Time.deltaTime * Time.deltaTime));
		}
		if (Input.GetButton ("Sprint")) {
			walk = sprint;
		} else if (Input.GetButton ("Sprint") == false) {
			walk = 6.0f;
		}

		moveDirection.y += speed * Time.deltaTime;
		speed -= gravity;
		moveDirection.y -= (gravity * (Time.deltaTime));
		//print(moveDirection.y);
		controller.Move (moveDirection * Time.deltaTime);
		map.SetActive (false);

		RaycastHit hit;
		if (Physics.Raycast (transform.position, transform.TransformDirection (Vector3.forward), out hit)) {
			toTarget = hit.distance;
			distanceFromTarget = toTarget;
		}
		if (Input.GetButton ("Sprint") == true && Input.GetAxis ("Vertical") {
			anim.SetBool ("isStationary", false);
			anim.SetBool ("isRunning", true);
		}
		if (Input.GetButton ("Sprint") == false && Input.GetAxis ("Vertical") > 0.1) {
			anim.SetBool ("isStationary", false);
			anim.SetBool ("isRunning", false);
		}
		if (Input.GetAxis ("Vertical") < 0.1 && Input.GetButton ("Sprint") == false) {
			anim.SetBool ("isStationary", true);
			anim.SetBool ("isRunning", false);
		}

	}
}
