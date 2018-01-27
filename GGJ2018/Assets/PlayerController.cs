using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	//
	// instance variables
	//
	private GameObject obj;

	private float pickDistance = 25f;
	private float holdDistance = 18f;
	private float downDistance = 5f;

	// Use this for initialization
	void Start () {
		obj = null;
	}
	
	// Update is called once per frame
	void Update () {

		if (obj == null) { // player is not holding an object
				
			RaycastHit hit;
			if (Physics.Raycast (transform.position, transform.forward, out hit, pickDistance)) {
				if (Input.GetKeyDown ("x")) {
					obj = hit.collider.gameObject;

				}
			}

		} else { // player is currently holding an object
					
			// object remains in front of player
			obj.transform.position = transform.position + transform.forward * holdDistance + -1 * transform.up * downDistance;

			if (Input.GetKeyDown ("x")) {
				obj = null;

			}

		}

	}
}
