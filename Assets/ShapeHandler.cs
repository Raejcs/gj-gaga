using UnityEngine;
using System.Collections;

public class ShapeHandler : MonoBehaviour {

    public enum Shape
    {
        cube,
        sphere,
        triangle
    };

    public Shape currentShape;
    public Transform sphere;
    public Transform cube;
    public Transform triangle;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
