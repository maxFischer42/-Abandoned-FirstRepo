using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public Rigidbody Box;
	public float speed;
	public GameObject target;
	void Update()
	{
		var x = Input.GetAxis("Mouse X") * Time.deltaTime * 150.0f;
		var y = Input.GetAxis ("Horizontal") * Time.deltaTime * 2.0f;
		var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

		transform.Rotate(0, x, 0);
		transform.Translate(y, 0, z);



		if (Input.GetAxis("Cancel") > 0) {
			Screen.lockCursor = false;
			//transform.SetPositionAndRotation (transform.position, Quaternion.identity);
			//GetComponent<Rigidbody> ().velocity = new Vector3(0,0,0);
		} else {
			Screen.lockCursor = true;
		}
	
	
	}
}
