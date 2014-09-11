using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour {

	private ShipController controller;

	// Use this for initialization
	void Start () {
		controller = this.GetComponent<ShipController>();
	}
	
	// Update is called once per frame
	void Update () {
		HandleInput();
	}

	void HandleInput() {
		this.controller.rotateThrottle = Input.GetAxis("Rotation");
		this.controller.accelThrottle = Input.GetAxis("Vertical");
		this.controller.strafeThrottle = Input.GetAxis("Horizontal");

		this.controller.stabilize = Input.GetButton("Stabilize");
	}
}
