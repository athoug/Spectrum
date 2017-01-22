using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.W) && Input.GetKeyDown(KeyCode.I) && Input.GetKeyDown(KeyCode.N))
		{

			SceneManager.LoadScene("WIN");


		}



	}

	void OnTriggerEnter (Collider col)
	{

		if(col.gameObject.tag == "Player"){

			SceneManager.LoadScene("END");
			
		}


	}

	public void DeathAwaits(){

		SceneManager.LoadScene("END");
	}
}
