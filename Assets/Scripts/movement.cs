using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {
    public float speed = 10f;
    private float prevSpeed;
    private Vector3 velocity;
	// Use this for initialization
	void Start () {
        prevSpeed = speed;
	}
	
	// Update is called once per frame
	void Update () {
        velocity = transform.position;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = prevSpeed * 2;
        }
        else
        {
            speed = prevSpeed;
        }
        if (Input.GetKey(KeyCode.W))
        {
            //GetComponent<Rigidbody>().MovePosition(transform.position + transform.forward * Time.deltaTime * speed);
            velocity += transform.forward * Time.deltaTime * speed;
            //transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            velocity += -transform.forward * Time.deltaTime * speed;
            //GetComponent<Rigidbody>().MovePosition(transform.position + -transform.forward * Time.deltaTime * speed);
            //transform.Translate(-Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            velocity += -transform.right * Time.deltaTime * speed;
            //GetComponent<Rigidbody>().MovePosition(transform.position + -transform.right * Time.deltaTime * speed);
            //transform.Translate(-Vector3.right * Time.deltaTime * speed);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            velocity += transform.right * Time.deltaTime * speed;
            //GetComponent<Rigidbody>().MovePosition(transform.position + transform.right * Time.deltaTime * speed);
            //transform.Translate(Vector3.right * Time.deltaTime * speed);
        }


        GetComponent<Rigidbody>().MovePosition(velocity);

    }
}
