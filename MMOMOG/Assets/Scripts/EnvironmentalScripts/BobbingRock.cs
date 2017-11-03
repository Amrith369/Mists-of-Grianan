using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BobbingRock : MonoBehaviour {

	public GameObject rock;

	//private Vector3 startPosition;

	public float sped = 0.2f;
	private Vector3 pos;
	public float max;
	public float min;

	void Start()
	{
		pos = rock.transform.position;
	}

	void Update()
	{
		
		transform.Translate(0, Mathf.Sin(Time.time * sped )/62,0, Space.World);
		if (pos.y >= max ||pos.y <= min) {
			sped = -1 * sped;
			print (sped);
		} 

	}
}
