using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour {
	public Movement mov;

	void OnTriggerEnter(Collider Coll){
		if (Coll.gameObject.layer == 8) {
			mov.grounded = true;
			mov.jump = mov.Jumpcount;
		}
	}


}
