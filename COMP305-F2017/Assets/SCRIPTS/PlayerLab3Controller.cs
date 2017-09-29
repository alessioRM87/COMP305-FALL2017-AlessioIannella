using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLab3Controller : MonoBehaviour {

    public float speed;
    private Rigidbody2D rBody;
    private Camera camera;

    // Use this for initialization
    void Start()
    {
        rBody = this.GetComponent<Rigidbody2D>();
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Use this for physics
    void FixedUpdate()
    {
        float horizMove = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(horizMove, 0, 0);
        rBody.velocity = movement * speed;

    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.name == "background_space")
        {
            Debug.Log("Detected collision with space");
            camera.GetComponent<CameraLab3ControllerBG1>().enabled = true;
            camera.GetComponent<CameraLab3ControllerBG2>().enabled = false;
            camera.GetComponent<CameraLab3ControllerBG3>().enabled = false;
        }
        else if (collider.name == "background_sea")
        {
            Debug.Log("Detected collision with sea");
            camera.GetComponent<CameraLab3ControllerBG1>().enabled = false;
            camera.GetComponent<CameraLab3ControllerBG2>().enabled = true;
            camera.GetComponent<CameraLab3ControllerBG3>().enabled = false;

        }
        else if (collider.name == "background_mountain")
        {
            Debug.Log("Detected collision with mountain");
            camera.GetComponent<CameraLab3ControllerBG1>().enabled = false;
            camera.GetComponent<CameraLab3ControllerBG2>().enabled = false;
            camera.GetComponent<CameraLab3ControllerBG3>().enabled = true;
        }

    }
}
