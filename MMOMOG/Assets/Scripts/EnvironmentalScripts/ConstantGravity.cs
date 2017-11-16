using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantGravity : MonoBehaviour {

	public float speed = 48f;
	public float gravity = 16f;
	private Vector3 moveDirection = Vector3.zero;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		moveDirection.y -= gravity * (Time.deltaTime * Time.deltaTime);
		
	}
}
