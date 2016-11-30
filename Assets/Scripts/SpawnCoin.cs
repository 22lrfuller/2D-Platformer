using UnityEngine;
using System.Collections;

public class SpawnCoin : MonoBehaviour {

	public Transform[] coinSpawns;
	public GameObject coin;

	void Start () {

		StartCoroutine (afterStart());

	}

	IEnumerator afterStart(){

		yield return new WaitForSeconds(.2f);
		Spawn ();

	}

	void Spawn()
	{
		for (int i = 0; i < coinSpawns.Length; i++)
		{
			int coinFlip = Random.Range (0, 3);
			if (coinFlip < 1)
				Instantiate(coin, coinSpawns[i].position, Quaternion.identity);
		}
	}
}