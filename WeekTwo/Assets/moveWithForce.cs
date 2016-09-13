using UnityEngine;
using System.Collections;

public class moveWithForce : MonoBehaviour {
	public float acceleration = 10;
	Rigidbody thisRB;

	void Start () {

		thisRB = GetComponent<Rigidbody> ();

	}

	void Update () {

		Input.GetAxis ("Horizontal");
		thisRB.AddForce (Vector3.right * Input.GetAxis ("Horizontal") * acceleration);
		thisRB.AddForce (Vector3.up * Input.GetAxis ("Vertical") * acceleration);
		//GetComponent<Rigidbody> ().AddForce (Vector3.left * (Input.GetAxis ("Horizontal") * acceleration)); 

	}

}