using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StoryContinue : MonoBehaviour {

	public Scrollbar sb;
	float temp_value = 1.0f;

	void Start(){
		GameControl.control.Save ();
	}
	public void ContinueBtn()
	{

		Application.LoadLevel ("MainMenu");
		Debug.Log ("clcikkkk");
	}
	public void Quit()
	{
		if (Application.platform == RuntimePlatform.Android) {
			
			if (Input.GetKeyUp(KeyCode.Escape)) {
				Application.Quit();
			}
		}
	}
	void Update () {
		Quit ();
		Debug.Log (temp_value);
		if ( Application.loadedLevelName == "Story" )
		{
			sb.value = temp_value;
			if (temp_value <= 0.0f) {
				temp_value = 1.0f;		
			} else 
			{
				temp_value -= 0.0005f;
			}
		}
	}
}
