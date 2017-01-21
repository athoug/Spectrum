using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

public class CapsuleControl : MonoBehaviour {
	Generator gen;
	//public GameObject capsule;
	private GameObject[] getCount;
	public int countCube;
	public int maxCapsuleNumber;

	// Use this for initialization
	void Start () {
		gen = gameObject.GetComponent (typeof(Generator)) as Generator;
		//maxCapsuleNumber = gen.numberOfCapsules;
		maxCapsuleNumber = GameObject.Find ("Main Camera").GetComponent <Generator>().numberOfCapsules;
	}
	
	// Update is called once per frame
	void Update ()
	{
		cubeCounting ();

		if (countCube+1 < maxCapsuleNumber) {
			generateSingleCapsule();
		}
	}

	// #TODO later add the actual collistion that will destroy
	void OnMouseDown ()
	{
		Destroy (gameObject);
		countCube--;
	}

	void cubeCounting ()
	{
		getCount = GameObject.FindGameObjectsWithTag ("capsule");
		countCube = getCount.Length;
	}

	void generateSingleCapsule ()
	{	
		
		Instantiate(gameObject, GameObject.Find ("Main Camera").GetComponent <Generator>().GenerateCapsulePosition (), Quaternion.identity);
	}
}
