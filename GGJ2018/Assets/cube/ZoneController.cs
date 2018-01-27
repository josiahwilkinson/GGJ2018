using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneController : MonoBehaviour {

	//
	// This script controlls the status of the 
	// zone it is attached to. 
	// A zone will only "activate" if the specific 
	// cube that it expects enters the zone


	// 
	// instance variables
	//
	private GameObject cube;
	private bool state = false;


	// Use this for initialization
	void Start () {

		// finds sibling called Cube_M
		cube = transform.parent.transform.Find("Cube_M").gameObject; 
		transform.parent = null;

	}

	void OnTriggerEnter(Collider other) {

		if (GameObject.ReferenceEquals( cube, other.gameObject)) {
			Debug.Log ("state: true");
			state = true;
		}


	}

	void OnTriggerExit(Collider other) {		

		if (GameObject.ReferenceEquals( cube, other.gameObject)) {
			Debug.Log ("state: false");
			state = false;
		}

	}

	public bool getState() {
		return state;
	}
		
}
