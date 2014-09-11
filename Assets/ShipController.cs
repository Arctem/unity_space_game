using UnityEngine;
using System.Collections;

public class ShipController : MonoBehaviour {

	const float ACCEL_SCALAR = 5;
	const float ROTAT_SCALAR = 2;

	public Gun[] guns;

	private Rigidbody2D body;

	public float rotateThrottle {get; set;}
	public float accelThrottle {get; set;}
	public float strafeThrottle {get; set;}
	public bool stabilize {get; set;}

	// Use this for initialization
	void Start () {
		this.body = this.rigidbody2D;
		this.rotateThrottle = 0.0f;
		this.accelThrottle = 0.0f;
		this.strafeThrottle = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		this.body.AddTorque(-rotateThrottle * ROTAT_SCALAR);
		this.body.AddForce (this.transform.right * accelThrottle * ACCEL_SCALAR);
		this.body.AddForce (-this.transform.up * strafeThrottle * ACCEL_SCALAR);
		//print (this.body.velocity);

		if(this.stabilize)
			this.Stabilize();
	}

	private void Stabilize() {
		this.body.AddTorque(-this.body.angularVelocity / 15);
		this.body.AddForce(-this.body.velocity * 2);
	}
}
