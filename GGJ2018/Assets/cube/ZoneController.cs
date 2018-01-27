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
	private GameObject light;
	private GameObject particleSystem; 


	// Use this for initialization
	void Start () {

		// finds sibling called Cube_M
		cube = transform.parent.transform.Find("Cube_M").gameObject; 
		transform.parent = null;
		light = transform.Find ("Spotlight").gameObject;
		//particleSystem
	}

	void OnTriggerEnter(Collider other) {

		if (GameObject.ReferenceEquals( cube, other.gameObject)) {			
			state = true;
			light.SetActive (state);

		}


	}

	void OnTriggerExit(Collider other) {		

		if (GameObject.ReferenceEquals( cube, other.gameObject)) {						
			state = false;
			light.SetActive (state);
		}

	}

	public bool getState() {
		return state;
	}
		
}
