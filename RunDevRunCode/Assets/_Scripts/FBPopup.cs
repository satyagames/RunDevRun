using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class FBPopup : MonoBehaviour {
	public Canvas FBCanvas;
	// Use this for initialization
	void Start () {
		FBCanvas = GetComponent<Canvas>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void CloseBtn()
	{
		FBCanvas.enabled = false;
	}
	public void ScoreShareBtn()
	{
		Application.OpenURL ("https://www.facebook.com/dialog/feed?app_id=145634995501895&display=popup&caption=Let's play Run Dev Run..!&description=Play this awesome game for fun&link=http://www.zopy.in&picture=http://gamezden.com/games/images/Dragon-Street.png&redirect_uri=http://www.facebook.com");
	}
}
