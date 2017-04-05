using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]
public class coinScript : MonoBehaviour {

	public GameObject hundredPointsUI;
	public GameObject coinEffect;

	//public GameObject coinSoundObject;
	//AudioSource boom_audiosource;

	//public AudioSource source;
	//public AudioClip clips;

	public AudioClip impact;
	void Awake()
	{
		//boom_audiosource = GameObject.Find("coinSoundObject").GetComponent<AudioSource>();
		//gameObject.audio.enabled = false;
	}
	void Start()
	{
		//gameObject.audio.enabled = true;
	}
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.tag == "Player") {
			//gameObject.audio.enabled = true;
			GameControl.control.coins += 100;
			//audio.PlayOneShot(impact);
			//audio.Play(44100);
			//coinSoundObject.audio.enabled = true;
			//boom_audiosource.Play();
			//coinSoundObject.audio.Play();
			//boom_audiosource.PlayClipAtPoint(coinSoundObject, transform.position);
			// Create a vector that is just above the enemy.
			Vector3 scorePos;
			scorePos = transform.position;
			scorePos.y += 0.5f;
			//anim.SetBool("touchC", true);
			// Instantiate the 100 points prefab at this point.
			Instantiate(hundredPointsUI, scorePos, Quaternion.identity);
			
			Vector3 coinPos;
			coinPos = transform.position;
			coinPos.y += 1.5f;
			//anim.SetBool("touchC", true);
			// Instantiate the 100 points prefab at this point.
			Instantiate(coinEffect, coinPos, Quaternion.identity);

			Destroy(this.gameObject);
		}
	}

}
