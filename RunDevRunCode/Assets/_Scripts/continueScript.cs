using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using com.microeyes.admob;
public class continueScript : MonoBehaviour {

	public Canvas FBCanvas;
	public Canvas AchivCanvas;
	public Text DisplayText;

	public Text Millionaire;
	public Text Billionaire;
	public Text Trillionaire;
	public Text Quadrillionaire;
	public Text Quintillionaire;
	public Text Sextillionaire;
	public Text Septillionaire;
	public Text Octillionaire;
	public Text Nonillionaire;
	public Text Decillionaire;
	public Text Undecillionaire;
	public Text Duodecillionaire;

	// Use this for initialization
	void Start () {
		TaskChack ();
		AchivCanvas.enabled = false;
		RemainingAmountCalculations ();
		TaskChack();
	}
	void RemainingAmountCalculations()
	{
		if (GameControl.control.TotalMoney < 1000000)	//6 
		{
			DisplayText.text = "YOU HAVE JUST $ "+(1000000 - GameControl.control.TotalMoney )+" TO BECAME A Millionaire."; // 6 
		}

		if (GameControl.control.TotalMoney < 1000000000 && GameControl.control.TotalMoney >= 1000000) // 9 - 6
		{
			DisplayText.text = "YOU HAVE JUST $ "+(1000000000 - GameControl.control.TotalMoney )+" TO BECAME A Billionaire."; //9
		}

		if (GameControl.control.TotalMoney < 1000000000000 && GameControl.control.TotalMoney >= 1000000000) // 12 - 9
		{
			DisplayText.text = "YOU HAVE JUST $ "+(1000000000000 - GameControl.control.TotalMoney )+" TO BECAME A Trillionaire.";	//12
		}

		if (GameControl.control.TotalMoney < 1000000000000000 && GameControl.control.TotalMoney >= 1000000000000) // 15 - 12
		{
			DisplayText.text = "YOU HAVE JUST $ "+(1000000000000000 - GameControl.control.TotalMoney )+" TO BECAME A Quadrillionaire.";//15
		}

		if (GameControl.control.TotalMoney < 1000000000000000 && GameControl.control.TotalMoney >= 1000000000000000000) // 15 - 18
		{
			DisplayText.text = "YOU HAVE JUST $ "+(1000000000000000000 - GameControl.control.TotalMoney )+" TO BECAME A Quintillionaire.";//18
		}

		/*if (GameControl.control.TotalMoney < 1000000000000000000 && GameControl.control.TotalMoney >= 1000000000000000000000) // 18 - 21
		{
			DisplayText.text = "YOU HAVE JUST $ "+(1000000000000000000000 - GameControl.control.TotalMoney )+" TO BECAME A Sextillionaire.";//21
		}*/


	}
	void TaskChack()
	{
		if (GameControl.control.TotalMoney >= 1000000) //6
		{
			Millionaire.text = "Completed";	
		}
		if (GameControl.control.TotalMoney >= 1000000000) //9
		{
			Billionaire.text = "Completed";	
		}
		if (GameControl.control.TotalMoney >= 1000000000000) //12
		{
			Trillionaire.text = "Completed";	
		}
		if (GameControl.control.TotalMoney >= 1000000000000000) //15
		{
			Quadrillionaire.text = "Completed";	
		}
		if (GameControl.control.TotalMoney >= 1000000000000000000) //18
		{
			Quintillionaire.text = "Completed";	
		}
		/*if (GameControl.control.TotalMoney >= 1000000000000000000000) //21
		{
			Sextillionaire.text = "Completed";	
		}
		if (GameControl.control.TotalMoney >= 1000000000000000000000000) //24
		{
			Septillionaire.text = "Completed";	
		}
		if (GameControl.control.TotalMoney >= 1000000000000000000000000000) //27
		{
			Octillionaire.text = "Completed";	
		}
		if (GameControl.control.TotalMoney >= 1000000000000000000000000000000) //30
		{
			Nonillionaire.text = "Completed";	
		}
		if (GameControl.control.TotalMoney >= 1000000000000000000000000000000000) //33
		{
			Decillionaire.text = "Completed";	
		}
		if (GameControl.control.TotalMoney >= 1000000000000000000000000000000000000) //36
		{
			Undecillionaire.text = "Completed";	
		}
		if (GameControl.control.TotalMoney >= 1000000000000000000000000000000000000000) //39
		{
			Duodecillionaire.text = "Completed";	
		}*/
	}
	// Update is called once per frame
	void Update () {
	
	}
	public void TasksButton()
	{
		AchivCanvas.enabled = true;
	}
	public void ContinueButton()
	{
		Application.LoadLevel ("c1");
		//FBCanvas.enabled = true;
	}

	public void CloseBtn()
	{
		FBCanvas.enabled = false;



		Intestinal_Ad_Show ();



	}
	public void Achive_CloseBtn()
	{
		AchivCanvas.enabled = false;
	}
	public void ScoreShareBtn()
	{
		Application.OpenURL ("https://www.facebook.com/dialog/feed?app_id=145634995501895&display=popup&caption=Let's play Run Dev Run..!&description=I Got $ "+GameControl.control.TotalMoney+" . If you want to Earn Money, Gold and Diamonds. Go and Play Run Dev Run at PlayStore and AppStore&link=https://play.google.com/store/apps/details?id=zopygames.com.rundevrun&picture=http://www.zopy.in/apk/images/100x100.png&redirect_uri=http://www.facebook.com");
		FBCanvas.enabled = false;
	}

	public void HomeBtn()
	{
		Application.LoadLevel ("MainMenu");
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
