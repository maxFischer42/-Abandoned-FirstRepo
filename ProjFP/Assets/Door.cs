using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

	private bool door;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (door) {
			gameObject.transform.Translate (0, -0.01f, 0);
		}
	}

	public void Open()
	{
		door = true;
	}
}
