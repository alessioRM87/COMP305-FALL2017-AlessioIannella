using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab8CameraController : MonoBehaviour {

	public GameObject box;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			Debug.Log("Left click of mouse");

			Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

			Vector3 position = new Vector3(mousePos.x, mousePos.y, (float)11.90039);

			Debug.Log("Position x: " + mousePos.x + " y: " + mousePos.y);

			spawnatclick(position);

		}
	}

	private void spawnatclick(Vector3 position)
	{
		Instantiate(box, position, Quaternion.identity);

	}
}
