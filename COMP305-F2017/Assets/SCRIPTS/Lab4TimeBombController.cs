using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab4TimeBombController : MonoBehaviour {

    public float timeout = 1.0f;
    public GameObject explosion;

    // Use this for initialization
    void Start()
    {
        Destroy(this.gameObject, timeout);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnDestroy()
    {
        Instantiate(explosion, this.transform.position, Quaternion.identity);
    }
}
