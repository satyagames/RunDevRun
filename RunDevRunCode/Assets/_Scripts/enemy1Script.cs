using UnityEngine;
using System.Collections;

public class enemy1Script : MonoBehaviour {
	//public GameObject hundredPointsUI;
	//public GameObject coinEffect;

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.tag == "Player") {
			//GameControl.control.redDiamondScore += 100;
			
			GameControl.control.lives = GameControl.control.lives - 1;
			
			Destroy(this.gameObject);
		}
	}
}
