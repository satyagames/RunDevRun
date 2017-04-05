using UnityEngine;
using System.Collections;

public class powerUpScript : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.tag == "Player") {
			GameControl.control.score += 50;
			Destroy(this.gameObject);
		}
	}
}
