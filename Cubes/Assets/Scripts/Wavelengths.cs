using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Security.Policy;
using System;

public class Wavelengths : MonoBehaviour {

	public GameObject sphereCollection;
	int OneCOUNT;
	// Wave lengths max and min ranges
	public int violetMax = 450;
	public int violetMin = 380;
	public int blueMax = 495;
	public int blueMin = 450;
	public int greenMax = 570;
	public int greenMin = 495;
	public int yellowMax = 590;
	public int yellowMin = 570;
	public int orangeMax = 620;
	public int orangeMin = 590;
	public int redMax = 740;
	public int redMin = 620;

	// counter waveLengths
	public int violet = 0;
	public int blue = 0;
	public int green = 0;
	public int yellow = 0;
	public int orange = 0;
	public int red = 0;

	// wavelength timers
	float constantTime = 5.0f;
	public float violetTimer = 0;
	public float blueTimer = 0;
	public float greenTimer = 0;
	public float yellowTimer = 0;
	public float orangeTimer = 0;
	public float redTimer = 0;

	// desawpon collectable again #TODO make sure to adjust min and max acording to game plain
	public int minx, maxx, minY, maxY;


	public Spectrum mySpec;
		AudioSource ad;
		AudioClip d;

	// Use this for initialization
	void Start () {
		violetTimer = constantTime;
		blueTimer = constantTime;
		greenTimer = constantTime;
		yellowTimer = constantTime;
		orangeTimer = constantTime;
		redTimer = constantTime;

		minx = -11;
		maxx = 10;
		minY = -12;
		maxY = 100;
		mySpec = FindObjectOfType<Spectrum>();

		ad = GetComponent<AudioSource>();  
		d = GetComponent<AudioClip>(); 

	}
	
	// Update is called once per frame
	void Update () {

		decreaseWaveLengthWithTime ();

	}


	void OnTriggerEnter (Collider col)
	{

		
		if (col.gameObject.CompareTag ("StART")) {

			//col.gameObject.SetActive(false);
			sphereCollection.SetActive(true);
			col.gameObject.transform.position = GenerateCapsulePosition ();
			if(mySpec.returnState() == Spectrum.colorStates.dark){
				if(OneCOUNT ==0){

					violet += 600; //first one onmly
				}
				else {violet += 300;}
			}
			if(mySpec.returnState() == Spectrum.colorStates.Violet){
				blue += 300;
			}
			if(mySpec.returnState() == Spectrum.colorStates.blue){
				green += 300;
			}
			if(mySpec.returnState() == Spectrum.colorStates.green){
				yellow += 300;
			}
			if(mySpec.returnState() == Spectrum.colorStates.yellow){
				orange += 300;
			}
			if(mySpec.returnState() == Spectrum.colorStates.orange){
				red += 300;
			}

			Debug.Log("VIOLET IS " + violet);
			ad.PlayOneShot(d);
		}


		if (col.gameObject.CompareTag ("violet")) {

			//col.gameObject.SetActive(false);
		
			col.gameObject.transform.position = GenerateCapsulePosition ();
			violet += 150;
			Debug.Log("VIOLET IS " + violet);
		}

		if (col.gameObject.CompareTag ("blue")) {
			//col.gameObject.SetActive(false);
			col.gameObject.transform.position = GenerateCapsulePosition ();
			blue += 150;
			Debug.Log("bLUE IS " + blue);

		}

		if (col.gameObject.CompareTag ("green")) {
			//col.gameObject.SetActive(false);
			col.gameObject.transform.position = GenerateCapsulePosition ();
			green += 150;
		}

		if (col.gameObject.CompareTag ("yellow")) {
			//col.gameObject.SetActive(false);
			col.gameObject.transform.position = GenerateCapsulePosition ();
			yellow += 150;
		}

		if (col.gameObject.CompareTag ("orange")) {
			//col.gameObject.SetActive(false);
			col.gameObject.transform.position = GenerateCapsulePosition ();
			orange += 150;
		}

		if (col.gameObject.CompareTag ("red")) {
			//col.gameObject.SetActive(false);
			col.gameObject.transform.position = GenerateCapsulePosition ();
			red += 150;
		}
	}


	void decreaseWaveLengthWithTime ()
	{
		
		if (mySpec.returnLocked() >= 1 && violet > 0) {
			violetTimer  -=Time.deltaTime;
			if(violetTimer < 0){
				violet -= 10;
				violetTimer = constantTime;
				Debug.Log("Time is " + violetTimer);
				Debug.Log("violet is " + violet);


			} 	
		}

		if (mySpec.returnLocked() >= 2 && blue > 0) {
			blueTimer  -=Time.deltaTime;
			if(blueTimer < 0){
				blue -= 10;
				blueTimer = constantTime;
				Debug.Log("Time is " + blueTimer);
				Debug.Log("violet is " + blue);


			} 	
		}

		if (mySpec.returnLocked() >= 3 && green > 0)  {
			greenTimer  -=Time.deltaTime;
			if(greenTimer < 0){
				green -= 10;
				greenTimer = constantTime;
				Debug.Log("Time is " + greenTimer);
			} 	
		}

		if  (mySpec.returnState() == Spectrum.colorStates.yellow && yellow >= 0)  {
			yellowTimer  -=Time.deltaTime;

			if(yellowTimer < 0){
				yellow -= 10;
				yellowTimer = constantTime;
				Debug.Log("Time is " + yellowTimer);
			} 	
		}

		if  (mySpec.returnState() == Spectrum.colorStates.orange && orange >= 0) {
			orangeTimer  -=Time.deltaTime;

			if(orangeTimer < 0){
				orange -= 10;
				orangeTimer = constantTime;
				Debug.Log("Time is " +  orangeTimer);
			} 	
		}

		if  (mySpec.returnState() == Spectrum.colorStates.red && red >= 0) {
			redTimer  -=Time.deltaTime;

			if(redTimer < 0){
				red -= 10;
				redTimer = constantTime;
				Debug.Log("Time is " + redTimer);
			} 	
		}

	}


	public Vector3 GenerateCapsulePosition ()
	{
		int x, y, z;
		x = UnityEngine.Random.Range (minx,maxx);
		y = UnityEngine.Random.Range (3,17); //hight up to highest platform
		z = UnityEngine.Random.Range (minY,maxY);
		return new Vector3(x,y,z);
	}


}


