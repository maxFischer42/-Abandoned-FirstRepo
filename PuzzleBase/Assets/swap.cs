using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swap : MonoBehaviour {

	public GameObject[] Coll;
	public bool colling;

	void Start()
	{
		PlayerPrefs.SetString ("Selected", "");
		PlayerPrefs.SetInt ("Setting", 0);
	}


	void Update()
	{
		if (colling != true) {

			for (int i = 0; i <= Coll.Length - 1; i++) {
				colling = Coll [i].GetComponent<CollideCorners> ().Colliding;
				if (colling)
					Debug.Log ("deb");
					return;
			}
		}
	}




	public void check()
	{
		if (colling) {
			if (PlayerPrefs.GetInt ("Setting") == 1) {
				selectSecond ();
			} else {
				selectOne ();
			}
		}
	}





	public void selectOne()
	{
		PlayerPrefs.SetString ("Selected", gameObject.name);
		PlayerPrefs.SetInt ("Setting", 1);
	}






	public void selectSecond()
	{
		Vector3 newPos = transform.position;
		Vector3 oldPos = GameObject.Find (PlayerPrefs.GetString ("Selected")).GetComponent<Transform>().position;
		transform.SetPositionAndRotation (oldPos, Quaternion.identity);
		GameObject.Find (PlayerPrefs.GetString ("Selected")).GetComponent<Transform>().SetPositionAndRotation (newPos, Quaternion.identity);
		PlayerPrefs.SetString ("Selected", "null");
		PlayerPrefs.SetInt ("Setting", 0);
	}






}
