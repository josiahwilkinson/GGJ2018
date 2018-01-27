using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorController : MonoBehaviour {

	//
	// This script mirrors the position of a cube across the x axis 
	// by controlling the position of a child cube.
	// 

	//
	// private instance variables
	//
	private bool debug  = false;
	private float speed = 3f;

	private GameObject mirrorObj;

	//private GameObject zoneObj;
	//private Vector3 initialZoneLocation;

	// Use this for initialization
	void Start () {
		mirrorObj = transform.Find ("Cube_M").gameObject;

	}
	
	// Update is called once per frame
	void Update () {

		mirrorObj.transform.position = new Vector3 (
			-1 * transform.position.x,
			transform.position.y,
			transform.position.z
		);
			
		if ( debug ) {

			if (Input.GetKey ("a")) {
				transform.position = new Vector3 (
					transform.position.x + speed,
					transform.position.y,
					transform.position.z
				);
			}
			if (Input.GetKey ("s")) {
				transform.position = new Vector3 (
					transform.position.x,
					transform.position.y,
					transform.position.z  + speed
				);
			}
			if (Input.GetKey ("d")) {
				transform.position = new Vector3 (
					transform.position.x - speed,
					transform.position.y,
					transform.position.z
				);
			}
			if (Input.GetKey ("w")) {
				transform.position = new Vector3 (
					transform.position.x,
					transform.position.y,
					transform.position.z - speed
				);
			}

		}
			
	}
}
