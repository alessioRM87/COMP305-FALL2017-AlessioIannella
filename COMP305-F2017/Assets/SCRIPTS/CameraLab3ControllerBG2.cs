using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLab3ControllerBG2 : MonoBehaviour {

    public Transform backgroundSea;
    private Camera camera;

    // Use this for initialization
    void Start()
    {
        camera = this.GetComponent<Camera>();

    }

    // Update is called once per frame
    void Update()
    {
        camera.transform.position = new Vector3(backgroundSea.position.x, backgroundSea.position.y, camera.transform.position.z);

    }
}
