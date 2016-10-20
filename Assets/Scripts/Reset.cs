using UnityEngine;
using System.Collections;

public class Reset : MonoBehaviour {

	public AudioClip impact;
	public AudioSource aSource;

	void Start () {

		aSource = Camera.main.GetComponent<AudioSource> ();

	}
		
	void Update () {

	}


	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.CompareTag("Player"))
			aSource.PlayOneShot (impact);
			Application.LoadLevel(Application.loadedLevel);
	}
}