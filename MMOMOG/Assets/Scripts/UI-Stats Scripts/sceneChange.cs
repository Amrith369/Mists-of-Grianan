using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class sceneChange : MonoBehaviour {

	public GameObject settingsMenu;
	public GameObject mainMenu;

	public void NextScene()
	{
		SceneManager.LoadScene("FieldOfBeginnings");
	}

	public void ExitGame()
	{
		SceneManager.LoadScene("Title 1");
	}

	public void QuitGame()
	{
		Application.Quit();
		print("GAME QUIT");
	}

	public void SettingsScreen()
	{
		mainMenu.SetActive (false);
		settingsMenu.SetActive (true);
	}

	public void SettingsScreenBack()
	{
		mainMenu.SetActive (true);
		settingsMenu.SetActive (false);
	}

}
