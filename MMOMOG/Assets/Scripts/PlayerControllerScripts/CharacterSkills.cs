using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSkills : MonoBehaviour {

	public float lightDMG;
	public float heavyDMG;
	private float DMG;
	public GameObject Player;
	public float heavyTimer = 0f;
	public float heavyTimerMax = 0.5f;
	public float lightTimer = 0;
	public float lightTimerMax = 0.2f;
	public float comboX = 0f;
	public float comboY = 0f;
	public float comboTimer = 3f;
	public float comboTimerMin = 0;





	void Start () {

		lightDMG = (Player.GetComponent<CharacterStats> ().atk) * 1.8f;
		heavyDMG = (Player.GetComponent<CharacterStats> ().atk) * 36f;
		//GameObject.Find("Player").GetComponent<CharacterStats>().atk
	}


	void Update () {

		heavyTimer += Time.deltaTime;
		lightTimer += Time.deltaTime;

		//COMBO TIMER ============================================================
		if (comboX != 0 || comboY != 0) 
		{
			comboTimer -= Time.deltaTime;
			if (comboTimer <= comboTimerMin) 
			{
				comboX = 0;
				comboY = 0;
				comboTimer = 3;
			}
		}
		// NO DAMAGE DONE ==========================================================
		if (Input.GetAxisRaw ("LiteAtk") == 0 && Input.GetAxisRaw ("HevAtk") == 0) {
			DMG = 0;

		} 
		//HEAVY DAMAGE
		else if (Input.GetAxisRaw ("LiteAtk") == 0 && Input.GetAxisRaw ("HevAtk") == 1) {
			if (heavyTimer >= heavyTimerMax) 
			{
				DMG = heavyDMG;
				print ("Heavy Damage Dealt " + DMG);
				heavyTimer = 0;
				comboX += 1;
			}


		} 
		//LIGHT DAMAGE =============================================================
		else if (Input.GetAxisRaw ("LiteAtk") == 1 && Input.GetAxisRaw ("HevAtk") == 0) 
		{
			if (lightTimer >= lightTimerMax) 
			{
				DMG = lightDMG;
				print ("Light Damage Inflicted " + DMG);
				lightTimer = 0;
				comboY += 1;
			}


		}
		//COMBO 1 ==================================================================
		if (Input.GetAxisRaw ("Confirm") >=1 && comboX == 1 && comboY == 1) 
		{
			print ("Special 1 Activated!");
			comboX = 0;
			comboY = 0;
		}

	}
}
