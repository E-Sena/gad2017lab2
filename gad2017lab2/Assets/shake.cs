using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class shake : MonoBehaviour {

	public float maxSpeed = 3;
	bool facingRight;
	public float velocity=3f;

	void FixedUpdate () 
	{
		float move = Input.GetAxis ("Horizontal");

		rigidbody2D.velocity = new Vector2 (move * maxSpeed, rigidbody2D.velocity.y);

		if (move > 0 && !facingRight)
			Flip ();
		else if (move < 0 && facingRight)
			Flip();
	}

	void Flip()
	{
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}