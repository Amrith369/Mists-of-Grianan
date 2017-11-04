using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AveraShop : MonoBehaviour {

	public float theDistance;
	//public GameObject ActionDisplay;
	public GameObject ActionText;
	public GameObject uiBuilding;
	public GameObject Player;

	
	// Update is called once per frame
	void Update () {
		
		theDistance = CharacterControl.distanceFromTarget;

		if (theDistance <= 1)
		{
			ActionText.SetActive(true);
			//ActionDisplay.SetActive(true);
		}

		if (Input.GetAxisRaw("Confirm") == 1)
		{
			if (theDistance <= 1)
			{
				//ActionDisplay.SetActive(false);
				ActionText.SetActive(false);
				SceneManager.LoadScene("AveraShop");
				Cursor.lockState = CursorLockMode.None;
				Player.SetActive (false);
				
			}
		}
	}
}
