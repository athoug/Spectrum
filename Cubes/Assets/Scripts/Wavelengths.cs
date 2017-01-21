using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Security.Policy;

public class Wavelengths : MonoBehaviour {

	// Wave lengths max and min ranges
	public const int violetMax = 450;
	public const int violetMin = 380;
	public const int blueMax = 495;
	public const int blueMin = 450;
	public const int greenMax = 570;
	public const int greenMin = 495;
	public const int yellowMax = 590;
	public const int yellowMin = 570;
	public const int orangeMax = 620;
	public const int orangeMin = 590;
	public const int redMax = 740;
	public const int redMin = 620;

	// counter waveLengths
	public int violet = 0;
	public int blue = 0;
	public int green = 0;
	public int yellow = 0;
	public int orange = 0;
	public int red = 0;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.CompareTag ("violet")) {
			violet += 50;
		}

		if (col.gameObject.CompareTag ("blue")) {
			blue += 50;
		}

		if (col.gameObject.CompareTag ("green")) {
			green += 50;
		}

		if (col.gameObject.CompareTag ("yellow")) {
			yellow += 50;
		}

		if (col.gameObject.CompareTag ("orange")) {
			orange += 50;
		}

		if (col.gameObject.CompareTag ("red")) {
			red += 50;
		}
	}

	void onMouseClick() {
		if(Input.GetMouseButtonDown(0)){

			if (gameObject.CompareTag ("violet")) {
			violet += 50;
			}

			if (gameObject.CompareTag ("blue")) {
			blue += 50;
			}

			if (gameObject.CompareTag ("green")) {
				green += 50;
			}

		}

	}
}
