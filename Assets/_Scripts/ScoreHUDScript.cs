using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreHUDScript : MonoBehaviour {
	
	Text Scoretext;

	void Start () {
		Scoretext = GetComponent<Text> ();
	}
	void Update () {
		GameControl.control.score += Time.deltaTime;
		Scoretext.text = "X " + (int)GameControl.control.score * 50;
	}
	public void IncrementScore(int amount)
	{
		GameControl.control.score += amount;
	}
}
