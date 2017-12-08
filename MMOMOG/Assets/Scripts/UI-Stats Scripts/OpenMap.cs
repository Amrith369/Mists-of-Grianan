using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMap : MonoBehaviour {

	public GameObject map;
	public bool mapActive = false;
	public bool charActive = false;
	public GameObject characterScreen;

	public void ActiveMap()
	{
		if (mapActive == false) {
			map.SetActive (true);
			characterScreen.SetActive (false);
			mapActive = true;
		} 
		else if (mapActive == true) {
			map.SetActive (false);
			mapActive = false;
		}
	}

	public void ActiveChar()
	{
		if (charActive == false) {
			characterScreen.SetActive (true);
			map.SetActive (false);
			charActive = true;

		} 
		else if (charActive == true) {
			characterScreen.SetActive (false);
			charActive = false;
		}
	}
	
		
}
