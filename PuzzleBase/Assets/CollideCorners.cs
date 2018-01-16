using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideCorners : MonoBehaviour {
		
	public bool Colliding = false;

	void OnTriggerEnter2D(Collider2D Coll)
	{
		if (Coll.gameObject.layer == gameObject.layer)
		{
			Colliding = true;
		}
	}

	void OnTriggerStay2D(Collider2D Coll)
	{
		if (Coll.gameObject.layer == gameObject.layer)
		{
			Colliding = true;
		}
	}

	void OnTriggerExit2D(Collider2D Coll)
	{
		if (Coll.gameObject.layer == gameObject.layer)
		{
			Colliding = false;
		}
	}

}
