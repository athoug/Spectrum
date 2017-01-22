using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MateralChange : MonoBehaviour {


	public Renderer rend ;
	Wavelengths plr;
	// Use this for initialization
	void Start () {
		 rend = GetComponent<Renderer>();
		 plr = FindObjectOfType<Wavelengths>();
	}
	
	// Update is called once per frame
	void Update () {

	if(Input.GetKeyDown(KeyCode.Z)){
			Debug.Log("pressed z");
			changeMaterial( Color.red);

	}
		
	}


	public void changeMaterial( Color32 colorValue){

		Debug.Log("changing colot to " + colorValue.ToString());

		rend.materials[1].color = colorValue;
		rend.materials[1].SetColor("_EmissionColor", colorValue);
        //rend.material.shader = Shader.Find("Specular");
        //rend.material.SetColor("_SpecColor", Color.green);

	}
}
