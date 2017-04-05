using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class GameControl : MonoBehaviour {

	public static GameControl control;

	public float score;
	public int coins;
	public int powerUps;

	public int redDiamondScore;
	public int greenDiamondScore;
	public int blueDiamondScore;

	public long TotalMoney;

	public int lives = 5;

	void Update()
	{
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
	void Awake()
	{
		if (control == null) {
			DontDestroyOnLoad (gameObject);
			control = this;
		}
		else if (control != this){
			Destroy(gameObject);
		}
	}

	void OnEnable() {
		Load ();
	}
	void OnDisable() {
		Save ();
	}
	public void Save()
	{
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create (Application.persistentDataPath + "/playerInfoDev.dat" );
		
		PlayerData data = new PlayerData();

		data.score = score;
		data.coins = coins;

		data.redDiamondScore = redDiamondScore;
		data.greenDiamondScore = greenDiamondScore;
		data.blueDiamondScore = blueDiamondScore;

		data.TotalMoney = TotalMoney;


		Debug.Log ("data Saved..."+Application.loadedLevelName);
		bf.Serialize (file, data);
		file.Close ();
	}
	public void Load()
	{
		if (File.Exists (Application.persistentDataPath + "/playerInfoDev.dat")) {
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Open (Application.persistentDataPath + "/playerInfoDev.dat", FileMode.Open);
			Debug.Log("file loads..."+Application.loadedLevelName);
			PlayerData data = (PlayerData)bf.Deserialize (file);
			file.Close ();


			score = data.score;
			coins = data.coins;

			redDiamondScore = data.redDiamondScore;
			greenDiamondScore = data.greenDiamondScore;
			blueDiamondScore = data.blueDiamondScore;

			TotalMoney = data.TotalMoney;

		} 
	}

}

[Serializable]
class PlayerData
{
	public float score;
	public int coins;
	public int powerUps;

	public int redDiamondScore;
	public int greenDiamondScore;
	public int blueDiamondScore;

	public long TotalMoney;
}
