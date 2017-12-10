﻿using UnityEngine;
using System.Collections;

public class followCamera : MonoBehaviour
{
	public GameObject player;
	public float distance;
	public float speed;
	public Vector3 velocity;

	private bool z;

	void Update ()
	{
		float dist = Vector3.Distance (player.transform.position, transform.position);

		Vector3 behind = player.transform.position - new Vector3 (player.transform.forward.x * distance, player.transform.forward.y - 1.0f, player.transform.forward.z * distance);

		if(!z && Input.GetButton("Horizontal"))
		{
			z = true;
		}
		else if(z)
		{
			transform.LookAt(player.transform);

			transform.position = Vector3.SmoothDamp(transform.position, behind, ref velocity, Time.deltaTime);
			print ("1");

			if(transform.position == behind)
			{
				z = false;
			}
		}
		else
		{
			if (dist < distance)
			{
				transform.LookAt(player.transform);
			}
			else if (dist > distance * 2)
			{
				transform.LookAt(player.transform);
				transform.position = Vector3.SmoothDamp(transform.position, behind, ref velocity, Time.deltaTime * 2);

				//transform.position = Vector3.MoveTowards(transform.position, new Vector3(player.transform.position.x, player.transform.position.y + 1.0f, player.transform.position.z - distance), speed * 30 * Time.deltaTime / 1000);
				//print ("2");
			}
			else if (dist < distance * 2 && dist > distance)
			{
				transform.LookAt(player.transform);

				transform.position = Vector3.MoveTowards(transform.position, new Vector3(player.transform.position.x, player.transform.position.y + 1.0f, player.transform.position.z - distance), speed * Time.deltaTime / 1000);
				print ("3");
			}
		}
	}
}