using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayAgain : MonoBehaviour {


	public void playAgainyay(){

		SceneManager.LoadScene("MainGameScene");

	}

	public void Quit(){

		Application.Quit();

	}


}
