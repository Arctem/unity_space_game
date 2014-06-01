using UnityEngine;
using System.Collections;

public class Asteroid : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.rigidbody2D.AddForce(new Vector3(Random.Range(-200.0f, 200.0f), Random.Range(-200.0f, 200.0f), Random.Range(-200.0f, 200.0f)));
		this.rigidbody2D.AddTorque(Random.Range(-500.0f, 500.0f));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
