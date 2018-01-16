using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetFour : MonoBehaviour {


	
	public int shared;

	void OnTriggerEnter2D(Collider2D Coll)
	{
		if (Coll.gameObject.layer == gameObject.layer)
		{
			if (Coll.gameObject.GetComponent<GetFour> ().shared > 0) {
				Coll.gameObject.GetComponent<GetFour> ().shared++;
			} else {
				shared++;
			}
		}
	}

	void OnTriggerExit2D(Collider2D Coll)
	{
		if (Coll.gameObject.layer == gameObject.layer)
		{
			if (Coll.gameObject.GetComponent<GetFour> ().shared > 0) {
				Coll.gameObject.GetComponent<GetFour> ().shared--;
			} else {
				shared--;
			}
		}
	}
}
