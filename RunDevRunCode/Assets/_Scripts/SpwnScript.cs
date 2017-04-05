using UnityEngine;
using System.Collections;

public class SpwnScript : MonoBehaviour {

	public GameObject[] obj;
	public float spanMin = 3f;
	public float spanMax = 6f;
	// Use this for initialization
	void Start () {
		Spawn ();
	}
	
	void Spawn()
	{
		Instantiate (obj [Random.Range (0, obj.Length)], transform.position, Quaternion.identity);
		Invoke ("Spawn", Random.Range (spanMin , spanMax));
	}
}
