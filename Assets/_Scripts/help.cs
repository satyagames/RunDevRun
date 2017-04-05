using UnityEngine;
using System.Collections;

public class help : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameControl.control.Save ();
	}
	
	// Update is called once per frame
	void Update () {
		Quit ();
	}
	public void Quit()
	{
		if (Application.platform == RuntimePlatform.Android) {
			
			if (Input.GetKeyUp(KeyCode.Escape)) {
				Application.Quit();
			}
		}
	}
	public void ContinueButton()
	{

		Application.LoadLevel ("MainMenu");
	}
}
