using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CoinsHUDScrpit : MonoBehaviour {

	Text Scoretext;
	
	void Start () {
		Scoretext = GetComponent<Text> ();
	}
	void Update () {
		Scoretext.text = "X " + (int)GameControl.control.coins ;
	}

}
