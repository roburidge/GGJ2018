using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerColliderDebug : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter (Collider other) {
		Debug.Log ("Object has entered the trigger");
	}
	
	// Update is called once per frame
	void OnTriggerStay (Collider other) {
		Debug.Log ("Object is inside the trigger");
	}

	void OnTriggerExit (Collider other) {
		Debug.Log ("Object has left the trigger");
	}
}
