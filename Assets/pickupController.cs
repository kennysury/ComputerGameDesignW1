﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupController : MonoBehaviour {

	public float rotateSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.eulerAngles += Vector3.forward * Time.deltaTime * rotateSpeed;
	}
}
