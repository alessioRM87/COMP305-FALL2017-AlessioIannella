using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLab3ControllerBG3 : MonoBehaviour {

    public Transform player;
    public Transform backgroundMountain;
    private Camera camera;
    public float minZoom;
    public float maxZoom;
    public float zoomSensitivity;

    // Use this for initialization
    void Start()
    {
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        camera.transform.position = new Vector3(player.position.x, player.position.y, camera.transform.position.z);
        if (player.GetComponent<Rigidbody2D>().velocity.x > 0)
        {
            Debug.Log("Going right, zoom in");
            float fieldOfView = camera.fieldOfView;
            fieldOfView -= zoomSensitivity;
            camera.fieldOfView = Mathf.Clamp(fieldOfView, minZoom, maxZoom);
        }
        else if (player.GetComponent<Rigidbody2D>().velocity.x < 0)
        {
            Debug.Log("Going left, zoom out");
            float fieldOfView = camera.fieldOfView;
            fieldOfView += zoomSensitivity;
            camera.fieldOfView = Mathf.Clamp(fieldOfView, minZoom, maxZoom);
        }
    }
}
