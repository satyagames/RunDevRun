using UnityEngine;
using System.Collections;
using com.microeyes.admob;
public class Social : MonoBehaviour {

	public GameObject loadingImage;
	void Start()
	{
		/*BannerAd l_newBanner = AdmobManager.Prepare<BannerAd>("Banner-1");
		l_newBanner.AdUnitId = "ca-app-pub-6065714673957825/3329761668";
		//l_newBanner.SetPosition(EPosition.CENTER_HORIZONTAL, EPosition.TOP);
		
		l_newBanner.BannerType = EBannerAdType.BANNER;
		l_newBanner.Orientation = EOrientation.HORIZONTAL;
		l_newBanner.AnimInType = EAnimationInType.FADE_IN;
		l_newBanner.AnimOutType = EAnimationOutType.SLIDE_OUT_RIGHT;
		l_newBanner.SetPosition(EPosition.CENTER, EPosition.BOTTOM);
		
		l_newBanner.Create();
		
		l_newBanner.Load();*/
	}
	public void play_btn()
	{
		loadingImage.SetActive(true);
		Application.LoadLevel("c1");



		//Intestinal_Ad_Create ();



	}
	public void story_btn()
	{
		Application.LoadLevel("Story");
		//GameControl.control.Load ();
	}
	public void help_btn()
	{
		Application.LoadLevel("Help");
		//GameControl.control.Load ();
	}
	public void FBShare(){
		Application.OpenURL ("https://www.facebook.com/dialog/feed?app_id=145634995501895&display=popup&caption=Let's play Run Dev Run..!&description=Play this awesome game for fun&link=https://play.google.com/store/apps/details?id=zopygames.com.rundevrun&picture=http://www.zopy.in/apk/images/100x100.png&redirect_uri=http://www.facebook.com");
		GameControl.control.score = GameControl.control.score + 1000;
	}
	public void GPLUSShare(){
		Application.OpenURL ("https://plus.google.com/share?url=https://play.google.com/store/apps/details?id=zopygames.com.rundevrun");
		GameControl.control.score = GameControl.control.score + 1000;
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
	
	IEnumerator Intestinal_Ad() {
		Intestinal_Ad_Create ();
		yield return new WaitForSeconds(2);
		Intestinal_Ad_Load ();
		yield return new WaitForSeconds(3);
		Intestinal_Ad_Show ();
		Intestinal_Ad_Show ();
	}
}
