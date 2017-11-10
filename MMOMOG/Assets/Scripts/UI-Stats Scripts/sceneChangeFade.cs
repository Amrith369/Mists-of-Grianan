﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;


public class sceneChangeFade : MonoBehaviour {

	public GameObject settingsMenu;
	public GameObject mainMenu;
	public GameObject fade;
	public string targetScene;
	public byte alpha = 0;
	public float fadeTime = 0f;
	public bool countDown = false;

	public void Update ()
	{
		if (countDown == true) 
		{
			Fade ();
		}
	}

	public void Fade()
	{
		fade.SetActive (true);
		Color color;

		if (fadeTime <= 10f) {
			fadeTime += Time.deltaTime;
			color = new Color32 (0, 0, 0, alpha);
			alpha += 5;
		} 
		else if (fadeTime >= 10f) 
		{
			fadeTime = 0f;
			countDown = false;
			SceneManager.LoadScene (targetScene);
		}

	}

	public void Avera()
	{
		countDown = true;
	}
	public void AveraWoodland()
	{
		SceneManager.LoadScene("AveraWoodland");
	}
	public void AveraDungeon()
	{
		SceneManager.LoadScene("AveraDungeon");
	}

	public void AveraWarf()
	{
		SceneManager.LoadScene("AveraWarf");
	}

	public void ExitGame()
	{
		SceneManager.LoadScene("Title 1");
	}

	public void QuitGame()
	{
		Application.Quit();
		//print("GAME QUIT");
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
