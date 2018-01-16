using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
	public float speed = 1.5f;
	public bool grounded;
	public int Jumpcount = 1;
	public int jump = 1;
	public float jumpSpeed = 2.0f;



	// Update is called once per frame
	void Update () {
		
		var rig = GetComponent<Rigidbody> ();
		var vel = rig.velocity;
		float x = Input.GetAxis ("Horizontal");
		Vector3 MoveMent = new Vector3 (vel.x, vel.y, speed * x);
		rig.velocity = MoveMent;

		if (grounded && Input.GetAxis ("Jump") > 0|| jump > 0 && Input.GetAxis ("Jump") > 0) {
			rig.velocity = new Vector3 (vel.x, jumpSpeed, vel.z);
			jump--;
			grounded = false;
		}
	}


}
