using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridStategyGame : MonoBehaviour {

	public GameObject[] whiteTeamPieces;
	public GameObject[] blackTeamPieces;

	public Vector2 whiteStart = new Vector2(0.5f,0.5f);
	public Vector2 blackStart = new Vector2(0.5f,0.5f);

	public bool selectObject = true;
	public bool selecting = false;

	//white = false
	//black = true
	public bool turn = false;

	void Start()
	{
		float x = whiteStart.x;
		float y = whiteStart.y;
		for( int i = 0; i <= whiteTeamPieces.Length - 1; i++)
		{
			PlacePiece (whiteTeamPieces [i], new Vector2 (x, y));
			x++;
			if (x > whiteStart.x + 9) {
				x = whiteStart.x;
				y++;
			}
		}



		x = blackStart.x;
		y = blackStart.y;
		for( int i = 0; i <= blackTeamPieces.Length - 1; i++)
		{
			PlacePiece (blackTeamPieces [i], new Vector2 (x, y));
			x++;
			if (x > blackStart.x + 9) {
				x = blackStart.x;
				y--;
			}
		}
			
	}




	// Update is called once per frame
	void Update ()
	{


		if (turn != true)
		{
			selectObject = true;
		}



	}



	private void PlacePiece
	(GameObject Piece, Vector2 Location)
	{
		Instantiate (Piece, Location, Quaternion.identity);
	}



	public void moveObject(GameObject Piece, Transform TileClicked)
	{
		if (turn == false && selectObject) {
			Vector3.MoveTowards (Piece.transform.position, TileClicked.position, 1f);

			Renderer rend = Piece.GetComponent<Renderer> ();
			rend.material.shader = Shader.Find ("Specular");
			rend.material.SetColor ("_SpecColor", Color.grey);
			GameObject[] boxes = Piece.GetComponent<MoveObject> ().boxes;
			for (int i = 0; i <= boxes.Length - 1; i++) {
				boxes [i].SetActive (false);
			}
		}

	}




}
