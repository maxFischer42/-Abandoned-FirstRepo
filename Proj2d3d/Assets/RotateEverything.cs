using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateEverything : MonoBehaviour {



	void Update () {
		if (Input.GetKey (KeyCode.Q)) {
			transform.Rotate (0, 1, 0);

		}
		if (Input.GetKey (KeyCode.E)) {
			transform.Rotate (0, -1, 0);
		//	transform.rotation = Quaternion.LookRotation(new Vector3(0,0,transform.GetChild(0).GetComponent<Movement>().speed));
		}
	}


}
