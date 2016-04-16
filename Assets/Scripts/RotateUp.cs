using UnityEngine;
using System.Collections;

public class RotateUp : MonoBehaviour {
    public float sensetivityY = 1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(-Input.GetAxis("Mouse Y") * Time.deltaTime * sensetivityY, 0, 0);
	}
}
