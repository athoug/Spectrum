﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour {
public float speed;
	public void Update(){

	transform.Rotate(Vector3.up * Time.deltaTime * speed, Space.World);
}}
