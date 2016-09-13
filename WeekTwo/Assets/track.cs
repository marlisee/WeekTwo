using UnityEngine;
using System.Collections;

public class track : MonoBehaviour {

	public GameObject trackObj;

	// Use this for initialization

	
	// Update is called once per frame
	void Update () {

		float xPos = trackObj.transform.position.x; 
		transform.position = new Vector3 (xPos, transform.position.y, transform.position.z);
	}
}
