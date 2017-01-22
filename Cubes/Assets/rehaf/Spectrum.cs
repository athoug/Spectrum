using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spectrum : MonoBehaviour {

	[SerializeField] Wavelengths SpectrumCheck;
	public enum colorStates {dark, Violet, blue, green, yellow, orange, red , win }
	//boolian values goes from dark to win wiith 0 is dark 
	public bool[] LockStates = new bool[7];

	colorStates mystate;

	public int lockedCounter;
	public int lockCheck;

	public MateralChange[] myprefabs;


	// color values


	public Color32 violet = new Color32(67, 13, 86, 255);
    public Color32 blue = new Color32(15, 51, 122, 255);
    public Color32 green = new Color32(11, 91, 30, 255);
    public Color32 yellow = new Color32(255, 232, 28, 255);
    public Color32 orange = new Color32(237, 118, 0, 255);
    public Color32 red = new Color32(168, 23, 23, 255);  
	public Color32 black = new Color32(0,0,0,0);

	// Use this for initialization
	void Awake()  {

		SpectrumCheck = GameObject.FindObjectOfType<Wavelengths>();
	}

	void Start(){
		myprefabs = GameObject.FindObjectsOfType<MateralChange>();

	}
	
	// Update is called once per frame
	void Update () {
		LockStates[0] = true; // it is always black in the background 


		checkColors(SpectrumCheck.violet, SpectrumCheck.violetMax , SpectrumCheck.violetMin , 1);
		checkColors(SpectrumCheck.blue, SpectrumCheck.blueMax , SpectrumCheck.blueMin , 2);
		checkColors(SpectrumCheck.green, SpectrumCheck.greenMax , SpectrumCheck.greenMin , 3);
		checkColors(SpectrumCheck.yellow, SpectrumCheck.yellowMax , SpectrumCheck.yellowMin , 4);
		checkColors(SpectrumCheck.orange, SpectrumCheck.orangeMax , SpectrumCheck.orangeMin , 5);
		checkColors(SpectrumCheck.red, SpectrumCheck.redMax , SpectrumCheck.redMin , 6);


		checkWin();
		if(mystate == colorStates.win){
		SceneManager.LoadScene("WIN");
		}
		Debug.Log(mystate);

		setStates(returnLocked());


		checkMyState();

		}//end of update 



		//this method sets the locked state for each color - refrence numbers above and sets it to less if it drops below the min color 
	public void checkColors( int colorValue, int max, int min,  int LockedIndex){

		if( colorValue <= max || colorValue >= min) {
				LockStates[LockedIndex] = true;
		}  if ( colorValue <  min){
				LockStates[LockedIndex] = false;
		}
		
	}//emd of colorCheck

	public void checkWin(){

		 lockedCounter = 0;

		for( int i = 0; i< LockStates.Length ;i ++){

			if(LockStates[i] == true)
				{lockedCounter++;}

		}//end fo foor loop

		if( lockedCounter == LockStates.Length){
				mystate = colorStates.win; }
		}



		//if bug change to one
	public int returnLocked(){
		lockCheck = 0;

		for( int i = 0; i< LockStates.Length ;i ++){

			if(LockStates[i] == true){

				lockCheck++;

		} 
			if( LockStates[i] == false){

				break;
			}

	}
	return lockCheck;


	}


	public void setStates(int value)
	{


		switch( value){
			case 1:
				mystate = colorStates.dark;
				break;
			case 2:
				mystate = colorStates.Violet;
				break;
			case 3:
				mystate = colorStates.blue;
				break;
			case 4:
				mystate = colorStates.green;
				break;
			case 5:
				mystate = colorStates.yellow;
				break;
			case 6:
				mystate = colorStates.orange;
				break;
			case 7:
				mystate = colorStates.red;
				break;
			case 8:
				mystate = colorStates.win;
				SceneManager.LoadScene("WIN");
				break;
			default:
				mystate = colorStates.dark;
				break;


	}
	}


	public void checkMyState(){

		if(mystate == colorStates.dark){
			foreach( MateralChange a in myprefabs){
				a.changeMaterial(black);

			}

		}
		if (mystate == colorStates.Violet){

			foreach( MateralChange a in myprefabs){
				a.changeMaterial(violet);

			}
			
		}
		if (mystate == colorStates.blue){


			foreach( MateralChange a in myprefabs){
				a.changeMaterial(blue);

			}
		}
		if (mystate == colorStates.green){

			foreach( MateralChange a in myprefabs){
				a.changeMaterial(green);

			}
		}
		if (mystate == colorStates.yellow){

			foreach( MateralChange a in myprefabs){
				a.changeMaterial(yellow);

			}
		}
		if (mystate == colorStates.orange){

			foreach( MateralChange a in myprefabs){
				a.changeMaterial(orange);

			}
		}
		if (mystate == colorStates.red){

			foreach( MateralChange a in myprefabs){
				a.changeMaterial(red);

			}
		}}


		public colorStates returnState(){

			return mystate;
		}



	



}


//old /* 
/*
switch( value){
			case 1:
				mystate = colorStates.Violet;
				break;
			case 2:
				mystate = colorStates.blue;
				break;
			case 3:
				mystate = colorStates.green;
				break;
			case 4:
				mystate = colorStates.yellow;
				break;
			case 5:
				mystate = colorStates.orange;
				break;
			case 6:
				mystate = colorStates.red;
				break;
			case 7:
				mystate = colorStates.win;
				break;
			default:
				mystate = colorStates.dark;
				break;


	}*/