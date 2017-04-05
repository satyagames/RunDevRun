using UnityEngine;
using System.Collections;
using com.microeyes.admob;
public class TouchMob : MonoBehaviour {
	
	private Vector3 ffp; //First finger position
	private Vector3 lfp; //Last finger position
	public float dragDistance;  //Distance needed for a swipe to register
	public static bool jump = false;
	IEnumerator conn()
	{
		yield return new WaitForSeconds (0.2f);
		Application.LoadLevel ("MainMenu");
	}

	void Update()
	{

		//Examine the touch inputs
		foreach (Touch touch in Input.touches)
		{
			if (touch.phase == TouchPhase.Began)
			{
				ffp = touch.position;
				lfp = touch.position;
			}
			if (touch.phase == TouchPhase.Moved)
			{
				lfp = touch.position;
			}
			if (touch.phase == TouchPhase.Ended)
			{
				//First check if it's actually a drag
				if (Mathf.Abs(lfp.x - ffp.x) > dragDistance || Mathf.Abs(lfp.y - ffp.y) > dragDistance)
				{   //It's a drag
					//Now check what direction the drag was
					//First check which axis
					if (Mathf.Abs(lfp.x - ffp.x) > Mathf.Abs(lfp.y - ffp.y))
					{   //If the horizontal movement is greater than the vertical movement...
						if (lfp.x>ffp.x)  //If the movement was to the right
						{   
							Debug.Log("horizontal MOVE RIGHT");
						}
						else
						{   
							Debug.Log("horizontal MOVE LEFT");
						}
					}
					else
					{   //the vertical movement is greater than the horizontal movement
						if (lfp.y>ffp.y)  //If the movement was up
						{   
							Debug.Log("vertical MOVE up");
						}
						else
						{   
							Debug.Log("vertical MOVE down");
						}
					}
				}
				else
				{   
					Debug.Log("just tap");
					jump = true;
				}
				
			}
		}
}

	public void Intestinal_Ad_Create () {
		InterstitialAd l_interAd = AdmobManager.PrepareInterstitialAd("Interstitial_1");
		l_interAd.AdUnitId = "ca-app-pub-6065714673957825/3190160868";
		l_interAd.Create();
	}
	public void Intestinal_Ad_Load () {
		InterstitialAd l_interAd = AdmobManager.Get<InterstitialAd>("Interstitial_1");
		l_interAd.Load();
	}
	public void Intestinal_Ad_Show () {
		InterstitialAd l_interAd = AdmobManager.Get<InterstitialAd>("Interstitial_1");
		l_interAd.Show();
	}
	void Awake()
	{
		Intestinal_Ad_Create ();
		BannerAd l_newBanner = AdmobManager.Prepare<BannerAd>("Banner-1");
		l_newBanner.AdUnitId = "ca-app-pub-6065714673957825/3329761668";
		//l_newBanner.SetPosition(EPosition.CENTER_HORIZONTAL, EPosition.TOP);
		
		l_newBanner.BannerType = EBannerAdType.BANNER;
		l_newBanner.Orientation = EOrientation.HORIZONTAL;
		l_newBanner.AnimInType = EAnimationInType.FADE_IN;
		l_newBanner.AnimOutType = EAnimationOutType.SLIDE_OUT_RIGHT;
		l_newBanner.SetPosition(EPosition.CENTER, EPosition.BOTTOM);
		
		l_newBanner.Create();
		
		l_newBanner.Load();
	}
	void Start()
	{
		StartCoroutine("conn");
	}
}
