using UnityEngine;
using System.Collections;

public class ShipController : MonoBehaviour {

	const float ACCEL_SCALAR = 3;
	const float ROTAT_SCALAR = 2;

	float speed;
	float heading;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		float rotation = Input.GetAxis("Horizontal");
		float acceleration = Input.GetAxis("Vertical");

		rotation *= ROTAT_SCALAR;
		acceleration *= ACCEL_SCALAR;

		speed += acceleration;

		//this.transform.Rotate (0, 0, -rotation);
		this.rigidbody2D.AddTorque(-rotation);
		this.rigidbody2D.AddForce (this.transform.right * acceleration);
		//print (this.rigidbody2D.velocity);
	}
}
