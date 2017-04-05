using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class redDiamondHUDScript : MonoBehaviour {

	Text RedDiamondtext;
	
	void Start () {
		RedDiamondtext = GetComponent<Text> ();
	}
	void Update () {
		RedDiamondtext.text = "X " + (int)GameControl.control.redDiamondScore ;
	}
}
