using UnityEngine;
using System.Collections;

public class trapDoorSwitch : MonoBehaviour {
	float rotationSpeed = 2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		//If i hit a specific key, open the trap door

		if (Input.GetKey (KeyCode.K)) {
			transform.Rotate (Vector3.forward * rotationSpeed);
		}

			if (Input.GetKey(KeyCode.L)){
			transform.Rotate (Vector3.back * rotationSpeed);
	}
}
}