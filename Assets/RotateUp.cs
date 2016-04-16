using UnityEngine;
using System.Collections;

public class RotateUp : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(-Input.GetAxis("Mouse Y") * Time.deltaTime * RotateLeft.sensetivity, 0, 0);
	}
}
