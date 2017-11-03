using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructable : MonoBehaviour {

	public GameObject destroyVer;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetAxisRaw ("LiteAtk")>0 | Input.GetAxisRaw ("HevAtk")>0) 
		{
			Instantiate (destroyVer, transform.position, transform.rotation);
			Destroy (gameObject);
		}
	}
}
