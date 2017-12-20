using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab7PlayerController : MonoBehaviour {

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
		

			
	}

	// Use this for physics
	void FixedUpdate()
	{
		float horizMove = Input.GetAxis("Horizontal");
		float verticalMove = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3(horizMove, verticalMove, 0);
		rBody.velocity = movement * speed;

	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.name.Contains ("fog")) 
		{
			Destroy (collider.gameObject);
		}

	}
}
