using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubes : MonoBehaviour {

	public float delay = 0.1f;
	public GameObject cube;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Spawn", delay, delay);
	}
	
	// Update is called once per frame
	void Spawn () {
		Instantiate (cube, new Vector3(UnityEngine.Random.Range(-6,6), 10, 0), Quaternion.identity);
	}
}
