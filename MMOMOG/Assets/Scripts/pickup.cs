using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickup : MonoBehaviour {

	public GameObject inventoryPanel;
	public GameObject[] inventoryIcons;

	void OnCollisionEnter(Collision collision)
	{
		foreach(Transform child in inventoryPanel.transform)
		{
			if(child.gameObject.tag == collision.gameObject.tag)
			{
				string c = child.Find ("Text").GetComponent<Text> ().text;
				int iconnumber = System.Int32.Parse (c) + 1;
				child.Find("Text").GetComponent<Text>().text = "" + iconnumber;
				return;
			}
		}

		GameObject i;
		if (collision.gameObject.tag == "1") {
			i = Instantiate (inventoryIcons [0]);
			i.transform.SetParent (inventoryPanel.transform);
		} else if (collision.gameObject.tag == "2") {
			i = Instantiate (inventoryIcons [1]);
			i.transform.SetParent (inventoryPanel.transform);
		} else if (collision.gameObject.tag == "3")	{
			i = Instantiate (inventoryIcons [2]);
			i.transform.SetParent (inventoryPanel.transform);
		}
	}
}