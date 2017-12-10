using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followCamera : MonoBehaviour {

	public Transform target;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.LookAt (target);
		transform.Translate (Vector3.up * 1, Space.World);
		transform.Translate (Vector3.back * 1, Space.World);
		if (target)
		{
			transform.position = Vector3.Lerp(transform.position, target.position, 0.4f);
	}
}
}
