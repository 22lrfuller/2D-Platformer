using UnityEngine;
using System.Collections;

public class PlatformFall : MonoBehaviour {

	public float fallDelay = 1f;
	public BoxCollider2D boxCo;
	public MeshRenderer meshRen;
	public SpriteRenderer sprRen;

	private Rigidbody2D rb2d;

	void Awake()
	{
		rb2d = GetComponent<Rigidbody2D>();
	}

	void OnCollisionEnter2D (Collision2D other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			Invoke ("Fall", fallDelay);
		}
	}

	void OnCollision2D (Collision2D other)
	{
		if (other.gameObject.CompareTag("DeathTrigger"))
		{
			Death ();
		}
	}

	void Fall()
	{
		rb2d.isKinematic = false;
	}

	void Death()
	{
		boxCo.enabled = false;
		meshRen.enabled = false;
		sprRen.enabled = false;
	}

}