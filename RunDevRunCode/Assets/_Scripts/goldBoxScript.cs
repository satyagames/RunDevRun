using UnityEngine;
using System.Collections;

public class goldBoxScript : MonoBehaviour {
	public GameObject hundredPointsUI;
	public GameObject coinEffect;

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.tag == "Player") {
			GameControl.control.redDiamondScore += 100;
			
			// Create a vector that is just above the enemy.
			Vector3 scorePos;
			scorePos = transform.position;
			scorePos.y += 0.5f;
			//anim.SetBool("touchC", true);
			// Instantiate the 100 points prefab at this point.
			Instantiate(hundredPointsUI, scorePos, Quaternion.identity);
			
			Vector3 coinPos;
			coinPos = transform.position;
			coinPos.y += 1.5f;
			//anim.SetBool("touchC", true);
			// Instantiate the 100 points prefab at this point.
			Instantiate(coinEffect, coinPos, Quaternion.identity);
			
			Destroy(this.gameObject);
		}
	}
}
