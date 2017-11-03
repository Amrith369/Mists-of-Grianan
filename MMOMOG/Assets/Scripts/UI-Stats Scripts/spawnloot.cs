using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnloot : MonoBehaviour {
	public GameObject loot;
	int spawnNum = 5;

	void spawn()
	{
		for (int i = 0; i < spawnNum; i++) {
			Vector3 lootPos = new Vector3 (this.transform.position.x + Random.Range (-1.0f, 1.0f),
				                  this.transform.position.y + Random.Range (0.0f, 1.0f),
				                  this.transform.position.z + Random.Range (-1.0f, 1.0f));
			Instantiate (loot, lootPos, Quaternion.identity);
		}
	}
	// Use this for initialization
	void Start () {
		spawn ();	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
