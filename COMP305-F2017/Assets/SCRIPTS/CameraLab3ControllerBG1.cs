using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLab3ControllerBG1 : MonoBehaviour {

    public Transform player;
    private Transform camTrans;

    // Use this for initialization
    void Start()
    {
        camTrans = this.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        camTrans.position = new Vector3(player.position.x, player.position.y, camTrans.position.z);
    }
}
