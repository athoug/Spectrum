using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour {

	public GameObject cube;
	public GameObject capsule;
	public int numberOfCubes;
	public int numberOfCapsules;
	public int min, max;
	public float delay = 0.1f;

	// Use this for initialization
	void Start () {
		Invoke ("PlaceCube", delay);
	}

	//function that generates the actual game object cube
	void PlaceCube ()
	{	
		// Randomly generate cubes
		for (int i = 0; i < numberOfCubes; i++){
			Instantiate (cube, GeneratePosition(), Quaternion.identity);
		}

		// Randomly generate capsules
		for (int i = 0; i < numberOfCapsules; i++){
			Instantiate (capsule, GenerateCapsulePosition(), Quaternion.identity);
		}
	}

	// Generate random positions for cube
	Vector3 GeneratePosition ()
	{
		int x, y, z;
		x = UnityEngine.Random.Range (min,max);
		y = UnityEngine.Random.Range (0,max);
		z = UnityEngine.Random.Range (min,max);
		return new Vector3(x,y,z);
	}


	// Generate random positions for cube
	public Vector3 GenerateCapsulePosition ()
	{
		int x, y, z;
		x = UnityEngine.Random.Range (min,max);
		y = UnityEngine.Random.Range (10,max);
		z = UnityEngine.Random.Range (min,max);
		return new Vector3(x,y,z);
	}
}
