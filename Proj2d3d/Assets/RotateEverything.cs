using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateEverything : MonoBehaviour {



	void Update () {
		if (Input.GetKey (KeyCode.Q)) {
			Vector3 variable = transform.forward;
			variable = new Vector3 (variable.x + 1f, variable.y, variable.z);
			transform.forward = variable;

		}
		if (Input.GetKey (KeyCode.E)) {
			Vector3 variable = transform.forward;
			variable = new Vector3 (variable.x - 1f, variable.y, variable.z);
			transform.forward = variable;
		}
	}


}
