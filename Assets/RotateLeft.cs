﻿using UnityEngine;
using System.Collections;

public class RotateLeft : MonoBehaviour {
    public static float sensetivity = 1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, Input.GetAxis("Mouse X") * Time.deltaTime * sensetivity, 0);
        
	}
}
