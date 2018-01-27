using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour {

	//
	// instance variables
	//
	GameObject[] zones;
	private bool isOpen = false;

	// Use this for initialization
	void Start () {
		zones = GameObject.FindGameObjectsWithTag ("zone");
	}

	bool zoneCheck() {
		
		foreach(GameObject zone in zones) {
			if ( !zone.GetComponent<ZoneController> ().getState () ) {
				return false;

			}
		}

		return true;
	}

	void doorOpens() {
		GetComponent<Animator> ().Play ("DoorOpen");
	}

	// Update is called once per frame
	void Update () {

		if ( !isOpen && zoneCheck () ) {
			doorOpens ();
			isOpen = true;
		}

	}
}
