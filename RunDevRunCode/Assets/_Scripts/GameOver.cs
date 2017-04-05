using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

	public Text DevRuntext;
	public Text Moneybagtext;
	public Text RedDiamondtext;
	public Text GreenDiamondtext;
	public Text BlueDiamondtext;

	public Text TotalWorthofMoney;



	void Start () {
		//Scoretext = GetComponent<Text> ();
		//Scoretext.text = "Score : " + (int)GameControl.control.score * 100 + "\nCoins : " + (int)GameControl.control.coins ;
		//Scoretext.text = "Score : "+""+ (int)GameControl.control.score * 100;
		DevRuntext.text = "" +(int)GameControl.control.score * 50 + " Meters";
		Moneybagtext.text = "$ " +GameControl.control.coins.ToString();
		RedDiamondtext.text = "" +GameControl.control.redDiamondScore.ToString()+ " Carats";
		GreenDiamondtext.text = "" +GameControl.control.greenDiamondScore.ToString()+ " Carats";
		BlueDiamondtext.text = "" +GameControl.control.blueDiamondScore.ToString()+ " Carats";

		GameControl.control.TotalMoney = GameControl.control.coins + (GameControl.control.redDiamondScore * 2000) + (GameControl.control.greenDiamondScore* 1400) + (GameControl.control.blueDiamondScore* 700);

		TotalWorthofMoney.text = "$ " +GameControl.control.TotalMoney.ToString();

		GameControl.control.Save ();

	}
	void Update () {
		//Scoretext.text = "Score : " + (int)GameControl.control.score * 100 + "\nCoins : " + (int)GameControl.control.coins ;
	}
	public void RunAgain()
	{
		Application.LoadLevel ("continue");
	}

	public void HomeBtn()
	{
		Application.LoadLevel ("MainMenu");
	}




}

