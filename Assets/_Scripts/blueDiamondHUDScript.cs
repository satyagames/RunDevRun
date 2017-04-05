using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class blueDiamondHUDScript : MonoBehaviour {

	Text BlueDiamondtext;
	
	void Start () {
		BlueDiamondtext = GetComponent<Text> ();
	}
	void Update () {
		BlueDiamondtext.text = "X " + (int)GameControl.control.blueDiamondScore ;
	}
}
