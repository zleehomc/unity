using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovment : MonoBehaviour {
    public float speed;
    public float angularSpeed = 30;
    private Rigidbody rd;
    public float number;
	// Use this for initialization
	void Start () {
        rd = this.GetComponent<Rigidbody>();	
	}
	// Update is called once per frame
	void FixedUpdate(){
        float v= Input.GetAxis("VerticalPlayer"+number);
        rd.velocity = transform.forward*v*speed;
        float h = Input.GetAxis("HorizontalPlayer"+number);
        rd.angularVelocity = transform.up * h * angularSpeed;
    }
}
