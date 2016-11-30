using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Coin : MonoBehaviour {

	public SpriteRenderer sprRen;
	public Collider2D col;
	public AudioClip impact;
	public AudioSource aSource;
	public GameObject txtObj;
	public Text countText;
	public coinStorage storageRef;

	private int count;

	void OnEnable() {

		sprRen = GetComponent<SpriteRenderer>();
		col = GetComponent<CircleCollider2D>();
		StartCoroutine (afterStart());
		countText = GameObject.Find ("Text").GetComponent<Text> ();
		storageRef = GameObject.Find ("Text").GetComponent<coinStorage> ();

	}

	IEnumerator afterStart(){

		yield return new WaitForSeconds (.1f);
		aSource = Camera.main.GetComponent<AudioSource> ();
		count = 0;
		SetCountText ();

	}
		

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.CompareTag("Player")){
			aSource.PlayOneShot (impact);
			col.enabled = false;
			sprRen.enabled = false;
			storageRef.coinTotal += 1;
			count = storageRef.coinTotal;
			SetCountText();
		}
	}

	public void SetCountText ()
	{
		countText.text = "Coin: " + count.ToString ();
	}
}