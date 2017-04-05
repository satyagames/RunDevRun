using UnityEngine;
using System.Collections;

public class medicineScript : MonoBehaviour {
	//public GameObject hundredPointsUI;
	//public GameObject coinEffect;

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.tag == "Player") {

			if ( GameControl.control.lives <= 5 || GameControl.control.lives >= 1)
			{
				GameControl.control.lives += 1;
			}
			Destroy(this.gameObject);
		}
	}
}
