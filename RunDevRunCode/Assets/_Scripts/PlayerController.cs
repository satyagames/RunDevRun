using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using com.microeyes.admob;

public class PlayerController : MonoBehaviour {

	public float moveSpeed = 1.2f;
	bool grounded = false;
	public Transform groundCheck;
	float groundRadius = 0.2f;
	public LayerMask whatISGround;
	public float jumpForce = 300f;
	bool jump = false;
	bool doubleJump = false;
	Animator anim;

	public Slider healthSlider;
	bool herodead;

	public GameObject loadingImage;

	public void Awake()
	{

	}

	void Start () {
		anim = GetComponent	<Animator> ();
	}
	

	void FixedUpdate () {

		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatISGround);
		anim.SetBool("Ground",grounded);
		//anim.SetFloat ("vSpeed", rigidbody2D.velocity.y);
		if (grounded == true) {
			doubleJump = false;		
		}

		rigidbody2D.velocity = new Vector2 (moveSpeed, rigidbody2D.velocity.y);
	}
	void Update()
	{
		if (Input.GetKeyDown (KeyCode.Space)) {
			jump = true;
			//TouchMob.jump = true;
		}

		if ((grounded || !doubleJump) /*&& TouchMob.jump*/ && jump && !herodead) {
			jump = false;
			TouchMob.jump = false;
			anim.SetBool("Ground", false);
			rigidbody2D.AddForce( new Vector2 (0, jumpForce)); 
			if (!doubleJump && !grounded ){
				doubleJump = true;
			}
		}

		healthSlider.value = GameControl.control.lives;
		
		if (GameControl.control.lives == 0) {
			GameControl.control.lives = -1;
			//audio.Play();
			moveSpeed = 0f;
			StartCoroutine("ReloadGame");
		}


	}
	IEnumerator ReloadGame()
	{

		Intestinal_Ad_Load ();




		moveSpeed = 0f;
		jump = false;
		anim.SetBool ("Death", true);
		yield return new WaitForSeconds (2);
		loadingImage.SetActive(true);
		yield return new WaitForSeconds (5);
		GameControl.control.lives = 5;
		Application.LoadLevel ("GameOver");
		
	}
	public void JumpBtnClick()
	{
		audio.Play ();
		jump = true;
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
