using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour {

	public int weaponType;


	public class Knuckle 
	{
		CharacterStats stat = new CharacterStats ();
		void Update ()
		{
			stat.atk *= 1.1f;
			stat.spd *= 1.5f;
			stat.def /= 1.4f;
			stat.vit *= 1.3f;
			stat.critChance *= 10f;
		}
		
	}

	public class Spear
	{
		CharacterStats stat = new CharacterStats ();
		void Update ()
		{
			stat.atk *= 2.1f;
			stat.spd *= 1.4f;
			stat.def /= 1.1f;
			stat.vit *= 1.1f;
			stat.critChance *= 16f;
		}
	}

	public class Sword
	{
		CharacterStats stat = new CharacterStats ();
		void Update ()
		{
			stat.atk *= 2.2f;
			stat.spd *= 1.2f;
			stat.def *= 1.1f;
			stat.vit *= 1.1f;
			stat.critChance *= 8;
		}
	}

	public class Greatsword
	{
		CharacterStats stat = new CharacterStats ();
		void Update ()
		{
			stat.atk *= 4f;
			stat.spd /= 1.6f;
			stat.def *= 1.2f;
			stat.vit *= 1.8f;
			stat.critChance *= 10f;
		}
	}

	public class Magic
	{
		CharacterStats stat = new CharacterStats ();
		void Update ()
		{
			stat.atk *= 3.8f;
			stat.spd *= 1.2f;
			stat.def /= 1.6f;
			stat.vit /= 1.2f;
			stat.critChance *= 14f;
		}
	}

	public class Hammer
	{
		CharacterStats stat = new CharacterStats ();
		void Update ()
		{
			stat.atk *= 4.2f;
			stat.spd /= 1.4f;
			stat.def /= 1.1f;
			stat.vit *= 1.6f;
			stat.critChance *= 12f;
		}
	}

	public class Shield
	{
		CharacterStats stat = new CharacterStats ();
		void Update ()
		{
			stat.atk *= 1.1f;
			stat.spd /= 1.2f;
			stat.def *= 4f;
			stat.vit *= 4f;
			stat.critChance *= 1.1f;
		}
	}

	public class Bow
	{
		CharacterStats stat = new CharacterStats ();
		void Update ()
		{
			stat.atk *= 2.2f;
			stat.spd *= 1.6f;
			stat.def /= 1.2f;
			stat.vit /= 1.1f;
			stat.critChance *= 20f;
		}
	}

	public class Knife
	{
		CharacterStats stat = new CharacterStats ();
		void Update ()
		{
			stat.atk *= 1.9f;
			stat.spd *= 1.8f;
			stat.def /= 1.9f;
			stat.vit /= 2.1f;
			stat.critChance *= 18f;
		}
	}
}
