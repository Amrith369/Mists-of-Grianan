using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMap : MonoBehaviour {

	public GameObject map;
	public bool mapActive = false;

	public void ActiveMap()
	{
		if (mapActive == false) {
			map.SetActive (true);
			mapActive = true;
		} 
		else if (mapActive = true) {
			map.SetActive (false);
			mapActive = false;
		}
	}
		
}
