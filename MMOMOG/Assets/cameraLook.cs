using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraLook : MonoBehaviour {

	public Transform player;
	public float minDistance = 10f;
	public float cameraSpeed = 10f;
	private Vector3 smoothVelocity = Vector3.zero;

	void Start()
	{

	}

	void Update()
	{
		transform.LookAt(player);
		float distance = Vector3.Distance(transform.position, player.position);
		if(distance < minDistance)
		{
			transform.position = Vector3.SmoothDamp(transform.position, player.position, ref smoothVelocity, cameraSpeed);
		}
	}
}