using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3(Input.GetAxis ("Horizontal"), 0, 0);
	}

	void onCollisionEnter ()
	{
		Destroy (gameObject);
	}
}
