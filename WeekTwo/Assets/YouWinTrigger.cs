using UnityEngine;
using System.Collections;

public class YouWinTrigger : MonoBehaviour {

	public GameObject Text;

	void OnTriggerEnter(Collider box) {

		if (box.gameObject.name == "Player") {
			Text.SetActive (true);
		}
	}

}
