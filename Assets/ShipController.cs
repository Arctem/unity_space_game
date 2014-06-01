using UnityEngine;
using System.Collections;

public class ShipController : MonoBehaviour {

	const float ACCEL_SCALAR = 5;
	const float ROTAT_SCALAR = 2;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		HandleInput();
	}

	void HandleInput() {
		float rotation = Input.GetAxis("Rotation");
		float acceleration = Input.GetAxis("Vertical");
		float strafe = Input.GetAxis("Horizontal");

		rotation *= ROTAT_SCALAR;
		acceleration *= ACCEL_SCALAR;
		strafe *= ACCEL_SCALAR;

		this.rigidbody2D.AddTorque(-rotation);
		this.rigidbody2D.AddForce (this.transform.right * acceleration);
		this.rigidbody2D.AddForce (-this.transform.up * strafe);
		//print (this.rigidbody2D.velocity);

		if(Input.GetButton("Stabilize")) {
			Stabilize();
		}
	}

	void Stabilize() {
		this.rigidbody2D.AddTorque(-this.rigidbody2D.angularVelocity / 15);
		this.rigidbody2D.AddForce(-this.rigidbody2D.velocity * 2);
	}
}
