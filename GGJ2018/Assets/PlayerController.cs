﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	//
	// instance variables
	//
	private GameObject obj;

	private float pickDistance = 5f;
	private float holdDistance = 4f;
	private float downDistance = 2f;

	// Use this for initialization
	void Start () {
		obj = null;
	}
	
	// Update is called once per frame
	void Update () {

		if (obj == null) { // player is not holding an object
				
			RaycastHit hit;
			if (Physics.Raycast (transform.position, transform.forward, out hit, pickDistance)) {

				if (Input.GetKeyDown ("x") && hit.collider.gameObject.tag == "cube") {
					obj = hit.collider.gameObject;
					obj.GetComponent<Rigidbody> ().constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ; 
				}
			}

		} else { // player is currently holding an object
					
			// object remains in front of player
			obj.transform.position = transform.position + transform.forward * holdDistance + -1 * transform.up * downDistance;

			if (Input.GetKeyDown ("x")) {
				obj.GetComponent<Rigidbody> ().constraints = RigidbodyConstraints.None;
				obj = null;

			}

		}

	}
}
