﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCamera : MonoBehaviour {


    int deg = 40;


    // Use this for initialization

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.RotateAround(Vector3.zero, Vector3.down, deg * Time.deltaTime);

    }
}
