﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CountDown : MonoBehaviour {

	public float timeLeft = 300.0f;
	public Text text;


	// Update is called once per frame
	void Update ()
	{
		
		if (timeLeft < 0) {
			// #TODO MAKE AN ACTUAL GAMEOVER PAGE
			text.text = "Game over";
		} else {
			timeLeft -= Time.deltaTime;
			text.text = "Time: " + Mathf.Round (timeLeft);
		}
	}
}
