using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class greenDiamondHUDScript : MonoBehaviour {

	Text GreenDiamondtext;
	
	void Start () {
		GreenDiamondtext = GetComponent<Text> ();
	}
	void Update () {
		GreenDiamondtext.text = "X " + (int)GameControl.control.greenDiamondScore ;
	}
}
