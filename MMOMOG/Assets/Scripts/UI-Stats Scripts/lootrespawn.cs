using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lootrespawn : MonoBehaviour {

	public int respawntime = 5;

	void OnCollisionEnter()
	{
		this.GetComponent<SphereCollider> ().enabled = false;
		this.GetComponent<MeshRenderer> ().enabled = false;


		if (respawntime < 0) {
			Destroy (this.gameObject);
		} else {
			Invoke ("Respawn", respawntime);
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Respawn()
	{
		this.GetComponent<SphereCollider> ().enabled = true;
		this.GetComponent<MeshRenderer> ().enabled = true;
	}
}
