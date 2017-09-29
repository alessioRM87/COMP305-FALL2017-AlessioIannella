using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLab3ControllerBG2 : MonoBehaviour {

    public Transform backgroundSea;
    private SpriteRenderer sprite;
    private float width;
    private Camera camera;

    // Use this for initialization
    void Start()
    {
        camera = this.GetComponent<Camera>();
        sprite = backgroundSea.GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        camera.fieldOfView = 70;

        camera.transform.position = new Vector3(backgroundSea.position.x, backgroundSea.position.y, camera.transform.position.z);

    }
}
