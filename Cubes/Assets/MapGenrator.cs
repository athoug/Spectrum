using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenrator : MonoBehaviour {


	public Transform tilePrefab;
	public Vector2 mapSize;
	[Range(0,1)]
	public float outline;

	public void GenrateMap(){

		for( int x = 0; x< mapSize.x; x++){
			for( int y = 0; y< mapSize.y ;y++){

				Vector3 TilePos = new Vector3(-mapSize.x/2 + 0.5f + x, 1, -mapSize.y/2 + 0.5f + y);
				Transform newTile = Instantiate( tilePrefab, TilePos, Quaternion.identity) as Transform;
				newTile.localScale = Vector3.one * (1- outline);
			}
			
		}

	}
	// Use this for initialization
	void Start () {
		GenrateMap();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
