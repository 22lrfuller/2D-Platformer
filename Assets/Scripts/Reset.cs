using UnityEngine;
using System.Collections;

public class Reset : MonoBehaviour {

	void Start () {

	}
		
	void Update () {

	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.CompareTag("Player"))
			Application.LoadLevel(Application.loadedLevel);
	}
}