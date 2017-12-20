using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab8PlayerController : MonoBehaviour {

	public float speed;
	private Rigidbody2D rBody;
	private Camera camera;

	// Use this for initialization
	void Start () {
		rBody = this.GetComponent<Rigidbody2D>();
		camera = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
		float horizMove = Input.GetAxis("Horizontal");
		float verticalMove = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3(horizMove, verticalMove, 0);
		rBody.velocity = movement * speed;
	}
}
