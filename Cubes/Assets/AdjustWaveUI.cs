using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdjustWaveUI : MonoBehaviour {
	public Slider[] sliders = new Slider[6];
	public Wavelengths wave;
 	// Use this for initialization
	void Start () {
		wave = GameObject.FindObjectOfType<Wavelengths> ();
	}
	
	// Update is called once per frame
	void Update () {

		sliders[0].value = wave.violet;
		sliders[1].value = wave.blue;
		sliders[2].value = wave.green;
		sliders[3].value = wave.yellow;
		sliders[4].value = wave.orange;
		sliders[5].value = wave.red;
		
	}
}
