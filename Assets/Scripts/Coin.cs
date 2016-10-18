using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

	public SpriteRenderer sprRen;
	public Collider2D col;
	public AudioClip impact;
	public AudioSource aSource;


	void Start () {

		sprRen = GetComponent<SpriteRenderer>();
		col = GetComponent<CircleCollider2D>();
		StartCoroutine (afterStart());

	}

	IEnumerator afterStart(){

		yield return new WaitForSeconds (.3f);
		aSource = Camera.main.GetComponent<AudioSource> ();

	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.CompareTag("Player")){
			aSource.PlayOneShot (impact);
			col.enabled = false;
			sprRen.enabled = false;
		}
	}
}