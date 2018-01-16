using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour {

	public GridStategyGame Grid;
	public Canvas Menu;
	public string Tag = "Mouse";

	private bool mouseOver = false;
	private bool alreadySelected = false;
	public GameObject[] boxes;
	public bool isBoxNotObject = false;


	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update ()
	{
		if (isBoxNotObject != true) {
			if (alreadySelected != true) {
				if (mouseOver && Input.GetAxis ("Fire1") > 0) {
					alreadySelected = true;
				}
			} else {
				for (int i = 0; i <= boxes.Length - 1; i++) {
					boxes [i].SetActive (true);
				}




			}
		} else {
			if (mouseOver && Input.GetAxis ("Fire1") > 0) {
				Grid.moveObject (transform.parent.gameObject, gameObject.transform);
			}
		}
	}

	void OnTriggerEnter2D(Collider2D Coll)
	{
		if (Coll.gameObject.tag == Tag) {
			mouseOver = true;
			Debug.Log ("enter");
		}
	}

	void OnTriggerStay2D(Collider2D Coll)
	{
		if (Coll.gameObject.tag == Tag) {
			mouseOver = true;
			Debug.Log ("stay");
		}
	}

	void OnTriggerExit2D(Collider2D Coll)
	{
		if (Coll.gameObject.tag == Tag) {
			mouseOver = false;
			Debug.Log ("exit");
		}
	}

}
