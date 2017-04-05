using UnityEngine;
using System.Collections;
using com.microeyes.admob;

public class DestroyerScript : MonoBehaviour {
	public GameObject loadingImage;
	void OnTriggerEnter2D (Collider2D other)
	{

		if (other.tag == "Player")
		{


			StartCoroutine("ReloadGame");

			return;
		}
		if (other.gameObject.transform.parent)
		{
			Destroy(other.gameObject.transform.parent.gameObject);
		}
		else
		{
			Destroy (other.gameObject);
		}
	}

	IEnumerator ReloadGame()
	{

		Intestinal_Ad_Load ();



		yield return new WaitForSeconds (1);
		loadingImage.SetActive(true);
		yield return new WaitForSeconds (4);
		GameControl.control.lives = 5;
		Application.LoadLevel("GameOver");
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
